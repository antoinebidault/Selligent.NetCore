using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Selligent.NetCore
{
  public class BaseSelligentClient
  {
    public readonly string BaseUrl = "";
    private readonly string _publicKey;
    public readonly string _privateKey;

    public BaseSelligentClient(SelligentClientConfiguration clientConfig)
    {
      BaseUrl = clientConfig.BaseUrl;
      _publicKey = clientConfig.PublicKey;
      _privateKey = clientConfig.PrivateKey;
    }

    // Called by implementing swagger client classes
    protected async System.Threading.Tasks.Task<HttpRequestMessage> CreateHttpRequestMessageAsync(CancellationToken cancellationToken)
    {
      var msg = new HttpRequestMessage();
      // Set the bearer 
      msg.Headers.Add("X-ApiKey", $"{_publicKey}:{_privateKey}");

      return await System.Threading.Tasks.Task.FromResult<HttpRequestMessage>(msg);
    }
  }
}
