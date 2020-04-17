using System;
using System.IO;

namespace FilesAndFoldersPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE
            //Copy the files folder away from the project.
            //Otherwise you might find thing bit more difficult, since debug folder and such....
            //Creating and copying files won't show in project hierarchy, since they are not included in the project.

            //string currentpath = System.IO.Directory.GetCurrentDirectory();
            //Console.WriteLine(currentpath);

            //string startupPath = Environment.CurrentDirectory;
            //Console.WriteLine(startupPath);

            //notice @ at the start. Needed for using \ in string
            string rootpath = @"C:\Users\pophe\source\repos\FilesAndFoldersPractise\Files\";

            //get only directories in this path
            string[] dirs = Directory.GetDirectories(rootpath,"*", SearchOption.TopDirectoryOnly);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //get files from also from the subdirectories
            //returns files with full path
            var files = Directory.GetFiles(rootpath, "*",SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine(file);
            //    //print files without path
            //    Console.WriteLine(Path.GetFileName(file));
            //    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    Console.WriteLine(Path.GetExtension(file));
            //}

            ////Get the file info
            //foreach (string file in files)
            //{
            //    //instantiate a new FileInfo object
            //    var info = new FileInfo(file);
            //    Console.WriteLine($"{info.FullName} : {info.Length} bytes. created : {info.CreationTime}");
            //}

            //string toSearchFor = "TestDirectory C";
            //bool dirExists = Directory.Exists(rootpath + toSearchFor);

            //if (dirExists)
            //{
            //    Console.WriteLine(toSearchFor+" exists.");
            //}
            //else
            //{
            //    Console.WriteLine(toSearchFor+" was not found.");
            //}

            ////Create Directory
            //string toCreate = "TestDirectory D";
            //Directory.SetCurrentDirectory(rootpath);
            //Directory.CreateDirectory(toCreate);

            ////Copy and move files
            //string[] file = Directory.GetFiles(rootpath, "TestText2*");
            ////File.Copy(file[0], rootpath + "TestDirectory A/CopiedFile.txt");
            //file = Directory.GetFiles(rootpath+"TestDirectory A", "CopiedFile*");
            //Directory.Move(file[0],rootpath+"TestDirectory B/"+Path.GetFileName(file[0]));

        }

    }
}
