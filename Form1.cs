using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "RTF файлы|*.rtf|Текстовые файлы|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.FileName.EndsWith(".rtf"))
                    richTextBox1.LoadFile(open.FileName);
                else
                    richTextBox1.Text = File.ReadAllText(open.FileName);
            }

        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "RTF файлы|*.rtf|Текстовые файлы|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (save.FileName.EndsWith(".rtf"))
                    richTextBox1.SaveFile(save.FileName);
                else
                    File.WriteAllText(save.FileName, richTextBox1.Text);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "RTF файлы|*.rtf|Текстовые файлы|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.FileName.EndsWith(".rtf"))
                    richTextBox1.LoadFile(open.FileName);
                else
                    richTextBox1.Text = File.ReadAllText(open.FileName);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "RTF файлы|*.rtf|Текстовые файлы|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (save.FileName.EndsWith(".rtf"))
                    richTextBox1.SaveFile(save.FileName);
                else
                    File.WriteAllText(save.FileName, richTextBox1.Text);
            }

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }

        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void размерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog.Color;
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionBackColor = colorDialog.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = colorDialog.Color;
            }
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Italic)
                    newFontStyle = currentFont.Style & ~FontStyle.Italic;  
                else
                    newFontStyle = currentFont.Style | FontStyle.Italic;   

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newFontStyle;

                if (currentFont.Bold)
                    newFontStyle = currentFont.Style & ~FontStyle.Bold;  
                else
                    newFontStyle = currentFont.Style | FontStyle.Bold;   

                richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
            }
        }
    }
}
