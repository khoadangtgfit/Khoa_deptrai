﻿using System.Web;
using System.Web.Mvc;

namespace Tuan6_DangPhuocKhoa
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
