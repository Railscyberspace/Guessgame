
using system;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
     
     namespace IntroProgrammingS
{
     class progress
{
    static void main(string[] args)
{
    Random random = new Random();
    int randomNumber = random.Next(1, 11);
    int guess;
    int numberOfGuesses = 6;
    bool gameOver = false;

    console.WriteLine("number between 1 and 10");

    while (gameOver == False)
{
    guess = convert.Toint32(console.ReadLine());
      numberOfGuesses --;

         if (guess!= randomNumber && numberOfGuesses == 0)
        {
          console.WriteLine("wow, three guesses you did not figure out you lose!");
           gameOver = true;
        }
        else if(guess ==  randomNumber)
        {
        console.WriteLine("You win!");
        gameOver = true;
        }
        else if(guess > randomNumber)
        console.WriteLine("My number is smaller than that!");
        else if(guess < randomNumber)
        console.WriteLine("my number is greater than that!");
       }

       console.WriteLine();
        }


