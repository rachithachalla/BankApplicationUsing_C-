using System;
using System.Collections.Generic;
using System.Linq;

namespace Bank_Application_C_
{
    class Account{
        public void depositeAmount(int [] acc,int[] pin, int [] amt, int id,int p){
            int fl = 0;
            for(int i=0;i<10;i++){
                if(acc[i]==id){
                    if(pin[i]==p){
                        Console.WriteLine("Enter amount: ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        amt[i] += amount;
                        Console.WriteLine("Amount Deposited!!");
                        Console.WriteLine("Balance is: "+amt[i]);
                        fl = 1;
                        break;
                    } else {
                        Console.WriteLine("Invalid Pin!!");
                        break;
                    }
                } 
            }
            if(fl==0){
                Console.WriteLine("Account Does not exist!!!");
            }
        }
        public void withdrawAmount(int [] acc,int[] pin, int [] amt, int id,int p){
            int fl1 =0;
            for(int i=0;i<10;i++){
                if(acc[i]==id){
                    if(pin[i]==p){
                        Console.WriteLine("Enter amount: ");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        amt[i] -= amount;
                        Console.WriteLine("Amount Withdrawn!!");
                        Console.WriteLine("Balance is: "+amt[i]);
                        fl1 = 1;
                        break;
                    } else {
                        Console.WriteLine("Invalid Pin!!");
                        break;
                    }
                }
             }
             if(fl1==0){
                 Console.WriteLine("Account Does not exist!!!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int idx=0;
            int [] acc = new int[10];
            string[] accName = new string[10];
            int [] amt = new int[10];
            int [] pin = new int[10];

            int [] tId = new int[10];
            string [,] desc = new string[10,10];
            int [,] tamt = new int[10,10];
            string [,] tm = new string[10,10];

            int [,] trs = new int[10,10];  
            Account ac = new Account();
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
                        idx++;
                        acc[idx-1]=idx;
                        Console.WriteLine("Enter your name");
                        accName[idx-1]=Console.ReadLine();
                        Console.WriteLine("Enter your pin");
                        pin[idx-1] = Convert.ToInt32(Console.ReadLine());
                        amt[idx] = 0;
                        Console.WriteLine("Account is created!!");
                        Console.WriteLine("Account Number is: "+idx);        
                        break;
                    case 2:
                        int accNo;
                        Console.WriteLine("Enter Your Account Number: ");
                        accNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your pin: ");
                        int p = Convert.ToInt32(Console.ReadLine());
                        ac.depositeAmount(acc,pin,amt,accNo,p);
                        trs[accNo,tId[accNo]] = accNo;
                        desc[accNo,tId[accNo]] = "deposit";
                        tamt[accNo,tId[accNo]] = ac.amt;
                        tm[accNo,tId[accNo]] = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                        tId[accNo]++;
                        break;
                    case 3:
                        int accNo1;
                        Console.WriteLine("Enter Your Account Number: ");
                        accNo1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter your pin: ");
                        int p1 = Convert.ToInt32(Console.ReadLine());
                        ac.withdrawAmount(acc,pin,amt,accNo1,p1);
                        trs[accNo,tId[accNo1]] = accNo1;
                        desc[accNo1,tId[accNo1]] = "withdrawl";
                        tamt[accNo1,tId[accNo1]] = ac.amt;
                        tm[accNo1,tId[accNo1]] = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                        tId[accNo1]++;
                        break;
                    case 4:
                        transferAmount();
                        break;
                    case 5:
                        transactionHistory();
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using this application!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Selection!!");
                        break;
                }
                }while (c != 6);

                static void transferAmount(){
                    int accNo;
                    Console.WriteLine("Enter Your Account Number: ");
                    accNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter your pin: ");
                    int p = Convert.ToInt32(Console.ReadLine());
                    for(int i=0;i<10;i++){
                        if(acc[i]==accNo){
                            if(pin[i]==p){
                                Console.WriteLine("Enter to Account number: ");
                                int toAccNo = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter amount: ");
                                int amount = Convert.ToInt32(Console.ReadLine());
                                for(int j=0;j<10;j++){
                                    if(acc[j] == toAccNo){
                                        amt[toAccNo] += amount; 
                                        amt[i] -= amount;
                                        trs[accNo,tId[toAccNo]] = toAccNo;
                                        desc[accNo1] = "withdrawl";
                                        tamt[accNo1] = ac.amt;
                                        tm[accNo1] = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                                        trs[accNo1]++;

                                    }
                                }
                                Console.WriteLine("Enter amount: ");
                                int amount = Convert.ToInt32(Console.ReadLine());

                            } else {
                                Console.WriteLine("Invalid Pin!!");
                                break;
                            }
                        } else {
                            Console.WriteLine("Account does not Exist!!");
                        }
                    }

                }
                static void transactionHistory(){

                }

            }
    }
}
