using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Acc(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnCredit_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            //acc.OnTransactionAlert += NotifyTransaction;
            acc.OnTransactionAlert += Acc_OnTransactionAlert;
            acc.OnTransactionAlert += Acc_OnTransactionLabel;

            int amount;
            if (int.TryParse(txtAmount.Text, out amount))
            {
                if(amount>0)
                {
                    acc.Credit(amount);                       
                }
            }
        }

        private void Acc_OnTransactionLabel(object source, NotificationArgs args)
        {
            label1.Text = args.Message;
        }

        private void Acc_OnTransactionAlert(object source, NotificationArgs args)
        {
            MessageBox.Show(args.Message);
        }

        private void NotifyTransaction(string message)
        {
            MessageBox.Show(message);
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            Account acc = new Account();
            //acc.OnTransactionAlert += NotifyTransaction;
            int amount;
            if (int.TryParse(txtAmount.Text, out amount))
            {
                if (amount > 0)
                {
                    acc.Debit(amount);
                }
            }
        }
    }
}
