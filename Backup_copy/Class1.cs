using System;
using System.Collections.Generic;
using System.Text;

namespace Backup_copy
{
	abstract class Storage
	{
		protected string Model_name { get; set; }
		public Storage(string Model_name)
		{
			this.Model_name = Model_name;
		}
		abstract public int Get_memory_size();
		abstract public double Copying_data(double x, double y);
		abstract public int Get_memory_free();
		abstract public void Get_info();
	}
}
