using System;

namespace Hello_world
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("Harry Potter", "JK Rowling", 300);
            Console.WriteLine(Book.bookCount);
            Book book2 = new Book("Harry Potter", "JK Rowling", 1050);


           Console.WriteLine(book.Pages);

            
            Console.WriteLine(book2.Pages);

            Console.WriteLine(Book.bookCount);

            Console.WriteLine(book.MorePages());
            Console.WriteLine(book2.MorePages());

            Console.WriteLine("Age Prediction App");
            Console.Write("Enter you name: ");
            
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.Write("Enter you age: ");

            string age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " your are "+ age + " years old");

            bool isMale = true;

            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("you are male");
            }
            else
            {
                Console.WriteLine("you are not male");
            }
            int[] nums = {3,5,7,89,3 };
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine(GetPow(2, 4));

            Console.ReadLine();

        }

        static int GetPow(int baseNum, int powNum) {
            int result = 1;

            for (int i =0; i < powNum;i++) {
                result = result * baseNum;
            }

            return result;
        }

        static void TwoDArray()
        {
            int[,] numberGrid = { { 1,2}, { 3,4}, { 5,6} };
            //int[,] myArray = new int[2, 3];

            for (int i = 0; i < numberGrid.Length; i++) {
              

            }

        }
    }
}
