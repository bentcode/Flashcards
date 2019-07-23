using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bentcode.Learning.Flashcards
{
  class FlashcardCLIViewer
  {
    public static string GetAvailableDecks(string location)
    {
      return $"No Decks found at this location: {location}";
    }

    internal static void DisplayMenu()
    {
      int result;
      do
      {
        Console.Clear();
        Console.WriteLine("Flashcard CLI Reviewer");
        Console.WriteLine("--------- --- --------");
        Console.WriteLine("1. Review an existing deck");
        Console.WriteLine("2. Create a Deck of cards");
        Console.WriteLine("3. Modify an existing deck");
        Console.WriteLine("4. Exit this application");
        
        Console.Write("\nSelection? ");

        while (!int.TryParse(Console.ReadLine(), out result)) {
          Console.BackgroundColor = ConsoleColor.Blue;
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine("Selection not available!");
          Console.ResetColor();
          Console.Write("Selection? ");
        };

      } while (result != 4);
    }
  }
}
