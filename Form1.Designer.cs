namespace Password_Generator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.charNum_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_browse_btn = new System.Windows.Forms.Button();
            this.genTxt_check = new System.Windows.Forms.CheckBox();
            this.onlyalfanum_check = new System.Windows.Forms.CheckBox();
            this.output_text = new System.Windows.Forms.TextBox();
            this.cpy_btn = new System.Windows.Forms.Button();
            this.history_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.gen_btn = new System.Windows.Forms.Button();
            this.txtPath_text = new System.Windows.Forms.TextBox();
            this.txtFileName_text = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // charNum_text
            // 
            this.charNum_text.Location = new System.Drawing.Point(12, 26);
            this.charNum_text.Multiline = true;
            this.charNum_text.Name = "charNum_text";
            this.charNum_text.Size = new System.Drawing.Size(47, 38);
            this.charNum_text.TabIndex = 0;
            this.charNum_text.TextChanged += new System.EventHandler(this.charNum_text_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lenght (characters)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFileName_text);
            this.groupBox1.Controls.Add(this.txtPath_text);
            this.groupBox1.Controls.Add(this.txt_browse_btn);
            this.groupBox1.Controls.Add(this.genTxt_check);
            this.groupBox1.Controls.Add(this.onlyalfanum_check);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 121);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // txt_browse_btn
            // 
            this.txt_browse_btn.ForeColor = System.Drawing.Color.Black;
            this.txt_browse_btn.Location = new System.Drawing.Point(461, 59);
            this.txt_browse_btn.Name = "txt_browse_btn";
            this.txt_browse_btn.Size = new System.Drawing.Size(94, 43);
            this.txt_browse_btn.TabIndex = 2;
            this.txt_browse_btn.Text = "Txt Path";
            this.txt_browse_btn.UseVisualStyleBackColor = true;
            this.txt_browse_btn.Click += new System.EventHandler(this.txt_browse_btn_Click);
            // 
            // genTxt_check
            // 
            this.genTxt_check.AutoSize = true;
            this.genTxt_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genTxt_check.Location = new System.Drawing.Point(6, 60);
            this.genTxt_check.Name = "genTxt_check";
            this.genTxt_check.Size = new System.Drawing.Size(152, 29);
            this.genTxt_check.TabIndex = 1;
            this.genTxt_check.Text = "Generate Txt";
            this.genTxt_check.UseVisualStyleBackColor = true;
            // 
            // onlyalfanum_check
            // 
            this.onlyalfanum_check.AutoSize = true;
            this.onlyalfanum_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlyalfanum_check.Location = new System.Drawing.Point(6, 25);
            this.onlyalfanum_check.Name = "onlyalfanum_check";
            this.onlyalfanum_check.Size = new System.Drawing.Size(322, 29);
            this.onlyalfanum_check.TabIndex = 0;
            this.onlyalfanum_check.Text = "Use only alfa-numeric characters";
            this.onlyalfanum_check.UseVisualStyleBackColor = true;
            // 
            // output_text
            // 
            this.output_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_text.Location = new System.Drawing.Point(18, 235);
            this.output_text.Name = "output_text";
            this.output_text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.output_text.Size = new System.Drawing.Size(612, 35);
            this.output_text.TabIndex = 3;
            // 
            // cpy_btn
            // 
            this.cpy_btn.Location = new System.Drawing.Point(653, 254);
            this.cpy_btn.Name = "cpy_btn";
            this.cpy_btn.Size = new System.Drawing.Size(96, 37);
            this.cpy_btn.TabIndex = 4;
            this.cpy_btn.Text = "Copy";
            this.cpy_btn.UseVisualStyleBackColor = true;
            this.cpy_btn.Click += new System.EventHandler(this.cpy_btn_Click);
            // 
            // history_text
            // 
            this.history_text.Location = new System.Drawing.Point(921, 13);
            this.history_text.Multiline = true;
            this.history_text.Name = "history_text";
            this.history_text.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.history_text.Size = new System.Drawing.Size(458, 234);
            this.history_text.TabIndex = 5;
            this.history_text.TextChanged += new System.EventHandler(this.history_text_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(780, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 38);
            this.label2.TabIndex = 6;
            this.label2.Text = "History";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(921, 254);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(90, 37);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // gen_btn
            // 
            this.gen_btn.Location = new System.Drawing.Point(653, 210);
            this.gen_btn.Name = "gen_btn";
            this.gen_btn.Size = new System.Drawing.Size(96, 37);
            this.gen_btn.TabIndex = 8;
            this.gen_btn.Text = "Generate";
            this.gen_btn.UseVisualStyleBackColor = true;
            this.gen_btn.Click += new System.EventHandler(this.gen_btn_Click);
            // 
            // txtPath_text
            // 
            this.txtPath_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPath_text.Location = new System.Drawing.Point(218, 60);
            this.txtPath_text.Name = "txtPath_text";
            this.txtPath_text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtPath_text.Size = new System.Drawing.Size(237, 35);
            this.txtPath_text.TabIndex = 3;
            // 
            // txtFileName_text
            // 
            this.txtFileName_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileName_text.Location = new System.Drawing.Point(576, 59);
            this.txtFileName_text.Name = "txtFileName_text";
            this.txtFileName_text.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFileName_text.Size = new System.Drawing.Size(288, 35);
            this.txtFileName_text.TabIndex = 4;
            this.txtFileName_text.Text = "passGen.txt";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(571, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Txt File name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1391, 303);
            this.Controls.Add(this.gen_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.history_text);
            this.Controls.Add(this.cpy_btn);
            this.Controls.Add(this.output_text);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charNum_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RealCom Password Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox charNum_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txt_browse_btn;
        private System.Windows.Forms.CheckBox genTxt_check;
        private System.Windows.Forms.CheckBox onlyalfanum_check;
        private System.Windows.Forms.TextBox output_text;
        private System.Windows.Forms.Button cpy_btn;
        private System.Windows.Forms.TextBox history_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button gen_btn;
        private System.Windows.Forms.TextBox txtPath_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFileName_text;
    }
}

