using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GMTool
{
    public class IniFile
    {
        public string m_filename;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);


        //类的构造函数，传递INI文件名
        public IniFile(string filename)
        {
            m_filename = filename;
        }

        //写INI文件
        public void IniWriteValue(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, this.m_filename);
        }

        //读取INI文件
        public string IniReadValue(string Section, string Key)
        {
            StringBuilder temp = new StringBuilder(255);

            int i = GetPrivateProfileString(Section, Key, "", temp, 255, this.m_filename);

            return temp.ToString();
        }
    }
}
