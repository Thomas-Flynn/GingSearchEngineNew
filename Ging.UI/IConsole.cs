﻿using System;

namespace Ging.UI
{
    public interface IConsole
    {
        void WriteLine(string message);

        void Write(string message);

        string ReadLine();

        void WriteLine(object o);

        void Clear();
    }
}
