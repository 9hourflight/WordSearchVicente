    using System.IO;
    namespace WordSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wordsFilePath = "words.txt";
            StreamWriter categoryWriter = new StreamWriter(wordsFilePath);
            string[] minecraftBiomes = { "minecraftBiomes", "desert", "savanna", "jungle", "taiga", "meadow", "swamp", "badlands", "snowyTundra", "mushroomField", "bambooJungle", "dripstoneCave", "stonyPeaks", "cherryGrove", "forest", "beach" };
            string[] avatarCharacters = { "avatarCharacters","aang", "katara", "sokka", "zuko", "iroh", "toph", "appa", "momo", "azula", "kingOzai", "suki", "jet", "kimgBumi", "roku", "princessYue" };
            string[] undertaleCharacters = { "undertaleCharacters", "toriel", "papyrus", "sans", "asgore", "muffet", "napstablook", "undyne", "alphys", "mettaton", "flowey", "asriel", "frisk", "chara", "monsterKid", "temmie" };
            string[] tarotCards = { "tarotCards", "theFool", "theMagician", "judgement", "kingOfWands", "threeOfCups", "tenOfSwords", "knightOfCoins", "highPriestess", "theLovers", "strength", "death", "temperance", "theTower", "theHangedMan", "justice" };
            string[] breathOfTheWildIngredients = { "breathOfTheWildIngredients", "amoranth", "heartyRadish", "enduraCarrot", "hydromelon", "keeseWing", "mightyBananas", "rawMeat", "chuchuJelly", "roskSalt", "spicyPepper", "voltfruit", "wildberry", "ironshellCrab", "hylianRice", "hinoxGuts" };
            string[] texasWildFlowers = {"texasWildFlowers", "bluebonnet", "brownEyedSusan", "mexicanBlanket", "texasThistle", "pricklyPoppy", "frogFruit", "greenMilkweed", "purpleConeflower", "yellowLotus", "henbit", "bluebells", "mistFlower", "passionFlower", "woodSorrel", "falseGarlic" };
            string[] darkSoulsStats = { "darkSoulsStats", "vigor", "attunement", "endurance", "vitality", "stength", "dexterity", "intelligence", "faith", "luck", "bleedResistance", "poisonResistance", "frostResistance", "curseResistance", "magicDefense", "physicalDefense" };
            string[] austinVenues = {"austinVenues", "mohawk", "chessClub", "theParish", "emos", "holeInTheWall", "empire", "thirteenthFloor", "ballroom", "kickbuttCoffee", "concourseProject", "farOutLounge", "pattonHaus", "hotelVegas", "radioEast", "theCoralSnake"};
            string[] desserts = { "desserts", "pudding", "cheesecake", "icecream", "donut", "cannoli", "baklava", "mochi", "jalebi", "cobbler", "pie", "flan", "bananaBread", "cupcake", "cinnamonRoll", "cookie"};
            string[] appsOnMyPhone = {"appsOnMyPhone", "discord", "googleClassroom", "pinterest", "depop", "planetFitness", "libby", "boyCat", "venmo", "tooGoodToGo", "lyft", "tidal", "gmail", "alliant", "busuu", "googleDrive"};
            IterateThrough(categoryWriter, minecraftBiomes);
            IterateThrough(categoryWriter, avatarCharacters);
            IterateThrough(categoryWriter, undertaleCharacters);
            IterateThrough(categoryWriter, tarotCards);
            IterateThrough(categoryWriter, breathOfTheWildIngredients);
            IterateThrough(categoryWriter, texasWildFlowers);
            IterateThrough(categoryWriter, darkSoulsStats);
            IterateThrough(categoryWriter, austinVenues);
            IterateThrough(categoryWriter, desserts);
            IterateThrough(categoryWriter, appsOnMyPhone);
            categoryWriter.Close();
        }
        private static void IterateThrough(StreamWriter wordWriter, string[] categoryName)
        {
            for (int i = 0; i < categoryName.Length; i++)
            {
                wordWriter.WriteLine(categoryName[i]);
                wordWriter.Flush();
            }
        }
    }
}
