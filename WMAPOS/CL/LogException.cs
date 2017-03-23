using System;
using System.IO;


public class LogException
{
    public static void LogSystemError(Exception ex)
    {
        FileStream fs = new FileStream(String.Format("{0}\\Log\\Log.txt", Directory.GetCurrentDirectory()), FileMode.Append);
        StreamWriter writer = new StreamWriter(fs); //open the file for writing. 
        writer.WriteLine(DateTime.Now.ToString()); //write the current date to the file. change this with your date or something. 
        writer.WriteLine(string.Format("Error message :{0}", ex.Message));
        writer.WriteLine(string.Format("Error source :{0}", ex.Source));
        writer.WriteLine(string.Format("Error method :{0}", ex.TargetSite.Name));
        if (ex.InnerException != null)
            writer.WriteLine(string.Format("Inner exception :{0}", ex.InnerException.Message));
        writer.WriteLine(string.Format("Error stack trace :{0}", ex.StackTrace));
        writer.WriteLine("//////////////////////////End of exception////////////////////////////");
        writer.Close(); //remember to close the file again. 
        writer.Dispose(); //remember to dispose it from the memory. 
    }
}

