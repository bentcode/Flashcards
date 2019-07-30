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

      Deck deck = new Deck("CSharp");

      //deck.Cards.Add(new QACFlashcard("What is a 'Field'?", "A data member of the class. \n\nIn general they should not be public… only private or protected."));
      //deck.Cards.Add(new QACFlashcard("How do you define an indexer?", "You must user the 'this' followed by square brackets"));
      //deck.Cards.Add(new QACFlashcard("What is a class 'Event'?", "Class members that allow an object to notify subscribers whenever something noteworthy happens.\n\nExamples of an event is a field or property change."));
      //FlashcardCLIViewer.WriteOutDeck(deck, dataLocation);

      deck = FlashcardCLIViewer.GetAvailableDecks(dataLocation);

      int result = FlashcardCLIViewer.PromptUser();



      //foreach (Flashcard card in deck)
      //{
      //  Console.WriteLine($"SideA: {card.QuestionText}; \tSideB: {card.AnwserText}");
      //}

      for (int i = 0; i < deck.Length(); i++)
      {
        Console.WriteLine($"SideA: {deck[i].QuestionText}; \tSideB: {deck[i].AnwserText}");
      }

      string jsonData = JsonConvert.SerializeObject(deck);
      File.WriteAllText(dataLocation, jsonData);

      // serialize JSON directly to a file
      using (StreamWriter file = File.CreateText(@"e:\data2.json"))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, deck);
      }

      Console.WriteLine("...End");
    }

    
  }
}

