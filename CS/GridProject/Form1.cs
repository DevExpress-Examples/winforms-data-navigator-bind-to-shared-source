using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Helpers;
using DevExpress.XtraEditors.Repository;
using System.Data;
using DevExpress.XtraEditors;

namespace GridProject
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
			dataNavigator1.ButtonClick += DataNavigator1_ButtonClick;

		}

		private void DataNavigator1_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
		{
	
		}

		private void Form1_Load(object sender, EventArgs e)
        {
            //change the DSparameter value to create other tables
            DataHelper dh = new DataHelper(DSparameter.relatedDS2);

            //create DataSet
            DataSet ds = dh.DataSet;
            sampleBindingSource.DataSource = ds;
            sampleBindingSource.DataMember = dh.DataMember;

            //DataBinding
            teValue1.DataBindings.Add("EditValue", sampleBindingSource, "value1");
            meValue2.DataBindings.Add("EditValue", sampleBindingSource, "value2");
            meValue3.DataBindings.Add("EditValue", sampleBindingSource, "value3");
            gridControl1.DataSource = sampleBindingSource;

            dataNavigator1.DataSource = sampleBindingSource;
        }
        
    }
}
