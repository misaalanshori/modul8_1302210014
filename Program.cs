namespace modul8_1302210014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppConfig conf = new AppConfig();

            if (conf.config.lang.Equals("en")) {
                Console.Write("Please insert the amount of money to transfer: ");
            } else if (conf.config.lang.Equals("id")) {
                Console.Write("Masukkan jumlah uang yang akan di-transfer: ");
            }

            int jumlahTransfer;
            try
            {
                jumlahTransfer = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                jumlahTransfer = 0;
            }

            int biayaTransfer;
            if (jumlahTransfer <= conf.config.transfer.threshold)
            {
                biayaTransfer = conf.config.transfer.low_fee;
            } else
            {
                biayaTransfer = conf.config.transfer.high_fee;
            }

            if (conf.config.lang.Equals("en")) {
                Console.WriteLine("Transfer fee = " + biayaTransfer);
                Console.WriteLine("Total amount = " + (biayaTransfer + jumlahTransfer));
            }
            else if (conf.config.lang.Equals("id")) {
                Console.WriteLine("Biaya transfer = " + biayaTransfer);
                Console.WriteLine("Total Biaya = " + (biayaTransfer + jumlahTransfer));
            }

            if (conf.config.lang.Equals("en")) {
                Console.WriteLine("Select transfer method:");
            }
            else if (conf.config.lang.Equals("id")) {
                Console.WriteLine("Pilih metode transfer:");
            }

            for (int i = 0; i < conf.config.methods.Count(); i++)
            {
                Console.WriteLine($"{i + 1}. {conf.config.methods[i]}");
            }

            Console.Write("> ");
            int metodeTransfer;
            try
            {
                metodeTransfer = int.Parse(Console.ReadLine());
            } catch (FormatException)
            {
                metodeTransfer = 1;
            }

            if (conf.config.lang.Equals("en"))
            {
                Console.Write($"Please type \"{conf.config.confirmation.en}\" to confirm the transaction: ");
            }
            else if (conf.config.lang.Equals("id"))
            {
                Console.Write($"Ketik \"{conf.config.confirmation.id}\" untuk mengkonfirmasi transaksi: ");
            }

            string inputKonfirmasi = Console.ReadLine();

            if (conf.config.lang.Equals("en"))
            {
                if (inputKonfirmasi.Equals(conf.config.confirmation.en))
                {
                    Console.WriteLine("The transfer is completed");
                } 
                else
                {
                    Console.WriteLine("Transfer is cancelled");
                }
            }
            else if (conf.config.lang.Equals("id"))
            {
                if (inputKonfirmasi.Equals(conf.config.confirmation.id))
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }

        }
    }
}