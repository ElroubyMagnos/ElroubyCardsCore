namespace ElroubyCardsCore.CardItems
{
    partial class Card
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sway = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // Sway
            // 
            this.Sway.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sway.BackgroundImage = global::ElroubyCardsCore.Properties.Resources.black;
            this.Sway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sway.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sway.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sway.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Sway.Location = new System.Drawing.Point(17, 47);
            this.Sway.Name = "Sway";
            this.Sway.Size = new System.Drawing.Size(50, 25);
            this.Sway.TabIndex = 0;
            this.Sway.Text = "Sway";
            this.Sway.UseVisualStyleBackColor = true;
            this.Sway.Visible = false;
            // 
            // Card
            // 
            this.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::ElroubyCardsCore.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Sway);
            this.Size = new System.Drawing.Size(85, 120);
            this.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button Sway;
    }
}
