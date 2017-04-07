#r "Microsoft.ServiceBus"
using System;
using System.Net;
using System.Reflection;
using Microsoft.ServiceBus.Common;
using Microsoft.ServiceBus.Messaging;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

public static void Run(EventData d2cMessage, TraceWriter log)
{
    TelemetryClient telemetry = new TelemetryClient();
    telemetry.InstrumentationKey = System.Environment.GetEnvironmentVariable("APP_INSIGHTS_INSTRUMENTATION_KEY");

    Dictionary<string,string> diagnostics = new Dictionary<string,string>();
    foreach(KeyValuePair<string, object> entry in d2cMessage.Properties) {
        if (entry.Key.StartsWith("x-"))
        {
            diagnostics.Add(entry.Key, (string)entry.Value);
        }
    }

    if (diagnostics.Count > 0)
    {
        telemetry.TrackEvent("d2c-diagnostics", diagnostics);
    }
}