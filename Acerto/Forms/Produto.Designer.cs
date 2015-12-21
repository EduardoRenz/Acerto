namespace Acerto
{
    partial class Produto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produto));
            this.divProdTopEsq = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMaterial = new System.Windows.Forms.Panel();
            this.lblProdMaterial = new System.Windows.Forms.Label();
            this.prodMaterial = new System.Windows.Forms.TextBox();
            this.panelSerie = new System.Windows.Forms.Panel();
            this.lblProdSerie = new System.Windows.Forms.Label();
            this.prodSerie = new System.Windows.Forms.TextBox();
            this.panelFilial = new System.Windows.Forms.Panel();
            this.ProdLblFilial = new System.Windows.Forms.Label();
            this.prodFilial = new System.Windows.Forms.TextBox();
            this.separaProdInfos = new System.Windows.Forms.Splitter();
            this.prodDescr = new System.Windows.Forms.Label();
            this.ProdGridHist = new System.Windows.Forms.DataGridView();
            this.prodGridSaldos = new System.Windows.Forms.DataGridView();
            this.tableLayoutProd = new System.Windows.Forms.TableLayoutPanel();
            this.divProdTopEsq.SuspendLayout();
            this.panelMaterial.SuspendLayout();
            this.panelSerie.SuspendLayout();
            this.panelFilial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGridHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGridSaldos)).BeginInit();
            this.tableLayoutProd.SuspendLayout();
            this.SuspendLayout();
            // 
            // divProdTopEsq
            // 
            this.divProdTopEsq.AutoSize = true;
            this.divProdTopEsq.Controls.Add(this.panelMaterial);
            this.divProdTopEsq.Controls.Add(this.panelSerie);
            this.divProdTopEsq.Controls.Add(this.panelFilial);
            this.divProdTopEsq.Controls.Add(this.separaProdInfos);
            this.divProdTopEsq.Controls.Add(this.prodDescr);
            this.divProdTopEsq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divProdTopEsq.Location = new System.Drawing.Point(0, 0);
            this.divProdTopEsq.Margin = new System.Windows.Forms.Padding(0);
            this.divProdTopEsq.Name = "divProdTopEsq";
            this.divProdTopEsq.Size = new System.Drawing.Size(1100, 24);
            this.divProdTopEsq.TabIndex = 1;
            // 
            // panelMaterial
            // 
            this.panelMaterial.AutoSize = true;
            this.panelMaterial.Controls.Add(this.lblProdMaterial);
            this.panelMaterial.Controls.Add(this.prodMaterial);
            this.panelMaterial.Location = new System.Drawing.Point(0, 0);
            this.panelMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.panelMaterial.Name = "panelMaterial";
            this.panelMaterial.Size = new System.Drawing.Size(171, 24);
            this.panelMaterial.TabIndex = 5;
            // 
            // lblProdMaterial
            // 
            this.lblProdMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdMaterial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProdMaterial.Location = new System.Drawing.Point(0, 0);
            this.lblProdMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.lblProdMaterial.Name = "lblProdMaterial";
            this.lblProdMaterial.Size = new System.Drawing.Size(90, 24);
            this.lblProdMaterial.TabIndex = 0;
            this.lblProdMaterial.Text = "Material:";
            // 
            // prodMaterial
            // 
            this.prodMaterial.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prodMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodMaterial.Location = new System.Drawing.Point(90, 1);
            this.prodMaterial.Margin = new System.Windows.Forms.Padding(0);
            this.prodMaterial.Name = "prodMaterial";
            this.prodMaterial.ReadOnly = true;
            this.prodMaterial.Size = new System.Drawing.Size(81, 22);
            this.prodMaterial.TabIndex = 2;
            this.prodMaterial.Text = "Material";
            // 
            // panelSerie
            // 
            this.panelSerie.AutoSize = true;
            this.panelSerie.Controls.Add(this.lblProdSerie);
            this.panelSerie.Controls.Add(this.prodSerie);
            this.panelSerie.Location = new System.Drawing.Point(171, 0);
            this.panelSerie.Margin = new System.Windows.Forms.Padding(0);
            this.panelSerie.Name = "panelSerie";
            this.panelSerie.Size = new System.Drawing.Size(150, 24);
            this.panelSerie.TabIndex = 6;
            // 
            // lblProdSerie
            // 
            this.lblProdSerie.AutoSize = true;
            this.lblProdSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdSerie.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProdSerie.Location = new System.Drawing.Point(0, 0);
            this.lblProdSerie.Margin = new System.Windows.Forms.Padding(0);
            this.lblProdSerie.Name = "lblProdSerie";
            this.lblProdSerie.Size = new System.Drawing.Size(65, 24);
            this.lblProdSerie.TabIndex = 1;
            this.lblProdSerie.Text = "Serie:";
            // 
            // prodSerie
            // 
            this.prodSerie.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prodSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodSerie.Location = new System.Drawing.Point(64, 0);
            this.prodSerie.Margin = new System.Windows.Forms.Padding(0);
            this.prodSerie.Name = "prodSerie";
            this.prodSerie.ReadOnly = true;
            this.prodSerie.Size = new System.Drawing.Size(86, 22);
            this.prodSerie.TabIndex = 3;
            this.prodSerie.Text = "Serie";
            // 
            // panelFilial
            // 
            this.panelFilial.AutoSize = true;
            this.panelFilial.Controls.Add(this.ProdLblFilial);
            this.panelFilial.Controls.Add(this.prodFilial);
            this.panelFilial.Location = new System.Drawing.Point(321, 0);
            this.panelFilial.Margin = new System.Windows.Forms.Padding(0);
            this.panelFilial.Name = "panelFilial";
            this.panelFilial.Size = new System.Drawing.Size(94, 23);
            this.panelFilial.TabIndex = 7;
            // 
            // ProdLblFilial
            // 
            this.ProdLblFilial.AutoSize = true;
            this.ProdLblFilial.Dock = System.Windows.Forms.DockStyle.Left;
            this.ProdLblFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdLblFilial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProdLblFilial.Location = new System.Drawing.Point(0, 0);
            this.ProdLblFilial.Margin = new System.Windows.Forms.Padding(0);
            this.ProdLblFilial.Name = "ProdLblFilial";
            this.ProdLblFilial.Size = new System.Drawing.Size(60, 24);
            this.ProdLblFilial.TabIndex = 1;
            this.ProdLblFilial.Text = "Filial:";
            // 
            // prodFilial
            // 
            this.prodFilial.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prodFilial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodFilial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodFilial.Location = new System.Drawing.Point(62, 1);
            this.prodFilial.Margin = new System.Windows.Forms.Padding(0);
            this.prodFilial.Name = "prodFilial";
            this.prodFilial.ReadOnly = true;
            this.prodFilial.Size = new System.Drawing.Size(32, 22);
            this.prodFilial.TabIndex = 4;
            this.prodFilial.Text = "00";
            // 
            // separaProdInfos
            // 
            this.separaProdInfos.BackColor = System.Drawing.SystemColors.ControlText;
            this.separaProdInfos.Location = new System.Drawing.Point(418, 0);
            this.separaProdInfos.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
            this.separaProdInfos.Name = "separaProdInfos";
            this.separaProdInfos.Size = new System.Drawing.Size(2, 24);
            this.separaProdInfos.TabIndex = 9;
            this.separaProdInfos.TabStop = false;
            // 
            // prodDescr
            // 
            this.prodDescr.AutoSize = true;
            this.prodDescr.Dock = System.Windows.Forms.DockStyle.Left;
            this.prodDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDescr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.prodDescr.Location = new System.Drawing.Point(426, 0);
            this.prodDescr.Margin = new System.Windows.Forms.Padding(0);
            this.prodDescr.Name = "prodDescr";
            this.prodDescr.Size = new System.Drawing.Size(191, 24);
            this.prodDescr.TabIndex = 8;
            this.prodDescr.Text = "Descrição do produto";
            // 
            // ProdGridHist
            // 
            this.ProdGridHist.AllowUserToAddRows = false;
            this.ProdGridHist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProdGridHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProdGridHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdGridHist.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.ProdGridHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdGridHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdGridHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdGridHist.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdGridHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdGridHist.EnableHeadersVisualStyles = false;
            this.ProdGridHist.Location = new System.Drawing.Point(3, 27);
            this.ProdGridHist.Name = "ProdGridHist";
            this.ProdGridHist.ReadOnly = true;
            this.ProdGridHist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdGridHist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ProdGridHist.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProdGridHist.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ProdGridHist.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ProdGridHist.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdGridHist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProdGridHist.Size = new System.Drawing.Size(1094, 158);
            this.ProdGridHist.TabIndex = 0;
            // 
            // prodGridSaldos
            // 
            this.prodGridSaldos.AllowUserToAddRows = false;
            this.prodGridSaldos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.prodGridSaldos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.prodGridSaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.prodGridSaldos.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.prodGridSaldos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodGridSaldos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGridSaldos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.prodGridSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGridSaldos.DefaultCellStyle = dataGridViewCellStyle8;
            this.prodGridSaldos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodGridSaldos.EnableHeadersVisualStyles = false;
            this.prodGridSaldos.Location = new System.Drawing.Point(3, 191);
            this.prodGridSaldos.Name = "prodGridSaldos";
            this.prodGridSaldos.ReadOnly = true;
            this.prodGridSaldos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodGridSaldos.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.prodGridSaldos.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prodGridSaldos.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.prodGridSaldos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.prodGridSaldos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prodGridSaldos.Size = new System.Drawing.Size(1094, 147);
            this.prodGridSaldos.TabIndex = 1;
            // 
            // tableLayoutProd
            // 
            this.tableLayoutProd.ColumnCount = 1;
            this.tableLayoutProd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutProd.Controls.Add(this.prodGridSaldos, 0, 2);
            this.tableLayoutProd.Controls.Add(this.divProdTopEsq, 0, 0);
            this.tableLayoutProd.Controls.Add(this.ProdGridHist, 0, 1);
            this.tableLayoutProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutProd.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutProd.Name = "tableLayoutProd";
            this.tableLayoutProd.RowCount = 3;
            this.tableLayoutProd.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutProd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutProd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutProd.Size = new System.Drawing.Size(1100, 341);
            this.tableLayoutProd.TabIndex = 2;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1100, 341);
            this.Controls.Add(this.tableLayoutProd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(550, 330);
            this.Name = "Produto";
            this.Text = "Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Produto_FormClosed);
            this.Load += new System.EventHandler(this.Produto_Load);
            this.divProdTopEsq.ResumeLayout(false);
            this.divProdTopEsq.PerformLayout();
            this.panelMaterial.ResumeLayout(false);
            this.panelMaterial.PerformLayout();
            this.panelSerie.ResumeLayout(false);
            this.panelSerie.PerformLayout();
            this.panelFilial.ResumeLayout(false);
            this.panelFilial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdGridHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodGridSaldos)).EndInit();
            this.tableLayoutProd.ResumeLayout(false);
            this.tableLayoutProd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel divProdTopEsq;
        private System.Windows.Forms.Label lblProdMaterial;
        private System.Windows.Forms.TextBox prodMaterial;
        private System.Windows.Forms.Label lblProdSerie;
        private System.Windows.Forms.TextBox prodSerie;
        private System.Windows.Forms.Label ProdLblFilial;
        private System.Windows.Forms.TextBox prodFilial;
        private System.Windows.Forms.Panel panelMaterial;
        private System.Windows.Forms.Panel panelSerie;
        private System.Windows.Forms.Panel panelFilial;
        private System.Windows.Forms.Label prodDescr;
        private System.Windows.Forms.Splitter separaProdInfos;
        private System.Windows.Forms.DataGridView ProdGridHist;
        private System.Windows.Forms.DataGridView prodGridSaldos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutProd;
    }
}