using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiragana_Memory_Game
{
    /// <summary>
    /// This class was written entirely by Irene Wang.
    /// </summary>
    public class JPCharacterMap
    {
        #region -- Answer Keys --
        static public string[] answerKeys =
            new string[]
            {
                "no",   // 0
                "a",    // 1
                "ki",   // 2
                "su",   // 3
                "te",   // 4
                "ka",   // 5
                "shi",  // 6
                "tsu",  // 7
                "ne",   // 8
                "ho",   // 9
                "sa",   // 10
                "chi",  // 11
                "nu",   // 12
                "he",   // 13
                "mo",   // 14
                "ta",   // 15
                "ni",   // 16
                "hu",   // 17
                "me",   // 18
                "yo",   // 19
                "ke",   // 20
                "so",   // 21
                "u",    // 22
                "yu",   // 23
                "wa",   // 24
                "mu",   // 25
                "ha",   // 26
                "ya",   // 27
                "ri",   // 28
                "wo",   // 29
                "ma",   // 30
                "ra",   // 31
                "ru",   // 32
                "se",   // 33
                "o",    // 34
                "e",     // 35
                "ku",   // 36
                "i",    // 37
                "re",   // 38
                "mi",   // 39
                "ro",   // 40
                "ko",   // 41
                "to",   // 42
                "hi",   // 43
                "na",   // 44
                "n"     // 45
            };
        #endregion -- Answer Keys --

        #region -- Declare Tab Labels --
        static public string[] tabLabels =
            new string[]
            {
                "#1: の",    // 0
                "#2: あ",    // 1
                "#3: き",    // 2
                "#4: す",    // 3
                "#5: て",    // 4
                "#6: か",    // 5
                "#7: し",    // 6
                "#8: つ",    // 7
                "#9: ね",    // 8
                "#10: ほ",   // 9
                "#11: さ",   // 10
                "#12: ち",   // 11
                "#13: ぬ",   // 12
                "#14: へ",   // 13
                "#15: も",   // 14
                "#16: た",   // 15
                "#17: に",   // 16
                "#18: ふ",   // 17
                "#19: め",   // 18
                "#20: よ",   // 19
                "#21: け",   // 20
                "#22: そ",   // 21
                "#23: う",   // 22
                "#24: ゆ",   // 23
                "#25: わ",   // 24
                "#26: む",   // 25
                "#27: は",   // 26
                "#28: や",   // 27
                "#29: り",   // 28
                "#30: を",   // 29
                "#31: ま",   // 30
                "#32: ら",   // 31
                "#33: る",   // 32
                "#34: せ",   // 33
                "#35: お",   // 34
                "#36: え",   // 35
                "#37: く",   // 36
                "#38: い",   // 37
                "#39: れ",   // 38
                "#40: み",   // 39
                "#41: ろ",   // 40
                "#42: こ",   // 41
                "#43: と",   // 42
                "#44: ひ",   // 43
                "#45: な",   // 44
                "#46: ん"    // 45
            };
        #endregion -- Declare Tab Labels --

        #region -- Member Fields --
        private string returnMessage;
        #endregion -- Member Fields --

        #region -- Properties --
        public string ReturnMessage
        {
            get
            {
                return returnMessage;
            }
            set
            {
                returnMessage = value;
            }
        }
        #endregion -- Properties --

        #region -- Methods --
        /// <summary>
        /// Method to validate whether the user's answer input is correct or incorrect, returning true/false and saving the result to the ReturnMessage.
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="answerIndex"></param>
        /// <returns></returns>
        public bool AnswerValidation(string userInput, int answerIndex)
        {
            bool retVal = false;

            if (userInput == JPCharacterMap.answerKeys[answerIndex])
            {
                ReturnMessage = "Good job!\n\nClick OK for the next character.";
                retVal = true;
            }
            else
            {
                ReturnMessage = "Sorry that is incorrect.\n\nClick OK for the next character.";
            }

            return retVal;
        }
        #endregion -- Methods --
    }
}
