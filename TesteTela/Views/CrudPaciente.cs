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
    public class CrudPaciente : BaseForm
    {
        ListView listView;
        ButtonForm btnCadastrar;
        ButtonForm btnEditar;
        ButtonForm btnExcluir;
        ButtonForm btnCancelar;
       
        public CrudPaciente() : base("Lista de Pacientes",SizeScreen.Large)
        {
            listView = new ListView();
			listView.Location = new Point(20, 30);
			listView.Size = new Size(800,300);
            listView.View = View.Details;
            ListViewItem Paciente1 = new ListViewItem("José da Silva");
			Paciente1.SubItems.Add("123.456.789-00");
            Paciente1.SubItems.Add("47 9999-9999");
            Paciente1.SubItems.Add("jose.silva@paciente.com.br");
            Paciente1.SubItems.Add("1234");
            Paciente1.SubItems.Add("18/04/1957");
            listView.Items.AddRange(new ListViewItem[]{Paciente1});
			listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("E-mail", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Senha", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
			
            btnCadastrar = new ButtonForm("Cadastrar", 100, 450, this.CadastrarPaciente);
            btnEditar = new ButtonForm("Editar", 200, 450, this.EditarPaciente);
            btnExcluir = new ButtonForm("Excluir", 300, 450, this.ExcluirPaciente);
            btnCancelar = new ButtonForm("Cancelar", 400, 450, this.handleCancel);

            this.Controls.Add(listView);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnCancelar);

        }
  
        private void CadastrarPaciente(object sender, EventArgs e)
        {
            (new Paciente()).Show();

        }
        private void EditarPaciente(object sender, EventArgs e)
        {
            (new CrudDentista()).Show();

        }
        private void ExcluirPaciente(object sender, EventArgs e)
        {
            (new CrudDentista()).Show();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}