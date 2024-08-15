using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class AtmMachine
    {
        double balance = 0;

        public AtmMachine(){}

        public AtmMachine(double balance)
        {
            this.balance = balance;
        }
        public double getBalance() { return balance; }
        public void setBalance(double balance) { this.balance = balance; }

        public void checkBalance() {

            Console.WriteLine("Your balance is: {0}\n", getBalance().ToString("C2"));
        }

        public void depositMoney(double money)
        {
            if (money > 0){
                setBalance(money);

                Console.WriteLine("You deposited {0} to your account, your new balance is {1}\n",
                    money.ToString("C2"), getBalance().ToString("C2"));
            }
        }

        public void withdrawMoney(double amount)
        {
            if (amount > 0 && (amount < this.balance))
            {
                setBalance(this.balance - amount);

                Console.WriteLine("You withdrew: {0} from your account, your new Balance is: {1}\n",
                    amount.ToString("C2"), getBalance().ToString("C2"));
            }
            else
            {
                Console.WriteLine("Not Enough balance in your account!");
            }
        }
    }
}
