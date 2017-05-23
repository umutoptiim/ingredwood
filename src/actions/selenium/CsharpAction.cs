using System;
using System.Collections.Generic;

namespace actions.selenium{
    class CsharpAction{
        public void run(Dictionary<string, object> Params){
            
        }
        
        private void OpenWebPage()
{
            string key = @"http\shell\open\command";
	Microsoft.Win32.RegistryKey registryKey = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(key, false);
	string defaultbrowserpath = ((string)registryKey.GetValue(null, null)).Split('"')[1];
	System.Diagnostics.Process.Start(defaultbrowserpath, "http://www.yazilimindunyasi.com");
	
}
    }
}