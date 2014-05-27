Imports System.Xml
Imports System.IO

Public Class Form1
    Dim arrCategories As List(Of usrCategory)
    Dim intCategoriesCount = 0
    Dim txtFocused As TextBox
    Dim strOpenFileName As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        arrCategories = New List(Of usrCategory)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddCategory("", "", "")
    End Sub

    Private Sub ButtonInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Try
            txtFocused.Focus()
            SendKeys.Send(lstQuickText.SelectedItem.ToString())
        Catch
        End Try
    End Sub

    Private Sub butOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOpen.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        fd.Title = "Open File Dialog"
        If strOpenFileName = "" Then
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Else
            fd.InitialDirectory = Path.GetDirectoryName(strOpenFileName)
        End If
        fd.Filter = "All files (*.*)|*.*|AIML files (*.aiml)|*.aiml"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            strOpenFileName = strFileName
            LoadFile(strFileName)
        End If
    End Sub

    Private Sub butSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSave.Click
        Dim fd As SaveFileDialog = New SaveFileDialog()
        Dim strFileName As String

        fd.Title = "Save File Dialog"
        If strOpenFileName = "" Then
            fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Else
            fd.InitialDirectory = Path.GetDirectoryName(strOpenFileName)
        End If
        fd.Filter = "All files (*.*)|*.*|AIML files (*.aiml)|*.aiml"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            SaveFile(strFileName)

            strOpenFileName = strFileName
        End If
    End Sub

    Private Sub butQuickSave_Click(sender As System.Object, e As System.EventArgs) Handles butQuickSave.Click
        If strOpenFileName <> "" Then
            SaveFile(strOpenFileName)
        Else
            Dim fd As SaveFileDialog = New SaveFileDialog()
            Dim strFileName As String

            fd.Title = "Save File Dialog"
            If strOpenFileName = "" Then
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
            Else
                fd.InitialDirectory = Path.GetDirectoryName(strOpenFileName)
            End If
            fd.Filter = "All files (*.*)|*.*|AIML files (*.aiml)|*.aiml"
            fd.FilterIndex = 2
            fd.RestoreDirectory = True

            If fd.ShowDialog() = DialogResult.OK Then
                strFileName = fd.FileName
                SaveFile(strFileName)

                strOpenFileName = strFileName
            End If
        End If
    End Sub

    Private Sub butClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butClose.Click
        Dim msgBoxResult = MsgBox("Close the file? (any unsaved work will be lost)", MsgBoxStyle.OkCancel, "Confirm")
        If msgBoxResult = DialogResult.OK Then
            pnlCategories.Controls.Clear()
            arrCategories.Clear()
            Me.Text = "AIML Editor"
        End If

    End Sub

    Private Sub txt_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtFocused = sender
    End Sub

    Sub LoadFile(ByVal strFilename As String)
        pnlCategories.Controls.Clear()
        arrCategories.Clear()
        Dim xDoc As XmlDocument = New XmlDocument()
        xDoc.Load(strFilename)

        Dim strPattern As String
        Dim strTemplate As String
        Dim strThat As String
        Dim catList = xDoc.GetElementsByTagName("category")
        For Each node As XmlElement In catList
            Try
                strTemplate = node.GetElementsByTagName("template").Item(0).InnerXml
            Catch
                strTemplate = ""
            End Try
            Try
                strThat = node.GetElementsByTagName("that").Item(0).InnerXml
            Catch
                strThat = ""
            End Try
            Try
                strPattern = node.GetElementsByTagName("pattern").Item(0).InnerXml
            Catch
                strPattern = ""
            End Try

            AddCategory(strTemplate, strThat, strPattern)
        Next
        Console.ReadLine()
        Me.Text = "AIML Editor - " + Path.GetFileNameWithoutExtension(strFilename)
    End Sub

    Sub SaveFile(ByVal strFilename As String)
        Dim strPattern As String
        Dim strThat As String
        Dim strTemplate As String

        Dim xws As XmlWriterSettings = New XmlWriterSettings()
        xws.Indent = True
        xws.NewLineOnAttributes = True
        Dim xw As XmlWriter = XmlWriter.Create(strFilename, xws)
        xw.WriteStartDocument()
        xw.WriteStartElement("aiml")

        For Each category In arrCategories
            strPattern = category.txtPattern.Text
            strThat = category.txtThat.Text
            strTemplate = category.txtTemplate.Text

            Console.WriteLine(strPattern + ":" + strThat + ":" + strTemplate)

            xw.WriteStartElement("category")

            xw.WriteStartElement("pattern")
            xw.WriteRaw(strPattern)
            xw.WriteEndElement()
            If strThat <> "" Then
                xw.WriteStartElement("that")
                xw.WriteRaw(strThat)
                xw.WriteEndElement()
            End If
            xw.WriteStartElement("template")
            xw.WriteRaw(strTemplate)
            xw.WriteEndElement()

            xw.WriteEndElement()

        Next
        xw.WriteEndElement()
        xw.WriteEndDocument()
        xw.Flush()
        xw.Close()
    End Sub

    Sub AddCategory(ByVal template As String, ByVal that As String, ByVal pattern As String)
        arrCategories.Add(New usrCategory())
        Dim itmNew = arrCategories.Item(arrCategories.Count - 1)
        With itmNew
            .Anchor = AnchorStyles.Top + AnchorStyles.Left
            .Location = New Point(0, ((arrCategories.Count - 1) * 122) - pnlCategories.VerticalScroll.Value)
            .txtTemplate.Text = template
            .txtThat.Text = that
            .txtPattern.Text = pattern
        End With
        AddHandler itmNew.txtTemplate.GotFocus, AddressOf txt_GotFocus
        AddHandler itmNew.txtThat.GotFocus, AddressOf txt_GotFocus
        AddHandler itmNew.txtPattern.GotFocus, AddressOf txt_GotFocus
        AddHandler itmNew.btnRemove.Click, AddressOf RemoveCategory

        intCategoriesCount += 1
        pnlCategories.Controls.Add(itmNew)
    End Sub

    Sub RemoveCategory(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim targetBtn As Button = sender
        Dim targetItem As usrCategory = targetBtn.Parent
        pnlCategories.Controls.Remove(targetItem)
        arrCategories.Remove(targetItem)
    End Sub
End Class
