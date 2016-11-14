using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestProfiler
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TenSecondDelay();
        }

        private void TenSecondDelay()
        {
            System.Threading.Thread.Sleep(10 * 1000);
        }
    }
}