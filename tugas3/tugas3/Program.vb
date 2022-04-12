Imports System

Module Program

    Public Function fungsi_return() As String
        fungsi_return = "return 1"
        Return "return 2"
    End Function
    Sub Main(args As String())
        Console.WriteLine("============== Tugas Pertemuan 7 ============")
        Console.WriteLine("================== Kelompok 1 ============")
        Console.WriteLine("1. Eggi Andika Maulana")
        Console.WriteLine("2. Muhammad Rijaldi")
        Console.WriteLine("3. Renda sandi saputra")
        Console.WriteLine("4. Syarif Maulana Malik ibrahim")
        Console.WriteLine("5. Valentio Aditama")
        Console.WriteLine("6. Yogi Rizki Rahmawan")
        Console.WriteLine("")

        Console.WriteLine("1. Statement Perulangan")
        Console.WriteLine("2. Statement Loncat")
        Console.WriteLine("3. Array")
        Console.WriteLine("4. Quit Program")

        Dim choose As Int16
        Console.Write("Pilih > ")
        choose = Console.ReadLine()
        If choose = 1 Then
            Dim menu_perulangan As Int16
            Console.WriteLine("========== statement Perulangan ============")
            Console.WriteLine("1. Statement While - End While")
            Console.WriteLine("2. Do Loop")
            Console.WriteLine("3. For next")
            Console.WriteLine("4. Pengulangan Bersarang")
            Console.Write("Pilih > ")
            menu_perulangan = Console.ReadLine()
            If menu_perulangan = 1 Then
                Console.WriteLine("===== Statement While - End While =====")
                Dim i As Int16 = 1
                While i <= 10
                    Console.WriteLine("ulang - {0}", i)
                    i += 1
                End While
            ElseIf menu_perulangan = 2 Then
                Console.WriteLine("=========== Do Loop ============")
                Dim i As Int16 = 1
                Do
                    Console.WriteLine("ulang - {0}", i)
                    i += 1
                Loop Until i > 10
            ElseIf menu_perulangan = 3 Then
                Console.WriteLine("========== For Next ========")
                For i As Int16 = 1 To 10
                    Console.WriteLine("Ulang - {0}", i)
                Next
            ElseIf menu_perulangan = 4 Then
                Console.WriteLine("========== Pengulangan Bersarang/ Nested Loop ===========")
                For i As Int16 = 1 To 10
                    For j As Int16 = 2 To 20
                        Console.WriteLine("ulang - {0}{0}", i, j)
                    Next
                Next
            Else
                Console.WriteLine("invalid input")
            End If
        ElseIf choose = 2 Then
            Console.WriteLine("======= Statement Loncat ========")
            Console.WriteLine("1. Statement Exit")
            Console.WriteLine("2. Statement Continue")
            Console.WriteLine("3. Statement Go To ")
            Console.WriteLine("4. Statement Return")
            Console.WriteLine("4. Statement End")
            Console.WriteLine("5. Statement Stop")
            Console.Write("Pilih > ")
            Dim menu_loncat As Int16
            menu_loncat = Console.ReadLine()
            If menu_loncat = 1 Then
                Console.WriteLine("======= Statement Exit ==========")
                Dim i As Int16 = 1
                While i <= 10
                    Console.WriteLine("- {0}", i)
                    i += 1
                    Exit While
                End While
            ElseIf menu_loncat = 2 Then
                Console.WriteLine("======= Statement Continue ==========")
                Dim i As Int16 = 1
                While i <= 10
                    Console.WriteLine("- {0}", i)
                    i += 1
                    Continue While
                End While
            ElseIf menu_loncat = 3 Then
                Console.WriteLine("======= Statement Go To ==========")
                Dim pilih As Int16
                Console.WriteLine("1. Dokumen 1 ")
                Console.WriteLine("2. Dokumen 2")
                Console.Write("Pilih > ")
                pilih = Console.ReadLine()
                Dim docs As String
                If pilih = 1 Then GoTo Line1 Else GoTo Line2
Line1:
                Console.WriteLine("baris pertama")
                GoTo LastLine
Line2:
                Console.WriteLine("Baris kedua")
LastLine:
                Console.WriteLine("Last line")
            ElseIf menu_loncat = 4 Then
                Console.WriteLine("======= Statement Return ==========")
                Console.WriteLine(fungsi_return)
            ElseIf menu_loncat = 5 Then
                Console.WriteLine("======= Statement End ==========")
                End
                Console.WriteLine("baris ini tidak akan di eksekusi karena sudah di stop programm oleh fungsi end")
            ElseIf menu_loncat = 6 Then
                Console.WriteLine("======= Statement Stop ==========")
                Stop
                Console.WriteLine("baris ini tidak akan di eksekusi karena di suspend execution oleh fungsi Stop")
            Else
                Console.WriteLine("Invalid input")
            End If
        ElseIf choose = 3 Then
            Dim menu_array As Int16
            Console.WriteLine("======= Array ========")
            Console.WriteLine("1. Deklarasi Array")
            Console.WriteLine("2. Inisialisasi Array")
            Console.WriteLine("3. Array Multidimensi (Array 2 Dimensi dan Array 3 Dimensi)")
            Console.WriteLine("4. Deklarasi Array tanpa tipe data")
            Console.WriteLine("5. Array sebgai Parameter Metode (Prosedur / Fungsi)")
            Console.WriteLine("6. Array dari Objek")
            Console.WriteLine("7. Array dalam VB.Net (Metode CreateInstance (), Sort (), Reverse (), Copy (), CopyTo().")
            Console.Write("Pilih > ")
            menu_array = Console.ReadLine()
            If menu_array = 1 Then
                Console.WriteLine("======= Deklarasi Array ==========")
                Dim angka(5) As Integer
                Console.WriteLine(angka)
            ElseIf menu_array = 2 Then
                Console.WriteLine("======= Inisialisasi Array ==========")
                Dim angka(5) As Integer
                angka(0) = 1
                angka(1) = 2
                angka(2) = 3
                angka(3) = 4
                angka(4) = 5
                angka(5) = 6
                For a As Integer = 0 To 5
                    Console.Write($"{angka(a)}")
                Next
            ElseIf menu_array = 3 Then
                Console.WriteLine("======= Array Multidimensi (Array 2 Dimensi dan Array 3 Dimensi) ==========")

            End If
        ElseIf choose = 4 Then
            Console.WriteLine("Quit....")
            End
        End If
    End Sub
End Module
