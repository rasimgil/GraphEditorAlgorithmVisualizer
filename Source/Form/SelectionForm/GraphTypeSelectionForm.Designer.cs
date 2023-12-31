﻿namespace GraphEditor
{
    partial class GraphTypeSelectionForm
    {
        private System.Windows.Forms.Button directedButton;
        private System.Windows.Forms.Button undirectedButton;

        private void InitializeComponent()
        {
            this.directedButton = new System.Windows.Forms.Button();
            this.undirectedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // directedButton
            // 
            this.directedButton.Location = new System.Drawing.Point(91, 338);
            this.directedButton.Name = "directedButton";
            this.directedButton.Size = new System.Drawing.Size(445, 81);
            this.directedButton.TabIndex = 1;
            this.directedButton.Text = "Directed Graph";
            this.directedButton.Click += new System.EventHandler(this.directedButton_Click);
            // 
            // undirectedButton
            // 
            this.undirectedButton.Location = new System.Drawing.Point(91, 185);
            this.undirectedButton.Name = "undirectedButton";
            this.undirectedButton.Size = new System.Drawing.Size(445, 81);
            this.undirectedButton.TabIndex = 0;
            this.undirectedButton.Text = "Undirected Graph";
            this.undirectedButton.Click += new System.EventHandler(this.undirectedButton_Click);
            // 
            // GraphTypeSelectionForm
            // 
            this.ClientSize = new System.Drawing.Size(662, 593);
            this.Controls.Add(this.undirectedButton);
            this.Controls.Add(this.directedButton);
            this.Name = "GraphTypeSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graph Type Selection";
            this.ResumeLayout(false);

        }
    }
}
