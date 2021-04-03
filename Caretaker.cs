using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTexteditor
{
    class Caretaker
    {
        private Dictionary<DateTime, Memento> mementos = new Dictionary<DateTime, Memento>();

        public void addMemento(DateTime dateTime, Memento memento)
        {
            mementos.Add(dateTime, memento);
        }

        public Memento getMemento(DateTime dateTime)
        {
            return mementos[dateTime];
        }
    }
}
