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
            string chosenCategory;
            string[] possibleWords = new string[15];
            int rangeMin = 1;
            int rangeMaxOrientation = 3;
            int rangeMaxBackOrForward = 2;
            int wordOrientation = randomize.Next(rangeMin, rangeMaxOrientation);
            int wordBackOrForward = randomize.Next(rangeMin, rangeMaxBackOrForward);


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
                    if (userEntry == i)
                    {
                        isChoosing = false;
                        chosenCategory = userEntry;
                    }
                }
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

        }
    }
}
