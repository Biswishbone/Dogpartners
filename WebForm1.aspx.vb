Imports System.Data
Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page
    Public Shared conS As String = "Server=COBBISSQL01.ad.ilstu.edu\BIS362;Database=BIS362;Trusted_Connection=Yes;"
    Public Shared con As SqlConnection = New SqlConnection(conS)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Image1.ImageUrl = "Wishbone.jpg"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim DogPartners As String

        DogPartners = TextBox2.Text


        Dim cmdInsert As New SqlCommand("Insert Into DogPartners (PartnerName) Values (@p2)", con)

        With cmdInsert.Parameters
            .Clear()
            .AddWithValue("@p2", DogPartners)

        End With

        Try
            If con.State = ConnectionState.Closed Then con.Open()
            cmdInsert.ExecuteNonQuery()
            Response.Write("Partner Added Successfully")
        Catch ex As Exception
            Response.Write(ex.Message)

        Finally
            con.Close()
        End Try

    End Sub
End Class