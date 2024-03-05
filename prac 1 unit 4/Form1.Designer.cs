namespace prac_1_unit_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtedad = new TextBox();
            btnguardar = new Button();
            btnlimpiar = new Button();
            Grilla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grilla).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 45);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 90);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Edad :";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(133, 38);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(296, 27);
            txtnombre.TabIndex = 2;
            // 
            // txtedad
            // 
            txtedad.Location = new Point(112, 83);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(85, 27);
            txtedad.TabIndex = 3;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(480, 36);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(128, 74);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.Location = new Point(636, 36);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(120, 74);
            btnlimpiar.TabIndex = 5;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = true;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // Grilla
            // 
            Grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla.Location = new Point(56, 135);
            Grilla.Name = "Grilla";
            Grilla.RowHeadersWidth = 51;
            Grilla.RowTemplate.Height = 29;
            Grilla.Size = new Size(640, 303);
            Grilla.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Grilla);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(txtedad);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtedad;
        private Button btnguardar;
        private Button btnlimpiar;
        private DataGridView Grilla;
    }
}