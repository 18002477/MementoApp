using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTexteditor
{
    class Originator
    {
        private string oneWord;//temp holding cell for what is going to be stored in memento

        public void setWord(string newWord)
        {
            this.oneWord = newWord;
        }

        public Memento createMemento(string inWordInMemento)
        {
            Memento memento = new Memento(inWordInMemento);

            return memento;
        }

        public string restoreFromMemento(Memento memento)
        {
            oneWord = memento.getSavedWord();

            return oneWord;
        }

    }

}
