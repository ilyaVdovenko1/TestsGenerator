using TestsGenerator.Core;

namespace TestsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestsGenerator1 generator = new(@"C:\Users\Lenovo\Documents\бгуир\предметы\3курс\5сем\СПП\лабы\TestGenerator\TestsGenerator\Generated");

            generator.Generate(
                @"C:\Users\Lenovo\Documents\бгуир\предметы\3курс\5сем\СПП\лабы\TestGenerator\TestsGenerator\TestsGenerator.Tests\ClassForTests.cs",
                @"C:\Users\Lenovo\Documents\бгуир\предметы\3курс\5сем\СПП\лабы\TestGenerator\TestsGenerator\TestsGenerator.Core\CodeGenerator.cs"
            ).GetAwaiter().GetResult();
        }
    }
}