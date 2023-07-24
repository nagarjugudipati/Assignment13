using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                //Task-1

                Console.WriteLine("Hello,World!");

                 //Task-2

                 string name;
                 Console.WriteLine("Enter User Name : ");
                 name = Console.ReadLine();
                 Console.WriteLine($"Hello,{name}!");
                 Console.ReadKey();


                 //Task-3

                 int num1, num2;
                 Console.WriteLine("Enter First Number: ");
                 num1= int.Parse(Console.ReadLine());
                 Console.WriteLine("Enter Second Number");
                 num2= int.Parse(Console.ReadLine());
                 int Add = num1 + num2;
                 Console.WriteLine("The addition of given numbers is : " + Add);
                 int Sub = num1 - num2;
                 Console.WriteLine("The Subtraction of given numbers is : " + Sub);
                 int Mul = num1 * num2;
                 Console.WriteLine("The Multiplication of given numbers is : " + Mul);
                 if (num2 != 0)
                 {
                     int div = num1/ num2;

                     Console.WriteLine("The division is : "+div);
                     int modulus = num1 % num2;
                     Console.WriteLine("Modulus is : " + modulus);
                 }
                 else
                 {
                     Console.WriteLine("Cannot divisible by Zero");
                 }

                 Console.ReadKey();

     
                 //Task-4

                 int num;
                 Console.WriteLine("Enter a Number");
                 num = int.Parse(Console.ReadLine());
                 if(num%2 == 0)
                 {
                     Console.WriteLine($"{num} is Even");
                 }
                 else
                 {
                     Console.WriteLine($"{num} is Odd");
                 }
                 Console.ReadLine();
                


                //Task-5
                  /*  int num =0;
                    while(num <=10) 
                    {
                        Console.WriteLine(num);
                        num++;
                    }
                    Console.ReadKey();*/
                

               /* //Task-6

                            int[] numbers = new int[] { 12,24,86,54,25 };

                            int sum = 0;
                            foreach (int num in numbers)
                            {
                                sum = sum+ num;
                            }

                            double average = sum / numbers.Length;
                            Console.WriteLine($"Sum: {sum}");
                            Console.WriteLine($"Average: {average}");

                            Console.ReadKey();*/



                //Task-7

                /* int i,num, fact = 1;
                 Console.Write("Enter any Number: ");
                 num = int.Parse(Console.ReadLine());
                 for (i = 1; i <= num; i++)
                 {
                     fact = fact * i;
                 }
                 Console.Write("Factorial of " + num + " is: " + fact);
                 Console.ReadKey();*/



                //Task-8

                int age;
                try
                {
                    Console.WriteLine("Enter age: ");
                    age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Age is :" + age);
                    if (age < 18)
                    {
                        Console.WriteLine("You are a minor.");
                    }
                    else if (age >= 18 && age < 65)
                    {
                        Console.WriteLine("You are an adult.");
                    }
                    else
                    {
                        Console.WriteLine("You are a senior.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!" + e.Message);
                }
                finally
                {
                    Console.ReadKey();
                }
        }
    }
    
}
    

