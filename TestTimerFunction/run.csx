using System;
using Serilog;

public static void Run(TimerInfo timer, TraceWriter log)
{
    //What is this thing??

    log.Info(log.GetType().ToString());

    log.Info($"C# Timer trigger function executed at: {DateTime.Now}");    
}