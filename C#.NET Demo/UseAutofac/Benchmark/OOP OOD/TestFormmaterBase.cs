//https://stackoverflow.com/questions/761194/interface-vs-abstract-class-general-oo

public abstract class TestFormmaterBase
{
    private readonly ITextWriter _textWriter;

    ///DI DI vs IOC
    protected TestFormmaterBase(ITextWriter sink)
    {
        _textWriter = sink;
    }

    public abstract void FormatResult();

    protected void Write(string str) => _textWriter.Write(str);
    protected void WriteLine() => _textWriter.WriteLine();
    protected void WriteLine(string str) => _textWriter.WriteLine(str);
    protected void WriteLine(string format, params object?[] args) => _textWriter.WriteLine(format, args);
}

interface ITextWriter : IDisposable
{
    void Write(string text);
    void WriteLine();
    WriteLine(string str);
    void WriteLine(string format, params object?[] args);
}

public class DefaultTextFormatter : TestFormmaterBase
{
    public DefaultTextFormatter(ITextWriter sink)
        : base(sink)
    {
        
    }


     public override void FormatResult()
     {

     }
}

public ConsoleTextWriter : ITextWriter
{
    public void Write(string str)
            => Console.Write(str);

    public void WriteLine()
        => Console.WriteLine();

    public void WriteLine(string str) 
        => Console.WriteLine(str);

    public void WriteLine(string format, params object?[] args) => Console.WriteLine(format, args);

    public void Dispose()
    {
    }
}