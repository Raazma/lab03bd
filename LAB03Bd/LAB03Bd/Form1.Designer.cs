namespace LAB03Bd
{
   partial class Form1
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
         this.Tb_Nom = new System.Windows.Forms.TextBox();
         this.Tb_Prenon = new System.Windows.Forms.TextBox();
         this.Tb_Sal = new System.Windows.Forms.TextBox();
         this.Tb_Codedep = new System.Windows.Forms.TextBox();
         this.lBL_NumEmp = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.Btn_Precedent = new System.Windows.Forms.Button();
         this.Btn_suivant = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // Tb_Nom
         // 
         this.Tb_Nom.Location = new System.Drawing.Point(69, 105);
         this.Tb_Nom.Name = "Tb_Nom";
         this.Tb_Nom.Size = new System.Drawing.Size(100, 20);
         this.Tb_Nom.TabIndex = 0;
         // 
         // Tb_Prenon
         // 
         this.Tb_Prenon.Location = new System.Drawing.Point(69, 160);
         this.Tb_Prenon.Name = "Tb_Prenon";
         this.Tb_Prenon.Size = new System.Drawing.Size(100, 20);
         this.Tb_Prenon.TabIndex = 1;
         // 
         // Tb_Sal
         // 
         this.Tb_Sal.Location = new System.Drawing.Point(69, 209);
         this.Tb_Sal.Name = "Tb_Sal";
         this.Tb_Sal.Size = new System.Drawing.Size(100, 20);
         this.Tb_Sal.TabIndex = 2;
         // 
         // Tb_Codedep
         // 
         this.Tb_Codedep.Location = new System.Drawing.Point(69, 260);
         this.Tb_Codedep.Name = "Tb_Codedep";
         this.Tb_Codedep.Size = new System.Drawing.Size(100, 20);
         this.Tb_Codedep.TabIndex = 3;
         // 
         // lBL_NumEmp
         // 
         this.lBL_NumEmp.AutoSize = true;
         this.lBL_NumEmp.Location = new System.Drawing.Point(95, 58);
         this.lBL_NumEmp.Name = "lBL_NumEmp";
         this.lBL_NumEmp.Size = new System.Drawing.Size(35, 13);
         this.lBL_NumEmp.TabIndex = 4;
         this.lBL_NumEmp.Text = "label1";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(12, 58);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(50, 13);
         this.label1.TabIndex = 5;
         this.label1.Text = "NumEmp";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(12, 105);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(29, 13);
         this.label2.TabIndex = 6;
         this.label2.Text = "Nom";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(-2, 160);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(43, 13);
         this.label3.TabIndex = 7;
         this.label3.Text = "Prenom";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(-2, 209);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(39, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "Salaire";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(-2, 263);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(55, 13);
         this.label5.TabIndex = 9;
         this.label5.Text = "Code Dep";
         // 
         // Btn_Precedent
         // 
         this.Btn_Precedent.Location = new System.Drawing.Point(7, 308);
         this.Btn_Precedent.Name = "Btn_Precedent";
         this.Btn_Precedent.Size = new System.Drawing.Size(46, 23);
         this.Btn_Precedent.TabIndex = 10;
         this.Btn_Precedent.Text = "<<";
         this.Btn_Precedent.UseVisualStyleBackColor = true;
         this.Btn_Precedent.Click += new System.EventHandler(this.Btn_Precedent_Click);
         // 
         // Btn_suivant
         // 
         this.Btn_suivant.Location = new System.Drawing.Point(84, 308);
         this.Btn_suivant.Name = "Btn_suivant";
         this.Btn_suivant.Size = new System.Drawing.Size(46, 23);
         this.Btn_suivant.TabIndex = 11;
         this.Btn_suivant.Text = ">>";
         this.Btn_suivant.UseVisualStyleBackColor = true;
         this.Btn_suivant.Click += new System.EventHandler(this.Btn_suivant_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(409, 394);
         this.Controls.Add(this.Btn_suivant);
         this.Controls.Add(this.Btn_Precedent);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lBL_NumEmp);
         this.Controls.Add(this.Tb_Codedep);
         this.Controls.Add(this.Tb_Sal);
         this.Controls.Add(this.Tb_Prenon);
         this.Controls.Add(this.Tb_Nom);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox Tb_Nom;
      private System.Windows.Forms.TextBox Tb_Prenon;
      private System.Windows.Forms.TextBox Tb_Sal;
      private System.Windows.Forms.TextBox Tb_Codedep;
      private System.Windows.Forms.Label lBL_NumEmp;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Button Btn_Precedent;
      private System.Windows.Forms.Button Btn_suivant;
   }
}

