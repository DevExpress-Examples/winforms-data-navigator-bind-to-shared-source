Namespace GridProject
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
			Me.meValue2 = New DevExpress.XtraEditors.MemoEdit()
			Me.meValue3 = New DevExpress.XtraEditors.MemoEdit()
			Me.sampleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
			Me.teValue1 = New DevExpress.XtraEditors.TextEdit()
			Me.labelControl5 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.meValue2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.meValue3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sampleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.teValue1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataNavigator1
			' 
			Me.dataNavigator1.Location = New System.Drawing.Point(12, 615)
			Me.dataNavigator1.Name = "dataNavigator1"
			Me.dataNavigator1.Size = New System.Drawing.Size(577, 24)
			Me.dataNavigator1.TabIndex = 0
			Me.dataNavigator1.Text = "dataNavigator1"
			' 
			' meValue2
			' 
			Me.meValue2.Location = New System.Drawing.Point(12, 412)
			Me.meValue2.Name = "meValue2"
			Me.meValue2.Size = New System.Drawing.Size(577, 77)
			Me.meValue2.TabIndex = 2
			' 
			' meValue3
			' 
			Me.meValue3.Location = New System.Drawing.Point(12, 514)
			Me.meValue3.Name = "meValue3"
			Me.meValue3.Size = New System.Drawing.Size(577, 76)
			Me.meValue3.TabIndex = 3
			' 
			' gridControl1
			' 
			Me.gridControl1.Location = New System.Drawing.Point(12, 32)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(577, 310)
			Me.gridControl1.TabIndex = 5
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 495)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(95, 13)
			Me.labelControl1.TabIndex = 6
			Me.labelControl1.Text = "Value 3 (Memo Edit)"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(14, 393)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(95, 13)
			Me.labelControl2.TabIndex = 7
			Me.labelControl2.Text = "Value 2 (Memo Edit)"
			' 
			' labelControl3
			' 
			Me.labelControl3.Location = New System.Drawing.Point(13, 348)
			Me.labelControl3.Name = "labelControl3"
			Me.labelControl3.Size = New System.Drawing.Size(89, 13)
			Me.labelControl3.TabIndex = 8
			Me.labelControl3.Text = "Value 1 (Text Edit)"
			' 
			' labelControl4
			' 
			Me.labelControl4.Location = New System.Drawing.Point(12, 13)
			Me.labelControl4.Name = "labelControl4"
			Me.labelControl4.Size = New System.Drawing.Size(151, 13)
			Me.labelControl4.TabIndex = 9
			Me.labelControl4.Text = "Data Source (Data Grid control)"
			' 
			' teValue1
			' 
			Me.teValue1.Location = New System.Drawing.Point(12, 367)
			Me.teValue1.Name = "teValue1"
			Me.teValue1.Size = New System.Drawing.Size(577, 20)
			Me.teValue1.TabIndex = 10
			' 
			' labelControl5
			' 
			Me.labelControl5.Location = New System.Drawing.Point(14, 595)
			Me.labelControl5.Name = "labelControl5"
			Me.labelControl5.Size = New System.Drawing.Size(73, 13)
			Me.labelControl5.TabIndex = 11
			Me.labelControl5.Text = "Data Navigator"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(601, 651)
			Me.Controls.Add(Me.labelControl5)
			Me.Controls.Add(Me.teValue1)
			Me.Controls.Add(Me.labelControl4)
			Me.Controls.Add(Me.labelControl3)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.meValue3)
			Me.Controls.Add(Me.meValue2)
			Me.Controls.Add(Me.dataNavigator1)
			Me.Controls.Add(Me.gridControl1)
			Me.MaximumSize = New System.Drawing.Size(617, 690)
			Me.MinimumSize = New System.Drawing.Size(617, 690)
			Me.Name = "Form1"
			Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
			Me.Text = "Form1"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			CType(Me.meValue2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.meValue3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sampleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.teValue1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
		Private meValue2 As DevExpress.XtraEditors.MemoEdit
		Private meValue3 As DevExpress.XtraEditors.MemoEdit
		Private sampleBindingSource As System.Windows.Forms.BindingSource
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
		Private labelControl3 As DevExpress.XtraEditors.LabelControl
		Private labelControl4 As DevExpress.XtraEditors.LabelControl
		Private teValue1 As DevExpress.XtraEditors.TextEdit
		Private labelControl5 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

