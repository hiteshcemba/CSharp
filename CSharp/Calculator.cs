using System;

namespace Program1
{
    class Calculator
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Number1 :");
                double dblNum1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Number2 :");
                double dblNum2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter 1 for Add.");
                Console.WriteLine("Enter 2 for Subtract.");
                Console.WriteLine("Enter 3 for Multiply.");
                Console.WriteLine("Enter 4 for Devide.");

                Console.Write("Enter Your Choice :");
                int intChoice = Convert.ToInt16(Console.ReadLine());

                double dblResult = 0.0;

                switch (intChoice)
                {
                    case 1:
                        dblResult = dblNum1 + dblNum2;
                        break;

                    case 2:
                        dblResult = dblNum1 - dblNum2;
                        break;

                    case 3:
                        dblResult = dblNum1 * dblNum2;
                        break;

                    case 4:
                        dblResult = dblNum1 / dblNum2;
                        break;


                }
                Console.WriteLine("Your Selected Operation Result :" + dblResult.ToString());


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            Console.Read();
        }


    }
}
