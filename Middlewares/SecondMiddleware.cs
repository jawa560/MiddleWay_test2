namespace MiddleWay_test2.Middlewares
{
    public class SecondMiddleware
    {
        private readonly RequestDelegate _next;

        public SecondMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 執行第二層邏輯
            Console.WriteLine("     -->Second Middleware: Before");

            // 調用下一個 Middleware
            await _next(context);

            // 回應階段邏輯
            Console.WriteLine("     <--Second Middleware: After");
        }
    }
}
