Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = GetDataSet()

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Dim tbl As DataTable = DataGridView1.DataSource
        tbl.DefaultView.RowFilter = $"[Name] like '{txtFilter.Text.Trim()}%'"
    End Sub

    Private Function GetDataSet() As DataTable

        Dim dataSrc As New DataTable()

        Dim dcName As New DataColumn("Name")
        Dim dcValue As New DataColumn("Value")
        Dim dcSelected As New DataColumn("Selected")

        dataSrc.Columns.Add(dcName)
        dataSrc.Columns.Add(dcValue)
        dataSrc.Columns.Add(dcSelected)

        Dim dr1 = dataSrc.NewRow()
        dr1(0) = "Bob"
        dr1(1) = "Programmer"


        Dim dr2 = dataSrc.NewRow()
        dr2(0) = "Alice"
        dr2(1) = "QA"

        Dim dr3 = dataSrc.NewRow()
        dr3(0) = "Steve"
        dr3(1) = "DBA"

        dataSrc.Rows.Add(dr1)
        dataSrc.Rows.Add(dr2)
        dataSrc.Rows.Add(dr3)

        Return dataSrc

    End Function
End Class
