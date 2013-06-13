using System;

namespace Class3
{
    class mylist
    {
        protected mylist next;
        protected mylist prev;
        protected int l;
        protected int r;
        public mylist Next
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

        public mylist Prev
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

        public int L
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
        public mylist(mylist nxt, mylist prv, int k)
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

    class Mylist
    {
        protected mylist current;
        public mylist pointer;
        /*****************************************************************************************************************************************/
        public void Addpoint(int m)               //
        {
            mylist added = new mylist(null,current, m);
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
                mylist inst;
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
                mylist inst;
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

        public Mylist(int m)
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
            Mylist m1 = new Mylist(2);
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
