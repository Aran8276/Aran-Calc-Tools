// While digunakan untuk jika user ingin mengulangi program setelah operasi selesai.

while(true) // Pertemuan 3: Modifikasi Loop
{
    int choice;
    string invalidInputMessage = "Invalid input. Please enter a valid number.";
    Console.Clear();
    // Membaca inputan user untuk memilih program apa yang akan digunakan
    Console.WriteLine("Selamat datang di program AranTools");
    Console.WriteLine("1. Penghitung Luas Persegi");
    Console.WriteLine("2. Converter Suhu Fahrenheit ke Celsius");
    Console.WriteLine("3. Kaluklator Akar");
    Console.WriteLine("4. Cake Builder");

    Console.Write("Masukan pilihan anda: ");
    string userInput = Console.ReadLine();

    // Mencoba parse untuk mengubah string menjadi integer. Jika gagal atau tidak bisa, maka akan print error Invalid output

    // Pertemuan 3: Modifikasi Perulangan / IF ELSE
    if (!(int.TryParse(userInput, out choice)))
    {
        Console.WriteLine(invalidInputMessage);
    }
    // Jika nomor melebihi choice yang ada (max 3), maka akan print error Invalid output
    if (choice > 4)
    {
        Console.WriteLine(invalidInputMessage);
    }

    // Jika inputan user 1:
    if (choice == 1)
    {
        // Meminta data dan menyimpannya di variable tertentu
        Console.Write("Masukan Panjang: ");
        int panjang = Convert.ToInt32(Console.ReadLine());
        Console.Write("Masukan Lebar: ");
        int lebar = Convert.ToInt32(Console.ReadLine());

        // Melakukan kalkulasi rumus luas persegi
        int hasilLuas = panjang * lebar;

        // Print hasil kalkulasi tersebut di console
        Console.WriteLine("Luas Persegi Anda Adalah: " + hasilLuas);
    }
    // Jika inputan user 2:
    else if (choice == 2)
    {
        // Meminta data dan menyimpannya di variable tertentu
        Console.Write("Masukan Suhu F ");
        double fahr = Convert.ToDouble(Console.ReadLine());

        // Melakukan kalkulasi rumus suhu fahrenheit ke celcius
        double hasilSuhu = (fahr - 32) * 5 / 9;

        // Print hasil kalkulasi tersebut di console
        Console.WriteLine("Suhu Celcius Anda Adalah: " + hasilSuhu + "° celcius");
    }
    // Jika inputan user 3:
    else if (choice == 3)
    {
        // Meminta data dan menyimpannya di variable tertentu
        Console.Write("Masukan Angka Akar ");
        double angkaSqrt = Convert.ToDouble(Console.ReadLine());

        // Menggunakan method Math.Sqrt untuk menghitung akar
        double hasilSqrt = Math.Sqrt(angkaSqrt);

        // Print hasil kalkulasi tersebut di console
        Console.WriteLine("Akar dari: " + angkaSqrt + " adalah " + hasilSqrt);
    }
    else if (choice == 4)
    {
        while (true)
        {
            /* 
            Mendeklarasikan array string mengandung kue yang dapat digunakan 
            utk menampilkan informasi dan pemilihan inputan user
            */
            
            string[] listKue = { "Cheesecake", "Brownis", "Sponge Cake" };
            string[] listFondant = { "Biru", "Merah", "Kuning" };
            string[] listIcing = { "Blueberry", "Vanilla", "Matcha" };

            // Menampilkan data yang dibutuhkan dan meminta data dan menyimpannya di variable tertentu
            for (int i = 0; i < listKue.Length; i++)
            {
                Console.WriteLine(i + ". " + listKue[i]);
            }
            Console.Write("Masukan Index Kue (0 sampai 2) : ");
            int choiceKue = Convert.ToInt32(Console.ReadLine());

            // Mengeluarkan error & keluar dari code block jika choice melebihi dari 2
            if(choiceKue > 2)
            {
                Console.Write(invalidInputMessage);
                break;
            }
            Console.WriteLine(listKue[choiceKue]); // Menampilkan preview pilihan user

            // Fondant
            for (int i = 0; i < listFondant.Length; i++)
            {
                Console.WriteLine(i + ". " + listFondant[i]);
            }
            Console.Write("Masukan Index Fondant (0 sampai 2) : ");
            int choiceFondant = Convert.ToInt32(Console.ReadLine());

            if (choiceFondant > 2)
            {
                Console.Write(invalidInputMessage);
                break;
            }
            Console.WriteLine(listFondant[choiceFondant]);

            // Icing
            for (int i = 0; i < listIcing.Length; i++)
            {
                Console.WriteLine(i + ". " + listIcing[i]);
            }
            Console.Write("Masukan Index Icing (0 sampai 2) : ");
            int choiceIcing = Convert.ToInt32(Console.ReadLine());

            if (choiceIcing > 2)
            {
                Console.Write(invalidInputMessage);
                break;
            }
            Console.WriteLine(listIcing[choiceIcing]);

            // Mengoutput dengan inputan yang user telah input
            string hasilKue = $"Anda telah membuat: Kue {listKue[choiceKue]} dengan Fondant {listFondant[choiceFondant]} yang dihias oleh Icing {listIcing[choiceIcing]}";
            Console.WriteLine(hasilKue);
            break;
        }
    }

    /* 
    Menanya jika user ingin mengulangi program. Membaca inputan dan jika inputan tersebut bukan "Y" atau "y",
    maka program akan berulang dan loop tidak akan di break
     */
    Console.Write("Apakah anda ingin melakukan kalkulasi lagi? [Y/N]: ");
    string loopChoice = Console.ReadLine();
    if (!(loopChoice == "y" || loopChoice == "Y"))
    {
        break; // Break = Keluar dari loop while(true)
    }
}