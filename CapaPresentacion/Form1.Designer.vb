<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtcontrasena = New System.Windows.Forms.TextBox()
        Me.chkactivo = New System.Windows.Forms.CheckBox()
        Me.cbotipo = New System.Windows.Forms.ComboBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(53, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NOMBRE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(53, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "APELLIDO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(53, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TIPOUSER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(53, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ESTADO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(53, 283)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CONTRASEÑA"
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(285, 97)
        Me.txtid.Multiline = True
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(228, 28)
        Me.txtid.TabIndex = 6
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Firebrick
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(26, 83)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(235, 283)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(285, 142)
        Me.txtnombre.Multiline = True
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(228, 28)
        Me.txtnombre.TabIndex = 8
        '
        'txtapellido
        '
        Me.txtapellido.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(285, 186)
        Me.txtapellido.Multiline = True
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(228, 28)
        Me.txtapellido.TabIndex = 9
        '
        'txtcontrasena
        '
        Me.txtcontrasena.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontrasena.Location = New System.Drawing.Point(267, 282)
        Me.txtcontrasena.Multiline = True
        Me.txtcontrasena.Name = "txtcontrasena"
        Me.txtcontrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontrasena.Size = New System.Drawing.Size(228, 28)
        Me.txtcontrasena.TabIndex = 10
        '
        'chkactivo
        '
        Me.chkactivo.AutoSize = True
        Me.chkactivo.Location = New System.Drawing.Point(285, 332)
        Me.chkactivo.Name = "chkactivo"
        Me.chkactivo.Size = New System.Drawing.Size(80, 21)
        Me.chkactivo.TabIndex = 11
        Me.chkactivo.Text = "ACTIVO"
        Me.chkactivo.UseVisualStyleBackColor = True
        '
        'cbotipo
        '
        Me.cbotipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo.FormattingEnabled = True
        Me.cbotipo.Items.AddRange(New Object() {"Administrador", "Empleado"})
        Me.cbotipo.Location = New System.Drawing.Point(285, 240)
        Me.cbotipo.Name = "cbotipo"
        Me.cbotipo.Size = New System.Drawing.Size(228, 24)
        Me.cbotipo.TabIndex = 12
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNuevo.Location = New System.Drawing.Point(26, 382)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(235, 54)
        Me.btnNuevo.TabIndex = 13
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(543, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(673, 406)
        Me.DataGridView1.TabIndex = 14
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(278, 382)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(235, 54)
        Me.btnEditar.TabIndex = 15
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEliminar.Location = New System.Drawing.Point(26, 442)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(487, 54)
        Me.btnEliminar.TabIndex = 16
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Gadugi", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBuscar.Location = New System.Drawing.Point(921, 37)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(235, 54)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(687, 52)
        Me.txtBuscar.Multiline = True
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(228, 28)
        Me.txtBuscar.TabIndex = 18
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(498, 282)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(39, 27)
        Me.btnVer.TabIndex = 19
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Gadugi", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(682, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 28)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(1228, 573)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.cbotipo)
        Me.Controls.Add(Me.chkactivo)
        Me.Controls.Add(Me.txtcontrasena)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtapellido As System.Windows.Forms.TextBox
    Friend WithEvents txtcontrasena As System.Windows.Forms.TextBox
    Friend WithEvents chkactivo As System.Windows.Forms.CheckBox
    Friend WithEvents cbotipo As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
