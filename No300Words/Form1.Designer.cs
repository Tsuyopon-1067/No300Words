namespace No300Words {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.名前を付けて保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォント設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.フォントカラーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外観設定をリセットToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_save = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.param = new System.Windows.Forms.ToolStripLabel();
            this.tx = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.フォント設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_KeyDown);
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.名前を付けて保存ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // 開くToolStripMenuItem
            // 
            this.開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            this.開くToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.開くToolStripMenuItem.Text = "開く";
            this.開くToolStripMenuItem.Click += new System.EventHandler(this.open_dia);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.保存ToolStripMenuItem.Text = "上書き保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 名前を付けて保存ToolStripMenuItem
            // 
            this.名前を付けて保存ToolStripMenuItem.Name = "名前を付けて保存ToolStripMenuItem";
            this.名前を付けて保存ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.名前を付けて保存ToolStripMenuItem.Text = "名前を付けて保存";
            this.名前を付けて保存ToolStripMenuItem.Click += new System.EventHandler(this.save_name);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // フォント設定ToolStripMenuItem
            // 
            this.フォント設定ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.フォントToolStripMenuItem,
            this.フォントカラーToolStripMenuItem,
            this.背景色ToolStripMenuItem,
            this.外観設定をリセットToolStripMenuItem});
            this.フォント設定ToolStripMenuItem.Name = "フォント設定ToolStripMenuItem";
            this.フォント設定ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.フォント設定ToolStripMenuItem.Text = "外観設定";
            // 
            // フォントToolStripMenuItem
            // 
            this.フォントToolStripMenuItem.Name = "フォントToolStripMenuItem";
            this.フォントToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.フォントToolStripMenuItem.Text = "フォント";
            this.フォントToolStripMenuItem.Click += new System.EventHandler(this.フォント設定ToolStripMenuItem_Click);
            // 
            // フォントカラーToolStripMenuItem
            // 
            this.フォントカラーToolStripMenuItem.Name = "フォントカラーToolStripMenuItem";
            this.フォントカラーToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.フォントカラーToolStripMenuItem.Text = "フォントカラー";
            this.フォントカラーToolStripMenuItem.Click += new System.EventHandler(this.フォントカラーToolStripMenuItem_Click);
            // 
            // 背景色ToolStripMenuItem
            // 
            this.背景色ToolStripMenuItem.Name = "背景色ToolStripMenuItem";
            this.背景色ToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.背景色ToolStripMenuItem.Text = "背景色";
            this.背景色ToolStripMenuItem.Click += new System.EventHandler(this.背景色ToolStripMenuItem_Click);
            // 
            // 外観設定をリセットToolStripMenuItem
            // 
            this.外観設定をリセットToolStripMenuItem.Name = "外観設定をリセットToolStripMenuItem";
            this.外観設定をリセットToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.外観設定をリセットToolStripMenuItem.Text = "外観設定をリセット";
            this.外観設定をリセットToolStripMenuItem.Click += new System.EventHandler(this.外観設定をリセットToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_save,
            this.toolStripButton2,
            this.toolStripButton4,
            this.param});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_save.Image = global::No300Words.Properties.Resources.save;
            this.btn_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(23, 22);
            this.btn_save.Text = "上書き保存";
            this.btn_save.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::No300Words.Properties.Resources.num;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "文数カウント";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::No300Words.Properties.Resources.goal;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "目標語数設定";
            this.toolStripButton4.Click += new System.EventHandler(this.Goalbtn_Click);
            // 
            // param
            // 
            this.param.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(375, 22);
            this.param.Text = "目標 : 0語  現在 : 0文字 0語  あと0語  達成率 : 100.0%";
            // 
            // tx
            // 
            this.tx.AcceptsTab = true;
            this.tx.AllowDrop = true;
            this.tx.BackColor = System.Drawing.SystemColors.Window;
            this.tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tx.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx.ForeColor = System.Drawing.Color.Black;
            this.tx.Location = new System.Drawing.Point(0, 49);
            this.tx.Multiline = true;
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(784, 512);
            this.tx.TabIndex = 2;
            this.tx.TextChanged += new System.EventHandler(this.tx_TextChanged);
            this.tx.DragDrop += new System.Windows.Forms.DragEventHandler(this.tx_DragDrop);
            this.tx.DragEnter += new System.Windows.Forms.DragEventHandler(this.tx_DragEnter);
            this.tx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_KeyDown);
            this.tx.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.wheel);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "No300Words";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 名前を付けて保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_save;
        private System.Windows.Forms.ToolStripLabel param;
        private System.Windows.Forms.ToolStripMenuItem フォント設定ToolStripMenuItem;
        private System.Windows.Forms.TextBox tx;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem フォントToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フォントカラーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景色ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem 外観設定をリセットToolStripMenuItem;
    }
}

