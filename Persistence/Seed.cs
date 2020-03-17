using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Persistence
{
    //klasse for å legge til data i vår migration. 
    public class Seed
    {
        //Datacontext kommer som parameter 
        public static void SeedData(DataContext context)
        {
            //hvis 
            if(!context.Kurs.Any())
            {
                //lager liste av kurs: 
                var kurs = new List<Kurs> 
                {
                    new Kurs
                    {
                        Title = "Past Activity 1",
                        Description = "Activity 2 months ago"
                    },
                    new Kurs
                    {
                        Title = "Past Activity 2",
                        Description = "Activity 1 month ago"
                    },
                    new Kurs
                    {
                        Title = "Future Activity 1",
                        Description = "Activity 1 month in future"
                    }
                   
                };

                context.Kurs.AddRange(kurs);
                context.SaveChanges(); 
            }
        }
    }
}