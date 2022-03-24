using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using Views.Lib;

namespace Views
{
    public class Procedimento : BaseForm
    {
        FieldForm fieldDescricao;
        FieldForm fieldPreco;
		ButtonForm btnConfirmar;
        ButtonForm btnCancelar;

        public Procedimento() : base("Procedimento",SizeScreen.Small)
        {
            fieldDescricao = new FieldForm("Descrição",20,20,220,20);
            fieldPreco = new FieldForm("Preço",20,100,150,60);

			btnConfirmar = new ButtonForm("Confirmar", 20, 200, this.handleConfirm);
            btnCancelar = new ButtonForm("Cancelar", 140, 200, this.handleCancel);

            this.Controls.Add(fieldDescricao.lblField);
            this.Controls.Add(fieldDescricao.txtField);
            this.Controls.Add(fieldPreco.lblField);
            this.Controls.Add(fieldPreco.txtField);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        }

        private void handleConfirm(object sender, EventArgs e)
        {
            string title = "Atenção"; 
            string message = "Procedimento Cadastrado";  
            MessageBox.Show(message, title);
            this.Close();

        }

        
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }

}