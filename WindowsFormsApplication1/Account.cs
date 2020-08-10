using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Account
    {
        public delegate void Notification(object source, NotificationArgs args);
        //public delegate void Notification(string message);
        public event Notification OnTransactionAlert;

        public static int Balance { get; set; }
        public string AccountHolderName { get; set; }

        public void Credit(int amount)
        {
            Account.Balance += amount;


          
            if (OnTransactionAlert != null)
            {
                OnTransactionAlert(this, new NotificationArgs { Message = $"Your account credited with Rs. {amount}" });
                //OnTransactionAlert($"Your account credited with Rs. {amount}");
            }
        }

        public void Debit(int amount)
        {
            bool flag = false;
            if (Balance >= amount)
            {
                Account.Balance -= amount;
                flag = true;
            }
            else
            {
                flag = false;
            }

            if (OnTransactionAlert != null)
            {
                string message = string.Empty;

                if (flag)
                    message = $"Your account has debited with Rs. {amount}";
                else
                    message = $"You don't have sufficient balance to withdraw this amount!";

                OnTransactionAlert(this, new NotificationArgs { Message = message });
                //OnTransactionAlert(message);

            }
        }
    }

    public class NotificationArgs : EventArgs
    {
        public string Message { get; set; }
    }
}
