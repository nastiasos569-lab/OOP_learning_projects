using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lb30.Services
{
    public class FtpService
    {
        private string host;
        private NetworkCredential cred;

        public FtpService(string host, string user, string pass)
        {
            this.host = host;
            cred = new NetworkCredential(user, pass);
        }

        private FtpWebRequest Create(string path, string method)
        {
            var req = (FtpWebRequest)WebRequest.Create(host + path);
            req.Credentials = cred;
            req.Method = method;
            return req;
        }
    }
}
