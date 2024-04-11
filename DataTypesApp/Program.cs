namespace DataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Int: {sizeof(int) * 8}, Min: {int.MinValue}, Max: {int.MaxValue}");
            Console.WriteLine($"Uint: {sizeof(uint) * 8}, Min: {uint.MinValue}, Max: {uint.MaxValue}");
            Console.WriteLine($"byte: {sizeof(byte) * 8}, Min: {byte.MinValue}, Max: {byte.MaxValue}");
            Console.WriteLine($"sbyte: {sizeof(sbyte) * 8}, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
            Console.WriteLine($"short: {sizeof(short) * 8}, Min: {short.MinValue}, Max: {short.MaxValue}");
            Console.WriteLine($"ushort: {sizeof(ushort) * 8}, Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
            Console.WriteLine($"long: {sizeof(long) * 8}, Min: {long.MinValue:Ν2}, Max: {long.MaxValue:N2}");
            Console.WriteLine($"ulong: {sizeof(ulong) * 8}, Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
            Console.WriteLine($"float: {sizeof(float) * 8}, Min: {float.MinValue}, Max: {float.MaxValue}");
            Console.WriteLine($"double: {sizeof(double) * 8}, Min: {double.MinValue:N0}, Max: {double.MaxValue}");
            Console.WriteLine($"decimal: {sizeof(decimal) * 8}, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");
            Console.WriteLine($"bool: {sizeof(bool) * 8}, Min: {bool.TrueString}, Max: {bool.FalseString}");
            Console.WriteLine($"char: {sizeof(char) * 8}");
        }
    }
}
