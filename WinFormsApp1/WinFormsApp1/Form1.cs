namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        delegate void delegado();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await procesoHilo02();
        }
        private void procesoHilo()
        {
            System.Threading.Thread.Sleep(1000);
        }
        private async Task procesoHilo02()
        {
            //System.Threading.Thread.Sleep(1000);
            await Task.Delay(5000);
            Console.WriteLine("fin");
        }

        private async Task proceso03()
        {

            Task tk = Task.Run(() =>
            {
                System.Threading.Thread.Sleep(1000);
            });
            await tk;

        }
    }
}