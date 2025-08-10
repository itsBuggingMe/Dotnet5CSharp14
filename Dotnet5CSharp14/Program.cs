using System.Runtime.CompilerServices;

namespace Dotnet5CSharp14;

internal partial class CSharp13
{
    static void Main(string[] args) { }
    public void IEnumerableParams(params IEnumerable<int> ints) { }
    public partial string PartialProp { get; }
    public partial string PartialProp => "Impl";
}


internal class CSharp12(int x)
{
    public int PrimaryCtor = x;
    public int[] CollectionExpr = [1, 2, 3];
    public void MoreCollExpr()
    {
        IEnumerable<int> ints = [1, 2, 3];
        IEnumerable<int> ints2 = [1, 2, 3];
        int[] moreInts = [.. ints, .. ints2];
    }
    public void RefReadonly(ref readonly int x) { }
}

file class CSharp11
{
    [Generic<string>]
    public class GenericAttribute<T> : Attribute { }
    nint Nint;
    nuint Nuint;
    public string RawStringLiteral => """
        Hello, World
        Newlines here.
        """;
}

internal class CSharp10
{
    public void NaturalLambdaType()
    {
        var fun = string.IsNullOrEmpty;
    }

    public Func<int> AttributesOnLambdas(Func<int> func) => AttributesOnLambdas([MethodImpl] () => 0);

    public record struct A;
    public readonly record struct B;
    public record class C(int X);

    public C WithKeyword(C c) => c with { X = 1 };

    public const string ConstInterpolatedString = $"This is {nameof(CSharp10)}";
}