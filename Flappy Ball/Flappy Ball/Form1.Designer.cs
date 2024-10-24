namespace Flappy_Ball
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.scoree = new System.Windows.Forms.Label();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.BotPipe = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // scoree
            // 
            this.scoree.AutoSize = true;
            this.scoree.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoree.Location = new System.Drawing.Point(12, 9);
            this.scoree.Name = "scoree";
            this.scoree.Size = new System.Drawing.Size(104, 24);
            this.scoree.TabIndex = 1;
            this.scoree.Text = "SCORE:0";
            // 
            // Ball
            // 
            this.Ball.Image = global::Flappy_Ball.Properties.Resources.icons8_flappy_dunk_100_removebg_preview;
            this.Ball.Location = new System.Drawing.Point(488, 276);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(100, 100);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            // 
            // BotPipe
            // 
            this.BotPipe.Image = global::Flappy_Ball.Properties.Resources.pipes__1__removebg_preview__1_;
            this.BotPipe.Location = new System.Drawing.Point(842, 444);
            this.BotPipe.Name = "BotPipe";
            this.BotPipe.Size = new System.Drawing.Size(128, 135);
            this.BotPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BotPipe.TabIndex = 0;
            this.BotPipe.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.Image = global::Flappy_Ball.Properties.Resources.pipes_removebg_preview;
            this.topPipe.Location = new System.Drawing.Point(853, 0);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(128, 185);
            this.topPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.topPipe.TabIndex = 0;
            this.topPipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 575);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1132, 61);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1132, 636);
            this.Controls.Add(this.scoree);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.BotPipe);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.ground);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox BotPipe;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label scoree;
        private System.Windows.Forms.PictureBox ground;
    }
}

