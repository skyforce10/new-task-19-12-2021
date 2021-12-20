﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace ExcelTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ExcelTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("7a2ea189-087b-4c26-87e5-ff4bf683c945")]
    public partial class ExcelTestRepository : RepoGenBaseFolder
    {
        static ExcelTestRepository instance = new ExcelTestRepository();

        /// <summary>
        /// Gets the singleton class instance representing the ExcelTestRepository element repository.
        /// </summary>
        [RepositoryFolder("7a2ea189-087b-4c26-87e5-ff4bf683c945")]
        public static ExcelTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ExcelTestRepository() 
            : base("ExcelTestRepository", "/", null, 0, false, "7a2ea189-087b-4c26-87e5-ff4bf683c945", ".\\RepositoryImages\\ExcelTestRepository7a2ea189.rximgres")
        {
        }

#region Variables

        string _excel_testfile = "C:\\ranorex_test\\test1.xlsx";

        /// <summary>
        /// Gets or sets the value of variable excel_testfile.
        /// </summary>
        [TestVariable("00ba792b-f7f1-4c64-aad1-dbc517e2436a")]
        public string excel_testfile
        {
            get { return _excel_testfile; }
            set { _excel_testfile = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("7a2ea189-087b-4c26-87e5-ff4bf683c945")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class ExcelTestRepositoryFolders
    {
    }
#pragma warning restore 0436
}
