using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        public void HistoryWindowLoad(object sender, System.EventArgs e)
        {
            FileStream file = new FileStream("History.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            string buff;
            buff = reader.ReadToEnd();

            string temp_str = "";

            for (int i = 0; i < buff.Length; i++)
            {
                temp_str += buff[i];

                if (i + 1 < buff.Length)
                    if (buff[i + 1] == '@')
                    {
                        i++;
                        listBox1.Items.Add(temp_str);
                        temp_str = "";
                    }
            }

            reader.Close();
        }

        private void Navigate(object sender, System.EventArgs e)
        {
            string address = listBox1.SelectedItem.ToString();
            Clipboard.SetText(address);
        }
    }
}
