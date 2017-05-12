using System;
using Serilog;

public static void Run(TimerInfo timer, TraceWriter log)
{
    // Log.Logger = new LoggerConfiguration()
    //     .CreateLogger();
    
    log.Info($"C# Timer trigger function executed at: {DateTime.Now}");    
}