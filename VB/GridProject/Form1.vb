Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports Helpers
Imports DevExpress.XtraEditors.Repository
Imports System.Data
Imports DevExpress.XtraEditors

Namespace GridProject
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
			AddHandler dataNavigator1.ButtonClick, AddressOf DataNavigator1_ButtonClick

		End Sub

		Private Sub DataNavigator1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.NavigatorButtonClickEventArgs)

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			'change the DSparameter value to create other tables
			Dim dh As New DataHelper(DSparameter.relatedDS2)

			'create DataSet
			Dim ds As DataSet = dh.DataSet
			sampleBindingSource.DataSource = ds
			sampleBindingSource.DataMember = dh.DataMember

			'DataBinding
			teValue1.DataBindings.Add("EditValue", sampleBindingSource, "value1")
			meValue2.DataBindings.Add("EditValue", sampleBindingSource, "value2")
			meValue3.DataBindings.Add("EditValue", sampleBindingSource, "value3")
			gridControl1.DataSource = sampleBindingSource

			dataNavigator1.DataSource = sampleBindingSource
		End Sub

	End Class
End Namespace
