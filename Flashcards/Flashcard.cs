using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Bentcode.Learning.Flashcards
{
  [DataContract]
  class Flashcard : IFlashcard
  {
    [DataMember]
    public string SideA_Text { get; set; }
    [DataMember]
    public string SideB_Text { get; set; }

    public Flashcard(string SideA, string SideB)
    {
      this.SideA_Text = SideA;
      this.SideB_Text = SideB;
    }
  }
}
