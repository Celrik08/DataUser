<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPegawai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextPegawai = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        TextNama = New TextBox()
        TextJumlah = New TextBox()
        TextGaji = New TextBox()
        TextTunjangan = New TextBox()
        TextZakat = New TextBox()
        TextPajak = New TextBox()
        TextTotal = New TextBox()
        ComboJabatan = New ComboBox()
        BtnExit = New Button()
        SuspendLayout()
        ' 
        ' TextPegawai
        ' 
        TextPegawai.Location = New Point(145, 12)
        TextPegawai.Name = "TextPegawai"
        TextPegawai.Size = New Size(151, 28)
        TextPegawai.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 20)
        Label1.TabIndex = 1
        Label1.Text = "Id Pegawai"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nama Pegawai"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 83)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 3
        Label3.Text = "Jabatan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 117)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 4
        Label4.Text = "Jumlah Anak"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 20)
        Label5.TabIndex = 5
        Label5.Text = "Gaji Pokok"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 185)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 20)
        Label6.TabIndex = 6
        Label6.Text = "Tunjangan Anak"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 219)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 20)
        Label7.TabIndex = 7
        Label7.Text = "Zakat"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 253)
        Label8.Name = "Label8"
        Label8.Size = New Size(50, 20)
        Label8.TabIndex = 8
        Label8.Text = "Pajak"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 287)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 20)
        Label9.TabIndex = 9
        Label9.Text = "Total Gaji"
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(145, 46)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(151, 28)
        TextNama.TabIndex = 10
        ' 
        ' TextJumlah
        ' 
        TextJumlah.Location = New Point(145, 114)
        TextJumlah.Name = "TextJumlah"
        TextJumlah.Size = New Size(151, 28)
        TextJumlah.TabIndex = 11
        ' 
        ' TextGaji
        ' 
        TextGaji.Enabled = False
        TextGaji.Location = New Point(145, 148)
        TextGaji.Name = "TextGaji"
        TextGaji.Size = New Size(151, 28)
        TextGaji.TabIndex = 12
        ' 
        ' TextTunjangan
        ' 
        TextTunjangan.Enabled = False
        TextTunjangan.Location = New Point(145, 182)
        TextTunjangan.Name = "TextTunjangan"
        TextTunjangan.Size = New Size(151, 28)
        TextTunjangan.TabIndex = 13
        ' 
        ' TextZakat
        ' 
        TextZakat.Enabled = False
        TextZakat.Location = New Point(145, 216)
        TextZakat.Name = "TextZakat"
        TextZakat.Size = New Size(151, 28)
        TextZakat.TabIndex = 14
        ' 
        ' TextPajak
        ' 
        TextPajak.Enabled = False
        TextPajak.Location = New Point(145, 250)
        TextPajak.Name = "TextPajak"
        TextPajak.Size = New Size(151, 28)
        TextPajak.TabIndex = 15
        ' 
        ' TextTotal
        ' 
        TextTotal.Enabled = False
        TextTotal.Location = New Point(145, 284)
        TextTotal.Name = "TextTotal"
        TextTotal.Size = New Size(151, 28)
        TextTotal.TabIndex = 16
        ' 
        ' ComboJabatan
        ' 
        ComboJabatan.FormattingEnabled = True
        ComboJabatan.Items.AddRange(New Object() {"Pimpinan", "Manager", "Staff"})
        ComboJabatan.Location = New Point(145, 80)
        ComboJabatan.Name = "ComboJabatan"
        ComboJabatan.Size = New Size(151, 28)
        ComboJabatan.TabIndex = 17
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(415, 97)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(94, 29)
        BtnExit.TabIndex = 18
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' DataPegawai
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(674, 450)
        Controls.Add(BtnExit)
        Controls.Add(ComboJabatan)
        Controls.Add(TextTotal)
        Controls.Add(TextPajak)
        Controls.Add(TextZakat)
        Controls.Add(TextTunjangan)
        Controls.Add(TextGaji)
        Controls.Add(TextJumlah)
        Controls.Add(TextNama)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextPegawai)
        Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "DataPegawai"
        Text = "DataPegawai"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextPegawai As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextJumlah As TextBox
    Friend WithEvents TextGaji As TextBox
    Friend WithEvents TextTunjangan As TextBox
    Friend WithEvents TextZakat As TextBox
    Friend WithEvents TextPajak As TextBox
    Friend WithEvents TextTotal As TextBox
    Friend WithEvents ComboJabatan As ComboBox
    Friend WithEvents BtnExit As Button
End Class
