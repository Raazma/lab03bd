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
            this.lBL_NumEmp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Precedent = new System.Windows.Forms.Button();
            this.Btn_suivant = new System.Windows.Forms.Button();
            this.Lb_Codedep = new System.Windows.Forms.ListBox();
            this.Btn_supprimer = new System.Windows.Forms.Button();
            this.Btn_update = new System.Windows.Forms.Button();
            this.Btn_Nbpersonne = new System.Windows.Forms.Button();
            this.Btn_recherche = new System.Windows.Forms.Button();
            this.Tb_RName = new System.Windows.Forms.TextBox();
            this.Tb_rPrenom = new System.Windows.Forms.TextBox();
            this.Tb_rSalaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_Code = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Tb__Recherche = new System.Windows.Forms.TextBox();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_Nom
            // 
            this.Tb_Nom.Enabled = false;
            this.Tb_Nom.Location = new System.Drawing.Point(50, 109);
            this.Tb_Nom.Name = "Tb_Nom";
            this.Tb_Nom.Size = new System.Drawing.Size(100, 20);
            this.Tb_Nom.TabIndex = 0;
            // 
            // Tb_Prenon
            // 
            this.Tb_Prenon.Enabled = false;
            this.Tb_Prenon.Location = new System.Drawing.Point(50, 157);
            this.Tb_Prenon.Name = "Tb_Prenon";
            this.Tb_Prenon.Size = new System.Drawing.Size(100, 20);
            this.Tb_Prenon.TabIndex = 1;
            // 
            // Tb_Sal
            // 
            this.Tb_Sal.Location = new System.Drawing.Point(43, 209);
            this.Tb_Sal.Name = "Tb_Sal";
            this.Tb_Sal.Size = new System.Drawing.Size(100, 20);
            this.Tb_Sal.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(4, 112);
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
            // Btn_Precedent
            // 
            this.Btn_Precedent.Location = new System.Drawing.Point(12, 254);
            this.Btn_Precedent.Name = "Btn_Precedent";
            this.Btn_Precedent.Size = new System.Drawing.Size(46, 23);
            this.Btn_Precedent.TabIndex = 10;
            this.Btn_Precedent.Text = "<<";
            this.Btn_Precedent.UseVisualStyleBackColor = true;
            this.Btn_Precedent.Click += new System.EventHandler(this.Btn_Precedent_Click);
            // 
            // Btn_suivant
            // 
            this.Btn_suivant.Location = new System.Drawing.Point(84, 254);
            this.Btn_suivant.Name = "Btn_suivant";
            this.Btn_suivant.Size = new System.Drawing.Size(46, 23);
            this.Btn_suivant.TabIndex = 11;
            this.Btn_suivant.Text = ">>";
            this.Btn_suivant.UseVisualStyleBackColor = true;
            this.Btn_suivant.Click += new System.EventHandler(this.Btn_suivant_Click);
            // 
            // Lb_Codedep
            // 
            this.Lb_Codedep.FormattingEnabled = true;
            this.Lb_Codedep.Location = new System.Drawing.Point(170, 109);
            this.Lb_Codedep.Name = "Lb_Codedep";
            this.Lb_Codedep.Size = new System.Drawing.Size(70, 108);
            this.Lb_Codedep.TabIndex = 12;
            this.Lb_Codedep.SelectedIndexChanged += new System.EventHandler(this.Lb_Codedep_SelectedIndexChanged);
            // 
            // Btn_supprimer
            // 
            this.Btn_supprimer.Location = new System.Drawing.Point(12, 300);
            this.Btn_supprimer.Name = "Btn_supprimer";
            this.Btn_supprimer.Size = new System.Drawing.Size(66, 23);
            this.Btn_supprimer.TabIndex = 13;
            this.Btn_supprimer.Text = "Supprimer";
            this.Btn_supprimer.UseVisualStyleBackColor = true;
            this.Btn_supprimer.Click += new System.EventHandler(this.Btn_supprimer_Click);
            // 
            // Btn_update
            // 
            this.Btn_update.Location = new System.Drawing.Point(85, 300);
            this.Btn_update.Name = "Btn_update";
            this.Btn_update.Size = new System.Drawing.Size(58, 23);
            this.Btn_update.TabIndex = 14;
            this.Btn_update.Text = "Modifier";
            this.Btn_update.UseVisualStyleBackColor = true;
            this.Btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // Btn_Nbpersonne
            // 
            this.Btn_Nbpersonne.Location = new System.Drawing.Point(536, 48);
            this.Btn_Nbpersonne.Name = "Btn_Nbpersonne";
            this.Btn_Nbpersonne.Size = new System.Drawing.Size(106, 23);
            this.Btn_Nbpersonne.TabIndex = 15;
            this.Btn_Nbpersonne.Text = "Nombre Employe\\";
            this.Btn_Nbpersonne.UseVisualStyleBackColor = true;
            this.Btn_Nbpersonne.Click += new System.EventHandler(this.Btn_Nbpersonne_Click);
            // 
            // Btn_recherche
            // 
            this.Btn_recherche.Location = new System.Drawing.Point(460, 355);
            this.Btn_recherche.Name = "Btn_recherche";
            this.Btn_recherche.Size = new System.Drawing.Size(72, 27);
            this.Btn_recherche.TabIndex = 16;
            this.Btn_recherche.Text = "Rechercher";
            this.Btn_recherche.UseVisualStyleBackColor = true;
            this.Btn_recherche.Click += new System.EventHandler(this.Btn_recherche_Click);
            // 
            // Tb_RName
            // 
            this.Tb_RName.Location = new System.Drawing.Point(394, 102);
            this.Tb_RName.Name = "Tb_RName";
            this.Tb_RName.Size = new System.Drawing.Size(100, 20);
            this.Tb_RName.TabIndex = 17;
            // 
            // Tb_rPrenom
            // 
            this.Tb_rPrenom.Enabled = false;
            this.Tb_rPrenom.Location = new System.Drawing.Point(394, 145);
            this.Tb_rPrenom.Name = "Tb_rPrenom";
            this.Tb_rPrenom.Size = new System.Drawing.Size(100, 20);
            this.Tb_rPrenom.TabIndex = 18;
            // 
            // Tb_rSalaire
            // 
            this.Tb_rSalaire.Location = new System.Drawing.Point(394, 197);
            this.Tb_rSalaire.Name = "Tb_rSalaire";
            this.Tb_rSalaire.Size = new System.Drawing.Size(100, 20);
            this.Tb_rSalaire.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Prenom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Salaire";
            // 
            // Tb_Code
            // 
            this.Tb_Code.Location = new System.Drawing.Point(407, 237);
            this.Tb_Code.Name = "Tb_Code";
            this.Tb_Code.Size = new System.Drawing.Size(72, 20);
            this.Tb_Code.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Code Dep";
            // 
            // Tb__Recherche
            // 
            this.Tb__Recherche.Location = new System.Drawing.Point(555, 362);
            this.Tb__Recherche.Name = "Tb__Recherche";
            this.Tb__Recherche.Size = new System.Drawing.Size(102, 20);
            this.Tb__Recherche.TabIndex = 25;
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(404, 282);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 26;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 394);
            this.Controls.Add(this.Btn_Ajouter);
            this.Controls.Add(this.Tb__Recherche);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Tb_Code);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tb_rSalaire);
            this.Controls.Add(this.Tb_rPrenom);
            this.Controls.Add(this.Tb_RName);
            this.Controls.Add(this.Btn_recherche);
            this.Controls.Add(this.Btn_Nbpersonne);
            this.Controls.Add(this.Btn_update);
            this.Controls.Add(this.Btn_supprimer);
            this.Controls.Add(this.Lb_Codedep);
            this.Controls.Add(this.Btn_suivant);
            this.Controls.Add(this.Btn_Precedent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBL_NumEmp);
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
      private System.Windows.Forms.Label lBL_NumEmp;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button Btn_Precedent;
      private System.Windows.Forms.Button Btn_suivant;
      private System.Windows.Forms.ListBox Lb_Codedep;
      private System.Windows.Forms.Button Btn_supprimer;
      private System.Windows.Forms.Button Btn_update;
      private System.Windows.Forms.Button Btn_Nbpersonne;
      private System.Windows.Forms.Button Btn_recherche;
      private System.Windows.Forms.TextBox Tb_RName;
      private System.Windows.Forms.TextBox Tb_rPrenom;
      private System.Windows.Forms.TextBox Tb_rSalaire;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.TextBox Tb_Code;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.TextBox Tb__Recherche;
      private System.Windows.Forms.Button Btn_Ajouter;
   }
}

