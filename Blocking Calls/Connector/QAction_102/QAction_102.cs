using System;
using Skyline.DataMiner.Scripting;


/// <summary>
/// DataMiner QAction Class: QActionName.
/// </summary>
public static class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocolExt protocol)
	{
		try
		{
			System.Threading.Thread.Sleep(5000);

			protocol.SetParameter(Parameter.statusflow1_103, $"Done {DateTime.Now}");

			protocol.Log($"Finished Flow 1 - QA 102 - {DateTime.Now}");
		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}