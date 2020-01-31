using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace MVCCore.Middleware
{
    public class AfterAuthentication
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<AfterAuthentication> _logger;

        public AfterAuthentication(RequestDelegate next, ILogger<AfterAuthentication> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync (HttpContext context)
        {
            if (context.User.Identity.IsAuthenticated)
                _logger.LogDebug("Authenticated");
            else
                _logger.LogDebug("Not Authenticated");

            await _next(context);
        }
    }
}
