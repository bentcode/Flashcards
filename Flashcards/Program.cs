using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bentcode.Learning.Flashcards


{
  class Program
  {
    static string dataLocation = @"e:\data.json";

    static void Main(string[] args)
    {
      // Get the list of available decks
      // Offer to the user a menu
      // 1. Review an existing deck
      // 2. Create a Deck of cards
      // 3. Modify an existing deck
      // 4. Exit this application

      List<QAFlashcard> Deck = FlashcardCLIViewer.GetAvailableDecks(dataLocation);

      int result = FlashcardCLIViewer.PromptUser();        

      //FlashcardCLIViewer.WriteOutDeck(Deck, dataLocation);

      foreach (Flashcard card in Deck)
      {
        Console.WriteLine($"SideA: {card.QuestionText}; \tSideB: {card.AnwserText}");
      }


      string jsonData = JsonConvert.SerializeObject(Deck);
      File.WriteAllText(dataLocation, jsonData);

      // serialize JSON directly to a file
      using (StreamWriter file = File.CreateText(@"e:\data2.json"))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, Deck);
      }

      Console.WriteLine("...End");
    }

    
  }
}

