using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PXRFProcessor;

namespace PXRF_processor
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 0)
            {
                Console.WriteLine("Missing file name.");
                return;
            }

            var file = args[0];

            Console.WriteLine($"Reading {file}");
            var lines = File.ReadLines(file);

            var records = lines.Select(PxrfRecord.CreateRecord).Where(record => record != null).ToList();

            records.AddRange(records.GroupBy(x => x.Record).Select(g =>
                new PxrfRecord {Record = g.Key,
                    RecordTitle = g.Key + "-Avg",
                    AsKa1 = g.Average(a => a.AsKa1),
                    BaLa1 = g.Average(a=>a.BaLa1),
                    CaKa1 = g.Average(a=>a.CaKa1),
                    CrKa1 = g.Average(a=>a.CrKa1),
                    CoKa1 = g.Average(a=>a.CoKa1),
                    CuKa1 = g.Average(a => a.CuKa1),
                    FeKa1 = g.Average(a => a.FeKa1),
                    MnKa1 = g.Average(a => a.MnKa1),
                    MoKa1 = g.Average(a => a.MoKa1),
                    NbKa1 = g.Average(a => a.NbKa1),
                    NiKa1 = g.Average(a => a.NiKa1),
                    PbLa1 = g.Average(a => a.PbLa1),
                    RbKa1 = g.Average(a=>a.RbKa1),
                    RhKa1 = g.Average(a => a.RhKa1),
                    SbKa1 = g.Average(a => a.SbKa1),
                    SrKa1 = g.Average(a => a.SrKa1),
                    SnKa1 = g.Average(a => a.SnKa1),
                    ThLa1 = g.Average(a=> a.ThLa1),
                    TiKa1 = g.Average(a => a.TiKa1),
                    ULa1 = g.Average(a=>a.ULa1),
                    YKa1 = g.Average(a => a.YKa1),
                    ZnKa1 = g.Average(a => a.ZnKa1),
                    ZrKa1 = g.Average(a => a.ZrKa1),
                }));

            File.WriteAllLines("c:\\result\\Output.csv",records.OrderBy(x=>x.RecordTitle).Select(x=>x.ToCsv()));
        }
    }
}
