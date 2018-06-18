using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class MainWindow : Form
    {
        private void buttonNavigateToHomePage(object sender, EventArgs e)
        {
            if (tabControl1.TabCount == 0)
            {
                buttonCreatePage(sender, e);
            }
            else
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("google.com");
            }
        }
    }
}