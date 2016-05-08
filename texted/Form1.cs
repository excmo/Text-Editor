using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texted
{
    public partial class Form1 : Form
    {
        string romPath="";
        string edition = "";
        int currentOffs = 0;
        int currentLenght = 0;
        Conversion convert = new Conversion();
        RomStuff rom = new RomStuff();

        public Form1()
        {
            InitializeComponent();
        }

        private void toTextFromHex(object sender, EventArgs e)
        {
            NewText.Text = convert.HexToText(HEXBOX.Text);
        }

        private void writeNewTextToROM(object sender, EventArgs e)
        {
            HEXBOX.Text = convert.TextToHex(NewText.Text);
        }

        private void loadFromROM(object sender, EventArgs e)
        {
            if (romPath != "")
            {
                HEXBOX.Text=rom.readROM(romPath, int.Parse(offsetBox.Text, System.Globalization.NumberStyles.HexNumber));
                currentLenght=HEXBOX.TextLength;
                currentOffs = 
            }
        }

        private void openROM(object sender, EventArgs e)
        {
            if (romOpener.ShowDialog() == DialogResult.OK)
            {
                romPath = romOpener.FileName;
                edition=rom.checkEdition(romPath);
                setStatusEdition();
            }
        }

        private void setStatusEdition()
        {
            statusEdition.Text=rom.selectEdition(edition);
            switch (edition[2])
            {
                case 'V': statusEdition.ForeColor = Color.DarkRed;     break; //R
                case 'P': statusEdition.ForeColor = Color.DarkBlue;    break; //S
                case 'R': statusEdition.ForeColor = Color.OrangeRed;   break; //FR
                case 'G': statusEdition.ForeColor = Color.GreenYellow; break; //LG
                case 'E': statusEdition.ForeColor = Color.DarkGreen;   break; //E
                default: edition = "N/A"; break;
            }
        }
    }
}
