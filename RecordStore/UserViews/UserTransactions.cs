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
        public List<BankTransaction> usertrans = new List<BankTransaction>();
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

        private void UserTransactions_Load(object sender, EventArgs e)
        {
            UserLbl.Text = $"Transactions for {user.Username}";
            using (var context = new MovieDatabaseContext())
            {
                usertrans = context.Banks.Where(a => a.UserId == user.UserId).ToList();
                TransactionsList.DataSource = usertrans;
            }
        }

        private void TransactionsList_Format(object sender, ListControlConvertEventArgs e)
        {
            string transactiondate = ((BankTransaction)e.ListItem).TransactionDate.ToString("MM/dd/yyyy");
            string transactiondesc = ((BankTransaction)e.ListItem).TransactionDescription.ToString();
            string transamount = ((BankTransaction)e.ListItem).TransactionAmount.ToString("c2");
            string newwallet = ((BankTransaction)e.ListItem).NewWalletAmount.ToString("c2");
            string location = ((BankTransaction)e.ListItem).TransactionLocation.ToString();


            e.Value = $"Date:{transactiondate} | Description:{transactiondesc} | Amount:{transamount} | Account Balance:{newwallet} | Purchase location: {location} ";
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
