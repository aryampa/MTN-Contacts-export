using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MTNContactsExported_NET2_0
{
    public partial class Main : Form
    {
        Dictionary<string, string> name_Number_Dictionary;
        TextReader txtReader;
        TextWriter txtWriter;

        List<string> listOfLines = new List<string> { };

        OpenFileDialog openFileDlg;

        FileStream fileInStrm;
        FileStream fileOutStrm;

        StreamReader strmReader;
        StreamWriter strmWriter;

        FolderBrowserDialog outFolderDlg;

        string fileInPath;
        string fileOutPath = "";
        string outFolderPath;


        public Main()
        {
            InitializeComponent();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDlg = new OpenFileDialog();

                openFileDlg.ShowDialog();
                fileInPath = openFileDlg.FileName;


                if (fileInStrm != null) fileInStrm.Close();


                if (fileInPath == "")
                {

                    TbxOpen.Text = "";
                    gBxOut.Enabled = false;
                    throw new Exception("No File Selected!!");
                }
                else
                {



                    fileInStrm = new FileStream(fileInPath, FileMode.Open);

                    strmReader = new StreamReader(fileInStrm);

                    outFolderPath = Path.GetDirectoryName(fileInPath);

                    fileOutPath = outFolderPath + "\\ConvertedFile.csv";

                    strmReader = new StreamReader(fileInStrm);

                    string readLine = "";

                    StringBuilder sBuilder = new StringBuilder();

                    listOfLines.Clear();

                    while (readLine != null)
                    {

                        sBuilder.AppendLine(readLine);
                        listOfLines.Add(readLine);

                        readLine = strmReader.ReadLine();

                    }

                    TbxOpen.Text = sBuilder.ToString();

                    gBxOut.Enabled = true;

                    fileInStrm.Close();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File Loading Error: " + ex.Message);
            }


        }

        private void Main_Load(object sender, EventArgs e)
        {
            outFolderDlg = new FolderBrowserDialog();
            gBxOut.Enabled = false;

            name_Number_Dictionary = new Dictionary<string, string> { };
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int countedCharacters = 0;
            StringBuilder sBulderFormatedContent = new StringBuilder();
            Boolean foundStartSquareBracket = false;
            try
            {
                ///############################ START DATA PROCRSSING ENGINE########################################################

                if (listOfLines.Count > 0)
                {

                    foreach (string lineWithContacts in listOfLines)
                    {

                        foundStartSquareBracket = false;

                        for (int i = 0; i < lineWithContacts.Length; i++)
                        {

                            if (lineWithContacts[i].ToString() != "")
                            {

                                if (lineWithContacts[i].ToString() == "[")
                                {
                                    foundStartSquareBracket = true;
                                    break;
                                }
                                else break;
                            }
                        }

                        if (foundStartSquareBracket)
                        {

                            char currentCharacter = ' ';
                            int firstOpenBracIndex = -1;
                            int firstCloseBracIndex = -1;
                            int secondOpenBracIndex = -1;
                            int secondCloseBracIndex = -1;

                            Boolean lineisProperlyFormated = true;


                            for (int i2 = 0; i2 < lineWithContacts.Length; i2++)
                            {
                                currentCharacter = lineWithContacts[i2];

                                if (firstOpenBracIndex == -1 | firstCloseBracIndex == -1 | secondOpenBracIndex == -1 | secondCloseBracIndex == -1)
                                {

                                    if (lineWithContacts[i2].ToString() == "[" & firstOpenBracIndex != -1 & firstCloseBracIndex == -1) lineisProperlyFormated = false;

                                    if (lineWithContacts[i2].ToString() == "[" & firstOpenBracIndex == -1) firstOpenBracIndex = i2;

                                    if (lineWithContacts[i2].ToString() == "]" & firstCloseBracIndex != -1 & secondOpenBracIndex == -1) lineisProperlyFormated = false;
                                    if (lineWithContacts[i2].ToString() == "]" & firstOpenBracIndex != -1 & firstCloseBracIndex == -1) firstCloseBracIndex = i2;


                                    if (lineWithContacts[i2].ToString() == "[" & secondOpenBracIndex != -1 & secondCloseBracIndex == -1) lineisProperlyFormated = false;
                                    if (lineWithContacts[i2].ToString() == "[" & firstCloseBracIndex != -1 & secondOpenBracIndex == -1) secondOpenBracIndex = i2;

                                    if (lineWithContacts[i2].ToString() == "]" & secondCloseBracIndex != -1) lineisProperlyFormated = false;
                                    if (lineWithContacts[i2].ToString() == "]" & secondOpenBracIndex != -1 & secondCloseBracIndex == -1) secondCloseBracIndex = i2;
                                }


                            }

                            if (lineisProperlyFormated & foundStartSquareBracket)
                            {
                                int spacesCounter = 0;
                                Boolean nameModeOn = false;
                                Boolean numberModeOn = false;
                                Boolean firstEscapeCharModeOn = true;
                                Boolean secondEscapeCharModeOn = false;
                                Boolean stopReadingLine = false;

                                char[] escapeChars = new char[] { '\t', ' ' };

                                string Cont_Name = "";
                                string Cont_Number = "";
                                string currentLetter = "";
                                char test = '\t';

                                char currentChar = ' ';


                                for (int i3 = secondCloseBracIndex + 1; i3 < lineWithContacts.Length; i3++)
                                {

                                    currentLetter = lineWithContacts[i3].ToString();
                                    currentChar = lineWithContacts[i3];

                                    if (!escapeChars.Contains(currentChar) & !secondEscapeCharModeOn)
                                    {
                                        firstEscapeCharModeOn = false;
                                        nameModeOn = true;

                                    }


                                    if (nameModeOn & currentChar == ' ') spacesCounter++;

                                    if (nameModeOn & spacesCounter <= 2 & !numberModeOn)
                                    {

                                        if (currentChar == '\t')
                                        {
                                            nameModeOn = false;
                                            secondEscapeCharModeOn = true;

                                        }

                                        else Cont_Name = Cont_Name + lineWithContacts[i3].ToString();


                                    }

                                    if (secondEscapeCharModeOn & !escapeChars.Contains(currentChar))
                                    {
                                        secondEscapeCharModeOn = false;
                                        numberModeOn = true;
                                    }

                                    if (numberModeOn)
                                    {
                                        if (escapeChars.Contains(currentChar)) stopReadingLine = true;
                                        else
                                        {
                                            Cont_Number = Cont_Number + currentLetter;
                                        }
                                    }

                                    if (stopReadingLine) break;
                                }

                                sBulderFormatedContent.AppendLine("Name: " + Cont_Name + " ---- Number: " + Cont_Number);

                                if (name_Number_Dictionary.Keys.Contains(Cont_Name))
                                {
                                    name_Number_Dictionary.Add(DuplicateNameResolver(Cont_Name), Cont_Number);
                                }
                                else
                                {

                                    name_Number_Dictionary.Add(Cont_Name, Cont_Number);
                                }

                                TbxOut.Text = sBulderFormatedContent.ToString();


                            }

                            else
                            {

                                ///########### HANDLE POORLY FORMATED TEXT###############
                            }

                        }
                    }
                }

                ///############################# END OF DATA PROCESSIONG ENGINE #####################################################
                if (RbtnConvAndroid.Checked)
                {

                    sBulderFormatedContent.Clear();


                    if (name_Number_Dictionary.Count > 0)
                    {

                        foreach (KeyValuePair<string, string> name_Number in name_Number_Dictionary)
                        {

                            sBulderFormatedContent.AppendLine("BEGIN:VCARD");
                            sBulderFormatedContent.AppendLine("VERSION:2.1");
                            sBulderFormatedContent.AppendLine("N:" + name_Number.Key + ";;");
                            sBulderFormatedContent.AppendLine("FN:" + name_Number.Key);
                            sBulderFormatedContent.AppendLine("TEL;CELL:" + name_Number.Value);
                            sBulderFormatedContent.AppendLine("");
                            sBulderFormatedContent.AppendLine("END:VCARD");
                        }

                        TbxOut.Text = sBulderFormatedContent.ToString();

                        fileOutStrm = new FileStream(fileOutPath = outFolderPath + "\\ConvertedFile.csv", FileMode.Create);
                        strmWriter = new StreamWriter(fileOutStrm);
                        strmWriter.Write(sBulderFormatedContent.ToString());
                        strmWriter.Flush();
                        fileOutStrm.Close();


                    }

                    else
                    {
                        throw new Exception("No Records Found");
                    }

                }
                else if (RbtnConvSim.Checked)
                {
                }
            }

            catch (Exception ex)
            {
                if (fileOutStrm != null) fileOutStrm.Close();
                MessageBox.Show(ex.Message);


            }
        }

        private void RbtnConvAndroid_Click(object sender, EventArgs e)
        {
            if (RbtnConvAndroid.Checked) fileOutPath = outFolderPath + "\\ConvertedFile.vcf";
            else fileOutPath = outFolderPath + "\\ConvertedFile.csv";
        }

        private string DuplicateNameResolver(string DuplicateName)
        {

            List<int> PostFixInt = new List<int> { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10 };
            string name2Return = "";


            int counter = 1;
            Boolean BestNameFound = false;

            while (!BestNameFound)
            {

                if (!name_Number_Dictionary.Keys.Contains(DuplicateName + "-" + counter.ToString()))
                {
                    name2Return = DuplicateName + "-" + counter.ToString();
                    BestNameFound = true;
                }

            }

            return name2Return;
        }




    }


}
