using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoGridDemo.Models;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;


namespace KendoGridDemo.Controllers
{
    public class EmpController : Controller
    {
        //
        // GET: /Emp/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData([DataSourceRequest] DataSourceRequest request)
        {
            using (DBEmpEntities db = new DBEmpEntities())
            {
                var lst = db.Tbl_Emp.ToList();
                return Json(lst.ToDataSourceResult(request));
            }
        }

    }
}
