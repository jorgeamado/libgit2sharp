﻿using System;
using System.IO;

namespace LibGit2Sharp
{
    public static class StreamExtensions
    {
        public static void CopyTo(this Stream input, Stream output)
        {
            byte[] buffer = new byte[32768];
            while (true)
            {
                int read = input.Read (buffer, 0, buffer.Length);
                if (read <= 0)
                    return;
                output.Write (buffer, 0, read);
            }
        }
    }
}

