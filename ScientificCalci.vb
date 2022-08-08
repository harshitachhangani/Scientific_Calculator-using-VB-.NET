Public Class Form1
 Dim Celsius, Fehrenheit, Kelvin As Double
 Dim iOperation As String
 Dim f As Double
 Dim s As Double
 Dim a As Double
 Dim op As String
 Dim n As Int32
 Dim Opera As Double
 Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 Me.Width = 227
 txtDisplay.Width = 192
 Me.Text = "Standard Calculator"
 cmbUnit.Text = "Choose One..."
 cmbUnit.Items.Add("Mile")
 cmbUnit.Items.Add("Kilometre ")
 cmbUnit.Items.Add("Metre ")
 cmbUnit.Items.Add("Centimetre ")
 ComboBox1.Text = "Choose One..."
 ComboBox1.Items.Add("Kilometre")
 ComboBox1.Items.Add("Metre ")
 ComboBox1.Items.Add("Centimetre ")
 ComboBox1.Items.Add("Mile ")
 GroupBox1.Visible = False
 GroupBox3.Visible = False
 End Sub
 Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles
ScientificToolStripMenuItem.Click
 Me.Width = 451
 txtDisplay.Width = 396
 Me.Text = "Scientific Calculator"
 End Sub
 Private Sub TemperatureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles
TemperatureToolStripMenuItem.Click
 Me.Width = 768
 txtDisplay.Width = 396
 Me.Text = "Temperature Conversion"
 GroupBox1.Location = New Point(427, 27)
 GroupBox1.Width = 297
 GroupBox1.Height = 319
 GroupBox1.Visible = True
 GroupBox3.Visible = False
 End Sub
 Private Sub UnitConversionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles
UnitConversionToolStripMenuItem.Click
 Me.Width = 768
 txtDisplay.Width = 396
 Me.Text = "Unit Conversion"
 GroupBox3.Location = New Point(427, 27)
 GroupBox3.Width = 297
 GroupBox3.Height = 319
 GroupBox3.Visible = True
 GroupBox1.Visible = False
 End Sub
 Private Sub rbCelToFah_CheckedChanged(sender As Object, e As EventArgs) Handles
rbCelToFah.CheckedChanged
 iOperation = "C"
 End Sub
 Private Sub rbFahToCel_CheckedChanged(sender As Object, e As EventArgs) Handles
rbFahToCel.CheckedChanged
 iOperation = "F"
 End Sub
 Private Sub rbKelvin_CheckedChanged(sender As Object, e As EventArgs) Handles
rbKelvin.CheckedChanged
 iOperation = "K"
 End Sub
 Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
 Select Case (iOperation)
 Case "C"
 'Celsius to Fahrenheit
 Celsius = Double.Parse(TextBox1.Text)
 txtConvert.Text = ((((9 * Celsius) / 5) + 32).ToString())
 Case "F"
 'Fahrenheit to Celsius
 Fehrenheit = Double.Parse(TextBox1.Text)
 txtConvert.Text = ((((Fehrenheit - 32) / 5) + 9).ToString())
 Case "K"
 Kelvin = Double.Parse(TextBox1.Text)
 txtConvert.Text = (((((9 * Kelvin) / 5) + 32) + 273.15).ToString())
 End Select
 End Sub
 Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
 txtConvert.Clear()
 lblConvert.Text = ""
 rbCelToFah.Checked = False
 rbFahToCel.Checked = False
 rbKelvin.Checked = False
 End Sub
 Private Sub button_Click(sender As Object, e As EventArgs) Handles Button8.Click, Button7.Click,
Button6.Click, Button20.Click, Button16.Click, Button15.Click, Button14.Click, Button12.Click,
Button11.Click, Button10.Click
 Dim b As Button = sender
 If txtDisplay.Text = "0" Then
 txtDisplay.Text = b.Text
 Else
 txtDisplay.Text = txtDisplay.Text + b.Text
 End If
 End Sub
 Private Sub Arithmetic_Operator(sender As Object, e As EventArgs) Handles Button9.Click,
