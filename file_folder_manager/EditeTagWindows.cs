using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace file_folder_manager
{
    public partial class EditeTagWindows : Form
    {
        private const string FILE_NAME = "tag.json";

        public EditeTagWindows()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            selectedFileFolderText.Text = "";
            favoriteCheckBox.Checked = false;
            keywordListView.Items.Clear();
            disallowEdite();

        }

        private void allowEdite()
        {
            favoriteCheckBox.Enabled = true;
            addKeywordButton.Enabled = true;
            deleteKeywordButton.Enabled = true;
            registerButton.Enabled = true;
        }

        private void disallowEdite()
        {
            favoriteCheckBox.Enabled = false;
            addKeywordButton.Enabled = false;
            deleteKeywordButton.Enabled = false;
            registerButton.Enabled = false;
        }

        private void exsitButton_Click(object sender, EventArgs e)
        {
            // InitWindowsを表示
            InitWindow initWindow = new InitWindow();
            initWindow.Visible = true;

            // EditeTagWindowsを閉じる
            this.Close();
        }

        private void EditeTagWindows_DragDrop(object sender, DragEventArgs e)
        {
            Initialize();

            // ドラッグ＆ドロップしたファイルフォルダのパスを取得
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            // ファイルフォルダかを確認
            string targetFolder = files[0];
            bool isFolder = File.GetAttributes(targetFolder).HasFlag(FileAttributes.Directory);
            if (isFolder)
            {
                // ファイルフォルダのパス情報を表示
                selectedFileFolderText.Text = targetFolder;

                try
                {
                    // ファイル読み込み
                    string tagFile = selectedFileFolderText.Text + "/" + FILE_NAME;
                    string jsonStr = File.ReadAllText(tagFile);

                    // タグ生成
                    Tag tag = JsonSerializer.Deserialize<Tag>(jsonStr);

                    // キーワードおよびお気に入り設定の情報を表示
                    foreach (string keyword in tag.Keywords)
                    {
                        keywordListView.Items.Add(keyword);
                    }
                    favoriteCheckBox.Checked = tag.IsFavorited;

                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }

                allowEdite();
            }
            else
            {
                MessageBox.Show("ファイルは指定できません。\nフォルダをドラッグ＆ドロップで指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditeTagWindows_DragEnter(object sender, DragEventArgs e)
        {
            // マウスポインター形状変更
            //
            //  DragDropEffects
            //  Copy  :データがドロップ先にコピーされようとしている状態
            //  Move  :データがドロップ先に移動されようとしている状態
            //  Scroll:データによってドロップ先でスクロールが開始されようとしている状態、あるいは現在スクロール中である状態
            //  All   :上の3つを組み合わせたもの
            //  Link  :データのリンクがドロップ先に作成されようとしている状態
            //  None  :いかなるデータもドロップ先が受け付けようとしない状態
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void addKeywordButton_Click(object sender, EventArgs e)
        {
            EditeKeywordWindows form = new EditeKeywordWindows("");
            DialogResult res = form.ShowDialog();

            if (form.KeywordTextBoxStr.Length != 0 && res == DialogResult.OK)
            {
                keywordListView.Items.Add(form.KeywordTextBoxStr);
            }

        }

        private void deleteKeywordButton_Click(object sender, EventArgs e)
        {
            // 選択したキーワードを削除
            if (keywordListView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in keywordListView.SelectedItems)
                {
                    keywordListView.Items.Remove(item);
                }
            }
        }

        private void keywordListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ダブルクリックしたキーワードを取得
            ListView listView = (ListView)sender;
            ListViewItem targetItem = listView.SelectedItems[0];

            // 遷移画面でキーワードを修正後、OKボタンを押すと反映
            EditeKeywordWindows form = new EditeKeywordWindows(targetItem.Text);
            DialogResult res = form.ShowDialog();
            if (res == DialogResult.OK)
            {
                targetItem.Text = form.KeywordTextBoxStr;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            // キーワードを取得
            List<string> keywords = new List<string>();
            foreach (ListViewItem item in keywordListView.Items)
            {
                keywords.Add(item.Text);
            }

            // お気に入り設定を取得
            bool isFavorited = favoriteCheckBox.Checked;

            // タグ生成
            Tag tag = new Tag(keywords, isFavorited);

            // json生成および出力
            string jsonStr = JsonSerializer.Serialize(tag);
            string filePath = selectedFileFolderText.Text;
            File.WriteAllText(filePath + "/" + FILE_NAME, jsonStr);
        }
    }
}
