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
using Newtonsoft.Json;

namespace SourceEngineTranslationHelper
{
    public partial class Form_Main : Form
    {
        private SourceEngineTranslation currentTranslation;
        private BindingSource bs;
        private string baseTitle;

        public Form_Main()
        {
            InitializeComponent();

            baseTitle = this.Text;

            NewProject();
        }

        private void NewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void ImportJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadJSON();
            UpdateDataSource();

            textBox_ProjectName.Text = currentTranslation.Project;
            textBox_ProjectLanguage.Text = currentTranslation.Language;
            UpdateTitle();
        }

        private void ExportJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveJSON();
        }

        private void ExportTranslationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTXT();
        }

        private void TextBox_ProjectName_TextChanged(object sender, EventArgs e)
        {
            currentTranslation.Project = textBox_ProjectName.Text;
            UpdateTitle();
        }

        private void TextBox_ProjectLanguage_TextChanged(object sender, EventArgs e)
        {
            currentTranslation.Language = textBox_ProjectLanguage.Text;
            UpdateTitle();
        }


        private void LoadJSON()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "JSON (*.json)|*.json";
                dialog.DefaultExt = "json";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string file = File.ReadAllText(dialog.FileName);
                    currentTranslation = JsonConvert.DeserializeObject<SourceEngineTranslation>(file);
                }
            }
        }

        private void SaveJSON()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "JSON (*.json)|*.json";
                dialog.DefaultExt = "json";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string file = JsonConvert.SerializeObject(currentTranslation, Formatting.Indented);
                    File.WriteAllText(dialog.FileName, file);
                }
            }
        }

        private void SaveTXT()
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Text (*.txt)|*.txt";
                dialog.DefaultExt = "txt";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string file = currentTranslation.Export();
                    File.WriteAllText(dialog.FileName, file);
                }
            }
        }

        private void UpdateDataSource()
        {
            bs.DataSource = currentTranslation.Pairs;
            dataGridView_Main.DataSource = bs;
        }

        private void AddNewRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentTranslation.Pairs.Add(new SourceEngineTranslationObject("default_key","Default String"));
            bs.ResetBindings(false);
            UpdateDataSource();
        }


        private void NewProject()
        {
            bs = new BindingSource();
            currentTranslation = new SourceEngineTranslation();

            textBox_ProjectName.Text = currentTranslation.Project;
            textBox_ProjectLanguage.Text = currentTranslation.Language;
            UpdateTitle();
            UpdateDataSource();
        }

        private void UpdateTitle()
        {
            this.Text = $"{baseTitle} - {currentTranslation.Project} ({currentTranslation.Language})";
        }

    }
}
