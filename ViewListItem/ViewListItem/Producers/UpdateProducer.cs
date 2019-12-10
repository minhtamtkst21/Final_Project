using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewListItem.Producers
{
    public partial class UpdateProducer : Form
    {
        private ProducerManagement business;
        public UpdateProducer()
        {
            InitializeComponent();
            business = new ProducerManagement();
            this.Load += UpdateProducer_Load;
            this.btnCancel.Click += btnCancel_Click;
            this.btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var db=new Producer();
            var id = 
            var name = this.Name;
            business.UpdateProducer();
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void UpdateProducer_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
