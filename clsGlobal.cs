using Buisness;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using Buisness;
using System.Security.Cryptography;


namespace DVLD
{
    internal static class clsGlobal
    {
      


        public static clsUsers CurrentUser;

        public static bool RememberUsernameAndPasswordUsingWindowsRegistry(string Username, string Password)
        {

            try
            {
                string KeyPath = @"SOFTWARE\DVDL";

                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey Subkey = BaseKey.CreateSubKey(KeyPath, true))
                    {
                        if (Subkey != null)
                            Subkey.SetValue("Username", Username, RegistryValueKind.String);
                            Subkey.SetValue("Password", Password, RegistryValueKind.String);


                            return true;

                       



                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public static bool GetStoredCredentialUsingWindowsRegistry(ref string Username, ref string Password)
        {
            try
            {
                string KeyPath = @"SOFTWARE\DVDL";

                using (RegistryKey BaseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using (RegistryKey Subkey = BaseKey.OpenSubKey(KeyPath))
                    {
                        Username = Subkey.GetValue("Username", null) as string;
                        Password = Subkey.GetValue("Password", null) as string;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
        }
      
        

       
    }
}
