﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MLApp;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MLApp.MLApp matlab = new MLApp.MLApp();
        matlab.Execute(Server.MapPath("~/MATLab"));
        object result = null;

        // Call the MATLAB function myfunc
        matlab.Feval("myfunc", 2, out result, 3.14, 42.0, "world");

        // Display result 
        object[] res = result as object[];

    }
}