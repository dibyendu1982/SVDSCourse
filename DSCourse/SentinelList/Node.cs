using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSCourse.SentinelList
{
    public class Node
    {
        public Node Previous { get; set; }

        public Node Next { get; set; }

        public int Value { get; set; }
        public Node(int value)
        {
            this.Value = value;
        }
    }
}
