using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Runspaces;




namespace PrintIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Enable LPR PS Script
        const string psScript = "Enable-WindowsOptionalFeature -Online -FeatureName Printing-Foundation-LPRPortMonitor -n";


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        //print it button
         private void Print_it_btn_Click(object sender, EventArgs e)
        {
            String ip_addr = this.ip_address.Text;
            String file_name = this.file_path.Text;
            System.Diagnostics.Process.Start("cmd.exe", $"/C START/MIN lpr -S {ip_addr} -P PASSTHRU -o l {file_name}");
        }

        //enable LPR button
        private void Enable_lpr_btn_Click(object sender, EventArgs e)
        {
           // using (PowerShell PowerShellInstance = PowerShell.Create())
            {
                //PowerShellInstance.AddScript(psScript);
                //Collection<PSObject> PSOutput = PowerShellInstance.Invoke();
                System.Diagnostics.Process.Start("cmd.exe", $"/c DISM.exe /online /Enable-Feature /FeatureName:Printing-Foundation-LPRPortMonitor /NoRestart");
            }
        }
        //select file button
        private void Select_file_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "PRN Files|*.prn";
            openFileDialog1.InitialDirectory = "c:\\PRN Files";


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strfilename = openFileDialog1.FileName;


                file_path.Text = openFileDialog1.FileName;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Help_btn_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            

        }
    }
}
