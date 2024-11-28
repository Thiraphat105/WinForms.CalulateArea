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
            MessageBox.Show("ยินดีต้อนรับผู้ใช้งาน", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดโปรแกรม?", "Close Windows?"
                                        , MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input  รับค่าจาก Textboxชื่อ txtRadius  (แปลงชนิดข้อมูลเป็น Double)
            double Radius = 0;
            //Radius = Convert.ToDouble(txtRaduis.Text);
            if (double.TryParse(txtRaduis.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "ฮ่วย Error!!");
                txtRaduis.Focus();    //ให้มี Cursor ที่ Textbox
                txtRaduis.SelectAll();  //ให้ Selected ข้อความใน Textbox
                return;
            }
            //process คำนวณพื้นที่ สูตร  pi*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI  ให้ค่า Pi
            //Math.Pow(x,y)   x ยกกำลัง y
            //output  นำไปแสดงผลที่ lblResult
            lblResult.Text = CircleArea.ToString("0.00");

            txtRaduis.Focus();
            txtRaduis.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            
            if (!double.TryParse(txtHeitght.Text, out double Height))
            {
                MessageBox.Show("กรอกเป็นตัวเลขเท่านั้น", "Error");
                txtHeitght.Focus();
                txtHeitght.SelectAll();
                return;
            }

            if (!double.TryParse(txtWidth.Text, out double Width))
            {
                MessageBox.Show("กรอกเป็นตัวเลขเท่านั้น", "Error");
                txtWidth.Focus();
                txtWidth.SelectAll();
                return;
            }

            double a = 0.5 * Width * Height;
            lblResult.Text = "พื้นที่: " + a.ToString("0.00");

            txtHeitght.Focus();
            txtWidth.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtHexagonWidth.Text, out double lenght))
            {
                MessageBox.Show("กรุณากรอกตัวเลขเท่านั้น!", "Error");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }
            
            double x = (3 * Math.Sqrt(3) / 2) * lenght * lenght;

            lblResult.Text = "พื้นที่: " + x.ToString("0.00");
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }
    }
}
