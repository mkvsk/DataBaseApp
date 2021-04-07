using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
       private void button1_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();

        private void abonentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.abonentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.abonents". При необходимости она может быть перемещена или удалена.
            this.abonentsTableAdapter.Fill(this.dataSet1.abonents);

        }

        private void buttonExit_Click(object sender, EventArgs e) => System.Windows.Forms.Application.Exit();

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            abonentsBindingSource.AddNew();

            panelFillData.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            abonentsBindingSource.EndEdit();
            abonentsTableAdapter.Update(dataSet1);
        }
    }
}
