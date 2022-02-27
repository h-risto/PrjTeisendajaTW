Public Class TeisendajaAken

    Dim teisendused() = {"km -> mi", "mi -> km", "C -> F", "F -> C"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblSisendYhik.Text = ""
        lblVastusYhik.Text = ""
        txtVastus.ReadOnly = True
        cmbTeisendus.DropDownStyle = ComboBoxStyle.DropDownList

        cmbTeisendus.Items.AddRange(teisendused)
        cmbTeisendus.SelectedIndex = 0
    End Sub

    Private Sub cmbTeisendus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTeisendus.SelectedIndexChanged
        Dim teisenduseIndeks = cmbTeisendus.SelectedIndex
        SetLabels(teisendused(teisenduseIndeks))
        If txtSisend.Text <> "" Then
            Arvuta(teisenduseIndeks, txtSisend.Text)
        End If
    End Sub

    Private Sub txtSisend_TextChanged(sender As Object, e As EventArgs) Handles txtSisend.TextChanged
        If txtSisend.Text <> "" Then
            Arvuta(cmbTeisendus.SelectedIndex, txtSisend.Text)
        Else
            txtVastus.Text = ""
        End If
    End Sub

    Private Sub SetLabels(ByVal teisendus As String)
        Dim tykeldatud() = teisendus.Split(" ")
        lblSisendYhik.Text = tykeldatud(0)
        lblVastusYhik.Text = tykeldatud(2)
    End Sub
    Private Sub Arvuta(ByVal teisenduseTyyp As Int32, ByVal sisend As String)
        Dim teisendaja As PrjTeisendajad.ITeisendaja
        teisendaja = New PrjTeisendajad.CTeisendaja
        Dim vastus
        Try
            Select Case teisenduseTyyp
                Case 0
                    vastus = Math.Round(teisendaja.KilometersToMiles(sisend), 2)
                Case 1
                    vastus = Math.Round(teisendaja.MilesToKilometers(sisend), 2)
                Case 2
                    vastus = Math.Round(teisendaja.CelciusToFahrenheit(sisend), 2)
                Case 3
                    vastus = Math.Round(teisendaja.FahrenheitToCelsius(sisend), 2)
                Case Else
                    vastus = "Tundmatu teisendus!"
            End Select
        Catch ex As NotImplementedException
            vastus = "Funktsioon pole veel valmis"
        Catch ex As Exception
            vastus = "Vigane sisend!"
        End Try

        txtVastus.Text = vastus
    End Sub


End Class
