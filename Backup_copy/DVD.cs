using System;
using System.Collections.Generic;
using System.Text;

namespace Backup_copy
{
	class DVD : Storage
	{
		private int Speed_read_of_recording { get; set; }
		private string Type { get; set; }
		private int Memory;
		private int notFreeMemory = 0;
		public DVD(int Speed_read_of_recording, string Type, string Model_name) : base(Model_name)
		{
			this.Speed_read_of_recording = Speed_read_of_recording;
			this.Type = Type;
			this.Model_name = Model_name;

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
			Console.WriteLine($"Модель: {Model_name}\nТип: {Type}\nСкорость чтения/записи: {Speed_read_of_recording} Мбит\\с\nОбъём памяти: {Get_memory_size()} GB\nСвободно: {Get_memory_free()}");
		}

		public override int Get_memory_free()
		{
			return Memory - notFreeMemory;
		}

		public override int Get_memory_size()
		{
			if (Type == "Односторонний")
			{
				Memory = 5;
			}
			else
			{
				Memory = 9;
			}
			return Memory;
		}
	}
}
