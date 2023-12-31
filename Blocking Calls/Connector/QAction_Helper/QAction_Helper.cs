// <auto-generated>This is auto-generated code by DIS. Do not modify.</auto-generated>
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Skyline.DataMiner.Scripting
{
public static class Parameter
{
	/// <summary>PID: 10 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int remotereceiver_10 = 10;
	/// <summary>PID: 10 | Type: read</summary>
	public const int remotereceiver = 10;
	/// <summary>PID: 100 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int status_100 = 100;
	/// <summary>PID: 100 | Type: read</summary>
	public const int status = 100;
	/// <summary>PID: 103 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int statusflow1_103 = 103;
	/// <summary>PID: 103 | Type: read</summary>
	public const int statusflow1 = 103;
	/// <summary>PID: 104 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int statusflow2_104 = 104;
	/// <summary>PID: 104 | Type: read</summary>
	public const int statusflow2 = 104;
	/// <summary>PID: 105 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int statusflow3_105 = 105;
	/// <summary>PID: 105 | Type: read</summary>
	public const int statusflow3 = 105;
	/// <summary>PID: 200 | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public const int devicestatus_200 = 200;
	/// <summary>PID: 200 | Type: read</summary>
	public const int devicestatus = 200;
	public class Write
	{
		/// <summary>PID: 101 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int buttonrun_101 = 101;
		/// <summary>PID: 101 | Type: write</summary>
		public const int buttonrun = 101;
		/// <summary>PID: 202 | Type: write</summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public const int devicestatus_202 = 202;
		/// <summary>PID: 202 | Type: write</summary>
		public const int devicestatus = 202;
	}
}
public class WriteParameters
{
	/// <summary>PID: 101  | Type: write | DISCREETS: Run = 1</summary>
	public System.Object Buttonrun {get { return Protocol.GetParameter(101); }set { Protocol.SetParameter(101, value); }}
	/// <summary>PID: 202  | Type: write | DISCREETS: Enabled = 1, Disabled = 2</summary>
	public System.Object Devicestatus {get { return Protocol.GetParameter(202); }set { Protocol.SetParameter(202, value); }}
	public SLProtocolExt Protocol;
	public WriteParameters(SLProtocolExt protocol)
	{
		Protocol = protocol;
	}
}
public interface SLProtocolExt : SLProtocol
{
	object Afterstartup_dummy { get; set; }
	object Remotereceiver_10 { get; set; }
	object Remotereceiver { get; set; }
	object Status_100 { get; set; }
	object Status { get; set; }
	object Buttonrun_101 { get; set; }
	object Buttonrun { get; set; }
	object Runlogic1_dummy { get; set; }
	object Statusflow1_103 { get; set; }
	object Statusflow1 { get; set; }
	object Statusflow2_104 { get; set; }
	object Statusflow2 { get; set; }
	object Statusflow3_105 { get; set; }
	object Statusflow3 { get; set; }
	object Devicestatus_200 { get; set; }
	object Devicestatus { get; set; }
	object Devicestatus_202 { get; set; }
	object Runlogicflow2_dummy { get; set; }
	object Runlogicflow3_dummy { get; set; }
	WriteParameters Write { get; set; }
}
public class ConcreteSLProtocolExt : ConcreteSLProtocol, SLProtocolExt
{
	/// <summary>PID: 2  | Type: dummy</summary>
	public System.Object Afterstartup_dummy {get { return GetParameter(2); }set { SetParameter(2, value); }}
	/// <summary>PID: 10  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Remotereceiver_10 {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 10  | Type: read</summary>
	public System.Object Remotereceiver {get { return GetParameter(10); }set { SetParameter(10, value); }}
	/// <summary>PID: 100  | Type: read</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Status_100 {get { return GetParameter(100); }set { SetParameter(100, value); }}
	/// <summary>PID: 100  | Type: read</summary>
	public System.Object Status {get { return GetParameter(100); }set { SetParameter(100, value); }}
	/// <summary>PID: 101  | Type: write | DISCREETS: Run = 1</summary>
	public System.Object Buttonrun_101 {get { return GetParameter(101); }set { SetParameter(101, value); }}
	/// <summary>PID: 101  | Type: write | DISCREETS: Run = 1</summary>
	public System.Object Buttonrun {get { return Write.Buttonrun; }set { Write.Buttonrun = value; }}
	/// <summary>PID: 102  | Type: dummy</summary>
	public System.Object Runlogic1_dummy {get { return GetParameter(102); }set { SetParameter(102, value); }}
	/// <summary>PID: 103  | Type: read | EXCEPTIONS: N/A = NA</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Statusflow1_103 {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 103  | Type: read | EXCEPTIONS: N/A = NA</summary>
	public System.Object Statusflow1 {get { return GetParameter(103); }set { SetParameter(103, value); }}
	/// <summary>PID: 104  | Type: read | EXCEPTIONS: N/A = NA</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Statusflow2_104 {get { return GetParameter(104); }set { SetParameter(104, value); }}
	/// <summary>PID: 104  | Type: read | EXCEPTIONS: N/A = NA</summary>
	public System.Object Statusflow2 {get { return GetParameter(104); }set { SetParameter(104, value); }}
	/// <summary>PID: 105  | Type: read | EXCEPTIONS: N/A = NA</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Statusflow3_105 {get { return GetParameter(105); }set { SetParameter(105, value); }}
	/// <summary>PID: 105  | Type: read | EXCEPTIONS: N/A = NA</summary>
	public System.Object Statusflow3 {get { return GetParameter(105); }set { SetParameter(105, value); }}
	/// <summary>PID: 200  | Type: read | DISCREETS: Enabled = 1, Disabled = 2</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Devicestatus_200 {get { return GetParameter(200); }set { SetParameter(200, value); }}
	/// <summary>PID: 200  | Type: read | DISCREETS: Enabled = 1, Disabled = 2</summary>
	public System.Object Devicestatus {get { return GetParameter(200); }set { SetParameter(200, value); }}
	/// <summary>PID: 202  | Type: write | DISCREETS: Enabled = 1, Disabled = 2</summary>
	[EditorBrowsable(EditorBrowsableState.Never)]
	public System.Object Devicestatus_202 {get { return GetParameter(202); }set { SetParameter(202, value); }}
	/// <summary>PID: 1103  | Type: dummy</summary>
	public System.Object Runlogicflow2_dummy {get { return GetParameter(1103); }set { SetParameter(1103, value); }}
	/// <summary>PID: 1104  | Type: dummy</summary>
	public System.Object Runlogicflow3_dummy {get { return GetParameter(1104); }set { SetParameter(1104, value); }}
	public WriteParameters Write { get; set; }
	public ConcreteSLProtocolExt()
	{
		Write = new WriteParameters(this);
	}
}
}
