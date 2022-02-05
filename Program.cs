using System;

namespace Learn_CSharp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator();
            
        }

        static void BasicCalculator(){
            bool active = true;

            var total = getNumber();

            do{
                Console.Write("Enter Operand: ");
                string operand = Console.ReadLine();

                switch (operand)
                {
                    case "+": var number = getNumber(); total += number; break;
                    case "-": number = getNumber(); total -= number; break;
                    case "*": number = getNumber(); total *= number; break;
                    case "/": number = getNumber(); total /= number; break;
                    case "=": active = false; break;
                    default: Console.WriteLine("Invalid Operand"); break;
                }   
                
            }while (active);

            Console.WriteLine("Total: {0}", total);
        }

        static float getNumber(){
            bool active = true;
            float number = 0;
            do
            {
                try{
                    Console.Write("Enter Number: ");
                    number = float.Parse(Console.ReadLine());
                    active = false;
                }
                catch (System.Exception){
                    Console.WriteLine("Error Occured");
                }
            } while (active);

            return number;
        }

        static String MiniBlackjack(){
            String[] avatar = {"Ace", "Jack", "King"};
            Random.next(avatar)
            return " ";
        }
    }
}
