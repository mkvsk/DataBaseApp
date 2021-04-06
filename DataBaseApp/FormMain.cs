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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.dataSet1.clients);

        }

        private void buttonRegisterNewClient_Click(object sender, EventArgs e)
        {
            clientsBindingSource.AddNew();
        }

        private void buttonSaveNewClient_Click(object sender, EventArgs e)
        {
            clientsBindingSource.EndEdit();
            clientsTableAdapter.Update(dataSet1);
        }
    }
}
