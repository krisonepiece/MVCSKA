using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCSKA.Models.ViewModel
{
	public class IndexViewModel
	{
		[Display(Name = "類別")]
		public AccountingType Type { get; set; }
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
		[Display(Name = "日期")]
		public DateTime Date { get; set; }
		[DisplayFormat(DataFormatString = "{0:N0}")]
		[Display(Name = "金額")]
		public int Amount { get; set; }
		[Display(Name = "備註")]
		public string Remark { get; set; }
	}

	public enum AccountingType
	{
		[Display(Name = "支出")]
		Outlay,
		[Display(Name = "收入")]
		Income
	}
}