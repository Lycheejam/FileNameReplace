namespace FileNameReplace
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.act_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folder_btn = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // act_btn
            // 
            this.act_btn.Location = new System.Drawing.Point(13, 13);
            this.act_btn.Name = "act_btn";
            this.act_btn.Size = new System.Drawing.Size(259, 45);
            this.act_btn.TabIndex = 0;
            this.act_btn.Text = "実行";
            this.act_btn.UseVisualStyleBackColor = true;
            this.act_btn.Click += new System.EventHandler(this.act_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 19);
            this.textBox1.TabIndex = 1;
            // 
            // folder_btn
            // 
            this.folder_btn.Location = new System.Drawing.Point(13, 64);
            this.folder_btn.Name = "folder_btn";
            this.folder_btn.Size = new System.Drawing.Size(258, 44);
            this.folder_btn.TabIndex = 2;
            this.folder_btn.Text = "フォルダ選択";
            this.folder_btn.UseVisualStyleBackColor = true;
            this.folder_btn.Click += new System.EventHandler(this.folder_btn_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(13, 140);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 21;
            this.dgv.Size = new System.Drawing.Size(259, 154);
            this.dgv.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 306);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.folder_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.act_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button act_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button folder_btn;
        private System.Windows.Forms.DataGridView dgv;
    }
}

