namespace Jers_Tabata_Project
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lbSecondsRemaining = new System.Windows.Forms.Label();
            this.timerGo = new System.Windows.Forms.Timer(this.components);
            this.lbGoOrRest = new System.Windows.Forms.Label();
            this.lbTabatasRemaining = new System.Windows.Forms.Label();
            this.timerPrepare = new System.Windows.Forms.Timer(this.components);
            this.lbPrepare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(135, 215);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(255, 215);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 30);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbSecondsRemaining
            // 
            this.lbSecondsRemaining.AutoSize = true;
            this.lbSecondsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSecondsRemaining.Location = new System.Drawing.Point(180, 164);
            this.lbSecondsRemaining.Name = "lbSecondsRemaining";
            this.lbSecondsRemaining.Size = new System.Drawing.Size(0, 20);
            this.lbSecondsRemaining.TabIndex = 3;
            // 
            // timerGo
            // 
            this.timerGo.Interval = 1000;
            this.timerGo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbGoOrRest
            // 
            this.lbGoOrRest.AutoSize = true;
            this.lbGoOrRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGoOrRest.Location = new System.Drawing.Point(208, 119);
            this.lbGoOrRest.Name = "lbGoOrRest";
            this.lbGoOrRest.Size = new System.Drawing.Size(0, 20);
            this.lbGoOrRest.TabIndex = 4;
            // 
            // lbTabatasRemaining
            // 
            this.lbTabatasRemaining.AutoSize = true;
            this.lbTabatasRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTabatasRemaining.Location = new System.Drawing.Point(131, 54);
            this.lbTabatasRemaining.Name = "lbTabatasRemaining";
            this.lbTabatasRemaining.Size = new System.Drawing.Size(199, 24);
            this.lbTabatasRemaining.TabIndex = 5;
            this.lbTabatasRemaining.Text = "Tabatas remaining 8";
            // 
            // timerPrepare
            // 
            this.timerPrepare.Interval = 1000;
            this.timerPrepare.Tick += new System.EventHandler(this.timerPrepare_Tick);
            // 
            // lbPrepare
            // 
            this.lbPrepare.AutoSize = true;
            this.lbPrepare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrepare.Location = new System.Drawing.Point(192, 88);
            this.lbPrepare.Name = "lbPrepare";
            this.lbPrepare.Size = new System.Drawing.Size(0, 20);
            this.lbPrepare.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(432, 340);
            this.Controls.Add(this.lbPrepare);
            this.Controls.Add(this.lbTabatasRemaining);
            this.Controls.Add(this.lbGoOrRest);
            this.Controls.Add(this.lbSecondsRemaining);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lbSecondsRemaining;
        private System.Windows.Forms.Timer timerGo;
        private System.Windows.Forms.Label lbGoOrRest;
        private System.Windows.Forms.Label lbTabatasRemaining;
        private System.Windows.Forms.Timer timerPrepare;
        private System.Windows.Forms.Label lbPrepare;
    }
}

