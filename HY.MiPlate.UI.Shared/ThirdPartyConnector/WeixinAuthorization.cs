using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace HY.MiPlate.UI.Shared.ThirdPartyConnector
{
  public class WeixinAuthorization : IAuthorization
  {
    public bool VerifySignture(WeixinSignature s, WeixinToken token)
    {
      string[] tempArray = { token.TokenKey, s.TimeStamp, s.Nonce };
      Array.Sort(tempArray);     //字典排序
      var tempStr = string.Join("", tempArray);
      tempStr = FormsAuthentication.HashPasswordForStoringInConfigFile(tempStr, "SHA1").ToLower();

      return tempStr == s.Signature ? true : false;
    }

    public string IsValid(WeixinSignature s, WeixinToken token)
    {
      if (VerifySignture(s, token))
      {
        if (!string.IsNullOrEmpty(s.Echostr))
        {
          return s.Echostr;
        }
      }

      return string.Empty;
    }
  }
}
