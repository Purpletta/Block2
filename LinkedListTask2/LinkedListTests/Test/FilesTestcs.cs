using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTask2;
using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace LinkedListTests
{
    namespace LinkedListTests
{
    [TestClass]
   public class FilesTestcs
    {
            Extends<int> extend = new Extends<int>();
            private string WayToTestData = "/Users/raida/OneDrive/Desktop/task2c#/LinkedListTask2/LinkedListTests/Test/TestData1.txt";

            [TestMethod]
            public void AddLastByDataTest()
            {
                string line;
                string data = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddLastByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line;
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddLast(data);
                Assert.AreEqual(data, testList.Last.Data);
            }

            [TestMethod]
            public void AddFirstByDataTest()
            {
                string line;
                string data = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddFirstByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line;
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddFirst(data);
                Assert.AreEqual(data, testList.First.Data);
            }

            [TestMethod]
            public void AddLastByNodeTest()
            {
                string line;
                string data = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddLastByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line;
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddLast(new Node<string>(data));
                Assert.AreEqual(data, testList.Last.Data);
            }

            [TestMethod]
            public void AddFirstByNodeTest()
            {
                string line;
                string data = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddFirstByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line;
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddFirst(new Node<string>(data));
                Assert.AreEqual(data, testList.First.Data);
            }

            [TestMethod]
            public void AddAfterByDataTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddAfterByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddAfter(testList.getNode(Convert.ToInt32(data[0])), data[1]);
                Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).Next.Data);
            }

            [TestMethod]
            public void AddBeforeByDataTest()
            {
                string line;
                string[] data = new string[2];
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddBeforeByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddBefore(testList.getNode(Convert.ToInt32(data[0])), data[1]);
                Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).Data);
            }

            [TestMethod]
            public void AddAfterByNodeTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddAfterByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddAfter(testList.getNode(Convert.ToInt32(data[0])), new Node<string>(data[1]));
                Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).Next.Data);
            }

            [TestMethod]
            public void AddBeforeByNodeTest()
            {
                string line;
                string[] data = new string[2];
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AddBeforeByDataTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                string[] arr = new[] { "1", "2", "3" };
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(arr);
                testList.AddBefore(testList.getNode(Convert.ToInt32(data[0])), new Node<string>(data[1]));
                Assert.AreEqual(data[1], testList.getNode(Convert.ToInt32(data[0])).Data);
            }

            [TestMethod]
            public void ClearTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "ClearTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
                testList.Clear();
                
                    Assert.AreEqual(testList.First, null);
                    Assert.AreEqual(testList.Last, null);
                
            }

            [TestMethod]
            public void ContainsTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "ContainsTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
                
                    for (int i = 0; i < data.Length; i++)
                    {
                        Assert.AreEqual(testList.Contains(testList.getNode(i).Data), true);
                    }
                    Assert.AreEqual(testList.Contains("TheCakeIsReal"), false);
              
            }

            [TestMethod]
            public void FindTest()
            {
                string line;
                string[] input = new string[2];
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "FindTest")
                    {
                        line = sr.ReadLine();
                        input = line.Split(' ');
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
               
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
                Assert.AreEqual(testList.Find(input[0]), testList.getNode(Convert.ToInt32(input[1])));
            }

            [TestMethod]
            public void FindLastTest()
            {
                string line;
                string[] input = new string[2];
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "FindLastTest")
                    {
                        line = sr.ReadLine();
                        input = line.Split(' ');
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
               
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
                Assert.AreEqual(testList.FindLast(input[0]), testList.getNode(Convert.ToInt32(input[1])));
            }

            [TestMethod]
            public void EqualsTest()
            {
                string line;
                bool boolean = false;
                string[] data1 = new string[] { };
                string[] data2 = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "EqualsTest")
                    {
                        line = sr.ReadLine();
                        boolean = Convert.ToBoolean(line);
                        line = sr.ReadLine();
                        data1 = line.Split(' ');
                        line = sr.ReadLine();
                        data2 = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }
                sr.Close();
                DoublyLinkedList<string> testList1 = new DoublyLinkedList<string>(data1);
                DoublyLinkedList<string> testList2 = new DoublyLinkedList<string>(data2);
               
                    Assert.AreEqual(testList1.Equals(testList1), true);
                    Assert.AreEqual(testList2.Equals(testList2), true);
                    Assert.AreEqual(testList1.Equals(testList2), boolean);
                    Assert.AreEqual(testList2.Equals(testList1), boolean);
              
            }

            [TestMethod]
            public void RemoveNodeByDataTest()
            {
                string line;
                string input = null;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "RemoveNodeByDataTest")
                    {
                        line = sr.ReadLine();
                        input = line;
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
                DoublyLinkedList<string> copyList = new DoublyLinkedList<string>(data);
                testList.Remove(input);
                Assert.AreEqual(testList.Equals(copyList), false);
            }



            [TestMethod]
            public void RemoveFirstTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "RemoveFirstTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
                DoublyLinkedList<string> copyList = new DoublyLinkedList<string>(data);
                testList.RemoveFirst();
                Assert.AreEqual(testList.First.Data, copyList.getNode(1).Data);
            }

            [TestMethod]
            public void RemoveLastTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "RemoveLastTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                DoublyLinkedList<string> testList = new DoublyLinkedList<string>(data);
                DoublyLinkedList<string> copyList = new DoublyLinkedList<string>(data);
                testList.RemoveLast();
                Assert.AreEqual(testList.Last.Data, copyList.getNode(data.Length - 2).Data);
            }

           

            [TestMethod]
            public void AnyTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "AnyTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                Assert.AreEqual(extend.Any(data), true);
            }


            [TestMethod]
            public void CountTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "CountTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                Assert.AreEqual(extend.Count(data), data.Length);
            }

            [TestMethod]
            public void ElementAtTest()
            {
                string line;
                string[] data = new string[] { };
                string input = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "ElementAtTest")
                    {
                        line = sr.ReadLine();
                        input = line;
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                Assert.AreEqual(extend.ElementAt(data, Convert.ToInt32(input)), data[Convert.ToInt32(input)]);
            }

            [TestMethod]
            public void ElementAtOrDefaultTest()
            {
                string line;
                string[] data = new string[] { };
                string input = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "ElementAtOrDefaultTest")
                    {
                        line = sr.ReadLine();
                        input = line;
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
               
                    Assert.AreEqual(extend.ElementAtOrDefault(data, 1000000), null);
                    Assert.AreEqual(extend.ElementAt(data, Convert.ToInt32(input)), data[Convert.ToInt32(input)]);
             
            }

            [TestMethod]
            public void FirstTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "FirstTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                Assert.AreEqual(extend.First(data), data[0]);
            }

            [TestMethod]
            public void LastTest()
            {
                string line;
                string[] data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "LastTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                Assert.AreEqual(extend.Last(data), data[data.Length - 1]);
            }


            [TestMethod]
            public void MaxTest()
            {
                string line;
                string[] data = new string[] { };
                string max = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "MaxTest")
                    {
                        line = sr.ReadLine();
                        max = line;
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                Assert.AreEqual(extend.Max(data, (i1, i2) => i1.Length < i2.Length), max);
            }

            [TestMethod]
            public void MinTest()
            {
                string line;
                string[] data = new string[] { };
                string min = null;
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "MinTest")
                    {
                        line = sr.ReadLine();
                        min = line;
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                Assert.AreEqual(extend.Min(data, (i1, i2) => i1.Length < i2.Length), min);
            }

            [TestMethod]
            public void ReverseTest()
            {
                string line;
                string[] data = new string[] { };
                string[] rev_data = new string[] { };
                StreamReader sr = new StreamReader(WayToTestData);
                line = sr.ReadLine();
                while (line != null)
                {
                    if (line == "ReverseTest")
                    {
                        line = sr.ReadLine();
                        data = line.Split(' ');
                        line = sr.ReadLine();
                        rev_data = line.Split(' ');
                        line = null;
                    }
                    else
                    {
                        line = sr.ReadLine();
                    }
                }

                sr.Close();
                string[] rev_arr = extend.Reverse(data);
               
                Enumerable.SequenceEqual(rev_arr, data);
            }
        }

    }
}
