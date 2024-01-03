public static class LoadFile
{
    public static List<Product> LoadFileFromSource(FileData file)    
    {
        if (file.FileExist())
        {
            switch (file.FileExtension())
            {
                case ".json":
                    return new JsonMenuLoader().LoadMenu(file.FileSource());
                case ".csv":
                    return new CsvMenuLoader().LoadMenu(file.FileSource());
                default:
                    throw new FileNotFoundException("This file was not found.");                    
            }            
        }else
        {
            throw new FileNotFoundException("This file was not found.");
        }
    }
}