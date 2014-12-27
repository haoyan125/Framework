namespace HY.MiPlate.UI.Shared.ThirdPartyConnector
{
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  public class WeixinToken
  {
    public string TokenKey { get; set; }

    public long OrganiztionId { get; set; }
  }

  public class DeveloperOId
  {
    public string AppId { get; set; }

    public string AppSecret { get; set; }

    public long OrganiztionId { get; set; }
  }

  public class ServerConfig
  {
    public string URL { get; set; }

    public string Token { get; set; }

    public string EncodingAESKey { get; set; }

    public int EncriptType { get; set; }

    public long OrganiztionId { get; set; }
  }

  public enum EncriptType
  {
    PlainTextMode = 1,
    CompatibilityMode = 2,
    SafeMode = 3
  }
}
