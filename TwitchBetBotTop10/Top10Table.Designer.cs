namespace TwitchBetBotTop10
{
    partial class Top10Table
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nnneznakomec [999]"}, -1, System.Drawing.Color.Lime, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Prismata_TV [100000]"}, -1, System.Drawing.Color.Lime, System.Drawing.Color.Empty, null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Megamegamegamega [1010101]");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Top10Table));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView_Top10 = new System.Windows.Forms.ListView();
            this.timerTop10 = new System.Windows.Forms.Timer(this.components);
            this.button_Update = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView_Top10);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 265);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top 10 viewers";
            // 
            // listView_Top10
            // 
            this.listView_Top10.BackColor = System.Drawing.SystemColors.InfoText;
            this.listView_Top10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView_Top10.ForeColor = System.Drawing.Color.Lime;
            this.listView_Top10.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listView_Top10.Location = new System.Drawing.Point(6, 19);
            this.listView_Top10.MultiSelect = false;
            this.listView_Top10.Name = "listView_Top10";
            this.listView_Top10.Scrollable = false;
            this.listView_Top10.Size = new System.Drawing.Size(253, 240);
            this.listView_Top10.TabIndex = 7;
            this.listView_Top10.UseCompatibleStateImageBehavior = false;
            this.listView_Top10.View = System.Windows.Forms.View.List;
            // 
            // timerTop10
            // 
            this.timerTop10.Enabled = true;
            this.timerTop10.Interval = 10000;
            this.timerTop10.Tick += new System.EventHandler(this.timerTop10_Tick);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(283, 12);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(162, 265);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // Top10Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 282);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Top10Table";
            this.Text = "Top10Table";
            this.Load += new System.EventHandler(this.ControlDesc_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView_Top10;
        private System.Windows.Forms.Timer timerTop10;
        private System.Windows.Forms.Button button_Update;
    }
}