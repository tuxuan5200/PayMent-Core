﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSample
{
    public class QPayNotifyResult
    {
        private static readonly ContentResult _success = new ContentResult() { Content = "<xml><return_code>SUCCESS</return_code></xml>", ContentType = "text/xml" };

        public static IActionResult Success => _success;
    }
}
