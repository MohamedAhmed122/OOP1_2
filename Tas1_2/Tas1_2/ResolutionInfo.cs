using System;
using System.Collections.Generic;
using System.Text;

namespace Tas1_2
{
    class ResolutionInfo
    {
        private readonly int PixelsCount;

        private readonly string Resoultion;

        public string GetInfo() => this.Resoultion;

        public ResolutionInfo(string productResolution)
        {
            this.Resoultion = productResolution;
        }
    }
}
