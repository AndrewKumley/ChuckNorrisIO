using System;
using System.Collections.Generic;
using System.Text;

namespace ChuckNorrisIO
{
    public class ChuckNorrisClient
    {
        public IEnumerable<string> Categories()
        {
            return new string[] { "dev" };
        }
    }
}
