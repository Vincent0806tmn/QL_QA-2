namespace SuongSuon
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node6");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.img_ls = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_TongQuan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pnl_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnl_Menu.Controls.Add(this.treeView1);
            this.pnl_Menu.Controls.Add(this.button1);
            this.pnl_Menu.Controls.Add(this.btn_TongQuan);
            this.pnl_Menu.Controls.Add(this.pictureBox1);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(177, 583);
            this.pnl_Menu.TabIndex = 0;
            // 
            // img_ls
            // 
            this.img_ls.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.img_ls.ImageSize = new System.Drawing.Size(16, 16);
            this.img_ls.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SuongSuon.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(177, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(177, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 483);
            this.panel2.TabIndex = 2;
            // 
            // btn_TongQuan
            // 
            this.btn_TongQuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_TongQuan.Location = new System.Drawing.Point(0, 129);
            this.btn_TongQuan.Name = "btn_TongQuan";
            this.btn_TongQuan.Size = new System.Drawing.Size(177, 73);
            this.btn_TongQuan.TabIndex = 1;
            this.btn_TongQuan.Text = "button1";
            this.btn_TongQuan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.treeView1.Location = new System.Drawing.Point(0, 202);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node4";
            treeNode1.Text = "Node4";
            treeNode2.Name = "Node5";
            treeNode2.Text = "Node5";
            treeNode3.Name = "Node6";
            treeNode3.Text = "Node6";
            treeNode4.Name = "Node7";
            treeNode4.Text = "Node7";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Node0";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(177, 70);
            this.treeView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 583);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Menu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList img_ls;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_TongQuan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
    }
}

