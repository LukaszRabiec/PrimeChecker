﻿using System;

namespace DelegatesAndEvents
{
    public class ProgressEventArgs : EventArgs
    {
        public int Progress { get; private set; }

        public ProgressEventArgs(int progress)
        {
            Progress = progress;
        }
    }
}
