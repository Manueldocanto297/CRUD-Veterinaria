<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdPerros = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtRaza = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.grdPerros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPerros
        '
        Me.grdPerros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPerros.Location = New System.Drawing.Point(26, 26)
        Me.grdPerros.Name = "grdPerros"
        Me.grdPerros.Size = New System.Drawing.Size(370, 272)
        Me.grdPerros.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(425, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Raza:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(425, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(425, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Color:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(428, 59)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(48, 20)
        Me.txtId.TabIndex = 8
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(428, 103)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(255, 20)
        Me.txtNombre.TabIndex = 9
        '
        'txtRaza
        '
        Me.txtRaza.Location = New System.Drawing.Point(428, 147)
        Me.txtRaza.Name = "txtRaza"
        Me.txtRaza.Size = New System.Drawing.Size(255, 20)
        Me.txtRaza.TabIndex = 10
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(428, 191)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(255, 20)
        Me.txtColor.TabIndex = 11
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(428, 242)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(79, 23)
        Me.btnIngresar.TabIndex = 12
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(513, 242)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(80, 23)
        Me.btnEditar.TabIndex = 13
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(599, 242)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(84, 23)
        Me.btnEliminar.TabIndex = 14
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(704, 332)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtRaza)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grdPerros)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Veterinaria"
        CType(Me.grdPerros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdPerros As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtRaza As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnEliminar As Button
End Class
