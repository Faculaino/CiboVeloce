Imports System.Text
Public Class MailManager

    Public Shared Sub enviarMail(destinatario As String, asunto As String, mensaje As String)
        Dim nuevoMail As New Net.Mail.MailMessage()
        Dim smtp As New Net.Mail.SmtpClient

        'Configuración del STMP
        smtp.Credentials = New System.Net.NetworkCredential("Correo Remitente", "Contraseña")
        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587
        smtp.EnableSsl = True
        'Configuración del Mensaje
        nuevoMail.[To].Add(destinatario)
        nuevoMail.From = New Net.Mail.MailAddress("Correo Remitente", "Nombre", Encoding.UTF8)
        nuevoMail.Subject = asunto
        nuevoMail.SubjectEncoding = Encoding.UTF8
        nuevoMail.Body = mensaje
        nuevoMail.BodyEncoding = Encoding.UTF8
        nuevoMail.Priority = Net.Mail.MailPriority.Normal
        nuevoMail.IsBodyHtml = False
        'Envío del Mail
        Try
            smtp.Send(nuevoMail)
            MsgBox("Mensaje enviado correctamene", "Exito!", MsgBoxStyle.Information)
        Catch ex As System.Net.Mail.SmtpException
            MsgBox(ex.ToString, "Error!", MsgBoxStyle.Critical)
        End Try
    End Sub



End Class
