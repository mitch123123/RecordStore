using homework9.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MovieStore.Models
{
    public partial class BankTransaction
    {
        //if true then transaction successfully logged
     public async Task<bool> LogTransaction()
        {
            using(var context = new MovieDatabaseContext())
            {
                if (validTransaction())
                {
                  await context.AddAsync(this);
                   
                }
                var created = await context.SaveChangesAsync();

                return created > 0;

            }
        }
     public void CreateTransaction(UserDatum user,string desc, float amount)
        {
            amount = (float)(amount + (amount * .06));
            GetNewWalletAmount(user,amount);
            GenerateTransactionNumber();
            SetTransactionDescription(desc);
            SetTransactionAmount(amount);
            SetTransactionDate();
            SetTransactionLocation();
        }
     public void GetNewWalletAmount(UserDatum user,float amount)
        {
            user.AccountBalance = user.AccountBalance - amount;
            this.NewWalletAmount = user.AccountBalance;
            
        }
      public void GenerateTransactionNumber()
        {
           
           this.TransactionNumber= new Guid();
        }
        public void SetTransactionDescription(string desc)
        {
            this.TransactionDescription = desc;
        }
        public void SetTransactionAmount(float amount)
        {
            this.TransactionAmount = amount;
        }
        public void SetTransactionDate()
        {
            this.TransactionDate = DateTime.Now;
        }
        public void SetTransactionLocation()
        {
            string fullLocation;
            using (var http = new HttpClient())
            {
                var endpoint = "http://www.ipinfo.io?token=e4cbd5a9f00587";
                var result = http.GetAsync(endpoint).Result;
                var json = result.Content.ReadAsStringAsync().Result;
                var obj = JsonConvert.DeserializeObject<IPInfo>(json);
                fullLocation = obj.city + "," + obj.region + "," + obj.country;
            }
            this.TransactionLocation = fullLocation;
        }
        public bool validTransaction()
        {
            if (UserId == null)
            {
                return false;
            }
            else if (NewWalletAmount == null)
            {
                return false;
            }
            else if(TransactionNumber == null)
            {
                return false;
            }
            else if (TransactionAmount == null)
            {
                return false;
            }
            else if (TransactionDate == null)
            {
                return false;
            }
            else if(TransactionLocation== null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
