using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class MainWindow : Form
    {
        private void buttonPageNavigate(object sender, EventArgs e)
        {
            if (AddressBar.Text != null)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(AddressBar.Text);
            }
        }

        private void keyPressToPageNavigate(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (tabControl1.TabCount == 0)
                {
                    buttonCreatePage(sender, e);
                }

                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(AddressBar.Text);
            }
        }

        private void buttonNavigateToExplorer_D(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("D:/");
        }

        private void buttonNavigateToExplorer_C(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("C:/");
        }
    }
}