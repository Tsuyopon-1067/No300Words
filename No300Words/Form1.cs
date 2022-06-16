using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace No300Words {
    public partial class Form1 : Form {


        string filename = "";//上書き保存に使う
        int goal = 300;
        int[] goal_array = new int[1];//0データわたし
        //bool save_flug = false;//セーブが必要ならtrue
        SAVE_FLUG save_f = new SAVE_FLUG();

        public Form1() {
            InitializeComponent();
            //最初画面をに更新する
            txt_renew();
            btn_save.BackColor = ColorTranslator.FromHtml("#ffffff");//初回の色
            goal_array[0] = goal;
            this.tx.ForeColor = Properties.Settings.Default.tx_fcolor;
            this.tx.BackColor = Properties.Settings.Default.tx_bcolor;
            this.tx.Font = Properties.Settings.Default.tx_font;
            this.Size = Properties.Settings.Default.form_size;
            this.Location = Properties.Settings.Default.form_loc;
        }

        private class SAVE_FLUG {
            public bool flug = false;//セーブが必要ならtrue falseは保存済み
            private bool flug2 = false;//検知用
            public bool is_changed() {//変更されたらTrue
                bool f = false;
                if (flug != flug2) {
                    flug2 = flug;
                    f = true;
                }
                return f;
            }
        }


        private void save_name(object sender, EventArgs e) {
            save_name_dia();
        }
        private bool save_name_dia() {//名前で保存できなかったらtrueを返す
            bool flug = false;
            //SaveFileDialogクラスのインスタンスを作成
            SaveFileDialog sfd = new SaveFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            sfd.FileName = "新しいファイル.txt";
            //はじめに表示されるフォルダを指定する
            sfd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            sfd.Filter = "テキストファイル(*.txt)|*.txt";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            sfd.FilterIndex = 1;
            //タイトルを設定する
            sfd.Title = "保存先のファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.RestoreDirectory = true;
            //既に存在するファイル名を指定したとき警告する
            //デフォルトでTrueなので指定する必要はない
            sfd.OverwritePrompt = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;

            //ダイアログを表示する
            DialogResult result = sfd.ShowDialog();
            if (result == DialogResult.OK) {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                filename = sfd.FileName;
                save(filename);
            }
            else if (result == DialogResult.Cancel) flug = true;
            title_renew();


            return flug;
        }
        private void save(string s) {
            StreamWriter sw = new StreamWriter(s, false, Encoding.GetEncoding("UTF-8"));
            sw.Write(tx.Text);
            sw.Close();
            save_f.flug = false;
            btn_save.BackColor = ColorTranslator.FromHtml("#ffffff");
        }
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            save_uwa();
        }

        private bool save_uwa() {//名前で保存できなかったらtrueを返す
            bool flug = false;
            if (filename == "") {
                if(save_name_dia()) flug = true;
            }
            else save(filename);
            return flug;
        }
        private void tx_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
        }


        private void tx_DragDrop(object sender, DragEventArgs e) {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
            filename = "";
            filename = string.Join("", s);
            open(filename); 
            title_renew();
        }
        private void open(string s) {
            StreamReader st = new StreamReader(s, Encoding.GetEncoding("UTF-8"));
            tx.Text = st.ReadToEnd();
            st.Dispose();
            title_renew();
        }


        private void open_dia(object sender, EventArgs e) {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.html";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); ;
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "テキストファイル(*.txt)|*.txt";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK) {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                filename = (ofd.FileName);
                open(filename);
            }
        }
        private void tx_TextChanged(object sender, EventArgs e) {
            txt_renew();
            save_f.flug = true;
        }
        private void txt_renew() {
            int word_now = count_word(tx.Text);//現在語数

            int word_remain;//残り語数
            word_remain = goal - word_now;
            if (word_remain < 0) word_remain = 0;

            double achive_num = 0;
            string moku = "目標 : " + goal.ToString() + "語";
            string gen = "現在 : " + (tx.TextLength).ToString() + "文字 " + word_now.ToString() + "語";
            string ato = "あと : " + word_remain.ToString() + "語";
            //語数求める
            if (goal != 0) achive_num = 100 * (double)word_now / (double)goal;
            else achive_num = 100;
            string achive = "達成率 : " + achive_num.ToString("0.0") + "%";
            string sentence = (tx.Text.Length - tx.Text.Replace(".", "").Length).ToString() + "文";
            string s = "   ";
            param.Text = moku + s + gen + s + ato + s + achive + s + sentence;

            btn_save.BackColor = ColorTranslator.FromHtml("#ff0000");
        }
        private int count_word(string s) {
            int i;//返す

            while (s.Contains("  ")) {
                s = s.Replace("    ", " ");
                s = s.Replace("   ", " ");
                s = s.Replace("  ", " ");
            }

            if (s.Length == 0) {
                i = 0;
            }
            else if (s.Length == 1) {
                if (s == " ") i = 0;
                else i = 1;
            }
            else {
                char[] c = s.ToCharArray();//最初のスペースの有無判定用配列
                if (c[0] == ' ') s = s.Remove(0, 1);
                s = s.Remove(s.Length - 1);//最後スペースならは絶対に1スペース
                string[] array = s.Split(' ');
                i = array.Length;
            }
            return i;
        }


        private void フォント設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            // FontDialog の新しいインスタンスを生成する (デザイナから追加している場合は必要ない)
            FontDialog fontDialog1 = new FontDialog();

            // 初期選択するフォントを設定する
            fontDialog1.Font = tx.Font;

            // 初期選択する色を設定する
            fontDialog1.Color = tx.ForeColor;

            // 選択可能なフォントサイズの最大値を設定する
            fontDialog1.MaxSize = 1000;

            // 選択可能なフォントサイズの最小値を設定する
            fontDialog1.MinSize = 4;

            // 色を選択できるようにする (初期値 false)
            fontDialog1.ShowColor = true;

            // 取り消し線、下線、テキストの色などのオプションを指定可能にする (初期値 true)
            fontDialog1.ShowEffects = false;

            // ダイアログを表示し、戻り値が [OK] の場合は選択したフォントを textBox1 に適用する
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                tx.Font = fontDialog1.Font;
                tx.ForeColor = fontDialog1.Color;

                Properties.Settings.Default["tx_font"] = tx.Font;
                //Properties.Settings.Default["tx_color"] = tx.ForeColor;
            }//https://builder.japan.zdnet.com/blog/10507800/2009/04/27/entry_27022047/

            // 不要になった時点で破棄する (正しくは オブジェクトの破棄を保証する を参照)
            fontDialog1.Dispose();
            Properties.Settings.Default.tx_font = tx.Font;
            Properties.Settings.Default.Save();
        }

        private void Goalbtn_Click(object sender, EventArgs e) {
            
            Form2 f2 = new Form2(goal_array);
            f2.numbox.Value = goal;
            f2.numbox.Select();
            f2.numbox.Select(0, f2.numbox.Value.ToString().Length);
            int X = System.Windows.Forms.Cursor.Position.X - 100;
            int Y = System.Windows.Forms.Cursor.Position.Y - 100;
            if (X < 0) X = 0;
            if (Y < 0) Y = 0;
            f2.Location = new System.Drawing.Point(X, Y);

            f2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (goal != goal_array[0]) {
                goal = goal_array[0];
                txt_renew();
            }
            
            if (save_f.is_changed()) {
                title_renew();
            }
            
        }


        private void 背景色ToolStripMenuItem_Click(object sender, EventArgs e) {
            tx.BackColor = Color_set(tx.BackColor);
            Properties.Settings.Default.tx_fcolor = tx.BackColor;
            Properties.Settings.Default.Save();
        }
        private void フォントカラーToolStripMenuItem_Click(object sender, EventArgs e) {
            tx.ForeColor = Color_set(tx.ForeColor);
            Properties.Settings.Default.tx_bcolor = tx.BackColor;
            Properties.Settings.Default.Save();
        }
        private Color Color_set(Color col_def) {//col_def:最初の色
            //ColorDialogクラスのインスタンスを作成
            ColorDialog cd = new ColorDialog();

            //はじめに選択されている色を設定
            cd.Color = col_def;
            //色の作成部分を表示可能にする
            //デフォルトがTrueのため必要はない
            cd.AllowFullOpen = true;
            //純色だけに制限しない
            //デフォルトがFalseのため必要はない
            cd.SolidColorOnly = false;
            //[作成した色]に指定した色（RGB値）を表示する
            cd.CustomColors = new int[] {
    0x33, 0x66, 0x99, 0xCC, 0x3300, 0x3333,
    0x3366, 0x3399, 0x33CC, 0x6600, 0x6633,
    0x6666, 0x6699, 0x66CC, 0x9900, 0x9933};

            //ダイアログを表示する
            if (cd.ShowDialog() == DialogResult.OK) col_def = cd.Color;//選択された色の取得
            return col_def;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            
            if(before_close()) e.Cancel = true;
        }
        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            before_close();

        }
        bool before_close() {
            bool flug = false;//falseなら閉じる
            if(save_f.flug) {
                DialogResult result = MessageBox.Show("ファイルを保存しますか？",
                                                        "質問",
                                                        MessageBoxButtons.YesNoCancel,
                                                        MessageBoxIcon.Exclamation,
                                                        MessageBoxDefaultButton.Button2);

                //何が選択されたか調べる
                if (result == DialogResult.Yes) {
                    if (save_uwa()) flug = true;//save_name_dia>>save_uwa>>TF
                    if (!flug) this.Dispose();
                }
                else if (result == DialogResult.No) this.Dispose();
                else if (result == DialogResult.Cancel) flug = true;
            }
            else this.Dispose();
            return flug;
        }
        void title_renew() {
            if (save_f.flug) this.Text = "[保存前] | ";
            else this.Text = "[保存済み] | ";

            if (filename != "") this.Text = filename + " | " + this.Text;

            this.Text = this.Text + "No300Words";
        }

        private void toolStripButton2_Click(object sender, EventArgs e) {
            string[] s = tx.Text.Split('.');
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length - 1; i++) {
                s[i] = s[i] + ".(" + (i + 1).ToString() + ")";
                sb.Append(s[i]);
            }
            sb.Append(s[s.Length - 1]);
            tx.Text = sb.ToString();
        }

        private void tx_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.S && e.Control == true) save_uwa();
            //e.Handled = true;
        }

        private void wheel(object sender,
    System.Windows.Forms.MouseEventArgs e) {
            if(Control.ModifierKeys == Keys.Control) {
                if(tx.Font.Size + e.Delta* SystemInformation.MouseWheelScrollLines / 120 > 0) {
                    tx.Font = new Font(tx.Font.FontFamily, tx.Font.Size + e.Delta * SystemInformation.MouseWheelScrollLines / 120);
                }
                
            }
        }

        private void 外観設定をリセットToolStripMenuItem_Click(object sender, EventArgs e) {
            if(MessageBox.Show("外観設定をリセットします。", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                if (MessageBox.Show("フォント・フォントカラー・背景色をリセットします。", "ほんまにええんか？", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes) {
                    tx.Font = new Font("Century", 16);
                    tx.ForeColor = Color.Black;
                    tx.BackColor = Color.White;

                    Properties.Settings.Default.tx_font = tx.Font;
                    Properties.Settings.Default.tx_fcolor = tx.ForeColor;
                    Properties.Settings.Default.tx_bcolor = tx.BackColor;
                    Properties.Settings.Default.Save();
                }
                }
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {
            Properties.Settings.Default.form_size = this.Size;
            Properties.Settings.Default.Save();
        }

        private void Form1_LocationChanged(object sender, EventArgs e) {
            Properties.Settings.Default.form_loc = this.Location;
            Properties.Settings.Default.Save();
        }
    }
}
