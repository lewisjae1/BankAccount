﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Creates an account with a specific owner and a balacne of 0
    /// </summary>
    /// <param name="accOwner">The customer full name that owns the account</param>
    public class Account
    {
        public Account(string accOwner)
        {
            Owner = accOwner;
        }
        /// <summary>
        /// The account holders full name (first and last)
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// The amount of money currently in the account
        /// </summary>
        public double Balance { get; private set; }
        /// <summary>
        /// Adds a specified amount of money to the account.
        /// Returns the new balance
        /// </summary>
        /// <param name="amt">The positive amount to deposit</param>
        /// <returns>The new balance after the deposit</returns>
        public double Deposit(double amt)
        {
            Balance += amt;
            return Balance;
        }
        /// <summary>
        /// Withdraws an amount of money from the balance
        /// </summary>
        /// <param name="amt">The positive amount of money to be taken from the balance</param>
        public void Withdraw(double amt)
        {
            throw new NotImplementedException();
        }
    }
}
