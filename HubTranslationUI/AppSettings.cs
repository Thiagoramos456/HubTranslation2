using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubTranslationUI
{
    public class AppSettingsJson
    {
        public AppSettings? AppSettings { get; set; }
    }
    public class AppSettings
    {
        public string? UserSelectedFolder { get; set; }
    }
}
