using System;
  
namespace metix.Models
{
    
        public class User : MongoBaseModel
        {
            public String Name { get; set; }
            public String Surname { get; set; }
            public String Email { get; set; }
            public String Password { get; set; }
             
        }
    }

