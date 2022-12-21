using InstagramPrivateAPI.Enums;


namespace InstaManagerUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string username = usernameValueBox.Text;
            string password = passwordValueBox.Text;

            Program.InstaMain = new InstagramPrivateAPI.InstaMain(Program.Quiz, username, password);
            var result = Program.InstaMain.LogInAsync().Result;

            if(result == LoginEnum.Success)
            {

            }
            else if(result == LoginEnum.EmailChallenged)
            {

            }
            else if(result != LoginEnum.Unsuccessful)
            {

            }
            else
            {

            }
            
        }
    }
}