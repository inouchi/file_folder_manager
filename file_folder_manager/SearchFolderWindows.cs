using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace file_folder_manager
{

    public partial class SearchFolderWindows : Form
    {
        private Dictionary<string, Tag> mFolders = new Dictionary<string, Tag>();
        private HashSet<string> mCandidateKeywords = new HashSet<string>();

        private const string FILE_NAME = "tag.json";

        public SearchFolderWindows()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            selectedRootFolderText.Text = "";
            anyRadioButton.Checked = true;
            allRadioButton.Checked = false;
            favoriteCheckBox.Checked = false;
            keywordListView.Items.Clear();
            searchResultListView.Items.Clear();
            mFolders.Clear();
            mCandidateKeywords.Clear();
            disallowEdite();

        }

        private void allowEdite()
        {
            anyRadioButton.Enabled = true;
            allRadioButton.Enabled = true;
            favoriteCheckBox.Enabled = true;
            addKeywordButton.Enabled = true;
            deleteKeywordButton.Enabled = true;
            searchButton.Enabled = true;
        }

        private void disallowEdite()
        {
            anyRadioButton.Enabled = false;
            allRadioButton.Enabled = false;
            favoriteCheckBox.Enabled = false;
            addKeywordButton.Enabled = false;
            deleteKeywordButton.Enabled = false;
            searchButton.Enabled = false;
        }

        private void SearchFolderWindows_DragDrop(object sender, DragEventArgs e)
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
                selectedRootFolderText.Text = targetFolder;

                // ディレクトリ以下のすべてのサブディレクトリの一覧を取得
                DirectoryInfo root = new DirectoryInfo(targetFolder);
                DirectoryInfo[] diAlls = root.GetDirectories("*", SearchOption.AllDirectories);

                foreach (DirectoryInfo di in diAlls)
                {
                    try
                    {
                        // ファイル読み込み
                        string tagFile = di.FullName + "/" + FILE_NAME;
                        string jsonStr = File.ReadAllText(tagFile);

                        // 検索対象のフォルダ情報（フォルダパス、タグ情報）を取得
                        Tag tag = JsonSerializer.Deserialize<Tag>(jsonStr);
                        string folderPath = di.FullName;
                        mFolders.Add(folderPath, tag);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("ファイルは指定できません。\nフォルダをドラッグ＆ドロップで指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (mFolders.Count > 0)
            {
                // 検索候補のキーワードを設定
                foreach (Tag tag in mFolders.Values)
                {
                    foreach (string keyword in tag.Keywords)
                    {
                        mCandidateKeywords.Add(keyword);
                    }
                }

                allowEdite();
            }
            else
            {
                MessageBox.Show("タグファイルが存在しません。。\nタグファイルがあるルートフォルダをドラッグ＆ドロップで指定してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SearchFolderWindows_DragEnter(object sender, DragEventArgs e)
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

        private void exsitButton_Click(object sender, EventArgs e)
        {
            // InitWindowsを表示
            InitWindow initWindow = new InitWindow();
            initWindow.Visible = true;

            // SearchFolderWindowsを閉じる
            this.Close();
        }

        private void addKeywordButton_Click(object sender, EventArgs e)
        {
            // 設定中のキーワードを除いた候補のキーワードを取得
            HashSet<string> candidateKeywords = mCandidateKeywords;
            foreach (ListViewItem item in keywordListView.Items)
            {
                candidateKeywords.Remove(item.Text);
            }

            SelectKeywordWindows form = new SelectKeywordWindows(candidateKeywords);
            DialogResult res = form.ShowDialog();

            if (form.KeywordComboBoxStr.Length != 0 && res == DialogResult.OK)
            {
                keywordListView.Items.Add(form.KeywordComboBoxStr);
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

        private Dictionary<string, Tag> searchFavoritedFolder(Dictionary<string, Tag> folders)
        {
            Dictionary<string, Tag> res = new Dictionary<string, Tag>();

            // お気に入り設定されているフォルダを検索
            foreach (KeyValuePair<string, Tag> item in folders)
            {
                if (item.Value.IsFavorited)
                {
                    res.Add(item.Key, item.Value);
                }
            }

            return res;
        }

        private Dictionary<string, Tag> anySearchFolder(List<string> keywords, bool isFavorited)
        {
            Dictionary<string, Tag> res = new Dictionary<string, Tag>();
            Dictionary<string, Tag> tmp = new Dictionary<string, Tag>();

            // お気に入り設定されているフォルダを検索
            if (isFavorited)
            {
                res = searchFavoritedFolder(mFolders);
            }
            else
            {
                res = mFolders;
            }

            if (keywords.Count == 0)
            {
                return res;
            }

            // いずれかのキーワードを含むフォルダを検索
            tmp = new Dictionary<string, Tag>(res);
            res.Clear();
            foreach (KeyValuePair<string, Tag> item in tmp)
            {
                var s = new HashSet<string>(item.Value.Keywords);
                s.IntersectWith(keywords);
                if (s.Count > 0)
                {
                    res.Add(item.Key, item.Value);
                }

            }

            return res;
        }

        private Dictionary<string, Tag> allSearchFolder(List<string> keywords, bool isFavorited)
        {
            Dictionary<string, Tag> res = new Dictionary<string, Tag>();
            Dictionary<string, Tag> tmp = new Dictionary<string, Tag>();

            // お気に入り設定されているフォルダを検索
            if (isFavorited)
            {
                res = searchFavoritedFolder(mFolders);
            }
            else
            {
                res = mFolders;
            }

            if (keywords.Count == 0)
            {
                return res;
            }

            // キーワードをすべて含むフォルダを検索
            tmp = new Dictionary<string, Tag>(res);
            res.Clear();
            int keywordNum = keywords.Count;
            foreach (KeyValuePair<string, Tag> item in tmp)
            {
                var s = new HashSet<string>(item.Value.Keywords);
                s.IntersectWith(keywords);
                if (s.Count == keywordNum)
                {
                    res.Add(item.Key, item.Value);
                }

            }

            return res;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchResultListView.Items.Clear();
            Dictionary<string, Tag> res = new Dictionary<string, Tag>();

            // 設定したキーワードを取得
            List<string> keywords = new List<string>();
            foreach (ListViewItem item in keywordListView.Items)
            {
                keywords.Add(item.Text);
            }

            // お気に入り設定の情報を取得
            bool isFavorited = favoriteCheckBox.Checked;

            // ラジオボタンに対応した検索
            if (anyRadioButton.Checked)
            {
                res = anySearchFolder(keywords, isFavorited);
            }
            else
            {
                res = allSearchFolder(keywords, isFavorited);
            }

            if (res.Count == 0)
            {
                MessageBox.Show("条件を満たすフォルダが見つかりませんでした。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string folderPath in res.Keys)
            {
                searchResultListView.Items.Add(folderPath);
            }
        }

        private void searchResultListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ダブルクリックしたキーワードを取得
            ListView listView = (ListView)sender;
            ListViewItem targetItem = listView.SelectedItems[0];

            try
            {
                Process.Start(targetItem.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
