/*
 * Created by SharpDevelop.
 * User: Agus Sigit
 * Date: 20/10/2016
 * Time: 12:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CasparCGCSharpClient
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtCasparServer = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCasparPort = new System.Windows.Forms.TextBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.txtConsole = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCommand = new System.Windows.Forms.TextBox();
			this.btnSendCommand = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.lblStatus = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.linkDoc = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Caspar Server Address";
			// 
			// txtCasparServer
			// 
			this.txtCasparServer.Location = new System.Drawing.Point(127, 6);
			this.txtCasparServer.Name = "txtCasparServer";
			this.txtCasparServer.Size = new System.Drawing.Size(85, 20);
			this.txtCasparServer.TabIndex = 1;
			this.txtCasparServer.Text = "127.0.0.1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(218, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Port";
			// 
			// txtCasparPort
			// 
			this.txtCasparPort.Location = new System.Drawing.Point(246, 6);
			this.txtCasparPort.Name = "txtCasparPort";
			this.txtCasparPort.Size = new System.Drawing.Size(36, 20);
			this.txtCasparPort.TabIndex = 2;
			this.txtCasparPort.Text = "5250";
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(288, 4);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(73, 23);
			this.btnCheck.TabIndex = 3;
			this.btnCheck.Text = "Connect";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.BtnCheckClick);
			// 
			// txtConsole
			// 
			this.txtConsole.BackColor = System.Drawing.Color.Black;
			this.txtConsole.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtConsole.ForeColor = System.Drawing.Color.Lime;
			this.txtConsole.Location = new System.Drawing.Point(6, 122);
			this.txtConsole.Multiline = true;
			this.txtConsole.Name = "txtConsole";
			this.txtConsole.Size = new System.Drawing.Size(355, 94);
			this.txtConsole.TabIndex = 4;
			this.txtConsole.Text = "idle..";
			this.txtConsole.TextChanged += new System.EventHandler(this.TxtConsoleTextChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 103);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "Console Debug";
			// 
			// txtCommand
			// 
			this.txtCommand.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCommand.Location = new System.Drawing.Point(5, 51);
			this.txtCommand.Name = "txtCommand";
			this.txtCommand.Size = new System.Drawing.Size(356, 20);
			this.txtCommand.TabIndex = 5;
			this.txtCommand.Text = "INFO OK";
			// 
			// btnSendCommand
			// 
			this.btnSendCommand.Location = new System.Drawing.Point(265, 77);
			this.btnSendCommand.Name = "btnSendCommand";
			this.btnSendCommand.Size = new System.Drawing.Size(96, 41);
			this.btnSendCommand.TabIndex = 6;
			this.btnSendCommand.Text = "Send Command";
			this.btnSendCommand.UseVisualStyleBackColor = true;
			this.btnSendCommand.Click += new System.EventHandler(this.BtnSendCommandClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "Command";
			// 
			// lblStatus
			// 
			this.lblStatus.ForeColor = System.Drawing.Color.Red;
			this.lblStatus.Location = new System.Drawing.Point(261, 32);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(100, 13);
			this.lblStatus.TabIndex = 0;
			this.lblStatus.Text = "NOT CONNECTED";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(218, 31);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "Status";
			// 
			// linkDoc
			// 
			this.linkDoc.Location = new System.Drawing.Point(4, 77);
			this.linkDoc.Name = "linkDoc";
			this.linkDoc.Size = new System.Drawing.Size(164, 15);
			this.linkDoc.TabIndex = 7;
			this.linkDoc.TabStop = true;
			this.linkDoc.Text = "AMCP Command Documentation";
			this.linkDoc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1LinkClicked);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(365, 221);
			this.Controls.Add(this.linkDoc);
			this.Controls.Add(this.btnSendCommand);
			this.Controls.Add(this.txtCommand);
			this.Controls.Add(this.txtConsole);
			this.Controls.Add(this.btnCheck);
			this.Controls.Add(this.txtCasparPort);
			this.Controls.Add(this.txtCasparServer);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblStatus);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Caspar CG CSharp Client";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.LinkLabel linkDoc;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSendCommand;
		private System.Windows.Forms.TextBox txtCommand;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtConsole;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.TextBox txtCasparPort;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCasparServer;
		private System.Windows.Forms.Label label1;
	}
}
