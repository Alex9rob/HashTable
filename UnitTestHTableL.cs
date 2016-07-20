using System;
using HashTable;
using NUnit.Framework;

namespace NUnitTestHashTable
{
        public class UnitTestHTableL
    {
        HTableL t = new HTableL();

        [SetUp]
        public void SetUp()
        {
            t.Clear();
        }
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37, "457 Александр Пушкин 37", TestName = "L_Add1")]
        public void TestMethodAdd1(int id, string fn, string ln, int ag, string res)
        {
            Person p1 = new Person();
            p1.ID = id;
            p1.FName = fn;
            p1.LName = ln;
            p1.Age = ag;
            t.Add(p1);
            int l = t.ToArray().Length;
            Person[] array = new Person[l];
            array = t.ToArray();
            for (int i = 0; i < l; i++)
            {
                Assert.AreEqual(res, array[i].ToString());
            }
        }
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
                    254, "Николай", "Гоголь", 43,
                    new string[] {  "254 Николай Гоголь 43",
                                    "457 Александр Пушкин 37" }, TestName = "L_Add2")]
        public void TestMethodAdd2(int id1, string fn1, string ln1, int ag1,
            int id2, string fn2, string ln2, int ag2, string[] res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Add(p1);
            t.Add(p2);
            int l = t.ToArray().Length;
            Person[] array = new Person[l];
            array = t.ToArray();
            for (int i = 0; i < l; i++)
            {
                Assert.AreEqual(res[i], array[i].ToString());
            }
        }

        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
                   254, "Николай", "Гоголь", 43,
                   new string[] {  "254 Николай Гоголь 43","457 Александр Пушкин 37",
                       "457 Александр Пушкин 37"}, TestName = "L_Add3")]
        public void TestMethodAdd3(int id1, string fn1, string ln1, int ag1,
           int id2, string fn2, string ln2, int ag2, string[] res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Add(p1);
            t.Add(p2);
            t.Add(p1);
            int l = t.ToArray().Length;
            Person[] array = new Person[l];
            array = t.ToArray();
            for (int i = 0; i < l; i++)
            {
                Assert.AreEqual(res[i], array[i].ToString());
            }
        }
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
           254, "Николай", "Гоголь", 43,
           new string[] {  "254 Николай Гоголь 43", "254 Николай Гоголь 43",
               "457 Александр Пушкин 37", "254 Николай Гоголь 43"}, TestName = "L_Add4")]
        public void TestMethodAdd4(int id1, string fn1, string ln1, int ag1,
   int id2, string fn2, string ln2, int ag2, string[] res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Add(p1);
            t.Add(p2);
            t.Add(p2);
            t.Add(p2);
            int l = t.Size();
            Person[] array = new Person[l];
            array = t.ToArray();
            for (int i = 0; i < l; i++)
            {
                Assert.AreEqual(res[i], array[i].ToString());
            }
        }
        ///
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37, "", TestName = "Del0")]
        public void TestMethodDel0(int id, string fn, string ln, int ag, string res)
        {
            Person p1 = new Person();
            p1.ID = id;
            p1.FName = fn;
            p1.LName = ln;
            p1.Age = ag;
            t.Del(p1);
            Assert.AreEqual(res, t.ToString());
        }
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37, "", TestName = "Del1")]
        public void TestMethodDel1(int id, string fn, string ln, int ag, string res)
        {
            Person p1 = new Person();
            p1.ID = id;
            p1.FName = fn;
            p1.LName = ln;
            p1.Age = ag;
            t.Add(p1);
            t.Del(p1);
            Assert.AreEqual(res, t.ToString());
        }

        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
                    254, "Николай", "Гоголь", 43,
                      "254 Николай Гоголь 43, ", TestName = "Del2")]
        public void TestMethodDel2(int id1, string fn1, string ln1, int ag1,
            int id2, string fn2, string ln2, int ag2, string res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Add(p1);
            t.Add(p2);
            t.Del(p1);
            Assert.AreEqual(res, t.ToString());
        }
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
          254, "Николай", "Гоголь", 43,
          new string[] {  "254 Николай Гоголь 43",
               "457 Александр Пушкин 37"}, TestName = "Del3")]
        public void TestMethodDel3(int id1, string fn1, string ln1, int ag1,
                    int id2, string fn2, string ln2, int ag2, string[] res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Add(p1);
            t.Add(p2);
            t.Add(p2);
            t.Add(p2);
            t.Del(p2);
            t.Del(p2);
            int l = t.Size();
            Person[] array = new Person[l];
            array = t.ToArray();
            for (int i = 0; i < l; i++)
            {
                Assert.AreEqual(res[i], array[i].ToString());
            }
        }

        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
                    254, "Николай", "Гоголь", 43,
                      "", TestName = "Set0")]
        public void TestMethodSet0(int id1, string fn1, string ln1, int ag1,
            int id2, string fn2, string ln2, int ag2, string res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Set(p1,p2);
            Assert.AreEqual(res, t.ToString());
        }

        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
            254, "Николай", "Гоголь", 43,
              "254 Николай Гоголь 43, ", TestName = "Set1")]
        public void TestMethodSet1(int id1, string fn1, string ln1, int ag1,
    int id2, string fn2, string ln2, int ag2, string res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Add(p1);
            t.Set(p1, p2);
            Assert.AreEqual(res, t.ToString());
        }

        [Test]
        [TestCase(457, "Александр", "Пушкин", 37, TestName = "Get0")]
        public void TestMethodGet0(int id1, string fn1, string ln1, int ag1)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2 = t.Get(p1);
            Assert.AreEqual(null, p2);
        }
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37, "457 Александр Пушкин 37", TestName = "Get1")]
        public void TestMethodGet1(int id1, string fn1, string ln1, int ag1, string res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            t.Add(p1);
            p2 = t.Get(p1);
            Assert.AreEqual(res, p2.ToString());
        }
        [Test]
        [TestCase(457, "Александр", "Пушкин", 37,
                   254, "Николай", "Гоголь", 43,
                   "457 Александр Пушкин 37", TestName = "Get2")]
        public void TestMethodGet2(int id1, string fn1, string ln1, int ag1,
           int id2, string fn2, string ln2, int ag2, string res)
        {
            Person p1 = new Person();
            p1.ID = id1;
            p1.FName = fn1;
            p1.LName = ln1;
            p1.Age = ag1;
            Person p2 = new Person();
            p2.ID = id2;
            p2.FName = fn2;
            p2.LName = ln2;
            p2.Age = ag2;
            t.Add(p1);
            t.Add(p2);
            t.Add(p1);
            Person p3 = new Person();
            p3 = t.Get(p1);
            int l = t.ToArray().Length;
            Person[] array = new Person[l];
            Assert.AreEqual(res, p3.ToString());
        }
    }
}
