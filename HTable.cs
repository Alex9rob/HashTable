using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HTable
    {
        Person[] ar = new Person[97];
        public HTable()
        {

        }
        public void Add(Person p)
        {
            int d = ar.Length;
            if (Size() < d)
            {
                int j = GetHashCode(p);
                while (true)
                {
                    int i = j % d;
                    if (ar[i] == null)
                    {
                        ar[i] = p;
                        return;
                    }
                    else
                    {
                        j = j*11/10;
                    }
                }
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
        public void Del(Person p)
        {
            int i = FindIndex(p);
            if (i == -1)
                return;
            ar[i] = null;

        }
        public void Set(Person p, Person p2)
        {
            int i = FindIndex(p);
            if (i == -1)
                return;
            ar[i] = null;
            Add(p2);
        }
        public Person Get(Person p)
        {
            Person p2 = new Person();
            int i = FindIndex(p);
            if (i == -1)
                return null;
            p2 = ar[i];
            return p2;
        }
        public override string ToString()
        {
            string str = "";
            int d = ar.Length;
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
                    n++;
            }
            return n;
        }
        public Person[] ToArray()
        {
            int S = Size();
            int d = ar.Length;
            Person[] arPerson = new Person[S];
            int j = 0;
            for(int i = 0; i<d; i++)
            {
                if (ar[i] != null)
                {
                    arPerson[j] = ar[i];
                    j++;
                }
            }
            return arPerson;
        }
        public int FindIndex(Person p)
        {
            int d = ar.Length;

            int j = GetHashCode(p);
            for (int k = 0; k < d; k++)
            {
                int i = j % d;
                if (ar[i] == p)
                {
                    return i;
                }
                else
                {
                    j = j * 11 / 10;
                }
            }
            return -1;
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
