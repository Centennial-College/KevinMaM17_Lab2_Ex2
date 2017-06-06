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
            this.simpleRegistrationUserControl1 = new KevinMaM17_Lab2_Ex2.SimpleRegistrationUserControl();
            this.SuspendLayout();
            // 
            // simpleRegistrationUserControl1
            // 
            this.simpleRegistrationUserControl1.ClearBtnText = "Clear";
            this.simpleRegistrationUserControl1.GroupBoxTitle = "Registration";
            this.simpleRegistrationUserControl1.Location = new System.Drawing.Point(69, 151);
            this.simpleRegistrationUserControl1.Name = "simpleRegistrationUserControl1";
            this.simpleRegistrationUserControl1.Size = new System.Drawing.Size(499, 261);
            this.simpleRegistrationUserControl1.SubmitBtnText = "Submit";
            this.simpleRegistrationUserControl1.TabIndex = 0;
            // 
            // SimpleRegistrationDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 632);
            this.Controls.Add(this.simpleRegistrationUserControl1);
            this.Name = "SimpleRegistrationDemoForm";
            this.Text = "SimpleRegistration Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private KevinMaM17_Lab2_Ex2.SimpleRegistrationUserControl simpleRegistrationUserControl1;
    }
}

