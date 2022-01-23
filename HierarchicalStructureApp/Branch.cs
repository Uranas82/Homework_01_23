using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalStructureApp
{
    class Branch
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }

        public Branch(int id, int parentId, string name)
        {
            Id = id;
            ParentId = parentId;
            Name = name;
        }
    }
}
