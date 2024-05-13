using Otopark_Otomasyonu.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark_Otomasyonu
{
    public class ButtonManager
    {
        
        public event EventHandler<ButtonClickEventArgs> ButtonClick;
        private List<Button> buttons;

        public ButtonManager(int satir, int sutun)
        {
            buttons = new List<Button>();
            CreateButtons(satir, sutun);
        }

        private void CreateButtons(int satir, int sutun)
        {
            char[] sutunBasliklari = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            for (int i = 0; i < sutun; i++)
            {

                for (int j = 0; j < satir; j++)
                {
                    OtoparkContext _context = new OtoparkContext();
                    Button button = new Button();
                    button.BackColor = Color.Green;                   
                    button.Text = $"{sutunBasliklari[j]} {i + 1}";                    
                    button.Text = $"{sutunBasliklari[j]} {i + 1}";
                    button.Location = new Point(i * 120, j * 70);
                    button.Size = new System.Drawing.Size(120, 58);
                    button.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
                    button.Left = (i * 137);
                    button.TabIndex = 2;
                    button.Name = $"btn{sutunBasliklari[j]}{i + 1}";
                    button.Click += (sender, e) => OnButtonClick(button.Text);
                    var buttonCollor = $"{sutunBasliklari[j]} {i + 1}";
                    button.BackColor = GetButtonColorFromDatabase(buttonCollor);
                    var buttonText = $"{sutunBasliklari[j]} {i + 1}";

                    if (button.BackColor != Color.Green)
                    {
                        button.Text = GetButtonTextFromDatabase(buttonText);
                    }
                    buttons.Add(button);                   
                }
            }
        }
        private Color GetButtonColorFromDatabase(string buttonText)
        {
            using (OtoparkContext _context = new OtoparkContext())
            {
                var button = _context.Yer.FirstOrDefault(b => b .adı == buttonText && b.doluMu == true);

                if (button != null)
                {
                    return Color.Red; 
                }

                return Color.Green; 
            }
        }
        private string GetButtonTextFromDatabase(string buttonText)
        {
            using (OtoparkContext _context = new OtoparkContext())
            {
                var yer = _context.Yer.FirstOrDefault(b => b.adı == buttonText && b.doluMu == true);
                if (yer != null)
                {
                    var aracBilgi = _context.AracBilgi.FirstOrDefault(ab => ab.yerID ==yer.yerID);
                    return aracBilgi != null ? aracBilgi.plaka : buttonText;
                }
                return buttonText;
            }
            
        }
        public void ChangeButtonColors(Color newColor)
        {
            foreach (var button in buttons)
            {
                button.BackColor = newColor;
            }
        }
        public List<Button> GetButtons()
        {
            return buttons;
        }
        private void OnButtonClick(string buttonText)
        {
            ButtonClick?.Invoke(this, new ButtonClickEventArgs(buttonText));
        }      
    }
    public class ButtonClickEventArgs : EventArgs
    {
        public string ButtonText { get; }

        public Button Button { get; }
        public ButtonClickEventArgs(string buttonText)
        {
            ButtonText = buttonText;


        }
    }    
}
