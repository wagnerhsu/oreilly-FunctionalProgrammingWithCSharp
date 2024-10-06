using CSharpFunctionalExtensions;
using CSharpFunctionalExtensionsDemo;
using Dumpify;

string r = DoSomething().Match(
    () => "Success",
    (x) => x);
r.Dump();

var user = new UserService().GetUserByEmail("myExample.com");
var k = user.Match(
    (u) => u.Name,
    (x) => x);
k.Dump();    
Result DoSomething()
{
    // Some operation
    bool success = true;

    if (success)
        return Result.Success();
    else
        return Result.Failure("Operation failed");
}