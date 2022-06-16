namespace No300Words {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_p100 = new System.Windows.Forms.Button();
            this.btn_m100 = new System.Windows.Forms.Button();
            this.btn_m10 = new System.Windows.Forms.Button();
            this.btn_p10 = new System.Windows.Forms.Button();
            this.btn_m1 = new System.Windows.Forms.Button();
            this.btn_p1 = new System.Windows.Forms.Button();
            this.numbox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numbox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.button1.Location = new System.Drawing.Point(18, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "目標語数を入力してください";
            // 
            // btn_p100
            // 
            this.btn_p100.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btn_p100.Location = new System.Drawing.Point(152, 44);
            this.btn_p100.Name = "btn_p100";
            this.btn_p100.Size = new System.Drawing.Size(43, 23);
            this.btn_p100.TabIndex = 5;
            this.btn_p100.Text = "+100";
            this.btn_p100.UseVisualStyleBackColor = true;
            this.btn_p100.Click += new System.EventHandler(this.btn_p_Click);
            // 
            // btn_m100
            // 
            this.btn_m100.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btn_m100.Location = new System.Drawing.Point(152, 70);
            this.btn_m100.Name = "btn_m100";
            this.btn_m100.Size = new System.Drawing.Size(43, 23);
            this.btn_m100.TabIndex = 6;
            this.btn_m100.Text = "-100";
            this.btn_m100.UseVisualStyleBackColor = true;
            this.btn_m100.Click += new System.EventHandler(this.btn_m_Click);
            // 
            // btn_m10
            // 
            this.btn_m10.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btn_m10.Location = new System.Drawing.Point(201, 70);
            this.btn_m10.Name = "btn_m10";
            this.btn_m10.Size = new System.Drawing.Size(43, 23);
            this.btn_m10.TabIndex = 8;
            this.btn_m10.Text = "-10";
            this.btn_m10.UseVisualStyleBackColor = true;
            this.btn_m10.Click += new System.EventHandler(this.btn_m_Click);
            // 
            // btn_p10
            // 
            this.btn_p10.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btn_p10.Location = new System.Drawing.Point(201, 44);
            this.btn_p10.Name = "btn_p10";
            this.btn_p10.Size = new System.Drawing.Size(43, 23);
            this.btn_p10.TabIndex = 7;
            this.btn_p10.Text = "+10";
            this.btn_p10.UseVisualStyleBackColor = true;
            this.btn_p10.Click += new System.EventHandler(this.btn_p_Click);
            // 
            // btn_m1
            // 
            this.btn_m1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btn_m1.Location = new System.Drawing.Point(250, 70);
            this.btn_m1.Name = "btn_m1";
            this.btn_m1.Size = new System.Drawing.Size(43, 23);
            this.btn_m1.TabIndex = 10;
            this.btn_m1.Text = "-1";
            this.btn_m1.UseVisualStyleBackColor = true;
            this.btn_m1.Click += new System.EventHandler(this.btn_m_Click);
            // 
            // btn_p1
            // 
            this.btn_p1.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.btn_p1.Location = new System.Drawing.Point(250, 44);
            this.btn_p1.Name = "btn_p1";
            this.btn_p1.Size = new System.Drawing.Size(43, 23);
            this.btn_p1.TabIndex = 9;
            this.btn_p1.Text = "+1";
            this.btn_p1.UseVisualStyleBackColor = true;
            this.btn_p1.Click += new System.EventHandler(this.btn_p_Click);
            // 
            // numbox
            // 
            this.numbox.Font = new System.Drawing.Font("Meiryo UI", 24F);
            this.numbox.Location = new System.Drawing.Point(18, 44);
            this.numbox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numbox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbox.Name = "numbox";
            this.numbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numbox.Size = new System.Drawing.Size(128, 48);
            this.numbox.TabIndex = 11;
            this.numbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numbox.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numbox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 147);
            this.Controls.Add(this.numbox);
            this.Controls.Add(this.btn_m1);
            this.Controls.Add(this.btn_p1);
            this.Controls.Add(this.btn_m10);
            this.Controls.Add(this.btn_p10);
            this.Controls.Add(this.btn_m100);
            this.Controls.Add(this.btn_p100);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(325, 186);
            this.MinimumSize = new System.Drawing.Size(325, 186);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "目標語数設定";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numbox_KeyDown_En);
            ((System.ComponentModel.ISupportInitialize)(this.numbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_p100;
        private System.Windows.Forms.Button btn_m100;
        private System.Windows.Forms.Button btn_m10;
        private System.Windows.Forms.Button btn_p10;
        private System.Windows.Forms.Button btn_m1;
        private System.Windows.Forms.Button btn_p1;
        internal System.Windows.Forms.NumericUpDown numbox;
    }
}