<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        botonigual = New Button()
        botondivision = New Button()
        botonmultiplicar = New Button()
        botonrestar = New Button()
        botonsuma = New Button()
        botonborrar = New Button()
        botonpunto = New Button()
        boton0 = New Button()
        boton9 = New Button()
        boton8 = New Button()
        boton7 = New Button()
        boton6 = New Button()
        boton5 = New Button()
        boton4 = New Button()
        boton3 = New Button()
        boton2 = New Button()
        boton1 = New Button()
        txresultado = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(botonigual)
        Panel1.Controls.Add(botondivision)
        Panel1.Controls.Add(botonmultiplicar)
        Panel1.Controls.Add(botonrestar)
        Panel1.Controls.Add(botonsuma)
        Panel1.Controls.Add(botonborrar)
        Panel1.Controls.Add(botonpunto)
        Panel1.Controls.Add(boton0)
        Panel1.Controls.Add(boton9)
        Panel1.Controls.Add(boton8)
        Panel1.Controls.Add(boton7)
        Panel1.Controls.Add(boton6)
        Panel1.Controls.Add(boton5)
        Panel1.Controls.Add(boton4)
        Panel1.Controls.Add(boton3)
        Panel1.Controls.Add(boton2)
        Panel1.Controls.Add(boton1)
        Panel1.Controls.Add(txresultado)
        Panel1.Location = New Point(89, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(469, 385)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(36, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(390, 72)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' botonigual
        ' 
        botonigual.Location = New Point(247, 328)
        botonigual.Name = "botonigual"
        botonigual.Size = New Size(75, 23)
        botonigual.TabIndex = 17
        botonigual.Text = "="
        botonigual.UseVisualStyleBackColor = True
        ' 
        ' botondivision
        ' 
        botondivision.Location = New Point(351, 328)
        botondivision.Name = "botondivision"
        botondivision.Size = New Size(75, 23)
        botondivision.TabIndex = 16
        botondivision.Text = "/"
        botondivision.UseVisualStyleBackColor = True
        ' 
        ' botonmultiplicar
        ' 
        botonmultiplicar.Location = New Point(351, 275)
        botonmultiplicar.Name = "botonmultiplicar"
        botonmultiplicar.Size = New Size(75, 23)
        botonmultiplicar.TabIndex = 15
        botonmultiplicar.Text = "*"
        botonmultiplicar.UseVisualStyleBackColor = True
        ' 
        ' botonrestar
        ' 
        botonrestar.Location = New Point(351, 226)
        botonrestar.Name = "botonrestar"
        botonrestar.Size = New Size(75, 23)
        botonrestar.TabIndex = 14
        botonrestar.Text = "-"
        botonrestar.UseVisualStyleBackColor = True
        ' 
        ' botonsuma
        ' 
        botonsuma.Location = New Point(351, 185)
        botonsuma.Name = "botonsuma"
        botonsuma.Size = New Size(75, 23)
        botonsuma.TabIndex = 13
        botonsuma.Text = "+"
        botonsuma.UseVisualStyleBackColor = True
        ' 
        ' botonborrar
        ' 
        botonborrar.Location = New Point(351, 124)
        botonborrar.Name = "botonborrar"
        botonborrar.Size = New Size(75, 23)
        botonborrar.TabIndex = 12
        botonborrar.Text = "C"
        botonborrar.UseVisualStyleBackColor = True
        ' 
        ' botonpunto
        ' 
        botonpunto.Location = New Point(145, 328)
        botonpunto.Name = "botonpunto"
        botonpunto.Size = New Size(75, 23)
        botonpunto.TabIndex = 11
        botonpunto.Text = "."
        botonpunto.UseVisualStyleBackColor = True
        ' 
        ' boton0
        ' 
        boton0.Location = New Point(47, 328)
        boton0.Name = "boton0"
        boton0.Size = New Size(75, 23)
        boton0.TabIndex = 10
        boton0.Text = "0"
        boton0.UseVisualStyleBackColor = True
        ' 
        ' boton9
        ' 
        boton9.Location = New Point(247, 275)
        boton9.Name = "boton9"
        boton9.Size = New Size(75, 23)
        boton9.TabIndex = 9
        boton9.Text = "9"
        boton9.UseVisualStyleBackColor = True
        ' 
        ' boton8
        ' 
        boton8.Location = New Point(145, 275)
        boton8.Name = "boton8"
        boton8.Size = New Size(75, 23)
        boton8.TabIndex = 8
        boton8.Text = "8"
        boton8.UseVisualStyleBackColor = True
        ' 
        ' boton7
        ' 
        boton7.Location = New Point(47, 275)
        boton7.Name = "boton7"
        boton7.Size = New Size(75, 23)
        boton7.TabIndex = 7
        boton7.Text = "7"
        boton7.UseVisualStyleBackColor = True
        ' 
        ' boton6
        ' 
        boton6.Location = New Point(247, 226)
        boton6.Name = "boton6"
        boton6.Size = New Size(75, 23)
        boton6.TabIndex = 6
        boton6.Text = "6"
        boton6.UseVisualStyleBackColor = True
        ' 
        ' boton5
        ' 
        boton5.Location = New Point(145, 226)
        boton5.Name = "boton5"
        boton5.Size = New Size(75, 23)
        boton5.TabIndex = 5
        boton5.Text = "5"
        boton5.UseVisualStyleBackColor = True
        ' 
        ' boton4
        ' 
        boton4.Location = New Point(47, 226)
        boton4.Name = "boton4"
        boton4.Size = New Size(75, 23)
        boton4.TabIndex = 4
        boton4.Text = "4"
        boton4.UseVisualStyleBackColor = True
        ' 
        ' boton3
        ' 
        boton3.Location = New Point(247, 185)
        boton3.Name = "boton3"
        boton3.Size = New Size(75, 23)
        boton3.TabIndex = 3
        boton3.Text = "3"
        boton3.UseVisualStyleBackColor = True
        ' 
        ' boton2
        ' 
        boton2.Location = New Point(145, 185)
        boton2.Name = "boton2"
        boton2.Size = New Size(75, 23)
        boton2.TabIndex = 2
        boton2.Text = "2"
        boton2.UseVisualStyleBackColor = True
        ' 
        ' boton1
        ' 
        boton1.Location = New Point(47, 185)
        boton1.Name = "boton1"
        boton1.Size = New Size(75, 23)
        boton1.TabIndex = 1
        boton1.Text = "1"
        boton1.UseVisualStyleBackColor = True
        ' 
        ' txresultado
        ' 
        txresultado.Location = New Point(47, 124)
        txresultado.Name = "txresultado"
        txresultado.Size = New Size(275, 23)
        txresultado.TabIndex = 0
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(628, 450)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents boton9 As Button
    Friend WithEvents boton8 As Button
    Friend WithEvents boton7 As Button
    Friend WithEvents boton6 As Button
    Friend WithEvents boton5 As Button
    Friend WithEvents boton4 As Button
    Friend WithEvents boton3 As Button
    Friend WithEvents boton2 As Button
    Friend WithEvents boton1 As Button
    Friend WithEvents txresultado As TextBox
    Friend WithEvents botonigual As Button
    Friend WithEvents botondivision As Button
    Friend WithEvents botonmultiplicar As Button
    Friend WithEvents botonrestar As Button
    Friend WithEvents botonsuma As Button
    Friend WithEvents botonborrar As Button
    Friend WithEvents botonpunto As Button
    Friend WithEvents boton0 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
