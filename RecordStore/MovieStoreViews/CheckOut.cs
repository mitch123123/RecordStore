using homework9;
using MovieStore.Classes;
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
        private int Promocount { get; set; }
        private UserPromos activePromo { get; set; }
        public CheckOut(UserDatum curuser)
        {
            InitializeComponent();
            Promocount = 0;
            user = curuser;           
            UserBalanceLbl.Text = $"{user.Username}'s account balance:{user.AccountBalance.ToString("c2")}";
            writetotals();
            CartItemList.DataSource = user.usercart.movies;
            PromoBox.DataSource = UserPromos.GetUserPromos(user);   
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            new MovieShop(user).Show();
            this.Hide();
        }

        private async void CheckoutBtn_Click(object sender, EventArgs e)
        {
            var bank = new BankTransaction();
            
            if(user.checkInventory(out var alreadyowned))
            {
                errLbl.Text = $"you already own {alreadyowned}, please remove from cart and try again";
            }
            else
            {

                if (errLbl.Text == "")
                {
                    var c = user.usercart.movies.Count;
                    string moviesadded = user.usercart.movies[0].MovieTitle;
                    if (c > 1)
                    {
                        foreach (var movie in user.usercart.movies)
                        {
                            moviesadded += $",{movie.MovieTitle}";
                            user.AddMovie(movie);
                        }
                    }
                    bank.CreateTransaction(user, $"purchase of {moviesadded}", user.usercart.CartTotal);
                    if (!await bank.LogTransaction())
                    {
                        errLbl.ForeColor = Color.Red;
                        errLbl.Text = "transaction failed";


                    }
                    else
                    {
                       
                        UserPromos.RemovePromo(user, activePromo);
                        UserPromos.CheckForPromosAvailable(user, null, out var newpromo);
                        Emailer.CreateReciptEmail(user, moviesadded, c, totalLbl.Text,newpromo);
                        user.usercart.movies.Clear();
                        user.usercart.CartTotal = 0;
                        new SuccessNotice(user, c, moviesadded).Show();
                        this.Hide();
                    }

                }
            }

            
        }

        private void CartItemList_Format(object sender, ListControlConvertEventArgs e)
        {
            string movietitle = ((UserMovie)e.ListItem).MovieTitle.ToString();        
            string price = ((UserMovie)e.ListItem).PurchasePrice.ToString("c2");
            e.Value = $"Title:{movietitle}  |  Price:{price} ";
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var removeitem = CartItemList.Items[CartItemList.SelectedIndex];
            user.usercart.movies.Remove((UserMovie)removeitem);
            writetotals();
        }
        public void writetotals()
        {
            user.usercart.GetTotal();
            subtotalLbl.Text = user.usercart.CartTotal.ToString("c2");
            float taxamount = (float)(user.usercart.CartTotal * .06);
            float total = (float)(taxamount + user.usercart.CartTotal);
            taxLbl.Text = taxamount.ToString("c2");
            totalLbl.Text = total.ToString("c2");
        }
        public void recalculate()
        {
            subtotalLbl.Text = user.usercart.CartTotal.ToString("c2");
            float taxamount = (float)(user.usercart.CartTotal * .06);
            float total = (float)(taxamount + user.usercart.CartTotal);
            taxLbl.Text = taxamount.ToString("c2");
            totalLbl.Text = total.ToString("c2");
        }

        private void PromoBtn_Click(object sender, EventArgs e)
        {
            if (Promocount == 1)
            {
                errLbl.Text = $"promo {activePromo.Promoname} has already been applied, only one promo per transaction";
            }
            else
            {
                Promocount++;
                activePromo = (UserPromos)PromoBox.Items[PromoBox.SelectedIndex];
                //discount total
                user.usercart.CartTotal = user.usercart.CartTotal - (user.usercart.CartTotal * activePromo.PromoValue);
                //remove promo
               
                recalculate();
            }
          
        }

        private void PromoBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string promoname = ((UserPromos)e.ListItem).Promoname.ToString();
          
            e.Value = $"{promoname} ";
        }
    }
}
