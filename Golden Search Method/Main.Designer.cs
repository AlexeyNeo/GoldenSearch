namespace GoldenSearchMethod
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxf = new System.Windows.Forms.ComboBox();
            this.maxRadio = new System.Windows.Forms.RadioButton();
            this.MinRatio = new System.Windows.Forms.RadioButton();
            this.labelk = new System.Windows.Forms.Label();
            this.k_maxBox = new System.Windows.Forms.TextBox();
            this.labelt = new System.Windows.Forms.Label();
            this.tolBox = new System.Windows.Forms.TextBox();
            this.labelb = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.labela = new System.Windows.Forms.Label();
            this.aBox = new System.Windows.Forms.TextBox();
            this.labelf = new System.Windows.Forms.Label();
            this.iterationButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelms = new System.Windows.Forms.Label();
            this.ms = new System.Windows.Forms.TextBox();
            this.labelfx = new System.Windows.Forms.Label();
            this.fx1outBox = new System.Windows.Forms.TextBox();
            this.labelkk = new System.Windows.Forms.Label();
            this.countinerBox = new System.Windows.Forms.TextBox();
            this.labelabs = new System.Windows.Forms.Label();
            this.outTolBox = new System.Windows.Forms.TextBox();
            this.labelx = new System.Windows.Forms.Label();
            this.x1uotFBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelerr = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(283, 221);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(82, 26);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxf);
            this.groupBox1.Controls.Add(this.maxRadio);
            this.groupBox1.Controls.Add(this.MinRatio);
            this.groupBox1.Controls.Add(this.labelk);
            this.groupBox1.Controls.Add(this.k_maxBox);
            this.groupBox1.Controls.Add(this.labelt);
            this.groupBox1.Controls.Add(this.tolBox);
            this.groupBox1.Controls.Add(this.labelb);
            this.groupBox1.Controls.Add(this.bBox);
            this.groupBox1.Controls.Add(this.labela);
            this.groupBox1.Controls.Add(this.aBox);
            this.groupBox1.Controls.Add(this.labelf);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 205);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Входные данные";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxf
            // 
            this.comboBoxf.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxf.FormattingEnabled = true;
            this.comboBoxf.Items.AddRange(new object[] {
            "x^3+x^2-6*x-6",
            "x^3+x^2-7*x-7",
            "x^3+x^2-5*x-5",
            "x^3+x^2-8*x-8",
            "",
            ""});
            this.comboBoxf.Location = new System.Drawing.Point(121, 23);
            this.comboBoxf.Name = "comboBoxf";
            this.comboBoxf.Size = new System.Drawing.Size(121, 25);
            this.comboBoxf.TabIndex = 15;
            // 
            // maxRadio
            // 
            this.maxRadio.AutoSize = true;
            this.maxRadio.Checked = true;
            this.maxRadio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxRadio.Location = new System.Drawing.Point(104, 171);
            this.maxRadio.Name = "maxRadio";
            this.maxRadio.Size = new System.Drawing.Size(49, 19);
            this.maxRadio.TabIndex = 13;
            this.maxRadio.TabStop = true;
            this.maxRadio.Text = "Max";
            this.maxRadio.UseVisualStyleBackColor = true;
            // 
            // MinRatio
            // 
            this.MinRatio.AutoSize = true;
            this.MinRatio.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinRatio.Location = new System.Drawing.Point(162, 171);
            this.MinRatio.Name = "MinRatio";
            this.MinRatio.Size = new System.Drawing.Size(47, 19);
            this.MinRatio.TabIndex = 12;
            this.MinRatio.Text = "Min";
            this.MinRatio.UseVisualStyleBackColor = true;
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelk.Location = new System.Drawing.Point(52, 142);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(60, 18);
            this.labelk.TabIndex = 11;
            this.labelk.Text = "K_Max:";
            // 
            // k_maxBox
            // 
            this.k_maxBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.k_maxBox.Location = new System.Drawing.Point(122, 142);
            this.k_maxBox.Name = "k_maxBox";
            this.k_maxBox.Size = new System.Drawing.Size(82, 25);
            this.k_maxBox.TabIndex = 10;
            this.k_maxBox.Text = "100";
            this.k_maxBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.k_maxBox_KeyPress);
            // 
            // labelt
            // 
            this.labelt.AutoSize = true;
            this.labelt.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelt.Location = new System.Drawing.Point(81, 115);
            this.labelt.Name = "labelt";
            this.labelt.Size = new System.Drawing.Size(32, 18);
            this.labelt.TabIndex = 9;
            this.labelt.Text = "Tol:";
            this.labelt.Click += new System.EventHandler(this.label4_Click);
            // 
            // tolBox
            // 
            this.tolBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tolBox.Location = new System.Drawing.Point(122, 113);
            this.tolBox.Name = "tolBox";
            this.tolBox.Size = new System.Drawing.Size(82, 25);
            this.tolBox.TabIndex = 8;
            this.tolBox.Text = "1e-15";
            this.tolBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.tolBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tolBox_KeyPress);
            // 
            // labelb
            // 
            this.labelb.AutoSize = true;
            this.labelb.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelb.Location = new System.Drawing.Point(92, 87);
            this.labelb.Name = "labelb";
            this.labelb.Size = new System.Drawing.Size(20, 18);
            this.labelb.TabIndex = 7;
            this.labelb.Text = "b:";
            this.labelb.Click += new System.EventHandler(this.label3_Click);
            // 
            // bBox
            // 
            this.bBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBox.Location = new System.Drawing.Point(122, 84);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(82, 25);
            this.bBox.TabIndex = 6;
            this.bBox.TextChanged += new System.EventHandler(this.bBox_TextChanged);
            this.bBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bBox_KeyPress);
            // 
            // labela
            // 
            this.labela.AutoSize = true;
            this.labela.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labela.Location = new System.Drawing.Point(92, 56);
            this.labela.Name = "labela";
            this.labela.Size = new System.Drawing.Size(21, 18);
            this.labela.TabIndex = 5;
            this.labela.Text = "a:";
            // 
            // aBox
            // 
            this.aBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.aBox.Location = new System.Drawing.Point(122, 54);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(82, 25);
            this.aBox.TabIndex = 4;
            this.aBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.aBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aBox_KeyPress);
            // 
            // labelf
            // 
            this.labelf.AutoSize = true;
            this.labelf.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelf.Location = new System.Drawing.Point(92, 26);
            this.labelf.Name = "labelf";
            this.labelf.Size = new System.Drawing.Size(23, 18);
            this.labelf.TabIndex = 3;
            this.labelf.Text = "F:";
            this.labelf.Click += new System.EventHandler(this.label1_Click);
            // 
            // iterationButton
            // 
            this.iterationButton.Enabled = false;
            this.iterationButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iterationButton.Location = new System.Drawing.Point(317, 176);
            this.iterationButton.Margin = new System.Windows.Forms.Padding(1);
            this.iterationButton.Name = "iterationButton";
            this.iterationButton.Size = new System.Drawing.Size(32, 21);
            this.iterationButton.TabIndex = 2;
            this.iterationButton.Text = " ...";
            this.iterationButton.UseVisualStyleBackColor = true;
            this.iterationButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.Red;
            this.clearButton.Location = new System.Drawing.Point(12, 221);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 28);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Сброс";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelms);
            this.groupBox2.Controls.Add(this.ms);
            this.groupBox2.Controls.Add(this.labelfx);
            this.groupBox2.Controls.Add(this.fx1outBox);
            this.groupBox2.Controls.Add(this.labelkk);
            this.groupBox2.Controls.Add(this.iterationButton);
            this.groupBox2.Controls.Add(this.countinerBox);
            this.groupBox2.Controls.Add(this.labelabs);
            this.groupBox2.Controls.Add(this.outTolBox);
            this.groupBox2.Controls.Add(this.labelx);
            this.groupBox2.Controls.Add(this.x1uotFBox);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 213);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выходные данные";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelms
            // 
            this.labelms.AutoSize = true;
            this.labelms.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelms.Location = new System.Drawing.Point(31, 157);
            this.labelms.Name = "labelms";
            this.labelms.Size = new System.Drawing.Size(32, 18);
            this.labelms.TabIndex = 15;
            this.labelms.Text = "Ms:";
            // 
            // ms
            // 
            this.ms.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ms.Location = new System.Drawing.Point(67, 154);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(82, 25);
            this.ms.TabIndex = 14;
            // 
            // labelfx
            // 
            this.labelfx.AutoSize = true;
            this.labelfx.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelfx.Location = new System.Drawing.Point(12, 63);
            this.labelfx.Name = "labelfx";
            this.labelfx.Size = new System.Drawing.Size(51, 18);
            this.labelfx.TabIndex = 13;
            this.labelfx.Text = "F(X*):";
            this.labelfx.Click += new System.EventHandler(this.label8_Click);
            // 
            // fx1outBox
            // 
            this.fx1outBox.Enabled = false;
            this.fx1outBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fx1outBox.Location = new System.Drawing.Point(68, 60);
            this.fx1outBox.Name = "fx1outBox";
            this.fx1outBox.Size = new System.Drawing.Size(267, 25);
            this.fx1outBox.TabIndex = 12;
            // 
            // labelkk
            // 
            this.labelkk.AutoSize = true;
            this.labelkk.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelkk.Location = new System.Drawing.Point(40, 126);
            this.labelkk.Name = "labelkk";
            this.labelkk.Size = new System.Drawing.Size(23, 18);
            this.labelkk.TabIndex = 11;
            this.labelkk.Text = "K:";
            // 
            // countinerBox
            // 
            this.countinerBox.Enabled = false;
            this.countinerBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countinerBox.Location = new System.Drawing.Point(68, 123);
            this.countinerBox.Name = "countinerBox";
            this.countinerBox.Size = new System.Drawing.Size(82, 25);
            this.countinerBox.TabIndex = 10;
            this.countinerBox.TextChanged += new System.EventHandler(this.countinerBox_TextChanged);
            // 
            // labelabs
            // 
            this.labelabs.AutoSize = true;
            this.labelabs.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelabs.Location = new System.Drawing.Point(2, 95);
            this.labelabs.Name = "labelabs";
            this.labelabs.Size = new System.Drawing.Size(64, 18);
            this.labelabs.TabIndex = 9;
            this.labelabs.Text = "abs(b-a):";
            this.labelabs.Click += new System.EventHandler(this.label7_Click);
            // 
            // outTolBox
            // 
            this.outTolBox.Enabled = false;
            this.outTolBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outTolBox.Location = new System.Drawing.Point(68, 92);
            this.outTolBox.Name = "outTolBox";
            this.outTolBox.Size = new System.Drawing.Size(82, 25);
            this.outTolBox.TabIndex = 8;
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelx.Location = new System.Drawing.Point(35, 32);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(31, 18);
            this.labelx.TabIndex = 3;
            this.labelx.Text = "X*:";
            // 
            // x1uotFBox
            // 
            this.x1uotFBox.Enabled = false;
            this.x1uotFBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1uotFBox.Location = new System.Drawing.Point(67, 29);
            this.x1uotFBox.Name = "x1uotFBox";
            this.x1uotFBox.Size = new System.Drawing.Size(268, 25);
            this.x1uotFBox.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 256);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(353, 18);
            this.progressBar1.TabIndex = 6;
            this.progressBar1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelerr
            // 
            this.labelerr.AutoSize = true;
            this.labelerr.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelerr.ForeColor = System.Drawing.Color.Red;
            this.labelerr.Location = new System.Drawing.Point(33, 280);
            this.labelerr.Name = "labelerr";
            this.labelerr.Size = new System.Drawing.Size(0, 18);
            this.labelerr.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 560);
            this.Controls.Add(this.labelerr);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchButton);
            this.Name = "Main";
            this.Text = "Метод золотого сечения";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelk;
        private System.Windows.Forms.TextBox k_maxBox;
        private System.Windows.Forms.Label labelt;
        private System.Windows.Forms.TextBox tolBox;
        private System.Windows.Forms.Label labelb;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.Label labela;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.Label labelf;
        private System.Windows.Forms.Button iterationButton;
        private System.Windows.Forms.RadioButton maxRadio;
        private System.Windows.Forms.RadioButton MinRatio;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelkk;
        public System.Windows.Forms.TextBox countinerBox;
        private System.Windows.Forms.Label labelabs;
        public System.Windows.Forms.TextBox outTolBox;
        private System.Windows.Forms.Label labelx;
        public System.Windows.Forms.TextBox x1uotFBox;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        public int count;
        private System.Windows.Forms.Label labelfx;
        public System.Windows.Forms.TextBox fx1outBox;
        public System.Windows.Forms.TextBox ms;
        private System.Windows.Forms.Label labelms;
        private System.Windows.Forms.ComboBox comboBoxf;
        private System.Windows.Forms.Label labelerr;
    }
}

