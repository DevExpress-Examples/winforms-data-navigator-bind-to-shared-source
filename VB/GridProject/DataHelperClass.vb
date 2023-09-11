Imports System
Imports System.Data

Namespace Helpers

    Public Class DataHelper

        Private _DataSet As DataSet

        Private _DataMember As String = "FirstTable"

        Public Sub New(ByVal param As DSparameter)
            Select Case param
                Case DSparameter.simpleDS
                    MakeFirstTable()
                    Exit Select
                Case DSparameter.simpleBoolDS
                    MakeBoolFirstTable()
                    Exit Select
                Case DSparameter.simpleTimeDS
                    MakeTimeFirstTable()
                    Exit Select
                Case DSparameter.doubleDS
                    MakeFirstTable()
                    MakeSecondTable()
                    Exit Select
                Case DSparameter.relatedDS1
                    MakeFirstTable()
                    MakeSecondTable()
                    MakeThirdTable()
                    MakeDataRelation()
                    Exit Select
                Case DSparameter.relatedDS2
                    MakeFirstTable()
                    MakeSecondTable()
                    MakeThirdTable()
                    MakeDataRelation2()
                    Exit Select
            End Select

            DataSet.AcceptChanges()
        End Sub

        Private Sub MakeFirstTable()
            Dim table As DataTable = New DataTable("FirstTable")
            Dim column As DataColumn
            Dim row As DataRow
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value1"
            column.AutoIncrement = False
            column.Caption = "value1"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value2"
            column.AutoIncrement = False
            column.Caption = "value2"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value3"
            column.AutoIncrement = False
            column.Caption = "value3"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            DataSet = New DataSet()
            DataSet.Tables.Add(table)
            For i As Integer = 0 To 100
                row = table.NewRow()
                row("value1") = i
                row("value2") = 10 * i
                row("value3") = 100 * i
                table.Rows.Add(row)
            Next
        End Sub

        Public Shared Function MakeAdditionalTable() As DataTable
            Dim table As DataTable = New DataTable("FirstTable")
            Dim column As DataColumn
            Dim row As DataRow
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value1"
            column.AutoIncrement = False
            column.Caption = "value1"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value2"
            column.AutoIncrement = False
            column.Caption = "value2"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value3"
            column.AutoIncrement = False
            column.Caption = "value3"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            For i As Integer = 0 To 100
                row = table.NewRow()
                row("value1") = i
                row("value2") = 10 * i
                row("value3") = 100 * i
                table.Rows.Add(row)
            Next

            Return table
        End Function

        Private Sub MakeTimeFirstTable()
            Dim table As DataTable = New DataTable("FirstTable")
            Dim column As DataColumn
            Dim row As DataRow
            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "value1"
            column.AutoIncrement = False
            column.Caption = "value1"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Date)
            column.ColumnName = "value2"
            column.AutoIncrement = False
            column.Caption = "value2"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value3"
            column.AutoIncrement = False
            column.Caption = "value3"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            DataSet = New DataSet()
            DataSet.Tables.Add(table)
            For i As Integer = 0 To 10
                row = table.NewRow()
                row("value1") = "Item" & i.ToString()
                row("value2") = Date.Now
                row("value3") = Date.Now.Year
                table.Rows.Add(row)
            Next
        End Sub

        Private Sub MakeBoolFirstTable()
            Dim table As DataTable = New DataTable("FirstTable")
            Dim column As DataColumn
            Dim row As DataRow
            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "value1"
            column.AutoIncrement = False
            column.Caption = "value1"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Boolean)
            column.ColumnName = "value2"
            column.AutoIncrement = False
            column.Caption = "value2"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(String)
            column.ColumnName = "value3"
            column.AutoIncrement = False
            column.Caption = "value2"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            DataSet = New DataSet()
            DataSet.Tables.Add(table)
            For i As Integer = 0 To 10
                row = table.NewRow()
                row("value1") = "Item " & i.ToString()
                row("value2") = False
                row("value3") = "Opposite value: " & (Not CBool(row("value2"))).ToString()
                table.Rows.Add(row)
            Next
        End Sub

        Private Sub MakeSecondTable()
            Dim table As DataTable = New DataTable("SecondTable")
            Dim column As DataColumn
            Dim row As DataRow
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value4"
            column.AutoIncrement = False
            column.Caption = "value4"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value5"
            column.AutoIncrement = False
            column.Caption = "value5"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value6"
            column.AutoIncrement = False
            column.Caption = "value6"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            DataSet.Tables.Add(table)
            For i As Integer = 0 To 10
                row = table.NewRow()
                row("value4") = i
                row("value5") = 10 * i
                row("value6") = 100 * i
                table.Rows.Add(row)
            Next
        End Sub

        Private Sub MakeThirdTable()
            Dim table As DataTable = New DataTable("ThirdTable")
            Dim column As DataColumn
            Dim row As DataRow
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value7"
            column.AutoIncrement = False
            column.Caption = "value7"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value8"
            column.AutoIncrement = False
            column.Caption = "value7"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            column = New DataColumn()
            column.DataType = GetType(Integer)
            column.ColumnName = "value9"
            column.AutoIncrement = False
            column.Caption = "Value9"
            column.ReadOnly = False
            column.Unique = False
            table.Columns.Add(column)
            DataSet.Tables.Add(table)
            For i As Integer = 0 To 10
                row = table.NewRow()
                row("value7") = i
                row("value8") = 10 * i
                row("value9") = 100 * i
                table.Rows.Add(row)
            Next
        End Sub

        Private Sub MakeDataRelation()
            Dim parentColumn As DataColumn = DataSet.Tables("FirstTable").Columns("value1")
            Dim childColumn As DataColumn = DataSet.Tables("SecondTable").Columns("value4")
            Dim relation As DataRelation = New DataRelation("value1_value4", parentColumn, childColumn)
            DataSet.Tables("SecondTable").ParentRelations.Add(relation)
            parentColumn = DataSet.Tables("SecondTable").Columns("value4")
            childColumn = DataSet.Tables("ThirdTable").Columns("value7")
            relation = New DataRelation("value4_value7", parentColumn, childColumn)
            DataSet.Tables("ThirdTable").ParentRelations.Add(relation)
        End Sub

        Private Sub MakeDataRelation2()
            Dim parentColumn As DataColumn = DataSet.Tables("FirstTable").Columns("value1")
            Dim childColumn As DataColumn = DataSet.Tables("SecondTable").Columns("value4")
            Dim relation As DataRelation = New DataRelation("value1_value4", parentColumn, childColumn)
            DataSet.Tables("SecondTable").ParentRelations.Add(relation)
            parentColumn = DataSet.Tables("FirstTable").Columns("value1")
            childColumn = DataSet.Tables("ThirdTable").Columns("value7")
            relation = New DataRelation("value1_value7", parentColumn, childColumn)
            DataSet.Tables("ThirdTable").ParentRelations.Add(relation)
        End Sub

        Public Property DataSet As DataSet
            Get
                Return _DataSet
            End Get

            Set(ByVal value As DataSet)
                _DataSet = value
            End Set
        End Property

        Public Property DataMember As String
            Get
                Return _DataMember
            End Get

            Set(ByVal value As String)
                _DataMember = value
            End Set
        End Property

        Public Shared Sub CommitTransactionStub()
            Throw New InvalidOperationException("Fake exception")
        End Sub
    End Class

    Public Enum DSparameter
        simpleDS = 0
        doubleDS = 1
        relatedDS1 = 2
        simpleBoolDS = 3
        simpleTimeDS = 4
        relatedDS2 = 5
    End Enum
End Namespace
