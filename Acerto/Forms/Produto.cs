using Consulta.utilitarios;
using System;
using System.Data;
using System.Windows.Forms;

namespace Acerto
{
    partial class Produto : Form
    {
        private string serie { get; set; }
        private string material { get; set; }
        private int filial { get; set; }
        private DataTable dadosProduto = new DataTable();
        private OracleConexao conecta;
        public Produto(string material, string serie, int filial, OracleConexao conecta)
        {
            Initialize(material, serie, filial);
            this.conecta = conecta;
            Show();
        }  // Construtor Oracle
        private void Produto_Load(object sender, EventArgs e)
        {
            // Busca os dados
            MostraHistorico(conecta);
            MostraSaldo(conecta);
            DetalhesProduto(conecta);
            VerificaErrosProcessamento(conecta);
            // Aplicando os labels e texts
            prodMaterial.Text = material;
            prodSerie.Text = serie;
            prodFilial.Text = filial.ToString();
            Text = filial + " | " + material + " | " + serie;
            prodDescr.Text = Eduardo.UpperFirst(prodDescr.Text);

        }
        private void Initialize(string material, string serie, int filial)
        {
            InitializeComponent();
            this.serie = serie;
            this.material = material;
            this.filial = filial;

        } // Inicio padrão para o construtor desta classe
        // HISTORICOS
        private void MostraHistorico(OracleConexao conecta)
        {
            string query = "select mov_dat Data, mov_seo Origem, mov_sed Destino,TIP_DES Tipo, mov_doc nf,MOV_CDEMP cpf_cnpj, MOV_CDVDR Vendedor, MOV_VAL Valor from movimento, TIPMOV where mov_ref = '" + material + "' and mov_ser = '" + serie + "' and mov_tip = TIP_COD order by mov_dat";
            ProdGridHist.DataSource = conecta.Consulta(query);
            // Loop para verificação e ajuste
            foreach (DataGridViewRow row in ProdGridHist.Rows)
            {
                // Muda para Checkin o Tipo
                if (row.Cells["Origem"].Value.ToString() == "98" && row.Cells["Destino"].Value.ToString() != "98")
                {
                    row.Cells["Tipo"].Value = "Check-in";
                }
                if (row.Cells["nf"].Value.ToString() == "opc9")
                { // Tem opção 9
                    string query2 = "select mov_ser serie, mov_dat from MOVIMENTO where mov_dat = TO_DATE('" + row.Cells["Data"].Value.ToString() + "', 'DD/MM/YYYY HH24:MI:SS')" +
                    " and mov_ser != '" + serie + "'";
                    DataTable retquery2 = new DataTable();
                    retquery2 = conecta.Consulta(query2);
                    //  Console.WriteLine(retquery2.Rows[0]["serie"] + "é essa");
                    if (row.Cells["TIPO"].Value.ToString() == "Vendas")
                    {
                        row.Cells["TIPO"].Value = "Sai. por " + retquery2.Rows[0]["serie"];
                    }
                    else if (row.Cells["TIPO"].Value.ToString() == "Devolução de Vendas ")
                    {
                        row.Cells["TIPO"].Value = "Entra. por " + retquery2.Rows[0]["serie"];
                    }
                }
            }
        } // tabela de historico do produto oracle MOVIMENTO
        //SALDOS
        private void MostraSaldo(OracleConexao conecta)
        {
            string query = "select est_set Filial, est_sal saldo, est_tam tamanho from estoques where est_ref = '" + material + "' and est_ser = '" + (serie).Trim() + "'";
            prodGridSaldos.DataSource = conecta.Consulta(query);
        } // Tabela dos ESTOQUES
        // DADOS DO PRODUTO
        private void DetalhesProduto(OracleConexao conecta)
        {
            string query = "select * from MERCADORIAS where MERCADO_COD = '" + material + "'";
            dadosProduto = conecta.Consulta(query);
            prodDescr.Text = dadosProduto.Rows[0].Field<string>("MERCADO_DES").ToLower();
            anoEst.Text = dadosProduto.Rows[0].Field<string>("MERCADO_ANOEST");
            subGrp.Text = dadosProduto.Rows[0].Field<string>("MERCADO_SGRP");
            prodGrp.Text = dadosProduto.Rows[0].Field<string>("MERCADO_GRP");
        } // Detalhes do produto tabela MERCADORIAS
        // Verifica erros de processamento
        private void VerificaErrosProcessamento(OracleConexao conecta)
        {
            string query = "select movestdat Data, movestseo Origem, movestsed Destino, movesttip Tipo, movestref Material, movestser Serie, movestncf Nf, me_log Processamento from me where me_est is null and movestref = '" + material + "' and movestser = '" + serie + "'";
            DataTable errosProc = new DataTable();
            errosProc = conecta.Consulta(query);
            if (errosProc.Rows.Count > 0)
            {
                lblErrProc.Text = "Erro de processamento em: " + errosProc.Rows[0]["Data"].ToString().Replace("00:00:00","") + " Nota: " + errosProc.Rows[0]["NF"] + " - " + errosProc.Rows[0]["Processamento"].ToString();
            }
            else
            {
                lblErrProc.Text = "";
            }
        }
        // Eventos do FORM
        private void Produto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        } // ao fechar a janela     
    }
}


//private MysqlConexao conecta;
//private void MostraSaldo(MysqlConexao conecta)
//{
//    string query = "SELECT  DATE_FORMAT(dataHora,'%d/%m/%Y %h:%i') as Data,descricao FROM produto,historico WHERE produto_idProduto = produto.idProduto and material =" + material;
//    prodGridSaldos.DataSource = conecta.Consulta(query);
//}
//private void MostraHistorico(MysqlConexao conecta)
//{
//    string query = "select * from produto";
//    ProdGridHist.DataSource = conecta.Consulta(query);
//} // tabela de historico do produto mysql
//public Produto(string material, string serie, int filial, MysqlConexao conecta)
//{
//    Initialize(material, serie, filial);
//    //this.conecta = conecta;
//    Show();
//}  // Construtor Mysql