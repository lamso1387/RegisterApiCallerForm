using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterApiCallerForm
{
    class Test
    {
        static int i;
        static int all;
        static int notRegistered;

        public static void ParallelSend(SemnanEntities3 db, List<Anbar> DBitems, string from, Button btnSearch, string parallel)
        {

            Loading loading = new Loading();
            loading.Show();
            loading.lblSrart.Text = DateTime.Now.ToString();
            TruncateTimeTable(db);
            i = 0;
            all = DBitems.Count;
            notRegistered = 0;
            Publics.stopLoop = false;
            List<Task> task_list = new List<Task>();
            int per_count = int.Parse(parallel);
            int take = all / per_count;
            int skip = 0;
            var DBquery = DBitems.AsQueryable();
            for (int j = 0; j < per_count; j++)
            {
                Application.DoEvents();
                var query = DBquery.Skip(skip).Take(take);
                skip += take;
                Task task = new Task(() => StartSending(db,query.ToList(),loading));
                task_list.Add(task);
                task.Start();           
                
            }
            Task.WaitAll(task_list.ToArray());

            loading.lblLoading.Text = " تعداد  " + i + " رکورد از " + all + " رکورد بررسی شد " + "\n" +
            " ارسال " + notRegistered + " از " + i + " مورد برای ثبت نام انجام شد   " + "\n" +
            "تعداد " + (notRegistered - DBquery.Take(i).Where(x => x.user_id == null || x.user_id == string.Empty || x.user_id == "").ToList().Count) + "ثبت نام جدید انجام شد";
            loading.lblEnd.Text = DateTime.Now.ToString();
            loading.Text = from+"-done";
            loading.btnClose.Enabled = true;
            loading.lblTime.Text = db.TimeTakens.Select(x => x.time_taken).Average().ToString();
            btnSearch.PerformClick();
            
        }

        private static void TruncateTimeTable(SemnanEntities3 db)
        {
            db.Database.ExecuteSqlCommand("truncate table TimeTaken");
            db.SaveChanges();
        }

        public static void StartSending(SemnanEntities3 db, List<Anbar> DBitems, Loading loading)
        {
            int all_per = DBitems.Count;
            Stopwatch apiTimer;
            foreach (Anbar DBitem in DBitems)
            {
                Application.DoEvents();
                apiTimer = new Stopwatch();
                if (Publics.stopLoop)  break; 
                i++;

                if (string.IsNullOrWhiteSpace(DBitem.user_id))

                    try
                    {
                        notRegistered++;
                        RegisterAnbarDB(db, DBitem, apiTimer);                      
                    }
                    catch (Exception error)
                    {
                        DBitem.error = error.Message;
                        db.SaveChanges();
                    }
               
            }
        }

        public static void RegisterAnbarDB(SemnanEntities3 db, Anbar DBitem, Stopwatch timer)
        {

           Dictionary<string, object> input = new Dictionary<string, object>();
            input = CreateInputFromDB(input, DBitem);
            timer.Start();
            var result = SendAnbar(input);
            timer.Stop();
            InsertIntoDB(db, result, DBitem, timer.Elapsed.TotalSeconds);
        }

        private static Dictionary<string, object> CreateInputFromDB(Dictionary<string, object> input, Anbar DBitem)
        {
            if (!string.IsNullOrWhiteSpace(DBitem.national_id)) input.Add("national_id", DBitem.national_id);
            if (!string.IsNullOrWhiteSpace(DBitem.mobile)) input.Add("mobile", DBitem.mobile);
            if (!string.IsNullOrWhiteSpace(DBitem.name)) input.Add("name", DBitem.name);
            if (!string.IsNullOrWhiteSpace(DBitem.postal_code)) input.Add("postal_code", DBitem.postal_code);
            input.Add("contractor_or_agent", DBitem.contractor_or_agent);
            if (!string.IsNullOrWhiteSpace(DBitem.type)) input.Add("type", DBitem.type);
            if (!string.IsNullOrWhiteSpace(DBitem.co_national_id)) input.Add("co_national_id", DBitem.co_national_id);

            if (!string.IsNullOrWhiteSpace(DBitem.activity_sector)) input.Add("activity_sector", DBitem.activity_sector.Split(';').Select(n => n).ToList());


            if (!string.IsNullOrWhiteSpace(DBitem.province_input)) input.Add("province", DBitem.province_input);
            if (!string.IsNullOrWhiteSpace(DBitem.city_input)) input.Add("city", DBitem.city_input);

            if (!string.IsNullOrWhiteSpace(Publics.errorSMS)) input.Add("on_error_data_send_sms_to_user", Boolean.Parse(Publics.errorSMS));
            input.Add("auto_fill_user_data", true);

            return input;
        }


        public static string SendAnbar(object anbar)
        {
            HttpResponseMessage response = Publics.client.PostAsJsonAsync(Publics.apiKey + Publics.uri, anbar).Result;
            return response.Content.ReadAsStringAsync().Result;
        }

        private static void InsertIntoDB(SemnanEntities3 db, string result, Anbar DBitem, double time_taked)
        {

            db.TimeTakens.Add(new TimeTaken() { time_taken = time_taked });

            DBitem.output_result = System.Text.RegularExpressions.Regex.Unescape(result);

            if (string.IsNullOrWhiteSpace(result)) DBitem.error = "soheil writes: result is empty from server";
            else if (!Publics.IsJson(result)) DBitem.error = "soheil writes: result is not json";
            else
            {
                Anbar resultAnbar = JsonConvert.DeserializeObject<Anbar>(result);
                DBitem.province = resultAnbar.province;
                DBitem.city = resultAnbar.city;
                DBitem.user_id = resultAnbar.user_id;
                DBitem.user_first_name = resultAnbar.user_first_name;
                DBitem.full_address = resultAnbar.full_address;
                DBitem.warehouse_id = resultAnbar.warehouse_id;
                DBitem.user_last_name = resultAnbar.user_last_name;
                DBitem.company_name = resultAnbar.company_name;
                DBitem.last_sent = DateTime.Now;
                DBitem.api_key = Publics.apiKey;
                DBitem.error = string.Empty;
            }
            db.SaveChanges();
        }

    }
}
