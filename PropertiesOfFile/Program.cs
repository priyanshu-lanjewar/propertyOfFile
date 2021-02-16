using System;
using System.Linq;
using Aneka;
using Aneka.Entity;
using Aneka.Threading;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using System.Collections.Generic;
using Aneka.Accounting;
using System.Diagnostics;

namespace PropertiesOfFile
{
   public class Program
    {

        [Serializable]
        public class Words
        {
            public int wordsCount = 0;
            String str;
            String[] k;
            public Words(String str)
            {
                this.str = str;
            }
            public void count()
            {
                k = str.Split();
                foreach(String s in k)
                {
                    var j = s.Replace(" ", "");
                    if(j!="")
                    {
                        wordsCount++;
                    }
                }
            }
            public String[] getArr()
            {
                return k;
            }
        }
        [Serializable]
        public class calcUpperCaseClass
        {
            char[] arr;
            public int res = 0;
            public calcUpperCaseClass(char[] arr)
            {
                this.arr = arr;
            }

            public void count()
            {
                foreach(char c in arr)
                {
                    if (c >= 'A' && c <= 'Z')
                        res++;
                }
            }
        }
        [Serializable]
        public class calcLowerCaseClass
        {
            char[] arr;
            public int res = 0;
            public calcLowerCaseClass(char[] arr)
            {
                this.arr = arr;
            }

            public void count()
            {
                foreach (char c in arr)
                {
                    if (c >= 'a' && c <= 'z')
                        res++;
                }
            }
        }
        [Serializable]
        public class calcSpecialCharClass
        {
            char[] arr;
            public int res = 0;
            public calcSpecialCharClass(char[] arr)
            {
                this.arr = arr;
            }
            public void count()
            {
                foreach(char c in arr)
                {
                    if(!((c>='A' && c<='Z')||(c>='a' && c<='z')||(c>='0' && c <= '9') || c == 32 || c == 13 || c == 9))
                    {
                        res++;
                    }
                }
            }
        }
        [Serializable]
        public class calcAllCharClass
        {
            char[] arr;
            public int res = 0;
            public calcAllCharClass(char[] arr)
            {
                this.arr = arr;
            }

            public void count()
            {
                foreach(char c in arr)
                {
                    if(c==9 || !(c>=0 && c<=31))
                        res++;
                }
            }
        }

        [Serializable]
        public class calcAllChaWithoutSpaceClass
        {
            char[] arr;
            public int res = 0;
            public calcAllChaWithoutSpaceClass(char[] arr)
            {
                this.arr = arr;
            }

            public void count()
            {
                  foreach (char c in arr)
                {
                  if(!(c>=0 && c<=32))
                    res++;
                }
            }
        }

        public class FileProcess
        {
            private String location;
            private String confFileLoc;
            public FileProcess(String location,String confFileLoc)
            {
                this.location = location;
                this.confFileLoc = confFileLoc;
            }
         
            public void StartCount()
            {
                AnekaApplication<AnekaThread, ThreadManager> app = null;
                try
                {
                    Configuration conf = Configuration.GetConfiguration(confFileLoc);
                    Microsoft.Office.Interop.Word.Application a = new Microsoft.Office.Interop.Word.Application();
                    Document s = a.Documents.Open(location);
                    String text = s.Content.Text;
                    Logger.Start();
                    app = new AnekaApplication<AnekaThread, ThreadManager>(conf);
                    Words words = new Words(text.TrimStart().TrimEnd());
                    words.count();
                    int lines = s.ComputeStatistics(WdStatistic.wdStatisticLines,false);
                    int totalwords = words.wordsCount;
                    int thr = (int)Math.Ceiling(Math.Sqrt(text.Length));
                    int size = (int)Math.Floor(Math.Sqrt(text.Length));
                    if(text.Length > thr * size)
                    {
                        size = thr;
                    }
                    Form1.setMax(6 * thr);
                     Array[] arrr = new Array[thr];
                     try
                     {
                         for (int i = 0; i < thr; i++)
                         {
                             arrr[i] = text.Skip(i * size).Take(size).ToArray();
                             
                         }
                     }
                     catch(Exception e) { }

                     AnekaThread[] allCharacterWithSpace = new AnekaThread[thr];
                     AnekaThread[] allCharacterWithoutSpace = new AnekaThread[thr];
                     AnekaThread[] uppercaseThread = new AnekaThread[thr];
                     AnekaThread[] lowercaseThread = new AnekaThread[thr];
                     AnekaThread[] specialCharThread = new AnekaThread[thr];
                     for(int i = 0; i < thr; i++)
                     {
                        calcAllCharClass CACC = new calcAllCharClass((char[])arrr[i]);
                        calcAllChaWithoutSpaceClass CACWSC = new calcAllChaWithoutSpaceClass((char[])arrr[i]);
                        calcSpecialCharClass CSCC = new calcSpecialCharClass((char[])arrr[i]);
                        calcUpperCaseClass CUCC = new calcUpperCaseClass((char[])arrr[i]);
                        calcLowerCaseClass CLCC = new calcLowerCaseClass((char[])arrr[i]);
                         allCharacterWithSpace[i] = new AnekaThread(CACC.count, app);
                         allCharacterWithoutSpace[i] = new AnekaThread(CACWSC.count, app);
                         uppercaseThread[i] = new AnekaThread(CUCC.count, app);
                         lowercaseThread[i] = new AnekaThread(CLCC.count, app);
                         specialCharThread[i] = new AnekaThread(CSCC.count, app);
                        allCharacterWithSpace[i].Start();
                        Form1.updateProgressbar();
                        allCharacterWithoutSpace[i].Start();
                        Form1.updateProgressbar();
                        uppercaseThread[i].Start();
                        Form1.updateProgressbar();
                        lowercaseThread[i].Start();
                        Form1.updateProgressbar();
                        specialCharThread[i].Start();
                        Form1.updateProgressbar();
                     }
                     int totalCharsAll = 0,totalCharsWOS = -lines, totalUpperCase = 0, totalLowerCase = 0, totalSpecialChars = 0;
                     for(int i = 0; i < thr; i++)
                     {
                        allCharacterWithSpace[i].Join();
                         var c1 = (calcAllCharClass)allCharacterWithSpace[i].Target;
                         totalCharsAll += c1.res;
                        allCharacterWithoutSpace[i].Join();
                         var c5 = (calcAllChaWithoutSpaceClass)allCharacterWithoutSpace[i].Target;
                         totalCharsWOS += c5.res;
                        uppercaseThread[i].Join();
                         var c2 = (calcUpperCaseClass)uppercaseThread[i].Target;
                         totalUpperCase += c2.res;
                        lowercaseThread[i].Join();
                         var c3 = (calcLowerCaseClass)lowercaseThread[i].Target;
                         totalLowerCase += c3.res;
                        specialCharThread[i].Join();
                         var c4 = (calcSpecialCharClass)specialCharThread[i].Target;
                        totalSpecialChars += c4.res;
                        Form1.updateProgressbar();
                    }

                     int totalPage = s.ComputeStatistics(WdStatistic.wdStatisticPages, false);
                    
                     PropWin p = new PropWin(location,totalPage.ToString(),totalwords.ToString(),totalCharsAll.ToString(),totalCharsWOS.ToString(),totalUpperCase.ToString(),totalLowerCase.ToString(),totalSpecialChars.ToString());
                    p.Show();
                    s.Close();
                    



                }
                finally
                {
                    Logger.Stop();
                    app.StopExecution();
                }
                



            }
        }
    [STAThread]
    static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new Form1());
           
        }
    }
}
