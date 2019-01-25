namespace DumpingDay
{
    partial class Main
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
            this.pnlDate = new System.Windows.Forms.Panel();
            this.lblDayofWeek = new System.Windows.Forms.Label();
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblMemo1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMemo4 = new System.Windows.Forms.Label();
            this.lblMemo3 = new System.Windows.Forms.Label();
            this.lblMemo2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlDate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlDate.Controls.Add(this.lblDayofWeek);
            this.pnlDate.Controls.Add(this.lblCurrentDate);
            this.pnlDate.Location = new System.Drawing.Point(30, 30);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(540, 88);
            this.pnlDate.TabIndex = 0;
            // 
            // lblDayofWeek
            // 
            this.lblDayofWeek.AutoSize = true;
            this.lblDayofWeek.Font = new System.Drawing.Font("メイリオ", 34F);
            this.lblDayofWeek.Location = new System.Drawing.Point(400, 10);
            this.lblDayofWeek.Name = "lblDayofWeek";
            this.lblDayofWeek.Size = new System.Drawing.Size(168, 69);
            this.lblDayofWeek.TabIndex = 3;
            this.lblDayofWeek.Text = "（金）";
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.Font = new System.Drawing.Font("メイリオ", 34F);
            this.lblCurrentDate.Location = new System.Drawing.Point(4, 11);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(371, 69);
            this.lblCurrentDate.TabIndex = 0;
            this.lblCurrentDate.Text = "2016年5月28日";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(500, 360);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(73, 32);
            this.btnReload.TabIndex = 1;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblMemo1
            // 
            this.lblMemo1.AutoSize = true;
            this.lblMemo1.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMemo1.Location = new System.Drawing.Point(7, 13);
            this.lblMemo1.Name = "lblMemo1";
            this.lblMemo1.Size = new System.Drawing.Size(436, 48);
            this.lblMemo1.TabIndex = 2;
            this.lblMemo1.Text = "今日は燃えるごみの日です。";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblMemo4);
            this.panel1.Controls.Add(this.lblMemo3);
            this.panel1.Controls.Add(this.lblMemo2);
            this.panel1.Controls.Add(this.lblMemo1);
            this.panel1.Location = new System.Drawing.Point(30, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 229);
            this.panel1.TabIndex = 3;
            // 
            // lblMemo4
            // 
            this.lblMemo4.AutoSize = true;
            this.lblMemo4.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMemo4.Location = new System.Drawing.Point(7, 163);
            this.lblMemo4.Name = "lblMemo4";
            this.lblMemo4.Size = new System.Drawing.Size(436, 48);
            this.lblMemo4.TabIndex = 5;
            this.lblMemo4.Text = "今日は燃えるごみの日です。";
            // 
            // lblMemo3
            // 
            this.lblMemo3.AutoSize = true;
            this.lblMemo3.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMemo3.Location = new System.Drawing.Point(7, 113);
            this.lblMemo3.Name = "lblMemo3";
            this.lblMemo3.Size = new System.Drawing.Size(436, 48);
            this.lblMemo3.TabIndex = 4;
            this.lblMemo3.Text = "今日は燃えるごみの日です。";
            // 
            // lblMemo2
            // 
            this.lblMemo2.AutoSize = true;
            this.lblMemo2.Font = new System.Drawing.Font("メイリオ", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMemo2.Location = new System.Drawing.Point(7, 63);
            this.lblMemo2.Name = "lblMemo2";
            this.lblMemo2.Size = new System.Drawing.Size(436, 48);
            this.lblMemo2.TabIndex = 3;
            this.lblMemo2.Text = "今日は燃えるごみの日です。";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClose.Location = new System.Drawing.Point(30, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(73, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("メイリオ", 9F);
            this.btnSetting.Location = new System.Drawing.Point(380, 360);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(73, 32);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.pnlDate);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Label lblDayofWeek;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label lblMemo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMemo4;
        private System.Windows.Forms.Label lblMemo3;
        private System.Windows.Forms.Label lblMemo2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSetting;
    }
}

