using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTexteditor
{
    class Originator
    {
        private string word;

        public void set(string inWord)
        {
            this.word = inWord;
        }

        public void createMemento(string inWordInMemento)
        {
            Memento memento = new Memento(inWordInMemento);

        }

        public string restoreMemento(Memento memento)
        {
            return word;
        }

    }

}
