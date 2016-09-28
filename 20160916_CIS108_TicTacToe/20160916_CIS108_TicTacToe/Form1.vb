Public Class frmTicTacToe

    ' Keith Dodge
    ' declare global variable(s)
    Dim player As String = "X"

    Dim A1 As String = ""
    Dim B1 As String = ""
    Dim C1 As String = ""
    Dim A2 As String = ""
    Dim B2 As String = ""
    Dim C2 As String = ""
    Dim A3 As String = ""
    Dim B3 As String = ""
    Dim C3 As String = ""

    Sub GetBoardLayout()

        ' Keith Dodge
        ' get input values
        A1 = btnA1.Text
        B1 = btnB1.Text
        C1 = btnC1.Text
        A2 = btnA2.Text
        B2 = btnB2.Text
        C2 = btnC2.Text
        A3 = btnA3.Text
        B3 = btnB3.Text
        C3 = btnC3.Text

    End Sub

    Private Sub btnA1_Click(sender As Object, e As EventArgs) Handles btnA1.Click

        ' Keith Dodge
        ' Set next player button value
        btnA1.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnA1.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If A1 <> "" Then
            If A1 = B1 And B1 = C1 Then ' across

                lblMessageBox.Text = "Player """ & A1 & """ Wins"

            ElseIf A1 = B2 And B2 = C3 Then ' diagonal

                lblMessageBox.Text = "Player """ & A1 & """ Wins"

            ElseIf A1 = A2 And A2 = A3 Then ' up/down

                lblMessageBox.Text = "Player """ & A1 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnB1_Click(sender As Object, e As EventArgs) Handles btnB1.Click

        ' Keith Dodge
        ' Set next player button value
        btnB1.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnB1.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If B1 <> "" Then
            If B1 = A1 And A1 = C1 Then ' across

                lblMessageBox.Text = "Player """ & B1 & """ Wins"

            ElseIf B1 = B2 And B2 = B3 Then ' up/down

                lblMessageBox.Text = "Player """ & B1 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnC1_Click(sender As Object, e As EventArgs) Handles btnC1.Click

        ' Keith Dodge
        ' Set next player button value
        btnC1.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnC1.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If C1 <> "" Then
            If C1 = A1 And A1 = B1 Then ' across

                lblMessageBox.Text = "Player """ & C1 & """ Wins"

            ElseIf C1 = B2 And B2 = A3 Then ' diagonal

                lblMessageBox.Text = "Player """ & C1 & """ Wins"

            ElseIf C1 = C2 And C2 = C3 Then ' up/down

                lblMessageBox.Text = "Player """ & C1 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnA2_Click(sender As Object, e As EventArgs) Handles btnA2.Click

        ' Keith Dodge
        ' Set next player button value
        btnA2.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnA2.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If A2 <> "" Then
            If A2 = B2 And B2 = C2 Then ' across

                lblMessageBox.Text = "Player """ & A2 & """ Wins"

            ElseIf A2 = A1 And A1 = A3 Then ' up/down

                lblMessageBox.Text = "Player """ & A2 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnB2_Click(sender As Object, e As EventArgs) Handles btnB2.Click

        ' Keith Dodge
        ' Set next player button value
        btnB2.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnB2.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If B2 <> "" Then
            If B2 = A2 And A2 = C2 Then ' across

                lblMessageBox.Text = "Player """ & B2 & """ Wins"

            ElseIf B2 = A1 And A1 = C3 Then ' diagonal

                lblMessageBox.Text = "Player """ & B2 & """ Wins"

            ElseIf B2 = C1 And C1 = A3 Then ' diagonal

                lblMessageBox.Text = "Player """ & B2 & """ Wins"

            ElseIf B2 = B1 And B1 = B3 Then ' up/down

                lblMessageBox.Text = "Player """ & B2 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnC2_Click(sender As Object, e As EventArgs) Handles btnC2.Click

        ' Keith Dodge
        ' Set next player button value
        btnC2.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnC2.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If C2 <> "" Then
            If C2 = A2 And A2 = B2 Then ' across

                lblMessageBox.Text = "Player """ & C2 & """ Wins"

            ElseIf C2 = C1 And C1 = C3 Then ' up/down

                lblMessageBox.Text = "Player """ & C2 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnA3_Click(sender As Object, e As EventArgs) Handles btnA3.Click

        ' Keith Dodge
        ' Set next player button value
        btnA3.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnA3.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If A3 <> "" Then
            If A3 = B3 And B3 = C3 Then ' across

                lblMessageBox.Text = "Player """ & A3 & """ Wins"

            ElseIf A3 = C1 And C1 = B2 Then ' diagonal

                lblMessageBox.Text = "Player """ & A3 & """ Wins"

            ElseIf A3 = A1 And A1 = A2 Then ' up/down

                lblMessageBox.Text = "Player """ & A3 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnB3_Click(sender As Object, e As EventArgs) Handles btnB3.Click

        ' Keith Dodge
        ' Set next player button value
        btnB3.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnB3.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If B3 <> "" Then
            If B3 = A3 And A3 = C3 Then ' across

                lblMessageBox.Text = "Player """ & B3 & """ Wins"

            ElseIf B3 = B1 And B1 = B2 Then ' up/down

                lblMessageBox.Text = "Player """ & B3 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnC3_Click(sender As Object, e As EventArgs) Handles btnC3.Click

        ' Keith Dodge
        ' Set next player button value
        btnC3.Text = player

        If player = "X" Then

            player = "O"
        Else
            player = "X"
        End If

        ' disable button after initial click
        btnC3.Enabled = False

        ' get input values
        Call GetBoardLayout()

        ' Check for a winner
        If C3 <> "" Then
            If C3 = A3 And A3 = B3 Then ' across

                lblMessageBox.Text = "Player """ & C3 & """ Wins"

            ElseIf C3 = A1 And A1 = B2 Then ' diagonal

                lblMessageBox.Text = "Player """ & C3 & """ Wins"

            ElseIf C3 = C1 And C1 = C2 Then ' up/down

                lblMessageBox.Text = "Player """ & C3 & """ Wins"

            End If
        End If
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click

        ' Keith Dodge
        ' clear button text property
        btnA1.Text = ""
        btnA2.Text = ""
        btnA3.Text = ""
        btnB1.Text = ""
        btnB2.Text = ""
        btnB3.Text = ""
        btnC1.Text = ""
        btnC2.Text = ""
        btnC3.Text = ""

        ' disable button after initial click
        btnA1.Enabled = True
        btnA2.Enabled = True
        btnA3.Enabled = True
        btnB1.Enabled = True
        btnB2.Enabled = True
        btnB3.Enabled = True
        btnC1.Enabled = True
        btnC2.Enabled = True
        btnC3.Enabled = True

        ' clear message box
        lblMessageBox.Text = ""

        ' initialize player one
        player = "X"

    End Sub

    Private Sub frmTicTacToe_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        ' Keith Dodge
        'declare variable
        Dim blackPen As New Pen(Color.Black, 2)

        ' draw grid lines
        e.Graphics.DrawLine(blackPen, 112, 120, 172, 120) ' upper horizontal 
        e.Graphics.DrawLine(blackPen, 112, 140, 172, 140) ' lower horizontal 
        e.Graphics.DrawLine(blackPen, 132, 100, 132, 160) ' left vertical 
        e.Graphics.DrawLine(blackPen, 152, 100, 152, 160) ' right vertical 

    End Sub
End Class
