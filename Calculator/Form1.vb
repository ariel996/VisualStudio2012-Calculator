Public Class Form1

    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int32


    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button11.Click, Button10.Click
        Dim b As Button = sender
        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Label1.Text = "0"
        Label3.Text = ""
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text = "0"
        Label3.Text = ""
    End Sub

    Private Sub arithmetic_function(sender As Object, e As EventArgs) Handles Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button23.Click, Button26.Click
        Dim ops As Button = sender
        f = Label1.Text
        Label3.Text = Label1.Text
        Label1.Text = ""
        op = ops.Text
        Label3.Text = Label3.Text + " " + op
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        s = Label1.Text
        If op = "+" Then
            a = f + s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "-" Then
            a = f - s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "*" Then
            a = f * s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "/" Then
            a = f / s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "mod" Then
            a = f Mod s
            Label1.Text = a
            Label3.Text = ""
        ElseIf op = "exp" Then
            a = f ^ s
            Label1.Text = a
            Label3.Text = ""
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        a = Math.Sin(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        a = Math.Cos(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        a = Math.Tan(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        a = Math.Log(Label1.Text)
        Label1.Text = a
        Label3.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = 398
        Me.Width = 269

        Label1.Width = 229

        ComboBox1.Text = "Choose me ..."
        ComboBox1.Items.Add("Celsius to Fahrenheit")
        ComboBox1.Items.Add("Fahrenheit to Celsius")
        ComboBox1.Items.Add("Miles to Kilometres")
        ComboBox1.Items.Add("Kilometres to Miles")

    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim convt As Double
        If ComboBox1.Text = "Celsius to Fahrenheit" Then
            convt = (9 / 5 * TextBox2.Text) + 32
            Label2.Text = (convt) & " Fahrenheit"
        ElseIf ComboBox1.Text = "Fahrenheit to Celsius" Then
            convt = 5 / 9 * (TextBox2.Text - 32)
            Label2.Text = (convt) & " Celsius"
        ElseIf ComboBox1.Text = "Miles to Kilometres" Then
            convt = (TextBox2.Text * 1.609344)
            Label2.Text = (convt) & " Kilometres"
        ElseIf ComboBox1.Text = "Kilometres to Miles" Then
            convt = (TextBox2.Text / 1.609344)
            Label2.Text = (convt) & " Miles"
        ElseIf ComboBox1.Text = "Choose one..." Or TextBox2.Text = "" Then
            MsgBox("Select a unit of conversion", "Calculator Plus", vbInformation)
        End If
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Height = 398
        Me.Width = 393
        Button14.Width = 110
        Label1.Width = 363
    End Sub

    Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitConversionToolStripMenuItem.Click
        Me.Height = 398
        Me.Width = 701
        Button14.Width = 110
        Label1.Width = 363
    End Sub

    Private Sub StandardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StandardToolStripMenuItem.Click
        Me.Height = 398
        Me.Width = 269
        Button14.Width = 110
        Label1.Width = 229
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Label2.Text = ""
        TextBox2.Text = ""
    End Sub
End Class
