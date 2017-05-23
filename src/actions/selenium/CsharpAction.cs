using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace actions.selenium{
    class CsharpAction{
        
                            private void tarayici_Ac()
{
 System.Diagnostics.Process.Start("http://google.com.tr/");
}

        
        public void run(Dictionary<string, object> Params){
          
tarayici_Ac();
           
        }

    }
}