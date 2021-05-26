using System;

namespace Laba8Lib
{
    public class Node
    {
        public float Data { get; set; }
        public Node Next { get; set; }
        public Node(float data)
        {
            Data = data;
        }
    }
}
