using System.Collections;

bool runningProgram = true;
int exerciseNumber;

Introduction();

while (runningProgram)
{
    exerciseNumber = GetExerciseNumber();
    if (exerciseNumber >= 31 && exerciseNumber <= 41)
    {
        Console.WriteLine("");
        switch (exerciseNumber)
        {
            case 31:
                Console.Clear();
                DoExercise31();
                break;
            case 32:
                Console.Clear();
                DoExercise32();
                break;
            case 33:
                Console.Clear();
                DoExercise33();
                break;
            case 34:
                Console.Clear();
                DoExercise34();
                break;
            case 35:
                Console.Clear();
                DoExercise35();
                break;
            case 36:
                Console.Clear();
                DoExercise36();
                break;
            case 37:
                Console.Clear();
                DoExercise37();
                break;
            case 38:
                Console.Clear();
                DoExercise38();
                break;
            case 39:
                Console.Clear();
                DoExercise39();
                break;
            case 40:
                Console.Clear();
                DoExercise40();
                break;
            case 41:
                Console.Clear();
                DoExercise41();
                break;
        }
        runningProgram = RunProgramAgainPrompt();
    }
    else if (exerciseNumber < 31 || exerciseNumber > 41)
    {
        Console.WriteLine("");
        Console.WriteLine("Sorry, that number appears to be out of the specified range. Please try again.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine("This concludes Exercises 31 - 41 for the 2022 Grand Circus C# .Net boot camp.");
Console.WriteLine("Goodbye...");

static void Introduction()
{
    Console.WriteLine("Welcome to the program for Exercises 31 - 41 in the 2022 Grand Circus C# .Net boot camp.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}
static void PrintMenuOfExercises()
{
    Console.WriteLine("EXERCISE MENU:");
    Console.WriteLine("");
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 31: \tCreate an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. ");
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "Prompt the user to enter an index. Display the element in the array at that index."));
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 32: \tCreate an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. ");
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "Prompt the user to enter a number. If the number is in the array, display the index "));
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "at which it is located."));
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 33: \tCreate an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. ");
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "Let the user change the array by specifying an index and a replacement number."));
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 34: \tCreate an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256. ");
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "Prompt the user to enter a command, 'half' or 'double'. If the user enters 'half',"));
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "half all the elements in the array. If the user enters 'double', double all the"));
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "elements in the array."));
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 35: \tCreate an array of size 5 and fill it with the following strings: \"cow\", \"elephant\",");
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "\"jaguar\", \"horse\", \"crow\". Prompt the user to enter two indices separated by a"));
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "space. The first index will specify the word, and the second will specify a letter in that word."));
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "Prompt the user to enter two indices separated by a space. The first index will specify the word,"));
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "and the second will specify a letter in that word. Display the corresponding word and letter."));
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 36: \tCreate two arrays, each of size 5. Fill the first array with the numbers: 12, 11, 10, 9, 8. ");
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "Fill the second array with the strings: \"Drummers Drumming\", \"Pipers Piping\", \"Lords a - Leaping\","));
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "\"Ladies Dancing\", \"Maids a - Milking\". Combine both arrays to display a piece of the holiday song."));
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 37: \tPrompt the user to enter five numbers. Store these numbers in an array and output their sum.");
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 38: \tPrompt the user to enter five numbers. Store these numbers in an array and output their average.");
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 39: \tPrompt the user to enter five numbers. Store these numbers in an array and output them");
    Console.WriteLine(String.Format("{0,16}{1,0}", "", "in ascending order."));
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 40: \tPrompt the user to enter five numbers. Store these numbers in an array and output the median.");
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("Exercise 41: \tPrompt the user to enter two numbers. Divide the two numbers and show only two decimal places.");
    Console.WriteLine("----------------------------------------------------------------------------------------------------");
    Console.WriteLine("");
}
static int GetExerciseNumber()
{
    bool gettingUserNumber = true;
    while (gettingUserNumber)
    {
        PrintMenuOfExercises();
        Console.WriteLine("Which exercise would you like to run?");
        Console.WriteLine("");
        Console.Write("Enter a number between 31 and 41 inclusive: ");
        string userInput = Console.ReadLine();
        bool isANumber = int.TryParse(userInput, out int exerciseNumber);
        if (isANumber)
        {
            return exerciseNumber;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, that doesnt appear to be a number. Please try again.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
    return -1;
}
static void DoExercise31()
{
    Console.WriteLine("EXERCISE 31:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. ");
    Console.WriteLine("Prompt the user to enter an index. Display the element in the array at that index.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise31 = true;
    while (doingExercise31)
    {
        int[] thisArray = new int[] {2,8,0,24,51};
        Console.WriteLine("Enter a number from 1 to 5 and I will show you what number exists in the original array at that index.");
        Console.WriteLine("");
        Console.Write("Your Entry: ");
        string userNumber = Console.ReadLine();
        Console.WriteLine("");
        bool isANumber = int.TryParse(userNumber, out int indexNumber);
        if(isANumber)
        {
            if(indexNumber < 1 || indexNumber > 5)
            {
                Console.WriteLine("Sorry, that number appears to be out of range. Let's try again.");

            }
            else
            {
                Console.WriteLine("The original array was: {2, 8, 0, 24, 51}");
                Console.WriteLine("");
                Console.WriteLine($"Your index number was {indexNumber}, which means we want the number in position #{indexNumber} on the list.");
                Console.WriteLine($"The computer begins at zero, so it believes your index number is {indexNumber-1}.");
                Console.WriteLine($"Therefore, the number at the index of {indexNumber-1} and position #{indexNumber} is {thisArray[indexNumber-1]}.");
            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
        }
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise31 = AskingUserToRepeat();
    }
}
static void DoExercise32()
{
    Console.WriteLine("EXERCISE 32:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51. ");
    Console.WriteLine("Prompt the user to enter a number. If the number is in the array, display the index ");
    Console.WriteLine("at which it is located.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise32 = true;
    while (doingExercise32)
    {
        int[] thisArray = new int[] { 2, 8, 0, 24, 51 };
        Console.WriteLine("Enter a number and I will tell you if that number is in our original list.");
        Console.WriteLine("");
        Console.Write("Your Entry: ");
        string userNumber = Console.ReadLine();
        Console.WriteLine("");
        bool isANumber = int.TryParse(userNumber, out int numberToFind);
        if (isANumber)
        {
            if (thisArray.Contains(numberToFind))
            {
                Console.WriteLine("The original array was: {2, 8, 0, 24, 51}");
                Console.WriteLine("");
                Console.WriteLine($"Your number IS in the original array, and it exists at index {Array.IndexOf(thisArray, numberToFind)}.");
            }
            else
            {
                Console.WriteLine("The original array was: {2, 8, 0, 24, 51}");
                Console.WriteLine("");
                Console.WriteLine($"Your number IS NOT in the original array.");

            }
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
        }
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise32 = AskingUserToRepeat();
    }
}
static void DoExercise33()
{
    Console.WriteLine("EXERCISE 33:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Create an array of size 5 and fill it with the following numbers: 2, 8, 0, 24, 51.");
    Console.WriteLine("Let the user change the array by specifying an index and a replacement number.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise33 = true;
    while (doingExercise33)
    {
        ArrayList thisArray = new ArrayList {2,8,0,24,51};
        bool gettingTheseNumbers = true;
        while (gettingTheseNumbers)
        {
            Console.WriteLine("Enter an index number from 0 - 4 and anumber to put in it. I will replace what was in the original array with your new number.");
            Console.WriteLine("");
            Console.Write("Enter the index you wish to change: ");
            string userIndexChoice = Console.ReadLine();
            Console.WriteLine("");
            bool isANumber = int.TryParse(userIndexChoice, out int userIndex);
            if (isANumber)
            {
                if (userIndex >= 0 && userIndex <= 4)
                {
                    Console.Write("Enter the number you wish to add as a replacement: ");
                    string userNumberToAdd = Console.ReadLine();
                    Console.WriteLine("");
                    bool isAnotherNumber = int.TryParse(userNumberToAdd, out int userNum);
                    if (isAnotherNumber)
                    {
                        thisArray.Remove(thisArray[userIndex]);
                        thisArray.Insert(userIndex, userNum);
                        Console.WriteLine("The original array was: { 2, 8, 0, 24, 51 }");
                        Console.Write("The new array with your number added at your specified index is: { ");
                        for (int i = 0; i < thisArray.Count-1; i++)
                        {
                            Console.Write($"{thisArray[i]}, ");

                        }
                        for (int i = thisArray.Count-1; i < thisArray.Count; i++)
                        {
                            Console.Write($"{thisArray[i]} ");

                        }
                        Console.Write("}");
                        Console.WriteLine("");
                    }
                    gettingTheseNumbers = false;
                }
                else
                {
                    Console.WriteLine("Sorry, that number is outside of our specified range. Let's try again.");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to Continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to Continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise33 = AskingUserToRepeat();
    }
}
static void DoExercise34()
{
    Console.WriteLine("EXERCISE 34:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Create an array of size 5 and fill it with the following numbers: 16, 32, 64, 128, 256. ");
    Console.WriteLine("Prompt the user to enter a command, 'half' or 'double'. If the user enters 'half',");
    Console.WriteLine("half all the elements in the array. If the user enters 'double', double all the");
    Console.WriteLine("elements in the array.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise34 = true;
    while (doingExercise34)
    {
        bool halvingAndDoubling = true;
        while (halvingAndDoubling)
        {
            ArrayList thisArray = new ArrayList() { 16, 32, 64, 128, 256 };
            Console.WriteLine("Enter a command of either \"half\" or \"double\" andI will display the respective result of our original list.");
            Console.Write("Your Choice: ");
            string userChoice = Console.ReadLine().ToLower();
            Console.WriteLine("");
            if (userChoice == "half")
            {
                ArrayList halfArray = new ArrayList();
                foreach (int item in thisArray)
                {
                    int half = item / 2;
                    halfArray.Add(half);
                }
                Console.WriteLine("The original array was: { 16, 32, 64, 128, 256 }");
                Console.Write("The new array with those values halved is: { ");
                for (int i = 0; i < halfArray.Count - 1; i++)
                {
                    Console.Write($"{halfArray[i]}, ");

                }
                for (int i = halfArray.Count - 1; i < halfArray.Count; i++)
                {
                    Console.Write($"{halfArray[i]} ");

                }
                Console.Write("}");
                Console.WriteLine("");
                halvingAndDoubling = false;
            }
            else if (userChoice == "double")
            {
                ArrayList doubleArray = new ArrayList();
                foreach (int item in thisArray)
                {
                    int doubleNum = item * 2;
                    doubleArray.Add(doubleNum);
                }
                Console.WriteLine("The original array was: { 16, 32, 64, 128, 256 }");
                Console.Write("The new array with those values doubled is: { ");
                for (int i = 0; i < doubleArray.Count - 1; i++)
                {
                    Console.Write($"{doubleArray[i]}, ");

                }
                for (int i = doubleArray.Count - 1; i < doubleArray.Count; i++)
                {
                    Console.Write($"{doubleArray[i]} ");

                }
                Console.Write("}");
                Console.WriteLine("");
                halvingAndDoubling = false;
            }
            else
            {
                Console.WriteLine("Sorry, that appears to be neither \"half\" nor \"double\". Let's try again.");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise34 = AskingUserToRepeat();
    }
}
static void DoExercise35()
{
    Console.WriteLine("EXERCISE 35:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Create an array of size 5 and fill it with the following strings: \"cow\", \"elephant\",");
    Console.WriteLine("\"jaguar\", \"horse\", \"crow\". Prompt the user to enter two indices separated by a");
    Console.WriteLine("space. The first index will specify the word, and the second will specify a letter in that word.");
    Console.WriteLine("Prompt the user to enter two indices separated by a space. The first index will specify the word,");
    Console.WriteLine("and the second will specify a letter in that word. Display the corresponding word and letter.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise35 = true;
    while (doingExercise35)
    {
        ArrayList originalArray = new ArrayList { 
            "cow", 
            "elephant", 
            "jaguar", 
            "horse", 
            "crow" };
        bool gettingFirstNumber = true;
        while (gettingFirstNumber)
        {
            Console.WriteLine("Enter two numbers, which will represent two indices. I will use those values to return a " +
                "corresponding word and letter index from an original list of words.");
            Console.WriteLine("");
            Console.Write("Enter the index of the word you wish to display: ");
            string wordIndex = Console.ReadLine();
            Console.WriteLine("");
            bool isANumber = int.TryParse(wordIndex, out int trueWordIndex);
            if (isANumber)
            {
                if (trueWordIndex <= originalArray.Count-1 && trueWordIndex >= 0)
                {
                    string wordToDisplay = originalArray[trueWordIndex].ToString();
                    bool gettingSecondNumber = true;
                    while(gettingSecondNumber)
                    {
                        Console.Write("Enter the index of the letter you wish to display: ");
                        string userNumberToAdd = Console.ReadLine();
                        Console.WriteLine("");
                        bool isAnotherNumber = int.TryParse(userNumberToAdd, out int userNum);
                        if (isAnotherNumber)
                        {
                            if (userNum - 1 < wordToDisplay.Length-1 && userNum - 1 >= 0)
                            {
                                char letterToDisplay = wordToDisplay[userNum];
                                Console.WriteLine("The original array is: \n{\"cow\", \"elephant\", \"jaguar\", \"horse\", \"crow\"}");
                                Console.WriteLine("");
                                Console.WriteLine($"The word at index {trueWordIndex} (or position #{trueWordIndex + 1}) in the original array is {wordToDisplay}.");
                                Console.WriteLine($"The letter at index {userNum} (or positon #{userNum + 1}) in the word is {letterToDisplay}.");
                                gettingSecondNumber = false;
                                gettingFirstNumber = false;
                            }
                            else
                            {
                                Console.WriteLine("Looks like that number is bigger than the number of letters in the word. Let's try again.");
                                Console.WriteLine("");
                                Console.WriteLine("Press Enter to Continue.");
                                Console.ReadLine();
                                Console.Clear();
                                gettingSecondNumber = false;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, our list of words doesnt have that many words in it. Let's try again.");
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to Continue.");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Sorry, that doesnt appear to be a number. Let's try again.");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to Continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise35 = AskingUserToRepeat();
    }
}
static void DoExercise36()
{
    Console.WriteLine("EXERCISE 36:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Create two arrays, each of size 5. Fill the first array with the numbers: 12, 11, 10, 9, 8. ");
    Console.WriteLine("Fill the second array with the strings: \"Drummers Drumming\", \"Pipers Piping\", \"Lords a - Leaping\",");
    Console.WriteLine("\"Ladies Dancing\", \"Maids a - Milking\". Combine both arrays to display a piece of the holiday song.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise36 = true;
    while (doingExercise36)
    {
        Console.WriteLine("This is meant to represent Exercise 36.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise36 = AskingUserToRepeat();
    }
}
static void DoExercise37()
{
    Console.WriteLine("EXERCISE 37:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter five numbers. Store these numbers in an array and output their sum.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise37 = true;
    while (doingExercise37)
    {
        Console.WriteLine("This is meant to represent Exercise 37.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise37 = AskingUserToRepeat();
    }
}
static void DoExercise38()
{
    Console.WriteLine("EXERCISE 38:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter five numbers. Store these numbers in an array and output their average.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise38 = true;
    while (doingExercise38)
    {
        Console.WriteLine("This is meant to represent Exercise 38.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise38 = AskingUserToRepeat();
    }
}
static void DoExercise39()
{
    Console.WriteLine("EXERCISE 39:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter five numbers. Store these numbers in an array and output them");
    Console.WriteLine("in ascending order.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise39 = true;
    while (doingExercise39)
    {
        Console.WriteLine("This is meant to represent Exercise 39.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise39 = AskingUserToRepeat();
    }
}
static void DoExercise40()
{
    Console.WriteLine("EXERCISE 40:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter five numbers. Store these numbers in an array and output the median.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise40 = true;
    while (doingExercise40)
    {
        Console.WriteLine("This is meant to represent Exercise 40.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise40 = AskingUserToRepeat();
    }
}
static void DoExercise41()
{
    Console.WriteLine("EXERCISE 41:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter two numbers. Divide the two numbers and show only two decimal places.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise41 = true;
    while (doingExercise41)
    {
        Console.WriteLine("This is meant to represent Exercise 41.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise41 = AskingUserToRepeat();
    }
}
static bool AskingUserToRepeat()
{
    bool askingUser = true;
    while (askingUser)
    {
        Console.WriteLine("Would you like to do this exercise again?");
        Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y" || answer == "y")
        {
            Console.WriteLine("");
            Console.Clear();
            return true;
        }
        else if (answer == "n" || answer == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
            return false;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
            Console.WriteLine("");
        }
    }
    return false;
}
static bool RunProgramAgainPrompt()
{
    bool promptingUser = true;
    while (promptingUser)
    {
        Console.WriteLine("Would you like to do another exercise?");
        Console.WriteLine("Enter 'y' or 'yes' to do another exercise, or enter 'n' or 'no' to exit the program.");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "y" || userInput == "yes")
        {
            Console.WriteLine("");
            Console.Clear();
            return true;
        }
        else if (userInput == "n" || userInput == "no")
        {
            Console.WriteLine("");
            Console.Clear();
            return false;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, I didn't understand that response. Please try again.");
            Console.WriteLine("");
        }
    }
    return false;
}