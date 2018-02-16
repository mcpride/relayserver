using System;
using System.Reflection;

namespace Thinktecture.Relay.OnPremiseConnector.SignalR
{
	internal interface IRelayServerConnectionFactory
	{
		IRelayServerConnection Create(Assembly versionAssembly, string userName, string password, Uri relayServer, int requestTimeout, int tokenRefreshWindow);
	}
}
