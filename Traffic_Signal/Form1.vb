Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pic_bx_Red1.Visible = True
        Pic_bx_Red2.Visible = True
        Pic_bx_Yellow3.Visible = True
        Pic_bx_Yellow4.Visible = True
        'Pic_bx_Green3.Visible = True
        'Pic_bx_Green4.Visible = True
        Dim a As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath
        a.AddEllipse(0, 0, Pic_bx_Red1.Width, Pic_bx_Red1.Height)
        Pic_bx_Red1.Region = New Region(a)
        Pic_bx_Yellow1.Region = New Region(a)
        Pic_bx_Green1.Region = New Region(a)
        Pic_bx_Red2.Region = New Region(a)
        Pic_bx_Red3.Region = New Region(a)
        Pic_bx_Red4.Region = New Region(a)
        Pic_bx_Yellow2.Region = New Region(a)
        Pic_bx_Yellow3.Region = New Region(a)
        Pic_bx_Yellow4.Region = New Region(a)
        Pic_bx_Green2.Region = New Region(a)
        Pic_bx_Green3.Region = New Region(a)
        Pic_bx_Green4.Region = New Region(a)

        'Hello wORLD

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If Pic_bx_Red1.Visible = True Then
                Pic_bx_Red1.Visible = False
                Pic_bx_Red2.Visible = False
                Pic_bx_Yellow1.Visible = True
                Pic_bx_Yellow2.Visible = True
            ElseIf Pic_bx_Yellow1.Visible = True Then
                Pic_bx_Yellow1.Visible = False
                Pic_bx_Yellow2.Visible = False
                Pic_bx_Green1.Visible = True
                Pic_bx_Green2.Visible = True
            ElseIf Pic_bx_Green1.Visible = True Then
                Pic_bx_Green1.Visible = False
                Pic_bx_Green2.Visible = False
                Pic_bx_Red2.Visible = True
                Pic_bx_Red1.Visible = True
            End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Pic_bx_Green3.Visible = True Then
            Pic_bx_Green3.Visible = False
            Pic_bx_Green4.Visible = False
            Pic_bx_Red4.Visible = True
            Pic_bx_Red3.Visible = True
        ElseIf Pic_bx_Yellow3.Visible = True Then
            Pic_bx_Yellow3.Visible = False
            Pic_bx_Yellow4.Visible = False
            Pic_bx_Green3.Visible = True
            Pic_bx_Green4.Visible = True
        ElseIf Pic_bx_Red3.Visible = True Then
            Pic_bx_Red3.Visible = False
            Pic_bx_Red4.Visible = False
            Pic_bx_Yellow3.Visible = True
            Pic_bx_Yellow4.Visible = True
        End If
    End Sub


End Class
