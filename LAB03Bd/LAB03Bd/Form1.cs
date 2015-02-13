using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
namespace LAB03Bd
{
   public partial class Form1 : Form
   {
      public OracleConnection oraconn = new OracleConnection();
      public DataSet data = new DataSet();
      
      public Form1()
      {
         InitializeComponent();
   
      }
       public void Connection()
        {
           
            
            string Dsource = "(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
              "(HOST=205.237.244.251)(PORT=1521)))" + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
            string chainedeconnexion = "DATA SOURCE =" + Dsource + ";USER ID =  PAQUETTE;PASSWORD = ORACLE1";
            
            try
            {
                 oraconn.ConnectionString = chainedeconnexion;
                 oraconn.Open();
            }

            catch (OracleException ex)
            {
                MessageBox.Show("La conection a echouer");
            }
        }

       private void Form1_Load(object sender, EventArgs e)
       {
          Connection();
          Filledliste();
          Filled();
       }

       private void Filled()
       {
           Clear();
          OracleCommand ObjSelct = new OracleCommand("Employes", oraconn);       
          ObjSelct.CommandType = CommandType.StoredProcedure;
          ObjSelct.CommandText = " GESTIONEMPLOYES.LISTER";
          OracleParameter liste = new OracleParameter("liste", OracleDbType.RefCursor);
          liste.Direction = ParameterDirection.ReturnValue;
          OracleParameter codedep = new OracleParameter("code", OracleDbType.Char, 3);
          codedep.Direction = ParameterDirection.Input;
          codedep.Value = Lb_Codedep.SelectedItem.ToString();
          ObjSelct.Parameters.Add(liste);
          ObjSelct.Parameters.Add(codedep);
         // ObjSelct.ExecuteNonQuery();
          OracleDataAdapter Info = new OracleDataAdapter(ObjSelct);
          Info.Fill(data, "Lister");
          BindInfo();

       }
      private void BindInfo()
       {
         
          lBL_NumEmp.DataBindings.Add("Text", data, "lister.numemp");
          Tb_Nom.DataBindings.Add("Text", data, "lister.nomemp");
          Tb_Prenon.DataBindings.Add("Text", data, "lister.prenomemp");
          Tb_Sal.DataBindings.Add("Text", data, "lister.salaireemp");               
      }

      private void Filledliste()
      { 
      
              string sql = "select codedep from EMPLOYESCLG";
            OracleCommand oraclecomm = new OracleCommand(sql, oraconn);

            
          OracleDataReader oraread = oraclecomm.ExecuteReader();
           while (oraread.Read())
           {             
               Lb_Codedep.Items.Add(oraread.GetString(0));
           }

           Lb_Codedep.SelectedIndex = 1;
      }
      private void Btn_suivant_Click(object sender, EventArgs e)
      {
         this.BindingContext[data, "lister"].Position += 1;
      }

      private void Btn_Precedent_Click(object sender, EventArgs e)
      {
         this.BindingContext[data, "lister"].Position -= 1;
      }

      private void Lb_Codedep_SelectedIndexChanged(object sender, EventArgs e)
      {
          Filled();
      }
      private void Clear()
      {
          data.Clear();
          lBL_NumEmp.DataBindings.Clear();
          Tb_Nom.DataBindings.Clear();
          Tb_Prenon.DataBindings.Clear();
          Tb_Sal.DataBindings.Clear();       
      }

      private void Btn_supprimer_Click(object sender, EventArgs e)
      {
          OracleCommand ObjSelct = new OracleCommand("Delete", oraconn);
          ObjSelct.CommandType = CommandType.StoredProcedure;
          ObjSelct.CommandText = " GESTIONEMPLOYES.SUPPRIMER";
          OracleParameter codeemp = new OracleParameter("numemp",OracleDbType.Int32);
          codeemp.Direction = ParameterDirection.Input;
          codeemp.Value = lBL_NumEmp.Text;
          ObjSelct.Parameters.Add(codeemp);
         int i = ObjSelct.ExecuteNonQuery();

         MessageBox.Show(i.ToString());
      }

