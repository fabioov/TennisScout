using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TennisScoutProject
{
    public partial class StatsForm : Form
    {
        //declare timer.
        Timer RefreshTimer = new Timer();
        //Declare variables
        //Ace
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
        //Games returned
        int gamesReturnedSet1Player1 = 0;
        int gamesReturnedSet2Player1 = 0;
        int gamesReturnedSet3Player1 = 0;
        int gamesReturnedSet1Player2 = 0;
        int gamesReturnedSet2Player2 = 0;
        int gamesReturnedSet3Player2 = 0;
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

        //Variables for calculus.
        //First Serve In
        int firstServeInSet1Player1 = 0;
        int firstServeInSet2Player1 = 0;
        int firstServeInSet3Player1 = 0;
        int firstServeInSet1Player2 = 0;
        int firstServeInSet2Player2 = 0;
        int firstServeInSet3Player2 = 0;
        //2ND Serve in
        int secondServeInSet1Player1 = 0;
        int secondServeInSet2Player1 = 0;
        int secondServeInSet3Player1 = 0;
        int secondServeInSet1Player2 = 0;
        int secondServeInSet2Player2 = 0;
        int secondServeInSet3Player2 = 0;
        //Percentage 1st serve
        int percentFirstServeSet1Player1 = 0;
        int percentFirstServeSet2Player1 = 0;
        int percentFirstServeSet3Player1 = 0;
        int percentFirstServeSet1Player2 = 0;
        int percentFirstServeSet2Player2 = 0;
        int percentFirstServeSet3Player2 = 0;
        //Percentage return 1st serve
        int percentFirstServeReturnSet1Player1 = 0;
        int percentFirstServeReturnSet2Player1 = 0;
        int percentFirstServeReturnSet3Player1 = 0;
        int percentFirstServeReturnSet1Player2 = 0;
        int percentFirstServeReturnSet2Player2 = 0;
        int percentFirstServeReturnSet3Player2 = 0;
        //Percentage return 2nd serve
        int percentSecondServeReturnSet1Player1 = 0;
        int percentSecondServeReturnSet2Player1 = 0;
        int percentSecondServeReturnSet3Player1 = 0;
        int percentSecondServeReturnSet1Player2 = 0;
        int percentSecondServeReturnSet2Player2 = 0;
        int percentSecondServeReturnSet3Player2 = 0;
        //Return points won 1st serve
        int returnFirstServeWonSet1Player1 = 0;
        int returnFirstServeWonSet2Player1 = 0;
        int returnFirstServeWonSet3Player1 = 0;
        int returnFirstServeWonSet1Player2 = 0;
        int returnFirstServeWonSet2Player2 = 0;
        int returnFirstServeWonSet3Player2 = 0;

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

        //Percent breaks saved.
        int percentBreaksSavedSet1Player1 = 0;
        int percentBreaksSavedSet2Player1 = 0;
        int percentBreaksSavedSet3Player1 = 0;
        int percentBreaksSavedSet1Player2 = 0;
        int percentBreaksSavedSet2Player2 = 0;
        int percentBreaksSavedSet3Player2 = 0;

        //Percent breaks won.
        int percentBreaksWonSet1Player1 = 0;
        int percentBreaksWonSet2Player1 = 0;
        int percentBreaksWonSet3Player1 = 0;
        int percentBreaksWonSet1Player2 = 0;
        int percentBreaksWonSet2Player2 = 0;
        int percentBreaksWonSet3Player2 = 0;

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

        //Percentage of total service points won.
        int percentTotalServicePointsWonSet1Player1 = 0;
        int percentTotalServicePointsWonSet2Player1 = 0;
        int percentTotalServicePointsWonSet3Player1 = 0;
        int percentTotalServicePointsWonSet1Player2 = 0;
        int percentTotalServicePointsWonSet2Player2 = 0;
        int percentTotalServicePointsWonSet3Player2 = 0;

        //Percentage of total return points won.
        int percentTotalReturnPointsWonSet1Player1 = 0;
        int percentTotalReturnPointsWonSet2Player1 = 0;
        int percentTotalReturnPointsWonSet3Player1 = 0;
        int percentTotalReturnPointsWonSet1Player2 = 0;
        int percentTotalReturnPointsWonSet2Player2 = 0;
        int percentTotalReturnPointsWonSet3Player2 = 0;

        //Percentage of total return points won.
        int percentTotalPointsWonSet1Player1 = 0;
        int percentTotalPointsWonSet2Player1 = 0;
        int percentTotalPointsWonSet3Player1 = 0;
        int percentTotalPointsWonSet1Player2 = 0;
        int percentTotalPointsWonSet2Player2 = 0;
        int percentTotalPointsWonSet3Player2 = 0;

        //Percentage point won at the net.
        int percentPointsWonAtTheNetSet1Player1 = 0;
        int percentPointsWonAtTheNetSet2Player1 = 0;
        int percentPointsWonAtTheNetSet3Player1 = 0;
        int percentPointsWonAtTheNetSet1Player2 = 0;
        int percentPointsWonAtTheNetSet2Player2 = 0;
        int percentPointsWonAtTheNetSet3Player2 = 0;

        //Players names
        string firstNamePlayer1 = "";
        string firstNamePlayer2 = "";
        string lastNamePlayer1 = "";
        string lastNamePlayer2 = "";

        //Public the variables.
        //Ace
        public int AceSet1Player1
        {
            set
            {
                aceSet1Player1 = value;
            }
        }

        public int AceSet2Player1
        {
            set
            {
                aceSet2Player1 = value;
            }
        }

        public int AceSet3Player1
        {
            set
            {
                aceSet3Player1 = value;
            }
        }

        public int AceSet1Player2
        {
            set
            {
                aceSet1Player2 = value;
            }
        }

        public int AceSet2Player2
        {
            set
            {
                aceSet2Player2 = value;
            }
        }

        public int AceSet3Player2
        {
            set
            {
                aceSet3Player2 = value;
            }
        }

        //Faults.
        public int FaultSet1Player1
        {
            set
            {
                faultSet1Player1 = value;
            }
        }

        public int FaultSet2Player1
        {
            set
            {
                faultSet2Player1 = value;
            }
        }

        public int FaultSet3Player1
        {
            set
            {
                faultSet3Player1 = value;
            }
        }

        public int FaultSet1Player2
        {
            set
            {
                faultSet1Player2 = value;
            }
        }

        public int FaultSet2Player2
        {
            set
            {
                faultSet2Player2 = value;
            }
        }

        public int FaultSet3Player2
        {
            set
            {
                faultSet3Player2 = value;
            }
        }

        //Double faults.
        public int DoubleFaultSet1Player1
        {
            set
            {
                doubleFaultSet1Player1 = value;
            }
        }

        public int DoubleFaultSet2Player1
        {
            set
            {
                doubleFaultSet2Player1 = value;
            }
        }

        public int DoubleFaultSet3Player1
        {
            set
            {
                doubleFaultSet3Player1 = value;
            }
        }

        public int DoubleFaultSet1Player2
        {
            set
            {
                doubleFaultSet1Player2 = value;
            }
        }

        public int DoubleFaultSet2Player2
        {
            set
            {
                doubleFaultSet2Player2 = value;
            }
        }

        public int DoubleFaultSet3Player2
        {
            set
            {
                doubleFaultSet3Player2 = value;
            }
        }

        //Number of serves.
        public int NumberOfServesSet1Player1
        {
            set
            {
                numberOfServesSet1Player1 = value;
            }
        }

        public int NumberOfServesSet2Player1
        {
            set
            {
                numberOfServesSet2Player1 = value;
            }
        }

        public int NumberOfServesSet3Player1
        {
            set
            {
                numberOfServesSet3Player1 = value;
            }
        }

        public int NumberOfServesSet1Player2
        {
            set
            {
                numberOfServesSet1Player2 = value;
            }
        }

        public int NumberOfServesSet2Player2
        {
            set
            {
                numberOfServesSet2Player2 = value;
            }
        }

        public int NumberOfServesSet3Player2
        {
            set
            {
                numberOfServesSet3Player2 = value;
            }
        }
        
        //First serve in.
        public int FirstServeInSet1Player1
        {
            set
            {
                firstServeInSet1Player1 = value;
            }
        }

        public int FirstServeInSet2Player1
        {
            set
            {
                firstServeInSet2Player1 = value;
            }
        }

        public int FirstServeInSet3Player1
        {
            set
            {
                firstServeInSet3Player1 = value;
            }
        }

        public int FirstServeInSet1Player2
        {
            set
            {
                firstServeInSet1Player2 = value;
            }
        }

        public int FirstServeInSet2Player2
        {
            set
            {
                firstServeInSet2Player2 = value;
            }
        }

        public int FirstServeInSet3Player2
        {
            set
            {
                firstServeInSet3Player2 = value;
            }
        }

        //First serve in.
        public int SecondServeInSet1Player1
        {
            set
            {
                secondServeInSet1Player1 = value;
            }
        }

        public int SecondServeInSet2Player1
        {
            set
            {
                secondServeInSet2Player1 = value;
            }
        }

        public int SecondServeInSet3Player1
        {
            set
            {
                secondServeInSet3Player1 = value;
            }
        }

        public int SecondServeInSet1Player2
        {
            set
            {
                secondServeInSet1Player2 = value;
            }
        }

        public int SecondServeInSet2Player2
        {
            set
            {
                secondServeInSet2Player2 = value;
            }
        }

        public int SecondServeInSet3Player2
        {
            set
            {
                secondServeInSet3Player2 = value;
            }
        }

        //Percentage first serve
        public int PercentFirstServeSet1Player1
        {
            set
            {
                percentFirstServeSet1Player1 = value;
            }
        }

        public int PercentFirstServeSet2Player1
        {
            set
            {
                percentFirstServeSet2Player1 = value;
            }
        }

        public int PercentFirstServeSet3Player1
        {
            set
            {
                percentFirstServeSet3Player1 = value;
            }
        }

        public int PercentFirstServeSet1Player2
        {
            set
            {
                percentFirstServeSet1Player2 = value;
            }
        }

        public int PercentFirstServeSet2Player2
        {
            set
            {
                percentFirstServeSet2Player2 = value;
            }
        }

        public int PercentFirstServeSet3Player2
        {
            set
            {
                percentFirstServeSet3Player2 = value;
            }
        }


        //Percentage of points won 1st serve
        public int PercentPointsWon1stServeSet1Player1
        {
            set
            {
                percentPointsWon1stServeSet1Player1 = value;
            }
        }

        public int PercentPointsWon1stServeSet2Player1
        {
            set
            {
                percentPointsWon1stServeSet2Player1 = value;
            }
        }

        public int PercentPointsWon1stServeSet3Player1
        {
            set
            {
                percentPointsWon1stServeSet3Player1 = value;
            }
        }

        public int PercentPointsWon1stServeSet1Player2
        {
            set
            {
                percentPointsWon1stServeSet1Player2 = value;
            }
        }

        public int PercentPointsWon1stServeSet2Player2
        {
            set
            {
                percentPointsWon1stServeSet2Player2 = value;
            }
        }

        public int PercentPointsWon1stServeSet3Player2
        {
            set
            {
                percentPointsWon1stServeSet3Player2 = value;
            }
        }

        //POINTS WON 1ST SERVE
        public int PointWon1ServeSet1Player1
        {
            set
            {
                pointWon1ServeSet1Player1 = value;
            }
        }

        public int PointWon1ServeSet2Player1
        {
            set
            {
                pointWon1ServeSet2Player1 = value;
            }
        }

        public int PointWon1ServeSet3Player1
        {
            set
            {
                pointWon1ServeSet3Player1 = value;
            }
        }

        public int PointWon1ServeSet1Player2
        {
            set
            {
                pointWon1ServeSet1Player2 = value;
            }
        }

        public int PointWon1ServeSet2Player2
        {
            set
            {
                pointWon1ServeSet2Player2 = value;
            }
        }

        public int PointWon1ServeSet3Player2
        {
            set
            {
                pointWon1ServeSet3Player2 = value;
            }
        }

        //Percentage of points won 1st serve
        public int PercentPointsWon2ndServeSet1Player1
        {
            set
            {
                percentPointsWon2ndServeSet1Player1 = value;
            }
        }

        public int PercentPointsWon2ndServeSet2Player1
        {
            set
            {
                percentPointsWon2ndServeSet2Player1 = value;
            }
        }

        public int PercentPointsWon2ndServeSet3Player1
        {
            set
            {
                percentPointsWon2ndServeSet3Player1 = value;
            }
        }

        public int PercentPointsWon2ndServeSet1Player2
        {
            set
            {
                percentPointsWon2ndServeSet1Player2 = value;
            }
        }

        public int PercentPointsWon2ndServeSet2Player2
        {
            set
            {
                percentPointsWon2ndServeSet2Player2 = value;
            }
        }

        public int PercentPointsWon2ndServeSet3Player2
        {
            set
            {
                percentPointsWon2ndServeSet3Player2 = value;
            }
        }

        //POINTS WON 2ND SERVE
        public int PointWon2ServeSet1Player1
        {
            set
            {
                pointWon2ServeSet1Player1 = value;
            }
        }

        public int PointWon2ServeSet2Player1
        {
            set
            {
                pointWon2ServeSet2Player1 = value;
            }
        }

        public int PointWon2ServeSet3Player1
        {
            set
            {
                pointWon2ServeSet3Player1 = value;
            }
        }

        public int PointWon2ServeSet1Player2
        {
            set
            {
                pointWon2ServeSet1Player2 = value;
            }
        }

        public int PointWon2ServeSet2Player2
        {
            set
            {
                pointWon2ServeSet2Player2 = value;
            }
        }

        public int PointWon2ServeSet3Player2
        {
            set
            {
                pointWon2ServeSet3Player2 = value;
            }
        }

        //Breaks
        public int BreaksSet1Player1
        {
            set
            {
                breaksSet1Player1 = value;
            }
        }
        public int BreaksSet2Player1
        {
            set
            {
                breaksSet2Player1 = value;
            }
        }
        public int BreaksSet3Player1
        {
            set
            {
                breaksSet3Player1 = value;
            }
        }
        public int BreaksSet1Player2
        {
            set
            {
                breaksSet1Player2 = value;
            }
        }
        public int BreaksSet2Player2
        {
            set
            {
                breaksSet2Player2 = value;
            }
        }
        public int BreaksSet3Player2
        {
            set
            {
                breaksSet3Player2 = value;
            }
        }

        //Breaks saved.
        public int BreaksSavedSet1Player1
        {
            set
            {
                breaksSavedSet1Player1 = value;
            }
        }
        public int BreaksSavedSet2Player1
        {
            set
            {
                breaksSavedSet2Player1 = value;
            }
        }
        public int BreaksSavedSet3Player1
        {
            set
            {
                breaksSavedSet3Player1 = value;
            }
        }
        public int BreaksSavedSet1Player2
        {
            set
            {
                breaksSavedSet1Player2 = value;
            }
        }
        public int BreaksSavedSet2Player2
        {
            set
            {
                breaksSavedSet2Player2 = value;
            }
        }
        public int BreaksSavedSet3Player2
        {
            set
            {
                breaksSavedSet3Player2 = value;
            }
        }

        //Percentage breaks saved
        public int PercentBreaksSavedSet1Player1
        {
            set
            {
                percentBreaksSavedSet1Player1 = value;
            }
        }

        public int PercentBreaksSavedSet2Player1
        {
            set
            {
                percentBreaksSavedSet2Player1 = value;
            }
        }

        public int PercentBreaksSavedSet3Player1
        {
            set
            {
                percentBreaksSavedSet3Player1 = value;
            }
        }

        public int PercentBreaksSavedSet1Player2
        {
            set
            {
                percentBreaksSavedSet1Player2 = value;
            }
        }

        public int PercentBreaksSavedSet2Player2
        {
            set
            {
                percentBreaksSavedSet2Player2 = value;
            }
        }

        public int PercentBreaksSavedSet3Player2
        {
            set
            {
                percentBreaksSavedSet3Player2 = value;
            }
        }

        //Games served.
        public int GamesServedSet1Player1
        {
            set
            {
                gamesServedSet1Player1 = value;
            }
        }
        public int GamesServedSet2Player1
        {
            set
            {
                gamesServedSet2Player1 = value;
            }
        }
        public int GamesServedSet3Player1
        {
            set
            {
                gamesServedSet3Player1 = value;
            }
        }
        public int GamesServedSet1Player2
        {
            set
            {
                gamesServedSet1Player2 = value;
            }
        }
        public int GamesServedSet2Player2
        {
            set
            {
                gamesServedSet2Player2 = value;
            }
        }
        public int GamesServedSet3Player2
        {
            set
            {
                gamesServedSet3Player2 = value;
            }
        }

        //Games returned.
        public int GamesReturnedSet1Player1
        {
            set
            {
                gamesReturnedSet1Player1 = value;
            }
        }
        public int GamesReturnedSet2Player1
        {
            set
            {
                gamesReturnedSet2Player1 = value;
            }
        }
        public int GamesReturnedSet3Player1
        {
            set
            {
                gamesReturnedSet3Player1 = value;
            }
        }
        public int GamesReturnedSet1Player2
        {
            set
            {
                gamesReturnedSet1Player2 = value;
            }
        }
        public int GamesReturnedSet2Player2
        {
            set
            {
                gamesReturnedSet2Player2 = value;
            }
        }
        public int GamesReturnedSet3Player2
        {
            set
            {
                gamesReturnedSet3Player2 = value;
            }
        }

        //Winners
        public int WinnersSet1Player1
        {
            set
            {
                winnersSet1Player1 = value;
            }
        }
        public int WinnersSet2Player1
        {
            set
            {
                winnersSet2Player1 = value;
            }
        }
        public int WinnersSet3Player1
        {
            set
            {
                winnersSet3Player1 = value;
            }
        }
        public int WinnersSet1Player2
        {
            set
            {
                winnersSet1Player2 = value;
            }
        }
        public int WinnersSet2Player2
        {
            set
            {
                winnersSet2Player2 = value;
            }
        }
        public int WinnersSet3Player2
        {
            set
            {
                winnersSet3Player2 = value;
            }
        }

        //Forehand winners
        public int ForehandWinnersSet1Player1
        {
            set
            {
                forehandWinnersSet1Player1 = value;
            }
        }
        public int ForehandWinnersSet2Player1
        {
            set
            {
                forehandWinnersSet2Player1 = value;
            }
        }
        public int ForehandWinnersSet3Player1
        {
            set
            {
                forehandWinnersSet3Player1 = value;
            }
        }
        public int ForehandWinnersSet1Player2
        {
            set
            {
                forehandWinnersSet1Player2 = value;
            }
        }
        public int ForehandWinnersSet2Player2
        {
            set
            {
                forehandWinnersSet2Player2 = value;
            }
        }
        public int ForehandWinnersSet3Player2
        {
            set
            {
                forehandWinnersSet3Player2 = value;
            }
        }

        //Backhand winners
        public int BackhandWinnersSet1Player1
        {
            set
            {
                backhandWinnersSet1Player1 = value;
            }
        }
        public int BackhandWinnersSet2Player1
        {
            set
            {
                backhandWinnersSet2Player1 = value;
            }
        }
        public int BackhandWinnersSet3Player1
        {
            set
            {
                backhandWinnersSet3Player1 = value;
            }
        }
        public int BackhandWinnersSet1Player2
        {
            set
            {
                backhandWinnersSet1Player2 = value;
            }
        }
        public int BackhandWinnersSet2Player2
        {
            set
            {
                backhandWinnersSet2Player2 = value;
            }
        }
        public int BackhandWinnersSet3Player2
        {
            set
            {
                backhandWinnersSet3Player2 = value;
            }
        }

        //Unforced errors
        public int UnforcedErrorsSet1Player1
        {
            set
            {
                unforcedErrorsSet1Player1 = value;
            }
        }
        public int UnforcedErrorsSet2Player1
        {
            set
            {
                unforcedErrorsSet2Player1 = value;
            }
        }
        public int UnforcedErrorsSet3Player1
        {
            set
            {
                unforcedErrorsSet3Player1 = value;
            }
        }
        public int UnforcedErrorsSet1Player2
        {
            set
            {
                unforcedErrorsSet1Player2 = value;
            }
        }
        public int UnforcedErrorsSet2Player2
        {
            set
            {
                unforcedErrorsSet2Player2 = value;
            }
        }
        public int UnforcedErrorsSet3Player2
        {
            set
            {
                unforcedErrorsSet3Player2 = value;
            }
        }

        //Forehand unforced errors
        public int ForehandUnforcedErrorsSet1Player1
        {
            set
            {
                forehandUnforcedErrorsSet1Player1 = value;
            }
        }
        public int ForehandUnforcedErrorsSet2Player1
        {
            set
            {
                forehandUnforcedErrorsSet2Player1 = value;
            }
        }
        public int ForehandUnforcedErrorsSet3Player1
        {
            set
            {
                forehandUnforcedErrorsSet3Player1 = value;
            }
        }
        public int ForehandUnforcedErrorsSet1Player2
        {
            set
            {
                forehandUnforcedErrorsSet1Player2 = value;
            }
        }
        public int ForehandUnforcedErrorsSet2Player2
        {
            set
            {
                forehandUnforcedErrorsSet2Player2 = value;
            }
        }
        public int ForehandUnforcedErrorsSet3Player2
        {
            set
            {
                forehandUnforcedErrorsSet3Player2 = value;
            }
        }

        //Backhand unforced errors
        public int BackhandUnforcedErrorsSet1Player1
        {
            set
            {
                backhandUnforcedErrorsSet1Player1 = value;
            }
        }
        public int BackhandUnforcedErrorsSet2Player1
        {
            set
            {
                backhandUnforcedErrorsSet2Player1 = value;
            }
        }
        public int BackhandUnforcedErrorsSet3Player1
        {
            set
            {
                backhandUnforcedErrorsSet3Player1 = value;
            }
        }
        public int BackhandUnforcedErrorsSet1Player2
        {
            set
            {
                backhandUnforcedErrorsSet1Player2 = value;
            }
        }
        public int BackhandUnforcedErrorsSet2Player2
        {
            set
            {
                backhandUnforcedErrorsSet2Player2 = value;
            }
        }
        public int BackhandUnforcedErrorsSet3Player2
        {
            set
            {
                backhandUnforcedErrorsSet3Player2 = value;
            }
        }

        //Forced errors
        public int ForcedErrorsSet1Player1
        {
            set
            {
                forcedErrorsSet1Player1 = value;
            }
        }
        public int ForcedErrorsSet2Player1
        {
            set
            {
                forcedErrorsSet2Player1 = value;
            }
        }
        public int ForcedErrorsSet3Player1
        {
            set
            {
                forcedErrorsSet3Player1 = value;
            }
        }
        public int ForcedErrorsSet1Player2
        {
            set
            {
                forcedErrorsSet1Player2 = value;
            }
        }
        public int ForcedErrorsSet2Player2
        {
            set
            {
                forcedErrorsSet2Player2 = value;
            }
        }
        public int ForcedErrorsSet3Player2
        {
            set
            {
                forcedErrorsSet3Player2 = value;
            }
        }

        //Forehand forced errors
        public int ForehandForcedErrorsSet1Player1
        {
            set
            {
                forehandForcedErrorsSet1Player1 = value;
            }
        }
        public int ForehandForcedErrorsSet2Player1
        {
            set
            {
                forehandForcedErrorsSet2Player1 = value;
            }
        }
        public int ForehandForcedErrorsSet3Player1
        {
            set
            {
                forehandForcedErrorsSet3Player1 = value;
            }
        }
        public int ForehandForcedErrorsSet1Player2
        {
            set
            {
                forehandForcedErrorsSet1Player2 = value;
            }
        }
        public int ForehandForcedErrorsSet2Player2
        {
            set
            {
                forehandForcedErrorsSet2Player2 = value;
            }
        }
        public int ForehandForcedErrorsSet3Player2
        {
            set
            {
                forehandForcedErrorsSet3Player2 = value;
            }
        }

        //Backhand forced errors
        public int BackhandForcedErrorsSet1Player1
        {
            set
            {
                backhandForcedErrorsSet1Player1 = value;
            }
        }
        public int BackhandForcedErrorsSet2Player1
        {
            set
            {
                backhandForcedErrorsSet2Player1 = value;
            }
        }
        public int BackhandForcedErrorsSet3Player1
        {
            set
            {
                backhandForcedErrorsSet3Player1 = value;
            }
        }
        public int BackhandForcedErrorsSet1Player2
        {
            set
            {
                backhandForcedErrorsSet1Player2 = value;
            }
        }
        public int BackhandForcedErrorsSet2Player2
        {
            set
            {
                backhandForcedErrorsSet2Player2 = value;
            }
        }
        public int BackhandForcedErrorsSet3Player2
        {
            set
            {
                backhandForcedErrorsSet3Player2 = value;
            }
        }

        //Percentage return points won first serve
        public int PercentFirstServeReturnSet1Player1
        {
            set
            {
                percentFirstServeReturnSet1Player1 = value;
            }
        }

        public int PercentFirstServeReturnSet2Player1
        {
            set
            {
                percentFirstServeReturnSet2Player1 = value;
            }
        }

        public int PercentFirstServeReturnSet3Player1
        {
            set
            {
                percentFirstServeReturnSet3Player1 = value;
            }
        }

        public int PercentFirstServeReturnSet1Player2
        {
            set
            {
                percentFirstServeReturnSet1Player2 = value;
            }
        }

        public int PercentFirstServeReturnSet2Player2
        {
            set
            {
                percentFirstServeReturnSet2Player2 = value;
            }
        }

        public int PercentFirstServeReturnSet3Player2
        {
            set
            {
                percentFirstServeReturnSet3Player2 = value;
            }
        }

        //Percentage return points won second serve
        public int PercentSecondServeReturnSet1Player1
        {
            set
            {
                percentSecondServeReturnSet1Player1 = value;
            }
        }

        public int PercentSecondServeReturnSet2Player1
        {
            set
            {
                percentSecondServeReturnSet2Player1 = value;
            }
        }

        public int PercentSecondServeReturnSet3Player1
        {
            set
            {
                percentSecondServeReturnSet3Player1 = value;
            }
        }

        public int PercentSecondServeReturnSet1Player2
        {
            set
            {
                percentSecondServeReturnSet1Player2 = value;
            }
        }

        public int PercentSecondServeReturnSet2Player2
        {
            set
            {
                percentSecondServeReturnSet2Player2 = value;
            }
        }

        public int PercentSecondServeReturnSet3Player2
        {
            set
            {
                percentSecondServeReturnSet3Player2 = value;
            }
        }

        //POINTS WON 1ST SERVE
        public int ReturnFirstServeWonSet1Player1
        {
            set
            {
                returnFirstServeWonSet1Player1 = value;
            }
        }

        public int ReturnFirstServeWonSet2Player1
        {
            set
            {
                returnFirstServeWonSet2Player1 = value;
            }
        }

        public int ReturnFirstServeWonSet3Player1
        {
            set
            {
                returnFirstServeWonSet3Player1 = value;
            }
        }

        public int ReturnFirstServeWonSet1Player2
        {
            set
            {
                returnFirstServeWonSet1Player2 = value;
            }
        }

        public int ReturnFirstServeWonSet2Player2
        {
            set
            {
                returnFirstServeWonSet2Player2 = value;
            }
        }

        public int ReturnFirstServeWonSet3Player2
        {
            set
            {
                returnFirstServeWonSet3Player2 = value;
            }
        }

        //POINTS WON 2ND SERVE
        public int PointWonReturning2ndServeSet1Player1
        {
            set
            {
                pointWonReturning2ndServeSet1Player1 = value;
            }
        }

        public int PointWonReturning2ndServeSet2Player1
        {
            set
            {
                pointWonReturning2ndServeSet2Player1 = value;
            }
        }

        public int PointWonReturning2ndServeSet3Player1
        {
            set
            {
                pointWonReturning2ndServeSet3Player1 = value;
            }
        }

        public int PointWonReturning2ndServeSet1Player2
        {
            set
            {
                pointWonReturning2ndServeSet1Player2 = value;
            }
        }

        public int PointWonReturning2ndServeSet2Player2
        {
            set
            {
                pointWonReturning2ndServeSet2Player2 = value;
            }
        }

        public int PointWonReturning2ndServeSet3Player2
        {
            set
            {
                pointWonReturning2ndServeSet3Player2 = value;
            }
        }

        //Percentage breaks won
        public int PercentBreaksWonSet1Player1
        {
            set
            {
                percentBreaksWonSet1Player1 = value;
            }
        }

        public int PercentBreaksWonSet2Player1
        {
            set
            {
                percentBreaksWonSet2Player1 = value;
            }
        }

        public int PercentBreaksWonSet3Player1
        {
            set
            {
                percentBreaksWonSet3Player1 = value;
            }
        }

        public int PercentBreaksWonSet1Player2
        {
            set
            {
                percentBreaksWonSet1Player2 = value;
            }
        }

        public int PercentBreaksWonSet2Player2
        {
            set
            {
                percentBreaksWonSet2Player2 = value;
            }
        }

        public int PercentBreaksWonSet3Player2
        {
            set
            {
                percentBreaksWonSet3Player2 = value;
            }
        }

        //Breaks won.
        public int BreakPointWonSet1Player1
        {
            set
            {
                breakPointWonSet1Player1 = value;
            }
        }
        public int BreakPointWonSet2Player1
        {
            set
            {
                breakPointWonSet2Player1 = value;
            }
        }
        public int BreakPointWonSet3Player1
        {
            set
            {
                breakPointWonSet3Player1 = value;
            }
        }
        public int BreakPointWonSet1Player2
        {
            set
            {
                breakPointWonSet1Player2 = value;
            }
        }
        public int BreakPointWonSet2Player2
        {
            set
            {
                breakPointWonSet2Player2 = value;
            }
        }
        public int BreakPointWonSet3Player2
        {
            set
            {
                breakPointWonSet3Player2 = value;
            }
        }

        //Percentage total service points won.
        public int PercentTotalServicePointsWonSet1Player1
        {
            set
            {
                percentTotalServicePointsWonSet1Player1 = value;
            }
        }

        public int PercentTotalServicePointsWonSet2Player1
        {
            set
            {
                percentTotalServicePointsWonSet2Player1 = value;
            }
        }

        public int PercentTotalServicePointsWonSet3Player1
        {
            set
            {
                percentTotalServicePointsWonSet3Player1 = value;
            }
        }

        public int PercentTotalServicePointsWonSet1Player2
        {
            set
            {
                percentTotalServicePointsWonSet1Player2 = value;
            }
        }

        public int PercentTotalServicePointsWonSet2Player2
        {
            set
            {
                percentTotalServicePointsWonSet2Player2 = value;
            }
        }

        public int PercentTotalServicePointsWonSet3Player2
        {
            set
            {
                percentTotalServicePointsWonSet3Player2 = value;
            }
        }


        //Percentage total return points won.
        public int PercentTotalReturnPointsWonSet1Player1
        {
            set
            {
                percentTotalReturnPointsWonSet1Player1 = value;
            }
        }

        public int PercentTotalReturnPointsWonSet2Player1
        {
            set
            {
                percentTotalReturnPointsWonSet2Player1 = value;
            }
        }

        public int PercentTotalReturnPointsWonSet3Player1
        {
            set
            {
                percentTotalReturnPointsWonSet3Player1 = value;
            }
        }

        public int PercentTotalReturnPointsWonSet1Player2
        {
            set
            {
                percentTotalReturnPointsWonSet1Player2 = value;
            }
        }

        public int PercentTotalReturnPointsWonSet2Player2
        {
            set
            {
                percentTotalReturnPointsWonSet2Player2 = value;
            }
        }

        public int PercentTotalReturnPointsWonSet3Player2
        {
            set
            {
                percentTotalReturnPointsWonSet3Player2 = value;
            }
        }


        //Percentage total points won.
        public int PercentTotalPointsWonSet1Player1
        {
            set
            {
                percentTotalPointsWonSet1Player1 = value;
            }
        }

        public int PercentTotalPointsWonSet2Player1
        {
            set
            {
                percentTotalPointsWonSet2Player1 = value;
            }
        }

        public int PercentTotalPointsWonSet3Player1
        {
            set
            {
                percentTotalPointsWonSet3Player1 = value;
            }
        }

        public int PercentTotalPointsWonSet1Player2
        {
            set
            {
                percentTotalPointsWonSet1Player2 = value;
            }
        }

        public int PercentTotalPointsWonSet2Player2
        {
            set
            {
                percentTotalPointsWonSet2Player2 = value;
            }
        }

        public int PercentTotalPointsWonSet3Player2
        {
            set
            {
                percentTotalPointsWonSet3Player2 = value;
            }
        }

        //Percentage total points won at the net.
        public int PercentPointsWonAtTheNetSet1Player1
        {
            set
            {
                percentPointsWonAtTheNetSet1Player1 = value;
            }
        }

        public int PercentPointsWonAtTheNetSet2Player1
        {
            set
            {
                percentPointsWonAtTheNetSet2Player1 = value;
            }
        }

        public int PercentPointsWonAtTheNetSet3Player1
        {
            set
            {
                percentPointsWonAtTheNetSet3Player1 = value;
            }
        }

        public int PercentPointsWonAtTheNetSet1Player2
        {
            set
            {
                percentPointsWonAtTheNetSet1Player2 = value;
            }
        }

        public int PercentPointsWonAtTheNetSet2Player2
        {
            set
            {
                percentPointsWonAtTheNetSet2Player2 = value;
            }
        }

        public int PercentPointsWonAtTheNetSet3Player2
        {
            set
            {
                percentPointsWonAtTheNetSet3Player2 = value;
            }
        }


        //Points played at the net.
        public int ApproachSet1Player1
        {
            set
            {
                approachSet1Player1 = value;
            }
        }

        public int ApproachSet2Player1
        {
            set
            {
                approachSet2Player1 = value;
            }
        }

        public int ApproachSet3Player1
        {
            set
            {
                approachSet3Player1 = value;
            }
        }

        public int ApproachSet1Player2
        {
            set
            {
                approachSet1Player2 = value;
            }
        }

        public int ApproachSet2Player2
        {
            set
            {
                approachSet2Player2 = value;
            }
        }

        public int ApproachSet3Player2
        {
            set
            {
                approachSet3Player2 = value;
            }
        }


        //Points won at the net.
        public int PointsWonNetSet1Player1
        {
            set
            {
                pointsWonNetSet1Player1 = value;
            }
        }

        public int PointsWonNetSet2Player1
        {
            set
            {
                pointsWonNetSet2Player1 = value;
            }
        }

        public int PointsWonNetSet3Player1
        {
            set
            {
                pointsWonNetSet3Player1 = value;
            }
        }

        public int PointsWonNetSet1Player2
        {
            set
            {
                pointsWonNetSet1Player2 = value;
            }
        }

        public int PointsWonNetSet2Player2
        {
            set
            {
                pointsWonNetSet2Player2 = value;
            }
        }

        public int PointsWonNetSet3Player2
        {
            set
            {
                pointsWonNetSet3Player2 = value;
            }
        }

        //Sum of sets won
        public int SumOfSetsPlayer1
        {
            set
            {
                sumOfSetsPlayer1 = value;
            }
        }

        public int SumOfSetsPlayer2
        {
            set
            {
                sumOfSetsPlayer2 = value;
            }
        }

        //PLAYERS NAMES
        public string FirstNamePlayer1
        {
            set
            {
                firstNamePlayer1 = value;
            }
        }
        public string FirstNamePlayer2
        {
            set
            {
                firstNamePlayer2 = value;
            }
        }
        public string LastNamePlayer1
        {
            set
            {
                lastNamePlayer1 = value;
            }
        }
        public string LastNamePlayer2
        {
            set
            {
                lastNamePlayer2 = value;
            }
        }
        //Initialize form
        public StatsForm()
        {           
            InitializeComponent();
            RefreshTimer.Interval = 1000 * 1; //5 seconds
            RefreshTimer.Tick += new EventHandler(RefreshTimer_Tick);
            RefreshTimer.Enabled = true;
        }

        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
        }

        private void StatsForm_Activated(object sender, EventArgs e)
        {
            //Display players names
            player1LastNameLabel.Text = firstNamePlayer1[0] + ". " + lastNamePlayer1;
            player2LastNameLabel.Text = firstNamePlayer2[0] + ". " + lastNamePlayer2;
            player1LastNameLabel2.Text = firstNamePlayer1[0] + ". " + lastNamePlayer1;
            player2LastNameLabel2.Text = firstNamePlayer2[0] + ". " + lastNamePlayer2;
                       
            if (sumOfSetsPlayer1 + sumOfSetsPlayer2 == 3)
            {
                matchStatsComboBox.Items.Clear();
                matchStatsComboBox.Items.Add("Match");
                matchStatsComboBox.Items.Add("1st Set");
                matchStatsComboBox.Items.Add("2nd Set");
                matchStatsComboBox.Items.Add("3rd Set");
            }
            else if (sumOfSetsPlayer1 + sumOfSetsPlayer2 == 2)
            {
                matchStatsComboBox.Items.Clear();
                matchStatsComboBox.Items.Add("Match");
                matchStatsComboBox.Items.Add("1st Set");
                matchStatsComboBox.Items.Add("2nd Set");
            }
            else
            {
                matchStatsComboBox.Items.Clear();
                matchStatsComboBox.Items.Add("1st Set");
            }
            
        }

        private void matchStatsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchStatsComboBox.SelectedIndex == 0)
            {
                int acesMatchPlayer1 = 0;
                int acesMatchPlayer2 = 0;
                int doubleFaultMatchPlayer1 = 0;
                int doubleFaultMatchPlayer2 = 0;
                double percentFirstServeMatchPlayer1 = 0.0;
                double percentFirstServeMatchPlayer2 = 0.0;
                double percentPointsWon1ServeMatchPlayer1 = 0.0;
                double percentPointsWon1ServeMatchPlayer2 = 0.0;
                double percentPointsWon2ndServeMatchPlayer1 = 0.0;
                double percentPointsWon2ndServeMatchPlayer2 = 0.0;
                double percentBreaksSavedMatchPlayer1 = 0.0;
                double percentBreaksSavedMatchPlayer2 = 0.0;
                double percentPointsWonAtTheNetMatchPlayer1 = 0.0;
                double percentPointsWonAtTheNetMatchPlayer2 = 0.0;
                double percentFirstServeReturnMatchPlayer1 = 0.0;
                double percentFirstServeReturnMatchPlayer2 = 0.0;
                double percent2ndServeReturnMatchPlayer1 = 0.0;
                double percent2ndServeReturnMatchPlayer2 = 0.0;
                double percentBreaksWonMatchPlayer1 = 0.0;
                double percentBreaksWonMatchPlayer2 = 0.0;
                double percentTotalServicePointsWonMatchPlayer1 = 0.0;
                double percentTotalServicePointsWonMatchPlayer2 = 0.0;
                double percentTotalReturnPointsWonMatchPlayer1 = 0.0;
                double percentTotalReturnPointsWonMatchPlayer2 = 0.0;
                double percentTotalPointsWonMatchPlayer1 = 0.0;
                double percentTotalPointsWonMatchPlayer2 = 0.0;
                int firstServeInMatchPlayer1 = 0;
                int firstServeInMatchPlayer2 = 0;
                int numberOfServesMatchPlayer1 = 0;
                int numberOfServesMatchPlayer2 = 0;
                int faultMatchPlayer1 = 0;
                int faultMatchPlayer2 = 0;
                int pointWon1ServeMatchPlayer1 = 0;  
                int pointWon1ServeMatchPlayer2 = 0;
                int pointWon2ServeMatchPlayer1 = 0;
                int pointWon2ServeMatchPlayer2 = 0;
                int secondServeInMatchPlayer1 = 0;
                int secondServeInMatchPlayer2 = 0;
                int breaksSavedMatchPlayer1 = 0;
                int breaksSavedMatchPlayer2 = 0;
                int breaksMatchPlayer1 = 0;
                int breaksMatchPlayer2 = 0;
                int gamesServedMatchPlayer1 = 0;
                int gamesServedMatchPlayer2 = 0;
                int gamesReturnedMatchPlayer1 = 0;
                int gamesReturnedMatchPlayer2 = 0;
                int winnerMatchPlayer1 = 0;
                int winnerMatchPlayer2 = 0;
                int forehandWinnerMatchPlayer1 = 0;
                int backhandWinnerMatchPlayer2 = 0;
                int forehandWinnerMatchPlayer2 = 0;
                int backhandWinnerMatchPlayer1 = 0;
                int unforcedErrorsMatchPlayer1 = 0;
                int unforcedErrorsMatchPlayer2 = 0;
                int forehandUnforcedErrorsMatchPlayer1 = 0;
                int forehandUnforcedErrorsMatchPlayer2 = 0;
                int backhandUnforcedErrorsMatchPlayer1 = 0;
                int backhandUnforcedErrorsMatchPlayer2 = 0;
                int forcedErrorsMatchPlayer1 = 0;
                int forcedErrorsMatchPlayer2 = 0;
                int forehandForcedErrorMatchPlayer1 = 0;
                int forehandForcedErrorMatchPlayer2 = 0;
                int backhandForcedErrorMatchPlayer1 = 0;
                int backhandForcedErrorMatchPlayer2 = 0;
                int pointsWonNetMatchPlayer1 = 0;
                int pointsWonNetMatchPlayer2 = 0;
                int approachMatchPlayer1 = 0;
                int approachMatchPlayer2 = 0;
                int returnFirstServeWonMatchPlayer1 = 0;
                int returnFirstServeWonMatchPlayer2 = 0;
                int pointWonReturning2ndServeMatchPlayer1 = 0;
                int pointWonReturning2ndServeMatchPlayer2 = 0;
                int breakPointWonMatchPlayer1 = 0;
                int breakPointWonMatchPlayer2 = 0;

                //Calc Aces
                acesMatchPlayer1 = aceSet1Player1 + aceSet2Player1 + aceSet3Player1;
                acePlayer1Label.Text = acesMatchPlayer1.ToString();
                acesMatchPlayer2 = aceSet1Player2 + aceSet2Player2 + aceSet3Player2;
                acePlayer2Label.Text = acesMatchPlayer2.ToString();
                //Calc double fault
                doubleFaultMatchPlayer1 = doubleFaultSet1Player1 + doubleFaultSet2Player1 + doubleFaultSet3Player1;
                doubleFaultPlayer1Label.Text = doubleFaultMatchPlayer1.ToString();
                doubleFaultMatchPlayer2 = doubleFaultSet1Player2 + doubleFaultSet2Player2 + doubleFaultSet3Player2;
                doubleFaultPlayer2Label.Text = doubleFaultMatchPlayer2.ToString();
                //Calc percent first serve               
                numberOfServesMatchPlayer1 = numberOfServesSet1Player1 + numberOfServesSet2Player1 + numberOfServesSet3Player1;
                numberOfServesMatchPlayer2 = numberOfServesSet1Player2 + numberOfServesSet2Player2 + numberOfServesSet3Player2;
                faultMatchPlayer1 = faultSet1Player1 + faultSet2Player1 + faultSet3Player1;
                faultMatchPlayer2 = faultSet1Player2 + faultSet2Player2 + faultSet3Player2;
                firstServeInMatchPlayer1 = numberOfServesMatchPlayer1 - faultMatchPlayer1;
                firstServeInMatchPlayer2 = numberOfServesMatchPlayer2 - faultMatchPlayer2;
                //sum points won first serve
                pointWon1ServeMatchPlayer1 = pointWon1ServeSet1Player1 + pointWon1ServeSet2Player1 + pointWon1ServeSet3Player1;
                pointWon1ServeMatchPlayer2 = pointWon1ServeSet1Player2 + pointWon1ServeSet2Player2 + pointWon1ServeSet3Player2;
                //sum points won 2nd serve
                pointWon2ServeMatchPlayer1 = pointWon2ServeSet1Player1 + pointWon2ServeSet2Player1 + pointWon2ServeSet3Player1;
                pointWon2ServeMatchPlayer2 = pointWon2ServeSet1Player2 + pointWon2ServeSet2Player2 + pointWon2ServeSet3Player2;
                //Sum of second serves in
                secondServeInMatchPlayer1 = faultMatchPlayer1 - doubleFaultMatchPlayer1;
                secondServeInMatchPlayer2 = faultMatchPlayer2 - doubleFaultMatchPlayer2;
                //sum Breaks and breaks saved
                breaksMatchPlayer1 = breaksSet1Player1 + breaksSet2Player1 + breaksSet3Player1;
                breaksMatchPlayer2 = breaksSet1Player2 + breaksSet2Player2 + breaksSet3Player2;
                breaksSavedMatchPlayer1 = breaksSavedSet1Player1 + breaksSavedSet2Player1 + breaksSavedSet3Player1;
                breaksSavedMatchPlayer2 = breaksSavedSet1Player2 + breaksSavedSet2Player2 + breaksSavedSet3Player2;
                //sum of games served and return
                gamesServedMatchPlayer1 = gamesServedSet1Player1 + gamesServedSet2Player1 + gamesServedSet3Player1;
                gamesServedMatchPlayer2 = gamesServedSet1Player2 + gamesServedSet2Player2 + gamesServedSet3Player2;
                gamesReturnedMatchPlayer1 = gamesReturnedSet1Player1 + gamesReturnedSet2Player1 + gamesReturnedSet3Player1;
                gamesReturnedMatchPlayer2 = gamesReturnedSet1Player2 + gamesReturnedSet2Player2 + gamesReturnedSet3Player2;
                //sum winners
                winnerMatchPlayer1 = winnersSet1Player1 + winnersSet2Player1 + winnersSet3Player1;
                winnerMatchPlayer2 = winnersSet1Player2 + winnersSet2Player2 + winnersSet3Player2;
                forehandWinnerMatchPlayer1 = forehandWinnersSet1Player1 + forehandWinnersSet2Player1 + forehandWinnersSet3Player1;
                forehandWinnerMatchPlayer2 = forehandWinnersSet1Player2 + forehandWinnersSet2Player2 + forehandWinnersSet3Player2;
                backhandWinnerMatchPlayer1 = backhandWinnersSet1Player1 + backhandWinnersSet2Player1 + backhandWinnersSet3Player1;
                backhandWinnerMatchPlayer2 = backhandWinnersSet1Player2 + backhandWinnersSet2Player2 + backhandWinnersSet3Player2;
                //sum unforced errors
                unforcedErrorsMatchPlayer1 = unforcedErrorsSet1Player1 + unforcedErrorsSet2Player1 + unforcedErrorsSet3Player1;
                unforcedErrorsMatchPlayer2 = unforcedErrorsSet1Player2 + unforcedErrorsSet2Player2 + unforcedErrorsSet3Player2;
                forehandUnforcedErrorsMatchPlayer1 = forehandUnforcedErrorsSet1Player1 + forehandUnforcedErrorsSet2Player1 
                    + forehandUnforcedErrorsSet3Player1;
                forehandUnforcedErrorsMatchPlayer2 = forehandUnforcedErrorsSet1Player2 + forehandUnforcedErrorsSet2Player2 
                    + forehandUnforcedErrorsSet3Player2;
                backhandUnforcedErrorsMatchPlayer1 = backhandUnforcedErrorsSet1Player1 + backhandUnforcedErrorsSet2Player1 
                    + backhandUnforcedErrorsSet3Player1;
                backhandUnforcedErrorsMatchPlayer2 = backhandUnforcedErrorsSet1Player2 + backhandUnforcedErrorsSet2Player2 
                    + backhandUnforcedErrorsSet3Player2;
                //sum forced errors
                forcedErrorsMatchPlayer1 = forcedErrorsSet1Player1 + forcedErrorsSet2Player1 + forcedErrorsSet3Player1;
                forcedErrorsMatchPlayer2 = forcedErrorsSet1Player2 + forcedErrorsSet2Player2 + forcedErrorsSet3Player2;
                forehandForcedErrorMatchPlayer1 = forehandForcedErrorsSet1Player1 + forehandForcedErrorsSet2Player1 
                    + forehandForcedErrorsSet3Player1;
                forehandForcedErrorMatchPlayer2 = forehandForcedErrorsSet1Player2 + forehandForcedErrorsSet2Player2 
                    + forehandForcedErrorsSet3Player2;
                backhandForcedErrorMatchPlayer1 = backhandForcedErrorsSet1Player1 + backhandForcedErrorsSet2Player1 
                    + backhandForcedErrorsSet3Player1;
                backhandForcedErrorMatchPlayer2 = backhandForcedErrorsSet1Player2 + backhandForcedErrorsSet2Player2 
                    + backhandForcedErrorsSet3Player2;
                //games returned
                gamesReturnedMatchPlayer1 = gamesServedMatchPlayer2;
                gamesReturnedMatchPlayer2 = gamesServedMatchPlayer1;
                //sum approaches
                approachMatchPlayer1 = approachSet1Player1 + approachSet2Player1 + approachSet3Player1;
                approachMatchPlayer2 = approachSet1Player2 + approachSet2Player2 + approachSet3Player2;
                //sum net points won
                pointsWonNetMatchPlayer1 = pointsWonNetSet1Player1 + pointsWonNetSet2Player1 + pointsWonNetSet3Player1;
                pointsWonNetMatchPlayer2 = pointsWonNetSet1Player2 + pointsWonNetSet2Player2 + pointsWonNetSet3Player2;
                //sum of returning 1st serve won
                returnFirstServeWonMatchPlayer1 = (numberOfServesMatchPlayer2 - faultMatchPlayer2) - pointWon1ServeMatchPlayer2;
                returnFirstServeWonMatchPlayer2 = (numberOfServesMatchPlayer1 - faultMatchPlayer1) - pointWon1ServeMatchPlayer1;
                //sum of returning 2nd serve won
                pointWonReturning2ndServeMatchPlayer1 = pointWonReturning2ndServeSet1Player1 + pointWonReturning2ndServeSet2Player1 +
                    pointWonReturning2ndServeSet3Player1;
                pointWonReturning2ndServeMatchPlayer2 = pointWonReturning2ndServeSet1Player2 + pointWonReturning2ndServeSet2Player2 +
                    pointWonReturning2ndServeSet3Player2;
                //sum break points won
                breakPointWonMatchPlayer2 = breakPointWonSet1Player2 + breakPointWonSet2Player2 + breakPointWonSet3Player2;
                breakPointWonMatchPlayer2 = breakPointWonSet1Player2 + breakPointWonSet2Player2 + breakPointWonSet3Player2;
                //Calc percentage first serve for the match                
                percentFirstServeMatchPlayer1 = (int)(((double)firstServeInMatchPlayer1 / (double)numberOfServesMatchPlayer1) * 100);
                percentFirstServeMatchPlayer2 = (int)(((double)firstServeInMatchPlayer2 / (double)numberOfServesMatchPlayer2) * 100);
                //Check whether the percent is less than zero
                if (percentFirstServeMatchPlayer1 < 0)
                {
                    percentFirstServeMatchPlayer1 = 0;
                    firstServeInMatchPlayer1 = 0;
                    numberOfServesMatchPlayer1 = 0;
                    firstServeInPlayer1Label.Text = firstServeInMatchPlayer1.ToString() + "/" + 
                        numberOfServesMatchPlayer1.ToString() + " (" + percentFirstServeMatchPlayer1.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer1Label.Text = firstServeInMatchPlayer1.ToString() + "/" +
                        numberOfServesMatchPlayer1.ToString() + " (" + percentFirstServeMatchPlayer1.ToString() + "%" + ")";
                }
                if (percentFirstServeMatchPlayer2 < 0)
                {
                    percentFirstServeMatchPlayer2 = 0;
                    firstServeInMatchPlayer2 = 0;
                    numberOfServesMatchPlayer2 = 0;
                    firstServeInPlayer2Label.Text = firstServeInMatchPlayer2.ToString() + "/" +
                        numberOfServesMatchPlayer2.ToString() + " (" + percentFirstServeMatchPlayer2.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer2Label.Text = firstServeInMatchPlayer2.ToString() + "/" +
                        numberOfServesMatchPlayer2.ToString() + " (" + percentFirstServeMatchPlayer2.ToString() + "%" + ")";
                }

                //Calc percentage first serve for the match                
                percentPointsWon1ServeMatchPlayer1 = (int)(((double)pointWon1ServeMatchPlayer1 /
                    (double)firstServeInMatchPlayer1) * 100);
                percentPointsWon1ServeMatchPlayer2 = (int)(((double)pointWon1ServeMatchPlayer2 /
                    (double)firstServeInMatchPlayer2) * 100);
                //POINTS WON 1ST SERVE
                if (percentPointsWon1ServeMatchPlayer1 < 0)
                {
                    percentPointsWon1ServeMatchPlayer1 = 0;
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeMatchPlayer1 + "/" + firstServeInMatchPlayer1 +
                        " (" + percentPointsWon1ServeMatchPlayer1 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeMatchPlayer1 + "/" + firstServeInMatchPlayer1 +
                        " (" + percentPointsWon1ServeMatchPlayer1 + "%" + ")";
                }
                if (percentPointsWon1ServeMatchPlayer2 < 0)
                {
                    percentPointsWon1ServeMatchPlayer2 = 0;
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeMatchPlayer2 + "/" + firstServeInMatchPlayer2 +
                        " (" + percentPointsWon1ServeMatchPlayer2 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeMatchPlayer2 + "/" + firstServeInMatchPlayer2 +
                        " (" + percentPointsWon1ServeMatchPlayer2 + "%" + ")";
                }

                //Percentage point won 2 serve
                percentPointsWon2ndServeMatchPlayer1 = (int)(((double)pointWon2ServeMatchPlayer1 /
                    (double)secondServeInMatchPlayer1) * 100);
                percentPointsWon2ndServeMatchPlayer2 = (int)(((double)pointWon2ServeMatchPlayer2 /
                    (double)secondServeInMatchPlayer2) * 100);

                //POINTS WON 2ND SERVE.
                if (percentPointsWon2ndServeMatchPlayer1 < 0)
                {
                    percentPointsWon2ndServeMatchPlayer1 = 0;
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeMatchPlayer1 + "/" + secondServeInMatchPlayer1
                        + " (" +  percentPointsWon2ndServeMatchPlayer1 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeMatchPlayer1 + "/" + secondServeInMatchPlayer1
                        + " (" + percentPointsWon2ndServeMatchPlayer1 + "%" + ")";
                }
                if (percentPointsWon2ndServeMatchPlayer2 < 0)
                {
                    percentPointsWon2ndServeMatchPlayer2 = 0;
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeMatchPlayer2 + "/" + secondServeInMatchPlayer2
                       + " (" + percentPointsWon2ndServeMatchPlayer2 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeMatchPlayer2 + "/" + secondServeInMatchPlayer2
                       + " (" + percentPointsWon2ndServeMatchPlayer2 + "%" + ")";
                }

                //Breaks Saved
                percentBreaksSavedMatchPlayer1 = (int)(((double)breaksSavedMatchPlayer1 /
                    (double)breaksMatchPlayer2) * 100);
                percentBreaksSavedMatchPlayer2 = (int)(((double)breaksSavedMatchPlayer2 /
                   (double)breaksMatchPlayer1) * 100);

                //Breaks saved
                if (percentBreaksSavedMatchPlayer1 < 0)
                {
                    percentBreaksSavedMatchPlayer1 = 0;
                    breaksSavedPlayer1Label.Text = breaksSavedMatchPlayer1 + "/" + breaksMatchPlayer2 +
                        " (" + percentBreaksSavedMatchPlayer1 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer1Label.Text = breaksSavedMatchPlayer1 + "/" + breaksMatchPlayer2 +
                        " (" + percentBreaksSavedMatchPlayer1 + "%" + ")";
                }
                if (percentBreaksSavedMatchPlayer2 < 0)
                {
                    percentBreaksSavedMatchPlayer2 = 0;
                    breaksSavedPlayer2Label.Text = breaksSavedMatchPlayer2 + "/" + breaksMatchPlayer2 +
                        " (" + percentBreaksSavedMatchPlayer2 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer2Label.Text = breaksSavedMatchPlayer2 + "/" + breaksMatchPlayer2 +
                        " (" + percentBreaksSavedMatchPlayer2 + "%" + ")";
                }

                //Games served
                gamesServedPlayer1Label.Text = gamesServedMatchPlayer1.ToString();
                gamesServedPlayer2Label.Text = gamesServedMatchPlayer2.ToString();

                //Games returned
                gamesReturnedPlayer1Label.Text = gamesReturnedMatchPlayer1.ToString();
                gamesReturnedPlayer2Label.Text = gamesReturnedMatchPlayer2.ToString();

                //Winners
                winnersPlayer1Label.Text = winnerMatchPlayer1.ToString();
                winnersPlayer2Label.Text = winnerMatchPlayer2.ToString();
                forehandWinnersPlayer1Label.Text = forehandWinnerMatchPlayer1.ToString();
                forehandWinnersPlayer2Label.Text = forehandWinnerMatchPlayer2.ToString();
                backhandWinnersPlayer1Label.Text = backhandWinnerMatchPlayer1.ToString();
                backhandWinnersPlayer2Label.Text = backhandWinnerMatchPlayer2.ToString();

                //Unforced errors
                unforcedErrorPlayer1Label.Text = unforcedErrorsMatchPlayer1.ToString();
                unforcedErrorPlayer2Label.Text = unforcedErrorsMatchPlayer2.ToString();
                forehandUnforcedErrorPlayer1Label.Text = forehandUnforcedErrorsMatchPlayer1.ToString();
                forehandUnforcedErrorPlayer2Label.Text = forehandUnforcedErrorsMatchPlayer2.ToString();
                backhandUnforcedErrorPlayer1Label.Text = backhandUnforcedErrorsMatchPlayer1.ToString();
                backhandUnforcedErrorPlayer2Label.Text = backhandUnforcedErrorsMatchPlayer2.ToString();

                //Forced errors
                //Unforced errors
                forcedErrorPlayer1Label.Text = forcedErrorsMatchPlayer1.ToString();
                forcedErrorPlayer2Label.Text = forcedErrorsMatchPlayer2.ToString();
                forehandForcedErrorPlayer1Label.Text = forehandForcedErrorMatchPlayer1.ToString();
                forehandForcedErrorPlayer2Label.Text = forehandForcedErrorMatchPlayer2.ToString();
                backhandForcedErrorPlayer1Label.Text = backhandForcedErrorMatchPlayer1.ToString();
                backhandForcedErrorPlayer2Label.Text = backhandForcedErrorMatchPlayer2.ToString();

                //POINTS WON AT THE NET
                percentPointsWonAtTheNetMatchPlayer1 = (int)(((double)pointsWonNetMatchPlayer1 /
                    approachMatchPlayer1) * 100);
                if (percentPointsWonAtTheNetMatchPlayer1 < 0)
                {
                    percentPointsWonAtTheNetMatchPlayer1 = 0;
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetMatchPlayer1 + "/" + approachMatchPlayer1 +
                        " (" + percentPointsWonAtTheNetMatchPlayer1 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetMatchPlayer1 + "/" + approachMatchPlayer1 +
                        " (" + percentPointsWonAtTheNetMatchPlayer1 + "%" + ")";
                }

                percentPointsWonAtTheNetMatchPlayer2 = (int)(((double)pointsWonNetMatchPlayer2 /
                   approachMatchPlayer2) * 100);
                if (percentPointsWonAtTheNetMatchPlayer2 < 0)
                {
                    percentPointsWonAtTheNetMatchPlayer2 = 0;
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetMatchPlayer2 + "/" + approachMatchPlayer2 +
                        " (" + percentPointsWonAtTheNetMatchPlayer2 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetMatchPlayer2 + "/" + approachMatchPlayer2 +
                        " (" + percentPointsWonAtTheNetMatchPlayer2 + "%" + ")";
                }

                //POINTS WON RETURNING 1ST SERVE.                
                percentFirstServeReturnMatchPlayer1 = (int)(((double)returnFirstServeWonMatchPlayer1 / ((double)numberOfServesMatchPlayer2 - faultMatchPlayer2)) * 100);
                if (percentFirstServeReturnMatchPlayer1 < 0)
                {
                    percentFirstServeReturnMatchPlayer1 = 0;
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonMatchPlayer1 + "/" + firstServeInMatchPlayer2 +
                        " (" + percentFirstServeReturnMatchPlayer1 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonMatchPlayer1 + "/" + firstServeInMatchPlayer2 +
                        " (" + percentFirstServeReturnMatchPlayer1 + "%" + ")";
                }

                percentFirstServeReturnMatchPlayer2 = (int)(((double)returnFirstServeWonMatchPlayer2 / ((double)numberOfServesMatchPlayer1 - faultMatchPlayer1)) * 100);
                if (percentFirstServeReturnMatchPlayer2 < 0)
                {
                    percentFirstServeReturnMatchPlayer2 = 0;
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonMatchPlayer2 + "/" + firstServeInMatchPlayer1 +
                        " (" + percentFirstServeReturnMatchPlayer2 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonMatchPlayer2 + "/" + firstServeInMatchPlayer1 +
                        " (" + percentFirstServeReturnMatchPlayer2 + "%" + ")";
                }

                //POINTS WON RETURNING 2ND SERVE.
                percent2ndServeReturnMatchPlayer1 = (int)(((double)pointWonReturning2ndServeMatchPlayer1 /
                    ((double)faultMatchPlayer2 - doubleFaultMatchPlayer2)) * 100);
                if (percent2ndServeReturnMatchPlayer1 < 0)
                {
                    percent2ndServeReturnMatchPlayer1 = 0;
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeMatchPlayer1 + "/" + (faultMatchPlayer2 - doubleFaultMatchPlayer2) +
                        " (" + percent2ndServeReturnMatchPlayer1 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeMatchPlayer1 + "/" + (faultMatchPlayer2 - doubleFaultMatchPlayer2) +
                        " (" + percent2ndServeReturnMatchPlayer1 + "%" + ")";
                }

                percent2ndServeReturnMatchPlayer2 = (int)(((double)pointWonReturning2ndServeMatchPlayer2 /
                    ((double)faultMatchPlayer1 - doubleFaultMatchPlayer1)) * 100);
                if (percent2ndServeReturnMatchPlayer2 < 0)
                {
                    percent2ndServeReturnMatchPlayer2 = 0;
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeMatchPlayer2 + "/" + (faultMatchPlayer1 - doubleFaultMatchPlayer1) +
                        " (" + percent2ndServeReturnMatchPlayer2 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeMatchPlayer2 + "/" + (faultMatchPlayer1 - doubleFaultMatchPlayer1) +
                        " (" + percent2ndServeReturnMatchPlayer2 + "%" + ")";
                }

                //Break points won.
                percentBreaksWonMatchPlayer1 = (int)(((double)breakPointWonMatchPlayer1 /
                    breaksMatchPlayer1) * 100);
                if (percentBreaksWonMatchPlayer1 < 0)
                {
                    percentBreaksWonMatchPlayer1 = 0;
                    breakPointsWonPlayer1Label.Text = breakPointWonMatchPlayer1 + "/" + breaksMatchPlayer1 +
                        " (" + percentBreaksWonMatchPlayer1 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer1Label.Text = breakPointWonMatchPlayer1 + "/" + breaksMatchPlayer1 +
                        " (" + percentBreaksWonMatchPlayer1 + "%" + ")";
                }

                percentBreaksWonMatchPlayer2 = (int)(((double)breakPointWonMatchPlayer2 /
                   breaksMatchPlayer2) * 100);
                if (percentBreaksWonMatchPlayer2 < 0)
                {
                    percentBreaksWonMatchPlayer2 = 0;
                    breakPointsWonPlayer2Label.Text = breakPointWonMatchPlayer2 + "/" + breaksMatchPlayer2 +
                        " (" + percentBreaksWonMatchPlayer2 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer2Label.Text = breakPointWonMatchPlayer2 + "/" + breaksMatchPlayer2 +
                        " (" + percentBreaksWonMatchPlayer2 + "%" + ")";
                }

                //Percentage of total points won serving
                percentTotalServicePointsWonMatchPlayer1 = (int)(((double)(pointWon1ServeMatchPlayer1 +
                    pointWon2ServeMatchPlayer1) / numberOfServesMatchPlayer1) * 100);
                if (percentTotalServicePointsWonMatchPlayer1 < 0)
                {
                    percentTotalServicePointsWonMatchPlayer1 = 0;
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeMatchPlayer1 + pointWon2ServeMatchPlayer1 +
                        "/" + numberOfServesMatchPlayer1 + " (" + percentTotalServicePointsWonMatchPlayer1 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeMatchPlayer1 + pointWon2ServeMatchPlayer1 +
                        "/" + numberOfServesMatchPlayer1 + " (" + percentTotalServicePointsWonMatchPlayer1 + "%" + ")";
                }
                percentTotalServicePointsWonMatchPlayer2 = (int)(((double)(pointWon1ServeMatchPlayer2 +
                    pointWon2ServeMatchPlayer2) / numberOfServesMatchPlayer2) * 100);
                if (percentTotalServicePointsWonMatchPlayer2 < 0)
                {
                    percentTotalServicePointsWonMatchPlayer2 = 0;
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeMatchPlayer2 + pointWon2ServeMatchPlayer2 +
                        "/" + numberOfServesMatchPlayer2 + " (" + percentTotalServicePointsWonMatchPlayer2 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeMatchPlayer2 + pointWon2ServeMatchPlayer2 +
                        "/" + numberOfServesMatchPlayer2 + " (" + percentTotalServicePointsWonMatchPlayer2 + "%" + ")";
                }

                //Percentage of total points won returning
                percentTotalReturnPointsWonMatchPlayer1 = (int)(((double)(returnFirstServeWonMatchPlayer1 +
                    pointWonReturning2ndServeMatchPlayer1) / numberOfServesMatchPlayer2) * 100);
                if (percentTotalReturnPointsWonMatchPlayer1 < 0)
                {
                    percentTotalReturnPointsWonMatchPlayer1 = 0;
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonMatchPlayer1 + pointWonReturning2ndServeMatchPlayer1 +
                        "/" + numberOfServesMatchPlayer2 + " (" + percentTotalReturnPointsWonMatchPlayer1 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonMatchPlayer1 + pointWonReturning2ndServeMatchPlayer1 +
                        "/" + numberOfServesMatchPlayer2 + " (" + percentTotalReturnPointsWonMatchPlayer1 + "%" + ")";
                }
                percentTotalReturnPointsWonMatchPlayer2 = (int)(((double)(returnFirstServeWonMatchPlayer2 +
                    pointWonReturning2ndServeMatchPlayer2) / numberOfServesMatchPlayer1) * 100);
                if (percentTotalReturnPointsWonMatchPlayer2 < 0)
                {
                    percentTotalReturnPointsWonMatchPlayer2 = 0;
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonMatchPlayer2 + pointWonReturning2ndServeMatchPlayer2 +
                        "/" + numberOfServesMatchPlayer1 + " (" + percentTotalReturnPointsWonMatchPlayer2 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonMatchPlayer2 + pointWonReturning2ndServeMatchPlayer2 +
                        "/" + numberOfServesMatchPlayer1 + " (" + percentTotalReturnPointsWonMatchPlayer2 + "%" + ")";
                }

                //Percentage of total points won.
                percentTotalPointsWonMatchPlayer1 = (int)(((double)(returnFirstServeWonMatchPlayer1 +
                    pointWonReturning2ndServeMatchPlayer1 + pointWon1ServeMatchPlayer1 +
                    pointWon2ServeMatchPlayer1) / (numberOfServesMatchPlayer1 + numberOfServesMatchPlayer2)) * 100);
                if (percentTotalPointsWonMatchPlayer1 < 0)
                {
                    percentTotalPointsWonMatchPlayer1 = 0;
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonMatchPlayer1 +
                    pointWonReturning2ndServeMatchPlayer1 + pointWon1ServeMatchPlayer1 +
                    pointWon2ServeMatchPlayer1) + "/" + (numberOfServesMatchPlayer1 + numberOfServesMatchPlayer2) +
                        " (" + percentTotalPointsWonMatchPlayer1 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonMatchPlayer1 +
                    pointWonReturning2ndServeMatchPlayer1 + pointWon1ServeMatchPlayer1 +
                    pointWon2ServeMatchPlayer1) + "/" + (numberOfServesMatchPlayer1 + numberOfServesMatchPlayer2) +
                        " (" + percentTotalPointsWonMatchPlayer1 + "%" + ")";
                }
                percentTotalPointsWonMatchPlayer2 = (int)(((double)(returnFirstServeWonMatchPlayer2 +
                    pointWonReturning2ndServeMatchPlayer2 + pointWon1ServeMatchPlayer2 +
                    pointWon2ServeMatchPlayer2) / (numberOfServesMatchPlayer2 + numberOfServesMatchPlayer1)) * 100);
                if (percentTotalPointsWonMatchPlayer2 < 0)
                {
                    percentTotalPointsWonMatchPlayer2 = 0;
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonMatchPlayer2 +
                     pointWonReturning2ndServeMatchPlayer2 + pointWon1ServeMatchPlayer2 +
                     pointWon2ServeMatchPlayer2) + "/" + (numberOfServesMatchPlayer2 + numberOfServesMatchPlayer1) +
                         " (" + percentTotalPointsWonMatchPlayer2 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonMatchPlayer2 +
                     pointWonReturning2ndServeMatchPlayer2 + pointWon1ServeMatchPlayer2 +
                     pointWon2ServeMatchPlayer2) + "/" + (numberOfServesMatchPlayer2 + numberOfServesMatchPlayer1) +
                         " (" + percentTotalPointsWonMatchPlayer2 + "%" + ")";
                }

            }


            //CHANGE TO FIRST SET
            else if (matchStatsComboBox.SelectedIndex == 1)
            {
                acePlayer1Label.Text = aceSet1Player1.ToString();
                acePlayer2Label.Text = aceSet1Player2.ToString();
                doubleFaultPlayer1Label.Text = doubleFaultSet1Player1.ToString();
                doubleFaultPlayer2Label.Text = doubleFaultSet1Player2.ToString();
                if (percentFirstServeSet1Player1 < 0)
                {
                    percentFirstServeSet1Player1 = 0;
                    firstServeInSet1Player1 = 0;
                    numberOfServesSet1Player1 = 0;
                    firstServeInPlayer1Label.Text = firstServeInSet1Player1.ToString() + "/" + numberOfServesSet1Player1.ToString() +
                    " (" + percentFirstServeSet1Player1.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer1Label.Text = firstServeInSet1Player1.ToString() + "/" + numberOfServesSet1Player1.ToString() +
                    " (" + percentFirstServeSet1Player1.ToString() + "%" + ")";
                }
                if (percentFirstServeSet1Player2 < 0)
                {
                    percentFirstServeSet1Player2 = 0;
                    firstServeInSet1Player2 = 0;
                    numberOfServesSet1Player2 = 0;
                    firstServeInPlayer2Label.Text = firstServeInSet1Player2.ToString() + "/" + numberOfServesSet1Player2.ToString() +
                    " (" + percentFirstServeSet1Player2.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer2Label.Text = firstServeInSet1Player2.ToString() + "/" + numberOfServesSet1Player2.ToString() +
                    " (" + percentFirstServeSet1Player2.ToString() + "%" + ")";
                }
                //Breaks saved
                if (percentBreaksSavedSet1Player1 < 0)
                {
                    percentBreaksSavedSet1Player1 = 0;
                    breaksSavedPlayer1Label.Text = breaksSavedSet1Player1 + "/" + breaksSet1Player2 +
                        " (" + percentBreaksSavedSet1Player1 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer1Label.Text = breaksSavedSet1Player1 + "/" + breaksSet1Player2 +
                        " (" + percentBreaksSavedSet1Player1 + "%" + ")";
                }
                if (percentBreaksSavedSet1Player2 < 0)
                {
                    percentBreaksSavedSet1Player2 = 0;
                    breaksSavedPlayer2Label.Text = breaksSavedSet1Player2 + "/" + breaksSet1Player1 +
                        " (" + percentBreaksSavedSet1Player2 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer2Label.Text = breaksSavedSet1Player2 + "/" + breaksSet1Player1 +
                        " (" + percentBreaksSavedSet1Player2 + "%" + ")";
                }

                //POINTS WON 1ST SERVE.
                if (percentPointsWon1stServeSet1Player1 < 0)
                {
                    percentPointsWon1stServeSet1Player1 = 0;
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeSet1Player1 + "/" + firstServeInSet1Player1 +
                        " (" + percentPointsWon1stServeSet1Player1 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeSet1Player1 + "/" + firstServeInSet1Player1 +
                         " (" + percentPointsWon1stServeSet1Player1 + "%" + ")";
                }
                if (percentPointsWon1stServeSet1Player2 < 0)
                {
                    percentPointsWon1stServeSet1Player2 = 0;
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeSet1Player2 + "/" + firstServeInSet1Player2 +
                         " (" + percentPointsWon1stServeSet1Player2 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeSet1Player2 + "/" + firstServeInSet1Player2 +
                         " (" + percentPointsWon1stServeSet1Player2 + "%" + ")";
                }

                //POINTS WON 2ND SERVE.
                if (percentPointsWon2ndServeSet1Player1 < 0)
                {
                    percentPointsWon2ndServeSet1Player1 = 0;
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeSet1Player1 + "/" + secondServeInSet1Player1
                         + " (" + percentPointsWon2ndServeSet1Player1 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeSet1Player1 + "/" + secondServeInSet1Player1
                         + " (" + percentPointsWon2ndServeSet1Player1 + "%" + ")";
                }
                if (percentPointsWon2ndServeSet1Player2 < 0)
                {
                    percentPointsWon2ndServeSet1Player2 = 0;
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeSet1Player2 + "/" + secondServeInSet1Player2
                        + " (" + percentPointsWon2ndServeSet1Player2 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeSet1Player2 + "/" + secondServeInSet1Player2
                        + " (" + percentPointsWon2ndServeSet1Player2 + "%" + ")";
                }

                //Games served
                gamesServedPlayer1Label.Text = gamesServedSet1Player1.ToString();
                gamesServedPlayer2Label.Text = gamesServedSet1Player2.ToString();

                //Games returned
                gamesReturnedSet1Player1 = gamesServedSet1Player2;
                gamesReturnedSet1Player2 = gamesServedSet1Player1;
                gamesReturnedPlayer1Label.Text = gamesReturnedSet1Player1.ToString();
                gamesReturnedPlayer2Label.Text = gamesReturnedSet1Player2.ToString();

                //Winners
                winnersPlayer1Label.Text = winnersSet1Player1.ToString();
                winnersPlayer2Label.Text = winnersSet1Player2.ToString();
                forehandWinnersPlayer1Label.Text = forehandWinnersSet1Player1.ToString();
                forehandWinnersPlayer2Label.Text = forehandWinnersSet1Player2.ToString();
                backhandWinnersPlayer1Label.Text = backhandWinnersSet1Player1.ToString();
                backhandWinnersPlayer2Label.Text = backhandWinnersSet1Player2.ToString();

                //Unforced errors
                unforcedErrorPlayer1Label.Text = unforcedErrorsSet1Player1.ToString();
                unforcedErrorPlayer2Label.Text = unforcedErrorsSet1Player2.ToString();
                forehandUnforcedErrorPlayer1Label.Text = forehandUnforcedErrorsSet1Player1.ToString();
                forehandUnforcedErrorPlayer2Label.Text = forehandUnforcedErrorsSet1Player2.ToString();
                backhandUnforcedErrorPlayer1Label.Text = backhandUnforcedErrorsSet1Player1.ToString();
                backhandUnforcedErrorPlayer2Label.Text = backhandUnforcedErrorsSet1Player2.ToString();

                //Forced errors
                //Unforced errors
                forcedErrorPlayer1Label.Text = forcedErrorsSet1Player1.ToString();
                forcedErrorPlayer2Label.Text = forcedErrorsSet1Player2.ToString();
                forehandForcedErrorPlayer1Label.Text = forehandForcedErrorsSet1Player1.ToString();
                forehandForcedErrorPlayer2Label.Text = forehandForcedErrorsSet1Player2.ToString();
                backhandForcedErrorPlayer1Label.Text = backhandForcedErrorsSet1Player1.ToString();
                backhandForcedErrorPlayer2Label.Text = backhandForcedErrorsSet1Player2.ToString();

                //POINTS WON RETURNING 1ST SERVE.
                returnFirstServeWonSet1Player1 = (numberOfServesSet1Player2 - faultSet1Player2) - pointWon1ServeSet1Player2;
                percentFirstServeReturnSet1Player1 = (int)(((double)returnFirstServeWonSet1Player1 / ((double)numberOfServesSet1Player2 - faultSet1Player2)) * 100);
                if (percentFirstServeReturnSet1Player1 < 0)
                {
                    percentFirstServeReturnSet1Player1 = 0;
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet1Player1 + "/" + firstServeInSet1Player2 +
                        " (" + percentFirstServeReturnSet1Player1 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet1Player1 + "/" + firstServeInSet1Player2 +
                        " (" + percentFirstServeReturnSet1Player1 + "%" + ")";
                }

                returnFirstServeWonSet1Player2 = (numberOfServesSet1Player1 - faultSet1Player1) - pointWon1ServeSet1Player1;
                percentFirstServeReturnSet1Player2 = (int)(((double)returnFirstServeWonSet1Player2 / ((double)numberOfServesSet1Player1 - faultSet1Player1)) * 100);
                if (percentFirstServeReturnSet1Player2 < 0)
                {
                    percentFirstServeReturnSet1Player2 = 0;
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet1Player2 + "/" + firstServeInSet1Player1 +
                        " (" + percentFirstServeReturnSet1Player2 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet1Player2 + "/" + firstServeInSet1Player1 +
                        " (" + percentFirstServeReturnSet1Player2 + "%" + ")";
                }

                //Return won 2nd serve
                percentPointsWon2ndServeSet1Player1 = (int)(((double)pointWonReturning2ndServeSet1Player1 /
                    ((double)faultSet1Player2 - doubleFaultSet1Player2)) * 100);
                if (percentPointsWon2ndServeSet1Player1 < 0)
                {
                    percentPointsWon2ndServeSet1Player1 = 0;
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeSet1Player1 + "/" + (faultSet1Player2 - doubleFaultSet1Player2) +
                        " (" + percentPointsWon2ndServeSet1Player1 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeSet1Player1 + "/" + (faultSet1Player2 - doubleFaultSet1Player2) +
                        " (" + percentPointsWon2ndServeSet1Player1 + "%" + ")";
                }

                percentPointsWon2ndServeSet1Player2 = (int)(((double)pointWonReturning2ndServeSet1Player2 /
                    ((double)faultSet1Player1 - doubleFaultSet1Player1)) * 100);
                if (percentPointsWon2ndServeSet1Player2 < 0)
                {
                    percentPointsWon2ndServeSet1Player2 = 0;
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeSet1Player2 + "/" + (faultSet1Player1 - doubleFaultSet1Player1) +
                        " (" + percentPointsWon2ndServeSet1Player2 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeSet1Player2 + "/" + (faultSet1Player1 - doubleFaultSet1Player1) +
                        " (" + percentPointsWon2ndServeSet1Player2 + "%" + ")";
                }

                //Break points won.
                percentBreaksWonSet1Player1 = (int)(((double)breakPointWonSet1Player1 /
                    breaksSet1Player1) * 100);
                if (percentBreaksWonSet1Player1 < 0)
                {
                    percentBreaksWonSet1Player1 = 0;
                    breakPointsWonPlayer1Label.Text = breakPointWonSet1Player1 + "/" + breaksSet1Player1 +
                        " (" + percentBreaksWonSet1Player1 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer1Label.Text = breakPointWonSet1Player1 + "/" + breaksSet1Player1 +
                        " (" + percentBreaksWonSet1Player1 + "%" + ")";
                }

                percentBreaksWonSet1Player2 = (int)(((double)breakPointWonSet1Player2 /
                   breaksSet1Player2) * 100);
                if (percentBreaksWonSet1Player2 < 0)
                {
                    percentBreaksWonSet1Player2 = 0;
                    breakPointsWonPlayer2Label.Text = breakPointWonSet1Player2 + "/" + breaksSet1Player2 +
                        " (" + percentBreaksWonSet1Player2 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer2Label.Text = breakPointWonSet1Player2 + "/" + breaksSet1Player2 +
                        " (" + percentBreaksWonSet1Player2 + "%" + ")";
                }

                //Percentage of total points won serving
                percentTotalServicePointsWonSet1Player1 = (int)(((double)(pointWon1ServeSet1Player1 +
                    pointWon2ServeSet1Player1) / numberOfServesSet1Player1) * 100);
                if (percentTotalServicePointsWonSet1Player1 < 0)
                {
                    percentTotalServicePointsWonSet1Player1 = 0;
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeSet1Player1 + pointWon2ServeSet1Player1 +
                        "/" + numberOfServesSet1Player1 + " (" + percentTotalServicePointsWonSet1Player1 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeSet1Player1 + pointWon2ServeSet1Player1 +
                        "/" + numberOfServesSet1Player1 + " (" + percentTotalServicePointsWonSet1Player1 + "%" + ")";
                }
                percentTotalServicePointsWonSet1Player2 = (int)(((double)(pointWon1ServeSet1Player2 +
                    pointWon2ServeSet1Player2) / numberOfServesSet1Player2) * 100);
                if (percentTotalServicePointsWonSet1Player2 < 0)
                {
                    percentTotalServicePointsWonSet1Player2 = 0;
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeSet1Player2 + pointWon2ServeSet1Player2 +
                        "/" + numberOfServesSet1Player2 + " (" + percentTotalServicePointsWonSet1Player2 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeSet1Player2 + pointWon2ServeSet1Player2 +
                        "/" + numberOfServesSet1Player2 + " (" + percentTotalServicePointsWonSet1Player2 + "%" + ")";
                }

                //Percentage of total points won returning
                percentTotalReturnPointsWonSet1Player1 = (int)(((double)(returnFirstServeWonSet1Player1 +
                    pointWonReturning2ndServeSet1Player1) / numberOfServesSet1Player2) * 100);
                if (percentTotalReturnPointsWonSet1Player1 < 0)
                {
                    percentTotalReturnPointsWonSet1Player1 = 0;
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet1Player1 + pointWonReturning2ndServeSet1Player1 +
                        "/" + numberOfServesSet1Player2 + " (" + percentTotalReturnPointsWonSet1Player1 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet1Player1 + pointWonReturning2ndServeSet1Player1 +
                        "/" + numberOfServesSet1Player2 + " (" + percentTotalReturnPointsWonSet1Player1 + "%" + ")";
                }
                percentTotalReturnPointsWonSet1Player2 = (int)(((double)(returnFirstServeWonSet1Player2 +
                    pointWonReturning2ndServeSet1Player2) / numberOfServesSet1Player1) * 100);
                if (percentTotalReturnPointsWonSet1Player2 < 0)
                {
                    percentTotalReturnPointsWonSet1Player2 = 0;
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet1Player2 + pointWonReturning2ndServeSet1Player2 +
                        "/" + numberOfServesSet1Player1 + " (" + percentTotalReturnPointsWonSet1Player2 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet1Player2 + pointWonReturning2ndServeSet1Player2 +
                        "/" + numberOfServesSet1Player1 + " (" + percentTotalReturnPointsWonSet1Player2 + "%" + ")";
                }

                //Percentage of total points won.
                percentTotalPointsWonSet1Player1 = (int)(((double)(returnFirstServeWonSet1Player1 +
                    pointWonReturning2ndServeSet1Player1 + pointWon1ServeSet1Player1 +
                    pointWon2ServeSet1Player1) / (numberOfServesSet1Player1 + numberOfServesSet1Player2)) * 100);
                if (percentTotalPointsWonSet1Player1 < 0)
                {
                    percentTotalPointsWonSet1Player1 = 0;
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonSet1Player1 +
                    pointWonReturning2ndServeSet1Player1 + pointWon1ServeSet1Player1 +
                    pointWon2ServeSet1Player1) + "/" + (numberOfServesSet1Player1 + numberOfServesSet1Player2) +
                        " (" + percentTotalPointsWonSet1Player1 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonSet1Player1 +
                    pointWonReturning2ndServeSet1Player1 + pointWon1ServeSet1Player1 +
                    pointWon2ServeSet1Player1) + "/" + (numberOfServesSet1Player1 + numberOfServesSet1Player2) +
                        " (" + percentTotalPointsWonSet1Player1 + "%" + ")";
                }
                percentTotalPointsWonSet1Player2 = (int)(((double)(returnFirstServeWonSet1Player2 +
                    pointWonReturning2ndServeSet1Player2 + pointWon1ServeSet1Player2 +
                    pointWon2ServeSet1Player2) / (numberOfServesSet1Player2 + numberOfServesSet1Player1)) * 100);
                if (percentTotalPointsWonSet1Player2 < 0)
                {
                    percentTotalPointsWonSet1Player2 = 0;
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonSet1Player2 +
                     pointWonReturning2ndServeSet1Player2 + pointWon1ServeSet1Player2 +
                     pointWon2ServeSet1Player2) + "/" + (numberOfServesSet1Player2 + numberOfServesSet1Player1) +
                         " (" + percentTotalPointsWonSet1Player2 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonSet1Player2 +
                     pointWonReturning2ndServeSet1Player2 + pointWon1ServeSet1Player2 +
                     pointWon2ServeSet1Player2) + "/" + (numberOfServesSet1Player2 + numberOfServesSet1Player1) +
                         " (" + percentTotalPointsWonSet1Player2 + "%" + ")";
                }

                //Percentage points won at the net
                percentPointsWonAtTheNetSet1Player1 = (int)(((double)pointsWonNetSet1Player1 /
                    approachSet1Player1) * 100);
                if (percentPointsWonAtTheNetSet1Player1 < 0)
                {
                    percentPointsWonAtTheNetSet1Player1 = 0;
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetSet1Player1 + "/" + approachSet1Player1 +
                        " (" + percentPointsWonAtTheNetSet1Player1 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetSet1Player1 + "/" + approachSet1Player1 +
                        " (" + percentPointsWonAtTheNetSet1Player1 + "%" + ")";
                }

                percentPointsWonAtTheNetSet1Player2 = (int)(((double)pointsWonNetSet1Player2 /
                   approachSet1Player2) * 100);
                if (percentPointsWonAtTheNetSet1Player2 < 0)
                {
                    percentPointsWonAtTheNetSet1Player2 = 0;
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetSet1Player2 + "/" + approachSet1Player2 +
                        " (" + percentPointsWonAtTheNetSet1Player2 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetSet1Player2 + "/" + approachSet1Player2 +
                        " (" + percentPointsWonAtTheNetSet1Player2 + "%" + ")";
                }
            }
            //CHANGE TO SECOND SET
            else if (matchStatsComboBox.SelectedIndex == 2)
            {
                acePlayer1Label.Text = aceSet2Player1.ToString();
                acePlayer2Label.Text = aceSet2Player2.ToString();
                doubleFaultPlayer1Label.Text = doubleFaultSet2Player1.ToString();
                doubleFaultPlayer2Label.Text = doubleFaultSet2Player2.ToString();
                if (percentFirstServeSet2Player1 < 0)
                {
                    percentFirstServeSet2Player1 = 0;
                    firstServeInSet2Player1 = 0;
                    numberOfServesSet2Player1 = 0;
                    firstServeInPlayer1Label.Text = firstServeInSet2Player1.ToString() + "/" + numberOfServesSet2Player1.ToString() +
                    " (" + percentFirstServeSet2Player1.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer1Label.Text = firstServeInSet2Player1.ToString() + "/" + numberOfServesSet2Player1.ToString() +
                    " (" + percentFirstServeSet2Player1.ToString() + "%" + ")";
                }
                if (percentFirstServeSet2Player2 < 0)
                {
                    percentFirstServeSet2Player2 = 0;
                    firstServeInSet2Player2 = 0;
                    numberOfServesSet2Player2 = 0;
                    firstServeInPlayer2Label.Text = firstServeInSet2Player2.ToString() + "/" + numberOfServesSet2Player2.ToString() +
                    " (" + percentFirstServeSet2Player2.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer2Label.Text = firstServeInSet2Player2.ToString() + "/" + numberOfServesSet2Player2.ToString() +
                    " (" + percentFirstServeSet2Player2.ToString() + "%" + ")";
                }
                //Breaks saved
                if (percentBreaksSavedSet2Player1 < 0)
                {
                    percentBreaksSavedSet2Player1 = 0;
                    breaksSavedPlayer1Label.Text = breaksSavedSet2Player1 + "/" + breaksSet2Player2 +
                        " (" + percentBreaksSavedSet2Player1 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer1Label.Text = breaksSavedSet2Player1 + "/" + breaksSet2Player2 +
                        " (" + percentBreaksSavedSet2Player1 + "%" + ")";
                }
                if (percentBreaksSavedSet2Player2 < 0)
                {
                    percentBreaksSavedSet2Player2 = 0;
                    breaksSavedPlayer2Label.Text = breaksSavedSet2Player2 + "/" + breaksSet2Player1 +
                        " (" + percentBreaksSavedSet2Player2 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer2Label.Text = breaksSavedSet2Player2 + "/" + breaksSet2Player1 +
                        " (" + percentBreaksSavedSet2Player2 + "%" + ")";
                }

                //POINTS WON 1ST SERVE.
                if (percentPointsWon1stServeSet2Player1 < 0)
                {
                    percentPointsWon1stServeSet2Player1 = 0;
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeSet2Player1 + "/" + firstServeInSet2Player1 +
                        " (" + percentPointsWon1stServeSet2Player1 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeSet2Player1 + "/" + firstServeInSet2Player1 +
                         " (" + percentPointsWon1stServeSet2Player1 + "%" + ")";
                }
                if (percentPointsWon1stServeSet2Player2 < 0)
                {
                    percentPointsWon1stServeSet2Player2 = 0;
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeSet2Player2 + "/" + firstServeInSet2Player2 +
                         " (" + percentPointsWon1stServeSet2Player2 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeSet2Player2 + "/" + firstServeInSet2Player2 +
                         " (" + percentPointsWon1stServeSet2Player2 + "%" + ")";
                }

                //POINTS WON 2ND SERVE.
                if (percentPointsWon2ndServeSet2Player1 < 0)
                {
                    percentPointsWon2ndServeSet2Player1 = 0;
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeSet2Player1 + "/" + secondServeInSet2Player1
                         + " (" + percentPointsWon2ndServeSet2Player1 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeSet2Player1 + "/" + secondServeInSet2Player1
                         + " (" + percentPointsWon2ndServeSet2Player1 + "%" + ")";
                }
                if (percentPointsWon2ndServeSet2Player2 < 0)
                {
                    percentPointsWon2ndServeSet2Player2 = 0;
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeSet2Player2 + "/" + secondServeInSet2Player2
                        + " (" + percentPointsWon2ndServeSet2Player2 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeSet2Player2 + "/" + secondServeInSet2Player2
                        + " (" + percentPointsWon2ndServeSet2Player2 + "%" + ")";
                }

                //Games served
                gamesServedPlayer1Label.Text = gamesServedSet2Player1.ToString();
                gamesServedPlayer2Label.Text = gamesServedSet2Player2.ToString();

                //Games returned
                gamesReturnedSet2Player1 = gamesServedSet2Player2;
                gamesReturnedSet2Player2 = gamesServedSet2Player1;
                gamesReturnedPlayer1Label.Text = gamesReturnedSet2Player1.ToString();
                gamesReturnedPlayer2Label.Text = gamesReturnedSet2Player2.ToString();

                //Winners
                winnersPlayer1Label.Text = winnersSet2Player1.ToString();
                winnersPlayer2Label.Text = winnersSet2Player2.ToString();
                forehandWinnersPlayer1Label.Text = forehandWinnersSet2Player1.ToString();
                forehandWinnersPlayer2Label.Text = forehandWinnersSet2Player2.ToString();
                backhandWinnersPlayer1Label.Text = backhandWinnersSet2Player1.ToString();
                backhandWinnersPlayer2Label.Text = backhandWinnersSet2Player2.ToString();

                //Unforced errors
                unforcedErrorPlayer1Label.Text = unforcedErrorsSet2Player1.ToString();
                unforcedErrorPlayer2Label.Text = unforcedErrorsSet2Player2.ToString();
                forehandUnforcedErrorPlayer1Label.Text = forehandUnforcedErrorsSet2Player1.ToString();
                forehandUnforcedErrorPlayer2Label.Text = forehandUnforcedErrorsSet2Player2.ToString();
                backhandUnforcedErrorPlayer1Label.Text = backhandUnforcedErrorsSet2Player1.ToString();
                backhandUnforcedErrorPlayer2Label.Text = backhandUnforcedErrorsSet2Player2.ToString();

                //Forced errors
                //Unforced errors
                forcedErrorPlayer1Label.Text = forcedErrorsSet2Player1.ToString();
                forcedErrorPlayer2Label.Text = forcedErrorsSet2Player2.ToString();
                forehandForcedErrorPlayer1Label.Text = forehandForcedErrorsSet2Player1.ToString();
                forehandForcedErrorPlayer2Label.Text = forehandForcedErrorsSet2Player2.ToString();
                backhandForcedErrorPlayer1Label.Text = backhandForcedErrorsSet2Player1.ToString();
                backhandForcedErrorPlayer2Label.Text = backhandForcedErrorsSet2Player2.ToString();

                //POINTS WON RETURNING 1ST SERVE.
                returnFirstServeWonSet2Player1 = (numberOfServesSet2Player2 - faultSet2Player2) - pointWon1ServeSet2Player2;
                percentFirstServeReturnSet2Player1 = (int)(((double)returnFirstServeWonSet2Player1 / ((double)numberOfServesSet2Player2 - faultSet2Player2)) * 100);
                if (percentFirstServeReturnSet2Player1 < 0)
                {
                    percentFirstServeReturnSet2Player1 = 0;
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet2Player1 + "/" + firstServeInSet2Player2 +
                        " (" + percentFirstServeReturnSet2Player1 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet2Player1 + "/" + firstServeInSet2Player2 +
                        " (" + percentFirstServeReturnSet2Player1 + "%" + ")";
                }

                returnFirstServeWonSet2Player2 = (numberOfServesSet2Player1 - faultSet2Player1) - pointWon1ServeSet2Player1;
                percentFirstServeReturnSet2Player2 = (int)(((double)returnFirstServeWonSet2Player2 / ((double)numberOfServesSet2Player1 - faultSet2Player1)) * 100);
                if (percentFirstServeReturnSet2Player2 < 0)
                {
                    percentFirstServeReturnSet2Player2 = 0;
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet2Player2 + "/" + firstServeInSet2Player1 +
                        " (" + percentFirstServeReturnSet2Player2 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet2Player2 + "/" + firstServeInSet2Player1 +
                        " (" + percentFirstServeReturnSet2Player2 + "%" + ")";
                }

                //Return won 2nd serve
                percentPointsWon2ndServeSet2Player1 = (int)(((double)pointWonReturning2ndServeSet2Player1 /
                    ((double)faultSet2Player2 - doubleFaultSet2Player2)) * 100);
                if (percentPointsWon2ndServeSet2Player1 < 0)
                {
                    percentPointsWon2ndServeSet2Player1 = 0;
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeSet2Player1 + "/" + (faultSet2Player2 - doubleFaultSet2Player2) +
                        " (" + percentPointsWon2ndServeSet2Player1 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeSet2Player1 + "/" + (faultSet2Player2 - doubleFaultSet2Player2) +
                        " (" + percentPointsWon2ndServeSet2Player1 + "%" + ")";
                }

                percentPointsWon2ndServeSet2Player2 = (int)(((double)pointWonReturning2ndServeSet2Player2 /
                    ((double)faultSet2Player1 - doubleFaultSet2Player1)) * 100);
                if (percentPointsWon2ndServeSet2Player2 < 0)
                {
                    percentPointsWon2ndServeSet2Player2 = 0;
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeSet2Player2 + "/" + (faultSet2Player1 - doubleFaultSet2Player1) +
                        " (" + percentPointsWon2ndServeSet2Player2 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeSet2Player2 + "/" + (faultSet2Player1 - doubleFaultSet2Player1) +
                        " (" + percentPointsWon2ndServeSet2Player2 + "%" + ")";
                }

                //Break points won.
                percentBreaksWonSet2Player1 = (int)(((double)breakPointWonSet2Player1 /
                    breaksSet2Player1) * 100);
                if (percentBreaksWonSet2Player1 < 0)
                {
                    percentBreaksWonSet2Player1 = 0;
                    breakPointsWonPlayer1Label.Text = breakPointWonSet2Player1 + "/" + breaksSet2Player1 +
                        " (" + percentBreaksWonSet2Player1 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer1Label.Text = breakPointWonSet2Player1 + "/" + breaksSet2Player1 +
                        " (" + percentBreaksWonSet2Player1 + "%" + ")";
                }

                percentBreaksWonSet2Player2 = (int)(((double)breakPointWonSet2Player2 /
                   breaksSet2Player2) * 100);
                if (percentBreaksWonSet2Player2 < 0)
                {
                    percentBreaksWonSet2Player2 = 0;
                    breakPointsWonPlayer2Label.Text = breakPointWonSet2Player2 + "/" + breaksSet2Player2 +
                        " (" + percentBreaksWonSet2Player2 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer2Label.Text = breakPointWonSet2Player2 + "/" + breaksSet2Player2 +
                        " (" + percentBreaksWonSet2Player2 + "%" + ")";
                }

                //Percentage of total points won serving
                percentTotalServicePointsWonSet2Player1 = (int)(((double)(pointWon1ServeSet2Player1 +
                    pointWon2ServeSet2Player1) / numberOfServesSet2Player1) * 100);
                if (percentTotalServicePointsWonSet2Player1 < 0)
                {
                    percentTotalServicePointsWonSet2Player1 = 0;
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeSet2Player1 + pointWon2ServeSet2Player1 +
                        "/" + numberOfServesSet2Player1 + " (" + percentTotalServicePointsWonSet2Player1 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeSet2Player1 + pointWon2ServeSet2Player1 +
                        "/" + numberOfServesSet2Player1 + " (" + percentTotalServicePointsWonSet2Player1 + "%" + ")";
                }
                percentTotalServicePointsWonSet2Player2 = (int)(((double)(pointWon1ServeSet2Player2 +
                    pointWon2ServeSet2Player2) / numberOfServesSet2Player2) * 100);
                if (percentTotalServicePointsWonSet2Player2 < 0)
                {
                    percentTotalServicePointsWonSet2Player2 = 0;
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeSet2Player2 + pointWon2ServeSet2Player2 +
                        "/" + numberOfServesSet2Player2 + " (" + percentTotalServicePointsWonSet2Player2 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeSet2Player2 + pointWon2ServeSet2Player2 +
                        "/" + numberOfServesSet2Player2 + " (" + percentTotalServicePointsWonSet2Player2 + "%" + ")";
                }

                //Percentage of total points won returning
                percentTotalReturnPointsWonSet2Player1 = (int)(((double)(returnFirstServeWonSet2Player1 +
                    pointWonReturning2ndServeSet2Player1) / numberOfServesSet2Player2) * 100);
                if (percentTotalReturnPointsWonSet2Player1 < 0)
                {
                    percentTotalReturnPointsWonSet2Player1 = 0;
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet2Player1 + pointWonReturning2ndServeSet2Player1 +
                        "/" + numberOfServesSet2Player2 + " (" + percentTotalReturnPointsWonSet2Player1 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet2Player1 + pointWonReturning2ndServeSet2Player1 +
                        "/" + numberOfServesSet2Player2 + " (" + percentTotalReturnPointsWonSet2Player1 + "%" + ")";
                }
                percentTotalReturnPointsWonSet2Player2 = (int)(((double)(returnFirstServeWonSet2Player2 +
                    pointWonReturning2ndServeSet2Player2) / numberOfServesSet2Player1) * 100);
                if (percentTotalReturnPointsWonSet2Player2 < 0)
                {
                    percentTotalReturnPointsWonSet2Player2 = 0;
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet2Player2 + pointWonReturning2ndServeSet2Player2 +
                        "/" + numberOfServesSet2Player1 + " (" + percentTotalReturnPointsWonSet2Player2 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet2Player2 + pointWonReturning2ndServeSet2Player2 +
                        "/" + numberOfServesSet2Player1 + " (" + percentTotalReturnPointsWonSet2Player2 + "%" + ")";
                }

                //Percentage of total points won.
                percentTotalPointsWonSet2Player1 = (int)(((double)(returnFirstServeWonSet2Player1 +
                    pointWonReturning2ndServeSet2Player1 + pointWon1ServeSet2Player1 +
                    pointWon2ServeSet2Player1) / (numberOfServesSet2Player1 + numberOfServesSet2Player2)) * 100);
                if (percentTotalPointsWonSet2Player1 < 0)
                {
                    percentTotalPointsWonSet2Player1 = 0;
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonSet2Player1 +
                    pointWonReturning2ndServeSet2Player1 + pointWon1ServeSet2Player1 +
                    pointWon2ServeSet2Player1) + "/" + (numberOfServesSet2Player1 + numberOfServesSet2Player2) +
                        " (" + percentTotalPointsWonSet2Player1 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonSet2Player1 +
                    pointWonReturning2ndServeSet2Player1 + pointWon1ServeSet2Player1 +
                    pointWon2ServeSet2Player1) + "/" + (numberOfServesSet2Player1 + numberOfServesSet2Player2) +
                        " (" + percentTotalPointsWonSet2Player1 + "%" + ")";
                }
                percentTotalPointsWonSet2Player2 = (int)(((double)(returnFirstServeWonSet2Player2 +
                    pointWonReturning2ndServeSet2Player2 + pointWon1ServeSet2Player2 +
                    pointWon2ServeSet2Player2) / (numberOfServesSet2Player2 + numberOfServesSet2Player1)) * 100);
                if (percentTotalPointsWonSet2Player2 < 0)
                {
                    percentTotalPointsWonSet2Player2 = 0;
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonSet2Player2 +
                     pointWonReturning2ndServeSet2Player2 + pointWon1ServeSet2Player2 +
                     pointWon2ServeSet2Player2) + "/" + (numberOfServesSet2Player2 + numberOfServesSet2Player1) +
                         " (" + percentTotalPointsWonSet2Player2 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonSet2Player2 +
                     pointWonReturning2ndServeSet2Player2 + pointWon1ServeSet2Player2 +
                     pointWon2ServeSet2Player2) + "/" + (numberOfServesSet2Player2 + numberOfServesSet2Player1) +
                         " (" + percentTotalPointsWonSet2Player2 + "%" + ")";
                }

                //Percentage points won at the net
                percentPointsWonAtTheNetSet2Player1 = (int)(((double)pointsWonNetSet2Player1 /
                    approachSet2Player1) * 100);
                if (percentPointsWonAtTheNetSet2Player1 < 0)
                {
                    percentPointsWonAtTheNetSet2Player1 = 0;
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetSet2Player1 + "/" + approachSet2Player1 +
                        " (" + percentPointsWonAtTheNetSet2Player1 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetSet2Player1 + "/" + approachSet2Player1 +
                        " (" + percentPointsWonAtTheNetSet2Player1 + "%" + ")";
                }

                percentPointsWonAtTheNetSet2Player2 = (int)(((double)pointsWonNetSet2Player2 /
                   approachSet2Player2) * 100);
                if (percentPointsWonAtTheNetSet2Player2 < 0)
                {
                    percentPointsWonAtTheNetSet2Player2 = 0;
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetSet2Player2 + "/" + approachSet2Player2 +
                        " (" + percentPointsWonAtTheNetSet2Player2 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetSet2Player2 + "/" + approachSet2Player2 +
                        " (" + percentPointsWonAtTheNetSet2Player2 + "%" + ")";
                }
            }
            //CHANGE TO 3RD SET
            else if (matchStatsComboBox.SelectedIndex == 3)
            {
                acePlayer1Label.Text = aceSet3Player1.ToString();
                acePlayer2Label.Text = aceSet3Player2.ToString();
                doubleFaultPlayer1Label.Text = doubleFaultSet3Player1.ToString();
                doubleFaultPlayer2Label.Text = doubleFaultSet3Player2.ToString();
                if (percentFirstServeSet3Player1 < 0)
                {
                    percentFirstServeSet3Player1 = 0;
                    firstServeInSet3Player1 = 0;
                    numberOfServesSet3Player1 = 0;
                    firstServeInPlayer1Label.Text = firstServeInSet3Player1.ToString() + "/" + numberOfServesSet3Player1.ToString() +
                    " (" + percentFirstServeSet3Player1.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer1Label.Text = firstServeInSet3Player1.ToString() + "/" + numberOfServesSet3Player1.ToString() +
                    " (" + percentFirstServeSet3Player1.ToString() + "%" + ")";
                }
                if (percentFirstServeSet3Player2 < 0)
                {
                    percentFirstServeSet3Player2 = 0;
                    firstServeInSet3Player2 = 0;
                    numberOfServesSet3Player2 = 0;
                    firstServeInPlayer2Label.Text = firstServeInSet3Player2.ToString() + "/" + numberOfServesSet3Player2.ToString() +
                    " (" + percentFirstServeSet3Player2.ToString() + "%" + ")";
                }
                else
                {
                    firstServeInPlayer2Label.Text = firstServeInSet3Player2.ToString() + "/" + numberOfServesSet3Player2.ToString() +
                    " (" + percentFirstServeSet3Player2.ToString() + "%" + ")";
                }
                //Breaks saved
                if (percentBreaksSavedSet3Player1 < 0)
                {
                    percentBreaksSavedSet3Player1 = 0;
                    breaksSavedPlayer1Label.Text = breaksSavedSet3Player1 + "/" + breaksSet3Player2 +
                        " (" + percentBreaksSavedSet3Player1 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer1Label.Text = breaksSavedSet3Player1 + "/" + breaksSet3Player2 +
                        " (" + percentBreaksSavedSet3Player1 + "%" + ")";
                }
                if (percentBreaksSavedSet3Player2 < 0)
                {
                    percentBreaksSavedSet3Player2 = 0;
                    breaksSavedPlayer2Label.Text = breaksSavedSet3Player2 + "/" + breaksSet3Player1 +
                        " (" + percentBreaksSavedSet3Player2 + "%" + ")";
                }
                else
                {
                    breaksSavedPlayer2Label.Text = breaksSavedSet3Player2 + "/" + breaksSet3Player1 +
                        " (" + percentBreaksSavedSet3Player2 + "%" + ")";
                }

                //POINTS WON 1ST SERVE.
                if (percentPointsWon1stServeSet3Player1 < 0)
                {
                    percentPointsWon1stServeSet3Player1 = 0;
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeSet3Player1 + "/" + firstServeInSet3Player1 +
                        " (" + percentPointsWon1stServeSet3Player1 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer1Label.Text = pointWon1ServeSet3Player1 + "/" + firstServeInSet3Player1 +
                         " (" + percentPointsWon1stServeSet3Player1 + "%" + ")";
                }
                if (percentPointsWon1stServeSet3Player2 < 0)
                {
                    percentPointsWon1stServeSet3Player2 = 0;
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeSet3Player2 + "/" + firstServeInSet3Player2 +
                         " (" + percentPointsWon1stServeSet3Player2 + "%" + ")";
                }
                else
                {
                    pointsWon1stServePlayer2Label.Text = pointWon1ServeSet3Player2 + "/" + firstServeInSet3Player2 +
                         " (" + percentPointsWon1stServeSet3Player2 + "%" + ")";
                }

                //POINTS WON 2ND SERVE.
                if (percentPointsWon2ndServeSet3Player1 < 0)
                {
                    percentPointsWon2ndServeSet3Player1 = 0;
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeSet3Player1 + "/" + secondServeInSet3Player1
                         + " (" + percentPointsWon2ndServeSet3Player1 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer1Label.Text = pointWon2ServeSet3Player1 + "/" + secondServeInSet3Player1
                         + " (" + percentPointsWon2ndServeSet3Player1 + "%" + ")";
                }
                if (percentPointsWon2ndServeSet3Player2 < 0)
                {
                    percentPointsWon2ndServeSet3Player2 = 0;
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeSet3Player2 + "/" + secondServeInSet3Player2
                        + " (" + percentPointsWon2ndServeSet3Player2 + "%" + ")";
                }
                else
                {
                    pointsWon2ndServePlayer2Label.Text = pointWon2ServeSet3Player2 + "/" + secondServeInSet3Player2
                        + " (" + percentPointsWon2ndServeSet3Player2 + "%" + ")";
                }

                //Games served
                gamesServedPlayer1Label.Text = gamesServedSet3Player1.ToString();
                gamesServedPlayer2Label.Text = gamesServedSet3Player2.ToString();

                //Games returned
                gamesReturnedSet3Player1 = gamesServedSet3Player2;
                gamesReturnedSet3Player2 = gamesServedSet3Player1;
                gamesReturnedPlayer1Label.Text = gamesReturnedSet3Player1.ToString();
                gamesReturnedPlayer2Label.Text = gamesReturnedSet3Player2.ToString();

                //Winners
                winnersPlayer1Label.Text = winnersSet3Player1.ToString();
                winnersPlayer2Label.Text = winnersSet3Player2.ToString();
                forehandWinnersPlayer1Label.Text = forehandWinnersSet3Player1.ToString();
                forehandWinnersPlayer2Label.Text = forehandWinnersSet3Player2.ToString();
                backhandWinnersPlayer1Label.Text = backhandWinnersSet3Player1.ToString();
                backhandWinnersPlayer2Label.Text = backhandWinnersSet3Player2.ToString();

                //Unforced errors
                unforcedErrorPlayer1Label.Text = unforcedErrorsSet3Player1.ToString();
                unforcedErrorPlayer2Label.Text = unforcedErrorsSet3Player2.ToString();
                forehandUnforcedErrorPlayer1Label.Text = forehandUnforcedErrorsSet3Player1.ToString();
                forehandUnforcedErrorPlayer2Label.Text = forehandUnforcedErrorsSet3Player2.ToString();
                backhandUnforcedErrorPlayer1Label.Text = backhandUnforcedErrorsSet3Player1.ToString();
                backhandUnforcedErrorPlayer2Label.Text = backhandUnforcedErrorsSet3Player2.ToString();

                //Forced errors
                //Unforced errors
                forcedErrorPlayer1Label.Text = forcedErrorsSet3Player1.ToString();
                forcedErrorPlayer2Label.Text = forcedErrorsSet3Player2.ToString();
                forehandForcedErrorPlayer1Label.Text = forehandForcedErrorsSet3Player1.ToString();
                forehandForcedErrorPlayer2Label.Text = forehandForcedErrorsSet3Player2.ToString();
                backhandForcedErrorPlayer1Label.Text = backhandForcedErrorsSet3Player1.ToString();
                backhandForcedErrorPlayer2Label.Text = backhandForcedErrorsSet3Player2.ToString();

                //POINTS WON RETURNING 1ST SERVE.
                returnFirstServeWonSet3Player1 = (numberOfServesSet3Player2 - faultSet3Player2) - pointWon1ServeSet3Player2;
                percentFirstServeReturnSet3Player1 = (int)(((double)returnFirstServeWonSet3Player1 / ((double)numberOfServesSet3Player2 - faultSet3Player2)) * 100);
                if (percentFirstServeReturnSet3Player1 < 0)
                {
                    percentFirstServeReturnSet3Player1 = 0;
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet3Player1 + "/" + firstServeInSet3Player2 +
                        " (" + percentFirstServeReturnSet3Player1 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet3Player1 + "/" + firstServeInSet3Player2 +
                        " (" + percentFirstServeReturnSet3Player1 + "%" + ")";
                }

                returnFirstServeWonSet3Player2 = (numberOfServesSet3Player1 - faultSet3Player1) - pointWon1ServeSet3Player1;
                percentFirstServeReturnSet3Player2 = (int)(((double)returnFirstServeWonSet3Player2 / ((double)numberOfServesSet3Player1 - faultSet3Player1)) * 100);
                if (percentFirstServeReturnSet3Player2 < 0)
                {
                    percentFirstServeReturnSet3Player2 = 0;
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet3Player2 + "/" + firstServeInSet3Player1 +
                        " (" + percentFirstServeReturnSet3Player2 + "%" + ")";
                }
                else
                {
                    firstReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet3Player2 + "/" + firstServeInSet3Player1 +
                        " (" + percentFirstServeReturnSet3Player2 + "%" + ")";
                }

                //Return won 2nd serve
                percentPointsWon2ndServeSet3Player1 = (int)(((double)pointWonReturning2ndServeSet3Player1 /
                    ((double)faultSet3Player2 - doubleFaultSet3Player2)) * 100);
                if (percentPointsWon2ndServeSet3Player1 < 0)
                {
                    percentPointsWon2ndServeSet3Player1 = 0;
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeSet3Player1 + "/" + (faultSet3Player2 - doubleFaultSet3Player2) +
                        " (" + percentPointsWon2ndServeSet3Player1 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer1Label.Text = pointWonReturning2ndServeSet3Player1 + "/" + (faultSet3Player2 - doubleFaultSet3Player2) +
                        " (" + percentPointsWon2ndServeSet3Player1 + "%" + ")";
                }

                percentPointsWon2ndServeSet3Player2 = (int)(((double)pointWonReturning2ndServeSet3Player2 /
                    ((double)faultSet3Player1 - doubleFaultSet3Player1)) * 100);
                if (percentPointsWon2ndServeSet3Player2 < 0)
                {
                    percentPointsWon2ndServeSet3Player2 = 0;
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeSet3Player2 + "/" + (faultSet3Player1 - doubleFaultSet3Player1) +
                        " (" + percentPointsWon2ndServeSet3Player2 + "%" + ")";
                }
                else
                {
                    secondReturnPointsWonPlayer2Label.Text = pointWonReturning2ndServeSet3Player2 + "/" + (faultSet3Player1 - doubleFaultSet3Player1) +
                        " (" + percentPointsWon2ndServeSet3Player2 + "%" + ")";
                }

                //Break points won.
                percentBreaksWonSet3Player1 = (int)(((double)breakPointWonSet3Player1 /
                    breaksSet3Player1) * 100);
                if (percentBreaksWonSet3Player1 < 0)
                {
                    percentBreaksWonSet3Player1 = 0;
                    breakPointsWonPlayer1Label.Text = breakPointWonSet3Player1 + "/" + breaksSet3Player1 +
                        " (" + percentBreaksWonSet3Player1 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer1Label.Text = breakPointWonSet3Player1 + "/" + breaksSet3Player1 +
                        " (" + percentBreaksWonSet3Player1 + "%" + ")";
                }

                percentBreaksWonSet3Player2 = (int)(((double)breakPointWonSet3Player2 /
                   breaksSet3Player2) * 100);
                if (percentBreaksWonSet3Player2 < 0)
                {
                    percentBreaksWonSet3Player2 = 0;
                    breakPointsWonPlayer2Label.Text = breakPointWonSet3Player2 + "/" + breaksSet3Player2 +
                        " (" + percentBreaksWonSet3Player2 + "%" + ")";
                }
                else
                {
                    breakPointsWonPlayer2Label.Text = breakPointWonSet3Player2 + "/" + breaksSet3Player2 +
                        " (" + percentBreaksWonSet3Player2 + "%" + ")";
                }

                //Percentage of total points won serving
                percentTotalServicePointsWonSet3Player1 = (int)(((double)(pointWon1ServeSet3Player1 +
                    pointWon2ServeSet3Player1) / numberOfServesSet3Player1) * 100);
                if (percentTotalServicePointsWonSet3Player1 < 0)
                {
                    percentTotalServicePointsWonSet3Player1 = 0;
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeSet3Player1 + pointWon2ServeSet3Player1 +
                        "/" + numberOfServesSet3Player1 + " (" + percentTotalServicePointsWonSet3Player1 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer1Label.Text = pointWon1ServeSet3Player1 + pointWon2ServeSet3Player1 +
                        "/" + numberOfServesSet3Player1 + " (" + percentTotalServicePointsWonSet3Player1 + "%" + ")";
                }
                percentTotalServicePointsWonSet3Player2 = (int)(((double)(pointWon1ServeSet3Player2 +
                    pointWon2ServeSet3Player2) / numberOfServesSet3Player2) * 100);
                if (percentTotalServicePointsWonSet3Player2 < 0)
                {
                    percentTotalServicePointsWonSet3Player2 = 0;
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeSet3Player2 + pointWon2ServeSet3Player2 +
                        "/" + numberOfServesSet3Player2 + " (" + percentTotalServicePointsWonSet3Player2 + "%" + ")";
                }
                else
                {
                    totalServicePointsWonPlayer2Label.Text = pointWon1ServeSet3Player2 + pointWon2ServeSet3Player2 +
                        "/" + numberOfServesSet3Player2 + " (" + percentTotalServicePointsWonSet3Player2 + "%" + ")";
                }

                //Percentage of total points won returning
                percentTotalReturnPointsWonSet3Player1 = (int)(((double)(returnFirstServeWonSet3Player1 +
                    pointWonReturning2ndServeSet3Player1) / numberOfServesSet3Player2) * 100);
                if (percentTotalReturnPointsWonSet3Player1 < 0)
                {
                    percentTotalReturnPointsWonSet3Player1 = 0;
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet3Player1 + pointWonReturning2ndServeSet3Player1 +
                        "/" + numberOfServesSet3Player2 + " (" + percentTotalReturnPointsWonSet3Player1 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer1Label.Text = returnFirstServeWonSet3Player1 + pointWonReturning2ndServeSet3Player1 +
                        "/" + numberOfServesSet3Player2 + " (" + percentTotalReturnPointsWonSet3Player1 + "%" + ")";
                }
                percentTotalReturnPointsWonSet3Player2 = (int)(((double)(returnFirstServeWonSet3Player2 +
                    pointWonReturning2ndServeSet3Player2) / numberOfServesSet3Player1) * 100);
                if (percentTotalReturnPointsWonSet3Player2 < 0)
                {
                    percentTotalReturnPointsWonSet3Player2 = 0;
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet3Player2 + pointWonReturning2ndServeSet3Player2 +
                        "/" + numberOfServesSet3Player1 + " (" + percentTotalReturnPointsWonSet3Player2 + "%" + ")";
                }
                else
                {
                    totalReturnPointsWonPlayer2Label.Text = returnFirstServeWonSet3Player2 + pointWonReturning2ndServeSet3Player2 +
                        "/" + numberOfServesSet3Player1 + " (" + percentTotalReturnPointsWonSet3Player2 + "%" + ")";
                }

                //Percentage of total points won.
                percentTotalPointsWonSet3Player1 = (int)(((double)(returnFirstServeWonSet3Player1 +
                    pointWonReturning2ndServeSet3Player1 + pointWon1ServeSet3Player1 +
                    pointWon2ServeSet3Player1) / (numberOfServesSet3Player1 + numberOfServesSet3Player2)) * 100);
                if (percentTotalPointsWonSet3Player1 < 0)
                {
                    percentTotalPointsWonSet3Player1 = 0;
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonSet3Player1 +
                    pointWonReturning2ndServeSet3Player1 + pointWon1ServeSet3Player1 +
                    pointWon2ServeSet3Player1) + "/" + (numberOfServesSet3Player1 + numberOfServesSet3Player2) +
                        " (" + percentTotalPointsWonSet3Player1 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer1Label.Text = (returnFirstServeWonSet3Player1 +
                    pointWonReturning2ndServeSet3Player1 + pointWon1ServeSet3Player1 +
                    pointWon2ServeSet3Player1) + "/" + (numberOfServesSet3Player1 + numberOfServesSet3Player2) +
                        " (" + percentTotalPointsWonSet3Player1 + "%" + ")";
                }
                percentTotalPointsWonSet3Player2 = (int)(((double)(returnFirstServeWonSet3Player2 +
                    pointWonReturning2ndServeSet3Player2 + pointWon1ServeSet3Player2 +
                    pointWon2ServeSet3Player2) / (numberOfServesSet3Player2 + numberOfServesSet3Player1)) * 100);
                if (percentTotalPointsWonSet3Player2 < 0)
                {
                    percentTotalPointsWonSet3Player2 = 0;
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonSet3Player2 +
                     pointWonReturning2ndServeSet3Player2 + pointWon1ServeSet3Player2 +
                     pointWon2ServeSet3Player2) + "/" + (numberOfServesSet3Player2 + numberOfServesSet3Player1) +
                         " (" + percentTotalPointsWonSet3Player2 + "%" + ")";
                }
                else
                {
                    totalPointsWonPlayer2Label.Text = (returnFirstServeWonSet3Player2 +
                     pointWonReturning2ndServeSet3Player2 + pointWon1ServeSet3Player2 +
                     pointWon2ServeSet3Player2) + "/" + (numberOfServesSet3Player2 + numberOfServesSet3Player1) +
                         " (" + percentTotalPointsWonSet3Player2 + "%" + ")";
                }

                //Percentage points won at the net
                percentPointsWonAtTheNetSet3Player1 = (int)(((double)pointsWonNetSet3Player1 /
                    approachSet3Player1) * 100);
                if (percentPointsWonAtTheNetSet3Player1 < 0)
                {
                    percentPointsWonAtTheNetSet3Player1 = 0;
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetSet3Player1 + "/" + approachSet3Player1 +
                        " (" + percentPointsWonAtTheNetSet3Player1 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer1Label.Text = pointsWonNetSet3Player1 + "/" + approachSet3Player1 +
                        " (" + percentPointsWonAtTheNetSet3Player1 + "%" + ")";
                }

                percentPointsWonAtTheNetSet3Player2 = (int)(((double)pointsWonNetSet3Player2 /
                   approachSet3Player2) * 100);
                if (percentPointsWonAtTheNetSet3Player2 < 0)
                {
                    percentPointsWonAtTheNetSet3Player2 = 0;
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetSet3Player2 + "/" + approachSet3Player2 +
                        " (" + percentPointsWonAtTheNetSet3Player2 + "%" + ")";
                }
                else
                {
                    pointsWonAtTheNetPlayer2Label.Text = pointsWonNetSet3Player2 + "/" + approachSet3Player2 +
                        " (" + percentPointsWonAtTheNetSet3Player2 + "%" + ")";
                }
            }
        }
    }
}
