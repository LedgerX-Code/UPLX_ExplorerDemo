# What is an Explorer?
An Explorer allows you to explore and search the UPLX blockchain for transactions and other activities taking place on UPLX. LedgerX has created an Explorer demo for our BEMR platform. User can explore and search our BEMR data (testnet data) on our Explorer demo. Developers can create a derivative version of our Explorer demo to to query their own system data.


# Explorer Demo Setup Guide

Developer should be familair with programming environments and basics of C# language. Deeper knowledge of any programming language is recommended.

### Before

1. Getting started with C# and VS / VS Code
     * [Become familiar with tools](https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/local-environment)
     * [Build app with Visual Studio](https://docs.microsoft.com/en-us/visualstudio/get-started/csharp/tutorial-aspnet-core-ef-step-01?view=vs-2019)
2. Read e.g. [C# Yellow Book](http://www.csharpcourse.com/)
3. Do [C# Koans](https://github.com/NotMyself/DotNetCoreKoans)


#### After (advanced material)   

* LINQ
  * [LINQ-Tutorial](https://github.com/Basware/LINQ-Tutorial) 
* Refit Extensions
  * [Refit: The automatic type-safe REST library for .NET Core, Xamarin and .NET](https://github.com/reactiveui/refit)
* Json.Net - Newtonsoft
  * [Popular high-performance JSON framework for .NET](https://www.newtonsoft.com/json)

### Update app configuration to invoke UPLX API to get data
> CryptoAPIToken and CryptoAPI are available configuration in AppSettings! Just search `appsetting.json`

An example Configuration
---

```ini
[General]
# a comment
"AppSettings": {
    "CryptoToken": "{UPLX_API_KEY}",
    "CryptoAPI": "{UPLX_API_LINK}"
  }
```

That's it!

Contact us at `info@uplx.io` for the API link and key. Refer to [Explorer API Document](https://github.com/LedgerX-Code/UPLX-ExplorerDemo/blob/master/ExplorerAPI.pdf) for more details. 
