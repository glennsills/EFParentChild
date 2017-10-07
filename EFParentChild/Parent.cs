using System.Collections.Generic;

namespace EFParentChild
{
    public class Parent
    {
        public int ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Child> Children { get; set; } = new List<Child>();
    }
}