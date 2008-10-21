﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using Pbp.Properties;

namespace Pbp.Forms
{
    public partial class EditorWindow : Form
    {
        Settings setting;
        static private EditorWindow _instance;

        private int childFormNumber = 0;

        private EditorWindow()
        {
            setting = new Settings();
            InitializeComponent();
        }

        static public EditorWindow getInstance()
        {
            if (_instance==null)
                _instance = new EditorWindow();
            return _instance;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            EditorChild childForm = new EditorChild(null);
            childForm.MdiParent = this;
            
            
            childForm.Text = "Neues Lied " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = setting.dataDirectory+Path.DirectorySeparatorChar + setting.songDir;

            String fltr = String.Empty;
            int i = 0;
            foreach (String ext in Song.extensions)
            {
                fltr += Song.extensionNames[i] + " (" + ext + ")|" + ext + "|";
                i++;
            }
            fltr += "Alle Dateien (*.*)|*.*";

            openFileDialog.Filter = fltr;
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
                EditorChild childForm = new EditorChild(FileName);
                childForm.MdiParent = this;
                childForm.Show();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((EditorChild)ActiveMdiChild).saveAs();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutWindow ab = new AboutWindow();
            ab.ShowDialog(this);
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nicu.ch/pbp");
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsWindow stWnd = new settingsWindow();
            if (stWnd.ShowDialog(this) == DialogResult.OK)
            {
                setting.Reload();
            }
        }

        private void EditorWindow_Load(object sender, EventArgs e)
        {

        }

        private void EditorWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void saveChild(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ((EditorChild)ActiveMdiChild).save();
            }
        }

        public void setStatus(string text)
        {
            toolStripStatusLabel1.Text = text;
        }

    }
}
