using System.Security.Policy;
using FindMailWin;

namespace FindMailWin
{
    public partial class FindMail : Form
    {
        public FindMail()
        {
            InitializeComponent();
        }

        private void FindMailForm_Load(object sender, EventArgs e)
        {

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //Check if URL is valid
            SourceUrl.Text = Grabber.CheckUrl(SourceUrl.Text);
            //Url = SourceUrl.StringValue;

            //is URL valid?
            if (SourceUrl.Text.Equals("invalid"))
            {
                ResultBox.Text = "Invalid URL provided. Please try another URL.";
            }
            else
            {
                //Extract Emails
                //ResultBox.StringValue = Grabber.ExtractEmails(Url);
                ResultBox.Text = Grabber.ExtractEmails(SourceUrl.Text);
            }
        }
    }
}