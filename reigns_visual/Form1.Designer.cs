
namespace reigns_visual
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Txt_narration = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_eglise = new System.Windows.Forms.Label();
            this.label_pop = new System.Windows.Forms.Label();
            this.label_armee = new System.Windows.Forms.Label();
            this.label_argent = new System.Windows.Forms.Label();
            this.label_annee = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_annee = new System.Windows.Forms.TextBox();
            this.button_oui = new System.Windows.Forms.Button();
            this.button_non = new System.Windows.Forms.Button();
            this.txt_eglise = new System.Windows.Forms.RichTextBox();
            this.txt_pop = new System.Windows.Forms.RichTextBox();
            this.txt_armee = new System.Windows.Forms.RichTextBox();
            this.txt_argent = new System.Windows.Forms.RichTextBox();
            this.button_jouer = new System.Windows.Forms.Button();
            this.button_leaderboard = new System.Windows.Forms.Button();
            this.button_quitter = new System.Windows.Forms.Button();
            this.txt_entree_nom = new System.Windows.Forms.RichTextBox();
            this.button_valid_nom = new System.Windows.Forms.Button();
            this.dgv_leaderboard = new System.Windows.Forms.DataGridView();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button_retour = new System.Windows.Forms.Button();
            this.button_rejouer = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leaderboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_narration
            // 
            resources.ApplyResources(this.Txt_narration, "Txt_narration");
            this.Txt_narration.Cursor = System.Windows.Forms.Cursors.Default;
            this.Txt_narration.Name = "Txt_narration";
            this.Txt_narration.TextChanged += new System.EventHandler(this.Txt_narration_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label_eglise
            // 
            resources.ApplyResources(this.label_eglise, "label_eglise");
            this.label_eglise.Name = "label_eglise";
            // 
            // label_pop
            // 
            resources.ApplyResources(this.label_pop, "label_pop");
            this.label_pop.Name = "label_pop";
            // 
            // label_armee
            // 
            resources.ApplyResources(this.label_armee, "label_armee");
            this.label_armee.Name = "label_armee";
            // 
            // label_argent
            // 
            resources.ApplyResources(this.label_argent, "label_argent");
            this.label_argent.Name = "label_argent";
            // 
            // label_annee
            // 
            resources.ApplyResources(this.label_annee, "label_annee");
            this.label_annee.Name = "label_annee";
            // 
            // txt_annee
            // 
            resources.ApplyResources(this.txt_annee, "txt_annee");
            this.txt_annee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_annee.ForeColor = System.Drawing.Color.Black;
            this.txt_annee.Name = "txt_annee";
            this.txt_annee.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_oui
            // 
            resources.ApplyResources(this.button_oui, "button_oui");
            this.button_oui.Name = "button_oui";
            this.button_oui.UseVisualStyleBackColor = true;
            this.button_oui.Click += new System.EventHandler(this.button_oui_Click);
            this.button_oui.MouseEnter += new System.EventHandler(this.button_oui_MouseEnter);
            this.button_oui.MouseLeave += new System.EventHandler(this.button_oui_MouseLeave);
            // 
            // button_non
            // 
            resources.ApplyResources(this.button_non, "button_non");
            this.button_non.Name = "button_non";
            this.button_non.UseVisualStyleBackColor = true;
            this.button_non.Click += new System.EventHandler(this.button_non_Click);
            this.button_non.MouseEnter += new System.EventHandler(this.button_non_MouseEnter);
            this.button_non.MouseLeave += new System.EventHandler(this.button_non_MouseLeave);
            // 
            // txt_eglise
            // 
            resources.ApplyResources(this.txt_eglise, "txt_eglise");
            this.txt_eglise.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_eglise.ForeColor = System.Drawing.Color.Black;
            this.txt_eglise.Name = "txt_eglise";
            // 
            // txt_pop
            // 
            resources.ApplyResources(this.txt_pop, "txt_pop");
            this.txt_pop.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_pop.ForeColor = System.Drawing.Color.Black;
            this.txt_pop.Name = "txt_pop";
            // 
            // txt_armee
            // 
            resources.ApplyResources(this.txt_armee, "txt_armee");
            this.txt_armee.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_armee.ForeColor = System.Drawing.Color.Black;
            this.txt_armee.Name = "txt_armee";
            // 
            // txt_argent
            // 
            resources.ApplyResources(this.txt_argent, "txt_argent");
            this.txt_argent.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_argent.ForeColor = System.Drawing.Color.Black;
            this.txt_argent.Name = "txt_argent";
            this.txt_argent.TextChanged += new System.EventHandler(this.txt_argent_TextChanged);
            // 
            // button_jouer
            // 
            resources.ApplyResources(this.button_jouer, "button_jouer");
            this.button_jouer.Name = "button_jouer";
            this.button_jouer.UseVisualStyleBackColor = true;
            this.button_jouer.Click += new System.EventHandler(this.button_jouer_Click);
            // 
            // button_leaderboard
            // 
            resources.ApplyResources(this.button_leaderboard, "button_leaderboard");
            this.button_leaderboard.Name = "button_leaderboard";
            this.button_leaderboard.UseVisualStyleBackColor = true;
            this.button_leaderboard.Click += new System.EventHandler(this.button_leaderboard_Click);
            // 
            // button_quitter
            // 
            resources.ApplyResources(this.button_quitter, "button_quitter");
            this.button_quitter.Name = "button_quitter";
            this.button_quitter.UseVisualStyleBackColor = true;
            this.button_quitter.Click += new System.EventHandler(this.button_quitter_Click);
            // 
            // txt_entree_nom
            // 
            resources.ApplyResources(this.txt_entree_nom, "txt_entree_nom");
            this.txt_entree_nom.Name = "txt_entree_nom";
            // 
            // button_valid_nom
            // 
            resources.ApplyResources(this.button_valid_nom, "button_valid_nom");
            this.button_valid_nom.Name = "button_valid_nom";
            this.button_valid_nom.UseVisualStyleBackColor = true;
            this.button_valid_nom.Click += new System.EventHandler(this.button_valid_nom_Click);
            // 
            // dgv_leaderboard
            // 
            resources.ApplyResources(this.dgv_leaderboard, "dgv_leaderboard");
            this.dgv_leaderboard.AllowUserToAddRows = false;
            this.dgv_leaderboard.AllowUserToDeleteRows = false;
            this.dgv_leaderboard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_leaderboard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_leaderboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_leaderboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_leaderboard.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_leaderboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_leaderboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_leaderboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_leaderboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_leaderboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_leaderboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.position,
            this.dgv_nom,
            this.dgv_score});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_leaderboard.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_leaderboard.GridColor = System.Drawing.Color.White;
            this.dgv_leaderboard.Name = "dgv_leaderboard";
            this.dgv_leaderboard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_leaderboard.StandardTab = true;
            this.dgv_leaderboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_leaderboard_CellContentClick);
            // 
            // position
            // 
            this.position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.position.FillWeight = 46.63213F;
            resources.ApplyResources(this.position, "position");
            this.position.MaxInputLength = 2;
            this.position.Name = "position";
            // 
            // dgv_nom
            // 
            this.dgv_nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgv_nom.FillWeight = 126.6839F;
            resources.ApplyResources(this.dgv_nom, "dgv_nom");
            this.dgv_nom.MaxInputLength = 30;
            this.dgv_nom.Name = "dgv_nom";
            // 
            // dgv_score
            // 
            this.dgv_score.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dgv_score.FillWeight = 126.6839F;
            resources.ApplyResources(this.dgv_score, "dgv_score");
            this.dgv_score.MaxInputLength = 4;
            this.dgv_score.Name = "dgv_score";
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // button_retour
            // 
            resources.ApplyResources(this.button_retour, "button_retour");
            this.button_retour.Name = "button_retour";
            this.button_retour.UseVisualStyleBackColor = true;
            this.button_retour.Click += new System.EventHandler(this.button_retour_Click);
            // 
            // button_rejouer
            // 
            resources.ApplyResources(this.button_rejouer, "button_rejouer");
            this.button_rejouer.Name = "button_rejouer";
            this.button_rejouer.UseVisualStyleBackColor = true;
            this.button_rejouer.Click += new System.EventHandler(this.button_rejouer_Click);
            // 
            // button_menu
            // 
            resources.ApplyResources(this.button_menu, "button_menu");
            this.button_menu.Name = "button_menu";
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // Logo
            // 
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Image = global::reigns_visual.Properties.Resources.reigns;
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // button_start
            // 
            resources.ApplyResources(this.button_start, "button_start");
            this.button_start.Name = "button_start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_rejouer);
            this.Controls.Add(this.button_retour);
            this.Controls.Add(this.dgv_leaderboard);
            this.Controls.Add(this.button_valid_nom);
            this.Controls.Add(this.txt_entree_nom);
            this.Controls.Add(this.button_quitter);
            this.Controls.Add(this.button_leaderboard);
            this.Controls.Add(this.button_jouer);
            this.Controls.Add(this.txt_argent);
            this.Controls.Add(this.txt_armee);
            this.Controls.Add(this.txt_pop);
            this.Controls.Add(this.txt_eglise);
            this.Controls.Add(this.button_non);
            this.Controls.Add(this.button_oui);
            this.Controls.Add(this.txt_annee);
            this.Controls.Add(this.label_annee);
            this.Controls.Add(this.label_argent);
            this.Controls.Add(this.label_armee);
            this.Controls.Add(this.label_pop);
            this.Controls.Add(this.label_eglise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_narration);
            this.Controls.Add(this.Logo);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leaderboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_eglise;
        private System.Windows.Forms.Label label_pop;
        private System.Windows.Forms.Label label_armee;
        private System.Windows.Forms.Label label_argent;
        private System.Windows.Forms.Label label_annee;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_annee;
        private System.Windows.Forms.Button button_oui;
        private System.Windows.Forms.Button button_non;
        private System.Windows.Forms.RichTextBox txt_eglise;
        private System.Windows.Forms.RichTextBox txt_pop;
        private System.Windows.Forms.RichTextBox txt_armee;
        private System.Windows.Forms.RichTextBox txt_argent;
        private System.Windows.Forms.Button button_jouer;
        private System.Windows.Forms.Button button_leaderboard;
        private System.Windows.Forms.Button button_quitter;
        private System.Windows.Forms.RichTextBox txt_entree_nom;
        private System.Windows.Forms.Button button_valid_nom;
        private System.Windows.Forms.DataGridView dgv_leaderboard;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button_retour;
        private System.Windows.Forms.Button button_rejouer;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.RichTextBox Txt_narration;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_score;
    }
}

