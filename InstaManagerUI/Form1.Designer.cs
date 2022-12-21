namespace InstaManagerUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.accountPage = new System.Windows.Forms.TabPage();
            this.notSignedLabel = new System.Windows.Forms.Label();
            this.passwordValueBox = new System.Windows.Forms.TextBox();
            this.usernameValueBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.quizPage = new System.Windows.Forms.TabPage();
            this.signedLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.accountPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(22, 248);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 15);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(22, 182);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(60, 15);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.accountPage);
            this.tabControl1.Controls.Add(this.quizPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(691, 398);
            this.tabControl1.TabIndex = 0;
            // 
            // accountPage
            // 
            this.accountPage.Controls.Add(this.infoLabel);
            this.accountPage.Controls.Add(label2);
            this.accountPage.Controls.Add(this.textBox2);
            this.accountPage.Controls.Add(this.button2);
            this.accountPage.Controls.Add(label1);
            this.accountPage.Controls.Add(this.textBox1);
            this.accountPage.Controls.Add(this.button1);
            this.accountPage.Controls.Add(this.signedLabel);
            this.accountPage.Controls.Add(this.notSignedLabel);
            this.accountPage.Controls.Add(passwordLabel);
            this.accountPage.Controls.Add(usernameLabel);
            this.accountPage.Controls.Add(this.passwordValueBox);
            this.accountPage.Controls.Add(this.usernameValueBox);
            this.accountPage.Controls.Add(this.signInButton);
            this.accountPage.Location = new System.Drawing.Point(4, 24);
            this.accountPage.Name = "accountPage";
            this.accountPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountPage.Size = new System.Drawing.Size(683, 370);
            this.accountPage.TabIndex = 0;
            this.accountPage.Text = "Account";
            this.accountPage.UseVisualStyleBackColor = true;
            // 
            // notSignedLabel
            // 
            this.notSignedLabel.AutoSize = true;
            this.notSignedLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.notSignedLabel.ForeColor = System.Drawing.Color.Red;
            this.notSignedLabel.Location = new System.Drawing.Point(22, 56);
            this.notSignedLabel.Name = "notSignedLabel";
            this.notSignedLabel.Size = new System.Drawing.Size(171, 32);
            this.notSignedLabel.TabIndex = 5;
            this.notSignedLabel.Text = "Not signed in";
            this.notSignedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordValueBox
            // 
            this.passwordValueBox.Location = new System.Drawing.Point(22, 266);
            this.passwordValueBox.Name = "passwordValueBox";
            this.passwordValueBox.Size = new System.Drawing.Size(187, 23);
            this.passwordValueBox.TabIndex = 2;
            // 
            // usernameValueBox
            // 
            this.usernameValueBox.Location = new System.Drawing.Point(22, 200);
            this.usernameValueBox.Name = "usernameValueBox";
            this.usernameValueBox.Size = new System.Drawing.Size(187, 23);
            this.usernameValueBox.TabIndex = 1;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(78, 308);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // quizPage
            // 
            this.quizPage.Location = new System.Drawing.Point(4, 24);
            this.quizPage.Name = "quizPage";
            this.quizPage.Padding = new System.Windows.Forms.Padding(3);
            this.quizPage.Size = new System.Drawing.Size(683, 370);
            this.quizPage.TabIndex = 1;
            this.quizPage.Text = "Quiz";
            this.quizPage.UseVisualStyleBackColor = true;
            // 
            // signedLabel
            // 
            this.signedLabel.AutoSize = true;
            this.signedLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signedLabel.ForeColor = System.Drawing.Color.Green;
            this.signedLabel.Location = new System.Drawing.Point(22, 24);
            this.signedLabel.Name = "signedLabel";
            this.signedLabel.Size = new System.Drawing.Size(122, 32);
            this.signedLabel.TabIndex = 6;
            this.signedLabel.Text = "Signed in";
            this.signedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(248, 248);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(193, 15);
            label1.TabIndex = 9;
            label1.Text = "Phone number (with country code)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(475, 248);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(95, 15);
            label2.TabIndex = 12;
            label2.Text = "Verification code";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(475, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 23);
            this.textBox2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(531, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(341, 24);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(43, 15);
            this.infoLabel.TabIndex = 13;
            this.infoLabel.Text = "Sign in";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 398);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.accountPage.ResumeLayout(false);
            this.accountPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage accountPage;
        private TabPage quizPage;
        private Label notSignedLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordValueBox;
        private TextBox usernameValueBox;
        private Button signInButton;
        private Label signedLabel;
        private Label infoLabel;
        private TextBox textBox2;
        private Button button2;
        private TextBox textBox1;
        private Button button1;
    }
}