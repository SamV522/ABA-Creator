using ABA_Creator.Entities.ABA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABA_Creator.Entities
{
    class ABAFile
    {
        List<string> Lines;
        DescriptiveRecord descriptiveRecord;
        List<DetailRecord> detailRecords;
        FileTotalRecord fileTotalRecord;

        public void Read(string path)
        {
            Lines = new List<string>();
            Lines.AddRange(File.ReadAllLines(path));
            //descriptiveRecord = Lines[0];

        }
    }
}
