using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpBasics
{
    public class SealedClassDemo
    {
        static void Main(string[] args)
        {
            AccountTypes accType = new AccountTypes();
            accType.AccountName = "Saving";
            accType.ShowAccountName();

            Console.WriteLine("***************************");

            Accounts acc = new Accounts();

            AccountTypes accType1 = (AccountTypes)acc;
            accType1.AccountName = "Current";
            accType1.ShowAccountName();

            Console.ReadLine();
        }
    }

    public sealed class Accounts : AccountTypes
    {
        public override void ShowAccountName()
        {            
            Console.WriteLine($"Called from Accounts, Account Name : {this.AccountName}");
        }
    }

    public class AccountTypes
    {
        public string AccountName { get; set; }

        public virtual void ShowAccountName()
        {
            Console.WriteLine($"Called from AccountTypes,  Account Name : {this.AccountName}");
        }

        int j = 0;
        public static void Counter()
        {
            int i = 0;
           
            i++;
        }
    }
}
