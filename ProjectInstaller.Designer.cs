namespace SimpleWindowsService1
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstallerSimple = new System.ServiceProcess.ServiceProcessInstaller();
            this.serviceInstallerSimple = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstallerSimple
            // 
            this.serviceProcessInstallerSimple.Password = null;
            this.serviceProcessInstallerSimple.Username = null;
            // 
            // serviceInstallerSimple
            // 
            this.serviceInstallerSimple.ServiceName = "SimpleService";
            this.serviceInstallerSimple.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstallerSimple,
            this.serviceInstallerSimple});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstallerSimple;
        private System.ServiceProcess.ServiceInstaller serviceInstallerSimple;
    }
}