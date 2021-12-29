namespace file_folder_manager
{
    partial class EditeTagWindows
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
            this.exsitButton = new System.Windows.Forms.Button();
            this.selectedFileFolderText = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.keywordListView = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.addKeywordButton = new System.Windows.Forms.Button();
            this.deleteKeywordButton = new System.Windows.Forms.Button();
            this.favoriteCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // exsitButton
            // 
            this.exsitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exsitButton.Location = new System.Drawing.Point(272, 239);
            this.exsitButton.Name = "exsitButton";
            this.exsitButton.Size = new System.Drawing.Size(100, 30);
            this.exsitButton.TabIndex = 0;
            this.exsitButton.Text = "閉じる";
            this.exsitButton.UseVisualStyleBackColor = true;
            this.exsitButton.Click += new System.EventHandler(this.exsitButton_Click);
            // 
            // selectedFileFolderText
            // 
            this.selectedFileFolderText.Location = new System.Drawing.Point(12, 34);
            this.selectedFileFolderText.Multiline = true;
            this.selectedFileFolderText.Name = "selectedFileFolderText";
            this.selectedFileFolderText.ReadOnly = true;
            this.selectedFileFolderText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.selectedFileFolderText.Size = new System.Drawing.Size(360, 50);
            this.selectedFileFolderText.TabIndex = 1;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(12, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(170, 13);
            this.label.TabIndex = 2;
            this.label.Text = "< 選択中のファイルフォルダ >";
            // 
            // keywordListView
            // 
            this.keywordListView.GridLines = true;
            this.keywordListView.HideSelection = false;
            this.keywordListView.Location = new System.Drawing.Point(12, 115);
            this.keywordListView.Name = "keywordListView";
            this.keywordListView.Size = new System.Drawing.Size(240, 100);
            this.keywordListView.TabIndex = 3;
            this.keywordListView.UseCompatibleStateImageBehavior = false;
            this.keywordListView.View = System.Windows.Forms.View.List;
            this.keywordListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.keywordListView_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "< キーワード/お気に入り >";
            // 
            // registerButton
            // 
            this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerButton.Location = new System.Drawing.Point(12, 239);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 30);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "タグ登録";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // addKeywordButton
            // 
            this.addKeywordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addKeywordButton.Location = new System.Drawing.Point(272, 145);
            this.addKeywordButton.Name = "addKeywordButton";
            this.addKeywordButton.Size = new System.Drawing.Size(100, 30);
            this.addKeywordButton.TabIndex = 6;
            this.addKeywordButton.Text = "キーワード追加";
            this.addKeywordButton.UseVisualStyleBackColor = true;
            this.addKeywordButton.Click += new System.EventHandler(this.addKeywordButton_Click);
            // 
            // deleteKeywordButton
            // 
            this.deleteKeywordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteKeywordButton.Location = new System.Drawing.Point(272, 185);
            this.deleteKeywordButton.Name = "deleteKeywordButton";
            this.deleteKeywordButton.Size = new System.Drawing.Size(100, 30);
            this.deleteKeywordButton.TabIndex = 7;
            this.deleteKeywordButton.Text = "キーワード削除";
            this.deleteKeywordButton.UseVisualStyleBackColor = true;
            this.deleteKeywordButton.Click += new System.EventHandler(this.deleteKeywordButton_Click);
            // 
            // favoriteCheckBox
            // 
            this.favoriteCheckBox.AutoSize = true;
            this.favoriteCheckBox.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.favoriteCheckBox.Location = new System.Drawing.Point(273, 116);
            this.favoriteCheckBox.Name = "favoriteCheckBox";
            this.favoriteCheckBox.Size = new System.Drawing.Size(107, 17);
            this.favoriteCheckBox.TabIndex = 8;
            this.favoriteCheckBox.Text = "お気に入り設定";
            this.favoriteCheckBox.UseVisualStyleBackColor = true;
            // 
            // EditeTagWindows
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.favoriteCheckBox);
            this.Controls.Add(this.deleteKeywordButton);
            this.Controls.Add(this.addKeywordButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keywordListView);
            this.Controls.Add(this.label);
            this.Controls.Add(this.selectedFileFolderText);
            this.Controls.Add(this.exsitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditeTagWindows";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditeTagWindows";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.EditeTagWindows_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.EditeTagWindows_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exsitButton;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListView keywordListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button addKeywordButton;
        private System.Windows.Forms.Button deleteKeywordButton;
        private System.Windows.Forms.CheckBox favoriteCheckBox;
        private System.Windows.Forms.TextBox selectedFileFolderText;
    }
}