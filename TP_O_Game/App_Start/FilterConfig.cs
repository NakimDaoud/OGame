﻿using System.Web;
using System.Web.Mvc;

namespace TP_O_Game
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
