using System;

namespace Backup_copy
{
	class Program
	{
		static void Main(string[] args)
		{
			Flash flash = new Flash(5, 64, "ADATA");
			flash.Get_info();
			Console.WriteLine($"Для переноса этого объёма данных вам понадобиться {flash.Copying_data(780, 720)} Flash накопителей.\nВремя копирования: {flash.Get_time()} минут.\n");

			DVD dvd = new DVD(1, "Двусторонний", "Philips");
			dvd.Get_info();
			Console.WriteLine($"Для переноса этого объёма данных вам понадобиться {dvd.Copying_data(780, 720)} dvd дисков.\nВремя копирования: {dvd.Get_time()} минут.\n");

			HDD hdd = new HDD(480, 2, 120, "Seagate");
			hdd.Get_info();
			Console.WriteLine($"Для переноса этого объёма данных вам понадобиться {hdd.Copying_data(780, 720)} hdd дисков.\nВремя копирования: {hdd.Get_time()} минут.\n");

			Console.ReadKey();
		}
	}
}
