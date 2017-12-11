using System.Net.Http;
using Thinktecture.Relay.Server.OnPremise;

namespace Thinktecture.Relay.Server.Interceptor
{
	public interface IInterceptorManager
	{
		IOnPremiseConnectorRequest HandleRequest(IOnPremiseConnectorRequest request, HttpRequestMessage message, out HttpResponseMessage immidateResponse);
		HttpResponseMessage HandleResponse(IOnPremiseConnectorRequest request, IOnPremiseConnectorResponse response);
	}
}