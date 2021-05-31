using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC5.Helpers
{
    public static class ViewHelper
    {
        public static ViewResult CustomizeViewEngineCollection(this ViewResult view, RazorViewEngine razorViewEngine)
        {
            view.ViewEngineCollection.Clear();
            view.ViewEngineCollection.Add(razorViewEngine);

            return view;
        }
    }
}