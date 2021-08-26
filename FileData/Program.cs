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
            ReadVersion(args);
            ReadSize(args);
            ReadLine();
        }

        public static string ReadVersion(string[] args)
        {
            if (args.Length <= 0)
                WriteLine("Input is null, Please provide input");
            else
            {
                var fs = new FileDetails();
                if (VersionDetails != null && VersionDetails.Contains(args[0]))
                {
                    WriteLine(fs.Version(args[0]));
                    return fs.Version(args[0]);
                }
            }
            return string.Empty;
        }


        public static int ReadSize(string[] args)
        {
            if (args.Length <= 0)
            {
                WriteLine("Input is null, Please provide input");
            }
            else
            {
                var fs = new FileDetails();
                if (FilesDetails != null && FilesDetails.Contains(args[0]))
                {
                    WriteLine(fs.Size(args[0]));
                    return fs.Size(args[0]);
                }
            }
            return 0;
        }
    }
}