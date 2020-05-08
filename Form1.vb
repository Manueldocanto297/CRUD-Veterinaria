Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As MySqlConnection = New MySqlConnection
    Dim cmd As New MySqlCommand

    Private Sub ActualizarSelect()
        Dim ds As DataSet = New DataSet
        Dim adaptador As MySqlDataAdapter = New MySqlDataAdapter

        conexion.ConnectionString = "server=localhost; database=veterinaria; Uid=root; pwd=135790;"

        Try
            conexion.Open()
            cmd.Connection = conexion

            cmd.CommandText = "SELECT * FROM perros ORDER BY id ASC"
            adaptador.SelectCommand = cmd
            adaptador.Fill(ds, "Tabla")
            grdPerros.DataSource = ds
            grdPerros.DataMember = "Tabla"

            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        conexion.ConnectionString = "server=localhost; database=veterinaria; Uid=root; pwd=135790;"

        If (txtNombre.Text <> "") And (txtRaza.Text <> "") And (txtColor.Text <> "") Then
            Try
                conexion.Open()
                cmd.Connection = conexion

                cmd.CommandText = "INSERT INTO perros(nombreMascota,raza,color) VALUES (@nombre,@raza,@color)"
                cmd.Prepare()

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@raza", txtRaza.Text)
                cmd.Parameters.AddWithValue("@color", txtColor.Text)
                cmd.ExecuteNonQuery()

                conexion.Close()

                ActualizarSelect()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Error, compruebe que todos los datos sean correctos")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizarSelect()
    End Sub

    Private Sub grdPerros_SelectionChanged(sender As Object, e As EventArgs) Handles grdPerros.SelectionChanged
        If (grdPerros.SelectedRows.Count > 0) Then
            txtNombre.Text = grdPerros.Item("nombreMascota", grdPerros.SelectedRows(0).Index).Value
            txtRaza.Text = grdPerros.Item("raza", grdPerros.SelectedRows(0).Index).Value
            txtColor.Text = grdPerros.Item("color", grdPerros.SelectedRows(0).Index).Value
            txtId.Text = grdPerros.Item("id", grdPerros.SelectedRows(0).Index).Value
        End If


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        conexion.ConnectionString = "server=localhost; database=veterinaria; Uid=root; pwd=135790;"
        If (grdPerros.SelectedRows.Count > 0) Then

            Try
                conexion.Open()
                cmd.Connection = conexion

                cmd.CommandText = "UPDATE perros SET nombreMascota=@nombre, raza=@raza, color=@color WHERE id=@id"
                cmd.Prepare()

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text)
                cmd.Parameters.AddWithValue("@raza", txtRaza.Text)
                cmd.Parameters.AddWithValue("@color", txtColor.Text)
                cmd.Parameters.AddWithValue("@id", txtId.Text)

                cmd.ExecuteNonQuery()

                conexion.Close()

                ActualizarSelect()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Error, compuebe los datos antes de editar")
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        conexion.ConnectionString = "server=localhost; database=veterinaria; Uid=root; pwd=135790;"
        If MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            Try
                conexion.Open()
                cmd.Connection = conexion

                cmd.CommandText = "DELETE FROM perros WHERE id=@id"
                cmd.Prepare()

                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id", txtId.Text)

                cmd.ExecuteNonQuery()

                conexion.Close()

                ActualizarSelect()

                txtId.Clear()
                txtNombre.Clear()
                txtRaza.Clear()
                txtColor.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
End Class
