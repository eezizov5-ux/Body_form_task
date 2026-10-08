namespace Body_form_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            morbid_pic.Visible = false;
            normal_pic.Visible = false;
            obez_pic.Visible = false;
            Overweight_pic.Visible = false;
            Underweight_pic.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_btn_Click(object sender, EventArgs e)
        {
            double weight = double.Parse(weight_txt_box.Text);
            double height = double.Parse(height_txt_box.Text) / 100;

            double bki = weight / (height * height);

            lblBKI.Text = bki.ToString("0.00");

            morbid_pic.Visible = false;
            normal_pic.Visible = false;
            obez_pic.Visible = false;
            Overweight_pic.Visible = false;
            Underweight_pic.Visible = false;

            if (bki < 18.5)
            {
                result_lbl.Text = "Çəki azlığı (Arıq)";
                lblRisk.Text = "İmmunitet zəifliyi, qida çatışmazlığı riski";
                Underweight_pic.Visible = true;
            }
            else if (bki >= 18.5 && bki <= 24.9)
            {
                result_lbl.Text = "Normal çəki";
                lblRisk.Text = "Minimum risk (İdeal status)";
                normal_pic.Visible = true;
            }
            else if (bki >= 25.0 && bki <= 32.0)
            {
                result_lbl.Text = "Artıq çəki";
                lblRisk.Text = "Ürək-damar və şəkər xəstəliyi riski artır";
                Overweight_pic.Visible = true;
            }
            else if (bki >= 33.0 && bki <= 39.0)
            {
                result_lbl.Text = "I dərəcəli piylənmə";
                lblRisk.Text = "Yüksək tibbi risk";
                obez_pic.Visible = true;
            }
            else if (bki >= 40.0)
            {
                result_lbl.Text = "III dərəcəli (Morbid) piylənmə";
                lblRisk.Text = "Həyati təhlükəli risk";
                morbid_pic.Visible = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        private void Underweight_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
