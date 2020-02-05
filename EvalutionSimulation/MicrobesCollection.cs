using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EvalutionSimulation
{
    public class MicrobesCollection
    {
        public Microbe First;
        public int Count = 0;

        public MicrobesCollection()
        {
            First = null;
        }

        public MicrobesCollection(Microbe m)
        {
            First = m;
            m.Prev = null;
            m.Next = null;
            Count++;
        }

        public void Add(Microbe m)
        {
            if (First != null)
            {
                m.Next = First;
                First.Prev = m;
            }
            m.Prev = null;
            First = m;
            Count++;
        }

        public void Remove(Microbe m)
        {
            if (m == First)
                First = m.Next;
            if (m.Prev != null)
                m.Prev.Next = m.Next;
            if (m.Next != null)
                m.Next.Prev = m.Prev;
            m.Next = null;
            m.Prev = null;
            m.IsAlive = false;
            Count--;
        }

        public void Clear()
        {
            if (First != null)
            {
                First.Next = null;
                First.Prev = null;
                First = null;
            }
            Count = 0;
        }
    }
}
