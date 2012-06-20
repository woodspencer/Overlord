using System;
using System.IO;
using System.Diagnostics;
using System.ComponentModel;

namespace overlord
{
    class Program
    {

        static void Main(string[] args)
        {
            ServerControl server = new ServerControl();
            server.console();

        }
    }
}
