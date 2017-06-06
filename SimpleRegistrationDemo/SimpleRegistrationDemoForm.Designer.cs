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
            this.clearBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.loginTabPage = new System.Windows.Forms.TabPage();
            this.simpleRegistrationUserControl = new KevinMaM17_Lab2_Ex2.SimpleRegistrationUserControl();
            this.accountsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.accountManagmenetTabControl.SuspendLayout();
            this.registerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
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
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.accountsDataGridView);
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
            this.registerTabPage.Controls.Add(this.clearBtn);
            this.registerTabPage.Controls.Add(this.submitBtn);
            this.registerTabPage.Controls.Add(this.simpleRegistrationUserControl);
            this.registerTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTabPage.Location = new System.Drawing.Point(4, 34);
            this.registerTabPage.Name = "registerTabPage";
            this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.registerTabPage.Size = new System.Drawing.Size(503, 270);
            this.registerTabPage.TabIndex = 0;
            this.registerTabPage.Text = "Register";
            this.registerTabPage.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.clearBtn.Location = new System.Drawing.Point(120, 203);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(108, 38);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.submitBtn.Location = new System.Drawing.Point(234, 203);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(108, 38);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // loginTabPage
            // 
            this.loginTabPage.Location = new System.Drawing.Point(4, 34);
            this.loginTabPage.Name = "loginTabPage";
            this.loginTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.loginTabPage.Size = new System.Drawing.Size(503, 270);
            this.loginTabPage.TabIndex = 1;
            this.loginTabPage.Text = "Login";
            this.loginTabPage.UseVisualStyleBackColor = true;
            // 
            // simpleRegistrationUserControl
            // 
            this.simpleRegistrationUserControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleRegistrationUserControl.GroupBoxTitle = "Registration";
            this.simpleRegistrationUserControl.Location = new System.Drawing.Point(8, 6);
            this.simpleRegistrationUserControl.Name = "simpleRegistrationUserControl";
            this.simpleRegistrationUserControl.Size = new System.Drawing.Size(499, 261);
            this.simpleRegistrationUserControl.TabIndex = 0;
            // 
            // accountsDataGridView
            // 
            this.accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accountsDataGridView.Location = new System.Drawing.Point(4, 13);
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.Size = new System.Drawing.Size(240, 150);
            this.accountsDataGridView.TabIndex = 0;
            // 
            // SimpleRegistrationDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 308);
            this.Controls.Add(this.mainSplitContainer);
            this.Name = "SimpleRegistrationDemoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleRegistration Demo";
            this.Load += new System.EventHandler(this.SimpleRegistrationDemoForm_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.accountManagmenetTabControl.ResumeLayout(false);
            this.registerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.TabControl accountManagmenetTabControl;
        private System.Windows.Forms.TabPage registerTabPage;
        private System.Windows.Forms.TabPage loginTabPage;
        private KevinMaM17_Lab2_Ex2.SimpleRegistrationUserControl simpleRegistrationUserControl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.DataGridView accountsDataGridView;
    }
}

