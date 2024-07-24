using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomizeException.ExceptionHandler;

namespace CustomizeException.Model
{
    public class Person
    {
        public int Age { get; set; }
        public static string AgeCheck(int age)
        {
            try
            {
                if (age < 18)
                {
                    throw new AgeLess("Age is less");
                }
                else
                {
                    Person person = new Person() { Age = age };
                    return "You are eligble to vote";
                }
                
            }
            catch(AgeLess age1) 
            {
                Console.WriteLine(age1.Message);
            }
            return "You are not eligble to vote";

        }
    }
}
    
