
namespace Entertainment_Center_Database_Project
{
    partial class ChoosePackage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoosePackage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_funfiesta = new System.Windows.Forms.Button();
            this.btn_party = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1050, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_funfiesta
            // 
            this.btn_funfiesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_funfiesta.Location = new System.Drawing.Point(137, 469);
            this.btn_funfiesta.Name = "btn_funfiesta";
            this.btn_funfiesta.Size = new System.Drawing.Size(177, 59);
            this.btn_funfiesta.TabIndex = 1;
            this.btn_funfiesta.Text = "1";
            this.btn_funfiesta.UseVisualStyleBackColor = true;
            this.btn_funfiesta.Click += new System.EventHandler(this.btn_funfiesta_Click);
            // 
            // btn_party
            // 
            this.btn_party.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_party.Location = new System.Drawing.Point(652, 469);
            this.btn_party.Name = "btn_party";
            this.btn_party.Size = new System.Drawing.Size(174, 59);
            this.btn_party.TabIndex = 2;
            this.btn_party.Text = "2";
            this.btn_party.UseVisualStyleBackColor = true;
            this.btn_party.Click += new System.EventHandler(this.btn_party_Click);
            // 
            // ChoosePackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.btn_party);
            this.Controls.Add(this.btn_funfiesta);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoosePackage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoosePackage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_funfiesta;
        private System.Windows.Forms.Button btn_party;
    }
}