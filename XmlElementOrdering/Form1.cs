using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XmlElementOrdering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _selectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                _path.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void _orderContent_Click(object sender, EventArgs e)
        {
            string directoryPath = _path.Text;

            if (Directory.Exists(directoryPath))
            {
                NormalizeXmlFiles(directoryPath);
            }
            else
            {
                MessageBox.Show("The specified directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("Completed");
        }

        private void NormalizeXmlFiles(string directoryPath)
        {
            try
            {
                // Get all XML files in the directory recursively
                string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

                foreach (var file in files)
                {
                    try
                    {
                        // Load the XML file
                        XDocument doc = XDocument.Load(file);

                        // Normalize the XML (e.g., order elements by name)
                        NormalizeElement(doc.Root);

                        // Save the normalized XML back to the same file
                        doc.Save(file);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to process {file}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void NormalizeElement(XElement element)
        {
            // Recursively normalize child elements
            foreach (var child in element.Elements().ToList())
            {
                NormalizeElement(child);
            }

            // Order the child elements by their full string representation
            element.ReplaceNodes(element.Elements().OrderBy(e => e.ToString(SaveOptions.DisableFormatting)));
        }
    }
}
