namespace GridProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            this.meValue2 = new DevExpress.XtraEditors.MemoEdit();
            this.meValue3 = new DevExpress.XtraEditors.MemoEdit();
            this.sampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teValue1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.meValue2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meValue3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teValue1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Location = new System.Drawing.Point(12, 615);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(577, 24);
            this.dataNavigator1.TabIndex = 0;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // meValue2
            // 
            this.meValue2.Location = new System.Drawing.Point(12, 412);
            this.meValue2.Name = "meValue2";
            this.meValue2.Size = new System.Drawing.Size(577, 77);
            this.meValue2.TabIndex = 2;
            // 
            // meValue3
            // 
            this.meValue3.Location = new System.Drawing.Point(12, 514);
            this.meValue3.Name = "meValue3";
            this.meValue3.Size = new System.Drawing.Size(577, 76);
            this.meValue3.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 32);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(577, 310);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 495);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Value 3 (Memo Edit)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 393);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(95, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Value 2 (Memo Edit)";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 348);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(89, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Value 1 (Text Edit)";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(151, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Data Source (Data Grid control)";
            // 
            // teValue1
            // 
            this.teValue1.Location = new System.Drawing.Point(12, 367);
            this.teValue1.Name = "teValue1";
            this.teValue1.Size = new System.Drawing.Size(577, 20);
            this.teValue1.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 595);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(73, 13);
            this.labelControl5.TabIndex = 11;
            this.labelControl5.Text = "Data Navigator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 651);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.teValue1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.meValue3);
            this.Controls.Add(this.meValue2);
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.gridControl1);
            this.MaximumSize = new System.Drawing.Size(617, 690);
            this.MinimumSize = new System.Drawing.Size(617, 690);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meValue2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meValue3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teValue1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DataNavigator dataNavigator1;
        private DevExpress.XtraEditors.MemoEdit meValue2;
        private DevExpress.XtraEditors.MemoEdit meValue3;
        private System.Windows.Forms.BindingSource sampleBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teValue1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}

