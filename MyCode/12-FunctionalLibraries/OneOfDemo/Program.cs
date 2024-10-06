using Dumpify;
using OneOf;


var result1 = GetResult(1);
var result2 = GetResult(-1);
GetResultString(result1).Dump();
GetResultString(result2).Dump();

if (result1.IsT0)
{
    Console.WriteLine($"Result1: {result1.AsT0}");
}
else
{
    Console.WriteLine($"Result1: {result1.AsT1}");
}

if (result2.IsT0)
{
    Console.WriteLine($"Result2: {result2.AsT0}");
}
else
{
    Console.WriteLine($"Result2: {result2.AsT1}");
}


string GetResultString(OneOf<int, string> result)
{
    return result.Match(
        intResult => $"Result: {intResult}",
        stringResult => $"Error: {stringResult}"
    );
}

static OneOf<int, string> GetResult(int input)
{
    if (input > 0)
    {
        return 42; // 返回 int 类型
    }
    else
    {
        return "An error occurred"; // 返回 string 类型
    }
}
