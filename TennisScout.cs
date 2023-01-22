/*Tennis Scout - This program allow the user to compute statistics of a tennis match.
 * The program shows the user all the number of the match including
 * time. 
 * Create by Fabio Santos on 11/06/2011.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace TennisScoutProject
{
    public partial class TennisScout : Form
    {
        //declare the variables.
        //Aces
        int aceSet1Player1 = 0;
        int aceSet2Player1 = 0;
        int aceSet3Player1 = 0;
        int aceSet1Player2 = 0;
        int aceSet2Player2 = 0;
        int aceSet3Player2 = 0;
        //Faults
        int faultSet1Player1 = 0;
        int faultSet2Player1 = 0;
        int faultSet3Player1 = 0;
        int faultSet1Player2 = 0;
        int faultSet2Player2 = 0;
        int faultSet3Player2 = 0;
        //Double faults
        int doubleFaultSet1Player1 = 0;
        int doubleFaultSet2Player1 = 0;
        int doubleFaultSet3Player1 = 0;
        int doubleFaultSet1Player2 = 0;
        int doubleFaultSet2Player2 = 0;
        int doubleFaultSet3Player2 = 0;
        //Points won 1st and 2nd serves player 1
        int pointWon1ServeSet1Player1 = 0;
        int pointWon2ServeSet1Player1 = 0;
        int pointWon1ServeSet2Player1 = 0;
        int pointWon2ServeSet2Player1 = 0;
        int pointWon1ServeSet3Player1 = 0;
        int pointWon2ServeSet3Player1 = 0;
        //Points won 1st and 2nd serves player 2
        int pointWon1ServeSet1Player2 = 0;
        int pointWon2ServeSet1Player2 = 0;
        int pointWon1ServeSet2Player2 = 0;
        int pointWon2ServeSet2Player2 = 0;
        int pointWon1ServeSet3Player2 = 0;
        int pointWon2ServeSet3Player2 = 0;
        //Number of games served.
        int gamesServedSet1Player1 = 0;
        int gamesServedSet2Player1 = 0;
        int gamesServedSet3Player1 = 0;
        int gamesServedSet1Player2 = 0;
        int gamesServedSet2Player2 = 0;
        int gamesServedSet3Player2 = 0;
        //Winners
        int winnersSet1Player1 = 0;
        int winnersSet2Player1 = 0;
        int winnersSet3Player1 = 0;
        int winnersSet1Player2 = 0;
        int winnersSet2Player2 = 0;
        int winnersSet3Player2 = 0;
        //Forehand Winners
        int forehandWinnersSet1Player1 = 0;
        int forehandWinnersSet2Player1 = 0;
        int forehandWinnersSet3Player1 = 0;
        int forehandWinnersSet1Player2 = 0;
        int forehandWinnersSet2Player2 = 0;
        int forehandWinnersSet3Player2 = 0;
        //Backhand Winners
        int backhandWinnersSet1Player1 = 0;
        int backhandWinnersSet2Player1 = 0;
        int backhandWinnersSet3Player1 = 0;
        int backhandWinnersSet1Player2 = 0;
        int backhandWinnersSet2Player2 = 0;
        int backhandWinnersSet3Player2 = 0;
        //unforced errors
        int unforcedErrorsSet1Player1 = 0;
        int unforcedErrorsSet2Player1 = 0;
        int unforcedErrorsSet3Player1 = 0;
        int unforcedErrorsSet1Player2 = 0;
        int unforcedErrorsSet2Player2 = 0;
        int unforcedErrorsSet3Player2 = 0;
        //Forehand unforced errors
        int forehandUnforcedErrorsSet1Player1 = 0;
        int forehandUnforcedErrorsSet2Player1 = 0;
        int forehandUnforcedErrorsSet3Player1 = 0;
        int forehandUnforcedErrorsSet1Player2 = 0;
        int forehandUnforcedErrorsSet2Player2 = 0;
        int forehandUnforcedErrorsSet3Player2 = 0;
        //Backhand unforced errors.
        int backhandUnforcedErrorsSet1Player1 = 0;
        int backhandUnforcedErrorsSet2Player1 = 0;
        int backhandUnforcedErrorsSet3Player1 = 0;
        int backhandUnforcedErrorsSet1Player2 = 0;
        int backhandUnforcedErrorsSet2Player2 = 0;
        int backhandUnforcedErrorsSet3Player2 = 0;
        //Forced errors
        int forcedErrorsSet1Player1 = 0;
        int forcedErrorsSet2Player1 = 0;
        int forcedErrorsSet3Player1 = 0;
        int forcedErrorsSet1Player2 = 0;
        int forcedErrorsSet2Player2 = 0;
        int forcedErrorsSet3Player2 = 0;
        //Forehand forced errors
        int forehandForcedErrorsSet1Player1 = 0;
        int forehandForcedErrorsSet2Player1 = 0;
        int forehandForcedErrorsSet3Player1 = 0;
        int forehandForcedErrorsSet1Player2 = 0;
        int forehandForcedErrorsSet2Player2 = 0;
        int forehandForcedErrorsSet3Player2 = 0;
        //Backhand forced errors.
        int backhandForcedErrorsSet1Player1 = 0;
        int backhandForcedErrorsSet2Player1 = 0;
        int backhandForcedErrorsSet3Player1 = 0;
        int backhandForcedErrorsSet1Player2 = 0;
        int backhandForcedErrorsSet2Player2 = 0;
        int backhandForcedErrorsSet3Player2 = 0;
        //Approaches
        int approachSet1Player1 = 0;
        int approachSet2Player1 = 0;
        int approachSet3Player1 = 0;
        int approachSet1Player2 = 0;
        int approachSet2Player2 = 0;
        int approachSet3Player2 = 0;
        //Points
        int pointsPlayer1 = 0;
        int pointsPlayer2 = 0;
        //Games
        int set1GamesPlayer1 = 0;
        int set2GamesPlayer1 = 0;
        int set3GamesPlayer1 = 0;
        int set1GamesPlayer2 = 0;
        int set2GamesPlayer2 = 0;
        int set3GamesPlayer2 = 0;
        //Sum of serves per set
        int numberOfServesSet1Player1 = 0;
        int numberOfServesSet2Player1 = 0;
        int numberOfServesSet3Player1 = 0;
        int numberOfServesSet1Player2 = 0;
        int numberOfServesSet2Player2 = 0;
        int numberOfServesSet3Player2 = 0;
        //Sum of sets per player
        int sumOfSetsPlayer1 = 0;
        int sumOfSetsPlayer2 = 0;
        //Sum of breaks per set per player
        int breaksSet1Player1 = 0;
        int breaksSet2Player1 = 0;
        int breaksSet3Player1 = 0;
        int breaksSet1Player2 = 0;
        int breaksSet2Player2 = 0;
        int breaksSet3Player2 = 0;
        //Sum of breaks saved per set per player
        int breaksSavedSet1Player1 = 0;
        int breaksSavedSet2Player1 = 0;
        int breaksSavedSet3Player1 = 0;
        int breaksSavedSet1Player2 = 0;
        int breaksSavedSet2Player2 = 0;
        int breaksSavedSet3Player2 = 0;
        //Points won at the net.
        int pointsWonNetSet1Player1 = 0;
        int pointsWonNetSet2Player1 = 0;
        int pointsWonNetSet3Player1 = 0;
        int pointsWonNetSet1Player2 = 0;
        int pointsWonNetSet2Player2 = 0;
        int pointsWonNetSet3Player2 = 0;
        //Advantage
        bool adPlayer1 = false;
        bool adPlayer2 = false;
        //Tie break
        bool tieBreak = false;
        //Serve
        bool servePlayer1 = false;
        bool servePlayer2 = false;
        //Serve starting
        bool startServing = false;
        bool startServing1 = false;
        bool startServing2 = false;
        //Set won
        bool set1Won = false;
        bool set2Won = false;
        //fault
        bool fault = false;
        //winner
        bool winner = false;
        //unforced error
        bool unforcedError = false;
        //Forced error
        bool forcedError = false;
        //Approach
        bool approachPlayer1 = false;
        bool approachPlayer2 = false;

        //Variables for calculus.
        //First Serve in.
        int firstServeInSet1Player1 = 0;
        int firstServeInSet2Player1 = 0;
        int firstServeInSet3Player1 = 0;
        int firstServeInSet1Player2 = 0;
        int firstServeInSet2Player2 = 0;
        int firstServeInSet3Player2 = 0;
        //Percentage First Serve.
        int percentFirstServeSet1Player1 = 0;
        int percentFirstServeSet2Player1 = 0;
        int percentFirstServeSet3Player1 = 0;
        int percentFirstServeSet1Player2 = 0;
        int percentFirstServeSet2Player2 = 0;
        int percentFirstServeSet3Player2 = 0;
        //Percentage point won 1st serve.
        int percentPointsWon1stServeSet1Player1 = 0;
        int percentPointsWon1stServeSet2Player1 = 0;
        int percentPointsWon1stServeSet3Player1 = 0;
        int percentPointsWon1stServeSet1Player2 = 0;
        int percentPointsWon1stServeSet2Player2 = 0;
        int percentPointsWon1stServeSet3Player2 = 0;
        //Percentage point won 2nd serve.
        int percentPointsWon2ndServeSet1Player1 = 0;
        int percentPointsWon2ndServeSet2Player1 = 0;
        int percentPointsWon2ndServeSet3Player1 = 0;
        int percentPointsWon2ndServeSet1Player2 = 0;
        int percentPointsWon2ndServeSet2Player2 = 0;
        int percentPointsWon2ndServeSet3Player2 = 0;
        //2ND Serve in
        int secondServeInSet1Player1 = 0;
        int secondServeInSet2Player1 = 0;
        int secondServeInSet3Player1 = 0;
        int secondServeInSet1Player2 = 0;
        int secondServeInSet2Player2 = 0;
        int secondServeInSet3Player2 = 0;
        //Percent breaks saved.
        int percentBreaksSavedSet1Player1 = 0;
        int percentBreaksSavedSet2Player1 = 0;
        int percentBreaksSavedSet3Player1 = 0;
        int percentBreaksSavedSet1Player2 = 0;
        int percentBreaksSavedSet2Player2 = 0;
        int percentBreaksSavedSet3Player2 = 0;
        //Points won returning second serve.
        int pointWonReturning2ndServeSet1Player1 = 0;
        int pointWonReturning2ndServeSet2Player1 = 0;
        int pointWonReturning2ndServeSet3Player1 = 0;
        int pointWonReturning2ndServeSet1Player2 = 0;
        int pointWonReturning2ndServeSet2Player2 = 0;
        int pointWonReturning2ndServeSet3Player2 = 0;
        //Break points won.
        int breakPointWonSet1Player1 = 0;
        int breakPointWonSet2Player1 = 0;
        int breakPointWonSet3Player1 = 0;
        int breakPointWonSet1Player2 = 0;
        int breakPointWonSet2Player2 = 0;
        int breakPointWonSet3Player2 = 0;
        string firstNamePlayer1 = "";
        string firstNamePlayer2 = "";
        string lastNamePlayer1 = "";
        string lastNamePlayer2 = "";
        Timer RefreshTimer = new Timer();

        public TennisScout()
        {

            InitializeComponent();

        }

        //Check everything for player 1.
        private void CheckPlayer1()
        {
            //Check for tie-break set 1.
            if (set1GamesPlayer1 == 6 && set1GamesPlayer2 == 6)
            {
                tieBreak = true;
                if (pointsPlayer1 - pointsPlayer2 >= 1 && pointsPlayer1 >= 6)
                {
                    //Set first set to true.
                    set1Won = true;
                    //Start the set 2 timer and stopwatch.
                    timerSet2.Start();
                    sw2.Start();

                    //Do the rest.
                    GetSumPointsServed();
                    tieBreakSet1Player2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set1GamesPlayer1 += 1;
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    set1TimeLabel.Text = matchTimeTextBox.Text;
                    sumOfSetsPlayer1 += 1;
                    tieBreak = false;

                    if (startServing1 == true && servePlayer1 == true)
                    {
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    else if (startServing1 == true && servePlayer2 == true)
                    {
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;

                    }
                    if (startServing2 == true && servePlayer2)
                    {
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                    else if (startServing2 == true && servePlayer1)
                    {
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                }

                    //Change the server in the tiebreak for set 1.
                else
                {
                    if (servePlayer1 == true && pointsPlayer1 == 0 && pointsPlayer2 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (servePlayer2 == true && pointsPlayer2 == 0 && pointsPlayer1 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 2 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 2 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 4 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 4 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 6 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 6 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 8 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 8 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 10 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 10 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 12 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 12 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 14 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 14 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 16 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 16 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 18 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 18 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 20 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 20 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 22 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 22 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 24 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 24 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 26 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 26 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 28 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 28 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 30 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 30 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 32 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 32 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 34 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 34 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 36 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 36 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 38 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 38 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 40 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 40 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 42 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 42 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 44 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 44 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 46 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 46 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 48 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 48 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 50 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 50 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else
                    {
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                        GetSumPointsServed();
                    }
                }
            }

            //Check for tiebreak set 2.
            if (set2GamesPlayer1 == 6 && set2GamesPlayer2 == 6)
            {
                tieBreak = true;
                if (pointsPlayer1 - pointsPlayer2 >= 1 && pointsPlayer1 >= 6)
                {
                    //Set set 2 to true.
                    set2Won = true;

                    //Stop the timer and the stopwatch for the 2 set.
                    timerSet2.Stop();
                    sw2.Stop();

                    //Get the time for the second set.
                    int hours2 = sw2.Elapsed.Hours, mins2 = sw2.Elapsed.Minutes, secs2 = sw2.Elapsed.Seconds;
                    set2TimeLabel.Text = hours2 + ":";
                    if (mins2 < 10)
                        set2TimeLabel.Text += "0" + mins2 + ":";
                    else
                        set2TimeLabel.Text += mins2 + ":";
                    if (secs2 < 10)
                        set2TimeLabel.Text += "0" + secs2;
                    else
                        set2TimeLabel.Text += secs2;

                    //Start the timer and the stopwatch for the set 3.
                    timerSet3.Start();
                    sw3.Start();

                    //Do the rest.
                    GetSumPointsServed();
                    tieBreakSet2Player2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer1 += 1;
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    sumOfSetsPlayer1 += 1;
                    CheckSumOfSets();
                    tieBreak = false;

                    if (startServing1 == true && servePlayer1 == true)
                    {
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    else if (startServing1 == true && servePlayer2 == true)
                    {
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;

                    }
                    if (startServing2 == true && servePlayer2)
                    {
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                    else if (startServing2 == true && servePlayer1)
                    {
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                }
                //Change the server in the tiebreak for set 2.
                else
                {
                    if (servePlayer1 == true && pointsPlayer1 == 0 && pointsPlayer2 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (servePlayer2 == true && pointsPlayer2 == 0 && pointsPlayer1 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 2 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 2 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 4 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 4 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 6 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 6 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 8 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 8 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 10 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 10 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 12 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 12 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 14 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 14 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 16 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 16 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 18 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 18 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 20 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 20 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 22 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 22 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 24 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 24 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 26 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 26 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 28 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 28 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 30 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 30 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 32 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 32 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 34 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 34 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 36 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 36 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 38 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 38 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 40 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 40 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 42 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 42 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 44 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 44 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 46 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 46 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 48 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 48 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 50 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 50 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else
                    {
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                        GetSumPointsServed();
                    }
                }
            }

                //Check for tiebreak set 3.
            else if (set3GamesPlayer1 == 6 && set3GamesPlayer2 == 6)
            {
                tieBreak = true;
                if (pointsPlayer1 - pointsPlayer2 >= 1 && pointsPlayer1 >= 6)
                {
                    //Stop the timer and the stopwatch for the 3 set.
                    timerSet3.Stop();
                    sw3.Stop();

                    //Get the time for the second set.
                    int hours3 = sw3.Elapsed.Hours, mins3 = sw3.Elapsed.Minutes, secs3 = sw3.Elapsed.Seconds;
                    set3TimeLabel.Text = hours3 + ":";
                    if (mins3 < 10)
                        set3TimeLabel.Text += "0" + mins3 + ":";
                    else
                        set3TimeLabel.Text += mins3 + ":";
                    if (secs3 < 10)
                        set3TimeLabel.Text += "0" + secs3;
                    else
                        set3TimeLabel.Text += secs3;

                    //Do the rest
                    GetSumPointsServed();
                    tieBreakSet3Player2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set3GamesPlayer1 += 1;
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    sumOfSetsPlayer1 += 1;
                    CheckSumOfSets();
                    tieBreak = false;
                }

                //Change the server in the tiebreak for set 3.
                else
                {
                    if (servePlayer1 == true && pointsPlayer1 == 0 && pointsPlayer2 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (servePlayer2 == true && pointsPlayer2 == 0 && pointsPlayer1 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 2 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 2 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 4 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 4 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 6 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 6 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 8 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 8 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 10 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 10 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 12 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 12 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 14 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 14 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 16 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 16 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 18 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 18 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 20 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 20 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 22 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 22 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 24 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 24 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 26 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 26 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 28 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 28 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 30 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 30 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 32 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 32 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 34 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 34 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 36 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 36 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 38 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 38 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 40 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 40 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 42 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 42 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 44 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 44 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 46 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 46 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 48 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 48 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else if (pointsPlayer1 + pointsPlayer2 == 50 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }

                    else if (pointsPlayer1 + pointsPlayer2 == 50 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    }
                    else
                    {
                        pointsPlayer1 += 1;
                        pointsPlayer1Label.Text = pointsPlayer1.ToString();
                        GetSumPointsServed();
                    }
                }

            }
            //Check if the player 1 is in advantage.
            else if (adPlayer1 == true)
            {
                //Check if the player is about to close the set 3 and set up the set counter.
                //Get the time of the set.
                if (set3GamesPlayer1 - set3GamesPlayer2 >= 1 && set3GamesPlayer1 == 5 || set3GamesPlayer1 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //Stop the timer and the stopwatch for the 3 set.
                    timerSet3.Stop();
                    sw3.Stop();

                    //Get the time for the second set.
                    int hours3 = sw3.Elapsed.Hours, mins3 = sw3.Elapsed.Minutes, secs3 = sw3.Elapsed.Seconds;
                    set2TimeLabel.Text = hours3 + ":";
                    if (mins3 < 10)
                        set3TimeLabel.Text += "0" + mins3 + ":";
                    else
                        set2TimeLabel.Text += mins3 + ":";
                    if (secs3 < 10)
                        set3TimeLabel.Text += "0" + secs3;
                    else
                        set3TimeLabel.Text += secs3;

                    //Do the rest.
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set3GamesPlayer1 += 1;
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    sumOfSetsPlayer1 += 1;
                    CheckSumOfSets();
                }

                    //Check set 2 on player 2.
                else if (set2GamesPlayer2 - set2GamesPlayer1 >= 2 && set2Player2Label.Text == set2GamesPlayer2.ToString("6") ||
                    set2Player2Label.Text == set2GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set3GamesPlayer1 += 1;
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                }

                    //Check set 2 on player 1.
                else if (set2GamesPlayer1 - set2GamesPlayer2 >= 2 && set2Player1Label.Text == set2GamesPlayer1.ToString("6") ||
                    set2Player1Label.Text == set2GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set3GamesPlayer1 += 1;
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                }

                     //Check if the player is about to close the set 2 and set up the set counter.
                //Get the time of the set.
                else if (set2GamesPlayer1 - set2GamesPlayer2 >= 1 && set2GamesPlayer1 == 5 || set2GamesPlayer1 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //Set counter set 2
                    set2Won = true;
                    //Stop the timer and the stopwatch for the 2 set.
                    timerSet2.Stop();
                    sw2.Stop();

                    //Get the time for the second set.
                    int hours2 = sw2.Elapsed.Hours, mins2 = sw2.Elapsed.Minutes, secs2 = sw2.Elapsed.Seconds;
                    set2TimeLabel.Text = hours2 + ":";
                    if (mins2 < 10)
                        set2TimeLabel.Text += "0" + mins2 + ":";
                    else
                        set2TimeLabel.Text += mins2 + ":";
                    if (secs2 < 10)
                        set2TimeLabel.Text += "0" + secs2;
                    else
                        set2TimeLabel.Text += secs2;

                    //Start the timer and the stopwatch for the set 3.
                    timerSet3.Start();
                    sw3.Start();

                    //Do the rest.
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer1 += 1;
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    sumOfSetsPlayer1 += 1;
                    CheckSumOfSets();
                }

                    //Check set 1 on player 2.
                else if (set1GamesPlayer2 - set1GamesPlayer1 >= 2 && set1Player2Label.Text == set1GamesPlayer2.ToString("6") ||
                    set1Player2Label.Text == set1GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer1 += 1;
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                }

                    //Check set 1 on player 1.
                else if (set1GamesPlayer1 - set1GamesPlayer2 >= 2 && set1Player1Label.Text == set1GamesPlayer1.ToString("6") ||
                     set1Player1Label.Text == set1GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer1 += 1;
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                }

                    //Check if the player is about to close the set 1 and set up the set counter.
                //Get the time of the set.
                else if (set1GamesPlayer1 - set1GamesPlayer2 >= 1 && set1GamesPlayer1 == 5 || set1GamesPlayer1 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //Set counter to set 1;
                    set1Won = true;

                    //Start the set 2 timer and stopwatch.
                    timerSet2.Start();
                    sw2.Start();

                    //Do the rest.
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set1GamesPlayer1 += 1;
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    set1TimeLabel.Text = matchTimeTextBox.Text;
                    sumOfSetsPlayer1 += 1;
                    timerSet2.Start();
                    sw2.Start();
                }

                    //Mark and display on set 1 player1.
                else
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set1GamesPlayer1 += 1;
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                }

                //Check if player 1 is serving, if he is, switch server.
                if (servePlayer1 == true)
                {
                    servePlayer1 = false;
                    pictureBox3.Visible = false;
                    servePlayer2 = true;
                    pictureBox2.Visible = true;
                }
                else if (servePlayer2 == true)
                {
                    servePlayer2 = false;
                    pictureBox2.Visible = false;
                    servePlayer1 = true;
                    pictureBox3.Visible = true;
                }

                //Turn advantage of player 1 to false.
                adPlayer1 = false;
            }

                //Check if player 2 is in advantage.
            else if (adPlayer2 == true)
            {
                GetSumPointsServed();
                pointsPlayer1 = 40;
                pointsPlayer2 = 40;
                pointsPlayer1Label.Text = pointsPlayer1.ToString();
                pointsPlayer2Label.Text = pointsPlayer2.ToString();
                adPlayer2 = false;
            }

                //Check if players 1 and 2 are "Deuce".
            else if (pointsPlayer1 == 40 && pointsPlayer2 == 40)
            {
                GetSumPointsServed();
                pointsPlayer1 = 0;
                pointsPlayer2 = 0;
                pointsPlayer2Label.Text = pointsPlayer2.ToString(" ");
                pointsPlayer1Label.Text = pointsPlayer1.ToString("AD");
                adPlayer1 = true;
            }

                //Check if player 1 is 40-0, 40-15, or 40-30.
            else if (pointsPlayer1 == 40 && pointsPlayer2 < 40)
            {
                //Check if the player is about to close the set 3 and set up the set counter.
                //Get the time of the set.
                if (set3GamesPlayer1 - set3GamesPlayer2 >= 1 && set3GamesPlayer1 == 5 || set3GamesPlayer1 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();

                    //Stop the timer and the stopwatch for the 3 set.
                    timerSet3.Stop();
                    sw3.Stop();

                    //Get the time for the second set.
                    int hours3 = sw3.Elapsed.Hours, mins3 = sw3.Elapsed.Minutes, secs3 = sw3.Elapsed.Seconds;
                    set2TimeLabel.Text = hours3 + ":";
                    if (mins3 < 10)
                        set3TimeLabel.Text += "0" + mins3 + ":";
                    else
                        set2TimeLabel.Text += mins3 + ":";
                    if (secs3 < 10)
                        set3TimeLabel.Text += "0" + secs3;
                    else
                        set3TimeLabel.Text += secs3;

                    //Do the rest.
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set3GamesPlayer1 += 1;
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    sumOfSetsPlayer1 += 1;
                    CheckSumOfSets();
                }

                    //Check set 2 on player 2.
                else if (set2GamesPlayer2 - set2GamesPlayer1 >= 2 && set2Player2Label.Text == set2GamesPlayer2.ToString("6") ||
                    set2Player2Label.Text == set2GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set3GamesPlayer1 += 1;
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                }

                    //Check set 2 on player 1.
                else if (set2GamesPlayer1 - set2GamesPlayer2 >= 2 && set2Player1Label.Text == set2GamesPlayer1.ToString("6") ||
                    set2Player1Label.Text == set2GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set3GamesPlayer1 += 1;
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                }

                     //Check if the player is about to close the set 2 and set up the set counter.
                //Get the time of the set.
                else if (set2GamesPlayer1 - set2GamesPlayer2 >= 1 && set2GamesPlayer1 == 5 || set2GamesPlayer1 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //Set set 2 counter to true.
                    set2Won = true;
                    //Stop the timer and the stopwatch for the 2 set.
                    timerSet2.Stop();
                    sw2.Stop();

                    //Get the time for the second set.
                    int hours2 = sw2.Elapsed.Hours, mins2 = sw2.Elapsed.Minutes, secs2 = sw2.Elapsed.Seconds;
                    set2TimeLabel.Text = hours2 + ":";
                    if (mins2 < 10)
                        set2TimeLabel.Text += "0" + mins2 + ":";
                    else
                        set2TimeLabel.Text += mins2 + ":";
                    if (secs2 < 10)
                        set2TimeLabel.Text += "0" + secs2;
                    else
                        set2TimeLabel.Text += secs2;

                    //Start the timer and the stopwatch for the set 3.
                    timerSet3.Start();
                    sw3.Start();

                    //Do the rest.
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer1 += 1;
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    sumOfSetsPlayer1 += 1;
                    CheckSumOfSets();
                }

                    //Check set 1 on player 2.
                else if (set1GamesPlayer2 - set1GamesPlayer1 >= 2 && set1Player2Label.Text == set1GamesPlayer2.ToString("6") ||
                    set1Player2Label.Text == set1GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer1 += 1;
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();

                }

                    //Check set 1 on player 1.
                else if (set1GamesPlayer1 - set1GamesPlayer2 >= 2 && set1Player1Label.Text == set1GamesPlayer1.ToString("6") ||
                     set1Player1Label.Text == set1GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer1 += 1;
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    GamesServed();
                }

                    //Check if the player is about to close the set 1 and set up the set counter.
                //Get the time of the set.
                else if (set1GamesPlayer1 - set1GamesPlayer2 >= 1 && set1GamesPlayer1 == 5 || set1GamesPlayer1 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //set set 1 counter to true.
                    set1Won = true;
                    //Start the set 2 timer and stopwatch.
                    timerSet2.Start();
                    sw2.Start();

                    //Do the rest.
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set1GamesPlayer1 += 1;
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    set1TimeLabel.Text = matchTimeTextBox.Text;
                    sumOfSetsPlayer1 += 1;
                }

                    //Mark and display on set 1 player1.
                else
                {
                    GetSumPointsServed();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set1GamesPlayer1 += 1;
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    GamesServed();
                }

                //Check if player 1 is serving, if he is, switch server.
                if (servePlayer1 == true)
                {
                    servePlayer1 = false;
                    pictureBox3.Visible = false;
                    servePlayer2 = true;
                    pictureBox2.Visible = true;
                }
                else if (servePlayer2 == true)
                {
                    servePlayer2 = false;
                    pictureBox2.Visible = false;
                    servePlayer1 = true;
                    pictureBox3.Visible = true;
                }
            }

                //Check if player 1 is 30.
            else if (pointsPlayer1 == 30 && tieBreak == false)
            {
                GetSumPointsServed();
                pointsPlayer1 = 40;
                pointsPlayer1Label.Text = pointsPlayer1.ToString();
            }

                //Check if player 1 is 15.
            else if (pointsPlayer1 == 15 && tieBreak == false)
            {
                GetSumPointsServed();
                pointsPlayer1 = 30;
                pointsPlayer1Label.Text = pointsPlayer1.ToString();
            }

                //Check if player 1 is 0.
            else if (pointsPlayer1 == 0 && tieBreak == false)
            {
                GetSumPointsServed();
                pointsPlayer1 = 15;
                pointsPlayer1Label.Text = pointsPlayer1.ToString();
                pointsPlayer2Label.Text = pointsPlayer2.ToString();
            }
        }

        //Check everything for player 2.
        private void CheckPlayer2()
        {
            //Check for tie-break set 1.
            if (set1GamesPlayer2 == 6 && set1GamesPlayer1 == 6)
            {
                tieBreak = true;
                if (pointsPlayer2 - pointsPlayer1 >= 1 && pointsPlayer2 >= 6)
                {
                    //Set counter set 1 to true.
                    set1Won = true;

                    //Start timer and stopwatch for set 2.
                    timerSet2.Start();
                    sw2.Start();

                    //Do the rest.
                    GetSumPointsServed();
                    tieBreakSet1Player1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set1GamesPlayer2 += 1;
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    set1TimeLabel.Text = matchTimeTextBox.Text;
                    sumOfSetsPlayer2 += 1;
                    tieBreak = false;

                    if (startServing1 == true && servePlayer1 == true)
                    {
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    else if (startServing1 == true && servePlayer2 == true)
                    {
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    if (startServing2 == true && servePlayer2)
                    {
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                    else if (startServing2 == true && servePlayer1)
                    {
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                }

                     //Change the server in the tiebreak for set 1.
                else
                {
                    if (servePlayer2 == true && pointsPlayer2 == 0 && pointsPlayer1 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (servePlayer1 == true && pointsPlayer1 == 0 && pointsPlayer2 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 2 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 2 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 4 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 4 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 6 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 6 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 8 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 8 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 10 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 10 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 12 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 12 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 14 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 14 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 16 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 16 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 18 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 18 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 20 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 20 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 22 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 22 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 24 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 24 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 26 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 26 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 28 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 28 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 30 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 30 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 32 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 32 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 34 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 34 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 36 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 36 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 38 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 38 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 40 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 40 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 42 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 42 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 44 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 44 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 46 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 46 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 48 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 48 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 50 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 50 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else
                    {
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                        GetSumPointsServed();
                    }
                }
            }

                //Check for tiebreak set 2.
            else if (set2GamesPlayer2 == 6 && set2GamesPlayer1 == 6)
            {
                tieBreak = true;
                if (pointsPlayer2 - pointsPlayer1 >= 1 && pointsPlayer2 >= 6)
                {
                    //Set counter set 2 to true.
                    set2Won = true;

                    //Stop the timer and the stopwatch for the 2 set.
                    timerSet2.Stop();
                    sw2.Stop();

                    //Get the time for the second set.
                    int hours2 = sw2.Elapsed.Hours, mins2 = sw2.Elapsed.Minutes, secs2 = sw2.Elapsed.Seconds;
                    set2TimeLabel.Text = hours2 + ":";
                    if (mins2 < 10)
                        set2TimeLabel.Text += "0" + mins2 + ":";
                    else
                        set2TimeLabel.Text += mins2 + ":";
                    if (secs2 < 10)
                        set2TimeLabel.Text += "0" + secs2;
                    else
                        set2TimeLabel.Text += secs2;

                    //Start the timer and stopwatch for the 3 set.
                    timerSet3.Start();
                    sw3.Start();

                    //Do the rest.
                    GetSumPointsServed();
                    tieBreakSet2Player1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer1 = 0;
                    pointsPlayer2 = 0;
                    set2GamesPlayer2 += 1;
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    sumOfSetsPlayer2 += 1;
                    CheckSumOfSets();
                    tieBreak = false;

                    if (startServing1 == true && servePlayer1 == true)
                    {
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    else if (startServing1 == true && servePlayer2 == true)
                    {
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    if (startServing2 == true && servePlayer2)
                    {
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                    else if (startServing2 == true && servePlayer1)
                    {
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                }

                    //Change the server in the tiebreak for set 2.
                else
                {
                    if (servePlayer2 == true && pointsPlayer2 == 0 && pointsPlayer1 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (servePlayer1 == true && pointsPlayer1 == 0 && pointsPlayer2 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 2 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 2 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 4 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 4 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 6 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 6 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 8 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 8 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 10 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 10 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 12 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 12 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 14 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 14 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 16 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 16 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 18 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 18 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 20 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 20 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 22 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 22 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 24 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 24 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 26 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 26 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 28 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 28 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 30 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 30 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 32 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 32 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 34 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 34 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 36 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 36 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 38 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 38 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 40 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 40 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 42 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 42 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 44 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 44 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 46 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 46 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 48 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 48 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 50 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 50 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else
                    {
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                        GetSumPointsServed();
                    }
                }
            }

                //Check for tiebreak set 3.
            else if (set3GamesPlayer2 == 6 && set3GamesPlayer1 == 6)
            {
                tieBreak = true;
                if (pointsPlayer2 - pointsPlayer1 >= 1 && pointsPlayer2 >= 6)
                {
                    //Stop the timer and the stopwatch for the 3 set.
                    timerSet3.Stop();
                    sw3.Stop();

                    //Get the time for the second set.
                    int hours3 = sw3.Elapsed.Hours, mins3 = sw3.Elapsed.Minutes, secs3 = sw3.Elapsed.Seconds;
                    set3TimeLabel.Text = hours3 + ":";
                    if (mins3 < 10)
                        set3TimeLabel.Text += "0" + mins3 + ":";
                    else
                        set3TimeLabel.Text += mins3 + ":";
                    if (secs3 < 10)
                        set3TimeLabel.Text += "0" + secs3;
                    else
                        set3TimeLabel.Text += secs3;

                    //Do the rest.
                    GetSumPointsServed();
                    tieBreakSet3Player1Label.Text = pointsPlayer1.ToString();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set3GamesPlayer2 += 1;
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    sumOfSetsPlayer2 += 1;
                    CheckSumOfSets();
                    tieBreak = false;
                }

                    //Change the server in the tiebreak for set 3.
                else
                {
                    if (servePlayer2 == true && pointsPlayer2 == 0 && pointsPlayer1 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (servePlayer1 == true && pointsPlayer1 == 0 && pointsPlayer2 == 0)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 2 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 2 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 4 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 4 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 6 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 6 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 8 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 8 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 10 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 10 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 12 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 12 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 14 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 14 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 16 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 16 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 18 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 18 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 20 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 20 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 22 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 22 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 24 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 24 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 26 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 26 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 28 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 28 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 30 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 30 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 32 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 32 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 34 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 34 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 36 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 36 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 38 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 38 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 40 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 40 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 42 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 42 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 44 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 44 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 46 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 46 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 48 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 48 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else if (pointsPlayer2 + pointsPlayer1 == 50 && servePlayer2 == true)
                    {
                        GetSumPointsServed();
                        servePlayer2 = false;
                        pictureBox2.Visible = false;
                        servePlayer1 = true;
                        pictureBox3.Visible = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }

                    else if (pointsPlayer2 + pointsPlayer1 == 50 && servePlayer1 == true)
                    {
                        GetSumPointsServed();
                        servePlayer1 = false;
                        pictureBox3.Visible = false;
                        servePlayer2 = true;
                        pictureBox2.Visible = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    }
                    else
                    {
                        pointsPlayer2 += 1;
                        pointsPlayer2Label.Text = pointsPlayer2.ToString();
                        GetSumPointsServed();
                    }
                }
            }

            else if (adPlayer2 == true)
            {
                //Check if the player is about to close the set 3 and set up the set counter.
                //Get the time of the set.
                if (set3GamesPlayer2 - set3GamesPlayer1 >= 1 && set3GamesPlayer2 == 5 || set3GamesPlayer2 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //Stop the timer and the stopwatch for the 3 set.
                    timerSet3.Stop();
                    sw3.Stop();

                    //Get the time for the second set.
                    int hours3 = sw3.Elapsed.Hours, mins3 = sw3.Elapsed.Minutes, secs3 = sw3.Elapsed.Seconds;
                    set3TimeLabel.Text = hours3 + ":";
                    if (mins3 < 10)
                        set3TimeLabel.Text += "0" + mins3 + ":";
                    else
                        set3TimeLabel.Text += mins3 + ":";
                    if (secs3 < 10)
                        set3TimeLabel.Text += "0" + secs3;
                    else
                        set3TimeLabel.Text += secs3;

                    //Do the rest.
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set3GamesPlayer2 += 1;
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    sumOfSetsPlayer2 += 1;
                    CheckSumOfSets();
                }


                else if (set2GamesPlayer1 - set2GamesPlayer2 >= 2 && set2Player1Label.Text == set2GamesPlayer1.ToString("6") ||
                    set2Player1Label.Text == set2GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set3GamesPlayer2 += 1;
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }


                else if (set2GamesPlayer2 - set2GamesPlayer1 >= 2 && set2Player2Label.Text == set2GamesPlayer2.ToString("6") ||
                    set2Player2Label.Text == set2GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set3GamesPlayer2 += 1;
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                    //Check if the player is about to close the set 2 and set up the set counter.
                //Get the time of the set.
                else if (set2GamesPlayer2 - set2GamesPlayer1 >= 1 && set2GamesPlayer2 == 5 || set2GamesPlayer2 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //set counter set 2 to true.
                    set2Won = true;
                    //Stop the timer and the stopwatch for the 2 set.
                    timerSet2.Stop();
                    sw2.Stop();

                    //Get the time for the second set.
                    int hours2 = sw2.Elapsed.Hours, mins2 = sw2.Elapsed.Minutes, secs2 = sw2.Elapsed.Seconds;
                    set2TimeLabel.Text = hours2 + ":";
                    if (mins2 < 10)
                        set2TimeLabel.Text += "0" + mins2 + ":";
                    else
                        set2TimeLabel.Text += mins2 + ":";
                    if (secs2 < 10)
                        set2TimeLabel.Text += "0" + secs2;
                    else
                        set2TimeLabel.Text += secs2;

                    //Start the timer and the stopwatch for the set 3.
                    timerSet3.Start();
                    sw3.Start();

                    //Do the rest.
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set2GamesPlayer2 += 1;
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    sumOfSetsPlayer2 += 1;
                    CheckSumOfSets();
                }

                else if (set1GamesPlayer1 - set1GamesPlayer2 >= 2 && set1Player1Label.Text == set1GamesPlayer1.ToString("6") ||
                    set1Player1Label.Text == set1GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set2GamesPlayer2 += 1;
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                else if (set1GamesPlayer2 - set1GamesPlayer1 >= 2 && set1Player2Label.Text == set1GamesPlayer2.ToString("6") ||
                     set1Player2Label.Text == set1GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set2GamesPlayer2 += 1;
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                    //Check if the player is about to close the set 1 and set up the set counter.
                //Get the time of the set.
                else if (set1GamesPlayer2 - set1GamesPlayer1 >= 1 && set1GamesPlayer2 == 5 || set1GamesPlayer2 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //Set set 1 counter to true.
                    set1Won = true;
                    //Start the timer and the stopwatch for the set 2.
                    timerSet2.Start();
                    sw2.Start();

                    //Do the rest.
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set1GamesPlayer2 += 1;
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    set1TimeLabel.Text = matchTimeTextBox.Text;
                    sumOfSetsPlayer2 += 1;
                }

                else
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set1GamesPlayer2 += 1;
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                //Check if player 1 is serving, if he is, switch server.
                if (servePlayer2 == true)
                {
                    servePlayer2 = false;
                    pictureBox2.Visible = false;
                    servePlayer1 = true;
                    pictureBox3.Visible = true;
                }
                else if (servePlayer1 == true)
                {
                    servePlayer1 = false;
                    pictureBox3.Visible = false;
                    servePlayer2 = true;
                    pictureBox2.Visible = true;
                }
                adPlayer2 = false;
            }
            else if (adPlayer1 == true)
            {
                GetSumPointsServed();
                pointsPlayer2 = 40;
                pointsPlayer1 = 40;
                pointsPlayer2Label.Text = pointsPlayer2.ToString();
                pointsPlayer1Label.Text = pointsPlayer1.ToString();
                adPlayer1 = false;
            }
            else if (pointsPlayer2 == 40 && pointsPlayer1 == 40)
            {
                GetSumPointsServed();
                pointsPlayer2 = 0;
                pointsPlayer1 = 0;
                pointsPlayer1Label.Text = pointsPlayer1.ToString(" ");
                pointsPlayer2Label.Text = pointsPlayer2.ToString("AD");
                adPlayer2 = true;
            }
            else if (pointsPlayer2 == 40 && pointsPlayer1 < 40)
            {

                //Check if the player is about to close the set 3 and set up the set counter.
                //Get the time of the set.
                if (set3GamesPlayer2 - set3GamesPlayer1 >= 1 && set3GamesPlayer2 == 5 || set3GamesPlayer2 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //Stop the timer and the stopwatch for the 3 set.
                    timerSet3.Stop();
                    sw3.Stop();

                    //Get the time for the second set.
                    int hours3 = sw3.Elapsed.Hours, mins3 = sw3.Elapsed.Minutes, secs3 = sw3.Elapsed.Seconds;
                    set3TimeLabel.Text = hours3 + ":";
                    if (mins3 < 10)
                        set3TimeLabel.Text += "0" + mins3 + ":";
                    else
                        set3TimeLabel.Text += mins3 + ":";
                    if (secs3 < 10)
                        set3TimeLabel.Text += "0" + secs3;
                    else
                        set3TimeLabel.Text += secs3;

                    //Do the rest.
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set3GamesPlayer2 += 1;
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    sumOfSetsPlayer2 += 1;
                    CheckSumOfSets();
                }


                else if (set2GamesPlayer1 - set2GamesPlayer2 >= 2 && set2Player1Label.Text == set2GamesPlayer1.ToString("6") ||
                    set2Player1Label.Text == set2GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set3GamesPlayer2 += 1;
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }


                else if (set2GamesPlayer2 - set2GamesPlayer1 >= 2 && set2Player2Label.Text == set2GamesPlayer2.ToString("6") ||
                    set2Player2Label.Text == set2GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set3GamesPlayer2 += 1;
                    set3Player2Label.Text = set3GamesPlayer2.ToString();
                    set3Player1Label.Text = set3GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                    //Check if the player is about to close the set 2 and set up the set counter.
                //Get the time of the set.
                else if (set2GamesPlayer2 - set2GamesPlayer1 >= 1 && set2GamesPlayer2 == 5 || set2GamesPlayer2 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //set set 2 counter to true.
                    set2Won = true;
                    //Stop the timer and the stopwatch for the 2 set.
                    timerSet2.Stop();
                    sw2.Stop();

                    //Get the time for the second set.
                    int hours2 = sw2.Elapsed.Hours, mins2 = sw2.Elapsed.Minutes, secs2 = sw2.Elapsed.Seconds;
                    set2TimeLabel.Text = hours2 + ":";
                    if (mins2 < 10)
                        set2TimeLabel.Text += "0" + mins2 + ":";
                    else
                        set2TimeLabel.Text += mins2 + ":";
                    if (secs2 < 10)
                        set2TimeLabel.Text += "0" + secs2;
                    else
                        set2TimeLabel.Text += secs2;

                    //Start the timer and the stopwatch for the set 3.
                    timerSet3.Start();
                    sw3.Start();

                    //Do the rest.
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set2GamesPlayer2 += 1;
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    sumOfSetsPlayer2 += 1;
                    CheckSumOfSets();
                }

                else if (set1GamesPlayer1 - set1GamesPlayer2 >= 2 && set1Player1Label.Text == set1GamesPlayer1.ToString("6") ||
                    set1Player1Label.Text == set1GamesPlayer1.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set2GamesPlayer2 += 1;
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                else if (set1GamesPlayer2 - set1GamesPlayer1 >= 2 && set1Player2Label.Text == set1GamesPlayer2.ToString("6") ||
                     set1Player2Label.Text == set1GamesPlayer2.ToString("7"))
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set2GamesPlayer2 += 1;
                    set2Player2Label.Text = set2GamesPlayer2.ToString();
                    set2Player1Label.Text = set2GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                    //Check if the player is about to close the set 1 and set up the set counter.
                //Get the time of the set.
                else if (set1GamesPlayer2 - set1GamesPlayer1 >= 1 && set1GamesPlayer2 == 5 || set1GamesPlayer2 == 6)
                {
                    GamesServed();
                    GetSumPointsServed();
                    //set counter set 1 to true.
                    set1Won = true;
                    //Start the timer and the stopwatch for the set 2.
                    timerSet2.Start();
                    sw2.Start();

                    //Do the rest.
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set1GamesPlayer2 += 1;
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                    set1TimeLabel.Text = matchTimeTextBox.Text;
                    sumOfSetsPlayer2 += 1;
                }

                else
                {
                    GamesServed();
                    GetSumPointsServed();
                    pointsPlayer2 = 0;
                    pointsPlayer1 = 0;
                    set1GamesPlayer2 += 1;
                    set1Player2Label.Text = set1GamesPlayer2.ToString();
                    set1Player1Label.Text = set1GamesPlayer1.ToString();
                    pointsPlayer2Label.Text = pointsPlayer2.ToString();
                    pointsPlayer1Label.Text = pointsPlayer1.ToString();
                }

                //Check if player 1 is serving, if he is, switch server.
                if (servePlayer2 == true)
                {
                    servePlayer2 = false;
                    pictureBox2.Visible = false;
                    servePlayer1 = true;
                    pictureBox3.Visible = true;
                }
                else if (servePlayer1 == true)
                {
                    servePlayer1 = false;
                    pictureBox3.Visible = false;
                    servePlayer2 = true;
                    pictureBox2.Visible = true;
                }
            }
            else if (pointsPlayer2 == 30)
            {
                GetSumPointsServed();
                pointsPlayer2 = 40;
                pointsPlayer2Label.Text = pointsPlayer2.ToString();
            }
            else if (pointsPlayer2 == 15)
            {
                GetSumPointsServed();
                pointsPlayer2 = 30;
                pointsPlayer2Label.Text = pointsPlayer2.ToString();
            }
            else if (pointsPlayer2 == 0)
            {
                GetSumPointsServed();
                pointsPlayer2 = 15;
                pointsPlayer2Label.Text = pointsPlayer2.ToString();
                pointsPlayer1Label.Text = pointsPlayer1.ToString();
            }
        }

        //Check ace for player 1
        private void acePlayer1Button_Click(object sender, EventArgs e)
        {
            CountBreaksPlayer1();
            GetBreakPointWonPlayer1();
            //Switch servers.
            if (adPlayer1 == true || pointsPlayer1 == 40 && pointsPlayer2 < 40)
            {
                acePlayer1Button.Enabled = false;
                faultPlayer1Button.Enabled = false;
                acePlayer2Button.Enabled = true;
                faultPlayer2Button.Enabled = true;
            }
            if (set2Won == true)
            {
                aceSet3Player1 += 1;
                if (fault == true)
                {
                    //Switch servers.
                    if (adPlayer1 == true || pointsPlayer1 == 40 && pointsPlayer2 < 40)
                    {
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    else
                        faultPlayer1Button.Enabled = true;
                }
            }
            else if (set1Won == true)
            {
                aceSet2Player1 += 1;
                if (fault == true)
                {
                    //Switch servers.
                    if (adPlayer1 == true || pointsPlayer1 == 40 && pointsPlayer2 < 40)
                    {
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    else
                        faultPlayer1Button.Enabled = true;
                }
            }
            else
            {
                aceSet1Player1 += 1;
                if (fault == true)
                {
                    //Switch servers.
                    if (adPlayer1 == true || pointsPlayer1 == 40 && pointsPlayer2 < 40)
                    {
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                    }
                    else
                        faultPlayer1Button.Enabled = true;
                }
            }
            doubleFaultPlayer1Button.Enabled = false;
            CheckPointsWon1st2ndServesPlayer1();
            CheckPlayer1();
            fault = false;
        }

        //Check ace for player 2
        private void acePlayer2Button_Click(object sender, EventArgs e)
        {
            CountBreaksPlayer2();
            GetBreakPointWonPlayer2();
            //Switch servers.
            if (adPlayer2 == true || pointsPlayer2 == 40 && pointsPlayer1 < 40)
            {
                acePlayer2Button.Enabled = false;
                faultPlayer2Button.Enabled = false;
                acePlayer1Button.Enabled = true;
                faultPlayer1Button.Enabled = true;
            }
            if (set2Won == true)
            {
                aceSet3Player2 += 1;
                if (fault == true)
                {
                    //Switch servers.
                    if (adPlayer2 == true || pointsPlayer2 == 40 && pointsPlayer1 < 40)
                    {
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                    else
                        faultPlayer2Button.Enabled = true;
                }
            }
            else if (set1Won == true)
            {
                aceSet2Player2 += 1;
                if (fault == true)
                {//Switch servers.
                    if (adPlayer2 == true || pointsPlayer2 == 40 && pointsPlayer1 < 40)
                    {
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                    else
                        faultPlayer2Button.Enabled = true;
                }
            }
            else
            {
                aceSet1Player2 += 1;
                if (fault == true)
                {
                    //Switch servers.
                    if (adPlayer2 == true || pointsPlayer2 == 40 && pointsPlayer1 < 40)
                    {
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                    }
                    else
                        faultPlayer2Button.Enabled = true;
                }
            }
            doubleFaultPlayer2Button.Enabled = false;
            CheckPointsWon1st2ndServesPlayer2();
            CheckPlayer2();
            fault = false;
        }

        //Disable all the buttons when teh match is done.
        private void DisableAllButtons()
        {
            acePlayer1Button.Enabled = false;
            faultPlayer1Button.Enabled = false;
            doubleFaultPlayer1Button.Enabled = false;
            winnerPlayer1Button.Enabled = false;
            unfErrorPlayer1Button.Enabled = false;
            forcedErrorPlayer1Button.Enabled = false;
            approachPlayer1Button.Enabled = false;
            forePlayer1Button.Enabled = false;
            backPlayer1Button.Enabled = false;
            acePlayer2Button.Enabled = false;
            faultPlayer2Button.Enabled = false;
            doubleFaultPlayer2Button.Enabled = false;
            winnerPlayer2Button.Enabled = false;
            unfErrorPlayer2Button.Enabled = false;
            forcedErrorPlayer2Button.Enabled = false;
            approachPlayer2Button.Enabled = false;
            forePlayer2Button.Enabled = false;
            backPlayer2Button.Enabled = false;
        }

        //Initiate the stopwatch for the match
        private Stopwatch sw = new Stopwatch();

        //Initiate the stopwatch for the match
        private Stopwatch sw2 = new Stopwatch();

        //Initiate the stopwatch for the match
        private Stopwatch sw3 = new Stopwatch();

        //Initiate timer for the match
        private void timer1_Tick(object sender, EventArgs e)
        {
            int hours = sw.Elapsed.Hours, mins = sw.Elapsed.Minutes, secs = sw.Elapsed.Seconds;
            matchTimeTextBox.Text = hours + ":";
            if (mins < 10)
                matchTimeTextBox.Text += "0" + mins + ":";
            else
                matchTimeTextBox.Text += mins + ":";
            if (secs < 10)
                matchTimeTextBox.Text += "0" + secs;
            else
                matchTimeTextBox.Text += secs;

        }

        //Check the sum of sets
        private void CheckSumOfSets()
        {
            if (sumOfSetsPlayer1 == 2)
            {
                timer1.Stop();
                sw.Stop();
                MessageBox.Show("Winner:    " + player1LastNameTextBox.Text +
                    "\n by:    " + sumOfSetsPlayer1 + " sets" +
                    "\n to:    " + sumOfSetsPlayer2 +
                    "\n Set 1 Player 1 approaches: " + approachSet1Player1 +
                    "\n Set 2 Player 1 points won: " + pointsWonNetSet1Player1 +
                    "\n Set 1 Player 2 approaches: " + approachSet1Player2 +
                    "\n Set 2 Player 2 points won: " + pointsWonNetSet1Player2 +
                    "\n Breaks" + breaksSet1Player1 + "and" + breaksSet2Player1 +
                    "\n Saved Set 1" + breaksSavedSet1Player2 +
                    "\n Saved Set 2" + breaksSavedSet2Player2, "Match is Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAllButtons();
            }
            else if (sumOfSetsPlayer2 == 2)
            {
                timer1.Stop();
                sw.Stop();
                MessageBox.Show("Winner:    " + player2LastNameTextBox.Text +
                    "\n by:    " + sumOfSetsPlayer2 + " sets" +
                    "\n to:    " + sumOfSetsPlayer1 +
                    "\n Set 1 Player 1 approaches: " + approachSet1Player1 +
                    "\n Set 2 Player 1 points won: " + pointsWonNetSet1Player1 +
                    "\n Set 1 Player 2 approaches: " + approachSet1Player2 +
                    "\n Set 2 Player 2 points won: " + pointsWonNetSet1Player2 +
                    "\n Breaks" + breaksSet1Player1 + "and" + breaksSet2Player1 +
                    "\n Saved Set 1" + breaksSavedSet1Player2 +
                    "\n Saved Set 2" + breaksSavedSet2Player2, "Match is Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DisableAllButtons();
            }

        }

        //Get sum of points served
        private void GetSumPointsServed()
        {
            if (servePlayer1 == true)
            {
                if (set2Won == true)
                    numberOfServesSet3Player1 += 1;
                else if (set1Won == true)
                    numberOfServesSet2Player1 += 1;
                else
                    numberOfServesSet1Player1 += 1;
            }
            else if (servePlayer2 == true)
            {
                if (set2Won == true)
                    numberOfServesSet3Player2 += 1;
                else if (set1Won == true)
                    numberOfServesSet2Player2 += 1;
                else
                    numberOfServesSet1Player2 += 1;
            }
        }        

        //Open the stats form
        private void statsButton_Click(object sender, EventArgs e)
        {
            //Initialize the stats form.
            StatsForm statsForm = new StatsForm();
            Calculateresults();

            //Declare variables for serve.
            //Ace
            statsForm.AceSet1Player1 = aceSet1Player1;
            statsForm.AceSet2Player1 = aceSet2Player1;
            statsForm.AceSet3Player1 = aceSet3Player1;
            statsForm.AceSet1Player2 = aceSet1Player2;
            statsForm.AceSet2Player2 = aceSet2Player2;
            statsForm.AceSet3Player2 = aceSet3Player2;

            //Double Faults.
            statsForm.DoubleFaultSet1Player1 = doubleFaultSet1Player1;
            statsForm.DoubleFaultSet2Player1 = doubleFaultSet2Player1;
            statsForm.DoubleFaultSet3Player1 = doubleFaultSet3Player1;
            statsForm.DoubleFaultSet1Player2 = doubleFaultSet1Player2;
            statsForm.DoubleFaultSet2Player2 = doubleFaultSet2Player2;
            statsForm.DoubleFaultSet3Player2 = doubleFaultSet3Player2;

            //Number of serves.
            statsForm.NumberOfServesSet1Player1 = numberOfServesSet1Player1;
            statsForm.NumberOfServesSet2Player1 = numberOfServesSet2Player1;
            statsForm.NumberOfServesSet3Player1 = numberOfServesSet3Player1;
            statsForm.NumberOfServesSet1Player2 = numberOfServesSet1Player2;
            statsForm.NumberOfServesSet2Player2 = numberOfServesSet2Player2;
            statsForm.NumberOfServesSet3Player2 = numberOfServesSet3Player2;

            //Calculus for serve.
            //First serve in.
            statsForm.FirstServeInSet1Player1 = firstServeInSet1Player1;
            statsForm.FirstServeInSet2Player1 = firstServeInSet2Player1;
            statsForm.FirstServeInSet3Player1 = firstServeInSet3Player1;
            statsForm.FirstServeInSet1Player2 = firstServeInSet1Player2;
            statsForm.FirstServeInSet2Player2 = firstServeInSet2Player2;
            statsForm.FirstServeInSet3Player2 = firstServeInSet3Player2;

            //Second serve in.
            statsForm.SecondServeInSet1Player1 = secondServeInSet1Player1;
            statsForm.SecondServeInSet2Player1 = secondServeInSet2Player1;
            statsForm.SecondServeInSet3Player1 = secondServeInSet3Player1;
            statsForm.SecondServeInSet1Player2 = secondServeInSet1Player2;
            statsForm.SecondServeInSet2Player2 = secondServeInSet2Player2;
            statsForm.SecondServeInSet3Player2 = secondServeInSet3Player2;

            //Percentage of serve in.
            statsForm.PercentFirstServeSet1Player1 = percentFirstServeSet1Player1;
            statsForm.PercentFirstServeSet2Player1 = percentFirstServeSet2Player1;
            statsForm.PercentFirstServeSet3Player1 = percentFirstServeSet3Player1;
            statsForm.PercentFirstServeSet1Player2 = percentFirstServeSet1Player2;
            statsForm.PercentFirstServeSet2Player2 = percentFirstServeSet2Player2;
            statsForm.PercentFirstServeSet3Player2 = percentFirstServeSet3Player2;

            //Percentage points won 1st serve.
            statsForm.PercentPointsWon1stServeSet1Player1 = percentPointsWon1stServeSet1Player1;
            statsForm.PercentPointsWon1stServeSet2Player1 = percentPointsWon1stServeSet2Player1;
            statsForm.PercentPointsWon1stServeSet3Player1 = percentPointsWon1stServeSet3Player1;
            statsForm.PercentPointsWon1stServeSet1Player2 = percentPointsWon1stServeSet1Player2;
            statsForm.PercentPointsWon1stServeSet2Player2 = percentPointsWon1stServeSet2Player2;
            statsForm.PercentPointsWon1stServeSet3Player2 = percentPointsWon1stServeSet3Player2;

            //Percentage points won 2nd serve.
            statsForm.PercentPointsWon2ndServeSet1Player1 = percentPointsWon2ndServeSet1Player1;
            statsForm.PercentPointsWon2ndServeSet2Player1 = percentPointsWon2ndServeSet2Player1;
            statsForm.PercentPointsWon2ndServeSet3Player1 = percentPointsWon2ndServeSet3Player1;
            statsForm.PercentPointsWon2ndServeSet1Player2 = percentPointsWon2ndServeSet1Player2;
            statsForm.PercentPointsWon2ndServeSet2Player2 = percentPointsWon2ndServeSet2Player2;
            statsForm.PercentPointsWon2ndServeSet3Player2 = percentPointsWon2ndServeSet3Player2;

            //Points won 1st serve.
            statsForm.PointWon1ServeSet1Player1 = pointWon1ServeSet1Player1;
            statsForm.PointWon1ServeSet2Player1 = pointWon1ServeSet2Player1;
            statsForm.PointWon1ServeSet3Player1 = pointWon1ServeSet3Player1;
            statsForm.PointWon1ServeSet1Player2 = pointWon1ServeSet1Player2;
            statsForm.PointWon1ServeSet2Player2 = pointWon1ServeSet2Player2;
            statsForm.PointWon1ServeSet3Player2 = pointWon1ServeSet3Player2;

            //Points won 2nd serve.
            statsForm.PointWon2ServeSet1Player1 = pointWon2ServeSet1Player1;
            statsForm.PointWon2ServeSet2Player1 = pointWon2ServeSet2Player1;
            statsForm.PointWon2ServeSet3Player1 = pointWon2ServeSet3Player1;
            statsForm.PointWon2ServeSet1Player2 = pointWon2ServeSet1Player2;
            statsForm.PointWon2ServeSet2Player2 = pointWon2ServeSet2Player2;
            statsForm.PointWon2ServeSet3Player2 = pointWon2ServeSet3Player2;

            //Fault players 1 and 2.
            statsForm.FaultSet1Player1 = faultSet1Player1;
            statsForm.FaultSet2Player1 = faultSet2Player1;
            statsForm.FaultSet3Player1 = faultSet3Player1;
            statsForm.FaultSet1Player2 = faultSet1Player2;
            statsForm.FaultSet2Player2 = faultSet2Player2;
            statsForm.FaultSet3Player2 = faultSet3Player2;

            //Breaks
            statsForm.BreaksSet1Player1 = breaksSet1Player1;
            statsForm.BreaksSet2Player1 = breaksSet2Player1;
            statsForm.BreaksSet3Player1 = breaksSet3Player1;
            statsForm.BreaksSet1Player2 = breaksSet1Player2;
            statsForm.BreaksSet2Player2 = breaksSet2Player2;
            statsForm.BreaksSet3Player2 = breaksSet3Player2;

            //Breaks saved
            statsForm.BreaksSavedSet1Player1 = breaksSavedSet1Player1;
            statsForm.BreaksSavedSet2Player1 = breaksSavedSet2Player1;
            statsForm.BreaksSavedSet3Player1 = breaksSavedSet3Player1;
            statsForm.BreaksSavedSet1Player2 = breaksSavedSet1Player2;
            statsForm.BreaksSavedSet2Player2 = breaksSavedSet2Player2;
            statsForm.BreaksSavedSet3Player2 = breaksSavedSet3Player2;

            //Percentage breaks saved
            statsForm.PercentBreaksSavedSet1Player1 = percentBreaksSavedSet1Player1;
            statsForm.PercentBreaksSavedSet2Player1 = percentBreaksSavedSet2Player1;
            statsForm.PercentBreaksSavedSet3Player1 = percentBreaksSavedSet3Player1;
            statsForm.PercentBreaksSavedSet1Player2 = percentBreaksSavedSet1Player2;
            statsForm.PercentBreaksSavedSet2Player2 = percentBreaksSavedSet2Player2;
            statsForm.PercentBreaksSavedSet3Player2 = percentBreaksSavedSet3Player2;

            //Games served
            statsForm.GamesServedSet1Player1 = gamesServedSet1Player1;
            statsForm.GamesServedSet2Player1 = gamesServedSet2Player1;
            statsForm.GamesServedSet3Player1 = gamesServedSet3Player1;
            statsForm.GamesServedSet1Player2 = gamesServedSet1Player2;
            statsForm.GamesServedSet2Player2 = gamesServedSet2Player2;
            statsForm.GamesServedSet3Player2 = gamesServedSet3Player2;

            //Winners.
            statsForm.WinnersSet1Player1 = winnersSet1Player1;
            statsForm.WinnersSet2Player1 = winnersSet2Player1;
            statsForm.WinnersSet3Player1 = winnersSet3Player1;
            statsForm.WinnersSet1Player2 = winnersSet1Player2;
            statsForm.WinnersSet2Player2 = winnersSet2Player2;
            statsForm.WinnersSet3Player2 = winnersSet3Player2;

            //Forehand winners
            statsForm.ForehandWinnersSet1Player1 = forehandWinnersSet1Player1;
            statsForm.ForehandWinnersSet2Player1 = forehandWinnersSet2Player1;
            statsForm.ForehandWinnersSet3Player1 = forehandWinnersSet3Player1;
            statsForm.ForehandWinnersSet1Player2 = forehandWinnersSet1Player2;
            statsForm.ForehandWinnersSet2Player2 = forehandWinnersSet2Player2;
            statsForm.ForehandWinnersSet3Player2 = forehandWinnersSet3Player2;

            //Backhand winners
            statsForm.BackhandWinnersSet1Player1 = backhandWinnersSet1Player1;
            statsForm.BackhandWinnersSet2Player1 = backhandWinnersSet2Player1;
            statsForm.BackhandWinnersSet3Player1 = backhandWinnersSet3Player1;
            statsForm.BackhandWinnersSet1Player2 = backhandWinnersSet1Player2;
            statsForm.BackhandWinnersSet2Player2 = backhandWinnersSet2Player2;
            statsForm.BackhandWinnersSet3Player2 = backhandWinnersSet3Player2;

            //Unforced errors
            statsForm.UnforcedErrorsSet1Player1 = unforcedErrorsSet1Player1;
            statsForm.UnforcedErrorsSet2Player1 = unforcedErrorsSet2Player1;
            statsForm.UnforcedErrorsSet3Player1 = unforcedErrorsSet3Player1;
            statsForm.UnforcedErrorsSet1Player2 = unforcedErrorsSet1Player2;
            statsForm.UnforcedErrorsSet2Player2 = unforcedErrorsSet2Player2;
            statsForm.UnforcedErrorsSet3Player2 = unforcedErrorsSet3Player2;

            //Forehand unforced errors
            statsForm.ForehandUnforcedErrorsSet1Player1 = forehandUnforcedErrorsSet1Player1;
            statsForm.ForehandUnforcedErrorsSet2Player1 = forehandUnforcedErrorsSet2Player1;
            statsForm.ForehandUnforcedErrorsSet3Player1 = forehandUnforcedErrorsSet3Player1;
            statsForm.ForehandUnforcedErrorsSet1Player2 = forehandUnforcedErrorsSet1Player2;
            statsForm.ForehandUnforcedErrorsSet2Player2 = forehandUnforcedErrorsSet2Player2;
            statsForm.ForehandUnforcedErrorsSet3Player2 = forehandUnforcedErrorsSet3Player2;

            //Backhand unforced errors
            statsForm.BackhandUnforcedErrorsSet1Player1 = backhandUnforcedErrorsSet1Player1;
            statsForm.BackhandUnforcedErrorsSet2Player1 = backhandUnforcedErrorsSet2Player1;
            statsForm.BackhandUnforcedErrorsSet3Player1 = backhandUnforcedErrorsSet3Player1;
            statsForm.BackhandUnforcedErrorsSet1Player2 = backhandUnforcedErrorsSet1Player2;
            statsForm.BackhandUnforcedErrorsSet2Player2 = backhandUnforcedErrorsSet2Player2;
            statsForm.BackhandUnforcedErrorsSet3Player2 = backhandUnforcedErrorsSet3Player2;

            //Forced errors
            statsForm.ForcedErrorsSet1Player1 = forcedErrorsSet1Player1;
            statsForm.ForcedErrorsSet2Player1 = forcedErrorsSet2Player1;
            statsForm.ForcedErrorsSet3Player1 = forcedErrorsSet3Player1;
            statsForm.ForcedErrorsSet1Player2 = forcedErrorsSet1Player2;
            statsForm.ForcedErrorsSet2Player2 = forcedErrorsSet2Player2;
            statsForm.ForcedErrorsSet3Player2 = forcedErrorsSet3Player2;

            //Forehand forced errors
            statsForm.ForehandForcedErrorsSet1Player1 = forehandForcedErrorsSet1Player1;
            statsForm.ForehandForcedErrorsSet2Player1 = forehandForcedErrorsSet2Player1;
            statsForm.ForehandForcedErrorsSet3Player1 = forehandForcedErrorsSet3Player1;
            statsForm.ForehandForcedErrorsSet1Player2 = forehandForcedErrorsSet1Player2;
            statsForm.ForehandForcedErrorsSet2Player2 = forehandForcedErrorsSet2Player2;
            statsForm.ForehandForcedErrorsSet3Player2 = forehandForcedErrorsSet3Player2;

            //Backhand forced errors
            statsForm.BackhandForcedErrorsSet1Player1 = backhandForcedErrorsSet1Player1;
            statsForm.BackhandForcedErrorsSet2Player1 = backhandForcedErrorsSet2Player1;
            statsForm.BackhandForcedErrorsSet3Player1 = backhandForcedErrorsSet3Player1;
            statsForm.BackhandForcedErrorsSet1Player2 = backhandForcedErrorsSet1Player2;
            statsForm.BackhandForcedErrorsSet2Player2 = backhandForcedErrorsSet2Player2;
            statsForm.BackhandForcedErrorsSet3Player2 = backhandForcedErrorsSet3Player2;

            //Points won returning 2nd serve.
            statsForm.PointWonReturning2ndServeSet1Player1 = pointWonReturning2ndServeSet1Player1;
            statsForm.PointWonReturning2ndServeSet2Player1 = pointWonReturning2ndServeSet2Player1;
            statsForm.PointWonReturning2ndServeSet3Player1 = pointWonReturning2ndServeSet3Player1;
            statsForm.PointWonReturning2ndServeSet1Player2 = pointWonReturning2ndServeSet1Player2;
            statsForm.PointWonReturning2ndServeSet2Player2 = pointWonReturning2ndServeSet2Player2;
            statsForm.PointWonReturning2ndServeSet3Player2 = pointWonReturning2ndServeSet3Player2;

            //Break points won.
            statsForm.BreakPointWonSet1Player1 = breakPointWonSet1Player1;
            statsForm.BreakPointWonSet2Player1 = breakPointWonSet2Player1;
            statsForm.BreakPointWonSet3Player1 = breakPointWonSet3Player1;
            statsForm.BreakPointWonSet1Player2 = breakPointWonSet1Player2;
            statsForm.BreakPointWonSet2Player2 = breakPointWonSet2Player2;
            statsForm.BreakPointWonSet3Player2 = breakPointWonSet3Player2;

            //Points at the net.
            statsForm.ApproachSet1Player1 = approachSet1Player1;
            statsForm.ApproachSet2Player1 = approachSet2Player1;
            statsForm.ApproachSet3Player1 = approachSet3Player1;
            statsForm.ApproachSet1Player2 = approachSet1Player2;
            statsForm.ApproachSet2Player2 = approachSet2Player2;
            statsForm.ApproachSet3Player2 = approachSet3Player2;

            //Points won at the net.
            statsForm.PointsWonNetSet1Player1 = pointsWonNetSet1Player1;
            statsForm.PointsWonNetSet2Player1 = pointsWonNetSet2Player1;
            statsForm.PointsWonNetSet3Player1 = pointsWonNetSet3Player1;
            statsForm.PointsWonNetSet1Player2 = pointsWonNetSet1Player2;
            statsForm.PointsWonNetSet2Player2 = pointsWonNetSet2Player2;
            statsForm.PointsWonNetSet3Player2 = pointsWonNetSet3Player2;

            //Sets won
            statsForm.SumOfSetsPlayer1 = sumOfSetsPlayer1;
            statsForm.SumOfSetsPlayer2 = sumOfSetsPlayer2;

            //Players names
            statsForm.FirstNamePlayer1 = firstNamePlayer1;
            statsForm.FirstNamePlayer2 = firstNamePlayer2;
            statsForm.LastNamePlayer1 = lastNamePlayer1;
            statsForm.LastNamePlayer2 = lastNamePlayer2;


            //Show the summary.
            statsForm.ShowDialog();
        }

        //Count break player 1.
        private void CountBreaksPlayer1()
        {
            if (set2Won == true)
            {
                if (servePlayer2 == true)
                {
                    if (pointsPlayer1 == 40 && pointsPlayer2 == 40)
                        breaksSet3Player1 += 1;
                    else if (pointsPlayer2 == 30 && pointsPlayer1 == 30)
                        breaksSet3Player1 += 1;
                    else if (pointsPlayer2 == 15 && pointsPlayer1 == 30)
                        breaksSet3Player1 += 1;
                    else if (pointsPlayer2 == 0 && pointsPlayer1 == 30)
                        breaksSet3Player1 += 1;
                }
                else if (servePlayer1 == true)
                {
                    if (adPlayer2 == true)
                        breaksSavedSet3Player1 += 1;
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 30)
                        breaksSavedSet3Player1 += 1;
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 15)
                    {
                        breaksSavedSet3Player1 += 1;
                        breaksSet3Player2 += 1;
                    }
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 0)
                    {
                        breaksSavedSet3Player1 += 1;
                        breaksSet3Player2 += 1;
                    }
                }

            }
            else if (set1Won == true)
            {
                if (servePlayer2 == true)
                {
                    if (pointsPlayer1 == 40 && pointsPlayer2 == 40)
                        breaksSet2Player1 += 1;
                    else if (pointsPlayer2 == 30 && pointsPlayer1 == 30)
                        breaksSet2Player1 += 1;
                    else if (pointsPlayer2 == 15 && pointsPlayer1 == 30)
                        breaksSet2Player1 += 1;
                    else if (pointsPlayer2 == 0 && pointsPlayer1 == 30)
                        breaksSet2Player1 += 1;
                }
                else if (servePlayer1 == true)
                {
                    if (adPlayer2 == true)
                        breaksSavedSet2Player1 += 1;
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 30)
                        breaksSavedSet2Player1 += 1;
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 15)
                    {
                        breaksSavedSet2Player1 += 1;
                        breaksSet2Player2 += 1;
                    }
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 0)
                    {
                        breaksSavedSet2Player1 += 1;
                        breaksSet2Player2 += 1;
                    }
                }
            }
            else
            {
                if (servePlayer2 == true)
                {
                    if (pointsPlayer1 == 40 && pointsPlayer2 == 40)
                        breaksSet1Player1 += 1;
                    else if (pointsPlayer2 == 30 && pointsPlayer1 == 30)
                        breaksSet1Player1 += 1;
                    else if (pointsPlayer2 == 15 && pointsPlayer1 == 30)
                        breaksSet1Player1 += 1;
                    else if (pointsPlayer2 == 0 && pointsPlayer1 == 30)
                        breaksSet1Player1 += 1;
                }
                else if (servePlayer1 == true)
                {
                    if (adPlayer2 == true)
                        breaksSavedSet1Player1 += 1;
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 30)
                        breaksSavedSet1Player1 += 1;
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 15)
                    {
                        breaksSavedSet1Player1 += 1;
                        breaksSet1Player2 += 1;
                    }
                    else if (pointsPlayer2 == 40 && pointsPlayer1 == 0)
                    {
                        breaksSavedSet1Player1 += 1;
                        breaksSet1Player2 += 1;
                    }
                }
            }
        }

        //Count breaks player 2.
        private void CountBreaksPlayer2()
        {
            if (set2Won == true)
            {
                if (servePlayer1 == true)
                {
                    if (pointsPlayer1 == 40 && pointsPlayer2 == 40)
                        breaksSet3Player2 += 1;
                    else if (pointsPlayer1 == 30 && pointsPlayer2 == 30)
                        breaksSet3Player2 += 1;
                    else if (pointsPlayer1 == 15 && pointsPlayer2 == 30)
                        breaksSet3Player2 += 1;
                    else if (pointsPlayer1 == 0 && pointsPlayer2 == 30)
                        breaksSet3Player2 += 1;
                }
                else if (servePlayer2 == true)
                {
                    if (adPlayer1 == true)
                        breaksSavedSet3Player2 += 1;
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 30)
                        breaksSavedSet3Player2 += 1;
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 15)
                    {
                        breaksSavedSet3Player2 += 1;
                        breaksSet3Player1 += 1;
                    }
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 0)
                    {
                        breaksSavedSet3Player2 += 1;
                        breaksSet3Player1 += 1;
                    }
                }

            }
            else if (set1Won == true)
            {
                if (servePlayer1 == true)
                {
                    if (pointsPlayer1 == 40 && pointsPlayer2 == 40)
                        breaksSet2Player2 += 1;
                    else if (pointsPlayer1 == 30 && pointsPlayer2 == 30)
                        breaksSet2Player2 += 1;
                    else if (pointsPlayer1 == 15 && pointsPlayer2 == 30)
                        breaksSet2Player2 += 1;
                    else if (pointsPlayer1 == 0 && pointsPlayer2 == 30)
                        breaksSet2Player2 += 1;
                }
                else if (servePlayer2 == true)
                {
                    if (adPlayer1 == true)
                        breaksSavedSet2Player2 += 1;
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 30)
                        breaksSavedSet2Player2 += 1;
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 15)
                    {
                        breaksSavedSet2Player2 += 1;
                        breaksSet2Player1 += 1;
                    }
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 0)
                    {
                        breaksSavedSet2Player2 += 1;
                        breaksSet2Player1 += 1;
                    }
                }
            }
            else
            {
                if (servePlayer1 == true)
                {
                    if (pointsPlayer1 == 40 && pointsPlayer2 == 40)
                        breaksSet1Player2 += 1;
                    else if (pointsPlayer1 == 30 && pointsPlayer2 == 30)
                        breaksSet1Player2 += 1;
                    else if (pointsPlayer1 == 15 && pointsPlayer2 == 30)
                        breaksSet1Player2 += 1;
                    else if (pointsPlayer1 == 0 && pointsPlayer2 == 30)
                        breaksSet1Player2 += 1;
                }
                else if (servePlayer2 == true)
                {
                    if (adPlayer1 == true)
                        breaksSavedSet1Player2 += 1;
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 30)
                        breaksSavedSet1Player2 += 1;
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 15)
                    {
                        breaksSavedSet1Player2 += 1;
                        breaksSet1Player1 += 1;
                    }
                    else if (pointsPlayer1 == 40 && pointsPlayer2 == 0)
                    {
                        breaksSavedSet1Player2 += 1;
                        breaksSet1Player1 += 1;
                    }
                }
            }

        }

        //Fault player 1.
        private void faultPlayer1Button_Click(object sender, EventArgs e)
        {
            fault = true;
            if (set2Won == true)
                faultSet3Player1 += 1;
            else if (set1Won == true)
                faultSet2Player1 += 1;
            else
                faultSet1Player1 += 1;
            faultPlayer1Button.Enabled = false;
            doubleFaultPlayer1Button.Enabled = true;
            Calculateresults();
        }

        //Fault player 2.
        private void faultPlayer2Button_Click(object sender, EventArgs e)
        {
            fault = true;
            if (set2Won == true)
                faultSet3Player2 += 1;
            else if (set1Won == true)
                faultSet2Player2 += 1;
            else
                faultSet1Player2 += 1;
            faultPlayer2Button.Enabled = false;
            doubleFaultPlayer2Button.Enabled = true;
        }

        //Double fault player 1
        private void doubleFaultPlayer1Button_Click(object sender, EventArgs e)
        {
            fault = false;
            GetBreakPointWonPlayer2();
            CountBreaksPlayer2();
            if (pointsPlayer1 < 40 && pointsPlayer2 == 40 || adPlayer2 == true)
            {
                acePlayer2Button.Enabled = true;
                faultPlayer2Button.Enabled = true;
                acePlayer1Button.Enabled = false;
                faultPlayer1Button.Enabled = false;
                doubleFaultPlayer1Button.Enabled = false;

            }
            else
            {
                acePlayer1Button.Enabled = true;
                faultPlayer1Button.Enabled = true;
                doubleFaultPlayer1Button.Enabled = false;
            }
            
            if (set2Won == true)
            {
                doubleFaultSet3Player1 += 1;
                pointWonReturning2ndServeSet3Player2 += 1;
            }
            else if (set1Won == true)
            {
                doubleFaultSet2Player1 += 1;
                pointWonReturning2ndServeSet2Player2 += 1;
            }
            else
            {
                doubleFaultSet1Player1 += 1;
                pointWonReturning2ndServeSet1Player2 += 1;
            }
            CheckPlayer2();
        }

        //Double fault player 2
        private void doubleFaultPlayer2Button_Click(object sender, EventArgs e)
        {
            fault = false;
            GetBreakPointWonPlayer1();
            CountBreaksPlayer1();
            if (pointsPlayer2 < 40 && pointsPlayer1 == 40 || adPlayer1 == true)
            {
                acePlayer1Button.Enabled = true;
                faultPlayer1Button.Enabled = true;
                acePlayer2Button.Enabled = false;
                faultPlayer2Button.Enabled = false;
                doubleFaultPlayer2Button.Enabled = false;

            }
            else
            {
                acePlayer2Button.Enabled = true;
                faultPlayer2Button.Enabled = true;
                doubleFaultPlayer2Button.Enabled = false;
            }
            
            if (set2Won == true)
            {
                doubleFaultSet3Player2 += 1;
                pointWonReturning2ndServeSet3Player1 += 1;
            }
            else if (set1Won == true)
            {
                doubleFaultSet2Player2 += 1;
                pointWonReturning2ndServeSet2Player1 += 1;
            }
            else
            {
                doubleFaultSet1Player2 += 1;
                pointWonReturning2ndServeSet1Player1 += 1;
            }
            CheckPlayer1();
        }

        //Winner player 1.
        private void winnerPlayer1Button_Click(object sender, EventArgs e)
        {
            winner = true;
            GetPointsWonAtTheNetPlayer1();
            GetPointsWonReturn2ndServeWinnerPlayer1();
            GetBreakPointWonPlayer1();
            CountBreaksPlayer1();
            if (servePlayer1 == true)
            {
                if (approachPlayer1 == true || approachPlayer1 == true && approachPlayer2 == true)
                {
                    if (pointsPlayer1 < 40 && pointsPlayer2 == 40 || adPlayer2 == true)
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                    else if (pointsPlayer2 < 40 && pointsPlayer1 == 40 || adPlayer1 == true)
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        acePlayer1Button.Enabled = false;
                        faultPlayer1Button.Enabled = false;
                        approachPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                }
                else if (approachPlayer2 == true)
                {
                    approachPlayer1Button.Enabled = false;
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player1 += 1;
                    else if (set1Won == true)
                        winnersSet2Player1 += 1;
                    else
                        winnersSet1Player1 += 1;
                }
                else
                {
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player1 += 1;
                    else if (set1Won == true)
                        winnersSet2Player1 += 1;
                    else
                        winnersSet1Player1 += 1;
                }
            }
            else if (servePlayer2 == true)
            {
                if (approachPlayer1 == true || approachPlayer1 == true && approachPlayer2 == true)
                {
                    approachPlayer1 = false;
                    approachPlayer2 = false;
                    acePlayer2Button.Enabled = true;
                    faultPlayer2Button.Enabled = true;
                    doubleFaultPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = true;
                    approachPlayer2Button.Enabled = true;
                }
                else if (approachPlayer2 == true)
                {
                    approachPlayer1Button.Enabled = false;
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player1 += 1;
                    else if (set1Won == true)
                        winnersSet2Player1 += 1;
                    else
                        winnersSet1Player1 += 1;
                }
                else
                {
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer2Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player1 += 1;
                    else if (set1Won == true)
                        winnersSet2Player1 += 1;
                    else
                        winnersSet1Player1 += 1;
                }
            }
            CheckPointsWon1st2ndServesPlayer1();
            CheckPlayer1();
        }

        //Winner player 2.
        private void winnerPlayer2Button_Click(object sender, EventArgs e)
        {
            winner = true;
            GetPointsWonAtTheNetPlayer2();
            GetPointsWonReturn2ndServeWinnerPlayer2();
            GetBreakPointWonPlayer2();
            CountBreaksPlayer2();
            if (servePlayer2 == true)
            {
                if (approachPlayer2 == true || approachPlayer2 == true && approachPlayer1 == true)
                {
                    if (pointsPlayer2 < 40 && pointsPlayer1 == 40 || adPlayer1 == true)
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else if (pointsPlayer1 < 40 && pointsPlayer2 == 40 || adPlayer2 == true)
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        acePlayer2Button.Enabled = false;
                        faultPlayer2Button.Enabled = false;
                        approachPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                }
                else if (approachPlayer1 == true)
                {
                    approachPlayer2Button.Enabled = false;
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player2 += 1;
                    else if (set1Won == true)
                        winnersSet2Player2 += 1;
                    else
                        winnersSet1Player2 += 1;

                }
                else
                {
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    doubleFaultPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player2 += 1;
                    else if (set1Won == true)
                        winnersSet2Player2 += 1;
                    else
                        winnersSet1Player2 += 1;
                }
            }
            else if (servePlayer1 == true)
            {
                if (approachPlayer2 == true || approachPlayer2 == true && approachPlayer1 == true)
                {
                    approachPlayer2 = false;
                    approachPlayer1 = false;
                    acePlayer1Button.Enabled = true;
                    faultPlayer1Button.Enabled = true;
                    approachPlayer2Button.Enabled = true;
                    approachPlayer1Button.Enabled = true;
                }
                else if (approachPlayer1 == true)
                {
                    approachPlayer2Button.Enabled = false;
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player2 += 1;
                    else if (set1Won == true)
                        winnersSet2Player2 += 1;
                    else
                        winnersSet1Player2 += 1;
                }
                else
                {
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        winnersSet3Player2 += 1;
                    else if (set1Won == true)
                        winnersSet2Player2 += 1;
                    else
                        winnersSet1Player2 += 1;
                }
            }
            CheckPointsWon1st2ndServesPlayer2();
            CheckPlayer2();
        }

        //Unforced error player 1.
        private void unfErrorPlayer1Button_Click(object sender, EventArgs e)
        {
            unforcedError = true;
            GetPointsWonAtTheNetPlayer2();
            GetPointsWonReturn2ndServeErrorsPlayer2();
            GetBreakPointWonPlayer2();
            CountBreaksPlayer2();
            if (servePlayer1 == true)
            {
                if (approachPlayer1 == true || approachPlayer1 == true && approachPlayer2 == true)
                {
                    if (pointsPlayer1 < 40 && pointsPlayer2 == 40 || adPlayer2 == true)
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                }
                else if (approachPlayer2 == true)
                {
                    approachPlayer1Button.Enabled = false;
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player1 += 1;
                    else
                        unforcedErrorsSet1Player1 += 1;
                }
                else
                {
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player1 += 1;
                    else
                        unforcedErrorsSet1Player1 += 1;
                }
            }
            else if (servePlayer2 == true)
            {
                if (approachPlayer1 == true || approachPlayer1 == true && approachPlayer2 == true)
                {
                    if (pointsPlayer1 < 40 && pointsPlayer2 == 40 || adPlayer2 == true)
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                }
                else if (approachPlayer2 == true)
                {
                    approachPlayer1Button.Enabled = false;
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player1 += 1;
                    else
                        unforcedErrorsSet1Player1 += 1;
                }
                else
                {
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer2Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player1 += 1;
                    else
                        unforcedErrorsSet1Player1 += 1;
                }
            }
            CheckPointsWon1st2ndServesPlayer2();
            CheckPlayer2();
        }

        //Unforced error player 2
        private void unfErrorPlayer2Button_Click(object sender, EventArgs e)
        {
            unforcedError = true;
            GetPointsWonAtTheNetPlayer1();
            GetPointsWonReturn2ndServeErrorsPlayer1();
            GetBreakPointWonPlayer1();
            CountBreaksPlayer1();
            if (servePlayer2 == true)
            {
                if (approachPlayer2 == true || approachPlayer2 == true && approachPlayer1 == true)
                {
                    if (pointsPlayer2 < 40 && pointsPlayer1 == 40 || adPlayer1 == true)
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                }
                else if (approachPlayer1 == true)
                {
                    approachPlayer2Button.Enabled = false;
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player2 += 1;
                    else
                        unforcedErrorsSet1Player2 += 1;

                }
                else
                {
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    doubleFaultPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player2 += 1;
                    else
                        unforcedErrorsSet1Player2 += 1;
                }
            }
            else if (servePlayer1 == true)
            {
                if (approachPlayer2 == true || approachPlayer2 == true && approachPlayer1 == true)
                {
                    if (pointsPlayer2 < 40 && pointsPlayer1 == 40 || adPlayer1 == true)
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }

                }
                else if (approachPlayer1 == true)
                {
                    approachPlayer2Button.Enabled = false;
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player2 += 1;
                    else
                        unforcedErrorsSet1Player2 += 1;
                }
                else
                {
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer2Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        unforcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        unforcedErrorsSet2Player2 += 1;
                    else
                        unforcedErrorsSet1Player2 += 1;
                }
            }
            CheckPointsWon1st2ndServesPlayer1();
            CheckPlayer1();
        }

        //Forced error player 1
        private void forcedErrorPlayer1Button_Click(object sender, EventArgs e)
        {
            forcedError = true;
            GetPointsWonAtTheNetPlayer2();
            GetPointsWonReturn2ndServeErrorsPlayer2();
            GetBreakPointWonPlayer2();
            CountBreaksPlayer2();
            if (servePlayer1 == true)
            {
                if (approachPlayer1 == true || approachPlayer1 == true && approachPlayer2 == true)
                {
                    if (pointsPlayer1 < 40 && pointsPlayer2 == 40 || adPlayer2 == true)
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }

                }
                else if (approachPlayer2 == true)
                {
                    approachPlayer1Button.Enabled = false;
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player1 += 1;
                    else
                        forcedErrorsSet1Player1 += 1;

                }
                else
                {
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player1 += 1;
                    else
                        forcedErrorsSet1Player1 += 1;
                }
            }
            else if (servePlayer2 == true)
            {
                if (approachPlayer1 == true || approachPlayer1 == true && approachPlayer2 == true)
                {
                    if (pointsPlayer1 < 40 && pointsPlayer2 == 40 || adPlayer2 == true)
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer1 = false;
                        approachPlayer2 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                }
                else if (approachPlayer2 == true)
                {
                    approachPlayer1Button.Enabled = false;
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player1 += 1;
                    else
                        forcedErrorsSet1Player1 += 1;
                }
                else
                {
                    forePlayer1Button.Enabled = true;
                    backPlayer1Button.Enabled = true;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer2Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player1 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player1 += 1;
                    else
                        forcedErrorsSet1Player1 += 1;
                }
            }
            CheckPointsWon1st2ndServesPlayer2();
            CheckPlayer2();
        }

        //Forced error player 2.
        private void forcedErrorPlayer2Button_Click(object sender, EventArgs e)
        {
            forcedError = true;
            GetPointsWonAtTheNetPlayer1();
            GetPointsWonReturn2ndServeErrorsPlayer1();
            GetBreakPointWonPlayer1();
            CountBreaksPlayer1();
            if (servePlayer2 == true)
            {
                if (approachPlayer2 == true || approachPlayer2 == true && approachPlayer1 == true)
                {
                    if (pointsPlayer2 < 40 && pointsPlayer1 == 40 || adPlayer1 == true)
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }

                }
                else if (approachPlayer1 == true)
                {
                    approachPlayer2Button.Enabled = false;
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player2 += 1;
                    else
                        forcedErrorsSet1Player2 += 1;

                }
                else
                {
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    doubleFaultPlayer2Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player2 += 1;
                    else
                        forcedErrorsSet1Player2 += 1;
                }
            }
            else if (servePlayer1 == true)
            {
                if (approachPlayer2 == true || approachPlayer2 == true && approachPlayer1 == true)
                {
                    if (pointsPlayer2 < 40 && pointsPlayer1 == 40 || adPlayer1 == true)
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else
                    {
                        approachPlayer2 = false;
                        approachPlayer1 = false;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                }
                else if (approachPlayer1 == true)
                {
                    approachPlayer2Button.Enabled = false;
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer2Button.Enabled = false;
                    faultPlayer2Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    winnerPlayer1Button.Enabled = false;
                    unfErrorPlayer1Button.Enabled = false;
                    forcedErrorPlayer1Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player2 += 1;
                    else
                        forcedErrorsSet1Player2 += 1;

                }
                else
                {
                    forePlayer2Button.Enabled = true;
                    backPlayer2Button.Enabled = true;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    acePlayer1Button.Enabled = false;
                    faultPlayer1Button.Enabled = false;
                    doubleFaultPlayer1Button.Enabled = false;
                    approachPlayer1Button.Enabled = false;
                    approachPlayer2Button.Enabled = false;
                    winnerPlayer2Button.Enabled = false;
                    unfErrorPlayer2Button.Enabled = false;
                    forcedErrorPlayer2Button.Enabled = false;
                    if (set2Won == true)
                        forcedErrorsSet3Player2 += 1;
                    else if (set1Won == true)
                        forcedErrorsSet2Player2 += 1;
                    else
                        forcedErrorsSet1Player2 += 1;

                }
            }
            CheckPointsWon1st2ndServesPlayer1();
            CheckPlayer1();
        }

        //Forehand player 1
        private void forePlayer1Button_Click(object sender, EventArgs e)
        {
            fault = false;
            if (servePlayer1 == true)
            {
                forePlayer1Button.Enabled = false;
                backPlayer1Button.Enabled = false;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
                acePlayer1Button.Enabled = true;
                faultPlayer1Button.Enabled = true;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
            }
            else if (servePlayer2 == true)
            {
                forePlayer1Button.Enabled = false;
                backPlayer1Button.Enabled = false;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
                acePlayer2Button.Enabled = true;
                faultPlayer2Button.Enabled = true;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
            }
            if (winner == true)
            {
                winner = false;
                if (set2Won == true)
                    forehandWinnersSet3Player1 += 1;
                else if (set1Won == true)
                    forehandWinnersSet2Player1 += 1;
                else
                {
                    forehandWinnersSet1Player1 += 1;
                }
                CheckPlayer1();

            }
            else if (unforcedError == true)
            {
                unforcedError = false;
                if (set2Won == true)
                    forehandUnforcedErrorsSet3Player1 += 1;
                else if (set1Won == true)
                    forehandUnforcedErrorsSet2Player1 += 1;
                else
                {
                    forehandUnforcedErrorsSet1Player1 += 1;
                }

            }
            else if (forcedError == true)
            {
                forcedError = false;
                if (set2Won == true)
                    forehandForcedErrorsSet3Player1 += 1;
                else if (set1Won == true)
                    forehandForcedErrorsSet2Player1 += 1;
                else
                {
                    forehandForcedErrorsSet1Player1 += 1;
                }

            }
            approachPlayer1Button.Enabled = true;
            approachPlayer2Button.Enabled = true;
            approachPlayer1 = false;
            approachPlayer2 = false;

        }

        //Backhand player 1
        private void backPlayer1Button_Click(object sender, EventArgs e)
        {
            fault = false;
            if (servePlayer1 == true)
            {
                forePlayer1Button.Enabled = false;
                backPlayer1Button.Enabled = false;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
                acePlayer1Button.Enabled = true;
                faultPlayer1Button.Enabled = true;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
            }
            else if (servePlayer2 == true)
            {
                forePlayer1Button.Enabled = false;
                backPlayer1Button.Enabled = false;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
                acePlayer2Button.Enabled = true;
                faultPlayer2Button.Enabled = true;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
            }
            if (winner == true)
            {
                winner = false;
                if (set2Won == true)
                    backhandWinnersSet3Player1 += 1;
                else if (set1Won == true)
                    backhandWinnersSet2Player1 += 1;
                else
                {
                    backhandWinnersSet1Player1 += 1;
                }

            }
            else if (unforcedError == true)
            {
                unforcedError = false;
                if (set2Won == true)
                    backhandUnforcedErrorsSet3Player1 += 1;
                else if (set1Won == true)
                    backhandUnforcedErrorsSet2Player1 += 1;
                else
                {
                    backhandUnforcedErrorsSet1Player1 += 1;
                }
                CheckPlayer2();

            }
            else if (forcedError == true)
            {
                forcedError = false;
                if (set2Won == true)
                    backhandForcedErrorsSet3Player1 += 1;
                else if (set1Won == true)
                    forehandForcedErrorsSet2Player1 += 1;
                else
                {
                    backhandForcedErrorsSet1Player1 += 1;
                }

            }
            approachPlayer2Button.Enabled = true;
            approachPlayer1Button.Enabled = true;
            approachPlayer1 = false;
            approachPlayer2 = false;
        }

        //Forehand player 2
        private void forePlayer2Button_Click(object sender, EventArgs e)
        {
            fault = false;
            if (servePlayer2 == true)
            {
                forePlayer2Button.Enabled = false;
                backPlayer2Button.Enabled = false;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
                acePlayer2Button.Enabled = true;
                faultPlayer2Button.Enabled = true;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
            }
            else if (servePlayer1 == true)
            {
                forePlayer2Button.Enabled = false;
                backPlayer2Button.Enabled = false;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
                acePlayer1Button.Enabled = true;
                faultPlayer1Button.Enabled = true;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
            }
            if (winner == true)
            {
                winner = false;
                if (set2Won == true)
                    forehandWinnersSet3Player2 += 1;
                else if (set1Won == true)
                    forehandWinnersSet2Player2 += 1;
                else
                {
                    forehandWinnersSet1Player2 += 1;
                }

            }
            else if (unforcedError == true)
            {
                unforcedError = false;
                if (set2Won == true)
                    forehandUnforcedErrorsSet3Player2 += 1;
                else if (set1Won == true)
                    forehandUnforcedErrorsSet2Player2 += 1;
                else
                {
                    forehandUnforcedErrorsSet1Player2 += 1;
                }
                CheckPlayer1();

            }
            else if (forcedError == true)
            {
                forcedError = false;
                if (set2Won == true)
                    forehandForcedErrorsSet3Player2 += 1;
                else if (set1Won == true)
                    forehandForcedErrorsSet2Player2 += 1;
                else
                {
                    forehandForcedErrorsSet1Player2 += 1;
                }

            }
            approachPlayer2Button.Enabled = true;
            approachPlayer1Button.Enabled = true;
            approachPlayer1 = false;
            approachPlayer2 = false;
        }

        //Backhand player 2.
        private void backPlayer2Button_Click(object sender, EventArgs e)
        {
            fault = false;
            if (servePlayer2 == true)
            {
                forePlayer2Button.Enabled = false;
                backPlayer2Button.Enabled = false;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
                acePlayer2Button.Enabled = true;
                faultPlayer2Button.Enabled = true;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
            }
            else if (servePlayer1 == true)
            {
                forePlayer2Button.Enabled = false;
                backPlayer2Button.Enabled = false;
                winnerPlayer2Button.Enabled = true;
                unfErrorPlayer2Button.Enabled = true;
                forcedErrorPlayer2Button.Enabled = true;
                acePlayer1Button.Enabled = true;
                faultPlayer1Button.Enabled = true;
                winnerPlayer1Button.Enabled = true;
                unfErrorPlayer1Button.Enabled = true;
                forcedErrorPlayer1Button.Enabled = true;
            }
            if (winner == true)
            {
                winner = false;
                if (set2Won == true)
                    backhandWinnersSet3Player2 += 1;
                else if (set1Won == true)
                    backhandWinnersSet2Player2 += 1;
                else
                {
                    backhandWinnersSet1Player2 += 1;
                }

            }
            else if (unforcedError == true)
            {
                unforcedError = false;
                if (set2Won == true)
                    backhandUnforcedErrorsSet3Player2 += 1;
                else if (set1Won == true)
                    backhandUnforcedErrorsSet2Player2 += 1;
                else
                {
                    backhandUnforcedErrorsSet1Player2 += 1;
                }
                CheckPlayer1();

            }
            else if (forcedError == true)
            {
                forcedError = false;
                if (set2Won == true)
                    backhandForcedErrorsSet3Player2 += 1;
                else if (set1Won == true)
                    forehandForcedErrorsSet2Player2 += 1;
                else
                {
                    backhandForcedErrorsSet1Player2 += 1;
                }

            }
            approachPlayer2Button.Enabled = true;
            approachPlayer1Button.Enabled = true;
            approachPlayer1 = false;
            approachPlayer2 = false;
        }

        //Activate and count approach player 1.
        private void approachPlayer1Button_Click(object sender, EventArgs e)
        {
            approachPlayer1 = true;
            approachPlayer1Button.Enabled = false;
            if (servePlayer1 == true)
            {
                acePlayer1Button.Enabled = false;
                faultPlayer1Button.Enabled = false;
                doubleFaultPlayer1Button.Enabled = false;
            }
            else if (servePlayer2 == true)
            {
                acePlayer2Button.Enabled = false;
                faultPlayer2Button.Enabled = false;
                doubleFaultPlayer2Button.Enabled = false;
            }
            if (set2Won == true)
                approachSet3Player1 += 1;
            else if (set1Won == true)
                approachSet2Player1 += 1;
            else
                approachSet1Player1 += 1;
        }

        //Activate and count approach player 2.
        private void approachPlayer2Button_Click(object sender, EventArgs e)
        {
            approachPlayer2 = true;
            approachPlayer2Button.Enabled = false;
            if (servePlayer2 == true)
            {
                acePlayer2Button.Enabled = false;
                faultPlayer2Button.Enabled = false;
                doubleFaultPlayer2Button.Enabled = false;
            }
            else if (servePlayer1 == true)
            {
                acePlayer1Button.Enabled = false;
                faultPlayer1Button.Enabled = false;
                doubleFaultPlayer1Button.Enabled = false;
            }
            if (set2Won == true)
                approachSet3Player2 += 1;
            else if (set1Won == true)
                approachSet2Player2 += 1;
            else
                approachSet1Player2 += 1;
        }

       
        //Check if approach is true and count per set.
        private void CheckApproachesPlayer1()
        {
            if (approachPlayer1 == true)
            {
                if (set2Won == true)
                    pointsWonNetSet3Player1 += 1;
                else if (set1Won == true)
                    pointsWonNetSet2Player1 += 1;
                else
                    pointsWonNetSet1Player1 += 1;
            }
            approachPlayer1 = false;
            approachPlayer1Button.Enabled = true;
        }

        //Check if approach is true and count per set.
        private void CheckApproachesPlayer2()
        {
            if (approachPlayer2 == true)
            {
                if (set2Won == true)
                    pointsWonNetSet3Player2 += 1;
                else if (set1Won == true)
                    pointsWonNetSet2Player2 += 1;
                else
                    pointsWonNetSet1Player2 += 1;
            }
            approachPlayer2 = false;
            approachPlayer2Button.Enabled = true;
        }

        //Start match time, disable info text box and enable scout buttons
        private void startMatchButton_Click_1(object sender, EventArgs e)
        {
            if (player1FirstNameTextBox.Text == "" || player2FirstNameTextBox.Text == ""
                || player1LastNameTextBox.Text == "" || player2LastNameTextBox.Text == "")
            {
                MessageBox.Show("You must enter the player's names!", "Missing Entry",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (startServingPlayer1RadioButton.Checked == false && startServingPlayer2RadioButton.Checked == false)
                {
                    MessageBox.Show("You must choose a player to start serving!", "Choose Server",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    timer1.Start();
                    sw.Start();
                    firstNamePlayer1 = player1FirstNameTextBox.Text;
                    firstNamePlayer2 = player2FirstNameTextBox.Text;
                    lastNamePlayer1 = player1LastNameTextBox.Text;
                    lastNamePlayer2 = player2LastNameTextBox.Text;
                    player1Label.Text = firstNamePlayer1[0] + ". " + lastNamePlayer1;
                    player2Label.Text = firstNamePlayer2[0] + ". " + lastNamePlayer2;

                    //Disable info text boxes.
                    player1FirstNameTextBox.Enabled = false;
                    player1LastNameTextBox.Enabled = false;
                    schoolPlayer1TextBox.Enabled = false;
                    startServingPlayer1RadioButton.Enabled = false;
                    player2FirstNameTextBox.Enabled = false;
                    player2LastNameTextBox.Enabled = false;
                    schoolPlayer2TextBox.Enabled = false;
                    startServingPlayer2RadioButton.Enabled = false;
                    localTextBox.Enabled = false;
                    dateTimePicker.Enabled = false;
                    surfaceTextBox.Enabled = false;
                    startMatchButton.Enabled = false;
                    statsButton.Enabled = true;
                    if (startServing1 == true)
                    {
                        approachPlayer1Button.Enabled = true;
                        winnerPlayer1Button.Enabled = true;
                        unfErrorPlayer1Button.Enabled = true;
                        forcedErrorPlayer1Button.Enabled = true;
                        acePlayer1Button.Enabled = true;
                        faultPlayer1Button.Enabled = true;
                        winnerPlayer2Button.Enabled = true;
                        unfErrorPlayer2Button.Enabled = true;
                        forcedErrorPlayer2Button.Enabled = true;
                        approachPlayer2Button.Enabled = true;
                    }
                    else if (startServing2 == true)
                    {
                        approachPlayer2Button.Enabled = true;
                        winnerPlayer2Button.Enabled = true;
                        unfErrorPlayer2Button.Enabled = true;
                        forcedErrorPlayer2Button.Enabled = true;
                        acePlayer2Button.Enabled = true;
                        faultPlayer2Button.Enabled = true;
                        winnerPlayer1Button.Enabled = true;
                        unfErrorPlayer1Button.Enabled = true;
                        forcedErrorPlayer1Button.Enabled = true;
                        approachPlayer1Button.Enabled = true;
                    }
                }
            }

        }

        //check for points won with first or second serve player 1.
        private void CheckPointsWon1st2ndServesPlayer1()
        {
            if (servePlayer1 == true && fault == true)
            {
                if (set2Won == true)
                    pointWon2ServeSet3Player1 += 1;
                else if (set1Won == true)
                    pointWon2ServeSet2Player1 += 1;
                else
                    pointWon2ServeSet1Player1 += 1;
            }
            else if (servePlayer1 == true && fault == false)
            {
                if (set2Won == true)
                    pointWon1ServeSet3Player1 += 1;
                else if (set1Won == true)
                    pointWon1ServeSet2Player1 += 1;
                else
                    pointWon1ServeSet1Player1 += 1;
            }
        }

        //check for points won with first or second serve player 2.
        private void CheckPointsWon1st2ndServesPlayer2()
        {
            if (servePlayer2 == true && fault == true)
            {
                if (set2Won == true)
                    pointWon2ServeSet3Player2 += 1;
                else if (set1Won == true)
                    pointWon2ServeSet2Player2 += 1;
                else
                    pointWon2ServeSet1Player2 += 1;
            }
            else if (servePlayer2 == true && fault == false)
            {
                if (set2Won == true)
                    pointWon1ServeSet3Player2 += 1;
                else if (set1Won == true)
                    pointWon1ServeSet2Player2 += 1;
                else
                    pointWon1ServeSet1Player2 += 1;
            }
        }

        //Close the program.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close this program.
            this.Close();
        }

        //Get games served.
        private void GamesServed()
        {
            if (servePlayer1 == true)
            {
                if (set2Won == true)
                    gamesServedSet3Player1 += 1;
                else if (set1Won == true)
                    gamesServedSet2Player1 += 1;
                else
                    gamesServedSet1Player1 += 1;
            }
            else if (servePlayer2 == true)
            {
                if (set2Won == true)
                    gamesServedSet3Player2 += 1;
                else if (set1Won == true)
                    gamesServedSet2Player2 += 1;
                else
                    gamesServedSet1Player2 += 1;
            }
        }

        //Calculate results to stats form.
        public void Calculateresults()
        {
            //CALCULUS FOR 1ST SET
            //First serve in player 1 Set 1.
            firstServeInSet1Player1 = numberOfServesSet1Player1 - faultSet1Player1;
            percentFirstServeSet1Player1 = (int)(((double)firstServeInSet1Player1 / (double)numberOfServesSet1Player1) * 100);

            //First serve in player 1 Set 2.
            firstServeInSet2Player1 = numberOfServesSet2Player1 - faultSet2Player1;
            percentFirstServeSet2Player1 = (int)(((double)firstServeInSet2Player1 / (double)numberOfServesSet2Player1) * 100);

            //First serve in player 1 Set 3.
            firstServeInSet3Player1 = numberOfServesSet3Player1 - faultSet3Player1;
            percentFirstServeSet3Player1 = (int)(((double)firstServeInSet3Player1 / (double)numberOfServesSet3Player1) * 100);
            //End player1

            //First serve in player 2 Set 1
            firstServeInSet1Player2 = numberOfServesSet1Player2 - faultSet1Player2;
            percentFirstServeSet1Player2 = (int)(((double)firstServeInSet1Player2 / (double)numberOfServesSet1Player2) * 100);

            //First serve in player 2 Set 2
            firstServeInSet2Player2 = numberOfServesSet2Player2 - faultSet2Player2;
            percentFirstServeSet2Player2 = (int)(((double)firstServeInSet2Player2 / (double)numberOfServesSet2Player2) * 100);

            //First serve in player 2 Set 3
            firstServeInSet3Player2 = numberOfServesSet3Player2 - faultSet3Player2;
            percentFirstServeSet3Player2 = (int)(((double)firstServeInSet3Player2 / (double)numberOfServesSet3Player2) * 100);
            //End player 2

            //Points won 1st serve player1
            percentPointsWon1stServeSet1Player1 = (int)(((double)pointWon1ServeSet1Player1 /
                (double)firstServeInSet1Player1) * 100);
            //Points won 1st serve player 2
            percentPointsWon1stServeSet1Player2 = (int)(((double)pointWon1ServeSet1Player2 /
                (double)firstServeInSet1Player2) * 100);

            //Points won 2nd serve player1
            secondServeInSet1Player1 = faultSet1Player1 - doubleFaultSet1Player1;
            percentPointsWon2ndServeSet1Player1 = (int)(((double)pointWon2ServeSet1Player1 /
                (double)secondServeInSet1Player1) * 100);
            //Points won 2nd serve player 2
            secondServeInSet1Player2 = faultSet1Player2 - doubleFaultSet1Player2;
            percentPointsWon2ndServeSet1Player2 = (int)(((double)pointWon2ServeSet1Player2 /
                (double)secondServeInSet1Player2) * 100);

            //Breaks saved player 1.
            percentBreaksSavedSet1Player1 = (int)(((double)breaksSavedSet1Player1 /
                (double)breaksSet1Player2) * 100);
            percentBreaksSavedSet1Player2 = (int)(((double)breaksSavedSet1Player2 /
               (double)breaksSet1Player1) * 100);

            //CALCULUS FOR 2ND SET
            //First serve in player 1 Set 1.
            firstServeInSet2Player1 = numberOfServesSet2Player1 - faultSet2Player1;
            percentFirstServeSet2Player1 = (int)(((double)firstServeInSet2Player1 / (double)numberOfServesSet2Player1) * 100);

            //First serve in player 1 Set 2.
            firstServeInSet2Player1 = numberOfServesSet2Player1 - faultSet2Player1;
            percentFirstServeSet2Player1 = (int)(((double)firstServeInSet2Player1 / (double)numberOfServesSet2Player1) * 100);

            //First serve in player 1 Set 3.
            firstServeInSet3Player1 = numberOfServesSet3Player1 - faultSet3Player1;
            percentFirstServeSet3Player1 = (int)(((double)firstServeInSet3Player1 / (double)numberOfServesSet3Player1) * 100);
            //End player1

            //First serve in player 2 Set 1
            firstServeInSet2Player2 = numberOfServesSet2Player2 - faultSet2Player2;
            percentFirstServeSet2Player2 = (int)(((double)firstServeInSet2Player2 / (double)numberOfServesSet2Player2) * 100);

            //First serve in player 2 Set 2
            firstServeInSet2Player2 = numberOfServesSet2Player2 - faultSet2Player2;
            percentFirstServeSet2Player2 = (int)(((double)firstServeInSet2Player2 / (double)numberOfServesSet2Player2) * 100);

            //First serve in player 2 Set 3
            firstServeInSet3Player2 = numberOfServesSet3Player2 - faultSet3Player2;
            percentFirstServeSet3Player2 = (int)(((double)firstServeInSet3Player2 / (double)numberOfServesSet3Player2) * 100);
            //End player 2

            //Points won 1st serve player1
            percentPointsWon1stServeSet2Player1 = (int)(((double)pointWon1ServeSet2Player1 /
                (double)firstServeInSet2Player1) * 100);
            //Points won 1st serve player 2
            percentPointsWon1stServeSet2Player2 = (int)(((double)pointWon1ServeSet2Player2 /
                (double)firstServeInSet2Player2) * 100);

            //Points won 2nd serve player1
            secondServeInSet2Player1 = faultSet2Player1 - doubleFaultSet2Player1;
            percentPointsWon2ndServeSet2Player1 = (int)(((double)pointWon2ServeSet2Player1 /
                (double)secondServeInSet2Player1) * 100);
            //Points won 2nd serve player 2
            secondServeInSet2Player2 = faultSet2Player2 - doubleFaultSet2Player2;
            percentPointsWon2ndServeSet2Player2 = (int)(((double)pointWon2ServeSet2Player2 /
                (double)secondServeInSet2Player2) * 100);

            //Breaks saved player 1.
            percentBreaksSavedSet2Player1 = (int)(((double)breaksSavedSet2Player1 /
                (double)breaksSet2Player2) * 100);
            percentBreaksSavedSet2Player2 = (int)(((double)breaksSavedSet2Player2 /
               (double)breaksSet2Player1) * 100);

            //CALCULUS FOR 3RD SET
            //First serve in player 1 Set 1.
            firstServeInSet3Player1 = numberOfServesSet3Player1 - faultSet3Player1;
            percentFirstServeSet3Player1 = (int)(((double)firstServeInSet3Player1 / (double)numberOfServesSet3Player1) * 100);

            //First serve in player 1 Set 2.
            firstServeInSet3Player1 = numberOfServesSet3Player1 - faultSet3Player1;
            percentFirstServeSet3Player1 = (int)(((double)firstServeInSet3Player1 / (double)numberOfServesSet3Player1) * 100);

            //First serve in player 1 Set 3.
            firstServeInSet3Player1 = numberOfServesSet3Player1 - faultSet3Player1;
            percentFirstServeSet3Player1 = (int)(((double)firstServeInSet3Player1 / (double)numberOfServesSet3Player1) * 100);
            //End player1

            //First serve in player 2 Set 1
            firstServeInSet3Player2 = numberOfServesSet3Player2 - faultSet3Player2;
            percentFirstServeSet3Player2 = (int)(((double)firstServeInSet3Player2 / (double)numberOfServesSet3Player2) * 100);

            //First serve in player 2 Set 2
            firstServeInSet3Player2 = numberOfServesSet3Player2 - faultSet3Player2;
            percentFirstServeSet3Player2 = (int)(((double)firstServeInSet3Player2 / (double)numberOfServesSet3Player2) * 100);

            //First serve in player 2 Set 3
            firstServeInSet3Player2 = numberOfServesSet3Player2 - faultSet3Player2;
            percentFirstServeSet3Player2 = (int)(((double)firstServeInSet3Player2 / (double)numberOfServesSet3Player2) * 100);
            //End player 2

            //Points won 1st serve player1
            percentPointsWon1stServeSet3Player1 = (int)(((double)pointWon1ServeSet3Player1 /
                (double)firstServeInSet3Player1) * 100);
            //Points won 1st serve player 2
            percentPointsWon1stServeSet3Player2 = (int)(((double)pointWon1ServeSet3Player2 /
                (double)firstServeInSet3Player2) * 100);

            //Points won 2nd serve player1
            secondServeInSet3Player1 = faultSet3Player1 - doubleFaultSet3Player1;
            percentPointsWon2ndServeSet3Player1 = (int)(((double)pointWon2ServeSet3Player1 /
                (double)secondServeInSet3Player1) * 100);
            //Points won 2nd serve player 2
            secondServeInSet3Player2 = faultSet3Player2 - doubleFaultSet3Player2;
            percentPointsWon2ndServeSet3Player2 = (int)(((double)pointWon2ServeSet3Player2 /
                (double)secondServeInSet3Player2) * 100);

            //Breaks saved player 1.
            percentBreaksSavedSet3Player1 = (int)(((double)breaksSavedSet3Player1 /
                (double)breaksSet3Player2) * 100);
            percentBreaksSavedSet3Player2 = (int)(((double)breaksSavedSet3Player2 /
               (double)breaksSet3Player1) * 100);
        }

        //Get points won returning second serve by winners player 1.
        private void GetPointsWonReturn2ndServeWinnerPlayer1()
        {
            if (servePlayer2 == true && fault == true)
            {
                if (set2Won == true)
                    pointWonReturning2ndServeSet3Player1 += 1;
                else if (set1Won == true)
                    pointWonReturning2ndServeSet2Player1 += 1;
                else
                    pointWonReturning2ndServeSet1Player1 += 1;
            }
        }

        //Get points won returning second serve by winneers player 2
        private void GetPointsWonReturn2ndServeWinnerPlayer2()
        {
            if (servePlayer1 == true && fault == true)
            {
                if (set2Won == true)
                    pointWonReturning2ndServeSet3Player2 += 1;
                else if (set1Won == true)
                    pointWonReturning2ndServeSet2Player2 += 1;
                else
                    pointWonReturning2ndServeSet1Player2 += 1;
            }

        }

        //Get points won returning second serve by errors player 1.
        private void GetPointsWonReturn2ndServeErrorsPlayer1()
        {
            if (servePlayer2 == true && fault == true)
            {
                if (set2Won == true)
                    pointWonReturning2ndServeSet3Player1 += 1;
                else if (set1Won == true)
                    pointWonReturning2ndServeSet2Player1 += 1;
                else
                    pointWonReturning2ndServeSet1Player1 += 1;
            }
        }

        //Get points won returning second serve by errors player2.
        private void GetPointsWonReturn2ndServeErrorsPlayer2()
        {
            if (servePlayer1 == true && fault == true)
            {
                if (set2Won == true)
                    pointWonReturning2ndServeSet3Player2 += 1;
                else if (set1Won == true)
                    pointWonReturning2ndServeSet2Player2 += 1;
                else
                    pointWonReturning2ndServeSet1Player2 += 1;
            }

        }

        //Get break points won player 1.
        private void GetBreakPointWonPlayer1()
        {
            if (servePlayer2 == true)
            {
                if (adPlayer1 == true)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player1 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player1 += 1;
                    else
                        breakPointWonSet1Player1 += 1;
                }
                else if (pointsPlayer1 == 40 && pointsPlayer2 == 30)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player1 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player1 += 1;
                    else
                        breakPointWonSet1Player1 += 1;
                }
                else if (pointsPlayer1 == 40 && pointsPlayer2 == 15)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player1 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player1 += 1;
                    else
                        breakPointWonSet1Player1 += 1;
                }
                else if (pointsPlayer1 == 40 && pointsPlayer2 == 0)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player1 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player1 += 1;
                    else
                        breakPointWonSet1Player1 += 1;
                }
            }
        }

        //Get break points won player 2.
        private void GetBreakPointWonPlayer2()
        {
            if (servePlayer1 == true)
            {
                if (adPlayer2 == true)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player2 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player2 += 1;
                    else
                        breakPointWonSet1Player2 += 1;
                }
                else if (pointsPlayer2 == 40 && pointsPlayer1 == 30)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player2 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player2 += 1;
                    else
                        breakPointWonSet1Player2 += 1;
                }
                else if (pointsPlayer2 == 40 && pointsPlayer1 == 15)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player2 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player2 += 1;
                    else
                        breakPointWonSet1Player2 += 1;
                }
                else if (pointsPlayer2 == 40 && pointsPlayer1 == 0)
                {
                    if (set2Won == true)
                        breakPointWonSet3Player2 += 1;
                    else if (set1Won == true)
                        breakPointWonSet2Player2 += 1;
                    else
                        breakPointWonSet1Player2 += 1;
                }
            }
        }

        //Get points won at the net player 1.
        private void GetPointsWonAtTheNetPlayer1()
        {
            if (servePlayer1 == true && approachPlayer1 == true)
            {
                if (set2Won == true)
                    pointsWonNetSet3Player1 += 1;
                else if (set1Won == true)
                    pointsWonNetSet2Player1 += 1;
                else
                    pointsWonNetSet1Player1 += 1;
            }
            else if (servePlayer2 == true && approachPlayer1 == true)
            {
                if (set2Won == true)
                    pointsWonNetSet3Player1 += 1;
                else if (set1Won == true)
                    pointsWonNetSet2Player1 += 1;
                else
                    pointsWonNetSet1Player1 += 1;
            }
        }

        //Get points won at the net player 1.
        private void GetPointsWonAtTheNetPlayer2()
        {
            if (servePlayer2 == true && approachPlayer2 == true)
            {
                if (set2Won == true)
                    pointsWonNetSet3Player2 += 1;
                else if (set1Won == true)
                    pointsWonNetSet2Player2 += 1;
                else
                    pointsWonNetSet1Player2 += 1;
            }
            else if (servePlayer1 == true && approachPlayer2 == true)
            {
                if (set2Won == true)
                    pointsWonNetSet3Player2 += 1;
                else if (set1Won == true)
                    pointsWonNetSet2Player2 += 1;
                else
                    pointsWonNetSet1Player2 += 1;
            }
        }

        private void startServingPlayer1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = (RadioButton)sender;
            switch (selectedRadioButton.Name)
            {
                case "startServingPlayer1RadioButton":
                    startServing2 = false;
                    startServing = true;
                    startServing1 = true;
                    servePlayer1 = true;
                    pictureBox3.Visible = true;
                    servePlayer2 = false;
                    pictureBox2.Visible = false;
                    break;
                case "startServingPlayer2RadioButton":
                    startServing1 = false;
                    startServing = true;
                    startServing2 = true;
                    servePlayer2 = true;
                    pictureBox2.Visible = true;
                    servePlayer1 = false;
                    pictureBox3.Visible = false;
                    break;
            }
        }
    }
}
