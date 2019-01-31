using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating object of Rectangle class to get lenth and width.          
            Rectangle rectangle = new Rectangle();
            int rectlength = rectangle.Length;
            int rectwidth = rectangle.Width;
            /// Initializing variables for the input
            string length = string.Empty;
            string width = string.Empty;
            string userinputs = string.Empty;
            bool validMenuSelection = false;
            Console.WriteLine("Values of Length and Width are 1");
            Console.WriteLine("");
            //Menus for Selecting User inputs
            while (validMenuSelection == false)
            {
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2. Change Rectangle Length");
                Console.WriteLine("3. Get Rectangle Width");
                Console.WriteLine("4. Change Rectangle Width");
                Console.WriteLine("5. Get Rectangle Parameter");
                Console.WriteLine("6. Get Rectangle Area");
                Console.WriteLine("7. Exit");
                userinputs = Console.ReadLine();
                switch (userinputs)
                {
                    case "1":
                        Console.WriteLine("Length is = {0} ", rectangle.GetLength());
                        break;
                    case "2":
                        Console.WriteLine("Enter New Length");
                        length = Console.ReadLine();
                        // Validation for Length
                        if ((!int.TryParse(length, out rectlength)) && (rectlength <= 0))
                        {
                            Console.WriteLine("Please Enter Valid Length");
                        }
                        else
                        {
                            Console.WriteLine("New Length is = {0} ", rectangle.SetLength(rectlength));
                        }
                        break;
                    case "3":
                        Console.WriteLine("Width is = {0} ", rectangle.GetWidth());
                        break;
                    case "4":
                        Console.WriteLine("Enter new width");
                        width = Console.ReadLine();
                        // Validation for Width
                        if ((!int.TryParse(width, out rectwidth)) && (rectwidth <= 0))
                        {
                            Console.WriteLine("Please Enter Valid Width");
                        }
                        else
                        {
                            Console.WriteLine("New Width is = {0} ", rectangle.SetWidth(rectwidth));
                        }
                        break;
                    case "5":
                        Console.WriteLine("Perimeter = {0} ", rectangle.GetPerimeter());
                        break;
                    case "6":
                        Console.WriteLine("Area is = {0} ", rectangle.GetArea());
                        break;
                    case "7":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please Enter a Valid Number");
                        break;
                }
            }
        }
    }
}


      
