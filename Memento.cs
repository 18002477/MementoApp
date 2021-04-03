using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTexteditor
{
    class Memento
    {
        string word;

        public Memento(string word)
        {
            this.word = word;
        }

        public string Word()
        {
            return word;
        }
    }
}
