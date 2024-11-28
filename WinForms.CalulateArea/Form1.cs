namespace WinForms.CalulateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ�����ҹ", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("��ͧ��ûԴ�����?", "Close Windows?"
                                        , MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input  �Ѻ��Ҩҡ Textbox���� txtRadius  (�ŧ��Դ�������� Double)
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRaduis.Text);
            if (double.TryParse(txtRaduis.Text, out Radius) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "���� Error!!");
                txtRaduis.Focus();    //����� Cursor ��� Textbox
                txtRaduis.SelectAll();  //��� Selected ��ͤ���� Textbox
                return;
            }
            //process �ӹǳ��鹷�� �ٵ�  pi*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI  ����� Pi
            //Math.Pow(x,y)   x ¡���ѧ y
            //output  ����ʴ��ŷ�� lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRaduis.Focus();
            txtRaduis.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(txtHeitght.Text, out double Height))
            {
                MessageBox.Show("��͡�繵���Ţ��ҹ��", "Error");
                txtHeitght.Focus();
                txtHeitght.SelectAll();
                return;
            }

            if (!double.TryParse(txtWidth.Text, out double Width))
            {
                MessageBox.Show("��͡�繵���Ţ��ҹ��", "Error");
                txtWidth.Focus();
                txtWidth.SelectAll();
                return;
            }

            double a = 0.5 * Width * Height;
            lblResult.Text = "��鹷��: " + a.ToString("0.00");

            txtHeitght.Focus();
            txtWidth.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtHexagonWidth.Text, out double lenght))
            {
                MessageBox.Show("��سҡ�͡����Ţ��ҹ��!", "Error");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }
            
            double x = (3 * Math.Sqrt(3) / 2) * lenght * lenght;

            lblResult.Text = "��鹷��: " + x.ToString("0.00");
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }
    }
}
