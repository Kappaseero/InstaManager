using InstagramPrivateAPI.Enums;


namespace InstaManagerUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AccountPageLoad(this);
        }
        
        private async void signInButton_Click(object sender, EventArgs e)
        {
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;
            lblAccountInfo.Text = "Trying to sign in. Wait.";

            Program.InstaMain = new InstagramPrivateAPI.InstaMain(Program.QuizSettings, Program.Client, username, password);

            //result does nothing now since all info comes from
            //Program.InstaMain.AccountActions but it might be useful in the future
            var result = await Program.InstaMain.AccountActions.TryLogInAsync();
            AccountPageLoad(this);

            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcMainTabControl.SelectedTab == tbAccountPage)
            { AccountPageLoad(this); }

            else if (tbcMainTabControl.SelectedTab == tbQuizPage)
            {  }
        }

        public void AccountPageLoad(MainForm form)
        {
            //disable all enable after
            SetPhoneVisibility(form, false);
            SetSignInVisibility(form, false);
            SetVerificationVisibility(form, false);


            //if not signed in
            if (Program.InstaMain == null)
            {
                SetSignInVisibility(form, true);
                form.lblNotSignedIn.Visible = true;
                form.lblSignedIn.Visible = false;
            }
            
            //challenged
            else if(Program.InstaMain.AccountActions.Challenged)
            {
                
                form.lblNotSignedIn.Visible = true;
                form.lblSignedIn.Visible = false;
                switch (Program.InstaMain.AccountActions.ChallengeType)
                {
                    case ChallengeEnum.TxtMessage:
                        form.lblAccountInfo.Text = "You have been challenged. Check your text messages.";
                        SetVerificationVisibility(form, true);
                        return;
                    case ChallengeEnum.Email:
                        form.lblAccountInfo.Text = "You have been challenged. Check your email. Press \"Send Code\" to resend one. ";
                        SetVerificationVisibility(form, true);
                        return;
                    case ChallengeEnum.PhoneNumber:
                        form.lblAccountInfo.Text = "You have been challenged. Submit your phone number.";
                        SetPhoneVisibility(form, true);
                        return;
                }
            }

            //signed in
            else if(Program.InstaMain.AccountActions.IsLoggedIn)
            {
                form.lblAccountInfo.Text = "You are logged in.";
                SetSignInVisibility(form, false);
                form.lblSignedIn.Visible = true;
                form.lblNotSignedIn.Visible = false;
            }

            //wrong credentials
            else
            {
                form.lblAccountInfo.Text = "Wrong credentials or something similar.";
                form.lblNotSignedIn.Visible = true;
                form.lblSignedIn.Visible = false;
                SetSignInVisibility(form, true);
            }



        }

        public void QuizPageLoad(MainForm form)
        {
            //is null or not logged in
            if (Program.InstaMain == null || !Program.InstaMain.AccountActions.IsLoggedIn)
            {

            }
            //logged in
            else if(Program.InstaMain.AccountActions.IsLoggedIn)
            {

            }
            //dont know what situation this would be but just in case.
            //InstaMain might not be null but IsLoggedIn might
            else
            {

            }
        }

        private void SetSignInVisibility(MainForm form, bool state)
        {
            if (state)
            {
                form.lblUsername.Visible = true;
                form.lblPassword.Visible = true;
                form.txtboxUsername.Visible = true;
                form.txtboxPassword.Visible = true;
                form.btnSignInButton.Visible = true;
            }
            else
            {
                form.lblUsername.Visible = false;
                form.lblPassword.Visible = false;
                form.txtboxUsername.Visible = false;
                form.txtboxPassword.Visible = false;
                form.btnSignInButton.Visible = false;
            }
        }

        private void SetPhoneVisibility(MainForm form, bool state)
        {
            if (state)
            {
                form.btnPhoneNumberSubmitButton.Visible = true;
                form.txtboxPhoneNumber.Visible = true;
                form.lblPhoneNumber.Visible = true;
            }
            else
            {
                form.btnPhoneNumberSubmitButton.Visible = false;
                form.txtboxPhoneNumber.Visible = false;
                form.lblPhoneNumber.Visible = false;
            }
        }

        private void SetVerificationVisibility(MainForm form, bool state)
        {
            if (state)
            {
                form.btnVerificationCodeSubmitButton.Visible = true;
                form.txtboxVerificationCode.Visible = true;
                form.lblVerificationCode.Visible = true;
                form.btnVerificationCodeResend.Visible = true;
            }
            else
            {
                form.btnVerificationCodeSubmitButton.Visible = false;
                form.txtboxVerificationCode.Visible = false;
                form.lblVerificationCode.Visible = false;
                form.btnVerificationCodeResend.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnOpenTDBQuizPost_Click(object sender, EventArgs e)
        {
            var success = await Program.InstaMain.Quiz.PostUnguessedAsync();
            if (success)
            {
                lblQuizInfo.Text = "OpenTDBQuiz posted successfully.";
            }
            else
            {
                lblQuizInfo.Text = "Could not post a OpenTDB quiz.";
            }
        }

        private async void btnVerificationCodeResend_Click(object sender, EventArgs e)
        {
            await Program.InstaMain.instaApi.RequestVerifyCodeToEmailForChallengeRequireAsync();
        }
    }
}