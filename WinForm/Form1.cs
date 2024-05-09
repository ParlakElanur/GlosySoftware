using Microsoft.AspNetCore.SignalR.Client;

namespace WinForm
{
    public partial class Form1 : Form
    {
        private HubConnection hubConnection;
        public Form1()
        {
            InitializeComponent();
            InitializeSignalR();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private async void InitializeSignalR()
        {
            hubConnection = new HubConnectionBuilder().WithUrl("http://localhost:64955/myhub").Build();

            hubConnection.On<string>("receiveMessage", (message) =>
            {
                if (receiveBox.InvokeRequired)
                {
                    receiveBox.Invoke(new MethodInvoker(delegate
                    {
                        receiveBox.Text = message;
                    }));
                }
                receiveBox.Text = message;
            });
            await hubConnection.StartAsync();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text;
            await hubConnection.InvokeAsync("SendMessageAsync", message);
        }
    }
}
