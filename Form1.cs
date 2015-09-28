using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KHUT_Autobit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string linkTo64bit = "http://trainer.konghack.com/x64/KongHackTrainer.application";
        string linkTo32bit = "http://trainer.konghack.com/KongHackTrainer.application";
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                bool bits = System.Environment.Is64BitOperatingSystem;
                WebClient trainerDL = new WebClient();
                if (bits)
                {
                    trainerDL.DownloadFile(linkTo64bit, AppDomain.CurrentDomain.BaseDirectory + "64bitKHUT.application");
                    Process.Start(AppDomain.CurrentDomain.BaseDirectory + "64bitKHUT.application");
                    Application.Exit();
                }
                else
                {
                    trainerDL.DownloadFile(linkTo32bit, AppDomain.CurrentDomain.BaseDirectory + "32bitKHUT.application");
                    Process.Start(AppDomain.CurrentDomain.BaseDirectory + "32bitKHUT.application");
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception has occured:" + Environment.NewLine + ex.Message);
            }
        }
    }
}
