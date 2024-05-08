using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Televisao.Console;

namespace TelevisaoForms
{
    public partial class frmNovaBox : Form
    {
        private frmPrincipal _formPrincipal;

        //passagem de parametros
        public frmNovaBox(frmPrincipal principal)
        {
            InitializeComponent();
            _formPrincipal = principal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (numericUpDownCanais.Value <= 0)
            {
                //Se eu escolher um valor negativo 
                MessageBox.Show("tem que escolher o número total de canais", "Faltam dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Ele sai fora da função não faz código nenhum
                return;
            }

            //se a outra box estiver ligada 
            //aviso para desligar e só depois é que 
            //aceito uma nova com o número de canais pretendidos

            if (_formPrincipal.Meo != null && _formPrincipal.Meo.Estado)
            {
                MessageBox.Show("Tem primeiro que desligar a box, para poder criar outra");
                return;
            }

            //criara a nova tv com os canais
            Box novaBox = new Box(Convert.ToInt16(numericUpDownCanais.Value));

            _formPrincipal.Meo = novaBox;

            // _formPrincipal.Meo =new Box(Convert.ToInt16(numericUpDownCanais.Value));

            this.Close();
        }

        private void frmNovaBox_Load(object sender, EventArgs e)
        {

        }
    }
}
