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
    public partial class SelectKeywordWindows : Form
    {
        public string KeywordComboBoxStr { get; private set; }

        public SelectKeywordWindows(HashSet<string> candidateKeywords)
        {
            InitializeComponent();
            KeywordComboBoxStr = "";
            foreach (string keyword in candidateKeywords)
            {
               keywordComboBox.Items.Add(keyword);
            }

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            KeywordComboBoxStr = keywordComboBox.Text;
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
