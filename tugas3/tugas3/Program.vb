Imports System

Module Program

    Public Function fungsi_return() As String
        fungsi_return = "return 1"
        Return "return 2"
    End Function

    Public Function fungsi_menampilkanArray() As Integer
        Dim angka(5) As Integer
        angka(0) = 1
        angka(1) = 2
        angka(2) = 3
        angka(3) = 4
        angka(4) = 5
        angka(5) = 6
        For a As Integer = 0 To 5
            Console.Write(angka(a))
        Next
    End Function

    Sub sortName()
        Dim nama(5) As String
        nama(0) = "Muhammad Rijaldi"
        nama(1) = "Eggi Andika Maulana"
        nama(2) = "Syarif Maulana Malik Ibrahim"
        nama(3) = "Renda Sandi Saputra"
        nama(4) = "Yogi Rizki Rahmawan"
        nama(5) = "Valentio Aditama"
        Console.WriteLine("Before sorted:")
        For a As Integer = 0 To 5
            Console.WriteLine(nama(a))
        Next
        System.Array.Sort(nama)
        Console.WriteLine("")
        Console.WriteLine("After Sort: ")
        For b As Integer = 0 To 5
            Console.WriteLine(CStr(nama(b)))
        Next
    End Sub

    Sub reverseName()
        Dim nama(5) As String
        nama(0) = "Muhammad Rijaldi"
        nama(1) = "Eggi Andika Maulana"
        nama(2) = "Syarif Maulana Malik Ibrahim"
        nama(3) = "Renda Sandi Saputra"
        nama(4) = "Yogi Rizki Rahmawan"
        nama(5) = "Valentio Aditama"
        Console.WriteLine("Before Reverse: ")
        For a As Integer = 0 To 5
            Console.WriteLine(nama(a))
        Next
        Console.WriteLine("")
        Console.WriteLine("After Reverse: ")
        System.Array.Reverse(nama)
        For b As Integer = 0 To 5
            Console.WriteLine(CStr(nama(b)))
        Next
    End Sub

    Sub CopyName()
        Dim nama_hasilCopy(5) As String

        Dim nama(5) As String
        nama(0) = "Muhammad Rijaldi"
        nama(1) = "Eggi Andika Maulana"
        nama(2) = "Syarif Maulana Malik Ibrahim"
        nama(3) = "Renda Sandi Saputra"
        nama(4) = "Yogi Rizki Rahmawan"
        nama(5) = "Valentio Aditama"
        Console.WriteLine("Before copy: ")
        For a As Integer = 0 To 5
            Console.WriteLine(nama(a))
        Next
        Console.WriteLine("")
        Console.WriteLine("After Copy:")
        System.Array.Copy(nama, nama_hasilCopy, 4)
        For b As Integer = 0 To 4
            Console.WriteLine(nama_hasilCopy(b))
        Next
    End Sub

    Sub copyToName()
        Dim nama_hasilCopy(5) As String

        Dim nama(5) As String
        nama(0) = "Muhammad Rijaldi"
        nama(1) = "Eggi Andika Maulana"
        nama(2) = "Syarif Maulana Malik Ibrahim"
        nama(3) = "Renda Sandi Saputra"
        nama(4) = "Yogi Rizki Rahmawan"
        nama(5) = "Valentio Aditama"
        Console.WriteLine("Before copy: ")
        For a As Integer = 0 To 5
            Console.WriteLine(nama(a))
        Next
        Console.WriteLine("")
        Console.WriteLine("After Copy: ")
        nama.CopyTo(nama_hasilCopy, 0)
        For b As Integer = 0 To 5
            Console.WriteLine(nama_hasilCopy(b))
        Next
    End Sub

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
                Dim araywhere As Integer
                Console.WriteLine("1. Array dua dimensi")
                Console.WriteLine("2. Array tiga DImensi")
                Console.Write("pilih > ")
                araywhere = Console.ReadLine()
                If araywhere = 1 Then
                    Console.WriteLine("=========== Array Dua Dimensi ===========")
                    Dim angka(,) As Integer = {{1, 2}, {1, 3}, {0, 3}, {1, 1}}
                    Dim dimensi0 As Integer = angka.GetUpperBound(0)
                    Dim dimensi1 As Integer = angka.GetUpperBound(1)
                    For a As Integer = 0 To dimensi0
                        For b As Integer = 0 To dimensi1
                            Dim c As Integer = angka(a, b)
                            Console.Write(c)
                            Console.Write(" ")
                        Next
                        Console.WriteLine()
                    Next
                ElseIf araywhere = 2 Then
                    Console.WriteLine("=========== Array Tiga Dimensi ===========")
                    Dim angka(2, 2, 2) As Integer
                    angka(0, 0, 0) = 1
                    angka(1, 1, 1) = 2
                    angka(2, 2, 2) = 3
                    angka(1, 2, 1) = 4
                    angka(1, 1, 1) = 5
                    angka(2, 1, 2) = 6
                    For a As Integer = 0 To angka.GetLength(2) - 1
                        For b As Integer = 0 To angka.GetLength(1) - 1
                            For c As Integer = 0 To angka.GetLength(0) - 1
                                Console.Write(angka(a, b, c))
                            Next
                            Console.WriteLine()
                        Next
                        Console.WriteLine()
                    Next
                Else
                    Console.WriteLine("Invalid Error")
                End If
            ElseIf menu_array = 4 Then
                Console.WriteLine("=========== Deklarasi Array tanpa tipe data ===========")
                Dim angka(2)
                angka(0) = 1
                angka(1) = 2
                angka(2) = 3
                For a = 0 To 2
                    Console.Write(angka(2))
                Next
            ElseIf menu_array = 5 Then
                Console.WriteLine("=========== Array sebgai Parameter Metode (Prosedur / Fungsi) ===========")
                fungsi_menampilkanArray()
            ElseIf menu_array = 6 Then
                Console.WriteLine("=========== Array dari Objek ===========")
                Dim nama(5) As String
                nama(0) = "Eggi Andika Maulana"
                nama(1) = "Muhammad Rijladi"
                nama(2) = "Renda Sandi Saputra"
                nama(3) = "Syarif Maulana Malik Ibrahim"
                nama(4) = "Valentio Aditama"
                nama(5) = "Yogi Rizki Rahmawan"
                For a As Integer = 0 To 5
                    Console.WriteLine("- {0}", nama(a))
                Next
            ElseIf menu_array = 7 Then
                Console.WriteLine("=========== Array dalam VB.Net (Metode CreateInstance (), Sort (), Reverse (), Copy (), CopyTo(). ===========")
                Dim array_method As Integer
                Console.WriteLine("1. CreateInstance()")
                Console.WriteLine("2. Sort()")
                Console.WriteLine("3. Reverse()")
                Console.WriteLine("4. Copy()")
                Console.WriteLine("5. CopyTo()")
                Console.Write("Pilih > ")
                array_method = Console.ReadLine()
                If array_method = 1 Then
                    Console.WriteLine("============ CreateInstance() ============")
                    Dim angka As Array = Array.CreateInstance(GetType(Integer), 11)
                    For a As Integer = 0 To 10
                        angka.SetValue(a, a)
                    Next a
                    Console.WriteLine(Array.IndexOf(angka, 10).ToString)
                ElseIf array_method = 2 Then
                    Console.WriteLine("============ Sort() ============")
                    sortName()
                ElseIf array_method = 3 Then
                    Console.WriteLine("============ Reverse() ============")
                    reverseName()
                ElseIf array_method = 4 Then
                    Console.WriteLine("============ Copy() ============")
                    CopyName()
                ElseIf array_method = 5 Then
                    Console.WriteLine("============ Copy To() ============")
                    copyToName()
                Else
                    Console.WriteLine("Invalid Input")
                End If
            End If
        ElseIf choose = 4 Then
            Console.WriteLine("Quit....")
            End
        End If
    End Sub
End Module
