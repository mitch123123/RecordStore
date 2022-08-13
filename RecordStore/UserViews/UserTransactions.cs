using homework9;
using MovieStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStore
{
    public partial class UserTransactions : Form
    {
        public UserDatum user = new UserDatum();
        public UserTransactions(UserDatum fromuser)
        {
            InitializeComponent();
            user= fromuser;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            new UserMenu().Show();
            this.Hide();
        }
    }
}
