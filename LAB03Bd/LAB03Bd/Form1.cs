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
          Filled();
       }

       private void Filled()
       {
          OracleCommand ObjSelct = new OracleCommand("Employes", oraconn);
         
          ObjSelct.CommandType = CommandType.StoredProcedure;
          ObjSelct.CommandText = " GESTIONEMPLOYES.LISTER";
          OracleParameter liste = new OracleParameter("liste", OracleDbType.RefCursor);
          liste.Direction = ParameterDirection.ReturnValue;
          OracleParameter codedep = new OracleParameter("code", OracleDbType.Char, 3);
          codedep.Direction = ParameterDirection.Input;
          codedep.Value = "INF";
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

      private void Btn_suivant_Click(object sender, EventArgs e)
      {
         this.BindingContext[data, "lister"].Position += 1;
      }

      private void Btn_Precedent_Click(object sender, EventArgs e)
      {
         this.BindingContext[data, "lister"].Position -= 1;
      }
   }
}