      private void Btn_update_Click(object sender, EventArgs e)
      {
          OracleCommand ObjSelct = new OracleCommand("update", oraconn);
          ObjSelct.CommandType = CommandType.StoredProcedure;
          ObjSelct.CommandText = " GESTIONEMPLOYES.MJOUR";
          OracleParameter codeemp = new OracleParameter("numemp", OracleDbType.Int32);
          OracleParameter aug = new OracleParameter("aug", OracleDbType.Int32);
          codeemp.Direction = ParameterDirection.Input;
          aug.Direction = ParameterDirection.Input;
          aug.Value = Tb_Sal.Text;
          codeemp.Value = lBL_NumEmp.Text;
          ObjSelct.Parameters.Add(codeemp);
          ObjSelct.Parameters.Add(aug);
          int i = ObjSelct.ExecuteNonQuery();

          MessageBox.Show(i.ToString());
      }

      private void Btn_Nbpersonne_Click(object sender, EventArgs e)
      {
          OracleCommand ObjSelct = new OracleCommand(" NBEMPLOYES", oraconn);
          ObjSelct.CommandType = CommandType.StoredProcedure;
          ObjSelct.CommandText = " GESTIONEMPLOYES.NBEMPLOYES";
          OracleParameter codeemp = new OracleParameter("numemp", OracleDbType.Int32);
        
          codeemp.Direction = ParameterDirection.ReturnValue;
     
          ObjSelct.Parameters.Add(codeemp);
        
           ObjSelct.ExecuteNonQuery();

          MessageBox.Show("il y a "+codeemp.Value.ToString() + " employes");
       }

      private void Btn_recherche_Click(object sender, EventArgs e)
      {
         clearBinding();
          OracleCommand ObjSelct = new OracleCommand("Employes", oraconn);
          ObjSelct.CommandType = CommandType.StoredProcedure;
          ObjSelct.CommandText = " GESTIONEMPLOYES.RECHERCHER";
          OracleParameter Result = new OracleParameter("liste", OracleDbType.RefCursor);
         Result.Direction = ParameterDirection.Output;
          OracleParameter codedep = new OracleParameter("code", OracleDbType.Varchar2, 30);
          codedep.Direction = ParameterDirection.Input;
          codedep.Value = Tb__Recherche.Text;
          
          ObjSelct.Parameters.Add(codedep);
           ObjSelct.Parameters.Add( Result);
          OracleDataAdapter Info = new OracleDataAdapter(ObjSelct);
          Info.Fill(data, "Recherche");

          FilledRbox();
          
      }
      private void FilledRbox()
      {
         Tb_RName.DataBindings.Add("TEXT", data, "Recherche.nomemp");
         Tb_rPrenom.DataBindings.Add("TEXT", data, "Recherche.prenomemp");
         Tb_rSalaire.DataBindings.Add("TEXT", data, "Recherche.salaireemp");
         Tb_Code.DataBindings.Add("TEXT", data, "Recherche.codedep");
      }
      private void clearBinding()
      {
         data.Clear();
         Tb_RName.DataBindings.Clear();
         Tb_rPrenom.DataBindings.Clear();
         Tb_rSalaire.DataBindings.Clear();
         Tb_Code.DataBindings.Clear();
      }

      private void Btn_Ajouter_Click(object sender, EventArgs e)
      {

         OracleCommand ObjSelct = new OracleCommand("Employes", oraconn);
         ObjSelct.CommandType = CommandType.StoredProcedure;
         ObjSelct.CommandText = " GESTIONEMPLOYES.INSERTION";

         OracleParameter name = new OracleParameter("name", OracleDbType.Varchar2, 30);
         name.Direction = ParameterDirection.Input;
         name.Value = Tb_Iname.Text;       
         ObjSelct.Parameters.Add(name);

         OracleParameter prenom = new OracleParameter("prenom", OracleDbType.Varchar2, 30);
         prenom.Direction = ParameterDirection.Input;
         prenom.Value = Tb_Iprenom.Text;
         ObjSelct.Parameters.Add(prenom);

         OracleParameter salaire = new OracleParameter("salaire", OracleDbType.Int32);
         salaire.Direction = ParameterDirection.Input;
         salaire.Value = Tb_ISalaire.Text;
         ObjSelct.Parameters.Add(salaire);

         OracleParameter code = new OracleParameter("codedep", OracleDbType.Char, 3);
         code.Direction = ParameterDirection.Input;
         code.Value = Tb_ICodeDep.Text;
         ObjSelct.Parameters.Add(code);

         int i =ObjSelct.ExecuteNonQuery();

         MessageBox.Show(i.ToString());

      }
    }
   }

