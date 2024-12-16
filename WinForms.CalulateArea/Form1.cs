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
            displaycircle();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {

            tree2();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            
            displayHexagon();
            
        }
        public void displaycircle() //ǧ���
            {
    
                if (!double.TryParse(txtRaduis.Text, out double Radius))
             {
                    MessageBox.Show("��͡�繵���Ţ��ҹ��", "Error");
                    txtRaduis.Focus();   
                    txtRaduis.SelectAll();  
                    return;
             }

                double area = circle(Radius);
    
                lblResult.Text = "��鹷��ǧ���: " + area.ToString("0.00");

                txtRaduis.Focus();
                txtRaduis.SelectAll();
            }

        public double circle(double radius)
            {
                return Math.PI * Math.Pow(radius, 2);
            }


        public void tree2()//����������
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

            double area = tree3(Width, Height);
            lblResult.Text = "��鹷��: " + area.ToString("0.00");

            txtHeitght.Focus();
            txtWidth.SelectAll();
        }

        public double tree3(double width, double height)
        {
            
            return 0.5 * width * height;
        }
        public void displayHexagon()//ˡ�������
        {
            
            if (!double.TryParse(txtHexagonWidth.Text, out double length))
            {
                MessageBox.Show("��سҡ�͡����Ţ��ҹ��!", "Error");
                txtHexagonWidth.Focus();       
                txtHexagonWidth.SelectAll(); 
                return;
            }

            double area = Hexagon(length);

            lblResult.Text = "��鹷��: " + area.ToString("0.00");

            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }

        public double Hexagon(double length)
        {
            
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(length, 2);
        }

    }
}
