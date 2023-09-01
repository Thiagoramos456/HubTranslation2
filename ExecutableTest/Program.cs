using LibreTranslate;
using System;
using System.IO;

namespace ExecutableTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var translation = new Translation();
            var response = await translation.Translate("Hello, World!", "en");
            var response2 = await translation.Translate("Hello, World!", "it");
            var response3 = await translation.Translate("Hello, World!", "es");

        }
    }
}