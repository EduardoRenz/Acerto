using System;
using System.Windows.Forms;

namespace Acerto
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.divTopo = new System.Windows.Forms.FlowLayoutPanel();
            this.painelPesquisa = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkVendas = new System.Windows.Forms.CheckBox();
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.grpCondi = new System.Windows.Forms.Panel();
            this.btCorrigir = new System.Windows.Forms.Button();
            this.condLabel = new System.Windows.Forms.Label();
            this.splitterErros = new System.Windows.Forms.Splitter();
            this.panelPesquisa = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.pesquisar = new System.Windows.Forms.NumericUpDown();
            this.lblFilial = new System.Windows.Forms.Label();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblConexao = new System.Windows.Forms.Label();
            this.topo = new System.Windows.Forms.FlowLayoutPanel();
            this.menuConsulta = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConsultaFilial = new System.Windows.Forms.Label();
            this.consFilial = new System.Windows.Forms.NumericUpDown();
            this.lblConsultaSerie = new System.Windows.Forms.Label();
            this.txtConsultaSerie = new System.Windows.Forms.TextBox();
            this.lblConsultaMaterial = new System.Windows.Forms.Label();
            this.txtConsultaMaterial = new System.Windows.Forms.TextBox();
            this.btConsultaPesquisar = new System.Windows.Forms.Button();
            this.txtProcessos = new System.Windows.Forms.RichTextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.tabelaNProc = new System.Windows.Forms.DataGridView();
            this.lblnaoproc = new System.Windows.Forms.Label();
            this.divCentro = new System.Windows.Forms.TableLayoutPanel();
            this.abas = new System.Windows.Forms.TabControl();
            this.pagErros = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridConsulta = new System.Windows.Forms.DataGridView();
            this.grpCondi.SuspendLayout();
            this.panelPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).BeginInit();
            this.topo.SuspendLayout();
            this.menuConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).BeginInit();
            this.divCentro.SuspendLayout();
            this.abas.SuspendLayout();
            this.pagErros.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // divTopo
            // 
            this.divTopo.AutoSize = true;
            this.divTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.divTopo.Location = new System.Drawing.Point(0, 0);
            this.divTopo.Name = "divTopo";
            this.divTopo.Size = new System.Drawing.Size(1456, 0);
            this.divTopo.TabIndex = 1;
            // 
            // painelPesquisa
            // 
            this.painelPesquisa.Location = new System.Drawing.Point(0, 0);
            this.painelPesquisa.Name = "painelPesquisa";
            this.painelPesquisa.Size = new System.Drawing.Size(100, 20);
            this.painelPesquisa.TabIndex = 0;
            // 
            // chkVendas
            // 
            this.chkVendas.AutoSize = true;
            this.chkVendas.Location = new System.Drawing.Point(76, 7);
            this.chkVendas.Margin = new System.Windows.Forms.Padding(0);
            this.chkVendas.Name = "chkVendas";
            this.chkVendas.Size = new System.Drawing.Size(62, 17);
            this.chkVendas.TabIndex = 5;
            this.chkVendas.Text = "Vendas";
            this.toolTip.SetToolTip(this.chkVendas, "Ira corrigir Vendas pendentes se não houver saldo, e o ano for 2014");
            this.chkVendas.UseVisualStyleBackColor = true;
            // 
            // chkTrans
            // 
            this.chkTrans.AutoSize = true;
            this.chkTrans.Location = new System.Drawing.Point(144, 8);
            this.chkTrans.Margin = new System.Windows.Forms.Padding(0);
            this.chkTrans.Name = "chkTrans";
            this.chkTrans.Size = new System.Drawing.Size(96, 17);
            this.chkTrans.TabIndex = 6;
            this.chkTrans.Text = "Transferências";
            this.toolTip.SetToolTip(this.chkTrans, "Ira substituir por outra serie com ano 2014");
            this.chkTrans.UseVisualStyleBackColor = true;
            // 
            // grpCondi
            // 
            this.grpCondi.Controls.Add(this.btCorrigir);
            this.grpCondi.Controls.Add(this.chkTrans);
            this.grpCondi.Controls.Add(this.chkVendas);
            this.grpCondi.Controls.Add(this.condLabel);
            this.grpCondi.Location = new System.Drawing.Point(674, 5);
            this.grpCondi.Margin = new System.Windows.Forms.Padding(0);
            this.grpCondi.Name = "grpCondi";
            this.grpCondi.Size = new System.Drawing.Size(356, 31);
            this.grpCondi.TabIndex = 0;
            // 
            // btCorrigir
            // 
            this.btCorrigir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCorrigir.Location = new System.Drawing.Point(250, 1);
            this.btCorrigir.Margin = new System.Windows.Forms.Padding(0);
            this.btCorrigir.Name = "btCorrigir";
            this.btCorrigir.Size = new System.Drawing.Size(106, 25);
            this.btCorrigir.TabIndex = 2;
            this.btCorrigir.Text = "Corrigir";
            this.btCorrigir.UseVisualStyleBackColor = true;
            this.btCorrigir.Click += new System.EventHandler(this.btCorrigir_Click);
            // 
            // condLabel
            // 
            this.condLabel.AutoSize = true;
            this.condLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.condLabel.Location = new System.Drawing.Point(3, 6);
            this.condLabel.Name = "condLabel";
            this.condLabel.Size = new System.Drawing.Size(67, 17);
            this.condLabel.TabIndex = 4;
            this.condLabel.Text = "Corrigir:";
            // 
            // splitterErros
            // 
            this.splitterErros.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitterErros.Location = new System.Drawing.Point(673, 8);
            this.splitterErros.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.splitterErros.Name = "splitterErros";
            this.splitterErros.Size = new System.Drawing.Size(1, 25);
            this.splitterErros.TabIndex = 6;
            this.splitterErros.TabStop = false;
            // 
            // panelPesquisa
            // 
            this.panelPesquisa.Controls.Add(this.lblA);
            this.panelPesquisa.Controls.Add(this.dataFim);
            this.panelPesquisa.Controls.Add(this.dataInicio);
            this.panelPesquisa.Controls.Add(this.lblData);
            this.panelPesquisa.Controls.Add(this.pesquisar);
            this.panelPesquisa.Controls.Add(this.lblFilial);
            this.panelPesquisa.Controls.Add(this.btPesquisa);
            this.panelPesquisa.Location = new System.Drawing.Point(143, 5);
            this.panelPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.panelPesquisa.Name = "panelPesquisa";
            this.panelPesquisa.Size = new System.Drawing.Size(524, 31);
            this.panelPesquisa.TabIndex = 5;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(289, 4);
            this.lblA.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 17);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "a";
            // 
            // dataFim
            // 
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFim.Location = new System.Drawing.Point(312, 5);
            this.dataFim.Margin = new System.Windows.Forms.Padding(0);
            this.dataFim.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dataFim.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(100, 20);
            this.dataFim.TabIndex = 8;
            this.dataFim.Value = new System.DateTime(2015, 8, 1, 0, 0, 0, 0);
            // 
            // dataInicio
            // 
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(180, 5);
            this.dataInicio.Margin = new System.Windows.Forms.Padding(0);
            this.dataInicio.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dataInicio.MinDate = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(103, 20);
            this.dataInicio.TabIndex = 7;
            this.dataInicio.Value = new System.DateTime(2015, 7, 1, 0, 0, 0, 0);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(127, 6);
            this.lblData.Margin = new System.Windows.Forms.Padding(0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 17);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // pesquisar
            // 
            this.pesquisar.Location = new System.Drawing.Point(56, 5);
            this.pesquisar.Margin = new System.Windows.Forms.Padding(0);
            this.pesquisar.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.pesquisar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(65, 20);
            this.pesquisar.TabIndex = 5;
            this.pesquisar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFilial.Location = new System.Drawing.Point(3, 6);
            this.lblFilial.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(47, 17);
            this.lblFilial.TabIndex = 3;
            this.lblFilial.Text = "Filial:";
            // 
            // btPesquisa
            // 
            this.btPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisa.Location = new System.Drawing.Point(418, 3);
            this.btPesquisa.Margin = new System.Windows.Forms.Padding(0);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(106, 23);
            this.btPesquisa.TabIndex = 1;
            this.btPesquisa.Text = "Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(139, 8);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1, 25);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblConexao.Location = new System.Drawing.Point(8, 5);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(125, 31);
            this.lblConexao.TabIndex = 0;
            this.lblConexao.Text = "Desconectado";
            this.lblConexao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // topo
            // 
            this.topo.AutoSize = true;
            this.topo.Controls.Add(this.lblConexao);
            this.topo.Controls.Add(this.splitter1);
            this.topo.Controls.Add(this.panelPesquisa);
            this.topo.Controls.Add(this.splitterErros);
            this.topo.Controls.Add(this.grpCondi);
            this.topo.Controls.Add(this.menuConsulta);
            this.topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.topo.Location = new System.Drawing.Point(0, 0);
            this.topo.Margin = new System.Windows.Forms.Padding(0);
            this.topo.Name = "topo";
            this.topo.Padding = new System.Windows.Forms.Padding(5);
            this.topo.Size = new System.Drawing.Size(1456, 74);
            this.topo.TabIndex = 4;
            // 
            // menuConsulta
            // 
            this.menuConsulta.Controls.Add(this.lblConsultaFilial);
            this.menuConsulta.Controls.Add(this.consFilial);
            this.menuConsulta.Controls.Add(this.lblConsultaMaterial);
            this.menuConsulta.Controls.Add(this.txtConsultaMaterial);
            this.menuConsulta.Controls.Add(this.lblConsultaSerie);
            this.menuConsulta.Controls.Add(this.txtConsultaSerie);
            this.menuConsulta.Controls.Add(this.btConsultaPesquisar);
            this.menuConsulta.Location = new System.Drawing.Point(5, 38);
            this.menuConsulta.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Size = new System.Drawing.Size(588, 31);
            this.menuConsulta.TabIndex = 7;
            this.menuConsulta.Visible = false;
            // 
            // lblConsultaFilial
            // 
            this.lblConsultaFilial.AutoSize = true;
            this.lblConsultaFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblConsultaFilial.Location = new System.Drawing.Point(3, 4);
            this.lblConsultaFilial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lblConsultaFilial.Name = "lblConsultaFilial";
            this.lblConsultaFilial.Size = new System.Drawing.Size(47, 17);
            this.lblConsultaFilial.TabIndex = 6;
            this.lblConsultaFilial.Text = "Filial:";
            // 
            // consFilial
            // 
            this.consFilial.Location = new System.Drawing.Point(56, 3);
            this.consFilial.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.consFilial.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.consFilial.Name = "consFilial";
            this.consFilial.Size = new System.Drawing.Size(65, 20);
            this.consFilial.TabIndex = 7;
            this.consFilial.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblConsultaSerie
            // 
            this.lblConsultaSerie.AutoSize = true;
            this.lblConsultaSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblConsultaSerie.Location = new System.Drawing.Point(309, 4);
            this.lblConsultaSerie.Margin = new System.Windows.Forms.Padding(2, 4, 3, 0);
            this.lblConsultaSerie.Name = "lblConsultaSerie";
            this.lblConsultaSerie.Size = new System.Drawing.Size(51, 17);
            this.lblConsultaSerie.TabIndex = 8;
            this.lblConsultaSerie.Text = "Serie:";
            // 
            // txtConsultaSerie
            // 
            this.txtConsultaSerie.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConsultaSerie.Location = new System.Drawing.Point(363, 3);
            this.txtConsultaSerie.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.txtConsultaSerie.MaxLength = 6;
            this.txtConsultaSerie.Name = "txtConsultaSerie";
            this.txtConsultaSerie.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaSerie.TabIndex = 9;
            // 
            // lblConsultaMaterial
            // 
            this.lblConsultaMaterial.AutoSize = true;
            this.lblConsultaMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblConsultaMaterial.Location = new System.Drawing.Point(127, 4);
            this.lblConsultaMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lblConsultaMaterial.Name = "lblConsultaMaterial";
            this.lblConsultaMaterial.Size = new System.Drawing.Size(71, 17);
            this.lblConsultaMaterial.TabIndex = 10;
            this.lblConsultaMaterial.Text = "Material:";
            // 
            // txtConsultaMaterial
            // 
            this.txtConsultaMaterial.Location = new System.Drawing.Point(204, 3);
            this.txtConsultaMaterial.MaxLength = 8;
            this.txtConsultaMaterial.Name = "txtConsultaMaterial";
            this.txtConsultaMaterial.Size = new System.Drawing.Size(100, 20);
            this.txtConsultaMaterial.TabIndex = 11;
            // 
            // btConsultaPesquisar
            // 
            this.btConsultaPesquisar.Location = new System.Drawing.Point(467, 1);
            this.btConsultaPesquisar.Margin = new System.Windows.Forms.Padding(4, 1, 0, 0);
            this.btConsultaPesquisar.Name = "btConsultaPesquisar";
            this.btConsultaPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btConsultaPesquisar.TabIndex = 12;
            this.btConsultaPesquisar.Text = "Pesquisar";
            this.btConsultaPesquisar.UseVisualStyleBackColor = true;
            this.btConsultaPesquisar.Click += new System.EventHandler(this.btConsultaPesquisar_Click);
            // 
            // txtProcessos
            // 
            this.txtProcessos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProcessos.Location = new System.Drawing.Point(724, 28);
            this.txtProcessos.Name = "txtProcessos";
            this.txtProcessos.ReadOnly = true;
            this.txtProcessos.Size = new System.Drawing.Size(710, 610);
            this.txtProcessos.TabIndex = 3;
            this.txtProcessos.Text = "";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(724, 8);
            this.lblResults.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(88, 17);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Processos:";
            // 
            // tabelaNProc
            // 
            this.tabelaNProc.AllowUserToAddRows = false;
            this.tabelaNProc.AllowUserToDeleteRows = false;
            this.tabelaNProc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelaNProc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tabelaNProc.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaNProc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaNProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaNProc.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaNProc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelaNProc.Location = new System.Drawing.Point(8, 28);
            this.tabelaNProc.Name = "tabelaNProc";
            this.tabelaNProc.ReadOnly = true;
            this.tabelaNProc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tabelaNProc.Size = new System.Drawing.Size(710, 610);
            this.tabelaNProc.TabIndex = 5;
            // 
            // lblnaoproc
            // 
            this.lblnaoproc.AutoSize = true;
            this.lblnaoproc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblnaoproc.Location = new System.Drawing.Point(8, 8);
            this.lblnaoproc.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblnaoproc.Name = "lblnaoproc";
            this.lblnaoproc.Size = new System.Drawing.Size(140, 17);
            this.lblnaoproc.TabIndex = 0;
            this.lblnaoproc.Text = "Não Processadas:";
            // 
            // divCentro
            // 
            this.divCentro.ColumnCount = 2;
            this.divCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.divCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.divCentro.Controls.Add(this.lblResults, 1, 0);
            this.divCentro.Controls.Add(this.txtProcessos, 1, 1);
            this.divCentro.Controls.Add(this.lblnaoproc, 0, 0);
            this.divCentro.Controls.Add(this.tabelaNProc, 0, 1);
            this.divCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divCentro.Location = new System.Drawing.Point(3, 3);
            this.divCentro.Name = "divCentro";
            this.divCentro.Padding = new System.Windows.Forms.Padding(5);
            this.divCentro.RowCount = 2;
            this.divCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.divCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.divCentro.Size = new System.Drawing.Size(1442, 646);
            this.divCentro.TabIndex = 6;
            // 
            // abas
            // 
            this.abas.Controls.Add(this.pagErros);
            this.abas.Controls.Add(this.tabPage2);
            this.abas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abas.Location = new System.Drawing.Point(0, 74);
            this.abas.Margin = new System.Windows.Forms.Padding(0);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(1456, 678);
            this.abas.TabIndex = 7;
            this.abas.Selected += new System.Windows.Forms.TabControlEventHandler(this.abas_changed);
            // 
            // pagErros
            // 
            this.pagErros.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pagErros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pagErros.Controls.Add(this.divCentro);
            this.pagErros.Location = new System.Drawing.Point(4, 22);
            this.pagErros.Margin = new System.Windows.Forms.Padding(0);
            this.pagErros.Name = "pagErros";
            this.pagErros.Padding = new System.Windows.Forms.Padding(3);
            this.pagErros.Size = new System.Drawing.Size(1448, 652);
            this.pagErros.TabIndex = 0;
            this.pagErros.Text = "Erros de Processamento";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage2.Controls.Add(this.gridConsulta);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1448, 652);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Mercadorias";
            // 
            // gridConsulta
            // 
            this.gridConsulta.AllowUserToAddRows = false;
            this.gridConsulta.AllowUserToOrderColumns = true;
            this.gridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridConsulta.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 0);
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.ReadOnly = true;
            this.gridConsulta.Size = new System.Drawing.Size(1448, 652);
            this.gridConsulta.TabIndex = 0;
            this.gridConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsulta_CellDoubleClick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1456, 752);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.topo);
            this.Controls.Add(this.divTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.Text = "Acerto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCondi.ResumeLayout(false);
            this.grpCondi.PerformLayout();
            this.panelPesquisa.ResumeLayout(false);
            this.panelPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).EndInit();
            this.topo.ResumeLayout(false);
            this.topo.PerformLayout();
            this.menuConsulta.ResumeLayout(false);
            this.menuConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consFilial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).EndInit();
            this.divCentro.ResumeLayout(false);
            this.divCentro.PerformLayout();
            this.abas.ResumeLayout(false);
            this.pagErros.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

  
        #endregion
        private System.Windows.Forms.FlowLayoutPanel divTopo;
        private System.Windows.Forms.TextBox painelPesquisa;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel grpCondi;
        private System.Windows.Forms.Button btCorrigir;
        private System.Windows.Forms.CheckBox chkTrans;
        private System.Windows.Forms.CheckBox chkVendas;
        private System.Windows.Forms.Label condLabel;
        private System.Windows.Forms.Splitter splitterErros;
        private System.Windows.Forms.Panel panelPesquisa;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.NumericUpDown pesquisar;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.FlowLayoutPanel topo;
        private System.Windows.Forms.Label lblnaoproc;
        private System.Windows.Forms.DataGridView tabelaNProc;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.RichTextBox txtProcessos;
        private System.Windows.Forms.TableLayoutPanel divCentro;
        private System.Windows.Forms.TabControl abas;
        private System.Windows.Forms.TabPage pagErros;
        private System.Windows.Forms.TabPage tabPage2;
        private FlowLayoutPanel menuConsulta;
        private Label lblConsultaFilial;
        private NumericUpDown consFilial;
        private Label lblConsultaSerie;
        private TextBox txtConsultaSerie;
        private Label lblConsultaMaterial;
        private TextBox txtConsultaMaterial;
        private Button btConsultaPesquisar;
        private DataGridView gridConsulta;
    }
}

