namespace puzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader categoryReader = new StreamReader("words.txt");
            string? allText = categoryReader.ReadLine();
            string[] allTextAndCategories = new string[160];
            int allTextIndexCounter = 0;
            while(allText != null)
            {
                allTextAndCategories[allTextIndexCounter] = allText;
                allText = categoryReader.ReadLine();
                allTextIndexCounter++;
            }
            categoryReader.Close();
            string[] categories = new string[10];
            int categoriesIndexCounter = 0;
            allTextIndexCounter = 0;
            for (allTextIndexCounter = 0; allTextIndexCounter < allTextAndCategories.Length; allTextIndexCounter++)
            {
                if (allTextIndexCounter % 16 == 0)
                {
                    categories[categoriesIndexCounter] = allTextAndCategories[allTextIndexCounter];
                    categoriesIndexCounter++;
                }
            }
            
            
            string[] fillerLetters = { "a", "b", "c", "d", "e", "f", "g","h", "i", "j", "k", "l", "m","n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] wordSearchBoard = new string[20];
            bool isChoosing = true;
            bool isPlaying = true;
            Random randomize = new Random();
            string chosenCategory;

            while (isPlaying)
            {

                while (isChoosing)
                {
                    for (int i = 0; i < categories.Length; i++)
                    {
                       Console.WriteLine(categories[i]);
                    }
                    Console.WriteLine("Please enter one of the above categories to begin your wordsearch.");
                    string? userEntry = Console.ReadLine();
                    foreach(string i in categories)
                    {
                        if (userEntry == i)
                        {
                            chosenCategory = i;
                            isChoosing = false;
                        }
                    }
                }
                Console.WriteLine("you are here");
            }
           
        }
    }
}
