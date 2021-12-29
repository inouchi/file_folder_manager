namespace file_folder_manager
{
    partial class SearchFolderWindows
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedRootFolderText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anyRadioButton = new System.Windows.Forms.RadioButton();
            this.allRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.favoriteCheckBox = new System.Windows.Forms.CheckBox();
            this.keywordListView = new System.Windows.Forms.ListView();
            this.addKeywordButton = new System.Windows.Forms.Button();
            this.deleteKeywordButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exsitButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // selectedRootFolderText
            // 
            this.selectedRootFolderText.Location = new System.Drawing.Point(12, 34);
            this.selectedRootFolderText.Multiline = true;
            this.selectedRootFolderText.Name = "selectedRootFolderText";
            this.selectedRootFolderText.ReadOnly = true;
            this.selectedRootFolderText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectedRootFolderText.Size = new System.Drawing.Size(560, 19);
            this.selectedRootFolderText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "< 選択中のルートフォルダ >";
            // 
            // anyRadioButton
            // 
            this.anyRadioButton.AutoSize = true;
            this.anyRadioButton.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.anyRadioButton.Location = new System.Drawing.Point(15, 88);
            this.anyRadioButton.Name = "anyRadioButton";
            this.anyRadioButton.Size = new System.Drawing.Size(104, 17);
            this.anyRadioButton.TabIndex = 3;
            this.anyRadioButton.TabStop = true;
            this.anyRadioButton.Text = "いずれかを含む";
            this.anyRadioButton.UseVisualStyleBackColor = true;
            // 
            // allRadioButton
            // 
            this.allRadioButton.AutoSize = true;
            this.allRadioButton.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.allRadioButton.Location = new System.Drawing.Point(125, 88);
            this.allRadioButton.Name = "allRadioButton";
            this.allRadioButton.Size = new System.Drawing.Size(91, 17);
            this.allRadioButton.TabIndex = 4;
            this.allRadioButton.TabStop = true;
            this.allRadioButton.Text = "すべてを含む";
            this.allRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "< 検索条件 >";
            // 
            // favoriteCheckBox
            // 
            this.favoriteCheckBox.AutoSize = true;
            this.favoriteCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.favoriteCheckBox.Location = new System.Drawing.Point(472, 116);
            this.favoriteCheckBox.Name = "favoriteCheckBox";
            this.favoriteCheckBox.Size = new System.Drawing.Size(107, 17);
            this.favoriteCheckBox.TabIndex = 9;
            this.favoriteCheckBox.Text = "お気に入り設定";
            this.favoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // keywordListView
            // 
            this.keywordListView.GridLines = true;
            this.keywordListView.HideSelection = false;
            this.keywordListView.Location = new System.Drawing.Point(12, 111);
            this.keywordListView.Name = "keywordListView";
            this.keywordListView.Size = new System.Drawing.Size(440, 100);
            this.keywordListView.TabIndex = 10;
            this.keywordListView.UseCompatibleStateImageBehavior = false;
            this.keywordListView.View = System.Windows.Forms.View.List;
            // 
            // addKeywordButton
            // 
            this.addKeywordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addKeywordButton.Location = new System.Drawing.Point(472, 145);
            this.addKeywordButton.Name = "addKeywordButton";
            this.addKeywordButton.Size = new System.Drawing.Size(100, 30);
            this.addKeywordButton.TabIndex = 11;
            this.addKeywordButton.Text = "キーワード追加";
            this.addKeywordButton.UseVisualStyleBackColor = true;
            this.addKeywordButton.Click += new System.EventHandler(this.addKeywordButton_Click);
            // 
            // deleteKeywordButton
            // 
            this.deleteKeywordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteKeywordButton.Location = new System.Drawing.Point(472, 181);
            this.deleteKeywordButton.Name = "deleteKeywordButton";
            this.deleteKeywordButton.Size = new System.Drawing.Size(100, 30);
            this.deleteKeywordButton.TabIndex = 12;
            this.deleteKeywordButton.Text = "キーワード削除";
            this.deleteKeywordButton.UseVisualStyleBackColor = true;
            this.deleteKeywordButton.Click += new System.EventHandler(this.deleteKeywordButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(12, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "< 検索結果 >";
            // 
            // exsitButton
            // 
            this.exsitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exsitButton.Location = new System.Drawing.Point(472, 399);
            this.exsitButton.Name = "exsitButton";
            this.exsitButton.Size = new System.Drawing.Size(100, 30);
            this.exsitButton.TabIndex = 14;
            this.exsitButton.Text = "閉じる";
            this.exsitButton.UseVisualStyleBackColor = true;
            this.exsitButton.Click += new System.EventHandler(this.exsitButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(12, 399);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 30);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "検索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchResultListView
            // 
            this.searchResultListView.GridLines = true;
            this.searchResultListView.HideSelection = false;
            this.searchResultListView.Location = new System.Drawing.Point(12, 256);
            this.searchResultListView.Name = "searchResultListView";
            this.searchResultListView.Size = new System.Drawing.Size(560, 120);
            this.searchResultListView.TabIndex = 16;
            this.searchResultListView.UseCompatibleStateImageBehavior = false;
            this.searchResultListView.View = System.Windows.Forms.View.List;
            this.searchResultListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.searchResultListView_MouseDoubleClick);
            // 
            // SearchFolderWindows
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.searchResultListView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.exsitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deleteKeywordButton);
            this.Controls.Add(this.addKeywordButton);
            this.Controls.Add(this.keywordListView);
            this.Controls.Add(this.favoriteCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allRadioButton);
            this.Controls.Add(this.anyRadioButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectedRootFolderText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchFolderWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchFolderWindows";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.SearchFolderWindows_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.SearchFolderWindows_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox selectedRootFolderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton anyRadioButton;
        private System.Windows.Forms.RadioButton allRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox favoriteCheckBox;
        private System.Windows.Forms.ListView keywordListView;
        private System.Windows.Forms.Button addKeywordButton;
        private System.Windows.Forms.Button deleteKeywordButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exsitButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ListView searchResultListView;
    }
}