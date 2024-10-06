using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;

namespace CSharpFunctionalExtensionsDemo
{
   public class UserService
{
    public Result<User> GetUserByEmail(string email)
    {
        var maybeUser = FindUserByEmail(email);
        if (maybeUser.HasNoValue)
        {
            return Result.Failure<User>("User not found");
        }

        return Result.Success(maybeUser.Value);
    }

    private Maybe<User> FindUserByEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
            return Maybe<User>.None;
        return new User(email, "John Doe");
    }
}
}