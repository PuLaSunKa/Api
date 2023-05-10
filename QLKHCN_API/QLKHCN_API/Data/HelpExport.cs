using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;

namespace QLKHCN_API.Data
{
    public static class HelpExport
    {
        public static Stream UpdateDataIntoExcelTemplate(List<DanhMucXetDuyet> cList, FileInfo path)
        {
            Stream stream = new MemoryStream();
            if (path.Exists)
            {
                using (ExcelPackage p = new ExcelPackage(path))
                {
                    ExcelWorksheet wsEstimate = p.Workbook.Worksheets["Sheet1"];
                    wsEstimate.Cells["A9:Z119"].LoadFromCollection(cList);
                    p.SaveAs(stream);
                    stream.Position = 0;
                }
            }
            return stream;
        }
    }
}