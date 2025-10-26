using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;


namespace SLNK_Shell.codecrafters_shell_csharp.src
{
    internal class Utilities
    {
        public static void Echo(string[] words)
        {
            
            if (words.Length > 0)
            {
                Console.WriteLine(string.Join(" ", words));
                return;
            }
            Console.WriteLine("");
        }

        public static void Type(string[] cmd)
        {
            string message = " is a shell builtin";
            switch (cmd[0])
            {
                case "echo":
                    Console.WriteLine($"echo{message}");
                    break;
                case "exit":
                    Console.WriteLine($"exit{message}");
                    break;
                case "type":
                    Console.WriteLine($"type{message}");
                    break;
                default:
                    GetDir(cmd[0]);
                    break;
            }
           
        }

        internal static void GetDir(string cmd) 
        {
            string operatingSystem = GetOperatingSystem(); //retreives the operating system for checking executable permissions later
            var path = Environment.GetEnvironmentVariable("PATH"); //gets the paths from the environment variable PATH="/usr/bin:/usr/local/bin:$PATH"
            string[] directories = path.Split(Path.PathSeparator); //splits the paths into an array

            foreach (var directory in directories) //iterates through each directory in the PATH variable which is now in the directories array
            {
                if (File.Exists(Path.Combine(directory, cmd)))    //checks if file exists in directory
                {
                    var fullPath = Path.Combine(directory, cmd); //combines directory and command to get full path

                    if(IsExecutable(fullPath, operatingSystem))
                    {
                        Console.WriteLine(fullPath);
                        return;
                    } 
                    ;     //need to still check if its executable

                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{String.Join(" ", cmd)}: not found");
            Console.ResetColor();
        }

        internal static string GetOperatingSystem()
        {
            if (OperatingSystem.IsWindows())
            {
                return "Windows";
            }
            else if (OperatingSystem.IsLinux())
            {
                return "Linux";
            }
            else if (OperatingSystem.IsMacOS())
            {
                return "MacOS";
            }
            else
            {
                return "Unknown OS";
            }
        }
        internal static bool IsExecutable(string filePath, string operatingSystem)
        {
            if (operatingSystem == "Windows")
            {
                // On Windows, check for common executable extensions
                string[] executableExtensions = { ".exe", ".bat", ".cmd", ".com" }; // list of executable file extensions
                string fileExtension = Path.GetExtension(filePath).ToLower(); // get the file extension of the given file and convert to lowercase
                return executableExtensions.Contains(fileExtension); // check if the file extension is in the list of executable extensions
            }
            else
            {
                var file = new FileInfo(filePath); // create a FileInfo object to access file properties
                var mode = file.UnixFileMode; // get the Unix file mode (permissions)
                bool isExecutable = (mode & (UnixFileMode.UserExecute | UnixFileMode.GroupExecute | UnixFileMode.OtherExecute)) != 0; // check if any execute permission is set
                return isExecutable;
            }
        }


    }
}
