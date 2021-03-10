using ABA_Creator.Entities.ABA;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABA_Creator.Entities
{
    class ABAFile
    {
        List<string> Lines;
        public DescriptiveRecord descriptiveRecord { get; private set; }
        public List<DetailRecord> detailRecords { get; private set; } = new List<DetailRecord>();
        public FileTotalRecord fileTotalRecord { get; private set; }

        public ABAFile(string file)
        {
            Read(file);
        }

        public ABAFile(DescriptiveRecord _descriptiveRecord, List<DetailRecord> _detailRecords, FileTotalRecord _fileTotalRecord)
        {
            descriptiveRecord = _descriptiveRecord;
            detailRecords = _detailRecords;
            fileTotalRecord = _fileTotalRecord;
        }

        public void Read(string path)
        {
            Lines = new List<string>();
            Lines.AddRange(File.ReadAllLines(path));
            foreach (string line in Lines)
            {
                switch (line.Substring(0, 1))
                {
                    case "0":   // Descriptive Record
                        descriptiveRecord = new DescriptiveRecord(line);
                        break;
                    case "1":   // Detail Record
                        DetailRecord detailRecord = new DetailRecord(line);
                        detailRecords.Add(detailRecord);
                        break;
                    case "7":   // File Total Record
                        break;
                    default:
                        break;
                }
            }
            fileTotalRecord = new FileTotalRecord((from trans in detailRecords
                                                   where trans.TransactionCode != "13"
                                                   select trans).ToList(),
                                                  (from trans in detailRecords
                                                   where trans.TransactionCode == "13"
                                                   select trans).ToList());
        }

        public override string ToString()
        {
            string str = "";
            str += $"{descriptiveRecord}";
            foreach(DetailRecord record in detailRecords)
            {
                str += $"\r\n{record}";
            }
            str += $"\r\n{fileTotalRecord}";
            return str;
        }
    }
}
