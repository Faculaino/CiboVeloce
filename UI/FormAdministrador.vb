Imports MetroFramework
Imports BLL
Public Class FormAdministrador
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MetroFramework.MetroMessageBox.Show(Me, "Datos Resguardados Correctamente", "Backup OK", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim frmUsuarios = New FormUsuarios
        frmUsuarios.StartPosition = FormStartPosition.CenterScreen
        frmUsuarios.Show()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        Try
            Dim query As String = ""
            Dim archivo = Date.Now.Year.ToString() & "-" & Date.Now.Month.ToString() & "@" & "CiboVeloce.bak"
            Dim ubicacion = "C:\BackupSQL\" & archivo

            query = "BACKUP DATABASE [CiboVeloce] TO DISK = " & ubicacion

            Dim newBK = New BackupBussines
            Dim respuesta = newBK.backup(query)

            If respuesta = True Then
                MetroMessageBox.Show(Me, "Datos Resguardados Correctamente", "Backup OK", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                MetroMessageBox.Show(Me, "Hubo un error que impidió guardar los datos. Intentelo más tarde", "Error Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MetroMessageBox.Show(Me, "Hubo un error que impidió guardar los datos. Intentelo más tarde", "Error Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frmIdioma = New FormIdioma
        frmIdioma.StartPosition = FormStartPosition.CenterScreen
        frmIdioma.Show()
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim frmbitacora = New FormBitacora
        frmbitacora.StartPosition = FormStartPosition.CenterScreen
        frmbitacora.Show()
    End Sub
End Class