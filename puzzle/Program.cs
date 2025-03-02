using System.IO;
namespace puzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader categoryReader = new StreamReader("words.txt");
            string? allText = categoryReader.ReadLine();
            string[] allTextAndCategories = new string[160];
            int indexCounter = 0;
            while(allText != null)
            {
                allTextAndCategories[indexCounter] = allText;
                allText = categoryReader.ReadLine();
                indexCounter++;
            }
            categoryReader.Close();
            //Console.WriteLine(allTextAndCategories[0]);
            //Console.WriteLine(allTextAndCategories[159]);
            string[] categories = new string[14];
            indexCounter = 0;
            for(indexCounter = 0; indexCounter < allTextAndCategories.Length; indexCounter++)
            {
                if (indexCounter % 16 == 0)
                {
                    Console.WriteLine(allTextAndCategories[indexCounter]);
                }
            }
           
            
            string[] fillerLetters = { "a", "b", "c", "d", "e", "f", "g","h", "i", "j", "k", "l", "m","n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[,] wordSearchBoard = new string[20, 20];
            bool isChoosing = true;
            bool isPlaying = true;
            Random randomize = new Random();

            while (isPlaying)
            {

                while (isChoosing)
                {
                    Console.WriteLine("Please enter one of the above categories to begin your wordsearch.");
                    string? chosenCategory = Console.ReadLine();
                    if (chosenCategory == null)
                    {
                        Console.WriteLine("Invalid input, try again.");
                        isChoosing = false;
                    }
                    //else if (chosenCategory ==)
                    {

                    }
                }
            }
           
        }
    }
}
