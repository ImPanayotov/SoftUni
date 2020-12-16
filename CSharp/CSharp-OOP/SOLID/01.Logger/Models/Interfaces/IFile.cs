namespace _01.Logger.Models.Interfaces
{
    public interface IFile
    {
        string Path { get; }

        long Size { get; }

        string Write(ILayout layout, IError error);
    }
}
