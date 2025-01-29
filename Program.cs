// Create an instance of the class 

using Hangman;

HangmanTools ht = new HangmanTools();

string solution = "";
string guess = "";
string lettersGuessed = "";
int lives = 6; 

bool gameOver = false;

// welcome user to the game and generate a random word 
Console.WriteLine("Welcome to Hangman!");
Console.WriteLine("Generating a random word... ");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");
Thread.Sleep(500);
Console.Write(".");

solution = ht.GetRandomWord();

Console.WriteLine("");
Console.WriteLine("Alright, I've got a word!");

do
{
    // get user guess and make sure it is valid 
    Console.WriteLine("What is your guess? Please enter a single letter: ");

    do
    {
        guess = Console.ReadLine();
    } while (!ht.ValidGuess(guess, lettersGuessed)); // this says while true. The function returns true or false.
    // So we wait until it returns true
    
    // add the guess to the letters guessed variable 
    lettersGuessed += guess;

    // Check to see if the guess is in the solution 
    if (solution.Contains(guess))
    {
        Console.WriteLine($"Yes the letter {guess} is in the word!");
        
        
        if (ht.updateWord(lettersGuessed, solution) == solution)
        {
            Console.WriteLine("Congratulations! You Won!");
            gameOver = true;
        }
        Console.WriteLine($"Word: {ht.updateWord(lettersGuessed, solution)}");
    }
    else 
    {
        Console.WriteLine($"Sorry, the letter {guess} is not in the word!");
        lives --;
        
        if (lives > 0)
        {
            Console.WriteLine($"You have {lives} lives left.");
        }
        else
        {
            Console.WriteLine($"You lose the game.");
            Console.WriteLine($"The word was {solution}");
            gameOver = true;
        }
        
    }

} while (!gameOver);

Console.WriteLine("Thanks for playing! Please come again.");

         

