using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Communication;

namespace obs_dotnet_websocket_playground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            obs = new OBSWebsocket();
            obs.Connected += OBSOnConnected;
            obs.Disconnected += OBSOnDisconnected;
        }

        private OBSWebsocket obs;

        private void OBSOnConnected(object sender, EventArgs e)
        {
            var version = obs.GetVersion();
            MessageBox.Show($"Connected. Version: {version.Version}");
        }

        private void OBSOnDisconnected(object sender, ObsDisconnectionInfo info)
        {
            MessageBox.Show($"Disconnected.");
        }

        private void ConnectButtonClick(object sender, EventArgs e)
        {
            if (obs.IsConnected) return;

            var port = portTextBox.Text;
            var password = passwordTextBox.Text;
            if (string.IsNullOrWhiteSpace(port))
            {
                MessageBox.Show("Port must be specified");
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password must be specified");
                return;
            }
            
            obs.ConnectAsync($"ws://localhost:{port}", password);
        }

        private void VisibleToggleClick(object sender, EventArgs e)
        {
            if (!obs.IsConnected) return;
            var sceneListInfo = obs.GetSceneList();
            var scenes = sceneListInfo.Scenes;
            var desktopScene = scenes.FirstOrDefault((s) => s.Name == sceneTextBox.Text);
            if (desktopScene == null) return;

            var sceneItemDetailsList = obs.GetSceneItemList(desktopScene.Name);
            var textObjectiveSource = sceneItemDetailsList.FirstOrDefault(x => x.SourceName == sourceTextBox.Text);
            if (textObjectiveSource == null) return;
            
            var sceneEnabled = obs.GetSceneItemEnabled(desktopScene.Name, textObjectiveSource.ItemId);
            obs.SetSceneItemEnabled(desktopScene.Name, textObjectiveSource.ItemId, !sceneEnabled);
        }
        
        private void DisconnectButtonClick(object sender, EventArgs e)
        {
            if (!obs.IsConnected) return;

            obs.Disconnect();
        }
    }
}