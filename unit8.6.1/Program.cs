using System;
using System.IO;

class FileCleaner
{
    public static void Main()
    {
        if (Directory.Exists(@"\Users\ggg"))
            return;
        try
        {

            var root = new DirectoryInfo(@"\Users\ggg");

            foreach (var Director in root.GetDirectories())
            {
                if (DateTime.Now - Director.LastWriteTime >= TimeSpan.FromMinutes(30))
                {
                    try { Director.Delete(); }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            foreach (var files in root.GetFiles())
            {
                if (DateTime.Now - files.LastWriteTime <= TimeSpan.FromMinutes(30))
                {
                    try
                    { files.Delete(); }
                    catch (Exception ex)
                    { Console.WriteLine(ex.Message); }

                }
            }



        }
        catch (Exception ex)
        {

        }
    }

}