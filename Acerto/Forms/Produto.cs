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
        private DataTable dadosProduto = new DataTable() ;
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
            // Aplicando os labels e texts
            prodMaterial.Text = material;
            prodSerie.Text = serie;
            prodFilial.Text = filial.ToString();
            Text = filial + " | " + material + " | " + serie;
            prodDescr.Text = dadosProduto.Rows[0].Field<string>("MERCADO_DES").ToLower();
            anoEst.Text = dadosProduto.Rows[0].Field<string>("MERCADO_ANOEST");
            subGrp.Text = dadosProduto.Rows[0].Field<string>("MERCADO_SGRP");
            prodGrp.Text = dadosProduto.Rows[0].Field<string>("MERCADO_GRP");
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
            string query = "select mov_dat Data, mov_seo Origem, mov_sed Destino,TIP_DES Tipo, mov_doc nf,MOV_CDEMP cpf_cnpj, MOV_CDVDR Vendedor, MOV_VAL Valor from movimento, TIPMOV where mov_ref = '" + material+"' and mov_ser = '"+serie+"' and mov_tip = TIP_COD order by mov_dat";
            ProdGridHist.DataSource = conecta.Consulta(query);
        } // tabela de historico do produto oracle MOVIMENTO
        //SALDOS
        private void MostraSaldo(OracleConexao conecta) {
            string query = "select est_set Filial, est_sal saldo, est_tam tamanho from estoques where est_ref = '"+material+"' and est_ser = '"+ (serie).Trim()+"'";
            prodGridSaldos.DataSource = conecta.Consulta(query);
        } // Tabela dos ESTOQUES
        // DADOS DO PRODUTO
        private void DetalhesProduto(OracleConexao conecta)
        {
            string query = "select * from MERCADORIAS where MERCADO_COD = '"+material+"'";
            dadosProduto = conecta.Consulta(query);
            foreach (var coluna in dadosProduto.Columns)
            {
                Console.WriteLine(coluna+ " : "+dadosProduto.Rows[0][coluna.ToString()]);
            }
        } // Detalhes do produto tabela MERCADORIAS
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