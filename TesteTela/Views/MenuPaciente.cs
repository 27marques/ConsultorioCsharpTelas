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
    public class MenuPaciente : BaseForm
    {
        ListView listView;
        ButtonForm btnConfirmar;
        ButtonForm btnSair;
       
        public MenuPaciente() : base("Menu Paciente",SizeScreen.Medium)
        {
            listView = new ListView();
			listView.Location = new Point(10, 20);
			listView.Size = new Size(290,150);
            listView.View = View.Details;
            ListViewItem Procedimento1 = new ListViewItem("23/03/2022");
			Procedimento1.SubItems.Add("JOão da Silva");
            Procedimento1.SubItems.Add("Sala 01-A");
            Procedimento1.SubItems.Add("Confirmado");
            listView.Items.AddRange(new ListViewItem[]{Procedimento1});
			listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Confirmado", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
			
            btnConfirmar = new ButtonForm("Confirmar", 30, 220, this.handleConfirm);
            btnSair = new ButtonForm("Cancelar", 150, 220, this.handleCancel);

            this.Controls.Add(listView);
            this.Controls.Add(btnConfirmar);
            this.Controls.Add(btnSair);

        }

        private void handleConfirm(object sender, EventArgs e)
        {
            (new Login()).Show();

        }

        
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}