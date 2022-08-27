using System;

namespace Launcher
{
    internal class ListProcessor
    {
        public static void AddFile(string File)
        {
            Globals.File file = new Globals.File
            {
                Name = File.Split(' ')[0],
                Hash = File.Split(' ')[1]
            };
            try
            {
                file.Size = Convert.ToInt64(File.Split(' ')[2]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Globals.Files.Add(file);
        }
    }
}
