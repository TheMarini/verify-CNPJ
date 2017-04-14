using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjFormClasse
{
    public partial class frmFormClasse : Form
    {
        public frmFormClasse()
        {
            InitializeComponent();
        }

        private void TxtCNPJ_Changed(object sender, EventArgs e)
        {
            string cnpj = txtCNPJ.Text.Replace(".", "").Replace("-", "").Replace("_", "").Replace("/", "");

            if (cnpj.Length == 14)
            {
                prjClasse27757.validarCNPJ validarCNPJ = new prjClasse27757.validarCNPJ();
                try
                {
                    validarCNPJ.cnpj = cnpj;
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                    return;
                }

                if (validarCNPJ.valido)
                {
                    lblValido.ForeColor = Color.Green;
                    lblValido.Text = "Válido";
                }
                else
                {
                    lblValido.ForeColor = Color.Red;
                    lblValido.Text = "Inválido";
                }
            }
        }
    }
}
