using System.IO;
public class FileData : IFileValidate
{
    readonly string fileName;

    public FileData(string fileName)
    {
        this.fileName = fileName;
    }

    public bool FileExist()
    {            
        return File.Exists(fileName) ? true : false;        
    }

    public string FileExtension()
    {
        return System.IO.Path.GetExtension(fileName);
    }

    public string FileSource(){
        return fileName;
    }
}