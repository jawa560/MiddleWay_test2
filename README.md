#概念

![1](images/console.png)
```
public class TraditionalFlow
{
    public void ProcessRequest(string request)
    {
        // Step 1: 驗證請求
        if (ValidateRequest(request))
        {
            Console.WriteLine("Step 1: 驗證請求 - 通過");

            // Step 2: 進行處理
            if (ProcessRequestData(request))
            {
                Console.WriteLine("Step 2: 進行處理 - 成功");

                // Step 3: 回傳結果
                if (ReturnResult(request))
                {
                    Console.WriteLine("Step 3: 回傳結果 - 成功");
                }
                else
                {
                    Console.WriteLine("Step 3: 回傳結果 - 失敗");
                }
            }
            else
            {
                Console.WriteLine("Step 2: 進行處理 - 失敗");
            }
        }
        else
        {
            Console.WriteLine("Step 1: 驗證請求 - 失敗");
        }
    }

    private bool ValidateRequest(string request)
    {
        // 模擬驗證邏輯
        return !string.IsNullOrEmpty(request);
    }

    private bool ProcessRequestData(string request)
    {
        // 模擬處理邏輯
        return request.Length > 5;
    }

    private bool ReturnResult(string request)
    {
        // 模擬結果回傳邏輯
        return true;
    }
}

```
