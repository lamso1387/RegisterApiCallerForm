﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RegisterApiCallerForm
{
    class Publics
    {
       
        public static HttpClient client = new HttpClient();
        public static string apiKey;
        public static string uri;
        public static string errorSMS;
        public static bool stopLoop = false;

        static Dictionary<string, object> input;
        static Loading loading;

        public static void StartSending(SemnanEntities3 db, List<Anbar> DBitems, string from, Button btnSearch)
        {
            Publics.stopLoop = false;
            loading = new Loading();
            loading.Show();
            int i = 0;
            int notRegistered = 0;
            int all = DBitems.Count;
            Stopwatch apiTimer;
            TimeSpan apiTimeTaken = new TimeSpan(0, 0, 0);
            Stopwatch appTimer;
            loading.Text = from;
            loading.lblSrart.Text = DateTime.Now.ToString();
            foreach (Anbar DBitem in DBitems)
            {
                Application.DoEvents();
                apiTimer = new Stopwatch();
                appTimer = new Stopwatch();
                appTimer.Start();
                if (Publics.stopLoop) { loading.Text += "-stopped"; break; }
                i++;
                loading.lblLoading.Text = "در حال ارسال " + i + " از " + all;

                if (string.IsNullOrWhiteSpace(DBitem.user_id))

                    try
                    {
                        notRegistered++;
                        RegisterAnbarDB(db, DBitem, apiTimer);
                        apiTimeTaken = apiTimer.Elapsed;
                        loading.lblTime.Text = apiTimeTaken.ToString();
                    }
                    catch (Exception error)
                    {
                        DBitem.error = error.Message;
                        db.SaveChanges();

                    }
                appTimer.Stop();

            }
            loading.lblLoading.Text = " تعداد  " + i + " رکورد از " + all + " رکورد بررسی شد " + "\n" +
            " ارسال " + notRegistered + " از " + i + " مورد برای ثبت نام انجام شد   " + "\n" +
            "تعداد " + (notRegistered - DBitems.AsQueryable().Take(i).Where(x => x.user_id == null || x.user_id == string.Empty || x.user_id == "").ToList().Count) + "ثبت نام جدید انجام شد";
            loading.lblEnd.Text = DateTime.Now.ToString();
            loading.Text += "-done";
            loading.btnClose.Enabled = true;
            btnSearch.PerformClick();
        }

        public static void RegisterAnbarDB(SemnanEntities3 db, Anbar DBitem, Stopwatch timer)
        {

            input = new Dictionary<string, object>();
            input = CreateInputFromDB(input, DBitem);
            timer.Start();
            var result = SendAnbar(input);
            timer.Stop();
            InsertIntoDB(db, result, DBitem);
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

        private static void InsertIntoDB(SemnanEntities3 db, string result, Anbar DBitem)
        {


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

        public static void GetRows(DataGridView dgv, TextBox tbFrom,TextBox tbTo, SemnanEntities3 db)
        {
            if (dgv.SelectedRows.Count < 1) return;
            long id = (long)dgv.SelectedRows[0].Cells["ID"].Value;
            tbFrom.Text = (db.Anbars.ToList().IndexOf(db.Anbars.Where(x => x.ID == id).First()) + 1).ToString();
            tbTo.Text = dgv.SelectedRows.Count.ToString();
        }
        public static bool IsJson(string input)
        {
            input = input.Trim();
            return input.StartsWith("{") && input.EndsWith("}")
                   || input.StartsWith("[") && input.EndsWith("]");
        }
        public class DataReport
        {
            public string tag { get; set; }
            public string explain { get; set; }
            public int index { get; set; }
            public int count { get; set; }
            public int sent { get; set; }
            public int registered { get; set; }
            public int error { get; set; }
        }
        public static void ButtonLoading(Action<object, EventArgs> method)
        {
            loading = new Loading();
            loading.Show();
            loading.lblTime.Text = "";
            loading.lblLoading.Text = "در حال اعمال اطلاعات...";
            method(null, null);
            loading.Close();
        }
        public static class AnbarStatus
        {

            public static IQueryable<Anbar>  AnbarsSent(SemnanEntities3 db){

             return   db.Anbars.Where(x => (x.api_key != null && x.api_key != string.Empty && x.api_key != ""));
            }

            public static IQueryable<Anbar>  AnbarsNotSent(SemnanEntities3 db){

                return db.Anbars.Where(x => (x.api_key == null || x.api_key == string.Empty || x.api_key == ""));
            }

            public static IQueryable<Anbar> AnbarsSentNotRegistered(SemnanEntities3 db)
            {

                return db.Anbars.Where(x => (x.api_key != null && x.api_key != string.Empty && x.api_key != ""))
                    .Where(x => (x.user_id == null || x.user_id == string.Empty || x.user_id == ""));
            }

            public static IQueryable<Anbar> AnbarsRegistered(SemnanEntities3 db)
            {

                return db.Anbars.Where(x => (x.user_id != null && x.user_id != string.Empty && x.user_id != ""));
            }

            public static IQueryable<Anbar> AnbarsNotRegistered(SemnanEntities3 db)
            {

                return db.Anbars.Where(x => (x.user_id == null || x.user_id == string.Empty || x.user_id == ""));
            }
            
            public static IQueryable<Anbar> AnbarsSentNotRegisteredOrError(SemnanEntities3 db)
            {

                return AnbarsSentNotRegistered(db).Union(AnbarsWithError(db));

            }

            public static IQueryable<Anbar> AnbarsWithError(SemnanEntities3 db)
            {
                return db.Anbars.Where(x => x.error != null);
            }
            
            
        }
        public static void MakeChart(Chart chart,string xValue, string yValue, IQueryable<object> query)
        {
            string chartName="name";
            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(chartName);
            chart.Series.Clear();
            chart.Series.Add(chartName);
            chart.Series[chartName].XValueMember = xValue;
            chart.Series[chartName].YValueMembers = yValue;

            chart.Series[chartName].IsValueShownAsLabel = true;

            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;

            chart.ChartAreas[0].AxisX.Interval = 1;

            chart.DataSource = query.ToList();
            chart.DataBind();
        }

    }
}
