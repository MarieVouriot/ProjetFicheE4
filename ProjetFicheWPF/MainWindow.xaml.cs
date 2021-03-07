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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjetFicheWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        fiche_revisionEntities gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new fiche_revisionEntities();

        }

        private void btnInscription_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, RoutedEventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtMessageErreur.Text = "Veuillez saisir votre nom";
            }
            else
            {
                if (txtPrenom.Text == "")
                {
                    txtMessageErreur.Text = "Veuillez saisir votre prénom";
                }
                else
                {
                    if (txtMdp.Text == "")
                    {
                        txtMessageErreur.Text = "Veuillez saisir votre mot de passe";
                    }
                    else
                    {
                        medecin unMedecin = gst.medecin.ToList().Find(med => med.nomMedecin == txtNom.Text && med.prenomMedecin == txtPrenom.Text && med.mdp == txtMdp.Text);
                        if(unMedecin == null)
                        {
                            txtMessageErreur.Text = "Vos identifiants sont incorrects";
                        }
                        else
                        {
                            if(unMedecin.idStatut == 1) // admin
                            {
                                frmAdmin frm = new frmAdmin();
                                frm.Show();
                            }
                            else // utilisateur
                            {
                                frmUtilisateur frm = new frmUtilisateur();
                                frm.Show();
                            }
                        }

                    }
                }
            }
        }
    }
}
