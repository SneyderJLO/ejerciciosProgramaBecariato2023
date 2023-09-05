namespace delegates
{
    public partial class Form1 : Form
    {
        delegate void delegado(string msg);

        delegate void delegadoRichTextBox(RichTextBox richTextBox, string msg);

        private delegadoRichTextBox delegadoValor;


        private void delegadoMsg(string msg)
        {
            textBox1.Text = msg;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {

            delegadoValor = new delegadoRichTextBox(valorRichTexto);
            System.Threading.Thread proc = new System.Threading.Thread(procesoTexto);
            proc.Start();


        }

        private void setValor(string msg)
        {
            this.Invoke(delegadoValor, new object[]
            {
                richTextBox1, msg
            });
        }

        private void valorRichTexto(RichTextBox richTextBox, string value)
        {
            richTextBox.SelectionStart = richTextBox1.Text.Length;
            richTextBox.SelectedText = value + "" + "\n";
        }

        public void procesoTexto()
        {
            for (int i = 0; i < 10; i++)
            {
                System.Threading.Thread.Sleep(1000);
                setValor(i.ToString());
            }
        }
    }
}