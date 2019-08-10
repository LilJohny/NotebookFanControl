﻿using clipr;

namespace NbfcCli.CommandLineOptions
{
    [ApplicationInfo(Name = "nbfc.exe", Description = "NoteBook FanControl CLI client")]
    public class Verbs
    {
        [Verb("start", "Start the service")]
        public StartVerb Start { get; set; }

        [Verb("stop", "Stop the service")]
        public StopVerb Stop { get; set; }

        [Verb("status", "Show the service status")]
        public StatusVerb Status { get; set; }

        [Verb("config", "List or apply configs")]
        public ConfigVerb Config { get; set; }

        [Verb("set", "Control fans")]
        public SetVerb Set { get; set; }
    }
}
