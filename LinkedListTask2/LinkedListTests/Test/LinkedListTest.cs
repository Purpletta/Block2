using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListTask2;
using System.Collections.Generic;

namespace LinkedListTests
{
    [TestClass]
    public class LinkedListTest
    {
        [TestMethod]
        public void CountTest()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            Assert.AreEqual(0, list.Count);

        }

        [TestMethod]
        public void GetFirstTest()
        {

            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            Assert.AreEqual(null, list.First);

        }
        [TestMethod]
        public void GetLastTest() {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            Assert.AreEqual(null, list.Last);
        
        
        }

        [TestMethod]
        public void AddByDataTest()  {
        DoublyLinkedList<int> list= new DoublyLinkedList<int>();
            list.Add(1);
            Assert.AreEqual(1, list.Last.Data);
        
        }
        [TestMethod]
        public void AddByNodeTest () {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            Node<int> node = new Node<int>(1);
            list.Add(node);
            Assert.AreEqual(node.Data, 1);
        
        }
        [TestMethod]
        public void AddFirstByDataTest() {

            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddFirst(1);
            Assert.AreEqual(1, list.First.Data);
        }

        [TestMethod]
        public void AddFirstByNodeTest() {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            Node<int> node = new Node<int>(1);
            list.AddFirst(node);
            Assert.AreEqual(1, list.First.Data);
        
        }
        [TestMethod]
        public void AddLastByDataTest()
        { int[] arr = new[] {0, 1, 2};
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.AddLast(3);
            Assert.AreEqual(3, list.Last.Data);  

        }

        [TestMethod]

        public void AddLastByNodeTest()
        {
            int[] arr = new[] { 0, 1, 2 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            Node<int> node = new Node<int>(5);
            list.AddLast(node);
            Assert.AreEqual(5, list.Last.Data);

        }

        [TestMethod]


        public void AddAfterByDateTest() {
            int[] arr = new[] { 0, 1, 2 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.AddAfter(list.First, 10);
            Assert.AreEqual(10, list.First.Next.Data);

        
        }

        [TestMethod]

        public void AddAfterByNodeTest() {
            int[] arr = new[] { 0, 1, 2 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.AddAfter(list.First, new Node<int>(10));
            Assert.AreEqual(10, list.First.Next.Data);
        }

        [TestMethod]

        public void AddBeforeByDataTest() {
            int[] arr = new[] { 0, 1, 2 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.AddBefore(list.Last, 10);
            Assert.AreEqual(list.Last.Previous.Data,10);
        
        }

        [TestMethod]


        public void AddBeforeByNodeTest() {
            int[] arr = new[] { 0, 1, 2 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.AddBefore(list.Last,new Node<int> (10));
            Assert.AreEqual(10,list.Last.Previous.Data);

        
        }
        [TestMethod]
        public void ClearTest()
        {
            int[] arr = new[] { 0,1,2};
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.Clear();
            
                Assert.AreEqual(list.First, null);
                Assert.AreEqual(list.Last, null);
        }

        [TestMethod]

        public void ContainsTest()
        {
            int[] arr = new[] {0,1,2};
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
           
                Assert.AreEqual(list.Contains(2), true);
                Assert.AreEqual(list.Contains(3), false);
            }


        [TestMethod]

        public void EqualTest()
        {
            int[] arr = new[] { 0,1,2,3 };
            DoublyLinkedList<int> list1 = new DoublyLinkedList<int>(arr);
            DoublyLinkedList<int> list2 = new DoublyLinkedList<int>();
            
                Assert.AreEqual(list1.Equals(list1), true);
                Assert.AreEqual(list1.Equals(list2), false);
                Assert.AreEqual(list1.Equals(arr), false);
           
        }

        [TestMethod]

        public void FindTest() {

            int[] arr = new[] {0,1,2};
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
           
                Assert.AreEqual(list.Find(2), list.Last);
                Assert.AreEqual(list.Find(10), null);
            
        }
        [TestMethod]

        public void FindLastTest() {
            int[] arr = new[] { 1, 2, 2, 2, 3,2,3 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);

            Assert.AreEqual(list.FindLast(2), list.Last.Previous); ;
                Assert.AreEqual(list.FindLast(10), null);
          

        }

        [TestMethod]

        public void RemoveTest() {
            int[] arr = new[] { 0,1,2 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.Remove(1);
            Assert.AreEqual(list.Last.Data, 2);

        }


        [TestMethod]

        public void RemoveFirstTest() {
            int[] arr = new[] { 0,1,2 };
            DoublyLinkedList<int> list = new DoublyLinkedList<int>(arr);
            list.RemoveFirst();
            Assert.AreEqual(list.First.Data, 1);

        }

        [TestMethod]


        public void RemoveLastTest(){
            int[] arr = new[] { 0, 1, 2 };
            DoublyLinkedList<int> list= new DoublyLinkedList<int>(arr);
            list.RemoveLast();
            Assert.AreEqual(list.Last.Data, 1);



        }


     

    }





    }

