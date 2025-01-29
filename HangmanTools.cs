using System.ComponentModel.Design;

namespace Hangman;

public class HangmanTools
{
    public string GetRandomWord()
    {
        // this creates an instance of the Random class
        // you can use this instance called random to access the methods of the Random class 
        // one of those functions is Next
        Random random = new Random();
        string word = ""; 
        
        // create a list of type string to hold a word bank to pull a random word from 
        // list is a constructor and we are creating a new list object by calling the list constructor  
        // this creates a dynamic list/array that allows you to add and remove things in the list and the list positions adjust 
        List<string> words = new List<string>()
        {
            // add words to the list 
            "Hello",
            "World",
            "customer",
            "synthetic", 
            "maid", 
            "bleach",
            "offbeat", 
            "Laugh"
        };
        
        // Next Method() generates a number between 0 and whatever number you put in the parenthesis
        word = words[random.Next(words.Count)];
        return word;
    }

    public bool ValidGuess(string guess, string lettersGuessed)
    {
        bool result = true; // default to a valid guess 

        if (guess.Length != 1)// check for only one character
        {
            Console.WriteLine("Sorry, the guess must be a single character. Try Again.");
            result = false;
        }
        else if (!Char.IsLetter(guess[0])) // check that the guess is a letter 
        {
            Console.WriteLine("Sorry, the guess must be a letter. Try Again.");
            result = false;
        }
        else if (lettersGuessed.Contains(guess.ToLower())) // check to see if letter has already been guessed. 
        {
            Console.WriteLine("Sorry, you already guessed that letter. Try Again.");
            result = false;
        }
        
        return result;
    }

    public string updateWord(string Lg, string s)
    {
        string result = ""; 
        
        for (int i = 0; i < s.Length; i++)
        {
            if (Lg.Contains(s[i])) //  the letter is in the list
            {
                result += s[i];
            }
            else // the letter is not in the list 
            {
                result += "_";
            }
        }
        return result;
    }
        
}