namespace SnakeGame
{
    partial class scene
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scene));
            this.ptbSnake = new System.Windows.Forms.PictureBox();
            this.pbCoin = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrBewegung = new System.Windows.Forms.Timer(this.components);
            this.txtbMove = new System.Windows.Forms.TextBox();
            this.Snake = new System.Windows.Forms.ImageList(this.components);
            this.Snake1 = new System.Windows.Forms.ImageList(this.components);
            this.failBackground = new System.Windows.Forms.Button();
            this.lblFail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbArrow = new System.Windows.Forms.PictureBox();
            this.ptbTitle = new System.Windows.Forms.PictureBox();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.Coin = new System.Windows.Forms.ImageList(this.components);
            this.tmrMünze = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSnake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbSnake
            // 
            this.ptbSnake.Location = new System.Drawing.Point(217, 247);
            this.ptbSnake.Name = "ptbSnake";
            this.ptbSnake.Size = new System.Drawing.Size(60, 30);
            this.ptbSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbSnake.TabIndex = 0;
            this.ptbSnake.TabStop = false;
            this.ptbSnake.Visible = false;
            // 
            // pbCoin
            // 
            this.pbCoin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCoin.BackgroundImage")));
            this.pbCoin.Location = new System.Drawing.Point(237, 186);
            this.pbCoin.Name = "pbCoin";
            this.pbCoin.Size = new System.Drawing.Size(30, 30);
            this.pbCoin.TabIndex = 1;
            this.pbCoin.TabStop = false;
            this.pbCoin.Tag = "TagCoin";
            this.pbCoin.Visible = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Red;
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(166, 346);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(164, 44);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tmrBewegung
            // 
            this.tmrBewegung.Tick += new System.EventHandler(this.TmrBewegung_Tick);
            // 
            // txtbMove
            // 
            this.txtbMove.Location = new System.Drawing.Point(396, 451);
            this.txtbMove.Name = "txtbMove";
            this.txtbMove.Size = new System.Drawing.Size(0, 20);
            this.txtbMove.TabIndex = 3;
            this.txtbMove.Enter += new System.EventHandler(this.BtnStart_Click);
            this.txtbMove.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtbMove_KeyDown);
            // 
            // Snake
            // 
            this.Snake.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Snake.ImageStream")));
            this.Snake.TransparentColor = System.Drawing.Color.Transparent;
            this.Snake.Images.SetKeyName(0, "SnakeUp.png");
            this.Snake.Images.SetKeyName(1, "SnakeLeft.png");
            this.Snake.Images.SetKeyName(2, "SnakeDown.png");
            this.Snake.Images.SetKeyName(3, "SnakeRight.png");
            // 
            // Snake1
            // 
            this.Snake1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Snake1.ImageStream")));
            this.Snake1.TransparentColor = System.Drawing.Color.Transparent;
            this.Snake1.Images.SetKeyName(0, "SnakeUp.png");
            this.Snake1.Images.SetKeyName(1, "SnakeDown.png");
            // 
            // failBackground
            // 
            this.failBackground.BackColor = System.Drawing.Color.Red;
            this.failBackground.Location = new System.Drawing.Point(-8, -7);
            this.failBackground.Name = "failBackground";
            this.failBackground.Size = new System.Drawing.Size(10, 10);
            this.failBackground.TabIndex = 4;
            this.failBackground.UseVisualStyleBackColor = false;
            this.failBackground.Visible = false;
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.BackColor = System.Drawing.Color.Red;
            this.lblFail.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFail.Location = new System.Drawing.Point(81, 169);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(0, 30);
            this.lblFail.TabIndex = 5;
            this.lblFail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFail.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // ptbArrow
            // 
            this.ptbArrow.BackColor = System.Drawing.Color.White;
            this.ptbArrow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbArrow.BackgroundImage")));
            this.ptbArrow.Location = new System.Drawing.Point(284, 12);
            this.ptbArrow.Name = "ptbArrow";
            this.ptbArrow.Size = new System.Drawing.Size(204, 146);
            this.ptbArrow.TabIndex = 7;
            this.ptbArrow.TabStop = false;
            // 
            // ptbTitle
            // 
            this.ptbTitle.BackColor = System.Drawing.Color.White;
            this.ptbTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptbTitle.BackgroundImage")));
            this.ptbTitle.Location = new System.Drawing.Point(56, 185);
            this.ptbTitle.Name = "ptbTitle";
            this.ptbTitle.Size = new System.Drawing.Size(399, 151);
            this.ptbTitle.TabIndex = 8;
            this.ptbTitle.TabStop = false;
            this.ptbTitle.Click += new System.EventHandler(this.PtbTitle_Click);
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblPunkte.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPunkte.Location = new System.Drawing.Point(27, 26);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(0, 23);
            this.lblPunkte.TabIndex = 9;
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Red;
            this.btnRetry.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetry.Location = new System.Drawing.Point(166, 342);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(164, 48);
            this.btnRetry.TabIndex = 10;
            this.btnRetry.Text = "Nochmal";
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Red;
            this.btnEnd.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.Location = new System.Drawing.Point(166, 397);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(164, 44);
            this.btnEnd.TabIndex = 11;
            this.btnEnd.Text = "Beenden";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Visible = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Coin
            // 
            this.Coin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Coin.ImageStream")));
            this.Coin.TransparentColor = System.Drawing.Color.Transparent;
            this.Coin.Images.SetKeyName(0, "Coin1.png");
            this.Coin.Images.SetKeyName(1, "Coin2.png");
            this.Coin.Images.SetKeyName(2, "Coin3.png");
            this.Coin.Images.SetKeyName(3, "Coin4.png");
            this.Coin.Images.SetKeyName(4, "Coin3 - Kopie.png");
            this.Coin.Images.SetKeyName(5, "Coin2 - Kopie.png");
            this.Coin.Images.SetKeyName(6, "Coin1.png");
            // 
            // tmrMünze
            // 
            this.tmrMünze.Interval = 80;
            this.tmrMünze.Tick += new System.EventHandler(this.timerMünze_Tick);
            // 
            // scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 499);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.ptbTitle);
            this.Controls.Add(this.ptbArrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFail);
            this.Controls.Add(this.failBackground);
            this.Controls.Add(this.txtbMove);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbCoin);
            this.Controls.Add(this.ptbSnake);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "scene";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.ptbSnake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTitle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbSnake;
        private System.Windows.Forms.PictureBox pbCoin;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrBewegung;
        private System.Windows.Forms.TextBox txtbMove;
        private System.Windows.Forms.ImageList Snake;
        private System.Windows.Forms.ImageList Snake1;
        private System.Windows.Forms.Button failBackground;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbArrow;
        private System.Windows.Forms.PictureBox ptbTitle;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ImageList Coin;
        private System.Windows.Forms.Timer tmrMünze;
    }
}

