namespace ElroubyCardsCore
{
    partial class ScoreWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreWindow));
            this.Score = new System.Windows.Forms.TableLayoutPanel();
            this.Guest = new System.Windows.Forms.Label();
            this.Host = new System.Windows.Forms.Label();
            this.Deck = new System.Windows.Forms.TableLayoutPanel();
            this.Clubs = new System.Windows.Forms.Label();
            this.Hearts = new System.Windows.Forms.Label();
            this.Spades = new System.Windows.Forms.Label();
            this.Cards = new System.Windows.Forms.Label();
            this.Diamonds = new System.Windows.Forms.Label();
            this.Club = new System.Windows.Forms.Control();
            this.Spade = new System.Windows.Forms.Control();
            this.Heart = new System.Windows.Forms.Control();
            this.Diamond = new System.Windows.Forms.Control();
            this.TotalRemain = new System.Windows.Forms.Control();
            this.ComputerScore = new ElroubyCardsCore.Score();
            this.PlayerScore = new ElroubyCardsCore.Score();
            this.Score.SuspendLayout();
            this.Deck.SuspendLayout();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.BackColor = System.Drawing.Color.Transparent;
            this.Score.ColumnCount = 2;
            this.Score.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Score.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Score.Controls.Add(this.ComputerScore, 1, 1);
            this.Score.Controls.Add(this.PlayerScore, 0, 1);
            this.Score.Controls.Add(this.Guest, 1, 0);
            this.Score.Controls.Add(this.Host, 0, 0);
            this.Score.Location = new System.Drawing.Point(3, 3);
            this.Score.Name = "Score";
            this.Score.RowCount = 2;
            this.Score.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.9439F));
            this.Score.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.0561F));
            this.Score.Size = new System.Drawing.Size(220, 48);
            this.Score.TabIndex = 1;
            // 
            // Computer
            // 
            this.Guest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Guest.AutoSize = true;
            this.Guest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Guest.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Guest.ForeColor = System.Drawing.Color.White;
            this.Guest.Location = new System.Drawing.Point(113, 0);
            this.Guest.Name = "Computer";
            this.Guest.Size = new System.Drawing.Size(104, 25);
            this.Guest.TabIndex = 1;
            this.Guest.Text = "Computer";
            this.Guest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player
            // 
            this.Host.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Host.AutoSize = true;
            this.Host.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Host.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.Host.ForeColor = System.Drawing.Color.White;
            this.Host.Location = new System.Drawing.Point(3, 0);
            this.Host.Name = "Player";
            this.Host.Size = new System.Drawing.Size(104, 25);
            this.Host.TabIndex = 0;
            this.Host.Text = "Player";
            this.Host.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Deck
            // 
            this.Deck.ColumnCount = 5;
            this.Deck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.09346F));
            this.Deck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.15888F));
            this.Deck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Deck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Deck.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.Deck.Controls.Add(this.Clubs, 0, 1);
            this.Deck.Controls.Add(this.Hearts, 0, 1);
            this.Deck.Controls.Add(this.Spades, 0, 1);
            this.Deck.Controls.Add(this.Cards, 0, 1);
            this.Deck.Controls.Add(this.Diamonds, 0, 1);
            this.Deck.Controls.Add(this.Club, 0, 0);
            this.Deck.Controls.Add(this.Spade, 1, 0);
            this.Deck.Controls.Add(this.Heart, 2, 0);
            this.Deck.Controls.Add(this.Diamond, 3, 0);
            this.Deck.Controls.Add(this.TotalRemain, 4, 0);
            this.Deck.Location = new System.Drawing.Point(6, 57);
            this.Deck.Name = "Deck";
            this.Deck.RowCount = 2;
            this.Deck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Deck.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Deck.Size = new System.Drawing.Size(214, 61);
            this.Deck.TabIndex = 2;
            // 
            // Clubs
            // 
            this.Clubs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clubs.AutoSize = true;
            this.Clubs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Clubs.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clubs.ForeColor = System.Drawing.Color.White;
            this.Clubs.Location = new System.Drawing.Point(3, 30);
            this.Clubs.Name = "Clubs";
            this.Clubs.Size = new System.Drawing.Size(37, 31);
            this.Clubs.TabIndex = 12;
            this.Clubs.Text = "13";
            this.Clubs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hearts
            // 
            this.Hearts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Hearts.AutoSize = true;
            this.Hearts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Hearts.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hearts.ForeColor = System.Drawing.Color.White;
            this.Hearts.Location = new System.Drawing.Point(87, 30);
            this.Hearts.Name = "Hearts";
            this.Hearts.Size = new System.Drawing.Size(37, 31);
            this.Hearts.TabIndex = 11;
            this.Hearts.Text = "13";
            this.Hearts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Spades
            // 
            this.Spades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spades.AutoSize = true;
            this.Spades.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Spades.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spades.ForeColor = System.Drawing.Color.White;
            this.Spades.Location = new System.Drawing.Point(46, 30);
            this.Spades.Name = "Spades";
            this.Spades.Size = new System.Drawing.Size(35, 31);
            this.Spades.TabIndex = 10;
            this.Spades.Text = "13";
            this.Spades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cards
            // 
            this.Cards.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cards.AutoSize = true;
            this.Cards.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Cards.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cards.ForeColor = System.Drawing.Color.White;
            this.Cards.Location = new System.Drawing.Point(173, 30);
            this.Cards.Name = "Cards";
            this.Cards.Size = new System.Drawing.Size(38, 31);
            this.Cards.TabIndex = 9;
            this.Cards.Text = "52";
            this.Cards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Diamonds
            // 
            this.Diamonds.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diamonds.AutoSize = true;
            this.Diamonds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Diamonds.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diamonds.ForeColor = System.Drawing.Color.White;
            this.Diamonds.Location = new System.Drawing.Point(130, 30);
            this.Diamonds.Name = "Diamonds";
            this.Diamonds.Size = new System.Drawing.Size(37, 31);
            this.Diamonds.TabIndex = 6;
            this.Diamonds.Text = "13";
            this.Diamonds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Club
            // 
            this.Club.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Club.BackColor = System.Drawing.Color.White;
            this.Club.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Club.BackgroundImage")));
            this.Club.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Club.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Club.ForeColor = System.Drawing.Color.White;
            this.Club.Location = new System.Drawing.Point(3, 3);
            this.Club.Name = "Club";
            this.Club.Size = new System.Drawing.Size(37, 24);
            this.Club.TabIndex = 3;
            // 
            // Spade
            // 
            this.Spade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Spade.BackColor = System.Drawing.Color.White;
            this.Spade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Spade.BackgroundImage")));
            this.Spade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spade.ForeColor = System.Drawing.Color.White;
            this.Spade.Location = new System.Drawing.Point(46, 3);
            this.Spade.Name = "Spade";
            this.Spade.Size = new System.Drawing.Size(35, 24);
            this.Spade.TabIndex = 7;
            // 
            // Heart
            // 
            this.Heart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Heart.BackColor = System.Drawing.Color.White;
            this.Heart.BackgroundImage = global::ElroubyCardsCore.Properties.Resources.tHeart;
            this.Heart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Heart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heart.ForeColor = System.Drawing.Color.White;
            this.Heart.Location = new System.Drawing.Point(87, 3);
            this.Heart.Name = "Heart";
            this.Heart.Size = new System.Drawing.Size(37, 24);
            this.Heart.TabIndex = 4;
            // 
            // Diamond
            // 
            this.Diamond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Diamond.BackColor = System.Drawing.Color.White;
            this.Diamond.BackgroundImage = global::ElroubyCardsCore.Properties.Resources.tDiamond;
            this.Diamond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Diamond.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Diamond.ForeColor = System.Drawing.Color.White;
            this.Diamond.Location = new System.Drawing.Point(130, 3);
            this.Diamond.Name = "Diamond";
            this.Diamond.Size = new System.Drawing.Size(37, 24);
            this.Diamond.TabIndex = 5;
            // 
            // TotalRemain
            // 
            this.TotalRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalRemain.BackColor = System.Drawing.Color.White;
            this.TotalRemain.BackgroundImage = global::ElroubyCardsCore.Properties.Resources.back;
            this.TotalRemain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TotalRemain.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalRemain.ForeColor = System.Drawing.Color.White;
            this.TotalRemain.Location = new System.Drawing.Point(173, 3);
            this.TotalRemain.Name = "TotalRemain";
            this.TotalRemain.Size = new System.Drawing.Size(38, 24);
            this.TotalRemain.TabIndex = 8;
            // 
            // ComputerScore
            // 
            this.ComputerScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerScore.AutoSize = true;
            this.ComputerScore.BackColor = System.Drawing.Color.Transparent;
            this.ComputerScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ComputerScore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerScore.ForeColor = System.Drawing.Color.White;
            this.ComputerScore.Location = new System.Drawing.Point(113, 25);
            this.ComputerScore.Name = "ComputerScore";
            this.ComputerScore.Size = new System.Drawing.Size(104, 23);
            this.ComputerScore.TabIndex = 3;
            this.ComputerScore.Text = "0";
            this.ComputerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComputerScore.Value = 0;
            // 
            // PlayerScore
            // 
            this.PlayerScore.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlayerScore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.Color.White;
            this.PlayerScore.Location = new System.Drawing.Point(3, 25);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(104, 23);
            this.PlayerScore.TabIndex = 2;
            this.PlayerScore.Text = "0";
            this.PlayerScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerScore.Value = 0;
            // 
            // ScoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ElroubyCardsCore.Properties.Resources.ScoreTV;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.Deck);
            this.Controls.Add(this.Score);
            this.DoubleBuffered = true;
            this.Name = "ScoreWindow";
            this.Size = new System.Drawing.Size(226, 148);
            this.Score.ResumeLayout(false);
            this.Score.PerformLayout();
            this.Deck.ResumeLayout(false);
            this.Deck.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TableLayoutPanel Score;
        public System.Windows.Forms.Label Host;
        public System.Windows.Forms.Label Guest;
        public Score PlayerScore;
        public Score ComputerScore;
        public System.Windows.Forms.TableLayoutPanel Deck;
        public System.Windows.Forms.Label Clubs;
        public System.Windows.Forms.Label Hearts;
        public System.Windows.Forms.Label Spades;
        public System.Windows.Forms.Label Cards;
        public System.Windows.Forms.Label Diamonds;
        public System.Windows.Forms.Control Club;
        public System.Windows.Forms.Control Spade;
        public System.Windows.Forms.Control Heart;
        public System.Windows.Forms.Control Diamond;
        public System.Windows.Forms.Control TotalRemain;
    }
}
