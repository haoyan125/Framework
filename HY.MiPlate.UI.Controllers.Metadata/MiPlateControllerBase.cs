using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Xml;
using JsonResult = HY.MiPlate.UI.Shared.MVC.JsonResult;
namespace HY.MiPlate.UI.Controllers.Metadata
{
  /// <summary>
  /// 
  /// </summary>
   public class MiPlateControllerBase : Controller
    {
       protected string RenderPartialViewToString(string viewName, object model)
       {
           if (string.IsNullOrEmpty(viewName))
               viewName = ControllerContext.RouteData.GetRequiredString("action");

           ViewData.Model = model;

           using (var sw = new StringWriter())
           {
               var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
               var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
               viewResult.View.Render(viewContext, sw);

               return sw.GetStringBuilder().ToString();
           }
       }

       protected string RenderPartialViewToString()
       {
           var viewName = ControllerContext.RouteData.GetRequiredString("action");
           using (var sw = new StringWriter())
           {
               var viewResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
               var viewContext = new ViewContext(ControllerContext, viewResult.View, ViewData, TempData, sw);
               viewResult.View.Render(viewContext, sw);

               return sw.GetStringBuilder().ToString();
           }
       }

       protected new JsonResult Json(object data, string contentType)
       {
           return this.Json(data, contentType, Encoding.Default);
       }

       protected new JsonResult Json(dynamic data, string contentType, Encoding contentEncoding)
       {
           var jsonNetResult = new JsonResult();
           if (contentType != null)
           {
               jsonNetResult.ContentType = contentType;
           }

           jsonNetResult.Data = data;

           return jsonNetResult;
       }

       protected new JsonResult Json(object data)
       {
           return this.Json(data, null, Encoding.Default);
       }
    }
}
