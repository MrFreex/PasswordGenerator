﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Xml.Linq;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        private static string XMLFileDIR = @"C:\ProgramData\PasswordGen\Settings_file.xml";
        private static string XMLDIR = XMLFileDIR.Replace(@"\Settings_file.xml", "");
        public Form1()
        {
            InitializeComponent();
            loadMLConfig();
        }
        private void loadMLConfig()
        {


            // Check if the config exists
            // Set Public Variables 
            string updatetxtDir = "";

        // Goto label
        Recheck:

            if (!File.Exists(XMLFileDIR))
            {
                //Creata a New XDocument
                string currentVer = Assembly.GetEntryAssembly().GetName().Version.ToString();
                XDocument MLConfig = new XDocument(
                    new XDeclaration("1.0", "utf8", "yes"),
                    new XComment("XML Config auto generated by Password Generator"),
                    new XComment("Authors: MrFreex"),
                    new XElement("PassGen",
                        new XElement("XMLVersion", currentVer),
                        new XElement("Settings",
                            new XElement("txtDir", updatetxtDir),
                            new XElement("txtName", "passwordgen.txt"),
                            new XElement("charNum", "0"),
                            new XElement("onlyAlfaNum", "False"),
                            new XElement("genTxt", "False")
                        )

                    )
                    );
                //Creata the Directory and Config
                Directory.CreateDirectory(XMLDIR);
                MLConfig.Save(XMLFileDIR);
                goto Recheck;

            }
            else
            {
                //Load the config
                XDocument _config = XDocument.Load(XMLFileDIR);
                string currentVer = Assembly.GetEntryAssembly().GetName().Version.ToString();
                string xmlVer = _config.Root.Element("XMLVersion").Value.ToString().Replace("<XMLVersion>", "").Replace("</XMLVersion", "");
                updatetxtDir = _config.Root.Element("Settings").Element("txtDir").Value.ToString().Replace("<txtDir>", "").Replace("</txtDir>", "");
                txtFileName_text.Text = _config.Root.Element("Settings").Element("txtName").Value.ToString().Replace("<txtName>", "").Replace("</txtName>", "");
                charNum_text.Text = _config.Root.Element("Settings").Element("charNum").Value.ToString().Replace("<charNum>", "").Replace("</charNum>", "");

                if (xmlVer == currentVer)
                {
                    //set Arma 3 Dir
                    txtPath_text.Text = updatetxtDir;

                    //set Checkboxes
                    genTxt_check.Checked = Convert.ToBoolean(_config.Root.Element("Settings").Element("genTxt").Value);
                    onlyalfanum_check.Checked = Convert.ToBoolean(_config.Root.Element("Settings").Element("onlyAlfaNum").Value);
                }
                else
                {
                    /*
                        If the XML Version is not the same as the program Version
                        Delete, after loop through and Recreate the XML and reset
                        the settings.
                    */
                    System.IO.File.Delete(XMLFileDIR);
                    goto Recheck;
                }

            }


        }

        private void saveCBValues()
        {

            XDocument _config = XDocument.Load(XMLFileDIR);

            _config.Root.Element("Settings").Element("txtDir").Value = txtPath_text.Text;
            _config.Root.Element("Settings").Element("txtName").Value = txtFileName_text.Text;
            _config.Root.Element("Settings").Element("charNum").Value = charNum_text.Text;
            _config.Root.Element("Settings").Element("onlyAlfaNum").Value = onlyalfanum_check.Checked.ToString();
            _config.Root.Element("Settings").Element("genTxt").Value = genTxt_check.Checked.ToString();
            _config.Save(XMLFileDIR);
        }

        private void cpy_btn_Click(object sender, EventArgs e)
        {
            if (output_text.Text != "")
            {
                System.Windows.Forms.Clipboard.SetText(output_text.Text);
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            history_text.Text = "";
        }

        private void history_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_browse_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            txtPath_text.Text = fbd.SelectedPath;
        }

        private void charNum_text_TextChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void gen_btn_Click(object sender, EventArgs e)
        {
            freex_randomPassGen();
        }

        private void freex_randomPassGen()
        {
            bool isAlfaNum = onlyalfanum_check.Checked;
            string charNum = charNum_text.Text;
            bool genText = genTxt_check.Checked;

            if (!int.TryParse(charNum, out _)) { charNum_text.Text = "0"; MessageBox.Show("Wrong type of characters number"); };

            string[] alfa = {"q","w","e","r","t","y","u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m" };
            string[] num = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", };
            string special = "!#$%&'()*+,-./:;<=>?@[]^_`{|}~";
            char[] specialArray = special.ToCharArray();
            string[] specialArrayStr = new string[specialArray.Length];
            int loop = 0;
            string[] passwordArr = new string[int.Parse(charNum_text.Text)];
            foreach (char element in specialArray)
            {
                specialArrayStr[loop] = string.Format("{0}", element);
                loop++;
            }
            var random = new Random();
            var random2 = new Random();
            string[][] Arrays = { alfa, num, specialArrayStr };
            
            for (int i = 0;  i < int.Parse(charNum_text.Text); i++)
            {
                int lenght;
                if (!onlyalfanum_check.Checked)
                {
                    lenght = 3;
                }
                else
                {
                    lenght = 2;
                }
                int index = random.Next(lenght);
                string[] ToUse = Arrays[index];
                
                int index2 = random2.Next(ToUse.Length);
                passwordArr[i] = ToUse[index2];
            }
            string password = string.Join("", passwordArr);
            output_text.Text = password;
            history_text.Text += (string.Format("{0}\r\n", password));
            if (genTxt_check.Checked)
            {
                if (txtPath_text.Text == "" || !(Directory.Exists(txtPath_text.Text)))
                {
                    MessageBox.Show("Path or file name not valid");
                } else
                {
                    string[] lines = history_text.Lines;
                    // WriteAllLines creates a file, writes a collection of strings to the file,
                    // and then closes the file.  You do NOT need to call Flush() or Close().
                    System.IO.File.WriteAllLines(txtPath_text.Text + "/" + txtFileName_text.Text, lines);
                }
            }
        }

        private void onlyalfanum_check_CheckedChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void genTxt_check_CheckedChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void txtPath_text_TextChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }

        private void txtFileName_text_TextChanged(object sender, EventArgs e)
        {
            saveCBValues();
        }
    }
}
