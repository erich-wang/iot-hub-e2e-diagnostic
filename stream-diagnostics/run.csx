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

            StringBuilder buider = new StringBuilder("Keys:");
            foreach(var key in d2cMessage.Properties)
            {
                buider.Append(" " + key);
            }
            log.Info(buider.ToString());
}