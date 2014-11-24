using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace HY.MiPlate.UI.Shared.MVC
{
    public class JsonResult : ActionResult
    {
        #region Private Fields

        /// <summary>
        /// Data object
        /// </summary>
        private object _data;

        /// <summary>
        /// Content type
        /// </summary>
        private string _contentType = Constants.ContentTypes.Json;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonResult"/> class.
        /// </summary>
        public JsonResult()
        {
            this.SerializerSettings = new JsonSerializerSettings();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets ContentEncoding.
        /// </summary>
        public Encoding ContentEncoding { get; set; }

        /// <summary>
        /// Gets or sets ContentType.
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        public object Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        /// <summary>
        /// Gets or sets SerializerSettings.
        /// </summary>
        public JsonSerializerSettings SerializerSettings { get; set; }

        /// <summary>
        /// Gets or sets Formatting.
        /// </summary>
        public Formatting Formatting { get; set; }

        #endregion

        #region Helper Functions

        /// <summary>
        /// Execute result
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context != null)
            {
                var response = context.HttpContext.Response;
                response.ContentType = this._contentType;
                if (this.ContentEncoding != null)
                {
                    response.ContentEncoding = this.ContentEncoding;
                }

                if (this.Data != null)
                {
                    var writer = new JsonTextWriter(response.Output) { Formatting = Formatting };
                    JsonSerializer serializer = JsonSerializer.Create(this.SerializerSettings);
                    serializer.Serialize(writer, this._data);  
                    writer.Flush();
                }
            }
        }

        #endregion
    }
}
