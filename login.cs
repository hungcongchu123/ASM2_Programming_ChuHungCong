using System.Diagnostics.Eventing.Reader;
using WaterBill.Models;

namespace WinFormsApp10
{
    public partial class login : Form
    {
        List<User> users = new List<User>();
        public login()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            users.Add(new User { Id = 1, Username = "chuhungcong", Password = MyHelper.Hash256("123") });
            users.Add(new User { Id = 2 , Username = "admin", Password = MyHelper.Hash256("123") });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password is not empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string passwordHash = MyHelper.Hash256(password);
            if (users.Any(x => x.Username == username && x.Password == passwordHash))
            {

                this.Hide();
                WaterBill waterBill = new WaterBill();
                waterBill.ShowDialog();


            }
            else
            {
                MessageBox.Show("Account invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
