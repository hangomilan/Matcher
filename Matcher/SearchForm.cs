using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Matcher
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e) {
            resultList.Items.Clear();
            foreach (var line in textBox.Lines) {
                MatchCollection matchCollection = Regex.Matches(line, patternBox.Text);

                if (matchCollection.Count > 0)
                {
                    foreach (System.Text.RegularExpressions.Match match in matchCollection)
                    {
                        resultList.Items.Add(match);
                    }
                }
            }
        }
    }
}
