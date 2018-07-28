namespace Kapital_bank.forms
{
    partial class Worker_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.work_name = new System.Windows.Forms.TextBox();
            this.work_sname = new System.Windows.Forms.TextBox();
            this.vesiqe_no = new System.Windows.Forms.TextBox();
            this.positions = new System.Windows.Forms.ComboBox();
            this.work_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adinizi daxil edin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadinizi daxil edin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vesiqe nomrenizi daxil edin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vezifenizi secin:";
            // 
            // work_name
            // 
            this.work_name.Location = new System.Drawing.Point(286, 94);
            this.work_name.Name = "work_name";
            this.work_name.Size = new System.Drawing.Size(316, 26);
            this.work_name.TabIndex = 4;
            // 
            // work_sname
            // 
            this.work_sname.Location = new System.Drawing.Point(286, 148);
            this.work_sname.Name = "work_sname";
            this.work_sname.Size = new System.Drawing.Size(316, 26);
            this.work_sname.TabIndex = 5;
            // 
            // vesiqe_no
            // 
            this.vesiqe_no.Location = new System.Drawing.Point(286, 210);
            this.vesiqe_no.Name = "vesiqe_no";
            this.vesiqe_no.Size = new System.Drawing.Size(316, 26);
            this.vesiqe_no.TabIndex = 6;
            // 
            // positions
            // 
            this.positions.FormattingEnabled = true;
            this.positions.Items.AddRange(new object[] {
            " stajor",
            " mutexessis,",
            " aparici_mutexessis",
            " boyuk_mutexessis",
            " bolme_mudiri",
            " shobe_mudiri"});
            this.positions.Location = new System.Drawing.Point(286, 273);
            this.positions.Name = "positions";
            this.positions.Size = new System.Drawing.Size(316, 28);
            this.positions.TabIndex = 7;
            // 
            // work_login
            // 
            this.work_login.Location = new System.Drawing.Point(780, 482);
            this.work_login.Name = "work_login";
            this.work_login.Size = new System.Drawing.Size(126, 55);
            this.work_login.TabIndex = 8;
            this.work_login.Text = "Log in";
            this.work_login.UseVisualStyleBackColor = true;
            this.work_login.Click += new System.EventHandler(this.work_login_Click);
            // 
            // Worker_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 434);
            this.Controls.Add(this.work_login);
            this.Controls.Add(this.positions);
            this.Controls.Add(this.vesiqe_no);
            this.Controls.Add(this.work_sname);
            this.Controls.Add(this.work_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Worker_Login";
            this.Text = "Worker_Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox work_name;
        private System.Windows.Forms.TextBox work_sname;
        private System.Windows.Forms.TextBox vesiqe_no;
        private System.Windows.Forms.ComboBox positions;
        public System.Windows.Forms.Button work_login;
    }
}