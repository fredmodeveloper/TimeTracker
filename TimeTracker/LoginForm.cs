using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class LoginForm : Form
    {
        public bool isLogin = false;
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private  void LoginBtn_Click(object sender, EventArgs e)
        {
            var usernameTxt = this.UsernameTxt.Text;
            var passwordTxt = this.PasswordTxt.Text;
            if(string.IsNullOrEmpty(usernameTxt) || string.IsNullOrEmpty(passwordTxt))
                MessageBox.Show("Fill the Items Correctly");
            else
            {

                if (Tools.Context.Users.Where(o => o.Username == usernameTxt).Any())
                {
                    if (Tools.Context.Users.Where(o => o.Password == passwordTxt).Any())
                    {

                        var user =  Tools.Context.Users.Where(o => o.Username == usernameTxt && o.Password == passwordTxt).FirstOrDefault();
                        Tools.CurrentUser = user;

                        // var user = Tools.Context.Users.Where(o=>o.Username==usernameTxt && o.Password==passwordTxt).FirstOrDefault();
                        //Tools.CurrentUser = user;
                        this.isLogin = true;
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Username or Password is incorrect.");
                }
            
        }
    }
}
