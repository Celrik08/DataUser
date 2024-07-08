Public Class DataSiswa
    Private Sub TextAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNISN.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
            MessageBox.Show("Nilai harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextNISN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNISN.KeyPress, TextNama.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.SelectNextControl(DirectCast(sender, Control), True, True, True, True)
        End If
    End Sub
    Private Sub RadioKelas1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RadioKelas1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.RadioKelas2.Focus()
            e.Handled = True
        End If
    End Sub
    Private Sub RadioKelas2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RadioKelas2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Me.SelectNextControl(RadioKelas2, True, True, True, True)
            e.Handled = True
        End If
    End Sub
    Private Sub TextHarian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextHarian.KeyPress
        ' Menggabungkan teks yang sudah ada di TextHarian dengan karakter yang baru dimasukkan oleh pengguna.
        Dim nilaiTextBox As String = TextHarian.Text & e.KeyChar

        ' Memeriksa apakah karakter yang dimasukkan bukan merupakan angka dan bukan karakter kontrol seperti Backspace atau Delete.
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika kondisi di atas terpenuhi, tandai event ini sebagai sudah di-handle.
            ' Ini berarti karakter yang tidak valid tidak akan ditambahkan ke dalam TextHarian.
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            ' Jika tombol "Enter" (kode karakter 13) ditekan, pindahkan fokus ke TextHarian
            Me.SelectNextControl(TextHarian, True, True, True, True)
            ' Tandai event sebagai sudah di-handle
            e.Handled = True
        End If
        ' Memeriksa apakah nilai di TextHarian melebihi 100. Jika iya, maka tampilkan pesan kesalahan.
        ' Selain itu, hapus nilai yang ada di Textharian dan keluar dari event handler untuk menghentikan perhitungan lebih lanjut.
        If Val(TextHarian.Text) > 100 Then
            MessageBox.Show("Nilai harus berada di antara 1 dan 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextHarian.Clear() ' Menghapus nilai yang ada di TextHarian.
            Return ' Keluar dari event handler agar tidak ada perhitungan lebih lanjut.
        End If
    End Sub
    Private Sub TextSTS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSTS.KeyPress
        ' Menggabungkan teks yang sudah ada di TextSTS dengan karakter yang baru dimasukkan oleh pengguna.
        Dim nilaiTextBox As String = TextSTS.Text & e.KeyChar

        ' Memeriksa apakah karakter yang dimasukkan bukan merupakan angka dan bukan karakter kontrol seperti Backspace atau Delete.
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika kondisi di atas terpenuhi, tandai event ini sebagai sudah di-handle.
            ' Ini berarti karakter yang tidak valid tidak akan ditambahkan ke dalam TextSTS.
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            ' Jika tombol "Enter" (kode karakter 13) ditekan, pindahkan fokus ke TextSTS
            Me.SelectNextControl(TextSTS, True, True, True, True)
            ' Tandai event sebagai sudah di-handle
            e.Handled = True
        End If
        ' Memeriksa apakah nilai di TextSTS melebihi 100. Jika iya, maka tampilkan pesan kesalahan.
        ' Selain itu, hapus nilai yang ada di TextSTS dan keluar dari event handler untuk menghentikan perhitungan lebih lanjut.
        If Val(TextSTS.Text) > 100 Then
            MessageBox.Show("Nilai harus berada di antara 1 dan 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextSTS.Clear() ' Menghapus nilai yang ada di TextSTS.
            Return ' Keluar dari event handler agar tidak ada perhitungan lebih lanjut.
        End If
    End Sub
    Private Sub TextSAS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextSAS.KeyPress
        ' Menggabungkan teks yang sudah ada di TextSAS dengan karakter yang baru dimasukkan oleh pengguna.
        Dim nilaiTextBox As String = TextSAS.Text & e.KeyChar

        ' Memeriksa apakah karakter yang dimasukkan bukan merupakan angka dan bukan karakter kontrol seperti Backspace atau Delete.
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika kondisi di atas terpenuhi, tandai event ini sebagai sudah di-handle.
            ' Ini berarti karakter yang tidak valid tidak akan ditambahkan ke dalam TextSAS.
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            ' Jika tombol "Enter" (kode karakter 13) ditekan, maka kita akan melakukan perhitungan nilai akhir.

            ' Memeriksa apakah nilai di TextSAS melebihi 100. Jika iya, maka tampilkan pesan kesalahan.
            ' Selain itu, hapus nilai yang ada di TextSAS dan keluar dari event handler untuk menghentikan perhitungan lebih lanjut.
            If Val(TextSAS.Text) > 100 Then
                MessageBox.Show("Nilai harus berada di antara 1 dan 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TextSAS.Clear() ' Menghapus nilai yang ada di TextSAS.
                Return ' Keluar dari event handler agar tidak ada perhitungan lebih lanjut.
            End If
            ' Jika nilai di TextSAS tidak melebihi 100, kita lanjutkan dengan melakukan perhitungan nilai akhir berdasarkan persentase.

            ' Mendefinisikan persentase bobot nilai untuk masing-masing komponen (Harian, STS, dan SAS).
            Dim PercentHarian As Double = 0.2
            Dim PercentSTS As Double = 0.3
            Dim PercentSAS As Double = 0.5

            ' Menghitung nilai akhir berdasarkan persentase yang telah ditetapkan.
            Dim NilaiAkhir As Integer = Val(TextHarian.Text) * PercentHarian + Val(TextSTS.Text) * PercentSTS + Val(TextSAS.Text) * PercentSAS

            ' Menampilkan nilai akhir ke dalam TextAkhir.
            TextAkhir.Text = NilaiAkhir

            ' Menghitung predikat berdasarkan nilai akhir
            Dim predikat As String = ""
            If NilaiAkhir >= 91 And NilaiAkhir <= 100 Then
                predikat = "A (Amat Baik)"
            ElseIf NilaiAkhir >= 81 And NilaiAkhir <= 90 Then
                predikat = "B (Baik)"
            ElseIf NilaiAkhir >= 75 And NilaiAkhir <= 80 Then
                predikat = "C (Cukup)"
            Else
                predikat = "D (Kurang)"
            End If

            ' Menampilkan predikat di Label TextPredikat
            TextPredikat.Text = predikat

        End If
    End Sub
    Private Sub Data_Siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextHarian.MaxLength = 3
        TextSTS.MaxLength = 3
        TextSAS.MaxLength = 3
    End Sub

    Private Sub TextHarian_TextChanged(sender As Object, e As EventArgs) Handles TextHarian.TextChanged

    End Sub
End Class