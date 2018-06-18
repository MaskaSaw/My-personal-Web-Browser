using System;
using System.IO;
using System.Windows.Forms;

namespace Browser
{
    public partial class MainWindow : Form
    {
        private void openFavouritsWindow(object sender, EventArgs e)
        {
            FavouriteForm showFavourite = new FavouriteForm();
            showFavourite.Show();
        }

        private void openHistoryWindow(object sender, EventArgs e)
        {
            HistoryForm showHistory = new HistoryForm();
            showHistory.Show();
        }

        private void openOptionsWindow(object sender, System.EventArgs e)
        {
            OptionsForm showOptions = new OptionsForm();
            showOptions.Show();
        }
    }
}
