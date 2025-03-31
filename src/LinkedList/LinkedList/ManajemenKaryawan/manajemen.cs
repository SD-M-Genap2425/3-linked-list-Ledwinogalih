using System;
using System.Collections.Generic;

namespace LinkedList.ManajemenKaryawan
{
    public class Karyawan
    {
        public string NomorKaryawan{ get;}
        public string Nama{ get;}
        public string Posisi{ get;}

        public Karyawan(string nomorKaryawan, string nama, string posisi)
        {
            NomorKaryawan = nomorKaryawan;
            Nama = nama;
            Posisi = posisi;
        }
    }

    public class KaryawanNode
    {
        public Karyawan Karyawan{ get;}
        public KaryawanNode? Next{ get; set;}
        public KaryawanNode? Prev{ get; set;}

        public KaryawanNode(Karyawan karyawan)
        {
            Karyawan = karyawan;
            Next = null;
            Prev = null;
        }
    }

    public class DaftarKaryawan
    {
        private KaryawanNode? head;
        private KaryawanNode? tail;

        public DaftarKaryawan()
        {
            head = null;
            tail = null;
        }

        public void TambahKaryawan(Karyawan karyawan)
        {
            var nodeBaru = new KaryawanNode(karyawan);
            if (tail == null){
                head = tail = nodeBaru;
            }else{
                tail.Next = nodeBaru;
                nodeBaru.Prev = tail;
                tail = nodeBaru;
            }
        }

        public bool HapusKaryawan(string nomorKaryawan)
        {
            var current = head;
            while (current != null)
            {
                if (current.Karyawan.NomorKaryawan == nomorKaryawan)
                {
                    if (current.Prev != null) current.Prev.Next = current.Next;
                    if (current.Next != null) current.Next.Prev = current.Prev;
                    if (current == head) head = current.Next;
                    if (current == tail) tail = current.Prev;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public Karyawan[] CariKaryawan(string kataKunci)
        {
            var hasil = new List<Karyawan>();
            var current = head;
            while (current != null)
            {
                if (current.Karyawan.Nama.Contains(kataKunci, StringComparison.OrdinalIgnoreCase) || current.Karyawan.Posisi.Contains(kataKunci, StringComparison.OrdinalIgnoreCase)){
                    hasil.Add(current.Karyawan);
                }
                current = current.Next;
            }
            return hasil.ToArray();
        }

        public string TampilkanDaftar()
        {
            var daftar = new List<string>();
            var current = tail;
            while (current != null)
            {
                daftar.Add($"{current.Karyawan.NomorKaryawan}; {current.Karyawan.Nama}; {current.Karyawan.Posisi}");
                current = current.Prev;
            }
            return string.Join("\n", daftar);
        }
    }
}
