using System;
namespace mvcmoviecore2.Models
{
	public class MySettingsModel
	{

        public string DbConnection { get; set; }
        public string Email { get; set; }
        public string SMTPPort { get; set; }

        public MySettingsModel()
		{
		}
	}
}

