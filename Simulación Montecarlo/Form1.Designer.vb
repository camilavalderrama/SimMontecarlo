<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Button5 = New Button()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(299, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(440, 46)
        Label1.TabIndex = 0
        Label1.Text = "Cálculo del área bajo una curva mediante " & vbCrLf & "              Simulación Montecarlo"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(192, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 21)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese el intervalo"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 156)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(299, 156)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(189, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(18, 20)
        Label3.TabIndex = 4
        Label3.Text = "X"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(340, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(17, 20)
        Label4.TabIndex = 5
        Label4.Text = "Y"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(154, 297)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 40)
        Button1.TabIndex = 6
        Button1.Text = "100"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(299, 297)
        Button2.Name = "Button2"
        Button2.Size = New Size(100, 40)
        Button2.TabIndex = 7
        Button2.Text = "200"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(154, 343)
        Button3.Name = "Button3"
        Button3.Size = New Size(100, 40)
        Button3.TabIndex = 8
        Button3.Text = "500"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(299, 343)
        Button4.Name = "Button4"
        Button4.Size = New Size(100, 40)
        Button4.TabIndex = 9
        Button4.Text = "1000"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(175, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(214, 42)
        Label5.TabIndex = 10
        Label5.Text = "Seleccione la cantidad de " & vbCrLf & "      puntos aleatorios"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(34, 489)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(300, 200)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(393, 489)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(300, 200)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(753, 489)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(300, 200)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(120, 443)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 22)
        Label6.TabIndex = 14
        Label6.Text = "Iteración 1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(490, 444)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 22)
        Label7.TabIndex = 15
        Label7.Text = "Iteración 2"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(852, 444)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 22)
        Label8.TabIndex = 16
        Label8.Text = "Iteración 3"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(393, 754)
        Label9.Name = "Label9"
        Label9.Size = New Size(317, 22)
        Label9.TabIndex = 17
        Label9.Text = "Steven Rincón  - Camila Valderrama"
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ActiveCaption
        Button5.Location = New Point(-4, 714)
        Button5.Name = "Button5"
        Button5.Size = New Size(1097, 10)
        Button5.TabIndex = 19
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(548, 206)
        Label10.Name = "Label10"
        Label10.Size = New Size(128, 21)
        Label10.TabIndex = 21
        Label10.Text = "Puntos dentro:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(548, 166)
        Label11.Name = "Label11"
        Label11.Size = New Size(115, 21)
        Label11.TabIndex = 22
        Label11.Text = "Total puntos:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(548, 248)
        Label12.Name = "Label12"
        Label12.Size = New Size(130, 21)
        Label12.TabIndex = 23
        Label12.Text = "Área estimada:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(548, 287)
        Label13.Name = "Label13"
        Label13.Size = New Size(115, 21)
        Label13.TabIndex = 24
        Label13.Text = "Error aprox: "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1082, 799)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Button5)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
