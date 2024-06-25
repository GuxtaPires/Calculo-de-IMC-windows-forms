namespace Calculo_imc
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
            lbl_imc = new Label();
            btn_calc = new Button();
            txt_peso = new TextBox();
            txt_Altura = new TextBox();
            lbl_resultado = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 20.25F);
            label1.Location = new Point(264, 132);
            label1.Name = "label1";
            label1.Size = new Size(79, 37);
            label1.TabIndex = 0;
            label1.Text = "Peso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 20.25F);
            label2.Location = new Point(255, 178);
            label2.Name = "label2";
            label2.Size = new Size(94, 37);
            label2.TabIndex = 1;
            label2.Text = "Altura:";
            // 
            // lbl_imc
            // 
            lbl_imc.AutoSize = true;
            lbl_imc.Font = new Font("Leelawadee UI", 20.25F);
            lbl_imc.Location = new Point(361, 245);
            lbl_imc.Name = "lbl_imc";
            lbl_imc.Size = new Size(65, 37);
            lbl_imc.TabIndex = 2;
            lbl_imc.Text = "IMC";
            // 
            // btn_calc
            // 
            btn_calc.Font = new Font("Leelawadee UI", 20.25F);
            btn_calc.Location = new Point(305, 345);
            btn_calc.Name = "btn_calc";
            btn_calc.Size = new Size(160, 54);
            btn_calc.TabIndex = 3;
            btn_calc.Text = "Calcular";
            btn_calc.UseVisualStyleBackColor = true;
            btn_calc.Click += btn_calc_Click;
            // 
            // txt_peso
            // 
            txt_peso.Font = new Font("Leelawadee UI", 20.25F);
            txt_peso.Location = new Point(349, 129);
            txt_peso.Name = "txt_peso";
            txt_peso.Size = new Size(100, 43);
            txt_peso.TabIndex = 4;
            txt_peso.TextChanged += peso_TextChanged;
            // 
            // txt_Altura
            // 
            txt_Altura.Font = new Font("Leelawadee UI", 20.25F);
            txt_Altura.Location = new Point(349, 175);
            txt_Altura.Name = "txt_Altura";
            txt_Altura.Size = new Size(100, 43);
            txt_Altura.TabIndex = 5;
            // 
            // lbl_resultado
            // 
            lbl_resultado.AutoSize = true;
            lbl_resultado.Font = new Font("Leelawadee UI", 20.25F);
            lbl_resultado.Location = new Point(336, 277);
            lbl_resultado.Name = "lbl_resultado";
            lbl_resultado.Size = new Size(0, 37);
            lbl_resultado.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 26.2499962F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(264, 29);
            label3.Name = "label3";
            label3.Size = new Size(263, 43);
            label3.TabIndex = 7;
            label3.Text = "Calcule seu IMC!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lbl_resultado);
            Controls.Add(txt_Altura);
            Controls.Add(txt_peso);
            Controls.Add(btn_calc);
            Controls.Add(lbl_imc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lbl_imc;
        private Button btn_calc;
        private TextBox txt_peso;
        private TextBox txt_Altura;
        private Label lbl_resultado;
        private Label label3;
    }
}
