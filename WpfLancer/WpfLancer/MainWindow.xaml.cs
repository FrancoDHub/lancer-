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

namespace WpfLancer
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LAncerDe_Click(object sender, RoutedEventArgs e)
        {
                                                                      //pour les imahes je les mets dans un dossier imagenet a la racine de mon projet
           int de = 0;                                              // et dans la propriete du dossier image,il y a 2 options;Action de generation Ressource qui signifie que les images vont etre integres    
                                                                    // a l'interieur des fichiers de l'application,mais pas directement dans le pc de mon user.
                                                                    // 2-avec le contenu ces images vont etre copies sur la machine de l'utilsateur au moment du deployment du soft
                                                                    // et dans copier dans repertoire sortie :: mettre copier si plus recent

            Random rnd = new Random(); // declarer ou instancie un objet ,c'est aussi un constructeur

            rnd.Next(1, 7); // cet objet va generer un nombre aleatoire  de 1 ,6,

            de = rnd.Next(1, 7);  //on peut ecrire aussi en un sul ligne : int  de = rnd.Next(1, 7); je mis 1,7 paseke je dois avoir 6 valeurs et la derniere valeur ne compte pas

            string chemin = AppDomain.CurrentDomain.BaseDirectory + "/imagenet/d" + de.ToString() + ".png";// le basedirectory va retourner le chemin complet de notre dossier

                                                                                    //notre dossier :imagenet,et le d parce que les noms des images commencent par  d
                                                                                     // notre variable de(int) .toString retourne en chaine de caractere le chiffre correspond au variable de
                                                                                      // et ensuite l'extension du fichier .png
            Uri imgUri = new Uri(chemin); // uri parce que Bitmapimage reclame Uri

            BitmapImage img = new BitmapImage(imgUri); // cet objet est la siurce de notre controle image
            ImageDe.Source = img;

            textblockde.Text = de.ToString(); // affiche la valeur de la variable de dans le Textblock,, mais de est un nombre alors on fait la conversion avec la methode Tostring en chaine de caractere


            // Uri est un chemin d'acces,cela pourrait etre aussi un site internet
        }
    }
}
