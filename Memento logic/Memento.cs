using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTexteditor
{
    class Memento//This is the type of data im storing. + set & get
    {
        private string word;

        public Memento(string inWord)//Set memento
        {
            this.word = inWord;
        }

        public string GetWord()//get memento
        {
            return word;
        }
    }
}
