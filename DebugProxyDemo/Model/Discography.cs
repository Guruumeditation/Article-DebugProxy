using System.Collections.Generic;

namespace DebugProxyDemo.Model
{
#if DEBUG
    [System.Diagnostics.DebuggerTypeProxy(typeof(DiscographyDebugProxy))]
#endif
    public class Discography
    {
        public string BandName { get; set; }

        public List<Record> Records { get; set; }
    }
}
