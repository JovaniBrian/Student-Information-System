Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class StudentInformationAndRecord
    Dim conn As New SqlConnection("Server=LENOVO-PC\SQLEXPRESS;Database=SIS;Integrated Security=true")
    Dim cmd As New SqlCommand
    Dim dt As New System.Data.DataTable

    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, conn)
        conn.Open()
        command.ExecuteNonQuery()
        conn.Close()
    End Sub
    Private Sub ExecuteQuery(command As SqlCommand, p2 As String)
        conn.Open()
        If command.ExecuteNonQuery = 1 Then
            MessageBox.Show(p2)
        Else
            MessageBox.Show("Query Not Executed")
            End
        End If
        conn.Close()
    End Sub
    Private Sub txtlrn__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtlrn.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtname__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtname.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtbirthplace__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtbirthplace.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttown__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttown.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtparent__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtparent.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtoccupation__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtoccupation.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) And Not Char.IsSymbol(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtgenave__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtgenave.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipinocgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipinocgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtenglish1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglishcgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglishcgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmath1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmathcgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmathcgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtscience1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtsciencecgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsciencecgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtap1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtapcgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtapcgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtesp1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtespcgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtespcgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txttle1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttlecgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttlecgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmapeh1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapehcgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapehcgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmusic1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusiccgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusiccgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtarts1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtartscgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtartscgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtpe1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpecgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpecgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txthealth1grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth1grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth2grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth2grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth3grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth3grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth4grade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth4grade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealthcgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealthcgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtaveragecgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtaveragecgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtdsjungrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjungrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjulgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjulgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsauggrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsauggrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdssepgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdssepgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsoctgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsoctgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsnovgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsnovgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsdecgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsdecgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjangrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjangrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsfebgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsfebgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsmargrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsmargrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsaprgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsaprgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdstotalgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdstotalgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjungrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjungrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjulgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjulgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpauggrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpauggrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpsepgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpsepgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpoctgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpoctgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpnovgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpnovgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpdecgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpdecgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjangrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjangrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpfebgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpfebgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpmargrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpmargrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpaprgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpaprgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdptotalgrade7__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdptotalgrade7.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipinocgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipinocgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtenglish1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglishcgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglishcgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmath1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmathcgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmathcgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtscience1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtsciencecgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsciencecgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtap1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtapcgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtapcgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtesp1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtespcgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtespcgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txttle1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttlecgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttlecgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmapeh1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapehcgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapehcgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmusic1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusiccgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusiccgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtarts1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtartscgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtartscgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtpe1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpecgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpecgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txthealth1grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth1grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth2grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth2grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth3grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth3grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth4grade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth4grade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealthcgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealthcgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtaveragecgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtaveragecgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtdsjungrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjungrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjulgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjulgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsauggrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsauggrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdssepgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdssepgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsoctgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsoctgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsnovgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsnovgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsdecgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsdecgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjangrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjangrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsfebgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsfebgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsmargrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsmargrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsaprgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsaprgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdstotalgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdstotalgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjungrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjungrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjulgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjulgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpauggrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpauggrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpsepgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpsepgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpoctgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpoctgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpnovgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpnovgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpdecgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpdecgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjangrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjangrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpfebgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpfebgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpmargrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpmargrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpaprgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpaprgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdptotalgrade8__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdptotalgrade8.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipinocgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipinocgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtenglish1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglishcgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglishcgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmath1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmathcgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmathcgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtscience1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtsciencecgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsciencecgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtap1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtapcgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtapcgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtesp1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtespcgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtespcgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txttle1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttlecgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttlecgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmapeh1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapehcgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapehcgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmusic1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusiccgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusiccgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtarts1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtartscgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtartscgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtpe1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpecgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpecgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txthealth1grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth1grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth2grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth2grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth3grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth3grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth4grade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth4grade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealthcgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealthcgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtaveragecgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtaveragecgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtdsjungrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjungrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjulgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjulgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsauggrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsauggrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdssepgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdssepgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsoctgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsoctgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsnovgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsnovgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsdecgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsdecgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjangrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjangrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsfebgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsfebgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsmargrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsmargrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsaprgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsaprgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdstotalgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdstotalgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjungrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjungrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjulgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjulgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpauggrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpauggrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpsepgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpsepgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpoctgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpoctgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpnovgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpnovgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpdecgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpdecgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjangrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjangrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpfebgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpfebgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpmargrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpmargrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpaprgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpaprgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdptotalgrade9__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdptotalgrade9.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipino4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipino4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtfilipinocgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtfilipinocgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtenglish1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglish4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglish4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtenglishcgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtenglishcgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmath1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmath4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmath4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmathcgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmathcgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtscience1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtscience4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtscience4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtsciencecgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtsciencecgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtap1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtap4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtap4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtapcgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtapcgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtesp1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtesp4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtesp4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtespcgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtespcgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txttle1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttle4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttle4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txttlecgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txttlecgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmapeh1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapeh4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapeh4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmapehcgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmapehcgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtmusic1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusic4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusic4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtmusiccgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtmusiccgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtarts1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtarts4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtarts4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtartscgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtartscgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtpe1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpe4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpe4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtpecgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtpecgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txthealth1grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth1grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth2grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth2grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth3grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth3grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealth4grade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealth4grade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txthealthcgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txthealthcgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtaveragecgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtaveragecgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
    End Sub
    Private Sub txtdsjungrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjungrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjulgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjulgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsauggrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsauggrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdssepgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdssepgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsoctgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsoctgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsnovgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsnovgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsdecgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsdecgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsjangrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsjangrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsfebgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsfebgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsmargrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsmargrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdsaprgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdsaprgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdstotalgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdstotalgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjungrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjungrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjulgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjulgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpauggrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpauggrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpsepgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpsepgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpoctgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpoctgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpnovgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpnovgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpdecgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpdecgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpjangrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpjangrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpfebgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpfebgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpmargrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpmargrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdpaprgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdpaprgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub txtdptotalgrade10__KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtdptotalgrade10.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
    End Sub
    Private Sub StudentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub txtname_Enter(sender As Object, e As EventArgs) Handles txtname.Enter
        If (txtname.Text = "Type the Full Name of the Student...") Then
            txtname.Text = ""
            txtname.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtname_Leave(sender As Object, e As EventArgs) Handles txtname.Leave
        If (txtname.Text = "") Then
            txtname.Text = "Type the Full Name of the Student..."
            txtname.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtlrn_Enter(sender As Object, e As EventArgs) Handles txtlrn.Enter
        If (txtlrn.Text = "Student LRN...") Then
            txtlrn.Text = ""
            txtlrn.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtlrn_Leave(sender As Object, e As EventArgs) Handles txtlrn.Leave
        If (txtlrn.Text = "") Then
            txtlrn.Text = "Student LRN..."
            txtlrn.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtbirthplace_Enter(sender As Object, e As EventArgs) Handles txtbirthplace.Enter
        If (txtbirthplace.Text = "Type the Birthplace/Province...") Then
            txtbirthplace.Text = ""
            txtbirthplace.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtbirthplace_Leave(sender As Object, e As EventArgs) Handles txtbirthplace.Leave
        If (txtbirthplace.Text = "") Then
            txtbirthplace.Text = "Type the Birthplace/Province..."
            txtbirthplace.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txttown_Enter(sender As Object, e As EventArgs) Handles txttown.Enter
        If (txttown.Text = "Type the Town/City...") Then
            txttown.Text = ""
            txttown.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txttown_Leave(sender As Object, e As EventArgs) Handles txttown.Leave
        If (txttown.Text = "") Then
            txttown.Text = "Type the Town/City..."
            txttown.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtbrgy_Enter(sender As Object, e As EventArgs) Handles txtbrgy.Enter
        If (txtbrgy.Text = "Type the Barangay...") Then
            txtbrgy.Text = ""
            txtbrgy.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtbrgy_Leave(sender As Object, e As EventArgs) Handles txtbrgy.Leave
        If (txtbrgy.Text = "") Then
            txtbrgy.Text = "Type the Barangay..."
            txtbrgy.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtparent_Enter(sender As Object, e As EventArgs) Handles txtparent.Enter
        If (txtparent.Text = "Parent/Guardian's Fullname...") Then
            txtparent.Text = ""
            txtparent.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtparent_Leave(sender As Object, e As EventArgs) Handles txtparent.Leave
        If (txtparent.Text = "") Then
            txtparent.Text = "Parent/Guardian's Fullname..."
            txtparent.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtoccupation_Enter(sender As Object, e As EventArgs) Handles txtoccupation.Enter
        If (txtoccupation.Text = "Occupation of the Parent/Guardian...") Then
            txtoccupation.Text = ""
            txtoccupation.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtoccupation_Leave(sender As Object, e As EventArgs) Handles txtoccupation.Leave
        If (txtoccupation.Text = "") Then
            txtoccupation.Text = "Occupation of the Parent/Guardian..."
            txtoccupation.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtaddress_Enter(sender As Object, e As EventArgs) Handles txtaddress.Enter
        If (txtaddress.Text = "Address of the Parent/Guardian...") Then
            txtaddress.Text = ""
            txtaddress.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtaddress_Leave(sender As Object, e As EventArgs) Handles txtaddress.Leave
        If (txtaddress.Text = "") Then
            txtaddress.Text = "Address of the Parent/Guardian..."
            txtaddress.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtelementaryschool_Enter(sender As Object, e As EventArgs) Handles txtelementaryschool.Enter
        If (txtelementaryschool.Text = "Elementary School Graduated...") Then
            txtelementaryschool.Text = ""
            txtelementaryschool.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtelementaryschool_Leave(sender As Object, e As EventArgs) Handles txtelementaryschool.Leave
        If (txtelementaryschool.Text = "") Then
            txtelementaryschool.Text = "Elementary School Graduated..."
            txtelementaryschool.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtgenave_Enter(sender As Object, e As EventArgs) Handles txtgenave.Enter
        If (txtgenave.Text = "Ave. Grade...") Then
            txtgenave.Text = ""
            txtgenave.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtgenave_Leave(sender As Object, e As EventArgs) Handles txtgenave.Leave
        If (txtgenave.Text = "") Then
            txtgenave.Text = "Ave. Grade..."
            txtgenave.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtsectiongrade7_Enter(sender As Object, e As EventArgs) Handles txtsectiongrade7.Enter
        If (txtsectiongrade7.Text = "Section...") Then
            txtsectiongrade7.Text = ""
            txtsectiongrade7.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtsectiongrade7_Leave(sender As Object, e As EventArgs) Handles txtsectiongrade7.Leave
        If (txtsectiongrade7.Text = "") Then
            txtsectiongrade7.Text = "Section..."
            txtsectiongrade7.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtschoolgrade7_Enter(sender As Object, e As EventArgs) Handles txtschoolgrade7.Enter
        If (txtschoolgrade7.Text = "School...") Then
            txtschoolgrade7.Text = ""
            txtschoolgrade7.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtschoolgrade7_Leave(sender As Object, e As EventArgs) Handles txtschoolgrade7.Leave
        If (txtschoolgrade7.Text = "") Then
            txtschoolgrade7.Text = "School..."
            txtschoolgrade7.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtsectiongrade8_Enter(sender As Object, e As EventArgs) Handles txtsectiongrade8.Enter
        If (txtsectiongrade8.Text = "Section...") Then
            txtsectiongrade8.Text = ""
            txtsectiongrade8.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtsectiongrade8_Leave(sender As Object, e As EventArgs) Handles txtsectiongrade8.Leave
        If (txtsectiongrade8.Text = "") Then
            txtsectiongrade8.Text = "Section..."
            txtsectiongrade8.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtschoolgrade8_Enter(sender As Object, e As EventArgs) Handles txtschoolgrade8.Enter
        If (txtschoolgrade8.Text = "School...") Then
            txtschoolgrade8.Text = ""
            txtschoolgrade8.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtschoolgrade8_Leave(sender As Object, e As EventArgs) Handles txtschoolgrade8.Leave
        If (txtschoolgrade8.Text = "") Then
            txtschoolgrade8.Text = "School..."
            txtschoolgrade8.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtsectiongrade9_Enter(sender As Object, e As EventArgs) Handles txtsectiongrade9.Enter
        If (txtsectiongrade9.Text = "Section...") Then
            txtsectiongrade9.Text = ""
            txtsectiongrade9.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtsectiongrade9_Leave(sender As Object, e As EventArgs) Handles txtsectiongrade9.Leave
        If (txtsectiongrade9.Text = "") Then
            txtsectiongrade9.Text = "Section..."
            txtsectiongrade9.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtschoolgrade9_Enter(sender As Object, e As EventArgs) Handles txtschoolgrade9.Enter
        If (txtschoolgrade9.Text = "School...") Then
            txtschoolgrade9.Text = ""
            txtschoolgrade9.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtschoolgrade9_Leave(sender As Object, e As EventArgs) Handles txtschoolgrade9.Leave
        If (txtschoolgrade9.Text = "") Then
            txtschoolgrade9.Text = "School..."
            txtschoolgrade9.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtsectiongrade10_Enter(sender As Object, e As EventArgs) Handles txtsectiongrade10.Enter
        If (txtsectiongrade10.Text = "Section...") Then
            txtsectiongrade10.Text = ""
            txtsectiongrade10.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtsectiongrade10_Leave(sender As Object, e As EventArgs) Handles txtsectiongrade10.Leave
        If (txtsectiongrade10.Text = "") Then
            txtsectiongrade10.Text = "Section..."
            txtsectiongrade10.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub txtschoolgrade10_Enter(sender As Object, e As EventArgs) Handles txtschoolgrade10.Enter
        If (txtschoolgrade10.Text = "School...") Then
            txtschoolgrade10.Text = ""
            txtschoolgrade10.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtschoolgrade10_Leave(sender As Object, e As EventArgs) Handles txtschoolgrade10.Leave
        If (txtschoolgrade10.Text = "") Then
            txtschoolgrade10.Text = "School..."
            txtschoolgrade10.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        PrintStudentRecord.Show()
    End Sub
    Private Sub txtfilipino1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtfilipino1grade7.TextChanged, txtfilipino2grade7.TextChanged, txtfilipino3grade7.TextChanged, txtfilipino4grade7.TextChanged
        If txtfilipino1grade7.Text = "" Or txtfilipino2grade7.Text = "" Or txtfilipino3grade7.Text = "" Or txtfilipino4grade7.Text = "" Then
            txtfilipinofrgrade7.Text = 0
            txtfilipinoatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtfilipino1grade7.Text) OrElse String.IsNullOrEmpty(txtfilipino2grade7.Text) OrElse String.IsNullOrEmpty(txtfilipino3grade7.Text) OrElse String.IsNullOrEmpty(txtfilipino4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtfilipino1grade7.Text) OrElse Not IsNumeric(txtfilipino2grade7.Text) OrElse Not IsNumeric(txtfilipino3grade7.Text) OrElse Not IsNumeric(txtfilipino4grade7.Text) Then Exit Sub
            txtfilipinofrgrade7.Text = Math.Round((CDbl(txtfilipino1grade7.Text) + CDbl(txtfilipino2grade7.Text) + CDbl(txtfilipino3grade7.Text) + CDbl(txtfilipino4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtfilipinofrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade7.TextChanged
        If txtfilipinofrgrade7.Text.ToString >= 74.5 Then
            txtfilipinoatgrade7.Text = "PASSED"
        Else
            txtfilipinoatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtenglish1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtenglish1grade7.TextChanged, txtenglish2grade7.TextChanged, txtenglish3grade7.TextChanged, txtenglish4grade7.TextChanged
        If txtenglish1grade7.Text = "" Or txtenglish2grade7.Text = "" Or txtenglish3grade7.Text = "" Or txtenglish4grade7.Text = "" Then
            txtenglishfrgrade7.Text = 0
            txtenglishatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtenglish1grade7.Text) OrElse String.IsNullOrEmpty(txtenglish2grade7.Text) OrElse String.IsNullOrEmpty(txtenglish3grade7.Text) OrElse String.IsNullOrEmpty(txtenglish4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtenglish1grade7.Text) OrElse Not IsNumeric(txtenglish2grade7.Text) OrElse Not IsNumeric(txtenglish3grade7.Text) OrElse Not IsNumeric(txtenglish4grade7.Text) Then Exit Sub
            txtenglishfrgrade7.Text = Math.Round((CDbl(txtenglish1grade7.Text) + CDbl(txtenglish2grade7.Text) + CDbl(txtenglish3grade7.Text) + CDbl(txtenglish4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtenglishfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtenglishfrgrade7.TextChanged
        If txtenglishfrgrade7.Text.ToString >= 74.5 Then
            txtenglishatgrade7.Text = "PASSED"
        Else
            txtenglishatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmath1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtmath1grade7.TextChanged, txtmath2grade7.TextChanged, txtmath3grade7.TextChanged, txtmath4grade7.TextChanged
        If txtmath1grade7.Text = "" Or txtmath2grade7.Text = "" Or txtmath3grade7.Text = "" Or txtmath4grade7.Text = "" Then
            txtmathfrgrade7.Text = 0
            txtmathatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtmath1grade7.Text) OrElse String.IsNullOrEmpty(txtmath2grade7.Text) OrElse String.IsNullOrEmpty(txtmath3grade7.Text) OrElse String.IsNullOrEmpty(txtmath4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtmath1grade7.Text) OrElse Not IsNumeric(txtmath2grade7.Text) OrElse Not IsNumeric(txtmath3grade7.Text) OrElse Not IsNumeric(txtmath4grade7.Text) Then Exit Sub
            txtmathfrgrade7.Text = Math.Round((CDbl(txtmath1grade7.Text) + CDbl(txtmath2grade7.Text) + CDbl(txtmath3grade7.Text) + CDbl(txtmath4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmathfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtmathfrgrade7.TextChanged
        If txtmathfrgrade7.Text.ToString >= 74.5 Then
            txtmathatgrade7.Text = "PASSED"
        Else
            txtmathatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtscience1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtscience1grade7.TextChanged, txtscience2grade7.TextChanged, txtscience3grade7.TextChanged, txtscience4grade7.TextChanged
        If txtscience1grade7.Text = "" Or txtscience2grade7.Text = "" Or txtscience3grade7.Text = "" Or txtscience4grade7.Text = "" Then
            txtsciencefrgrade7.Text = 0
            txtscienceatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtscience1grade7.Text) OrElse String.IsNullOrEmpty(txtscience2grade7.Text) OrElse String.IsNullOrEmpty(txtscience3grade7.Text) OrElse String.IsNullOrEmpty(txtscience4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtscience1grade7.Text) OrElse Not IsNumeric(txtscience2grade7.Text) OrElse Not IsNumeric(txtscience3grade7.Text) OrElse Not IsNumeric(txtscience4grade7.Text) Then Exit Sub
            txtsciencefrgrade7.Text = Math.Round((CDbl(txtscience1grade7.Text) + CDbl(txtscience2grade7.Text) + CDbl(txtscience3grade7.Text) + CDbl(txtscience4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtsciencefrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtsciencefrgrade7.TextChanged
        If txtsciencefrgrade7.Text.ToString >= 74.5 Then
            txtscienceatgrade7.Text = "PASSED"
        Else
            txtscienceatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtap1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtap1grade7.TextChanged, txtap2grade7.TextChanged, txtap3grade7.TextChanged, txtap4grade7.TextChanged
        If txtap1grade7.Text = "" Or txtap2grade7.Text = "" Or txtap3grade7.Text = "" Or txtap4grade7.Text = "" Then
            txtapfrgrade7.Text = 0
            txtapatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtap1grade7.Text) OrElse String.IsNullOrEmpty(txtap2grade7.Text) OrElse String.IsNullOrEmpty(txtap3grade7.Text) OrElse String.IsNullOrEmpty(txtap4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtap1grade7.Text) OrElse Not IsNumeric(txtap2grade7.Text) OrElse Not IsNumeric(txtap3grade7.Text) OrElse Not IsNumeric(txtap4grade7.Text) Then Exit Sub
            txtapfrgrade7.Text = Math.Round((CDbl(txtap1grade7.Text) + CDbl(txtap2grade7.Text) + CDbl(txtap3grade7.Text) + CDbl(txtap4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtapfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtapfrgrade7.TextChanged
        If txtapfrgrade7.Text.ToString >= 74.5 Then
            txtapatgrade7.Text = "PASSED"
        Else
            txtapatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtesp1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtesp1grade7.TextChanged, txtesp2grade7.TextChanged, txtesp3grade7.TextChanged, txtesp4grade7.TextChanged
        If txtesp1grade7.Text = "" Or txtesp2grade7.Text = "" Or txtesp3grade7.Text = "" Or txtesp4grade7.Text = "" Then
            txtespfrgrade7.Text = 0
            txtespatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtesp1grade7.Text) OrElse String.IsNullOrEmpty(txtesp2grade7.Text) OrElse String.IsNullOrEmpty(txtesp3grade7.Text) OrElse String.IsNullOrEmpty(txtesp4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtesp1grade7.Text) OrElse Not IsNumeric(txtesp2grade7.Text) OrElse Not IsNumeric(txtesp3grade7.Text) OrElse Not IsNumeric(txtesp4grade7.Text) Then Exit Sub
            txtespfrgrade7.Text = Math.Round((CDbl(txtesp1grade7.Text) + CDbl(txtesp2grade7.Text) + CDbl(txtesp3grade7.Text) + CDbl(txtesp4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtespfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtespfrgrade7.TextChanged
        If txtespfrgrade7.Text.ToString >= 74.5 Then
            txtespatgrade7.Text = "PASSED"
        Else
            txtespatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txttle1grade7_TextChanged(sender As Object, e As EventArgs) Handles txttle1grade7.TextChanged, txttle2grade7.TextChanged, txttle3grade7.TextChanged, txttle4grade7.TextChanged
        If txttle1grade7.Text = "" Or txttle2grade7.Text = "" Or txttle3grade7.Text = "" Or txttle4grade7.Text = "" Then
            txttlefrgrade7.Text = 0
            txttleatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txttle1grade7.Text) OrElse String.IsNullOrEmpty(txttle2grade7.Text) OrElse String.IsNullOrEmpty(txttle3grade7.Text) OrElse String.IsNullOrEmpty(txttle4grade7.Text) Then Exit Sub
            If Not IsNumeric(txttle1grade7.Text) OrElse Not IsNumeric(txttle2grade7.Text) OrElse Not IsNumeric(txttle3grade7.Text) OrElse Not IsNumeric(txttle4grade7.Text) Then Exit Sub
            txttlefrgrade7.Text = Math.Round((CDbl(txttle1grade7.Text) + CDbl(txttle2grade7.Text) + CDbl(txttle3grade7.Text) + CDbl(txttle4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txttlefrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txttlefrgrade7.TextChanged
        If txttlefrgrade7.Text.ToString >= 74.5 Then
            txttleatgrade7.Text = "PASSED"
        Else
            txttleatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmapeh1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtmapeh1grade7.TextChanged, txtmapeh2grade7.TextChanged, txtmapeh3grade7.TextChanged, txtmapeh4grade7.TextChanged
        If txtmapeh1grade7.Text = "" Or txtmapeh2grade7.Text = "" Or txtmapeh3grade7.Text = "" Or txtmapeh4grade7.Text = "" Then
            txtmapehfrgrade7.Text = 0
            txtmapehatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtmapeh1grade7.Text) OrElse String.IsNullOrEmpty(txtmapeh2grade7.Text) OrElse String.IsNullOrEmpty(txtmapeh3grade7.Text) OrElse String.IsNullOrEmpty(txtmapeh4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtmapeh1grade7.Text) OrElse Not IsNumeric(txtmapeh2grade7.Text) OrElse Not IsNumeric(txtmapeh3grade7.Text) OrElse Not IsNumeric(txtmapeh4grade7.Text) Then Exit Sub
            txtmapehfrgrade7.Text = Math.Round((CDbl(txtmapeh1grade7.Text) + CDbl(txtmapeh2grade7.Text) + CDbl(txtmapeh3grade7.Text) + CDbl(txtmapeh4grade7.Text)) / 4, 0)
        End If
    End Sub

    Private Sub txtmapehfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtmapehfrgrade7.TextChanged
        If txtmapehfrgrade7.Text.ToString >= 74.5 Then
            txtmapehatgrade7.Text = "PASSED"
        Else
            txtmapehatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmusic1grade7_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade7.TextChanged, txtarts1grade7.TextChanged, txtpe1grade7.TextChanged, txthealth1grade7.TextChanged
        If txtmusic1grade7.Text = "" Or txtarts1grade7.Text = "" Or txtpe1grade7.Text = "" Or txthealth1grade7.Text = "" Then
            txtmapeh1grade7.Text = 0
            txtmapehatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade7.Text) OrElse String.IsNullOrEmpty(txtarts1grade7.Text) OrElse String.IsNullOrEmpty(txtpe1grade7.Text) OrElse String.IsNullOrEmpty(txthealth1grade7.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade7.Text) OrElse Not IsNumeric(txtarts1grade7.Text) OrElse Not IsNumeric(txtpe1grade7.Text) OrElse Not IsNumeric(txthealth1grade7.Text) Then Exit Sub
            txtmapeh1grade7.Text = Math.Round((CDbl(txtmusic1grade7.Text) + CDbl(txtarts1grade7.Text) + CDbl(txtpe1grade7.Text) + CDbl(txthealth1grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic2grade7_TextChanged(sender As Object, e As EventArgs) Handles txtmusic2grade7.TextChanged, txtarts2grade7.TextChanged, txtpe2grade7.TextChanged, txthealth2grade7.TextChanged
        If txtmusic2grade7.Text = "" Or txtarts2grade7.Text = "" Or txtpe2grade7.Text = "" Or txthealth2grade7.Text = "" Then
            txtmapeh2grade7.Text = 0
            txtmapehatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic2grade7.Text) OrElse String.IsNullOrEmpty(txtarts2grade7.Text) OrElse String.IsNullOrEmpty(txtpe2grade7.Text) OrElse String.IsNullOrEmpty(txthealth2grade7.Text) Then Exit Sub
            If Not IsNumeric(txtmusic2grade7.Text) OrElse Not IsNumeric(txtarts2grade7.Text) OrElse Not IsNumeric(txtpe2grade7.Text) OrElse Not IsNumeric(txthealth2grade7.Text) Then Exit Sub
            txtmapeh2grade7.Text = Math.Round((CDbl(txtmusic2grade7.Text) + CDbl(txtarts2grade7.Text) + CDbl(txtpe2grade7.Text) + CDbl(txthealth2grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic3grade7_TextChanged(sender As Object, e As EventArgs) Handles txtmusic3grade7.TextChanged, txtarts3grade7.TextChanged, txtpe3grade7.TextChanged, txthealth3grade7.TextChanged
        If txtmusic3grade7.Text = "" Or txtarts3grade7.Text = "" Or txtpe3grade7.Text = "" Or txthealth3grade7.Text = "" Then
            txtmapeh3grade7.Text = 0
            txtmapehatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic3grade7.Text) OrElse String.IsNullOrEmpty(txtarts3grade7.Text) OrElse String.IsNullOrEmpty(txtpe3grade7.Text) OrElse String.IsNullOrEmpty(txthealth3grade7.Text) Then Exit Sub
            If Not IsNumeric(txtmusic3grade7.Text) OrElse Not IsNumeric(txtarts3grade7.Text) OrElse Not IsNumeric(txtpe3grade7.Text) OrElse Not IsNumeric(txthealth3grade7.Text) Then Exit Sub
            txtmapeh3grade7.Text = Math.Round((CDbl(txtmusic3grade7.Text) + CDbl(txtarts3grade7.Text) + CDbl(txtpe3grade7.Text) + CDbl(txthealth3grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic4grade7_TextChanged(sender As Object, e As EventArgs) Handles txtmusic4grade7.TextChanged, txtarts4grade7.TextChanged, txtpe4grade7.TextChanged, txthealth4grade7.TextChanged
        If txtmusic4grade7.Text = "" Or txtarts4grade7.Text = "" Or txtpe4grade7.Text = "" Or txthealth4grade7.Text = "" Then
            txtmapeh4grade7.Text = 0
            txtmapehatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic4grade7.Text) OrElse String.IsNullOrEmpty(txtarts4grade7.Text) OrElse String.IsNullOrEmpty(txtpe4grade7.Text) OrElse String.IsNullOrEmpty(txthealth4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtmusic4grade7.Text) OrElse Not IsNumeric(txtarts4grade7.Text) OrElse Not IsNumeric(txtpe4grade7.Text) OrElse Not IsNumeric(txthealth4grade7.Text) Then Exit Sub
            txtmapeh4grade7.Text = Math.Round((CDbl(txtmusic4grade7.Text) + CDbl(txtarts4grade7.Text) + CDbl(txtpe4grade7.Text) + CDbl(txthealth4grade7.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusicfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade7.TextChanged, txtmusic2grade7.TextChanged, txtmusic3grade7.TextChanged, txtmusic4grade7.TextChanged
        If txtmusic1grade7.Text = "" Or txtmusic2grade7.Text = "" Or txtmusic3grade7.Text = "" Or txtmusic4grade7.Text = "" Then
            txtmusicfrgrade7.Text = 0
            txtmusicatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade7.Text) OrElse String.IsNullOrEmpty(txtmusic2grade7.Text) OrElse String.IsNullOrEmpty(txtmusic3grade7.Text) OrElse String.IsNullOrEmpty(txtmusic4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade7.Text) OrElse Not IsNumeric(txtmusic2grade7.Text) OrElse Not IsNumeric(txtmusic3grade7.Text) OrElse Not IsNumeric(txtmusic4grade7.Text) Then Exit Sub
            txtmusicfrgrade7.Text = Math.Round((CDbl(txtmusic1grade7.Text) + CDbl(txtmusic2grade7.Text) + CDbl(txtmusic3grade7.Text) + CDbl(txtmusic4grade7.Text)) / 4, 0)
            If txtmusicfrgrade7.Text.ToString >= 74.5 Then
                txtmusicatgrade7.Text = "PASSED"
            Else
                txtmusicatgrade7.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtartsfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtarts1grade7.TextChanged, txtarts2grade7.TextChanged, txtarts3grade7.TextChanged, txtarts4grade7.TextChanged
        If txtarts1grade7.Text = "" Or txtarts2grade7.Text = "" Or txtarts3grade7.Text = "" Or txtarts4grade7.Text = "" Then
            txtartsfrgrade7.Text = 0
            txtartsatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtarts1grade7.Text) OrElse String.IsNullOrEmpty(txtarts2grade7.Text) OrElse String.IsNullOrEmpty(txtarts3grade7.Text) OrElse String.IsNullOrEmpty(txtarts4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtarts1grade7.Text) OrElse Not IsNumeric(txtarts2grade7.Text) OrElse Not IsNumeric(txtarts3grade7.Text) OrElse Not IsNumeric(txtarts4grade7.Text) Then Exit Sub
            txtartsfrgrade7.Text = Math.Round((CDbl(txtarts1grade7.Text) + CDbl(txtarts2grade7.Text) + CDbl(txtarts3grade7.Text) + CDbl(txtarts4grade7.Text)) / 4, 0)
            If txtartsfrgrade7.Text.ToString >= 74.5 Then
                txtartsatgrade7.Text = "PASSED"
            Else
                txtartsatgrade7.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtpefrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtpe1grade7.TextChanged, txtpe2grade7.TextChanged, txtpe3grade7.TextChanged, txtpe4grade7.TextChanged
        If txtpe1grade7.Text = "" Or txtpe2grade7.Text = "" Or txtpe3grade7.Text = "" Or txtpe4grade7.Text = "" Then
            txtpefrgrade7.Text = 0
            txtpeatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtpe1grade7.Text) OrElse String.IsNullOrEmpty(txtpe2grade7.Text) OrElse String.IsNullOrEmpty(txtpe3grade7.Text) OrElse String.IsNullOrEmpty(txtpe4grade7.Text) Then Exit Sub
            If Not IsNumeric(txtpe1grade7.Text) OrElse Not IsNumeric(txtpe2grade7.Text) OrElse Not IsNumeric(txtpe3grade7.Text) OrElse Not IsNumeric(txtpe4grade7.Text) Then Exit Sub
            txtpefrgrade7.Text = Math.Round((CDbl(txtpe1grade7.Text) + CDbl(txtpe2grade7.Text) + CDbl(txtpe3grade7.Text) + CDbl(txtpe4grade7.Text)) / 4, 0)
            If txtpefrgrade7.Text.ToString >= 74.5 Then
                txtpeatgrade7.Text = "PASSED"
            Else
                txtpeatgrade7.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txthealthfrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txthealth1grade7.TextChanged, txthealth2grade7.TextChanged, txthealth3grade7.TextChanged, txthealth4grade7.TextChanged
        If txthealth1grade7.Text = "" Or txthealth2grade7.Text = "" Or txthealth3grade7.Text = "" Or txthealth4grade7.Text = "" Then
            txthealthfrgrade7.Text = 0
            txthealthatgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txthealth1grade7.Text) OrElse String.IsNullOrEmpty(txthealth2grade7.Text) OrElse String.IsNullOrEmpty(txthealth3grade7.Text) OrElse String.IsNullOrEmpty(txthealth4grade7.Text) Then Exit Sub
            If Not IsNumeric(txthealth1grade7.Text) OrElse Not IsNumeric(txthealth2grade7.Text) OrElse Not IsNumeric(txthealth3grade7.Text) OrElse Not IsNumeric(txthealth4grade7.Text) Then Exit Sub
            txthealthfrgrade7.Text = Math.Round((CDbl(txthealth1grade7.Text) + CDbl(txthealth2grade7.Text) + CDbl(txthealth3grade7.Text) + CDbl(txthealth4grade7.Text)) / 4, 0)
            If txthealthfrgrade7.Text.ToString >= 74.5 Then
                txthealthatgrade7.Text = "PASSED"
            Else
                txthealthatgrade7.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtaveragefrgrade7_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade7.TextChanged, txtenglishfrgrade7.TextChanged, txtmathfrgrade7.TextChanged, txtsciencefrgrade7.TextChanged, txtapfrgrade7.TextChanged, txtespfrgrade7.TextChanged, txttlefrgrade7.TextChanged, txtmapehfrgrade7.TextChanged
        If String.IsNullOrEmpty(txtfilipinofrgrade7.Text) OrElse String.IsNullOrEmpty(txtenglishfrgrade7.Text) OrElse String.IsNullOrEmpty(txtmathfrgrade7.Text) OrElse String.IsNullOrEmpty(txtsciencefrgrade7.Text) OrElse String.IsNullOrEmpty(txtapfrgrade7.Text) OrElse String.IsNullOrEmpty(txtespfrgrade7.Text) OrElse String.IsNullOrEmpty(txttlefrgrade7.Text) OrElse String.IsNullOrEmpty(txtmapehfrgrade7.Text) Then Exit Sub
        If Not IsNumeric(txtfilipinofrgrade7.Text) OrElse Not IsNumeric(txtenglishfrgrade7.Text) OrElse Not IsNumeric(txtmathfrgrade7.Text) OrElse Not IsNumeric(txtsciencefrgrade7.Text) OrElse Not IsNumeric(txtapfrgrade7.Text) OrElse Not IsNumeric(txtespfrgrade7.Text) OrElse Not IsNumeric(txttlefrgrade7.Text) OrElse Not IsNumeric(txtmapehfrgrade7.Text) Then Exit Sub
        txtaveragefrgrade7.Text = Math.Round((CDbl(txtfilipinofrgrade7.Text) + CDbl(txtenglishfrgrade7.Text) + CDbl(txtmathfrgrade7.Text) + CDbl(txtsciencefrgrade7.Text) + CDbl(txtapfrgrade7.Text) + CDbl(txtespfrgrade7.Text) + CDbl(txttlefrgrade7.Text) + CDbl(txtmapehfrgrade7.Text)) / 8, 2)
        If txtaveragefrgrade7.Text.ToString >= 74.5 Then
            txtaverageatgrade7.Text = "PASSED"
        Else
            txtaverageatgrade7.Text = "FAILED"
        End If
    End Sub
    Private Sub txtdsjungrade7_TextChanged(sender As Object, e As EventArgs) Handles txtdsjungrade7.TextChanged, txtdsjulgrade7.TextChanged, txtdsauggrade7.TextChanged, txtdssepgrade7.TextChanged, txtdsoctgrade7.TextChanged, txtdsnovgrade7.TextChanged, txtdsdecgrade7.TextChanged, txtdsjangrade7.TextChanged, txtdsfebgrade7.TextChanged, txtdsmargrade7.TextChanged, txtdsaprgrade7.TextChanged
        If txtdsjungrade7.Text = "" Or txtdsjulgrade7.Text = "" Or txtdsauggrade7.Text = "" Or txtdssepgrade7.Text = "" Or txtdsoctgrade7.Text = "" Or txtdsnovgrade7.Text = "" Or txtdsdecgrade7.Text = "" Or txtdsjangrade7.Text = "" Or txtdsfebgrade7.Text = "" Or txtdsmargrade7.Text = "" Or txtdsaprgrade7.Text = "" Then
            txtdstotalgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtdsjungrade7.Text) OrElse String.IsNullOrEmpty(txtdsjulgrade7.Text) OrElse String.IsNullOrEmpty(txtdsauggrade7.Text) OrElse String.IsNullOrEmpty(txtdssepgrade7.Text) OrElse String.IsNullOrEmpty(txtdsoctgrade7.Text) OrElse String.IsNullOrEmpty(txtdsnovgrade7.Text) OrElse String.IsNullOrEmpty(txtdsdecgrade7.Text) OrElse String.IsNullOrEmpty(txtdsjangrade7.Text) OrElse String.IsNullOrEmpty(txtdsfebgrade7.Text) OrElse String.IsNullOrEmpty(txtdsmargrade7.Text) OrElse String.IsNullOrEmpty(txtdsaprgrade7.Text) Then Exit Sub
            If Not IsNumeric(txtdsjungrade7.Text) OrElse Not IsNumeric(txtdsjulgrade7.Text) OrElse Not IsNumeric(txtdsauggrade7.Text) OrElse Not IsNumeric(txtdssepgrade7.Text) OrElse Not IsNumeric(txtdsoctgrade7.Text) OrElse Not IsNumeric(txtdsnovgrade7.Text) OrElse Not IsNumeric(txtdsdecgrade7.Text) OrElse Not IsNumeric(txtdsjangrade7.Text) OrElse Not IsNumeric(txtdsfebgrade7.Text) OrElse Not IsNumeric(txtdsmargrade7.Text) OrElse Not IsNumeric(txtdsaprgrade7.Text) Then Exit Sub
            txtdstotalgrade7.Text = (CDbl(txtdsjungrade7.Text) + CDbl(txtdsjulgrade7.Text) + CDbl(txtdsauggrade7.Text) + CDbl(txtdssepgrade7.Text) + CDbl(txtdsoctgrade7.Text) + CDbl(txtdsnovgrade7.Text) + CDbl(txtdsdecgrade7.Text) + CDbl(txtdsjangrade7.Text) + CDbl(txtdsfebgrade7.Text) + CDbl(txtdsmargrade7.Text) + CDbl(txtdsaprgrade7.Text))
        End If
    End Sub
    Private Sub txtdpjungrade7_TextChanged(sender As Object, e As EventArgs) Handles txtdpjungrade7.TextChanged, txtdpjulgrade7.TextChanged, txtdpauggrade7.TextChanged, txtdpsepgrade7.TextChanged, txtdpoctgrade7.TextChanged, txtdpnovgrade7.TextChanged, txtdpdecgrade7.TextChanged, txtdpjangrade7.TextChanged, txtdpfebgrade7.TextChanged, txtdpmargrade7.TextChanged, txtdpaprgrade7.TextChanged
        If txtdpjungrade7.Text = "" Or txtdpjulgrade7.Text = "" Or txtdpauggrade7.Text = "" Or txtdpsepgrade7.Text = "" Or txtdpoctgrade7.Text = "" Or txtdpnovgrade7.Text = "" Or txtdpdecgrade7.Text = "" Or txtdpjangrade7.Text = "" Or txtdpfebgrade7.Text = "" Or txtdpmargrade7.Text = "" Or txtdpaprgrade7.Text = "" Then
            txtdptotalgrade7.Text = ""
        Else
            If String.IsNullOrEmpty(txtdpjungrade7.Text) OrElse String.IsNullOrEmpty(txtdpjulgrade7.Text) OrElse String.IsNullOrEmpty(txtdpauggrade7.Text) OrElse String.IsNullOrEmpty(txtdpsepgrade7.Text) OrElse String.IsNullOrEmpty(txtdpoctgrade7.Text) OrElse String.IsNullOrEmpty(txtdpnovgrade7.Text) OrElse String.IsNullOrEmpty(txtdpdecgrade7.Text) OrElse String.IsNullOrEmpty(txtdpjangrade7.Text) OrElse String.IsNullOrEmpty(txtdpfebgrade7.Text) OrElse String.IsNullOrEmpty(txtdpmargrade7.Text) OrElse String.IsNullOrEmpty(txtdpaprgrade7.Text) Then Exit Sub
            If Not IsNumeric(txtdpjungrade7.Text) OrElse Not IsNumeric(txtdpjulgrade7.Text) OrElse Not IsNumeric(txtdpauggrade7.Text) OrElse Not IsNumeric(txtdpsepgrade7.Text) OrElse Not IsNumeric(txtdpoctgrade7.Text) OrElse Not IsNumeric(txtdpnovgrade7.Text) OrElse Not IsNumeric(txtdpdecgrade7.Text) OrElse Not IsNumeric(txtdpjangrade7.Text) OrElse Not IsNumeric(txtdpfebgrade7.Text) OrElse Not IsNumeric(txtdpmargrade7.Text) OrElse Not IsNumeric(txtdpaprgrade7.Text) Then Exit Sub
            txtdptotalgrade7.Text = (CDbl(txtdpjungrade7.Text) + CDbl(txtdpjulgrade7.Text) + CDbl(txtdpauggrade7.Text) + CDbl(txtdpsepgrade7.Text) + CDbl(txtdpoctgrade7.Text) + CDbl(txtdpnovgrade7.Text) + CDbl(txtdpdecgrade7.Text) + CDbl(txtdpjangrade7.Text) + CDbl(txtdpfebgrade7.Text) + CDbl(txtdpmargrade7.Text) + CDbl(txtdpaprgrade7.Text))
        End If
    End Sub
    Private Sub txtfilipino1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtfilipino1grade8.TextChanged, txtfilipino2grade8.TextChanged, txtfilipino3grade8.TextChanged, txtfilipino4grade8.TextChanged
        If txtfilipino1grade8.Text = "" Or txtfilipino2grade8.Text = "" Or txtfilipino3grade8.Text = "" Or txtfilipino4grade8.Text = "" Then
            txtfilipinofrgrade8.Text = 0
            txtfilipinoatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtfilipino1grade8.Text) OrElse String.IsNullOrEmpty(txtfilipino2grade8.Text) OrElse String.IsNullOrEmpty(txtfilipino3grade8.Text) OrElse String.IsNullOrEmpty(txtfilipino4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtfilipino1grade8.Text) OrElse Not IsNumeric(txtfilipino2grade8.Text) OrElse Not IsNumeric(txtfilipino3grade8.Text) OrElse Not IsNumeric(txtfilipino4grade8.Text) Then Exit Sub
            txtfilipinofrgrade8.Text = Math.Round((CDbl(txtfilipino1grade8.Text) + CDbl(txtfilipino2grade8.Text) + CDbl(txtfilipino3grade8.Text) + CDbl(txtfilipino4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtfilipinofrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade8.TextChanged
        If txtfilipinofrgrade8.Text.ToString >= 74.5 Then
            txtfilipinoatgrade8.Text = "PASSED"
        Else
            txtfilipinoatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtenglish1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtenglish1grade8.TextChanged, txtenglish2grade8.TextChanged, txtenglish3grade8.TextChanged, txtenglish4grade8.TextChanged
        If txtenglish1grade8.Text = "" Or txtenglish2grade8.Text = "" Or txtenglish3grade8.Text = "" Or txtenglish4grade8.Text = "" Then
            txtenglishfrgrade8.Text = 0
            txtenglishatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtenglish1grade8.Text) OrElse String.IsNullOrEmpty(txtenglish2grade8.Text) OrElse String.IsNullOrEmpty(txtenglish3grade8.Text) OrElse String.IsNullOrEmpty(txtenglish4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtenglish1grade8.Text) OrElse Not IsNumeric(txtenglish2grade8.Text) OrElse Not IsNumeric(txtenglish3grade8.Text) OrElse Not IsNumeric(txtenglish4grade8.Text) Then Exit Sub
            txtenglishfrgrade8.Text = Math.Round((CDbl(txtenglish1grade8.Text) + CDbl(txtenglish2grade8.Text) + CDbl(txtenglish3grade8.Text) + CDbl(txtenglish4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtenglishfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtenglishfrgrade8.TextChanged
        If txtenglishfrgrade8.Text.ToString >= 74.5 Then
            txtenglishatgrade8.Text = "PASSED"
        Else
            txtenglishatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmath1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtmath1grade8.TextChanged, txtmath2grade8.TextChanged, txtmath3grade8.TextChanged, txtmath4grade8.TextChanged
        If txtmath1grade8.Text = "" Or txtmath2grade8.Text = "" Or txtmath3grade8.Text = "" Or txtmath4grade8.Text = "" Then
            txtmathfrgrade8.Text = 0
            txtmathatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtmath1grade8.Text) OrElse String.IsNullOrEmpty(txtmath2grade8.Text) OrElse String.IsNullOrEmpty(txtmath3grade8.Text) OrElse String.IsNullOrEmpty(txtmath4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtmath1grade8.Text) OrElse Not IsNumeric(txtmath2grade8.Text) OrElse Not IsNumeric(txtmath3grade8.Text) OrElse Not IsNumeric(txtmath4grade8.Text) Then Exit Sub
            txtmathfrgrade8.Text = Math.Round((CDbl(txtmath1grade8.Text) + CDbl(txtmath2grade8.Text) + CDbl(txtmath3grade8.Text) + CDbl(txtmath4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmathfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtmathfrgrade8.TextChanged
        If txtmathfrgrade8.Text.ToString >= 74.5 Then
            txtmathatgrade8.Text = "PASSED"
        Else
            txtmathatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtscience1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtscience1grade8.TextChanged, txtscience2grade8.TextChanged, txtscience3grade8.TextChanged, txtscience4grade8.TextChanged
        If txtscience1grade8.Text = "" Or txtscience2grade8.Text = "" Or txtscience3grade8.Text = "" Or txtscience4grade8.Text = "" Then
            txtsciencefrgrade8.Text = 0
            txtscienceatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtscience1grade8.Text) OrElse String.IsNullOrEmpty(txtscience2grade8.Text) OrElse String.IsNullOrEmpty(txtscience3grade8.Text) OrElse String.IsNullOrEmpty(txtscience4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtscience1grade8.Text) OrElse Not IsNumeric(txtscience2grade8.Text) OrElse Not IsNumeric(txtscience3grade8.Text) OrElse Not IsNumeric(txtscience4grade8.Text) Then Exit Sub
            txtsciencefrgrade8.Text = Math.Round((CDbl(txtscience1grade8.Text) + CDbl(txtscience2grade8.Text) + CDbl(txtscience3grade8.Text) + CDbl(txtscience4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtsciencefrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtsciencefrgrade8.TextChanged
        If txtsciencefrgrade8.Text.ToString >= 74.5 Then
            txtscienceatgrade8.Text = "PASSED"
        Else
            txtscienceatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtap1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtap1grade8.TextChanged, txtap2grade8.TextChanged, txtap3grade8.TextChanged, txtap4grade8.TextChanged
        If txtap1grade8.Text = "" Or txtap2grade8.Text = "" Or txtap3grade8.Text = "" Or txtap4grade8.Text = "" Then
            txtapfrgrade8.Text = 0
            txtapatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtap1grade8.Text) OrElse String.IsNullOrEmpty(txtap2grade8.Text) OrElse String.IsNullOrEmpty(txtap3grade8.Text) OrElse String.IsNullOrEmpty(txtap4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtap1grade8.Text) OrElse Not IsNumeric(txtap2grade8.Text) OrElse Not IsNumeric(txtap3grade8.Text) OrElse Not IsNumeric(txtap4grade8.Text) Then Exit Sub
            txtapfrgrade8.Text = Math.Round((CDbl(txtap1grade8.Text) + CDbl(txtap2grade8.Text) + CDbl(txtap3grade8.Text) + CDbl(txtap4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtapfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtapfrgrade8.TextChanged
        If txtapfrgrade8.Text.ToString >= 74.5 Then
            txtapatgrade8.Text = "PASSED"
        Else
            txtapatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtesp1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtesp1grade8.TextChanged, txtesp2grade8.TextChanged, txtesp3grade8.TextChanged, txtesp4grade8.TextChanged
        If txtesp1grade8.Text = "" Or txtesp2grade8.Text = "" Or txtesp3grade8.Text = "" Or txtesp4grade8.Text = "" Then
            txtespfrgrade8.Text = 0
            txtespatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtesp1grade8.Text) OrElse String.IsNullOrEmpty(txtesp2grade8.Text) OrElse String.IsNullOrEmpty(txtesp3grade8.Text) OrElse String.IsNullOrEmpty(txtesp4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtesp1grade8.Text) OrElse Not IsNumeric(txtesp2grade8.Text) OrElse Not IsNumeric(txtesp3grade8.Text) OrElse Not IsNumeric(txtesp4grade8.Text) Then Exit Sub
            txtespfrgrade8.Text = Math.Round((CDbl(txtesp1grade8.Text) + CDbl(txtesp2grade8.Text) + CDbl(txtesp3grade8.Text) + CDbl(txtesp4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtespfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtespfrgrade8.TextChanged
        If txtespfrgrade8.Text.ToString >= 74.5 Then
            txtespatgrade8.Text = "PASSED"
        Else
            txtespatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txttle1grade8_TextChanged(sender As Object, e As EventArgs) Handles txttle1grade8.TextChanged, txttle2grade8.TextChanged, txttle3grade8.TextChanged, txttle4grade8.TextChanged
        If txttle1grade8.Text = "" Or txttle2grade8.Text = "" Or txttle3grade8.Text = "" Or txttle4grade8.Text = "" Then
            txttlefrgrade8.Text = 0
            txttleatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txttle1grade8.Text) OrElse String.IsNullOrEmpty(txttle2grade8.Text) OrElse String.IsNullOrEmpty(txttle3grade8.Text) OrElse String.IsNullOrEmpty(txttle4grade8.Text) Then Exit Sub
            If Not IsNumeric(txttle1grade8.Text) OrElse Not IsNumeric(txttle2grade8.Text) OrElse Not IsNumeric(txttle3grade8.Text) OrElse Not IsNumeric(txttle4grade8.Text) Then Exit Sub
            txttlefrgrade8.Text = Math.Round((CDbl(txttle1grade8.Text) + CDbl(txttle2grade8.Text) + CDbl(txttle3grade8.Text) + CDbl(txttle4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txttlefrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txttlefrgrade8.TextChanged
        If txttlefrgrade8.Text.ToString >= 74.5 Then
            txttleatgrade8.Text = "PASSED"
        Else
            txttleatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmapeh1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtmapeh1grade8.TextChanged, txtmapeh2grade8.TextChanged, txtmapeh3grade8.TextChanged, txtmapeh4grade8.TextChanged
        If txtmapeh1grade8.Text = "" Or txtmapeh2grade8.Text = "" Or txtmapeh3grade8.Text = "" Or txtmapeh4grade8.Text = "" Then
            txtmapehfrgrade8.Text = 0
            txtmapehatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtmapeh1grade8.Text) OrElse String.IsNullOrEmpty(txtmapeh2grade8.Text) OrElse String.IsNullOrEmpty(txtmapeh3grade8.Text) OrElse String.IsNullOrEmpty(txtmapeh4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtmapeh1grade8.Text) OrElse Not IsNumeric(txtmapeh2grade8.Text) OrElse Not IsNumeric(txtmapeh3grade8.Text) OrElse Not IsNumeric(txtmapeh4grade8.Text) Then Exit Sub
            txtmapehfrgrade8.Text = Math.Round((CDbl(txtmapeh1grade8.Text) + CDbl(txtmapeh2grade8.Text) + CDbl(txtmapeh3grade8.Text) + CDbl(txtmapeh4grade8.Text)) / 4, 0)
        End If
    End Sub

    Private Sub txtmapehfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtmapehfrgrade8.TextChanged
        If txtmapehfrgrade8.Text.ToString >= 74.5 Then
            txtmapehatgrade8.Text = "PASSED"
        Else
            txtmapehatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmusic1grade8_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade8.TextChanged, txtarts1grade8.TextChanged, txtpe1grade8.TextChanged, txthealth1grade8.TextChanged
        If txtmusic1grade8.Text = "" Or txtarts1grade8.Text = "" Or txtpe1grade8.Text = "" Or txthealth1grade8.Text = "" Then
            txtmapeh1grade8.Text = 0
            txtmapehatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade8.Text) OrElse String.IsNullOrEmpty(txtarts1grade8.Text) OrElse String.IsNullOrEmpty(txtpe1grade8.Text) OrElse String.IsNullOrEmpty(txthealth1grade8.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade8.Text) OrElse Not IsNumeric(txtarts1grade8.Text) OrElse Not IsNumeric(txtpe1grade8.Text) OrElse Not IsNumeric(txthealth1grade8.Text) Then Exit Sub
            txtmapeh1grade8.Text = Math.Round((CDbl(txtmusic1grade8.Text) + CDbl(txtarts1grade8.Text) + CDbl(txtpe1grade8.Text) + CDbl(txthealth1grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic2grade8_TextChanged(sender As Object, e As EventArgs) Handles txtmusic2grade8.TextChanged, txtarts2grade8.TextChanged, txtpe2grade8.TextChanged, txthealth2grade8.TextChanged
        If txtmusic2grade8.Text = "" Or txtarts2grade8.Text = "" Or txtpe2grade8.Text = "" Or txthealth2grade8.Text = "" Then
            txtmapeh2grade8.Text = 0
            txtmapehatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic2grade8.Text) OrElse String.IsNullOrEmpty(txtarts2grade8.Text) OrElse String.IsNullOrEmpty(txtpe2grade8.Text) OrElse String.IsNullOrEmpty(txthealth2grade8.Text) Then Exit Sub
            If Not IsNumeric(txtmusic2grade8.Text) OrElse Not IsNumeric(txtarts2grade8.Text) OrElse Not IsNumeric(txtpe2grade8.Text) OrElse Not IsNumeric(txthealth2grade8.Text) Then Exit Sub
            txtmapeh2grade8.Text = Math.Round((CDbl(txtmusic2grade8.Text) + CDbl(txtarts2grade8.Text) + CDbl(txtpe2grade8.Text) + CDbl(txthealth2grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic3grade8_TextChanged(sender As Object, e As EventArgs) Handles txtmusic3grade8.TextChanged, txtarts3grade8.TextChanged, txtpe3grade8.TextChanged, txthealth3grade8.TextChanged
        If txtmusic3grade8.Text = "" Or txtarts3grade8.Text = "" Or txtpe3grade8.Text = "" Or txthealth3grade8.Text = "" Then
            txtmapeh3grade8.Text = 0
            txtmapehatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic3grade8.Text) OrElse String.IsNullOrEmpty(txtarts3grade8.Text) OrElse String.IsNullOrEmpty(txtpe3grade8.Text) OrElse String.IsNullOrEmpty(txthealth3grade8.Text) Then Exit Sub
            If Not IsNumeric(txtmusic3grade8.Text) OrElse Not IsNumeric(txtarts3grade8.Text) OrElse Not IsNumeric(txtpe3grade8.Text) OrElse Not IsNumeric(txthealth3grade8.Text) Then Exit Sub
            txtmapeh3grade8.Text = Math.Round((CDbl(txtmusic3grade8.Text) + CDbl(txtarts3grade8.Text) + CDbl(txtpe3grade8.Text) + CDbl(txthealth3grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic4grade8_TextChanged(sender As Object, e As EventArgs) Handles txtmusic4grade8.TextChanged, txtarts4grade8.TextChanged, txtpe4grade8.TextChanged, txthealth4grade8.TextChanged
        If txtmusic4grade8.Text = "" Or txtarts4grade8.Text = "" Or txtpe4grade8.Text = "" Or txthealth4grade8.Text = "" Then
            txtmapeh4grade8.Text = 0
            txtmapehatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic4grade8.Text) OrElse String.IsNullOrEmpty(txtarts4grade8.Text) OrElse String.IsNullOrEmpty(txtpe4grade8.Text) OrElse String.IsNullOrEmpty(txthealth4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtmusic4grade8.Text) OrElse Not IsNumeric(txtarts4grade8.Text) OrElse Not IsNumeric(txtpe4grade8.Text) OrElse Not IsNumeric(txthealth4grade8.Text) Then Exit Sub
            txtmapeh4grade8.Text = Math.Round((CDbl(txtmusic4grade8.Text) + CDbl(txtarts4grade8.Text) + CDbl(txtpe4grade8.Text) + CDbl(txthealth4grade8.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusicfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade8.TextChanged, txtmusic2grade8.TextChanged, txtmusic3grade8.TextChanged, txtmusic4grade8.TextChanged
        If txtmusic1grade8.Text = "" Or txtmusic2grade8.Text = "" Or txtmusic3grade8.Text = "" Or txtmusic4grade8.Text = "" Then
            txtmusicfrgrade8.Text = 0
            txtmusicatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade8.Text) OrElse String.IsNullOrEmpty(txtmusic2grade8.Text) OrElse String.IsNullOrEmpty(txtmusic3grade8.Text) OrElse String.IsNullOrEmpty(txtmusic4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade8.Text) OrElse Not IsNumeric(txtmusic2grade8.Text) OrElse Not IsNumeric(txtmusic3grade8.Text) OrElse Not IsNumeric(txtmusic4grade8.Text) Then Exit Sub
            txtmusicfrgrade8.Text = Math.Round((CDbl(txtmusic1grade8.Text) + CDbl(txtmusic2grade8.Text) + CDbl(txtmusic3grade8.Text) + CDbl(txtmusic4grade8.Text)) / 4, 0)
            If txtmusicfrgrade8.Text.ToString >= 74.5 Then
                txtmusicatgrade8.Text = "PASSED"
            Else
                txtmusicatgrade8.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtartsfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtarts1grade8.TextChanged, txtarts2grade8.TextChanged, txtarts3grade8.TextChanged, txtarts4grade8.TextChanged
        If txtarts1grade8.Text = "" Or txtarts2grade8.Text = "" Or txtarts3grade8.Text = "" Or txtarts4grade8.Text = "" Then
            txtartsfrgrade8.Text = 0
            txtartsatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtarts1grade8.Text) OrElse String.IsNullOrEmpty(txtarts2grade8.Text) OrElse String.IsNullOrEmpty(txtarts3grade8.Text) OrElse String.IsNullOrEmpty(txtarts4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtarts1grade8.Text) OrElse Not IsNumeric(txtarts2grade8.Text) OrElse Not IsNumeric(txtarts3grade8.Text) OrElse Not IsNumeric(txtarts4grade8.Text) Then Exit Sub
            txtartsfrgrade8.Text = Math.Round((CDbl(txtarts1grade8.Text) + CDbl(txtarts2grade8.Text) + CDbl(txtarts3grade8.Text) + CDbl(txtarts4grade8.Text)) / 4, 0)
            If txtartsfrgrade8.Text.ToString >= 74.5 Then
                txtartsatgrade8.Text = "PASSED"
            Else
                txtartsatgrade8.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtpefrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtpe1grade8.TextChanged, txtpe2grade8.TextChanged, txtpe3grade8.TextChanged, txtpe4grade8.TextChanged
        If txtpe1grade8.Text = "" Or txtpe2grade8.Text = "" Or txtpe3grade8.Text = "" Or txtpe4grade8.Text = "" Then
            txtpefrgrade8.Text = 0
            txtpeatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtpe1grade8.Text) OrElse String.IsNullOrEmpty(txtpe2grade8.Text) OrElse String.IsNullOrEmpty(txtpe3grade8.Text) OrElse String.IsNullOrEmpty(txtpe4grade8.Text) Then Exit Sub
            If Not IsNumeric(txtpe1grade8.Text) OrElse Not IsNumeric(txtpe2grade8.Text) OrElse Not IsNumeric(txtpe3grade8.Text) OrElse Not IsNumeric(txtpe4grade8.Text) Then Exit Sub
            txtpefrgrade8.Text = Math.Round((CDbl(txtpe1grade8.Text) + CDbl(txtpe2grade8.Text) + CDbl(txtpe3grade8.Text) + CDbl(txtpe4grade8.Text)) / 4, 0)
            If txtpefrgrade8.Text.ToString >= 74.5 Then
                txtpeatgrade8.Text = "PASSED"
            Else
                txtpeatgrade8.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txthealthfrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txthealth1grade8.TextChanged, txthealth2grade8.TextChanged, txthealth3grade8.TextChanged, txthealth4grade8.TextChanged
        If txthealth1grade8.Text = "" Or txthealth2grade8.Text = "" Or txthealth3grade8.Text = "" Or txthealth4grade8.Text = "" Then
            txthealthfrgrade8.Text = 0
            txthealthatgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txthealth1grade8.Text) OrElse String.IsNullOrEmpty(txthealth2grade8.Text) OrElse String.IsNullOrEmpty(txthealth3grade8.Text) OrElse String.IsNullOrEmpty(txthealth4grade8.Text) Then Exit Sub
            If Not IsNumeric(txthealth1grade8.Text) OrElse Not IsNumeric(txthealth2grade8.Text) OrElse Not IsNumeric(txthealth3grade8.Text) OrElse Not IsNumeric(txthealth4grade8.Text) Then Exit Sub
            txthealthfrgrade8.Text = Math.Round((CDbl(txthealth1grade8.Text) + CDbl(txthealth2grade8.Text) + CDbl(txthealth3grade8.Text) + CDbl(txthealth4grade8.Text)) / 4, 0)
            If txthealthfrgrade8.Text.ToString >= 74.5 Then
                txthealthatgrade8.Text = "PASSED"
            Else
                txthealthatgrade8.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtaveragefrgrade8_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade8.TextChanged, txtenglishfrgrade8.TextChanged, txtmathfrgrade8.TextChanged, txtsciencefrgrade8.TextChanged, txtapfrgrade8.TextChanged, txtespfrgrade8.TextChanged, txttlefrgrade8.TextChanged, txtmapehfrgrade8.TextChanged
        If String.IsNullOrEmpty(txtfilipinofrgrade8.Text) OrElse String.IsNullOrEmpty(txtenglishfrgrade8.Text) OrElse String.IsNullOrEmpty(txtmathfrgrade8.Text) OrElse String.IsNullOrEmpty(txtsciencefrgrade8.Text) OrElse String.IsNullOrEmpty(txtapfrgrade8.Text) OrElse String.IsNullOrEmpty(txtespfrgrade8.Text) OrElse String.IsNullOrEmpty(txttlefrgrade8.Text) OrElse String.IsNullOrEmpty(txtmapehfrgrade8.Text) Then Exit Sub
        If Not IsNumeric(txtfilipinofrgrade8.Text) OrElse Not IsNumeric(txtenglishfrgrade8.Text) OrElse Not IsNumeric(txtmathfrgrade8.Text) OrElse Not IsNumeric(txtsciencefrgrade8.Text) OrElse Not IsNumeric(txtapfrgrade8.Text) OrElse Not IsNumeric(txtespfrgrade8.Text) OrElse Not IsNumeric(txttlefrgrade8.Text) OrElse Not IsNumeric(txtmapehfrgrade8.Text) Then Exit Sub
        txtaveragefrgrade8.Text = Math.Round((CDbl(txtfilipinofrgrade8.Text) + CDbl(txtenglishfrgrade8.Text) + CDbl(txtmathfrgrade8.Text) + CDbl(txtsciencefrgrade8.Text) + CDbl(txtapfrgrade8.Text) + CDbl(txtespfrgrade8.Text) + CDbl(txttlefrgrade8.Text) + CDbl(txtmapehfrgrade8.Text)) / 8, 2)
        If txtaveragefrgrade8.Text.ToString >= 74.5 Then
            txtaverageatgrade8.Text = "PASSED"
        Else
            txtaverageatgrade8.Text = "FAILED"
        End If
    End Sub
    Private Sub txtdsjungrade8_TextChanged(sender As Object, e As EventArgs) Handles txtdsjungrade8.TextChanged, txtdsjulgrade8.TextChanged, txtdsauggrade8.TextChanged, txtdssepgrade8.TextChanged, txtdsoctgrade8.TextChanged, txtdsnovgrade8.TextChanged, txtdsdecgrade8.TextChanged, txtdsjangrade8.TextChanged, txtdsfebgrade8.TextChanged, txtdsmargrade8.TextChanged, txtdsaprgrade8.TextChanged
        If txtdsjungrade8.Text = "" Or txtdsjulgrade8.Text = "" Or txtdsauggrade8.Text = "" Or txtdssepgrade8.Text = "" Or txtdsoctgrade8.Text = "" Or txtdsnovgrade8.Text = "" Or txtdsdecgrade8.Text = "" Or txtdsjangrade8.Text = "" Or txtdsfebgrade8.Text = "" Or txtdsmargrade8.Text = "" Or txtdsaprgrade8.Text = "" Then
            txtdstotalgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtdsjungrade8.Text) OrElse String.IsNullOrEmpty(txtdsjulgrade8.Text) OrElse String.IsNullOrEmpty(txtdsauggrade8.Text) OrElse String.IsNullOrEmpty(txtdssepgrade8.Text) OrElse String.IsNullOrEmpty(txtdsoctgrade8.Text) OrElse String.IsNullOrEmpty(txtdsnovgrade8.Text) OrElse String.IsNullOrEmpty(txtdsdecgrade8.Text) OrElse String.IsNullOrEmpty(txtdsjangrade8.Text) OrElse String.IsNullOrEmpty(txtdsfebgrade8.Text) OrElse String.IsNullOrEmpty(txtdsmargrade8.Text) OrElse String.IsNullOrEmpty(txtdsaprgrade8.Text) Then Exit Sub
            If Not IsNumeric(txtdsjungrade8.Text) OrElse Not IsNumeric(txtdsjulgrade8.Text) OrElse Not IsNumeric(txtdsauggrade8.Text) OrElse Not IsNumeric(txtdssepgrade8.Text) OrElse Not IsNumeric(txtdsoctgrade8.Text) OrElse Not IsNumeric(txtdsnovgrade8.Text) OrElse Not IsNumeric(txtdsdecgrade8.Text) OrElse Not IsNumeric(txtdsjangrade8.Text) OrElse Not IsNumeric(txtdsfebgrade8.Text) OrElse Not IsNumeric(txtdsmargrade8.Text) OrElse Not IsNumeric(txtdsaprgrade8.Text) Then Exit Sub
            txtdstotalgrade8.Text = (CDbl(txtdsjungrade8.Text) + CDbl(txtdsjulgrade8.Text) + CDbl(txtdsauggrade8.Text) + CDbl(txtdssepgrade8.Text) + CDbl(txtdsoctgrade8.Text) + CDbl(txtdsnovgrade8.Text) + CDbl(txtdsdecgrade8.Text) + CDbl(txtdsjangrade8.Text) + CDbl(txtdsfebgrade8.Text) + CDbl(txtdsmargrade8.Text) + CDbl(txtdsaprgrade8.Text))
        End If
    End Sub
    Private Sub txtdpjungrade8_TextChanged(sender As Object, e As EventArgs) Handles txtdpjungrade8.TextChanged, txtdpjulgrade8.TextChanged, txtdpauggrade8.TextChanged, txtdpsepgrade8.TextChanged, txtdpoctgrade8.TextChanged, txtdpnovgrade8.TextChanged, txtdpdecgrade8.TextChanged, txtdpjangrade8.TextChanged, txtdpfebgrade8.TextChanged, txtdpmargrade8.TextChanged, txtdpaprgrade8.TextChanged
        If txtdpjungrade8.Text = "" Or txtdpjulgrade8.Text = "" Or txtdpauggrade8.Text = "" Or txtdpsepgrade8.Text = "" Or txtdpoctgrade8.Text = "" Or txtdpnovgrade8.Text = "" Or txtdpdecgrade8.Text = "" Or txtdpjangrade8.Text = "" Or txtdpfebgrade8.Text = "" Or txtdpmargrade8.Text = "" Or txtdpaprgrade8.Text = "" Then
            txtdptotalgrade8.Text = ""
        Else
            If String.IsNullOrEmpty(txtdpjungrade8.Text) OrElse String.IsNullOrEmpty(txtdpjulgrade8.Text) OrElse String.IsNullOrEmpty(txtdpauggrade8.Text) OrElse String.IsNullOrEmpty(txtdpsepgrade8.Text) OrElse String.IsNullOrEmpty(txtdpoctgrade8.Text) OrElse String.IsNullOrEmpty(txtdpnovgrade8.Text) OrElse String.IsNullOrEmpty(txtdpdecgrade8.Text) OrElse String.IsNullOrEmpty(txtdpjangrade8.Text) OrElse String.IsNullOrEmpty(txtdpfebgrade8.Text) OrElse String.IsNullOrEmpty(txtdpmargrade8.Text) OrElse String.IsNullOrEmpty(txtdpaprgrade8.Text) Then Exit Sub
            If Not IsNumeric(txtdpjungrade8.Text) OrElse Not IsNumeric(txtdpjulgrade8.Text) OrElse Not IsNumeric(txtdpauggrade8.Text) OrElse Not IsNumeric(txtdpsepgrade8.Text) OrElse Not IsNumeric(txtdpoctgrade8.Text) OrElse Not IsNumeric(txtdpnovgrade8.Text) OrElse Not IsNumeric(txtdpdecgrade8.Text) OrElse Not IsNumeric(txtdpjangrade8.Text) OrElse Not IsNumeric(txtdpfebgrade8.Text) OrElse Not IsNumeric(txtdpmargrade8.Text) OrElse Not IsNumeric(txtdpaprgrade8.Text) Then Exit Sub
            txtdptotalgrade8.Text = (CDbl(txtdpjungrade8.Text) + CDbl(txtdpjulgrade8.Text) + CDbl(txtdpauggrade8.Text) + CDbl(txtdpsepgrade8.Text) + CDbl(txtdpoctgrade8.Text) + CDbl(txtdpnovgrade8.Text) + CDbl(txtdpdecgrade8.Text) + CDbl(txtdpjangrade8.Text) + CDbl(txtdpfebgrade8.Text) + CDbl(txtdpmargrade8.Text) + CDbl(txtdpaprgrade8.Text))
        End If
    End Sub
    Private Sub txtfilipino1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtfilipino1grade9.TextChanged, txtfilipino2grade9.TextChanged, txtfilipino3grade9.TextChanged, txtfilipino4grade9.TextChanged
        If txtfilipino1grade9.Text = "" Or txtfilipino2grade9.Text = "" Or txtfilipino3grade9.Text = "" Or txtfilipino4grade9.Text = "" Then
            txtfilipinofrgrade9.Text = 0
            txtfilipinoatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtfilipino1grade9.Text) OrElse String.IsNullOrEmpty(txtfilipino2grade9.Text) OrElse String.IsNullOrEmpty(txtfilipino3grade9.Text) OrElse String.IsNullOrEmpty(txtfilipino4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtfilipino1grade9.Text) OrElse Not IsNumeric(txtfilipino2grade9.Text) OrElse Not IsNumeric(txtfilipino3grade9.Text) OrElse Not IsNumeric(txtfilipino4grade9.Text) Then Exit Sub
            txtfilipinofrgrade9.Text = Math.Round((CDbl(txtfilipino1grade9.Text) + CDbl(txtfilipino2grade9.Text) + CDbl(txtfilipino3grade9.Text) + CDbl(txtfilipino4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtfilipinofrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade9.TextChanged
        If txtfilipinofrgrade9.Text.ToString >= 74.5 Then
            txtfilipinoatgrade9.Text = "PASSED"
        Else
            txtfilipinoatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtenglish1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtenglish1grade9.TextChanged, txtenglish2grade9.TextChanged, txtenglish3grade9.TextChanged, txtenglish4grade9.TextChanged
        If txtenglish1grade9.Text = "" Or txtenglish2grade9.Text = "" Or txtenglish3grade9.Text = "" Or txtenglish4grade9.Text = "" Then
            txtenglishfrgrade9.Text = 0
            txtenglishatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtenglish1grade9.Text) OrElse String.IsNullOrEmpty(txtenglish2grade9.Text) OrElse String.IsNullOrEmpty(txtenglish3grade9.Text) OrElse String.IsNullOrEmpty(txtenglish4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtenglish1grade9.Text) OrElse Not IsNumeric(txtenglish2grade9.Text) OrElse Not IsNumeric(txtenglish3grade9.Text) OrElse Not IsNumeric(txtenglish4grade9.Text) Then Exit Sub
            txtenglishfrgrade9.Text = Math.Round((CDbl(txtenglish1grade9.Text) + CDbl(txtenglish2grade9.Text) + CDbl(txtenglish3grade9.Text) + CDbl(txtenglish4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtenglishfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtenglishfrgrade9.TextChanged
        If txtenglishfrgrade9.Text.ToString >= 74.5 Then
            txtenglishatgrade9.Text = "PASSED"
        Else
            txtenglishatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmath1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtmath1grade9.TextChanged, txtmath2grade9.TextChanged, txtmath3grade9.TextChanged, txtmath4grade9.TextChanged
        If txtmath1grade9.Text = "" Or txtmath2grade9.Text = "" Or txtmath3grade9.Text = "" Or txtmath4grade9.Text = "" Then
            txtmathfrgrade9.Text = 0
            txtmathatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtmath1grade9.Text) OrElse String.IsNullOrEmpty(txtmath2grade9.Text) OrElse String.IsNullOrEmpty(txtmath3grade9.Text) OrElse String.IsNullOrEmpty(txtmath4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtmath1grade9.Text) OrElse Not IsNumeric(txtmath2grade9.Text) OrElse Not IsNumeric(txtmath3grade9.Text) OrElse Not IsNumeric(txtmath4grade9.Text) Then Exit Sub
            txtmathfrgrade9.Text = Math.Round((CDbl(txtmath1grade9.Text) + CDbl(txtmath2grade9.Text) + CDbl(txtmath3grade9.Text) + CDbl(txtmath4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmathfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtmathfrgrade9.TextChanged
        If txtmathfrgrade9.Text.ToString >= 74.5 Then
            txtmathatgrade9.Text = "PASSED"
        Else
            txtmathatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtscience1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtscience1grade9.TextChanged, txtscience2grade9.TextChanged, txtscience3grade9.TextChanged, txtscience4grade9.TextChanged
        If txtscience1grade9.Text = "" Or txtscience2grade9.Text = "" Or txtscience3grade9.Text = "" Or txtscience4grade9.Text = "" Then
            txtsciencefrgrade9.Text = 0
            txtscienceatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtscience1grade9.Text) OrElse String.IsNullOrEmpty(txtscience2grade9.Text) OrElse String.IsNullOrEmpty(txtscience3grade9.Text) OrElse String.IsNullOrEmpty(txtscience4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtscience1grade9.Text) OrElse Not IsNumeric(txtscience2grade9.Text) OrElse Not IsNumeric(txtscience3grade9.Text) OrElse Not IsNumeric(txtscience4grade9.Text) Then Exit Sub
            txtsciencefrgrade9.Text = Math.Round((CDbl(txtscience1grade9.Text) + CDbl(txtscience2grade9.Text) + CDbl(txtscience3grade9.Text) + CDbl(txtscience4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtsciencefrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtsciencefrgrade9.TextChanged
        If txtsciencefrgrade9.Text.ToString >= 74.5 Then
            txtscienceatgrade9.Text = "PASSED"
        Else
            txtscienceatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtap1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtap1grade9.TextChanged, txtap2grade9.TextChanged, txtap3grade9.TextChanged, txtap4grade9.TextChanged
        If txtap1grade9.Text = "" Or txtap2grade9.Text = "" Or txtap3grade9.Text = "" Or txtap4grade9.Text = "" Then
            txtapfrgrade9.Text = 0
            txtapatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtap1grade9.Text) OrElse String.IsNullOrEmpty(txtap2grade9.Text) OrElse String.IsNullOrEmpty(txtap3grade9.Text) OrElse String.IsNullOrEmpty(txtap4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtap1grade9.Text) OrElse Not IsNumeric(txtap2grade9.Text) OrElse Not IsNumeric(txtap3grade9.Text) OrElse Not IsNumeric(txtap4grade9.Text) Then Exit Sub
            txtapfrgrade9.Text = Math.Round((CDbl(txtap1grade9.Text) + CDbl(txtap2grade9.Text) + CDbl(txtap3grade9.Text) + CDbl(txtap4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtapfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtapfrgrade9.TextChanged
        If txtapfrgrade9.Text.ToString >= 74.5 Then
            txtapatgrade9.Text = "PASSED"
        Else
            txtapatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtesp1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtesp1grade9.TextChanged, txtesp2grade9.TextChanged, txtesp3grade9.TextChanged, txtesp4grade9.TextChanged
        If txtesp1grade9.Text = "" Or txtesp2grade9.Text = "" Or txtesp3grade9.Text = "" Or txtesp4grade9.Text = "" Then
            txtespfrgrade9.Text = 0
            txtespatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtesp1grade9.Text) OrElse String.IsNullOrEmpty(txtesp2grade9.Text) OrElse String.IsNullOrEmpty(txtesp3grade9.Text) OrElse String.IsNullOrEmpty(txtesp4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtesp1grade9.Text) OrElse Not IsNumeric(txtesp2grade9.Text) OrElse Not IsNumeric(txtesp3grade9.Text) OrElse Not IsNumeric(txtesp4grade9.Text) Then Exit Sub
            txtespfrgrade9.Text = Math.Round((CDbl(txtesp1grade9.Text) + CDbl(txtesp2grade9.Text) + CDbl(txtesp3grade9.Text) + CDbl(txtesp4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtespfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtespfrgrade9.TextChanged
        If txtespfrgrade9.Text.ToString >= 74.5 Then
            txtespatgrade9.Text = "PASSED"
        Else
            txtespatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txttle1grade9_TextChanged(sender As Object, e As EventArgs) Handles txttle1grade9.TextChanged, txttle2grade9.TextChanged, txttle3grade9.TextChanged, txttle4grade9.TextChanged
        If txttle1grade9.Text = "" Or txttle2grade9.Text = "" Or txttle3grade9.Text = "" Or txttle4grade9.Text = "" Then
            txttlefrgrade9.Text = 0
            txttleatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txttle1grade9.Text) OrElse String.IsNullOrEmpty(txttle2grade9.Text) OrElse String.IsNullOrEmpty(txttle3grade9.Text) OrElse String.IsNullOrEmpty(txttle4grade9.Text) Then Exit Sub
            If Not IsNumeric(txttle1grade9.Text) OrElse Not IsNumeric(txttle2grade9.Text) OrElse Not IsNumeric(txttle3grade9.Text) OrElse Not IsNumeric(txttle4grade9.Text) Then Exit Sub
            txttlefrgrade9.Text = Math.Round((CDbl(txttle1grade9.Text) + CDbl(txttle2grade9.Text) + CDbl(txttle3grade9.Text) + CDbl(txttle4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txttlefrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txttlefrgrade9.TextChanged
        If txttlefrgrade9.Text.ToString >= 74.5 Then
            txttleatgrade9.Text = "PASSED"
        Else
            txttleatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmapeh1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtmapeh1grade9.TextChanged, txtmapeh2grade9.TextChanged, txtmapeh3grade9.TextChanged, txtmapeh4grade9.TextChanged
        If txtmapeh1grade9.Text = "" Or txtmapeh2grade9.Text = "" Or txtmapeh3grade9.Text = "" Or txtmapeh4grade9.Text = "" Then
            txtmapehfrgrade9.Text = 0
            txtmapehatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtmapeh1grade9.Text) OrElse String.IsNullOrEmpty(txtmapeh2grade9.Text) OrElse String.IsNullOrEmpty(txtmapeh3grade9.Text) OrElse String.IsNullOrEmpty(txtmapeh4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtmapeh1grade9.Text) OrElse Not IsNumeric(txtmapeh2grade9.Text) OrElse Not IsNumeric(txtmapeh3grade9.Text) OrElse Not IsNumeric(txtmapeh4grade9.Text) Then Exit Sub
            txtmapehfrgrade9.Text = Math.Round((CDbl(txtmapeh1grade9.Text) + CDbl(txtmapeh2grade9.Text) + CDbl(txtmapeh3grade9.Text) + CDbl(txtmapeh4grade9.Text)) / 4, 0)
        End If
    End Sub

    Private Sub txtmapehfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtmapehfrgrade9.TextChanged
        If txtmapehfrgrade9.Text.ToString >= 74.5 Then
            txtmapehatgrade9.Text = "PASSED"
        Else
            txtmapehatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmusic1grade9_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade9.TextChanged, txtarts1grade9.TextChanged, txtpe1grade9.TextChanged, txthealth1grade9.TextChanged
        If txtmusic1grade9.Text = "" Or txtarts1grade9.Text = "" Or txtpe1grade9.Text = "" Or txthealth1grade9.Text = "" Then
            txtmapeh1grade9.Text = 0
            txtmapehatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade9.Text) OrElse String.IsNullOrEmpty(txtarts1grade9.Text) OrElse String.IsNullOrEmpty(txtpe1grade9.Text) OrElse String.IsNullOrEmpty(txthealth1grade9.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade9.Text) OrElse Not IsNumeric(txtarts1grade9.Text) OrElse Not IsNumeric(txtpe1grade9.Text) OrElse Not IsNumeric(txthealth1grade9.Text) Then Exit Sub
            txtmapeh1grade9.Text = Math.Round((CDbl(txtmusic1grade9.Text) + CDbl(txtarts1grade9.Text) + CDbl(txtpe1grade9.Text) + CDbl(txthealth1grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic2grade9_TextChanged(sender As Object, e As EventArgs) Handles txtmusic2grade9.TextChanged, txtarts2grade9.TextChanged, txtpe2grade9.TextChanged, txthealth2grade9.TextChanged
        If txtmusic2grade9.Text = "" Or txtarts2grade9.Text = "" Or txtpe2grade9.Text = "" Or txthealth2grade9.Text = "" Then
            txtmapeh2grade9.Text = 0
            txtmapehatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic2grade9.Text) OrElse String.IsNullOrEmpty(txtarts2grade9.Text) OrElse String.IsNullOrEmpty(txtpe2grade9.Text) OrElse String.IsNullOrEmpty(txthealth2grade9.Text) Then Exit Sub
            If Not IsNumeric(txtmusic2grade9.Text) OrElse Not IsNumeric(txtarts2grade9.Text) OrElse Not IsNumeric(txtpe2grade9.Text) OrElse Not IsNumeric(txthealth2grade9.Text) Then Exit Sub
            txtmapeh2grade9.Text = Math.Round((CDbl(txtmusic2grade9.Text) + CDbl(txtarts2grade9.Text) + CDbl(txtpe2grade9.Text) + CDbl(txthealth2grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic3grade9_TextChanged(sender As Object, e As EventArgs) Handles txtmusic3grade9.TextChanged, txtarts3grade9.TextChanged, txtpe3grade9.TextChanged, txthealth3grade9.TextChanged
        If txtmusic3grade9.Text = "" Or txtarts3grade9.Text = "" Or txtpe3grade9.Text = "" Or txthealth3grade9.Text = "" Then
            txtmapeh3grade9.Text = 0
            txtmapehatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic3grade9.Text) OrElse String.IsNullOrEmpty(txtarts3grade9.Text) OrElse String.IsNullOrEmpty(txtpe3grade9.Text) OrElse String.IsNullOrEmpty(txthealth3grade9.Text) Then Exit Sub
            If Not IsNumeric(txtmusic3grade9.Text) OrElse Not IsNumeric(txtarts3grade9.Text) OrElse Not IsNumeric(txtpe3grade9.Text) OrElse Not IsNumeric(txthealth3grade9.Text) Then Exit Sub
            txtmapeh3grade9.Text = Math.Round((CDbl(txtmusic3grade9.Text) + CDbl(txtarts3grade9.Text) + CDbl(txtpe3grade9.Text) + CDbl(txthealth3grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic4grade9_TextChanged(sender As Object, e As EventArgs) Handles txtmusic4grade9.TextChanged, txtarts4grade9.TextChanged, txtpe4grade9.TextChanged, txthealth4grade9.TextChanged
        If txtmusic4grade9.Text = "" Or txtarts4grade9.Text = "" Or txtpe4grade9.Text = "" Or txthealth4grade9.Text = "" Then
            txtmapeh4grade9.Text = 0
            txtmapehatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic4grade9.Text) OrElse String.IsNullOrEmpty(txtarts4grade9.Text) OrElse String.IsNullOrEmpty(txtpe4grade9.Text) OrElse String.IsNullOrEmpty(txthealth4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtmusic4grade9.Text) OrElse Not IsNumeric(txtarts4grade9.Text) OrElse Not IsNumeric(txtpe4grade9.Text) OrElse Not IsNumeric(txthealth4grade9.Text) Then Exit Sub
            txtmapeh4grade9.Text = Math.Round((CDbl(txtmusic4grade9.Text) + CDbl(txtarts4grade9.Text) + CDbl(txtpe4grade9.Text) + CDbl(txthealth4grade9.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusicfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade9.TextChanged, txtmusic2grade9.TextChanged, txtmusic3grade9.TextChanged, txtmusic4grade9.TextChanged
        If txtmusic1grade9.Text = "" Or txtmusic2grade9.Text = "" Or txtmusic3grade9.Text = "" Or txtmusic4grade9.Text = "" Then
            txtmusicfrgrade9.Text = 0
            txtmusicatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade9.Text) OrElse String.IsNullOrEmpty(txtmusic2grade9.Text) OrElse String.IsNullOrEmpty(txtmusic3grade9.Text) OrElse String.IsNullOrEmpty(txtmusic4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade9.Text) OrElse Not IsNumeric(txtmusic2grade9.Text) OrElse Not IsNumeric(txtmusic3grade9.Text) OrElse Not IsNumeric(txtmusic4grade9.Text) Then Exit Sub
            txtmusicfrgrade9.Text = Math.Round((CDbl(txtmusic1grade9.Text) + CDbl(txtmusic2grade9.Text) + CDbl(txtmusic3grade9.Text) + CDbl(txtmusic4grade9.Text)) / 4, 0)
            If txtmusicfrgrade9.Text.ToString >= 74.5 Then
                txtmusicatgrade9.Text = "PASSED"
            Else
                txtmusicatgrade9.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtartsfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtarts1grade9.TextChanged, txtarts2grade9.TextChanged, txtarts3grade9.TextChanged, txtarts4grade9.TextChanged
        If txtarts1grade9.Text = "" Or txtarts2grade9.Text = "" Or txtarts3grade9.Text = "" Or txtarts4grade9.Text = "" Then
            txtartsfrgrade9.Text = 0
            txtartsatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtarts1grade9.Text) OrElse String.IsNullOrEmpty(txtarts2grade9.Text) OrElse String.IsNullOrEmpty(txtarts3grade9.Text) OrElse String.IsNullOrEmpty(txtarts4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtarts1grade9.Text) OrElse Not IsNumeric(txtarts2grade9.Text) OrElse Not IsNumeric(txtarts3grade9.Text) OrElse Not IsNumeric(txtarts4grade9.Text) Then Exit Sub
            txtartsfrgrade9.Text = Math.Round((CDbl(txtarts1grade9.Text) + CDbl(txtarts2grade9.Text) + CDbl(txtarts3grade9.Text) + CDbl(txtarts4grade9.Text)) / 4, 0)
            If txtartsfrgrade9.Text.ToString >= 74.5 Then
                txtartsatgrade9.Text = "PASSED"
            Else
                txtartsatgrade9.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtpefrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtpe1grade9.TextChanged, txtpe2grade9.TextChanged, txtpe3grade9.TextChanged, txtpe4grade9.TextChanged
        If txtpe1grade9.Text = "" Or txtpe2grade9.Text = "" Or txtpe3grade9.Text = "" Or txtpe4grade9.Text = "" Then
            txtpefrgrade9.Text = 0
            txtpeatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtpe1grade9.Text) OrElse String.IsNullOrEmpty(txtpe2grade9.Text) OrElse String.IsNullOrEmpty(txtpe3grade9.Text) OrElse String.IsNullOrEmpty(txtpe4grade9.Text) Then Exit Sub
            If Not IsNumeric(txtpe1grade9.Text) OrElse Not IsNumeric(txtpe2grade9.Text) OrElse Not IsNumeric(txtpe3grade9.Text) OrElse Not IsNumeric(txtpe4grade9.Text) Then Exit Sub
            txtpefrgrade9.Text = Math.Round((CDbl(txtpe1grade9.Text) + CDbl(txtpe2grade9.Text) + CDbl(txtpe3grade9.Text) + CDbl(txtpe4grade9.Text)) / 4, 0)
            If txtpefrgrade9.Text.ToString >= 74.5 Then
                txtpeatgrade9.Text = "PASSED"
            Else
                txtpeatgrade9.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txthealthfrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txthealth1grade9.TextChanged, txthealth2grade9.TextChanged, txthealth3grade9.TextChanged, txthealth4grade9.TextChanged
        If txthealth1grade9.Text = "" Or txthealth2grade9.Text = "" Or txthealth3grade9.Text = "" Or txthealth4grade9.Text = "" Then
            txthealthfrgrade9.Text = 0
            txthealthatgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txthealth1grade9.Text) OrElse String.IsNullOrEmpty(txthealth2grade9.Text) OrElse String.IsNullOrEmpty(txthealth3grade9.Text) OrElse String.IsNullOrEmpty(txthealth4grade9.Text) Then Exit Sub
            If Not IsNumeric(txthealth1grade9.Text) OrElse Not IsNumeric(txthealth2grade9.Text) OrElse Not IsNumeric(txthealth3grade9.Text) OrElse Not IsNumeric(txthealth4grade9.Text) Then Exit Sub
            txthealthfrgrade9.Text = Math.Round((CDbl(txthealth1grade9.Text) + CDbl(txthealth2grade9.Text) + CDbl(txthealth3grade9.Text) + CDbl(txthealth4grade9.Text)) / 4, 0)
            If txthealthfrgrade9.Text.ToString >= 74.5 Then
                txthealthatgrade9.Text = "PASSED"
            Else
                txthealthatgrade9.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtaveragefrgrade9_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade9.TextChanged, txtenglishfrgrade9.TextChanged, txtmathfrgrade9.TextChanged, txtsciencefrgrade9.TextChanged, txtapfrgrade9.TextChanged, txtespfrgrade9.TextChanged, txttlefrgrade9.TextChanged, txtmapehfrgrade9.TextChanged
        If String.IsNullOrEmpty(txtfilipinofrgrade9.Text) OrElse String.IsNullOrEmpty(txtenglishfrgrade9.Text) OrElse String.IsNullOrEmpty(txtmathfrgrade9.Text) OrElse String.IsNullOrEmpty(txtsciencefrgrade9.Text) OrElse String.IsNullOrEmpty(txtapfrgrade9.Text) OrElse String.IsNullOrEmpty(txtespfrgrade9.Text) OrElse String.IsNullOrEmpty(txttlefrgrade9.Text) OrElse String.IsNullOrEmpty(txtmapehfrgrade9.Text) Then Exit Sub
        If Not IsNumeric(txtfilipinofrgrade9.Text) OrElse Not IsNumeric(txtenglishfrgrade9.Text) OrElse Not IsNumeric(txtmathfrgrade9.Text) OrElse Not IsNumeric(txtsciencefrgrade9.Text) OrElse Not IsNumeric(txtapfrgrade9.Text) OrElse Not IsNumeric(txtespfrgrade9.Text) OrElse Not IsNumeric(txttlefrgrade9.Text) OrElse Not IsNumeric(txtmapehfrgrade9.Text) Then Exit Sub
        txtaveragefrgrade9.Text = Math.Round((CDbl(txtfilipinofrgrade9.Text) + CDbl(txtenglishfrgrade9.Text) + CDbl(txtmathfrgrade9.Text) + CDbl(txtsciencefrgrade9.Text) + CDbl(txtapfrgrade9.Text) + CDbl(txtespfrgrade9.Text) + CDbl(txttlefrgrade9.Text) + CDbl(txtmapehfrgrade9.Text)) / 8, 2)
        If txtaveragefrgrade9.Text.ToString >= 74.5 Then
            txtaverageatgrade9.Text = "PASSED"
        Else
            txtaverageatgrade9.Text = "FAILED"
        End If
    End Sub
    Private Sub txtdsjungrade9_TextChanged(sender As Object, e As EventArgs) Handles txtdsjungrade9.TextChanged, txtdsjulgrade9.TextChanged, txtdsauggrade9.TextChanged, txtdssepgrade9.TextChanged, txtdsoctgrade9.TextChanged, txtdsnovgrade9.TextChanged, txtdsdecgrade9.TextChanged, txtdsjangrade9.TextChanged, txtdsfebgrade9.TextChanged, txtdsmargrade9.TextChanged, txtdsaprgrade9.TextChanged
        If txtdsjungrade9.Text = "" Or txtdsjulgrade9.Text = "" Or txtdsauggrade9.Text = "" Or txtdssepgrade9.Text = "" Or txtdsoctgrade9.Text = "" Or txtdsnovgrade9.Text = "" Or txtdsdecgrade9.Text = "" Or txtdsjangrade9.Text = "" Or txtdsfebgrade9.Text = "" Or txtdsmargrade9.Text = "" Or txtdsaprgrade9.Text = "" Then
            txtdstotalgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtdsjungrade9.Text) OrElse String.IsNullOrEmpty(txtdsjulgrade9.Text) OrElse String.IsNullOrEmpty(txtdsauggrade9.Text) OrElse String.IsNullOrEmpty(txtdssepgrade9.Text) OrElse String.IsNullOrEmpty(txtdsoctgrade9.Text) OrElse String.IsNullOrEmpty(txtdsnovgrade9.Text) OrElse String.IsNullOrEmpty(txtdsdecgrade9.Text) OrElse String.IsNullOrEmpty(txtdsjangrade9.Text) OrElse String.IsNullOrEmpty(txtdsfebgrade9.Text) OrElse String.IsNullOrEmpty(txtdsmargrade9.Text) OrElse String.IsNullOrEmpty(txtdsaprgrade9.Text) Then Exit Sub
            If Not IsNumeric(txtdsjungrade9.Text) OrElse Not IsNumeric(txtdsjulgrade9.Text) OrElse Not IsNumeric(txtdsauggrade9.Text) OrElse Not IsNumeric(txtdssepgrade9.Text) OrElse Not IsNumeric(txtdsoctgrade9.Text) OrElse Not IsNumeric(txtdsnovgrade9.Text) OrElse Not IsNumeric(txtdsdecgrade9.Text) OrElse Not IsNumeric(txtdsjangrade9.Text) OrElse Not IsNumeric(txtdsfebgrade9.Text) OrElse Not IsNumeric(txtdsmargrade9.Text) OrElse Not IsNumeric(txtdsaprgrade9.Text) Then Exit Sub
            txtdstotalgrade9.Text = (CDbl(txtdsjungrade9.Text) + CDbl(txtdsjulgrade9.Text) + CDbl(txtdsauggrade9.Text) + CDbl(txtdssepgrade9.Text) + CDbl(txtdsoctgrade9.Text) + CDbl(txtdsnovgrade9.Text) + CDbl(txtdsdecgrade9.Text) + CDbl(txtdsjangrade9.Text) + CDbl(txtdsfebgrade9.Text) + CDbl(txtdsmargrade9.Text) + CDbl(txtdsaprgrade9.Text))
        End If
    End Sub
    Private Sub txtdpjungrade9_TextChanged(sender As Object, e As EventArgs) Handles txtdpjungrade9.TextChanged, txtdpjulgrade9.TextChanged, txtdpauggrade9.TextChanged, txtdpsepgrade9.TextChanged, txtdpoctgrade9.TextChanged, txtdpnovgrade9.TextChanged, txtdpdecgrade9.TextChanged, txtdpjangrade9.TextChanged, txtdpfebgrade9.TextChanged, txtdpmargrade9.TextChanged, txtdpaprgrade9.TextChanged
        If txtdpjungrade9.Text = "" Or txtdpjulgrade9.Text = "" Or txtdpauggrade9.Text = "" Or txtdpsepgrade9.Text = "" Or txtdpoctgrade9.Text = "" Or txtdpnovgrade9.Text = "" Or txtdpdecgrade9.Text = "" Or txtdpjangrade9.Text = "" Or txtdpfebgrade9.Text = "" Or txtdpmargrade9.Text = "" Or txtdpaprgrade9.Text = "" Then
            txtdptotalgrade9.Text = ""
        Else
            If String.IsNullOrEmpty(txtdpjungrade9.Text) OrElse String.IsNullOrEmpty(txtdpjulgrade9.Text) OrElse String.IsNullOrEmpty(txtdpauggrade9.Text) OrElse String.IsNullOrEmpty(txtdpsepgrade9.Text) OrElse String.IsNullOrEmpty(txtdpoctgrade9.Text) OrElse String.IsNullOrEmpty(txtdpnovgrade9.Text) OrElse String.IsNullOrEmpty(txtdpdecgrade9.Text) OrElse String.IsNullOrEmpty(txtdpjangrade9.Text) OrElse String.IsNullOrEmpty(txtdpfebgrade9.Text) OrElse String.IsNullOrEmpty(txtdpmargrade9.Text) OrElse String.IsNullOrEmpty(txtdpaprgrade9.Text) Then Exit Sub
            If Not IsNumeric(txtdpjungrade9.Text) OrElse Not IsNumeric(txtdpjulgrade9.Text) OrElse Not IsNumeric(txtdpauggrade9.Text) OrElse Not IsNumeric(txtdpsepgrade9.Text) OrElse Not IsNumeric(txtdpoctgrade9.Text) OrElse Not IsNumeric(txtdpnovgrade9.Text) OrElse Not IsNumeric(txtdpdecgrade9.Text) OrElse Not IsNumeric(txtdpjangrade9.Text) OrElse Not IsNumeric(txtdpfebgrade9.Text) OrElse Not IsNumeric(txtdpmargrade9.Text) OrElse Not IsNumeric(txtdpaprgrade9.Text) Then Exit Sub
            txtdptotalgrade9.Text = (CDbl(txtdpjungrade9.Text) + CDbl(txtdpjulgrade9.Text) + CDbl(txtdpauggrade9.Text) + CDbl(txtdpsepgrade9.Text) + CDbl(txtdpoctgrade9.Text) + CDbl(txtdpnovgrade9.Text) + CDbl(txtdpdecgrade9.Text) + CDbl(txtdpjangrade9.Text) + CDbl(txtdpfebgrade9.Text) + CDbl(txtdpmargrade9.Text) + CDbl(txtdpaprgrade9.Text))
        End If
    End Sub
    Private Sub txtfilipino1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtfilipino1grade10.TextChanged, txtfilipino2grade10.TextChanged, txtfilipino3grade10.TextChanged, txtfilipino4grade10.TextChanged
        If txtfilipino1grade10.Text = "" Or txtfilipino2grade10.Text = "" Or txtfilipino3grade10.Text = "" Or txtfilipino4grade10.Text = "" Then
            txtfilipinofrgrade10.Text = 0
            txtfilipinoatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtfilipino1grade10.Text) OrElse String.IsNullOrEmpty(txtfilipino2grade10.Text) OrElse String.IsNullOrEmpty(txtfilipino3grade10.Text) OrElse String.IsNullOrEmpty(txtfilipino4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtfilipino1grade10.Text) OrElse Not IsNumeric(txtfilipino2grade10.Text) OrElse Not IsNumeric(txtfilipino3grade10.Text) OrElse Not IsNumeric(txtfilipino4grade10.Text) Then Exit Sub
            txtfilipinofrgrade10.Text = Math.Round((CDbl(txtfilipino1grade10.Text) + CDbl(txtfilipino2grade10.Text) + CDbl(txtfilipino3grade10.Text) + CDbl(txtfilipino4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtfilipinofrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade10.TextChanged
        If txtfilipinofrgrade10.Text.ToString >= 74.5 Then
            txtfilipinoatgrade10.Text = "PASSED"
        Else
            txtfilipinoatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtenglish1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtenglish1grade10.TextChanged, txtenglish2grade10.TextChanged, txtenglish3grade10.TextChanged, txtenglish4grade10.TextChanged
        If txtenglish1grade10.Text = "" Or txtenglish2grade10.Text = "" Or txtenglish3grade10.Text = "" Or txtenglish4grade10.Text = "" Then
            txtenglishfrgrade10.Text = 0
            txtenglishatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtenglish1grade10.Text) OrElse String.IsNullOrEmpty(txtenglish2grade10.Text) OrElse String.IsNullOrEmpty(txtenglish3grade10.Text) OrElse String.IsNullOrEmpty(txtenglish4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtenglish1grade10.Text) OrElse Not IsNumeric(txtenglish2grade10.Text) OrElse Not IsNumeric(txtenglish3grade10.Text) OrElse Not IsNumeric(txtenglish4grade10.Text) Then Exit Sub
            txtenglishfrgrade10.Text = Math.Round((CDbl(txtenglish1grade10.Text) + CDbl(txtenglish2grade10.Text) + CDbl(txtenglish3grade10.Text) + CDbl(txtenglish4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtenglishfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtenglishfrgrade10.TextChanged
        If txtenglishfrgrade10.Text.ToString >= 74.5 Then
            txtenglishatgrade10.Text = "PASSED"
        Else
            txtenglishatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmath1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtmath1grade10.TextChanged, txtmath2grade10.TextChanged, txtmath3grade10.TextChanged, txtmath4grade10.TextChanged
        If txtmath1grade10.Text = "" Or txtmath2grade10.Text = "" Or txtmath3grade10.Text = "" Or txtmath4grade10.Text = "" Then
            txtmathfrgrade10.Text = 0
            txtmathatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtmath1grade10.Text) OrElse String.IsNullOrEmpty(txtmath2grade10.Text) OrElse String.IsNullOrEmpty(txtmath3grade10.Text) OrElse String.IsNullOrEmpty(txtmath4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtmath1grade10.Text) OrElse Not IsNumeric(txtmath2grade10.Text) OrElse Not IsNumeric(txtmath3grade10.Text) OrElse Not IsNumeric(txtmath4grade10.Text) Then Exit Sub
            txtmathfrgrade10.Text = Math.Round((CDbl(txtmath1grade10.Text) + CDbl(txtmath2grade10.Text) + CDbl(txtmath3grade10.Text) + CDbl(txtmath4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmathfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtmathfrgrade10.TextChanged
        If txtmathfrgrade10.Text.ToString >= 74.5 Then
            txtmathatgrade10.Text = "PASSED"
        Else
            txtmathatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtscience1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtscience1grade10.TextChanged, txtscience2grade10.TextChanged, txtscience3grade10.TextChanged, txtscience4grade10.TextChanged
        If txtscience1grade10.Text = "" Or txtscience2grade10.Text = "" Or txtscience3grade10.Text = "" Or txtscience4grade10.Text = "" Then
            txtsciencefrgrade10.Text = 0
            txtscienceatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtscience1grade10.Text) OrElse String.IsNullOrEmpty(txtscience2grade10.Text) OrElse String.IsNullOrEmpty(txtscience3grade10.Text) OrElse String.IsNullOrEmpty(txtscience4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtscience1grade10.Text) OrElse Not IsNumeric(txtscience2grade10.Text) OrElse Not IsNumeric(txtscience3grade10.Text) OrElse Not IsNumeric(txtscience4grade10.Text) Then Exit Sub
            txtsciencefrgrade10.Text = Math.Round((CDbl(txtscience1grade10.Text) + CDbl(txtscience2grade10.Text) + CDbl(txtscience3grade10.Text) + CDbl(txtscience4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtsciencefrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtsciencefrgrade10.TextChanged
        If txtsciencefrgrade10.Text.ToString >= 74.5 Then
            txtscienceatgrade10.Text = "PASSED"
        Else
            txtscienceatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtap1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtap1grade10.TextChanged, txtap2grade10.TextChanged, txtap3grade10.TextChanged, txtap4grade10.TextChanged
        If txtap1grade10.Text = "" Or txtap2grade10.Text = "" Or txtap3grade10.Text = "" Or txtap4grade10.Text = "" Then
            txtapfrgrade10.Text = 0
            txtapatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtap1grade10.Text) OrElse String.IsNullOrEmpty(txtap2grade10.Text) OrElse String.IsNullOrEmpty(txtap3grade10.Text) OrElse String.IsNullOrEmpty(txtap4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtap1grade10.Text) OrElse Not IsNumeric(txtap2grade10.Text) OrElse Not IsNumeric(txtap3grade10.Text) OrElse Not IsNumeric(txtap4grade10.Text) Then Exit Sub
            txtapfrgrade10.Text = Math.Round((CDbl(txtap1grade10.Text) + CDbl(txtap2grade10.Text) + CDbl(txtap3grade10.Text) + CDbl(txtap4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtapfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtapfrgrade10.TextChanged
        If txtapfrgrade10.Text.ToString >= 74.5 Then
            txtapatgrade10.Text = "PASSED"
        Else
            txtapatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtesp1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtesp1grade10.TextChanged, txtesp2grade10.TextChanged, txtesp3grade10.TextChanged, txtesp4grade10.TextChanged
        If txtesp1grade10.Text = "" Or txtesp2grade10.Text = "" Or txtesp3grade10.Text = "" Or txtesp4grade10.Text = "" Then
            txtespfrgrade10.Text = 0
            txtespatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtesp1grade10.Text) OrElse String.IsNullOrEmpty(txtesp2grade10.Text) OrElse String.IsNullOrEmpty(txtesp3grade10.Text) OrElse String.IsNullOrEmpty(txtesp4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtesp1grade10.Text) OrElse Not IsNumeric(txtesp2grade10.Text) OrElse Not IsNumeric(txtesp3grade10.Text) OrElse Not IsNumeric(txtesp4grade10.Text) Then Exit Sub
            txtespfrgrade10.Text = Math.Round((CDbl(txtesp1grade10.Text) + CDbl(txtesp2grade10.Text) + CDbl(txtesp3grade10.Text) + CDbl(txtesp4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtespfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtespfrgrade10.TextChanged
        If txtespfrgrade10.Text.ToString >= 74.5 Then
            txtespatgrade10.Text = "PASSED"
        Else
            txtespatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txttle1grade10_TextChanged(sender As Object, e As EventArgs) Handles txttle1grade10.TextChanged, txttle2grade10.TextChanged, txttle3grade10.TextChanged, txttle4grade10.TextChanged
        If txttle1grade10.Text = "" Or txttle2grade10.Text = "" Or txttle3grade10.Text = "" Or txttle4grade10.Text = "" Then
            txttlefrgrade10.Text = 0
            txttleatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txttle1grade10.Text) OrElse String.IsNullOrEmpty(txttle2grade10.Text) OrElse String.IsNullOrEmpty(txttle3grade10.Text) OrElse String.IsNullOrEmpty(txttle4grade10.Text) Then Exit Sub
            If Not IsNumeric(txttle1grade10.Text) OrElse Not IsNumeric(txttle2grade10.Text) OrElse Not IsNumeric(txttle3grade10.Text) OrElse Not IsNumeric(txttle4grade10.Text) Then Exit Sub
            txttlefrgrade10.Text = Math.Round((CDbl(txttle1grade10.Text) + CDbl(txttle2grade10.Text) + CDbl(txttle3grade10.Text) + CDbl(txttle4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txttlefrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txttlefrgrade10.TextChanged
        If txttlefrgrade10.Text.ToString >= 74.5 Then
            txttleatgrade10.Text = "PASSED"
        Else
            txttleatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmapeh1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtmapeh1grade10.TextChanged, txtmapeh2grade10.TextChanged, txtmapeh3grade10.TextChanged, txtmapeh4grade10.TextChanged
        If txtmapeh1grade10.Text = "" Or txtmapeh2grade10.Text = "" Or txtmapeh3grade10.Text = "" Or txtmapeh4grade10.Text = "" Then
            txtmapehfrgrade10.Text = 0
            txtmapehatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtmapeh1grade10.Text) OrElse String.IsNullOrEmpty(txtmapeh2grade10.Text) OrElse String.IsNullOrEmpty(txtmapeh3grade10.Text) OrElse String.IsNullOrEmpty(txtmapeh4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtmapeh1grade10.Text) OrElse Not IsNumeric(txtmapeh2grade10.Text) OrElse Not IsNumeric(txtmapeh3grade10.Text) OrElse Not IsNumeric(txtmapeh4grade10.Text) Then Exit Sub
            txtmapehfrgrade10.Text = Math.Round((CDbl(txtmapeh1grade10.Text) + CDbl(txtmapeh2grade10.Text) + CDbl(txtmapeh3grade10.Text) + CDbl(txtmapeh4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmapehfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtmapehfrgrade10.TextChanged
        If txtmapehfrgrade10.Text.ToString >= 74.5 Then
            txtmapehatgrade10.Text = "PASSED"
        Else
            txtmapehatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtmusic1grade10_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade10.TextChanged, txtarts1grade10.TextChanged, txtpe1grade10.TextChanged, txthealth1grade10.TextChanged
        If txtmusic1grade10.Text = "" Or txtarts1grade10.Text = "" Or txtpe1grade10.Text = "" Or txthealth1grade10.Text = "" Then
            txtmapeh1grade10.Text = 0
            txtmapehatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade10.Text) OrElse String.IsNullOrEmpty(txtarts1grade10.Text) OrElse String.IsNullOrEmpty(txtpe1grade10.Text) OrElse String.IsNullOrEmpty(txthealth1grade10.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade10.Text) OrElse Not IsNumeric(txtarts1grade10.Text) OrElse Not IsNumeric(txtpe1grade10.Text) OrElse Not IsNumeric(txthealth1grade10.Text) Then Exit Sub
            txtmapeh1grade10.Text = Math.Round((CDbl(txtmusic1grade10.Text) + CDbl(txtarts1grade10.Text) + CDbl(txtpe1grade10.Text) + CDbl(txthealth1grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic2grade10_TextChanged(sender As Object, e As EventArgs) Handles txtmusic2grade10.TextChanged, txtarts2grade10.TextChanged, txtpe2grade10.TextChanged, txthealth2grade10.TextChanged
        If txtmusic2grade10.Text = "" Or txtarts2grade10.Text = "" Or txtpe2grade10.Text = "" Or txthealth2grade10.Text = "" Then
            txtmapeh2grade10.Text = 0
            txtmapehatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic2grade10.Text) OrElse String.IsNullOrEmpty(txtarts2grade10.Text) OrElse String.IsNullOrEmpty(txtpe2grade10.Text) OrElse String.IsNullOrEmpty(txthealth2grade10.Text) Then Exit Sub
            If Not IsNumeric(txtmusic2grade10.Text) OrElse Not IsNumeric(txtarts2grade10.Text) OrElse Not IsNumeric(txtpe2grade10.Text) OrElse Not IsNumeric(txthealth2grade10.Text) Then Exit Sub
            txtmapeh2grade10.Text = Math.Round((CDbl(txtmusic2grade10.Text) + CDbl(txtarts2grade10.Text) + CDbl(txtpe2grade10.Text) + CDbl(txthealth2grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic3grade10_TextChanged(sender As Object, e As EventArgs) Handles txtmusic3grade10.TextChanged, txtarts3grade10.TextChanged, txtpe3grade10.TextChanged, txthealth3grade10.TextChanged
        If txtmusic3grade10.Text = "" Or txtarts3grade10.Text = "" Or txtpe3grade10.Text = "" Or txthealth3grade10.Text = "" Then
            txtmapeh3grade10.Text = 0
            txtmapehatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic3grade10.Text) OrElse String.IsNullOrEmpty(txtarts3grade10.Text) OrElse String.IsNullOrEmpty(txtpe3grade10.Text) OrElse String.IsNullOrEmpty(txthealth3grade10.Text) Then Exit Sub
            If Not IsNumeric(txtmusic3grade10.Text) OrElse Not IsNumeric(txtarts3grade10.Text) OrElse Not IsNumeric(txtpe3grade10.Text) OrElse Not IsNumeric(txthealth3grade10.Text) Then Exit Sub
            txtmapeh3grade10.Text = Math.Round((CDbl(txtmusic3grade10.Text) + CDbl(txtarts3grade10.Text) + CDbl(txtpe3grade10.Text) + CDbl(txthealth3grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusic4grade10_TextChanged(sender As Object, e As EventArgs) Handles txtmusic4grade10.TextChanged, txtarts4grade10.TextChanged, txtpe4grade10.TextChanged, txthealth4grade10.TextChanged
        If txtmusic4grade10.Text = "" Or txtarts4grade10.Text = "" Or txtpe4grade10.Text = "" Or txthealth4grade10.Text = "" Then
            txtmapeh4grade10.Text = 0
            txtmapehatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic4grade10.Text) OrElse String.IsNullOrEmpty(txtarts4grade10.Text) OrElse String.IsNullOrEmpty(txtpe4grade10.Text) OrElse String.IsNullOrEmpty(txthealth4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtmusic4grade10.Text) OrElse Not IsNumeric(txtarts4grade10.Text) OrElse Not IsNumeric(txtpe4grade10.Text) OrElse Not IsNumeric(txthealth4grade10.Text) Then Exit Sub
            txtmapeh4grade10.Text = Math.Round((CDbl(txtmusic4grade10.Text) + CDbl(txtarts4grade10.Text) + CDbl(txtpe4grade10.Text) + CDbl(txthealth4grade10.Text)) / 4, 0)
        End If
    End Sub
    Private Sub txtmusicfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtmusic1grade10.TextChanged, txtmusic2grade10.TextChanged, txtmusic3grade10.TextChanged, txtmusic4grade10.TextChanged
        If txtmusic1grade10.Text = "" Or txtmusic2grade10.Text = "" Or txtmusic3grade10.Text = "" Or txtmusic4grade10.Text = "" Then
            txtmusicfrgrade10.Text = 0
            txtmusicatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtmusic1grade10.Text) OrElse String.IsNullOrEmpty(txtmusic2grade10.Text) OrElse String.IsNullOrEmpty(txtmusic3grade10.Text) OrElse String.IsNullOrEmpty(txtmusic4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtmusic1grade10.Text) OrElse Not IsNumeric(txtmusic2grade10.Text) OrElse Not IsNumeric(txtmusic3grade10.Text) OrElse Not IsNumeric(txtmusic4grade10.Text) Then Exit Sub
            txtmusicfrgrade10.Text = Math.Round((CDbl(txtmusic1grade10.Text) + CDbl(txtmusic2grade10.Text) + CDbl(txtmusic3grade10.Text) + CDbl(txtmusic4grade10.Text)) / 4, 0)
            If txtmusicfrgrade10.Text.ToString >= 74.5 Then
                txtmusicatgrade10.Text = "PASSED"
            Else
                txtmusicatgrade10.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtartsfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtarts1grade10.TextChanged, txtarts2grade10.TextChanged, txtarts3grade10.TextChanged, txtarts4grade10.TextChanged
        If txtarts1grade10.Text = "" Or txtarts2grade10.Text = "" Or txtarts3grade10.Text = "" Or txtarts4grade10.Text = "" Then
            txtartsfrgrade10.Text = 0
            txtartsatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtarts1grade10.Text) OrElse String.IsNullOrEmpty(txtarts2grade10.Text) OrElse String.IsNullOrEmpty(txtarts3grade10.Text) OrElse String.IsNullOrEmpty(txtarts4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtarts1grade10.Text) OrElse Not IsNumeric(txtarts2grade10.Text) OrElse Not IsNumeric(txtarts3grade10.Text) OrElse Not IsNumeric(txtarts4grade10.Text) Then Exit Sub
            txtartsfrgrade10.Text = Math.Round((CDbl(txtarts1grade10.Text) + CDbl(txtarts2grade10.Text) + CDbl(txtarts3grade10.Text) + CDbl(txtarts4grade10.Text)) / 4, 0)
            If txtartsfrgrade10.Text.ToString >= 74.5 Then
                txtartsatgrade10.Text = "PASSED"
            Else
                txtartsatgrade10.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtpefrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtpe1grade10.TextChanged, txtpe2grade10.TextChanged, txtpe3grade10.TextChanged, txtpe4grade10.TextChanged
        If txtpe1grade10.Text = "" Or txtpe2grade10.Text = "" Or txtpe3grade10.Text = "" Or txtpe4grade10.Text = "" Then
            txtpefrgrade10.Text = 0
            txtpeatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtpe1grade10.Text) OrElse String.IsNullOrEmpty(txtpe2grade10.Text) OrElse String.IsNullOrEmpty(txtpe3grade10.Text) OrElse String.IsNullOrEmpty(txtpe4grade10.Text) Then Exit Sub
            If Not IsNumeric(txtpe1grade10.Text) OrElse Not IsNumeric(txtpe2grade10.Text) OrElse Not IsNumeric(txtpe3grade10.Text) OrElse Not IsNumeric(txtpe4grade10.Text) Then Exit Sub
            txtpefrgrade10.Text = Math.Round((CDbl(txtpe1grade10.Text) + CDbl(txtpe2grade10.Text) + CDbl(txtpe3grade10.Text) + CDbl(txtpe4grade10.Text)) / 4, 0)
            If txtpefrgrade10.Text.ToString >= 74.5 Then
                txtpeatgrade10.Text = "PASSED"
            Else
                txtpeatgrade10.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txthealthfrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txthealth1grade10.TextChanged, txthealth2grade10.TextChanged, txthealth3grade10.TextChanged, txthealth4grade10.TextChanged
        If txthealth1grade10.Text = "" Or txthealth2grade10.Text = "" Or txthealth3grade10.Text = "" Or txthealth4grade10.Text = "" Then
            txthealthfrgrade10.Text = 0
            txthealthatgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txthealth1grade10.Text) OrElse String.IsNullOrEmpty(txthealth2grade10.Text) OrElse String.IsNullOrEmpty(txthealth3grade10.Text) OrElse String.IsNullOrEmpty(txthealth4grade10.Text) Then Exit Sub
            If Not IsNumeric(txthealth1grade10.Text) OrElse Not IsNumeric(txthealth2grade10.Text) OrElse Not IsNumeric(txthealth3grade10.Text) OrElse Not IsNumeric(txthealth4grade10.Text) Then Exit Sub
            txthealthfrgrade10.Text = Math.Round((CDbl(txthealth1grade10.Text) + CDbl(txthealth2grade10.Text) + CDbl(txthealth3grade10.Text) + CDbl(txthealth4grade10.Text)) / 4, 0)
            If txthealthfrgrade10.Text.ToString >= 74.5 Then
                txthealthatgrade10.Text = "PASSED"
            Else
                txthealthatgrade10.Text = "FAILED"
            End If
        End If
    End Sub
    Private Sub txtaveragefrgrade10_TextChanged(sender As Object, e As EventArgs) Handles txtfilipinofrgrade10.TextChanged, txtenglishfrgrade10.TextChanged, txtmathfrgrade10.TextChanged, txtsciencefrgrade10.TextChanged, txtapfrgrade10.TextChanged, txtespfrgrade10.TextChanged, txttlefrgrade10.TextChanged, txtmapehfrgrade10.TextChanged
        If String.IsNullOrEmpty(txtfilipinofrgrade10.Text) OrElse String.IsNullOrEmpty(txtenglishfrgrade10.Text) OrElse String.IsNullOrEmpty(txtmathfrgrade10.Text) OrElse String.IsNullOrEmpty(txtsciencefrgrade10.Text) OrElse String.IsNullOrEmpty(txtapfrgrade10.Text) OrElse String.IsNullOrEmpty(txtespfrgrade10.Text) OrElse String.IsNullOrEmpty(txttlefrgrade10.Text) OrElse String.IsNullOrEmpty(txtmapehfrgrade10.Text) Then Exit Sub
        If Not IsNumeric(txtfilipinofrgrade10.Text) OrElse Not IsNumeric(txtenglishfrgrade10.Text) OrElse Not IsNumeric(txtmathfrgrade10.Text) OrElse Not IsNumeric(txtsciencefrgrade10.Text) OrElse Not IsNumeric(txtapfrgrade10.Text) OrElse Not IsNumeric(txtespfrgrade10.Text) OrElse Not IsNumeric(txttlefrgrade10.Text) OrElse Not IsNumeric(txtmapehfrgrade10.Text) Then Exit Sub
        txtaveragefrgrade10.Text = Math.Round((CDbl(txtfilipinofrgrade10.Text) + CDbl(txtenglishfrgrade10.Text) + CDbl(txtmathfrgrade10.Text) + CDbl(txtsciencefrgrade10.Text) + CDbl(txtapfrgrade10.Text) + CDbl(txtespfrgrade10.Text) + CDbl(txttlefrgrade10.Text) + CDbl(txtmapehfrgrade10.Text)) / 8, 2)
        If txtaveragefrgrade10.Text.ToString >= 74.5 Then
            txtaverageatgrade10.Text = "PASSED"
        Else
            txtaverageatgrade10.Text = "FAILED"
        End If
    End Sub
    Private Sub txtdsjungrade10_TextChanged(sender As Object, e As EventArgs) Handles txtdsjungrade10.TextChanged, txtdsjulgrade10.TextChanged, txtdsauggrade10.TextChanged, txtdssepgrade10.TextChanged, txtdsoctgrade10.TextChanged, txtdsnovgrade10.TextChanged, txtdsdecgrade10.TextChanged, txtdsjangrade10.TextChanged, txtdsfebgrade10.TextChanged, txtdsmargrade10.TextChanged, txtdsaprgrade10.TextChanged
        If txtdsjungrade10.Text = "" Or txtdsjulgrade10.Text = "" Or txtdsauggrade10.Text = "" Or txtdssepgrade10.Text = "" Or txtdsoctgrade10.Text = "" Or txtdsnovgrade10.Text = "" Or txtdsdecgrade10.Text = "" Or txtdsjangrade10.Text = "" Or txtdsfebgrade10.Text = "" Or txtdsmargrade10.Text = "" Or txtdsaprgrade10.Text = "" Then
            txtdstotalgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtdsjungrade10.Text) OrElse String.IsNullOrEmpty(txtdsjulgrade10.Text) OrElse String.IsNullOrEmpty(txtdsauggrade10.Text) OrElse String.IsNullOrEmpty(txtdssepgrade10.Text) OrElse String.IsNullOrEmpty(txtdsoctgrade10.Text) OrElse String.IsNullOrEmpty(txtdsnovgrade10.Text) OrElse String.IsNullOrEmpty(txtdsdecgrade10.Text) OrElse String.IsNullOrEmpty(txtdsjangrade10.Text) OrElse String.IsNullOrEmpty(txtdsfebgrade10.Text) OrElse String.IsNullOrEmpty(txtdsmargrade10.Text) OrElse String.IsNullOrEmpty(txtdsaprgrade10.Text) Then Exit Sub
            If Not IsNumeric(txtdsjungrade10.Text) OrElse Not IsNumeric(txtdsjulgrade10.Text) OrElse Not IsNumeric(txtdsauggrade10.Text) OrElse Not IsNumeric(txtdssepgrade10.Text) OrElse Not IsNumeric(txtdsoctgrade10.Text) OrElse Not IsNumeric(txtdsnovgrade10.Text) OrElse Not IsNumeric(txtdsdecgrade10.Text) OrElse Not IsNumeric(txtdsjangrade10.Text) OrElse Not IsNumeric(txtdsfebgrade10.Text) OrElse Not IsNumeric(txtdsmargrade10.Text) OrElse Not IsNumeric(txtdsaprgrade10.Text) Then Exit Sub
            txtdstotalgrade10.Text = (CDbl(txtdsjungrade10.Text) + CDbl(txtdsjulgrade10.Text) + CDbl(txtdsauggrade10.Text) + CDbl(txtdssepgrade10.Text) + CDbl(txtdsoctgrade10.Text) + CDbl(txtdsnovgrade10.Text) + CDbl(txtdsdecgrade10.Text) + CDbl(txtdsjangrade10.Text) + CDbl(txtdsfebgrade10.Text) + CDbl(txtdsmargrade10.Text) + CDbl(txtdsaprgrade10.Text))
        End If
    End Sub
    Private Sub txtdpjungrade10_TextChanged(sender As Object, e As EventArgs) Handles txtdpjungrade10.TextChanged, txtdpjulgrade10.TextChanged, txtdpauggrade10.TextChanged, txtdpsepgrade10.TextChanged, txtdpoctgrade10.TextChanged, txtdpnovgrade10.TextChanged, txtdpdecgrade10.TextChanged, txtdpjangrade10.TextChanged, txtdpfebgrade10.TextChanged, txtdpmargrade10.TextChanged, txtdpaprgrade10.TextChanged
        If txtdpjungrade10.Text = "" Or txtdpjulgrade10.Text = "" Or txtdpauggrade10.Text = "" Or txtdpsepgrade10.Text = "" Or txtdpoctgrade10.Text = "" Or txtdpnovgrade10.Text = "" Or txtdpdecgrade10.Text = "" Or txtdpjangrade10.Text = "" Or txtdpfebgrade10.Text = "" Or txtdpmargrade10.Text = "" Or txtdpaprgrade10.Text = "" Then
            txtdptotalgrade10.Text = ""
        Else
            If String.IsNullOrEmpty(txtdpjungrade10.Text) OrElse String.IsNullOrEmpty(txtdpjulgrade10.Text) OrElse String.IsNullOrEmpty(txtdpauggrade10.Text) OrElse String.IsNullOrEmpty(txtdpsepgrade10.Text) OrElse String.IsNullOrEmpty(txtdpoctgrade10.Text) OrElse String.IsNullOrEmpty(txtdpnovgrade10.Text) OrElse String.IsNullOrEmpty(txtdpdecgrade10.Text) OrElse String.IsNullOrEmpty(txtdpjangrade10.Text) OrElse String.IsNullOrEmpty(txtdpfebgrade10.Text) OrElse String.IsNullOrEmpty(txtdpmargrade10.Text) OrElse String.IsNullOrEmpty(txtdpaprgrade10.Text) Then Exit Sub
            If Not IsNumeric(txtdpjungrade10.Text) OrElse Not IsNumeric(txtdpjulgrade10.Text) OrElse Not IsNumeric(txtdpauggrade10.Text) OrElse Not IsNumeric(txtdpsepgrade10.Text) OrElse Not IsNumeric(txtdpoctgrade10.Text) OrElse Not IsNumeric(txtdpnovgrade10.Text) OrElse Not IsNumeric(txtdpdecgrade10.Text) OrElse Not IsNumeric(txtdpjangrade10.Text) OrElse Not IsNumeric(txtdpfebgrade10.Text) OrElse Not IsNumeric(txtdpmargrade10.Text) OrElse Not IsNumeric(txtdpaprgrade10.Text) Then Exit Sub
            txtdptotalgrade10.Text = (CDbl(txtdpjungrade10.Text) + CDbl(txtdpjulgrade10.Text) + CDbl(txtdpauggrade10.Text) + CDbl(txtdpsepgrade10.Text) + CDbl(txtdpoctgrade10.Text) + CDbl(txtdpnovgrade10.Text) + CDbl(txtdpdecgrade10.Text) + CDbl(txtdpjangrade10.Text) + CDbl(txtdpfebgrade10.Text) + CDbl(txtdpmargrade10.Text) + CDbl(txtdpaprgrade10.Text))
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Try
            Dim sqlcon As New SqlCommand("Select * from studinfoTbl where lrn='" & txtlrn.Text & "'", conn)
            Dim da As New SqlDataAdapter(sqlcon)
            Dim dt As New DataTable
            da.Fill(dt)
            If txtname.Text = "Type the Full Name of the Student..." Or txtname.Text = "" Or dtpdateofbirth.Text = "" Or cbgender.Text = "" Or txtlrn.Text = "" Or txtlrn.Text = "Student LRN..." Or txtbirthplace.Text = "Type the Birthplace/Province..." Or txtbirthplace.Text = "" Or txttown.Text = "Type the Town/City..." Or txttown.Text = "" Or txtbrgy.Text = "Type the Barangay..." Or txtbrgy.Text = "" Or txtparent.Text = "Parent/Guardian's Fullname..." Or txtparent.Text = "" Or txtoccupation.Text = "Occupation of the Parent/Guardian..." Or txtoccupation.Text = "" Or txtaddress.Text = "Address of the Parent/Guardian..." Or txtaddress.Text = "" Or txtelementaryschool.Text = "Elementary School Graduated..." Or txtelementaryschool.Text = "" Or cbyeargrad.Text = "" Or txtgenave.Text = "Ave. Grade..." Or txtgenave.Text = "" Then
                MessageBox.Show("You must fill up all the required information to proceed")
            ElseIf dt.Rows.Count > 0 Then
                MessageBox.Show("LRN already exists!")
            Else
                conn.Open()
                Dim insertQuery1, insertQuery2, insertQuery3, insertQuery4, insertQuery5, insertQuery6, insertQuery7, insertQuery8, insertQuery9 As String
                If MessageBox.Show("You are about to save the information Select Yes in order to proceed ", "Save", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    insertQuery1 = "INSERT INTO studinfoTbl(lrn,fullname,dateofbirth,sex,birthplace,town,brgy,parent,occupation,parentaddress,elemschool,yeargrad,genave) VALUES ('" & txtlrn.Text & "' , '" & txtname.Text & "' , '" & dtpdateofbirth.Text & "' , '" & cbgender.Text & "', '" & txtbirthplace.Text & "', '" & txttown.Text & "', '" & txtbrgy.Text & "', '" & txtparent.Text & "','" & txtoccupation.Text & "','" & txtaddress.Text & "', '" & txtelementaryschool.Text & "', '" & cbyeargrad.Text & "', '" & txtgenave.Text & "' )"
                    insertQuery2 = "INSERT INTO studrecordgrade7Tbl(lrn,classifiedgrade7,totalyearsgrade7,yeargrade7,sectiongrade7,schoolgrade7,schoolyeargrade7,cs1filipinograde7,cs2filipinograde7,cs3filipinograde7,cs4filipinograde7,filipinofinalratinggrade7,filipinoactiontakengrade7,filipinocreditgrade7,filipinoecagrade7,cs1englishgrade7,cs2englishgrade7,cs3englishgrade7,cs4englishgrade7,englishfinalratinggrade7,englishactiontakengrade7,englishcreditgrade7,englishecagrade7,cs1mathgrade7,cs2mathgrade7,cs3mathgrade7,cs4mathgrade7,mathfinalratinggrade7,mathactiontakengrade7,mathcreditgrade7,mathecagrade7,cs1sciencegrade7,cs2sciencegrade7,cs3sciencegrade7,cs4sciencegrade7,sciencefinalratinggrade7,scienceactiontakengrade7,sciencecreditgrade7,scienceecagrade7,cs1apgrade7,cs2apgrade7,cs3apgrade7,cs4apgrade7,apfinalratinggrade7,apactiontakengrade7,apcreditgrade7,apecagrade7,cs1espgrade7,cs2espgrade7,cs3espgrade7,cs4espgrade7,espfinalratinggrade7,espactiontakengrade7,espcreditgrade7,especagrade7,cs1tlegrade7,cs2tlegrade7,cs3tlegrade7,cs4tlegrade7,tlefinalratinggrade7,tleactiontakengrade7,tlecreditgrade7,tleecagrade7,cs1mapehgrade7,cs2mapehgrade7,cs3mapehgrade7,cs4mapehgrade7,mapehfinalratinggrade7,mapehactiontakengrade7,mapehcreditgrade7,mapehecagrade7,cs1musicgrade7,cs2musicgrade7,cs3musicgrade7,cs4musicgrade7,musicfinalratinggrade7,musicactiontakengrade7,musiccreditgrade7,musicecagrade7,cs1artsgrade7,cs2artsgrade7,cs3artsgrade7,cs4artsgrade7,artsfinalratinggrade7,artsactiontakengrade7,artscreditgrade7,artsecagrade7,cs1pegrade7,cs2pegrade7,cs3pegrade7,cs4pegrade7,pefinalratinggrade7,peactiontakengrade7,pecreditgrade7,peecagrade7,cs1healthgrade7,cs2healthgrade7,cs3healthgrade7,cs4healthgrade7,healthfinalratinggrade7,healthactiontakengrade7,healthcreditgrade7,healthecagrade7,averagegrade7,averageactiontakengrade7,averagecreditgrade7) VALUES ('" & txtlrn.Text & "' , '" & txtclassifiedgrade7.Text & "', '" & cbtotalyearsgrade7.Text & "', '" & txtyeargrade7.Text & "' , '" & txtsectiongrade7.Text & "', '" & txtschoolgrade7.Text & "', '" & cbschoolyeargrade7.Text & "', '" & txtfilipino1grade7.Text & "', '" & txtfilipino2grade7.Text & "', '" & txtfilipino3grade7.Text & "', '" & txtfilipino4grade7.Text & "', '" & txtfilipinofrgrade7.Text & "', '" & txtfilipinoatgrade7.Text & "', '" & txtfilipinocgrade7.Text & "', '" & txtfilipinoecagrade7.Text & "', '" & txtenglish1grade7.Text & "', '" & txtenglish2grade7.Text & "', '" & txtenglish3grade7.Text & "', '" & txtenglish4grade7.Text & "', '" & txtenglishfrgrade7.Text & "', '" & txtenglishatgrade7.Text & "', '" & txtenglishcgrade7.Text & "', '" & txtenglishecagrade7.Text & "', '" & txtmath1grade7.Text & "', '" & txtmath2grade7.Text & "', '" & txtmath3grade7.Text & "', '" & txtmath4grade7.Text & "', '" & txtmathfrgrade7.Text & "', '" & txtmathatgrade7.Text & "', '" & txtmathcgrade7.Text & "', '" & txtmathecagrade7.Text & "', '" & txtscience1grade7.Text & "', '" & txtscience2grade7.Text & "', '" & txtscience3grade7.Text & "', '" & txtscience4grade7.Text & "', '" & txtsciencefrgrade7.Text & "', '" & txtscienceatgrade7.Text & "', '" & txtsciencecgrade7.Text & "', '" & txtscienceecagrade7.Text & "', '" & txtap1grade7.Text & "', '" & txtap2grade7.Text & "', '" & txtap3grade7.Text & "', '" & txtap4grade7.Text & "', '" & txtapfrgrade7.Text & "', '" & txtapatgrade7.Text & "', '" & txtapcgrade7.Text & "', '" & txtapecagrade7.Text & "', '" & txtesp1grade7.Text & "', '" & txtesp2grade7.Text & "', '" & txtesp3grade7.Text & "', '" & txtesp4grade7.Text & "', '" & txtespfrgrade7.Text & "', '" & txtespatgrade7.Text & "', '" & txtespcgrade7.Text & "', '" & txtespecagrade7.Text & "', '" & txttle1grade7.Text & "', '" & txttle2grade7.Text & "', '" & txttle3grade7.Text & "', '" & txttle4grade7.Text & "', '" & txttlefrgrade7.Text & "', '" & txttleatgrade7.Text & "', '" & txttlecgrade7.Text & "', '" & txttleecagrade7.Text & "', '" & txtmapeh1grade7.Text & "', '" & txtmapeh2grade7.Text & "', '" & txtmapeh3grade7.Text & "', '" & txtmapeh4grade7.Text & "', '" & txtmapehfrgrade7.Text & "', '" & txtmapehatgrade7.Text & "', '" & txtmapehcgrade7.Text & "', '" & txtmapehecagrade7.Text & "', '" & txtmusic1grade7.Text & "', '" & txtmusic2grade7.Text & "', '" & txtmusic3grade7.Text & "', '" & txtmusic4grade7.Text & "', '" & txtmusicfrgrade7.Text & "', '" & txtmusicatgrade7.Text & "', '" & txtmusiccgrade7.Text & "', '" & txtmusicecagrade7.Text & "', '" & txtarts1grade7.Text & "', '" & txtarts2grade7.Text & "', '" & txtarts3grade7.Text & "', '" & txtarts4grade7.Text & "', '" & txtartsfrgrade7.Text & "', '" & txtartsatgrade7.Text & "', '" & txtartscgrade7.Text & "', '" & txtartsecagrade7.Text & "', '" & txtpe1grade7.Text & "', '" & txtpe2grade7.Text & "', '" & txtpe3grade7.Text & "', '" & txtpe4grade7.Text & "', '" & txtpefrgrade7.Text & "', '" & txtpeatgrade7.Text & "', '" & txtpecgrade7.Text & "', '" & txtpeecagrade7.Text & "', '" & txthealth1grade7.Text & "', '" & txthealth2grade7.Text & "', '" & txthealth3grade7.Text & "', '" & txthealth4grade7.Text & "', '" & txthealthfrgrade7.Text & "', '" & txthealthatgrade7.Text & "', '" & txthealthcgrade7.Text & "', '" & txthealthecagrade7.Text & "', '" & txtaveragefrgrade7.Text & "', '" & txtaverageatgrade7.Text & "', '" & txtaveragecgrade7.Text & "')"
                    insertQuery3 = "INSERT INTO studrecordgrade8Tbl(lrn,classifiedgrade8,totalyearsgrade8,yeargrade8,sectiongrade8,schoolgrade8,schoolyeargrade8,cs1filipinograde8,cs2filipinograde8,cs3filipinograde8,cs4filipinograde8,filipinofinalratinggrade8,filipinoactiontakengrade8,filipinocreditgrade8,filipinoecagrade8,cs1englishgrade8,cs2englishgrade8,cs3englishgrade8,cs4englishgrade8,englishfinalratinggrade8,englishactiontakengrade8,englishcreditgrade8,englishecagrade8,cs1mathgrade8,cs2mathgrade8,cs3mathgrade8,cs4mathgrade8,mathfinalratinggrade8,mathactiontakengrade8,mathcreditgrade8,mathecagrade8,cs1sciencegrade8,cs2sciencegrade8,cs3sciencegrade8,cs4sciencegrade8,sciencefinalratinggrade8,scienceactiontakengrade8,sciencecreditgrade8,scienceecagrade8,cs1apgrade8,cs2apgrade8,cs3apgrade8,cs4apgrade8,apfinalratinggrade8,apactiontakengrade8,apcreditgrade8,apecagrade8,cs1espgrade8,cs2espgrade8,cs3espgrade8,cs4espgrade8,espfinalratinggrade8,espactiontakengrade8,espcreditgrade8,especagrade8,cs1tlegrade8,cs2tlegrade8,cs3tlegrade8,cs4tlegrade8,tlefinalratinggrade8,tleactiontakengrade8,tlecreditgrade8,tleecagrade8,cs1mapehgrade8,cs2mapehgrade8,cs3mapehgrade8,cs4mapehgrade8,mapehfinalratinggrade8,mapehactiontakengrade8,mapehcreditgrade8,mapehecagrade8,cs1musicgrade8,cs2musicgrade8,cs3musicgrade8,cs4musicgrade8,musicfinalratinggrade8,musicactiontakengrade8,musiccreditgrade8,musicecagrade8,cs1artsgrade8,cs2artsgrade8,cs3artsgrade8,cs4artsgrade8,artsfinalratinggrade8,artsactiontakengrade8,artscreditgrade8,artsecagrade8,cs1pegrade8,cs2pegrade8,cs3pegrade8,cs4pegrade8,pefinalratinggrade8,peactiontakengrade8,pecreditgrade8,peecagrade8,cs1healthgrade8,cs2healthgrade8,cs3healthgrade8,cs4healthgrade8,healthfinalratinggrade8,healthactiontakengrade8,healthcreditgrade8,healthecagrade8,averagegrade8,averageactiontakengrade8,averagecreditgrade8) VALUES ('" & txtlrn.Text & "' , '" & txtclassifiedgrade8.Text & "', '" & cbtotalyearsgrade8.Text & "', '" & txtyeargrade8.Text & "' , '" & txtsectiongrade8.Text & "', '" & txtschoolgrade8.Text & "', '" & cbschoolyeargrade8.Text & "', '" & txtfilipino1grade8.Text & "', '" & txtfilipino2grade8.Text & "', '" & txtfilipino3grade8.Text & "', '" & txtfilipino4grade8.Text & "', '" & txtfilipinofrgrade8.Text & "', '" & txtfilipinoatgrade8.Text & "', '" & txtfilipinocgrade8.Text & "', '" & txtfilipinoecagrade8.Text & "', '" & txtenglish1grade8.Text & "', '" & txtenglish2grade8.Text & "', '" & txtenglish3grade8.Text & "', '" & txtenglish4grade8.Text & "', '" & txtenglishfrgrade8.Text & "', '" & txtenglishatgrade8.Text & "', '" & txtenglishcgrade8.Text & "', '" & txtenglishecagrade8.Text & "', '" & txtmath1grade8.Text & "', '" & txtmath2grade8.Text & "', '" & txtmath3grade8.Text & "', '" & txtmath4grade8.Text & "', '" & txtmathfrgrade8.Text & "', '" & txtmathatgrade8.Text & "', '" & txtmathcgrade8.Text & "', '" & txtmathecagrade8.Text & "', '" & txtscience1grade8.Text & "', '" & txtscience2grade8.Text & "', '" & txtscience3grade8.Text & "', '" & txtscience4grade8.Text & "', '" & txtsciencefrgrade8.Text & "', '" & txtscienceatgrade8.Text & "', '" & txtsciencecgrade8.Text & "', '" & txtscienceecagrade8.Text & "', '" & txtap1grade8.Text & "', '" & txtap2grade8.Text & "', '" & txtap3grade8.Text & "', '" & txtap4grade8.Text & "', '" & txtapfrgrade8.Text & "', '" & txtapatgrade8.Text & "', '" & txtapcgrade8.Text & "', '" & txtapecagrade8.Text & "', '" & txtesp1grade8.Text & "', '" & txtesp2grade8.Text & "', '" & txtesp3grade8.Text & "', '" & txtesp4grade8.Text & "', '" & txtespfrgrade8.Text & "', '" & txtespatgrade8.Text & "', '" & txtespcgrade8.Text & "', '" & txtespecagrade8.Text & "', '" & txttle1grade8.Text & "', '" & txttle2grade8.Text & "', '" & txttle3grade8.Text & "', '" & txttle4grade8.Text & "', '" & txttlefrgrade8.Text & "', '" & txttleatgrade8.Text & "', '" & txttlecgrade8.Text & "', '" & txttleecagrade8.Text & "', '" & txtmapeh1grade8.Text & "', '" & txtmapeh2grade8.Text & "', '" & txtmapeh3grade8.Text & "', '" & txtmapeh4grade8.Text & "', '" & txtmapehfrgrade8.Text & "', '" & txtmapehatgrade8.Text & "', '" & txtmapehcgrade8.Text & "', '" & txtmapehecagrade8.Text & "', '" & txtmusic1grade8.Text & "', '" & txtmusic2grade8.Text & "', '" & txtmusic3grade8.Text & "', '" & txtmusic4grade8.Text & "', '" & txtmusicfrgrade8.Text & "', '" & txtmusicatgrade8.Text & "', '" & txtmusiccgrade8.Text & "', '" & txtmusicecagrade8.Text & "', '" & txtarts1grade8.Text & "', '" & txtarts2grade8.Text & "', '" & txtarts3grade8.Text & "', '" & txtarts4grade8.Text & "', '" & txtartsfrgrade8.Text & "', '" & txtartsatgrade8.Text & "', '" & txtartscgrade8.Text & "', '" & txtartsecagrade8.Text & "', '" & txtpe1grade8.Text & "', '" & txtpe2grade8.Text & "', '" & txtpe3grade8.Text & "', '" & txtpe4grade8.Text & "', '" & txtpefrgrade8.Text & "', '" & txtpeatgrade8.Text & "', '" & txtpecgrade8.Text & "', '" & txtpeecagrade8.Text & "', '" & txthealth1grade8.Text & "', '" & txthealth2grade8.Text & "', '" & txthealth3grade8.Text & "', '" & txthealth4grade8.Text & "', '" & txthealthfrgrade8.Text & "', '" & txthealthatgrade8.Text & "', '" & txthealthcgrade8.Text & "', '" & txthealthecagrade8.Text & "', '" & txtaveragefrgrade8.Text & "', '" & txtaverageatgrade8.Text & "', '" & txtaveragecgrade8.Text & "')"
                    insertQuery4 = "INSERT INTO studrecordgrade9Tbl(lrn,classifiedgrade9,totalyearsgrade9,yeargrade9,sectiongrade9,schoolgrade9,schoolyeargrade9,cs1filipinograde9,cs2filipinograde9,cs3filipinograde9,cs4filipinograde9,filipinofinalratinggrade9,filipinoactiontakengrade9,filipinocreditgrade9,filipinoecagrade9,cs1englishgrade9,cs2englishgrade9,cs3englishgrade9,cs4englishgrade9,englishfinalratinggrade9,englishactiontakengrade9,englishcreditgrade9,englishecagrade9,cs1mathgrade9,cs2mathgrade9,cs3mathgrade9,cs4mathgrade9,mathfinalratinggrade9,mathactiontakengrade9,mathcreditgrade9,mathecagrade9,cs1sciencegrade9,cs2sciencegrade9,cs3sciencegrade9,cs4sciencegrade9,sciencefinalratinggrade9,scienceactiontakengrade9,sciencecreditgrade9,scienceecagrade9,cs1apgrade9,cs2apgrade9,cs3apgrade9,cs4apgrade9,apfinalratinggrade9,apactiontakengrade9,apcreditgrade9,apecagrade9,cs1espgrade9,cs2espgrade9,cs3espgrade9,cs4espgrade9,espfinalratinggrade9,espactiontakengrade9,espcreditgrade9,especagrade9,cs1tlegrade9,cs2tlegrade9,cs3tlegrade9,cs4tlegrade9,tlefinalratinggrade9,tleactiontakengrade9,tlecreditgrade9,tleecagrade9,cs1mapehgrade9,cs2mapehgrade9,cs3mapehgrade9,cs4mapehgrade9,mapehfinalratinggrade9,mapehactiontakengrade9,mapehcreditgrade9,mapehecagrade9,cs1musicgrade9,cs2musicgrade9,cs3musicgrade9,cs4musicgrade9,musicfinalratinggrade9,musicactiontakengrade9,musiccreditgrade9,musicecagrade9,cs1artsgrade9,cs2artsgrade9,cs3artsgrade9,cs4artsgrade9,artsfinalratinggrade9,artsactiontakengrade9,artscreditgrade9,artsecagrade9,cs1pegrade9,cs2pegrade9,cs3pegrade9,cs4pegrade9,pefinalratinggrade9,peactiontakengrade9,pecreditgrade9,peecagrade9,cs1healthgrade9,cs2healthgrade9,cs3healthgrade9,cs4healthgrade9,healthfinalratinggrade9,healthactiontakengrade9,healthcreditgrade9,healthecagrade9,averagegrade9,averageactiontakengrade9,averagecreditgrade9) VALUES ('" & txtlrn.Text & "' , '" & txtclassifiedgrade9.Text & "', '" & cbtotalyearsgrade9.Text & "', '" & txtyeargrade9.Text & "' , '" & txtsectiongrade9.Text & "', '" & txtschoolgrade9.Text & "', '" & cbschoolyeargrade9.Text & "', '" & txtfilipino1grade9.Text & "', '" & txtfilipino2grade9.Text & "', '" & txtfilipino3grade9.Text & "', '" & txtfilipino4grade9.Text & "', '" & txtfilipinofrgrade9.Text & "', '" & txtfilipinoatgrade9.Text & "', '" & txtfilipinocgrade9.Text & "', '" & txtfilipinoecagrade9.Text & "', '" & txtenglish1grade9.Text & "', '" & txtenglish2grade9.Text & "', '" & txtenglish3grade9.Text & "', '" & txtenglish4grade9.Text & "', '" & txtenglishfrgrade9.Text & "', '" & txtenglishatgrade9.Text & "', '" & txtenglishcgrade9.Text & "', '" & txtenglishecagrade9.Text & "', '" & txtmath1grade9.Text & "', '" & txtmath2grade9.Text & "', '" & txtmath3grade9.Text & "', '" & txtmath4grade9.Text & "', '" & txtmathfrgrade9.Text & "', '" & txtmathatgrade9.Text & "', '" & txtmathcgrade9.Text & "', '" & txtmathecagrade9.Text & "', '" & txtscience1grade9.Text & "', '" & txtscience2grade9.Text & "', '" & txtscience3grade9.Text & "', '" & txtscience4grade9.Text & "', '" & txtsciencefrgrade9.Text & "', '" & txtscienceatgrade9.Text & "', '" & txtsciencecgrade9.Text & "', '" & txtscienceecagrade9.Text & "', '" & txtap1grade9.Text & "', '" & txtap2grade9.Text & "', '" & txtap3grade9.Text & "', '" & txtap4grade9.Text & "', '" & txtapfrgrade9.Text & "', '" & txtapatgrade9.Text & "', '" & txtapcgrade9.Text & "', '" & txtapecagrade9.Text & "', '" & txtesp1grade9.Text & "', '" & txtesp2grade9.Text & "', '" & txtesp3grade9.Text & "', '" & txtesp4grade9.Text & "', '" & txtespfrgrade9.Text & "', '" & txtespatgrade9.Text & "', '" & txtespcgrade9.Text & "', '" & txtespecagrade9.Text & "', '" & txttle1grade9.Text & "', '" & txttle2grade9.Text & "', '" & txttle3grade9.Text & "', '" & txttle4grade9.Text & "', '" & txttlefrgrade9.Text & "', '" & txttleatgrade9.Text & "', '" & txttlecgrade9.Text & "', '" & txttleecagrade9.Text & "', '" & txtmapeh1grade9.Text & "', '" & txtmapeh2grade9.Text & "', '" & txtmapeh3grade9.Text & "', '" & txtmapeh4grade9.Text & "', '" & txtmapehfrgrade9.Text & "', '" & txtmapehatgrade9.Text & "', '" & txtmapehcgrade9.Text & "', '" & txtmapehecagrade9.Text & "', '" & txtmusic1grade9.Text & "', '" & txtmusic2grade9.Text & "', '" & txtmusic3grade9.Text & "', '" & txtmusic4grade9.Text & "', '" & txtmusicfrgrade9.Text & "', '" & txtmusicatgrade9.Text & "', '" & txtmusiccgrade9.Text & "', '" & txtmusicecagrade9.Text & "', '" & txtarts1grade9.Text & "', '" & txtarts2grade9.Text & "', '" & txtarts3grade9.Text & "', '" & txtarts4grade9.Text & "', '" & txtartsfrgrade9.Text & "', '" & txtartsatgrade9.Text & "', '" & txtartscgrade9.Text & "', '" & txtartsecagrade9.Text & "', '" & txtpe1grade9.Text & "', '" & txtpe2grade9.Text & "', '" & txtpe3grade9.Text & "', '" & txtpe4grade9.Text & "', '" & txtpefrgrade9.Text & "', '" & txtpeatgrade9.Text & "', '" & txtpecgrade9.Text & "', '" & txtpeecagrade9.Text & "', '" & txthealth1grade9.Text & "', '" & txthealth2grade9.Text & "', '" & txthealth3grade9.Text & "', '" & txthealth4grade9.Text & "', '" & txthealthfrgrade9.Text & "', '" & txthealthatgrade9.Text & "', '" & txthealthcgrade9.Text & "', '" & txthealthecagrade9.Text & "', '" & txtaveragefrgrade9.Text & "', '" & txtaverageatgrade9.Text & "', '" & txtaveragecgrade9.Text & "')"
                    insertQuery5 = "INSERT INTO studrecordgrade10Tbl(lrn,classifiedgrade10,totalyearsgrade10,yeargrade10,sectiongrade10,schoolgrade10,schoolyeargrade10,cs1filipinograde10,cs2filipinograde10,cs3filipinograde10,cs4filipinograde10,filipinofinalratinggrade10,filipinoactiontakengrade10,filipinocreditgrade10,filipinoecagrade10,cs1englishgrade10,cs2englishgrade10,cs3englishgrade10,cs4englishgrade10,englishfinalratinggrade10,englishactiontakengrade10,englishcreditgrade10,englishecagrade10,cs1mathgrade10,cs2mathgrade10,cs3mathgrade10,cs4mathgrade10,mathfinalratinggrade10,mathactiontakengrade10,mathcreditgrade10,mathecagrade10,cs1sciencegrade10,cs2sciencegrade10,cs3sciencegrade10,cs4sciencegrade10,sciencefinalratinggrade10,scienceactiontakengrade10,sciencecreditgrade10,scienceecagrade10,cs1apgrade10,cs2apgrade10,cs3apgrade10,cs4apgrade10,apfinalratinggrade10,apactiontakengrade10,apcreditgrade10,apecagrade10,cs1espgrade10,cs2espgrade10,cs3espgrade10,cs4espgrade10,espfinalratinggrade10,espactiontakengrade10,espcreditgrade10,especagrade10,cs1tlegrade10,cs2tlegrade10,cs3tlegrade10,cs4tlegrade10,tlefinalratinggrade10,tleactiontakengrade10,tlecreditgrade10,tleecagrade10,cs1mapehgrade10,cs2mapehgrade10,cs3mapehgrade10,cs4mapehgrade10,mapehfinalratinggrade10,mapehactiontakengrade10,mapehcreditgrade10,mapehecagrade10,cs1musicgrade10,cs2musicgrade10,cs3musicgrade10,cs4musicgrade10,musicfinalratinggrade10,musicactiontakengrade10,musiccreditgrade10,musicecagrade10,cs1artsgrade10,cs2artsgrade10,cs3artsgrade10,cs4artsgrade10,artsfinalratinggrade10,artsactiontakengrade10,artscreditgrade10,artsecagrade10,cs1pegrade10,cs2pegrade10,cs3pegrade10,cs4pegrade10,pefinalratinggrade10,peactiontakengrade10,pecreditgrade10,peecagrade10,cs1healthgrade10,cs2healthgrade10,cs3healthgrade10,cs4healthgrade10,healthfinalratinggrade10,healthactiontakengrade10,healthcreditgrade10,healthecagrade10,averagegrade10,averageactiontakengrade10,averagecreditgrade10) VALUES ('" & txtlrn.Text & "' , '" & txtclassifiedgrade10.Text & "', '" & cbtotalyearsgrade10.Text & "', '" & txtyeargrade10.Text & "' , '" & txtsectiongrade10.Text & "', '" & txtschoolgrade10.Text & "', '" & cbschoolyeargrade10.Text & "', '" & txtfilipino1grade10.Text & "', '" & txtfilipino2grade10.Text & "', '" & txtfilipino3grade10.Text & "', '" & txtfilipino4grade10.Text & "', '" & txtfilipinofrgrade10.Text & "', '" & txtfilipinoatgrade10.Text & "', '" & txtfilipinocgrade10.Text & "', '" & txtfilipinoecagrade10.Text & "', '" & txtenglish1grade10.Text & "', '" & txtenglish2grade10.Text & "', '" & txtenglish3grade10.Text & "', '" & txtenglish4grade10.Text & "', '" & txtenglishfrgrade10.Text & "', '" & txtenglishatgrade10.Text & "', '" & txtenglishcgrade10.Text & "', '" & txtenglishecagrade10.Text & "', '" & txtmath1grade10.Text & "', '" & txtmath2grade10.Text & "', '" & txtmath3grade10.Text & "', '" & txtmath4grade10.Text & "', '" & txtmathfrgrade10.Text & "', '" & txtmathatgrade10.Text & "', '" & txtmathcgrade10.Text & "', '" & txtmathecagrade10.Text & "', '" & txtscience1grade10.Text & "', '" & txtscience2grade10.Text & "', '" & txtscience3grade10.Text & "', '" & txtscience4grade10.Text & "', '" & txtsciencefrgrade10.Text & "', '" & txtscienceatgrade10.Text & "', '" & txtsciencecgrade10.Text & "', '" & txtscienceecagrade10.Text & "', '" & txtap1grade10.Text & "', '" & txtap2grade10.Text & "', '" & txtap3grade10.Text & "', '" & txtap4grade10.Text & "', '" & txtapfrgrade10.Text & "', '" & txtapatgrade10.Text & "', '" & txtapcgrade10.Text & "', '" & txtapecagrade10.Text & "', '" & txtesp1grade10.Text & "', '" & txtesp2grade10.Text & "', '" & txtesp3grade10.Text & "', '" & txtesp4grade10.Text & "', '" & txtespfrgrade10.Text & "', '" & txtespatgrade10.Text & "', '" & txtespcgrade10.Text & "', '" & txtespecagrade10.Text & "', '" & txttle1grade10.Text & "', '" & txttle2grade10.Text & "', '" & txttle3grade10.Text & "', '" & txttle4grade10.Text & "', '" & txttlefrgrade10.Text & "', '" & txttleatgrade10.Text & "', '" & txttlecgrade10.Text & "', '" & txttleecagrade10.Text & "', '" & txtmapeh1grade10.Text & "', '" & txtmapeh2grade10.Text & "', '" & txtmapeh3grade10.Text & "', '" & txtmapeh4grade10.Text & "', '" & txtmapehfrgrade10.Text & "', '" & txtmapehatgrade10.Text & "', '" & txtmapehcgrade10.Text & "', '" & txtmapehecagrade10.Text & "', '" & txtmusic1grade10.Text & "', '" & txtmusic2grade10.Text & "', '" & txtmusic3grade10.Text & "', '" & txtmusic4grade10.Text & "', '" & txtmusicfrgrade10.Text & "', '" & txtmusicatgrade10.Text & "', '" & txtmusiccgrade10.Text & "', '" & txtmusicecagrade10.Text & "', '" & txtarts1grade10.Text & "', '" & txtarts2grade10.Text & "', '" & txtarts3grade10.Text & "', '" & txtarts4grade10.Text & "', '" & txtartsfrgrade10.Text & "', '" & txtartsatgrade10.Text & "', '" & txtartscgrade10.Text & "', '" & txtartsecagrade10.Text & "', '" & txtpe1grade10.Text & "', '" & txtpe2grade10.Text & "', '" & txtpe3grade10.Text & "', '" & txtpe4grade10.Text & "', '" & txtpefrgrade10.Text & "', '" & txtpeatgrade10.Text & "', '" & txtpecgrade10.Text & "', '" & txtpeecagrade10.Text & "', '" & txthealth1grade10.Text & "', '" & txthealth2grade10.Text & "', '" & txthealth3grade10.Text & "', '" & txthealth4grade10.Text & "', '" & txthealthfrgrade10.Text & "', '" & txthealthatgrade10.Text & "', '" & txthealthcgrade10.Text & "', '" & txthealthecagrade10.Text & "', '" & txtaveragefrgrade10.Text & "', '" & txtaverageatgrade10.Text & "', '" & txtaveragecgrade10.Text & "')"
                    insertQuery6 = "INSERT INTO studattendancegrade7Tbl(lrn,dsjungrade7,dsjulgrade7,dsauggrade7,dssepgrade7,dsoctgrade7,dsnovgrade7,dsdecgrade7,dsjangrade7,dsfebgrade7,dsmargrade7,dsaprgrade7,dstotalgrade7,dpjungrade7,dpjulgrade7,dpauggrade7,dpsepgrade7,dpoctgrade7,dpnovgrade7,dpdecgrade7,dpjangrade7,dpfebgrade7,dpmargrade7,dpaprgrade7,dptotalgrade7,advisergrade7,advancedunitsgrade7,lackunitsgrade7) VALUES ('" & txtlrn.Text & "' , '" & txtdsjungrade7.Text & "', '" & txtdsjulgrade7.Text & "', '" & txtdsauggrade7.Text & "', '" & txtdssepgrade7.Text & "', '" & txtdsoctgrade7.Text & "', '" & txtdsnovgrade7.Text & "', '" & txtdsdecgrade7.Text & "', '" & txtdsjangrade7.Text & "', '" & txtdsfebgrade7.Text & "', '" & txtdsmargrade7.Text & "', '" & txtdsaprgrade7.Text & "', '" & txtdstotalgrade7.Text & "', '" & txtdpjungrade7.Text & "', '" & txtdpjulgrade7.Text & "', '" & txtdpauggrade7.Text & "', '" & txtdpsepgrade7.Text & "', '" & txtdpoctgrade7.Text & "', '" & txtdpnovgrade7.Text & "', '" & txtdpdecgrade7.Text & "', '" & txtdpjangrade7.Text & "', '" & txtdpfebgrade7.Text & "', '" & txtdpmargrade7.Text & "', '" & txtdpaprgrade7.Text & "', '" & txtdptotalgrade7.Text & "', '" & txtadvisergrade7.Text & "', '" & txtadvancedunitsgrade7.Text & "', '" & txtlackunitsgrade7.Text & "')"
                    insertQuery7 = "INSERT INTO studattendancegrade8Tbl(lrn,dsjungrade8,dsjulgrade8,dsauggrade8,dssepgrade8,dsoctgrade8,dsnovgrade8,dsdecgrade8,dsjangrade8,dsfebgrade8,dsmargrade8,dsaprgrade8,dstotalgrade8,dpjungrade8,dpjulgrade8,dpauggrade8,dpsepgrade8,dpoctgrade8,dpnovgrade8,dpdecgrade8,dpjangrade8,dpfebgrade8,dpmargrade8,dpaprgrade8,dptotalgrade8,advisergrade8,advancedunitsgrade8,lackunitsgrade8) VALUES ('" & txtlrn.Text & "' , '" & txtdsjungrade8.Text & "', '" & txtdsjulgrade8.Text & "', '" & txtdsauggrade8.Text & "', '" & txtdssepgrade8.Text & "', '" & txtdsoctgrade8.Text & "', '" & txtdsnovgrade8.Text & "', '" & txtdsdecgrade8.Text & "', '" & txtdsjangrade8.Text & "', '" & txtdsfebgrade8.Text & "', '" & txtdsmargrade8.Text & "', '" & txtdsaprgrade8.Text & "', '" & txtdstotalgrade8.Text & "', '" & txtdpjungrade8.Text & "', '" & txtdpjulgrade8.Text & "', '" & txtdpauggrade8.Text & "', '" & txtdpsepgrade8.Text & "', '" & txtdpoctgrade8.Text & "', '" & txtdpnovgrade8.Text & "', '" & txtdpdecgrade8.Text & "', '" & txtdpjangrade8.Text & "', '" & txtdpfebgrade8.Text & "', '" & txtdpmargrade8.Text & "', '" & txtdpaprgrade8.Text & "', '" & txtdptotalgrade8.Text & "', '" & txtadvisergrade8.Text & "', '" & txtadvancedunitsgrade8.Text & "', '" & txtlackunitsgrade8.Text & "')"
                    insertQuery8 = "INSERT INTO studattendancegrade9Tbl(lrn,dsjungrade9,dsjulgrade9,dsauggrade9,dssepgrade9,dsoctgrade9,dsnovgrade9,dsdecgrade9,dsjangrade9,dsfebgrade9,dsmargrade9,dsaprgrade9,dstotalgrade9,dpjungrade9,dpjulgrade9,dpauggrade9,dpsepgrade9,dpoctgrade9,dpnovgrade9,dpdecgrade9,dpjangrade9,dpfebgrade9,dpmargrade9,dpaprgrade9,dptotalgrade9,advisergrade9,advancedunitsgrade9,lackunitsgrade9) VALUES ('" & txtlrn.Text & "' , '" & txtdsjungrade9.Text & "', '" & txtdsjulgrade9.Text & "', '" & txtdsauggrade9.Text & "', '" & txtdssepgrade9.Text & "', '" & txtdsoctgrade9.Text & "', '" & txtdsnovgrade9.Text & "', '" & txtdsdecgrade9.Text & "', '" & txtdsjangrade9.Text & "', '" & txtdsfebgrade9.Text & "', '" & txtdsmargrade9.Text & "', '" & txtdsaprgrade9.Text & "', '" & txtdstotalgrade9.Text & "', '" & txtdpjungrade9.Text & "', '" & txtdpjulgrade9.Text & "', '" & txtdpauggrade9.Text & "', '" & txtdpsepgrade9.Text & "', '" & txtdpoctgrade9.Text & "', '" & txtdpnovgrade9.Text & "', '" & txtdpdecgrade9.Text & "', '" & txtdpjangrade9.Text & "', '" & txtdpfebgrade9.Text & "', '" & txtdpmargrade9.Text & "', '" & txtdpaprgrade9.Text & "', '" & txtdptotalgrade9.Text & "', '" & txtadvisergrade9.Text & "', '" & txtadvancedunitsgrade9.Text & "', '" & txtlackunitsgrade9.Text & "')"
                    insertQuery9 = "INSERT INTO studattendancegrade10Tbl(lrn,dsjungrade10,dsjulgrade10,dsauggrade10,dssepgrade10,dsoctgrade10,dsnovgrade10,dsdecgrade10,dsjangrade10,dsfebgrade10,dsmargrade10,dsaprgrade10,dstotalgrade10,dpjungrade10,dpjulgrade10,dpauggrade10,dpsepgrade10,dpoctgrade10,dpnovgrade10,dpdecgrade10,dpjangrade10,dpfebgrade10,dpmargrade10,dpaprgrade10,dptotalgrade10,advisergrade10,advancedunitsgrade10,lackunitsgrade10) VALUES ('" & txtlrn.Text & "' , '" & txtdsjungrade10.Text & "', '" & txtdsjulgrade10.Text & "', '" & txtdsauggrade10.Text & "', '" & txtdssepgrade10.Text & "', '" & txtdsoctgrade10.Text & "', '" & txtdsnovgrade10.Text & "', '" & txtdsdecgrade10.Text & "', '" & txtdsjangrade10.Text & "', '" & txtdsfebgrade10.Text & "', '" & txtdsmargrade10.Text & "', '" & txtdsaprgrade10.Text & "', '" & txtdstotalgrade10.Text & "', '" & txtdpjungrade10.Text & "', '" & txtdpjulgrade10.Text & "', '" & txtdpauggrade10.Text & "', '" & txtdpsepgrade10.Text & "', '" & txtdpoctgrade10.Text & "', '" & txtdpnovgrade10.Text & "', '" & txtdpdecgrade10.Text & "', '" & txtdpjangrade10.Text & "', '" & txtdpfebgrade10.Text & "', '" & txtdpmargrade10.Text & "', '" & txtdpaprgrade10.Text & "', '" & txtdptotalgrade10.Text & "', '" & txtadvisergrade10.Text & "', '" & txtadvancedunitsgrade10.Text & "', '" & txtlackunitsgrade10.Text & "')"
                    Dim command1 As New SqlCommand(insertQuery1, conn)
                    Dim command2 As New SqlCommand(insertQuery2, conn)
                    Dim command3 As New SqlCommand(insertQuery3, conn)
                    Dim command4 As New SqlCommand(insertQuery4, conn)
                    Dim command5 As New SqlCommand(insertQuery5, conn)
                    Dim command6 As New SqlCommand(insertQuery6, conn)
                    Dim command7 As New SqlCommand(insertQuery7, conn)
                    Dim command8 As New SqlCommand(insertQuery8, conn)
                    Dim command9 As New SqlCommand(insertQuery9, conn)
                    command1.ExecuteNonQuery()
                    command2.ExecuteNonQuery()
                    command3.ExecuteNonQuery()
                    command4.ExecuteNonQuery()
                    command5.ExecuteNonQuery()
                    command6.ExecuteNonQuery()
                    command7.ExecuteNonQuery()
                    command8.ExecuteNonQuery()
                    command9.ExecuteNonQuery()
                    MessageBox.Show("Information Saved")
                    txtlrn.ForeColor = Color.Gray
                    txtname.ForeColor = Color.Gray
                    txtbirthplace.ForeColor = Color.Gray
                    txttown.ForeColor = Color.Gray
                    txtbrgy.ForeColor = Color.Gray
                    txtparent.ForeColor = Color.Gray
                    txtoccupation.ForeColor = Color.Gray
                    txtaddress.ForeColor = Color.Gray
                    txtelementaryschool.ForeColor = Color.Gray
                    txtgenave.ForeColor = Color.Gray
                    txtsectiongrade7.ForeColor = Color.Gray
                    txtschoolgrade7.ForeColor = Color.Gray
                    txtsectiongrade8.ForeColor = Color.Gray
                    txtschoolgrade8.ForeColor = Color.Gray
                    txtsectiongrade9.ForeColor = Color.Gray
                    txtschoolgrade9.ForeColor = Color.Gray
                    txtsectiongrade10.ForeColor = Color.Gray
                    txtschoolgrade10.ForeColor = Color.Gray
                    txtlrn.Text = "Student LRN..."
                    txtname.Text = "Type the Full Name of the Student..."
                    txtbirthplace.Text = "Type the Birthplace/Province..."
                    txttown.Text = "Type the Town/City..."
                    txtbrgy.Text = "Type the Barangay..."
                    txtparent.Text = "Parent/Guardian's Fullname..."
                    txtoccupation.Text = "Occupation of the Parent/Guardian..."
                    txtaddress.Text = "Address of the Parent/Guardian..."
                    txtelementaryschool.Text = "Elementary School Graduated..."
                    txtgenave.Text = "Ave. Grade..."
                    dtpdateofbirth.Text = Nothing
                    cbgender.Text = Nothing
                    cbyeargrad.Text = Nothing
                    txtclassifiedgrade7.Text = "GRADE 7"
                    cbtotalyearsgrade7.Text = Nothing
                    txtyeargrade7.Text = "7"
                    txtsectiongrade7.Text = "Section..."
                    txtschoolgrade7.Text = "School..."
                    cbschoolyeargrade7.Text = Nothing
                    txtfilipino1grade7.Text = ""
                    txtfilipino2grade7.Text = ""
                    txtfilipino3grade7.Text = ""
                    txtfilipino4grade7.Text = ""
                    txtfilipinofrgrade7.Text = "0"
                    txtfilipinoatgrade7.Text = ""
                    txtfilipinocgrade7.Text = ""
                    txtfilipinoecagrade7.Text = ""
                    txtenglish1grade7.Text = ""
                    txtenglish2grade7.Text = ""
                    txtenglish3grade7.Text = ""
                    txtenglish4grade7.Text = ""
                    txtenglishfrgrade7.Text = "0"
                    txtenglishatgrade7.Text = ""
                    txtenglishcgrade7.Text = ""
                    txtenglishecagrade7.Text = ""
                    txtmath1grade7.Text = ""
                    txtmath2grade7.Text = ""
                    txtmath3grade7.Text = ""
                    txtmath4grade7.Text = ""
                    txtmathfrgrade7.Text = "0"
                    txtmathatgrade7.Text = ""
                    txtmathcgrade7.Text = ""
                    txtmathecagrade7.Text = ""
                    txtscience1grade7.Text = ""
                    txtscience2grade7.Text = ""
                    txtscience3grade7.Text = ""
                    txtscience4grade7.Text = ""
                    txtsciencefrgrade7.Text = "0"
                    txtscienceatgrade7.Text = ""
                    txtsciencecgrade7.Text = ""
                    txtscienceecagrade7.Text = ""
                    txtap1grade7.Text = ""
                    txtap2grade7.Text = ""
                    txtap3grade7.Text = ""
                    txtap4grade7.Text = ""
                    txtapfrgrade7.Text = "0"
                    txtapatgrade7.Text = ""
                    txtapcgrade7.Text = ""
                    txtapecagrade7.Text = ""
                    txtesp1grade7.Text = ""
                    txtesp2grade7.Text = ""
                    txtesp3grade7.Text = ""
                    txtesp4grade7.Text = ""
                    txtespfrgrade7.Text = "0"
                    txtespatgrade7.Text = ""
                    txtespcgrade7.Text = ""
                    txtespecagrade7.Text = ""
                    txttle1grade7.Text = ""
                    txttle2grade7.Text = ""
                    txttle3grade7.Text = ""
                    txttle4grade7.Text = ""
                    txttlefrgrade7.Text = "0"
                    txttleatgrade7.Text = ""
                    txttlecgrade7.Text = ""
                    txttleecagrade7.Text = ""
                    txtmapeh1grade7.Text = ""
                    txtmapeh2grade7.Text = ""
                    txtmapeh3grade7.Text = ""
                    txtmapeh4grade7.Text = ""
                    txtmapehfrgrade7.Text = "0"
                    txtmapehatgrade7.Text = ""
                    txtmapehcgrade7.Text = ""
                    txtmapehecagrade7.Text = ""
                    txtmusic1grade7.Text = ""
                    txtmusic2grade7.Text = ""
                    txtmusic3grade7.Text = ""
                    txtmusic4grade7.Text = ""
                    txtmusicfrgrade7.Text = "0"
                    txtmusicatgrade7.Text = ""
                    txtmusiccgrade7.Text = ""
                    txtmusicecagrade7.Text = ""
                    txtarts1grade7.Text = ""
                    txtarts2grade7.Text = ""
                    txtarts3grade7.Text = ""
                    txtarts4grade7.Text = ""
                    txtartsfrgrade7.Text = "0"
                    txtartsatgrade7.Text = ""
                    txtartscgrade7.Text = ""
                    txtartsecagrade7.Text = ""
                    txtpe1grade7.Text = ""
                    txtpe2grade7.Text = ""
                    txtpe3grade7.Text = ""
                    txtpe4grade7.Text = ""
                    txtpefrgrade7.Text = "0"
                    txtpeatgrade7.Text = ""
                    txtpecgrade7.Text = ""
                    txtpeecagrade7.Text = ""
                    txthealth1grade7.Text = ""
                    txthealth2grade7.Text = ""
                    txthealth3grade7.Text = ""
                    txthealth4grade7.Text = ""
                    txthealthfrgrade7.Text = "0"
                    txthealthatgrade7.Text = ""
                    txthealthcgrade7.Text = ""
                    txthealthecagrade7.Text = ""
                    txtaveragefrgrade7.Text = "0"
                    txtaverageatgrade7.Text = ""
                    txtaveragecgrade7.Text = ""
                    txtclassifiedgrade8.Text = "GRADE 8"
                    cbtotalyearsgrade8.Text = Nothing
                    txtyeargrade8.Text = "8"
                    txtsectiongrade8.Text = "Section..."
                    txtschoolgrade8.Text = "School..."
                    cbschoolyeargrade8.Text = Nothing
                    txtfilipino1grade8.Text = ""
                    txtfilipino2grade8.Text = ""
                    txtfilipino3grade8.Text = ""
                    txtfilipino4grade8.Text = ""
                    txtfilipinofrgrade8.Text = "0"
                    txtfilipinoatgrade8.Text = ""
                    txtfilipinocgrade8.Text = ""
                    txtfilipinoecagrade8.Text = ""
                    txtenglish1grade8.Text = ""
                    txtenglish2grade8.Text = ""
                    txtenglish3grade8.Text = ""
                    txtenglish4grade8.Text = ""
                    txtenglishfrgrade8.Text = "0"
                    txtenglishatgrade8.Text = ""
                    txtenglishcgrade8.Text = ""
                    txtenglishecagrade8.Text = ""
                    txtmath1grade8.Text = ""
                    txtmath2grade8.Text = ""
                    txtmath3grade8.Text = ""
                    txtmath4grade8.Text = ""
                    txtmathfrgrade8.Text = "0"
                    txtmathatgrade8.Text = ""
                    txtmathcgrade8.Text = ""
                    txtmathecagrade8.Text = ""
                    txtscience1grade8.Text = ""
                    txtscience2grade8.Text = ""
                    txtscience3grade8.Text = ""
                    txtscience4grade8.Text = ""
                    txtsciencefrgrade8.Text = "0"
                    txtscienceatgrade8.Text = ""
                    txtsciencecgrade8.Text = ""
                    txtscienceecagrade8.Text = ""
                    txtap1grade8.Text = ""
                    txtap2grade8.Text = ""
                    txtap3grade8.Text = ""
                    txtap4grade8.Text = ""
                    txtapfrgrade8.Text = "0"
                    txtapatgrade8.Text = ""
                    txtapcgrade8.Text = ""
                    txtapecagrade8.Text = ""
                    txtesp1grade8.Text = ""
                    txtesp2grade8.Text = ""
                    txtesp3grade8.Text = ""
                    txtesp4grade8.Text = ""
                    txtespfrgrade8.Text = "0"
                    txtespatgrade8.Text = ""
                    txtespcgrade8.Text = ""
                    txtespecagrade8.Text = ""
                    txttle1grade8.Text = ""
                    txttle2grade8.Text = ""
                    txttle3grade8.Text = ""
                    txttle4grade8.Text = ""
                    txttlefrgrade8.Text = "0"
                    txttleatgrade8.Text = ""
                    txttlecgrade8.Text = ""
                    txttleecagrade8.Text = ""
                    txtmapeh1grade8.Text = ""
                    txtmapeh2grade8.Text = ""
                    txtmapeh3grade8.Text = ""
                    txtmapeh4grade8.Text = ""
                    txtmapehfrgrade8.Text = "0"
                    txtmapehatgrade8.Text = ""
                    txtmapehcgrade8.Text = ""
                    txtmapehecagrade8.Text = ""
                    txtmusic1grade8.Text = ""
                    txtmusic2grade8.Text = ""
                    txtmusic3grade8.Text = ""
                    txtmusic4grade8.Text = ""
                    txtmusicfrgrade8.Text = "0"
                    txtmusicatgrade8.Text = ""
                    txtmusiccgrade8.Text = ""
                    txtmusicecagrade8.Text = ""
                    txtarts1grade8.Text = ""
                    txtarts2grade8.Text = ""
                    txtarts3grade8.Text = ""
                    txtarts4grade8.Text = ""
                    txtartsfrgrade8.Text = "0"
                    txtartsatgrade8.Text = ""
                    txtartscgrade8.Text = ""
                    txtartsecagrade8.Text = ""
                    txtpe1grade8.Text = ""
                    txtpe2grade8.Text = ""
                    txtpe3grade8.Text = ""
                    txtpe4grade8.Text = ""
                    txtpefrgrade8.Text = "0"
                    txtpeatgrade8.Text = ""
                    txtpecgrade8.Text = ""
                    txtpeecagrade8.Text = ""
                    txthealth1grade8.Text = ""
                    txthealth2grade8.Text = ""
                    txthealth3grade8.Text = ""
                    txthealth4grade8.Text = ""
                    txthealthfrgrade8.Text = "0"
                    txthealthatgrade8.Text = ""
                    txthealthcgrade8.Text = ""
                    txthealthecagrade8.Text = ""
                    txtaveragefrgrade8.Text = "0"
                    txtaverageatgrade8.Text = ""
                    txtaveragecgrade8.Text = ""
                    txtclassifiedgrade9.Text = "GRADE 9"
                    cbtotalyearsgrade9.Text = Nothing
                    txtyeargrade9.Text = "9"
                    txtsectiongrade9.Text = "Section..."
                    txtschoolgrade9.Text = "School..."
                    cbschoolyeargrade9.Text = Nothing
                    txtfilipino1grade9.Text = ""
                    txtfilipino2grade9.Text = ""
                    txtfilipino3grade9.Text = ""
                    txtfilipino4grade9.Text = ""
                    txtfilipinofrgrade9.Text = "0"
                    txtfilipinoatgrade9.Text = ""
                    txtfilipinocgrade9.Text = ""
                    txtfilipinoecagrade9.Text = ""
                    txtenglish1grade9.Text = ""
                    txtenglish2grade9.Text = ""
                    txtenglish3grade9.Text = ""
                    txtenglish4grade9.Text = ""
                    txtenglishfrgrade9.Text = "0"
                    txtenglishatgrade9.Text = ""
                    txtenglishcgrade9.Text = ""
                    txtenglishecagrade9.Text = ""
                    txtmath1grade9.Text = ""
                    txtmath2grade9.Text = ""
                    txtmath3grade9.Text = ""
                    txtmath4grade9.Text = ""
                    txtmathfrgrade9.Text = "0"
                    txtmathatgrade9.Text = ""
                    txtmathcgrade9.Text = ""
                    txtmathecagrade9.Text = ""
                    txtscience1grade9.Text = ""
                    txtscience2grade9.Text = ""
                    txtscience3grade9.Text = ""
                    txtscience4grade9.Text = ""
                    txtsciencefrgrade9.Text = "0"
                    txtscienceatgrade9.Text = ""
                    txtsciencecgrade9.Text = ""
                    txtscienceecagrade9.Text = ""
                    txtap1grade9.Text = ""
                    txtap2grade9.Text = ""
                    txtap3grade9.Text = ""
                    txtap4grade9.Text = ""
                    txtapfrgrade9.Text = "0"
                    txtapatgrade9.Text = ""
                    txtapcgrade9.Text = ""
                    txtapecagrade9.Text = ""
                    txtesp1grade9.Text = ""
                    txtesp2grade9.Text = ""
                    txtesp3grade9.Text = ""
                    txtesp4grade9.Text = ""
                    txtespfrgrade9.Text = "0"
                    txtespatgrade9.Text = ""
                    txtespcgrade9.Text = ""
                    txtespecagrade9.Text = ""
                    txttle1grade9.Text = ""
                    txttle2grade9.Text = ""
                    txttle3grade9.Text = ""
                    txttle4grade9.Text = ""
                    txttlefrgrade9.Text = "0"
                    txttleatgrade9.Text = ""
                    txttlecgrade9.Text = ""
                    txttleecagrade9.Text = ""
                    txtmapeh1grade9.Text = ""
                    txtmapeh2grade9.Text = ""
                    txtmapeh3grade9.Text = ""
                    txtmapeh4grade9.Text = ""
                    txtmapehfrgrade9.Text = "0"
                    txtmapehatgrade9.Text = ""
                    txtmapehcgrade9.Text = ""
                    txtmapehecagrade9.Text = ""
                    txtmusic1grade9.Text = ""
                    txtmusic2grade9.Text = ""
                    txtmusic3grade9.Text = ""
                    txtmusic4grade9.Text = ""
                    txtmusicfrgrade9.Text = "0"
                    txtmusicatgrade9.Text = ""
                    txtmusiccgrade9.Text = ""
                    txtmusicecagrade9.Text = ""
                    txtarts1grade9.Text = ""
                    txtarts2grade9.Text = ""
                    txtarts3grade9.Text = ""
                    txtarts4grade9.Text = ""
                    txtartsfrgrade9.Text = "0"
                    txtartsatgrade9.Text = ""
                    txtartscgrade9.Text = ""
                    txtartsecagrade9.Text = ""
                    txtpe1grade9.Text = ""
                    txtpe2grade9.Text = ""
                    txtpe3grade9.Text = ""
                    txtpe4grade9.Text = ""
                    txtpefrgrade9.Text = "0"
                    txtpeatgrade9.Text = ""
                    txtpecgrade9.Text = ""
                    txtpeecagrade9.Text = ""
                    txthealth1grade9.Text = ""
                    txthealth2grade9.Text = ""
                    txthealth3grade9.Text = ""
                    txthealth4grade9.Text = ""
                    txthealthfrgrade9.Text = "0"
                    txthealthatgrade9.Text = ""
                    txthealthcgrade9.Text = ""
                    txthealthecagrade9.Text = ""
                    txtaveragefrgrade9.Text = "0"
                    txtaverageatgrade9.Text = ""
                    txtaveragecgrade9.Text = ""
                    txtclassifiedgrade10.Text = "GRADE 10"
                    cbtotalyearsgrade10.Text = Nothing
                    txtyeargrade10.Text = "10"
                    txtsectiongrade10.Text = "Section..."
                    txtschoolgrade10.Text = "School..."
                    cbschoolyeargrade10.Text = Nothing
                    txtfilipino1grade10.Text = ""
                    txtfilipino2grade10.Text = ""
                    txtfilipino3grade10.Text = ""
                    txtfilipino4grade10.Text = ""
                    txtfilipinofrgrade10.Text = "0"
                    txtfilipinoatgrade10.Text = ""
                    txtfilipinocgrade10.Text = ""
                    txtfilipinoecagrade10.Text = ""
                    txtenglish1grade10.Text = ""
                    txtenglish2grade10.Text = ""
                    txtenglish3grade10.Text = ""
                    txtenglish4grade10.Text = ""
                    txtenglishfrgrade10.Text = "0"
                    txtenglishatgrade10.Text = ""
                    txtenglishcgrade10.Text = ""
                    txtenglishecagrade10.Text = ""
                    txtmath1grade10.Text = ""
                    txtmath2grade10.Text = ""
                    txtmath3grade10.Text = ""
                    txtmath4grade10.Text = ""
                    txtmathfrgrade10.Text = "0"
                    txtmathatgrade10.Text = ""
                    txtmathcgrade10.Text = ""
                    txtmathecagrade10.Text = ""
                    txtscience1grade10.Text = ""
                    txtscience2grade10.Text = ""
                    txtscience3grade10.Text = ""
                    txtscience4grade10.Text = ""
                    txtsciencefrgrade10.Text = "0"
                    txtscienceatgrade10.Text = ""
                    txtsciencecgrade10.Text = ""
                    txtscienceecagrade10.Text = ""
                    txtap1grade10.Text = ""
                    txtap2grade10.Text = ""
                    txtap3grade10.Text = ""
                    txtap4grade10.Text = ""
                    txtapfrgrade10.Text = "0"
                    txtapatgrade10.Text = ""
                    txtapcgrade10.Text = ""
                    txtapecagrade10.Text = ""
                    txtesp1grade10.Text = ""
                    txtesp2grade10.Text = ""
                    txtesp3grade10.Text = ""
                    txtesp4grade10.Text = ""
                    txtespfrgrade10.Text = "0"
                    txtespatgrade10.Text = ""
                    txtespcgrade10.Text = ""
                    txtespecagrade10.Text = ""
                    txttle1grade10.Text = ""
                    txttle2grade10.Text = ""
                    txttle3grade10.Text = ""
                    txttle4grade10.Text = ""
                    txttlefrgrade10.Text = "0"
                    txttleatgrade10.Text = ""
                    txttlecgrade10.Text = ""
                    txttleecagrade10.Text = ""
                    txtmapeh1grade10.Text = ""
                    txtmapeh2grade10.Text = ""
                    txtmapeh3grade10.Text = ""
                    txtmapeh4grade10.Text = ""
                    txtmapehfrgrade10.Text = "0"
                    txtmapehatgrade10.Text = ""
                    txtmapehcgrade10.Text = ""
                    txtmapehecagrade10.Text = ""
                    txtmusic1grade10.Text = ""
                    txtmusic2grade10.Text = ""
                    txtmusic3grade10.Text = ""
                    txtmusic4grade10.Text = ""
                    txtmusicfrgrade10.Text = "0"
                    txtmusicatgrade10.Text = ""
                    txtmusiccgrade10.Text = ""
                    txtmusicecagrade10.Text = ""
                    txtarts1grade10.Text = ""
                    txtarts2grade10.Text = ""
                    txtarts3grade10.Text = ""
                    txtarts4grade10.Text = ""
                    txtartsfrgrade10.Text = "0"
                    txtartsatgrade10.Text = ""
                    txtartscgrade10.Text = ""
                    txtartsecagrade10.Text = ""
                    txtpe1grade10.Text = ""
                    txtpe2grade10.Text = ""
                    txtpe3grade10.Text = ""
                    txtpe4grade10.Text = ""
                    txtpefrgrade10.Text = "0"
                    txtpeatgrade10.Text = ""
                    txtpecgrade10.Text = ""
                    txtpeecagrade10.Text = ""
                    txthealth1grade10.Text = ""
                    txthealth2grade10.Text = ""
                    txthealth3grade10.Text = ""
                    txthealth4grade10.Text = ""
                    txthealthfrgrade10.Text = "0"
                    txthealthatgrade10.Text = ""
                    txthealthcgrade10.Text = ""
                    txthealthecagrade10.Text = ""
                    txtaveragefrgrade10.Text = "0"
                    txtaverageatgrade10.Text = ""
                    txtaveragecgrade10.Text = ""
                    txtdsjungrade7.Text = ""
                    txtdsjulgrade7.Text = ""
                    txtdsauggrade7.Text = ""
                    txtdssepgrade7.Text = ""
                    txtdsoctgrade7.Text = ""
                    txtdsnovgrade7.Text = ""
                    txtdsdecgrade7.Text = ""
                    txtdsjangrade7.Text = ""
                    txtdsfebgrade7.Text = ""
                    txtdsmargrade7.Text = ""
                    txtdsaprgrade7.Text = ""
                    txtdstotalgrade7.Text = ""
                    txtdpjungrade7.Text = ""
                    txtdpjulgrade7.Text = ""
                    txtdpauggrade7.Text = ""
                    txtdpsepgrade7.Text = ""
                    txtdpoctgrade7.Text = ""
                    txtdpnovgrade7.Text = ""
                    txtdpdecgrade7.Text = ""
                    txtdpjangrade7.Text = ""
                    txtdpfebgrade7.Text = ""
                    txtdpmargrade7.Text = ""
                    txtdpaprgrade7.Text = ""
                    txtdptotalgrade7.Text = ""
                    txtadvisergrade7.Text = ""
                    txtadvancedunitsgrade7.Text = ""
                    txtlackunitsgrade7.Text = ""
                    txtdsjungrade8.Text = ""
                    txtdsjulgrade8.Text = ""
                    txtdsauggrade8.Text = ""
                    txtdssepgrade8.Text = ""
                    txtdsoctgrade8.Text = ""
                    txtdsnovgrade8.Text = ""
                    txtdsdecgrade8.Text = ""
                    txtdsjangrade8.Text = ""
                    txtdsfebgrade8.Text = ""
                    txtdsmargrade8.Text = ""
                    txtdsaprgrade8.Text = ""
                    txtdstotalgrade8.Text = ""
                    txtdpjungrade8.Text = ""
                    txtdpjulgrade8.Text = ""
                    txtdpauggrade8.Text = ""
                    txtdpsepgrade8.Text = ""
                    txtdpoctgrade8.Text = ""
                    txtdpnovgrade8.Text = ""
                    txtdpdecgrade8.Text = ""
                    txtdpjangrade8.Text = ""
                    txtdpfebgrade8.Text = ""
                    txtdpmargrade8.Text = ""
                    txtdpaprgrade8.Text = ""
                    txtdptotalgrade8.Text = ""
                    txtadvisergrade8.Text = ""
                    txtadvancedunitsgrade8.Text = ""
                    txtlackunitsgrade8.Text = ""
                    txtdsjungrade9.Text = ""
                    txtdsjulgrade9.Text = ""
                    txtdsauggrade9.Text = ""
                    txtdssepgrade9.Text = ""
                    txtdsoctgrade9.Text = ""
                    txtdsnovgrade9.Text = ""
                    txtdsdecgrade9.Text = ""
                    txtdsjangrade9.Text = ""
                    txtdsfebgrade9.Text = ""
                    txtdsmargrade9.Text = ""
                    txtdsaprgrade9.Text = ""
                    txtdstotalgrade9.Text = ""
                    txtdpjungrade9.Text = ""
                    txtdpjulgrade9.Text = ""
                    txtdpauggrade9.Text = ""
                    txtdpsepgrade9.Text = ""
                    txtdpoctgrade9.Text = ""
                    txtdpnovgrade9.Text = ""
                    txtdpdecgrade9.Text = ""
                    txtdpjangrade9.Text = ""
                    txtdpfebgrade9.Text = ""
                    txtdpmargrade9.Text = ""
                    txtdpaprgrade9.Text = ""
                    txtdptotalgrade9.Text = ""
                    txtadvisergrade9.Text = ""
                    txtadvancedunitsgrade9.Text = ""
                    txtlackunitsgrade9.Text = ""
                    txtdsjungrade10.Text = ""
                    txtdsjulgrade10.Text = ""
                    txtdsauggrade10.Text = ""
                    txtdssepgrade10.Text = ""
                    txtdsoctgrade10.Text = ""
                    txtdsnovgrade10.Text = ""
                    txtdsdecgrade10.Text = ""
                    txtdsjangrade10.Text = ""
                    txtdsfebgrade10.Text = ""
                    txtdsmargrade10.Text = ""
                    txtdsaprgrade10.Text = ""
                    txtdstotalgrade10.Text = ""
                    txtdpjungrade10.Text = ""
                    txtdpjulgrade10.Text = ""
                    txtdpauggrade10.Text = ""
                    txtdpsepgrade10.Text = ""
                    txtdpoctgrade10.Text = ""
                    txtdpnovgrade10.Text = ""
                    txtdpdecgrade10.Text = ""
                    txtdpjangrade10.Text = ""
                    txtdpfebgrade10.Text = ""
                    txtdpmargrade10.Text = ""
                    txtdpaprgrade10.Text = ""
                    txtdptotalgrade10.Text = ""
                    txtadvisergrade10.Text = ""
                    txtadvancedunitsgrade10.Text = ""
                    txtlackunitsgrade10.Text = ""
                    txtlrn.Enabled = True
                    txtname.Enabled = True
                    txtbirthplace.Enabled = True
                    txttown.Enabled = True
                    txtbrgy.Enabled = True
                    txtparent.Enabled = True
                    txtoccupation.Enabled = True
                    txtaddress.Enabled = True
                    txtelementaryschool.Enabled = True
                    txtgenave.Enabled = True
                    dtpdateofbirth.Enabled = True
                    cbgender.Enabled = True
                    cbyeargrad.Enabled = True
                    txtclassifiedgrade7.ReadOnly = True
                    cbtotalyearsgrade7.Enabled = True
                    txtyeargrade7.ReadOnly = True
                    txtsectiongrade7.Enabled = True
                    txtschoolgrade7.Enabled = True
                    cbschoolyeargrade7.Enabled = True
                    txtfilipino1grade7.Enabled = True
                    txtfilipino2grade7.Enabled = True
                    txtfilipino3grade7.Enabled = True
                    txtfilipino4grade7.Enabled = True
                    txtfilipinofrgrade7.ReadOnly = True
                    txtfilipinoatgrade7.ReadOnly = True
                    txtfilipinocgrade7.Enabled = True
                    txtfilipinoecagrade7.Enabled = True
                    txtenglish1grade7.Enabled = True
                    txtenglish2grade7.Enabled = True
                    txtenglish3grade7.Enabled = True
                    txtenglish4grade7.Enabled = True
                    txtenglishfrgrade7.ReadOnly = True
                    txtenglishatgrade7.ReadOnly = True
                    txtenglishcgrade7.Enabled = True
                    txtenglishecagrade7.Enabled = True
                    txtmath1grade7.Enabled = True
                    txtmath2grade7.Enabled = True
                    txtmath3grade7.Enabled = True
                    txtmath4grade7.Enabled = True
                    txtmathfrgrade7.ReadOnly = True
                    txtmathatgrade7.ReadOnly = True
                    txtmathcgrade7.Enabled = True
                    txtmathecagrade7.Enabled = True
                    txtscience1grade7.Enabled = True
                    txtscience2grade7.Enabled = True
                    txtscience3grade7.Enabled = True
                    txtscience4grade7.Enabled = True
                    txtsciencefrgrade7.ReadOnly = True
                    txtscienceatgrade7.ReadOnly = True
                    txtsciencecgrade7.Enabled = True
                    txtscienceecagrade7.Enabled = True
                    txtap1grade7.Enabled = True
                    txtap2grade7.Enabled = True
                    txtap3grade7.Enabled = True
                    txtap4grade7.Enabled = True
                    txtapfrgrade7.ReadOnly = True
                    txtapatgrade7.ReadOnly = True
                    txtapcgrade7.Enabled = True
                    txtapecagrade7.Enabled = True
                    txtesp1grade7.Enabled = True
                    txtesp2grade7.Enabled = True
                    txtesp3grade7.Enabled = True
                    txtesp4grade7.Enabled = True
                    txtespfrgrade7.ReadOnly = True
                    txtespatgrade7.ReadOnly = True
                    txtespcgrade7.Enabled = True
                    txtespecagrade7.Enabled = True
                    txttle1grade7.Enabled = True
                    txttle2grade7.Enabled = True
                    txttle3grade7.Enabled = True
                    txttle4grade7.Enabled = True
                    txttlefrgrade7.ReadOnly = True
                    txttleatgrade7.ReadOnly = True
                    txttlecgrade7.Enabled = True
                    txttleecagrade7.Enabled = True
                    txtmapeh1grade7.ReadOnly = True
                    txtmapeh2grade7.ReadOnly = True
                    txtmapeh3grade7.ReadOnly = True
                    txtmapeh4grade7.ReadOnly = True
                    txtmapehfrgrade7.ReadOnly = True
                    txtmapehatgrade7.ReadOnly = True
                    txtmapehcgrade7.Enabled = True
                    txtmapehecagrade7.Enabled = True
                    txtmusic1grade7.Enabled = True
                    txtmusic2grade7.Enabled = True
                    txtmusic3grade7.Enabled = True
                    txtmusic4grade7.Enabled = True
                    txtmusicfrgrade7.ReadOnly = True
                    txtmusicatgrade7.ReadOnly = True
                    txtmusiccgrade7.Enabled = True
                    txtmusicecagrade7.Enabled = True
                    txtarts1grade7.Enabled = True
                    txtarts2grade7.Enabled = True
                    txtarts3grade7.Enabled = True
                    txtarts4grade7.Enabled = True
                    txtartsfrgrade7.ReadOnly = True
                    txtartsatgrade7.ReadOnly = True
                    txtartscgrade7.Enabled = True
                    txtartsecagrade7.Enabled = True
                    txtpe1grade7.Enabled = True
                    txtpe2grade7.Enabled = True
                    txtpe3grade7.Enabled = True
                    txtpe4grade7.Enabled = True
                    txtpefrgrade7.ReadOnly = True
                    txtpeatgrade7.ReadOnly = True
                    txtpecgrade7.Enabled = True
                    txtpeecagrade7.Enabled = True
                    txthealth1grade7.Enabled = True
                    txthealth2grade7.Enabled = True
                    txthealth3grade7.Enabled = True
                    txthealth4grade7.Enabled = True
                    txthealthfrgrade7.ReadOnly = True
                    txthealthatgrade7.ReadOnly = True
                    txthealthcgrade7.Enabled = True
                    txthealthecagrade7.Enabled = True
                    txtaveragefrgrade7.ReadOnly = True
                    txtaverageatgrade7.ReadOnly = True
                    txtaveragecgrade7.Enabled = True
                    txtclassifiedgrade8.ReadOnly = True
                    cbtotalyearsgrade8.Enabled = True
                    txtyeargrade8.ReadOnly = True
                    txtsectiongrade8.Enabled = True
                    txtschoolgrade8.Enabled = True
                    cbschoolyeargrade8.Enabled = True
                    txtfilipino1grade8.Enabled = True
                    txtfilipino2grade8.Enabled = True
                    txtfilipino3grade8.Enabled = True
                    txtfilipino4grade8.Enabled = True
                    txtfilipinofrgrade8.ReadOnly = True
                    txtfilipinoatgrade8.ReadOnly = True
                    txtfilipinocgrade8.Enabled = True
                    txtfilipinoecagrade8.Enabled = True
                    txtenglish1grade8.Enabled = True
                    txtenglish2grade8.Enabled = True
                    txtenglish3grade8.Enabled = True
                    txtenglish4grade8.Enabled = True
                    txtenglishfrgrade8.ReadOnly = True
                    txtenglishatgrade8.ReadOnly = True
                    txtenglishcgrade8.Enabled = True
                    txtenglishecagrade8.Enabled = True
                    txtmath1grade8.Enabled = True
                    txtmath2grade8.Enabled = True
                    txtmath3grade8.Enabled = True
                    txtmath4grade8.Enabled = True
                    txtmathfrgrade8.ReadOnly = True
                    txtmathatgrade8.ReadOnly = True
                    txtmathcgrade8.Enabled = True
                    txtmathecagrade8.Enabled = True
                    txtscience1grade8.Enabled = True
                    txtscience2grade8.Enabled = True
                    txtscience3grade8.Enabled = True
                    txtscience4grade8.Enabled = True
                    txtsciencefrgrade8.ReadOnly = True
                    txtscienceatgrade8.ReadOnly = True
                    txtsciencecgrade8.Enabled = True
                    txtscienceecagrade8.Enabled = True
                    txtap1grade8.Enabled = True
                    txtap2grade8.Enabled = True
                    txtap3grade8.Enabled = True
                    txtap4grade8.Enabled = True
                    txtapfrgrade8.ReadOnly = True
                    txtapatgrade8.ReadOnly = True
                    txtapcgrade8.Enabled = True
                    txtapecagrade8.Enabled = True
                    txtesp1grade8.Enabled = True
                    txtesp2grade8.Enabled = True
                    txtesp3grade8.Enabled = True
                    txtesp4grade8.Enabled = True
                    txtespfrgrade8.ReadOnly = True
                    txtespatgrade8.ReadOnly = True
                    txtespcgrade8.Enabled = True
                    txtespecagrade8.Enabled = True
                    txttle1grade8.Enabled = True
                    txttle2grade8.Enabled = True
                    txttle3grade8.Enabled = True
                    txttle4grade8.Enabled = True
                    txttlefrgrade8.ReadOnly = True
                    txttleatgrade8.ReadOnly = True
                    txttlecgrade8.Enabled = True
                    txttleecagrade8.Enabled = True
                    txtmapeh1grade8.ReadOnly = True
                    txtmapeh2grade8.ReadOnly = True
                    txtmapeh3grade8.ReadOnly = True
                    txtmapeh4grade8.ReadOnly = True
                    txtmapehfrgrade8.ReadOnly = True
                    txtmapehatgrade8.ReadOnly = True
                    txtmapehcgrade8.Enabled = True
                    txtmapehecagrade8.Enabled = True
                    txtmusic1grade8.Enabled = True
                    txtmusic2grade8.Enabled = True
                    txtmusic3grade8.Enabled = True
                    txtmusic4grade8.Enabled = True
                    txtmusicfrgrade8.ReadOnly = True
                    txtmusicatgrade8.ReadOnly = True
                    txtmusiccgrade8.Enabled = True
                    txtmusicecagrade8.Enabled = True
                    txtarts1grade8.Enabled = True
                    txtarts2grade8.Enabled = True
                    txtarts3grade8.Enabled = True
                    txtarts4grade8.Enabled = True
                    txtartsfrgrade8.ReadOnly = True
                    txtartsatgrade8.ReadOnly = True
                    txtartscgrade8.Enabled = True
                    txtartsecagrade8.Enabled = True
                    txtpe1grade8.Enabled = True
                    txtpe2grade8.Enabled = True
                    txtpe3grade8.Enabled = True
                    txtpe4grade8.Enabled = True
                    txtpefrgrade8.ReadOnly = True
                    txtpeatgrade8.ReadOnly = True
                    txtpecgrade8.Enabled = True
                    txtpeecagrade8.Enabled = True
                    txthealth1grade8.Enabled = True
                    txthealth2grade8.Enabled = True
                    txthealth3grade8.Enabled = True
                    txthealth4grade8.Enabled = True
                    txthealthfrgrade8.ReadOnly = True
                    txthealthatgrade8.ReadOnly = True
                    txthealthcgrade8.Enabled = True
                    txthealthecagrade8.Enabled = True
                    txtaveragefrgrade8.ReadOnly = True
                    txtaverageatgrade8.ReadOnly = True
                    txtaveragecgrade8.Enabled = True
                    txtclassifiedgrade9.ReadOnly = True
                    cbtotalyearsgrade9.Enabled = True
                    txtyeargrade9.ReadOnly = True
                    txtsectiongrade9.Enabled = True
                    txtschoolgrade9.Enabled = True
                    cbschoolyeargrade9.Enabled = True
                    txtfilipino1grade9.Enabled = True
                    txtfilipino2grade9.Enabled = True
                    txtfilipino3grade9.Enabled = True
                    txtfilipino4grade9.Enabled = True
                    txtfilipinofrgrade9.ReadOnly = True
                    txtfilipinoatgrade9.ReadOnly = True
                    txtfilipinocgrade9.Enabled = True
                    txtfilipinoecagrade9.Enabled = True
                    txtenglish1grade9.Enabled = True
                    txtenglish2grade9.Enabled = True
                    txtenglish3grade9.Enabled = True
                    txtenglish4grade9.Enabled = True
                    txtenglishfrgrade9.ReadOnly = True
                    txtenglishatgrade9.ReadOnly = True
                    txtenglishcgrade9.Enabled = True
                    txtenglishecagrade9.Enabled = True
                    txtmath1grade9.Enabled = True
                    txtmath2grade9.Enabled = True
                    txtmath3grade9.Enabled = True
                    txtmath4grade9.Enabled = True
                    txtmathfrgrade9.ReadOnly = True
                    txtmathatgrade9.ReadOnly = True
                    txtmathcgrade9.Enabled = True
                    txtmathecagrade9.Enabled = True
                    txtscience1grade9.Enabled = True
                    txtscience2grade9.Enabled = True
                    txtscience3grade9.Enabled = True
                    txtscience4grade9.Enabled = True
                    txtsciencefrgrade9.ReadOnly = True
                    txtscienceatgrade9.ReadOnly = True
                    txtsciencecgrade9.Enabled = True
                    txtscienceecagrade9.Enabled = True
                    txtap1grade9.Enabled = True
                    txtap2grade9.Enabled = True
                    txtap3grade9.Enabled = True
                    txtap4grade9.Enabled = True
                    txtapfrgrade9.ReadOnly = True
                    txtapatgrade9.ReadOnly = True
                    txtapcgrade9.Enabled = True
                    txtapecagrade9.Enabled = True
                    txtesp1grade9.Enabled = True
                    txtesp2grade9.Enabled = True
                    txtesp3grade9.Enabled = True
                    txtesp4grade9.Enabled = True
                    txtespfrgrade9.ReadOnly = True
                    txtespatgrade9.ReadOnly = True
                    txtespcgrade9.Enabled = True
                    txtespecagrade9.Enabled = True
                    txttle1grade9.Enabled = True
                    txttle2grade9.Enabled = True
                    txttle3grade9.Enabled = True
                    txttle4grade9.Enabled = True
                    txttlefrgrade9.ReadOnly = True
                    txttleatgrade9.ReadOnly = True
                    txttlecgrade9.Enabled = True
                    txttleecagrade9.Enabled = True
                    txtmapeh1grade9.ReadOnly = True
                    txtmapeh2grade9.ReadOnly = True
                    txtmapeh3grade9.ReadOnly = True
                    txtmapeh4grade9.ReadOnly = True
                    txtmapehfrgrade9.ReadOnly = True
                    txtmapehatgrade9.ReadOnly = True
                    txtmapehcgrade9.Enabled = True
                    txtmapehecagrade9.Enabled = True
                    txtmusic1grade9.Enabled = True
                    txtmusic2grade9.Enabled = True
                    txtmusic3grade9.Enabled = True
                    txtmusic4grade9.Enabled = True
                    txtmusicfrgrade9.ReadOnly = True
                    txtmusicatgrade9.ReadOnly = True
                    txtmusiccgrade9.Enabled = True
                    txtmusicecagrade9.Enabled = True
                    txtarts1grade9.Enabled = True
                    txtarts2grade9.Enabled = True
                    txtarts3grade9.Enabled = True
                    txtarts4grade9.Enabled = True
                    txtartsfrgrade9.ReadOnly = True
                    txtartsatgrade9.ReadOnly = True
                    txtartscgrade9.Enabled = True
                    txtartsecagrade9.Enabled = True
                    txtpe1grade9.Enabled = True
                    txtpe2grade9.Enabled = True
                    txtpe3grade9.Enabled = True
                    txtpe4grade9.Enabled = True
                    txtpefrgrade9.ReadOnly = True
                    txtpeatgrade9.ReadOnly = True
                    txtpecgrade9.Enabled = True
                    txtpeecagrade9.Enabled = True
                    txthealth1grade9.Enabled = True
                    txthealth2grade9.Enabled = True
                    txthealth3grade9.Enabled = True
                    txthealth4grade9.Enabled = True
                    txthealthfrgrade9.ReadOnly = True
                    txthealthatgrade9.ReadOnly = True
                    txthealthcgrade9.Enabled = True
                    txthealthecagrade9.Enabled = True
                    txtaveragefrgrade9.ReadOnly = True
                    txtaverageatgrade9.ReadOnly = True
                    txtaveragecgrade9.Enabled = True
                    txtclassifiedgrade10.ReadOnly = True
                    cbtotalyearsgrade10.Enabled = True
                    txtyeargrade10.ReadOnly = True
                    txtsectiongrade10.Enabled = True
                    txtschoolgrade10.Enabled = True
                    cbschoolyeargrade10.Enabled = True
                    txtfilipino1grade10.Enabled = True
                    txtfilipino2grade10.Enabled = True
                    txtfilipino3grade10.Enabled = True
                    txtfilipino4grade10.Enabled = True
                    txtfilipinofrgrade10.ReadOnly = True
                    txtfilipinoatgrade10.ReadOnly = True
                    txtfilipinocgrade10.Enabled = True
                    txtfilipinoecagrade10.Enabled = True
                    txtenglish1grade10.Enabled = True
                    txtenglish2grade10.Enabled = True
                    txtenglish3grade10.Enabled = True
                    txtenglish4grade10.Enabled = True
                    txtenglishfrgrade10.ReadOnly = True
                    txtenglishatgrade10.ReadOnly = True
                    txtenglishcgrade10.Enabled = True
                    txtenglishecagrade10.Enabled = True
                    txtmath1grade10.Enabled = True
                    txtmath2grade10.Enabled = True
                    txtmath3grade10.Enabled = True
                    txtmath4grade10.Enabled = True
                    txtmathfrgrade10.ReadOnly = True
                    txtmathatgrade10.ReadOnly = True
                    txtmathcgrade10.Enabled = True
                    txtmathecagrade10.Enabled = True
                    txtscience1grade10.Enabled = True
                    txtscience2grade10.Enabled = True
                    txtscience3grade10.Enabled = True
                    txtscience4grade10.Enabled = True
                    txtsciencefrgrade10.ReadOnly = True
                    txtscienceatgrade10.ReadOnly = True
                    txtsciencecgrade10.Enabled = True
                    txtscienceecagrade10.Enabled = True
                    txtap1grade10.Enabled = True
                    txtap2grade10.Enabled = True
                    txtap3grade10.Enabled = True
                    txtap4grade10.Enabled = True
                    txtapfrgrade10.ReadOnly = True
                    txtapatgrade10.ReadOnly = True
                    txtapcgrade10.Enabled = True
                    txtapecagrade10.Enabled = True
                    txtesp1grade10.Enabled = True
                    txtesp2grade10.Enabled = True
                    txtesp3grade10.Enabled = True
                    txtesp4grade10.Enabled = True
                    txtespfrgrade10.ReadOnly = True
                    txtespatgrade10.ReadOnly = True
                    txtespcgrade10.Enabled = True
                    txtespecagrade10.Enabled = True
                    txttle1grade10.Enabled = True
                    txttle2grade10.Enabled = True
                    txttle3grade10.Enabled = True
                    txttle4grade10.Enabled = True
                    txttlefrgrade10.ReadOnly = True
                    txttleatgrade10.ReadOnly = True
                    txttlecgrade10.Enabled = True
                    txttleecagrade10.Enabled = True
                    txtmapeh1grade10.ReadOnly = True
                    txtmapeh2grade10.ReadOnly = True
                    txtmapeh3grade10.ReadOnly = True
                    txtmapeh4grade10.ReadOnly = True
                    txtmapehfrgrade10.ReadOnly = True
                    txtmapehatgrade10.ReadOnly = True
                    txtmapehcgrade10.Enabled = True
                    txtmapehecagrade10.Enabled = True
                    txtmusic1grade10.Enabled = True
                    txtmusic2grade10.Enabled = True
                    txtmusic3grade10.Enabled = True
                    txtmusic4grade10.Enabled = True
                    txtmusicfrgrade10.ReadOnly = True
                    txtmusicatgrade10.ReadOnly = True
                    txtmusiccgrade10.Enabled = True
                    txtmusicecagrade10.Enabled = True
                    txtarts1grade10.Enabled = True
                    txtarts2grade10.Enabled = True
                    txtarts3grade10.Enabled = True
                    txtarts4grade10.Enabled = True
                    txtartsfrgrade10.ReadOnly = True
                    txtartsatgrade10.ReadOnly = True
                    txtartscgrade10.Enabled = True
                    txtartsecagrade10.Enabled = True
                    txtpe1grade10.Enabled = True
                    txtpe2grade10.Enabled = True
                    txtpe3grade10.Enabled = True
                    txtpe4grade10.Enabled = True
                    txtpefrgrade10.ReadOnly = True
                    txtpeatgrade10.ReadOnly = True
                    txtpecgrade10.Enabled = True
                    txtpeecagrade10.Enabled = True
                    txthealth1grade10.Enabled = True
                    txthealth2grade10.Enabled = True
                    txthealth3grade10.Enabled = True
                    txthealth4grade10.Enabled = True
                    txthealthfrgrade10.ReadOnly = True
                    txthealthatgrade10.ReadOnly = True
                    txthealthcgrade10.Enabled = True
                    txthealthecagrade10.Enabled = True
                    txtaveragefrgrade10.ReadOnly = True
                    txtaverageatgrade10.ReadOnly = True
                    txtaveragecgrade10.Enabled = True
                    txtdsjungrade7.Enabled = True
                    txtdsjulgrade7.Enabled = True
                    txtdsauggrade7.Enabled = True
                    txtdssepgrade7.Enabled = True
                    txtdsoctgrade7.Enabled = True
                    txtdsnovgrade7.Enabled = True
                    txtdsdecgrade7.Enabled = True
                    txtdsjangrade7.Enabled = True
                    txtdsfebgrade7.Enabled = True
                    txtdsmargrade7.Enabled = True
                    txtdsaprgrade7.Enabled = True
                    txtdstotalgrade7.ReadOnly = True
                    txtdpjungrade7.Enabled = True
                    txtdpjulgrade7.Enabled = True
                    txtdpauggrade7.Enabled = True
                    txtdpsepgrade7.Enabled = True
                    txtdpoctgrade7.Enabled = True
                    txtdpnovgrade7.Enabled = True
                    txtdpdecgrade7.Enabled = True
                    txtdpjangrade7.Enabled = True
                    txtdpfebgrade7.Enabled = True
                    txtdpmargrade7.Enabled = True
                    txtdpaprgrade7.Enabled = True
                    txtdptotalgrade7.ReadOnly = True
                    txtadvisergrade7.Enabled = True
                    txtadvancedunitsgrade7.Enabled = True
                    txtlackunitsgrade7.Enabled = True
                    txtdsjungrade8.Enabled = True
                    txtdsjulgrade8.Enabled = True
                    txtdsauggrade8.Enabled = True
                    txtdssepgrade8.Enabled = True
                    txtdsoctgrade8.Enabled = True
                    txtdsnovgrade8.Enabled = True
                    txtdsdecgrade8.Enabled = True
                    txtdsjangrade8.Enabled = True
                    txtdsfebgrade8.Enabled = True
                    txtdsmargrade8.Enabled = True
                    txtdsaprgrade8.Enabled = True
                    txtdstotalgrade8.ReadOnly = True
                    txtdpjungrade8.Enabled = True
                    txtdpjulgrade8.Enabled = True
                    txtdpauggrade8.Enabled = True
                    txtdpsepgrade8.Enabled = True
                    txtdpoctgrade8.Enabled = True
                    txtdpnovgrade8.Enabled = True
                    txtdpdecgrade8.Enabled = True
                    txtdpjangrade8.Enabled = True
                    txtdpfebgrade8.Enabled = True
                    txtdpmargrade8.Enabled = True
                    txtdpaprgrade8.Enabled = True
                    txtdptotalgrade8.ReadOnly = True
                    txtadvisergrade8.Enabled = True
                    txtadvancedunitsgrade8.Enabled = True
                    txtlackunitsgrade8.Enabled = True
                    txtdsjungrade9.Enabled = True
                    txtdsjulgrade9.Enabled = True
                    txtdsauggrade9.Enabled = True
                    txtdssepgrade9.Enabled = True
                    txtdsoctgrade9.Enabled = True
                    txtdsnovgrade9.Enabled = True
                    txtdsdecgrade9.Enabled = True
                    txtdsjangrade9.Enabled = True
                    txtdsfebgrade9.Enabled = True
                    txtdsmargrade9.Enabled = True
                    txtdsaprgrade9.Enabled = True
                    txtdstotalgrade9.ReadOnly = True
                    txtdpjungrade9.Enabled = True
                    txtdpjulgrade9.Enabled = True
                    txtdpauggrade9.Enabled = True
                    txtdpsepgrade9.Enabled = True
                    txtdpoctgrade9.Enabled = True
                    txtdpnovgrade9.Enabled = True
                    txtdpdecgrade9.Enabled = True
                    txtdpjangrade9.Enabled = True
                    txtdpfebgrade9.Enabled = True
                    txtdpmargrade9.Enabled = True
                    txtdpaprgrade9.Enabled = True
                    txtdptotalgrade9.ReadOnly = True
                    txtadvisergrade9.Enabled = True
                    txtadvancedunitsgrade9.Enabled = True
                    txtlackunitsgrade9.Enabled = True
                    txtdsjungrade10.Enabled = True
                    txtdsjulgrade10.Enabled = True
                    txtdsauggrade10.Enabled = True
                    txtdssepgrade10.Enabled = True
                    txtdsoctgrade10.Enabled = True
                    txtdsnovgrade10.Enabled = True
                    txtdsdecgrade10.Enabled = True
                    txtdsjangrade10.Enabled = True
                    txtdsfebgrade10.Enabled = True
                    txtdsmargrade10.Enabled = True
                    txtdsaprgrade10.Enabled = True
                    txtdstotalgrade10.ReadOnly = True
                    txtdpjungrade10.Enabled = True
                    txtdpjulgrade10.Enabled = True
                    txtdpauggrade10.Enabled = True
                    txtdpsepgrade10.Enabled = True
                    txtdpoctgrade10.Enabled = True
                    txtdpnovgrade10.Enabled = True
                    txtdpdecgrade10.Enabled = True
                    txtdpjangrade10.Enabled = True
                    txtdpfebgrade10.Enabled = True
                    txtdpmargrade10.Enabled = True
                    txtdpaprgrade10.Enabled = True
                    txtdptotalgrade10.ReadOnly = True
                    txtadvisergrade10.Enabled = True
                    txtadvancedunitsgrade10.Enabled = True
                    txtlackunitsgrade10.Enabled = True
                    btndelete.Enabled = False
                    btnupdate.Enabled = False
                    btnedit.Enabled = False
                    btnprint.Enabled = False
                    btnsave.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        If MessageBox.Show("Are You Sure You Want to Clear All the information?", "Clear", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            txtlrn.ForeColor = Color.Gray
            txtname.ForeColor = Color.Gray
            txtbirthplace.ForeColor = Color.Gray
            txttown.ForeColor = Color.Gray
            txtbrgy.ForeColor = Color.Gray
            txtparent.ForeColor = Color.Gray
            txtoccupation.ForeColor = Color.Gray
            txtaddress.ForeColor = Color.Gray
            txtelementaryschool.ForeColor = Color.Gray
            txtgenave.ForeColor = Color.Gray
            txtsectiongrade7.ForeColor = Color.Gray
            txtschoolgrade7.ForeColor = Color.Gray
            txtsectiongrade8.ForeColor = Color.Gray
            txtschoolgrade8.ForeColor = Color.Gray
            txtsectiongrade9.ForeColor = Color.Gray
            txtschoolgrade9.ForeColor = Color.Gray
            txtsectiongrade10.ForeColor = Color.Gray
            txtschoolgrade10.ForeColor = Color.Gray
            txtlrn.Text = "Student LRN..."
            txtname.Text = "Type the Full Name of the Student..."
            txtbirthplace.Text = "Type the Birthplace/Province..."
            txttown.Text = "Type the Town/City..."
            txtbrgy.Text = "Type the Barangay..."
            txtparent.Text = "Parent/Guardian's Fullname..."
            txtoccupation.Text = "Occupation of the Parent/Guardian..."
            txtaddress.Text = "Address of the Parent/Guardian..."
            txtelementaryschool.Text = "Elementary School Graduated..."
            txtgenave.Text = "Ave. Grade..."
            dtpdateofbirth.Text = Nothing
            cbgender.Text = Nothing
            cbyeargrad.Text = Nothing
            txtclassifiedgrade7.Text = "GRADE 7"
            cbtotalyearsgrade7.Text = Nothing
            txtyeargrade7.Text = "7"
            txtsectiongrade7.Text = "Section..."
            txtschoolgrade7.Text = "School..."
            cbschoolyeargrade7.Text = Nothing
            txtfilipino1grade7.Text = ""
            txtfilipino2grade7.Text = ""
            txtfilipino3grade7.Text = ""
            txtfilipino4grade7.Text = ""
            txtfilipinofrgrade7.Text = "0"
            txtfilipinoatgrade7.Text = ""
            txtfilipinocgrade7.Text = ""
            txtfilipinoecagrade7.Text = ""
            txtenglish1grade7.Text = ""
            txtenglish2grade7.Text = ""
            txtenglish3grade7.Text = ""
            txtenglish4grade7.Text = ""
            txtenglishfrgrade7.Text = "0"
            txtenglishatgrade7.Text = ""
            txtenglishcgrade7.Text = ""
            txtenglishecagrade7.Text = ""
            txtmath1grade7.Text = ""
            txtmath2grade7.Text = ""
            txtmath3grade7.Text = ""
            txtmath4grade7.Text = ""
            txtmathfrgrade7.Text = "0"
            txtmathatgrade7.Text = ""
            txtmathcgrade7.Text = ""
            txtmathecagrade7.Text = ""
            txtscience1grade7.Text = ""
            txtscience2grade7.Text = ""
            txtscience3grade7.Text = ""
            txtscience4grade7.Text = ""
            txtsciencefrgrade7.Text = "0"
            txtscienceatgrade7.Text = ""
            txtsciencecgrade7.Text = ""
            txtscienceecagrade7.Text = ""
            txtap1grade7.Text = ""
            txtap2grade7.Text = ""
            txtap3grade7.Text = ""
            txtap4grade7.Text = ""
            txtapfrgrade7.Text = "0"
            txtapatgrade7.Text = ""
            txtapcgrade7.Text = ""
            txtapecagrade7.Text = ""
            txtesp1grade7.Text = ""
            txtesp2grade7.Text = ""
            txtesp3grade7.Text = ""
            txtesp4grade7.Text = ""
            txtespfrgrade7.Text = "0"
            txtespatgrade7.Text = ""
            txtespcgrade7.Text = ""
            txtespecagrade7.Text = ""
            txttle1grade7.Text = ""
            txttle2grade7.Text = ""
            txttle3grade7.Text = ""
            txttle4grade7.Text = ""
            txttlefrgrade7.Text = "0"
            txttleatgrade7.Text = ""
            txttlecgrade7.Text = ""
            txttleecagrade7.Text = ""
            txtmapeh1grade7.Text = ""
            txtmapeh2grade7.Text = ""
            txtmapeh3grade7.Text = ""
            txtmapeh4grade7.Text = ""
            txtmapehfrgrade7.Text = "0"
            txtmapehatgrade7.Text = ""
            txtmapehcgrade7.Text = ""
            txtmapehecagrade7.Text = ""
            txtmusic1grade7.Text = ""
            txtmusic2grade7.Text = ""
            txtmusic3grade7.Text = ""
            txtmusic4grade7.Text = ""
            txtmusicfrgrade7.Text = "0"
            txtmusicatgrade7.Text = ""
            txtmusiccgrade7.Text = ""
            txtmusicecagrade7.Text = ""
            txtarts1grade7.Text = ""
            txtarts2grade7.Text = ""
            txtarts3grade7.Text = ""
            txtarts4grade7.Text = ""
            txtartsfrgrade7.Text = "0"
            txtartsatgrade7.Text = ""
            txtartscgrade7.Text = ""
            txtartsecagrade7.Text = ""
            txtpe1grade7.Text = ""
            txtpe2grade7.Text = ""
            txtpe3grade7.Text = ""
            txtpe4grade7.Text = ""
            txtpefrgrade7.Text = "0"
            txtpeatgrade7.Text = ""
            txtpecgrade7.Text = ""
            txtpeecagrade7.Text = ""
            txthealth1grade7.Text = ""
            txthealth2grade7.Text = ""
            txthealth3grade7.Text = ""
            txthealth4grade7.Text = ""
            txthealthfrgrade7.Text = "0"
            txthealthatgrade7.Text = ""
            txthealthcgrade7.Text = ""
            txthealthecagrade7.Text = ""
            txtaveragefrgrade7.Text = "0"
            txtaverageatgrade7.Text = ""
            txtaveragecgrade7.Text = ""
            txtclassifiedgrade8.Text = "GRADE 8"
            cbtotalyearsgrade8.Text = Nothing
            txtyeargrade8.Text = "8"
            txtsectiongrade8.Text = "Section..."
            txtschoolgrade8.Text = "School..."
            cbschoolyeargrade8.Text = Nothing
            txtfilipino1grade8.Text = ""
            txtfilipino2grade8.Text = ""
            txtfilipino3grade8.Text = ""
            txtfilipino4grade8.Text = ""
            txtfilipinofrgrade8.Text = "0"
            txtfilipinoatgrade8.Text = ""
            txtfilipinocgrade8.Text = ""
            txtfilipinoecagrade8.Text = ""
            txtenglish1grade8.Text = ""
            txtenglish2grade8.Text = ""
            txtenglish3grade8.Text = ""
            txtenglish4grade8.Text = ""
            txtenglishfrgrade8.Text = "0"
            txtenglishatgrade8.Text = ""
            txtenglishcgrade8.Text = ""
            txtenglishecagrade8.Text = ""
            txtmath1grade8.Text = ""
            txtmath2grade8.Text = ""
            txtmath3grade8.Text = ""
            txtmath4grade8.Text = ""
            txtmathfrgrade8.Text = "0"
            txtmathatgrade8.Text = ""
            txtmathcgrade8.Text = ""
            txtmathecagrade8.Text = ""
            txtscience1grade8.Text = ""
            txtscience2grade8.Text = ""
            txtscience3grade8.Text = ""
            txtscience4grade8.Text = ""
            txtsciencefrgrade8.Text = "0"
            txtscienceatgrade8.Text = ""
            txtsciencecgrade8.Text = ""
            txtscienceecagrade8.Text = ""
            txtap1grade8.Text = ""
            txtap2grade8.Text = ""
            txtap3grade8.Text = ""
            txtap4grade8.Text = ""
            txtapfrgrade8.Text = "0"
            txtapatgrade8.Text = ""
            txtapcgrade8.Text = ""
            txtapecagrade8.Text = ""
            txtesp1grade8.Text = ""
            txtesp2grade8.Text = ""
            txtesp3grade8.Text = ""
            txtesp4grade8.Text = ""
            txtespfrgrade8.Text = "0"
            txtespatgrade8.Text = ""
            txtespcgrade8.Text = ""
            txtespecagrade8.Text = ""
            txttle1grade8.Text = ""
            txttle2grade8.Text = ""
            txttle3grade8.Text = ""
            txttle4grade8.Text = ""
            txttlefrgrade8.Text = "0"
            txttleatgrade8.Text = ""
            txttlecgrade8.Text = ""
            txttleecagrade8.Text = ""
            txtmapeh1grade8.Text = ""
            txtmapeh2grade8.Text = ""
            txtmapeh3grade8.Text = ""
            txtmapeh4grade8.Text = ""
            txtmapehfrgrade8.Text = "0"
            txtmapehatgrade8.Text = ""
            txtmapehcgrade8.Text = ""
            txtmapehecagrade8.Text = ""
            txtmusic1grade8.Text = ""
            txtmusic2grade8.Text = ""
            txtmusic3grade8.Text = ""
            txtmusic4grade8.Text = ""
            txtmusicfrgrade8.Text = "0"
            txtmusicatgrade8.Text = ""
            txtmusiccgrade8.Text = ""
            txtmusicecagrade8.Text = ""
            txtarts1grade8.Text = ""
            txtarts2grade8.Text = ""
            txtarts3grade8.Text = ""
            txtarts4grade8.Text = ""
            txtartsfrgrade8.Text = "0"
            txtartsatgrade8.Text = ""
            txtartscgrade8.Text = ""
            txtartsecagrade8.Text = ""
            txtpe1grade8.Text = ""
            txtpe2grade8.Text = ""
            txtpe3grade8.Text = ""
            txtpe4grade8.Text = ""
            txtpefrgrade8.Text = "0"
            txtpeatgrade8.Text = ""
            txtpecgrade8.Text = ""
            txtpeecagrade8.Text = ""
            txthealth1grade8.Text = ""
            txthealth2grade8.Text = ""
            txthealth3grade8.Text = ""
            txthealth4grade8.Text = ""
            txthealthfrgrade8.Text = "0"
            txthealthatgrade8.Text = ""
            txthealthcgrade8.Text = ""
            txthealthecagrade8.Text = ""
            txtaveragefrgrade8.Text = "0"
            txtaverageatgrade8.Text = ""
            txtaveragecgrade8.Text = ""
            txtclassifiedgrade9.Text = "GRADE 9"
            cbtotalyearsgrade9.Text = Nothing
            txtyeargrade9.Text = "9"
            txtsectiongrade9.Text = "Section..."
            txtschoolgrade9.Text = "School..."
            cbschoolyeargrade9.Text = Nothing
            txtfilipino1grade9.Text = ""
            txtfilipino2grade9.Text = ""
            txtfilipino3grade9.Text = ""
            txtfilipino4grade9.Text = ""
            txtfilipinofrgrade9.Text = "0"
            txtfilipinoatgrade9.Text = ""
            txtfilipinocgrade9.Text = ""
            txtfilipinoecagrade9.Text = ""
            txtenglish1grade9.Text = ""
            txtenglish2grade9.Text = ""
            txtenglish3grade9.Text = ""
            txtenglish4grade9.Text = ""
            txtenglishfrgrade9.Text = "0"
            txtenglishatgrade9.Text = ""
            txtenglishcgrade9.Text = ""
            txtenglishecagrade9.Text = ""
            txtmath1grade9.Text = ""
            txtmath2grade9.Text = ""
            txtmath3grade9.Text = ""
            txtmath4grade9.Text = ""
            txtmathfrgrade9.Text = "0"
            txtmathatgrade9.Text = ""
            txtmathcgrade9.Text = ""
            txtmathecagrade9.Text = ""
            txtscience1grade9.Text = ""
            txtscience2grade9.Text = ""
            txtscience3grade9.Text = ""
            txtscience4grade9.Text = ""
            txtsciencefrgrade9.Text = "0"
            txtscienceatgrade9.Text = ""
            txtsciencecgrade9.Text = ""
            txtscienceecagrade9.Text = ""
            txtap1grade9.Text = ""
            txtap2grade9.Text = ""
            txtap3grade9.Text = ""
            txtap4grade9.Text = ""
            txtapfrgrade9.Text = "0"
            txtapatgrade9.Text = ""
            txtapcgrade9.Text = ""
            txtapecagrade9.Text = ""
            txtesp1grade9.Text = ""
            txtesp2grade9.Text = ""
            txtesp3grade9.Text = ""
            txtesp4grade9.Text = ""
            txtespfrgrade9.Text = "0"
            txtespatgrade9.Text = ""
            txtespcgrade9.Text = ""
            txtespecagrade9.Text = ""
            txttle1grade9.Text = ""
            txttle2grade9.Text = ""
            txttle3grade9.Text = ""
            txttle4grade9.Text = ""
            txttlefrgrade9.Text = "0"
            txttleatgrade9.Text = ""
            txttlecgrade9.Text = ""
            txttleecagrade9.Text = ""
            txtmapeh1grade9.Text = ""
            txtmapeh2grade9.Text = ""
            txtmapeh3grade9.Text = ""
            txtmapeh4grade9.Text = ""
            txtmapehfrgrade9.Text = "0"
            txtmapehatgrade9.Text = ""
            txtmapehcgrade9.Text = ""
            txtmapehecagrade9.Text = ""
            txtmusic1grade9.Text = ""
            txtmusic2grade9.Text = ""
            txtmusic3grade9.Text = ""
            txtmusic4grade9.Text = ""
            txtmusicfrgrade9.Text = "0"
            txtmusicatgrade9.Text = ""
            txtmusiccgrade9.Text = ""
            txtmusicecagrade9.Text = ""
            txtarts1grade9.Text = ""
            txtarts2grade9.Text = ""
            txtarts3grade9.Text = ""
            txtarts4grade9.Text = ""
            txtartsfrgrade9.Text = "0"
            txtartsatgrade9.Text = ""
            txtartscgrade9.Text = ""
            txtartsecagrade9.Text = ""
            txtpe1grade9.Text = ""
            txtpe2grade9.Text = ""
            txtpe3grade9.Text = ""
            txtpe4grade9.Text = ""
            txtpefrgrade9.Text = "0"
            txtpeatgrade9.Text = ""
            txtpecgrade9.Text = ""
            txtpeecagrade9.Text = ""
            txthealth1grade9.Text = ""
            txthealth2grade9.Text = ""
            txthealth3grade9.Text = ""
            txthealth4grade9.Text = ""
            txthealthfrgrade9.Text = "0"
            txthealthatgrade9.Text = ""
            txthealthcgrade9.Text = ""
            txthealthecagrade9.Text = ""
            txtaveragefrgrade9.Text = "0"
            txtaverageatgrade9.Text = ""
            txtaveragecgrade9.Text = ""
            txtclassifiedgrade10.Text = "GRADE 10"
            cbtotalyearsgrade10.Text = Nothing
            txtyeargrade10.Text = "10"
            txtsectiongrade10.Text = "Section..."
            txtschoolgrade10.Text = "School..."
            cbschoolyeargrade10.Text = Nothing
            txtfilipino1grade10.Text = ""
            txtfilipino2grade10.Text = ""
            txtfilipino3grade10.Text = ""
            txtfilipino4grade10.Text = ""
            txtfilipinofrgrade10.Text = "0"
            txtfilipinoatgrade10.Text = ""
            txtfilipinocgrade10.Text = ""
            txtfilipinoecagrade10.Text = ""
            txtenglish1grade10.Text = ""
            txtenglish2grade10.Text = ""
            txtenglish3grade10.Text = ""
            txtenglish4grade10.Text = ""
            txtenglishfrgrade10.Text = "0"
            txtenglishatgrade10.Text = ""
            txtenglishcgrade10.Text = ""
            txtenglishecagrade10.Text = ""
            txtmath1grade10.Text = ""
            txtmath2grade10.Text = ""
            txtmath3grade10.Text = ""
            txtmath4grade10.Text = ""
            txtmathfrgrade10.Text = "0"
            txtmathatgrade10.Text = ""
            txtmathcgrade10.Text = ""
            txtmathecagrade10.Text = ""
            txtscience1grade10.Text = ""
            txtscience2grade10.Text = ""
            txtscience3grade10.Text = ""
            txtscience4grade10.Text = ""
            txtsciencefrgrade10.Text = "0"
            txtscienceatgrade10.Text = ""
            txtsciencecgrade10.Text = ""
            txtscienceecagrade10.Text = ""
            txtap1grade10.Text = ""
            txtap2grade10.Text = ""
            txtap3grade10.Text = ""
            txtap4grade10.Text = ""
            txtapfrgrade10.Text = "0"
            txtapatgrade10.Text = ""
            txtapcgrade10.Text = ""
            txtapecagrade10.Text = ""
            txtesp1grade10.Text = ""
            txtesp2grade10.Text = ""
            txtesp3grade10.Text = ""
            txtesp4grade10.Text = ""
            txtespfrgrade10.Text = "0"
            txtespatgrade10.Text = ""
            txtespcgrade10.Text = ""
            txtespecagrade10.Text = ""
            txttle1grade10.Text = ""
            txttle2grade10.Text = ""
            txttle3grade10.Text = ""
            txttle4grade10.Text = ""
            txttlefrgrade10.Text = "0"
            txttleatgrade10.Text = ""
            txttlecgrade10.Text = ""
            txttleecagrade10.Text = ""
            txtmapeh1grade10.Text = ""
            txtmapeh2grade10.Text = ""
            txtmapeh3grade10.Text = ""
            txtmapeh4grade10.Text = ""
            txtmapehfrgrade10.Text = "0"
            txtmapehatgrade10.Text = ""
            txtmapehcgrade10.Text = ""
            txtmapehecagrade10.Text = ""
            txtmusic1grade10.Text = ""
            txtmusic2grade10.Text = ""
            txtmusic3grade10.Text = ""
            txtmusic4grade10.Text = ""
            txtmusicfrgrade10.Text = "0"
            txtmusicatgrade10.Text = ""
            txtmusiccgrade10.Text = ""
            txtmusicecagrade10.Text = ""
            txtarts1grade10.Text = ""
            txtarts2grade10.Text = ""
            txtarts3grade10.Text = ""
            txtarts4grade10.Text = ""
            txtartsfrgrade10.Text = "0"
            txtartsatgrade10.Text = ""
            txtartscgrade10.Text = ""
            txtartsecagrade10.Text = ""
            txtpe1grade10.Text = ""
            txtpe2grade10.Text = ""
            txtpe3grade10.Text = ""
            txtpe4grade10.Text = ""
            txtpefrgrade10.Text = "0"
            txtpeatgrade10.Text = ""
            txtpecgrade10.Text = ""
            txtpeecagrade10.Text = ""
            txthealth1grade10.Text = ""
            txthealth2grade10.Text = ""
            txthealth3grade10.Text = ""
            txthealth4grade10.Text = ""
            txthealthfrgrade10.Text = "0"
            txthealthatgrade10.Text = ""
            txthealthcgrade10.Text = ""
            txthealthecagrade10.Text = ""
            txtaveragefrgrade10.Text = "0"
            txtaverageatgrade10.Text = ""
            txtaveragecgrade10.Text = ""
            txtdsjungrade7.Text = ""
            txtdsjulgrade7.Text = ""
            txtdsauggrade7.Text = ""
            txtdssepgrade7.Text = ""
            txtdsoctgrade7.Text = ""
            txtdsnovgrade7.Text = ""
            txtdsdecgrade7.Text = ""
            txtdsjangrade7.Text = ""
            txtdsfebgrade7.Text = ""
            txtdsmargrade7.Text = ""
            txtdsaprgrade7.Text = ""
            txtdstotalgrade7.Text = ""
            txtdpjungrade7.Text = ""
            txtdpjulgrade7.Text = ""
            txtdpauggrade7.Text = ""
            txtdpsepgrade7.Text = ""
            txtdpoctgrade7.Text = ""
            txtdpnovgrade7.Text = ""
            txtdpdecgrade7.Text = ""
            txtdpjangrade7.Text = ""
            txtdpfebgrade7.Text = ""
            txtdpmargrade7.Text = ""
            txtdpaprgrade7.Text = ""
            txtdptotalgrade7.Text = ""
            txtadvisergrade7.Text = ""
            txtadvancedunitsgrade7.Text = ""
            txtlackunitsgrade7.Text = ""
            txtdsjungrade8.Text = ""
            txtdsjulgrade8.Text = ""
            txtdsauggrade8.Text = ""
            txtdssepgrade8.Text = ""
            txtdsoctgrade8.Text = ""
            txtdsnovgrade8.Text = ""
            txtdsdecgrade8.Text = ""
            txtdsjangrade8.Text = ""
            txtdsfebgrade8.Text = ""
            txtdsmargrade8.Text = ""
            txtdsaprgrade8.Text = ""
            txtdstotalgrade8.Text = ""
            txtdpjungrade8.Text = ""
            txtdpjulgrade8.Text = ""
            txtdpauggrade8.Text = ""
            txtdpsepgrade8.Text = ""
            txtdpoctgrade8.Text = ""
            txtdpnovgrade8.Text = ""
            txtdpdecgrade8.Text = ""
            txtdpjangrade8.Text = ""
            txtdpfebgrade8.Text = ""
            txtdpmargrade8.Text = ""
            txtdpaprgrade8.Text = ""
            txtdptotalgrade8.Text = ""
            txtadvisergrade8.Text = ""
            txtadvancedunitsgrade8.Text = ""
            txtlackunitsgrade8.Text = ""
            txtdsjungrade9.Text = ""
            txtdsjulgrade9.Text = ""
            txtdsauggrade9.Text = ""
            txtdssepgrade9.Text = ""
            txtdsoctgrade9.Text = ""
            txtdsnovgrade9.Text = ""
            txtdsdecgrade9.Text = ""
            txtdsjangrade9.Text = ""
            txtdsfebgrade9.Text = ""
            txtdsmargrade9.Text = ""
            txtdsaprgrade9.Text = ""
            txtdstotalgrade9.Text = ""
            txtdpjungrade9.Text = ""
            txtdpjulgrade9.Text = ""
            txtdpauggrade9.Text = ""
            txtdpsepgrade9.Text = ""
            txtdpoctgrade9.Text = ""
            txtdpnovgrade9.Text = ""
            txtdpdecgrade9.Text = ""
            txtdpjangrade9.Text = ""
            txtdpfebgrade9.Text = ""
            txtdpmargrade9.Text = ""
            txtdpaprgrade9.Text = ""
            txtdptotalgrade9.Text = ""
            txtadvisergrade9.Text = ""
            txtadvancedunitsgrade9.Text = ""
            txtlackunitsgrade9.Text = ""
            txtdsjungrade10.Text = ""
            txtdsjulgrade10.Text = ""
            txtdsauggrade10.Text = ""
            txtdssepgrade10.Text = ""
            txtdsoctgrade10.Text = ""
            txtdsnovgrade10.Text = ""
            txtdsdecgrade10.Text = ""
            txtdsjangrade10.Text = ""
            txtdsfebgrade10.Text = ""
            txtdsmargrade10.Text = ""
            txtdsaprgrade10.Text = ""
            txtdstotalgrade10.Text = ""
            txtdpjungrade10.Text = ""
            txtdpjulgrade10.Text = ""
            txtdpauggrade10.Text = ""
            txtdpsepgrade10.Text = ""
            txtdpoctgrade10.Text = ""
            txtdpnovgrade10.Text = ""
            txtdpdecgrade10.Text = ""
            txtdpjangrade10.Text = ""
            txtdpfebgrade10.Text = ""
            txtdpmargrade10.Text = ""
            txtdpaprgrade10.Text = ""
            txtdptotalgrade10.Text = ""
            txtadvisergrade10.Text = ""
            txtadvancedunitsgrade10.Text = ""
            txtlackunitsgrade10.Text = ""
            txtlrn.Enabled = True
            txtname.Enabled = True
            txtbirthplace.Enabled = True
            txttown.Enabled = True
            txtbrgy.Enabled = True
            txtparent.Enabled = True
            txtoccupation.Enabled = True
            txtaddress.Enabled = True
            txtelementaryschool.Enabled = True
            txtgenave.Enabled = True
            dtpdateofbirth.Enabled = True
            cbgender.Enabled = True
            cbyeargrad.Enabled = True
            txtclassifiedgrade7.Enabled = True
            txtclassifiedgrade7.ReadOnly = True
            cbtotalyearsgrade7.Enabled = True
            txtyeargrade7.Enabled = True
            txtyeargrade7.ReadOnly = True
            txtsectiongrade7.Enabled = True
            txtschoolgrade7.Enabled = True
            cbschoolyeargrade7.Enabled = True
            txtfilipino1grade7.Enabled = True
            txtfilipino2grade7.Enabled = True
            txtfilipino3grade7.Enabled = True
            txtfilipino4grade7.Enabled = True
            txtfilipinofrgrade7.Enabled = True
            txtfilipinoatgrade7.Enabled = True
            txtfilipinocgrade7.Enabled = True
            txtfilipinoecagrade7.Enabled = True
            txtenglish1grade7.Enabled = True
            txtenglish2grade7.Enabled = True
            txtenglish3grade7.Enabled = True
            txtenglish4grade7.Enabled = True
            txtenglishfrgrade7.Enabled = True
            txtenglishatgrade7.Enabled = True
            txtenglishcgrade7.Enabled = True
            txtenglishecagrade7.Enabled = True
            txtmath1grade7.Enabled = True
            txtmath2grade7.Enabled = True
            txtmath3grade7.Enabled = True
            txtmath4grade7.Enabled = True
            txtmathfrgrade7.Enabled = True
            txtmathatgrade7.Enabled = True
            txtmathcgrade7.Enabled = True
            txtmathecagrade7.Enabled = True
            txtscience1grade7.Enabled = True
            txtscience2grade7.Enabled = True
            txtscience3grade7.Enabled = True
            txtscience4grade7.Enabled = True
            txtsciencefrgrade7.Enabled = True
            txtscienceatgrade7.Enabled = True
            txtsciencecgrade7.Enabled = True
            txtscienceecagrade7.Enabled = True
            txtap1grade7.Enabled = True
            txtap2grade7.Enabled = True
            txtap3grade7.Enabled = True
            txtap4grade7.Enabled = True
            txtapfrgrade7.Enabled = True
            txtapatgrade7.Enabled = True
            txtapcgrade7.Enabled = True
            txtapecagrade7.Enabled = True
            txtesp1grade7.Enabled = True
            txtesp2grade7.Enabled = True
            txtesp3grade7.Enabled = True
            txtesp4grade7.Enabled = True
            txtespfrgrade7.Enabled = True
            txtespatgrade7.Enabled = True
            txtespcgrade7.Enabled = True
            txtespecagrade7.Enabled = True
            txttle1grade7.Enabled = True
            txttle2grade7.Enabled = True
            txttle3grade7.Enabled = True
            txttle4grade7.Enabled = True
            txttlefrgrade7.Enabled = True
            txttleatgrade7.Enabled = True
            txttlecgrade7.Enabled = True
            txttleecagrade7.Enabled = True
            txtmapeh1grade7.Enabled = True
            txtmapeh2grade7.Enabled = True
            txtmapeh3grade7.Enabled = True
            txtmapeh4grade7.Enabled = True
            txtmapehfrgrade7.Enabled = True
            txtmapehatgrade7.Enabled = True
            txtmapehcgrade7.Enabled = True
            txtmapehecagrade7.Enabled = True
            txtmusic1grade7.Enabled = True
            txtmusic2grade7.Enabled = True
            txtmusic3grade7.Enabled = True
            txtmusic4grade7.Enabled = True
            txtmusicfrgrade7.Enabled = True
            txtmusicatgrade7.Enabled = True
            txtmusiccgrade7.Enabled = True
            txtmusicecagrade7.Enabled = True
            txtarts1grade7.Enabled = True
            txtarts2grade7.Enabled = True
            txtarts3grade7.Enabled = True
            txtarts4grade7.Enabled = True
            txtartsfrgrade7.Enabled = True
            txtartsatgrade7.Enabled = True
            txtartscgrade7.Enabled = True
            txtartsecagrade7.Enabled = True
            txtpe1grade7.Enabled = True
            txtpe2grade7.Enabled = True
            txtpe3grade7.Enabled = True
            txtpe4grade7.Enabled = True
            txtpefrgrade7.Enabled = True
            txtpeatgrade7.Enabled = True
            txtpecgrade7.Enabled = True
            txtpeecagrade7.Enabled = True
            txthealth1grade7.Enabled = True
            txthealth2grade7.Enabled = True
            txthealth3grade7.Enabled = True
            txthealth4grade7.Enabled = True
            txthealthfrgrade7.Enabled = True
            txthealthatgrade7.Enabled = True
            txthealthcgrade7.Enabled = True
            txthealthecagrade7.Enabled = True
            txtaveragefrgrade7.Enabled = True
            txtaverageatgrade7.Enabled = True
            txtaveragecgrade7.Enabled = True
            txtfilipinofrgrade7.ReadOnly = True
            txtfilipinoatgrade7.ReadOnly = True
            txtenglishfrgrade7.ReadOnly = True
            txtenglishatgrade7.ReadOnly = True
            txtmathfrgrade7.ReadOnly = True
            txtmathatgrade7.ReadOnly = True
            txtsciencefrgrade7.ReadOnly = True
            txtscienceatgrade7.ReadOnly = True
            txtapfrgrade7.ReadOnly = True
            txtapatgrade7.ReadOnly = True
            txtespfrgrade7.ReadOnly = True
            txtespatgrade7.ReadOnly = True
            txttlefrgrade7.ReadOnly = True
            txttleatgrade7.ReadOnly = True
            txtmapeh1grade7.ReadOnly = True
            txtmapeh2grade7.ReadOnly = True
            txtmapeh3grade7.ReadOnly = True
            txtmapeh4grade7.ReadOnly = True
            txtmapehfrgrade7.ReadOnly = True
            txtmapehatgrade7.ReadOnly = True
            txtmusicfrgrade7.ReadOnly = True
            txtmusicatgrade7.ReadOnly = True
            txtartsfrgrade7.ReadOnly = True
            txtartsatgrade7.ReadOnly = True
            txtpefrgrade7.ReadOnly = True
            txtpeatgrade7.ReadOnly = True
            txthealthfrgrade7.ReadOnly = True
            txthealthatgrade7.ReadOnly = True
            txtaveragefrgrade7.ReadOnly = True
            txtaverageatgrade7.ReadOnly = True
            txtclassifiedgrade8.ReadOnly = True
            cbtotalyearsgrade8.Enabled = True
            txtyeargrade8.ReadOnly = True
            txtsectiongrade8.Enabled = True
            txtschoolgrade8.Enabled = True
            cbschoolyeargrade8.Enabled = True
            txtfilipino1grade8.Enabled = True
            txtfilipino2grade8.Enabled = True
            txtfilipino3grade8.Enabled = True
            txtfilipino4grade8.Enabled = True
            txtfilipinofrgrade8.Enabled = True
            txtfilipinoatgrade8.Enabled = True
            txtfilipinocgrade8.Enabled = True
            txtfilipinoecagrade8.Enabled = True
            txtenglish1grade8.Enabled = True
            txtenglish2grade8.Enabled = True
            txtenglish3grade8.Enabled = True
            txtenglish4grade8.Enabled = True
            txtenglishfrgrade8.Enabled = True
            txtenglishatgrade8.Enabled = True
            txtenglishcgrade8.Enabled = True
            txtenglishecagrade8.Enabled = True
            txtmath1grade8.Enabled = True
            txtmath2grade8.Enabled = True
            txtmath3grade8.Enabled = True
            txtmath4grade8.Enabled = True
            txtmathfrgrade8.Enabled = True
            txtmathatgrade8.Enabled = True
            txtmathcgrade8.Enabled = True
            txtmathecagrade8.Enabled = True
            txtscience1grade8.Enabled = True
            txtscience2grade8.Enabled = True
            txtscience3grade8.Enabled = True
            txtscience4grade8.Enabled = True
            txtsciencefrgrade8.Enabled = True
            txtscienceatgrade8.Enabled = True
            txtsciencecgrade8.Enabled = True
            txtscienceecagrade8.Enabled = True
            txtap1grade8.Enabled = True
            txtap2grade8.Enabled = True
            txtap3grade8.Enabled = True
            txtap4grade8.Enabled = True
            txtapfrgrade8.Enabled = True
            txtapatgrade8.Enabled = True
            txtapcgrade8.Enabled = True
            txtapecagrade8.Enabled = True
            txtesp1grade8.Enabled = True
            txtesp2grade8.Enabled = True
            txtesp3grade8.Enabled = True
            txtesp4grade8.Enabled = True
            txtespfrgrade8.Enabled = True
            txtespatgrade8.Enabled = True
            txtespcgrade8.Enabled = True
            txtespecagrade8.Enabled = True
            txttle1grade8.Enabled = True
            txttle2grade8.Enabled = True
            txttle3grade8.Enabled = True
            txttle4grade8.Enabled = True
            txttlefrgrade8.Enabled = True
            txttleatgrade8.Enabled = True
            txttlecgrade8.Enabled = True
            txttleecagrade8.Enabled = True
            txtmapeh1grade8.Enabled = True
            txtmapeh2grade8.Enabled = True
            txtmapeh3grade8.Enabled = True
            txtmapeh4grade8.Enabled = True
            txtmapehfrgrade8.Enabled = True
            txtmapehatgrade8.Enabled = True
            txtmapehcgrade8.Enabled = True
            txtmapehecagrade8.Enabled = True
            txtmusic1grade8.Enabled = True
            txtmusic2grade8.Enabled = True
            txtmusic3grade8.Enabled = True
            txtmusic4grade8.Enabled = True
            txtmusicfrgrade8.Enabled = True
            txtmusicatgrade8.Enabled = True
            txtmusiccgrade8.Enabled = True
            txtmusicecagrade8.Enabled = True
            txtarts1grade8.Enabled = True
            txtarts2grade8.Enabled = True
            txtarts3grade8.Enabled = True
            txtarts4grade8.Enabled = True
            txtartsfrgrade8.Enabled = True
            txtartsatgrade8.Enabled = True
            txtartscgrade8.Enabled = True
            txtartsecagrade8.Enabled = True
            txtpe1grade8.Enabled = True
            txtpe2grade8.Enabled = True
            txtpe3grade8.Enabled = True
            txtpe4grade8.Enabled = True
            txtpefrgrade8.Enabled = True
            txtpeatgrade8.Enabled = True
            txtpecgrade8.Enabled = True
            txtpeecagrade8.Enabled = True
            txthealth1grade8.Enabled = True
            txthealth2grade8.Enabled = True
            txthealth3grade8.Enabled = True
            txthealth4grade8.Enabled = True
            txthealthfrgrade8.Enabled = True
            txthealthatgrade8.Enabled = True
            txthealthcgrade8.Enabled = True
            txthealthecagrade8.Enabled = True
            txtaveragefrgrade8.Enabled = True
            txtaverageatgrade8.Enabled = True
            txtaveragecgrade8.Enabled = True
            txtclassifiedgrade8.ReadOnly = True
            txtyeargrade8.ReadOnly = True
            txtfilipinofrgrade8.ReadOnly = True
            txtfilipinoatgrade8.ReadOnly = True
            txtenglishfrgrade8.ReadOnly = True
            txtenglishatgrade8.ReadOnly = True
            txtmathfrgrade8.ReadOnly = True
            txtmathatgrade8.ReadOnly = True
            txtsciencefrgrade8.ReadOnly = True
            txtscienceatgrade8.ReadOnly = True
            txtapfrgrade8.ReadOnly = True
            txtapatgrade8.ReadOnly = True
            txtespfrgrade8.ReadOnly = True
            txtespatgrade8.ReadOnly = True
            txttlefrgrade8.ReadOnly = True
            txttleatgrade8.ReadOnly = True
            txtmapeh1grade8.ReadOnly = True
            txtmapeh2grade8.ReadOnly = True
            txtmapeh3grade8.ReadOnly = True
            txtmapeh4grade8.ReadOnly = True
            txtmapehfrgrade8.ReadOnly = True
            txtmapehatgrade8.ReadOnly = True
            txtmusicfrgrade8.ReadOnly = True
            txtmusicatgrade8.ReadOnly = True
            txtartsfrgrade8.ReadOnly = True
            txtartsatgrade8.ReadOnly = True
            txtpefrgrade8.ReadOnly = True
            txtpeatgrade8.ReadOnly = True
            txthealthfrgrade8.ReadOnly = True
            txthealthatgrade8.ReadOnly = True
            txtaveragefrgrade8.ReadOnly = True
            txtaverageatgrade8.ReadOnly = True
            txtclassifiedgrade9.ReadOnly = True
            cbtotalyearsgrade9.Enabled = True
            txtyeargrade9.ReadOnly = True
            txtsectiongrade9.Enabled = True
            txtschoolgrade9.Enabled = True
            cbschoolyeargrade9.Enabled = True
            txtfilipino1grade9.Enabled = True
            txtfilipino2grade9.Enabled = True
            txtfilipino3grade9.Enabled = True
            txtfilipino4grade9.Enabled = True
            txtfilipinofrgrade9.Enabled = True
            txtfilipinoatgrade9.Enabled = True
            txtfilipinocgrade9.Enabled = True
            txtfilipinoecagrade9.Enabled = True
            txtenglish1grade9.Enabled = True
            txtenglish2grade9.Enabled = True
            txtenglish3grade9.Enabled = True
            txtenglish4grade9.Enabled = True
            txtenglishfrgrade9.Enabled = True
            txtenglishatgrade9.Enabled = True
            txtenglishcgrade9.Enabled = True
            txtenglishecagrade9.Enabled = True
            txtmath1grade9.Enabled = True
            txtmath2grade9.Enabled = True
            txtmath3grade9.Enabled = True
            txtmath4grade9.Enabled = True
            txtmathfrgrade9.Enabled = True
            txtmathatgrade9.Enabled = True
            txtmathcgrade9.Enabled = True
            txtmathecagrade9.Enabled = True
            txtscience1grade9.Enabled = True
            txtscience2grade9.Enabled = True
            txtscience3grade9.Enabled = True
            txtscience4grade9.Enabled = True
            txtsciencefrgrade9.Enabled = True
            txtscienceatgrade9.Enabled = True
            txtsciencecgrade9.Enabled = True
            txtscienceecagrade9.Enabled = True
            txtap1grade9.Enabled = True
            txtap2grade9.Enabled = True
            txtap3grade9.Enabled = True
            txtap4grade9.Enabled = True
            txtapfrgrade9.Enabled = True
            txtapatgrade9.Enabled = True
            txtapcgrade9.Enabled = True
            txtapecagrade9.Enabled = True
            txtesp1grade9.Enabled = True
            txtesp2grade9.Enabled = True
            txtesp3grade9.Enabled = True
            txtesp4grade9.Enabled = True
            txtespfrgrade9.Enabled = True
            txtespatgrade9.Enabled = True
            txtespcgrade9.Enabled = True
            txtespecagrade9.Enabled = True
            txttle1grade9.Enabled = True
            txttle2grade9.Enabled = True
            txttle3grade9.Enabled = True
            txttle4grade9.Enabled = True
            txttlefrgrade9.Enabled = True
            txttleatgrade9.Enabled = True
            txttlecgrade9.Enabled = True
            txttleecagrade9.Enabled = True
            txtmapeh1grade9.Enabled = True
            txtmapeh2grade9.Enabled = True
            txtmapeh3grade9.Enabled = True
            txtmapeh4grade9.Enabled = True
            txtmapehfrgrade9.Enabled = True
            txtmapehatgrade9.Enabled = True
            txtmapehcgrade9.Enabled = True
            txtmapehecagrade9.Enabled = True
            txtmusic1grade9.Enabled = True
            txtmusic2grade9.Enabled = True
            txtmusic3grade9.Enabled = True
            txtmusic4grade9.Enabled = True
            txtmusicfrgrade9.Enabled = True
            txtmusicatgrade9.Enabled = True
            txtmusiccgrade9.Enabled = True
            txtmusicecagrade9.Enabled = True
            txtarts1grade9.Enabled = True
            txtarts2grade9.Enabled = True
            txtarts3grade9.Enabled = True
            txtarts4grade9.Enabled = True
            txtartsfrgrade9.Enabled = True
            txtartsatgrade9.Enabled = True
            txtartscgrade9.Enabled = True
            txtartsecagrade9.Enabled = True
            txtpe1grade9.Enabled = True
            txtpe2grade9.Enabled = True
            txtpe3grade9.Enabled = True
            txtpe4grade9.Enabled = True
            txtpefrgrade9.Enabled = True
            txtpeatgrade9.Enabled = True
            txtpecgrade9.Enabled = True
            txtpeecagrade9.Enabled = True
            txthealth1grade9.Enabled = True
            txthealth2grade9.Enabled = True
            txthealth3grade9.Enabled = True
            txthealth4grade9.Enabled = True
            txthealthfrgrade9.Enabled = True
            txthealthatgrade9.Enabled = True
            txthealthcgrade9.Enabled = True
            txthealthecagrade9.Enabled = True
            txtaveragefrgrade9.Enabled = True
            txtaverageatgrade9.Enabled = True
            txtaveragecgrade9.Enabled = True
            txtclassifiedgrade9.ReadOnly = True
            txtyeargrade9.ReadOnly = True
            txtfilipinofrgrade9.ReadOnly = True
            txtfilipinoatgrade9.ReadOnly = True
            txtenglishfrgrade9.ReadOnly = True
            txtenglishatgrade9.ReadOnly = True
            txtmathfrgrade9.ReadOnly = True
            txtmathatgrade9.ReadOnly = True
            txtsciencefrgrade9.ReadOnly = True
            txtscienceatgrade9.ReadOnly = True
            txtapfrgrade9.ReadOnly = True
            txtapatgrade9.ReadOnly = True
            txtespfrgrade9.ReadOnly = True
            txtespatgrade9.ReadOnly = True
            txttlefrgrade9.ReadOnly = True
            txttleatgrade9.ReadOnly = True
            txtmapeh1grade9.ReadOnly = True
            txtmapeh2grade9.ReadOnly = True
            txtmapeh3grade9.ReadOnly = True
            txtmapeh4grade9.ReadOnly = True
            txtmapehfrgrade9.ReadOnly = True
            txtmapehatgrade9.ReadOnly = True
            txtmusicfrgrade9.ReadOnly = True
            txtmusicatgrade9.ReadOnly = True
            txtartsfrgrade9.ReadOnly = True
            txtartsatgrade9.ReadOnly = True
            txtpefrgrade9.ReadOnly = True
            txtpeatgrade9.ReadOnly = True
            txthealthfrgrade9.ReadOnly = True
            txthealthatgrade9.ReadOnly = True
            txtaveragefrgrade9.ReadOnly = True
            txtaverageatgrade9.ReadOnly = True
            txtclassifiedgrade10.ReadOnly = True
            cbtotalyearsgrade10.Enabled = True
            txtyeargrade10.ReadOnly = True
            txtsectiongrade10.Enabled = True
            txtschoolgrade10.Enabled = True
            cbschoolyeargrade10.Enabled = True
            txtfilipino1grade10.Enabled = True
            txtfilipino2grade10.Enabled = True
            txtfilipino3grade10.Enabled = True
            txtfilipino4grade10.Enabled = True
            txtfilipinofrgrade10.Enabled = True
            txtfilipinoatgrade10.Enabled = True
            txtfilipinocgrade10.Enabled = True
            txtfilipinoecagrade10.Enabled = True
            txtenglish1grade10.Enabled = True
            txtenglish2grade10.Enabled = True
            txtenglish3grade10.Enabled = True
            txtenglish4grade10.Enabled = True
            txtenglishfrgrade10.Enabled = True
            txtenglishatgrade10.Enabled = True
            txtenglishcgrade10.Enabled = True
            txtenglishecagrade10.Enabled = True
            txtmath1grade10.Enabled = True
            txtmath2grade10.Enabled = True
            txtmath3grade10.Enabled = True
            txtmath4grade10.Enabled = True
            txtmathfrgrade10.Enabled = True
            txtmathatgrade10.Enabled = True
            txtmathcgrade10.Enabled = True
            txtmathecagrade10.Enabled = True
            txtscience1grade10.Enabled = True
            txtscience2grade10.Enabled = True
            txtscience3grade10.Enabled = True
            txtscience4grade10.Enabled = True
            txtsciencefrgrade10.Enabled = True
            txtscienceatgrade10.Enabled = True
            txtsciencecgrade10.Enabled = True
            txtscienceecagrade10.Enabled = True
            txtap1grade10.Enabled = True
            txtap2grade10.Enabled = True
            txtap3grade10.Enabled = True
            txtap4grade10.Enabled = True
            txtapfrgrade10.Enabled = True
            txtapatgrade10.Enabled = True
            txtapcgrade10.Enabled = True
            txtapecagrade10.Enabled = True
            txtesp1grade10.Enabled = True
            txtesp2grade10.Enabled = True
            txtesp3grade10.Enabled = True
            txtesp4grade10.Enabled = True
            txtespfrgrade10.Enabled = True
            txtespatgrade10.Enabled = True
            txtespcgrade10.Enabled = True
            txtespecagrade10.Enabled = True
            txttle1grade10.Enabled = True
            txttle2grade10.Enabled = True
            txttle3grade10.Enabled = True
            txttle4grade10.Enabled = True
            txttlefrgrade10.Enabled = True
            txttleatgrade10.Enabled = True
            txttlecgrade10.Enabled = True
            txttleecagrade10.Enabled = True
            txtmapeh1grade10.Enabled = True
            txtmapeh2grade10.Enabled = True
            txtmapeh3grade10.Enabled = True
            txtmapeh4grade10.Enabled = True
            txtmapehfrgrade10.Enabled = True
            txtmapehatgrade10.Enabled = True
            txtmapehcgrade10.Enabled = True
            txtmapehecagrade10.Enabled = True
            txtmusic1grade10.Enabled = True
            txtmusic2grade10.Enabled = True
            txtmusic3grade10.Enabled = True
            txtmusic4grade10.Enabled = True
            txtmusicfrgrade10.Enabled = True
            txtmusicatgrade10.Enabled = True
            txtmusiccgrade10.Enabled = True
            txtmusicecagrade10.Enabled = True
            txtarts1grade10.Enabled = True
            txtarts2grade10.Enabled = True
            txtarts3grade10.Enabled = True
            txtarts4grade10.Enabled = True
            txtartsfrgrade10.Enabled = True
            txtartsatgrade10.Enabled = True
            txtartscgrade10.Enabled = True
            txtartsecagrade10.Enabled = True
            txtpe1grade10.Enabled = True
            txtpe2grade10.Enabled = True
            txtpe3grade10.Enabled = True
            txtpe4grade10.Enabled = True
            txtpefrgrade10.Enabled = True
            txtpeatgrade10.Enabled = True
            txtpecgrade10.Enabled = True
            txtpeecagrade10.Enabled = True
            txthealth1grade10.Enabled = True
            txthealth2grade10.Enabled = True
            txthealth3grade10.Enabled = True
            txthealth4grade10.Enabled = True
            txthealthfrgrade10.Enabled = True
            txthealthatgrade10.Enabled = True
            txthealthcgrade10.Enabled = True
            txthealthecagrade10.Enabled = True
            txtaveragefrgrade10.Enabled = True
            txtaverageatgrade10.Enabled = True
            txtaveragecgrade10.Enabled = True
            txtclassifiedgrade10.ReadOnly = True
            txtyeargrade10.ReadOnly = True
            txtfilipinofrgrade10.ReadOnly = True
            txtfilipinoatgrade10.ReadOnly = True
            txtenglishfrgrade10.ReadOnly = True
            txtenglishatgrade10.ReadOnly = True
            txtmathfrgrade10.ReadOnly = True
            txtmathatgrade10.ReadOnly = True
            txtsciencefrgrade10.ReadOnly = True
            txtscienceatgrade10.ReadOnly = True
            txtapfrgrade10.ReadOnly = True
            txtapatgrade10.ReadOnly = True
            txtespfrgrade10.ReadOnly = True
            txtespatgrade10.ReadOnly = True
            txttlefrgrade10.ReadOnly = True
            txttleatgrade10.ReadOnly = True
            txtmapeh1grade10.ReadOnly = True
            txtmapeh2grade10.ReadOnly = True
            txtmapeh3grade10.ReadOnly = True
            txtmapeh4grade10.ReadOnly = True
            txtmapehfrgrade10.ReadOnly = True
            txtmapehatgrade10.ReadOnly = True
            txtmusicfrgrade10.ReadOnly = True
            txtmusicatgrade10.ReadOnly = True
            txtartsfrgrade10.ReadOnly = True
            txtartsatgrade10.ReadOnly = True
            txtpefrgrade10.ReadOnly = True
            txtpeatgrade10.ReadOnly = True
            txthealthfrgrade10.ReadOnly = True
            txthealthatgrade10.ReadOnly = True
            txtaveragefrgrade10.ReadOnly = True
            txtaverageatgrade10.ReadOnly = True
            txtdsjungrade7.Enabled = True
            txtdsjulgrade7.Enabled = True
            txtdsauggrade7.Enabled = True
            txtdssepgrade7.Enabled = True
            txtdsoctgrade7.Enabled = True
            txtdsnovgrade7.Enabled = True
            txtdsdecgrade7.Enabled = True
            txtdsjangrade7.Enabled = True
            txtdsfebgrade7.Enabled = True
            txtdsmargrade7.Enabled = True
            txtdsaprgrade7.Enabled = True
            txtdstotalgrade7.Enabled = True
            txtdpjungrade7.Enabled = True
            txtdpjulgrade7.Enabled = True
            txtdpauggrade7.Enabled = True
            txtdpsepgrade7.Enabled = True
            txtdpoctgrade7.Enabled = True
            txtdpnovgrade7.Enabled = True
            txtdpdecgrade7.Enabled = True
            txtdpjangrade7.Enabled = True
            txtdpfebgrade7.Enabled = True
            txtdpmargrade7.Enabled = True
            txtdpaprgrade7.Enabled = True
            txtdptotalgrade7.Enabled = True
            txtadvisergrade7.Enabled = True
            txtadvancedunitsgrade7.Enabled = True
            txtlackunitsgrade7.Enabled = True
            txtdsjungrade8.Enabled = True
            txtdsjulgrade8.Enabled = True
            txtdsauggrade8.Enabled = True
            txtdssepgrade8.Enabled = True
            txtdsoctgrade8.Enabled = True
            txtdsnovgrade8.Enabled = True
            txtdsdecgrade8.Enabled = True
            txtdsjangrade8.Enabled = True
            txtdsfebgrade8.Enabled = True
            txtdsmargrade8.Enabled = True
            txtdsaprgrade8.Enabled = True
            txtdstotalgrade8.Enabled = True
            txtdpjungrade8.Enabled = True
            txtdpjulgrade8.Enabled = True
            txtdpauggrade8.Enabled = True
            txtdpsepgrade8.Enabled = True
            txtdpoctgrade8.Enabled = True
            txtdpnovgrade8.Enabled = True
            txtdpdecgrade8.Enabled = True
            txtdpjangrade8.Enabled = True
            txtdpfebgrade8.Enabled = True
            txtdpmargrade8.Enabled = True
            txtdpaprgrade8.Enabled = True
            txtdptotalgrade8.Enabled = True
            txtadvisergrade8.Enabled = True
            txtadvancedunitsgrade8.Enabled = True
            txtlackunitsgrade8.Enabled = True
            txtdsjungrade9.Enabled = True
            txtdsjulgrade9.Enabled = True
            txtdsauggrade9.Enabled = True
            txtdssepgrade9.Enabled = True
            txtdsoctgrade9.Enabled = True
            txtdsnovgrade9.Enabled = True
            txtdsdecgrade9.Enabled = True
            txtdsjangrade9.Enabled = True
            txtdsfebgrade9.Enabled = True
            txtdsmargrade9.Enabled = True
            txtdsaprgrade9.Enabled = True
            txtdstotalgrade9.Enabled = True
            txtdpjungrade9.Enabled = True
            txtdpjulgrade9.Enabled = True
            txtdpauggrade9.Enabled = True
            txtdpsepgrade9.Enabled = True
            txtdpoctgrade9.Enabled = True
            txtdpnovgrade9.Enabled = True
            txtdpdecgrade9.Enabled = True
            txtdpjangrade9.Enabled = True
            txtdpfebgrade9.Enabled = True
            txtdpmargrade9.Enabled = True
            txtdpaprgrade9.Enabled = True
            txtdptotalgrade9.Enabled = True
            txtadvisergrade9.Enabled = True
            txtadvancedunitsgrade9.Enabled = True
            txtlackunitsgrade9.Enabled = True
            txtdsjungrade10.Enabled = True
            txtdsjulgrade10.Enabled = True
            txtdsauggrade10.Enabled = True
            txtdssepgrade10.Enabled = True
            txtdsoctgrade10.Enabled = True
            txtdsnovgrade10.Enabled = True
            txtdsdecgrade10.Enabled = True
            txtdsjangrade10.Enabled = True
            txtdsfebgrade10.Enabled = True
            txtdsmargrade10.Enabled = True
            txtdsaprgrade10.Enabled = True
            txtdstotalgrade10.Enabled = True
            txtdpjungrade10.Enabled = True
            txtdpjulgrade10.Enabled = True
            txtdpauggrade10.Enabled = True
            txtdpsepgrade10.Enabled = True
            txtdpoctgrade10.Enabled = True
            txtdpnovgrade10.Enabled = True
            txtdpdecgrade10.Enabled = True
            txtdpjangrade10.Enabled = True
            txtdpfebgrade10.Enabled = True
            txtdpmargrade10.Enabled = True
            txtdpaprgrade10.Enabled = True
            txtdptotalgrade10.Enabled = True
            txtadvisergrade10.Enabled = True
            txtadvancedunitsgrade10.Enabled = True
            txtlackunitsgrade10.Enabled = True
            txtdstotalgrade7.ReadOnly = True
            txtdptotalgrade7.ReadOnly = True
            txtdstotalgrade8.ReadOnly = True
            txtdptotalgrade8.ReadOnly = True
            txtdstotalgrade9.ReadOnly = True
            txtdptotalgrade9.ReadOnly = True
            txtdstotalgrade10.ReadOnly = True
            txtdptotalgrade10.ReadOnly = True
            btndelete.Enabled = False
            btnupdate.Enabled = False
            btnedit.Enabled = False
            btnprint.Enabled = False
            btnsave.Enabled = True
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click

        conn.Open()
        Try
            Dim updateQuery1, updateQuery2, updateQuery3, updateQuery4, updateQuery5, updateQuery6, updateQuery7, updateQuery8, updateQuery9 As String
            If txtname.Text = "Type the Full Name of the Student..." Or txtname.Text = "" Or dtpdateofbirth.Text = "" Or cbgender.Text = "" Or txtlrn.Text = "" Or txtlrn.Text = "Student LRN..." Or txtbirthplace.Text = "Type the Birthplace/Province..." Or txtbirthplace.Text = "" Or txttown.Text = "Type the Town/City..." Or txttown.Text = "" Or txtbrgy.Text = "Type the Barangay..." Or txtbrgy.Text = "" Or txtparent.Text = "Parent/Guardian's Fullname..." Or txtparent.Text = "" Or txtoccupation.Text = "Occupation of the Parent/Guardian..." Or txtoccupation.Text = "" Or txtaddress.Text = "Address of the Parent/Guardian..." Or txtaddress.Text = "" Or txtelementaryschool.Text = "Elementary School Graduated..." Or txtelementaryschool.Text = "" Or cbyeargrad.Text = "" Or txtgenave.Text = "Ave. Grade..." Or txtgenave.Text = "" Then
                MessageBox.Show("You must fill up all the required information to proceed")
            Else
                If MessageBox.Show("Are You Sure You Want to Update all the information?", "Update", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    updateQuery1 = "UPDATE studinfoTbl set fullname='" & txtname.Text & "',dateofbirth='" & dtpdateofbirth.Text & "',sex='" & cbgender.Text & "',birthplace='" & txtbirthplace.Text & "',town='" & txttown.Text & "',brgy='" & txtbrgy.Text & "',parent='" & txtparent.Text & "',occupation='" & txtoccupation.Text & "',parentaddress='" & txtaddress.Text & "',elemschool='" & txtelementaryschool.Text & "',yeargrad='" & cbyeargrad.Text & "',genave='" & txtgenave.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery2 = "UPDATE studrecordgrade7Tbl set classifiedgrade7='" & txtclassifiedgrade7.Text & "',totalyearsgrade7='" & cbtotalyearsgrade7.Text & "',yeargrade7='" & txtyeargrade7.Text & "',sectiongrade7='" & txtsectiongrade7.Text & "',schoolgrade7='" & txtschoolgrade7.Text & "',schoolyeargrade7='" & cbschoolyeargrade7.Text & "',cs1filipinograde7='" & txtfilipino1grade7.Text & "',cs2filipinograde7='" & txtfilipino2grade7.Text & "',cs3filipinograde7='" & txtfilipino3grade7.Text & "',cs4filipinograde7='" & txtfilipino4grade7.Text & "',filipinofinalratinggrade7='" & txtfilipinofrgrade7.Text & "',filipinoactiontakengrade7='" & txtfilipinoatgrade7.Text & "',filipinocreditgrade7='" & txtfilipinocgrade7.Text & "',filipinoecagrade7='" & txtfilipinoecagrade7.Text & "',cs1englishgrade7='" & txtenglish1grade7.Text & "',cs2englishgrade7='" & txtenglish2grade7.Text & "',cs3englishgrade7='" & txtenglish3grade7.Text & "',cs4englishgrade7='" & txtenglish4grade7.Text & "',englishfinalratinggrade7='" & txtenglishfrgrade7.Text & "',englishactiontakengrade7='" & txtenglishatgrade7.Text & "',englishcreditgrade7='" & txtenglishcgrade7.Text & "',englishecagrade7='" & txtenglishecagrade7.Text & "',cs1mathgrade7='" & txtmath1grade7.Text & "',cs2mathgrade7='" & txtmath2grade7.Text & "',cs3mathgrade7='" & txtmath3grade7.Text & "',cs4mathgrade7='" & txtmath4grade7.Text & "',mathfinalratinggrade7='" & txtmathfrgrade7.Text & "',mathactiontakengrade7='" & txtmathatgrade7.Text & "',mathcreditgrade7='" & txtmathcgrade7.Text & "',mathecagrade7='" & txtmathecagrade7.Text & "',cs1sciencegrade7='" & txtscience1grade7.Text & "',cs2sciencegrade7='" & txtscience2grade7.Text & "',cs3sciencegrade7='" & txtscience3grade7.Text & "',cs4sciencegrade7='" & txtscience4grade7.Text & "',sciencefinalratinggrade7='" & txtsciencefrgrade7.Text & "',scienceactiontakengrade7='" & txtscienceatgrade7.Text & "',sciencecreditgrade7='" & txtsciencecgrade7.Text & "',scienceecagrade7='" & txtscienceecagrade7.Text & "',cs1apgrade7='" & txtap1grade7.Text & "',cs2apgrade7='" & txtap2grade7.Text & "',cs3apgrade7='" & txtap3grade7.Text & "',cs4apgrade7='" & txtap4grade7.Text & "',apfinalratinggrade7='" & txtapfrgrade7.Text & "',apactiontakengrade7='" & txtapatgrade7.Text & "',apcreditgrade7='" & txtapcgrade7.Text & "',apecagrade7='" & txtapecagrade7.Text & "',cs1espgrade7='" & txtesp1grade7.Text & "',cs2espgrade7='" & txtesp2grade7.Text & "',cs3espgrade7='" & txtesp3grade7.Text & "',cs4espgrade7='" & txtesp4grade7.Text & "',espfinalratinggrade7='" & txtespfrgrade7.Text & "',espactiontakengrade7='" & txtespatgrade7.Text & "',espcreditgrade7='" & txtespcgrade7.Text & "',especagrade7='" & txtespecagrade7.Text & "',cs1tlegrade7='" & txttle1grade7.Text & "',cs2tlegrade7='" & txttle2grade7.Text & "',cs3tlegrade7='" & txttle3grade7.Text & "',cs4tlegrade7='" & txttle4grade7.Text & "',tlefinalratinggrade7='" & txttlefrgrade7.Text & "',tleactiontakengrade7='" & txttleatgrade7.Text & "',tlecreditgrade7='" & txttlecgrade7.Text & "',tleecagrade7='" & txttleecagrade7.Text & "',cs1mapehgrade7='" & txtmapeh1grade7.Text & "',cs2mapehgrade7='" & txtmapeh2grade7.Text & "',cs3mapehgrade7='" & txtmapeh3grade7.Text & "',cs4mapehgrade7='" & txtmapeh4grade7.Text & "',mapehfinalratinggrade7='" & txtmapehfrgrade7.Text & "',mapehactiontakengrade7='" & txtmapehatgrade7.Text & "',mapehcreditgrade7='" & txtmapehcgrade7.Text & "',mapehecagrade7='" & txtmapehecagrade7.Text & "',cs1musicgrade7='" & txtmusic1grade7.Text & "',cs2musicgrade7='" & txtmusic2grade7.Text & "',cs3musicgrade7='" & txtmusic3grade7.Text & "',cs4musicgrade7='" & txtmusic4grade7.Text & "',musicfinalratinggrade7='" & txtmusicfrgrade7.Text & "',musicactiontakengrade7='" & txtmusicatgrade7.Text & "',musiccreditgrade7='" & txtmusiccgrade7.Text & "',musicecagrade7='" & txtmusicecagrade7.Text & "',cs1artsgrade7='" & txtarts1grade7.Text & "',cs2artsgrade7='" & txtarts2grade7.Text & "',cs3artsgrade7='" & txtarts3grade7.Text & "',cs4artsgrade7='" & txtarts4grade7.Text & "',artsfinalratinggrade7='" & txtartsfrgrade7.Text & "',artsactiontakengrade7='" & txtartsatgrade7.Text & "',artscreditgrade7='" & txtartscgrade7.Text & "',artsecagrade7='" & txtartsecagrade7.Text & "',cs1pegrade7='" & txtpe1grade7.Text & "',cs2pegrade7='" & txtpe2grade7.Text & "',cs3pegrade7='" & txtpe3grade7.Text & "',cs4pegrade7='" & txtpe4grade7.Text & "',pefinalratinggrade7='" & txtpefrgrade7.Text & "',peactiontakengrade7='" & txtpeatgrade7.Text & "',pecreditgrade7='" & txtpecgrade7.Text & "',peecagrade7='" & txtpeecagrade7.Text & "',cs1healthgrade7='" & txthealth1grade7.Text & "',cs2healthgrade7='" & txthealth2grade7.Text & "',cs3healthgrade7='" & txthealth3grade7.Text & "',cs4healthgrade7='" & txthealth4grade7.Text & "',healthfinalratinggrade7='" & txthealthfrgrade7.Text & "',healthactiontakengrade7='" & txthealthatgrade7.Text & "',healthcreditgrade7='" & txthealthcgrade7.Text & "',healthecagrade7='" & txthealthecagrade7.Text & "',averagegrade7='" & txtaveragefrgrade7.Text & "',averageactiontakengrade7='" & txtaverageatgrade7.Text & "',averagecreditgrade7='" & txtaveragecgrade7.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery3 = "UPDATE studrecordgrade8Tbl set classifiedgrade8='" & txtclassifiedgrade8.Text & "',totalyearsgrade8='" & cbtotalyearsgrade8.Text & "',yeargrade8='" & txtyeargrade8.Text & "',sectiongrade8='" & txtsectiongrade8.Text & "',schoolgrade8='" & txtschoolgrade8.Text & "',schoolyeargrade8='" & cbschoolyeargrade8.Text & "',cs1filipinograde8='" & txtfilipino1grade8.Text & "',cs2filipinograde8='" & txtfilipino2grade8.Text & "',cs3filipinograde8='" & txtfilipino3grade8.Text & "',cs4filipinograde8='" & txtfilipino4grade8.Text & "',filipinofinalratinggrade8='" & txtfilipinofrgrade8.Text & "',filipinoactiontakengrade8='" & txtfilipinoatgrade8.Text & "',filipinocreditgrade8='" & txtfilipinocgrade8.Text & "',filipinoecagrade8='" & txtfilipinoecagrade8.Text & "',cs1englishgrade8='" & txtenglish1grade8.Text & "',cs2englishgrade8='" & txtenglish2grade8.Text & "',cs3englishgrade8='" & txtenglish3grade8.Text & "',cs4englishgrade8='" & txtenglish4grade8.Text & "',englishfinalratinggrade8='" & txtenglishfrgrade8.Text & "',englishactiontakengrade8='" & txtenglishatgrade8.Text & "',englishcreditgrade8='" & txtenglishcgrade8.Text & "',englishecagrade8='" & txtenglishecagrade8.Text & "',cs1mathgrade8='" & txtmath1grade8.Text & "',cs2mathgrade8='" & txtmath2grade8.Text & "',cs3mathgrade8='" & txtmath3grade8.Text & "',cs4mathgrade8='" & txtmath4grade8.Text & "',mathfinalratinggrade8='" & txtmathfrgrade8.Text & "',mathactiontakengrade8='" & txtmathatgrade8.Text & "',mathcreditgrade8='" & txtmathcgrade8.Text & "',mathecagrade8='" & txtmathecagrade8.Text & "',cs1sciencegrade8='" & txtscience1grade8.Text & "',cs2sciencegrade8='" & txtscience2grade8.Text & "',cs3sciencegrade8='" & txtscience3grade8.Text & "',cs4sciencegrade8='" & txtscience4grade8.Text & "',sciencefinalratinggrade8='" & txtsciencefrgrade8.Text & "',scienceactiontakengrade8='" & txtscienceatgrade8.Text & "',sciencecreditgrade8='" & txtsciencecgrade8.Text & "',scienceecagrade8='" & txtscienceecagrade8.Text & "',cs1apgrade8='" & txtap1grade8.Text & "',cs2apgrade8='" & txtap2grade8.Text & "',cs3apgrade8='" & txtap3grade8.Text & "',cs4apgrade8='" & txtap4grade8.Text & "',apfinalratinggrade8='" & txtapfrgrade8.Text & "',apactiontakengrade8='" & txtapatgrade8.Text & "',apcreditgrade8='" & txtapcgrade8.Text & "',apecagrade8='" & txtapecagrade8.Text & "',cs1espgrade8='" & txtesp1grade8.Text & "',cs2espgrade8='" & txtesp2grade8.Text & "',cs3espgrade8='" & txtesp3grade8.Text & "',cs4espgrade8='" & txtesp4grade8.Text & "',espfinalratinggrade8='" & txtespfrgrade8.Text & "',espactiontakengrade8='" & txtespatgrade8.Text & "',espcreditgrade8='" & txtespcgrade8.Text & "',especagrade8='" & txtespecagrade8.Text & "',cs1tlegrade8='" & txttle1grade8.Text & "',cs2tlegrade8='" & txttle2grade8.Text & "',cs3tlegrade8='" & txttle3grade8.Text & "',cs4tlegrade8='" & txttle4grade8.Text & "',tlefinalratinggrade8='" & txttlefrgrade8.Text & "',tleactiontakengrade8='" & txttleatgrade8.Text & "',tlecreditgrade8='" & txttlecgrade8.Text & "',tleecagrade8='" & txttleecagrade8.Text & "',cs1mapehgrade8='" & txtmapeh1grade8.Text & "',cs2mapehgrade8='" & txtmapeh2grade8.Text & "',cs3mapehgrade8='" & txtmapeh3grade8.Text & "',cs4mapehgrade8='" & txtmapeh4grade8.Text & "',mapehfinalratinggrade8='" & txtmapehfrgrade8.Text & "',mapehactiontakengrade8='" & txtmapehatgrade8.Text & "',mapehcreditgrade8='" & txtmapehcgrade8.Text & "',mapehecagrade8='" & txtmapehecagrade8.Text & "',cs1musicgrade8='" & txtmusic1grade8.Text & "',cs2musicgrade8='" & txtmusic2grade8.Text & "',cs3musicgrade8='" & txtmusic3grade8.Text & "',cs4musicgrade8='" & txtmusic4grade8.Text & "',musicfinalratinggrade8='" & txtmusicfrgrade8.Text & "',musicactiontakengrade8='" & txtmusicatgrade8.Text & "',musiccreditgrade8='" & txtmusiccgrade8.Text & "',musicecagrade8='" & txtmusicecagrade8.Text & "',cs1artsgrade8='" & txtarts1grade8.Text & "',cs2artsgrade8='" & txtarts2grade8.Text & "',cs3artsgrade8='" & txtarts3grade8.Text & "',cs4artsgrade8='" & txtarts4grade8.Text & "',artsfinalratinggrade8='" & txtartsfrgrade8.Text & "',artsactiontakengrade8='" & txtartsatgrade8.Text & "',artscreditgrade8='" & txtartscgrade8.Text & "',artsecagrade8='" & txtartsecagrade8.Text & "',cs1pegrade8='" & txtpe1grade8.Text & "',cs2pegrade8='" & txtpe2grade8.Text & "',cs3pegrade8='" & txtpe3grade8.Text & "',cs4pegrade8='" & txtpe4grade8.Text & "',pefinalratinggrade8='" & txtpefrgrade8.Text & "',peactiontakengrade8='" & txtpeatgrade8.Text & "',pecreditgrade8='" & txtpecgrade8.Text & "',peecagrade8='" & txtpeecagrade8.Text & "',cs1healthgrade8='" & txthealth1grade8.Text & "',cs2healthgrade8='" & txthealth2grade8.Text & "',cs3healthgrade8='" & txthealth3grade8.Text & "',cs4healthgrade8='" & txthealth4grade8.Text & "',healthfinalratinggrade8='" & txthealthfrgrade8.Text & "',healthactiontakengrade8='" & txthealthatgrade8.Text & "',healthcreditgrade8='" & txthealthcgrade8.Text & "',healthecagrade8='" & txthealthecagrade8.Text & "',averagegrade8='" & txtaveragefrgrade8.Text & "',averageactiontakengrade8='" & txtaverageatgrade8.Text & "',averagecreditgrade8='" & txtaveragecgrade8.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery4 = "UPDATE studrecordgrade9Tbl set classifiedgrade9='" & txtclassifiedgrade9.Text & "',totalyearsgrade9='" & cbtotalyearsgrade9.Text & "',yeargrade9='" & txtyeargrade9.Text & "',sectiongrade9='" & txtsectiongrade9.Text & "',schoolgrade9='" & txtschoolgrade9.Text & "',schoolyeargrade9='" & cbschoolyeargrade9.Text & "',cs1filipinograde9='" & txtfilipino1grade9.Text & "',cs2filipinograde9='" & txtfilipino2grade9.Text & "',cs3filipinograde9='" & txtfilipino3grade9.Text & "',cs4filipinograde9='" & txtfilipino4grade9.Text & "',filipinofinalratinggrade9='" & txtfilipinofrgrade9.Text & "',filipinoactiontakengrade9='" & txtfilipinoatgrade9.Text & "',filipinocreditgrade9='" & txtfilipinocgrade9.Text & "',filipinoecagrade9='" & txtfilipinoecagrade9.Text & "',cs1englishgrade9='" & txtenglish1grade9.Text & "',cs2englishgrade9='" & txtenglish2grade9.Text & "',cs3englishgrade9='" & txtenglish3grade9.Text & "',cs4englishgrade9='" & txtenglish4grade9.Text & "',englishfinalratinggrade9='" & txtenglishfrgrade9.Text & "',englishactiontakengrade9='" & txtenglishatgrade9.Text & "',englishcreditgrade9='" & txtenglishcgrade9.Text & "',englishecagrade9='" & txtenglishecagrade9.Text & "',cs1mathgrade9='" & txtmath1grade9.Text & "',cs2mathgrade9='" & txtmath2grade9.Text & "',cs3mathgrade9='" & txtmath3grade9.Text & "',cs4mathgrade9='" & txtmath4grade9.Text & "',mathfinalratinggrade9='" & txtmathfrgrade9.Text & "',mathactiontakengrade9='" & txtmathatgrade9.Text & "',mathcreditgrade9='" & txtmathcgrade9.Text & "',mathecagrade9='" & txtmathecagrade9.Text & "',cs1sciencegrade9='" & txtscience1grade9.Text & "',cs2sciencegrade9='" & txtscience2grade9.Text & "',cs3sciencegrade9='" & txtscience3grade9.Text & "',cs4sciencegrade9='" & txtscience4grade9.Text & "',sciencefinalratinggrade9='" & txtsciencefrgrade9.Text & "',scienceactiontakengrade9='" & txtscienceatgrade9.Text & "',sciencecreditgrade9='" & txtsciencecgrade9.Text & "',scienceecagrade9='" & txtscienceecagrade9.Text & "',cs1apgrade9='" & txtap1grade9.Text & "',cs2apgrade9='" & txtap2grade9.Text & "',cs3apgrade9='" & txtap3grade9.Text & "',cs4apgrade9='" & txtap4grade9.Text & "',apfinalratinggrade9='" & txtapfrgrade9.Text & "',apactiontakengrade9='" & txtapatgrade9.Text & "',apcreditgrade9='" & txtapcgrade9.Text & "',apecagrade9='" & txtapecagrade9.Text & "',cs1espgrade9='" & txtesp1grade9.Text & "',cs2espgrade9='" & txtesp2grade9.Text & "',cs3espgrade9='" & txtesp3grade9.Text & "',cs4espgrade9='" & txtesp4grade9.Text & "',espfinalratinggrade9='" & txtespfrgrade9.Text & "',espactiontakengrade9='" & txtespatgrade9.Text & "',espcreditgrade9='" & txtespcgrade9.Text & "',especagrade9='" & txtespecagrade9.Text & "',cs1tlegrade9='" & txttle1grade9.Text & "',cs2tlegrade9='" & txttle2grade9.Text & "',cs3tlegrade9='" & txttle3grade9.Text & "',cs4tlegrade9='" & txttle4grade9.Text & "',tlefinalratinggrade9='" & txttlefrgrade9.Text & "',tleactiontakengrade9='" & txttleatgrade9.Text & "',tlecreditgrade9='" & txttlecgrade9.Text & "',tleecagrade9='" & txttleecagrade9.Text & "',cs1mapehgrade9='" & txtmapeh1grade9.Text & "',cs2mapehgrade9='" & txtmapeh2grade9.Text & "',cs3mapehgrade9='" & txtmapeh3grade9.Text & "',cs4mapehgrade9='" & txtmapeh4grade9.Text & "',mapehfinalratinggrade9='" & txtmapehfrgrade9.Text & "',mapehactiontakengrade9='" & txtmapehatgrade9.Text & "',mapehcreditgrade9='" & txtmapehcgrade9.Text & "',mapehecagrade9='" & txtmapehecagrade9.Text & "',cs1musicgrade9='" & txtmusic1grade9.Text & "',cs2musicgrade9='" & txtmusic2grade9.Text & "',cs3musicgrade9='" & txtmusic3grade9.Text & "',cs4musicgrade9='" & txtmusic4grade9.Text & "',musicfinalratinggrade9='" & txtmusicfrgrade9.Text & "',musicactiontakengrade9='" & txtmusicatgrade9.Text & "',musiccreditgrade9='" & txtmusiccgrade9.Text & "',musicecagrade9='" & txtmusicecagrade9.Text & "',cs1artsgrade9='" & txtarts1grade9.Text & "',cs2artsgrade9='" & txtarts2grade9.Text & "',cs3artsgrade9='" & txtarts3grade9.Text & "',cs4artsgrade9='" & txtarts4grade9.Text & "',artsfinalratinggrade9='" & txtartsfrgrade9.Text & "',artsactiontakengrade9='" & txtartsatgrade9.Text & "',artscreditgrade9='" & txtartscgrade9.Text & "',artsecagrade9='" & txtartsecagrade9.Text & "',cs1pegrade9='" & txtpe1grade9.Text & "',cs2pegrade9='" & txtpe2grade9.Text & "',cs3pegrade9='" & txtpe3grade9.Text & "',cs4pegrade9='" & txtpe4grade9.Text & "',pefinalratinggrade9='" & txtpefrgrade9.Text & "',peactiontakengrade9='" & txtpeatgrade9.Text & "',pecreditgrade9='" & txtpecgrade9.Text & "',peecagrade9='" & txtpeecagrade9.Text & "',cs1healthgrade9='" & txthealth1grade9.Text & "',cs2healthgrade9='" & txthealth2grade9.Text & "',cs3healthgrade9='" & txthealth3grade9.Text & "',cs4healthgrade9='" & txthealth4grade9.Text & "',healthfinalratinggrade9='" & txthealthfrgrade9.Text & "',healthactiontakengrade9='" & txthealthatgrade9.Text & "',healthcreditgrade9='" & txthealthcgrade9.Text & "',healthecagrade9='" & txthealthecagrade9.Text & "',averagegrade9='" & txtaveragefrgrade9.Text & "',averageactiontakengrade9='" & txtaverageatgrade9.Text & "',averagecreditgrade9='" & txtaveragecgrade9.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery5 = "UPDATE studrecordgrade10Tbl set classifiedgrade10='" & txtclassifiedgrade10.Text & "',totalyearsgrade10='" & cbtotalyearsgrade10.Text & "',yeargrade10='" & txtyeargrade10.Text & "',sectiongrade10='" & txtsectiongrade10.Text & "',schoolgrade10='" & txtschoolgrade10.Text & "',schoolyeargrade10='" & cbschoolyeargrade10.Text & "',cs1filipinograde10='" & txtfilipino1grade10.Text & "',cs2filipinograde10='" & txtfilipino2grade10.Text & "',cs3filipinograde10='" & txtfilipino3grade10.Text & "',cs4filipinograde10='" & txtfilipino4grade10.Text & "',filipinofinalratinggrade10='" & txtfilipinofrgrade10.Text & "',filipinoactiontakengrade10='" & txtfilipinoatgrade10.Text & "',filipinocreditgrade10='" & txtfilipinocgrade10.Text & "',filipinoecagrade10='" & txtfilipinoecagrade10.Text & "',cs1englishgrade10='" & txtenglish1grade10.Text & "',cs2englishgrade10='" & txtenglish2grade10.Text & "',cs3englishgrade10='" & txtenglish3grade10.Text & "',cs4englishgrade10='" & txtenglish4grade10.Text & "',englishfinalratinggrade10='" & txtenglishfrgrade10.Text & "',englishactiontakengrade10='" & txtenglishatgrade10.Text & "',englishcreditgrade10='" & txtenglishcgrade10.Text & "',englishecagrade10='" & txtenglishecagrade10.Text & "',cs1mathgrade10='" & txtmath1grade10.Text & "',cs2mathgrade10='" & txtmath2grade10.Text & "',cs3mathgrade10='" & txtmath3grade10.Text & "',cs4mathgrade10='" & txtmath4grade10.Text & "',mathfinalratinggrade10='" & txtmathfrgrade10.Text & "',mathactiontakengrade10='" & txtmathatgrade10.Text & "',mathcreditgrade10='" & txtmathcgrade10.Text & "',mathecagrade10='" & txtmathecagrade10.Text & "',cs1sciencegrade10='" & txtscience1grade10.Text & "',cs2sciencegrade10='" & txtscience2grade10.Text & "',cs3sciencegrade10='" & txtscience3grade10.Text & "',cs4sciencegrade10='" & txtscience4grade10.Text & "',sciencefinalratinggrade10='" & txtsciencefrgrade10.Text & "',scienceactiontakengrade10='" & txtscienceatgrade10.Text & "',sciencecreditgrade10='" & txtsciencecgrade10.Text & "',scienceecagrade10='" & txtscienceecagrade10.Text & "',cs1apgrade10='" & txtap1grade10.Text & "',cs2apgrade10='" & txtap2grade10.Text & "',cs3apgrade10='" & txtap3grade10.Text & "',cs4apgrade10='" & txtap4grade10.Text & "',apfinalratinggrade10='" & txtapfrgrade10.Text & "',apactiontakengrade10='" & txtapatgrade10.Text & "',apcreditgrade10='" & txtapcgrade10.Text & "',apecagrade10='" & txtapecagrade10.Text & "',cs1espgrade10='" & txtesp1grade10.Text & "',cs2espgrade10='" & txtesp2grade10.Text & "',cs3espgrade10='" & txtesp3grade10.Text & "',cs4espgrade10='" & txtesp4grade10.Text & "',espfinalratinggrade10='" & txtespfrgrade10.Text & "',espactiontakengrade10='" & txtespatgrade10.Text & "',espcreditgrade10='" & txtespcgrade10.Text & "',especagrade10='" & txtespecagrade10.Text & "',cs1tlegrade10='" & txttle1grade10.Text & "',cs2tlegrade10='" & txttle2grade10.Text & "',cs3tlegrade10='" & txttle3grade10.Text & "',cs4tlegrade10='" & txttle4grade10.Text & "',tlefinalratinggrade10='" & txttlefrgrade10.Text & "',tleactiontakengrade10='" & txttleatgrade10.Text & "',tlecreditgrade10='" & txttlecgrade10.Text & "',tleecagrade10='" & txttleecagrade10.Text & "',cs1mapehgrade10='" & txtmapeh1grade10.Text & "',cs2mapehgrade10='" & txtmapeh2grade10.Text & "',cs3mapehgrade10='" & txtmapeh3grade10.Text & "',cs4mapehgrade10='" & txtmapeh4grade10.Text & "',mapehfinalratinggrade10='" & txtmapehfrgrade10.Text & "',mapehactiontakengrade10='" & txtmapehatgrade10.Text & "',mapehcreditgrade10='" & txtmapehcgrade10.Text & "',mapehecagrade10='" & txtmapehecagrade10.Text & "',cs1musicgrade10='" & txtmusic1grade10.Text & "',cs2musicgrade10='" & txtmusic2grade10.Text & "',cs3musicgrade10='" & txtmusic3grade10.Text & "',cs4musicgrade10='" & txtmusic4grade10.Text & "',musicfinalratinggrade10='" & txtmusicfrgrade10.Text & "',musicactiontakengrade10='" & txtmusicatgrade10.Text & "',musiccreditgrade10='" & txtmusiccgrade10.Text & "',musicecagrade10='" & txtmusicecagrade10.Text & "',cs1artsgrade10='" & txtarts1grade10.Text & "',cs2artsgrade10='" & txtarts2grade10.Text & "',cs3artsgrade10='" & txtarts3grade10.Text & "',cs4artsgrade10='" & txtarts4grade10.Text & "',artsfinalratinggrade10='" & txtartsfrgrade10.Text & "',artsactiontakengrade10='" & txtartsatgrade10.Text & "',artscreditgrade10='" & txtartscgrade10.Text & "',artsecagrade10='" & txtartsecagrade10.Text & "',cs1pegrade10='" & txtpe1grade10.Text & "',cs2pegrade10='" & txtpe2grade10.Text & "',cs3pegrade10='" & txtpe3grade10.Text & "',cs4pegrade10='" & txtpe4grade10.Text & "',pefinalratinggrade10='" & txtpefrgrade10.Text & "',peactiontakengrade10='" & txtpeatgrade10.Text & "',pecreditgrade10='" & txtpecgrade10.Text & "',peecagrade10='" & txtpeecagrade10.Text & "',cs1healthgrade10='" & txthealth1grade10.Text & "',cs2healthgrade10='" & txthealth2grade10.Text & "',cs3healthgrade10='" & txthealth3grade10.Text & "',cs4healthgrade10='" & txthealth4grade10.Text & "',healthfinalratinggrade10='" & txthealthfrgrade10.Text & "',healthactiontakengrade10='" & txthealthatgrade10.Text & "',healthcreditgrade10='" & txthealthcgrade10.Text & "',healthecagrade10='" & txthealthecagrade10.Text & "',averagegrade10='" & txtaveragefrgrade10.Text & "',averageactiontakengrade10='" & txtaverageatgrade10.Text & "',averagecreditgrade10='" & txtaveragecgrade10.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery6 = "UPDATE studattendancegrade7Tbl set dsjungrade7='" & txtdsjungrade7.Text & "',dsjulgrade7='" & txtdsjulgrade7.Text & "',dsauggrade7='" & txtdsauggrade7.Text & "',dssepgrade7='" & txtdssepgrade7.Text & "',dsoctgrade7='" & txtdsoctgrade7.Text & "',dsnovgrade7='" & txtdsnovgrade7.Text & "',dsdecgrade7='" & txtdsdecgrade7.Text & "',dsjangrade7='" & txtdsjangrade7.Text & "',dsfebgrade7='" & txtdsfebgrade7.Text & "',dsmargrade7='" & txtdsmargrade7.Text & "',dsaprgrade7='" & txtdsaprgrade7.Text & "',dstotalgrade7='" & txtdstotalgrade7.Text & "',dpjungrade7='" & txtdpjungrade7.Text & "',dpjulgrade7='" & txtdpjulgrade7.Text & "',dpauggrade7='" & txtdpauggrade7.Text & "',dpsepgrade7='" & txtdpsepgrade7.Text & "',dpoctgrade7='" & txtdpoctgrade7.Text & "',dpnovgrade7='" & txtdpnovgrade7.Text & "',dpdecgrade7='" & txtdpdecgrade7.Text & "',dpjangrade7='" & txtdpjangrade7.Text & "',dpfebgrade7='" & txtdpfebgrade7.Text & "',dpmargrade7='" & txtdpmargrade7.Text & "',dpaprgrade7='" & txtdpaprgrade7.Text & "',dptotalgrade7='" & txtdptotalgrade7.Text & "',advisergrade7= '" & txtadvisergrade7.Text & "',advancedunitsgrade7='" & txtadvancedunitsgrade7.Text & "',lackunitsgrade7='" & txtlackunitsgrade7.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery7 = "UPDATE studattendancegrade8Tbl set dsjungrade8='" & txtdsjungrade8.Text & "',dsjulgrade8='" & txtdsjulgrade8.Text & "',dsauggrade8='" & txtdsauggrade8.Text & "',dssepgrade8='" & txtdssepgrade8.Text & "',dsoctgrade8='" & txtdsoctgrade8.Text & "',dsnovgrade8='" & txtdsnovgrade8.Text & "',dsdecgrade8='" & txtdsdecgrade8.Text & "',dsjangrade8='" & txtdsjangrade8.Text & "',dsfebgrade8='" & txtdsfebgrade8.Text & "',dsmargrade8='" & txtdsmargrade8.Text & "',dsaprgrade8='" & txtdsaprgrade8.Text & "',dstotalgrade8='" & txtdstotalgrade8.Text & "',dpjungrade8='" & txtdpjungrade8.Text & "',dpjulgrade8='" & txtdpjulgrade8.Text & "',dpauggrade8='" & txtdpauggrade8.Text & "',dpsepgrade8='" & txtdpsepgrade8.Text & "',dpoctgrade8='" & txtdpoctgrade8.Text & "',dpnovgrade8='" & txtdpnovgrade8.Text & "',dpdecgrade8='" & txtdpdecgrade8.Text & "',dpjangrade8='" & txtdpjangrade8.Text & "',dpfebgrade8='" & txtdpfebgrade8.Text & "',dpmargrade8='" & txtdpmargrade8.Text & "',dpaprgrade8='" & txtdpaprgrade8.Text & "',dptotalgrade8='" & txtdptotalgrade8.Text & "',advisergrade8= '" & txtadvisergrade8.Text & "',advancedunitsgrade8='" & txtadvancedunitsgrade8.Text & "',lackunitsgrade8='" & txtlackunitsgrade8.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery8 = "UPDATE studattendancegrade9Tbl set dsjungrade9='" & txtdsjungrade9.Text & "',dsjulgrade9='" & txtdsjulgrade9.Text & "',dsauggrade9='" & txtdsauggrade9.Text & "',dssepgrade9='" & txtdssepgrade9.Text & "',dsoctgrade9='" & txtdsoctgrade9.Text & "',dsnovgrade9='" & txtdsnovgrade9.Text & "',dsdecgrade9='" & txtdsdecgrade9.Text & "',dsjangrade9='" & txtdsjangrade9.Text & "',dsfebgrade9='" & txtdsfebgrade9.Text & "',dsmargrade9='" & txtdsmargrade9.Text & "',dsaprgrade9='" & txtdsaprgrade9.Text & "',dstotalgrade9='" & txtdstotalgrade9.Text & "',dpjungrade9='" & txtdpjungrade9.Text & "',dpjulgrade9='" & txtdpjulgrade9.Text & "',dpauggrade9='" & txtdpauggrade9.Text & "',dpsepgrade9='" & txtdpsepgrade9.Text & "',dpoctgrade9='" & txtdpoctgrade9.Text & "',dpnovgrade9='" & txtdpnovgrade9.Text & "',dpdecgrade9='" & txtdpdecgrade9.Text & "',dpjangrade9='" & txtdpjangrade9.Text & "',dpfebgrade9='" & txtdpfebgrade9.Text & "',dpmargrade9='" & txtdpmargrade9.Text & "',dpaprgrade9='" & txtdpaprgrade9.Text & "',dptotalgrade9='" & txtdptotalgrade9.Text & "',advisergrade9= '" & txtadvisergrade9.Text & "',advancedunitsgrade9='" & txtadvancedunitsgrade9.Text & "',lackunitsgrade9='" & txtlackunitsgrade9.Text & "' where lrn='" & txtlrn.Text & "'"
                    updateQuery9 = "UPDATE studattendancegrade10Tbl set dsjungrade10='" & txtdsjungrade10.Text & "',dsjulgrade10='" & txtdsjulgrade10.Text & "',dsauggrade10='" & txtdsauggrade10.Text & "',dssepgrade10='" & txtdssepgrade10.Text & "',dsoctgrade10='" & txtdsoctgrade10.Text & "',dsnovgrade10='" & txtdsnovgrade10.Text & "',dsdecgrade10='" & txtdsdecgrade10.Text & "',dsjangrade10='" & txtdsjangrade10.Text & "',dsfebgrade10='" & txtdsfebgrade10.Text & "',dsmargrade10='" & txtdsmargrade10.Text & "',dsaprgrade10='" & txtdsaprgrade10.Text & "',dstotalgrade10='" & txtdstotalgrade10.Text & "',dpjungrade10='" & txtdpjungrade10.Text & "',dpjulgrade10='" & txtdpjulgrade10.Text & "',dpauggrade10='" & txtdpauggrade10.Text & "',dpsepgrade10='" & txtdpsepgrade10.Text & "',dpoctgrade10='" & txtdpoctgrade10.Text & "',dpnovgrade10='" & txtdpnovgrade10.Text & "',dpdecgrade10='" & txtdpdecgrade10.Text & "',dpjangrade10='" & txtdpjangrade10.Text & "',dpfebgrade10='" & txtdpfebgrade10.Text & "',dpmargrade10='" & txtdpmargrade10.Text & "',dpaprgrade10='" & txtdpaprgrade10.Text & "',dptotalgrade10='" & txtdptotalgrade10.Text & "',advisergrade10= '" & txtadvisergrade10.Text & "',advancedunitsgrade10='" & txtadvancedunitsgrade10.Text & "',lackunitsgrade10='" & txtlackunitsgrade10.Text & "' where lrn='" & txtlrn.Text & "'"
                    Dim command1 As New SqlCommand(updateQuery1, conn)
                    Dim command2 As New SqlCommand(updateQuery2, conn)
                    Dim command3 As New SqlCommand(updateQuery3, conn)
                    Dim command4 As New SqlCommand(updateQuery4, conn)
                    Dim command5 As New SqlCommand(updateQuery5, conn)
                    Dim command6 As New SqlCommand(updateQuery6, conn)
                    Dim command7 As New SqlCommand(updateQuery7, conn)
                    Dim command8 As New SqlCommand(updateQuery8, conn)
                    Dim command9 As New SqlCommand(updateQuery9, conn)
                    command1.ExecuteNonQuery()
                    command2.ExecuteNonQuery()
                    command3.ExecuteNonQuery()
                    command4.ExecuteNonQuery()
                    command5.ExecuteNonQuery()
                    command6.ExecuteNonQuery()
                    command7.ExecuteNonQuery()
                    command8.ExecuteNonQuery()
                    command9.ExecuteNonQuery()
                    MessageBox.Show("Information Updated")
                    txtlrn.Enabled = False
                    txtname.Enabled = False
                    txtbirthplace.Enabled = False
                    txttown.Enabled = False
                    txtbrgy.Enabled = False
                    txtparent.Enabled = False
                    txtoccupation.Enabled = False
                    txtaddress.Enabled = False
                    txtelementaryschool.Enabled = False
                    txtgenave.Enabled = False
                    dtpdateofbirth.Enabled = False
                    cbgender.Enabled = False
                    cbyeargrad.Enabled = False
                    txtclassifiedgrade7.Enabled = False
                    cbtotalyearsgrade7.Enabled = False
                    txtyeargrade7.Enabled = False
                    txtsectiongrade7.Enabled = False
                    txtschoolgrade7.Enabled = False
                    cbschoolyeargrade7.Enabled = False
                    txtfilipino1grade7.Enabled = False
                    txtfilipino2grade7.Enabled = False
                    txtfilipino3grade7.Enabled = False
                    txtfilipino4grade7.Enabled = False
                    txtfilipinofrgrade7.Enabled = False
                    txtfilipinoatgrade7.Enabled = False
                    txtfilipinocgrade7.Enabled = False
                    txtfilipinoecagrade7.Enabled = False
                    txtenglish1grade7.Enabled = False
                    txtenglish2grade7.Enabled = False
                    txtenglish3grade7.Enabled = False
                    txtenglish4grade7.Enabled = False
                    txtenglishfrgrade7.Enabled = False
                    txtenglishatgrade7.Enabled = False
                    txtenglishcgrade7.Enabled = False
                    txtenglishecagrade7.Enabled = False
                    txtmath1grade7.Enabled = False
                    txtmath2grade7.Enabled = False
                    txtmath3grade7.Enabled = False
                    txtmath4grade7.Enabled = False
                    txtmathfrgrade7.Enabled = False
                    txtmathatgrade7.Enabled = False
                    txtmathcgrade7.Enabled = False
                    txtmathecagrade7.Enabled = False
                    txtscience1grade7.Enabled = False
                    txtscience2grade7.Enabled = False
                    txtscience3grade7.Enabled = False
                    txtscience4grade7.Enabled = False
                    txtsciencefrgrade7.Enabled = False
                    txtscienceatgrade7.Enabled = False
                    txtsciencecgrade7.Enabled = False
                    txtscienceecagrade7.Enabled = False
                    txtap1grade7.Enabled = False
                    txtap2grade7.Enabled = False
                    txtap3grade7.Enabled = False
                    txtap4grade7.Enabled = False
                    txtapfrgrade7.Enabled = False
                    txtapatgrade7.Enabled = False
                    txtapcgrade7.Enabled = False
                    txtapecagrade7.Enabled = False
                    txtesp1grade7.Enabled = False
                    txtesp2grade7.Enabled = False
                    txtesp3grade7.Enabled = False
                    txtesp4grade7.Enabled = False
                    txtespfrgrade7.Enabled = False
                    txtespatgrade7.Enabled = False
                    txtespcgrade7.Enabled = False
                    txtespecagrade7.Enabled = False
                    txttle1grade7.Enabled = False
                    txttle2grade7.Enabled = False
                    txttle3grade7.Enabled = False
                    txttle4grade7.Enabled = False
                    txttlefrgrade7.Enabled = False
                    txttleatgrade7.Enabled = False
                    txttlecgrade7.Enabled = False
                    txttleecagrade7.Enabled = False
                    txtmapeh1grade7.Enabled = False
                    txtmapeh2grade7.Enabled = False
                    txtmapeh3grade7.Enabled = False
                    txtmapeh4grade7.Enabled = False
                    txtmapehfrgrade7.Enabled = False
                    txtmapehatgrade7.Enabled = False
                    txtmapehcgrade7.Enabled = False
                    txtmapehecagrade7.Enabled = False
                    txtmusic1grade7.Enabled = False
                    txtmusic2grade7.Enabled = False
                    txtmusic3grade7.Enabled = False
                    txtmusic4grade7.Enabled = False
                    txtmusicfrgrade7.Enabled = False
                    txtmusicatgrade7.Enabled = False
                    txtmusiccgrade7.Enabled = False
                    txtmusicecagrade7.Enabled = False
                    txtarts1grade7.Enabled = False
                    txtarts2grade7.Enabled = False
                    txtarts3grade7.Enabled = False
                    txtarts4grade7.Enabled = False
                    txtartsfrgrade7.Enabled = False
                    txtartsatgrade7.Enabled = False
                    txtartscgrade7.Enabled = False
                    txtartsecagrade7.Enabled = False
                    txtpe1grade7.Enabled = False
                    txtpe2grade7.Enabled = False
                    txtpe3grade7.Enabled = False
                    txtpe4grade7.Enabled = False
                    txtpefrgrade7.Enabled = False
                    txtpeatgrade7.Enabled = False
                    txtpecgrade7.Enabled = False
                    txtpeecagrade7.Enabled = False
                    txthealth1grade7.Enabled = False
                    txthealth2grade7.Enabled = False
                    txthealth3grade7.Enabled = False
                    txthealth4grade7.Enabled = False
                    txthealthfrgrade7.Enabled = False
                    txthealthatgrade7.Enabled = False
                    txthealthcgrade7.Enabled = False
                    txthealthecagrade7.Enabled = False
                    txtaveragefrgrade7.Enabled = False
                    txtaverageatgrade7.Enabled = False
                    txtaveragecgrade7.Enabled = False
                    txtclassifiedgrade8.Enabled = False
                    cbtotalyearsgrade8.Enabled = False
                    txtyeargrade8.Enabled = False
                    txtsectiongrade8.Enabled = False
                    txtschoolgrade8.Enabled = False
                    cbschoolyeargrade8.Enabled = False
                    txtfilipino1grade8.Enabled = False
                    txtfilipino2grade8.Enabled = False
                    txtfilipino3grade8.Enabled = False
                    txtfilipino4grade8.Enabled = False
                    txtfilipinofrgrade8.Enabled = False
                    txtfilipinoatgrade8.Enabled = False
                    txtfilipinocgrade8.Enabled = False
                    txtfilipinoecagrade8.Enabled = False
                    txtenglish1grade8.Enabled = False
                    txtenglish2grade8.Enabled = False
                    txtenglish3grade8.Enabled = False
                    txtenglish4grade8.Enabled = False
                    txtenglishfrgrade8.Enabled = False
                    txtenglishatgrade8.Enabled = False
                    txtenglishcgrade8.Enabled = False
                    txtenglishecagrade8.Enabled = False
                    txtmath1grade8.Enabled = False
                    txtmath2grade8.Enabled = False
                    txtmath3grade8.Enabled = False
                    txtmath4grade8.Enabled = False
                    txtmathfrgrade8.Enabled = False
                    txtmathatgrade8.Enabled = False
                    txtmathcgrade8.Enabled = False
                    txtmathecagrade8.Enabled = False
                    txtscience1grade8.Enabled = False
                    txtscience2grade8.Enabled = False
                    txtscience3grade8.Enabled = False
                    txtscience4grade8.Enabled = False
                    txtsciencefrgrade8.Enabled = False
                    txtscienceatgrade8.Enabled = False
                    txtsciencecgrade8.Enabled = False
                    txtscienceecagrade8.Enabled = False
                    txtap1grade8.Enabled = False
                    txtap2grade8.Enabled = False
                    txtap3grade8.Enabled = False
                    txtap4grade8.Enabled = False
                    txtapfrgrade8.Enabled = False
                    txtapatgrade8.Enabled = False
                    txtapcgrade8.Enabled = False
                    txtapecagrade8.Enabled = False
                    txtesp1grade8.Enabled = False
                    txtesp2grade8.Enabled = False
                    txtesp3grade8.Enabled = False
                    txtesp4grade8.Enabled = False
                    txtespfrgrade8.Enabled = False
                    txtespatgrade8.Enabled = False
                    txtespcgrade8.Enabled = False
                    txtespecagrade8.Enabled = False
                    txttle1grade8.Enabled = False
                    txttle2grade8.Enabled = False
                    txttle3grade8.Enabled = False
                    txttle4grade8.Enabled = False
                    txttlefrgrade8.Enabled = False
                    txttleatgrade8.Enabled = False
                    txttlecgrade8.Enabled = False
                    txttleecagrade8.Enabled = False
                    txtmapeh1grade8.Enabled = False
                    txtmapeh2grade8.Enabled = False
                    txtmapeh3grade8.Enabled = False
                    txtmapeh4grade8.Enabled = False
                    txtmapehfrgrade8.Enabled = False
                    txtmapehatgrade8.Enabled = False
                    txtmapehcgrade8.Enabled = False
                    txtmapehecagrade8.Enabled = False
                    txtmusic1grade8.Enabled = False
                    txtmusic2grade8.Enabled = False
                    txtmusic3grade8.Enabled = False
                    txtmusic4grade8.Enabled = False
                    txtmusicfrgrade8.Enabled = False
                    txtmusicatgrade8.Enabled = False
                    txtmusiccgrade8.Enabled = False
                    txtmusicecagrade8.Enabled = False
                    txtarts1grade8.Enabled = False
                    txtarts2grade8.Enabled = False
                    txtarts3grade8.Enabled = False
                    txtarts4grade8.Enabled = False
                    txtartsfrgrade8.Enabled = False
                    txtartsatgrade8.Enabled = False
                    txtartscgrade8.Enabled = False
                    txtartsecagrade8.Enabled = False
                    txtpe1grade8.Enabled = False
                    txtpe2grade8.Enabled = False
                    txtpe3grade8.Enabled = False
                    txtpe4grade8.Enabled = False
                    txtpefrgrade8.Enabled = False
                    txtpeatgrade8.Enabled = False
                    txtpecgrade8.Enabled = False
                    txtpeecagrade8.Enabled = False
                    txthealth1grade8.Enabled = False
                    txthealth2grade8.Enabled = False
                    txthealth3grade8.Enabled = False
                    txthealth4grade8.Enabled = False
                    txthealthfrgrade8.Enabled = False
                    txthealthatgrade8.Enabled = False
                    txthealthcgrade8.Enabled = False
                    txthealthecagrade8.Enabled = False
                    txtaveragefrgrade8.Enabled = False
                    txtaverageatgrade8.Enabled = False
                    txtaveragecgrade8.Enabled = False
                    txtclassifiedgrade9.Enabled = False
                    cbtotalyearsgrade9.Enabled = False
                    txtyeargrade9.Enabled = False
                    txtsectiongrade9.Enabled = False
                    txtschoolgrade9.Enabled = False
                    cbschoolyeargrade9.Enabled = False
                    txtfilipino1grade9.Enabled = False
                    txtfilipino2grade9.Enabled = False
                    txtfilipino3grade9.Enabled = False
                    txtfilipino4grade9.Enabled = False
                    txtfilipinofrgrade9.Enabled = False
                    txtfilipinoatgrade9.Enabled = False
                    txtfilipinocgrade9.Enabled = False
                    txtfilipinoecagrade9.Enabled = False
                    txtenglish1grade9.Enabled = False
                    txtenglish2grade9.Enabled = False
                    txtenglish3grade9.Enabled = False
                    txtenglish4grade9.Enabled = False
                    txtenglishfrgrade9.Enabled = False
                    txtenglishatgrade9.Enabled = False
                    txtenglishcgrade9.Enabled = False
                    txtenglishecagrade9.Enabled = False
                    txtmath1grade9.Enabled = False
                    txtmath2grade9.Enabled = False
                    txtmath3grade9.Enabled = False
                    txtmath4grade9.Enabled = False
                    txtmathfrgrade9.Enabled = False
                    txtmathatgrade9.Enabled = False
                    txtmathcgrade9.Enabled = False
                    txtmathecagrade9.Enabled = False
                    txtscience1grade9.Enabled = False
                    txtscience2grade9.Enabled = False
                    txtscience3grade9.Enabled = False
                    txtscience4grade9.Enabled = False
                    txtsciencefrgrade9.Enabled = False
                    txtscienceatgrade9.Enabled = False
                    txtsciencecgrade9.Enabled = False
                    txtscienceecagrade9.Enabled = False
                    txtap1grade9.Enabled = False
                    txtap2grade9.Enabled = False
                    txtap3grade9.Enabled = False
                    txtap4grade9.Enabled = False
                    txtapfrgrade9.Enabled = False
                    txtapatgrade9.Enabled = False
                    txtapcgrade9.Enabled = False
                    txtapecagrade9.Enabled = False
                    txtesp1grade9.Enabled = False
                    txtesp2grade9.Enabled = False
                    txtesp3grade9.Enabled = False
                    txtesp4grade9.Enabled = False
                    txtespfrgrade9.Enabled = False
                    txtespatgrade9.Enabled = False
                    txtespcgrade9.Enabled = False
                    txtespecagrade9.Enabled = False
                    txttle1grade9.Enabled = False
                    txttle2grade9.Enabled = False
                    txttle3grade9.Enabled = False
                    txttle4grade9.Enabled = False
                    txttlefrgrade9.Enabled = False
                    txttleatgrade9.Enabled = False
                    txttlecgrade9.Enabled = False
                    txttleecagrade9.Enabled = False
                    txtmapeh1grade9.Enabled = False
                    txtmapeh2grade9.Enabled = False
                    txtmapeh3grade9.Enabled = False
                    txtmapeh4grade9.Enabled = False
                    txtmapehfrgrade9.Enabled = False
                    txtmapehatgrade9.Enabled = False
                    txtmapehcgrade9.Enabled = False
                    txtmapehecagrade9.Enabled = False
                    txtmusic1grade9.Enabled = False
                    txtmusic2grade9.Enabled = False
                    txtmusic3grade9.Enabled = False
                    txtmusic4grade9.Enabled = False
                    txtmusicfrgrade9.Enabled = False
                    txtmusicatgrade9.Enabled = False
                    txtmusiccgrade9.Enabled = False
                    txtmusicecagrade9.Enabled = False
                    txtarts1grade9.Enabled = False
                    txtarts2grade9.Enabled = False
                    txtarts3grade9.Enabled = False
                    txtarts4grade9.Enabled = False
                    txtartsfrgrade9.Enabled = False
                    txtartsatgrade9.Enabled = False
                    txtartscgrade9.Enabled = False
                    txtartsecagrade9.Enabled = False
                    txtpe1grade9.Enabled = False
                    txtpe2grade9.Enabled = False
                    txtpe3grade9.Enabled = False
                    txtpe4grade9.Enabled = False
                    txtpefrgrade9.Enabled = False
                    txtpeatgrade9.Enabled = False
                    txtpecgrade9.Enabled = False
                    txtpeecagrade9.Enabled = False
                    txthealth1grade9.Enabled = False
                    txthealth2grade9.Enabled = False
                    txthealth3grade9.Enabled = False
                    txthealth4grade9.Enabled = False
                    txthealthfrgrade9.Enabled = False
                    txthealthatgrade9.Enabled = False
                    txthealthcgrade9.Enabled = False
                    txthealthecagrade9.Enabled = False
                    txtaveragefrgrade9.Enabled = False
                    txtaverageatgrade9.Enabled = False
                    txtaveragecgrade9.Enabled = False
                    txtclassifiedgrade10.Enabled = False
                    cbtotalyearsgrade10.Enabled = False
                    txtyeargrade10.Enabled = False
                    txtsectiongrade10.Enabled = False
                    txtschoolgrade10.Enabled = False
                    cbschoolyeargrade10.Enabled = False
                    txtfilipino1grade10.Enabled = False
                    txtfilipino2grade10.Enabled = False
                    txtfilipino3grade10.Enabled = False
                    txtfilipino4grade10.Enabled = False
                    txtfilipinofrgrade10.Enabled = False
                    txtfilipinoatgrade10.Enabled = False
                    txtfilipinocgrade10.Enabled = False
                    txtfilipinoecagrade10.Enabled = False
                    txtenglish1grade10.Enabled = False
                    txtenglish2grade10.Enabled = False
                    txtenglish3grade10.Enabled = False
                    txtenglish4grade10.Enabled = False
                    txtenglishfrgrade10.Enabled = False
                    txtenglishatgrade10.Enabled = False
                    txtenglishcgrade10.Enabled = False
                    txtenglishecagrade10.Enabled = False
                    txtmath1grade10.Enabled = False
                    txtmath2grade10.Enabled = False
                    txtmath3grade10.Enabled = False
                    txtmath4grade10.Enabled = False
                    txtmathfrgrade10.Enabled = False
                    txtmathatgrade10.Enabled = False
                    txtmathcgrade10.Enabled = False
                    txtmathecagrade10.Enabled = False
                    txtscience1grade10.Enabled = False
                    txtscience2grade10.Enabled = False
                    txtscience3grade10.Enabled = False
                    txtscience4grade10.Enabled = False
                    txtsciencefrgrade10.Enabled = False
                    txtscienceatgrade10.Enabled = False
                    txtsciencecgrade10.Enabled = False
                    txtscienceecagrade10.Enabled = False
                    txtap1grade10.Enabled = False
                    txtap2grade10.Enabled = False
                    txtap3grade10.Enabled = False
                    txtap4grade10.Enabled = False
                    txtapfrgrade10.Enabled = False
                    txtapatgrade10.Enabled = False
                    txtapcgrade10.Enabled = False
                    txtapecagrade10.Enabled = False
                    txtesp1grade10.Enabled = False
                    txtesp2grade10.Enabled = False
                    txtesp3grade10.Enabled = False
                    txtesp4grade10.Enabled = False
                    txtespfrgrade10.Enabled = False
                    txtespatgrade10.Enabled = False
                    txtespcgrade10.Enabled = False
                    txtespecagrade10.Enabled = False
                    txttle1grade10.Enabled = False
                    txttle2grade10.Enabled = False
                    txttle3grade10.Enabled = False
                    txttle4grade10.Enabled = False
                    txttlefrgrade10.Enabled = False
                    txttleatgrade10.Enabled = False
                    txttlecgrade10.Enabled = False
                    txttleecagrade10.Enabled = False
                    txtmapeh1grade10.Enabled = False
                    txtmapeh2grade10.Enabled = False
                    txtmapeh3grade10.Enabled = False
                    txtmapeh4grade10.Enabled = False
                    txtmapehfrgrade10.Enabled = False
                    txtmapehatgrade10.Enabled = False
                    txtmapehcgrade10.Enabled = False
                    txtmapehecagrade10.Enabled = False
                    txtmusic1grade10.Enabled = False
                    txtmusic2grade10.Enabled = False
                    txtmusic3grade10.Enabled = False
                    txtmusic4grade10.Enabled = False
                    txtmusicfrgrade10.Enabled = False
                    txtmusicatgrade10.Enabled = False
                    txtmusiccgrade10.Enabled = False
                    txtmusicecagrade10.Enabled = False
                    txtarts1grade10.Enabled = False
                    txtarts2grade10.Enabled = False
                    txtarts3grade10.Enabled = False
                    txtarts4grade10.Enabled = False
                    txtartsfrgrade10.Enabled = False
                    txtartsatgrade10.Enabled = False
                    txtartscgrade10.Enabled = False
                    txtartsecagrade10.Enabled = False
                    txtpe1grade10.Enabled = False
                    txtpe2grade10.Enabled = False
                    txtpe3grade10.Enabled = False
                    txtpe4grade10.Enabled = False
                    txtpefrgrade10.Enabled = False
                    txtpeatgrade10.Enabled = False
                    txtpecgrade10.Enabled = False
                    txtpeecagrade10.Enabled = False
                    txthealth1grade10.Enabled = False
                    txthealth2grade10.Enabled = False
                    txthealth3grade10.Enabled = False
                    txthealth4grade10.Enabled = False
                    txthealthfrgrade10.Enabled = False
                    txthealthatgrade10.Enabled = False
                    txthealthcgrade10.Enabled = False
                    txthealthecagrade10.Enabled = False
                    txtaveragefrgrade10.Enabled = False
                    txtaverageatgrade10.Enabled = False
                    txtaveragecgrade10.Enabled = False
                    txtdsjungrade7.Enabled = False
                    txtdsjulgrade7.Enabled = False
                    txtdsauggrade7.Enabled = False
                    txtdssepgrade7.Enabled = False
                    txtdsoctgrade7.Enabled = False
                    txtdsnovgrade7.Enabled = False
                    txtdsdecgrade7.Enabled = False
                    txtdsjangrade7.Enabled = False
                    txtdsfebgrade7.Enabled = False
                    txtdsmargrade7.Enabled = False
                    txtdsaprgrade7.Enabled = False
                    txtdstotalgrade7.Enabled = False
                    txtdpjungrade7.Enabled = False
                    txtdpjulgrade7.Enabled = False
                    txtdpauggrade7.Enabled = False
                    txtdpsepgrade7.Enabled = False
                    txtdpoctgrade7.Enabled = False
                    txtdpnovgrade7.Enabled = False
                    txtdpdecgrade7.Enabled = False
                    txtdpjangrade7.Enabled = False
                    txtdpfebgrade7.Enabled = False
                    txtdpmargrade7.Enabled = False
                    txtdpaprgrade7.Enabled = False
                    txtdptotalgrade7.Enabled = False
                    txtadvisergrade7.Enabled = False
                    txtadvancedunitsgrade7.Enabled = False
                    txtlackunitsgrade7.Enabled = False
                    txtdsjungrade8.Enabled = False
                    txtdsjulgrade8.Enabled = False
                    txtdsauggrade8.Enabled = False
                    txtdssepgrade8.Enabled = False
                    txtdsoctgrade8.Enabled = False
                    txtdsnovgrade8.Enabled = False
                    txtdsdecgrade8.Enabled = False
                    txtdsjangrade8.Enabled = False
                    txtdsfebgrade8.Enabled = False
                    txtdsmargrade8.Enabled = False
                    txtdsaprgrade8.Enabled = False
                    txtdstotalgrade8.Enabled = False
                    txtdpjungrade8.Enabled = False
                    txtdpjulgrade8.Enabled = False
                    txtdpauggrade8.Enabled = False
                    txtdpsepgrade8.Enabled = False
                    txtdpoctgrade8.Enabled = False
                    txtdpnovgrade8.Enabled = False
                    txtdpdecgrade8.Enabled = False
                    txtdpjangrade8.Enabled = False
                    txtdpfebgrade8.Enabled = False
                    txtdpmargrade8.Enabled = False
                    txtdpaprgrade8.Enabled = False
                    txtdptotalgrade8.Enabled = False
                    txtadvisergrade8.Enabled = False
                    txtadvancedunitsgrade8.Enabled = False
                    txtlackunitsgrade8.Enabled = False
                    txtdsjungrade9.Enabled = False
                    txtdsjulgrade9.Enabled = False
                    txtdsauggrade9.Enabled = False
                    txtdssepgrade9.Enabled = False
                    txtdsoctgrade9.Enabled = False
                    txtdsnovgrade9.Enabled = False
                    txtdsdecgrade9.Enabled = False
                    txtdsjangrade9.Enabled = False
                    txtdsfebgrade9.Enabled = False
                    txtdsmargrade9.Enabled = False
                    txtdsaprgrade9.Enabled = False
                    txtdstotalgrade9.Enabled = False
                    txtdpjungrade9.Enabled = False
                    txtdpjulgrade9.Enabled = False
                    txtdpauggrade9.Enabled = False
                    txtdpsepgrade9.Enabled = False
                    txtdpoctgrade9.Enabled = False
                    txtdpnovgrade9.Enabled = False
                    txtdpdecgrade9.Enabled = False
                    txtdpjangrade9.Enabled = False
                    txtdpfebgrade9.Enabled = False
                    txtdpmargrade9.Enabled = False
                    txtdpaprgrade9.Enabled = False
                    txtdptotalgrade9.Enabled = False
                    txtadvisergrade9.Enabled = False
                    txtadvancedunitsgrade9.Enabled = False
                    txtlackunitsgrade9.Enabled = False
                    txtdsjungrade10.Enabled = False
                    txtdsjulgrade10.Enabled = False
                    txtdsauggrade10.Enabled = False
                    txtdssepgrade10.Enabled = False
                    txtdsoctgrade10.Enabled = False
                    txtdsnovgrade10.Enabled = False
                    txtdsdecgrade10.Enabled = False
                    txtdsjangrade10.Enabled = False
                    txtdsfebgrade10.Enabled = False
                    txtdsmargrade10.Enabled = False
                    txtdsaprgrade10.Enabled = False
                    txtdstotalgrade10.Enabled = False
                    txtdpjungrade10.Enabled = False
                    txtdpjulgrade10.Enabled = False
                    txtdpauggrade10.Enabled = False
                    txtdpsepgrade10.Enabled = False
                    txtdpoctgrade10.Enabled = False
                    txtdpnovgrade10.Enabled = False
                    txtdpdecgrade10.Enabled = False
                    txtdpjangrade10.Enabled = False
                    txtdpfebgrade10.Enabled = False
                    txtdpmargrade10.Enabled = False
                    txtdpaprgrade10.Enabled = False
                    txtdptotalgrade10.Enabled = False
                    txtadvisergrade10.Enabled = False
                    txtadvancedunitsgrade10.Enabled = False
                    txtlackunitsgrade10.Enabled = False
                    btndelete.Enabled = False
                    btnupdate.Enabled = False
                    btnedit.Enabled = True
                    btnsave.Enabled = False
                    btnprint.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If MessageBox.Show("Are You Sure You Want to Edit the information?", "Edit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            txtname.ForeColor = Color.Black
            txtbirthplace.ForeColor = Color.Black
            txttown.ForeColor = Color.Black
            txtbrgy.ForeColor = Color.Black
            txtparent.ForeColor = Color.Black
            txtoccupation.ForeColor = Color.Black
            txtaddress.ForeColor = Color.Black
            txtelementaryschool.ForeColor = Color.Black
            txtgenave.ForeColor = Color.Black
            txtsectiongrade7.ForeColor = Color.Black
            txtschoolgrade7.ForeColor = Color.Black
            txtsectiongrade8.ForeColor = Color.Black
            txtschoolgrade8.ForeColor = Color.Black
            txtsectiongrade9.ForeColor = Color.Black
            txtschoolgrade9.ForeColor = Color.Black
            txtsectiongrade10.ForeColor = Color.Black
            txtschoolgrade10.ForeColor = Color.Black
            txtname.Enabled = True
            txtbirthplace.Enabled = True
            txttown.Enabled = True
            txtbrgy.Enabled = True
            txtparent.Enabled = True
            txtoccupation.Enabled = True
            txtaddress.Enabled = True
            txtelementaryschool.Enabled = True
            txtgenave.Enabled = True
            dtpdateofbirth.Enabled = True
            cbgender.Enabled = True
            cbyeargrad.Enabled = True
            txtclassifiedgrade7.Enabled = True
            txtclassifiedgrade7.ReadOnly = True
            cbtotalyearsgrade7.Enabled = True
            txtyeargrade7.Enabled = True
            txtyeargrade7.ReadOnly = True
            txtsectiongrade7.Enabled = True
            txtschoolgrade7.Enabled = True
            cbschoolyeargrade7.Enabled = True
            txtfilipino1grade7.Enabled = True
            txtfilipino2grade7.Enabled = True
            txtfilipino3grade7.Enabled = True
            txtfilipino4grade7.Enabled = True
            txtfilipinofrgrade7.Enabled = True
            txtfilipinoatgrade7.Enabled = True
            txtfilipinocgrade7.Enabled = True
            txtfilipinoecagrade7.Enabled = True
            txtenglish1grade7.Enabled = True
            txtenglish2grade7.Enabled = True
            txtenglish3grade7.Enabled = True
            txtenglish4grade7.Enabled = True
            txtenglishfrgrade7.Enabled = True
            txtenglishatgrade7.Enabled = True
            txtenglishcgrade7.Enabled = True
            txtenglishecagrade7.Enabled = True
            txtmath1grade7.Enabled = True
            txtmath2grade7.Enabled = True
            txtmath3grade7.Enabled = True
            txtmath4grade7.Enabled = True
            txtmathfrgrade7.Enabled = True
            txtmathatgrade7.Enabled = True
            txtmathcgrade7.Enabled = True
            txtmathecagrade7.Enabled = True
            txtscience1grade7.Enabled = True
            txtscience2grade7.Enabled = True
            txtscience3grade7.Enabled = True
            txtscience4grade7.Enabled = True
            txtsciencefrgrade7.Enabled = True
            txtscienceatgrade7.Enabled = True
            txtsciencecgrade7.Enabled = True
            txtscienceecagrade7.Enabled = True
            txtap1grade7.Enabled = True
            txtap2grade7.Enabled = True
            txtap3grade7.Enabled = True
            txtap4grade7.Enabled = True
            txtapfrgrade7.Enabled = True
            txtapatgrade7.Enabled = True
            txtapcgrade7.Enabled = True
            txtapecagrade7.Enabled = True
            txtesp1grade7.Enabled = True
            txtesp2grade7.Enabled = True
            txtesp3grade7.Enabled = True
            txtesp4grade7.Enabled = True
            txtespfrgrade7.Enabled = True
            txtespatgrade7.Enabled = True
            txtespcgrade7.Enabled = True
            txtespecagrade7.Enabled = True
            txttle1grade7.Enabled = True
            txttle2grade7.Enabled = True
            txttle3grade7.Enabled = True
            txttle4grade7.Enabled = True
            txttlefrgrade7.Enabled = True
            txttleatgrade7.Enabled = True
            txttlecgrade7.Enabled = True
            txttleecagrade7.Enabled = True
            txtmapeh1grade7.Enabled = True
            txtmapeh2grade7.Enabled = True
            txtmapeh3grade7.Enabled = True
            txtmapeh4grade7.Enabled = True
            txtmapehfrgrade7.Enabled = True
            txtmapehatgrade7.Enabled = True
            txtmapehcgrade7.Enabled = True
            txtmapehecagrade7.Enabled = True
            txtmusic1grade7.Enabled = True
            txtmusic2grade7.Enabled = True
            txtmusic3grade7.Enabled = True
            txtmusic4grade7.Enabled = True
            txtmusicfrgrade7.Enabled = True
            txtmusicatgrade7.Enabled = True
            txtmusiccgrade7.Enabled = True
            txtmusicecagrade7.Enabled = True
            txtarts1grade7.Enabled = True
            txtarts2grade7.Enabled = True
            txtarts3grade7.Enabled = True
            txtarts4grade7.Enabled = True
            txtartsfrgrade7.Enabled = True
            txtartsatgrade7.Enabled = True
            txtartscgrade7.Enabled = True
            txtartsecagrade7.Enabled = True
            txtpe1grade7.Enabled = True
            txtpe2grade7.Enabled = True
            txtpe3grade7.Enabled = True
            txtpe4grade7.Enabled = True
            txtpefrgrade7.Enabled = True
            txtpeatgrade7.Enabled = True
            txtpecgrade7.Enabled = True
            txtpeecagrade7.Enabled = True
            txthealth1grade7.Enabled = True
            txthealth2grade7.Enabled = True
            txthealth3grade7.Enabled = True
            txthealth4grade7.Enabled = True
            txthealthfrgrade7.Enabled = True
            txthealthatgrade7.Enabled = True
            txthealthcgrade7.Enabled = True
            txthealthecagrade7.Enabled = True
            txtaveragefrgrade7.Enabled = True
            txtaverageatgrade7.Enabled = True
            txtaveragecgrade7.Enabled = True
            txtfilipinofrgrade7.ReadOnly = True
            txtfilipinoatgrade7.ReadOnly = True
            txtenglishfrgrade7.ReadOnly = True
            txtenglishatgrade7.ReadOnly = True
            txtmathfrgrade7.ReadOnly = True
            txtmathatgrade7.ReadOnly = True
            txtsciencefrgrade7.ReadOnly = True
            txtscienceatgrade7.ReadOnly = True
            txtapfrgrade7.ReadOnly = True
            txtapatgrade7.ReadOnly = True
            txtespfrgrade7.ReadOnly = True
            txtespatgrade7.ReadOnly = True
            txttlefrgrade7.ReadOnly = True
            txttleatgrade7.ReadOnly = True
            txtmapeh1grade7.ReadOnly = True
            txtmapeh2grade7.ReadOnly = True
            txtmapeh3grade7.ReadOnly = True
            txtmapeh4grade7.ReadOnly = True
            txtmapehfrgrade7.ReadOnly = True
            txtmapehatgrade7.ReadOnly = True
            txtmusicfrgrade7.ReadOnly = True
            txtmusicatgrade7.ReadOnly = True
            txtartsfrgrade7.ReadOnly = True
            txtartsatgrade7.ReadOnly = True
            txtpefrgrade7.ReadOnly = True
            txtpeatgrade7.ReadOnly = True
            txthealthfrgrade7.ReadOnly = True
            txthealthatgrade7.ReadOnly = True
            txtaveragefrgrade7.ReadOnly = True
            txtaverageatgrade7.ReadOnly = True
            txtclassifiedgrade8.ReadOnly = True
            cbtotalyearsgrade8.Enabled = True
            txtyeargrade8.ReadOnly = True
            txtsectiongrade8.Enabled = True
            txtschoolgrade8.Enabled = True
            cbschoolyeargrade8.Enabled = True
            txtfilipino1grade8.Enabled = True
            txtfilipino2grade8.Enabled = True
            txtfilipino3grade8.Enabled = True
            txtfilipino4grade8.Enabled = True
            txtfilipinofrgrade8.Enabled = True
            txtfilipinoatgrade8.Enabled = True
            txtfilipinocgrade8.Enabled = True
            txtfilipinoecagrade8.Enabled = True
            txtenglish1grade8.Enabled = True
            txtenglish2grade8.Enabled = True
            txtenglish3grade8.Enabled = True
            txtenglish4grade8.Enabled = True
            txtenglishfrgrade8.Enabled = True
            txtenglishatgrade8.Enabled = True
            txtenglishcgrade8.Enabled = True
            txtenglishecagrade8.Enabled = True
            txtmath1grade8.Enabled = True
            txtmath2grade8.Enabled = True
            txtmath3grade8.Enabled = True
            txtmath4grade8.Enabled = True
            txtmathfrgrade8.Enabled = True
            txtmathatgrade8.Enabled = True
            txtmathcgrade8.Enabled = True
            txtmathecagrade8.Enabled = True
            txtscience1grade8.Enabled = True
            txtscience2grade8.Enabled = True
            txtscience3grade8.Enabled = True
            txtscience4grade8.Enabled = True
            txtsciencefrgrade8.Enabled = True
            txtscienceatgrade8.Enabled = True
            txtsciencecgrade8.Enabled = True
            txtscienceecagrade8.Enabled = True
            txtap1grade8.Enabled = True
            txtap2grade8.Enabled = True
            txtap3grade8.Enabled = True
            txtap4grade8.Enabled = True
            txtapfrgrade8.Enabled = True
            txtapatgrade8.Enabled = True
            txtapcgrade8.Enabled = True
            txtapecagrade8.Enabled = True
            txtesp1grade8.Enabled = True
            txtesp2grade8.Enabled = True
            txtesp3grade8.Enabled = True
            txtesp4grade8.Enabled = True
            txtespfrgrade8.Enabled = True
            txtespatgrade8.Enabled = True
            txtespcgrade8.Enabled = True
            txtespecagrade8.Enabled = True
            txttle1grade8.Enabled = True
            txttle2grade8.Enabled = True
            txttle3grade8.Enabled = True
            txttle4grade8.Enabled = True
            txttlefrgrade8.Enabled = True
            txttleatgrade8.Enabled = True
            txttlecgrade8.Enabled = True
            txttleecagrade8.Enabled = True
            txtmapeh1grade8.Enabled = True
            txtmapeh2grade8.Enabled = True
            txtmapeh3grade8.Enabled = True
            txtmapeh4grade8.Enabled = True
            txtmapehfrgrade8.Enabled = True
            txtmapehatgrade8.Enabled = True
            txtmapehcgrade8.Enabled = True
            txtmapehecagrade8.Enabled = True
            txtmusic1grade8.Enabled = True
            txtmusic2grade8.Enabled = True
            txtmusic3grade8.Enabled = True
            txtmusic4grade8.Enabled = True
            txtmusicfrgrade8.Enabled = True
            txtmusicatgrade8.Enabled = True
            txtmusiccgrade8.Enabled = True
            txtmusicecagrade8.Enabled = True
            txtarts1grade8.Enabled = True
            txtarts2grade8.Enabled = True
            txtarts3grade8.Enabled = True
            txtarts4grade8.Enabled = True
            txtartsfrgrade8.Enabled = True
            txtartsatgrade8.Enabled = True
            txtartscgrade8.Enabled = True
            txtartsecagrade8.Enabled = True
            txtpe1grade8.Enabled = True
            txtpe2grade8.Enabled = True
            txtpe3grade8.Enabled = True
            txtpe4grade8.Enabled = True
            txtpefrgrade8.Enabled = True
            txtpeatgrade8.Enabled = True
            txtpecgrade8.Enabled = True
            txtpeecagrade8.Enabled = True
            txthealth1grade8.Enabled = True
            txthealth2grade8.Enabled = True
            txthealth3grade8.Enabled = True
            txthealth4grade8.Enabled = True
            txthealthfrgrade8.Enabled = True
            txthealthatgrade8.Enabled = True
            txthealthcgrade8.Enabled = True
            txthealthecagrade8.Enabled = True
            txtaveragefrgrade8.Enabled = True
            txtaverageatgrade8.Enabled = True
            txtaveragecgrade8.Enabled = True
            txtclassifiedgrade8.ReadOnly = True
            txtyeargrade8.ReadOnly = True
            txtfilipinofrgrade8.ReadOnly = True
            txtfilipinoatgrade8.ReadOnly = True
            txtenglishfrgrade8.ReadOnly = True
            txtenglishatgrade8.ReadOnly = True
            txtmathfrgrade8.ReadOnly = True
            txtmathatgrade8.ReadOnly = True
            txtsciencefrgrade8.ReadOnly = True
            txtscienceatgrade8.ReadOnly = True
            txtapfrgrade8.ReadOnly = True
            txtapatgrade8.ReadOnly = True
            txtespfrgrade8.ReadOnly = True
            txtespatgrade8.ReadOnly = True
            txttlefrgrade8.ReadOnly = True
            txttleatgrade8.ReadOnly = True
            txtmapeh1grade8.ReadOnly = True
            txtmapeh2grade8.ReadOnly = True
            txtmapeh3grade8.ReadOnly = True
            txtmapeh4grade8.ReadOnly = True
            txtmapehfrgrade8.ReadOnly = True
            txtmapehatgrade8.ReadOnly = True
            txtmusicfrgrade8.ReadOnly = True
            txtmusicatgrade8.ReadOnly = True
            txtartsfrgrade8.ReadOnly = True
            txtartsatgrade8.ReadOnly = True
            txtpefrgrade8.ReadOnly = True
            txtpeatgrade8.ReadOnly = True
            txthealthfrgrade8.ReadOnly = True
            txthealthatgrade8.ReadOnly = True
            txtaveragefrgrade8.ReadOnly = True
            txtaverageatgrade8.ReadOnly = True
            txtclassifiedgrade9.ReadOnly = True
            cbtotalyearsgrade9.Enabled = True
            txtyeargrade9.ReadOnly = True
            txtsectiongrade9.Enabled = True
            txtschoolgrade9.Enabled = True
            cbschoolyeargrade9.Enabled = True
            txtfilipino1grade9.Enabled = True
            txtfilipino2grade9.Enabled = True
            txtfilipino3grade9.Enabled = True
            txtfilipino4grade9.Enabled = True
            txtfilipinofrgrade9.Enabled = True
            txtfilipinoatgrade9.Enabled = True
            txtfilipinocgrade9.Enabled = True
            txtfilipinoecagrade9.Enabled = True
            txtenglish1grade9.Enabled = True
            txtenglish2grade9.Enabled = True
            txtenglish3grade9.Enabled = True
            txtenglish4grade9.Enabled = True
            txtenglishfrgrade9.Enabled = True
            txtenglishatgrade9.Enabled = True
            txtenglishcgrade9.Enabled = True
            txtenglishecagrade9.Enabled = True
            txtmath1grade9.Enabled = True
            txtmath2grade9.Enabled = True
            txtmath3grade9.Enabled = True
            txtmath4grade9.Enabled = True
            txtmathfrgrade9.Enabled = True
            txtmathatgrade9.Enabled = True
            txtmathcgrade9.Enabled = True
            txtmathecagrade9.Enabled = True
            txtscience1grade9.Enabled = True
            txtscience2grade9.Enabled = True
            txtscience3grade9.Enabled = True
            txtscience4grade9.Enabled = True
            txtsciencefrgrade9.Enabled = True
            txtscienceatgrade9.Enabled = True
            txtsciencecgrade9.Enabled = True
            txtscienceecagrade9.Enabled = True
            txtap1grade9.Enabled = True
            txtap2grade9.Enabled = True
            txtap3grade9.Enabled = True
            txtap4grade9.Enabled = True
            txtapfrgrade9.Enabled = True
            txtapatgrade9.Enabled = True
            txtapcgrade9.Enabled = True
            txtapecagrade9.Enabled = True
            txtesp1grade9.Enabled = True
            txtesp2grade9.Enabled = True
            txtesp3grade9.Enabled = True
            txtesp4grade9.Enabled = True
            txtespfrgrade9.Enabled = True
            txtespatgrade9.Enabled = True
            txtespcgrade9.Enabled = True
            txtespecagrade9.Enabled = True
            txttle1grade9.Enabled = True
            txttle2grade9.Enabled = True
            txttle3grade9.Enabled = True
            txttle4grade9.Enabled = True
            txttlefrgrade9.Enabled = True
            txttleatgrade9.Enabled = True
            txttlecgrade9.Enabled = True
            txttleecagrade9.Enabled = True
            txtmapeh1grade9.Enabled = True
            txtmapeh2grade9.Enabled = True
            txtmapeh3grade9.Enabled = True
            txtmapeh4grade9.Enabled = True
            txtmapehfrgrade9.Enabled = True
            txtmapehatgrade9.Enabled = True
            txtmapehcgrade9.Enabled = True
            txtmapehecagrade9.Enabled = True
            txtmusic1grade9.Enabled = True
            txtmusic2grade9.Enabled = True
            txtmusic3grade9.Enabled = True
            txtmusic4grade9.Enabled = True
            txtmusicfrgrade9.Enabled = True
            txtmusicatgrade9.Enabled = True
            txtmusiccgrade9.Enabled = True
            txtmusicecagrade9.Enabled = True
            txtarts1grade9.Enabled = True
            txtarts2grade9.Enabled = True
            txtarts3grade9.Enabled = True
            txtarts4grade9.Enabled = True
            txtartsfrgrade9.Enabled = True
            txtartsatgrade9.Enabled = True
            txtartscgrade9.Enabled = True
            txtartsecagrade9.Enabled = True
            txtpe1grade9.Enabled = True
            txtpe2grade9.Enabled = True
            txtpe3grade9.Enabled = True
            txtpe4grade9.Enabled = True
            txtpefrgrade9.Enabled = True
            txtpeatgrade9.Enabled = True
            txtpecgrade9.Enabled = True
            txtpeecagrade9.Enabled = True
            txthealth1grade9.Enabled = True
            txthealth2grade9.Enabled = True
            txthealth3grade9.Enabled = True
            txthealth4grade9.Enabled = True
            txthealthfrgrade9.Enabled = True
            txthealthatgrade9.Enabled = True
            txthealthcgrade9.Enabled = True
            txthealthecagrade9.Enabled = True
            txtaveragefrgrade9.Enabled = True
            txtaverageatgrade9.Enabled = True
            txtaveragecgrade9.Enabled = True
            txtclassifiedgrade9.ReadOnly = True
            txtyeargrade9.ReadOnly = True
            txtfilipinofrgrade9.ReadOnly = True
            txtfilipinoatgrade9.ReadOnly = True
            txtenglishfrgrade9.ReadOnly = True
            txtenglishatgrade9.ReadOnly = True
            txtmathfrgrade9.ReadOnly = True
            txtmathatgrade9.ReadOnly = True
            txtsciencefrgrade9.ReadOnly = True
            txtscienceatgrade9.ReadOnly = True
            txtapfrgrade9.ReadOnly = True
            txtapatgrade9.ReadOnly = True
            txtespfrgrade9.ReadOnly = True
            txtespatgrade9.ReadOnly = True
            txttlefrgrade9.ReadOnly = True
            txttleatgrade9.ReadOnly = True
            txtmapeh1grade9.ReadOnly = True
            txtmapeh2grade9.ReadOnly = True
            txtmapeh3grade9.ReadOnly = True
            txtmapeh4grade9.ReadOnly = True
            txtmapehfrgrade9.ReadOnly = True
            txtmapehatgrade9.ReadOnly = True
            txtmusicfrgrade9.ReadOnly = True
            txtmusicatgrade9.ReadOnly = True
            txtartsfrgrade9.ReadOnly = True
            txtartsatgrade9.ReadOnly = True
            txtpefrgrade9.ReadOnly = True
            txtpeatgrade9.ReadOnly = True
            txthealthfrgrade9.ReadOnly = True
            txthealthatgrade9.ReadOnly = True
            txtaveragefrgrade9.ReadOnly = True
            txtaverageatgrade9.ReadOnly = True
            txtclassifiedgrade10.ReadOnly = True
            cbtotalyearsgrade10.Enabled = True
            txtyeargrade10.ReadOnly = True
            txtsectiongrade10.Enabled = True
            txtschoolgrade10.Enabled = True
            cbschoolyeargrade10.Enabled = True
            txtfilipino1grade10.Enabled = True
            txtfilipino2grade10.Enabled = True
            txtfilipino3grade10.Enabled = True
            txtfilipino4grade10.Enabled = True
            txtfilipinofrgrade10.Enabled = True
            txtfilipinoatgrade10.Enabled = True
            txtfilipinocgrade10.Enabled = True
            txtfilipinoecagrade10.Enabled = True
            txtenglish1grade10.Enabled = True
            txtenglish2grade10.Enabled = True
            txtenglish3grade10.Enabled = True
            txtenglish4grade10.Enabled = True
            txtenglishfrgrade10.Enabled = True
            txtenglishatgrade10.Enabled = True
            txtenglishcgrade10.Enabled = True
            txtenglishecagrade10.Enabled = True
            txtmath1grade10.Enabled = True
            txtmath2grade10.Enabled = True
            txtmath3grade10.Enabled = True
            txtmath4grade10.Enabled = True
            txtmathfrgrade10.Enabled = True
            txtmathatgrade10.Enabled = True
            txtmathcgrade10.Enabled = True
            txtmathecagrade10.Enabled = True
            txtscience1grade10.Enabled = True
            txtscience2grade10.Enabled = True
            txtscience3grade10.Enabled = True
            txtscience4grade10.Enabled = True
            txtsciencefrgrade10.Enabled = True
            txtscienceatgrade10.Enabled = True
            txtsciencecgrade10.Enabled = True
            txtscienceecagrade10.Enabled = True
            txtap1grade10.Enabled = True
            txtap2grade10.Enabled = True
            txtap3grade10.Enabled = True
            txtap4grade10.Enabled = True
            txtapfrgrade10.Enabled = True
            txtapatgrade10.Enabled = True
            txtapcgrade10.Enabled = True
            txtapecagrade10.Enabled = True
            txtesp1grade10.Enabled = True
            txtesp2grade10.Enabled = True
            txtesp3grade10.Enabled = True
            txtesp4grade10.Enabled = True
            txtespfrgrade10.Enabled = True
            txtespatgrade10.Enabled = True
            txtespcgrade10.Enabled = True
            txtespecagrade10.Enabled = True
            txttle1grade10.Enabled = True
            txttle2grade10.Enabled = True
            txttle3grade10.Enabled = True
            txttle4grade10.Enabled = True
            txttlefrgrade10.Enabled = True
            txttleatgrade10.Enabled = True
            txttlecgrade10.Enabled = True
            txttleecagrade10.Enabled = True
            txtmapeh1grade10.Enabled = True
            txtmapeh2grade10.Enabled = True
            txtmapeh3grade10.Enabled = True
            txtmapeh4grade10.Enabled = True
            txtmapehfrgrade10.Enabled = True
            txtmapehatgrade10.Enabled = True
            txtmapehcgrade10.Enabled = True
            txtmapehecagrade10.Enabled = True
            txtmusic1grade10.Enabled = True
            txtmusic2grade10.Enabled = True
            txtmusic3grade10.Enabled = True
            txtmusic4grade10.Enabled = True
            txtmusicfrgrade10.Enabled = True
            txtmusicatgrade10.Enabled = True
            txtmusiccgrade10.Enabled = True
            txtmusicecagrade10.Enabled = True
            txtarts1grade10.Enabled = True
            txtarts2grade10.Enabled = True
            txtarts3grade10.Enabled = True
            txtarts4grade10.Enabled = True
            txtartsfrgrade10.Enabled = True
            txtartsatgrade10.Enabled = True
            txtartscgrade10.Enabled = True
            txtartsecagrade10.Enabled = True
            txtpe1grade10.Enabled = True
            txtpe2grade10.Enabled = True
            txtpe3grade10.Enabled = True
            txtpe4grade10.Enabled = True
            txtpefrgrade10.Enabled = True
            txtpeatgrade10.Enabled = True
            txtpecgrade10.Enabled = True
            txtpeecagrade10.Enabled = True
            txthealth1grade10.Enabled = True
            txthealth2grade10.Enabled = True
            txthealth3grade10.Enabled = True
            txthealth4grade10.Enabled = True
            txthealthfrgrade10.Enabled = True
            txthealthatgrade10.Enabled = True
            txthealthcgrade10.Enabled = True
            txthealthecagrade10.Enabled = True
            txtaveragefrgrade10.Enabled = True
            txtaverageatgrade10.Enabled = True
            txtaveragecgrade10.Enabled = True
            txtclassifiedgrade10.ReadOnly = True
            txtyeargrade10.ReadOnly = True
            txtfilipinofrgrade10.ReadOnly = True
            txtfilipinoatgrade10.ReadOnly = True
            txtenglishfrgrade10.ReadOnly = True
            txtenglishatgrade10.ReadOnly = True
            txtmathfrgrade10.ReadOnly = True
            txtmathatgrade10.ReadOnly = True
            txtsciencefrgrade10.ReadOnly = True
            txtscienceatgrade10.ReadOnly = True
            txtapfrgrade10.ReadOnly = True
            txtapatgrade10.ReadOnly = True
            txtespfrgrade10.ReadOnly = True
            txtespatgrade10.ReadOnly = True
            txttlefrgrade10.ReadOnly = True
            txttleatgrade10.ReadOnly = True
            txtmapeh1grade10.ReadOnly = True
            txtmapeh2grade10.ReadOnly = True
            txtmapeh3grade10.ReadOnly = True
            txtmapeh4grade10.ReadOnly = True
            txtmapehfrgrade10.ReadOnly = True
            txtmapehatgrade10.ReadOnly = True
            txtmusicfrgrade10.ReadOnly = True
            txtmusicatgrade10.ReadOnly = True
            txtartsfrgrade10.ReadOnly = True
            txtartsatgrade10.ReadOnly = True
            txtpefrgrade10.ReadOnly = True
            txtpeatgrade10.ReadOnly = True
            txthealthfrgrade10.ReadOnly = True
            txthealthatgrade10.ReadOnly = True
            txtaveragefrgrade10.ReadOnly = True
            txtaverageatgrade10.ReadOnly = True
            txtdsjungrade7.Enabled = True
            txtdsjulgrade7.Enabled = True
            txtdsauggrade7.Enabled = True
            txtdssepgrade7.Enabled = True
            txtdsoctgrade7.Enabled = True
            txtdsnovgrade7.Enabled = True
            txtdsdecgrade7.Enabled = True
            txtdsjangrade7.Enabled = True
            txtdsfebgrade7.Enabled = True
            txtdsmargrade7.Enabled = True
            txtdsaprgrade7.Enabled = True
            txtdstotalgrade7.Enabled = True
            txtdpjungrade7.Enabled = True
            txtdpjulgrade7.Enabled = True
            txtdpauggrade7.Enabled = True
            txtdpsepgrade7.Enabled = True
            txtdpoctgrade7.Enabled = True
            txtdpnovgrade7.Enabled = True
            txtdpdecgrade7.Enabled = True
            txtdpjangrade7.Enabled = True
            txtdpfebgrade7.Enabled = True
            txtdpmargrade7.Enabled = True
            txtdpaprgrade7.Enabled = True
            txtdptotalgrade7.Enabled = True
            txtadvisergrade7.Enabled = True
            txtadvancedunitsgrade7.Enabled = True
            txtlackunitsgrade7.Enabled = True
            txtdsjungrade8.Enabled = True
            txtdsjulgrade8.Enabled = True
            txtdsauggrade8.Enabled = True
            txtdssepgrade8.Enabled = True
            txtdsoctgrade8.Enabled = True
            txtdsnovgrade8.Enabled = True
            txtdsdecgrade8.Enabled = True
            txtdsjangrade8.Enabled = True
            txtdsfebgrade8.Enabled = True
            txtdsmargrade8.Enabled = True
            txtdsaprgrade8.Enabled = True
            txtdstotalgrade8.Enabled = True
            txtdpjungrade8.Enabled = True
            txtdpjulgrade8.Enabled = True
            txtdpauggrade8.Enabled = True
            txtdpsepgrade8.Enabled = True
            txtdpoctgrade8.Enabled = True
            txtdpnovgrade8.Enabled = True
            txtdpdecgrade8.Enabled = True
            txtdpjangrade8.Enabled = True
            txtdpfebgrade8.Enabled = True
            txtdpmargrade8.Enabled = True
            txtdpaprgrade8.Enabled = True
            txtdptotalgrade8.Enabled = True
            txtadvisergrade8.Enabled = True
            txtadvancedunitsgrade8.Enabled = True
            txtlackunitsgrade8.Enabled = True
            txtdsjungrade9.Enabled = True
            txtdsjulgrade9.Enabled = True
            txtdsauggrade9.Enabled = True
            txtdssepgrade9.Enabled = True
            txtdsoctgrade9.Enabled = True
            txtdsnovgrade9.Enabled = True
            txtdsdecgrade9.Enabled = True
            txtdsjangrade9.Enabled = True
            txtdsfebgrade9.Enabled = True
            txtdsmargrade9.Enabled = True
            txtdsaprgrade9.Enabled = True
            txtdstotalgrade9.Enabled = True
            txtdpjungrade9.Enabled = True
            txtdpjulgrade9.Enabled = True
            txtdpauggrade9.Enabled = True
            txtdpsepgrade9.Enabled = True
            txtdpoctgrade9.Enabled = True
            txtdpnovgrade9.Enabled = True
            txtdpdecgrade9.Enabled = True
            txtdpjangrade9.Enabled = True
            txtdpfebgrade9.Enabled = True
            txtdpmargrade9.Enabled = True
            txtdpaprgrade9.Enabled = True
            txtdptotalgrade9.Enabled = True
            txtadvisergrade9.Enabled = True
            txtadvancedunitsgrade9.Enabled = True
            txtlackunitsgrade9.Enabled = True
            txtdsjungrade10.Enabled = True
            txtdsjulgrade10.Enabled = True
            txtdsauggrade10.Enabled = True
            txtdssepgrade10.Enabled = True
            txtdsoctgrade10.Enabled = True
            txtdsnovgrade10.Enabled = True
            txtdsdecgrade10.Enabled = True
            txtdsjangrade10.Enabled = True
            txtdsfebgrade10.Enabled = True
            txtdsmargrade10.Enabled = True
            txtdsaprgrade10.Enabled = True
            txtdstotalgrade10.Enabled = True
            txtdpjungrade10.Enabled = True
            txtdpjulgrade10.Enabled = True
            txtdpauggrade10.Enabled = True
            txtdpsepgrade10.Enabled = True
            txtdpoctgrade10.Enabled = True
            txtdpnovgrade10.Enabled = True
            txtdpdecgrade10.Enabled = True
            txtdpjangrade10.Enabled = True
            txtdpfebgrade10.Enabled = True
            txtdpmargrade10.Enabled = True
            txtdpaprgrade10.Enabled = True
            txtdptotalgrade10.Enabled = True
            txtadvisergrade10.Enabled = True
            txtadvancedunitsgrade10.Enabled = True
            txtlackunitsgrade10.Enabled = True
            txtdstotalgrade7.ReadOnly = True
            txtdptotalgrade7.ReadOnly = True
            txtdstotalgrade8.ReadOnly = True
            txtdptotalgrade8.ReadOnly = True
            txtdstotalgrade9.ReadOnly = True
            txtdptotalgrade9.ReadOnly = True
            txtdstotalgrade10.ReadOnly = True
            txtdptotalgrade10.ReadOnly = True
            btndelete.Enabled = False
            btnupdate.Enabled = True
            btnedit.Enabled = False
            btnsave.Enabled = False
            btnprint.Enabled = False
            txtlrn.Enabled = False
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim deleteQuery1, deleteQuery2, deleteQuery3, deleteQuery4, deleteQuery5, deleteQuery6, deleteQuery7, deleteQuery8, deleteQuery9 As String
        If MessageBox.Show("Are you sure you want to delete the record?", "Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            deleteQuery1 = "Delete from studinfoTbl where lrn='" & txtlrn.Text & "'"
            deleteQuery2 = "Delete from studrecordgrade7Tbl where lrn='" & txtlrn.Text & "'"
            deleteQuery3 = "Delete from studrecordgrade8Tbl where lrn='" & txtlrn.Text & "'"
            deleteQuery4 = "Delete from studrecordgrade9Tbl where lrn='" & txtlrn.Text & "'"
            deleteQuery5 = "Delete from studrecordgrade10Tbl where lrn='" & txtlrn.Text & "'"
            deleteQuery6 = "Delete from studattendancegrade7Tbl where lrn='" & txtlrn.Text & "'"
            deleteQuery7 = "Delete from studattendancegrade8Tbl where lrn='" & txtlrn.Text & "'"
            deleteQuery8 = "Delete from studattendancegrade9Tbl where lrn='" & txtlrn.Text & "'"
            deleteQuery9 = "Delete from studattendancegrade10Tbl where lrn='" & txtlrn.Text & "'"
            ExecuteQuery(deleteQuery1)
            ExecuteQuery(deleteQuery2)
            ExecuteQuery(deleteQuery3)
            ExecuteQuery(deleteQuery4)
            ExecuteQuery(deleteQuery5)
            ExecuteQuery(deleteQuery6)
            ExecuteQuery(deleteQuery7)
            ExecuteQuery(deleteQuery8)
            ExecuteQuery(deleteQuery9)
            MessageBox.Show("Record Deleted Successfully!")
            txtlrn.ForeColor = Color.Gray
            txtname.ForeColor = Color.Gray
            txtbirthplace.ForeColor = Color.Gray
            txttown.ForeColor = Color.Gray
            txtbrgy.ForeColor = Color.Gray
            txtparent.ForeColor = Color.Gray
            txtoccupation.ForeColor = Color.Gray
            txtaddress.ForeColor = Color.Gray
            txtelementaryschool.ForeColor = Color.Gray
            txtgenave.ForeColor = Color.Gray
            txtsectiongrade7.ForeColor = Color.Gray
            txtschoolgrade7.ForeColor = Color.Gray
            txtsectiongrade8.ForeColor = Color.Gray
            txtschoolgrade8.ForeColor = Color.Gray
            txtsectiongrade9.ForeColor = Color.Gray
            txtschoolgrade9.ForeColor = Color.Gray
            txtsectiongrade10.ForeColor = Color.Gray
            txtschoolgrade10.ForeColor = Color.Gray
            txtlrn.Text = "Student LRN..."
            txtname.Text = "Type the Full Name of the Student..."
            txtbirthplace.Text = "Type the Birthplace/Province..."
            txttown.Text = "Type the Town/City..."
            txtbrgy.Text = "Type the Barangay..."
            txtparent.Text = "Parent/Guardian's Fullname..."
            txtoccupation.Text = "Occupation of the Parent/Guardian..."
            txtaddress.Text = "Address of the Parent/Guardian..."
            txtelementaryschool.Text = "Elementary School Graduated..."
            txtgenave.Text = "Ave. Grade..."
            dtpdateofbirth.Text = Nothing
            cbgender.Text = Nothing
            cbyeargrad.Text = Nothing
            txtclassifiedgrade7.Text = "GRADE 7"
            cbtotalyearsgrade7.Text = Nothing
            txtyeargrade7.Text = "7"
            txtsectiongrade7.Text = "Section..."
            txtschoolgrade7.Text = "School..."
            cbschoolyeargrade7.Text = Nothing
            txtfilipino1grade7.Text = ""
            txtfilipino2grade7.Text = ""
            txtfilipino3grade7.Text = ""
            txtfilipino4grade7.Text = ""
            txtfilipinofrgrade7.Text = "0"
            txtfilipinoatgrade7.Text = ""
            txtfilipinocgrade7.Text = ""
            txtfilipinoecagrade7.Text = ""
            txtenglish1grade7.Text = ""
            txtenglish2grade7.Text = ""
            txtenglish3grade7.Text = ""
            txtenglish4grade7.Text = ""
            txtenglishfrgrade7.Text = "0"
            txtenglishatgrade7.Text = ""
            txtenglishcgrade7.Text = ""
            txtenglishecagrade7.Text = ""
            txtmath1grade7.Text = ""
            txtmath2grade7.Text = ""
            txtmath3grade7.Text = ""
            txtmath4grade7.Text = ""
            txtmathfrgrade7.Text = "0"
            txtmathatgrade7.Text = ""
            txtmathcgrade7.Text = ""
            txtmathecagrade7.Text = ""
            txtscience1grade7.Text = ""
            txtscience2grade7.Text = ""
            txtscience3grade7.Text = ""
            txtscience4grade7.Text = ""
            txtsciencefrgrade7.Text = "0"
            txtscienceatgrade7.Text = ""
            txtsciencecgrade7.Text = ""
            txtscienceecagrade7.Text = ""
            txtap1grade7.Text = ""
            txtap2grade7.Text = ""
            txtap3grade7.Text = ""
            txtap4grade7.Text = ""
            txtapfrgrade7.Text = "0"
            txtapatgrade7.Text = ""
            txtapcgrade7.Text = ""
            txtapecagrade7.Text = ""
            txtesp1grade7.Text = ""
            txtesp2grade7.Text = ""
            txtesp3grade7.Text = ""
            txtesp4grade7.Text = ""
            txtespfrgrade7.Text = "0"
            txtespatgrade7.Text = ""
            txtespcgrade7.Text = ""
            txtespecagrade7.Text = ""
            txttle1grade7.Text = ""
            txttle2grade7.Text = ""
            txttle3grade7.Text = ""
            txttle4grade7.Text = ""
            txttlefrgrade7.Text = "0"
            txttleatgrade7.Text = ""
            txttlecgrade7.Text = ""
            txttleecagrade7.Text = ""
            txtmapeh1grade7.Text = ""
            txtmapeh2grade7.Text = ""
            txtmapeh3grade7.Text = ""
            txtmapeh4grade7.Text = ""
            txtmapehfrgrade7.Text = "0"
            txtmapehatgrade7.Text = ""
            txtmapehcgrade7.Text = ""
            txtmapehecagrade7.Text = ""
            txtmusic1grade7.Text = ""
            txtmusic2grade7.Text = ""
            txtmusic3grade7.Text = ""
            txtmusic4grade7.Text = ""
            txtmusicfrgrade7.Text = "0"
            txtmusicatgrade7.Text = ""
            txtmusiccgrade7.Text = ""
            txtmusicecagrade7.Text = ""
            txtarts1grade7.Text = ""
            txtarts2grade7.Text = ""
            txtarts3grade7.Text = ""
            txtarts4grade7.Text = ""
            txtartsfrgrade7.Text = "0"
            txtartsatgrade7.Text = ""
            txtartscgrade7.Text = ""
            txtartsecagrade7.Text = ""
            txtpe1grade7.Text = ""
            txtpe2grade7.Text = ""
            txtpe3grade7.Text = ""
            txtpe4grade7.Text = ""
            txtpefrgrade7.Text = "0"
            txtpeatgrade7.Text = ""
            txtpecgrade7.Text = ""
            txtpeecagrade7.Text = ""
            txthealth1grade7.Text = ""
            txthealth2grade7.Text = ""
            txthealth3grade7.Text = ""
            txthealth4grade7.Text = ""
            txthealthfrgrade7.Text = "0"
            txthealthatgrade7.Text = ""
            txthealthcgrade7.Text = ""
            txthealthecagrade7.Text = ""
            txtaveragefrgrade7.Text = "0"
            txtaverageatgrade7.Text = ""
            txtaveragecgrade7.Text = ""
            txtclassifiedgrade8.Text = "GRADE 8"
            cbtotalyearsgrade8.Text = Nothing
            txtyeargrade8.Text = "8"
            txtsectiongrade8.Text = "Section..."
            txtschoolgrade8.Text = "School..."
            cbschoolyeargrade8.Text = Nothing
            txtfilipino1grade8.Text = ""
            txtfilipino2grade8.Text = ""
            txtfilipino3grade8.Text = ""
            txtfilipino4grade8.Text = ""
            txtfilipinofrgrade8.Text = "0"
            txtfilipinoatgrade8.Text = ""
            txtfilipinocgrade8.Text = ""
            txtfilipinoecagrade8.Text = ""
            txtenglish1grade8.Text = ""
            txtenglish2grade8.Text = ""
            txtenglish3grade8.Text = ""
            txtenglish4grade8.Text = ""
            txtenglishfrgrade8.Text = "0"
            txtenglishatgrade8.Text = ""
            txtenglishcgrade8.Text = ""
            txtenglishecagrade8.Text = ""
            txtmath1grade8.Text = ""
            txtmath2grade8.Text = ""
            txtmath3grade8.Text = ""
            txtmath4grade8.Text = ""
            txtmathfrgrade8.Text = "0"
            txtmathatgrade8.Text = ""
            txtmathcgrade8.Text = ""
            txtmathecagrade8.Text = ""
            txtscience1grade8.Text = ""
            txtscience2grade8.Text = ""
            txtscience3grade8.Text = ""
            txtscience4grade8.Text = ""
            txtsciencefrgrade8.Text = "0"
            txtscienceatgrade8.Text = ""
            txtsciencecgrade8.Text = ""
            txtscienceecagrade8.Text = ""
            txtap1grade8.Text = ""
            txtap2grade8.Text = ""
            txtap3grade8.Text = ""
            txtap4grade8.Text = ""
            txtapfrgrade8.Text = "0"
            txtapatgrade8.Text = ""
            txtapcgrade8.Text = ""
            txtapecagrade8.Text = ""
            txtesp1grade8.Text = ""
            txtesp2grade8.Text = ""
            txtesp3grade8.Text = ""
            txtesp4grade8.Text = ""
            txtespfrgrade8.Text = "0"
            txtespatgrade8.Text = ""
            txtespcgrade8.Text = ""
            txtespecagrade8.Text = ""
            txttle1grade8.Text = ""
            txttle2grade8.Text = ""
            txttle3grade8.Text = ""
            txttle4grade8.Text = ""
            txttlefrgrade8.Text = "0"
            txttleatgrade8.Text = ""
            txttlecgrade8.Text = ""
            txttleecagrade8.Text = ""
            txtmapeh1grade8.Text = ""
            txtmapeh2grade8.Text = ""
            txtmapeh3grade8.Text = ""
            txtmapeh4grade8.Text = ""
            txtmapehfrgrade8.Text = "0"
            txtmapehatgrade8.Text = ""
            txtmapehcgrade8.Text = ""
            txtmapehecagrade8.Text = ""
            txtmusic1grade8.Text = ""
            txtmusic2grade8.Text = ""
            txtmusic3grade8.Text = ""
            txtmusic4grade8.Text = ""
            txtmusicfrgrade8.Text = "0"
            txtmusicatgrade8.Text = ""
            txtmusiccgrade8.Text = ""
            txtmusicecagrade8.Text = ""
            txtarts1grade8.Text = ""
            txtarts2grade8.Text = ""
            txtarts3grade8.Text = ""
            txtarts4grade8.Text = ""
            txtartsfrgrade8.Text = "0"
            txtartsatgrade8.Text = ""
            txtartscgrade8.Text = ""
            txtartsecagrade8.Text = ""
            txtpe1grade8.Text = ""
            txtpe2grade8.Text = ""
            txtpe3grade8.Text = ""
            txtpe4grade8.Text = ""
            txtpefrgrade8.Text = "0"
            txtpeatgrade8.Text = ""
            txtpecgrade8.Text = ""
            txtpeecagrade8.Text = ""
            txthealth1grade8.Text = ""
            txthealth2grade8.Text = ""
            txthealth3grade8.Text = ""
            txthealth4grade8.Text = ""
            txthealthfrgrade8.Text = "0"
            txthealthatgrade8.Text = ""
            txthealthcgrade8.Text = ""
            txthealthecagrade8.Text = ""
            txtaveragefrgrade8.Text = "0"
            txtaverageatgrade8.Text = ""
            txtaveragecgrade8.Text = ""
            txtclassifiedgrade9.Text = "GRADE 9"
            cbtotalyearsgrade9.Text = Nothing
            txtyeargrade9.Text = "9"
            txtsectiongrade9.Text = "Section..."
            txtschoolgrade9.Text = "School..."
            cbschoolyeargrade9.Text = Nothing
            txtfilipino1grade9.Text = ""
            txtfilipino2grade9.Text = ""
            txtfilipino3grade9.Text = ""
            txtfilipino4grade9.Text = ""
            txtfilipinofrgrade9.Text = "0"
            txtfilipinoatgrade9.Text = ""
            txtfilipinocgrade9.Text = ""
            txtfilipinoecagrade9.Text = ""
            txtenglish1grade9.Text = ""
            txtenglish2grade9.Text = ""
            txtenglish3grade9.Text = ""
            txtenglish4grade9.Text = ""
            txtenglishfrgrade9.Text = "0"
            txtenglishatgrade9.Text = ""
            txtenglishcgrade9.Text = ""
            txtenglishecagrade9.Text = ""
            txtmath1grade9.Text = ""
            txtmath2grade9.Text = ""
            txtmath3grade9.Text = ""
            txtmath4grade9.Text = ""
            txtmathfrgrade9.Text = "0"
            txtmathatgrade9.Text = ""
            txtmathcgrade9.Text = ""
            txtmathecagrade9.Text = ""
            txtscience1grade9.Text = ""
            txtscience2grade9.Text = ""
            txtscience3grade9.Text = ""
            txtscience4grade9.Text = ""
            txtsciencefrgrade9.Text = "0"
            txtscienceatgrade9.Text = ""
            txtsciencecgrade9.Text = ""
            txtscienceecagrade9.Text = ""
            txtap1grade9.Text = ""
            txtap2grade9.Text = ""
            txtap3grade9.Text = ""
            txtap4grade9.Text = ""
            txtapfrgrade9.Text = "0"
            txtapatgrade9.Text = ""
            txtapcgrade9.Text = ""
            txtapecagrade9.Text = ""
            txtesp1grade9.Text = ""
            txtesp2grade9.Text = ""
            txtesp3grade9.Text = ""
            txtesp4grade9.Text = ""
            txtespfrgrade9.Text = "0"
            txtespatgrade9.Text = ""
            txtespcgrade9.Text = ""
            txtespecagrade9.Text = ""
            txttle1grade9.Text = ""
            txttle2grade9.Text = ""
            txttle3grade9.Text = ""
            txttle4grade9.Text = ""
            txttlefrgrade9.Text = "0"
            txttleatgrade9.Text = ""
            txttlecgrade9.Text = ""
            txttleecagrade9.Text = ""
            txtmapeh1grade9.Text = ""
            txtmapeh2grade9.Text = ""
            txtmapeh3grade9.Text = ""
            txtmapeh4grade9.Text = ""
            txtmapehfrgrade9.Text = "0"
            txtmapehatgrade9.Text = ""
            txtmapehcgrade9.Text = ""
            txtmapehecagrade9.Text = ""
            txtmusic1grade9.Text = ""
            txtmusic2grade9.Text = ""
            txtmusic3grade9.Text = ""
            txtmusic4grade9.Text = ""
            txtmusicfrgrade9.Text = "0"
            txtmusicatgrade9.Text = ""
            txtmusiccgrade9.Text = ""
            txtmusicecagrade9.Text = ""
            txtarts1grade9.Text = ""
            txtarts2grade9.Text = ""
            txtarts3grade9.Text = ""
            txtarts4grade9.Text = ""
            txtartsfrgrade9.Text = "0"
            txtartsatgrade9.Text = ""
            txtartscgrade9.Text = ""
            txtartsecagrade9.Text = ""
            txtpe1grade9.Text = ""
            txtpe2grade9.Text = ""
            txtpe3grade9.Text = ""
            txtpe4grade9.Text = ""
            txtpefrgrade9.Text = "0"
            txtpeatgrade9.Text = ""
            txtpecgrade9.Text = ""
            txtpeecagrade9.Text = ""
            txthealth1grade9.Text = ""
            txthealth2grade9.Text = ""
            txthealth3grade9.Text = ""
            txthealth4grade9.Text = ""
            txthealthfrgrade9.Text = "0"
            txthealthatgrade9.Text = ""
            txthealthcgrade9.Text = ""
            txthealthecagrade9.Text = ""
            txtaveragefrgrade9.Text = "0"
            txtaverageatgrade9.Text = ""
            txtaveragecgrade9.Text = ""
            txtclassifiedgrade10.Text = "GRADE 10"
            cbtotalyearsgrade10.Text = Nothing
            txtyeargrade10.Text = "10"
            txtsectiongrade10.Text = "Section..."
            txtschoolgrade10.Text = "School..."
            cbschoolyeargrade10.Text = Nothing
            txtfilipino1grade10.Text = ""
            txtfilipino2grade10.Text = ""
            txtfilipino3grade10.Text = ""
            txtfilipino4grade10.Text = ""
            txtfilipinofrgrade10.Text = "0"
            txtfilipinoatgrade10.Text = ""
            txtfilipinocgrade10.Text = ""
            txtfilipinoecagrade10.Text = ""
            txtenglish1grade10.Text = ""
            txtenglish2grade10.Text = ""
            txtenglish3grade10.Text = ""
            txtenglish4grade10.Text = ""
            txtenglishfrgrade10.Text = "0"
            txtenglishatgrade10.Text = ""
            txtenglishcgrade10.Text = ""
            txtenglishecagrade10.Text = ""
            txtmath1grade10.Text = ""
            txtmath2grade10.Text = ""
            txtmath3grade10.Text = ""
            txtmath4grade10.Text = ""
            txtmathfrgrade10.Text = "0"
            txtmathatgrade10.Text = ""
            txtmathcgrade10.Text = ""
            txtmathecagrade10.Text = ""
            txtscience1grade10.Text = ""
            txtscience2grade10.Text = ""
            txtscience3grade10.Text = ""
            txtscience4grade10.Text = ""
            txtsciencefrgrade10.Text = "0"
            txtscienceatgrade10.Text = ""
            txtsciencecgrade10.Text = ""
            txtscienceecagrade10.Text = ""
            txtap1grade10.Text = ""
            txtap2grade10.Text = ""
            txtap3grade10.Text = ""
            txtap4grade10.Text = ""
            txtapfrgrade10.Text = "0"
            txtapatgrade10.Text = ""
            txtapcgrade10.Text = ""
            txtapecagrade10.Text = ""
            txtesp1grade10.Text = ""
            txtesp2grade10.Text = ""
            txtesp3grade10.Text = ""
            txtesp4grade10.Text = ""
            txtespfrgrade10.Text = "0"
            txtespatgrade10.Text = ""
            txtespcgrade10.Text = ""
            txtespecagrade10.Text = ""
            txttle1grade10.Text = ""
            txttle2grade10.Text = ""
            txttle3grade10.Text = ""
            txttle4grade10.Text = ""
            txttlefrgrade10.Text = "0"
            txttleatgrade10.Text = ""
            txttlecgrade10.Text = ""
            txttleecagrade10.Text = ""
            txtmapeh1grade10.Text = ""
            txtmapeh2grade10.Text = ""
            txtmapeh3grade10.Text = ""
            txtmapeh4grade10.Text = ""
            txtmapehfrgrade10.Text = "0"
            txtmapehatgrade10.Text = ""
            txtmapehcgrade10.Text = ""
            txtmapehecagrade10.Text = ""
            txtmusic1grade10.Text = ""
            txtmusic2grade10.Text = ""
            txtmusic3grade10.Text = ""
            txtmusic4grade10.Text = ""
            txtmusicfrgrade10.Text = "0"
            txtmusicatgrade10.Text = ""
            txtmusiccgrade10.Text = ""
            txtmusicecagrade10.Text = ""
            txtarts1grade10.Text = ""
            txtarts2grade10.Text = ""
            txtarts3grade10.Text = ""
            txtarts4grade10.Text = ""
            txtartsfrgrade10.Text = "0"
            txtartsatgrade10.Text = ""
            txtartscgrade10.Text = ""
            txtartsecagrade10.Text = ""
            txtpe1grade10.Text = ""
            txtpe2grade10.Text = ""
            txtpe3grade10.Text = ""
            txtpe4grade10.Text = ""
            txtpefrgrade10.Text = "0"
            txtpeatgrade10.Text = ""
            txtpecgrade10.Text = ""
            txtpeecagrade10.Text = ""
            txthealth1grade10.Text = ""
            txthealth2grade10.Text = ""
            txthealth3grade10.Text = ""
            txthealth4grade10.Text = ""
            txthealthfrgrade10.Text = "0"
            txthealthatgrade10.Text = ""
            txthealthcgrade10.Text = ""
            txthealthecagrade10.Text = ""
            txtaveragefrgrade10.Text = "0"
            txtaverageatgrade10.Text = ""
            txtaveragecgrade10.Text = ""
            txtdsjungrade7.Text = ""
            txtdsjulgrade7.Text = ""
            txtdsauggrade7.Text = ""
            txtdssepgrade7.Text = ""
            txtdsoctgrade7.Text = ""
            txtdsnovgrade7.Text = ""
            txtdsdecgrade7.Text = ""
            txtdsjangrade7.Text = ""
            txtdsfebgrade7.Text = ""
            txtdsmargrade7.Text = ""
            txtdsaprgrade7.Text = ""
            txtdstotalgrade7.Text = ""
            txtdpjungrade7.Text = ""
            txtdpjulgrade7.Text = ""
            txtdpauggrade7.Text = ""
            txtdpsepgrade7.Text = ""
            txtdpoctgrade7.Text = ""
            txtdpnovgrade7.Text = ""
            txtdpdecgrade7.Text = ""
            txtdpjangrade7.Text = ""
            txtdpfebgrade7.Text = ""
            txtdpmargrade7.Text = ""
            txtdpaprgrade7.Text = ""
            txtdptotalgrade7.Text = ""
            txtadvisergrade7.Text = ""
            txtadvancedunitsgrade7.Text = ""
            txtlackunitsgrade7.Text = ""
            txtdsjungrade8.Text = ""
            txtdsjulgrade8.Text = ""
            txtdsauggrade8.Text = ""
            txtdssepgrade8.Text = ""
            txtdsoctgrade8.Text = ""
            txtdsnovgrade8.Text = ""
            txtdsdecgrade8.Text = ""
            txtdsjangrade8.Text = ""
            txtdsfebgrade8.Text = ""
            txtdsmargrade8.Text = ""
            txtdsaprgrade8.Text = ""
            txtdstotalgrade8.Text = ""
            txtdpjungrade8.Text = ""
            txtdpjulgrade8.Text = ""
            txtdpauggrade8.Text = ""
            txtdpsepgrade8.Text = ""
            txtdpoctgrade8.Text = ""
            txtdpnovgrade8.Text = ""
            txtdpdecgrade8.Text = ""
            txtdpjangrade8.Text = ""
            txtdpfebgrade8.Text = ""
            txtdpmargrade8.Text = ""
            txtdpaprgrade8.Text = ""
            txtdptotalgrade8.Text = ""
            txtadvisergrade8.Text = ""
            txtadvancedunitsgrade8.Text = ""
            txtlackunitsgrade8.Text = ""
            txtdsjungrade9.Text = ""
            txtdsjulgrade9.Text = ""
            txtdsauggrade9.Text = ""
            txtdssepgrade9.Text = ""
            txtdsoctgrade9.Text = ""
            txtdsnovgrade9.Text = ""
            txtdsdecgrade9.Text = ""
            txtdsjangrade9.Text = ""
            txtdsfebgrade9.Text = ""
            txtdsmargrade9.Text = ""
            txtdsaprgrade9.Text = ""
            txtdstotalgrade9.Text = ""
            txtdpjungrade9.Text = ""
            txtdpjulgrade9.Text = ""
            txtdpauggrade9.Text = ""
            txtdpsepgrade9.Text = ""
            txtdpoctgrade9.Text = ""
            txtdpnovgrade9.Text = ""
            txtdpdecgrade9.Text = ""
            txtdpjangrade9.Text = ""
            txtdpfebgrade9.Text = ""
            txtdpmargrade9.Text = ""
            txtdpaprgrade9.Text = ""
            txtdptotalgrade9.Text = ""
            txtadvisergrade9.Text = ""
            txtadvancedunitsgrade9.Text = ""
            txtlackunitsgrade9.Text = ""
            txtdsjungrade10.Text = ""
            txtdsjulgrade10.Text = ""
            txtdsauggrade10.Text = ""
            txtdssepgrade10.Text = ""
            txtdsoctgrade10.Text = ""
            txtdsnovgrade10.Text = ""
            txtdsdecgrade10.Text = ""
            txtdsjangrade10.Text = ""
            txtdsfebgrade10.Text = ""
            txtdsmargrade10.Text = ""
            txtdsaprgrade10.Text = ""
            txtdstotalgrade10.Text = ""
            txtdpjungrade10.Text = ""
            txtdpjulgrade10.Text = ""
            txtdpauggrade10.Text = ""
            txtdpsepgrade10.Text = ""
            txtdpoctgrade10.Text = ""
            txtdpnovgrade10.Text = ""
            txtdpdecgrade10.Text = ""
            txtdpjangrade10.Text = ""
            txtdpfebgrade10.Text = ""
            txtdpmargrade10.Text = ""
            txtdpaprgrade10.Text = ""
            txtdptotalgrade10.Text = ""
            txtadvisergrade10.Text = ""
            txtadvancedunitsgrade10.Text = ""
            txtlackunitsgrade10.Text = ""
            txtlrn.Enabled = True
            txtname.Enabled = True
            txtbirthplace.Enabled = True
            txttown.Enabled = True
            txtbrgy.Enabled = True
            txtparent.Enabled = True
            txtoccupation.Enabled = True
            txtaddress.Enabled = True
            txtelementaryschool.Enabled = True
            txtgenave.Enabled = True
            dtpdateofbirth.Enabled = True
            cbgender.Enabled = True
            cbyeargrad.Enabled = True
            txtclassifiedgrade7.ReadOnly = True
            cbtotalyearsgrade7.Enabled = True
            txtyeargrade7.ReadOnly = True
            txtsectiongrade7.Enabled = True
            txtschoolgrade7.Enabled = True
            cbschoolyeargrade7.Enabled = True
            txtfilipino1grade7.Enabled = True
            txtfilipino2grade7.Enabled = True
            txtfilipino3grade7.Enabled = True
            txtfilipino4grade7.Enabled = True
            txtfilipinofrgrade7.ReadOnly = True
            txtfilipinoatgrade7.ReadOnly = True
            txtfilipinocgrade7.Enabled = True
            txtfilipinoecagrade7.Enabled = True
            txtenglish1grade7.Enabled = True
            txtenglish2grade7.Enabled = True
            txtenglish3grade7.Enabled = True
            txtenglish4grade7.Enabled = True
            txtenglishfrgrade7.ReadOnly = True
            txtenglishatgrade7.ReadOnly = True
            txtenglishcgrade7.Enabled = True
            txtenglishecagrade7.Enabled = True
            txtmath1grade7.Enabled = True
            txtmath2grade7.Enabled = True
            txtmath3grade7.Enabled = True
            txtmath4grade7.Enabled = True
            txtmathfrgrade7.ReadOnly = True
            txtmathatgrade7.ReadOnly = True
            txtmathcgrade7.Enabled = True
            txtmathecagrade7.Enabled = True
            txtscience1grade7.Enabled = True
            txtscience2grade7.Enabled = True
            txtscience3grade7.Enabled = True
            txtscience4grade7.Enabled = True
            txtsciencefrgrade7.ReadOnly = True
            txtscienceatgrade7.ReadOnly = True
            txtsciencecgrade7.Enabled = True
            txtscienceecagrade7.Enabled = True
            txtap1grade7.Enabled = True
            txtap2grade7.Enabled = True
            txtap3grade7.Enabled = True
            txtap4grade7.Enabled = True
            txtapfrgrade7.ReadOnly = True
            txtapatgrade7.ReadOnly = True
            txtapcgrade7.Enabled = True
            txtapecagrade7.Enabled = True
            txtesp1grade7.Enabled = True
            txtesp2grade7.Enabled = True
            txtesp3grade7.Enabled = True
            txtesp4grade7.Enabled = True
            txtespfrgrade7.ReadOnly = True
            txtespatgrade7.ReadOnly = True
            txtespcgrade7.Enabled = True
            txtespecagrade7.Enabled = True
            txttle1grade7.Enabled = True
            txttle2grade7.Enabled = True
            txttle3grade7.Enabled = True
            txttle4grade7.Enabled = True
            txttlefrgrade7.ReadOnly = True
            txttleatgrade7.ReadOnly = True
            txttlecgrade7.Enabled = True
            txttleecagrade7.Enabled = True
            txtmapeh1grade7.ReadOnly = True
            txtmapeh2grade7.ReadOnly = True
            txtmapeh3grade7.ReadOnly = True
            txtmapeh4grade7.ReadOnly = True
            txtmapehfrgrade7.ReadOnly = True
            txtmapehatgrade7.ReadOnly = True
            txtmapehcgrade7.Enabled = True
            txtmapehecagrade7.Enabled = True
            txtmusic1grade7.Enabled = True
            txtmusic2grade7.Enabled = True
            txtmusic3grade7.Enabled = True
            txtmusic4grade7.Enabled = True
            txtmusicfrgrade7.ReadOnly = True
            txtmusicatgrade7.ReadOnly = True
            txtmusiccgrade7.Enabled = True
            txtmusicecagrade7.Enabled = True
            txtarts1grade7.Enabled = True
            txtarts2grade7.Enabled = True
            txtarts3grade7.Enabled = True
            txtarts4grade7.Enabled = True
            txtartsfrgrade7.ReadOnly = True
            txtartsatgrade7.ReadOnly = True
            txtartscgrade7.Enabled = True
            txtartsecagrade7.Enabled = True
            txtpe1grade7.Enabled = True
            txtpe2grade7.Enabled = True
            txtpe3grade7.Enabled = True
            txtpe4grade7.Enabled = True
            txtpefrgrade7.ReadOnly = True
            txtpeatgrade7.ReadOnly = True
            txtpecgrade7.Enabled = True
            txtpeecagrade7.Enabled = True
            txthealth1grade7.Enabled = True
            txthealth2grade7.Enabled = True
            txthealth3grade7.Enabled = True
            txthealth4grade7.Enabled = True
            txthealthfrgrade7.ReadOnly = True
            txthealthatgrade7.ReadOnly = True
            txthealthcgrade7.Enabled = True
            txthealthecagrade7.Enabled = True
            txtaveragefrgrade7.ReadOnly = True
            txtaverageatgrade7.ReadOnly = True
            txtaveragecgrade7.Enabled = True
            txtclassifiedgrade8.ReadOnly = True
            cbtotalyearsgrade8.Enabled = True
            txtyeargrade8.ReadOnly = True
            txtsectiongrade8.Enabled = True
            txtschoolgrade8.Enabled = True
            cbschoolyeargrade8.Enabled = True
            txtfilipino1grade8.Enabled = True
            txtfilipino2grade8.Enabled = True
            txtfilipino3grade8.Enabled = True
            txtfilipino4grade8.Enabled = True
            txtfilipinofrgrade8.ReadOnly = True
            txtfilipinoatgrade8.ReadOnly = True
            txtfilipinocgrade8.Enabled = True
            txtfilipinoecagrade8.Enabled = True
            txtenglish1grade8.Enabled = True
            txtenglish2grade8.Enabled = True
            txtenglish3grade8.Enabled = True
            txtenglish4grade8.Enabled = True
            txtenglishfrgrade8.ReadOnly = True
            txtenglishatgrade8.ReadOnly = True
            txtenglishcgrade8.Enabled = True
            txtenglishecagrade8.Enabled = True
            txtmath1grade8.Enabled = True
            txtmath2grade8.Enabled = True
            txtmath3grade8.Enabled = True
            txtmath4grade8.Enabled = True
            txtmathfrgrade8.ReadOnly = True
            txtmathatgrade8.ReadOnly = True
            txtmathcgrade8.Enabled = True
            txtmathecagrade8.Enabled = True
            txtscience1grade8.Enabled = True
            txtscience2grade8.Enabled = True
            txtscience3grade8.Enabled = True
            txtscience4grade8.Enabled = True
            txtsciencefrgrade8.ReadOnly = True
            txtscienceatgrade8.ReadOnly = True
            txtsciencecgrade8.Enabled = True
            txtscienceecagrade8.Enabled = True
            txtap1grade8.Enabled = True
            txtap2grade8.Enabled = True
            txtap3grade8.Enabled = True
            txtap4grade8.Enabled = True
            txtapfrgrade8.ReadOnly = True
            txtapatgrade8.ReadOnly = True
            txtapcgrade8.Enabled = True
            txtapecagrade8.Enabled = True
            txtesp1grade8.Enabled = True
            txtesp2grade8.Enabled = True
            txtesp3grade8.Enabled = True
            txtesp4grade8.Enabled = True
            txtespfrgrade8.ReadOnly = True
            txtespatgrade8.ReadOnly = True
            txtespcgrade8.Enabled = True
            txtespecagrade8.Enabled = True
            txttle1grade8.Enabled = True
            txttle2grade8.Enabled = True
            txttle3grade8.Enabled = True
            txttle4grade8.Enabled = True
            txttlefrgrade8.ReadOnly = True
            txttleatgrade8.ReadOnly = True
            txttlecgrade8.Enabled = True
            txttleecagrade8.Enabled = True
            txtmapeh1grade8.ReadOnly = True
            txtmapeh2grade8.ReadOnly = True
            txtmapeh3grade8.ReadOnly = True
            txtmapeh4grade8.ReadOnly = True
            txtmapehfrgrade8.ReadOnly = True
            txtmapehatgrade8.ReadOnly = True
            txtmapehcgrade8.Enabled = True
            txtmapehecagrade8.Enabled = True
            txtmusic1grade8.Enabled = True
            txtmusic2grade8.Enabled = True
            txtmusic3grade8.Enabled = True
            txtmusic4grade8.Enabled = True
            txtmusicfrgrade8.ReadOnly = True
            txtmusicatgrade8.ReadOnly = True
            txtmusiccgrade8.Enabled = True
            txtmusicecagrade8.Enabled = True
            txtarts1grade8.Enabled = True
            txtarts2grade8.Enabled = True
            txtarts3grade8.Enabled = True
            txtarts4grade8.Enabled = True
            txtartsfrgrade8.ReadOnly = True
            txtartsatgrade8.ReadOnly = True
            txtartscgrade8.Enabled = True
            txtartsecagrade8.Enabled = True
            txtpe1grade8.Enabled = True
            txtpe2grade8.Enabled = True
            txtpe3grade8.Enabled = True
            txtpe4grade8.Enabled = True
            txtpefrgrade8.ReadOnly = True
            txtpeatgrade8.ReadOnly = True
            txtpecgrade8.Enabled = True
            txtpeecagrade8.Enabled = True
            txthealth1grade8.Enabled = True
            txthealth2grade8.Enabled = True
            txthealth3grade8.Enabled = True
            txthealth4grade8.Enabled = True
            txthealthfrgrade8.ReadOnly = True
            txthealthatgrade8.ReadOnly = True
            txthealthcgrade8.Enabled = True
            txthealthecagrade8.Enabled = True
            txtaveragefrgrade8.ReadOnly = True
            txtaverageatgrade8.ReadOnly = True
            txtaveragecgrade8.Enabled = True
            txtclassifiedgrade9.ReadOnly = True
            cbtotalyearsgrade9.Enabled = True
            txtyeargrade9.ReadOnly = True
            txtsectiongrade9.Enabled = True
            txtschoolgrade9.Enabled = True
            cbschoolyeargrade9.Enabled = True
            txtfilipino1grade9.Enabled = True
            txtfilipino2grade9.Enabled = True
            txtfilipino3grade9.Enabled = True
            txtfilipino4grade9.Enabled = True
            txtfilipinofrgrade9.ReadOnly = True
            txtfilipinoatgrade9.ReadOnly = True
            txtfilipinocgrade9.Enabled = True
            txtfilipinoecagrade9.Enabled = True
            txtenglish1grade9.Enabled = True
            txtenglish2grade9.Enabled = True
            txtenglish3grade9.Enabled = True
            txtenglish4grade9.Enabled = True
            txtenglishfrgrade9.ReadOnly = True
            txtenglishatgrade9.ReadOnly = True
            txtenglishcgrade9.Enabled = True
            txtenglishecagrade9.Enabled = True
            txtmath1grade9.Enabled = True
            txtmath2grade9.Enabled = True
            txtmath3grade9.Enabled = True
            txtmath4grade9.Enabled = True
            txtmathfrgrade9.ReadOnly = True
            txtmathatgrade9.ReadOnly = True
            txtmathcgrade9.Enabled = True
            txtmathecagrade9.Enabled = True
            txtscience1grade9.Enabled = True
            txtscience2grade9.Enabled = True
            txtscience3grade9.Enabled = True
            txtscience4grade9.Enabled = True
            txtsciencefrgrade9.ReadOnly = True
            txtscienceatgrade9.ReadOnly = True
            txtsciencecgrade9.Enabled = True
            txtscienceecagrade9.Enabled = True
            txtap1grade9.Enabled = True
            txtap2grade9.Enabled = True
            txtap3grade9.Enabled = True
            txtap4grade9.Enabled = True
            txtapfrgrade9.ReadOnly = True
            txtapatgrade9.ReadOnly = True
            txtapcgrade9.Enabled = True
            txtapecagrade9.Enabled = True
            txtesp1grade9.Enabled = True
            txtesp2grade9.Enabled = True
            txtesp3grade9.Enabled = True
            txtesp4grade9.Enabled = True
            txtespfrgrade9.ReadOnly = True
            txtespatgrade9.ReadOnly = True
            txtespcgrade9.Enabled = True
            txtespecagrade9.Enabled = True
            txttle1grade9.Enabled = True
            txttle2grade9.Enabled = True
            txttle3grade9.Enabled = True
            txttle4grade9.Enabled = True
            txttlefrgrade9.ReadOnly = True
            txttleatgrade9.ReadOnly = True
            txttlecgrade9.Enabled = True
            txttleecagrade9.Enabled = True
            txtmapeh1grade9.ReadOnly = True
            txtmapeh2grade9.ReadOnly = True
            txtmapeh3grade9.ReadOnly = True
            txtmapeh4grade9.ReadOnly = True
            txtmapehfrgrade9.ReadOnly = True
            txtmapehatgrade9.ReadOnly = True
            txtmapehcgrade9.Enabled = True
            txtmapehecagrade9.Enabled = True
            txtmusic1grade9.Enabled = True
            txtmusic2grade9.Enabled = True
            txtmusic3grade9.Enabled = True
            txtmusic4grade9.Enabled = True
            txtmusicfrgrade9.ReadOnly = True
            txtmusicatgrade9.ReadOnly = True
            txtmusiccgrade9.Enabled = True
            txtmusicecagrade9.Enabled = True
            txtarts1grade9.Enabled = True
            txtarts2grade9.Enabled = True
            txtarts3grade9.Enabled = True
            txtarts4grade9.Enabled = True
            txtartsfrgrade9.ReadOnly = True
            txtartsatgrade9.ReadOnly = True
            txtartscgrade9.Enabled = True
            txtartsecagrade9.Enabled = True
            txtpe1grade9.Enabled = True
            txtpe2grade9.Enabled = True
            txtpe3grade9.Enabled = True
            txtpe4grade9.Enabled = True
            txtpefrgrade9.ReadOnly = True
            txtpeatgrade9.ReadOnly = True
            txtpecgrade9.Enabled = True
            txtpeecagrade9.Enabled = True
            txthealth1grade9.Enabled = True
            txthealth2grade9.Enabled = True
            txthealth3grade9.Enabled = True
            txthealth4grade9.Enabled = True
            txthealthfrgrade9.ReadOnly = True
            txthealthatgrade9.ReadOnly = True
            txthealthcgrade9.Enabled = True
            txthealthecagrade9.Enabled = True
            txtaveragefrgrade9.ReadOnly = True
            txtaverageatgrade9.ReadOnly = True
            txtaveragecgrade9.Enabled = True
            txtclassifiedgrade10.ReadOnly = True
            cbtotalyearsgrade10.Enabled = True
            txtyeargrade10.ReadOnly = True
            txtsectiongrade10.Enabled = True
            txtschoolgrade10.Enabled = True
            cbschoolyeargrade10.Enabled = True
            txtfilipino1grade10.Enabled = True
            txtfilipino2grade10.Enabled = True
            txtfilipino3grade10.Enabled = True
            txtfilipino4grade10.Enabled = True
            txtfilipinofrgrade10.ReadOnly = True
            txtfilipinoatgrade10.ReadOnly = True
            txtfilipinocgrade10.Enabled = True
            txtfilipinoecagrade10.Enabled = True
            txtenglish1grade10.Enabled = True
            txtenglish2grade10.Enabled = True
            txtenglish3grade10.Enabled = True
            txtenglish4grade10.Enabled = True
            txtenglishfrgrade10.ReadOnly = True
            txtenglishatgrade10.ReadOnly = True
            txtenglishcgrade10.Enabled = True
            txtenglishecagrade10.Enabled = True
            txtmath1grade10.Enabled = True
            txtmath2grade10.Enabled = True
            txtmath3grade10.Enabled = True
            txtmath4grade10.Enabled = True
            txtmathfrgrade10.ReadOnly = True
            txtmathatgrade10.ReadOnly = True
            txtmathcgrade10.Enabled = True
            txtmathecagrade10.Enabled = True
            txtscience1grade10.Enabled = True
            txtscience2grade10.Enabled = True
            txtscience3grade10.Enabled = True
            txtscience4grade10.Enabled = True
            txtsciencefrgrade10.ReadOnly = True
            txtscienceatgrade10.ReadOnly = True
            txtsciencecgrade10.Enabled = True
            txtscienceecagrade10.Enabled = True
            txtap1grade10.Enabled = True
            txtap2grade10.Enabled = True
            txtap3grade10.Enabled = True
            txtap4grade10.Enabled = True
            txtapfrgrade10.ReadOnly = True
            txtapatgrade10.ReadOnly = True
            txtapcgrade10.Enabled = True
            txtapecagrade10.Enabled = True
            txtesp1grade10.Enabled = True
            txtesp2grade10.Enabled = True
            txtesp3grade10.Enabled = True
            txtesp4grade10.Enabled = True
            txtespfrgrade10.ReadOnly = True
            txtespatgrade10.ReadOnly = True
            txtespcgrade10.Enabled = True
            txtespecagrade10.Enabled = True
            txttle1grade10.Enabled = True
            txttle2grade10.Enabled = True
            txttle3grade10.Enabled = True
            txttle4grade10.Enabled = True
            txttlefrgrade10.ReadOnly = True
            txttleatgrade10.ReadOnly = True
            txttlecgrade10.Enabled = True
            txttleecagrade10.Enabled = True
            txtmapeh1grade10.ReadOnly = True
            txtmapeh2grade10.ReadOnly = True
            txtmapeh3grade10.ReadOnly = True
            txtmapeh4grade10.ReadOnly = True
            txtmapehfrgrade10.ReadOnly = True
            txtmapehatgrade10.ReadOnly = True
            txtmapehcgrade10.Enabled = True
            txtmapehecagrade10.Enabled = True
            txtmusic1grade10.Enabled = True
            txtmusic2grade10.Enabled = True
            txtmusic3grade10.Enabled = True
            txtmusic4grade10.Enabled = True
            txtmusicfrgrade10.ReadOnly = True
            txtmusicatgrade10.ReadOnly = True
            txtmusiccgrade10.Enabled = True
            txtmusicecagrade10.Enabled = True
            txtarts1grade10.Enabled = True
            txtarts2grade10.Enabled = True
            txtarts3grade10.Enabled = True
            txtarts4grade10.Enabled = True
            txtartsfrgrade10.ReadOnly = True
            txtartsatgrade10.ReadOnly = True
            txtartscgrade10.Enabled = True
            txtartsecagrade10.Enabled = True
            txtpe1grade10.Enabled = True
            txtpe2grade10.Enabled = True
            txtpe3grade10.Enabled = True
            txtpe4grade10.Enabled = True
            txtpefrgrade10.ReadOnly = True
            txtpeatgrade10.ReadOnly = True
            txtpecgrade10.Enabled = True
            txtpeecagrade10.Enabled = True
            txthealth1grade10.Enabled = True
            txthealth2grade10.Enabled = True
            txthealth3grade10.Enabled = True
            txthealth4grade10.Enabled = True
            txthealthfrgrade10.ReadOnly = True
            txthealthatgrade10.ReadOnly = True
            txthealthcgrade10.Enabled = True
            txthealthecagrade10.Enabled = True
            txtaveragefrgrade10.ReadOnly = True
            txtaverageatgrade10.ReadOnly = True
            txtaveragecgrade10.Enabled = True
            txtdsjungrade7.Enabled = True
            txtdsjulgrade7.Enabled = True
            txtdsauggrade7.Enabled = True
            txtdssepgrade7.Enabled = True
            txtdsoctgrade7.Enabled = True
            txtdsnovgrade7.Enabled = True
            txtdsdecgrade7.Enabled = True
            txtdsjangrade7.Enabled = True
            txtdsfebgrade7.Enabled = True
            txtdsmargrade7.Enabled = True
            txtdsaprgrade7.Enabled = True
            txtdstotalgrade7.ReadOnly = True
            txtdpjungrade7.Enabled = True
            txtdpjulgrade7.Enabled = True
            txtdpauggrade7.Enabled = True
            txtdpsepgrade7.Enabled = True
            txtdpoctgrade7.Enabled = True
            txtdpnovgrade7.Enabled = True
            txtdpdecgrade7.Enabled = True
            txtdpjangrade7.Enabled = True
            txtdpfebgrade7.Enabled = True
            txtdpmargrade7.Enabled = True
            txtdpaprgrade7.Enabled = True
            txtdptotalgrade7.ReadOnly = True
            txtadvisergrade7.Enabled = True
            txtadvancedunitsgrade7.Enabled = True
            txtlackunitsgrade7.Enabled = True
            txtdsjungrade8.Enabled = True
            txtdsjulgrade8.Enabled = True
            txtdsauggrade8.Enabled = True
            txtdssepgrade8.Enabled = True
            txtdsoctgrade8.Enabled = True
            txtdsnovgrade8.Enabled = True
            txtdsdecgrade8.Enabled = True
            txtdsjangrade8.Enabled = True
            txtdsfebgrade8.Enabled = True
            txtdsmargrade8.Enabled = True
            txtdsaprgrade8.Enabled = True
            txtdstotalgrade8.ReadOnly = True
            txtdpjungrade8.Enabled = True
            txtdpjulgrade8.Enabled = True
            txtdpauggrade8.Enabled = True
            txtdpsepgrade8.Enabled = True
            txtdpoctgrade8.Enabled = True
            txtdpnovgrade8.Enabled = True
            txtdpdecgrade8.Enabled = True
            txtdpjangrade8.Enabled = True
            txtdpfebgrade8.Enabled = True
            txtdpmargrade8.Enabled = True
            txtdpaprgrade8.Enabled = True
            txtdptotalgrade8.ReadOnly = True
            txtadvisergrade8.Enabled = True
            txtadvancedunitsgrade8.Enabled = True
            txtlackunitsgrade8.Enabled = True
            txtdsjungrade9.Enabled = True
            txtdsjulgrade9.Enabled = True
            txtdsauggrade9.Enabled = True
            txtdssepgrade9.Enabled = True
            txtdsoctgrade9.Enabled = True
            txtdsnovgrade9.Enabled = True
            txtdsdecgrade9.Enabled = True
            txtdsjangrade9.Enabled = True
            txtdsfebgrade9.Enabled = True
            txtdsmargrade9.Enabled = True
            txtdsaprgrade9.Enabled = True
            txtdstotalgrade9.ReadOnly = True
            txtdpjungrade9.Enabled = True
            txtdpjulgrade9.Enabled = True
            txtdpauggrade9.Enabled = True
            txtdpsepgrade9.Enabled = True
            txtdpoctgrade9.Enabled = True
            txtdpnovgrade9.Enabled = True
            txtdpdecgrade9.Enabled = True
            txtdpjangrade9.Enabled = True
            txtdpfebgrade9.Enabled = True
            txtdpmargrade9.Enabled = True
            txtdpaprgrade9.Enabled = True
            txtdptotalgrade9.ReadOnly = True
            txtadvisergrade9.Enabled = True
            txtadvancedunitsgrade9.Enabled = True
            txtlackunitsgrade9.Enabled = True
            txtdsjungrade10.Enabled = True
            txtdsjulgrade10.Enabled = True
            txtdsauggrade10.Enabled = True
            txtdssepgrade10.Enabled = True
            txtdsoctgrade10.Enabled = True
            txtdsnovgrade10.Enabled = True
            txtdsdecgrade10.Enabled = True
            txtdsjangrade10.Enabled = True
            txtdsfebgrade10.Enabled = True
            txtdsmargrade10.Enabled = True
            txtdsaprgrade10.Enabled = True
            txtdstotalgrade10.ReadOnly = True
            txtdpjungrade10.Enabled = True
            txtdpjulgrade10.Enabled = True
            txtdpauggrade10.Enabled = True
            txtdpsepgrade10.Enabled = True
            txtdpoctgrade10.Enabled = True
            txtdpnovgrade10.Enabled = True
            txtdpdecgrade10.Enabled = True
            txtdpjangrade10.Enabled = True
            txtdpfebgrade10.Enabled = True
            txtdpmargrade10.Enabled = True
            txtdpaprgrade10.Enabled = True
            txtdptotalgrade10.ReadOnly = True
            txtadvisergrade10.Enabled = True
            txtadvancedunitsgrade10.Enabled = True
            txtlackunitsgrade10.Enabled = True
            btndelete.Enabled = False
            btnupdate.Enabled = False
            btnedit.Enabled = False
            btnprint.Enabled = False
            btnsave.Enabled = True
        End If
    End Sub
End Class