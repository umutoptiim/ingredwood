using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace actions.selenium{
    class CsharpAction{
        
                            private void tarayıcı_Ac()
{
 System.Diagnostics.Process.Start("http://google.com.tr/");
}

        
        public void run(Dictionary<string, object> Params){
          
tarayıcı_Ac();
           
        }

    }
}