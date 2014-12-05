using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HY.MiPlate.UI.Shared.ThirdPartyConnector
{
  public interface IAuthorization
  {
    bool VerifySignture(WeixinSignature signture, WeixinToken token);

    string IsValid(WeixinSignature signture, WeixinToken token);
  }
}
