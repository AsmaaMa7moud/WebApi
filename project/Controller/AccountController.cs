using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace project.Controller
{
    public class AccountController : ApiController
    {
        public async Task<IHttpActionResult> postUser(UserModel userModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            ApplicationDbContext dbContext = new ApplicationDbContext();
            UserStore<IdentityUser> userStore = new UserStore<IdentityUser>(dbContext);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(userStore);
            IdentityUser user = new IdentityUser();
            user.UserName = userModel.Name;
            user.Email = userModel.Email;
            user.PasswordHash = userModel.Password;
          IdentityResult result=await manager.CreateAsync(user,userModel.Password);
            if (result.Succeeded)
                return Created("", "User Added");
            return BadRequest(result.Errors.ToList()[0]);
        }
    }
}
