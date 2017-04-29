using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hiragana_Memory_Game
{
    public partial class HiraganaGame : Form
    {
        //The following was written by Patrick Condon:
        int total = 0;
        //End written by Patrick Condon.


        //The following was written by Irene Wang:
        #region -- Defining the Constant Numbers for the Hiragana Characters (Written by Irene Wang) --
        private const int _no_ = 0;
        private const int _a_ = 1;
        private const int _ki_ = 2;
        private const int _su_ = 3;
        private const int _te_ = 4;
        private const int _ka_ = 5;
        private const int _shi_ = 6;
        private const int _tsu_ = 7;
        private const int _ne_ = 8;
        private const int _ho_ = 9;
        private const int _sa_ = 10;
        private const int _chi_ = 11;
        private const int _nu_ = 12;
        private const int _he_ = 13;
        private const int _mo_ = 14;
        private const int _ta_ = 15;
        private const int _ni_ = 16;
        private const int _hu_ = 17;
        private const int _me_ = 18;
        private const int _yo_ = 19;
        private const int _ke_ = 20;
        private const int _so_ = 21;
        private const int _u_ = 22;
        private const int _yu_ = 23;
        private const int _wa_ = 24;
        private const int _mu_ = 25;
        private const int _ha_ = 26;
        private const int _ya_ = 27;
        private const int _ri_ = 28;
        private const int _wo_ = 29;
        private const int _ma_ = 30;
        private const int _ra_ = 31;
        private const int _ru_ = 32;
        private const int _se_ = 33;
        private const int _o_ = 34;
        private const int _e_ = 35;
        private const int _ku_ = 36;
        private const int _i_ = 37;
        private const int _re_ = 38;
        private const int _mi_ = 39;
        private const int _ro_ = 40;
        private const int _ko_ = 41;
        private const int _to_ = 42;
        private const int _hi_ = 43;
        private const int _na_ = 44;
        private const int _n_ = 45;
        #endregion -- Defining the Constant Numbers for the Hiragana Characters (Written by Irene Wang) --
        //End written by Irene Wang

        public HiraganaGame()
        {
            InitializeComponent();

            //The following was written by Irene Wang:
            #region -- Tab Label for each Hiragana (Written by Irene Wang)--
            tabPage1.Text = JPCharacterMap.tabLabels[0];
            tabPage2.Text = JPCharacterMap.tabLabels[1];
            tabPage3.Text = JPCharacterMap.tabLabels[2];
            tabPage4.Text = JPCharacterMap.tabLabels[3];
            tabPage5.Text = JPCharacterMap.tabLabels[4];
            tabPage6.Text = JPCharacterMap.tabLabels[5];
            tabPage7.Text = JPCharacterMap.tabLabels[6];
            tabPage8.Text = JPCharacterMap.tabLabels[7];
            tabPage9.Text = JPCharacterMap.tabLabels[8];
            tabPage10.Text = JPCharacterMap.tabLabels[9];
            tabPage11.Text = JPCharacterMap.tabLabels[10];
            tabPage12.Text = JPCharacterMap.tabLabels[11];
            tabPage13.Text = JPCharacterMap.tabLabels[12];
            tabPage14.Text = JPCharacterMap.tabLabels[13];
            tabPage15.Text = JPCharacterMap.tabLabels[14];
            tabPage16.Text = JPCharacterMap.tabLabels[15];
            tabPage17.Text = JPCharacterMap.tabLabels[16];
            tabPage18.Text = JPCharacterMap.tabLabels[17];
            tabPage19.Text = JPCharacterMap.tabLabels[18];
            tabPage20.Text = JPCharacterMap.tabLabels[19];
            tabPage21.Text = JPCharacterMap.tabLabels[20];
            tabPage22.Text = JPCharacterMap.tabLabels[21];
            tabPage23.Text = JPCharacterMap.tabLabels[22];
            tabPage24.Text = JPCharacterMap.tabLabels[23];
            tabPage25.Text = JPCharacterMap.tabLabels[24];
            tabPage26.Text = JPCharacterMap.tabLabels[25];
            tabPage27.Text = JPCharacterMap.tabLabels[26];
            tabPage28.Text = JPCharacterMap.tabLabels[26];
            tabPage29.Text = JPCharacterMap.tabLabels[28];
            tabPage30.Text = JPCharacterMap.tabLabels[29];
            tabPage31.Text = JPCharacterMap.tabLabels[30];
            tabPage32.Text = JPCharacterMap.tabLabels[31];
            tabPage33.Text = JPCharacterMap.tabLabels[32];
            tabPage34.Text = JPCharacterMap.tabLabels[33];
            tabPage35.Text = JPCharacterMap.tabLabels[34];
            tabPage36.Text = JPCharacterMap.tabLabels[35];
            tabPage37.Text = JPCharacterMap.tabLabels[36];
            tabPage38.Text = JPCharacterMap.tabLabels[37];
            tabPage39.Text = JPCharacterMap.tabLabels[38];
            tabPage40.Text = JPCharacterMap.tabLabels[39];
            tabPage41.Text = JPCharacterMap.tabLabels[40];
            tabPage42.Text = JPCharacterMap.tabLabels[41];
            tabPage43.Text = JPCharacterMap.tabLabels[42];
            tabPage44.Text = JPCharacterMap.tabLabels[43];
            tabPage45.Text = JPCharacterMap.tabLabels[44];
            tabPage46.Text = JPCharacterMap.tabLabels[45];
            #endregion -- Tab Label for each Hiragana (Written by Irene Wang) --

            //Starting with the first tab.
            tabControl1.SelectTab(0);
            //End written by Irene Wang.
        }

        /// <summary>
        /// Method to validate the user's input; checking the answer is valid/invalid.
        /// Written by Irene Wang.
        /// </summary>
        /// <param name="guiElement"></param>
        /// <param name="userInput"></param>
        /// <param name="answerIndex"></param>
        #region -- private Method ---
        private void VerifyingAnswer(object guiElement, string userInput, int answerIndex)
        {
            //Instantiating the class/object.
            JPCharacterMap jpCharMap = new JPCharacterMap();

            //Object/method call
            if (jpCharMap.AnswerValidation(userInput, answerIndex))
            {
                Scoreboard.Text = Convert.ToString(++total);
                Label_ResultMessage.Text = JPCharacterMap.tabLabels[answerIndex] + " - Correct! The correct answer is \"" + JPCharacterMap.answerKeys[answerIndex] + "\"";
                Label_ResultMessage.ForeColor = Color.ForestGreen;
            }
            else
            {
                Label_ResultMessage.Text = JPCharacterMap.tabLabels[answerIndex] + " - Incorrect! The correct answer is \"" + JPCharacterMap.answerKeys[answerIndex] + "\"";
                Label_ResultMessage.ForeColor = Color.Red;
            }

            //Disabling the checkbox.
            ((Button)guiElement).Enabled = false;

            //Check the tab count. If it reaches the maximum tab count of 46, resets to 0.
            if (tabControl1.TabCount != tabControl1.SelectedIndex + 1)
            {
                //Transitioning to the next tab.
                tabControl1.SelectedIndex += 1;
            }
            //Otherwise displays the Finish Game message and final score, refreshing the game.
            else
            {
                string message = String.Format("Your score is {0}/46 = {1}%", total, ((total / 46.00) * 100).ToString("F"));
                MessageBox.Show("You've finished the Hiragana Memory Game! " + message);

                //Assigning the following (tabControl1.SelectedIndex = 0) to the Start Over Button click event.
                startOverButton_Click(guiElement, new EventArgs());
            }
        }
        #endregion -- private Method ---

        #region -- Check Button Event --
        /// <summary>
        /// Button event for "Check" button, corresponding to the "no" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void noCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = noTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _no_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (noTextBox.Text.ToLower() == "no")
            //{
            //    tabControl1.SelectedTab = tabPage2;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    noTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage2;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "a" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = aTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _a_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (aTextBox.Text == "a")
            //{
            //    tabControl1.SelectedTab = tabPage3;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    aTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage3;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ki" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kiCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = kiTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ki_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (kiTextBox.Text.ToLower() == "ki")
            //{
            //    tabControl1.SelectedTab = tabPage4;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    kiTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage4;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "su" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void suCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = suTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _su_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (suTextBox.Text == "su")
            //{
            //    tabControl1.SelectedTab = tabPage5;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    suTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage5;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "te" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void teCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = teTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _te_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "te")
            //{
            //    tabControl1.SelectedTab = tabPage6;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage6;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ka" character
        /// Written by Irene Wang.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kaCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = kaTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ka_);
            //End written by Irene Wang.
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "shi" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shiCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = shiTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _shi_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "shi")
            //{
            //    tabControl1.SelectedTab = tabPage7;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage7;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "tsu" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsuCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = tsuTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _tsu_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "tsu")
            //{
            //    tabControl1.SelectedTab = tabPage8;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage8;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ne" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void neCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = neTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ne_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ne")
            //{
            //    tabControl1.SelectedTab = tabPage9;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage9;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ho" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hoCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = hoTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ho_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ho")
            //{
            //    tabControl1.SelectedTab = tabPage10;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage10;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "sa" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = saTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _sa_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "sa")
            //{
            //    tabControl1.SelectedTab = tabPage11;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage11;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "chi" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chiCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = chiTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _chi_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "chi")
            //{
            //    tabControl1.SelectedTab = tabPage12;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage12;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "nu" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = nuTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _nu_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "nu")
            //{
            //    tabControl1.SelectedTab = tabPage13;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage13;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "he" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void heCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = heTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _he_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "he")
            //{
            //    tabControl1.SelectedTab = tabPage14;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage14;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "mo" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void moCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = moTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _mo_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "mo")
            //{
            //    tabControl1.SelectedTab = tabPage15;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage15;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ta" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void taCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = taTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ta_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ta")
            //{
            //    tabControl1.SelectedTab = tabPage16;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage16;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ni" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void niCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = niTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ni_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ni")
            //{
            //    tabControl1.SelectedTab = tabPage17;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage17;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "hu" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void huCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = huTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _hu_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "hu")
            //{
            //    tabControl1.SelectedTab = tabPage18;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage18;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "me" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void meCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = meTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _me_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "me")
            //{
            //    tabControl1.SelectedTab = tabPage19;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage19;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "yo" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yoCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = yoTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _yo_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "yo")
            //{
            //    tabControl1.SelectedTab = tabPage20;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage20;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ke" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = keTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ke_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ke")
            //{
            //    tabControl1.SelectedTab = tabPage21;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage21;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "so" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void soCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = soTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _so_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "so")
            //{
            //    tabControl1.SelectedTab = tabPage22;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage22;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "u" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = uTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _u_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "u")
            //{
            //    tabControl1.SelectedTab = tabPage23;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage23;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "yu" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yuCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = yuTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _yu_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "yu")
            //{
            //    tabControl1.SelectedTab = tabPage24;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage24;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "wa" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void waCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = waTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _wa_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "wa")
            //{
            //    tabControl1.SelectedTab = tabPage25;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage25;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "mu" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void muCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = muTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _mu_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "mu")
            //{
            //    tabControl1.SelectedTab = tabPage26;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage26;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ha" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void haCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = haTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ha_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ha")
            //{
            //    tabControl1.SelectedTab = tabPage27;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage27;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ya" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void yaCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = yaTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ya_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ya")
            //{
            //    tabControl1.SelectedTab = tabPage28;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage28;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ri" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void riCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = riTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ri_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ri")
            //{
            //    tabControl1.SelectedTab = tabPage29;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage29;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "wo character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void woCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = woTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _wo_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "wo")
            //{
            //    tabControl1.SelectedTab = tabPage30;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}

            //else
            //{
            //    tabControl1.SelectedTab = tabPage30;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ma" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = maTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ma_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ma")
            //{
            //    tabControl1.SelectedTab = tabPage31;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage31;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ra" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void raCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = raTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ra_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ra")
            //{
            //    tabControl1.SelectedTab = tabPage32;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage32;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ru" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ruCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = ruTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ru_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ru")
            //{
            //    tabControl1.SelectedTab = tabPage33;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage33;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "se" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = seTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _se_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "se")
            //{
            //    tabControl1.SelectedTab = tabPage34;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage34;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "o" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void oCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = oTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _o_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "o")
            //{
            //    tabControl1.SelectedTab = tabPage35;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage35;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "e" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = eTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _e_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "e")
            //{
            //    tabControl1.SelectedTab = tabPage36;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage36;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ku" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kuCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = kuTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ku_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ku")
            //{
            //    tabControl1.SelectedTab = tabPage37;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage37;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "i" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = iTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _i_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "i")
            //{
            //    tabControl1.SelectedTab = tabPage38;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage38;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "re" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = reTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _re_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "re")
            //{
            //    tabControl1.SelectedTab = tabPage39;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage39;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "mi" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = miTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _mi_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "mi")
            //{
            //    tabControl1.SelectedTab = tabPage40;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage40;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ro" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void roCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = roTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ro_);
            //End written by Irene Wang.

            /* The following was written by Patrick Condon:
            //if (teTextBox.Text == "ro")
            //{
            //    tabControl1.SelectedTab = tabPage41;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage41;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "ko" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void koCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = koTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _ko_);
            //End written by Irene Wang.

            /*The following was written by Patrick Condon:
            //if (teTextBox.Text == "ko")
            //{
            //    tabControl1.SelectedTab = tabPage42;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage42;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "to" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = toTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _to_);
            //End written by Irene Wang.

            /*The following was written by Patrick Condon:
            //if (teTextBox.Text == "to")
            //{
            //    tabControl1.SelectedTab = tabPage43;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage43;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "hi" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hiCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = hiTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _hi_);
            //End written by Irene Wang.

            /*The following was written by Patrick Condon:
            //if (teTextBox.Text == "hi")
            //{
            //    tabControl1.SelectedTab = tabPage44;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage44;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "na" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void naCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = naTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _na_);
            //End written by Irene Wang.

            /*The following was written by Patrick Condon:
            //if (teTextBox.Text == "na")
            //{
            //    tabControl1.SelectedTab = tabPage45;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage45;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }

        /// <summary>
        /// Button event for "Check" button, corresponding to the "n" character
        /// Written by Irene Wang (commented-out parts written by Patrick Condon).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nCheckButton_Click(object sender, EventArgs e)
        {
            //The following was written by Irene Wang:
            var userInput = nTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(userInput))
                return;

            VerifyingAnswer(sender, userInput, _n_);
            //End written by Irene Wang.

            /*The following was written by Patrick Condon:
            //if (teTextBox.Text == "n")
            //{
            //    tabControl1.SelectedTab = tabPage46;
            //    total = total + 1;
            //    Scoreboard.Text = Convert.ToString(total);
            //    MessageBox.Show("Good Job!");
            //    teTextBox.Enabled = false;
            //    return;
            //}
            //else
            //{
            //    tabControl1.SelectedTab = tabPage46;
            //    MessageBox.Show("Sorry that is incorrect.");
            //    return;
            //}
            */
        }
        #endregion -- Check Button Event --

        #region -- Hint Button Event (written by Patrick Condon) --
        private void noHintButton_Click(object sender, EventArgs e)
        {
            noPictureBox.Visible = true;
        }

        private void aHintButton_Click(object sender, EventArgs e)
        {
            aPictureBox.Visible = true;
        }

        private void kiHintButton_Click(object sender, EventArgs e)
        {
            kiPictureBox.Visible = true;
        }

        private void suHintButton_Click(object sender, EventArgs e)
        {
            suPictureBox.Visible = true;
        }

        private void teHintButton_Click(object sender, EventArgs e)
        {
            tePictureBox.Visible = true;
        }

        private void kaHintButton_Click(object sender, EventArgs e)
        {
            kaPictureBox.Visible = true;
        }

        private void shiHintButton_Click(object sender, EventArgs e)
        {
            shiPictureBox.Visible = true;
        }

        private void tsuHintButton_Click(object sender, EventArgs e)
        {
            tsuPictureBox.Visible = true;
        }

        private void neHintButton_Click(object sender, EventArgs e)
        {
            nePictureBox.Visible = true;
        }

        private void hoHintButton_Click(object sender, EventArgs e)
        {
            hoPictureBox.Visible = true;
        }

        private void saHintButton_Click(object sender, EventArgs e)
        {
            saPictureBox.Visible = true;
        }

        private void chiHintButton_Click(object sender, EventArgs e)
        {
            chiPictureBox.Visible = true;
        }

        private void nuHintButton_Click(object sender, EventArgs e)
        {
            nuPictureBox.Visible = true;
        }

        private void heHintButton_Click(object sender, EventArgs e)
        {
            hePictureBox.Visible = true;
        }

        private void moHintButton_Click(object sender, EventArgs e)
        {
            moPictureBox.Visible = true;
        }

        private void taHintButton_Click(object sender, EventArgs e)
        {
            taPictureBox.Visible = true;
        }

        private void niHintButton_Click(object sender, EventArgs e)
        {
            niPictureBox.Visible = true;
        }

        private void huHintButton_Click(object sender, EventArgs e)
        {
            huPictureBox.Visible = true;
        }

        private void meHintButton_Click(object sender, EventArgs e)
        {
            mePictureBox.Visible = true;
        }

        private void yoHintButton_Click(object sender, EventArgs e)
        {
            yoPictureBox.Visible = true;
        }

        private void keHintButton_Click(object sender, EventArgs e)
        {
            kePictureBox.Visible = true;
        }

        private void soHintButton_Click(object sender, EventArgs e)
        {
            soPictureBox.Visible = true;
        }

        private void uHintButton_Click(object sender, EventArgs e)
        {
            uPictureBox.Visible = true;
        }

        private void yuHintButton_Click(object sender, EventArgs e)
        {
            yuPictureBox.Visible = true;
        }

        private void waHintButton_Click(object sender, EventArgs e)
        {
            waPictureBox.Visible = true;
        }

        private void muHintButton_Click(object sender, EventArgs e)
        {
            muPictureBox.Visible = true;
        }

        private void haHintButton_Click(object sender, EventArgs e)
        {
            haPictureBox.Visible = true;
        }

        private void yaHintButton_Click(object sender, EventArgs e)
        {
            yaPictureBox.Visible = true;
        }

        private void riHintButton_Click(object sender, EventArgs e)
        {
            riPictureBox.Visible = true;
        }

        private void woHintButton_Click(object sender, EventArgs e)
        {
            woPictureBox.Visible = true;
        }

        private void maHintButton_Click(object sender, EventArgs e)
        {
            maPictureBox.Visible = true;
        }

        private void raHintButton_Click(object sender, EventArgs e)
        {
            raPictureBox.Visible = true;
        }

        private void ruHintButton_Click(object sender, EventArgs e)
        {
            ruPictureBox.Visible = true;
        }

        private void seHintButton_Click(object sender, EventArgs e)
        {
            sePictureBox.Visible = true;
        }

        private void oHintButton_Click(object sender, EventArgs e)
        {
            oPictureBox.Visible = true;
        }

        private void eHintButton_Click(object sender, EventArgs e)
        {
            ePictureBox.Visible = true;
        }

        private void kuHintButton_Click(object sender, EventArgs e)
        {
            kuPictureBox.Visible = true;
        }

        private void iHintButton_Click(object sender, EventArgs e)
        {
            iPictureBox.Visible = true;
        }

        private void reHintButton_Click(object sender, EventArgs e)
        {
            rePictureBox.Visible = true;
        }

        private void miHintButton_Click(object sender, EventArgs e)
        {
            miPictureBox.Visible = true;
        }

        private void roHintButton_Click(object sender, EventArgs e)
        {
            roPictureBox.Visible = true;
        }

        private void koHintButton_Click(object sender, EventArgs e)
        {
            koPictureBox.Visible = true;
        }

        private void toHintButton_Click(object sender, EventArgs e)
        {
            toPictureBox.Visible = true;
        }

        private void hiHintButton_Click(object sender, EventArgs e)
        {
            hiPictureBox.Visible = true;
        }

        private void naHintButton_Click(object sender, EventArgs e)
        {
            naPictureBox.Visible = true;
        }

        private void nHintButton_Click(object sender, EventArgs e)
        {
            nPictureBox.Visible = true;
        }

        #endregion -- Hint Button Event (written by Patrick Condon) --

        /// <summary>
        /// Initial load of the game with the welcome message and instructions.
        /// Written by Irene Wang.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HiraganaGame_Load(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Welcome, {0}! Enjoy this Hiragana Memory Game.", Environment.UserName));
            RichTextBox_HowToPlay.Text = "Instructions:" + Environment.NewLine
                + "Enter the hiragana pronunciation in the textbox above." + Environment.NewLine
                + "Each correct answer yields 1 point. The maximum score is 46." + Environment.NewLine
                + "Click hint for an image corresponding to the first syllable pronunciation.";
        }

        /// <summary>
        /// Refreshes the game with the Start Over button.
        /// Written by Irene Wang.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startOverButton_Click(object sender, EventArgs e)
        {
            noTextBox.Clear();
            noCheckButton.Enabled = true;
            noPictureBox.Visible = false;

            aTextBox.Clear();
            aCheckButton.Enabled = true;
            aPictureBox.Visible = false;

            kiTextBox.Clear();
            kiCheckButton.Enabled = true;
            kiPictureBox.Visible = false;

            suTextBox.Clear();
            suCheckBox.Enabled = true;
            suPictureBox.Visible = false;

            teTextBox.Clear();
            teCheckButton.Enabled = true;
            tePictureBox.Visible = false;

            kaTextBox.Clear();
            kaCheckButton.Enabled = true;
            kaPictureBox.Visible = false;

            shiTextBox.Clear();
            shiCheckButton.Enabled = true;
            shiPictureBox.Visible = false;

            tsuTextBox.Clear();
            tsuTextBox.Enabled = true;
            tsuPictureBox.Visible = false;

            neTextBox.Clear();
            neCheckButton.Enabled = true;
            nePictureBox.Visible = false;

            hoTextBox.Clear();
            hoCheckButton.Enabled = true;
            hoPictureBox.Visible = false;

            saTextBox.Clear();
            saCheckButton.Enabled = true;
            saPictureBox.Visible = false;

            chiTextBox.Clear();
            chiCheckButton.Enabled = true;
            chiPictureBox.Visible = false;

            nuTextBox.Clear();
            nuCheckButton.Enabled = true;
            nuPictureBox.Visible = false;

            heTextBox.Clear();
            heCheckButton.Enabled = true;
            hePictureBox.Visible = false;

            moTextBox.Clear();
            moCheckButton.Enabled = true;
            moPictureBox.Visible = false;

            taTextBox.Clear();
            taCheckButton.Enabled = true;
            taPictureBox.Visible = false;

            niTextBox.Clear();
            niCheckButton.Enabled = true;
            niPictureBox.Visible = false;

            huTextBox.Clear();
            huCheckButton.Enabled = true;
            huPictureBox.Visible = false;

            meTextBox.Clear();
            meCheckButton.Enabled = true;
            mePictureBox.Visible = false;

            yoTextBox.Clear();
            yoCheckButton.Enabled = true;
            yoPictureBox.Visible = false;

            keTextBox.Clear();
            keCheckButton.Enabled = true;
            kePictureBox.Visible = false;

            soTextBox.Clear();
            soCheckButton.Enabled = true;
            soPictureBox.Visible = false;

            uTextBox.Clear();
            uCheckButton.Enabled = true;
            uPictureBox.Visible = false;

            yuTextBox.Clear();
            yuCheckButton.Enabled = true;
            yuPictureBox.Visible = false;

            waTextBox.Clear();
            waCheckButton.Enabled = true;
            waPictureBox.Visible = false;

            muTextBox.Clear();
            muCheckButton.Enabled = true;
            muPictureBox.Visible = false;

            haTextBox.Clear();
            haCheckButton.Enabled = true;
            haPictureBox.Visible = false;

            yaTextBox.Clear();
            yaCheckButton.Enabled = true;
            yaPictureBox.Visible = false;

            riTextBox.Clear();
            riCheckButton.Enabled = true;
            riPictureBox.Visible = false;

            woTextBox.Clear();
            woCheckButton.Enabled = true;
            woPictureBox.Visible = false;

            maTextBox.Clear();
            maCheckButton.Enabled = true;
            maPictureBox.Visible = false;

            raTextBox.Clear();
            raCheckButton.Enabled = true;
            raPictureBox.Visible = false;

            ruTextBox.Clear();
            ruCheckButton.Enabled = true;
            ruPictureBox.Visible = false;

            seTextBox.Clear();
            seCheckButton.Enabled = true;
            sePictureBox.Visible = false;

            oTextBox.Clear();
            oCheckButton.Enabled = true;
            oPictureBox.Visible = false;

            eTextBox.Clear();
            eCheckButton.Enabled = true;
            ePictureBox.Visible = false;

            kuTextBox.Clear();
            kuCheckButton.Enabled = true;
            kuPictureBox.Visible = false;

            iTextBox.Clear();
            iCheckButton.Enabled = true;
            iPictureBox.Visible = false;

            reTextBox.Clear();
            reCheckButton.Enabled = true;
            rePictureBox.Visible = false;

            miTextBox.Clear();
            miCheckButton.Enabled = true;
            miPictureBox.Visible = false;

            roTextBox.Clear();
            roCheckButton.Enabled = true;
            roPictureBox.Visible = false;

            koTextBox.Clear();
            koCheckButton.Enabled = true;
            koPictureBox.Visible = false;

            toTextBox.Clear();
            toCheckButton.Enabled = true;
            toPictureBox.Visible = false;

            hiTextBox.Clear();
            hiCheckButton.Enabled = true;
            hiPictureBox.Visible = false;

            naTextBox.Clear();
            naCheckButton.Enabled = true;
            naPictureBox.Visible = false;

            nTextBox.Clear();
            nCheckButton.Enabled = true;
            nPictureBox.Visible = false;
            total = 0;
            Scoreboard.Text = "0";
            Label_ResultMessage.Text = "Game refreshed. Good luck!";
            Label_ResultMessage.ForeColor = Color.RoyalBlue;

            tabControl1.SelectTab(0);
        }

        private void noTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void aTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
