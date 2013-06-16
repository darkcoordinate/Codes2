using System;

namespace Class3
{
    class mylist<T>
    {
        protected mylist<T> next;
        protected mylist<T> prev;
        protected T l;
        protected int r;
        public mylist<T> Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }

        public mylist<T> Prev
        {
            get
            {
                return prev;
            }
            set
            {
                prev = value;
            }
        }

        public T L
        {
            get
            {
                return l;
            }
            set
            {
                l = value;
            }
        }
        public mylist(mylist<T> nxt, mylist<T> prv, int k)
        {
            Next = nxt;
            Prev = prv;
            L = k;
        }

        public int R
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }

        ~mylist()
        {
            Console.WriteLine(" c1 Destructed");
        }
    }

    class Mylist<T>
    {
        protected mylist<T> current;
        public mylist<T> pointer;
        /*****************************************************************************************************************************************/
        public void Addpoint(T m)               //
        {
            mylist<T> added = new mylist<T>(null,current, m);
            if (current.Next == null)
            {
                current.Next = added;
                added.R = current.R + 1;
                current = current.Next;
            }
            else
            {
                throw new Exception("you cant add there");
            }
        }
        /* to move to next Class1 ****************************************************************************************************************/
        public void ToNext()
        {
            if (pointer.Next != null)
            {
                mylist<T> inst;
                inst = pointer;
                pointer = pointer.Next;
                pointer.Prev = inst;
            }
            else
            {
                throw new Exception("there is no next");
            }
        }

        /* to previous to ***********************************************************************************************************************/
        public void ToPrevious()
        {
            if (pointer.Prev != null)
            {
                mylist<T> inst;
                inst = pointer;
                pointer = pointer.Prev;
                pointer.Next = inst;
            }
            else
            {
                throw new Exception("there is no previous");
            }
        }
        public void GotoFirst()
        {
            while (pointer.Prev != null)
            {
                ToPrevious();
            }
        }

        public void GotoPoint(int h)
        {
            if (pointer.R < h)
            {
                while (pointer.R < h)
                {
                    ToNext();
                }
            }
            else if (pointer.R > h)
            {
                while (pointer.R > h)
                {
                    ToPrevious();
                }
            }
            else if( pointer.R == h)
            {
            }
        }
        public int GetPoint(int i)
        {
            GotoPoint(i);
            return pointer.L;
        }

        public Mylist(T m)
        {
            current = new mylist(null, null, m);
            current.R = 1;
            pointer = current;
        }
        ~Mylist()
        {
            Console.WriteLine("Destructed");
        }
    }

    class Program
    {
        public static void Main()
        {
            Mylist<int> m1 = new Mylist<int>(2);
            m1.Addpoint(3);
            m1.Addpoint(4);
            m1.Addpoint(6);
            Console.WriteLine(m1.GetPoint(3));
            Console.WriteLine(m1.GetPoint(1));
            Console.WriteLine(m1.GetPoint(4));
            Console.WriteLine(m1.GetPoint(2));
        }
    }
}
