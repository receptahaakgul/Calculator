using System;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class C : Form
    {
        public C()
        {
            InitializeComponent();
            ScreenLabel.Text = "0";
        }

        private char _islem;
        private bool _ekranTemizlenecekMi;
        private int _ilksayi;


        private void label1_Click(object sender, EventArgs e)
        {
            // If this method is unnecessary, we can leave it empty or remove it altogether.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            { 
                ScreenLabel.Text = ""; 
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1"
            ScreenLabel.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "6";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ScreenLabel.Text);

        }

        private void button11_Click(object sender, EventArgs e)
        {

            _islem = '-';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ScreenLabel.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ScreenLabel.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ScreenLabel.Text = "0";
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ScreenLabel.Text);
            int sonuc;

            switch (_islem) 
            {
                case '+':
                    sonuc = _ilksayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ScreenLabel.Text = Convert.ToString(sonuc);

        }

        private void Number7Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "7";
        }

        private void Number1Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }
            // Eğer ekranda "0" yazıyorsa, sıfırı sil
            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "1";
        }

        private void Number3Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "3";
        }

        private void Number5Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "5";
        }

        private void Number8Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "8";
        }

        private void Number9Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "9";
        }

        private void Number0Button_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenecekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenecekMi = false;
            }

            if (ScreenLabel.Text == "0")
            {
                ScreenLabel.Text = ""; // Use an empty string instead of "0"
            }
            // Add "1" 
            ScreenLabel.Text += "0";
        }

        private void splitButton_Click(object sender, EventArgs e)
        {

            _islem = '/';
            _ekranTemizlenecekMi = true;
            _ilksayi = Convert.ToInt32(ScreenLabel.Text);

        }
    }
}
