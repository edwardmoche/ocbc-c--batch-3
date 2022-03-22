using System;

class io{
    static void Main(String[] args){
        string username, password, nama, j_kelamin, s_pernikahan;
        int umur;       
        float n1, n2, n3, total, rata;
        bool y, x, gender, status;
            
        
        
        Console.WriteLine("=== PROGRAM PEDAFTARAN ===");
        Console.Write("Masukan username: ");
        username = Console.ReadLine();

        Console.Write("Masukan password: ");
        password = Console.ReadLine();

        Console.Write("Masukan nama: ");
        nama = Console.ReadLine();

        Console.Write("Masukan umur: ");
        umur = int.Parse(Console.ReadLine());
        
        do
        {
            Console.Write("Jenis Kelamin (Pria/Wanita): ");
            j_kelamin = Console.ReadLine();
            x = j_kelamin == "Pria" || j_kelamin == "Wanita";
        } while (!x);
        
        gender = false;

        if (j_kelamin == "x")
        {
            gender = true;
        }

        do
        {
            Console.Write("Status Pernikahan (True/False): ");
            s_pernikahan = Console.ReadLine();
            y = s_pernikahan == "True" || s_pernikahan == "False";
        } while (!y);
        
        status = false;

        if (s_pernikahan == "True")
        {
            status = true;
        }

        

        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Masukan nilai pertama: ");
        n1 = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai kedua: ");
        n2 = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai ketiga: ");
        n3 = int.Parse(Console.ReadLine());
        total = n1 + n2 + n3;
        rata = total/3;

        Console.WriteLine();
        Console.WriteLine("Terimakasih!");
        Console.WriteLine("Data Berikut");
        Console.WriteLine($"Username: {username}");        
        Console.WriteLine($"Nama: {nama}");
        Console.WriteLine($"Umur: {umur} tahun");
        Console.WriteLine($"Jenis Kelamin: {j_kelamin}");
        Console.WriteLine($"Status Pernikahan: {s_pernikahan}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Nilai Total: {total}");
        Console.WriteLine($"Nilai Rata-rata: {rata}");
        Console.WriteLine("SUDAH DISIMPAN!");
    }
}