using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using HY.MiPlate.UI.Controllers.Metadata;
using HY.MiPlate.UI.Domain;
using HY.MiPlate.UI.Models;
using JsonResult = HY.MiPlate.UI.Shared.MVC.JsonResult;

namespace HY.MiPlate.UI.Controllers.Data
{
    public class CenterController : MiPlateControllerBase
    {
       private readonly ISampleDataDomain _sampleData;
       public CenterController(ISampleDataDomain sampleData)
        {
            _sampleData = sampleData;
        }

        public JsonResult CenterPartView()
        {
            var view = this.RenderPartialViewToString();
            var result = new DataViewModelBase<CenterModel>()
            {
                IsSuccessful = true,
                View = view,
                DataList =
                    new List<CenterModel>()
                    {
                        new CenterModel() {Id = 1, CenterName = "aa", CreateOn = DateTime.Now},
                        new CenterModel() {Id = 2, CenterName = "bb", CreateOn = DateTime.Now}
                    }
            };
            return this.Json(result);
        }

        public ActionResult Ccc()
        {
            return this.Content("aa");
        }
    }
}
