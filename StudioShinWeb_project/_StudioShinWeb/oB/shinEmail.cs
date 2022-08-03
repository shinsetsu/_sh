using _DBC;
using System;
using System.ComponentModel.DataAnnotations;

namespace _StudioShinWeb.oB {
  


	public class shinEmail {




		[Key] public int id { get; set; }
		public string ToEmail { get; set; }
		public string FromEmail { get; set; }
		public string FromName { get; set; }
		public string Subject { get; set; }
		public string MessageBody { get; set; }


		internal void AddEmailToDB(DataBase _DB, shinEmail email) {
			try {
				_DB.Add(email);
				_DB.Update(email);
				_DB.SaveChanges();
			} catch (Exception e) { var a = e; }

		}// end of AddEmailToDb


	}
}
