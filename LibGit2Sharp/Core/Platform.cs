using System;

namespace LibGit2Sharp.Core
{
    internal enum OperatingSystemType
    {
        Windows,
        Unix,
        MacOSX
    }

    internal static class Platform
    {
        static bool is64Bit()
        {
            string pa = System.Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
            return ((System.String.IsNullOrEmpty(pa) || pa.Substring(0, 3) == "x86") ? false : true);
        }

        public static string ProcessorArchitecture
        {
            get { return  is64Bit() ? "amd64" : "x86"; }
        }

        public static OperatingSystemType OperatingSystem
        {
            get
            {
                // See http://www.mono-project.com/docs/faq/technical/#how-to-detect-the-execution-platform
                switch ((int)Environment.OSVersion.Platform)
                {
                    case 4:
                    case 128:
                        return OperatingSystemType.Unix;

                    case 6:
                        return OperatingSystemType.MacOSX;

                    default:
                        return OperatingSystemType.Windows;
                }
            }
        }
    }
}