Button5.Click, Button17.Click, Button13.Click, Button40.Click, Button39.Click
 Dim ops As Button = sender
 f = txtDisplay.Text
 Label4.Text = txtDisplay.Text
 txtDisplay.Text = ""
 op = ops.Text
 Label4.Text = Label4.Text + " " + op
 End Sub
 Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
 txtDisplay.Text = "0"
 Label4.Text = ""
 End Sub
 Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
 txtDisplay.Text = "0"
 Label4.Text = ""
 End Sub
 Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
 s = txtDisplay.Text
 If op = "+" Then
 a = f + s
 txtDisplay.Text = a
 Label4.Text = ""
 ElseIf op = "-" Then
 a = f - s
 txtDisplay.Text = a
 Label4.Text = ""
 ElseIf op = "*" Then
 a = f * s
 txtDisplay.Text = a
 Label4.Text = ""
 ElseIf op = "/" Then
 a = f / s
 txtDisplay.Text = a
 Label4.Text = ""
 ElseIf op = "Mod" Then
 a = f Mod s
 txtDisplay.Text = a
 Label4.Text = ""
 ElseIf op = "Exp" Then
 a = f ^ s
 txtDisplay.Text = a
 Label4.Text = ""
 End If
 End Sub
 Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
 If txtDisplay.Text.Length > 0 Then
 txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1)
 End If
 End Sub
 Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
 If InStr(txtDisplay.Text, ".") = "0" Then
 txtDisplay.Text = txtDisplay.Text + "."
 End If
 End Sub
 Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
 If (txtDisplay.Text.Contains("-")) Then
 txtDisplay.Text = txtDisplay.Text.Remove(0, 1)
 Else
 txtDisplay.Text = "-" + txtDisplay.Text
 End If
 End Sub
 Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
 txtDisplay.Text = "3.141592653589976323"
 End Sub
 Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
 Dim log As Double
 log = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")")
 log = Math.Log10(log)
 txtDisplay.Text = System.Convert.ToString(log)
 End Sub
 Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
 Dim iSqrt As Double
 iSqrt = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("sqrt" + "(" + (txtDisplay.Text) + ")")
 iSqrt = Math.Sqrt(iSqrt)
 txtDisplay.Text = System.Convert.ToString(iSqrt)
 End Sub
 Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
 Dim iSinh As Double
 iSinh = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("sinh" + "(" + (txtDisplay.Text) + ")")
 iSinh = Math.Sinh(iSinh)
 txtDisplay.Text = System.Convert.ToString(iSinh)
 End Sub
 Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
 Dim iSin As Double
 iSin = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("sin" + "(" + (txtDisplay.Text) + ")")
 iSin = Math.Sin(iSin)
 txtDisplay.Text = System.Convert.ToString(iSin)
 End Sub
 Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
 Dim icosh As Double
 icosh = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("cosh" + "(" + (txtDisplay.Text) + ")")
 icosh = Math.Cosh(icosh)
 txtDisplay.Text = System.Convert.ToString(icosh)
 End Sub
 Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
 Dim icos As Double
 icos = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("cos" + "(" + (txtDisplay.Text) + ")")
 icos = Math.Cos(icos)
 txtDisplay.Text = System.Convert.ToString(icos)
 End Sub
 Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
 Dim iTanh As Double
 iTanh = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("tanh" + "(" + (txtDisplay.Text) + ")")
 iTanh = Math.Tanh(iTanh)
 txtDisplay.Text = System.Convert.ToString(iTanh)
 End Sub
 Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
 Dim iTan As Double
 iTan = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("tan" + "(" + (txtDisplay.Text) + ")")
 iTan = Math.Tan(iTan)
 txtDisplay.Text = System.Convert.ToString(iTan)
 End Sub
 Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
 If Int32.TryParse(txtDisplay.Text, n) Then
 txtDisplay.Text = Convert.ToString(n, 8)
 Else
 txtDisplay.Text = ""
 End If
 End Sub
 Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
 If Int32.TryParse(txtDisplay.Text, n) Then
 txtDisplay.Text = Convert.ToString(n, 16)
 Else
 txtDisplay.Text = ""
 End If
 End Sub
 Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
 If Int32.TryParse(txtDisplay.Text, n) Then
 txtDisplay.Text = Convert.ToString(n, 2)
 Else
 txtDisplay.Text = ""
 End If
 End Sub
 Private Sub txtDisplay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles
txtDisplay.KeyPress
 If Asc(e.KeyChar) <> 8 Then
 If Asc(e.KeyChar) <> 48 Or Asc(e.KeyChar) <> 57 Then
 e.Handled = True
 End If
 End If
 End Sub
 Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click

 If Int32.TryParse(txtDisplay.Text, n) Then
 txtDisplay.Text = Convert.ToString(n)
 Else
 txtDisplay.Text = ""
 End If
 End Sub
 Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
 Dim a As Double
 a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text)
 txtDisplay.Text = System.Convert.ToString(a)
 End Sub
 Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
 Dim a As Double
 a = Convert.ToDouble(txtDisplay.Text) * Convert.ToDouble(txtDisplay.Text) *
