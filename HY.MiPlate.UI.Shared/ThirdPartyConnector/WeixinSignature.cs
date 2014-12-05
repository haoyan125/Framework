using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.MiPlate.UI.Shared.ThirdPartyConnector
{
  public class WeixinSignature
  {
    public string Signature { get; set; }

    public string TimeStamp { get; set; }

    public string Nonce { get; set; }

    public string Echostr { get; set; }
  }
}
