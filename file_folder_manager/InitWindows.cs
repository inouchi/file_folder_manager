using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;

namespace file_folder_manager
{
    public partial class InitWindow : Form
    {

        public InitWindow()
        {
            InitializeComponent();
        }

        private void editeTagButton_Click(object sender, EventArgs e)
        {
            // InitWindowsを非表示
            this.Visible = false;

            // EditeTagWindowsを表示
            EditeTagWindows editeTagWindows = new EditeTagWindows();
            editeTagWindows.Show();
        }

        private void searchFolderButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            // InitWindowsを非表示
            this.Visible = false;

            // SearchFolderWindowsを表示
            SearchFolderWindows searchFolderWindows = new SearchFolderWindows();
            searchFolderWindows.Show();
        }

        private void quitSystemButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
