using Microsoft.Win32;

namespace LabLockWinForms
{
    public static class RegistryManager
    {
        public static string AdminPass = "pass";
        public static string StartPage = "http://google.com";
        public static string StopPage = "http://yahoo.com";

        public static void ReadValues()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("LabLock");
            object pass, start, stop;

            if ((pass = key.GetValue("AdminPass")) != null)
            {
                AdminPass = (string)pass;
            }
            if ((start = key.GetValue("StartPage")) != null)
            {
                StartPage = (string)start;
            }
            if ((stop = key.GetValue("StopPage")) != null)
            {
                StopPage = (string)stop;
            }

            key.Close();
        }

        public static void WriteValues()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey("LabLock");

            key.SetValue("AdminPass", AdminPass);
            key.SetValue("StartPage", StartPage);
            key.SetValue("StopPage", StopPage);

            key.Close();
        }
    }
}
