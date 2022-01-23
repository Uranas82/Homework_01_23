using System;
using System.Collections.Generic;
using System.Linq;

namespace HierarchicalStructureApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var branches = new List<Branch>() {
               new Branch(1, 0, "Adam"),
               new Branch(2, 1, "Bob"),
               new Branch(3, 2, "Jude"),
               new Branch(4, 3, "Alex"),
               new Branch(5, 3, "Ana"),
               new Branch(6, 3, "Richy"),
               new Branch(7, 6, "Dollar"),
               new Branch(8, 6, "Euro")
             };

            branches.ForEach(branch => Console.WriteLine($"ID: { branch.Id}, Name: {branch.Name}, Depth: {GetParentsDepth(branches, branch)};"));
        }

        static int GetParentsDepth(List<Branch> all, Branch current)
        {
            var depth = 1;
            void GetPath(List<Branch> ps, Branch p)
            {
                var parents = all.Where(x => x.Id == p.ParentId);
                foreach (var parent in parents)
                {
                    depth++;
                    GetPath(ps, parent);
                }
            }

            GetPath(all, current);

            return depth;
        }
    }

 
}
