using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_folder_manager
{
    public partial class EditeKeywordWindows : Form
    {
        public string KeywordTextBoxStr { get; private set; }

        public EditeKeywordWindows(string keyword)
        {
            InitializeComponent();
            KeywordTextBoxStr = keyword;
            keywordTextBox.Text = keyword;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            KeywordTextBoxStr = keywordTextBox.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
