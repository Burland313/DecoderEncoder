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
using DecoderEncoder.Ciphers.Vigenere;

namespace DecoderEncoder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ICipher> CipherList = new List<ICipher>();

        List<string> CipherList2 = new List<string>();
        string outputText;
        

        public MainWindow()
        {
            InitializeComponent();
            CipherList2.Add("Caesar Shift");
            CipherList2.Add("Vigenere Cipher");

            CipherSelect.ItemsSource = CipherList2;
        }

        private void Encode_Click(object sender, RoutedEventArgs e)
        {
            switch (CipherSelect.SelectedItem)
            {
                case "Caesar Shift":
                    CaesarShiftCipher cipher1 = new CaesarShiftCipher();
                    outputText = cipher1.Encode(InputTextbox.Text, Int32.Parse(CaesarShiftValue.Text));
                    break;
                case "Vigenere Cipher":
                    VigenereCipher cipher2 = new VigenereCipher();
                    outputText = cipher2.Encode(InputTextbox.Text, VigenereKeyword.Text);
                    break;
                default:
                    break;
            }

            OutputTextbox.Text = outputText;
        }

        private void Decode_Click(object sender, RoutedEventArgs e)
        {
            switch (CipherSelect.SelectedItem)
            {
                case "Caesar Shift":
                    CaesarShiftCipher cipher1 = new CaesarShiftCipher();
                    outputText = cipher1.Decode(InputTextbox.Text, Int32.Parse(CaesarShiftValue.Text));
                    break;
                case "Vigenere Cipher":
                    VigenereCipher cipher2 = new VigenereCipher();
                    outputText = cipher2.Decode(InputTextbox.Text, VigenereKeyword.Text);
                    break;
                default:
                    break;
            }

            OutputTextbox.Text = outputText;
        }
    }
}
