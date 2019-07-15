using System;
using System.Collections.Generic;
using System.Text;

namespace Bentcode.Learning.Flashcards
{
  interface IFlashcard
  {
    string QuestionText { get; set; }
    string AnwserText { get; set; }
    bool ReversibleQandA { get; }

    DateTime NextReview { get; }
    DateTime[] ReviewHistory { get; }
  }
}
