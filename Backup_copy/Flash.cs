using System;
using System.Collections.Generic;
using System.Text;

namespace Backup_copy
{
	class Flash : Storage
	{
		private int Speed_USB_3_0 { get; set; }
		private int Memory { get; set; }
		private int notFreeMemory = 0;

		public Flash(int Speed_USB_3_0, int Memory, string Model_name) : base(Model_name)
		{
			this.Model_name = Model_name;
			this.Speed_USB_3_0 = Speed_USB_3_0;
			this.Memory = Memory;
		}
		public override double Copying_data(double amount_files, double memory_file)
		{
			int free = Get_memory_free();
			double result = (amount_files * memory_file / 1024) / free;
			int temp = Convert.ToInt32(result);
			if (temp < result)
			{
				return temp + 1;
			}
			return temp;
		}

		public override void Get_info()
		{
			Console.WriteLine($"Модель: {Model_name}\nСкорость USB 3.0: {Speed_USB_3_0} Гбит\\с \nОбъём памяти: {Memory} GB\nСвободно: {Get_memory_free()}");
		}

		public override int Get_memory_free()
		{
			return Memory - notFreeMemory;
		}

		public override int Get_memory_size()
		{
			return Memory;
		}
	}
}
