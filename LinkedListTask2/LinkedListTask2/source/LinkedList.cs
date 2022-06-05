using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTask2
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        Node<T> head ; // головной/первый элемент
        Node<T> tail ; // последний/хвостовой элемент
        int count ;  // количество элементов в списке



        public DoublyLinkedList()
        {
           head = null; 
           tail = null; 
           count = 0;  




        }

        public DoublyLinkedList(T[] array)
        {
            count = array.Length;
            head = new Node<T>(array[0]);
            Node<T> previous = null;
            Node<T> current = head;
            for (int i = 1; i < count; i++)
            {
                current.Next = new Node<T>(array[i]);
                current.Previous=previous;
                previous = current;
                current = current.Next;
            }
            current.Next=null;
            current.Previous=previous;
            tail = current;
        }




        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public void Add(Node<T> node) {

            if (head == null) { head = node; }
            else {
                tail.Next = node;
                node.Previous = tail;
            }
            tail=node;
            count++;
        
        }
        public void AddFirst(T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        public void AddFirst(Node<T> node)
        {
            Node<T> current = head;
            node.Next=current;
            head= node;
            if (count == 0)
                tail = head;
            else
                current.Previous = node; 
            count++;
        }
        public void AddLast(T data)
        {
            Node<T> temporaryNode= new Node<T>(data);

            if (head== null)
                head = temporaryNode;
            else
            {
                tail.Next = temporaryNode;
                temporaryNode.Previous = tail;
            }

            tail = temporaryNode;
            count++;
        }

        public void AddLast(Node<T> temporaryNode)
        {
            if (head == null)
                head = temporaryNode;
            else
            {
                tail.Next = temporaryNode;
                temporaryNode.Previous = tail;
            }

            tail = temporaryNode;
            count++;
        }
      
      

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public Node<T> First { get { return head; } }
        public Node<T> Last { get { return tail; } }
        public void AddAfter(Node<T> origin, T data) 
        {
            if (head == null) { return; }
            Node<T> temporaryNode = new Node<T>(data);
            Node<T> current = origin.Next;
            origin.Next = temporaryNode;
            temporaryNode.Previous = origin;
            if (current == null) { tail = temporaryNode; temporaryNode.Next = null;  }
            else { temporaryNode.Next = current; current.Previous = temporaryNode; }
            count++;
        }
        public void AddAfter(Node<T> origin, Node<T> temporaryNode) {
            if (head == null) { return; }
            Node<T> current = origin.Next;
            origin.Next = temporaryNode;
            temporaryNode.Previous = origin;
            if (current == null) { tail = temporaryNode; temporaryNode.Next = null; }
            else { temporaryNode.Next = current; current.Previous = temporaryNode; }
            count++;
        
        }
        public void AddBefore(Node<T> origin, T data) {
            if (head == null) { return; }
            Node<T> temporaryNode = new Node<T>(data);
            Node<T> current = origin.Previous;
            origin.Previous = temporaryNode;
            temporaryNode.Next = origin;
            if (current == null) { head = temporaryNode; temporaryNode.Previous = null; }
            else { temporaryNode.Previous = current; current.Next = temporaryNode; }
            count++;
        
        }
        public void AddBefore(Node<T> origin, Node<T> temporaryNode) {
            if (head == null)
            {
                return;
            }
            Node<T> current = origin.Previous;
            origin.Previous = temporaryNode;
            temporaryNode.Next = origin;
            if (current == null) { head = temporaryNode; temporaryNode.Previous = null; }
            else { temporaryNode.Previous = current; current.Next = temporaryNode; }
            count++;
        }
        public Node<T> getNode(int i)
        {
            if (i >= 0 && i < count)
            {
                Node<T> current = head;
                for (int j = 0; j < i; j++)
                {
                    current = current.Next;
                }

                return current;
            }

            return null;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
        public bool Equals(Object obj) {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else {
               DoublyLinkedList<T> prev = (DoublyLinkedList<T>)obj;
                Node<T> current = head;
                Node<T> currentObj = prev.head;
                if (prev.count == this.count)
                {
                    if (this.count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            if (!Equals(current.Data, currentObj.Data)|| current.Previous != currentObj.Previous ||current.Next != currentObj.Next)
                            {
                                return false;
                            }
                            current = current.Next;
                            currentObj = currentObj.Next;
                        }
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        public Node<T> Find(T data) {
            Node<T> current = head;
            for (int i = 0; i < count; i++) {
                if (Equals(current.Data, data)) { return current; }
                current = current.Next;
            }
            return null;

        }
        public Node<T> FindLast(T data)
        {
            Node<T> current = tail;
            for (int i = 0; i < count; i++)
            {
                if (Equals(current.Data, data)) { return current; }
                current = current.Previous;
            }
            return null;
        }  
        public bool Remove(T data)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
             
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                   
                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    
                    head = current.Next;
                }
                count--;
                return true;
            }
            return false;
        }
        public void RemoveFirst()
        {
            Node<T> current = head.Next;
            head.Next = null; 
            if (current != null)
            {
                current.Previous = null; ;
                head = current;
            }
            else
            {
                head = null;
                tail = null;
            }
            count--;
        }

        public void RemoveLast()
        {
            Node<T> current = tail.Previous;
            head.Previous = null;
            if (current != null)
            {
                current.Next = null; ;
                tail= current;
            }
            else
            {
                head = null;
                tail = null;
            }

            count--;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
} 
