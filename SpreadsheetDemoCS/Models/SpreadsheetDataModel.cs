using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static SpreadsheetDemoCS.Models.Randomizer;

namespace SpreadsheetDemoCS.Models
{
	public class SpreadsheetDataModel: Indexable
	{
		public string StringValue { get; set; }
		public DateTime DateValue { get; set; }
		public double PercentageValue { get; set; }
		public SpreadsheetDataModel()
		{
			KeyID = r.Next(0, 1000);
			PercentageValue = r.NextDouble()*100;
			DateValue = new DateTime(r.Next(2000, 2019), r.Next(1, 12), r.Next(1, 28));
			StringValue = "RandomString";
		}
	}
	public abstract class Indexable
	{
		public long KeyID { get; set; }
		public object this[int index]
		{
			get { return GetType().GetProperties()[index].GetValue(this); }
			set { GetType().GetProperties()[index].SetValue(this, value); }
		}
	}
}