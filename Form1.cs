using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UnicodePicker
{
    public partial class Form1 : Form
    {

        // Dictionary to store Unicode data
        private Dictionary<string, string> unicodeData = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
            LoadUnicodeData();
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnInsert.Click += BtnInsert_Click;
        }

        // Load Unicode data

        private void LoadUnicodeData()
        {
            string filePath = "unicode_names.ini";
            try
            {
                foreach (var line in File.ReadLines(filePath))
                {
                    if (!string.IsNullOrWhiteSpace(line) && line.Contains("="))
                    {
                        var parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            string code = parts[0].Trim();
                            string name = parts[1].Trim();

                            // Validate the code point
                            if (int.TryParse(code, System.Globalization.NumberStyles.HexNumber, null, out int codePoint) &&
                                codePoint >= 0x0000 && codePoint <= 0x10FFFF &&
                                !(codePoint >= 0xD800 && codePoint <= 0xDFFF)) // Exclude surrogate range
                            {
                                unicodeData[code] = name;
                            }
                        }
                    }
                }

                // MessageBox.Show($"Loaded {unicodeData.Count} valid entries.");
                UpdateListBox("");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Unicode data: {ex.Message}");
            }
        }



        // Update ListBox
        private void UpdateListBox(string filter)
        {
            lstResults.Items.Clear();
            var filteredResults = unicodeData
                .Where(kvp => kvp.Value.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                .Select(kvp => $"U+{kvp.Key} - {kvp.Value} : {char.ConvertFromUtf32(Convert.ToInt32(kvp.Key, 16))}");

            lstResults.Items.AddRange(filteredResults.ToArray());
        }

        // Search Handler
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox(txtSearch.Text);
        }

        // Insert Character Handler
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (lstResults.SelectedItem != null)
            {
                string selectedLine = lstResults.SelectedItem.ToString();
                int charPos = selectedLine.IndexOf(":") + 2;
                string character = selectedLine.Substring(charPos, 1);
                Clipboard.SetText(character);
                MessageBox.Show($"Character '{character}' copied to clipboard!", "Success");
            }
        }

    }
}
