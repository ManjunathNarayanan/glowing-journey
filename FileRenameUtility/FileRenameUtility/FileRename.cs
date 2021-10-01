using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenameUtility
{
    class FileRename
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Hello********\r\nThis utility renames all files and folders in given path so that the first letter of each word is uppercase.");
            Console.WriteLine("Please enter the input path:");
            string InputDir = string.Empty;
            while (true)
            {
                InputDir = Console.ReadLine();
                if (Directory.Exists(InputDir))
                {
                    break;
                }
                Console.WriteLine("Please Enter a valid Path:");
            }

            Console.WriteLine("Processing Files...");
            

            UpdateFileNames(InputDir, true);
            UpdateFileNames(InputDir, false);

            Console.WriteLine("Done! Press any key to exit");
            Console.ReadKey();
        }

        private static void UpdateFileNames(string inputDir, bool bDirectoriesOnly)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string[] paths = null;
            if (bDirectoriesOnly)
            {
                paths = Directory.GetDirectories(inputDir, "*", SearchOption.AllDirectories);
            }
            else
            {
                paths = Directory.GetFiles(inputDir, "*.*", SearchOption.AllDirectories);
            }
            try
            {
                foreach (string file in paths)
                {
                    string OldName = string.Empty;
                    string NewName = string.Empty;
                    string ParentDirPath = Path.GetDirectoryName(file);
                    if (bDirectoriesOnly)
                    {
                        OldName = new DirectoryInfo(file).Name;
                        NewName = textInfo.ToTitleCase(OldName);
                        Directory.Move(Path.Combine(ParentDirPath, OldName), Path.Combine(ParentDirPath, "TEMP"));
                        Directory.Move(Path.Combine(ParentDirPath, "TEMP"), Path.Combine(ParentDirPath,  NewName));
                    }
                    else
                    {
                        OldName = Path.GetFileName(file);
                        NewName = textInfo.ToTitleCase(OldName);
                        File.Move(Path.Combine(ParentDirPath, OldName), Path.Combine(ParentDirPath, "temp"));
                        File.Move(Path.Combine(ParentDirPath, "temp"), Path.Combine(ParentDirPath, NewName));
                    }         
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception:" + ex.Message);
                Console.WriteLine("StackTrace:" + ex.StackTrace);
            }
        }
    }
}