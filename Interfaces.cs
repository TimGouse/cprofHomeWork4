
namespace cprofHomeWork4
{
    public interface ISettings
    {
        int Min { get; }
        int Max { get; }
        int Attempts { get; }
    }
    public interface IInputReader
    {
        int ReadInput();
    }

    public interface IOutputWriter
    {
        void WriteOutput(string message);
    }
}
