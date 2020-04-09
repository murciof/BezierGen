using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierGen
{
    class Document
    {
        int dimensionX;
        int dimensionY;
        int marginX;
        int marginY;
        string documentType;
        public Document(int dimensionX, int dimensionY, int marginX, int marginY, string documentType)
        {
            this.dimensionX = dimensionX;
            this.dimensionY = dimensionY;
            this.marginX = marginX;
            this.marginY = marginY;
            this.documentType = documentType;
        }
    }
}
