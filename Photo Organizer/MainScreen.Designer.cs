namespace Photo_Organizer
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FindNewLocation = new System.Windows.Forms.TextBox();
            this.FindPhotoFolder = new System.Windows.Forms.TextBox();
            this.FindPhotoFolderButton = new System.Windows.Forms.Button();
            this.FindNewLocationButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FindNewLocation
            // 
            this.FindNewLocation.Location = new System.Drawing.Point(527, 175);
            this.FindNewLocation.Name = "FindNewLocation";
            this.FindNewLocation.Size = new System.Drawing.Size(300, 27);
            this.FindNewLocation.TabIndex = 0;
            // 
            // FindPhotoFolder
            // 
            this.FindPhotoFolder.Location = new System.Drawing.Point(12, 175);
            this.FindPhotoFolder.Name = "FindPhotoFolder";
            this.FindPhotoFolder.Size = new System.Drawing.Size(300, 27);
            this.FindPhotoFolder.TabIndex = 1;
            // 
            // FindPhotoFolderButton
            // 
            this.FindPhotoFolderButton.Location = new System.Drawing.Point(107, 208);
            this.FindPhotoFolderButton.Name = "FindPhotoFolderButton";
            this.FindPhotoFolderButton.Size = new System.Drawing.Size(94, 29);
            this.FindPhotoFolderButton.TabIndex = 2;
            this.FindPhotoFolderButton.Text = "Browse";
            this.FindPhotoFolderButton.UseVisualStyleBackColor = true;
            this.FindPhotoFolderButton.Click += new System.EventHandler(this.FindPhotoFolderButton_Click);
            // 
            // FindNewLocationButton
            // 
            this.FindNewLocationButton.Location = new System.Drawing.Point(648, 208);
            this.FindNewLocationButton.Name = "FindNewLocationButton";
            this.FindNewLocationButton.Size = new System.Drawing.Size(94, 29);
            this.FindNewLocationButton.TabIndex = 3;
            this.FindNewLocationButton.Text = "Browse";
            this.FindNewLocationButton.UseVisualStyleBackColor = true;
            this.FindNewLocationButton.Click += new System.EventHandler(this.FindNewLocationButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(355, 263);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(94, 29);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 484);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.FindNewLocationButton);
            this.Controls.Add(this.FindPhotoFolderButton);
            this.Controls.Add(this.FindPhotoFolder);
            this.Controls.Add(this.FindNewLocation);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox FindNewLocation;
        private TextBox FindPhotoFolder;
        private Button FindPhotoFolderButton;
        private Button FindNewLocationButton;
        private Button StartButton;
    }
}