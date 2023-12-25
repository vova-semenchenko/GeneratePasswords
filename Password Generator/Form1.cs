using System;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        private double timeInSeconds = 300;
        private TimeSpan time;
        private string text;
        private int inCorrectPasswordCount;
        private PasswordGenerator passwordGenerator;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time = TimeSpan.FromSeconds(timeInSeconds);
            text = timerTime.Text;
            passwordLength.SelectedIndex = 0;
            timer2.Start();
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            passwordGenerator = new PasswordGenerator((PasswordSize)Enum.Parse(typeof(PasswordSize), passwordLength.SelectedItem.ToString()));

            generatedPasswordTextBox.Text = passwordGenerator.Password.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            if (time.TotalMilliseconds == 0)
            {
                comparePasswordTextBox.Enabled = true;
                comparePasswords.Enabled = true;
                time = TimeSpan.FromSeconds(timeInSeconds);
                text = "Time left for password entry:  ";     
                timer1.Stop();
                timer2.Start();
            }
            Timer();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1000;
            if (time.TotalMilliseconds == 0)
            {
                CheckToDisableElemnents();
            }
            Timer();
        }

        private void Timer()
        {
            time = time.Subtract(TimeSpan.FromSeconds(1));
            timerTime.Text = text + time.ToString("mm\\:ss");
        }

        private void comparePasswords_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comparePasswordTextBox.Text))
            {
                Password password = new Password();
                password.AppendString(comparePasswordTextBox.Text);

                if (passwordGenerator.Password.Equals(password))
                {
                    MessageBox.Show("Password is correct!");
                }
                else
                {
                    MessageBox.Show("Password seems to be inccorect! Please, check your password and try again.");
                    inCorrectPasswordCount++;
                }
            }

            if (inCorrectPasswordCount > 3)
            {
                CheckToDisableElemnents();
            }
        }

        private void copyBUtton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(generatedPasswordTextBox.Text))
            {
                Clipboard.SetText(generatedPasswordTextBox.Text);
                MessageBox.Show("Password copied!");
            }
        }

        private void passwordLength_SelectedIndexChanged(object sender, EventArgs e)
        {
            generatedPasswordTextBox.Text = "";
            comparePasswordTextBox.Text = "";
        }

        private void CheckToDisableElemnents()
        {            
            comparePasswordTextBox.Enabled = false;
            comparePasswords.Enabled = false;
            time = TimeSpan.FromSeconds(timeInSeconds);
            text = "You need to wait to enter a password again:  ";
            comparePasswordTextBox.Text = "";
            timer2.Stop();
            timer1.Start();
        }
    }
}
