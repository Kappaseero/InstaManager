namespace InstaManagerUI
{
    partial class MainForm
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
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblVerificationCode = new System.Windows.Forms.Label();
            this.tbcMainTabControl = new System.Windows.Forms.TabControl();
            this.tbAccountPage = new System.Windows.Forms.TabPage();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.txtboxVerificationCode = new System.Windows.Forms.TextBox();
            this.btnVerificationCodeSubmitButton = new System.Windows.Forms.Button();
            this.txtboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPhoneNumberSubmitButton = new System.Windows.Forms.Button();
            this.lblSignedIn = new System.Windows.Forms.Label();
            this.lblNotSignedIn = new System.Windows.Forms.Label();
            this.txtboxPassword = new System.Windows.Forms.TextBox();
            this.txtboxUsername = new System.Windows.Forms.TextBox();
            this.btnSignInButton = new System.Windows.Forms.Button();
            this.tbQuizPage = new System.Windows.Forms.TabPage();
            this.gbxOpenTDB = new System.Windows.Forms.GroupBox();
            this.btnOpenTDBQuizPost = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblQuizInfo = new System.Windows.Forms.Label();
            this.btnVerificationCodeResend = new System.Windows.Forms.Button();
            this.tbcMainTabControl.SuspendLayout();
            this.tbAccountPage.SuspendLayout();
            this.tbQuizPage.SuspendLayout();
            this.gbxOpenTDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(22, 248);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(22, 182);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(248, 248);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(193, 15);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone number (with country code)";
            // 
            // lblVerificationCode
            // 
            this.lblVerificationCode.AutoSize = true;
            this.lblVerificationCode.Location = new System.Drawing.Point(475, 248);
            this.lblVerificationCode.Name = "lblVerificationCode";
            this.lblVerificationCode.Size = new System.Drawing.Size(95, 15);
            this.lblVerificationCode.TabIndex = 12;
            this.lblVerificationCode.Text = "Verification code";
            // 
            // tbcMainTabControl
            // 
            this.tbcMainTabControl.Controls.Add(this.tbAccountPage);
            this.tbcMainTabControl.Controls.Add(this.tbQuizPage);
            this.tbcMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcMainTabControl.Location = new System.Drawing.Point(0, 0);
            this.tbcMainTabControl.Name = "tbcMainTabControl";
            this.tbcMainTabControl.SelectedIndex = 0;
            this.tbcMainTabControl.Size = new System.Drawing.Size(691, 398);
            this.tbcMainTabControl.TabIndex = 0;
            this.tbcMainTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tbAccountPage
            // 
            this.tbAccountPage.Controls.Add(this.btnVerificationCodeResend);
            this.tbAccountPage.Controls.Add(this.lblAccountInfo);
            this.tbAccountPage.Controls.Add(this.lblVerificationCode);
            this.tbAccountPage.Controls.Add(this.txtboxVerificationCode);
            this.tbAccountPage.Controls.Add(this.btnVerificationCodeSubmitButton);
            this.tbAccountPage.Controls.Add(this.lblPhoneNumber);
            this.tbAccountPage.Controls.Add(this.txtboxPhoneNumber);
            this.tbAccountPage.Controls.Add(this.btnPhoneNumberSubmitButton);
            this.tbAccountPage.Controls.Add(this.lblSignedIn);
            this.tbAccountPage.Controls.Add(this.lblNotSignedIn);
            this.tbAccountPage.Controls.Add(this.lblPassword);
            this.tbAccountPage.Controls.Add(this.lblUsername);
            this.tbAccountPage.Controls.Add(this.txtboxPassword);
            this.tbAccountPage.Controls.Add(this.txtboxUsername);
            this.tbAccountPage.Controls.Add(this.btnSignInButton);
            this.tbAccountPage.Location = new System.Drawing.Point(4, 24);
            this.tbAccountPage.Name = "tbAccountPage";
            this.tbAccountPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbAccountPage.Size = new System.Drawing.Size(683, 370);
            this.tbAccountPage.TabIndex = 0;
            this.tbAccountPage.Text = "Account";
            this.tbAccountPage.UseVisualStyleBackColor = true;
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Location = new System.Drawing.Point(341, 24);
            this.lblAccountInfo.MaximumSize = new System.Drawing.Size(200, 150);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(43, 15);
            this.lblAccountInfo.TabIndex = 13;
            this.lblAccountInfo.Text = "Sign in";
            // 
            // txtboxVerificationCode
            // 
            this.txtboxVerificationCode.Location = new System.Drawing.Point(475, 266);
            this.txtboxVerificationCode.Name = "txtboxVerificationCode";
            this.txtboxVerificationCode.Size = new System.Drawing.Size(187, 23);
            this.txtboxVerificationCode.TabIndex = 11;
            // 
            // btnVerificationCodeSubmitButton
            // 
            this.btnVerificationCodeSubmitButton.Location = new System.Drawing.Point(531, 308);
            this.btnVerificationCodeSubmitButton.Name = "btnVerificationCodeSubmitButton";
            this.btnVerificationCodeSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.btnVerificationCodeSubmitButton.TabIndex = 10;
            this.btnVerificationCodeSubmitButton.Text = "Submit";
            this.btnVerificationCodeSubmitButton.UseVisualStyleBackColor = true;
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(248, 266);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(187, 23);
            this.txtboxPhoneNumber.TabIndex = 8;
            // 
            // btnPhoneNumberSubmitButton
            // 
            this.btnPhoneNumberSubmitButton.Location = new System.Drawing.Point(304, 308);
            this.btnPhoneNumberSubmitButton.Name = "btnPhoneNumberSubmitButton";
            this.btnPhoneNumberSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.btnPhoneNumberSubmitButton.TabIndex = 7;
            this.btnPhoneNumberSubmitButton.Text = "Submit";
            this.btnPhoneNumberSubmitButton.UseVisualStyleBackColor = true;
            // 
            // lblSignedIn
            // 
            this.lblSignedIn.AutoSize = true;
            this.lblSignedIn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSignedIn.ForeColor = System.Drawing.Color.Green;
            this.lblSignedIn.Location = new System.Drawing.Point(22, 24);
            this.lblSignedIn.Name = "lblSignedIn";
            this.lblSignedIn.Size = new System.Drawing.Size(122, 32);
            this.lblSignedIn.TabIndex = 6;
            this.lblSignedIn.Text = "Signed in";
            this.lblSignedIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNotSignedIn
            // 
            this.lblNotSignedIn.AutoSize = true;
            this.lblNotSignedIn.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotSignedIn.ForeColor = System.Drawing.Color.Red;
            this.lblNotSignedIn.Location = new System.Drawing.Point(22, 56);
            this.lblNotSignedIn.Name = "lblNotSignedIn";
            this.lblNotSignedIn.Size = new System.Drawing.Size(171, 32);
            this.lblNotSignedIn.TabIndex = 5;
            this.lblNotSignedIn.Text = "Not signed in";
            this.lblNotSignedIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.Location = new System.Drawing.Point(22, 266);
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.Size = new System.Drawing.Size(187, 23);
            this.txtboxPassword.TabIndex = 2;
            // 
            // txtboxUsername
            // 
            this.txtboxUsername.Location = new System.Drawing.Point(22, 200);
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.Size = new System.Drawing.Size(187, 23);
            this.txtboxUsername.TabIndex = 1;
            // 
            // btnSignInButton
            // 
            this.btnSignInButton.Location = new System.Drawing.Point(78, 308);
            this.btnSignInButton.Name = "btnSignInButton";
            this.btnSignInButton.Size = new System.Drawing.Size(75, 23);
            this.btnSignInButton.TabIndex = 0;
            this.btnSignInButton.Text = "Sign in";
            this.btnSignInButton.UseVisualStyleBackColor = true;
            this.btnSignInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // tbQuizPage
            // 
            this.tbQuizPage.Controls.Add(this.gbxOpenTDB);
            this.tbQuizPage.Controls.Add(this.lblQuizInfo);
            this.tbQuizPage.Location = new System.Drawing.Point(4, 24);
            this.tbQuizPage.Name = "tbQuizPage";
            this.tbQuizPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbQuizPage.Size = new System.Drawing.Size(683, 370);
            this.tbQuizPage.TabIndex = 1;
            this.tbQuizPage.Text = "Quiz";
            this.tbQuizPage.UseVisualStyleBackColor = true;
            // 
            // gbxOpenTDB
            // 
            this.gbxOpenTDB.Controls.Add(this.btnOpenTDBQuizPost);
            this.gbxOpenTDB.Controls.Add(this.button3);
            this.gbxOpenTDB.Controls.Add(this.button2);
            this.gbxOpenTDB.Location = new System.Drawing.Point(22, 24);
            this.gbxOpenTDB.Name = "gbxOpenTDB";
            this.gbxOpenTDB.Size = new System.Drawing.Size(152, 118);
            this.gbxOpenTDB.TabIndex = 4;
            this.gbxOpenTDB.TabStop = false;
            this.gbxOpenTDB.Text = "OpenTDB";
            // 
            // btnOpenTDBQuizPost
            // 
            this.btnOpenTDBQuizPost.Location = new System.Drawing.Point(6, 22);
            this.btnOpenTDBQuizPost.Name = "btnOpenTDBQuizPost";
            this.btnOpenTDBQuizPost.Size = new System.Drawing.Size(138, 23);
            this.btnOpenTDBQuizPost.TabIndex = 1;
            this.btnOpenTDBQuizPost.Text = "Post OpenTDB quiz";
            this.btnOpenTDBQuizPost.UseVisualStyleBackColor = true;
            this.btnOpenTDBQuizPost.Click += new System.EventHandler(this.btnOpenTDBQuizPost_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 80);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblQuizInfo
            // 
            this.lblQuizInfo.AutoSize = true;
            this.lblQuizInfo.Location = new System.Drawing.Point(526, 24);
            this.lblQuizInfo.Name = "lblQuizInfo";
            this.lblQuizInfo.Size = new System.Drawing.Size(92, 15);
            this.lblQuizInfo.TabIndex = 0;
            this.lblQuizInfo.Text = "Pick your action";
            // 
            // btnVerificationCodeResend
            // 
            this.btnVerificationCodeResend.Location = new System.Drawing.Point(531, 337);
            this.btnVerificationCodeResend.Name = "btnVerificationCodeResend";
            this.btnVerificationCodeResend.Size = new System.Drawing.Size(75, 23);
            this.btnVerificationCodeResend.TabIndex = 14;
            this.btnVerificationCodeResend.Text = "Send code";
            this.btnVerificationCodeResend.UseVisualStyleBackColor = true;
            this.btnVerificationCodeResend.Click += new System.EventHandler(this.btnVerificationCodeResend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 398);
            this.Controls.Add(this.tbcMainTabControl);
            this.Name = "MainForm";
            this.Text = "Instagram Manager WFUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcMainTabControl.ResumeLayout(false);
            this.tbAccountPage.ResumeLayout(false);
            this.tbAccountPage.PerformLayout();
            this.tbQuizPage.ResumeLayout(false);
            this.tbQuizPage.PerformLayout();
            this.gbxOpenTDB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tbcMainTabControl;
        private TabPage tbAccountPage;
        private TabPage tbQuizPage;
        private Label lblNotSignedIn;
        private Label lblPassword;
        private Label lblUsername;
        private TextBox txtboxPassword;
        private TextBox txtboxUsername;
        private Button btnSignInButton;
        private Label lblSignedIn;
        private Label lblAccountInfo;
        private TextBox txtboxVerificationCode;
        private Button btnVerificationCodeSubmitButton;
        private TextBox txtboxPhoneNumber;
        private Button btnPhoneNumberSubmitButton;
        private Label lblPhoneNumber;
        private Label lblVerificationCode;
        private Label lblQuizInfo;
        private Button button3;
        private Button button2;
        private Button btnOpenTDBQuizPost;
        private GroupBox gbxOpenTDB;
        private Button btnVerificationCodeResend;
    }
}