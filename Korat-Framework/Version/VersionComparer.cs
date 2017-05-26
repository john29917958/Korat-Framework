using System;

namespace KoratFramework.Version
{
    public static class VersionComparer
    {
        public static bool GreaterEquals(string version, string benchmark)
        {
            string[] versionTokens = version.Split('.');
            string[] benchmarkTokens = benchmark.Split('.');

            for (int i = versionTokens.Length - 1; i >= 0; i--)
            {
                if (i == benchmarkTokens.Length)
                {
                    return true;
                }

                string versionNumber = versionTokens[i];
                string benchmarkNumber = benchmarkTokens[i];

                if (GreaterOrEquals(versionNumber, benchmarkNumber))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool GreaterOrEquals(string version, string benchmark)
        {
            if (version.Length > benchmark.Length)
            {
                return true;
            }

            if (version.Length < benchmark.Length)
            {
                return false;
            }

            for (int i = 0; i < version.Length; i++)
            {
                int versionNumber = Convert.ToInt32(version[i]);
                int benchmarkNumber = Convert.ToInt32(benchmark[i]);

                if (versionNumber >= benchmarkNumber)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
