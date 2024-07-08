<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataSiswa
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        TextNISN = New TextBox()
        TextNama = New TextBox()
        RadioKelas1 = New RadioButton()
        RadioKelas2 = New RadioButton()
        TextHarian = New TextBox()
        TextSTS = New TextBox()
        TextSAS = New TextBox()
        TextAkhir = New TextBox()
        TextPredikat = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 0
        Label1.Text = "NISN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 49)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 20)
        Label3.TabIndex = 2
        Label3.Text = "Kelas"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 3
        Label4.Text = "Nilai Harian"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 4
        Label5.Text = "Nilai STS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 181)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 20)
        Label6.TabIndex = 5
        Label6.Text = "Nilai SAS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 20)
        Label7.TabIndex = 6
        Label7.Text = "Nilai Akhir"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 254)
        Label8.Name = "Label8"
        Label8.Size = New Size(69, 20)
        Label8.TabIndex = 7
        Label8.Text = "Predikat"
        ' 
        ' TextNISN
        ' 
        TextNISN.Location = New Point(113, 12)
        TextNISN.Name = "TextNISN"
        TextNISN.Size = New Size(125, 28)
        TextNISN.TabIndex = 8
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(113, 46)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(125, 28)
        TextNama.TabIndex = 9
        ' 
        ' RadioKelas1
        ' 
        RadioKelas1.AutoSize = True
        RadioKelas1.Location = New Point(113, 80)
        RadioKelas1.Name = "RadioKelas1"
        RadioKelas1.Size = New Size(114, 24)
        RadioKelas1.TabIndex = 10
        RadioKelas1.TabStop = True
        RadioKelas1.Text = "XI PPLG 1"
        RadioKelas1.UseVisualStyleBackColor = True
        ' 
        ' RadioKelas2
        ' 
        RadioKelas2.AutoSize = True
        RadioKelas2.Location = New Point(233, 80)
        RadioKelas2.Name = "RadioKelas2"
        RadioKelas2.Size = New Size(114, 24)
        RadioKelas2.TabIndex = 11
        RadioKelas2.TabStop = True
        RadioKelas2.Text = "XI PPLG 2"
        RadioKelas2.UseVisualStyleBackColor = True
        ' 
        ' TextHarian
        ' 
        TextHarian.Location = New Point(113, 110)
        TextHarian.Name = "TextHarian"
        TextHarian.Size = New Size(125, 28)
        TextHarian.TabIndex = 12
        ' 
        ' TextSTS
        ' 
        TextSTS.Location = New Point(113, 144)
        TextSTS.Name = "TextSTS"
        TextSTS.Size = New Size(125, 28)
        TextSTS.TabIndex = 13
        ' 
        ' TextSAS
        ' 
        TextSAS.Location = New Point(113, 178)
        TextSAS.Name = "TextSAS"
        TextSAS.Size = New Size(125, 28)
        TextSAS.TabIndex = 14
        ' 
        ' TextAkhir
        ' 
        TextAkhir.Location = New Point(113, 212)
        TextAkhir.Name = "TextAkhir"
        TextAkhir.Size = New Size(125, 28)
        TextAkhir.TabIndex = 15
        ' 
        ' TextPredikat
        ' 
        TextPredikat.AutoSize = True
        TextPredikat.Location = New Point(113, 254)
        TextPredikat.Name = "TextPredikat"
        TextPredikat.Size = New Size(162, 20)
        TextPredikat.TabIndex = 16
        TextPredikat.Text = "_________________"
        ' 
        ' DataSiswa
        ' 
        AutoScaleDimensions = New SizeF(10F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(809, 449)
        Controls.Add(TextPredikat)
        Controls.Add(TextAkhir)
        Controls.Add(TextSAS)
        Controls.Add(TextSTS)
        Controls.Add(TextHarian)
        Controls.Add(RadioKelas2)
        Controls.Add(RadioKelas1)
        Controls.Add(TextNama)
        Controls.Add(TextNISN)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "DataSiswa"
        Text = "DataSiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextNISN As TextBox
    Friend WithEvents TextNama As TextBox
    Friend WithEvents RadioKelas1 As RadioButton
    Friend WithEvents RadioKelas2 As RadioButton
    Friend WithEvents TextHarian As TextBox
    Friend WithEvents TextSTS As TextBox
    Friend WithEvents TextSAS As TextBox
    Friend WithEvents TextAkhir As TextBox
    Friend WithEvents TextPredikat As Label
End Class
