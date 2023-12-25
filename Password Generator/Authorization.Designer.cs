namespace Password_Generator
{
    partial class Authorization
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
            this.components = new System.ComponentModel.Container();
            this.passwordLength = new System.Windows.Forms.ComboBox();
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.generateGroupBox = new System.Windows.Forms.GroupBox();
            this.generatedPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.copyBUtton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerTime = new System.Windows.Forms.Label();
            this.comparePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comparePasswords = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.generateGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLength
            // 
            this.passwordLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLength.FormattingEnabled = true;
            this.passwordLength.Items.AddRange(new object[] {
            "8",
            "12",
            "24",
            "32",
            "48"});
            this.passwordLength.Location = new System.Drawing.Point(278, 45);
            this.passwordLength.Name = "passwordLength";
            this.passwordLength.Size = new System.Drawing.Size(75, 33);
            this.passwordLength.TabIndex = 0;
            this.passwordLength.SelectedIndexChanged += new System.EventHandler(this.passwordLength_SelectedIndexChanged);
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.BackColor = System.Drawing.Color.LimeGreen;
            this.generatePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generatePasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatePasswordButton.ForeColor = System.Drawing.Color.White;
            this.generatePasswordButton.Location = new System.Drawing.Point(382, 45);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(167, 33);
            this.generatePasswordButton.TabIndex = 1;
            this.generatePasswordButton.Text = "Generate";
            this.generatePasswordButton.UseVisualStyleBackColor = false;
            this.generatePasswordButton.Click += new System.EventHandler(this.generatePasswordButton_Click);
            // 
            // generateGroupBox
            // 
            this.generateGroupBox.Controls.Add(this.generatedPasswordTextBox);
            this.generateGroupBox.Controls.Add(this.label1);
            this.generateGroupBox.Controls.Add(this.copyBUtton);
            this.generateGroupBox.Controls.Add(this.passwordLength);
            this.generateGroupBox.Controls.Add(this.generatePasswordButton);
            this.generateGroupBox.Location = new System.Drawing.Point(30, 28);
            this.generateGroupBox.Name = "generateGroupBox";
            this.generateGroupBox.Size = new System.Drawing.Size(927, 161);
            this.generateGroupBox.TabIndex = 2;
            this.generateGroupBox.TabStop = false;
            this.generateGroupBox.Text = "Generate Password";
            // 
            // generatedPasswordTextBox
            // 
            this.generatedPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.generatedPasswordTextBox.Location = new System.Drawing.Point(21, 103);
            this.generatedPasswordTextBox.Name = "generatedPasswordTextBox";
            this.generatedPasswordTextBox.ReadOnly = true;
            this.generatedPasswordTextBox.Size = new System.Drawing.Size(733, 34);
            this.generatedPasswordTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Password Length:";
            // 
            // copyBUtton
            // 
            this.copyBUtton.BackColor = System.Drawing.SystemColors.Control;
            this.copyBUtton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyBUtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copyBUtton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.copyBUtton.Location = new System.Drawing.Point(776, 99);
            this.copyBUtton.Name = "copyBUtton";
            this.copyBUtton.Size = new System.Drawing.Size(101, 33);
            this.copyBUtton.TabIndex = 1;
            this.copyBUtton.Text = "Copy";
            this.copyBUtton.UseVisualStyleBackColor = false;
            this.copyBUtton.Click += new System.EventHandler(this.copyBUtton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.timerTime);
            this.groupBox1.Controls.Add(this.comparePasswordTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comparePasswords);
            this.groupBox1.Location = new System.Drawing.Point(30, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Check Passwords";
            // 
            // timerTime
            // 
            this.timerTime.AutoSize = true;
            this.timerTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerTime.Location = new System.Drawing.Point(219, 143);
            this.timerTime.Name = "timerTime";
            this.timerTime.Size = new System.Drawing.Size(266, 25);
            this.timerTime.TabIndex = 4;
            this.timerTime.Text = "Time left for password entry:  ";
            // 
            // comparePasswordTextBox
            // 
            this.comparePasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comparePasswordTextBox.Location = new System.Drawing.Point(21, 88);
            this.comparePasswordTextBox.Name = "comparePasswordTextBox";
            this.comparePasswordTextBox.Size = new System.Drawing.Size(875, 34);
            this.comparePasswordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Your Password";
            // 
            // comparePasswords
            // 
            this.comparePasswords.BackColor = System.Drawing.Color.LimeGreen;
            this.comparePasswords.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comparePasswords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comparePasswords.ForeColor = System.Drawing.Color.White;
            this.comparePasswords.Location = new System.Drawing.Point(21, 135);
            this.comparePasswords.Name = "comparePasswords";
            this.comparePasswords.Size = new System.Drawing.Size(167, 33);
            this.comparePasswords.TabIndex = 1;
            this.comparePasswords.Text = "Enter";
            this.comparePasswords.UseVisualStyleBackColor = false;
            this.comparePasswords.Click += new System.EventHandler(this.comparePasswords_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.generateGroupBox);
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.generateGroupBox.ResumeLayout(false);
            this.generateGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox passwordLength;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.GroupBox generateGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox generatedPasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox comparePasswordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button comparePasswords;
        private System.Windows.Forms.Button copyBUtton;
        private System.Windows.Forms.Label timerTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

