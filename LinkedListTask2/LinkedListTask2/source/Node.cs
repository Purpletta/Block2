using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTask2
{
    public class Node<T>
    {   public T Data { get; set; }
        public Node(T data)
        {
            Data = data;
        }
     
        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
    }
}
