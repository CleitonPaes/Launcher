using System.Collections.Generic;

namespace Launcher
{
    internal class Globals
    {
        public static string ServerURL = "http://localhost/update/";
        public static string PatchlistName = "Update.txt";
        public static string BinaryName = "Minecraft.exe";

        public static pForm pForm;

        public static List<File> Files = new List<File>();
        public static List<string> OldFiles = new List<string>();

        public static long fullSize;
        public static long completeSize;

        public struct File
        {
            public string Name;
            public string Hash;
            public long Size;
        }
    }
}
