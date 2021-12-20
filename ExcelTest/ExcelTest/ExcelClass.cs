/*
 * Created by Ranorex
 * User: skynete
 * Date: 19/12/2021
 * Time: 03:30 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Excel=Microsoft.Office.Interop.Excel;

namespace ExcelTest
{
	/// <summary>
	/// Description of ExcelClass.
	/// </summary>
	public class ExcelClass
	{
		public ExcelClass()
		{
		}
	
		public void OpenExcelFile(String path_name){
			
            var exApp = new Microsoft.Office.Interop.Excel.Application();
            var exWbk = exApp.Workbooks.Open(path_name);
            var exWks = (Excel.Worksheet)exWbk.Sheets["Sheet1"];
            
           
            //exWbk.Save();
            exWbk.Close();
		}
	}
}
