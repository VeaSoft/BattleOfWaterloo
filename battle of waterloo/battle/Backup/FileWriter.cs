using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace tictacktoe
{
    class FileWriter
    {
        static FileStream fs;
        public static bool writetofile(string filepath,string content)
        {
            
            
            bool successfull = false;
            try
            {
               fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
               content = "arise";
               StreamWriter sw=new StreamWriter(fs);
               sw.WriteLine(content);
               successfull=true;
               fs.Close();
            }
            catch(IOException e)
            {
                successfull=false;
            }
            finally
            {
                fs.Close();
            }
            return successfull;
        }
    }
}
