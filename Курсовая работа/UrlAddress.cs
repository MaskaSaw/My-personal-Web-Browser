using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public partial class MainWindow : Form
    {
        private void GetUrl(object sender, System.EventArgs e)
        {
            FileStream file = new FileStream("History.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            string url_str = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString();
            AddressBar.Text = url_str;
            url_str += '@';
            writer.Write(url_str);
            writer.Close();
        }
    }
}
