using metix.Models;
using metix.Services;
using Microsoft.AspNetCore.Mvc;

namespace metix.Controllers
{ 
        [Route("api/[controller]")]
        [ApiController]
        public class UserController : BaseMongoController<User>
        {
            //test deneme
            public UserController(UserRepository UserRepository) : base(UserRepository)
            {
            }


        }   

    }

