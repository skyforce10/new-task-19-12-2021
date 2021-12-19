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

namespace ApiTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the ApiTestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("c5b03a01-bbfe-4b72-80d1-48b1df9ae504")]
    public partial class ApiTestRepository : RepoGenBaseFolder
    {
        static ApiTestRepository instance = new ApiTestRepository();

        /// <summary>
        /// Gets the singleton class instance representing the ApiTestRepository element repository.
        /// </summary>
        [RepositoryFolder("c5b03a01-bbfe-4b72-80d1-48b1df9ae504")]
        public static ApiTestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public ApiTestRepository() 
            : base("ApiTestRepository", "/", null, 0, false, "c5b03a01-bbfe-4b72-80d1-48b1df9ae504", ".\\RepositoryImages\\ApiTestRepositoryc5b03a01.rximgres")
        {
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("c5b03a01-bbfe-4b72-80d1-48b1df9ae504")]
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
    public partial class ApiTestRepositoryFolders
    {
    }
#pragma warning restore 0436
}
