namespace IndieGameZone.Domain.RequestsAndResponses.Responses.TotalVirus
{
	public class TotalVirusResponse
	{
		public Data data { get; set; }
	}

	public class Data
	{
		public string type { get; set; }
		public string id { get; set; }
		public Links links { get; set; }
	}

	public class Links
	{
		public string self { get; set; }
	}
}
