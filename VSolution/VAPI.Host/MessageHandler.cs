using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace VSolution.VAPI.Host
{
    public class MessageHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            var result = new Task<HttpResponseMessage>(() =>
                {
                    var requestPath = request.RequestUri.AbsolutePath;
                    if (!string.IsNullOrEmpty(requestPath))
                    {
                        var pathName = requestPath.Substring(1, requestPath.Length - 1);

                        switch (pathName.Trim().ToLower())
                        {
                            case "robots.txt":
                                return new HttpResponseMessage()
                                {
                                    StatusCode = HttpStatusCode.OK,
                                    Content = new StringContent("User-agent: *\nDisallow: /", Encoding.GetEncoding("UTF-8"), "text/plain")
                                };
                            case "favicon.ico":
                                var favResponse = new HttpResponseMessage()
                                {
                                    StatusCode = HttpStatusCode.Redirect
                                };
                                favResponse.Headers.Location = new Uri("http://www.baidu.com/favicon.ico");
                                return favResponse;
                            case "":
                            case "/":
                            case "api":
                            case "api/":
                                return new HttpResponseMessage()
                                {
                                    StatusCode = HttpStatusCode.OK,
                                    Content = new StringContent("API host is running...", Encoding.GetEncoding("UTF-8"), "text/plain")
                                };
                            case "api/doc":
                            case "api/doc/":
                                var docResponse = new HttpResponseMessage()
                                {
                                    StatusCode = HttpStatusCode.Redirect
                                };
                                docResponse.Headers.Location =
                                    new Uri(request.RequestUri.Scheme + "://" + request.RequestUri.Authority + "/api/doc/getdoc");
                                return docResponse;
                        }
                    }
                
                    return base.SendAsync(request, cancellationToken).Result;
                });

            result.Start();
            return result;
        }
    }
}
