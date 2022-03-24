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
    public class CrudDentista : BaseForm
    {
        ListView listView;
        ButtonForm btnCadastrar;
        ButtonForm btnEditar;
        ButtonForm btnExcluir;
        ButtonForm btnCancelar;
       
        public CrudDentista() : base("Lista de Dentistas",SizeScreen.Large)
        {
            listView = new ListView();
			listView.Location = new Point(20, 30);
			listView.Size = new Size(800,300);
            listView.View = View.Details;
            ListViewItem Dentista1 = new ListViewItem("João da Silva");
			Dentista1.SubItems.Add("123.456.789-00");
            Dentista1.SubItems.Add("47 9999-9999");
            Dentista1.SubItems.Add("joao.silva@dentista.com.br");
            Dentista1.SubItems.Add("1234");
            Dentista1.SubItems.Add("123-SC");
            Dentista1.SubItems.Add("R$ 1.800,00");
            Dentista1.SubItems.Add("Clínico Geral");
            listView.Items.AddRange(new ListViewItem[]{Dentista1});
			listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("E-mail", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Senha", -2, HorizontalAlignment.Left);
            listView.Columns.Add("C.R.O.", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salário", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;
			
            btnCadastrar = new ButtonForm("Cadastrar", 100, 450, this.CadastrarDentista);
            btnEditar = new ButtonForm("Editar", 200, 450, this.EditarDentista);
            btnExcluir = new ButtonForm("Excluir", 300, 450, this.ExcluirDentista);
            btnCancelar = new ButtonForm("Cancelar", 400, 450, this.handleCancel);

            this.Controls.Add(listView);
            this.Controls.Add(btnCadastrar);
            this.Controls.Add(btnEditar);
            this.Controls.Add(btnExcluir);
            this.Controls.Add(btnCancelar);

        }
  
        private void CadastrarDentista(object sender, EventArgs e)
        {
            (new Dentista()).Show();

        }
        private void EditarDentista(object sender, EventArgs e)
        {
            (new CrudDentista()).Show();

        }
        private void ExcluirDentista(object sender, EventArgs e)
        {
            (new CrudDentista()).Show();

        }
        private void handleCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}