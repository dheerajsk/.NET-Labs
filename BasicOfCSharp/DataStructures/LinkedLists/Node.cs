using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    class Node
    {
        private string data;
        private Node next = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value;  }
        }

    }
}
