using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DeserializeXML
{
    public partial class XMLSerialization : Form
    {
        public XMLSerialization()
        {
            InitializeComponent();
        }

        private void deserialize_btn_Click(object sender, EventArgs e)
        {
            DeserializeForm deserializeForm = new DeserializeForm();
            deserializeForm.Show();
        }

        private void serialize_btn_Click(object sender, EventArgs e)
        {
            SerializeForm serializeForm = new SerializeForm();
            serializeForm.Show();
        }
    }
}