﻿///////////////////////////////////////////////////////////////////////////////
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

using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiTest
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

        public string getcountry(string post_code)
        {
            String url_var="https://api.zippopotam.us/us/"+post_code;
            IRestResponse API_response=Api_test_class.Get(url_var);
            String post_country=Api_test_class.ParseJson(API_response,"country");
            String post_country_abbreviation=Api_test_class.ParseJson(API_response,"country abbreviation");
            Report.Log(ReportLevel.Info,"country is: "+post_country+" , country abbreviation is: "+post_country_abbreviation);
            return post_country;
        }

    }
}