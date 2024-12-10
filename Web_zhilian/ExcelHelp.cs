using NPOI.SS.Formula.Functions;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Reflection;


namespace Web_zhilian
{
    public class ExcelHelp
    {
        public static IWorkbook toExcel<T>(List<T> list)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");

            Type tp = typeof(T);
            PropertyInfo[] proInfos = tp.GetProperties();

            IRow headerRow = sheet.CreateRow(0);

            var i = 0;
            foreach (PropertyInfo item in proInfos)
            {
                headerRow.CreateCell(i++).SetCellValue(item.Name);
            }

            int rowIndex = 1;
            foreach (var item in list)
            {
                IRow dataRow = sheet.CreateRow(rowIndex);
                var y = 0;
                foreach (var proInfo in proInfos)
                {
                    object obj = proInfo.GetValue(item);
                    if (proInfo.PropertyType == typeof(DateTime) && obj != null)
                    {
                        dataRow.CreateCell(y++).SetCellValue(obj?.ToString());
                    }
                    else if (proInfo.PropertyType == typeof(int) && obj != null)
                    {
                        dataRow.CreateCell(y++).SetCellValue((int)obj);
                    }
                    else if (proInfo.PropertyType == typeof(decimal) && obj != null)
                    {
                        dataRow.CreateCell(y++).SetCellValue(Convert.ToDouble(obj));
                    }
                    else { dataRow.CreateCell(y++).SetCellValue(obj?.ToString()); }
                }
                sheet.AutoSizeColumn(rowIndex,true);
                rowIndex++;
            }
            
            return workbook;
        }
    }
}
