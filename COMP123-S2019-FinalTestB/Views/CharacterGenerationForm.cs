using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/* 
 * STUDENT NAME: SOPHIA BHULLAR
 * STUDENT ID: 301048344
 * DESCRIPTION: This is the CharacterGeneratorForm - the main form of the application
 */

namespace COMP123_S2019_FinalTestB.Views
{
    
    public partial class CharacterGenerationForm : MasterForm
    {

        List<string> FirstNameList = new List<string>();
        List<string> LastNameList = new List<string>();
        List<String> InventoryList = new List<string>();
        public CharacterGenerationForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is the event handler for the BackButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }


        /// <summary>
        /// This is the event handler for the NextButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex<MainTabControl.TabPages.Count-1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        public void LoadNames()
        {
            
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            Program.character.FirstName = FirstNameDataLabel.Text;
            Program.character.LastName = LastNameDataLabel.Text;
        }

        public void LoadInventory()
        {

        }

        private void CharacterGenerationForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenButton_Click(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            Program.characterForm.ShowDialog();
        }
    }
}
