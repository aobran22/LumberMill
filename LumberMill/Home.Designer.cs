namespace LumberMill
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            client = new Button();
            dgv_client = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_client).BeginInit();
            SuspendLayout();
            // 
            // client
            // 
            client.Location = new Point(98, 55);
            client.Name = "client";
            client.Size = new Size(160, 105);
            client.TabIndex = 0;
            client.Text = "Klijent";
            client.UseVisualStyleBackColor = true;
            // 
            // dgv_client
            // 
            dgv_client.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_client.Location = new Point(344, 68);
            dgv_client.Name = "dgv_client";
            dgv_client.RowHeadersWidth = 51;
            dgv_client.Size = new Size(367, 183);
            dgv_client.TabIndex = 1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_client);
            Controls.Add(client);
            Name = "Home";
            Text = "Početna";
            ((System.ComponentModel.ISupportInitialize)dgv_client).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button client;
        private DataGridView dgv_client;
    }
}
