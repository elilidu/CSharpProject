using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             //Array of Strings store 
             string[] comSubject=new string[5];
             string copySubject;

             Console.WriteLine("List the five courses you have completed");

             //Read user input as string
             for (int i = 0; i < 5; i++)
             {
                 comSubject[i]=Console.ReadLine();
             }

             Console.WriteLine("The course you achieve are: \n");
             //Display each course complited
             for (int j = 0; j < 5; j++)
             {
                 Console.WriteLine(comSubject[j]);
             }
             //Tis Loop never terminates, It is an Infinity loop
             for (int j = 1; j > 0; j++)
             {
                 Console.WriteLine("No one will stop me !!!");
             }


             //To stop an infinite loop use insert a break statement

             for (int j = 1; j > 0; j++)
             {
                 if (j == 10)
                 {
                     Console.WriteLine(j);
                     break;

                 }
             }
             //Console.WriteLine(j);
             //  never terminates unless press Break
             //for (; ; )
             //{
             //   Console.WriteLine("Infinite Text ");
             //}

             //Display number 0 to 9
             int maxNumbet = 10;
             int x = 0;
             while (x < maxNumbet)
             {
                 Console.WriteLine(x);
                 x++;
             }

             //Display number 10 to 20
             int y = 10;
             do
             {
                 Console.WriteLine(y);
                 y++;
             }
             while (y <= 20);


             string[] DBsecurity = {  "java", "php", "c#", "c++", "python" };
             Console.WriteLine("Enter one object oriented programing language ");
             string searchVal = Console.ReadLine();

             //searc the String match to the user input
             bool myflag=false;
             for (int k= 0; k < DBsecurity.Length; k++)
             {
                     if (DBsecurity[k]==searchVal)
                     {
                         Console.WriteLine(DBsecurity[k]);
                         myflag=true;

                     }


              }

             if (myflag==false)
             {
                 Console.WriteLine("the input is not in the list");
             }

             string[] sililatItem = { "php","java","php","c#", "c++", "python" };
             Console.WriteLine("Enter one object oriented programing language ");
             string Val = Console.ReadLine();

             //show the index,which get the first match
             bool myfla = false;
             for (int m = 0; m < sililatItem.Length; m++)
             {
                 if (sililatItem[m] == Val)
                 {
                     Console.WriteLine(sililatItem[m] + "found in an Index"+m);
                     myfla = true;

                 }


             }

             if (myfla == false)
             {
                 Console.WriteLine("the input is not in the list");
             }



             string[] myItem = { "a", "b", "c", "d", "c", "e", };
             Console.WriteLine("Enter any letter between a to e");
             string comVal = Console.ReadLine();

             //show the index,which get the first match

             int numofRepeat =0;
             for (int t = 0; t < myItem.Length; t++)
             {
                 if (myItem[t]==comVal)
                 {
                     numofRepeat = numofRepeat+1;

                 }


              }
             if (numofRepeat > 1)
             {
                 Console.WriteLine(comVal + "\t is \t" + numofRepeat + "\t times repeted");
             }
             else
             {
                 Console.WriteLine(comVal + "\t is"+ "\t No repeted");
             }



             // Create an String type of Array 
             string[] ONProv = new string[] { "Toronto", " Ottawa", "Mississauga ", " Brampton", "Hamilton ", "London " };
             // Read user index between 0 to 5
             Console.WriteLine("Enter any Number in between 0 to 5");
             int userIndex=Convert.ToInt32( Console.ReadLine());

             //display the value,that corresponding indexed
             Console.WriteLine(ONProv[userIndex]);
            Console.ReadLine();


             // Create an String type of Array 
             int[] numinArray = new int[] { 67, 23,105, 40, 200, 99 };
             // Read user index between 0 to 5
             Console.WriteLine("Enter any Number in between 0 to 5");
             int user_Index = Convert.ToInt32(Console.ReadLine());

             if (user_Index>=0 && user_Index < 6)
             {
                 //display the value,that corresponding indexed
                 Console.WriteLine(numinArray[user_Index]);
             }
             else
             {
                 Console.WriteLine("This index  doesn’t exist");
             }
                 // create List of string type
                     List<String> EastAfrica = new List<String>();
                 //Add the value in the list
                 EastAfrica.Add("Ethiopia");
                 EastAfrica.Add("Uganda");
                 EastAfrica.Add("Kenya");
                 EastAfrica.Add("Sudan");
                 EastAfrica.Add("Zambia");

                 Console.WriteLine("Enter any Number in between 0 to 4");
                 // read user index number
                 int uIndex = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(EastAfrica[uIndex]);
             */
            // create a list store the dividend numbers
            List<int> listInt = new List<int> { 24,46,72,55,68,97};


            // read the divisor as input
            Console.WriteLine("Enter any Number an integer number");
            int userNum = Convert.ToInt32(Console.ReadLine());


           // block of code for which particular exceptions is activated
            try
            {
                //Divided each number in with an input number
                foreach (int d in listInt)
                    {
                        Console.WriteLine(d / userNum);
                        
                    }
                }
            // exception handler, handle the problem 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // conduct input type or format problem.
            catch (FormatException ex)
                    {
                Console.WriteLine(ex.Message);
            }
            //The try catch is finished
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }


            Console.ReadLine();
        }
    }
}