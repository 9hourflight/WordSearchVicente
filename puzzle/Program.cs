﻿namespace puzzle
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
                if (allTextIndexCounter > 0 && allTextIndexCounter % spaceBetweenCategories != 0)
                {
                    onlyWords[wordsIndexCounter] = allTextAndCategories[allTextIndexCounter];
                    wordsIndexCounter++;
                }

            }

            string[] fillerLetters = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string[] wordSearchBoard = { "  ABCDEFGHIJKLMNOPQRST", "01....................", "02....................", "03....................",
                "04....................", "05....................", "06....................", "07....................", "08....................",
                "09....................", "10....................", "11....................", "12....................", "13....................",
                "14....................", "15....................", "16....................", "17....................", "18....................",
                "19....................","20....................", };
            bool isChoosing = true;
            Random random = new();
            int chosenCategoryIndexValue = 0;

            int rangeMin = 1;
            int rangeMaxOrientation = 3;
            int rangeMaxBackOrForward = 2;
            
            int wordsPerCategory = 15;
            string[] eightWords = new string [8];
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
            //add iteration loop to get words in category
            string[] possibleWordsFifteen = new string[wordsPerCategory];
            int possibleWordIndex = 0;
            for (int i = chosenCategoryIndexValue; i < chosenCategoryIndexValue + wordsPerCategory; i++)
            {
                possibleWordsFifteen[possibleWordIndex] = onlyWords[i];
                possibleWordIndex++;
                
            }
            for (int j = 0; j < 8; j++)
            {
                string randomWord = possibleWordsFifteen[random.Next(0,possibleWordsFifteen.Length)];
                if (!eightWords.Contains(randomWord))
                {
                    eightWords[j] = randomWord;
                }
                else
                {
                    j--;
                }
            }
            for(int i = 0; i < eightWords.Length; i++)
            {
                int wordOrientation = random.Next(rangeMin, rangeMaxOrientation);
                int wordBackOrForward = random.Next(rangeMin, rangeMaxBackOrForward);

                //switch for word direction
                switch (wordOrientation)
                {
                    case 1:
                        //horizontal
                        int randomColumn = random.Next(2, 22);
                        //int randomRow = random.Next(1, 22);
                        bool canPlace = true;
                        if(randomColumn + eightWords[i].Length < 20)
                        {
                            /*
                            for(int j = randomColumn; j < randomColumn + eightWords[i].Length; j++)
                            {
                                if (wordSearchBoard[j] == ".")
                                {

                                }
                                else
                                {

                                }
                            }
                            */
                            wordSearchBoard[randomColumn] = wordSearchBoard[randomColumn].Substring(0, randomColumn) + eightWords[i] + wordSearchBoard[randomColumn].Substring(randomColumn + eightWords[i].Length);
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    case 2:
                        //vertical
                        break;
                    case 3:
                        //diagonal
                        break;
                }

                switch (wordBackOrForward)
                {
                    case 1:
                        //forward
                        break;
                    case 2:
                        //backward
                        break;
                }
            }
            Array.ForEach(wordSearchBoard, Console.WriteLine);
            //randomize 8 words with no repeats from category. Maybe make this and the above
            //
            //for loop a function


            //place words in grid then randomize all the empty slots
        }
        void HorizontalPlacement()
        {

        }
    }
}
