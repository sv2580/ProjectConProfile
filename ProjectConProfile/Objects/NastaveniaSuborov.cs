using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjectConProfile.Objects
{
    public class NastaveniaSuborov
    {
        public string cestaKSuboruFakt { get; set; }
        public string cestaKDatam { get; set; }
        public string cestaNaUkladanie { get; set; }

        public NastaveniaSuborov()
        {

            string appDataPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string folderName = "ProjectConProfile";
            string folderPath = Path.Combine(appDataPath, folderName);

            if (!Directory.Exists(folderPath)) //ak neexistuje tento priecinok vytvor ho 
            {
                Directory.CreateDirectory(folderPath);
            }

            //vytvori sa tam subor faktory
            //naplni sa hodnotami 

            string fileName = "factors.txt";
            string factorPath = Path.Combine(folderPath, fileName);
            if (!File.Exists(factorPath))
            {
                using (StreamWriter sw = File.CreateText(factorPath))
                {
                    sw.WriteLine("0 1\n2 1.4\n8 2.2\n32 3.6\n128 5\n512 1\n");
                    sw.Close();
                }
                cestaKSuboruFakt = factorPath;
            }

            string filePath = Path.Combine(appDataPath, "ProjectConProfile", "settings.txt"); //ak uz existuje subor settings precitaj ho
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string data = reader.ReadLine();
                    if (data != "-" && cestaKSuboruFakt == null)
                        cestaKSuboruFakt = data;
                    data = reader.ReadLine();
                    if (data != "-")
                        cestaKDatam = data;
                    data = reader.ReadLine();
                    if (data != "-")
                        cestaNaUkladanie = data;
                }
            }
            else
            {
                this.ulozitNastavenia();
            }

        }

        public void ulozitNastavenia()
        {
            string appDataPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string filePath = Path.Combine(appDataPath, "ProjectConProfile", "settings.txt");

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                if (cestaKSuboruFakt != null)
                    writer.WriteLine(cestaKSuboruFakt);
                else
                    writer.WriteLine("-");
                if (cestaKDatam != null)
                    writer.WriteLine(cestaKDatam);
                else
                    writer.WriteLine("-");
                if (cestaNaUkladanie != null)
                    writer.WriteLine(cestaNaUkladanie);
                else
                    writer.WriteLine("-");

            }
        }
    }
}
