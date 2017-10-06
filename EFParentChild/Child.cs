using System.ComponentModel.DataAnnotations.Schema;

namespace EFParentChild
{
    public class Child
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}