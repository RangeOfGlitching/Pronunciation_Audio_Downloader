namespace Pronounciation
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.button_open_brownser = new System.Windows.Forms.Button();
            this.label_result = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.radioButton_us = new System.Windows.Forms.RadioButton();
            this.radioButton_uk = new System.Windows.Forms.RadioButton();
            this.groupBox_accent = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton_speed_slow = new System.Windows.Forms.RadioButton();
            this.radioButton_speed_normal = new System.Windows.Forms.RadioButton();
            this.progressBar_searching = new System.Windows.Forms.ProgressBar();
            this.button_open_dir = new System.Windows.Forms.Button();
            this.static_path = new System.Windows.Forms.Label();
            this.static_search = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel_creditor1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel_creditor2 = new System.Windows.Forms.LinkLabel();
            this.static_version = new System.Windows.Forms.Label();
            this.groupBox_accent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_path.Location = new System.Drawing.Point(91, 16);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.ReadOnly = true;
            this.textBox_path.Size = new System.Drawing.Size(238, 22);
            this.textBox_path.TabIndex = 0;
            // 
            // button_open_brownser
            // 
            this.button_open_brownser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_open_brownser.Location = new System.Drawing.Point(336, 15);
            this.button_open_brownser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_open_brownser.Name = "button_open_brownser";
            this.button_open_brownser.Size = new System.Drawing.Size(89, 25);
            this.button_open_brownser.TabIndex = 1;
            this.button_open_brownser.Text = "Choose Dir";
            this.button_open_brownser.UseVisualStyleBackColor = true;
            this.button_open_brownser.Click += new System.EventHandler(this.button_open_brownser_Click);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_result.Location = new System.Drawing.Point(14, 246);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(45, 16);
            this.label_result.TabIndex = 2;
            this.label_result.Text = "Ready";
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.Location = new System.Drawing.Point(91, 52);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(333, 22);
            this.textBox_search.TabIndex = 3;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.Location = new System.Drawing.Point(432, 51);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(87, 25);
            this.button_search.TabIndex = 4;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_play
            // 
            this.button_play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_play.Enabled = false;
            this.button_play.Location = new System.Drawing.Point(430, 239);
            this.button_play.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(87, 31);
            this.button_play.TabIndex = 9;
            this.button_play.Text = "Play";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // radioButton_us
            // 
            this.radioButton_us.AutoSize = true;
            this.radioButton_us.Checked = true;
            this.radioButton_us.Location = new System.Drawing.Point(42, 28);
            this.radioButton_us.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_us.Name = "radioButton_us";
            this.radioButton_us.Size = new System.Drawing.Size(75, 20);
            this.radioButton_us.TabIndex = 5;
            this.radioButton_us.TabStop = true;
            this.radioButton_us.Text = "the USA";
            this.radioButton_us.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radioButton_us.UseVisualStyleBackColor = true;
            // 
            // radioButton_uk
            // 
            this.radioButton_uk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_uk.AutoSize = true;
            this.radioButton_uk.Location = new System.Drawing.Point(338, 28);
            this.radioButton_uk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_uk.Name = "radioButton_uk";
            this.radioButton_uk.Size = new System.Drawing.Size(66, 20);
            this.radioButton_uk.TabIndex = 6;
            this.radioButton_uk.Text = "the UK";
            this.radioButton_uk.UseVisualStyleBackColor = true;
            // 
            // groupBox_accent
            // 
            this.groupBox_accent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_accent.Controls.Add(this.radioButton_uk);
            this.groupBox_accent.Controls.Add(this.radioButton_us);
            this.groupBox_accent.ForeColor = System.Drawing.Color.White;
            this.groupBox_accent.Location = new System.Drawing.Point(15, 84);
            this.groupBox_accent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_accent.Name = "groupBox_accent";
            this.groupBox_accent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox_accent.Size = new System.Drawing.Size(502, 68);
            this.groupBox_accent.TabIndex = 8;
            this.groupBox_accent.TabStop = false;
            this.groupBox_accent.Text = "Accent";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.radioButton_speed_slow);
            this.groupBox2.Controls.Add(this.radioButton_speed_normal);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(15, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(502, 71);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed";
            // 
            // radioButton_speed_slow
            // 
            this.radioButton_speed_slow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_speed_slow.AutoSize = true;
            this.radioButton_speed_slow.Location = new System.Drawing.Point(339, 28);
            this.radioButton_speed_slow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_speed_slow.Name = "radioButton_speed_slow";
            this.radioButton_speed_slow.Size = new System.Drawing.Size(54, 20);
            this.radioButton_speed_slow.TabIndex = 8;
            this.radioButton_speed_slow.Text = "Slow";
            this.radioButton_speed_slow.UseVisualStyleBackColor = true;
            // 
            // radioButton_speed_normal
            // 
            this.radioButton_speed_normal.AutoSize = true;
            this.radioButton_speed_normal.Checked = true;
            this.radioButton_speed_normal.Location = new System.Drawing.Point(42, 28);
            this.radioButton_speed_normal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton_speed_normal.Name = "radioButton_speed_normal";
            this.radioButton_speed_normal.Size = new System.Drawing.Size(67, 20);
            this.radioButton_speed_normal.TabIndex = 7;
            this.radioButton_speed_normal.TabStop = true;
            this.radioButton_speed_normal.Text = "Normal";
            this.radioButton_speed_normal.UseVisualStyleBackColor = true;
            // 
            // progressBar_searching
            // 
            this.progressBar_searching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_searching.Enabled = false;
            this.progressBar_searching.Location = new System.Drawing.Point(91, 239);
            this.progressBar_searching.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar_searching.MarqueeAnimationSpeed = 10;
            this.progressBar_searching.Name = "progressBar_searching";
            this.progressBar_searching.Size = new System.Drawing.Size(334, 31);
            this.progressBar_searching.Step = 5;
            this.progressBar_searching.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar_searching.TabIndex = 10;
            this.progressBar_searching.Visible = false;
            // 
            // button_open_dir
            // 
            this.button_open_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_open_dir.Location = new System.Drawing.Point(432, 15);
            this.button_open_dir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_open_dir.Name = "button_open_dir";
            this.button_open_dir.Size = new System.Drawing.Size(87, 25);
            this.button_open_dir.TabIndex = 2;
            this.button_open_dir.Text = "Open Dir";
            this.button_open_dir.UseVisualStyleBackColor = true;
            this.button_open_dir.Click += new System.EventHandler(this.button_open_dir_Click);
            // 
            // static_path
            // 
            this.static_path.AutoSize = true;
            this.static_path.ForeColor = System.Drawing.Color.White;
            this.static_path.Location = new System.Drawing.Point(12, 19);
            this.static_path.Name = "static_path";
            this.static_path.Size = new System.Drawing.Size(71, 16);
            this.static_path.TabIndex = 12;
            this.static_path.Text = "Save Path:";
            // 
            // static_search
            // 
            this.static_search.AutoSize = true;
            this.static_search.ForeColor = System.Drawing.Color.White;
            this.static_search.Location = new System.Drawing.Point(12, 55);
            this.static_search.Name = "static_search";
            this.static_search.Size = new System.Drawing.Size(53, 16);
            this.static_search.TabIndex = 13;
            this.static_search.Text = "Search:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(279, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "by";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(427, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "and";
            // 
            // linkLabel_creditor1
            // 
            this.linkLabel_creditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_creditor1.AutoSize = true;
            this.linkLabel_creditor1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_creditor1.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel_creditor1.Location = new System.Drawing.Point(307, 282);
            this.linkLabel_creditor1.Name = "linkLabel_creditor1";
            this.linkLabel_creditor1.Size = new System.Drawing.Size(114, 16);
            this.linkLabel_creditor1.TabIndex = 10;
            this.linkLabel_creditor1.TabStop = true;
            this.linkLabel_creditor1.Text = "Range of Glitching";
            this.linkLabel_creditor1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_creditor1_LinkClicked);
            // 
            // linkLabel_creditor2
            // 
            this.linkLabel_creditor2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel_creditor2.AutoSize = true;
            this.linkLabel_creditor2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_creditor2.LinkColor = System.Drawing.Color.Yellow;
            this.linkLabel_creditor2.Location = new System.Drawing.Point(462, 282);
            this.linkLabel_creditor2.Name = "linkLabel_creditor2";
            this.linkLabel_creditor2.Size = new System.Drawing.Size(57, 16);
            this.linkLabel_creditor2.TabIndex = 11;
            this.linkLabel_creditor2.TabStop = true;
            this.linkLabel_creditor2.Text = "Bill Tsou";
            this.linkLabel_creditor2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_creditor2_LinkClicked);
            // 
            // static_version
            // 
            this.static_version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.static_version.AutoSize = true;
            this.static_version.ForeColor = System.Drawing.Color.White;
            this.static_version.Location = new System.Drawing.Point(12, 282);
            this.static_version.Name = "static_version";
            this.static_version.Size = new System.Drawing.Size(123, 16);
            this.static_version.TabIndex = 18;
            this.static_version.Text = "Version: 2022/04/03";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(533, 307);
            this.Controls.Add(this.static_version);
            this.Controls.Add(this.linkLabel_creditor2);
            this.Controls.Add(this.linkLabel_creditor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.static_search);
            this.Controls.Add(this.static_path);
            this.Controls.Add(this.button_open_dir);
            this.Controls.Add(this.progressBar_searching);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox_accent);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.button_open_brownser);
            this.Controls.Add(this.textBox_path);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 346);
            this.MinimumSize = new System.Drawing.Size(431, 346);
            this.Name = "Form1";
            this.Text = "Pronunciation Audio Download";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_accent.ResumeLayout(false);
            this.groupBox_accent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Button button_open_brownser;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.RadioButton radioButton_us;
        private System.Windows.Forms.RadioButton radioButton_uk;
        private System.Windows.Forms.GroupBox groupBox_accent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_speed_slow;
        private System.Windows.Forms.RadioButton radioButton_speed_normal;
        private System.Windows.Forms.ProgressBar progressBar_searching;
        private System.Windows.Forms.Button button_open_dir;
        private System.Windows.Forms.Label static_path;
        private System.Windows.Forms.Label static_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel_creditor1;
        private System.Windows.Forms.LinkLabel linkLabel_creditor2;
        private System.Windows.Forms.Label static_version;
    }
}

