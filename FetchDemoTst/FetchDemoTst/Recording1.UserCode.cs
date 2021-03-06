///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace FetchDemoTst
{
    public partial class Recording1
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void FetchTreeView()
        {
           
        	var treeView = repo.RxMainFrame.TreeView;

        	String str_var="";
        	for(int i=0;i<treeView.Items.Count;i++){
        		if(str_var!=""){
        			str_var=str_var+Environment.NewLine;
        		}
        		str_var=str_var+treeView.Items[i].Text;
        	}
        	Report.Log(ReportLevel.Info,str_var);
        }

    }
}
