namespace MiddleWay_test2.middleways
{
    public class FirstMiddleware
    {
        private readonly RequestDelegate _next;

        public FirstMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 執行第一層邏輯
            Console.WriteLine("-->First Middleware: Before");

            // 調用下一個 Middleware
            await _next(context);

            // 回應階段邏輯
            Console.WriteLine("<--First Middleware: After");
        }
    }
}
