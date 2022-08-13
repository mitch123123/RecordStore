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

namespace MovieStore.MovieStoreViews
{
    public partial class CheckOut : Form
    {
        public UserDatum user { get; set; }
        public BankTransaction bank { get; set; }
        public CheckOut(UserDatum curuser)
        {
            InitializeComponent();
            user = curuser;
            subtotalLbl.Text = user.usercart.CartTotal.ToString();
            var taxamount = user.usercart.CartTotal * .06;
            var total = taxamount + user.usercart.CartTotal;
            taxLbl.Text = taxamount.ToString();
            totalLbl.Text = total.ToString();
            CartItemList.DataSource = user.usercart.movies;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            new UserMenu(user).Show();
            this.Hide();
        }

        private async void CheckoutBtn_Click(object sender, EventArgs e)
        {
            foreach(var item in user.usercart.movies)
            {
                bank.CreateTransaction(user, $"purchase of {item.MovieTitle}", item.PurchasePrice);
            if (await bank.LogTransaction())
                {
                    new SuccessNotice(user).Show();
                }
                else
                {
                    errLbl.ForeColor= Color.Red;
                    errLbl.Text = "transaction failed";
                }
            }
           
        }
    }
}
