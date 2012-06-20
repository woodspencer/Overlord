using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace overlord
{
    class ServerControl
    {
        public void console()
        {
            Process mc_server = new Process();
            try
            {
                mc_server.StartInfo.FileName = "startserver.bat";

                mc_server.StartInfo.CreateNoWindow = false;
                mc_server.StartInfo.UseShellExecute = false;
                mc_server.StartInfo.RedirectStandardInput = true;
                mc_server.StartInfo.RedirectStandardOutput = true;
                mc_server.Start();

                StreamWriter input_writer = mc_server.StandardInput;

                String input_text;

                do
                {

                    input_text = Console.ReadLine();
                    input_writer.WriteLine(input_text);

                } while (input_text != "stop");

                input_writer.Close();

                mc_server.WaitForExit();
                mc_server.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
