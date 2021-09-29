using System;

namespace Bank_Application_C_
{
    class Account{
        public int[] id;
        public string accountNo;
        public string accountName;
        public string address;
        public int accountPin;
        public double balance = 0;

        public Account(){}
        public Account(string accountNo,string accountName,string address,int accountPin, double balance){
            this.accountNo = accountNo;
            this.accountName = accountName;
            this.address = address;
            this.accountPin = accountPin;
            this.balance = balance;
        }
        public int createAccount(){
            Console.WriteLine("Enter the Account Number");
            accountNo = Console.ReadLine();

            Console.WriteLine("Enter the Account Holder name");
            accountName = Console.ReadLine();

            Console.WriteLine("Enter the Account Holder address");
            address = Console.ReadLine();

            Console.WriteLine("Enter the Account Pin");
            accountPin = int.Parse(Console.ReadLine());

            return 1;
        }

        public void depositeAmount(string accNo){
            if(accountNo.Equals(accNo)){
                Console.WriteLine("Enter the amount");
                int amt = int.Parse(Console.ReadLine());
                this.balance = balance + amt;

                Console.WriteLine("Enter pin to view the balance");
                int pin = int.Parse(Console.ReadLine());
                if(accountPin.Equals(pin)){
                    Console.WriteLine("Your Balance is: $"+balance);
                } else {
                    Console.WriteLine("Inavlid pin!!!");
                }
            } else {
                Console.WriteLine("Account does not exist!!");
            }
        }

        public void withdrawAmount(string accNo){
            if(accountNo.Equals(accNo)){
                Console.WriteLine("Enter the amount");
                int amt = int.Parse(Console.ReadLine());
                if(balance == 0){
                    Console.WriteLine("Insufficient balance!!!");
                }
                else if(amt > balance){
                    Console.WriteLine("Insufficient balance!!!");
                }else {
                    this.balance = balance - amt;
                    Console.WriteLine("Enter pin to view the balance");
                    int pin = int.Parse(Console.ReadLine());
                    if(accountPin.Equals(pin)){
                        Console.WriteLine("Your Balance is: $"+balance);
                    } else {
                        Console.WriteLine("Inavlid pin!!!");
                    }
                }
            }else{
                Console.WriteLine("Account does not exist!!");
            }
        }


    }
    class Transaction{

    }
    class functions{

    }
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            Account ac = new Account();
            functions fun = new functions();
            do{ 
                Console.WriteLine("Select the function");
                Console.WriteLine("1.Create Account");
                Console.WriteLine("2.Deposite Amount");
                Console.WriteLine("3.Withdraw Amount");
                Console.WriteLine("4.Transfer Amount");
                Console.WriteLine("5.Print Transaction History");
                Console.WriteLine("6.exit");
                c = Convert.ToInt32(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        int res = ac.createAccount();
                        if(res ==1){
                            Console.WriteLine("Account is created!!!");
                        } else {
                            Console.WriteLine("Account is not created!!!");
                        }
                        break;
                    case 2:
                        string accNo;
                        Console.WriteLine("Enter Your Account Number: ");
                        accNo = Console.ReadLine();
                        ac.depositeAmount(accNo);
                        break;
                    case 3:
                        string accNo1;
                        Console.WriteLine("Enter Your Account Number: ");
                        accNo1 = Console.ReadLine();
                        ac.withdrawAmount(accNo1);
                        break;
                    case 4:
                        //fun.transferAmount();
                        break;
                    case 5:
                        //fun.transactionHistory();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using this application!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!");
                        break;
                }
                }while (c != 6);
            }
            //Console.WriteLine("Hello World!");
        }
    }
