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
                next = value;
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
        public mylist(mylist nxt,mylist prv, int k)
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
        }
    }

    class Mylist
    {
        protected mylist current;
        protected mylist pointer;
        protected int i;
/*****************************************************************************************************************************************/
        public void Addpoint(int m)               //
        {
            mylist added = new mylist(null, current, m);
            if(current.Next = null)
            {
                current.Next = added;
                added.R = current.R + 1;
                current = current.Next;
            }
            else
            {
                throw Exception("you cant add there");
            }
        }
/* to move to next Class1 ****************************************************************************************************************/
        public void ToNext()
        {
            if(pointer.Next != null)
            {
                pointer = pointer.Next;
            }
            else
            {
                throw Exception("there is no next");
            }
        }

/* to previous to ***********************************************************************************************************************/
        public void ToPrevious()
        {
            if(pointer.Prev != null)
            {
                pointer = pointer.Prev;
            }
            else
            {
                throw Exception("there is no previous");
            }
        }
        public void GotoFirst()
        {
            while(pointer.Prev != null)
            {
                ToPrevious();
            }
        }

        public void GotoPoint(int h)
        {
            if(pointer.R > h)
            {
                while(pointer.R > h)
                {
                    ToNext();
                }
            }
            else if( pointer.R < h)
            {
                while(pointer.R < h)
                {
                    ToPrevious();
                }
            }
            else
            {
            }
        }
        public int GetPoint(int i)
        {
            GotoPoint(i);
            return pointer.R;
        }

        public Mylist(int m)
        {
            current = new mylist(null, null,m);
            Current.R = 1;
            pointer = current;
        }
        ~Mylist()
        {
        }
    }

    class Program
    {
        public static void Main()
        {
            Mylist m1 = new Mylist(2);
            m1.Addpoint
