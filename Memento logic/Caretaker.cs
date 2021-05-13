using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTexteditor
{
    class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void addMemento(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento getMemento(int inIndex)
        {
            return mementos[inIndex];
        }

        public int count()
        {
            return mementos.Count();
        }
    }
}
