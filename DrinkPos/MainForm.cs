namespace DrinkPos
{
    public partial class MainForm : Form
    {
        private Form activeForm = null;
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LoginForm());
        }

        private void saleBtn_Click(object sender, EventArgs e)
        {
            if(CheckLogin())
            {
                OpenChildForm(new SaleForm());
            }
            else
            {
                MessageBox.Show("尚未登入");
                OpenChildForm(new LoginForm());
            }
        }

        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddEmployeeForm());
        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            if(CheckLogin())
            {
                OpenChildForm(new SetupForm());
            }
            else
            {
                MessageBox.Show("尚未登入");
                OpenChildForm(new LoginForm());
            }
        }


        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            formPanel.Controls.Add(childForm);
            formPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void SetLoginResult(bool login, string userID)
        {
            if (login)
            {
                stateText.Text = $"{userID}\n登入成功";
                stateText.ForeColor = Color.Green;
            }
        }

        private bool CheckLogin()
        {
            return (stateText.Text == "未登入") ? false : true;
        }
    }
}