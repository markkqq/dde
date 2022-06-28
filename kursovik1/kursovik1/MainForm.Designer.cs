
namespace kursovik1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button_createdisk_;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox disksizebox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox clustersizebox;
		
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button_createfile_;
		private System.Windows.Forms.TextBox filesizebox;
		private System.Windows.Forms.Label label5;
		
		private System.Windows.Forms.Button button_defragmentthedisk_;
		private System.Windows.Forms.Label label_disksize;
		private System.Windows.Forms.Label label_freespace;

		private System.Windows.Forms.Label labeldsfsd;
		private System.Windows.Forms.Label label_4352234;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label_filled_;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_systemclusterspace;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label_filespace;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button_cleandisk_;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button_deletefile;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button_help_;
		
		



		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.clustersizebox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button_createdisk_ = new System.Windows.Forms.Button();
			this.disksizebox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label_disksize = new System.Windows.Forms.Label();
			this.label_freespace = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button_createfile_ = new System.Windows.Forms.Button();
			this.filesizebox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button_defragmentthedisk_ = new System.Windows.Forms.Button();
			this.labeldsfsd = new System.Windows.Forms.Label();
			this.label_4352234 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.label_filled_ = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label_systemclusterspace = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label_filespace = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button_cleandisk_ = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button_deletefile = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button_help_ = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.clustersizebox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button_createdisk_);
			this.groupBox1.Controls.Add(this.disksizebox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(342, 284);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(138, 171);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Создание диска";
			// 
			// clustersizebox
			// 
			this.clustersizebox.FormattingEnabled = true;
			this.clustersizebox.Items.AddRange(new object[] {
			"2",
			"4",
			"8",
			"16",
			"32"});
			this.clustersizebox.Location = new System.Drawing.Point(7, 103);
			this.clustersizebox.Name = "clustersizebox";
			this.clustersizebox.Size = new System.Drawing.Size(121, 21);
			this.clustersizebox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Размер кластера в КБ";
			// 
			// button_createdisk_
			// 
			this.button_createdisk_.Location = new System.Drawing.Point(10, 130);
			this.button_createdisk_.Name = "button_createdisk_";
			this.button_createdisk_.Size = new System.Drawing.Size(118, 35);
			this.button_createdisk_.TabIndex = 4;
			this.button_createdisk_.Text = "Создать диск";
			this.button_createdisk_.UseVisualStyleBackColor = true;
			this.button_createdisk_.Click += new System.EventHandler(this.Button_createdisk_Click);
			// 
			// disksizebox
			// 
			this.disksizebox.Location = new System.Drawing.Point(7, 47);
			this.disksizebox.Name = "disksizebox";
			this.disksizebox.Size = new System.Drawing.Size(121, 20);
			this.disksizebox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Размер диска в МБ";
			// 
			// label_disksize
			// 
			this.label_disksize.Location = new System.Drawing.Point(3, 39);
			this.label_disksize.Name = "label_disksize";
			this.label_disksize.Size = new System.Drawing.Size(100, 23);
			this.label_disksize.TabIndex = 4;
			// 
			// label_freespace
			// 
			this.label_freespace.Location = new System.Drawing.Point(2, 232);
			this.label_freespace.Name = "label_freespace";
			this.label_freespace.Size = new System.Drawing.Size(100, 23);
			this.label_freespace.TabIndex = 5;
			this.label_freespace.Text = " ";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button_createfile_);
			this.groupBox2.Controls.Add(this.filesizebox);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Enabled = false;
			this.groupBox2.Location = new System.Drawing.Point(136, 369);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 86);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Создание файла";
			// 
			// button_createfile_
			// 
			this.button_createfile_.Location = new System.Drawing.Point(7, 62);
			this.button_createfile_.Name = "button_createfile_";
			this.button_createfile_.Size = new System.Drawing.Size(75, 24);
			this.button_createfile_.TabIndex = 3;
			this.button_createfile_.Text = "Создать файл";
			this.button_createfile_.UseVisualStyleBackColor = true;
			this.button_createfile_.Click += new System.EventHandler(this.Button_createfile_Click);
			// 
			// filesizebox
			// 
			this.filesizebox.Location = new System.Drawing.Point(7, 36);
			this.filesizebox.Name = "filesizebox";
			this.filesizebox.Size = new System.Drawing.Size(185, 20);
			this.filesizebox.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(123, 23);
			this.label5.TabIndex = 0;
			this.label5.Text = "Размер файла в КБ";
			// 
			// button_defragmentthedisk_
			// 
			this.button_defragmentthedisk_.Location = new System.Drawing.Point(3, 369);
			this.button_defragmentthedisk_.Name = "button_defragmentthedisk_";
			this.button_defragmentthedisk_.Size = new System.Drawing.Size(127, 41);
			this.button_defragmentthedisk_.TabIndex = 9;
			this.button_defragmentthedisk_.Text = "Дефрагментировать диск";
			this.button_defragmentthedisk_.UseVisualStyleBackColor = true;
			this.button_defragmentthedisk_.Click += new System.EventHandler(this.Button_defragmentthedisk_Click);
			// 
			// labeldsfsd
			// 
			this.labeldsfsd.Location = new System.Drawing.Point(3, 16);
			this.labeldsfsd.Name = "labeldsfsd";
			this.labeldsfsd.Size = new System.Drawing.Size(128, 23);
			this.labeldsfsd.TabIndex = 10;
			this.labeldsfsd.Text = "Всего места на диске";
			// 
			// label_4352234
			// 
			this.label_4352234.Location = new System.Drawing.Point(6, 209);
			this.label_4352234.Name = "label_4352234";
			this.label_4352234.Size = new System.Drawing.Size(107, 23);
			this.label_4352234.TabIndex = 11;
			this.label_4352234.Text = "Свободно на диске:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(106, 232);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 23);
			this.label6.TabIndex = 12;
			this.label6.Text = "КБ";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(109, 39);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 23);
			this.label7.TabIndex = 13;
			this.label7.Text = "КБ";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(4, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(333, 351);
			this.dataGridView1.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 18);
			this.label3.TabIndex = 15;
			this.label3.Text = "Занято на диске:";
			// 
			// label_filled_
			// 
			this.label_filled_.Location = new System.Drawing.Point(3, 80);
			this.label_filled_.Name = "label_filled_";
			this.label_filled_.Size = new System.Drawing.Size(106, 23);
			this.label_filled_.TabIndex = 16;
			this.label_filled_.Text = " ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(109, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(33, 23);
			this.label4.TabIndex = 17;
			this.label4.Text = "КБ";
			// 
			// label_systemclusterspace
			// 
			this.label_systemclusterspace.Location = new System.Drawing.Point(6, 126);
			this.label_systemclusterspace.Name = "label_systemclusterspace";
			this.label_systemclusterspace.Size = new System.Drawing.Size(100, 23);
			this.label_systemclusterspace.TabIndex = 18;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 103);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 12);
			this.label8.TabIndex = 19;
			this.label8.Text = "Система:";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(109, 126);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(28, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "КБ";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(2, 149);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 21;
			this.label10.Text = "Файлы:";
			// 
			// label_filespace
			// 
			this.label_filespace.Location = new System.Drawing.Point(9, 176);
			this.label_filespace.Name = "label_filespace";
			this.label_filespace.Size = new System.Drawing.Size(93, 23);
			this.label_filespace.TabIndex = 22;
			this.label_filespace.Text = " ";
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(108, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(23, 23);
			this.label12.TabIndex = 23;
			this.label12.Text = "КБ";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.label_filled_);
			this.groupBox3.Controls.Add(this.label_filespace);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.label_systemclusterspace);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label_4352234);
			this.groupBox3.Controls.Add(this.labeldsfsd);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.label_disksize);
			this.groupBox3.Controls.Add(this.label_freespace);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(343, 5);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(137, 273);
			this.groupBox3.TabIndex = 24;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "О диске";
			// 
			// button_cleandisk_
			// 
			this.button_cleandisk_.Location = new System.Drawing.Point(4, 414);
			this.button_cleandisk_.Name = "button_cleandisk_";
			this.button_cleandisk_.Size = new System.Drawing.Size(126, 41);
			this.button_cleandisk_.TabIndex = 25;
			this.button_cleandisk_.Text = "Очистить диск";
			this.button_cleandisk_.UseVisualStyleBackColor = true;
			this.button_cleandisk_.Click += new System.EventHandler(this.Button_cleandisk_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button_deletefile);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.textBox1);
			this.groupBox4.Enabled = false;
			this.groupBox4.Location = new System.Drawing.Point(12, 461);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(325, 39);
			this.groupBox4.TabIndex = 26;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Удаление";
			// 
			// button_deletefile
			// 
			this.button_deletefile.Location = new System.Drawing.Point(241, 13);
			this.button_deletefile.Name = "button_deletefile";
			this.button_deletefile.Size = new System.Drawing.Size(75, 23);
			this.button_deletefile.TabIndex = 2;
			this.button_deletefile.Text = "Удалить";
			this.button_deletefile.UseVisualStyleBackColor = true;
			this.button_deletefile.Click += new System.EventHandler(this.Button_deletefileClick);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(66, 18);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(80, 17);
			this.label11.TabIndex = 1;
			this.label11.Text = "Номер файла";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(152, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(83, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button_help_
			// 
			this.button_help_.Location = new System.Drawing.Point(342, 461);
			this.button_help_.Name = "button_help_";
			this.button_help_.Size = new System.Drawing.Size(138, 39);
			this.button_help_.TabIndex = 27;
			this.button_help_.Text = "Справка";
			this.button_help_.UseVisualStyleBackColor = true;
			this.button_help_.Click += new System.EventHandler(this.Button_help_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 512);
			this.Controls.Add(this.button_help_);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.button_cleandisk_);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button_defragmentthedisk_);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximumSize = new System.Drawing.Size(500, 550);
			this.MinimumSize = new System.Drawing.Size(500, 550);
			this.Name = "MainForm";
			this.Text = "kursovik1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

	}
}
		

		
	

