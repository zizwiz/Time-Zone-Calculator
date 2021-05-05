using System;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeZones
{
    public partial class Form1 : Form
    {
        ReadOnlyCollection<TimeZoneInfo> zones = TimeZoneInfo.GetSystemTimeZones();
        TimeZone curTimeZone = TimeZone.CurrentTimeZone;
        private bool flag = true;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_version.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;

            rchtxtbx_time_zones.AppendText("Number of time zones = " + zones.Count + "\r\r");

            //Get non daylight saving timezones
            rchtxtbx_no_daylight_saving.AppendText("The TimeZones that do not support the DayLightSavingTime :\r\r");
            foreach (TimeZoneInfo zone in zones)
            {
                if (!zone.SupportsDaylightSavingTime)
                    rchtxtbx_no_daylight_saving.AppendText("\r" + zone.DisplayName);
            }


            foreach (TimeZoneInfo zone in TimeZoneInfo.GetSystemTimeZones())
            {
                cmbobx_tzones.Items.Add(zone.Id);

                int zoneLen = zone.DisplayName.IndexOf(")");
                string timeZone = zone.DisplayName.Substring(0, zoneLen + 1);// add to combo window
                rchtxtbx_time_zones.AppendText(timeZone + " " + zone.Id + "\r"); //Add to time Zone box
            }

            cmbobx_tzones.SelectedIndex = 0;

            WorkOutTime();

            Task task = new Task(() =>
            {
                while (flag)
                {
                    WorkOutTime();
                    Thread.Sleep(1000);
                }
            });
            task.Start();

            InitializeControlValues();
            lbl_other_tz.Text = cmbobx_tzones.Text;
        }

        private void btn_local_tz_Click(object sender, EventArgs e)
        {
            WorkOutTime();
        }

        private void WorkOutTime()
        {
            Invoke(new Action(() =>
            {
                // Get DaylightTime object  
                System.Globalization.DaylightTime dl = curTimeZone.GetDaylightChanges(DateTime.Now.Year);

                // What is GMT (also called Coordinated Universal Time (UTC)  
                DateTime curUTC = curTimeZone.ToUniversalTime(DateTime.Now);

                // What is GMT/UTC offset ?  
                TimeSpan currentOffset = curTimeZone.GetUtcOffset(DateTime.Now);

                //----------------------------------------------------------------

                lbl_local_tz.Text = TimeZoneInfo.Local.DisplayName;

                // Difference between standard time and the daylight-saving time.  
                TimeZoneInfo localZone = TimeZoneInfo.Local;
                string answer = (localZone.BaseUtcOffset >= TimeSpan.Zero) ? "later" : "earlier";
                lbl_time_info.Text = "Local time now is " + dl.Delta + " (hh:mm:ss) " + answer + " than UTC.";

                lbl_UTC.Text = curUTC.ToString();
                lbl_local_time.Text = DateTime.Now.ToString();
                lbl_utc_offset.Text = currentOffset.ToString();

                lbl_DST_setting.Text = curTimeZone.IsDaylightSavingTime(DateTime.Now) ? "On" : "Off";
                lbl_dst_start.Text = dl.Start.ToString();
                lbl_dst_ends.Text = dl.End.ToString();

                lbl_timezone_name.Text = curTimeZone.StandardName;
                lbl_daylight_name.Text = curTimeZone.DaylightName;

                //---------------------------------------------------------------------------

                DateTime timeUtc = curTimeZone.ToUniversalTime(DateTime.Now);
                var dt = DateTime.SpecifyKind(timeUtc, DateTimeKind.Utc);
                //TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                TimeZoneInfo tZone = TimeZoneInfo.FindSystemTimeZoneById(cmbobx_tzones.SelectedItem.ToString());
                DateTime TheTime = TimeZoneInfo.ConvertTimeFromUtc(dt, tZone);

                lbl_time_in_tz.Text = TheTime.ToString();
            }));
        }

        private void cmbobx_tzones_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_other_tz.Text = cmbobx_tzones.Text;
            WorkOutTime();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            flag = false;
            Thread.Sleep(50);
            SaveSettings();
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            flag = false;
            SaveSettings();
            Thread.Sleep(50);
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            TimeSpan diff = TimeSpan.Zero;

            DateTime dt = dtpick_set_date_time_1.Value.Date + dtpick_set_date_time_2.Value.TimeOfDay;

            DateTime localdt = DateTime.Parse(lbl_local_time.Text);
            DateTime Otherdt = DateTime.Parse(lbl_time_in_tz.Text);

            if (rdobtn_to_local.Checked)
            {
                //To local time
               diff = Otherdt.Subtract(localdt);
               lbl_result_time.Text = dt.Subtract(diff).ToString();

            }
            else
            {
                // From local time
                diff = localdt.Subtract(Otherdt);
                lbl_result_time.Text = dt.Subtract(diff).ToString();
            }

        }
    }
}