Convert.ToDouble(txtDisplay.Text)
 txtDisplay.Text = System.Convert.ToString(a)
 End Sub
 Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
 Dim a As Double
 a = Convert.ToDouble(1.0 / Convert.ToDouble(txtDisplay.Text))
 txtDisplay.Text = System.Convert.ToString(a)
 End Sub
 Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles
ExitToolStripMenuItem.Click
 Me.Close()
 End Sub
 Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
 'These are the Boolean for the Length in the first box'
 Dim Mile1 As Boolean
 Dim KM1 As Boolean
 Dim M1 As Boolean
 Dim CM1 As Boolean
 'These are the Boolean for the length in the second box'
 Dim Mile2 As Boolean
 Dim KM2 As Boolean
 Dim M2 As Boolean
 Dim CM2 As Boolean
 'These are the inserted numbers that will be converted'
 Dim Num1 As String
 Num1 = txtUnit.Text
 Dim Num2 As String
 Num2 = TextBox2.Text
 'What it is converting'
 If cmbUnit.Text = ("Mile") And ComboBox1.Text = ("Kilometre") Then
 Mile1 = True
 KM2 = True
 End If
 'The equation for the conversion'
 If Mile1 = True And KM2 = True Then
 TextBox2.Text = Num1 / 0.62137
 End If
 If cmbUnit.Text = ("Mile") And ComboBox1.Text = ("Metre") Then
 Mile1 = True
 M2 = True
 End If
 If Mile1 = True And M2 = True Then
 TextBox2.Text = Num1 / 0.0062137
 End If
 If cmbUnit.Text = ("Mile") And ComboBox1.Text = ("Centimetre") Then
 Mile1 = True
 CM2 = True
 End If
 If Mile1 = True And CM2 = True Then
 TextBox2.Text = Num1 / 0.0000062137
 End If
 If cmbUnit.Text = ("Kilometre") And ComboBox1.Text = ("Mile") Then
 KM1 = True
 Mile2 = True
 End If
 If KM1 = True And Mile2 = True Then
 TextBox2.Text = Num1 * 0.62137
 End If
 If cmbUnit.Text = ("Kilometre") And ComboBox1.Text = ("Metre") Then
 KM1 = True
 M2 = True
 End If
 If KM1 = True And M2 = True Then
 TextBox2.Text = Num1 / 0.001
 End If
 If cmbUnit.Text = ("Kilometre") And ComboBox1.Text = ("Centimetre") Then
 KM1 = True
 CM2 = True
 End If
 If KM1 = True And CM2 = True Then
 TextBox2.Text = Num1 / 0.000001
 End If
 If cmbUnit.Text = ("Metre") And ComboBox1.Text = ("Mile") Then
 M1 = True
 Mile2 = True
 End If
 If M1 = True And Mile2 = True Then
 TextBox2.Text = Num1 * 0.000621317
 End If
 If cmbUnit.Text = ("Metre") And ComboBox1.Text = ("Kilometre") Then
 M1 = True
 KM2 = True
 End If
 If M1 = True And KM2 = True Then
 TextBox2.Text = Num1 / 1000
 End If
 If cmbUnit.Text = ("Metre") And ComboBox1.Text = ("Centimetre") Then
 M1 = True
 CM2 = True
 End If
 If M1 = True And CM2 = True Then
 TextBox2.Text = Num1 / 0.01
 End If
 If cmbUnit.Text = ("Centimetre") And ComboBox1.Text = ("Mile") Then
 CM1 = True
 Mile2 = True
 End If
 If CM1 = True And Mile2 = True Then
 TextBox2.Text = Num1 * 0.000000621317
 End If
 If cmbUnit.Text = ("Centimetre") And ComboBox1.Text = ("Kilometre") Then
 CM1 = True
 KM2 = True
 End If
 If CM1 = True And KM2 = True Then
 TextBox2.Text = Num1 * 0.00001
 End If
 If cmbUnit.Text = ("Centimetre") And ComboBox1.Text = ("Metre") Then
 CM1 = True
 M2 = True
 End If
 If CM1 = True And M2 = True Then
 TextBox2.Text = Num1 * 0.01
 End If
 'If converting into same unit then the valve will be the same'
 If cmbUnit.Text = ComboBox1.Text Then
 TextBox2.Text = Num1
 End If
 End Sub
 Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
 Dim log As Double
 log = Double.Parse(txtDisplay.Text)
 Label4.Text = System.Convert.ToString("log" + "(" + (txtDisplay.Text) + ")")
 log = Math.Log(log)
 txtDisplay.Text = System.Convert.ToString(log)
 End Sub
 Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
 Dim a As Double
 a = Convert.ToDouble(txtDisplay.Text) / Convert.ToDouble(100)
 txtDisplay.Text = System.Convert.ToString(a)
 End Sub
End Class