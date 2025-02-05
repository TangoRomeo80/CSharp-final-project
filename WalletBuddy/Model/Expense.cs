﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  class Expense
  {
    //Properties
    public int TransactionId { set; get; }
    public int UserId { set; get; }
    public int Amount { set; get; }
    public string PaymentTo { set; get; }
    public string Description { set; get; }
    public string AccountName { set; get; }
    public DateTime Date { set; get; }

    //default constructor
    public Expense()
    {
      TransactionId = 0;
      UserId = 0;
      Amount = 0;
      PaymentTo = "";
      Description = "";
      AccountName = "";
      Date = DateTime.Now;
    }

    //parameterized constructor
    public Expense(int transactionId, int userId, int amount, string paymentTo, string description, string accountName, DateTime date)
    {
      TransactionId = transactionId;
      UserId = userId;
      Amount = amount;
      PaymentTo = paymentTo;
      Description = description;
      AccountName = accountName;
      Date = date;
    }

  }
}
