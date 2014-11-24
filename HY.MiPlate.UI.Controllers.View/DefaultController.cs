using System.IO;
using System.Web.Mvc;
using HY.MiPlate.UI.Controllers.Metadata;
using HY.MiPlate.UI.Domain;
using HY.MiPlate.UI.Models;

namespace HY.MiPlate.UI.Controllers.View
{
    public class DefaultController : MiPlateControllerBase
    {
        private readonly ISampleDataDomain _sampleData;
        public DefaultController(ISampleDataDomain sampleData)
        {
            _sampleData = sampleData;
        }

        public ActionResult Index()
        {
            ViewData.Add("Number", this._sampleData.GetNumber());
            return this.View(ViewData);
        }
    }
}
