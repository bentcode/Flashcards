using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bentcode.Learning.Flashcards
{
  [DataContract]
  public abstract class Flashcard
  {
    [DataMember]
    public string QuestionText { get; set; }
    [DataMember]
    public string AnwserText { get; set; }

    [DataMember]
    public DateTime NextReview { get; set; }
    [DataMember]
    public DateTime[] ReviewHistory { get; set; }

    [DataMember]
    public bool ReversibleQandA { get; set; }

    public Flashcard(string SideA, string SideB)
    {
      this.QuestionText = SideA;
      this.AnwserText = SideB;
    }
  }
}
