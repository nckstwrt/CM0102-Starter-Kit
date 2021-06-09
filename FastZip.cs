using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CM0102_Starter_Kit
{
    public class FastZip
    {
        // Nick: I want to remove the reliance on ICSharpCode.SharpZipLib.dll - so wrote this is as drop in replacement
        public void ExtractZip(string zipFile, string destinationFolder, object obj)
        {
            using (var zip = ZipStorer.Open(zipFile, FileAccess.Read))
            {
                var dir = zip.ReadCentralDir();
                foreach (var entry in dir)
                {
                    if (entry.FilenameInZip.EndsWith("/"))
                        Directory.CreateDirectory(Path.Combine(destinationFolder, Path.GetDirectoryName(entry.FilenameInZip)));
                    else
                        zip.ExtractFile(entry, Path.Combine(destinationFolder, Path.GetDirectoryName(entry.FilenameInZip), Path.GetFileName(entry.FilenameInZip)));
                }
            }
        }

        public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter)
        {
            var files = Directory.GetFiles(sourceDirectory, "*.*", SearchOption.AllDirectories);
            using (var zip = ZipStorer.Create(zipFileName, ""))
            {
                foreach (var file in files)
                {
                    var cleanFile = ReplaceCaseInsensitive(file, sourceDirectory, "").Replace("\\", "/");
                    zip.AddFile(ZipStorer.Compression.Deflate, file, cleanFile, "");
                }
            }
        }

        private string ReplaceCaseInsensitive(string input, string search, string replacement)
        {
            string result = Regex.Replace(
                input,
                Regex.Escape(search),
                replacement.Replace("$", "$$"),
                RegexOptions.IgnoreCase
            );
            return result;
        }
    }
}
