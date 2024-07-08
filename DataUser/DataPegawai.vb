Public Class DataPegawai

    Private Sub TextJumlah_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextJumlah.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            If String.IsNullOrEmpty(TextPegawai.Text) Then
                MessageBox.Show("Data Tidak Lengkap", "ID Pegawai Tolong Diisi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If String.IsNullOrEmpty(TextNama.Text) Then
                MessageBox.Show("Data Tidak Lengkap", "Nama Pegawai Tolong Diisi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If String.IsNullOrEmpty(ComboJabatan.Text) Then
                MessageBox.Show("Data Tidak Lengkap", "Jabatan Tolong Diisi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            If String.IsNullOrEmpty(TextJumlah.Text) Then
                MessageBox.Show("Data Tidak Lengkap", "Jumlah Anak Tolong Diisi", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim angka As Integer = 100000
            Dim Zakat As Double = 0.025
            Dim Pajak As Double = 0.05

            If ComboJabatan.Text = "Pimpinan" Then
                TextGaji.Text = "5000000"
                TextTunjangan.Text = Val(TextJumlah.Text) * angka
                TextZakat.Text = Val(TextGaji.Text) * Zakat
                TextPajak.Text = Val(TextGaji.Text) * Pajak
                TextTotal.Text = Val(TextGaji.Text) + Val(TextTunjangan.Text) - Val(TextZakat.Text) - Val(TextPajak.Text)
            ElseIf ComboJabatan.Text = "Manager" Then
                TextGaji.Text = "4000000"
                TextTunjangan.Text = Val(TextJumlah.Text) * angka
                TextZakat.Text = Val(TextGaji.Text) * Zakat
                TextPajak.Text = Val(TextGaji.Text) * Pajak
                TextTotal.Text = Val(TextGaji.Text) + Val(TextTunjangan.Text) - Val(TextZakat.Text) - Val(TextPajak.Text)
            ElseIf ComboJabatan.Text = "Staff" Then
                TextGaji.Text = "3000000"
                TextTunjangan.Text = Val(TextJumlah.Text) * angka
                TextZakat.Text = Val(TextGaji.Text) * Zakat
                TextPajak.Text = Val(TextGaji.Text) * Pajak
                TextTotal.Text = Val(TextGaji.Text) + Val(TextTunjangan.Text) - Val(TextZakat.Text) - Val(TextPajak.Text)
            End If
        End If


    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda ingin keluar?", "Pilihan", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close() ' Jika pengguna memilih "Yes", keluar dari aplikasi
        Else
            ' Jika pengguna memilih "No", kembalikan nilai kosong ke TextBox3, TextBox4, dan TextBox5
            TextJumlah.Text = ""
            TextGaji.Text = ""
            TextTunjangan.Text = ""
            TextZakat.Text = ""
            TextPajak.Text = ""
            TextTotal.Text = ""
            ComboJabatan.Text = "" ' Kembalikan ComboBox1 ke pilihan awal
            TextPegawai.Text = "" ' Bersihkan TextBox1
            TextNama.Text = "" ' Bersihkan TextBox2
        End If
    End Sub


    'Private Sub TextJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextJumlah.KeyPress
    '   If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    ' Panggil fungsi untuk memproses gaji
    '   BtnProses.PerformClick()
    ' Setelah memproses, fokuskan ke TextBox selanjutnya atau ke mana sesuai kebutuhan
    ' Misalnya, Anda ingin fokus ke ComboBox, maka gunakan:
    ' ComboJabatan.Focus()
    '    End If
    ' End Sub
End Class