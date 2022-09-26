using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using veterinaria_1._3.Servicios;

namespace veterinaria_1._3
{
    public partial class AtencionVet : Form
    {
        private IServicio gestor;   

        private void habilitar(bool v)
        {            
            txtAtencion.Enabled = v; 
            txtApellido.Enabled = v;
            dtpFecha.Enabled = v;
            txtDni.Enabled = v;
            txtImporte.Enabled=v;
            txtMascota.Enabled=v;
            txtNombre.Enabled=v;
            cboTipo.Enabled=v;
            txtEdad.Enabled=v;
            btnNuevo.Enabled=!v;
            btnSalir.Enabled=!v;
            btnGrabar.Enabled=v;
            btnBorrar.Enabled=v;
            btnEditar.Enabled=v;
            btnCancelar.Enabled=v;
        }
        public AtencionVet()
        {
            InitializeComponent();
            gestor = new Servicio();
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            habilitar(false);
            cargarCombo();
            proximoCliente();
            this.ActiveControl = txtApellido;
        }
        private void proximoCliente()
        {
            int next = gestor.ObtenerProximo();

            if (next > 0)
                lblNroCliente.Text = "Cliente Nro:" + next.ToString();
            else
                MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void limpiar()
        {
            txtNombre.Text="";
            txtImporte.Text="";
            txtApellido.Text=String.Empty;
            txtDni.Text=String.Empty;
            txtEdad.Text="";
            txtMascota.Text="";
            txtAtencion.Text="";
            cboTipo.SelectedIndex= -1;
        }


        //private void cargarLista()
        //{            
        //    dgvMascotas.Rows.Clear();

        //    DataTable tabla = helper.conectarBD("CargarLista8");
           
        //    foreach (DataRow fila in tabla.Rows)
        //    {
        //        Veterinaria v = new Veterinaria();
        //        v.Mascota.Cliente.Apellido =Convert.ToString(fila[0]);
        //        v.Mascota.Cliente.Nombre=Convert.ToString(fila[1]);
        //        v.Mascota.Cliente.Dni=Convert.ToInt32(fila[2]);
        //        v.Mascota.Nombre=Convert.ToString(fila[3]);
        //        v.Mascota.Edad=Convert.ToInt32(fila[4]);
        //        v.Importe=Convert.ToDouble(fila[5]);
        //        v.Atencion=Convert.ToString(fila[6]);

        //        //    lVeterinaria.Add(v);
        //        //    lstMascotas.Items.Add(v);}

                
        //        dgvMascotas.Rows.Add(
        //            new object[] {
        //            v.Mascota.Cliente.Apellido,
        //            v.Mascota.Cliente.Nombre,
        //            v.Mascota.Cliente.Dni,
        //            v.Mascota.Nombre,
        //            v.Mascota.Edad,
        //            v.Importe,
        //            v.Atencion
        //        });
        //   }
        
   // }

         private void cargarCombo()
        {
            DataTable tabla = Helper.ObtenerInstancia().conectarBD("sp_combo");
            cboTipo.DataSource=tabla;
            cboTipo.ValueMember=tabla.Columns[0].ColumnName;
            cboTipo.DisplayMember=tabla.Columns[1].ColumnName;
            cboTipo.DropDownStyle=ComboBoxStyle.DropDownList;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
        }
        private bool validar()
        {
            if(txtMascota.Text=="")
            {
                MessageBox.Show("Tiene que agregar el nombre de la mascota para continuar");
                txtMascota.Focus();
                return false;
            }
            if(txtEdad.Text=="")
            {
                MessageBox.Show("Tiene que agregar la edad de la mascota para continuar");
                txtEdad.Focus();
                return false;
            }
            if(txtImporte.Text=="")
            {
                MessageBox.Show("Tiene que agregar el importe de la consulta para continuar");
                txtImporte.Focus();
                return false;
            }
            if(txtNombre.Text=="")
            {
                MessageBox.Show("Tiene que agregar el nombre del cliente para continuar");
                txtNombre.Focus();
                return false;
            }
            if(cboTipo.SelectedIndex==-1)
            {
                MessageBox.Show("Tiene que seleccionar un tipo de mascota para continuar");
                cboTipo.Focus();
                return false;
            }
            if (txtAtencion.Text=="")
            {
                MessageBox.Show("Tiene que agregar detalles de consulta para continuar");
                txtAtencion.Focus();
                return false;
            }
            return true;
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtCodCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitar(true);
            btnSalir.Enabled=true;
            limpiar();
                        
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Seguro quiere salir de la aplicacion??","SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop,
                MessageBoxDefaultButton.Button2 )==DialogResult.Yes)
                Close();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            habilitar(true);

