Imports System
Module Program
    Sub Main(args As String())
        ' ini adalah comment pada program 
        ' pada blok ini adalah untuk menghasilkan informasi output text pada layar
        Console.WriteLine("Nama: Valentio Aditama")
        Console.WriteLine("NPM: 9882405121111029")
        Console.WriteLine()
        Console.WriteLine("=============== Hello Gais ===============")
        Console.WriteLine("1. Isi Biodata")
        Console.WriteLine("2. Desklarasi Variabel menggunakan GetType()")
        Console.WriteLine("3. Konversi tipe data String ke tipe data lainnya")
        Console.WriteLine("4. Deklarasi Konstata")
        Console.WriteLine("5. Quit")
        '===================================================================================

        'fungsi pada komentar, program tidak akan meng-eksekusi. melainkan hanya untuk sebagai catatan/penjelesan program yang sudah kita tulis
        ' Masukan Input untuk memilih menu 1-5 menggunakan if elseif 
        Dim pilih As String
        Console.Write("Masukan input: ")
        pilih = Console.ReadLine()

        If pilih = "1" Then
            Console.WriteLine("============= Isi biodata ================")
            Dim nama, tanggalLahir, hobi As String
            Console.Write("Masukan Nama Lengkap: ")
            nama = Console.ReadLine()
            Console.Write("Tanggal Lahir: ")
            tanggalLahir = Console.ReadLine()
            Console.Write("hobi:  ")
            hobi = Console.ReadLine()

            Console.WriteLine("============= Hasil =================")
            Console.WriteLine("Nama lengkap: {0}", nama)
            Console.WriteLine("Tanggal Lahir: {0}", tanggalLahir)
            Console.WriteLine("Hobi: {0}", hobi)
            Console.WriteLine("======================================")
            Console.ReadLine()
        ElseIf pilih = "2" Then
            Console.WriteLine("======= Deklarasi variabel menggunakan GetType() =======")
            Dim a = 23902392
            Dim b = "ini karakter"
            Dim c = 1.23F
            Dim e = 1.239293
            Console.WriteLine("=============== Hasil =================")
            Console.WriteLine("hasil: {0}", a.GetType())
            Console.WriteLine("hasil: {0}", b.GetType())
            Console.WriteLine("hasil: {0}", c.GetType())
            Console.WriteLine("hasil: {0}", e.GetType())
        ElseIf pilih = "3" Then
            Console.WriteLine("======== Konversi Tipe data String ke tipe data lainnya =========")
            Dim text As String
            Dim hasilConvert = Convert.ToInt32(text)
            Console.WriteLine("Hasil konversi: {0}", hasilConvert.GetType())
            Console.WriteLine("============= sebelum di konversi ============")
            Dim num1, num2 As String
            num1 = 10
            num2 = 20
            Dim hasilnum = num1 + num2
            Console.WriteLine("Hasil: {0}", hasilnum)
            Console.WriteLine("=====================================================")
            Console.WriteLine("================ Setelah di konversi ================")
            Dim convert_num1 = Convert.ToInt32(num1)
            Console.Write("Number 1: ")
            convert_num1 = Console.ReadLine()
            Dim convert_num2 = Convert.ToInt32(num2)
            Console.Write("Number 2: ")
            convert_num2 = Console.ReadLine()
            Dim hasil = convert_num1 + convert_num2
            Console.WriteLine("Hasil: {0}", hasil)
            Console.ReadLine()
        ElseIf pilih = "4" Then
            Console.WriteLine("============= Deklarasi Konstanta ===============")
            Console.WriteLine("Menghitung Luas lingkaran")

            Const phi As Double = 3.14
            Dim r, luas As Double
            Console.Write("Masukan Jari-jari Lingkaran: ")
            r = Console.ReadLine()
            luas = phi * r * r

            Console.WriteLine("Hasil Luas lingkaran : {0}", luas)
            Console.ReadLine()
        ElseIf pilih = "5" Then
            Console.WriteLine("Quit! nuhun bos")
            End
            Console.WriteLine("test")
        Else
            Console.WriteLine("Error bos, salah input")
        End If

    End Sub
End Module
