using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;

namespace _23_EL_Exhibition_Charger.Common
{
    public static class CsUtil
    {
        public static void WriteLog(string LogMessage, string FolderName = "Log")
        {
            try
            {
                string LogDate;

                string LogContent;

                LogDate = DateTime.Now.ToString("yyyyMMdd");

                LogContent = "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:fff") + "] " + LogMessage;

                if (!Directory.Exists(Application.StartupPath + "\\" + FolderName + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0')))
                {
                    Directory.CreateDirectory(Application.StartupPath + "\\" + FolderName + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0'));
                }

                if (!File.Exists(Application.StartupPath + "\\" + FolderName + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + @"\" + LogDate + ".Log"))
                {
                    using (StreamWriter stream = File.CreateText(Application.StartupPath + "\\" + FolderName + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + @"\" + LogDate + ".Log"))
                    {
                        stream.WriteLine(LogContent);
                    }
                }
                else
                {
                    using (StreamWriter stream = File.AppendText(Application.StartupPath + "\\" + FolderName + "\\" + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString().PadLeft(2, '0') + @"\" + LogDate + ".Log"))
                    {
                        stream.WriteLine(LogContent);
                    }
                }

            }
            catch (Exception ex)
            {
            }
        }
        public static void dir_Log_Delete(string FolderName)
        {
            string folderDir = Application.StartupPath + "\\" + FolderName + "\\";
            try

            {

                int deleteMonth = 12;

                DirectoryInfo di = new DirectoryInfo(folderDir);

                if (di.Exists)

                {

                    DirectoryInfo[] dirInfo = di.GetDirectories();

                    string lDate = DateTime.Today.AddMonths(-deleteMonth).ToString("yyyyMM");

                    foreach (DirectoryInfo dir in dirInfo)

                    {

                        if (lDate.CompareTo(dir.Name) >= 0)

                        {

                            // 폴더 속성이 읽기, 쓰기 설정에 따라 삭제가 안될 수 있음

                            // 때문에 미리 속성 Normal로 설정

                            dir.Attributes = FileAttributes.Normal;

                            dir.Delete(true);

                        }

                    }

                }

            }

            catch (Exception) { }
        }
        #region INI 읽기/쓰기

        // ==========ini 파일 의 읽고 쓰기를 위한 API 함수 선언 =================
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, int Key,
              string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result,
              int Size, string FileName);

        // Third Method
        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(int Section, string Key,
               string Value, [MarshalAs(UnmanagedType.LPArray)] byte[] Result,
               int Size, string FileName);

        [DllImport("kernel32.dll")]
        private static extern int GetPrivateProfileString(    // ini Read 함수
                    String section,
                    String key,
                     String def,
                    StringBuilder retVal,
                    int size,
                    String filePath);

        [DllImport("kernel32.dll")]
        private static extern long WritePrivateProfileString(  // ini Write 함수
                    String section,
                    String key,
                    String val,
                    String filePath);
        //==========================================================================
        public static int CompareSec(DateTime before, DateTime current)
        {
            TimeSpan datediff = current - before;
            return datediff.Seconds;
        }

        public static string[] IniReadSectionNames(string iniPath)
        {
            for (int maxsize = 500; true; maxsize *= 2)
            {
                byte[] bytes = new byte[maxsize];
                int size = GetPrivateProfileString(0, "", "", bytes, maxsize, iniPath);

                if (size < maxsize - 2)
                {
                    string Selected = Encoding.ASCII.GetString(bytes, 0,
                                               size - (size > 0 ? 1 : 0));
                    return Selected.Split(new char[] { '\0' });
                }
            }
        }

        public static string[] IniReadEntryNames(string iniPath, string section)
        {
            for (int maxsize = 500; true; maxsize *= 2)
            {
                byte[] bytes = new byte[maxsize];
                int size = GetPrivateProfileString(section, 0, "", bytes, maxsize, iniPath);

                if (size < maxsize - 2)
                {
                    string entries = Encoding.ASCII.GetString(bytes, 0,
                                              size - (size > 0 ? 1 : 0));
                    return entries.Split(new char[] { '\0' });
                }
            }
        }

        // ini파일에 쓰기
        public static void IniWriteValue(string iniPath, string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, iniPath);
        }
        public static void IniWriteValue(string iniPath, string Section, string Key, int Value)
        {
            WritePrivateProfileString(Section, Key, Value.ToString(), iniPath);
        }
        public static void IniWriteValue(string iniPath, string Section, string Key, double Value)
        {
            WritePrivateProfileString(Section, Key, Value.ToString(), iniPath);
        }
        public static void IniWriteValue(string iniPath, string Section, string Key, bool Value)
        {
            WritePrivateProfileString(Section, Key, Value ? "1" : "0", iniPath);
        }

        // ini파일에서 읽어 오기
        public static string IniReadValue(string iniPath, string Section, string Key)
        {

            StringBuilder temp = new StringBuilder(2000);

            int i = GetPrivateProfileString(Section, Key, "", temp, 2000, iniPath);

            return temp.ToString();
        }
        public static string IniReadValue(string iniPath, string Section, string Key, string defaltValue)
        {

            StringBuilder temp = new StringBuilder(2000);

            int i = GetPrivateProfileString(Section, Key, "", temp, 2000, iniPath);

            if (temp.ToString() == "")
                return defaltValue;

            return temp.ToString();
        }
        #endregion

        public static bool IsNumeric(string str)
        {
            int i;
            try
            {
                i = Convert.ToInt32(str);
            }
            catch
            {
                return false;
            }

            return true;
        }
        public static string getExceptionInfo(Exception ex)
        {
            System.Diagnostics.StackTrace trace = new System.Diagnostics.StackTrace(ex, true);
            var stackFrame = trace.GetFrame(trace.FrameCount - 1);
            var lineNumber = stackFrame.GetFileLineNumber();

            return "\n" + ex.Message + " : " + lineNumber;
        }
        public static string GetIP()
        {
            try
            {
                IPHostEntry host;

                string localIP = "";

                host = Dns.GetHostEntry(Dns.GetHostName());

                foreach (IPAddress ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        localIP = ip.ToString();
                    }
                }

                return localIP;
            }
            catch (Exception ex)
            {
                WriteLog("CommonUtils.GetIP() - " + ex.Message);

                return string.Empty;
            }
        }

        #region 레지스트리 등록 / 삭제 (프로그램 자동 실행)
        public static void RegiAdd()
        {

            string AppName = Application.ProductName;
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                try
                {
                    //레지스트리 등록...
                    if (rk.GetValue(AppName) == null)
                    {
                        rk.SetValue(AppName, Application.ExecutablePath.ToString());
                    }
                    //레지스트리 닫기...
                    rk.Close();
                }
                catch (Exception ex)
                {
                    MessageUtils.ShowMessage(ex.Message, "레지스트리 등록 오류");
                    return;
                }
                MessageUtils.ShowMessage("레지스트리 등록 완료");
            }

        }
        public static void RegiDelete()
        {
            string AppName = Application.ProductName;
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                try
                {
                    //레지스트리 등록...
                    if (rk.GetValue(AppName) != null)
                    {
                        rk.SetValue(AppName, Application.ExecutablePath.ToString());
                        rk.DeleteValue(AppName, false);
                    }
                    rk.Close();
                }
                catch (Exception ex)
                {
                    MessageUtils.ShowMessage(ex.Message, "레지스트리 삭제 오류");
                    return;
                }
                MessageUtils.ShowMessage("레지스트리 삭제 완료");
            }
        }

        public static void RegiCheck()
        {
            string AppName = Application.ProductName;
            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true))
            {
                try
                {
                    //레지스트리 등록...
                    if (rk.GetValue(AppName) == null)
                    {
                        MessageUtils.ShowMessage("레지스트리에 등록 되어있지 않습니다.");
                    }
                    else
                    {
                        MessageUtils.ShowMessage("레지스트리에 등록 되어 있습니다.");
                    }
                    rk.Close();
                }
                catch (Exception ex)
                {
                    MessageUtils.ShowMessage(ex.Message, "레지스트리 체크 에러");
                    return;
                }
            }
        }
        #endregion
        public static class MessageUtils
        {
            public static DialogResult ShowMessage(string Message, string Caption = "", MessageBoxButtons Button = MessageBoxButtons.OK, MessageBoxIcon Icon = MessageBoxIcon.None)
            {
                if (Icon == MessageBoxIcon.Error)
                    CsUtil.WriteLog(Message);

                frmMessage frmmessage = new frmMessage(Message, Caption, Button, Icon);
                frmmessage.TopMost = true;
                DialogResult dlgResult = frmmessage.ShowDialog();

                return dlgResult;
            }
        }
    }
}
