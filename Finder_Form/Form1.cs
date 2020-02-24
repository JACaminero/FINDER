using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using DataLayer.Data;
using DataLayer.Business;
using DataLayer;

namespace Finder_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static BusinessUsuario businessUsuario = new BusinessUsuario();
        static UsuarioValidator usuarioValidator = new UsuarioValidator();
        static FileManager fileManager = new FileManager();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            BusinessSexo businessSexo = new BusinessSexo();
            CbSexo.DataSource = businessSexo.SelectAll();
            CbSexo.DisplayMember = "NombreSexo";
            CbSexo.ValueMember = "ID_Sexo";

            LoadDataGridWithAll();

            TxtPatrimonio.Maximum = int.MaxValue;
        }

        private bool SomeoneIsSelected
        {
            get
            {
                if (int.TryParse(TxtID.Text, out int result))
                {
                    return true;
                }
                else
                    return false;
            }
        }

        private void TxtBio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Gets todos los usuarios que hay en la base de datos
        /// </summary>
        public void LoadDataGridWithAll()
        {
            DataGVUsuario.DataSource = businessUsuario.SelectAll();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.FechaNacimiento = dateNacimiento.Value;
            usuario.Bio = TxtBio.Text;
            usuario.Localizacion = TxtLocalizacion.Text;
            usuario.Nombre = TxtNombre.Text;
            usuario.Patrimonio = TxtPatrimonio.Value;
            usuario.Sexo = new Sexo(Convert.ToInt32(CbSexo.SelectedValue));
            usuario.Imagen = fileManager.GetStream(pictureBox2.ImageLocation);


            var validationResult = usuarioValidator.Validate(usuario);

            if (validationResult.IsValid)
            {
                businessUsuario.Insert(usuario);
                Clear();
                MessageBox.Show("Operacion Exitosa");
                LoadDataGridWithAll();
            }
            else
            {
                foreach (var failure in validationResult.Errors)
                {
                    if (failure.AttemptedValue != null)
                    {
                        MessageBox.Show("El valor de " + failure.PropertyName + " no esta en un formato correcto. El mensaje de Error es: " + failure.ErrorMessage);
                    }
                }
            }
        }

        private void DataGVUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario selectedUsuario = (Usuario)DataGVUsuario.CurrentRow.DataBoundItem;

            TxtID.Text = selectedUsuario.ID.ToString();
            TxtNombre.Text = selectedUsuario.Nombre;
            TxtPatrimonio.Value = selectedUsuario.Patrimonio;
            TxtBio.Text = selectedUsuario.Bio;
            TxtLocalizacion.Text = selectedUsuario.Localizacion;
            dateNacimiento.Value = selectedUsuario.FechaNacimiento;
            pictureBox2.Image = fileManager.GetFile(selectedUsuario.Imagen);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (SomeoneIsSelected)
            {
                DialogResult result = MessageBox.Show("Deseas EXTERMINAR este usuario? o.O"
                    , "EXTERMINATE!!!! >:("
                    , MessageBoxButtons.YesNo);
                
                if (result == DialogResult.Yes)
                {
                    businessUsuario.Delete(int.Parse(TxtID.Text));
                    LoadDataGridWithAll();
                    Clear();
                }
            }
            else
                MessageBox.Show("Seleccione a quien desea eliminar.");
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Usuario usuario = businessUsuario.GetWithId(int.Parse(TxtID.Text));

            usuario.FechaNacimiento = dateNacimiento.Value;
            usuario.Bio = TxtBio.Text;
            usuario.Localizacion = TxtLocalizacion.Text;
            usuario.Nombre = TxtNombre.Text;
            usuario.Patrimonio = TxtPatrimonio.Value;
            usuario.Sexo = new Sexo(Convert.ToInt32(CbSexo.SelectedValue));
            usuario.ID = Convert.ToInt32(TxtID.Text);
            usuario.Imagen = fileManager.GetStream(pictureBox2.Image);
            var validationResult = usuarioValidator.Validate(usuario);

            if (validationResult.IsValid)
            {
                businessUsuario.Update(usuario);
                Clear();
                MessageBox.Show("Operacion Exitosa");
                LoadDataGridWithAll();
            }

            else
            {
                foreach (var failure in validationResult.Errors)
                {
                    if (failure.AttemptedValue != null)
                    {
                        MessageBox.Show("El valor del nombre " + failure.PropertyName + " no esta en un formato correcto. El mensaje de Error es: " + failure.ErrorMessage);
                    }
                }
            }
        }

        private void Clear()
        {
            TxtNombre.Clear();
            TxtID.Clear();
            dateNacimiento.Value = DateTime.Now;
            TxtBio.Clear();
            TxtLocalizacion.Clear();
            TxtPatrimonio.Value = TxtPatrimonio.Minimum;
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            LoadDataGridWithAll();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();

            string path = dialog.FileName;
            if (!string.IsNullOrEmpty(path))
            {
                Image image = Image.FromFile(path);
                pictureBox2.Image = image;
                pictureBox2.ImageLocation = path;
            }
        }
    }
}
