using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class MainWindow : Form
    {
        private void buttonCreatePage(object sender, EventArgs e)
        {
            web = new WebBrowser()
            {
                Visible = true,
                ScriptErrorsSuppressed = true,
                Dock = DockStyle.Fill
            };

            web.DocumentCompleted += web_DocumentComplete;
            tabControl1.TabPages.Add("");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i++;
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("google.com");
            AddressBar.Clear();
            ProgressBar.Value = 0;

            web.ProgressChanged += new WebBrowserProgressChangedEventHandler(delegate (object Sender, WebBrowserProgressChangedEventArgs events)
            {
                if ((int)events.CurrentProgress > 0)
                {
                    ProgressBar.Maximum = (int)events.MaximumProgress;
                //    ProgressBar.Value = (int)events.CurrentProgress;
                }
            });
        }

        private void splitButtonCreatePage(object sender, EventArgs e)
        {
            buttonCreatePage(sender, e);
        }

        private void web_DocumentComplete(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void browserLoad(object sender, EventArgs e)
        {
            buttonCreatePage(sender, e);
        }
    }
}