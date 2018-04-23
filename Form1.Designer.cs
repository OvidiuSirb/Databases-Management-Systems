namespace lab1
{
    partial class Songs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.GenreGridView = new System.Windows.Forms.DataGridView();
            this.TracksGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTId = new System.Windows.Forms.TextBox();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.txtAId = new System.Windows.Forms.TextBox();
            this.txtGId = new System.Windows.Forms.TextBox();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.txtMilliseconds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBytes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGenreId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GenreGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TracksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Genre";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(834, 32);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(98, 48);
            this.ShowButton.TabIndex = 2;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(834, 367);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 45);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(834, 765);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(98, 53);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // GenreGridView
            // 
            this.GenreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GenreGridView.Location = new System.Drawing.Point(16, 34);
            this.GenreGridView.Name = "GenreGridView";
            this.GenreGridView.RowTemplate.Height = 24;
            this.GenreGridView.Size = new System.Drawing.Size(729, 304);
            this.GenreGridView.TabIndex = 5;
            this.GenreGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GenreGridView_CellContentClick);
            // 
            // TracksGridView
            // 
            this.TracksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TracksGridView.Location = new System.Drawing.Point(16, 495);
            this.TracksGridView.Name = "TracksGridView";
            this.TracksGridView.RowTemplate.Height = 24;
            this.TracksGridView.Size = new System.Drawing.Size(729, 237);
            this.TracksGridView.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tracks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 776);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 776);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 776);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "AlbumId";
            // 
            // txtTId
            // 
            this.txtTId.Location = new System.Drawing.Point(16, 796);
            this.txtTId.Name = "txtTId";
            this.txtTId.Size = new System.Drawing.Size(48, 22);
            this.txtTId.TabIndex = 11;
            // 
            // txtTName
            // 
            this.txtTName.Location = new System.Drawing.Point(90, 796);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(84, 22);
            this.txtTName.TabIndex = 12;
            // 
            // txtAId
            // 
            this.txtAId.Location = new System.Drawing.Point(187, 796);
            this.txtAId.Name = "txtAId";
            this.txtAId.Size = new System.Drawing.Size(100, 22);
            this.txtAId.TabIndex = 13;
            // 
            // txtGId
            // 
            this.txtGId.Location = new System.Drawing.Point(302, 796);
            this.txtGId.Name = "txtGId";
            this.txtGId.Size = new System.Drawing.Size(100, 22);
            this.txtGId.TabIndex = 14;
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(425, 796);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(100, 22);
            this.txtComposer.TabIndex = 15;
            // 
            // txtMilliseconds
            // 
            this.txtMilliseconds.Location = new System.Drawing.Point(541, 796);
            this.txtMilliseconds.Name = "txtMilliseconds";
            this.txtMilliseconds.Size = new System.Drawing.Size(100, 22);
            this.txtMilliseconds.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(302, 776);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "GenreId";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 776);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Composer";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(541, 776);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Milliseconds";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 775);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "TrackId";
            // 
            // txtBytes
            // 
            this.txtBytes.Location = new System.Drawing.Point(659, 796);
            this.txtBytes.Name = "txtBytes";
            this.txtBytes.Size = new System.Drawing.Size(100, 22);
            this.txtBytes.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(659, 773);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Bytes";
            // 
            // txtGenreId
            // 
            this.txtGenreId.Location = new System.Drawing.Point(19, 369);
            this.txtGenreId.Name = "txtGenreId";
            this.txtGenreId.ReadOnly = true;
            this.txtGenreId.Size = new System.Drawing.Size(100, 22);
            this.txtGenreId.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 349);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "GenreId";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add child record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 837);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGenreId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBytes);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMilliseconds);
            this.Controls.Add(this.txtComposer);
            this.Controls.Add(this.txtGId);
            this.Controls.Add(this.txtAId);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.txtTId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TracksGridView);
            this.Controls.Add(this.GenreGridView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Songs";
            this.Text = "Songs Collection";
            ((System.ComponentModel.ISupportInitialize)(this.GenreGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TracksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView GenreGridView;
        private System.Windows.Forms.DataGridView TracksGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTId;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.TextBox txtAId;
        private System.Windows.Forms.TextBox txtGId;
        private System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.TextBox txtMilliseconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBytes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGenreId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button1;
    }
}

