namespace LinkedList;  

class Program
{
    static void Main(string[] args)
    {
        // Soal Perpustakaan
        var perpustakaan = new LinkedList.Perpustakaan.KoleksiPerpustakaan();
        perpustakaan.TambahBuku(new LinkedList.Perpustakaan.Buku("The Hobbit", "J.R.R. Tolkien", 1937));
        perpustakaan.TambahBuku(new LinkedList.Perpustakaan.Buku("1984", "George Orwell", 1949));
        perpustakaan.TambahBuku(new LinkedList.Perpustakaan.Buku("The Catcher in the Rye", "J.D. Salinger", 1951));

        Console.WriteLine(perpustakaan.TampilkanKoleksi());
        

        // Soal ManajemenKaryawan
        var daftar = new ManajemenKaryawan.DaftarKaryawan();
        daftar.TambahKaryawan(new ManajemenKaryawan.Karyawan("001", "John Doe", "Manager"));
        daftar.TambahKaryawan(new ManajemenKaryawan.Karyawan("002", "Jane Doe", "HR"));
        daftar.TambahKaryawan(new ManajemenKaryawan.Karyawan("003", "Bob Smith", "IT"));

        Console.WriteLine("Daftar Karyawan:");
        Console.WriteLine(daftar.TampilkanDaftar());

        daftar.HapusKaryawan("002");
        Console.WriteLine("\nSetelah menghapus Jane Doe:");
        Console.WriteLine(daftar.TampilkanDaftar());
        

        // Soal Inventori
        var inventori = new Inventori.ManajemenInventori();

        inventori.TambahItem(new Inventori.Item("Apple", 50));
        inventori.TambahItem(new Inventori.Item("Orange", 30));
        inventori.TambahItem(new Inventori.Item("Banana", 20));

        Console.WriteLine("Daftar Inventori:");
        Console.WriteLine(inventori.TampilkanInventori());
    }
}
