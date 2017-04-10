using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL
{
    public class KppInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<KppContext>
    {
        protected override void Seed(KppContext context)
        {
            var visitors = new List<Visitor>
            {
              
                new Visitor(){
                    LastName = "Stepanov",
                    FirstName = "Maxi",
                    Age = 1,
                    Email = "stepanovonline@gmail.com",
                    Gender = "Male",
                    Telephone = "+38068 25 06 773",
                    Feedback = "All right!"}
               
            };

            visitors.ForEach(s => context.Visitors.Add(s));
            context.SaveChanges();
        }
    }
}
