// See https://aka.ms/new-console-template for more information

using Microsoft.Office.Interop.Excel;


Console.WriteLine("Hello, World!");

string workbookPath = $"C://Temp/AKevinExcelCom{Guid.NewGuid()}.xlsx";

WriteToExcel(workbookPath, new string[,] { { "key1", "value1" }, { "key2", "value2" }, { "key3", "value3" } });
//var app = new Microsoft.Office.Interop.Excel.Application();


//var workbooks = app.Workbooks;
//var workbook = app.Workbooks.Add();
//var worksheet = workbook.Worksheets.Add();
//worksheet.Name = "KevinSheet";
//var workbookPath = $"C://Temp/KevinExcelCom{Guid.NewGuid()}.xlsx";

//workbook.Close(true, workbookPath, Type.Missing);

Console.ReadKey();

static void WriteToExcel(string filename, string[,] data)
{
    //Write cell value using row number and column number

    //*Note: Excel cells, can also be referenced by name, such as "E2" by using "Range"
    //
    //       All indices in Excel (rowNumber, columnNumber, etc...) start with 1 
    //       The format is: <rowNumber>, <columnNumber>
    //       The top left-most column, is: 1,1


    object oMissing = System.Reflection.Missing.Value;

    Microsoft.Office.Interop.Excel.Application? excelApp = null;
    Microsoft.Office.Interop.Excel.Workbook? workbook = null;
    Microsoft.Office.Interop.Excel.Worksheet? worksheet = null;

    int worksheetCount = 0;

    try
    {
        //create new instance
        excelApp = new Microsoft.Office.Interop.Excel.Application
        {
            //suppress displaying alerts (such as prompting to overwrite existing file)
            DisplayAlerts = false,

            //set Excel visability
            Visible = true
        };

        //disable user control while modifying the Excel Workbook
        //to prevent user interference
        //only necessary if Excel application Visibility property = true
        //excelApp.UserControl = false;

        //disable
        //excelApp.Calculation = Excel.XlCalculation.xlCalculationManual;

        //if writing/updating a large amount of data
        //disable screen updating by setting value to false
        //for better performance.
        //re-enable when done writing/updating data, if desired
        //excelApp.ScreenUpdating = false;

        //create new workbook
        workbook = excelApp.Workbooks.Add();

        //get number of existing worksheets
        worksheetCount = workbook.Sheets.Count;

        //add a worksheet and set the value to the new worksheet
        worksheet = workbook.Sheets.Add();

        FillWorkSheet(data, worksheet);

        //enable
        //excelApp.Calculation = Excel.XlCalculation.xlCalculationManual;
        //excelApp.ScreenUpdating = true;

        //save Workbook - if file exists, overwrite it
        workbook.SaveAs(filename, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value);

        System.Diagnostics.Debug.WriteLine("Status: Complete. " + DateTime.Now.ToString("HH:mm:ss"));
    }
    catch (Exception ex)
    {
        string errMsg = "Error (WriteToExcel) - " + ex.Message;
        System.Diagnostics.Debug.WriteLine(errMsg);

        if (ex.Message.StartsWith("Cannot access read-only document"))
        {

            Console.WriteLine("Cannot access read-only document");
            //System.Windows.Forms.MessageBox.Show(ex.Message + "Please close the workbook, before trying again.", "Error - Unable To Write To Workbook", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
    finally
    {
        if (workbook != null)
        {
            //close workbook
            workbook.Close();

            //release all resources
            _ = System.Runtime.InteropServices.Marshal.FinalReleaseComObject(workbook);
        }

        if (excelApp != null)
        {
            //close Excel
            excelApp.Quit();

            //release all resources
            _ = System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
        }
    }

    static void FillWorkSheet(string[,] data, Worksheet worksheet)
    {
        if (data != null)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                int rowNum = i + 1;

                for (int j = 0; j < data.GetLength(1); j++)
                {
                    int colNum = j + 1;

                    //set cell location that data needs to be written to
                    //range = worksheet.Cells[rowNum, colNum];

                    //set value of cell
                    //range.Value = data[i,j];

                    //set value of cell
                    worksheet.Cells[rowNum, colNum] = data[i, j];
                }
            }
        }
    }
}