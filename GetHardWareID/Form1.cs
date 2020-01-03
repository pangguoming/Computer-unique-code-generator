using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace GetHardWareID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HardwareInfo hardwareinfo = new HardwareInfo();
            string cpuID = hardwareinfo.GetCpuID();
            string hardDiskID = hardwareinfo.GetHardDiskID();
            string macAddress = hardwareinfo.GetMacAddress();
            string motherBoardSerialNumber= hardwareinfo.GetMotherBoardSerialNumber();
            string hardwareids = cpuID  +  motherBoardSerialNumber  ;

            byte[] result = Encoding.Default.GetBytes(hardwareids.Trim());    //tbPass为输入密码的文本框  
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            this.tb_safetycode.Text = BitConverter.ToString(output).Replace("-", "");  //tbMd5pass为输出加密文本的
        }
    }
}
