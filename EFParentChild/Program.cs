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
                    LastName = "Smith"
                };

                parent.Children.Add(
                    new Child
                    {
                        FirstName = "LittleJoe",
                        LastName = "Smith"
                    });
                parent.Children.Add(
                    new Child
                    {
                        FirstName = "Anne",
                        LastName = "Smith"
                    });

                dbContext.Add(parent);
                dbContext.SaveChanges();
            }
        }
    }
}
