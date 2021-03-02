using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedLists
{
    class DLNode
    {
        private string data;
        private DLNode next = null;

        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public DLNode Next
        {
            get { return this.next; }
            set { this.next = value; }
        }

        public DLNode Prev { get; set; }

    }
}
