namespace Examen1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.vtas = new System.Windows.Forms.TextBox();
            this.invIn = new System.Windows.Forms.TextBox();
            this.suelGer = new System.Windows.Forms.TextBox();
            this.publi = new System.Windows.Forms.TextBox();
            this.deVtas = new System.Windows.Forms.TextBox();
            this.Comp = new System.Windows.Forms.TextBox();
            this.gastCom = new System.Windows.Forms.TextBox();
            this.invFin = new System.Windows.Forms.TextBox();
            this.rentTiend = new System.Windows.Forms.TextBox();
            this.comVen = new System.Windows.Forms.TextBox();
            this.srvTele = new System.Windows.Forms.TextBox();
            this.empProd = new System.Windows.Forms.TextBox();
            this.rentOfi = new System.Windows.Forms.TextBox();
            this.devCom = new System.Windows.Forms.TextBox();
            this.oProd = new System.Windows.Forms.TextBox();
            this.oGastos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vtas
            // 
            this.vtas.Location = new System.Drawing.Point(25, 26);
            this.vtas.Name = "vtas";
            this.vtas.Size = new System.Drawing.Size(100, 20);
            this.vtas.TabIndex = 2;
            this.vtas.Text = "Ventas";
            // 
            // invIn
            // 
            this.invIn.Location = new System.Drawing.Point(142, 25);
            this.invIn.Name = "invIn";
            this.invIn.Size = new System.Drawing.Size(100, 20);
            this.invIn.TabIndex = 3;
            this.invIn.Text = "Inv Ini";
            // 
            // suelGer
            // 
            this.suelGer.Location = new System.Drawing.Point(25, 59);
            this.suelGer.Name = "suelGer";
            this.suelGer.Size = new System.Drawing.Size(100, 20);
            this.suelGer.TabIndex = 4;
            this.suelGer.Text = "Sueld gerent";
            // 
            // publi
            // 
            this.publi.Location = new System.Drawing.Point(142, 59);
            this.publi.Name = "publi";
            this.publi.Size = new System.Drawing.Size(100, 20);
            this.publi.TabIndex = 5;
            this.publi.Text = "Publi";
            // 
            // deVtas
            // 
            this.deVtas.Location = new System.Drawing.Point(248, 25);
            this.deVtas.Name = "deVtas";
            this.deVtas.Size = new System.Drawing.Size(100, 20);
            this.deVtas.TabIndex = 6;
            this.deVtas.Text = "Dev vtas";
            // 
            // Comp
            // 
            this.Comp.Location = new System.Drawing.Point(248, 59);
            this.Comp.Name = "Comp";
            this.Comp.Size = new System.Drawing.Size(100, 20);
            this.Comp.TabIndex = 7;
            this.Comp.Text = "Cmpras";
            // 
            // gastCom
            // 
            this.gastCom.Location = new System.Drawing.Point(363, 25);
            this.gastCom.Name = "gastCom";
            this.gastCom.Size = new System.Drawing.Size(100, 20);
            this.gastCom.TabIndex = 8;
            this.gastCom.Text = "Gast Com";
            // 
            // invFin
            // 
            this.invFin.Location = new System.Drawing.Point(363, 59);
            this.invFin.Name = "invFin";
            this.invFin.Size = new System.Drawing.Size(100, 20);
            this.invFin.TabIndex = 9;
            this.invFin.Text = "Inv final";
            // 
            // rentTiend
            // 
            this.rentTiend.Location = new System.Drawing.Point(25, 85);
            this.rentTiend.Name = "rentTiend";
            this.rentTiend.Size = new System.Drawing.Size(100, 20);
            this.rentTiend.TabIndex = 10;
            this.rentTiend.Text = "Rent tind";
            // 
            // comVen
            // 
            this.comVen.Location = new System.Drawing.Point(142, 85);
            this.comVen.Name = "comVen";
            this.comVen.Size = new System.Drawing.Size(100, 20);
            this.comVen.TabIndex = 11;
            this.comVen.Text = "Com Vende";
            // 
            // srvTele
            // 
            this.srvTele.Location = new System.Drawing.Point(248, 85);
            this.srvTele.Name = "srvTele";
            this.srvTele.Size = new System.Drawing.Size(100, 20);
            this.srvTele.TabIndex = 12;
            this.srvTele.Text = "Srv Tele";
            // 
            // empProd
            // 
            this.empProd.Location = new System.Drawing.Point(363, 85);
            this.empProd.Name = "empProd";
            this.empProd.Size = new System.Drawing.Size(100, 20);
            this.empProd.TabIndex = 13;
            this.empProd.Text = "emp prod";
            // 
            // rentOfi
            // 
            this.rentOfi.Location = new System.Drawing.Point(469, 25);
            this.rentOfi.Name = "rentOfi";
            this.rentOfi.Size = new System.Drawing.Size(100, 20);
            this.rentOfi.TabIndex = 14;
            this.rentOfi.Text = "Rent Ofi";
            // 
            // devCom
            // 
            this.devCom.Location = new System.Drawing.Point(469, 59);
            this.devCom.Name = "devCom";
            this.devCom.Size = new System.Drawing.Size(100, 20);
            this.devCom.TabIndex = 15;
            this.devCom.Text = "Dev comp";
            // 
            // oProd
            // 
            this.oProd.Location = new System.Drawing.Point(469, 85);
            this.oProd.Name = "oProd";
            this.oProd.Size = new System.Drawing.Size(100, 20);
            this.oProd.TabIndex = 16;
            this.oProd.Text = "otro prod";
            // 
            // oGastos
            // 
            this.oGastos.Location = new System.Drawing.Point(25, 111);
            this.oGastos.Name = "oGastos";
            this.oGastos.Size = new System.Drawing.Size(100, 20);
            this.oGastos.TabIndex = 17;
            this.oGastos.Text = "otro gastos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.oGastos);
            this.Controls.Add(this.oProd);
            this.Controls.Add(this.devCom);
            this.Controls.Add(this.rentOfi);
            this.Controls.Add(this.empProd);
            this.Controls.Add(this.srvTele);
            this.Controls.Add(this.comVen);
            this.Controls.Add(this.rentTiend);
            this.Controls.Add(this.invFin);
            this.Controls.Add(this.gastCom);
            this.Controls.Add(this.Comp);
            this.Controls.Add(this.deVtas);
            this.Controls.Add(this.publi);
            this.Controls.Add(this.suelGer);
            this.Controls.Add(this.invIn);
            this.Controls.Add(this.vtas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vtas;
        private System.Windows.Forms.TextBox invIn;
        private System.Windows.Forms.TextBox suelGer;
        private System.Windows.Forms.TextBox publi;
        private System.Windows.Forms.TextBox deVtas;
        private System.Windows.Forms.TextBox Comp;
        private System.Windows.Forms.TextBox gastCom;
        private System.Windows.Forms.TextBox invFin;
        private System.Windows.Forms.TextBox rentTiend;
        private System.Windows.Forms.TextBox comVen;
        private System.Windows.Forms.TextBox srvTele;
        private System.Windows.Forms.TextBox empProd;
        private System.Windows.Forms.TextBox rentOfi;
        private System.Windows.Forms.TextBox devCom;
        private System.Windows.Forms.TextBox oProd;
        private System.Windows.Forms.TextBox oGastos;
    }
}

