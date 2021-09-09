using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace reigns_visual
{
    public partial class Form1 : Form
    {
        static string dsnConnection = "server=localhost;database=reigns;uid=root;password=''"; //préparation pour la connection à la bdd
        static MySqlConnection dbConnection = new MySqlConnection(dsnConnection);
        Random nb = new Random();
        List<Evenement> liste_event = new List<Evenement>();
        Evenement evenement_actuel;
        int num_event;
        string nom;
        int eglise = 50;
        int population = 50;
        int armee = 50;
        int argent = 50;
        int anneepouvoir = 0;
        public Form1()
        {
            InitializeComponent();
        }
        void load()
        {
            string Query = "SELECT DISTINCT * FROM reponse, evenements WHERE evenements.ID_EVENEMENT = reponse.ID_EVENEMENT ORDER BY ID_REPONSE";   // Importation des évènements depuis la bdd
            dbConnection.Open();
            MySqlCommand command = dbConnection.CreateCommand();
            command.CommandText = Query;
            MySqlDataReader dataReader = command.ExecuteReader();
            int numevent = 0;
            int i = 0;
            while (dataReader.Read())     //Entrée de tout les évènements dans une list d'objets Evenement
            {
                if (i % 2 == 0)
                {
                    Evenement evenement = new Evenement(dataReader["ENONCE"].ToString());
                    liste_event.Add(evenement);
                    liste_event[numevent].ajoutReponse(dataReader["CHOIX"].ToString(), int.Parse(dataReader["EGLISE"].ToString()), int.Parse(dataReader["POPULATION"].ToString()), int.Parse(dataReader["ARMEE"].ToString()), int.Parse(dataReader["ARGENT"].ToString()));
                }
                else
                {
                    liste_event[numevent].ajoutReponse(dataReader["CHOIX"].ToString(), int.Parse(dataReader["EGLISE"].ToString()), int.Parse(dataReader["POPULATION"].ToString()), int.Parse(dataReader["ARMEE"].ToString()), int.Parse(dataReader["ARGENT"].ToString()));
                    numevent++;
                }
                i++;
            }
            dbConnection.Close();
            liste_event[0].ajoutReponse("oui", 10, 0, -15, 0);
            liste_event[0].ajoutReponse("non", 0, 0, 0, 0);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            load();
            menu_principal();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_oui_MouseEnter(object sender, EventArgs e)
        {
            if (liste_event[num_event].getReponse(0).getEglise() < 0)
            {
                txt_eglise.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(0).getEglise() > 0)
            {
                txt_eglise.ForeColor = Color.Green;
            }
            else
            {

            }

            if (liste_event[num_event].getReponse(0).getPopulation() < 0)
            {
                txt_pop.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(0).getPopulation() > 0)
            {
                txt_pop.ForeColor = Color.Green;
            }

            if (liste_event[num_event].getReponse(0).getArmee() < 0)
            {
                txt_armee.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(0).getArmee() > 0)
            {
                txt_armee.ForeColor = Color.Green;
            }

            if (liste_event[num_event].getReponse(0).getArgent() < 0)
            {
                txt_argent.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(0).getArgent() > 0)
            {
                txt_argent.ForeColor = Color.Green;
            }

        }
        private void button_oui_MouseLeave(object sender, EventArgs e)
        {
            txt_eglise.ForeColor = Color.Black;
            txt_pop.ForeColor = Color.Black;
            txt_armee.ForeColor = Color.Black;
            txt_argent.ForeColor = Color.Black;
        }

        private void button_non_MouseEnter(object sender, EventArgs e)
        {
            if (liste_event[num_event].getReponse(1).getEglise() < 0)
            {
                txt_eglise.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(1).getEglise() > 0)
            {
                txt_eglise.ForeColor = Color.Green;
            }

            if (liste_event[num_event].getReponse(1).getPopulation() < 0)
            {
                txt_pop.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(1).getPopulation() > 0)
            {
                txt_pop.ForeColor = Color.Green;
            }

            if (liste_event[num_event].getReponse(1).getArmee() < 0)
            {
                txt_armee.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(1).getArmee() > 0)
            {
                txt_armee.ForeColor = Color.Green;
            }

            if (liste_event[num_event].getReponse(1).getArgent() < 0)
            {
                txt_argent.ForeColor = Color.Red;
            }
            else if (liste_event[num_event].getReponse(1).getArgent() > 0)
            {
                txt_argent.ForeColor = Color.Green;
            }
        }

        private void button_non_MouseLeave(object sender, EventArgs e)
        {
            txt_eglise.ForeColor = Color.Black;
            txt_pop.ForeColor = Color.Black;
            txt_armee.ForeColor = Color.Black;
            txt_argent.ForeColor = Color.Black;
        }

        private void button_oui_Click(object sender, EventArgs e)
        {
            evenements_oui();
            set_stats();
            if (eglise >= 100 || eglise <= 0 || population >= 100 || population <= 0 || armee >= 100 || armee <= 0 || argent >= 100 || argent <= 0)
            {
                End(eglise, population, armee, argent);
                death();
            }
            else
            {
                evenements();
            }

        }

        private void button_non_Click(object sender, EventArgs e)
        {
            evenements_non();
            set_stats();
            if (eglise >= 100 || eglise <= 0 || population >= 100 || population <= 0 || armee >= 100 || armee <= 0 || argent >= 100 || argent <= 0)
            {
                End(eglise, population, armee, argent);
                death();
            }
            else
            {
                evenements();
            }

        }


        private void txt_eglise_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_argent_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_narration_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_jouer_Click(object sender, EventArgs e)
        {
            clear_btn();
            label_annee.Visible = true;
            txt_entree_nom.Visible = true;
            button_valid_nom.Visible = true;
            txt_annee.Visible = true;
            txt_annee.Text = "0";
            Txt_narration.Text = "Choisissez votre nom \n \n \n \n \n * Un nom déja existant résutera en sa modification en cas de meileur score et la non création d'un nouvel utilisateur";
        }

        private void button_valid_nom_Click(object sender, EventArgs e)
        {

            if (txt_entree_nom.Text == null || String.Concat(txt_entree_nom.Text.Where(c => !Char.IsWhiteSpace(c))) == "")
            {
                MessageBox.Show("Veuillez entrer un nom valide");
            }
            else
            {
                nom = txt_entree_nom.Text;
                dbConnection.Open();
                string insert = "INSERT IGNORE INTO joueurs(NOM,MEILLEUR_SCORE) values ('" + nom + "', 0 ) ;";
                MySqlCommand unInsert = new MySqlCommand(insert, dbConnection);
                unInsert.ExecuteNonQuery();
                dbConnection.Close();
                clear_btn();
                button_start.Visible = true;
                Txt_narration.Text = "Vous venez d'être couronné Roi de France jeune " + nom + ". Une longue vie vous attend.\nVos sujets vont dès à présent rentrer chacun leur tour pour vous demander audience.\nIl vous revient la décision d'accepter ou de refuser leur proposition.\nMais faites attention à bien gérer vos 4 pouvoirs.ils ne doivent pas atteindre ou dépasser 0 et 100.";
            }

        }

        private void dgv_leaderboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button_leaderboard_Click(object sender, EventArgs e)
        {
            clear();
            dgv_leaderboard.Visible = true;
            button_retour.Visible = true;
            dbConnection.Open();
            string select = "SELECT * FROM joueurs ORDER BY MEILLEUR_SCORE DESC;";
            MySqlCommand score = new MySqlCommand(select, dbConnection);
            MySqlDataReader MyReader;
            MyReader = score.ExecuteReader();
            Console.WriteLine("\n");
            int i = 0;
            while (MyReader.Read())
            {
                dgv_leaderboard.Rows.Add(i+1, MyReader["NOM"], MyReader["MEILLEUR_SCORE"]);
                i++;
            }
            dbConnection.Close();
            dgv_leaderboard.Rows[0].DefaultCellStyle.BackColor = Color.Gold;
            dgv_leaderboard.Rows[1].DefaultCellStyle.BackColor = Color.Silver;
            dgv_leaderboard.Rows[2].DefaultCellStyle.BackColor = Color.FromArgb(205, 127, 50);
        }

        private void clear_btn()
        {
            button_oui.Visible = false;
            button_non.Visible = false;
            button_valid_nom.Visible = false;
            button_jouer.Visible = false;
            button_quitter.Visible = false;
            button_leaderboard.Visible = false;
            button_retour.Visible = false;
            button_rejouer.Visible = false;
            button_menu.Visible = false;
            button_start.Visible = false;
        }

        private void clear()
        {
            clear_btn();
            Txt_narration.Visible = false;
            Logo.Visible = false;
            label_annee.Visible = false;
            txt_annee.Visible = false;
            label_eglise.Visible = false;
            txt_eglise.Visible = false;
            label_pop.Visible = false;
            txt_pop.Visible = false;
            label_armee.Visible = false;
            txt_armee.Visible = false;
            label_argent.Visible = false;
            txt_argent.Visible = false;
            txt_entree_nom.Visible = false;
            dgv_leaderboard.Visible = false;
        }

        private void button_retour_Click(object sender, EventArgs e)
        {
            menu_principal();
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void set_stats()
        {
            txt_eglise.Text = eglise.ToString();
            txt_pop.Text = population.ToString();
            txt_armee.Text = armee.ToString();
            txt_argent.Text = argent.ToString();
        }

        private void evenements()
        {
            anneepouvoir++;
            num_event = nb.Next(0, liste_event.Count());
            txt_annee.Text = anneepouvoir.ToString();
            evenement_actuel = liste_event[num_event];
            if (num_event == 0)
            {
                Txt_narration.Text = evenement_actuel.getEnonce() + "Appuyez sur Oui ou Non pour continuer";
            }
            else
            {
                Txt_narration.Text = evenement_actuel.getEnonce();
            }

        }

        private void evenements_oui()
        {
            eglise = eglise + evenement_actuel.getReponse(0).getEglise();
            population = population + evenement_actuel.getReponse(0).getPopulation();
            armee = armee + evenement_actuel.getReponse(0).getArmee();
            argent = argent + evenement_actuel.getReponse(0).getArgent();
        }

        private void evenements_non()
        {
            eglise = eglise + evenement_actuel.getReponse(1).getEglise();
            population = population + evenement_actuel.getReponse(1).getPopulation();
            armee = armee + evenement_actuel.getReponse(1).getArmee();
            argent = argent + evenement_actuel.getReponse(1).getArgent();
        }

        private void End(int num_eglise, int num_pop, int num_armee, int num_argent)
        {
            if (armee <= 0 || armee >= 100)
            {
                if (armee <= 0)
                {
                    Txt_narration.Text = "Votre armée est trop faible pour faire quoi que ce soit. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
                else if (armee >= 100)
                {
                    Txt_narration.Text = "Votre armée est devenue trop puissante. Elle organise un coup d'État et vous retire du trône. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
            }

            if (argent <= 0 || argent >= 100)
            {
                if (argent <= 0)
                {
                    Txt_narration.Text = "Votre pays est ruiné. Vous n'avez plus d'argent pour faire respecter votre autorité. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
                else if (argent >= 100)
                {
                    Txt_narration.Text = "Vous êtes tellement riche ! Vous organisez des banquets à longueur de journée sans compter l'argent que vous depensez et sans vous soucier de vos sujets. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
            }

            if (population <= 0 || population >= 100)
            {
                if (population <= 0)
                {
                    Txt_narration.Text = "Vous n'avez plus personne à gouverner. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
                else if (argent >= 100)
                {
                    Txt_narration.Text = "Votre peuple et en surnombre. Ils organisent une Révolution et vous font guillotiner. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
            }

            if (eglise <= 0 || eglise >= 100)
            {
                if (eglise <= 0)
                {
                    Txt_narration.Text = "Dieu a abandonné votre Royaume. Plus personne ne croit en votre souveraineté. Ils vous abandonnent tous petit à petit. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
                else if (eglise >= 100)
                {
                    Txt_narration.Text = "L'Église à pris une trop grande importance dans votre Royaume. Elle vous déstitue de votre trône et prend la tête du Royaume. Votre Royaume tombe après " + anneepouvoir + " années.";
                }
            }
        }

        private void button_rejouer_Click(object sender, EventArgs e)
        {
            replay();

        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            menu_principal();
        }

        private void menu_principal()
        {
            clear();
            Logo.Visible = true;
            Txt_narration.Visible = true;
            label_eglise.Visible = true;
            txt_eglise.Visible = true;
            label_pop.Visible = true;
            txt_pop.Visible = true;
            label_armee.Visible = true;
            txt_armee.Visible = true;
            label_argent.Visible = true;
            txt_argent.Visible = true;
            button_jouer.Visible = true;
            button_leaderboard.Visible = true;
            button_quitter.Visible = true;
            Logo.Image = Properties.Resources.reigns;
            Txt_narration.Clear();
            anneepouvoir = 0;
            eglise = 50;
            population = 50;
            armee = 50;
            argent = 50;
            set_stats();
        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void death()
        {
            Logo.Image = Properties.Resources.reigns_death;
            clear_btn();
            button_rejouer.Visible = true;
            button_menu.Visible = true;
            insertion();
        }

        private void replay()
        {
            clear_btn();
            Logo.Image = Properties.Resources.reigns;
            eglise = 50;
            population = 50;
            armee = 50;
            argent = 50;
            anneepouvoir = 0;
            set_stats();
            txt_annee.Text = anneepouvoir.ToString();
            button_start.Visible = true;
            Txt_narration.Text = "Vous venez d'être couronné Roi de France jeune " + nom + ". Une longue vie vous attend.\nVos sujets vont dès à présent rentrer chacun leur tour pour vous demander audience.\nIl vous revient la décision d'accepter ou de refuser leur proposition.\nMais faites attention à bien gérer vos 4 pouvoirs.ils ne doivent pas atteindre ou dépasser 0 et 100.";
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            button_oui.Visible = true;
            button_non.Visible = true;
            txt_entree_nom.Clear();
            txt_entree_nom.Visible = false;
            button_start.Visible = false;
            evenements();

        }

        private void insertion()
        {
            dbConnection.Open();
            string score = "SELECT MEILLEUR_SCORE FROM Joueurs WHERE NOM = '" + nom + "';";
            MySqlCommand cmdScore = new MySqlCommand(score, dbConnection);
            int dbScore = int.Parse(cmdScore.ExecuteScalar().ToString());
            if (anneepouvoir > dbScore)
            {
                string insert = "UPDATE joueurs SET MEILLEUR_SCORE = '" + anneepouvoir + "' WHERE NOM = '" + nom + "';";
                MySqlCommand unInsert = new MySqlCommand(insert, dbConnection);
                unInsert.ExecuteNonQuery();
                Txt_narration.Text = Txt_narration.Text + "\n Bravo roi " + nom + " ! Vous avez battu votre précédent record de " + dbScore + " avec " + anneepouvoir + " années de règne !";
            }
            else
            {
                Txt_narration.Text = Txt_narration.Text + "\n Vous avez atteint " + anneepouvoir + " années de pouvoir ! Votre record est de " + dbScore + ", ne vous découragez pas roi " + nom + " !";
            }
            dbConnection.Close();
        }
    }
}
