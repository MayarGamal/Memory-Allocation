namespace Memory_Allocation_Segmentation
{
    partial class Memory
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
            this.Memory_size_txt = new System.Windows.Forms.Label();
            this.Memory_size = new System.Windows.Forms.TextBox();
            this.starting_add_txt = new System.Windows.Forms.Label();
            this.Hole_size_txt = new System.Windows.Forms.Label();
            this.starting_add = new System.Windows.Forms.TextBox();
            this.Hole_size = new System.Windows.Forms.TextBox();
            this.No_seg_txt = new System.Windows.Forms.Label();
            this.Seg_name_txt = new System.Windows.Forms.Label();
            this.Seg_size_txt = new System.Windows.Forms.Label();
            this.No_seg = new System.Windows.Forms.TextBox();
            this.Seg_name = new System.Windows.Forms.TextBox();
            this.Seg_size = new System.Windows.Forms.TextBox();
            this.Allocation_list = new System.Windows.Forms.ComboBox();
            this.Holes_box = new System.Windows.Forms.GroupBox();
            this.submit_btn = new System.Windows.Forms.Button();
            this.No_hole = new System.Windows.Forms.TextBox();
            this.No_hole_txt = new System.Windows.Forms.Label();
            this.Segments_box = new System.Windows.Forms.GroupBox();
            this.submit_btn2 = new System.Windows.Forms.Button();
            this.Generate_btn = new System.Windows.Forms.Button();
            this.Deallocate_box = new System.Windows.Forms.ComboBox();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.Add_procees_btn = new System.Windows.Forms.Button();
            this.dealloacate_box = new System.Windows.Forms.GroupBox();
            this.deallocate_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.Shuffle_btn = new System.Windows.Forms.Button();
            this.Holes_box.SuspendLayout();
            this.Segments_box.SuspendLayout();
            this.dealloacate_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Memory_size_txt
            // 
            this.Memory_size_txt.AutoSize = true;
            this.Memory_size_txt.Location = new System.Drawing.Point(19, 48);
            this.Memory_size_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Memory_size_txt.Name = "Memory_size_txt";
            this.Memory_size_txt.Size = new System.Drawing.Size(95, 13);
            this.Memory_size_txt.TabIndex = 0;
            this.Memory_size_txt.Text = "Enter Memory Size";
            this.Memory_size_txt.Click += new System.EventHandler(this.Memory_size_txt_Click);
            // 
            // Memory_size
            // 
            this.Memory_size.BackColor = System.Drawing.SystemColors.Window;
            this.Memory_size.Location = new System.Drawing.Point(145, 45);
            this.Memory_size.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Memory_size.Name = "Memory_size";
            this.Memory_size.Size = new System.Drawing.Size(100, 20);
            this.Memory_size.TabIndex = 1;
            this.Memory_size.TextChanged += new System.EventHandler(this.Memory_size_TextChanged);
            this.Memory_size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Memory_size_KeyDown);
            // 
            // starting_add_txt
            // 
            this.starting_add_txt.AutoSize = true;
            this.starting_add_txt.Location = new System.Drawing.Point(20, 84);
            this.starting_add_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.starting_add_txt.Name = "starting_add_txt";
            this.starting_add_txt.Size = new System.Drawing.Size(81, 13);
            this.starting_add_txt.TabIndex = 3;
            this.starting_add_txt.Text = "starting address";
            this.starting_add_txt.Click += new System.EventHandler(this.Starting_add_txt_Click);
            // 
            // Hole_size_txt
            // 
            this.Hole_size_txt.AutoSize = true;
            this.Hole_size_txt.Location = new System.Drawing.Point(20, 131);
            this.Hole_size_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Hole_size_txt.Name = "Hole_size_txt";
            this.Hole_size_txt.Size = new System.Drawing.Size(64, 13);
            this.Hole_size_txt.TabIndex = 4;
            this.Hole_size_txt.Text = "Size of Hole";
            this.Hole_size_txt.Click += new System.EventHandler(this.Hole_size_txt_Click);
            // 
            // starting_add
            // 
            this.starting_add.Location = new System.Drawing.Point(143, 84);
            this.starting_add.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.starting_add.Name = "starting_add";
            this.starting_add.Size = new System.Drawing.Size(100, 20);
            this.starting_add.TabIndex = 6;
            this.starting_add.TextChanged += new System.EventHandler(this.Starting_add_TextChanged);
            // 
            // Hole_size
            // 
            this.Hole_size.Location = new System.Drawing.Point(143, 129);
            this.Hole_size.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Hole_size.Name = "Hole_size";
            this.Hole_size.Size = new System.Drawing.Size(100, 20);
            this.Hole_size.TabIndex = 7;
            this.Hole_size.TextChanged += new System.EventHandler(this.Hole_size_TextChanged);
            // 
            // No_seg_txt
            // 
            this.No_seg_txt.AutoSize = true;
            this.No_seg_txt.Location = new System.Drawing.Point(13, 33);
            this.No_seg_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.No_seg_txt.Name = "No_seg_txt";
            this.No_seg_txt.Size = new System.Drawing.Size(104, 13);
            this.No_seg_txt.TabIndex = 8;
            this.No_seg_txt.Text = "Number of segments";
            this.No_seg_txt.Click += new System.EventHandler(this.No_seg_txt_Click);
            // 
            // Seg_name_txt
            // 
            this.Seg_name_txt.AutoSize = true;
            this.Seg_name_txt.Location = new System.Drawing.Point(13, 79);
            this.Seg_name_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Seg_name_txt.Name = "Seg_name_txt";
            this.Seg_name_txt.Size = new System.Drawing.Size(90, 13);
            this.Seg_name_txt.TabIndex = 9;
            this.Seg_name_txt.Text = "Name of segment";
            this.Seg_name_txt.Click += new System.EventHandler(this.Seg_name_txt_Click);
            // 
            // Seg_size_txt
            // 
            this.Seg_size_txt.AutoSize = true;
            this.Seg_size_txt.Location = new System.Drawing.Point(17, 118);
            this.Seg_size_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Seg_size_txt.Name = "Seg_size_txt";
            this.Seg_size_txt.Size = new System.Drawing.Size(87, 13);
            this.Seg_size_txt.TabIndex = 10;
            this.Seg_size_txt.Text = "Size of segments";
            this.Seg_size_txt.Click += new System.EventHandler(this.Seg_size_txt_Click);
            // 
            // No_seg
            // 
            this.No_seg.Location = new System.Drawing.Point(169, 27);
            this.No_seg.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.No_seg.Name = "No_seg";
            this.No_seg.Size = new System.Drawing.Size(54, 20);
            this.No_seg.TabIndex = 11;
            this.No_seg.TextChanged += new System.EventHandler(this.No_seg_TextChanged);
            this.No_seg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.No_seg_KeyDown);
            // 
            // Seg_name
            // 
            this.Seg_name.Location = new System.Drawing.Point(144, 79);
            this.Seg_name.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Seg_name.Name = "Seg_name";
            this.Seg_name.Size = new System.Drawing.Size(100, 20);
            this.Seg_name.TabIndex = 12;
            this.Seg_name.TextChanged += new System.EventHandler(this.Seg_name_TextChanged);
            // 
            // Seg_size
            // 
            this.Seg_size.Location = new System.Drawing.Point(144, 118);
            this.Seg_size.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Seg_size.Name = "Seg_size";
            this.Seg_size.Size = new System.Drawing.Size(100, 20);
            this.Seg_size.TabIndex = 13;
            this.Seg_size.TextChanged += new System.EventHandler(this.Seg_size_TextChanged);
            // 
            // Allocation_list
            // 
            this.Allocation_list.FormattingEnabled = true;
            this.Allocation_list.Items.AddRange(new object[] {
            "First fit",
            "Best fit",
            "Worst fit"});
            this.Allocation_list.Location = new System.Drawing.Point(20, 308);
            this.Allocation_list.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Allocation_list.Name = "Allocation_list";
            this.Allocation_list.Size = new System.Drawing.Size(191, 21);
            this.Allocation_list.TabIndex = 17;
            this.Allocation_list.Text = "Method of Allocation";
            this.Allocation_list.SelectedIndexChanged += new System.EventHandler(this.Allocation_list_SelectedIndexChanged);
            // 
            // Holes_box
            // 
            this.Holes_box.Controls.Add(this.submit_btn);
            this.Holes_box.Controls.Add(this.starting_add_txt);
            this.Holes_box.Controls.Add(this.starting_add);
            this.Holes_box.Controls.Add(this.Hole_size_txt);
            this.Holes_box.Controls.Add(this.No_hole);
            this.Holes_box.Controls.Add(this.Hole_size);
            this.Holes_box.Controls.Add(this.No_hole_txt);
            this.Holes_box.Location = new System.Drawing.Point(23, 87);
            this.Holes_box.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Holes_box.Name = "Holes_box";
            this.Holes_box.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Holes_box.Size = new System.Drawing.Size(335, 207);
            this.Holes_box.TabIndex = 18;
            this.Holes_box.TabStop = false;
            this.Holes_box.Text = "Holes";
            // 
            // submit_btn
            // 
            this.submit_btn.Location = new System.Drawing.Point(115, 165);
            this.submit_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(74, 22);
            this.submit_btn.TabIndex = 8;
            this.submit_btn.Text = "Add Hole";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.Submit_btn_Click);
            // 
            // No_hole
            // 
            this.No_hole.Location = new System.Drawing.Point(175, 35);
            this.No_hole.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.No_hole.Name = "No_hole";
            this.No_hole.Size = new System.Drawing.Size(48, 20);
            this.No_hole.TabIndex = 22;
            this.No_hole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.No_hole_KeyDown);
            // 
            // No_hole_txt
            // 
            this.No_hole_txt.AutoSize = true;
            this.No_hole_txt.Location = new System.Drawing.Point(20, 38);
            this.No_hole_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.No_hole_txt.Name = "No_hole_txt";
            this.No_hole_txt.Size = new System.Drawing.Size(86, 13);
            this.No_hole_txt.TabIndex = 21;
            this.No_hole_txt.Text = "Number of Holes";
            // 
            // Segments_box
            // 
            this.Segments_box.Controls.Add(this.submit_btn2);
            this.Segments_box.Controls.Add(this.Seg_name);
            this.Segments_box.Controls.Add(this.Seg_size);
            this.Segments_box.Controls.Add(this.Seg_size_txt);
            this.Segments_box.Controls.Add(this.Seg_name_txt);
            this.Segments_box.Controls.Add(this.No_seg);
            this.Segments_box.Controls.Add(this.No_seg_txt);
            this.Segments_box.Enabled = false;
            this.Segments_box.Location = new System.Drawing.Point(20, 381);
            this.Segments_box.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Segments_box.Name = "Segments_box";
            this.Segments_box.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Segments_box.Size = new System.Drawing.Size(335, 204);
            this.Segments_box.TabIndex = 19;
            this.Segments_box.TabStop = false;
            this.Segments_box.Text = "Segments";
            // 
            // submit_btn2
            // 
            this.submit_btn2.Location = new System.Drawing.Point(98, 160);
            this.submit_btn2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.submit_btn2.Name = "submit_btn2";
            this.submit_btn2.Size = new System.Drawing.Size(92, 22);
            this.submit_btn2.TabIndex = 14;
            this.submit_btn2.Text = "Add Segment";
            this.submit_btn2.UseVisualStyleBackColor = true;
            this.submit_btn2.Click += new System.EventHandler(this.Submit_btn2_Click);
            // 
            // Generate_btn
            // 
            this.Generate_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Generate_btn.Location = new System.Drawing.Point(413, 108);
            this.Generate_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Generate_btn.Name = "Generate_btn";
            this.Generate_btn.Size = new System.Drawing.Size(103, 22);
            this.Generate_btn.TabIndex = 23;
            this.Generate_btn.Text = "Draw";
            this.Generate_btn.UseVisualStyleBackColor = true;
            this.Generate_btn.Click += new System.EventHandler(this.Generate_btn_Click);
            // 
            // Deallocate_box
            // 
            this.Deallocate_box.FormattingEnabled = true;
            this.Deallocate_box.Location = new System.Drawing.Point(7, 22);
            this.Deallocate_box.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Deallocate_box.Name = "Deallocate_box";
            this.Deallocate_box.Size = new System.Drawing.Size(191, 21);
            this.Deallocate_box.TabIndex = 24;
            this.Deallocate_box.Text = "Process";
            this.Deallocate_box.SelectedIndexChanged += new System.EventHandler(this.Deallocate_box_SelectedIndexChanged);
            this.Deallocate_box.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Deallocate_ControlAdded);
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(20, 611);
            this.Reset_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(212, 22);
            this.Reset_btn.TabIndex = 25;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // Add_procees_btn
            // 
            this.Add_procees_btn.Location = new System.Drawing.Point(218, 308);
            this.Add_procees_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Add_procees_btn.Name = "Add_procees_btn";
            this.Add_procees_btn.Size = new System.Drawing.Size(138, 22);
            this.Add_procees_btn.TabIndex = 26;
            this.Add_procees_btn.Text = "Add Process";
            this.Add_procees_btn.UseVisualStyleBackColor = true;
            this.Add_procees_btn.Click += new System.EventHandler(this.Add_procees_btn_Click);
            // 
            // dealloacate_box
            // 
            this.dealloacate_box.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dealloacate_box.Controls.Add(this.deallocate_btn);
            this.dealloacate_box.Controls.Add(this.Deallocate_box);
            this.dealloacate_box.Location = new System.Drawing.Point(362, 25);
            this.dealloacate_box.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dealloacate_box.Name = "dealloacate_box";
            this.dealloacate_box.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dealloacate_box.Size = new System.Drawing.Size(331, 65);
            this.dealloacate_box.TabIndex = 28;
            this.dealloacate_box.TabStop = false;
            this.dealloacate_box.Text = "Deallocate Process";
            // 
            // deallocate_btn
            // 
            this.deallocate_btn.Location = new System.Drawing.Point(230, 19);
            this.deallocate_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.deallocate_btn.Name = "deallocate_btn";
            this.deallocate_btn.Size = new System.Drawing.Size(74, 22);
            this.deallocate_btn.TabIndex = 25;
            this.deallocate_btn.Text = "Deallocate";
            this.deallocate_btn.UseVisualStyleBackColor = true;
            this.deallocate_btn.Click += new System.EventHandler(this.Deallocate_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Clear_btn.Location = new System.Drawing.Point(553, 108);
            this.Clear_btn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(119, 22);
            this.Clear_btn.TabIndex = 29;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Shuffle_btn
            // 
            this.Shuffle_btn.Location = new System.Drawing.Point(237, 610);
            this.Shuffle_btn.Name = "Shuffle_btn";
            this.Shuffle_btn.Size = new System.Drawing.Size(121, 23);
            this.Shuffle_btn.TabIndex = 30;
            this.Shuffle_btn.Text = "Shuffle";
            this.Shuffle_btn.UseVisualStyleBackColor = true;
            this.Shuffle_btn.Click += new System.EventHandler(this.Shuffle_btn_Click);
            // 
            // Memory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(701, 649);
            this.Controls.Add(this.Shuffle_btn);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.dealloacate_box);
            this.Controls.Add(this.Add_procees_btn);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.Generate_btn);
            this.Controls.Add(this.Segments_box);
            this.Controls.Add(this.Holes_box);
            this.Controls.Add(this.Allocation_list);
            this.Controls.Add(this.Memory_size);
            this.Controls.Add(this.Memory_size_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Memory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory Allocation";
            this.Load += new System.EventHandler(this.Memory_Load);
            this.Holes_box.ResumeLayout(false);
            this.Holes_box.PerformLayout();
            this.Segments_box.ResumeLayout(false);
            this.Segments_box.PerformLayout();
            this.dealloacate_box.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Memory_size_txt;
        private System.Windows.Forms.TextBox Memory_size;
        private System.Windows.Forms.Label starting_add_txt;
        private System.Windows.Forms.Label Hole_size_txt;
        private System.Windows.Forms.TextBox starting_add;
        private System.Windows.Forms.TextBox Hole_size;
        private System.Windows.Forms.Label No_seg_txt;
        private System.Windows.Forms.Label Seg_name_txt;
        private System.Windows.Forms.Label Seg_size_txt;
        private System.Windows.Forms.TextBox No_seg;
        private System.Windows.Forms.TextBox Seg_name;
        private System.Windows.Forms.TextBox Seg_size;
        private System.Windows.Forms.ComboBox Allocation_list;
        private System.Windows.Forms.GroupBox Holes_box;
        private System.Windows.Forms.GroupBox Segments_box;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button submit_btn2;
        private System.Windows.Forms.TextBox No_hole;
        private System.Windows.Forms.Label No_hole_txt;
        private System.Windows.Forms.Button Generate_btn;
        private System.Windows.Forms.ComboBox Deallocate_box;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.Button Add_procees_btn;
        private System.Windows.Forms.GroupBox dealloacate_box;
        private System.Windows.Forms.Button deallocate_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.Button Shuffle_btn;
    }
}

