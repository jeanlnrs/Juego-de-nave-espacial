Public Class Proyecto2
    Dim vBxy(9, 2) As Integer
    Dim vAxy(9, 2) As Integer
    Dim btmp As PictureBox
    Dim atmp As PictureBox
    Dim rnd As New Random()
    Dim VectorBasura(9) As PictureBox
    Dim VectorAsteroide(9) As PictureBox
    Dim vSama As Integer = 0
    Dim corazon As PictureBox
    Public Property X As Integer = 0
    Public Property Y As Integer = 0

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        TimerContenedor.Start()
        PicFondo.Visible = False
        btnIniciar.Visible = False
        picBase.Visible = True
        picNave.Visible = True
        TimerNave.Enabled = True
        TimerBasura.Enabled = True
        TimerAsteroide.Enabled = False
        lblMensaje.Visible = False
        Dim i As Integer

        For i = 0 To 9
            btmp = New PictureBox()
            btmp.Size = New Size(30, 30)
            btmp.Image = My.Resources.basura ' Imagen de Resources para la basura
            btmp.BackColor = Color.Transparent
            btmp.SizeMode = PictureBoxSizeMode.Zoom

            Dim a As Integer = rnd.Next(0, 35)
            Dim b As Integer = rnd.Next(0, 700)
            Dim c As Integer = rnd.Next(750, 900)
            Dim d As Integer = rnd.Next(500, 650)
            Dim x As Integer = rnd.Next(0, 4)
            If x = 0 Then
                btmp.Location = New Point(a, b)
            ElseIf x = 1 Then
                btmp.Location = New Point(b, a)
            ElseIf x = 2 Then
                btmp.Location = New Point(c, b)
            ElseIf x = 3 Then
                btmp.Location = New Point(b, d)
            End If
            VectorBasura(i) = btmp
            VectorBasura(i).Tag = 0
            Controls.Add(btmp)
            vBxy(i, 0) = rnd.Next(-5, 5)
            vBxy(i, 1) = rnd.Next(-5, 5)
        Next
        For i = 0 To 9
            atmp = New PictureBox()
            atmp.Size = New Size(100, 100)
            atmp.Image = My.Resources.asteoride ' Imagen de Resources para los asteroides
            atmp.BackColor = Color.Transparent
            atmp.SizeMode = PictureBoxSizeMode.Zoom
            Dim a As Integer = rnd.Next(0, 35)
            Dim b As Integer = rnd.Next(0, 700)
            Dim c As Integer = rnd.Next(750, 900)
            Dim d As Integer = rnd.Next(500, 650)
            Dim x As Integer = rnd.Next(0, 4)
            If x = 0 Then
                atmp.Location = New Point(a, b)
            ElseIf x = 1 Then
                atmp.Location = New Point(b, a)
            ElseIf x = 2 Then
                atmp.Location = New Point(c, b)
            ElseIf x = 3 Then
                atmp.Location = New Point(b, d)
            End If
            VectorAsteroide(i) = atmp

            Controls.Add(atmp)
            vAxy(i, 0) = rnd.Next(-5, 5)
            vAxy(i, 1) = rnd.Next(-5, 5)
        Next

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.Up
                picNave.Image = My.Resources.coheteUp
                Y = -10
                If Y < -10 Then
                    Y = Y + 10
                End If
            Case Keys.Down
                picNave.Image = My.Resources.coheteDown
                Y = 10
                If Y > +10 Then
                    Y = Y + 10
                End If
            Case Keys.Left
                picNave.Image = My.Resources.coheteLeft
                X = -10
                If X < -10 Then
                    X = X + 10
                End If
            Case Keys.Right
                picNave.Image = My.Resources.coheteRight
                X = 10
                If X > +10 Then
                    X = X + 10
                End If
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Dim t As Integer
    Private Sub TimerContenedor_Tick(sender As Object, e As EventArgs) Handles TimerContenedor.Tick
        t = t + 5
        If picBase.Location.X <= 0 Or picBase.Location.X + picBase.Width >= Me.Width - 20 Then
            t = 26


        End If

        picBase.Left = t
    End Sub

    Private Sub TimerNave_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles TimerNave.Tick
        If lblVidaValor.Text = 0 And lblNivelValor.Text < 5 Then

            lblMensaje.Text = "Has Perdido!"
            lblMensaje.Visible = True
            btnIniciar.Text = "Jugar Denuevo"
            btnIniciar.Visible = True
            limpiarT()
        End If
        If lblNivelValor.Text = 3 Then
            lblMensaje.Text = "Has Ganado!"
            lblMensaje.Visible = True
            btnIniciar.Text = "Jugar Denuevo"
            btnIniciar.Visible = True
            limpiarT()
        End If
        lblCargaValor.Text = vSama
        picNave.Location = New Point(picNave.Location.X + X, picNave.Location.Y + Y)
        If picNave.Location.X <= 0 Or picNave.Location.X + picNave.Width >= Me.Width - 20 Then
            X = -X
            Reversa()
        End If
        If picNave.Location.Y <= 0 Or picNave.Location.Y + picNave.Height >= Me.Height - 40 Then
            Y = -Y
            Reversa()
        End If
        For i = 0 To 9
            Try
                If picNave.Bounds.IntersectsWith(VectorBasura(i).Bounds) Then
                    If VectorBasura(i).Tag = 0 And vSama < 3 Then
                        VectorBasura(i).Tag = 1
                        VectorBasura(i).Visible = False
                        vSama += Val(VectorBasura(i).Tag)

                        My.Computer.Audio.Play(My.Resources.win, AudioPlayMode.Background)

                    End If

                End If
                If picNave.Bounds.IntersectsWith(VectorAsteroide(i).Bounds) Then
                    picNave.Visible = False
                    lblVidaValor.Text -= 1



                    picNave.Location = New Point(473, 302)
                    X = 0
                    Y = 0
                    picNave.Image = My.Resources.coheteUp
                    picNave.Visible = True
                End If
            Catch ex As Exception
            End Try
        Next
        If picNave.Bounds.IntersectsWith(picBase.Bounds) Then
            If vSama >= 1 And vSama <= 3 Then
                For i = 0 To 9
                    If VectorBasura(i).Tag = 1 Then
                        VectorBasura(i).Tag = 0
                        lblPuntoValor.Text += 10
                    End If
                Next
                If lblPuntoValor.Text >= 100 Then
                    lblNivelValor.Text += 1
                    lblPuntoValor.Text = 0
                    TimerBasura.Interval = TimerBasura.Interval - 100
                    TimerAsteroide.Interval = TimerAsteroide.Interval - 100
                End If
                vSama = 0
            End If
        End If
    End Sub

    Sub Basura()
        Dim i, j As Integer
        For i = 0 To 9
            If VectorBasura(i).Visible = True Then
                VectorBasura(i).Location = New Point(VectorBasura(i).Location.X + vBxy(i, 0), VectorBasura(i).Location.Y + vBxy(i, 1))
                If VectorBasura(i).Location.X <= 0 Or VectorBasura(i).Location.X + VectorBasura(i).Width >= Me.Width - 20 Then
                    vBxy(i, 0) = -vBxy(i, 0)
                End If
                If VectorBasura(i).Location.Y <= 0 Or VectorBasura(i).Location.Y + VectorBasura(i).Height >= Me.Height - 40 Then
                    vBxy(i, 1) = -vBxy(i, 1)
                End If
                For j = 0 To 9
                    If VectorBasura(i).Bounds.IntersectsWith(VectorAsteroide(j).Bounds) Then
                        If VectorBasura(i).Location.X <= VectorAsteroide(j).Location.X Or VectorBasura(i).Location.X + VectorBasura(i).Width >= VectorAsteroide(j).Location.X Then
                            vBxy(i, 0) = -vBxy(i, 0)
                        End If
                        If VectorBasura(i).Location.Y <= VectorAsteroide(j).Location.Y Or VectorBasura(i).Location.Y + VectorBasura(i).Height >= VectorAsteroide(j).Location.Y Then
                            vBxy(i, 1) = -vBxy(i, 1)
                        End If
                    End If
                Next
            Else
                If VectorBasura(i).Tag = 0 Then
                    VectorBasura(i).Location = New Point(rnd.Next(20, Me.Width - 20), rnd.Next(20, Me.Height - 20))
                    VectorBasura(i).Visible = True
                End If
            End If
            If VectorBasura(i).Bounds.IntersectsWith(picBase.Bounds) Then
                If VectorBasura(i).Location.X <= picBase.Location.X Or VectorBasura(i).Location.X + VectorBasura(i).Size.Width >= picBase.Location.X Then
                    vBxy(i, 0) = -vBxy(i, 0)
                End If
                If VectorBasura(i).Location.Y <= picBase.Location.Y Or VectorBasura(i).Location.Y + VectorBasura(i).Height >= picBase.Location.Y Then
                    vBxy(i, 1) = -vBxy(i, 1)
                End If
            End If

        Next
    End Sub

    Sub Reversa()
        If picNave.Location.X <= 0 Then
            picNave.Image = My.Resources.coheteRight
        End If
        If picNave.Location.X + picNave.Width >= Me.Width - 20 Then
            picNave.Image = My.Resources.coheteLeft
        End If
        If picNave.Location.Y <= 0 Then
            picNave.Image = My.Resources.coheteDown
        End If
        If picNave.Location.Y + picNave.Height >= Me.Height - 40 Then
            picNave.Image = My.Resources.coheteUp
        End If
    End Sub

    Private Sub TimerBasura_Tick(sender As Object, e As EventArgs) Handles TimerBasura.Tick
        Basura()
    End Sub

    Private Sub TimerAsteroide_Tick(sender As Object, e As EventArgs) Handles TimerAsteroide.Tick
        Asteroide()
    End Sub

    Private Sub Asteroide()
        Dim i As Integer
        For i = 0 To 9
            VectorAsteroide(i).Location = New Point(VectorAsteroide(i).Location.X + vAxy(i, 0), VectorAsteroide(i).Location.Y + vAxy(i, 1))
            If VectorAsteroide(i).Location.X <= 0 Or VectorAsteroide(i).Location.X + VectorAsteroide(i).Width >= Me.Width - 20 Then
                vAxy(i, 0) = -vAxy(i, 0)
            End If
            If VectorAsteroide(i).Location.Y <= 0 Or VectorAsteroide(i).Location.Y + VectorAsteroide(i).Height >= Me.Height - 40 Then
                vAxy(i, 1) = -vAxy(i, 1)
            End If

            If VectorAsteroide(i).Bounds.IntersectsWith(picBase.Bounds) Then
                If VectorAsteroide(i).Location.X <= picBase.Location.X Or VectorAsteroide(i).Location.X + VectorAsteroide(i).Width >= picBase.Location.X Then
                    vAxy(i, 0) = -vAxy(i, 0)
                End If
                If VectorAsteroide(i).Location.Y <= picBase.Location.Y Or VectorAsteroide(i).Location.Y + VectorAsteroide(i).Height >= picBase.Location.Y Then
                    vAxy(i, 1) = -vAxy(i, 1)
                End If
            End If
        Next
    End Sub

    Sub limpiarT()
        lblCargaValor.Text = 0
        lblNivelValor.Text = 1
        lblVidaValor.Text = 5
        lblPuntoValor.Text = 0
        TimerBasura.Enabled = False
        TimerNave.Stop()
        TimerNave.Enabled = False
        TimerAsteroide.Enabled = False
        picNave.Location = New Point(473, 302)
        picNave.Image = My.Resources.coheteUp
        picNave.Visible = False
        picBase.Visible = False
        vSama = 0
        X = 0
        Y = 0
        Dim i As Integer
        For i = 0 To 9
            VectorBasura(i).Visible = False
            VectorAsteroide(i).Visible = False
        Next
        VectorBasura(9) = New PictureBox
        VectorAsteroide(9) = New PictureBox




    End Sub
End Class
