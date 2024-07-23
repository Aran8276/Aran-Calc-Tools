// While digunakan untuk jika user ingin mengulangi program setelah operasi selesai.

while(true)
{
    int choice;
    string invalidInputMessage = "Invalid input. Please enter a valid number.";
    Console.Clear();
    // Membaca inputan user untuk memilih program apa yang akan digunakan
    Console.WriteLine("Selamat datang di program AranTools");
    Console.WriteLine("1. Penghitung Luas Persegi");
    Console.WriteLine("2. Converter Suhu Fahrenheit ke Celsius");
    Console.WriteLine("3. Kaluklator Akar");

    Console.Write("Masukan pilihan anda: ");
    string userInput = Console.ReadLine();

    // Mencoba parse untuk mengubah string menjadi integer. Jika gagal atau tidak bisa, maka akan print error Invalid output
    if (!(int.TryParse(userInput, out choice)))
    {
        Console.WriteLine(invalidInputMessage);
    }
    // Jika nomor melebihi choice yang ada (max 3), maka akan print error Invalid output
    if (choice > 3)
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

