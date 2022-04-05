Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("=========== Kelompok 1 =============== ")
        Console.WriteLine("1. Eggi Andika Maulana")
        Console.WriteLine("2. Muhammad Rijaldi")
        Console.WriteLine("3. Renda Sandi Saputra")
        Console.WriteLine("4. Syarif Maulana Malik Ibrahim")
        Console.WriteLine("5. Valentio Aditama")
        Console.WriteLine("6. Yogi Rizki Rahmawan")
        Console.WriteLine()

        Dim choose As Integer
        Console.WriteLine("1. Ruang Tes CPNS 2019")
        Console.WriteLine("2. Menampilkan 25 nabi dan rasul")
        Console.WriteLine("3. Quit")
        Console.Write("Silakan Pilih > ")
        choose = Console.ReadLine()

        Try
            If choose = 1 Then
                Console.WriteLine("Ruang tes CPNS 2019")
                Console.Write("Masukan umur > ")
                Dim umur As Integer
                umur = Console.ReadLine()
                If umur < 20 Then
                    Console.WriteLine("Ruang tes 1")
                ElseIf umur >= 20 And umur <= 25 Then
                    Dim jenis_kelamin As String
                    Console.WriteLine("Jenis Kelamin ")
                    Console.WriteLine("1. Laki-laki")
                    Console.WriteLine("2. Perempuan")
                    Console.Write("masukan jenis Kelamin : > ")
                    jenis_kelamin = Console.ReadLine()
                    If jenis_kelamin = "1" Then
                        Console.WriteLine("Ruang tes 2")
                    ElseIf jenis_kelamin = "2" Then
                        Console.WriteLine("Ruang tes 3")
                    End If
                ElseIf umur > 25 And umur < 36 Then
                    Console.WriteLine("Ruang tes 4")
                Else
                    Console.WriteLine("Tidak mendapatkan Ruang Tes")
                End If

            ElseIf choose = 2 Then
                Console.WriteLine("25 Nabi dan Rosul ")
                Dim pilih_nabi As Integer
                Console.Write("No. 1-25 > ")
                pilih_nabi = Console.ReadLine()
                If pilih_nabi = 1 Then
                    Console.WriteLine("Nabi Adam AS.")
                ElseIf pilih_nabi = 2 Then
                    Console.WriteLine("Nabi Idris As.")
                ElseIf pilih_nabi = 3 Then
                    Console.WriteLine("Nabi Nuh As.")
                ElseIf pilih_nabi = 4 Then
                    Console.WriteLine("Nabi Hud As.")
                ElseIf pilih_nabi = 5 Then
                    Console.WriteLine("Nabi Saleh As.")
                ElseIf pilih_nabi = 6 Then
                    Console.WriteLine("Nabi Ibrahim As.")
                ElseIf pilih_nabi = 7 Then
                    Console.WriteLine("Nabi Luth As. ")
                ElseIf pilih_nabi = 8 Then
                    Console.WriteLine("Nabi Ismail As. ")
                ElseIf pilih_nabi = 9 Then
                    Console.WriteLine("Nabi Ishaq As. ")
                ElseIf pilih_nabi = 10 Then
                    Console.WriteLine("Nabi Yaqub As. ")
                ElseIf pilih_nabi = 11 Then
                    Console.WriteLine("Nabi Yusuf As. ")
                ElseIf pilih_nabi = 12 Then
                    Console.WriteLine("Nabi Ayyub As. ")
                ElseIf pilih_nabi = 13 Then
                    Console.WriteLine("Nabi Syu'aib As. ")
                ElseIf pilih_nabi = 14 Then
                    Console.WriteLine("Nabi Musa As.")
                ElseIf pilih_nabi = 15 Then
                    Console.WriteLine("Nabi Harun As. ")
                ElseIf pilih_nabi = 16 Then
                    Console.WriteLine("Nabi Zulkifli As")
                ElseIf pilih_nabi = 17 Then
                    Console.WriteLine("Nabi Daud As. ")
                ElseIf pilih_nabi = 18 Then
                    Console.WriteLine("Nabi Sulaiman As. ")
                ElseIf pilih_nabi = 19 Then
                    Console.WriteLine("Nabi Ilyas As. ")
                ElseIf pilih_nabi = 20 Then
                    Console.WriteLine("Nabi Ilyasa As. ")
                ElseIf pilih_nabi = 21 Then
                    Console.WriteLine("Nabi Yahya As. ")
                ElseIf pilih_nabi = 22 Then
                    Console.WriteLine("Nabi Zakaria AS. ")
                ElseIf pilih_nabi = 23 Then
                    Console.WriteLine("Nabi Yahya AS. ")
                ElseIf pilih_nabi = 24 Then
                    Console.WriteLine("Nabi Isa As. ")
                ElseIf pilih_nabi = 25 Then
                    Console.WriteLine("Nabi Muhammad SAW.")
                Else
                    Console.WriteLine("Hanya 1-25 nabi dan rosul saja...")
                End If

            ElseIf choose = 3 Then
                Console.WriteLine("oke nuhun!, quit programs.....")
                End
            End If
        Catch ex As Exception
            Console.WriteLine("Invalid Error")
        End Try
    End Sub
End Module
