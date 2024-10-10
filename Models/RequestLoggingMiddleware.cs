using System.Diagnostics;

namespace MiddleWay_test2.Models
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestLoggingMiddleware> _logger;

        public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 在處理請求前執行的邏輯
            var requestPath = context.Request.Path;
            _logger.LogInformation($"Incoming request: {requestPath}");

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            // 呼叫下一個 middleware
            await _next(context);

            // 在處理請求後執行的邏輯
            stopwatch.Stop();
            _logger.LogInformation($"Request {requestPath} processed in {stopwatch.ElapsedMilliseconds} ms");
        }
    }

}
