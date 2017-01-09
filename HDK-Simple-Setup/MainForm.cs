using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HDK_Simple_Setup
{
    public partial class MainForm : Form
    {

        // Hardcoded file locations for 32-bit version
        string configHDK13_32 = @"C:\Program Files (x86)\OSVR\Runtime\bin\sample-configs\osvr_server_config.HDK13DirectMode.sample.json";
        string configHDK20_32 = @"C:\Program Files (x86)\OSVR\Runtime\bin\sample-configs\osvr_server_config.HDK20DirectMode.sample.json";
        string configDK1_32 = null;
        string configDK2_32 = null;
        string configVive_32 = null;

        string binLocation_32 = @"C:\Program Files (x86)\OSVR\Runtime\bin";

        string serverConfig_32 = @"C:\Program Files (x86)\OSVR\Runtime\bin\osvr_server_config.json";
        string serverPath_32 = @"C:\Program Files (x86)\OSVR\Runtime\bin\osvr_server.exe";

        string trackingCalibration_32 = @"C:\Program Files (x86)\OSVR\Runtime\bin\VideoTrackerCalibrationUtility.exe";

        string samplePath_32 = @"C:\Program Files (x86)\OSVR\Runtime\bin\RenderManagerD3DPresentExample3D.exe";

        // Hardcoded file locations for 64-bit version
        string configHDK13 = @"C:\Program Files\OSVR\Runtime\bin\sample-configs\osvr_server_config.HDK13DirectMode.sample.json";
        string configHDK20 = @"C:\Program Files\OSVR\Runtime\bin\sample-configs\osvr_server_config.HDK20DirectMode.sample.json";
        string configDK1 = null;
        string configDK2 = null;
        string configVive = null;

        string binLocation = @"C:\Program Files\OSVR\Runtime\bin";

        string serverConfig = @"C:\Program Files\OSVR\Runtime\bin\osvr_server_config.json";
        string serverPath = @"C:\Program Files\OSVR\Runtime\bin\osvr_server.exe";

        string trackingCalibration = @"C:\Program Files\OSVR\Runtime\bin\VideoTrackerCalibrationUtility.exe";

        string samplePath = @"C:\Program Files\OSVR\Runtime\bin\RenderManagerD3DPresentExample3D.exe";

        public MainForm()
        {
            InitializeComponent();
        }

        public static bool Is64BitVersion()
        {
            bool uses64Bit;

            if(System.IO.Directory.Exists(@"C:\Program Files\OSVR\Runtime\bin") == true)
            {
                uses64Bit = true;
            }

            else
            {
                uses64Bit = false;
            }

            return uses64Bit;
            
        }

        public static bool IsUserAdministrator()
        {
            // Check if app is already running with admin rights
            bool isAdmin;
            try
            {
                // Determine current user identity
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException ex)
            {
                isAdmin = false;
            }
            catch (Exception ex)
            {
                isAdmin = false;
            }
            return isAdmin;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            System.IO.Directory.SetCurrentDirectory(binLocation);

            if (IsUserAdministrator())
            {
                ;
            }
            else
            {
                MessageBox.Show("Run this utility as Administrator for full functionality");
            }

            if (Is64BitVersion())
            {
                MessageBox.Show("Using 64-bit OSVR Runtime");
            }
            else
            {
                MessageBox.Show("Using 32-bit OSVR Runtime");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (lstHMD.SelectedIndex == 0)
            {
                if (Is64BitVersion())
                {
                    configHDK13.ToString();
                    Console.WriteLine(configHDK13);
                    MessageBox.Show(configHDK13);

                    System.IO.File.Copy(configHDK13, serverConfig, true);
                }

                else
                {
                    configHDK13_32.ToString();
                    Console.WriteLine(configHDK13_32);
                    MessageBox.Show(configHDK13_32);

                    System.IO.File.Copy(configHDK13_32, serverConfig, true);
                }

            }
            else if (lstHMD.SelectedIndex == 1)
            {
                if (Is64BitVersion())
                {
                    configHDK20.ToString();
                    Console.WriteLine(configHDK20);
                    MessageBox.Show(configHDK20);

                    System.IO.File.Copy(configHDK20, serverConfig, true);
                }

                else
                {
                    configHDK20_32.ToString();
                    Console.WriteLine(configHDK20_32);
                    MessageBox.Show(configHDK20_32);

                    System.IO.File.Copy(configHDK20_32, serverConfig, true);
                }
            }
            else
            {
                MessageBox.Show("This config is not available currently.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Is64BitVersion()) { System.Diagnostics.Process.Start(trackingCalibration); }
            else{ System.Diagnostics.Process.Start(trackingCalibration_32); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Is64BitVersion()) { System.Diagnostics.Process.Start(serverPath); }
            else { System.Diagnostics.Process.Start(serverPath_32); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(samplePath);
            if (Is64BitVersion()) { System.Diagnostics.Process.Start(samplePath); }
            else { System.Diagnostics.Process.Start(samplePath_32); }
        }
    }
}
