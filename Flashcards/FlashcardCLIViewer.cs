using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Bentcode.Learning.Flashcards
{
  class FlashcardCLIViewer
  {
    public static List<QAFlashcard> GetAvailableDecks(string path)
    {
      // Test this is a valid path.
      if (IsValidPath(path) == false) return null;

      List<QAFlashcard> Deck = new List<QAFlashcard>();

      using (StreamReader DeckFile = new StreamReader(path))
      {
        string line = DeckFile.ReadToEnd();
        Deck = JsonConvert.DeserializeObject<List<QAFlashcard>>(line);
      }

      return Deck;
    }


    public static void WriteOutDeck(List<Flashcard> Deck, string path)
    {
      using (StreamWriter DeckFile = new StreamWriter(path))
      {
        DeckFile.Write(Deck);
      }
    }


    private static bool IsValidPath(string path, bool allowRelativePaths = false)
    {
      bool isValid = true;

      try
      {
        string fullPath = Path.GetFullPath(path);

        if (allowRelativePaths)
        {
          isValid = Path.IsPathRooted(path);
        }
        else
        {
          string root = Path.GetPathRoot(path);
          isValid = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
        }
      }
      catch (Exception ex)
      {
        isValid = false;
      }

      return isValid;
    }
    internal static void DisplayMenu()
    {
      Console.Clear();
      Console.WriteLine("Flashcard CLI Reviewer");
      Console.WriteLine("--------- --- --------");
      Console.WriteLine("1. Review an existing deck");
      Console.WriteLine("2. Create a Deck of cards");
      Console.WriteLine("3. Modify an existing deck");
      Console.WriteLine("4. Exit this application");

      Console.Write("\nSelection? ");
    }
    internal static int PromptUser()
    {
      string strUsersChoice = "";
      int intUsersChoice = 0;
      bool validChoice = false;

      FlashcardCLIViewer.DisplayMenu();

      do
      {
        strUsersChoice = Console.ReadLine();
        if ((int.TryParse(strUsersChoice, out intUsersChoice)) && (intUsersChoice <= 4)) validChoice = true;
        if (!validChoice)
        {
          Console.BackgroundColor = ConsoleColor.Blue;
          Console.ForegroundColor = ConsoleColor.White;
          Console.WriteLine($"Selection not available! {strUsersChoice}");
          Console.ResetColor();
          Console.Write("Selection? ");
        }

      } while (!validChoice);

      return intUsersChoice;
    }
  }
}
