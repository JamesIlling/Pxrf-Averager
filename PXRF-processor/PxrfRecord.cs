using System;

namespace PXRFProcessor
{
    public class PxrfRecord
    {
        private const string Separator = ",";

        public static PxrfRecord CreateRecord(string record)
        {

            var columns = record.Split(Separator.ToCharArray());
            if (columns.Length != 24)
            {
                return null;
            }
            for(var i=0; i<columns.Length;i++)
            {
                columns[i] = columns[i].Trim('\"');
            }

            try
            {
                return new PxrfRecord
                {
                    RecordTitle = columns[0],
                    Record = columns[0].Substring(0, columns[0].IndexOf("-", StringComparison.Ordinal)),
                    CaKa1 = decimal.Parse(columns[1]),
                    BaLa1 = decimal.Parse(columns[2]),
                    TiKa1 = decimal.Parse(columns[3]),
                    CrKa1 = decimal.Parse(columns[4]),
                    MnKa1 = decimal.Parse(columns[5]),
                    FeKa1 = decimal.Parse(columns[6]),
                    CoKa1 = decimal.Parse(columns[7]),
                    NiKa1 = decimal.Parse(columns[8]),
                    CuKa1 = decimal.Parse(columns[9]),
                    ZnKa1 = decimal.Parse(columns[10]),
                    AsKa1 = decimal.Parse(columns[11]),
                    PbLa1 = decimal.Parse(columns[12]),
                    ThLa1 = decimal.Parse(columns[13]),
                    RbKa1 = decimal.Parse(columns[14]),
                    ULa1 = decimal.Parse(columns[15]),
                    SrKa1 = decimal.Parse(columns[16]),
                    YKa1 = decimal.Parse(columns[17]),
                    ZrKa1 = decimal.Parse(columns[18]),
                    NbKa1 = decimal.Parse(columns[19]),
                    MoKa1 = decimal.Parse(columns[20]),
                    RhKa1 = decimal.Parse(columns[21]),
                    SnKa1 = decimal.Parse(columns[22]),
                    SbKa1 = decimal.Parse(columns[23])
                };
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string ToCsv()
        {
            return
                $"\"{RecordTitle}\",\"{CaKa1}\",\"{BaLa1}\",\"{TiKa1}\",\"{CrKa1}\",\"{MnKa1}\",\"{FeKa1}\",\"{CoKa1}\",\"{NiKa1}\",\"{CuKa1}\",\"{ZnKa1}\",\"{AsKa1}\",\"{PbLa1}\",\"{ThLa1}\",\"{RbKa1}\",\"{ULa1}\",\"{SrKa1}\",\"{YKa1}\",\"{ZrKa1}\",\"{NbKa1}\",\"{MoKa1}\",\"{RhKa1}\",\"{SnKa1}\",\"{SbKa1}\"";
        }

        public string RecordTitle { get; set; }
        public string Record { get; set; }        
        public decimal CaKa1 { get; set; }
        public decimal BaLa1 { get; set; }
        public decimal TiKa1 { get; set; }
        public decimal CrKa1 { get; set; }
        public decimal MnKa1 { get; set; }
        public decimal FeKa1 { get; set; }
        public decimal CoKa1 { get; set; }
        public decimal NiKa1 { get; set; }
        public decimal CuKa1 { get; set; }
        public decimal ZnKa1 { get; set; }
        public decimal AsKa1 { get; set; }
        public decimal PbLa1 { get; set; }
        public decimal ThLa1 { get; set; }
        public decimal RbKa1 { get; set; }
        public decimal ULa1 { get; set; }
        public decimal SrKa1 { get; set; }
        public decimal YKa1 { get; set; }
        public decimal ZrKa1 { get; set; }
        public decimal NbKa1 { get; set; }
        public decimal MoKa1 { get; set; }
        public decimal RhKa1 { get; set; }
        public decimal SnKa1 { get; set; }
        public decimal SbKa1 { get; set; }
    }
}
