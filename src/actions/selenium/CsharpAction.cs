using System;
using System.Collections.Generic;

namespace actions.selenium{
    class CsharpAction{
        public void run(Dictionary<string, object> Params){
            
        }
        
        private void OpenWebPage()
{
            string key = @"http\shell\open\command";
            RegistryKey registryKey =
            Registry.ClassesRoot.OpenSubKey(key, false);
            // Varsayılan tarayıcının yolunu al.
            // Aldığımız değer salt olarak programın
            // yolu olmadığı için biraz işlememiz gerekiyor.
            string defaultbrowserpath =
            ((string)registryKey.GetValue(null, null)).Split('"')[1];
            //Process.Start ile başlat
            Process.Start(defaultbrowserpath, "http://www.google.com");
}
    }
}