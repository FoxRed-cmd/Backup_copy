using System;
using System.Collections.Generic;
using System.Text;

namespace Backup_copy
{
	class HDD : Storage
	{
		private int Speed_USB_2_0 { get; set; }
		private int Value_of_directory { get; set; }
		private int Memory_of_directorys { get; set; }
		private int Memory;
		private int notFreeMemory = 0;
		int time;

		public HDD(int Speed_USB_2_0, int Value_of_directory, int Memory_of_directorys, string Model_name) : base(Model_name)
		{
			this.Speed_USB_2_0 = Speed_USB_2_0;
			this.Value_of_directory = Value_of_directory;
			this.Memory_of_directorys = Memory_of_directorys;
			this.Model_name = Model_name;
		}

		public override double Copying_data(double amount_files, double memory_file)
		{
			time = Convert.ToInt32((amount_files * memory_file / (Speed_USB_2_0 * 0.125)) / 60);
			int free = Get_memory_free();
			double result = (amount_files * memory_file / 1024) / free;
			int temp = Convert.ToInt32(result);
			if (temp < result)
			{
				return temp + 1;
			}
			return temp;
		}

		public int Get_time()
		{
			return time;
		}

		public override void Get_info()
		{
			Console.WriteLine($"Модель: {Model_name}\nКоличество разделов: {Value_of_directory}\nСкорость USB 2.0 {Speed_USB_2_0} Мбит\\с\nОбъём памяти раздела: {Memory_of_directorys} GB\nОбщий объём памяти: {Get_memory_size()}\nСвободно: {Get_memory_free()}");
		}

		public override int Get_memory_free()
		{
			return Memory - notFreeMemory;
		}

		public override int Get_memory_size()
		{
			return Memory = Value_of_directory * Memory_of_directorys;
		}
	}
}
