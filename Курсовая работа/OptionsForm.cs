using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void DeleteFavourite(object sender, EventArgs e)
        {
            FileStream file = new FileStream("Favourite.txt", FileMode.Create);
            file.Close();
        }

        private void DeleteHistory(object sender, EventArgs e)
        {
            FileStream file = new FileStream("History.txt", FileMode.Create);
            file.Close();
        }
    }
}
