using System;
using System.Windows.Forms;

namespace ShardCalculator
{
    /// <summary>
    /// Form for calculating the most efficient way of using midnight shards to gain levels.
    /// </summary>
    public partial class CalculateForm : Form
    {
        // The experience value of a shard per level. Multiply this by level (max 200) to get experience per shard.
        private double shardMultiplier = 300.0;

        // Formatter for updating the label that states experience left.
        private const string experienceLeftLabelFormat = "Exp. To Level {0} After Shards";
        private const string errorHeaderText = "The following fields are not valid, positive integers:";

        /// <summary>
        /// Creates a new CalculateForm
        /// </summary>
        public CalculateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculates the shard usage for the level, experience, and shard count
        /// </summary>
        private void calculateButtonClick(object sender, EventArgs e)
        {
            // Remove the previous calculations
            calculationBox.Items.Clear();

            string parsingError = string.Empty;

            ulong shardCountParsed;
            ulong currentLevelParsed;
            ulong currentExperienceParsed;

            // These values must be positive integers. Experience goes into the billions so
            // might as well handle the overflows
            if (!ulong.TryParse(currentLevelBox.Text, out currentLevelParsed))
            {
                parsingError += Environment.NewLine + currentLevelLabel.Text;
            }

            if (!ulong.TryParse(currentExperienceBox.Text, out currentExperienceParsed))
            {
                parsingError += Environment.NewLine + currentExperienceLabel.Text;
            }

            if (!ulong.TryParse(shardCountBox.Text, out shardCountParsed))
            {
                parsingError += Environment.NewLine + totalShardsLabel.Text;
            }

            // Tell the user how they failed the simple input.
            if (!string.IsNullOrWhiteSpace(parsingError))
            {
                MessageBox.Show(this, errorHeaderText + parsingError, "Incorrect Input");
                return;
            }

            // Cast everything over to doubles for precision math
            double shardCount = shardCountParsed;
            double currentLevel = currentLevelParsed;
            double currentExperience = currentExperienceParsed;

            // Calculate the initial experience difference between the next level and the current experience
            // This is the starting point of the calculations
            double experienceDifference = calculateExperience(currentLevel + 1) - currentExperience;

            // For each iteration of this while loop, while there are still shards left.
            //  1. Determine the min number of shards required to get the next level. Divide the experience difference by the shard multiplier for the current level, and round up.
            //  2. Determine how much overflow experience - the experience over the minimum to get the next level - is left after the shards are used.
            //  3a. Add the results for the level to the list box, if there are enough shards remaining, or
            //  3b. Add the number of shards remaining, if any, to the list box, if not enough shards are remaining. Then, calculate the remaining experience to the next level after
            //      using all the remaining shards
            //  4. Calculate the difference between the next level and the level after that. This is used for the next iteration of the loop if there are shards left.
            while (shardCount >= 0)
            {
                // The level multiplier is a max of 200.
                double levelForMultiplier = Math.Min(currentLevel, 200);

                // Calculate the shards used at the level stored in currentLevel, and any overflow experience - experience gained over the next level.
                double shardsUsed = Math.Ceiling(experienceDifference / (shardMultiplier * levelForMultiplier));
                double overflowExperience = (shardMultiplier * levelForMultiplier * shardsUsed) - experienceDifference;

                // Increment the level here. This will be used for the list box and further calculations
                currentLevel += 1;

                if (shardsUsed <= shardCount)
                {
                    // There are enough shards for this level. Add the level and shard count to the list
                    ListViewItem item = new ListViewItem(currentLevel.ToString());
                    item.SubItems.Add(new ListViewItem.ListViewSubItem(item, shardsUsed.ToString()));
                    calculationBox.Items.Add(item);
                }
                else
                {
                    // There are not enough shards left. If there are any shards, add this number to the list as "Leftover"
                    if (shardCount > 0)
                    {
                        ListViewItem item = new ListViewItem("Leftover");
                        item.SubItems.Add(new ListViewItem.ListViewSubItem(item, shardCount.ToString()));
                        calculationBox.Items.Add(item);
                    }

                    // Fill the experience left box and label with the experience left when using the leftover shards
                    experienceLeftBox.Text = Math.Floor(experienceDifference - (shardMultiplier * levelForMultiplier * shardCount)).ToString();
                    experienceLeftLabel.Text = string.Format(experienceLeftLabelFormat, currentLevel);
                }

                // Calculate the experience difference for the next level/iteration of the loop. The full difference between levels, minus the overflow experience.
                experienceDifference = calculateExperience(currentLevel + 1) - calculateExperience(currentLevel) - overflowExperience;

                // Decrement the shards.
                shardCount -= shardsUsed;
            }
        }

        /// <summary>
        /// Update the experience box when the user enters a valid level
        /// </summary>
        private void currentLevelBoxTextChanged(object sender, EventArgs e)
        {
            ulong value;

            if (ulong.TryParse(currentLevelBox.Text, out value))
            {
                currentExperienceBox.Text = calculateExperience(value).ToString();
            }
        }

        /// <summary>
        /// Calculate the total experience for the specified level
        /// </summary>
        /// <param name="level">The level to calculate experience for</param>
        /// <returns>The total experience for <paramref name="level"/></returns>
        private double calculateExperience(double level)
        {
            return Math.Floor((50.0 / 3.0) * (Math.Pow(level, 3) - (6 * Math.Pow(level, 2)) + (17 * level) - 12));
        }
    }
}