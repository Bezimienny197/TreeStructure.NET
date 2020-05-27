using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreeStructure.NET.Models
{
    public class Node
    {
        public int NodeId { get; set; }
        public int? RootId { get; set; }
        public string Value { get; set; }
    }
}
