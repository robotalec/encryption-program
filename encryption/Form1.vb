Public Class Form1
    Dim strOGalphabeht() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
    Dim strMianCypher() As Char = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}

    Dim seedInta As Integer


    Function EncryptDecrypt(ByVal text1 As String, ByVal key As String, ByVal isEncrypt As Boolean) As String
        Dim char1 As String 'first character to use
        Dim char2 As String ' holds the encyrpted or decrypted text
        Dim cKey As Byte 'holds onto each key number for the program to use
        Dim strLength As Integer 'length of string to use
        Dim Result As String = "" 'end result
        Dim j As Integer = -1 ' J keeps track of where we are in the string so can be assembled in the right order

        If text1 = "" And Not IsNumeric(key) Then
            text1 = 24
        End If
        If text1 <> "" And IsNumeric(key) Then 'controls if the program should run
                strLength = text1.Length
                For i As Integer = 0 To strLength - 1
                    char1 = text1.Substring(i, 1)
                    If j <key.Length - 1 Then
                        j= j + 1
                    Else
                        j= 0
                    End If
                    Console.WriteLine(char1)
                    Console.WriteLine(char2)
                    Console.WriteLine(cKey)

                    cKey = Val(key.Substring(j, 1)) 'Takes a number from the key then uses it to determin how far to move on the ASCII board
                    If isEncrypt Then
                        char2 = Chr(Asc(char1) + cKey)
                        Console.Write(char2)

                    Else
                        char2 = Chr(Asc(char1) - cKey)
                        Console.Write(char2)

                    End If
                    Console.Write(char1)
                    Console.Write(char2)

                    Result &= char2
                Next

        End If
            Console.Write(char1)
            Return Result
        errorlbl1.Visible = False
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles enBtn.Click
        Dim stHolder As String
        stHolder = txtText.Text
        Dim inHolder As Int64 = Convert.ToInt64(txtKey.Text)
        If inHolder > 888888888888 Then
            txtKey.Text = "888888888888"
            errorlbl1.Visible = True
        Else
            errorlbl1.Visible = False
        End If
        txtResult.Text = EncryptDecrypt(txtText.Text, txtKey.Text, True)
        If seedBar.Value > 1 Then
            For l = 1 To seedBar.Value - 1
                txtText.Text = txtResult.Text
                txtResult.Text = EncryptDecrypt(txtText.Text, txtKey.Text, True)
            Next
            'ElseIf seedBar.Value <= 1 Then
            '    txtResult.Text = EncryptDecrypt(txtText.Text, txtKey.Text, True)

        End If
        txtText.Text = stHolder

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles dec.Click
        Dim stHolder As String
        stHolder = txtText.Text
        Dim inHolder As Int64 = Convert.ToInt64(txtKey.Text)
        If inHolder > 888888888888 Then
            txtKey.Text = "888888888888"
            errorlbl1.Visible = True
        Else
            errorlbl1.Visible = False

        End If
        txtResult.Text = EncryptDecrypt(txtText.Text, txtKey.Text, False)
        If seedBar.Value > 1 Then
            For l = 1 To seedBar.Value - 1
                txtText.Text = txtResult.Text

                txtResult.Text = EncryptDecrypt(txtText.Text, txtKey.Text, False)
            Next
        End If

        txtText.Text = stHolder
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub opFile_Click(sender As Object, e As EventArgs) Handles opFile.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = "nothing"

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            filel.Text = strFileName
        End If

        Dim fileReader As System.IO.StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(strFileName)
        Dim stringReader As String
        stringReader = fileReader.ReadLine()
        txtText.Text = stringReader

        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText(strFileName)
        'inText.Text = fileReader

    End Sub


    Private Sub seedBar_Scroll(sender As Object, e As EventArgs) Handles seedBar.Scroll

        If seedBar.Value > 1 Then

        End If


        'seedInta = seedBar.Value
        Console.WriteLine(seedBar.Value)

        'test.Text = seedInta

        'Dim seedintb As Integer


        'Console.WriteLine(temSB.Length)
        'If seedInta > seedintb Then

        'Dim temSA As Char = strMianCypher(0)
        'Dim temSB(strMianCypher.Length - 2) As Char
        'For i = 0 To seedInta


        'For iii As Integer = 1 To strMianCypher.Length - 1
        'temSB(iii - 1) = strMianCypher(iii)
        'strMianCypher(iii - 1) = temSB(iii - 1)

        'Next iii
        'strMianCypher(strMianCypher.Length - 1) = temSA
        'Next i
        ' ElseIf seedInta < seedintb Then
        'Dim temSA As Char = strMianCypher(0)
        'Dim temSB(strMianCypher.Length - 2) As Char
        ' For i = 0 To seedInta
        '
        '
        ' For iii As Integer = 1 To strMianCypher.Length - 1
        'temSB(iii + 1) = strMianCypher(iii)
        'strMianCypher(iii + 1) = temSB(iii + 1)

        'Next iii
        'strMianCypher(strMianCypher.Length - 1) = temSA
        ' Next i
        '
        ' End If

        'seedintb = seedInta

        ' Console.WriteLine(strMianCypher(0))

        'If seedInta = 0 Then
        '    strMianCypher = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        'ElseIf seedInta = 1 Then
        '    strMianCypher = {"B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A"}
        'ElseIf seedInta = 2 Then
        '    strMianCypher = {"C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B"}
        'ElseIf seedInta = 3 Then
        '    strMianCypher = {"D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C"}
        'ElseIf seedInta = 4 Then
        '    strMianCypher = {"E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D"}
        'ElseIf seedInta = 5 Then
        '    strMianCypher = {"F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E"}
        'ElseIf seedInta = 6 Then
        '    strMianCypher = {"G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F"}
        'ElseIf seedInta = 7 Then
        '    strMianCypher = {"H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G"}
        'ElseIf seedInta = 8 Then
        '    strMianCypher = {"I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H"}
        'ElseIf seedInta = 9 Then
        '    strMianCypher = {"J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I"}
        'ElseIf seedInta = 10 Then
        '    strMianCypher = {"K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"}
        'ElseIf seedInta = 11 Then
        '    strMianCypher = {"L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K"}
        'ElseIf seedInta = 12 Then
        '    strMianCypher = {"M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"}
        'ElseIf seedInta = 13 Then
        '    strMianCypher = {"N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M"}
        'ElseIf seedInta = 14 Then
        '    strMianCypher = {"O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N"}
        'ElseIf seedInta = 15 Then
        '    strMianCypher = {"P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O"}
        'ElseIf seedInta = 16 Then
        '    strMianCypher = {"Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P"}
        'ElseIf seedInta = 17 Then
        '    strMianCypher = {"R", "S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q"}
        'ElseIf seedInta = 18 Then
        '    strMianCypher = {"S", "T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R"}
        'ElseIf seedInta = 19 Then
        '    strMianCypher = {"T", "U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S"}
        'ElseIf seedInta = 20 Then
        '    strMianCypher = {"U", "V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T"}
        'ElseIf seedInta = 21 Then
        '    strMianCypher = {"V", "W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U"}
        'ElseIf seedInta = 22 Then
        '    strMianCypher = {"W", "X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V"}
        'ElseIf seedinta = 23 Then
        '    strMianCypher = {"X", "Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W"}
        'ElseIf seedInta = 24 Then
        '    strMianCypher = {"Y", "Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X"}
        'ElseIf seedInta = 25 Then
        '    strMianCypher = {"Z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y"}
        'End If
        'Console.Write(strMianCypher)
    End Sub

    Private Sub flipBtn_Click(sender As Object, e As EventArgs) Handles flipBtn.Click
        txtText.Text = txtResult.Text

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub outBtn_Click(sender As Object, e As EventArgs) Handles outBtn.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String = "nothing"

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            filel2.Text = strFileName
        End If

        Dim fileReader As System.IO.StreamWriter
        fileReader = My.Computer.FileSystem.OpenTextFileWriter(strFileName, True)
        fileReader.WriteLine(txtResult.Text)
        fileReader.Close()
    End Sub

    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Application.Exit()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
