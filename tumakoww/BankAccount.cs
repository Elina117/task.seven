using System;
namespace tumakoww
{
    
        internal class BankAccount
        {
            internal ulong account_number;
            internal uint balance;
            internal enum AccountType
            {
                Расчетный, Накопительный, Кредитный, Инвестиционный, Пенсионный
            }
            internal AccountType acc_type;
            internal BankAccount(ulong account_number, uint balance, AccountType acc_type)
            {
                this.account_number = account_number;
                this.balance = balance;
                this.acc_type = acc_type;
            }
            internal void SwitchAccountBank(ulong account_number, uint balance, AccountType acc_type)
            {
                this.account_number = account_number;
                this.balance = balance;
                this.acc_type = acc_type;
            }
            internal void PrintAccountBank()
            {
                Console.WriteLine($"Номер счета - {account_number}, баланс - {balance} рублей, тип счета - {acc_type}");
            }
            internal void MoneyTransfer(BankAccount account, uint sum)
            {
                if (account.balance >= sum)
                {
                    Console.WriteLine($"На банковском счету было {account.balance}р. \n" +
                        $"С него сняли {sum}р, теперь на нем {account.balance - sum}р");
                }
                else
                {
                    Console.WriteLine($"На банковском счету недостаточно средств для снятия {sum}р. \n" +
                        $"На счету всего {account.balance}р.");
                }
            }
        }
    
    

}

