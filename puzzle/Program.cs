using System.Collections.Generic;
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
            while (allText != null)
            {
                allTextAndCategories[allTextIndexCounter] = allText;
                allText = categoryReader.ReadLine();
                allTextIndexCounter++;
            }
            categoryReader.Close();
            string[] categories = new string[10];
            int categoriesIndexCounter = 0;
            int spaceBetweenCategories = 16;
            string[] onlyWords = new string[150];
            int wordsIndexCounter = 0;
            for (allTextIndexCounter = 0; allTextIndexCounter < allTextAndCategories.Length; allTextIndexCounter++)
            {
                if (allTextIndexCounter % spaceBetweenCategories == 0)
                {
                    categories[categoriesIndexCounter] = allTextAndCategories[allTextIndexCounter];
                    categoriesIndexCounter++;
                }
                if(allTextIndexCounter > 0 && allTextIndexCounter % spaceBetweenCategories != 0)
                {
                    onlyWords[wordsIndexCounter] = allTextAndCategories[allTextIndexCounter];
                    wordsIndexCounter++;
                }

            }
           
            string[] fillerLetters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] wordSearchBoard = new string[21];
            bool isChoosing = true;
            Random randomize = new Random();
            int chosenCategoryIndexValue;
            
            int rangeMin = 1;
            int rangeMaxOrientation = 3;
            int rangeMaxBackOrForward = 2;
            int wordOrientation = randomize.Next(rangeMin, rangeMaxOrientation);
            int wordBackOrForward = randomize.Next(rangeMin, rangeMaxBackOrForward);
            int wordsPerCategory = 15;
            Dictionary<string, int> wordPossibilities = new Dictionary<string, int>();
            wordPossibilities.Add("minecraftBiomes", 0);
            wordPossibilities.Add("avatarCharacters", 15);
            wordPossibilities.Add("undertaleCharacters", 30);
            wordPossibilities.Add("tarotCards", 45);
            wordPossibilities.Add("breathOfTheWildCategories", 60);
            wordPossibilities.Add("texasWildFlowers", 75);
            wordPossibilities.Add("darkSoulsStats", 90);
            wordPossibilities.Add("austinVenues", 105);
            wordPossibilities.Add("desserts", 120);
            wordPossibilities.Add("appsOnMyPhone", 135);

            while (isChoosing)
            {
                for (int i = 0; i < categories.Length; i++)
                {
                    Console.WriteLine(categories[i]);
                }
                Console.WriteLine("Please enter one of the above categories to begin your wordsearch.");
                string? userEntry = Console.ReadLine();
                foreach (string i in categories)
                {
                    if (userEntry != null && wordPossibilities.ContainsKey(userEntry))
                    {
                        
                        wordPossibilities.TryGetValue(userEntry, out int chosenCategory);
                        chosenCategoryIndexValue = chosenCategory;
                        isChoosing = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                }
            }
            if (wordPossibilities.ContainsKey(chosenCategory))
            {
                //add iteration loop to get words in category
                for(int i = 0; i < wordsPerCategory; i++)
                {

                }
                //randomize 8 words with no repeats from category. Maybe make this and the above
                //
                //for loop a function
            }
            //switch for word direction
            switch (wordOrientation)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }

            switch (wordBackOrForward)
            {
                case 1:
                    break;
                case 2:
                    break;
            }

            //place words in grid then randomize all the empty slots
        }
    }
}
