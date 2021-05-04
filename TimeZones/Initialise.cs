using TimeZones.Properties;

namespace TimeZones
{
    public partial class Form1
    {
        private Settings settings = Settings.Default;

        private void InitializeControlValues()
        {
           cmbobx_tzones.Text = settings.TimeZone;
        }

        private void SaveSettings()
        {
            settings.TimeZone = cmbobx_tzones.Text;
            settings.Save();
        }


    }
}
