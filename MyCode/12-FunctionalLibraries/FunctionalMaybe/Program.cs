// 创建一个可能为空的值
using Functional.Maybe;

var maybeValue = GetValue(true);

// 使用 Maybe 对象处理值
maybeValue.Match(
    value => Console.WriteLine($"Value: {value}"),
    () => Console.WriteLine("No value")
);
maybeValue = GetValue(false);
maybeValue.Match(
    value => Console.WriteLine($"Value: {value}"),
    () => Console.WriteLine("No value")
);

static Maybe<int> GetValue(bool hasValue)
{
    if (hasValue)
    {
        return 42.ToMaybe();
    }
    else
    {
        return Maybe<int>.Nothing;
    }
}