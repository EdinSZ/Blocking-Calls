using System;
using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: Remote Receiver.
/// </summary>
public static class QAction
{
    /// <summary>
    /// The QAction entry point.
    /// </summary>
    /// <param name="protocol">Link with SLProtocol process.</param>
    public static void Run(SLProtocol protocol)
    {
        try
        {
            StartProcessing(protocol);

            System.Threading.Thread.Sleep(20000);

            StopProcessing(protocol);
        }
        catch (Exception ex)
        {
            protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
        }
    }

    private static void StartProcessing(SLProtocol protocol)
    {
        protocol.Log($"Start Processing..");

        protocol.SetParameter(Parameter.status_100, "Processing..");
    }

    private static void StopProcessing(SLProtocol protocol)
    {
        protocol.Log($"Finished Processing..");

        protocol.SetParameter(Parameter.status_100, "Finished");
    }
}