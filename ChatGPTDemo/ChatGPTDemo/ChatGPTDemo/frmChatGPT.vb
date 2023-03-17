#Region "ABOUT"
' / --------------------------------------------------------------------------------
' / Developer : Mr.Surapon Yodsanga (Thongkorn Tubtimkrob)
' / eMail : thongkorn@hotmail.com
' / URL: http://www.g2gnet.com (Khon Kaen - Thailand)
' / Facebook: http://www.facebook.com/g2gnet (for Thailand)
' / Facebook: http://www.facebook.com/commonindy (Worldwide)
' / More Info: http://www.g2gsoft.com
' /
' / Purpose: Demonstrate Chat GPT in VB.NET.
' / Microsoft Visual Basic .NET (2017) + .Net Framework 4.5
' /
' / This is open source code under @CopyLeft by Thongkorn Tubtimkrob.
' / You can modify and/or distribute without to inform the developer.
' / --------------------------------------------------------------------------------
#End Region

'// Special Thanks : Igor Krupitsky (USA)
'// Original Source Code ... Chat GPT in VB.NET and C#
'// https://www.codeproject.com/Articles/5350339/Chat-GPT-in-VB-NET-and-Csharp

Imports System.Net
Imports System.IO
Imports System.ComponentModel

Public Class frmChatGPT
    '// Create API KEY ... https://beta.openai.com/account/api-keys
    Dim OPENAI_API_KEY As String = "" '<-- OpenAI Key
    '// สร้าง BackGroundWorker แบบ @Run Time
    Private WithEvents RequestWorker As New BackgroundWorker
    '// ประกาศตัวแปรแบบบูลีน เผื่อนำเอาไปใช้งานประโยชน์อย่างอื่น
    Dim blnSucceed As Boolean = False

    Private Sub frmChatGPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If OPENAI_API_KEY = "" Then
            MessageBox.Show("Please enter your OpenAI API key.", "Report Status", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End If
        Me.KeyPreview = True
        '// Initialize Models.
        With cmbModel
            .Items.Add("text-davinci-003")
            .Items.Add("text-davinci-002")
            .Items.Add("code-davinci-002")
        End With
        cmbModel.SelectedIndex = 0
        '// Initialize ComboBox.
        With cmbTemperature
            .IntegralHeight = False
            .ItemHeight = 10
        End With
        For Temperature As Double = 0.0 To 2.1 Step 0.1
            With cmbTemperature
                .Items.Add(Format(Temperature, "0.0"))
            End With
        Next
        cmbTemperature.SelectedIndex = 10
        '// Initialized BackGroundWorker.
        With RequestWorker
            .WorkerReportsProgress = True
            .WorkerSupportsCancellation = True
        End With
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        '//
    End Sub

    '// ต้องกำหนด KeyPreview = True ของฟอร์มด้วย
    Private Sub frmChatGPT_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            '// กดฟังค์ชั่นคีย์ F8
            Case Keys.F8 : Call btnSend_Click(sender, e)
            '// กดฟังค์ชั่นคีย์ F10
            Case Keys.F10
                Call btnExit_Click(sender, e)
        End Select
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        '// Trap Error
        If txtUserID.Text.Trim = "" Or txtUserID.Text.Trim = "0" Then txtUserID.Text = "1"
        If txtMaxTokens.Text = "" Or txtMaxTokens.Text.Trim.Length = 0 Or Val(txtMaxTokens.Text) > 4096 Then txtMaxTokens.Text = 2048
        Try
            '// Add Events Handler background worker to do some stuff.
            AddHandler RequestWorker.DoWork, AddressOf RequestWorker_DoWork '// เมื่อส่งไปทำงาน Background Process
            AddHandler RequestWorker.ProgressChanged, AddressOf RequestWorker_ProgressChanged  '// ระหว่างการทำงาน
            AddHandler RequestWorker.RunWorkerCompleted, AddressOf RequestWorker_Completed '// การทำงานเสร็จสมบูรณ์
            '// ต้องการเงื่อนไขไม่จริง หรือ ไม่ติดงานอื่น เลยใช้ Not เข้าช่วย
            If Not RequestWorker.IsBusy Then RequestWorker.RunWorkerAsync()

        Catch ex As Exception
            txtAnswer.AppendText("Error: " & ex.Message)
        End Try
    End Sub

    '// BackgroundWorker - Event Handler DoWork
    Private Sub RequestWorker_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs)
        System.Net.ServicePointManager.SecurityProtocol =
            System.Net.SecurityProtocolType.Ssl3 Or
            System.Net.SecurityProtocolType.Tls12 Or
            System.Net.SecurityProtocolType.Tls11 Or
            System.Net.SecurityProtocolType.Tls

        Dim sQuestion As String = txtQuestion.Text
        If sQuestion = "" Then
            'MsgBox("Type in your question!")
            txtQuestion.Focus()
            Exit Sub
        End If
        If txtAnswer.Text <> "" Then
            txtAnswer.AppendText(vbCrLf & vbCrLf & "Me: " & sQuestion & vbCrLf)
        Else
            txtAnswer.AppendText("Me: " & sQuestion & vbCrLf)
        End If
        txtQuestion.Text = ""
        Dim sAnswer As String = String.Empty
        txtAnswer.AppendText("Chat GPT: " & Replace(sAnswer, vbLf, vbCrLf))
        '//
        Try
            Dim apiEndpoint As String = "https://api.openai.com/v1/completions"
            Dim request As HttpWebRequest = CType(WebRequest.Create(apiEndpoint), HttpWebRequest)
            request.Method = "POST"
            request.ContentType = "application/json"
            request.Headers.Add("Authorization", "Bearer " & OPENAI_API_KEY)

            Dim iMaxTokens As Integer = Val(txtMaxTokens.Text) '// 2048

            Dim dTemperature As Double = Val(cmbTemperature.Text) '// 1.0 (Between 0 - 2)
            Dim sUserId As String = txtUserID.Text '// 1
            Dim sModel As String = cmbModel.Text '// text-davinci-003, text-davinci-002

            '// API อ้างอิง ... https://beta.openai.com/docs/api-reference/completions/create
            Dim data As String = "{"
            data += " ""model"":""" & sModel & ""","
            data += " ""prompt"": """ & PadQuotes(sQuestion) & ""","
            data += " ""max_tokens"": " & iMaxTokens & ","
            data += " ""user"": """ & sUserId & """, "
            data += " ""temperature"": " & dTemperature & ", "
            data += " ""frequency_penalty"": 0.0" & ", " 'Number between -2.0 and 2.0  Positive value decrease the model's likelihood to repeat the same line verbatim.
            data += " ""presence_penalty"": 0.0" & ", " ' Number between -2.0 and 2.0. Positive values increase the model's likelihood to talk about new topics.
            data += " ""stop"": [""#""]" 'Up to 4 sequences where the API will stop generating further tokens. The returned text will not contain the stop sequence.
            '// EDIT
            '// ตัดเครื่องหมาย Semi-Colon (;) ออกไป ไม่อย่างนั้นมันจะหยุดการทำงานเมื่อเจอเครื่องหมายนี้ ในกรณีของฐานข้อมูลที่คั่น Parameters ด้วย ;
            '// ชุดคำสั่งเดิม data += " ""stop"": [""#"", "";""]"
            data += "}"
            '//
            Using streamWriter As New StreamWriter(request.GetRequestStream())
                streamWriter.Write(data)
                streamWriter.Flush()
                streamWriter.Close()
            End Using
            '// รับข้อมูล JSON
            Dim response As HttpWebResponse = request.GetResponse()
            Dim streamReader As New StreamReader(response.GetResponseStream())
            Dim sJson As String = streamReader.ReadToEnd()  '// ตั้ง Cursor ไว้แถวบรรทัดนี้ แล้วกด Ctrl+F8 เพื่อทำการ Debugger หรือจะดูข้อมูลจาก JSON
            '//
            Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
            Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
            Dim sResponse As String = oJson("choices")(0)("text")
            '// ขึ้นบรรทัดใหม่ด้วยการเพิ่ม Cr (Carriage Return) หรือการกด Enter
            txtAnswer.AppendText(sResponse.Replace(vbLf, vbCrLf))
        Catch ex As Exception
            txtAnswer.AppendText("Error: " & ex.Message)
        End Try
    End Sub

    '// BackgroundWorker - Event Handler ProgressChanged หรือช่วงเวลาที่กำลังโปรเซสอยู่
    Private Sub RequestWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs)
        blnSucceed = False   '// เผื่อนำไปใช้งานอย่างอื่นล่ะกัน
        '// ระหว่างการทำงาน (RequestWorker.IsBusy) กำหนดให้ txtQuestion ถูกล็อคเอาไว้
        If Not txtQuestion.ReadOnly Then txtQuestion.ReadOnly = True
    End Sub

    '// BackgroundWorker - Event Handler RunWorkerCompleted
    Private Sub RequestWorker_Completed(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        blnSucceed = True   '// เผื่อนำไปใช้งานอย่างอื่นล่ะกัน
        If txtQuestion.ReadOnly Then txtQuestion.ReadOnly = False
    End Sub

    Private Function PadQuotes(ByVal s As String) As String

        If s.IndexOf("\") <> -1 Then
            s = Replace(s, "\", "\\")
        End If

        If s.IndexOf(vbCrLf) <> -1 Then
            s = Replace(s, vbCrLf, "\n")
        End If

        If s.IndexOf(vbCr) <> -1 Then
            s = Replace(s, vbCr, "\r")
        End If

        If s.IndexOf(vbLf) <> -1 Then
            s = Replace(s, vbLf, "\f")
        End If

        If s.IndexOf(vbTab) <> -1 Then
            s = Replace(s, vbTab, "\t")
        End If

        If s.IndexOf("""") = -1 Then
            Return s
        Else
            Return Replace(s, """", "\""")
        End If
    End Function

    '// กด ENTER ในช่อง txtQuestion ก็สั่งให้ไปทำงานเรียก OpenAI ได้เลย
    Private Sub txtQuestion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuestion.KeyPress
        If e.KeyChar = Chr(13) AndAlso chkEnter.Checked Then
            e.Handled = True
            Call btnSend_Click(sender, e)
        End If
    End Sub

    Private Sub txtMaxTokens_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaxTokens.KeyPress
        '// หากกด Enter
        If e.KeyChar = Chr(13) Then
            e.Handled = True    '// ปิดเสียงบิ๊บ (เหมือนกับไม่ได้กดคีย์อะไรเลย)
            SendKeys.Send("{TAB}")  '// เลื่อนโฟกัสไปยัง Control ตัวถัดไป
        Else
            '// รับค่าเฉพาะตัวเลขเท่านั้น
            e.Handled = CheckDigitOnly(Asc(e.KeyChar))
        End If
    End Sub

    Private Sub txtUserID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUserID.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtUserID_LostFocus(sender As Object, e As EventArgs) Handles txtUserID.LostFocus
        If txtUserID.Text.Trim = "" Or txtUserID.Text = "0" Then txtUserID.Text = "1"
    End Sub

    Private Sub txtMaxTokens_LostFocus(sender As Object, e As EventArgs) Handles txtMaxTokens.LostFocus
        If txtMaxTokens.Text = "" Or txtMaxTokens.Text.Trim.Length = 0 Or Val(txtMaxTokens.Text) > 4096 Then txtMaxTokens.Text = 2048
    End Sub

    Private Sub cmbModel_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbModel.KeyDown
        If e.KeyCode = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbTemperature_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbTemperature.KeyDown
        If e.KeyCode = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtAnswer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAnswer.KeyPress
        '// เทคนิคเล็กๆ ... เมื่อไม่ต้องการให้เกิดการกดคีย์ใดๆใน TextBox Control
        e.Handled = True
    End Sub

    Private Sub btnClearAnswer_Click(sender As Object, e As EventArgs) Handles btnClearAnswer.Click
        txtAnswer.Clear()
    End Sub

    Private Sub chkEnter_KeyDown(sender As Object, e As KeyEventArgs) Handles chkEnter.KeyDown
        If e.KeyCode = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    ' / --------------------------------------------------------------------------------
    ' / ฟังค์ชั่นในการป้อนเฉพาะค่าตัวเลขได้เท่านั้น
    Function CheckDigitOnly(ByVal index As Integer) As Boolean
        Select Case index
            Case 48 To 57 ' เลข 0 - 9
                CheckDigitOnly = False
            Case 8, 13 ' Backspace = 8, Enter = 13
                CheckDigitOnly = False
            Case Else
                CheckDigitOnly = True
        End Select
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmChatGPT_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        RequestWorker.Dispose()
        Me.Dispose()
        GC.SuppressFinalize(Me)
        Application.Exit()
        'End
    End Sub

End Class
