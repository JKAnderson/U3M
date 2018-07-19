using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace U3M
{
    static class ArchiveDictionary
    {
        private const uint prime = 37;
        private static Dictionary<uint, string> hashes;

        static ArchiveDictionary()
        {
            hashes = new Dictionary<uint, string>();
            foreach (string line in Regex.Split(Properties.Resources.DS3Dictionary, "[\r\n]+"))
            {
                string trimmed = line.Trim();
                if (trimmed.Length > 0)
                {
                    uint hash = computeHash(trimmed);
                    hashes[hash] = trimmed;
                }
            }
        }

        private static uint computeHash(string path)
        {
            return path.Replace('\\', '/')
                .ToLowerInvariant()
                .Aggregate(0u, (i, c) => i * prime + c);
        }

        public static bool GetPath(uint hash, out string path)
        {
            return hashes.TryGetValue(hash, out path);
        }
    }
}
