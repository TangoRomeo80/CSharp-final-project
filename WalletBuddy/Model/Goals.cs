﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalletBuddy.Model
{
  class Goals
  {
    //Properties
    public int GoalId { set; get; }
    public int UserId { set; get; }
    public string GoalDuration { set; get; }
    public int TargetSavings { set; get; }
    public int CurrentExpense { set; get; }
    public int RemainingExpense { set; get; }

    //default constructor
    public Goals()
    {
      GoalId = 0;
      UserId = 0;
      GoalDuration = "";
      TargetSavings = 0;
      CurrentExpense = 0;
      RemainingExpense = 0;
    }

    //parameterized constructor
    public Goals(int goalId, int userId, string goalDuration, int targetSavings, int currentExpense, int remainingExpense)
    {
      GoalId = goalId;
      UserId = userId;
      GoalDuration = goalDuration;
      TargetSavings = targetSavings;
      CurrentExpense = currentExpense;
      RemainingExpense = remainingExpense;
    }
  }
}
