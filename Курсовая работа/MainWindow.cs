using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public partial class MainWindow : Form
    {
        private int i = 0;

        WebBrowser web;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void addFavourite(object sender, System.EventArgs e)
        {
            FileStream file = new FileStream("Favourite.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(file);

            string url_str = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Url.ToString() + '@';
            AddressBar.Text = url_str;
            writer.Write(url_str);
            writer.Close();
        }
    }
}