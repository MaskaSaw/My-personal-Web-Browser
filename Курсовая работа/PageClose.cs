using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class MainWindow : Form
    {
        private void buttonClosePage(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i--;
            }
            else
                Application.Exit();
        }

        private void doubleClickToClosePage(object sender, EventArgs e)
        {
            buttonClosePage(sender, e);
        }
    }
}