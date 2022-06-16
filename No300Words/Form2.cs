using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No300Words {
    public partial class Form2 : Form {
        int[] goal_array_f2 = new int[1];//返すやつ
        public Form2(int[] goal) {
            goal_array_f2 = goal;
            InitializeComponent();
            numbox.Controls[0].Visible = false;
        }
        public void ShowG() {
            
        }

        private void Form2_Load(object sender, EventArgs e) {
        }

        private void button1_Click(object sender, EventArgs e) {
            set();
        }
        private void set() {

            goal_array_f2[0] = (int)numbox.Value;
            this.Dispose();
        }
        private void numbox_KeyDown_En(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) set();
        }
        const int MAX = 99999;
        private void btn_p_Click(object sender, EventArgs e) {
            int goal_f2;
            goal_f2 = (int)(numbox.Value) + int.Parse((((Button)sender).Text).Remove(0, 1));
            if (goal_f2 > MAX) goal_f2 = MAX;
            numbox.Value = goal_f2;
        }
        private void btn_m_Click(object sender, EventArgs e) {
            int goal_f2;
            goal_f2 = (int)(numbox.Value) - int.Parse((((Button)sender).Text).Remove(0, 1));
            if (goal_f2 < 1) goal_f2 = 1;
            numbox.Value = goal_f2;
        }
    }
}
