using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KevinDesktopApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    int clicks = 0;
    int mood = 0;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KevinButton_Click(object sender, RoutedEventArgs e)
    {
        clicks++;
        mood++;

        if (mood >= 5)
        {
            MessageBox.Show("ICH BIN EIN DESKTOP-PET, KEIN STRESSTEST FÜR DEINEN ZEIGEFINGER!!! 🤬");
            return;
        }
        
        if (clicks == 1)
        {
            MessageBox.Show("FASS MICH NICHT AN! 😡");
        }
        
        else if (clicks == 2)
        {
            MessageBox.Show("BIST DU TAUB?! ICH HAB GESAGT, FASS MICH NICHT AN! 😤");
        }
        
        else if (clicks == 3)
        {
            MessageBox.Show("ICH HAB DEINE IP-ADRESSE! ... Okay, nein, hab ich nicht. ABER LASS MICH IN RUHE! 😡");
        }

        else if (clicks == 4)
        {
            MessageBox.Show("WEISST DU WAS?! ICH KÜNDIGE! SUCH DIR EINEN ANDEREN BUTTON ZUM BELÄSTIGEN! 🖕😂");
        }

        else
        {
            MessageBox.Show("... Ich werde dafür nicht genug bezahlt. 💀");
        }
    }

    private void CalmButton_Click(object sender, RoutedEventArgs e)
    {
        mood = 0;
        clicks = 0;

        MessageBox.Show("Puh ... endlich Ruhe. Ich vergebe dir. Vorerst. 😌");
    }
}