namespace MiddleWay_test2.Middlewares
{
    public class ThirdMiddleware
    {
        private readonly RequestDelegate _next;

        public ThirdMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 執行第三層邏輯
            Console.WriteLine("         -->Third Middleware: Before");

            // 調用下一個 Middleware（在這裡通常是最終的處理程序或路由）
            //throw new InvalidOperationException("Missing required header.");
            //await _next(context);
            try { 
                throw new Exception("Something wrong."); 
            }
            catch
            {
                Console.WriteLine("        <<<-------Somthing wrong------->>>");
            }
            
            // 回應階段邏輯
            Console.WriteLine("         <--Third Middleware: After");
        }
    }
}
