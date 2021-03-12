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

namespace ProjetFicheWPF
{
    /// <summary>
    /// Logique d'interaction pour frmUtilisateur.xaml
    /// </summary>
    public partial class frmUtilisateur : Window
    {
        fiche_revisionEntities gst;
        public frmUtilisateur(fiche_revisionEntities unGst)
        {
            InitializeComponent();
            gst = unGst;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboTheme.ItemsSource = gst.theme_fiche.ToList();
            lvFiches.ItemsSource = gst.fiche.ToList();

        }

        private void cboTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(cboTheme.SelectedItem != null)
            {
                int numTheme = (cboTheme.SelectedItem as theme_fiche).code;

                var ficheParTheme = from fi in gst.fiche
                                    where fi.codeTheme == numTheme
                                    select new fiche()
                                    {
                                        id = fi.id,
                                        titre = fi.titre,
                                        note = fi.note,
                                        prix = fi.prix
                                    };
                lvFiches.ItemsSource = ficheParTheme.ToList();

            }
        }

        private void lvFiches_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnCreer_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
