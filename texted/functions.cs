using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace texted
{
    public partial class Conversion
    {
        public string charToHex(char c)
        {
            switch (c)
            {
                case ' ': return "00"; break;
                case 'À': return "01"; break;
                case 'Á': return "02"; break;
                case 'Â': return "03"; break;
                case 'Ç': return "04"; break;
                case 'È': return "05"; break;
                case 'É': return "06"; break;
                case 'Ê': return "07"; break;
                case 'Ë': return "08"; break;
                case 'Ì': return "09"; break;
                case 'Î': return "0B"; break;
                case 'Ï': return "0C"; break;
                case 'Ò': return "0D"; break;
                case 'Ó': return "0E"; break;
                case 'Ô': return "0F"; break;
                case 'Æ': return "10"; break;
                case 'Ù': return "11"; break;
                case 'Ú': return "12"; break;
                case 'Û': return "13"; break;
                case 'Ñ': return "14"; break;
                case 'ß': return "15"; break;
                case 'à': return "16"; break;
                case 'á': return "17"; break;
                case 'ç': return "19"; break;
                case 'è': return "1A"; break;
                case 'é': return "1B"; break;
                case 'ê': return "1C"; break;
                case 'ë': return "1D"; break;
                case 'ì': return "1E"; break;
                case 'î': return "20"; break;
                case 'ï': return "21"; break;
                case 'ò': return "22"; break;
                case 'ó': return "23"; break;
                case 'ô': return "24"; break;
                case 'æ': return "25"; break;
                case 'ù': return "26"; break;
                case 'ú': return "27"; break;
                case 'û': return "28"; break;
                case 'ñ': return "29"; break;
                case 'º': return "2A"; break;
                case 'ª': return "2B"; break;
                case '·': return "2C"; break;
                case '&': return "2D"; break;
                case '+': return "2E"; break;
                case '=': return "35"; break;
                case ';': return "36"; break;
                case '¿': return "51"; break;
                case '¡': return "52"; break;
                case 'Í': return "5A"; break;
                case '%': return "5B"; break;
                case '(': return "5C"; break;
                case ')': return "5D"; break;
                case 'â': return "68"; break;
                case 'í': return "6F"; break;
                case '0': return "A1"; break;
                case '1': return "A2"; break;
                case '2': return "A3"; break;
                case '3': return "A4"; break;
                case '4': return "A5"; break;
                case '5': return "A6"; break;
                case '6': return "A7"; break;
                case '7': return "A8"; break;
                case '8': return "A9"; break;
                case '9': return "AA"; break;
                case '!': return "AB"; break;
                case '?': return "AC"; break;
                case '.': return "AD"; break;
                case '-': return "AE"; break;
              //case '·': return "AF"; break;
                case '"': return "B1"; break;
               case '\'': return "B3"; break;
                case '$': return "B7"; break;
                case ',': return "B8"; break;
                case '/': return "BA"; break;
                case 'A': return "BB"; break;
                case 'B': return "BC"; break;
                case 'C': return "BD"; break;
                case 'D': return "BE"; break;
                case 'E': return "BF"; break;
                case 'F': return "C0"; break;
                case 'G': return "C1"; break;
                case 'H': return "C2"; break;
                case 'I': return "C3"; break;
                case 'J': return "C4"; break;
                case 'K': return "C5"; break;
                case 'L': return "C6"; break;
                case 'M': return "C7"; break;
                case 'N': return "C8"; break;
                case 'O': return "C9"; break;
                case 'P': return "CA"; break;
                case 'Q': return "CB"; break;
                case 'R': return "CC"; break;
                case 'S': return "CD"; break;
                case 'T': return "CE"; break;
                case 'U': return "CF"; break;
                case 'V': return "D0"; break;
                case 'W': return "D1"; break;
                case 'X': return "D2"; break;
                case 'Y': return "D3"; break;
                case 'Z': return "D4"; break;
                case 'a': return "D5"; break;
                case 'b': return "D6"; break;
                case 'c': return "D7"; break;
                case 'd': return "D8"; break;
                case 'e': return "D9"; break;
                case 'f': return "DA"; break;
                case 'g': return "DB"; break;
                case 'h': return "DC"; break;
                case 'i': return "DD"; break;
                case 'j': return "DE"; break;
                case 'k': return "DF"; break;
                case 'l': return "E0"; break;
                case 'm': return "E1"; break;
                case 'n': return "E2"; break;
                case 'o': return "E3"; break;
                case 'p': return "E4"; break;
                case 'q': return "E5"; break;
                case 'r': return "E6"; break;
                case 's': return "E7"; break;
                case 't': return "E8"; break;
                case 'u': return "E9"; break;
                case 'v': return "EA"; break;
                case 'w': return "EB"; break;
                case 'x': return "EC"; break;
                case 'y': return "ED"; break;
                case 'z': return "EE"; break;
                case ':': return "F0"; break;
                case 'Ä': return "F1"; break;
                case 'Ö': return "F2"; break;
                case 'Ü': return "F3"; break;
                case 'ä': return "F4"; break;
                case 'ö': return "F5"; break;
                case 'ü': return "F6"; break;

                default:  return "00"; break;
            }
        }
        public string charToHex2(string s)
        {
            switch (s)
            {
                case "Lv": return "34"; break;
                case "PK": return "53"; break;
                case "MN": return "54"; break;
                case "PO": return "55"; break;
                case "Ke": return "56"; break;
                case "BL": return "57"; break;
                case "OC": return "58"; break;
                case "K":  return "59"; break;
                case "U":  return "79"; break;
                case "D":  return "7A"; break;
                case "L":  return "7B"; break;
                case "R":  return "7C"; break;
                case ".":  return "B0"; break;
                case "\"": return "B2"; break;
                case "\'": return "B4"; break;
                case "m":  return "B5"; break;
                case "f":  return "B6"; break;
                case "x":  return "B6"; break;
                case ">":  return "EF"; break;
                case "u":  return "F7"; break;
                case "d":  return "F8"; break;
                case "l":  return "F9"; break;
               case "\\l": return "FA"; break;
               case "\\p": return "FB"; break;
               case "\\c": return "FC"; break;
               case "\\v": return "FD"; break;
               case "\\n": return "FE"; break;
               case "\\x": return "FF"; break;

                default:   return "00"; break;
            }
        }
        public string TextToHex(string text)
        {
            string hex = "";
            int i = 0;
            char c;
            string s="";
            bool s_en = false;
            while (i < text.Length)
            {
                c = text[i];
                if (c == '\\')
                {
                    s_en = true;
                    s = s + c + text[i+1];
                    hex = hex + charToHex2(s);
                    s = "";
                    i++;
                }
                if (c == '[')
                {
                    s_en = true;
                }
                else
                {
                    if (c == ']')
                    {
                        s_en = false;
                        hex = hex + charToHex2(s);
                        s = "";
                    }
                    else
                    {
                        if (s_en == false)
                        {
                            hex = hex + charToHex(c);
                        }
                        else
                        {
                            if (c == '\\')
                            {
                                s_en = false;
                            }
                            else
                            {
                                s = s + c;
                            }
                        }
                    }
                }
                i++;

            }
            return hex;
        }

        public string HexToString(string b)
        {
            switch (b)
            {
                case "00": return " "; break;
                case "01": return "À"; break;
                case "02": return "Á"; break;
                case "03": return "Â"; break;
                case "04": return "Ç"; break;
                case "05": return "È"; break;
                case "06": return "É"; break;
                case "07": return "Ê"; break;
                case "08": return "Ë"; break;
                case "09": return "Ì"; break;
                case "0B": return "Î"; break;
                case "0C": return "Ï"; break;
                case "0D": return "Ò"; break;
                case "0E": return "Ó"; break;
                case "0F": return "Ô"; break;
                case "10": return "Æ"; break;
                case "11": return "Ù"; break;
                case "12": return "Ú"; break;
                case "13": return "Û"; break;
                case "14": return "Ñ"; break;
                case "15": return "ß"; break;
                case "16": return "à"; break;
                case "17": return "á"; break;
                case "19": return "ç"; break;
                case "1A": return "è"; break;
                case "1B": return "é"; break;
                case "1C": return "ê"; break;
                case "1D": return "ë"; break;
                case "1E": return "ì"; break;
                case "20": return "î"; break;
                case "21": return "ï"; break;
                case "22": return "ò"; break;
                case "23": return "ó"; break;
                case "24": return "ô"; break;
                case "25": return "æ"; break;
                case "26": return "ù"; break;
                case "27": return "ú"; break;
                case "28": return "û"; break;
                case "29": return "ñ"; break;
                case "2A": return "º"; break;
                case "2B": return "ª"; break;
                case "2C": return "·"; break;
                case "2D": return "&"; break;
                case "2E": return "+"; break;
                case "34": return "[Lv]"; break;
                case "35": return "="; break;
                case "36": return ";"; break;
                case "51": return "¿"; break;
                case "52": return "¡"; break;
                case "53": return "[PK]"; break;
                case "54": return "[MN]"; break;
                case "55": return "[PO]"; break;
                case "56": return "[Ke]"; break;
                case "57": return "[BL]"; break;
                case "58": return "[OC]"; break;
                case "59": return "[K]"; break;
                case "5A": return "Í"; break;
                case "5B": return "%"; break;
                case "5C": return "("; break;
                case "5D": return ")"; break;
                case "68": return "â"; break;
                case "6F": return "í"; break;
                case "79": return "[u]"; break;
                case "7A": return "[D]"; break;
                case "7B": return "[L]"; break;
                case "7C": return "[R]"; break;
                case "A1": return "0"; break;
                case "A2": return "1"; break;
                case "A3": return "2"; break;
                case "A4": return "3"; break;
                case "A5": return "4"; break;
                case "A6": return "5"; break;
                case "A7": return "6"; break;
                case "A8": return "7"; break;
                case "A9": return "8"; break;
                case "AA": return "9"; break;
                case "AB": return "!"; break;
                case "AC": return "?"; break;
                case "AD": return "."; break;
                case "AE": return "-"; break;
                case "AF": return "·"; break;
                case "B0": return "[.]"; break;
                case "B1": return "\""; break;
                case "B2": return "[\"]"; break;
                case "B3": return "\'"; break;
                case "B4": return "[\']"; break;
                case "B5": return "[m]"; break;
                case "B6": return "[f]"; break;
                case "B7": return "$"; break;
                case "B8": return ","; break;
                case "B9": return "[x]"; break;
                case "BA": return "/"; break;
                case "BB": return "A"; break;
                case "BC": return "B"; break;
                case "BD": return "C"; break;
                case "BE": return "D"; break;
                case "BF": return "E"; break;
                case "C0": return "F"; break;
                case "C1": return "G"; break;
                case "C2": return "H"; break;
                case "C3": return "I"; break;
                case "C4": return "J"; break;
                case "C5": return "K"; break;
                case "C6": return "L"; break;
                case "C7": return "M"; break;
                case "C8": return "N"; break;
                case "C9": return "O"; break;
                case "CA": return "P"; break;
                case "CB": return "Q"; break;
                case "CC": return "R"; break;
                case "CD": return "S"; break;
                case "CE": return "T"; break;
                case "CF": return "U"; break;
                case "D0": return "V"; break;
                case "D1": return "W"; break;
                case "D2": return "X"; break;
                case "D3": return "Y"; break;
                case "D4": return "Z"; break;
                case "D5": return "a"; break;
                case "D6": return "b"; break;
                case "D7": return "c"; break;
                case "D8": return "d"; break;
                case "D9": return "e"; break;
                case "DA": return "f"; break;
                case "DB": return "g"; break;
                case "DC": return "h"; break;
                case "DD": return "i"; break;
                case "DE": return "j"; break;
                case "DF": return "k"; break;
                case "E0": return "l"; break;
                case "E1": return "m"; break;
                case "E2": return "n"; break;
                case "E3": return "o"; break;
                case "E4": return "p"; break;
                case "E5": return "q"; break;
                case "E6": return "r"; break;
                case "E7": return "s"; break;
                case "E8": return "t"; break;
                case "E9": return "u"; break;
                case "EA": return "v"; break;
                case "EB": return "w"; break;
                case "EC": return "x"; break;
                case "ED": return "y"; break;
                case "EE": return "z"; break;
                case "EF": return "[>]"; break;
                case "F0": return ":"; break;
                case "F1": return "Ä"; break;
                case "F2": return "Ö"; break;
                case "F3": return "Ü"; break;
                case "F4": return "ä"; break;
                case "F5": return "ö"; break;
                case "F6": return "ü"; break;
                case "F7": return "[u]"; break;
                case "F8": return "[d]"; break;
                case "F9": return "[l]"; break;
                case "FA": return "\\l"; break;
                case "FB": return "\\p"; break;
                case "FC": return "\\c"; break;
                case "FD": return "\\v"; break;
                case "FE": return "\\n"; break;
                case "FF": return "\\x"; break;

                default: return "*"; break;
            }
        }
        public string HexToText(string hex)
        {
            int i = 0;
            string b, text="";
            char a;
            while (i < hex.Length)
            {
                b = "";
                a = hex[i];
                b = b + a;
                i++;
                a = hex[i];
                b = b + a;
                i++;
                text=text+HexToString(b);
            }
            return text;
        }
    }
    public partial class RomStuff
    {
        public string checkEdition(string rom)
        {
            Conversion convert = new Conversion();
            string edition;
            string filePath= rom;
            BinaryReader reader = new BinaryReader(new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None));
            reader.BaseStream.Position = 0xAC;
            byte a;
            char c=' ';
            string s = "";
            int i = 0;
            
            while ((a =(byte) reader.Read()) != 0x30)
            {
                c = (char)(a);
                s = s + c;
                i++;
            }
            reader.Close();
            edition = selectEdition(s);
            MessageBox.Show("ROM selected is " + edition);
            return s;
        }
        public string selectEdition(string code)
        {
            char ed = code[2];
            char la = code[3];
            string edition = "Pokémon ";
            string[] lang = new string[6] { "Japanese", "English", "Italian", "Spanish", "French", "German" };
            string[] vers = new string[30] { "Ruby", "Ruby", "Rubino", "Rubí", "Rubis", "Rubin", "Sapphire", "Sapphire", "Zaffiro", "Zafiro", "Saphir", "Saphir", "FireRed", "FireRed", "Rosso Fuoco", "Rojo Fuego", "Rouge Feu", "Feuerrote", "LeafGreen", "LeafGreen", "Verde Foglia", "Verde Hoja", "Vert Feuille", "Blattgrüne", "Emerald", "Emerald", "Smeraldo", "Esmeralda", "Émeraude", "Smaragd" };
            int iLang=0;
            int iVers=0;

            /*lang:
             * Jp -> 0
             * En -> 1
             * It -> 2
             * Es -> 3
             * Fr -> 4
             * De -> 5
             */

            /*version:
             * R  -> 0
             * S  -> 1
             * FR -> 2
             * LG -> 3
             * E  -> 4
             */
            
            switch (la)
            {
                case 'J': iLang = 0; break;
                case 'E': iLang = 1; break;
                case 'I': iLang = 2; break;
                case 'S': iLang = 3; break;
                case 'F': iLang = 4; break;
                case 'D': iLang = 5; break;
                default: edition = "N/A"; break;
            }
            switch (ed)
            {
                case 'V': iVers = 0; break;
                case 'P': iVers = 1; break;
                case 'R': iVers = 2; break;
                case 'G': iVers = 3; break;
                case 'E': iVers = 4; break;
                default:  edition = "N/A"; break;
            }
            edition = edition + vers[iLang + iVers * lang.Length] + " (" + lang[iLang] + ")";
            return edition;
        }
        public string readROM(string ROM, int offset)
        {
            BinaryReader reader = new BinaryReader(new FileStream(ROM, FileMode.Open, FileAccess.Read, FileShare.None));
            reader.BaseStream.Position = offset;
            byte a;
            string hex = "";
            int i = 0;

            while ((a = (byte)reader.Read()) != 0xFF)
            {
                hex = hex + a.ToString("X");
                i++;
            }
            reader.Close();
            return hex;
        }
    }
}
//00= 
//01=À
//02=Á
//03=Â
//04=Ç
//05=È
//06=É
//07=Ê
//08=Ë
//09=Ì
//0B=Î
//0C=Ï
//0D=Ò
//0E=Ó
//0F=Ô
//10=Æ
//11=Ù
//12=Ú
//13=Û
//14=Ñ
//15=ß
//16=à
//17=á
//19=ç
//1A=è
//1B=é
//1C=ê
//1D=ë
//1E=ì
//20=î
//21=ï
//22=ò
//23=ó
//24=ô
//25=æ
//26=ù
//27=ú
//28=û
//29=ñ
//2A=º
//2B=ª
//2C=·
//2D=&
//2E=+
//34=[Lv]
//35==
//36=;
//51=¿
//52=¡
//53=[PK]
//54=[MN]
//55=[PO]
//56=[Ke]
//57=[BL]
//58=[OC]
//59=[K]
//5A=Í
//5B=%
//5C=(
//5D=)
//68=â
//6F=í
//79=[u]
//7A=[D]
//7B=[L]
//7C=[R]
//A1=0
//A2=1
//A3=2
//A4=3
//A5=4
//A6=5
//A7=6
//A8=7
//A9=8
//AA=9
//AB=!
//AC=?
//AD=.
//AE=-
//AF=·
//B0=[.]
//B1="
//B2=["]
//B3='
//B4=[']
//B5=[m]
//B6=[f]
//B7=$
//B8=,
//B9=[x]
//BA=/
//BB=A
//BC=B
//BD=C
//BE=D
//BF=E
//C0=F
//C1=G
//C2=H
//C3=I
//C4=J
//C5=K
//C6=L
//C7=M
//C8=N
//C9=O
//CA=P
//CB=Q
//CC=R
//CD=S
//CE=T
//CF=U
//D0=V
//D1=W
//D2=X
//D3=Y
//D4=Z
//D5=a
//D6=b
//D7=c
//D8=d
//D9=e
//DA=f
//DB=g
//DC=h
//DD=i
//DE=j
//DF=k
//E0=l
//E1=m
//E2=n
//E3=o
//E4=p
//E5=q
//E6=r
//E7=s
//E8=t
//E9=u
//EA=v
//EB=w
//EC=x
//ED=y
//EE=z
//EF=[>]
//F0=:
//F1=Ä
//F2=Ö
//F3=Ü
//F4=ä
//F5=ö
//F6=ü
//F7=[u]
//F8=[d]
//F9=[l]
//FA=\l
//FB=\p
//FC=\c
//FD=\v
//FE=\n
//FF=\x