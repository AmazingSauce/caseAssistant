using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // needed for the signature email to be grabbed


namespace closing_email_templete
{


        class GettingSignature
        {

            public class emailSignature
            {

                //THis should allow the program to grab the users default signature from outlook and place it in the email template, this is getting the signature in HTML need to find out how to convert it.
                private string ReadSignature()
                {
                    string appDataDir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Signatures";
                    string signature = string.Empty;
                    DirectoryInfo diInfo = new DirectoryInfo(appDataDir);
                    if (diInfo.Exists)
                    {
                        FileInfo[] fiSignature = diInfo.GetFiles("*.txt");
                        if (fiSignature.Length > 0)
                        {
                            StreamReader sr = new StreamReader(fiSignature[0].FullName, Encoding.Default);
                            signature = sr.ReadToEnd();

                            if (!string.IsNullOrEmpty(signature))
                            {
                                string fileName = fiSignature[0].Name.Replace(fiSignature[0].Extension, string.Empty);
                                signature = signature.Replace(fileName + "_files/", appDataDir + "/" + fileName + "_files/");
                            }
                        }
                    }

                    return signature;
                }

            }

        }
    
}
