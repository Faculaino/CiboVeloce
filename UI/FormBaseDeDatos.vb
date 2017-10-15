Imports MetroFramework
Imports BLL
Public Class FormBaseDeDatos




    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try

            Dim newBK = New BaseDeDatosBussines
            Dim respuesta = newBK.backup()

            If respuesta = True Then
                MetroMessageBox.Show(Me, "Datos Resguardados Correctamente", "Backup OK", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                MetroMessageBox.Show(Me, "Hubo un error que impidió guardar los datos. Intentelo más tarde", "Error Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MetroMessageBox.Show(Me, "Hubo un error que impidió guardar los datos. Intentelo más tarde", "Error Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click

        Dim dialog = New OpenFileDialog
        dialog.Filter = "Backup Files (*.bak;*.tm)|*.bak;*.tm"
        dialog.InitialDirectory = "C:\BackupSQL\"

        If dialog.ShowDialog = DialogResult.OK Then
            Dim archivo = dialog.FileName.Split("\")
            Dim BAK = archivo(2)
            Dim nuevoRestore = New BaseDeDatosBussines
            Dim respuesta = nuevoRestore.restore(BAK)

            If respuesta = True Then
                MetroMessageBox.Show(Me, "Se realizó Restore de la Base de Datos de forma correcta", "Restore OK", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                MetroMessageBox.Show(Me, "Hubo un error que impidió realizar Restore de los datos. Intentelo más tarde", "Error Restore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Else
                MsgBox("Operación de RESTORE cancelada")
        End If
    End Sub
End Class