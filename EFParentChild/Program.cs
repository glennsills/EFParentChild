using System;

namespace EFParentChild
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new DbParentChild())
            {
                var parent = new Parent
                {
                    FirstName = "Joe",
                    LastName = "Blow"
                };
                parent.Children.Add(
                    new Child
                    {
                        FirstName = "LittleJoe",
                        LastName = "Blow"
                    });

                dbContext.Add(parent);
                dbContext.SaveChanges();
            }
        }
    }
}
