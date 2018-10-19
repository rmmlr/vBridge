using Rca.LightHttpServer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Rca.VirtualBridge
{
    public class BridgeHttpServer : HttpServer
    {
        #region Constructor
        /// <summary>
        /// Empty constructor of <seealso cref="Bridge"/>
        /// </summary>
        public BridgeHttpServer(IPAddress ip, int port) : base(ip, port)
        {

        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Handle a GET request
        /// </summary>
        /// <param name="p">HTTP handler</param>
        public override void HandleGetRequest(HttpProcessor p)
        {
            throw new NotImplementedException();
        }


        public override void HandlePostRequest(HttpProcessor p, StreamReader inputData)
        {
            throw new NotImplementedException();
        }


        #endregion Services

        #region Internal services

        IPAddress GetRemoteIp(HttpProcessor p)
        {
            if (p.Socket.Client.RemoteEndPoint.GetType() == typeof(IPEndPoint))
                return ((IPEndPoint)p.Socket.Client.RemoteEndPoint).Address;
            else
                return null;
        }

        #endregion Internal services
    }
}
