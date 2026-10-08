namespace Body_form_task
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lblRisk = new Label();
            result_btn = new Button();
            height_txt_box = new MaskedTextBox();
            weight_txt_box = new MaskedTextBox();
            result_lbl = new Label();
            height_lbl = new Label();
            weight_lbl = new Label();
            pictureBox1 = new PictureBox();
            morbid_pic = new PictureBox();
            normal_pic = new PictureBox();
            obez_pic = new PictureBox();
            Overweight_pic = new PictureBox();
            Underweight_pic = new PictureBox();
            lblBKI = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)morbid_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)normal_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obez_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Overweight_pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Underweight_pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(lblRisk);
            panel1.Controls.Add(result_btn);
            panel1.Controls.Add(height_txt_box);
            panel1.Controls.Add(weight_txt_box);
            panel1.Controls.Add(result_lbl);
            panel1.Controls.Add(height_lbl);
            panel1.Controls.Add(weight_lbl);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 818);
            panel1.TabIndex = 0;
            // 
            // lblRisk
            // 
            lblRisk.AutoSize = true;
            lblRisk.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRisk.ForeColor = Color.White;
            lblRisk.Location = new Point(52, 642);
            lblRisk.Name = "lblRisk";
            lblRisk.Size = new Size(0, 32);
            lblRisk.TabIndex = 6;
            // 
            // result_btn
            // 
            result_btn.BackColor = Color.FromArgb(0, 64, 0);
            result_btn.ForeColor = Color.White;
            result_btn.Location = new Point(41, 467);
            result_btn.Name = "result_btn";
            result_btn.Size = new Size(207, 63);
            result_btn.TabIndex = 5;
            result_btn.Text = "Result";
            result_btn.UseVisualStyleBackColor = false;
            result_btn.Click += result_btn_Click;
            // 
            // height_txt_box
            // 
            height_txt_box.Font = new Font("Segoe UI", 14F);
            height_txt_box.Location = new Point(41, 349);
            height_txt_box.Mask = "00000";
            height_txt_box.Name = "height_txt_box";
            height_txt_box.Size = new Size(351, 45);
            height_txt_box.TabIndex = 4;
            height_txt_box.ValidatingType = typeof(int);
            // 
            // weight_txt_box
            // 
            weight_txt_box.Font = new Font("Segoe UI", 14F);
            weight_txt_box.Location = new Point(41, 210);
            weight_txt_box.Mask = "00000";
            weight_txt_box.Name = "weight_txt_box";
            weight_txt_box.Size = new Size(351, 45);
            weight_txt_box.TabIndex = 3;
            weight_txt_box.ValidatingType = typeof(int);
            // 
            // result_lbl
            // 
            result_lbl.AutoSize = true;
            result_lbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            result_lbl.ForeColor = Color.White;
            result_lbl.Location = new Point(52, 593);
            result_lbl.Name = "result_lbl";
            result_lbl.Size = new Size(0, 32);
            result_lbl.TabIndex = 2;
            // 
            // height_lbl
            // 
            height_lbl.AutoSize = true;
            height_lbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            height_lbl.ForeColor = Color.White;
            height_lbl.Location = new Point(41, 305);
            height_lbl.Name = "height_lbl";
            height_lbl.Size = new Size(151, 32);
            height_lbl.TabIndex = 1;
            height_lbl.Text = "height (cm)";
            // 
            // weight_lbl
            // 
            weight_lbl.AutoSize = true;
            weight_lbl.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            weight_lbl.ForeColor = Color.White;
            weight_lbl.Location = new Point(41, 175);
            weight_lbl.Name = "weight_lbl";
            weight_lbl.Size = new Size(150, 32);
            weight_lbl.TabIndex = 0;
            weight_lbl.Text = "weight (kg)";
            weight_lbl.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(721, 467);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 351);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // morbid_pic
            // 
            morbid_pic.Image = (Image)resources.GetObject("morbid_pic.Image");
            morbid_pic.Location = new Point(773, 56);
            morbid_pic.Name = "morbid_pic";
            morbid_pic.Size = new Size(304, 357);
            morbid_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            morbid_pic.TabIndex = 2;
            morbid_pic.TabStop = false;
            // 
            // normal_pic
            // 
            normal_pic.Image = (Image)resources.GetObject("normal_pic.Image");
            normal_pic.Location = new Point(773, 56);
            normal_pic.Name = "normal_pic";
            normal_pic.Size = new Size(304, 357);
            normal_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            normal_pic.TabIndex = 3;
            normal_pic.TabStop = false;
            // 
            // obez_pic
            // 
            obez_pic.Image = (Image)resources.GetObject("obez_pic.Image");
            obez_pic.Location = new Point(773, 56);
            obez_pic.Name = "obez_pic";
            obez_pic.Size = new Size(304, 357);
            obez_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            obez_pic.TabIndex = 4;
            obez_pic.TabStop = false;
            // 
            // Overweight_pic
            // 
            Overweight_pic.Image = (Image)resources.GetObject("Overweight_pic.Image");
            Overweight_pic.Location = new Point(773, 56);
            Overweight_pic.Name = "Overweight_pic";
            Overweight_pic.Size = new Size(304, 357);
            Overweight_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Overweight_pic.TabIndex = 5;
            Overweight_pic.TabStop = false;
            Overweight_pic.Click += pictureBox5_Click;
            // 
            // Underweight_pic
            // 
            Underweight_pic.Image = (Image)resources.GetObject("Underweight_pic.Image");
            Underweight_pic.Location = new Point(773, 56);
            Underweight_pic.Name = "Underweight_pic";
            Underweight_pic.Size = new Size(304, 357);
            Underweight_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            Underweight_pic.TabIndex = 6;
            Underweight_pic.TabStop = false;
            Underweight_pic.Click += Underweight_pic_Click;
            // 
            // lblBKI
            // 
            lblBKI.AutoSize = true;
            lblBKI.BackColor = SystemColors.ActiveCaptionText;
            lblBKI.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBKI.ForeColor = Color.White;
            lblBKI.Location = new Point(894, 432);
            lblBKI.Name = "lblBKI";
            lblBKI.Size = new Size(64, 32);
            lblBKI.TabIndex = 6;
            lblBKI.Text = "0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 818);
            Controls.Add(lblBKI);
            Controls.Add(Underweight_pic);
            Controls.Add(Overweight_pic);
            Controls.Add(normal_pic);
            Controls.Add(morbid_pic);
            Controls.Add(obez_pic);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)morbid_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)normal_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)obez_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)Overweight_pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)Underweight_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button result_btn;
        private MaskedTextBox height_txt_box;
        private MaskedTextBox weight_txt_box;
        private Label result_lbl;
        private Label height_lbl;
        private Label weight_lbl;
        private PictureBox morbid_pic;
        private PictureBox normal_pic;
        private PictureBox obez_pic;
        private PictureBox Overweight_pic;
        private PictureBox Underweight_pic;
        private Label lblBKI;
        private Label lblRisk;
    }
}
