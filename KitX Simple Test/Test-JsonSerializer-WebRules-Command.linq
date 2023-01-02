<Query Kind="Program" />

using System.Text.Json;
namespace Test
{
	public struct DeviceLocator
	{
	    public string DeviceName { get; set; }
	    public string IPv4 { get; set; }
	    public string IPv6 { get; set; }
	    public string DeviceMacAddress { get; set; }
	}
	public class Command
	{
	    public CommandType Type { get; set; }
	    public DeviceLocator Sender { get; set; }
	    public DeviceLocator Target { get; set; }
	    public int CallId { get; set; }
	    public int CallIdTTL { get; set; }
	    public DateTime SendTime { get; set; }
	    public string Request { get; set; }
	    public List<string> RequestArgs { get; set; }
	    public byte[] Body { get; set; }
	    public int BodyLength { get; set; }
	    public Dictionary<string, string> Tags { get; set; }
	}
	public enum CommandType { Call = 1, CallBack = 2 }
	public class Program
	{
		public static void Main(string[] args){
			var cmd = new Command()
			{
				Type = CommandType.Call,
				Sender = new()
				{
					DeviceName = "DESKTOP-1",
					IPv4 = "192.168.1.1",
				},
				Target = new()
				{
					DeviceName = "DESKTOP-2",
					IPv4 = "192.168.1.2"
				},
				CallIdTTL = 10,
				SendTime = DateTime.Now,
				Request = "command",
				RequestArgs = new()
				{
					"arg1"
				},
				Body = new byte[] { 0x01, 0x02, 0x03, 0x04, 0x05 },
				BodyLength = 5,
			};
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,
                IncludeFields = true,
            };
			JsonSerializer.Serialize(cmd, options).Dump();
		}
	}
}