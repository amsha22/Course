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
                        Title = "Kurs om data",
                        Description = "Kurset handler om personvern og slikt"
                    },
                    new Kurs
                    {
                        Title = "OsloMet kurs",
                        Description = "KURS KURS"
                    },
                    new Kurs
                    {
                        Title = "Future",
                        Description =  "1 month in future"
                    }
                   
                };

                context.Kurs.AddRange(kurs);
                context.SaveChanges(); 

            }
        }
    }
}