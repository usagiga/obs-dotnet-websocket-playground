namespace obs_dotnet_websocket_playground
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.visibleToggleButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sceneTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(120, 165);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(238, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.ConnectButtonClick);
            // 
            // visibleToggleButton
            // 
            this.visibleToggleButton.Location = new System.Drawing.Point(120, 216);
            this.visibleToggleButton.Name = "visibleToggleButton";
            this.visibleToggleButton.Size = new System.Drawing.Size(238, 23);
            this.visibleToggleButton.TabIndex = 1;
            this.visibleToggleButton.Text = "Show / Hide source";
            this.visibleToggleButton.UseVisualStyleBackColor = true;
            this.visibleToggleButton.Click += new System.EventHandler(this.VisibleToggleClick);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(120, 267);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(238, 23);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButtonClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(443, 218);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(178, 19);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(380, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(380, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password: ";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(443, 167);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(178, 19);
            this.portTextBox.TabIndex = 5;
            this.portTextBox.Text = "4455";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(380, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Scene:";
            // 
            // sceneTextBox
            // 
            this.sceneTextBox.Location = new System.Drawing.Point(443, 269);
            this.sceneTextBox.Name = "sceneTextBox";
            this.sceneTextBox.Size = new System.Drawing.Size(178, 19);
            this.sceneTextBox.TabIndex = 7;
            this.sceneTextBox.Text = "global_forward";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(380, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Source:";
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Location = new System.Drawing.Point(443, 315);
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(178, 19);
            this.sourceTextBox.TabIndex = 9;
            this.sourceTextBox.Text = "capture_vtuber";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sourceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sceneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.visibleToggleButton);
            this.Name = "Form1";
            this.Text = "obs-dotnet-websocket-playground";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sceneTextBox;
        private System.Windows.Forms.TextBox sourceTextBox;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;

        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button disconnectButton;

        private System.Windows.Forms.Button visibleToggleButton;

        private System.Windows.Forms.Button connectButton;

        #endregion
    }
}