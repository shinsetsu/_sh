using System;

namespace ER
{
	public class eVM {
		public string RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}
