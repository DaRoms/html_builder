using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HTML_Builder
{
    public partial class frmMain : Form
    {
        //Editor variables
        String savePath = "";
        private Point MouseDownLocation;

        //Element variables
        Button button;
        TextBox textbox;
        Button submit;
        RichTextBox bigtextbox;
        TrackBar range;
        CheckBox checkbox;
        Panel div;

        //Code variables
        String head = "<head>";
        String body = "<body>\n";
        String style = "";
        String encoding;
        String title;

        //Counter variables
        int buttons = 0;
        int submits = 0;
        int textboxes = 0;
        int textareas = 0;
        int ranges = 0;
        int checkboxes = 0;
        int divs = 0;

        RichTextBox codeEditor;
        RichTextBox cssEditor;


        Boolean pressed = false;
        Control control_selected;
        Control props_selected;
        WebBrowser browser;

        Boolean previewing = false;

        public frmMain()
        {
            InitializeComponent();
            this.KeyPreview = true;
            //Setting up textarea
            codeEditor = new RichTextBox();

            codesplitter.Panel1.Controls.Add(codeEditor);
            codeEditor.Dock = DockStyle.Fill;
            codeEditor.Font = new Font("Consolas", 13);

            cssEditor = new RichTextBox();

            codesplitter.Panel2.Controls.Add(cssEditor);
            cssEditor.Dock = DockStyle.Fill;
            cssEditor.Font = new Font("Consolas", 13);

            setHead();

            colors.Color = Color.White;
        }

        private void setTextArea()
        {
            setStyle();
            codeEditor.Text = "<!--HTML-->\n";
            codeEditor.Text += "<!doctype html>\n";
            codeEditor.Text += "<html>\n";
            codeEditor.Text += head + "</head>\n\t";
            codeEditor.Text += body + "\n\t\t"+ style + "\t</body>\n";
            codeEditor.Text += "</html>";
        }

        private void setHead()
        {
            encoding = cmbEncoding.Text;
            title = txtTitle.Text;
            head = "\t<head>\n\t\t";
            head += "<link rel='stylesheet' type='text/css' href='style.css'>\n\t\t";
            head += "<meta charset='" + encoding + "'>\n\t\t";
            head += "<title>" + title + "</title>\n\t";
        }

        private void setStyle()
        {
            style = "<style>\n";
            for (int i = 0; i < cssEditor.Lines.Length;i++)
            {
                style += "\t\t" + cssEditor.Lines[i];
            }
            style += "\n\t\t</style>\n";
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {
                props_selected.Hide();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                saveFile();
            }
        }

        private void preview()
        {
            setTextArea();
            if (savePath != "")
            {
                if (cmbPreview.Text != "Built in")
                {
                    System.Diagnostics.Process.Start(savePath);
                }
                else
                {
                    btnStop.Enabled = true;
                    browser = new WebBrowser();
                    splitEditor.Panel1.Controls.Add(browser);
                    browser.Dock = DockStyle.Fill;
                    browser.BringToFront();
                    browser.Navigate(savePath);
                    previewing = true;
                }
            }
            else
            {
                MessageBox.Show("Save your file first!", "Error");
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            preview();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            browser.Dispose();
            previewing = false;
        }

        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        private void addButton()
        {
            body += "\t\t<input type='button' value='Button" + buttons + "' id='btn" + buttons + "' name='btn" + buttons + "'>\n";
            button = new Button();
            button.Name = "btn" + buttons;
            button.Height = 25;
            button.Text = "Button"+buttons;
            splitEditor.Panel1.Controls.Add(button);
            button.MouseDown += new MouseEventHandler(element_MouseDown);
            button.MouseMove += new MouseEventHandler(element_MouseMove);
            button.MouseUp += new MouseEventHandler(element_MouseUp);
            setTextArea();
            buttons += 1;
        }
        private void addTextbox()
        {
            textboxes += 1;
            body += "\t\t<input type='text' name='txtb" + textboxes + "' id='txtb" + textboxes + "'>\n";
            textbox = new TextBox();
            textbox.Name = "txtb" + textboxes;
            textbox.BorderStyle = BorderStyle.FixedSingle;
            textbox.Width = 150;
            splitEditor.Panel1.Controls.Add(textbox);
            textbox.MouseDown += new MouseEventHandler(element_MouseDown);
            textbox.MouseMove += new MouseEventHandler(element_MouseMove);
            textbox.MouseUp += new MouseEventHandler(element_MouseUp);
            setTextArea();
        }
        private void addSubmit()
        {
            submits += 1;
            body += "\t\t<input type='submit' value='Submit' name='sbt" + submits + "' id='sbt" + submits + "'>\n";
            submit = new Button();
            submit.Name = "sbt" + submits;
            submit.Text = "Submit"+submits;
            splitEditor.Panel1.Controls.Add(submit);
            submit.MouseDown += new MouseEventHandler(element_MouseDown);
            submit.MouseMove += new MouseEventHandler(element_MouseMove);
            submit.MouseUp += new MouseEventHandler(element_MouseUp);
            setTextArea();
        }
        private void addTextarea()
        {
            textareas += 1;
            body += "\t\t<textarea width='300' height='200' name='txta" + textareas + "' id='txta" + textareas + "'></textarea>\n";
            bigtextbox = new RichTextBox();
            bigtextbox.Name = "txta" + textareas;
            bigtextbox.Width = 300;
            bigtextbox.Height = 200;
            splitEditor.Panel1.Controls.Add(bigtextbox);
            bigtextbox.MouseDown += new MouseEventHandler(element_MouseDown);
            bigtextbox.MouseMove += new MouseEventHandler(element_MouseMove);
            bigtextbox.MouseUp += new MouseEventHandler(element_MouseUp);
            setTextArea();
        }
        private void addRange()
        {
            ranges += 1;
            body += "\t\t<input type='range' name='rng" + ranges + "' id='rng" + ranges + "'>\n";
            range = new TrackBar();
            range.Name = "rng" + ranges;
            range.Width = 125;
            splitEditor.Panel1.Controls.Add(range);
            range.MouseDown += new MouseEventHandler(element_MouseDown);
            range.MouseMove += new MouseEventHandler(element_MouseMove);
            range.MouseUp += new MouseEventHandler(element_MouseUp);
            setTextArea();
        }
        private void addCheckbox()
        {
            checkboxes += 1;
            body += "\t\t<input type='checkbox' name='chk" + checkboxes + "'  id='chk" + checkboxes + "'>\n";
            checkbox = new CheckBox();
            checkbox.Name = "chk" + checkboxes;
            checkbox.Text = "Checkbox"+checkboxes;
            splitEditor.Panel1.Controls.Add(checkbox);
            checkbox.MouseDown += new MouseEventHandler(element_MouseDown);
            checkbox.MouseMove += new MouseEventHandler(element_MouseMove);
            checkbox.MouseUp += new MouseEventHandler(element_MouseUp);
            checkbox.Checked = true;
            setTextArea();
        }
        private void addDiv()
        {
            divs += 1;
            body += "\t\t<div id='div" + divs + "' />\n";
            div = new Panel();
            div.Name = "div" + divs;
            splitEditor.Panel1.Controls.Add(div);
            div.MouseDown += new MouseEventHandler(element_MouseDown);
            div.MouseMove += new MouseEventHandler(element_MouseMove);
            div.MouseUp += new MouseEventHandler(element_MouseUp);
            div.BorderStyle = BorderStyle.FixedSingle;
            setTextArea();
        }
        //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

        

        private void element_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;

            lblName.Text = control.Name;
            txtValue.Text = control.Text;
            numWidth.Value = control.Width;
            numHeight.Value = control.Height;
            numX.Value = control.Left;
            numY.Value = control.Top;

            props_selected = control;

            if (e.Button == MouseButtons.Left)
            {
                if ((Control)sender is Button) control_selected = button;
                if ((Control)sender is TextBox) control_selected = textbox;
                if ((Control)sender is RichTextBox) control_selected = bigtextbox;
                if ((Control)sender is TrackBar) control_selected = range;
                if ((Control)sender is CheckBox) control_selected = checkbox;
                pressed = true;
                MouseDownLocation = e.Location;
            }
        }

        private void element_MouseMove(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;
            if (pressed)
            {
                control.Left = e.X + control.Left / 2 - MouseDownLocation.X;
                control.Top = e.Y + control.Top / 2 - MouseDownLocation.Y;
                numX.Value = control.Left;
                numY.Value = control.Top;
            }
        }

        private void element_MouseUp(object sender, MouseEventArgs e)
        {
            pressed = false;
            Control control = sender as Control;
        }

        private void tbButton_Click(object sender, EventArgs e){addButton();}
        private void tbTextbox_Click(object sender, EventArgs e){addTextbox();}
        private void tbSubmit_Click(object sender, EventArgs e){addSubmit();}
        private void tbTextarea_Click(object sender, EventArgs e){addTextarea();}
        private void tbRange_Click(object sender, EventArgs e){addRange();}
        private void tbCheckbox_Click(object sender, EventArgs e) { addCheckbox(); }
        private void tbDiv_Click(object sender, EventArgs e) { addDiv(); }


        private void cmbEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            setHead();
            setTextArea();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            setHead();
            setTextArea();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (previewing)
            {
                codeEditor.Enabled = false;
                cssEditor.Enabled = false;
                codeEditor.BackColor = Color.Gray;
                cssEditor.BackColor = Color.Gray;
            }
            else
            {
                codeEditor.Enabled = true;
                cssEditor.Enabled = true;
                codeEditor.BackColor = Color.White;
                cssEditor.BackColor = Color.White;
            }

            if (savePath != "") lblFilePath.Text = savePath;
            else lblFilePath.Text = "Unknown file";
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colors.ShowDialog() == DialogResult.OK)
            {
                if(props_selected != null) props_selected.BackColor = colors.Color;
            }
        }

        private void btnSetProps_Click(object sender, EventArgs e)
        {
            props_selected.Width = (int)numWidth.Value;
            props_selected.Height = (int)numHeight.Value;
            props_selected.Left = (int)numX.Value;
            props_selected.Top = (int)numY.Value;
            props_selected.Text = txtValue.Text;

            cssEditor.Text += "\n#" + props_selected.Name + "{\n";
            cssEditor.Text += "\tposition: absolute;\n";
            cssEditor.Text += "\tleft:"+(int)numX.Value+"px;\n";
            cssEditor.Text += "\ttop:" + (int)numY.Value + "px;\n";
            cssEditor.Text += "\twidth: "+props_selected.Width+"px;\n";
            cssEditor.Text += "\theight: " + props_selected.Height + "px;\n";
            cssEditor.Text += "\tborder: " + numBorder.Value + "px solid black;\n";
            cssEditor.Text += "\tborder-radius: " + numRadius.Value+ "px;\n";
            cssEditor.Text += "\tfont-family: " + props_selected.Font.FontFamily.Name + ";\n";
            cssEditor.Text += "\tfont-size: " + (int)props_selected.Font.Size + "px;\n";
            cssEditor.Text += "\tbackground-color: " + colors.Color.ToKnownColor() + ";\n";
            cssEditor.Text += "}";

            setHead();
            setStyle();
            setTextArea();
        }

        private void btnFont_Click_1(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                props_selected.Font = fontDialog.Font;
            }
        }

        private void saveFile()
        {
            setHead();
            setStyle();
            setTextArea();
            if (savePath != "")
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(savePath))
                    {
                        for (int i = 0; i < codeEditor.Lines.Length;i++)
                        {
                            file.WriteLine(codeEditor.Lines[i]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            else
            {
                saveFileAs();
            }
        }

        private void saveFileAs()
        {
            setHead();
            setStyle();
            setTextArea();
            saveDialog.Filter = "HTML|*.html|All files (*.*)|*.*";
            saveDialog.DefaultExt = "html";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                

                savePath = saveDialog.FileName;
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(savePath))
                    {
                        for (int i = 0; i < codeEditor.Lines.Length;i++)
                        {
                            file.WriteLine(codeEditor.Lines[i]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void newFile()
        {
            savePath = "";
            foreach (Control control in splitEditor.Controls)
            {
                
            }
            cssEditor.Text = "";
            codeEditor.Text = "";
        }

        private void exportCss()
        {
            saveDialog.Filter = "CSS|*.css*|All files (*.*)|*.*";
            saveDialog.DefaultExt = "css";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                String exPath = saveDialog.FileName;
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(exPath))
                    {
                        for (int i = 0; i < cssEditor.Lines.Length; i++)
                        {
                            file.WriteLine(cssEditor.Lines[i]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            saveFileAs();
        }

        private void frmMain_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.X)
            {
                if(props_selected != null) props_selected.Dispose();
            }
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
            {
                saveFile();
            }
            if (e.KeyCode == Keys.F5)
            {
                preview();
            }
        }

        private void mnuExport_Click(object sender, EventArgs e)
        {
            exportCss();
        }

        private void mnuNewFile_Click(object sender, EventArgs e)
        {
            newFile();
        }
    }
}
