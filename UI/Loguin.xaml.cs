using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Lógica de interacción para Loguin.xaml
    /// </summary>
    public partial class Loguin : Window
    {
        public Loguin()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContaseña.Text) || string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

          
            Entidade.ERegistroUser usuario = new Entidade.ERegistroUser
            {
                Email = txtEmail.Text,
                Contraseña = txtContaseña.Text
            };

            Negocio.NRegistroUser nRegistroUser = new Negocio.NRegistroUser();
            nRegistroUser.validarUsuario(usuario);

            bool exito = true;

            if (exito)
            {
                MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);
                // Aquí puedes abrir la ventana principal de la aplicación
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
    }
}
