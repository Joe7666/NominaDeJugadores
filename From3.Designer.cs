
namespace NominaDeJugadores
{
    partial class From3
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
            this.btnVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtPosicion = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPosicion = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Beige;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(190, 135);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(89, 33);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(549, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese la posicion para visualizar que jugadores tiene en dicha posicion";
            // 
            // mtxtPosicion
            // 
            this.mtxtPosicion.Location = new System.Drawing.Point(262, 87);
            this.mtxtPosicion.Mask = "LLLLLLLLLLLLLLL";
            this.mtxtPosicion.Name = "mtxtPosicion";
            this.mtxtPosicion.Size = new System.Drawing.Size(132, 22);
            this.mtxtPosicion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar:";
            // 
            // dgvPosicion
            // 
            this.dgvPosicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosicion.Location = new System.Drawing.Point(50, 174);
            this.dgvPosicion.Name = "dgvPosicion";
            this.dgvPosicion.RowHeadersWidth = 51;
            this.dgvPosicion.RowTemplate.Height = 24;
            this.dgvPosicion.Size = new System.Drawing.Size(584, 200);
            this.dgvPosicion.TabIndex = 4;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Beige;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(369, 135);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(86, 33);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Limpiar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // From3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 417);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.dgvPosicion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtPosicion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVer);
            this.Name = "From3";
            this.Text = "From3";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosicion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtPosicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPosicion;
        private System.Windows.Forms.Button btnBorrar;
    }
}