            dgvMascotas.Rows.Clear();

            DataTable tabla = Helper.ObtenerInstancia().conectarBD("CargarLista8");
           
            foreach (DataRow fila in tabla.Rows)
            {
                //Veterinaria v = new Veterinaria();
                //v.Mascota.Cliente.Apellido =Convert.ToString(fila[0]);
                //v.Mascota.Cliente.Nombre=Convert.ToString(fila[1]);
                //v.Mascota.Cliente.Dni=Convert.ToInt32(fila[2]);
                //v.Mascota.Nombre=Convert.ToString(fila[3]);
                //v.Mascota.Edad=Convert.ToInt32(fila[4]);
                //v.Importe=Convert.ToDouble(fila[5]);
                //v.Atencion=Convert.ToString(fila[6]);

              //dgvMascotas.Rows.Add(
              //      new object[] {
              //          v.Mascota.Cliente.Apellido,
              //          v.Mascota.Cliente.Nombre,
              //          v.Mascota.Cliente.Dni,
              //          v.Mascota.Nombre,
              //          v.Mascota.Edad,
              //          v.Importe,
              //          v.Atencion
              //  });
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvMascotas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMascotas.CurrentRow.Index != -1)
            {
                txtApellido.Text=dgvMascotas.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text=dgvMascotas.CurrentRow.Cells[1].Value.ToString();
                txtDni.Text=dgvMascotas.CurrentRow.Cells[2].Value.ToString();
                txtEdad.Text=(dgvMascotas.CurrentRow.Cells[3].Value.ToString());
                //cboTipo.SelectedValue= dgvMascotas.CurrentRow.Cells[3].Value;
                txtMascota.Text=dgvMascotas.CurrentRow.Cells[4].Value.ToString();
                txtImporte.Text=dgvMascotas.CurrentRow.Cells[5].Value.ToString();
                txtAtencion.Text=dgvMascotas.CurrentRow.Cells[6].Value.ToString();
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;

            }

        }
        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
           
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            habilitar(false);
            btnEditar.Enabled=false;
            btnBorrar.Enabled=false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
              

                //v.Mascota.Cliente.Nombre=txtNombre.Text;
                //v.Mascota.Cliente.Apellido=txtApellido.Text;
                //v.Mascota.Cliente.Dni=Convert.ToInt32(txtDni.Text);
                //v.Mascota.Tipo=Convert.ToInt32(cboTipo.SelectedValue);
                //v.Mascota.Nombre=txtMascota.Text;
                //v.Mascota.Edad=Convert.ToInt32(txtEdad.Text);
                //v.Importe=Convert.ToDouble(txtImporte.Text);
                //v.Fecha=Convert.ToDateTime(dtpFecha.Value);
                //v.Atencion=Convert.ToString(txtAtencion.Text);

            
               //dgvMascotas.Rows.Add(
               //         new object[] {
               //             v.Mascota.Cliente.Apellido,
               //             v.Mascota.Cliente.Nombre,
               //             v.Mascota.Cliente.Dni,
               //             v.Mascota.Nombre,
               //             v.Mascota.Edad,
               //             v.Importe,
               //             v.Atencion
                    //});



                }
        }
    }
}
