namespace LinkedList.Perpustakaan
{
    public class Buku
    {
        public string Judul{ get;}
        public string Penulis{ get;}
        public int Tahun{ get;}

        public Buku(string judul, string penulis, int tahun)
        {
            Judul = judul;
            Penulis = penulis;
            Tahun = tahun;
        }
    }

    public class BukuNode
    {
        public Buku Data{ get;}
        public BukuNode? Next{ get; set;}

        public BukuNode(Buku buku)
        {
            Data = buku;
            Next = null;
        }
    }

    public class KoleksiPerpustakaan
    {
        private BukuNode? head;
        public void TambahBuku(Buku buku)
        {
            var newNode = new BukuNode(buku) { Next = head };
            head = newNode;
        }

        public bool HapusBuku(string judul)
        {
            if(head == null){
                return false;
            }
            if(head.Data.Judul == judul){
                head = head.Next;
                return true;
            }
            BukuNode? current = head;
            while (current.Next != null)
            {
                if(current.Next.Data.Judul == judul){
                    current.Next = current.Next.Next;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Buku[] CariBuku(string kataKunci)
        {
            var hasil = new List<Buku>();
            BukuNode? current = head;
            while (current != null)
            {
                if(current.Data.Judul.Contains(kataKunci, StringComparison.OrdinalIgnoreCase)){
                    hasil.Add(current.Data);
                }
                current = current.Next;
            }
            return hasil.ToArray();
        }

        public string TampilkanKoleksi()
        {
            if (head == null) return string.Empty;
            
            var result = new List<string>();
            BukuNode? current = head;
            while (current != null)
            {
                result.Add($"\"{current.Data.Judul}\"; {current.Data.Penulis}; {current.Data.Tahun}");
                current = current.Next;
            }
            return string.Join("\n", result);
        }
    }
}
