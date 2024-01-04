namespace EvaLLVM;

class Program
{
    static void Main(string[] args)
    {
        var program = """hi""";
        var vm = new EvaCompiler();
        vm.exec(program);
    }
}
