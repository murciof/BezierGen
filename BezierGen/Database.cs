using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezierGen
{
    class Database
    {
        Document document_a4 = new Document(210, 297, 0, 0, "A4 Paper (210mm x 297mm)");
        Document document_bcard = new Document(80, 50, 0, 0, "Business Card (80mm x 50mm)");
    }
}
