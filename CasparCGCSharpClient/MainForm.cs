/*
 * User: Agus Sigit Wisnubroto (aswzen@gmail.com)
 * Date: 20/10/2016
 * Time: 12:39
 */
 
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CasparCGCSharpClient
{
	public partial class MainForm : Form
	{
		System.Net.Sockets.TcpClient casparClient = new System.Net.Sockets.TcpClient();
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void BtnSendCommandClick(object sender, EventArgs e)
		{
			try {
				var reader = new StreamReader(casparClient.GetStream());
	            var writer = new StreamWriter(casparClient.GetStream());
				
	            writer.WriteLine(txtCommand.Text);
	            writer.Flush();
	
	            var reply = reader.ReadLine();
	            
				txtConsole.Text+= reply+Environment.NewLine;
	
	            if (reply.Contains("201"))
	            {
	                reply = reader.ReadLine();
					txtConsole.Text+= reply+Environment.NewLine;
	            }
	            else if (reply.Contains("200"))
	            {
	                while (reply.Length > 0)
	                {
	                    reply = reader.ReadLine();
	                    txtConsole.Text+= reply+Environment.NewLine;
	                }
	            } 	
			} catch (Exception) {
				txtConsole.Text+= "Please make sure the connection is connected. "+Environment.NewLine;
			}
					
		}
		
		void BtnCheckClick(object sender, EventArgs e)
		{
			try {
				casparClient.Connect(txtCasparServer.Text, int.Parse(txtCasparPort.Text));
				if(casparClient.Connected){
					lblStatus.Text = "CONNECTED";
					lblStatus.ForeColor = Color.Green;
					txtConsole.Text+= Environment.NewLine+"Caspar server connected! "+Environment.NewLine;
				} else {
					lblStatus.Text = "NOT CONNECTED";
					lblStatus.ForeColor = Color.Green;	
					txtConsole.Text+= Environment.NewLine+"Unable to connect to caspar server! "+Environment.NewLine;
				}
			} catch (Exception) {
				txtConsole.Text+= Environment.NewLine+"Unable to connect to caspar server, server refused! "+Environment.NewLine;
			}
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			casparClient.Close();
		}
		
		void TxtConsoleTextChanged(object sender, EventArgs e)
		{
	        txtConsole.SelectionStart = txtConsole.TextLength;
	        txtConsole.ScrollToCaret();
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("http://casparcg.com/wiki/CasparCG_2.0_AMCP_Protocol" as string);			
		}
	}
}
