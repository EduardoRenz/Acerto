using System;
using System.Data;
using Consulta.utilitarios;
using Consulta.classes;
using System.ComponentModel;
using System.Windows.Forms;

namespace Acerto
{
    partial class Principal
    {
        public DataTable grupo;
        public DataTable subGrupo;
        public void listarGrupo(OracleConexao conecta)
        {
            grupo = conecta.Consulta("select subgrp_cod, subgrp_desc from SUBGRUPO where subgrp_grp='030'");
            comboBoxGrupo.Items.Add(new Grupo(-1, "---"));
            foreach (DataRow row in grupo.Rows)
            {
                // comboBoxGrupo.Items.Add(row[1]);
                comboBoxGrupo.Items.Add(new Grupo(Convert.ToInt32(row[0]),row[1].ToString()));
            }
        } // Busca grupos no banco e adiciona na comboBox
        private void listaMercadorias(string busca)
        {

            query = "select EST_SET as Filial, MERCADO_DES as Mercadoria,MERCADO_PRC preco, EST_SAL as Saldo, MERCADO_COD as Material, EST_SER as serie, MERCADO_SGRP as subgrupo" +
                   " from MERCADORIAS, ESTOQUES,GRUPO where MERCADO_DES LIKE '%" + Eduardo.SqlScape(textProduto.Text) + "%' and EST_REF = MERCADO_COD and GRUPO_COD = MERCADO_GRP and  ROWNUM <= 500";
            if (intFilial.Value != 0)
            {
                query += " and EST_SET =" + Eduardo.SqlScape(intFilial.Value.ToString()); // se não for qualquer filial
            }
            if (checkBoxMercadoSaldo.Checked)
            {
                query += " and EST_SAL = 1 "; // Apenas com saldo
            }
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }// só com busca
        private void listaMercadorias(string busca, Grupo grupo) // com busca e grupo
        {
            Console.WriteLine("Iniciou pesquisa com Grupo");
            query = "select EST_SET as Filial, MERCADO_DES as Mercadoria,MERCADO_PRC preco, EST_SAL as Saldo, MERCADO_COD as Material, EST_SER as serie, MERCADO_SGRP as subgrupo" +
                    " from MERCADORIAS, ESTOQUES, SUBGRUPO where MERCADO_DES LIKE '%" +Eduardo.SqlScape(textProduto.Text) + "%' and MERCADO_SGRP = " + grupo.codigo;

            if(intFilial.Value != 0)
            {
                query += " and EST_SET =" + Eduardo.SqlScape(intFilial.Value.ToString()); // se não for qualquer filial
            }
            if (checkBoxMercadoSaldo.Checked)
            {
                query += " and EST_SAL = 1 "; // Apenas com saldo
            } 
            query+=" and EST_REF = MERCADO_COD and SUBGRP_COD = MERCADO_SGRP and  ROWNUM <= 500";
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }
        private void listaMercadorias(string busca, Grupo grupo, Grupo subgrupo) // com busca e grupo e subgrupo
        {
            query = "select EST_SET as Filial, MERCADO_DES as Mercadoria,MERCADO_PRC preco, EST_SAL as Saldo, MERCADO_COD as Material, EST_SER as serie" +
                    " from MERCADORIAS, ESTOQUES,GRUPO where MERCADO_DES LIKE '%" + Eduardo.SqlScape(textProduto.Text) + "%' and MERCADO_GRP = " + grupo.codigo + " and MERCADO_SGRP = "+subgrupo.codigo+"";
            if (intFilial.Value != 0)
            {
                query += " and EST_SET =" + Eduardo.SqlScape(intFilial.Value.ToString()); // se não for qualquer filial
            }
            if (checkBoxMercadoSaldo.Checked)
            {
                query += " and EST_SAL = 1 "; // Apenas com saldo
            }
            query += " and EST_REF = MERCADO_COD and GRUPO_COD = MERCADO_GRP and  ROWNUM <= 500";
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }
        private void btMercadoriaPesquisa_Click(object sender, EventArgs e)
        {
            worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(PesquisaMercadoAsync);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(PesquisaMercadoAsyncCompleta);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            Grupo res = comboBoxGrupo.SelectedItem as Grupo;
           
            btMercadoriaPesquisa.Text = "Pesquisando...";
            btMercadoriaPesquisa.Enabled = false;
            if (comboBoxGrupo.SelectedIndex == -1 || res.codigo == -1)
            {
                listaMercadorias(textProduto.Text);
            }
            else
            {
                listaMercadorias(textProduto.Text,res);

            }
        } // Ao pesquisar mercadorias
        private void PesquisaMercadoAsync(object sender, DoWorkEventArgs e)
        {
            e.Result = conecta.Consulta(query);
            Console.WriteLine(query);
        } // Pesquisa mercadoria assincronamente
        private void PesquisaMercadoAsyncCompleta(object sender, RunWorkerCompletedEventArgs e)
        {
            gridMercadorias.DataSource = e.Result;
            gridMercadorias.Columns["MERCADORIA"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btMercadoriaPesquisa.Text = "Pesquisar";
            btMercadoriaPesquisa.Enabled = true;
            ConsultaNumLinhas.Text = gridMercadorias.RowCount + " encontradas (max:500)";
            textProduto.SelectAll();
        } // ao finalizar a busca assincrona, exibe o resultado
        private void gridMercadorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                produto = new Produto(gridMercadorias.Rows[e.RowIndex].Cells["material"].Value.ToString(), gridMercadorias.Rows[e.RowIndex].Cells["serie"].Value.ToString(), Convert.ToInt32(gridMercadorias.Rows[e.RowIndex].Cells["Filial"].Value), conecta);

            }
        }
    }
}
