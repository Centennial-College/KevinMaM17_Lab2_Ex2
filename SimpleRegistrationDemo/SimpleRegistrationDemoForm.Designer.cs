namespace SimpleRegistrationDemo
{
    partial class SimpleRegistrationDemoForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.accountManagmenetTabControl = new System.Windows.Forms.TabControl();
            this.registerTabPage = new System.Windows.Forms.TabPage();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.simpleRegistrationUserControl1 = new KevinMaM17_Lab2_Ex2.SimpleRegistrationUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.accountManagmenetTabControl.SuspendLayout();
            this.registerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.accountManagmenetTabControl);
            this.mainSplitContainer.Size = new System.Drawing.Size(937, 308);
            this.mainSplitContainer.SplitterDistance = 511;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // accountManagmenetTabControl
            // 
            this.accountManagmenetTabControl.Controls.Add(this.registerTabPage);
            this.accountManagmenetTabControl.Controls.Add(this.loginTabPage);
            this.accountManagmenetTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountManagmenetTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountManagmenetTabControl.Location = new System.Drawing.Point(0, 0);
            this.accountManagmenetTabControl.Name = "accountManagmenetTabControl";
            this.accountManagmenetTabControl.SelectedIndex = 0;
            this.accountManagmenetTabControl.Size = new System.Drawing.Size(511, 308);
            this.accountManagmenetTabControl.TabIndex = 0;
            // 
            // registerTabPage
            // 
            this.registerTabPage.Controls.Add(this.simpleRegistrationUserControl1);
            this.registerTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTabPage.Location = new System.Drawing.Point(4, 34);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerTabPage.Size = new System.Drawing.Size(503, 270);
            this.registerTabPage.TabIndex = 0;
            this.registerTabPage.Text = "Register";
            this.registerTabPage.UseVisualStyleBackColor = true;
            // 
            // loginTabPage
            // 
            this.loginTabPage.Location = new System.Drawing.Point(4, 34);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(743, 471);
            this.loginTabPage.TabIndex = 1;
            this.loginTabPage.Text = "Login";
            this.loginTabPage.UseVisualStyleBackColor = true;
            // 
            // simpleRegistrationUserControl1
            // 
            this.simpleRegistrationUserControl1.ClearBtnText = "Clear";
            this.simpleRegistrationUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleRegistrationUserControl1.GroupBoxTitle = "Registration";
            this.simpleRegistrationUserControl1.Location = new System.Drawing.Point(8, 6);
            this.simpleRegistrationUserControl1.Name = "simpleRegistrationUserControl1";
            this.simpleRegistrationUserControl1.Size = new System.Drawing.Size(499, 261);
            this.simpleRegistrationUserControl1.SubmitBtnText = "Submit";
            this.simpleRegistrationUserControl1.TabIndex = 0;
            // 
            // SimpleRegistrationDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 308);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "SimpleRegistrationDemoForm";
            this.Text = "SimpleRegistration Demo";
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.accountManagmenetTabControl.ResumeLayout(false);
            this.registerTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TabControl accountManagmenetTabControl;
        private System.Windows.Forms.TabPage registerTabPage;
        private System.Windows.Forms.TabPage loginTabPage;
        private KevinMaM17_Lab2_Ex2.SimpleRegistrationUserControl simpleRegistrationUserControl1;
    }
}

