using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    
    public class HTableL
    {   
        ListOfPerson[] ar = new ListOfPerson[97];
         public HTableL()
        {
        }
        public void Add(Person p)
        {
            int d = ar.Length;
            int i = p.GetHashCode();
            i = i % d;
            if (ar[i] == null)
            {
                ar[i] = new ListOfPerson();
                ar[i].AddEnd(p);
            }
            else
            {
                ar[i].AddEnd(p);
            }
        }
        
         public int GetHashCode(Person p)
        {
            string str = p.FName + p.LName;
            int hash = 0;
            foreach ( char c in str)
            {
                hash += (int)c;
            }
            return hash;
        }
        public int ListIndex(Person p)
        {
            int j = GetHashCode(p);
            int i = ar[j].GetPos(p);
            return i;
        }
        public void Del(Person p)
        {
            int i = FindIndex(p);
            int j = ListIndex(p);
            if (j == -1)
                return;
            else
            {
                ar[i].DelPos(j);
            }
        }

        public void Set(Person p, Person p2)
        {
            int i = FindIndex(p);
            int j = ListIndex(p);
            if (j == -1)
                return;
            else
            {
                ar[i].DelPos(j);
            }
            Add(p2);
        }
        public Person Get(Person p)
        {
            Person p2 = new Person();
            int i = FindIndex(p);
            int j = ListIndex(p);
            if (j == -1)
                return null;
            else
            {
                p2 = ar[i].ToArray()[j];
            }
            return p2;
        }
        public override string ToString()
        {
            int d = ar.Length;
            string str = "";
            for (int i = 0; i < d; i++)
            {
                if (ar[i] != null)
                {
                    str += ar[i].ToString() + ", ";
                }
            }
            return str;
        }
        public int Size()
        {
            int d = ar.Length;
            int n = 0;
            for(int i = 0; i<d; i++)
            {
                if (ar[i] != null)
                    n+=ar[i].Size();
            }
            return n;
        }
        public Person[] ToArray()
        {
            int S = Size();
            int d = ar.Length;
            Person[] arPerson = new Person[S];
            int j = 0;
            for (int i = 0; i < d; i++)
            {
                if (ar[i] != null)
                {
                    int l = ar[i].Size();
                    for (int k = 0; k < l; k++)
                    {
                        arPerson[j] = ar[i].ToArray()[k];
                        j++;
                    }
                }
            }
            return arPerson;
        }
        public int FindIndex(Person p)
        {
            int d = ar.Length;
            int i = GetHashCode(p);
            i = i % d;
            return i;
        }
        public void Clear()
        {
            int d = ar.Length;
            for (int i = 0; i<d; i++)
            {
                ar[i] = null;
            }
        }
    }
}
