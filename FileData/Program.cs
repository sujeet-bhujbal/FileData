using System;
using System.Linq;
using ThirdPartyTools;
using static System.Console;

namespace FileData
{
    public static class Program
    {
        private static readonly string[] VersionDetails = {"-v", "--v", "/v", "--version"};
        private static readonly string[] FilesDetails = {"-s", "--s", "/s", "--size"};

        public static void Main(string[] args)
        {
            try
            {
                ReadVersionAndData(args);
                ReadLine();
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                ReadLine();
            }
        }

        public static dynamic ReadVersionAndData(string[] args)
        {
            if (args.Length <= 0)
            {
                WriteLine("Input is null, Please provide input");
            }
            else
            {
                var fs = new FileDetails();
                if (VersionDetails != null && VersionDetails.Contains(args[0]))
                {
                    WriteLine(fs.Version(args[0]));
                    return fs.Version(args[0]);
                }

                if (FilesDetails != null && FilesDetails.Contains(args[0]))
                {
                    WriteLine(fs.Size(args[0]));
                    return fs.Size(args[0]);
                }
            }

            return string.Empty;
        }
    }
}