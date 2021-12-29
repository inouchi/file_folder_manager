namespace file_folder_manager
{
    partial class InitWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.editeTagButton = new System.Windows.Forms.Button();
            this.searchFolderButton = new System.Windows.Forms.Button();
            this.quitSystemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editeTagButton
            // 
            this.editeTagButton.Location = new System.Drawing.Point(92, 12);
            this.editeTagButton.Name = "editeTagButton";
            this.editeTagButton.Size = new System.Drawing.Size(100, 50);
            this.editeTagButton.TabIndex = 0;
            this.editeTagButton.Text = "タグ編集";
            this.editeTagButton.UseVisualStyleBackColor = true;
            this.editeTagButton.Click += new System.EventHandler(this.editeTagButton_Click);
            // 
            // searchFolderButton
            // 
            this.searchFolderButton.Location = new System.Drawing.Point(92, 75);
            this.searchFolderButton.Name = "searchFolderButton";
            this.searchFolderButton.Size = new System.Drawing.Size(100, 50);
            this.searchFolderButton.TabIndex = 1;
            this.searchFolderButton.Text = "フォルダ検索";
            this.searchFolderButton.UseVisualStyleBackColor = true;
            this.searchFolderButton.Click += new System.EventHandler(this.searchFolderButton_Click);
            // 
            // quitSystemButton
            // 
            this.quitSystemButton.Location = new System.Drawing.Point(92, 139);
            this.quitSystemButton.Name = "quitSystemButton";
            this.quitSystemButton.Size = new System.Drawing.Size(100, 50);
            this.quitSystemButton.TabIndex = 2;
            this.quitSystemButton.Text = "終了";
            this.quitSystemButton.UseVisualStyleBackColor = true;
            this.quitSystemButton.Click += new System.EventHandler(this.quitSystemButton_Click);
            // 
            // InitWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.quitSystemButton);
            this.Controls.Add(this.searchFolderButton);
            this.Controls.Add(this.editeTagButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "InitWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InitWindows";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editeTagButton;
        private System.Windows.Forms.Button searchFolderButton;
        private System.Windows.Forms.Button quitSystemButton;
    }
}

