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
    public class Sala : BaseForm
    {
        FieldForm fieldNumero;
        FieldForm fieldEquipamento;
		ButtonForm btnConfirmar;
        ButtonForm btnCancelar;

        public Sala() : base("Sala",SizeScreen.Small)
        {
            fieldNumero = new FieldForm("Número",20,20,180,20);
            fieldEquipamento = new FieldForm("Equipamento",20,100,180,60);

			btnConfirmar = new ButtonForm("Confirmar", 180, 220, this.handleConfirm);
            btnCancelar = new ButtonForm("Cancelar", 180, 260, this.handleCancel);

            this.Controls.Add(fieldNumero.lblField);
            this.Controls.Add(fieldNumero.txtField);
            this.Controls.Add(fieldEquipamento.lblField);
            this.Controls.Add(fieldEquipamento.txtField);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnCancelar);
        }

        private void handleConfirm(object sender, EventArgs e)
        {
            string message = "Você deseja confirmar?";  

            string title = "Atenção!";  

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;  

            DialogResult result = MessageBox.Show(message, title, buttons);  

            if (result == DialogResult.Yes) {  

                (new MenuDentista()).Show();

                this.Hide();  

            } else {  

                this.Close();  

            } 

        }

        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }

}