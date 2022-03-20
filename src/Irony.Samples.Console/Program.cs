using Irony.Parsing;
using Irony.Interpreter;
using Irony.Samples;
using Irony.Samples.MiniPython;

Console.Title = "Irony Console Sample";
Console.WriteLine("Irony Console Sample.");
Console.WriteLine("");
Console.WriteLine("Select a grammar to load:");
Console.WriteLine("  1. Expression Evaluator");
Console.WriteLine("  2. mini-Python");
Console.WriteLine("  Or press any other key to exit.");
Console.WriteLine("");
Console.Write("?");
var choice = Console.ReadLine();
Grammar grammar;
switch (choice)
{
    case "1":
        grammar = new SampleExpressionEvaluatorGrammar();
        break;
    case "2":
        grammar = new MiniPythonGrammar();
        break;
    default:
        return;
}
Console.Clear();
var language = new LanguageData(grammar);
var runtime = new LanguageRuntime(language);
var commandLine = new CommandLine(runtime);
commandLine.Run();