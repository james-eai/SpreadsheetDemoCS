using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpreadsheetDemoCS.Models
{
	public class IndexModel
	{
		public List<SpreadsheetDataModel> Data { get; set; }
		public IndexModel()
		{
			Data = new List<SpreadsheetDataModel>();
		}
	}
}