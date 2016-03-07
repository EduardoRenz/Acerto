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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.divTopo = new System.Windows.Forms.FlowLayoutPanel();
            this.painelPesquisa = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.chkVendas = new System.Windows.Forms.CheckBox();
            this.chkTrans = new System.Windows.Forms.CheckBox();
            this.intFilial = new System.Windows.Forms.NumericUpDown();
            this.lblFilial = new System.Windows.Forms.Label();
            this.numericDoc = new System.Windows.Forms.NumericUpDown();
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
            this.contTopBusca1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblcomboGrupo = new System.Windows.Forms.Label();
            this.comboBoxGrupo = new System.Windows.Forms.ComboBox();
            this.contTopBusca2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSubGrupo = new System.Windows.Forms.Label();
            this.comboBoxSubGrupo = new System.Windows.Forms.ComboBox();
            this.contTopBusca3 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxMercadoSaldo = new System.Windows.Forms.CheckBox();
            this.btMercadoriaPesquisa = new System.Windows.Forms.Button();
            this.topCPF = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btCPF = new System.Windows.Forms.Button();
            this.panelVolDocs = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDoc = new System.Windows.Forms.Label();
            this.radioMatriz = new System.Windows.Forms.RadioButton();
            this.radioFilial = new System.Windows.Forms.RadioButton();
            this.btVolDoc = new System.Windows.Forms.Button();
            this.ConsultaNumLinhas = new System.Windows.Forms.Label();
            this.tabelaNProc = new System.Windows.Forms.DataGridView();
            this.lblnaoproc = new System.Windows.Forms.Label();
            this.divCentro = new System.Windows.Forms.TableLayoutPanel();
            this.abas = new System.Windows.Forms.TabControl();
            this.tabConsultar = new System.Windows.Forms.TabPage();
            this.gridConsulta = new System.Windows.Forms.DataGridView();
            this.pagErros = new System.Windows.Forms.TabPage();
            this.tabMercadorias = new System.Windows.Forms.TabPage();
            this.gridMercadorias = new System.Windows.Forms.DataGridView();
            this.tabCPF = new System.Windows.Forms.TabPage();
            this.tableCPF = new System.Windows.Forms.TableLayoutPanel();
            this.flowCPFLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.gridCPF = new System.Windows.Forms.DataGridView();
            this.cpfResultDoc = new System.Windows.Forms.DataGridView();
            this.cpfDocsLabel = new System.Windows.Forms.Label();
            this.cpfLblMercadorias = new System.Windows.Forms.Label();
            this.cpfFlowLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.tabVolDoc = new System.Windows.Forms.TabPage();
            this.dataVolDoc = new System.Windows.Forms.DataGridView();
            this.textCPF = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.intFilial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).BeginInit();
            this.grpCondi.SuspendLayout();
            this.topo.SuspendLayout();
            this.painelFilial.SuspendLayout();
            this.menuConsulta.SuspendLayout();
            this.panelDatas.SuspendLayout();
            this.mercadoriaPanel.SuspendLayout();
            this.contTopBusca1.SuspendLayout();
            this.contTopBusca2.SuspendLayout();
            this.contTopBusca3.SuspendLayout();
            this.topCPF.SuspendLayout();
            this.panelVolDocs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).BeginInit();
            this.divCentro.SuspendLayout();
            this.abas.SuspendLayout();
            this.tabConsultar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).BeginInit();
            this.pagErros.SuspendLayout();
            this.tabMercadorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMercadorias)).BeginInit();
            this.tabCPF.SuspendLayout();
            this.tableCPF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfResultDoc)).BeginInit();
            this.cpfFlowLeft.SuspendLayout();
            this.tabVolDoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVolDoc)).BeginInit();
            this.SuspendLayout();
            // 
            // divTopo
            // 
            this.divTopo.AutoSize = true;
            this.divTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.divTopo.Location = new System.Drawing.Point(0, 0);
            this.divTopo.Name = "divTopo";
            this.divTopo.Size = new System.Drawing.Size(1062, 0);
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
            // numericDoc
            // 
            this.numericDoc.Location = new System.Drawing.Point(47, 6);
            this.numericDoc.Margin = new System.Windows.Forms.Padding(0);
            this.numericDoc.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericDoc.Name = "numericDoc";
            this.numericDoc.Size = new System.Drawing.Size(154, 20);
            this.numericDoc.TabIndex = 12;
            this.toolTip.SetToolTip(this.numericDoc, "0 = Todas as Filiais");
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
            // btCorrigir
            // 
            this.btCorrigir.Location = new System.Drawing.Point(0, 0);
            this.btCorrigir.Name = "btCorrigir";
            this.btCorrigir.Size = new System.Drawing.Size(75, 23);
            this.btCorrigir.TabIndex = 0;
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
            this.dataFim.Value = new System.DateTime(2016, 3, 4, 0, 0, 0, 0);
            // 
            // dataInicio
            // 
            this.dataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicio.Location = new System.Drawing.Point(56, 6);
            this.dataInicio.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dataInicio.Name = "dataInicio";
            this.dataInicio.Size = new System.Drawing.Size(103, 20);
            this.dataInicio.TabIndex = 2;
            this.dataInicio.Value = new System.DateTime(2016, 3, 1, 10, 48, 49, 957);
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
            this.topo.Controls.Add(this.contTopBusca1);
            this.topo.Controls.Add(this.contTopBusca2);
            this.topo.Controls.Add(this.contTopBusca3);
            this.topo.Controls.Add(this.topCPF);
            this.topo.Controls.Add(this.panelVolDocs);
            this.topo.Controls.Add(this.ConsultaNumLinhas);
            this.topo.Dock = System.Windows.Forms.DockStyle.Top;
            this.topo.Location = new System.Drawing.Point(0, 0);
            this.topo.Margin = new System.Windows.Forms.Padding(0);
            this.topo.Name = "topo";
            this.topo.Padding = new System.Windows.Forms.Padding(5);
            this.topo.Size = new System.Drawing.Size(1062, 103);
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
            this.mercadoriaPanel.Controls.Add(this.label1);
            this.mercadoriaPanel.Controls.Add(this.textProduto);
            this.mercadoriaPanel.Location = new System.Drawing.Point(5, 36);
            this.mercadoriaPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mercadoriaPanel.Name = "mercadoriaPanel";
            this.mercadoriaPanel.Padding = new System.Windows.Forms.Padding(3, 6, 0, 5);
            this.mercadoriaPanel.Size = new System.Drawing.Size(311, 31);
            this.mercadoriaPanel.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mercadoria:";
            // 
            // textProduto
            // 
            this.textProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textProduto.Location = new System.Drawing.Point(100, 6);
            this.textProduto.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.textProduto.Name = "textProduto";
            this.textProduto.Size = new System.Drawing.Size(205, 20);
            this.textProduto.TabIndex = 17;
            // 
            // contTopBusca1
            // 
            this.contTopBusca1.AutoSize = true;
            this.contTopBusca1.Controls.Add(this.lblcomboGrupo);
            this.contTopBusca1.Controls.Add(this.comboBoxGrupo);
            this.contTopBusca1.Location = new System.Drawing.Point(316, 42);
            this.contTopBusca1.Margin = new System.Windows.Forms.Padding(0, 6, 3, 0);
            this.contTopBusca1.Name = "contTopBusca1";
            this.contTopBusca1.Size = new System.Drawing.Size(248, 21);
            this.contTopBusca1.TabIndex = 23;
            // 
            // lblcomboGrupo
            // 
            this.lblcomboGrupo.AutoSize = true;
            this.lblcomboGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblcomboGrupo.Location = new System.Drawing.Point(0, 0);
            this.lblcomboGrupo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblcomboGrupo.Name = "lblcomboGrupo";
            this.lblcomboGrupo.Size = new System.Drawing.Size(58, 17);
            this.lblcomboGrupo.TabIndex = 19;
            this.lblcomboGrupo.Text = "Grupo:";
            // 
            // comboBoxGrupo
            // 
            this.comboBoxGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGrupo.FormattingEnabled = true;
            this.comboBoxGrupo.Location = new System.Drawing.Point(61, 0);
            this.comboBoxGrupo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.comboBoxGrupo.Name = "comboBoxGrupo";
            this.comboBoxGrupo.Size = new System.Drawing.Size(184, 21);
            this.comboBoxGrupo.TabIndex = 18;
            this.comboBoxGrupo.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrupo_SelectedIndexChanged);
            // 
            // contTopBusca2
            // 
            this.contTopBusca2.AutoSize = true;
            this.contTopBusca2.Controls.Add(this.lblSubGrupo);
            this.contTopBusca2.Controls.Add(this.comboBoxSubGrupo);
            this.contTopBusca2.Location = new System.Drawing.Point(567, 42);
            this.contTopBusca2.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.contTopBusca2.Name = "contTopBusca2";
            this.contTopBusca2.Size = new System.Drawing.Size(277, 21);
            this.contTopBusca2.TabIndex = 24;
            // 
            // lblSubGrupo
            // 
            this.lblSubGrupo.AutoSize = true;
            this.lblSubGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSubGrupo.Location = new System.Drawing.Point(0, 0);
            this.lblSubGrupo.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSubGrupo.Name = "lblSubGrupo";
            this.lblSubGrupo.Size = new System.Drawing.Size(86, 17);
            this.lblSubGrupo.TabIndex = 22;
            this.lblSubGrupo.Text = "SubGrupo:";
            // 
            // comboBoxSubGrupo
            // 
            this.comboBoxSubGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubGrupo.FormattingEnabled = true;
            this.comboBoxSubGrupo.Location = new System.Drawing.Point(89, 0);
            this.comboBoxSubGrupo.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.comboBoxSubGrupo.Name = "comboBoxSubGrupo";
            this.comboBoxSubGrupo.Size = new System.Drawing.Size(184, 21);
            this.comboBoxSubGrupo.TabIndex = 21;
            // 
            // contTopBusca3
            // 
            this.contTopBusca3.AutoSize = true;
            this.contTopBusca3.Controls.Add(this.checkBoxMercadoSaldo);
            this.contTopBusca3.Controls.Add(this.btMercadoriaPesquisa);
            this.contTopBusca3.Location = new System.Drawing.Point(844, 42);
            this.contTopBusca3.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.contTopBusca3.Name = "contTopBusca3";
            this.contTopBusca3.Size = new System.Drawing.Size(208, 22);
            this.contTopBusca3.TabIndex = 25;
            // 
            // checkBoxMercadoSaldo
            // 
            this.checkBoxMercadoSaldo.AutoSize = true;
            this.checkBoxMercadoSaldo.Checked = true;
            this.checkBoxMercadoSaldo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMercadoSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMercadoSaldo.Location = new System.Drawing.Point(3, 0);
            this.checkBoxMercadoSaldo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxMercadoSaldo.Name = "checkBoxMercadoSaldo";
            this.checkBoxMercadoSaldo.Size = new System.Drawing.Size(102, 22);
            this.checkBoxMercadoSaldo.TabIndex = 23;
            this.checkBoxMercadoSaldo.Text = "Com Saldo";
            this.checkBoxMercadoSaldo.UseVisualStyleBackColor = true;
            // 
            // btMercadoriaPesquisa
            // 
            this.btMercadoriaPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMercadoriaPesquisa.Location = new System.Drawing.Point(108, 0);
            this.btMercadoriaPesquisa.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btMercadoriaPesquisa.Name = "btMercadoriaPesquisa";
            this.btMercadoriaPesquisa.Size = new System.Drawing.Size(97, 20);
            this.btMercadoriaPesquisa.TabIndex = 20;
            this.btMercadoriaPesquisa.Text = "Pesquisar";
            this.btMercadoriaPesquisa.UseVisualStyleBackColor = true;
            this.btMercadoriaPesquisa.Click += new System.EventHandler(this.btMercadoriaPesquisa_Click);
            // 
            // topCPF
            // 
            this.topCPF.Controls.Add(this.lblCPF);
            this.topCPF.Controls.Add(this.textCPF);
            this.topCPF.Controls.Add(this.btCPF);
            this.topCPF.Location = new System.Drawing.Point(5, 67);
            this.topCPF.Margin = new System.Windows.Forms.Padding(0);
            this.topCPF.Name = "topCPF";
            this.topCPF.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.topCPF.Size = new System.Drawing.Size(365, 31);
            this.topCPF.TabIndex = 26;
            this.topCPF.Visible = false;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(3, 6);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 17);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF:";
            // 
            // btCPF
            // 
            this.btCPF.Location = new System.Drawing.Point(262, 6);
            this.btCPF.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btCPF.Name = "btCPF";
            this.btCPF.Size = new System.Drawing.Size(97, 20);
            this.btCPF.TabIndex = 4;
            this.btCPF.Text = "Pesquisar";
            this.btCPF.UseVisualStyleBackColor = true;
            this.btCPF.Click += new System.EventHandler(this.btCPF_Click);
            // 
            // panelVolDocs
            // 
            this.panelVolDocs.Controls.Add(this.lblDoc);
            this.panelVolDocs.Controls.Add(this.numericDoc);
            this.panelVolDocs.Controls.Add(this.radioMatriz);
            this.panelVolDocs.Controls.Add(this.radioFilial);
            this.panelVolDocs.Controls.Add(this.btVolDoc);
            this.panelVolDocs.Location = new System.Drawing.Point(370, 67);
            this.panelVolDocs.Margin = new System.Windows.Forms.Padding(0);
            this.panelVolDocs.Name = "panelVolDocs";
            this.panelVolDocs.Padding = new System.Windows.Forms.Padding(3, 6, 0, 0);
            this.panelVolDocs.Size = new System.Drawing.Size(441, 31);
            this.panelVolDocs.TabIndex = 27;
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDoc.Location = new System.Drawing.Point(3, 6);
            this.lblDoc.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(41, 17);
            this.lblDoc.TabIndex = 11;
            this.lblDoc.Text = "Doc:";
            // 
            // radioMatriz
            // 
            this.radioMatriz.AutoSize = true;
            this.radioMatriz.Checked = true;
            this.radioMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMatriz.Location = new System.Drawing.Point(207, 6);
            this.radioMatriz.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.radioMatriz.Name = "radioMatriz";
            this.radioMatriz.Size = new System.Drawing.Size(67, 22);
            this.radioMatriz.TabIndex = 13;
            this.radioMatriz.TabStop = true;
            this.radioMatriz.Text = "Matriz";
            this.radioMatriz.UseVisualStyleBackColor = true;
            // 
            // radioFilial
            // 
            this.radioFilial.AutoSize = true;
            this.radioFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFilial.Location = new System.Drawing.Point(280, 6);
            this.radioFilial.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.radioFilial.Name = "radioFilial";
            this.radioFilial.Size = new System.Drawing.Size(55, 22);
            this.radioFilial.TabIndex = 14;
            this.radioFilial.Text = "Filial";
            this.radioFilial.UseVisualStyleBackColor = true;
            // 
            // btVolDoc
            // 
            this.btVolDoc.Location = new System.Drawing.Point(338, 6);
            this.btVolDoc.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btVolDoc.Name = "btVolDoc";
            this.btVolDoc.Size = new System.Drawing.Size(97, 20);
            this.btVolDoc.TabIndex = 15;
            this.btVolDoc.Text = "Pesquisar";
            this.btVolDoc.UseVisualStyleBackColor = true;
            this.btVolDoc.Click += new System.EventHandler(this.btVolDoc_Click);
            // 
            // ConsultaNumLinhas
            // 
            this.ConsultaNumLinhas.AutoSize = true;
            this.ConsultaNumLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaNumLinhas.ForeColor = System.Drawing.SystemColors.Control;
            this.ConsultaNumLinhas.Location = new System.Drawing.Point(814, 73);
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
            this.tabelaNProc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabelaNProc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.tabelaNProc.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.tabelaNProc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
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
            this.tabelaNProc.Size = new System.Drawing.Size(1032, 581);
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
            this.divCentro.Size = new System.Drawing.Size(1048, 617);
            this.divCentro.TabIndex = 6;
            // 
            // abas
            // 
            this.abas.Controls.Add(this.tabConsultar);
            this.abas.Controls.Add(this.pagErros);
            this.abas.Controls.Add(this.tabMercadorias);
            this.abas.Controls.Add(this.tabCPF);
            this.abas.Controls.Add(this.tabVolDoc);
            this.abas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.abas.Location = new System.Drawing.Point(0, 103);
            this.abas.Margin = new System.Windows.Forms.Padding(0);
            this.abas.Name = "abas";
            this.abas.SelectedIndex = 0;
            this.abas.Size = new System.Drawing.Size(1062, 649);
            this.abas.TabIndex = 0;
            this.abas.Selected += new System.Windows.Forms.TabControlEventHandler(this.AbasChanged);
            // 
            // tabConsultar
            // 
            this.tabConsultar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabConsultar.Controls.Add(this.gridConsulta);
            this.tabConsultar.Location = new System.Drawing.Point(4, 22);
            this.tabConsultar.Name = "tabConsultar";
            this.tabConsultar.Size = new System.Drawing.Size(1054, 623);
            this.tabConsultar.TabIndex = 1;
            this.tabConsultar.Text = "Consultar Codigo";
            // 
            // gridConsulta
            // 
            this.gridConsulta.AllowUserToAddRows = false;
            this.gridConsulta.AllowUserToOrderColumns = true;
            this.gridConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridConsulta.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.gridConsulta.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
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
            this.gridConsulta.Size = new System.Drawing.Size(1054, 623);
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
            this.pagErros.Size = new System.Drawing.Size(1054, 623);
            this.pagErros.TabIndex = 0;
            this.pagErros.Text = "Erros de Processamento";
            // 
            // tabMercadorias
            // 
            this.tabMercadorias.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabMercadorias.Controls.Add(this.gridMercadorias);
            this.tabMercadorias.Location = new System.Drawing.Point(4, 22);
            this.tabMercadorias.Name = "tabMercadorias";
            this.tabMercadorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabMercadorias.Size = new System.Drawing.Size(1054, 623);
            this.tabMercadorias.TabIndex = 2;
            this.tabMercadorias.Text = "Busca Mercadoria";
            // 
            // gridMercadorias
            // 
            this.gridMercadorias.AllowUserToAddRows = false;
            this.gridMercadorias.AllowUserToOrderColumns = true;
            this.gridMercadorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridMercadorias.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.gridMercadorias.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.gridMercadorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMercadorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMercadorias.GridColor = System.Drawing.SystemColors.HotTrack;
            this.gridMercadorias.Location = new System.Drawing.Point(3, 3);
            this.gridMercadorias.Name = "gridMercadorias";
            this.gridMercadorias.ReadOnly = true;
            this.gridMercadorias.Size = new System.Drawing.Size(1048, 617);
            this.gridMercadorias.TabIndex = 0;
            this.gridMercadorias.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMercadorias_CellDoubleClick);
            // 
            // tabCPF
            // 
            this.tabCPF.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabCPF.Controls.Add(this.tableCPF);
            this.tabCPF.Location = new System.Drawing.Point(4, 22);
            this.tabCPF.Name = "tabCPF";
            this.tabCPF.Padding = new System.Windows.Forms.Padding(3);
            this.tabCPF.Size = new System.Drawing.Size(1054, 623);
            this.tabCPF.TabIndex = 3;
            this.tabCPF.Text = "Consulta CPF";
            // 
            // tableCPF
            // 
            this.tableCPF.ColumnCount = 2;
            this.tableCPF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCPF.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableCPF.Controls.Add(this.flowCPFLeft, 1, 0);
            this.tableCPF.Controls.Add(this.gridCPF, 0, 2);
            this.tableCPF.Controls.Add(this.cpfResultDoc, 1, 2);
            this.tableCPF.Controls.Add(this.cpfDocsLabel, 0, 1);
            this.tableCPF.Controls.Add(this.cpfLblMercadorias, 1, 1);
            this.tableCPF.Controls.Add(this.cpfFlowLeft, 0, 0);
            this.tableCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCPF.Location = new System.Drawing.Point(3, 3);
            this.tableCPF.Name = "tableCPF";
            this.tableCPF.RowCount = 3;
            this.tableCPF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableCPF.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableCPF.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableCPF.Size = new System.Drawing.Size(1048, 617);
            this.tableCPF.TabIndex = 2;
            // 
            // flowCPFLeft
            // 
            this.flowCPFLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCPFLeft.Location = new System.Drawing.Point(527, 3);
            this.flowCPFLeft.Name = "flowCPFLeft";
            this.flowCPFLeft.Size = new System.Drawing.Size(518, 17);
            this.flowCPFLeft.TabIndex = 26;
            // 
            // gridCPF
            // 
            this.gridCPF.AllowUserToAddRows = false;
            this.gridCPF.AllowUserToOrderColumns = true;
            this.gridCPF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridCPF.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.gridCPF.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.gridCPF.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCPF.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridCPF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCPF.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridCPF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCPF.Location = new System.Drawing.Point(3, 46);
            this.gridCPF.MultiSelect = false;
            this.gridCPF.Name = "gridCPF";
            this.gridCPF.ReadOnly = true;
            this.gridCPF.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridCPF.Size = new System.Drawing.Size(518, 568);
            this.gridCPF.TabIndex = 6;
            this.gridCPF.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCPF_RowEnter);
            // 
            // cpfResultDoc
            // 
            this.cpfResultDoc.AllowUserToAddRows = false;
            this.cpfResultDoc.AllowUserToOrderColumns = true;
            this.cpfResultDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cpfResultDoc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.cpfResultDoc.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.cpfResultDoc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cpfResultDoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.cpfResultDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cpfResultDoc.DefaultCellStyle = dataGridViewCellStyle9;
            this.cpfResultDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpfResultDoc.Location = new System.Drawing.Point(527, 46);
            this.cpfResultDoc.MultiSelect = false;
            this.cpfResultDoc.Name = "cpfResultDoc";
            this.cpfResultDoc.ReadOnly = true;
            this.cpfResultDoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cpfResultDoc.Size = new System.Drawing.Size(518, 568);
            this.cpfResultDoc.TabIndex = 7;
            this.cpfResultDoc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cpfResultDoc_CellDoubleClick);
            // 
            // cpfDocsLabel
            // 
            this.cpfDocsLabel.AutoSize = true;
            this.cpfDocsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cpfDocsLabel.Location = new System.Drawing.Point(0, 23);
            this.cpfDocsLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cpfDocsLabel.Name = "cpfDocsLabel";
            this.cpfDocsLabel.Size = new System.Drawing.Size(101, 17);
            this.cpfDocsLabel.TabIndex = 23;
            this.cpfDocsLabel.Text = "Docs do CPF";
            // 
            // cpfLblMercadorias
            // 
            this.cpfLblMercadorias.AutoSize = true;
            this.cpfLblMercadorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cpfLblMercadorias.Location = new System.Drawing.Point(524, 23);
            this.cpfLblMercadorias.Margin = new System.Windows.Forms.Padding(0);
            this.cpfLblMercadorias.Name = "cpfLblMercadorias";
            this.cpfLblMercadorias.Size = new System.Drawing.Size(97, 17);
            this.cpfLblMercadorias.TabIndex = 24;
            this.cpfLblMercadorias.Text = "Mercadorias";
            // 
            // cpfFlowLeft
            // 
            this.cpfFlowLeft.Controls.Add(this.labelNomeCliente);
            this.cpfFlowLeft.Controls.Add(this.lblClienteNome);
            this.cpfFlowLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpfFlowLeft.Location = new System.Drawing.Point(0, 3);
            this.cpfFlowLeft.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.cpfFlowLeft.Name = "cpfFlowLeft";
            this.cpfFlowLeft.Size = new System.Drawing.Size(521, 17);
            this.cpfFlowLeft.TabIndex = 25;
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(0, 0);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(63, 17);
            this.labelNomeCliente.TabIndex = 24;
            this.labelNomeCliente.Text = "Cliente:";
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblClienteNome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblClienteNome.Location = new System.Drawing.Point(63, 0);
            this.lblClienteNome.Margin = new System.Windows.Forms.Padding(0);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(0, 17);
            this.lblClienteNome.TabIndex = 25;
            // 
            // tabVolDoc
            // 
            this.tabVolDoc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tabVolDoc.Controls.Add(this.dataVolDoc);
            this.tabVolDoc.Location = new System.Drawing.Point(4, 22);
            this.tabVolDoc.Name = "tabVolDoc";
            this.tabVolDoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabVolDoc.Size = new System.Drawing.Size(1054, 623);
            this.tabVolDoc.TabIndex = 4;
            this.tabVolDoc.Text = "Volumes / Docs";
            // 
            // dataVolDoc
            // 
            this.dataVolDoc.AllowUserToAddRows = false;
            this.dataVolDoc.AllowUserToOrderColumns = true;
            this.dataVolDoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataVolDoc.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.dataVolDoc.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataVolDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVolDoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataVolDoc.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataVolDoc.Location = new System.Drawing.Point(3, 3);
            this.dataVolDoc.Name = "dataVolDoc";
            this.dataVolDoc.ReadOnly = true;
            this.dataVolDoc.Size = new System.Drawing.Size(1048, 617);
            this.dataVolDoc.TabIndex = 1;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(48, 6);
            this.textCPF.Margin = new System.Windows.Forms.Padding(0);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(211, 20);
            this.textCPF.TabIndex = 17;
            // 
            // Principal
            // 
            this.AcceptButton = this.btConsultaPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1062, 752);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericDoc)).EndInit();
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
            this.contTopBusca1.ResumeLayout(false);
            this.contTopBusca1.PerformLayout();
            this.contTopBusca2.ResumeLayout(false);
            this.contTopBusca2.PerformLayout();
            this.contTopBusca3.ResumeLayout(false);
            this.contTopBusca3.PerformLayout();
            this.topCPF.ResumeLayout(false);
            this.topCPF.PerformLayout();
            this.panelVolDocs.ResumeLayout(false);
            this.panelVolDocs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaNProc)).EndInit();
            this.divCentro.ResumeLayout(false);
            this.divCentro.PerformLayout();
            this.abas.ResumeLayout(false);
            this.tabConsultar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsulta)).EndInit();
            this.pagErros.ResumeLayout(false);
            this.tabMercadorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMercadorias)).EndInit();
            this.tabCPF.ResumeLayout(false);
            this.tableCPF.ResumeLayout(false);
            this.tableCPF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpfResultDoc)).EndInit();
            this.cpfFlowLeft.ResumeLayout(false);
            this.cpfFlowLeft.PerformLayout();
            this.tabVolDoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataVolDoc)).EndInit();
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
        private DataGridView gridMercadorias;
        private FlowLayoutPanel mercadoriaPanel;
        private Label label1;
        private TextBox textProduto;
        private ComboBox comboBoxGrupo;
        private Label lblcomboGrupo;
        private Button btMercadoriaPesquisa;
        private Label lblSubGrupo;
        private ComboBox comboBoxSubGrupo;
        private FlowLayoutPanel contTopBusca1;
        private CheckBox checkBoxMercadoSaldo;
        private FlowLayoutPanel contTopBusca2;
        private FlowLayoutPanel contTopBusca3;
        private TabPage tabCPF;
        private TableLayoutPanel tableCPF;
        private RadioButton radioVolMat;
        private RadioButton radioVolFil;
        private FlowLayoutPanel topCPF;
        private Label lblCPF;
        private Button btCPF;
        private Label cpfDocsLabel;
        private TabPage tabVolDoc;
        private FlowLayoutPanel panelVolDocs;
        private Label lblDoc;
        private RadioButton radioMatriz;
        private RadioButton radioFilial;
        private Button btVolDoc;
        private DataGridView dataVolDoc;
        private NumericUpDown numericDoc;
        private FlowLayoutPanel flowCPFLeft;
        private DataGridView gridCPF;
        private DataGridView cpfResultDoc;
        private Label cpfLblMercadorias;
        private FlowLayoutPanel cpfFlowLeft;
        private Label labelNomeCliente;
        private Label lblClienteNome;
        private TextBox textCPF;
    }
}

