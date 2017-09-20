Imports MetroFramework
Imports BLL
Imports Servicios
Public Class FormAdministrador


    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim frmUsuarios = New FormUsuarios
        frmUsuarios.StartPosition = FormStartPosition.CenterScreen
        frmUsuarios.Show()
    End Sub

    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click

        Try
            Dim query As String = ""
            Dim archivo = Date.Now.Year.ToString() & "-" & Date.Now.Month.ToString() & "-" & Date.Now.Day.ToString() & "@" & "CiboVeloce.bak"
            Dim ubicacion = "C:\BackupSQL\" & archivo

            'query = "BACKUP DATABASE [CiboVeloce] TO  DISK = N'" & ubicacion & "'" & " " & "WITH NOFORMAT, NOINIT,  NAME = N'CiboVeloce-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
            Dim SP = "SP_BackupSQL"


            Dim newBK = New BackupBussines
            'Dim respuesta = newBK.backup(query, ubicacion)
            Dim respuesta = newBK.backup(SP, ubicacion)

            If respuesta = True Then
                MetroMessageBox.Show(Me, "Datos Resguardados Correctamente", "Backup OK", MessageBoxButtons.OK, MessageBoxIcon.Question)
            Else
                MetroMessageBox.Show(Me, "Hubo un error que impidió guardar los datos. Intentelo más tarde", "Error Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MetroMessageBox.Show(Me, "Hubo un error que impidió guardar los datos. Intentelo más tarde", "Error Backup", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Dim nuevaBitacora = New BitacoraBussines
        nuevaBitacora.guardarEvento("Logout", SessionManager.Instance.Usuario)

        Me.Close()

        SessionManager.Instance.Logout()
        Application.Restart()
    End Sub

    Private Sub btnBitacora_Click(sender As Object, e As EventArgs) Handles btnBitacora.Click
        Dim frmbitacora = New FormBitacora
        frmbitacora.StartPosition = FormStartPosition.CenterScreen
        frmbitacora.Show()
    End Sub

    Private Sub btnIdioma_Click(sender As Object, e As EventArgs) Handles btnIdioma.Click
        Dim frmIdioma = New FormIdioma
        frmIdioma.StartPosition = FormStartPosition.CenterScreen
        frmIdioma.Show()
    End Sub

    Private Sub FormAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormAdministrador_Resize(sender As Object, e As EventArgs) Handles Me.Resize

    End Sub
End Class