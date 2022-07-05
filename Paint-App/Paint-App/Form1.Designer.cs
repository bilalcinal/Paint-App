namespace Paint_App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.renk_paleti = new System.Windows.Forms.PictureBox();
            this.btn_çizgi = new System.Windows.Forms.Button();
            this.btn_kare = new System.Windows.Forms.Button();
            this.btn_elips = new System.Windows.Forms.Button();
            this.btn_silgi = new System.Windows.Forms.Button();
            this.btn_kalem = new System.Windows.Forms.Button();
            this.btn_doldur = new System.Windows.Forms.Button();
            this.btn_renk = new System.Windows.Forms.Button();
            this.pic_renk = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renk_paleti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.renk_paleti);
            this.panel1.Controls.Add(this.btn_çizgi);
            this.panel1.Controls.Add(this.btn_kare);
            this.panel1.Controls.Add(this.btn_elips);
            this.panel1.Controls.Add(this.btn_silgi);
            this.panel1.Controls.Add(this.btn_kalem);
            this.panel1.Controls.Add(this.btn_doldur);
            this.panel1.Controls.Add(this.btn_renk);
            this.panel1.Controls.Add(this.pic_renk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(595, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 503);
            this.panel1.TabIndex = 0;
            // 
            // renk_paleti
            // 
            this.renk_paleti.Image = global::Paint_App.Properties.Resources.color_palette;
            this.renk_paleti.Location = new System.Drawing.Point(3, 0);
            this.renk_paleti.Name = "renk_paleti";
            this.renk_paleti.Size = new System.Drawing.Size(181, 124);
            this.renk_paleti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.renk_paleti.TabIndex = 8;
            this.renk_paleti.TabStop = false;
            // 
            // btn_çizgi
            // 
            this.btn_çizgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_çizgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_çizgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_çizgi.ForeColor = System.Drawing.Color.Black;
            this.btn_çizgi.Image = global::Paint_App.Properties.Resources.line;
            this.btn_çizgi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_çizgi.Location = new System.Drawing.Point(14, 364);
            this.btn_çizgi.Name = "btn_çizgi";
            this.btn_çizgi.Size = new System.Drawing.Size(70, 59);
            this.btn_çizgi.TabIndex = 7;
            this.btn_çizgi.Text = "Çizgi";
            this.btn_çizgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_çizgi.UseVisualStyleBackColor = true;
            // 
            // btn_kare
            // 
            this.btn_kare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_kare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_kare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kare.ForeColor = System.Drawing.Color.Black;
            this.btn_kare.Image = global::Paint_App.Properties.Resources.rectangle;
            this.btn_kare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kare.Location = new System.Drawing.Point(90, 299);
            this.btn_kare.Name = "btn_kare";
            this.btn_kare.Size = new System.Drawing.Size(73, 59);
            this.btn_kare.TabIndex = 6;
            this.btn_kare.Text = "Kare";
            this.btn_kare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kare.UseVisualStyleBackColor = true;
            // 
            // btn_elips
            // 
            this.btn_elips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_elips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_elips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_elips.ForeColor = System.Drawing.Color.Black;
            this.btn_elips.Image = global::Paint_App.Properties.Resources.circle;
            this.btn_elips.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_elips.Location = new System.Drawing.Point(14, 299);
            this.btn_elips.Name = "btn_elips";
            this.btn_elips.Size = new System.Drawing.Size(70, 59);
            this.btn_elips.TabIndex = 5;
            this.btn_elips.Text = "Elips";
            this.btn_elips.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_elips.UseVisualStyleBackColor = true;
            // 
            // btn_silgi
            // 
            this.btn_silgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_silgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_silgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_silgi.ForeColor = System.Drawing.Color.Black;
            this.btn_silgi.Image = global::Paint_App.Properties.Resources.eraser;
            this.btn_silgi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_silgi.Location = new System.Drawing.Point(90, 234);
            this.btn_silgi.Name = "btn_silgi";
            this.btn_silgi.Size = new System.Drawing.Size(73, 59);
            this.btn_silgi.TabIndex = 4;
            this.btn_silgi.Text = "Silgi";
            this.btn_silgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_silgi.UseVisualStyleBackColor = true;
            // 
            // btn_kalem
            // 
            this.btn_kalem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_kalem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_kalem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kalem.ForeColor = System.Drawing.Color.Black;
            this.btn_kalem.Image = global::Paint_App.Properties.Resources.pencil;
            this.btn_kalem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kalem.Location = new System.Drawing.Point(14, 234);
            this.btn_kalem.Name = "btn_kalem";
            this.btn_kalem.Size = new System.Drawing.Size(70, 59);
            this.btn_kalem.TabIndex = 3;
            this.btn_kalem.Text = "Kalem";
            this.btn_kalem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kalem.UseVisualStyleBackColor = true;
            this.btn_kalem.Click += new System.EventHandler(this.btn_kalem_Click);
            // 
            // btn_doldur
            // 
            this.btn_doldur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_doldur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_doldur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doldur.ForeColor = System.Drawing.Color.Black;
            this.btn_doldur.Image = global::Paint_App.Properties.Resources.bucket;
            this.btn_doldur.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_doldur.Location = new System.Drawing.Point(90, 169);
            this.btn_doldur.Name = "btn_doldur";
            this.btn_doldur.Size = new System.Drawing.Size(73, 59);
            this.btn_doldur.TabIndex = 2;
            this.btn_doldur.Text = "Doldur";
            this.btn_doldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_doldur.UseVisualStyleBackColor = true;
            // 
            // btn_renk
            // 
            this.btn_renk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_renk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_renk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renk.ForeColor = System.Drawing.Color.Black;
            this.btn_renk.Image = global::Paint_App.Properties.Resources.color;
            this.btn_renk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_renk.Location = new System.Drawing.Point(14, 169);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(70, 59);
            this.btn_renk.TabIndex = 1;
            this.btn_renk.Text = " Renk";
            this.btn_renk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_renk.UseVisualStyleBackColor = true;
            // 
            // pic_renk
            // 
            this.pic_renk.BackColor = System.Drawing.Color.White;
            this.pic_renk.Location = new System.Drawing.Point(16, 130);
            this.pic_renk.Name = "pic_renk";
            this.pic_renk.Size = new System.Drawing.Size(147, 33);
            this.pic_renk.TabIndex = 0;
            this.pic_renk.UseVisualStyleBackColor = false;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(782, 503);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.renk_paleti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pic;
        private Button btn_renk;
        private Button pic_renk;
        private Button btn_çizgi;
        private Button btn_kare;
        private Button btn_elips;
        private Button btn_silgi;
        private Button btn_kalem;
        private Button btn_doldur;
        private PictureBox renk_paleti;
    }
}