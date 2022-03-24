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
    public class CrudAgendamento : BaseForm
    {
        ListView listView;
        ButtonForm btnCadastrar;
        ButtonForm btnEditar;
        ButtonForm btnExcluir;
        ButtonForm btnCancelar;
       
        public CrudAgendamento() : base("Lista de Agendamento",SizeScreen.Medium)
        {
            listView = new ListView();
			listView.Location = new Point(20, 30);
			listView.Size = new Size(500,300);
            listView.View = View.Details;
            ListViewItem Agendamento1 = new ListViewItem("112");
			Agendamento1.SubItems.Add("01");
            Agendamento1.SubItems.Add("Sala 01-A");
            Agendamento1.SubItems.Add("23/03/2022");
            listView.Items.AddRange(new ListViewItem[]{Agendamento1});
			listView.Columns.Add("ID Paciente", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("ID Dentista", -2, HorizontalAlignment.Left);
			listView.Columns.Add("ID Sala", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
			
            btnCadastrar = new ButtonForm("Cadastrar", 100, 450, this.CadastrarAgendamento);
            btnEditar = new ButtonForm("Editar", 200, 450, this.EditarAgendamento);
            btnExcluir = new ButtonForm("Excluir", 300, 450, this.ExcluirAgendamento);
            btnCancelar = new ButtonForm("Cancelar", 400, 450, this.handleCancel);

            this.Controls.Add(listView);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnCancelar);

        }
  
        private void CadastrarAgendamento(object sender, EventArgs e)
        {
            (new Agendamento()).Show();

        }
        private void EditarAgendamento(object sender, EventArgs e)
        {
            (new CrudDentista()).Show();

        }
        private void ExcluirAgendamento(object sender, EventArgs e)
        {
            (new CrudDentista()).Show();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}