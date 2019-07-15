using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bentcode.Learning.Flashcards


{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Start...");

      List<IFlashcard> Deck = new List<IFlashcard>() {
        new Flashcard("Alpha","Alpha Answer"),
        new Flashcard("Beta", "Beta Answer")
      };

      Deck.Add(new Flashcard("Delta", "Delta Answer"));

      foreach (IFlashcard card in Deck)
      {
        Console.WriteLine($"SideA: {card.SideA_Text}; \tSideB: {card.SideB_Text}");
      }


      string jsonData = JsonConvert.SerializeObject(Deck);
      File.WriteAllText(@"d:\data.json", jsonData);

      // serialize JSON directly to a file
      using (StreamWriter file = File.CreateText(@"d:\data2.json"))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, Deck);
      }

      Console.WriteLine("...End");
    }
  }
}

