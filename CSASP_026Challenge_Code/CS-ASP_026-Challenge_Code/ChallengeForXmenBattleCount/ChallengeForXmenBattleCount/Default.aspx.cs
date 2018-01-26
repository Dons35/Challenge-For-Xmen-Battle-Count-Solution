using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers.Max())
                {
                    string maxbattles = string.Format("{0} has the most battles with {1}.<br />", names[i], numbers[i]);
                    result += maxbattles;
                }

                if (numbers[i] == numbers.Min())
                {
                    string minbattles = string.Format("{0} has the least battles with {1}.", names[i], numbers[i]);
                    result += minbattles;
                }
            }


            resultLabel.Text = result;
        }
    }
}