using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierGen
{
    class Document
    {
        private int dimensionX;
        private int dimensionY;
        private string documentType;
        public Document(int dimensionX, int dimensionY, string documentType)
        {
            this.dimensionX = dimensionX;
            this.dimensionY = dimensionY;
            this.documentType = documentType;
        }

        public int GetDimensionX()
        {
            return dimensionX;
        }

        public int GetDimensionY()
        {
            return dimensionY;
        }
        public string GetDocumentType()
        {
            return documentType;
        }
    }
}
