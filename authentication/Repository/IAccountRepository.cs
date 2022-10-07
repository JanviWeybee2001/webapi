using authentication.Model;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authentication.Repository
{
   public interface IAccountRepository
   {
        Task<IdentityResult> signUpAsync(SignUpModel signUpModel);
        Task<string> LoginAsync(SignInModel signInModel);
   }
}
