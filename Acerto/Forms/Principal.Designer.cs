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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.divTopo = new System.Windows.Forms.FlowLayoutPanel();
            this.painelPesquisa = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkVendas = new System.Windows.Forms.CheckBox();
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.intFilial = new System.Windows.Forms.NumericUpDown();
            this.lblFilial = new System.Windows.Forms.Label();
            this.grpCondi = new System.Windows.Forms.Panel();
            this.btCorrigir = new System.Windows.Forms.Button();
            this.condLabel = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.dataFim = new System.Windows.Forms.DateTimePicker();
            this.dataInicio = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.btPesquisa = new System.Windows.Forms.Button();
            this.topo = new System.Windows.Forms.FlowLayoutPanel();
            this.painelFilial = new System.Windows.Forms.FlowLayoutPanel();
            this.splseparator = new System.Windows.Forms.Splitter();
            this.menuConsulta = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConsultaMaterial = new System.Windows.Forms.Label();
            this.lblCodProd = new System.Windows.Forms.TextBox();
            this.btConsultaPesquisar = new System.Windows.Forms.Button();
            this.panelDatas = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.mercadoriaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textProduto = new System.Windows.Forms.TextBox();
            this.ConsultaNumLinhas = new System.Windows.Forms.Label();
            this.tabelaNProc = new System.Windows.Forms.DataGridView();
            this.lblnaoproc = new System.Windows.Forms.Label();
            this.divCentro = new System.Windows.Forms.TableLayoutPanel();
            this.abas = new System.Windows.Forms.TabControl();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.gridConsulta = new System.Windows.Forms.DataGridView();
            this.pagErros = new System.Windows.Forms.TabPage();
            this.tabMercadorias = new System.Windows.Forms.TabPage();
            this.listaMercadorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.intFilial)).BeginInit();
            this.grpCondi.SuspendLayout();
            this.topo.SuspendLayout();
            this.painelFilial.SuspendLayout();
            this.menuConsulta.SuspendLayout();
            this.panelDatas.SuspendLayout();
            this.mercadoriaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).BeginInit();
            this.divCentro.SuspendLayout();
            this.abas.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            this.pagErros.SuspendLayout();
            this.tabMercadorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMercadorias)).BeginInit();
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
            this.chkVendas.Location = new System.Drawing.Point(76, 4);
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
            this.chkTrans.Location = new System.Drawing.Point(144, 4);
            this.chkTrans.Margin = new System.Windows.Forms.Padding(0);
            this.chkTrans.Name = "chkTrans";
            this.chkTrans.Size = new System.Drawing.Size(96, 17);
            this.chkTrans.TabIndex = 6;
            this.chkTrans.Text = "Transferências";
            this.toolTip.SetToolTip(this.chkTrans, "Ira substituir por outra serie com ano 2014");
            this.chkTrans.UseVisualStyleBackColor = true;
            // 
            // intFilial
            // 
            this.intFilial.Location = new System.Drawing.Point(47, 6);
            this.intFilial.Margin = new System.Windows.Forms.Padding(0);
            this.intFilial.Maximum = new decimal(new int[] {
            61,
            0,
            0,
            0});
            this.intFilial.Name = "intFilial";
            this.intFilial.Size = new System.Drawing.Size(65, 20);
            this.intFilial.TabIndex = 1;
            this.toolTip.SetToolTip(this.intFilial, "0 = Todas as Filiais");
            // 
            // lblFilial
            // 
            this.lblFilial.AutoSize = true;
            this.lblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblFilial.Location = new System.Drawing.Point(0, 6);
            this.lblFilial.Margin = new System.Windows.Forms.Padding(0);
            this.lblFilial.Name = "lblFilial";
            this.lblFilial.Size = new System.Drawing.Size(47, 17);
            this.lblFilial.TabIndex = 0;
            this.lblFilial.Text = "Filial:";
            this.toolTip.SetToolTip(this.lblFilial, "0 = Todas as Filiais");
            // 
            // grpCondi
            // 
            this.grpCondi.Controls.Add(this.btCorrigir);
            this.grpCondi.Controls.Add(this.chkTrans);
            this.grpCondi.Controls.Add(this.chkVendas);
            this.grpCondi.Controls.Add(this.condLabel);
            this.grpCondi.Location = new System.Drawing.Point(0, 29);
            this.grpCondi.Margin = new System.Windows.Forms.Padding(0);
            this.grpCondi.Name = "grpCondi";
            this.grpCondi.Size = new System.Drawing.Size(356, 23);
            this.grpCondi.TabIndex = 8;
            this.grpCondi.Visible = false;
          
            // 
            // condLabel
            // 
            this.condLabel.AutoSize = true;
            this.condLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.condLabel.Location = new System.Drawing.Point(3, 1);
            this.condLabel.Name = "condLabel";
            this.condLabel.Size = new System.Drawing.Size(67, 17);
            this.condLabel.TabIndex = 4;
            this.condLabel.Text = "Corrigir:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(162, 6);
            this.lblA.Margin = new System.Windows.Forms.Padding(0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 17);
            this.lblA.TabIndex = 9;
            this.lblA.Text = "a";
            // 
            // dataFim
            // 
            this.dataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFim.Location = new System.Drawing.Point(179, 6);
            this.dataFim.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dataFim.Name = "dataFim";
            this.dataFim.Size = new System.Drawing.Size(100, 20);
            this.dataFim.TabIndex = 3;
            this.dataFim.Value = new System.DateTime(2015, 11, 24, 0, 0, 0, 0);
            // 
            // dataInicio
            // 
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(56, 6);
            this.dataInicio.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(103, 20);
            this.dataInicio.TabIndex = 2;
            this.dataInicio.Value = new System.DateTime(2015, 10, 24, 10, 48, 49, 957);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(6, 6);
            this.lblData.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 17);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // btPesquisa
            // 
            this.btPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisa.Location = new System.Drawing.Point(282, 6);
            this.btPesquisa.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btPesquisa.Name = "btPesquisa";
            this.btPesquisa.Size = new System.Drawing.Size(97, 20);
            this.btPesquisa.TabIndex = 4;
            this.btPesquisa.Text = "Pesquisar";
            this.btPesquisa.UseVisualStyleBackColor = true;
            this.btPesquisa.Click += new System.EventHandler(this.btPesquisa_Click);
            // 
            // topo
            // 
            this.topo.AutoSize = true;
            this.topo.Controls.Add(this.painelFilial);
            this.topo.Controls.Add(this.menuConsulta);
            this.topo.Controls.Add(this.panelDatas);
            this.topo.Controls.Add(this.mercadoriaPanel);
            this.topo.Controls.Add(this.ConsultaNumLinhas);
            this.topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.topo.Location = new System.Drawing.Point(0, 0);
            this.topo.Margin = new System.Windows.Forms.Padding(0);
            this.topo.Name = "topo";
            this.topo.Padding = new System.Windows.Forms.Padding(5);
            this.topo.Size = new System.Drawing.Size(1456, 41);
            this.topo.TabIndex = 4;
            // 
            // painelFilial
            // 
            this.painelFilial.Controls.Add(this.lblFilial);
            this.painelFilial.Controls.Add(this.intFilial);
            this.painelFilial.Controls.Add(this.splseparator);
            this.painelFilial.Location = new System.Drawing.Point(5, 5);
            this.painelFilial.Margin = new System.Windows.Forms.Padding(0);
            this.painelFilial.Name = "painelFilial";
            this.painelFilial.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.painelFilial.Size = new System.Drawing.Size(128, 31);
            this.painelFilial.TabIndex = 0;
            // 
            // splseparator
            // 
            this.splseparator.BackColor = System.Drawing.SystemColors.Desktop;
            this.splseparator.Location = new System.Drawing.Point(122, 9);
            this.splseparator.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.splseparator.Name = "splseparator";
            this.splseparator.Size = new System.Drawing.Size(1, 14);
            this.splseparator.TabIndex = 6;
            this.splseparator.TabStop = false;
            // 
            // menuConsulta
            // 
            this.menuConsulta.Controls.Add(this.lblConsultaMaterial);
            this.menuConsulta.Controls.Add(this.lblCodProd);
            this.menuConsulta.Controls.Add(this.btConsultaPesquisar);
            this.menuConsulta.Location = new System.Drawing.Point(133, 5);
            this.menuConsulta.Margin = new System.Windows.Forms.Padding(0);
            this.menuConsulta.Name = "menuConsulta";
            this.menuConsulta.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.menuConsulta.Size = new System.Drawing.Size(438, 31);
            this.menuConsulta.TabIndex = 4;
            this.menuConsulta.Visible = false;
            // 
            // lblConsultaMaterial
            // 
            this.lblConsultaMaterial.AutoSize = true;
            this.lblConsultaMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblConsultaMaterial.Location = new System.Drawing.Point(3, 6);
            this.lblConsultaMaterial.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblConsultaMaterial.Name = "lblConsultaMaterial";
            this.lblConsultaMaterial.Size = new System.Drawing.Size(114, 17);
            this.lblConsultaMaterial.TabIndex = 10;
            this.lblConsultaMaterial.Text = "Material/Serie:";
            // 
            // lblCodProd
            // 
            this.lblCodProd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lblCodProd.Location = new System.Drawing.Point(120, 6);
            this.lblCodProd.Margin = new System.Windows.Forms.Padding(0);
            this.lblCodProd.Name = "lblCodProd";
            this.lblCodProd.Size = new System.Drawing.Size(205, 20);
            this.lblCodProd.TabIndex = 15;
            // 
            // btConsultaPesquisar
            // 
            this.btConsultaPesquisar.Location = new System.Drawing.Point(328, 6);
            this.btConsultaPesquisar.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btConsultaPesquisar.Name = "btConsultaPesquisar";
            this.btConsultaPesquisar.Size = new System.Drawing.Size(97, 20);
            this.btConsultaPesquisar.TabIndex = 4;
            this.btConsultaPesquisar.Text = "Pesquisar";
            this.btConsultaPesquisar.UseVisualStyleBackColor = true;
            this.btConsultaPesquisar.Click += new System.EventHandler(this.btConsultaPesquisar_Click);
            // 
            // panelDatas
            // 
            this.panelDatas.Controls.Add(this.label3);
            this.panelDatas.Controls.Add(this.lblData);
            this.panelDatas.Controls.Add(this.dataInicio);
            this.panelDatas.Controls.Add(this.lblA);
            this.panelDatas.Controls.Add(this.dataFim);
            this.panelDatas.Controls.Add(this.btPesquisa);
            this.panelDatas.Controls.Add(this.grpCondi);
            this.panelDatas.Location = new System.Drawing.Point(571, 5);
            this.panelDatas.Margin = new System.Windows.Forms.Padding(0);
            this.panelDatas.Name = "panelDatas";
            this.panelDatas.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.panelDatas.Size = new System.Drawing.Size(382, 31);
            this.panelDatas.TabIndex = 2;
            this.panelDatas.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 14;
            // 
            // mercadoriaPanel
            // 
            this.mercadoriaPanel.AutoSize = true;
            this.mercadoriaPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mercadoriaPanel.Controls.Add(this.label1);
            this.mercadoriaPanel.Controls.Add(this.textProduto);
            this.mercadoriaPanel.Location = new System.Drawing.Point(953, 5);
            this.mercadoriaPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mercadoriaPanel.Name = "mercadoriaPanel";
            this.mercadoriaPanel.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.mercadoriaPanel.Size = new System.Drawing.Size(281, 26);
            this.mercadoriaPanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Produto:";
            // 
            // textProduto
            // 
            this.textProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textProduto.Location = new System.Drawing.Point(76, 6);
            this.textProduto.Margin = new System.Windows.Forms.Padding(0);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(205, 20);
            this.textProduto.TabIndex = 17;
            // 
            // ConsultaNumLinhas
            // 
            this.ConsultaNumLinhas.AutoSize = true;
            this.ConsultaNumLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaNumLinhas.ForeColor = System.Drawing.SystemColors.Control;
            this.ConsultaNumLinhas.Location = new System.Drawing.Point(1237, 11);
            this.ConsultaNumLinhas.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.ConsultaNumLinhas.Name = "ConsultaNumLinhas";
            this.ConsultaNumLinhas.Size = new System.Drawing.Size(131, 18);
            this.ConsultaNumLinhas.TabIndex = 14;
            this.ConsultaNumLinhas.Text = "0 = Todas as filiais";
            // 
            // tabelaNProc
            // 
            this.tabelaNProc.AllowUserToAddRows = false;
            this.tabelaNProc.AllowUserToOrderColumns = true;
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
            this.tabelaNProc.Size = new System.Drawing.Size(1426, 643);
            this.tabelaNProc.TabIndex = 5;
            this.tabelaNProc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaNProc_CellDoubleClick);
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
            this.divCentro.ColumnCount = 1;
            this.divCentro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.72067F));
            this.divCentro.Controls.Add(this.lblnaoproc, 0, 0);
            this.divCentro.Controls.Add(this.tabelaNProc, 0, 1);
            this.divCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divCentro.Location = new System.Drawing.Point(3, 3);
            this.divCentro.Name = "divCentro";
            this.divCentro.Padding = new System.Windows.Forms.Padding(5);
            this.divCentro.RowCount = 2;
            this.divCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.divCentro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.divCentro.Size = new System.Drawing.Size(1442, 679);
            this.divCentro.TabIndex = 6;
            // 
            // abas
            // 
            this.abas.Controls.Add(this.tabConsultar);
            this.abas.Controls.Add(this.pagErros);
            this.abas.Controls.Add(this.tabMercadorias);
            this.abas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abas.Location = new System.Drawing.Point(0, 41);
            this.abas.Margin = new System.Windows.Forms.Padding(0);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(1456, 711);
            this.abas.TabIndex = 0;
            this.abas.Selected += new System.Windows.Forms.TabControlEventHandler(this.AbasChanged);
            // 
            // tabConsultar
            // 
            this.tabConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabConsultar.Controls.Add(this.gridConsulta);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Size = new System.Drawing.Size(1448, 685);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar Mercadorias";
            // 
            // gridConsulta
            // 
            this.gridConsulta.AllowUserToAddRows = false;
            this.gridConsulta.AllowUserToOrderColumns = true;
            this.gridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridConsulta.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridConsulta.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridConsulta.Location = new System.Drawing.Point(0, 0);
            this.gridConsulta.Name = "gridConsulta";
            this.gridConsulta.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridConsulta.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridConsulta.Size = new System.Drawing.Size(1448, 685);
            this.gridConsulta.TabIndex = 0;
            this.gridConsulta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsulta_CellDoubleClick);
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
            this.pagErros.Size = new System.Drawing.Size(1448, 685);
            this.pagErros.TabIndex = 0;
            this.pagErros.Text = "Erros de Processamento";
            // 
            // tabMercadorias
            // 
            this.tabMercadorias.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabMercadorias.Controls.Add(this.listaMercadorias);
            this.tabMercadorias.Location = new System.Drawing.Point(4, 22);
            this.tabMercadorias.Name = "tabMercadorias";
            this.tabMercadorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabMercadorias.Size = new System.Drawing.Size(1448, 685);
            this.tabMercadorias.TabIndex = 2;
            this.tabMercadorias.Text = "Busca Mercadoria";
            // 
            // listaMercadorias
            // 
            this.listaMercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMercadorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaMercadorias.Location = new System.Drawing.Point(3, 3);
            this.listaMercadorias.Name = "listaMercadorias";
            this.listaMercadorias.Size = new System.Drawing.Size(1442, 679);
            this.listaMercadorias.TabIndex = 0;
            // 
            // Principal
            // 
            this.AcceptButton = this.btConsultaPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1456, 752);
            this.Controls.Add(this.abas);
            this.Controls.Add(this.topo);
            this.Controls.Add(this.divTopo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Principal";
            this.Text = "Acerto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intFilial)).EndInit();
            this.grpCondi.ResumeLayout(false);
            this.grpCondi.PerformLayout();
            this.topo.ResumeLayout(false);
            this.topo.PerformLayout();
            this.painelFilial.ResumeLayout(false);
            this.painelFilial.PerformLayout();
            this.menuConsulta.ResumeLayout(false);
            this.menuConsulta.PerformLayout();
            this.panelDatas.ResumeLayout(false);
            this.panelDatas.PerformLayout();
            this.mercadoriaPanel.ResumeLayout(false);
            this.mercadoriaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).EndInit();
            this.divCentro.ResumeLayout(false);
            this.divCentro.PerformLayout();
            this.abas.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            this.pagErros.ResumeLayout(false);
            this.tabMercadorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaMercadorias)).EndInit();
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
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.DateTimePicker dataFim;
        private System.Windows.Forms.DateTimePicker dataInicio;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.NumericUpDown intFilial;
        private System.Windows.Forms.Label lblFilial;
        private System.Windows.Forms.Button btPesquisa;
        private System.Windows.Forms.FlowLayoutPanel topo;
        private System.Windows.Forms.Label lblnaoproc;
        private System.Windows.Forms.DataGridView tabelaNProc;
        private System.Windows.Forms.TableLayoutPanel divCentro;
        private System.Windows.Forms.TabControl abas;
        private System.Windows.Forms.TabPage pagErros;
        private System.Windows.Forms.TabPage tabConsultar;
        private FlowLayoutPanel menuConsulta;
        private Label lblConsultaMaterial;
        private Button btConsultaPesquisar;
        private DataGridView gridConsulta;
        private Label ConsultaNumLinhas;
        private FlowLayoutPanel painelFilial;
        private FlowLayoutPanel panelDatas;
        private Label label3;
        private Splitter splseparator;
        private TextBox lblCodProd;
        private TabPage tabMercadorias;
        private DataGridView listaMercadorias;
        private FlowLayoutPanel mercadoriaPanel;
        private Label label1;
        private TextBox textProduto;
    }
}

