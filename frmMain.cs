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
        htmlElem head;
        htmlElem body;
        htmlElem meta;
        htmlElem title;
        Functions functions;
        String savePath;
        WebBrowser browser;
        Control selectedControl;

        public frmMain()
        {
            InitializeComponent();
            browser = new WebBrowser();
            functions = new Functions();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            head = new htmlElem("head");
            body = new htmlElem("body");
            meta = new htmlElem("meta");
            title = new htmlElem("title");
            
            splitEditor.Panel1.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
            browser.Hide();
        }

        //Sets <head> and all it's childs
        private void setHead()
        {
            title.value = txtTitle.Text;
            meta.addProperty("charset", cmbEncoding.Text);
            head.addChild(meta);
            head.addChild(title);
        }

        private void tbTextbox_Click(object sender, EventArgs e)
        {
            htmlElem textbox = new htmlElem("text");
            textbox.createControl();
            splitEditor.Panel1.Controls.Add(textbox.control);
            textbox.control.MouseDown += new MouseEventHandler(element_MouseDown);
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (savePath != "") functions.saveFile(savePath, save, htmlEditor);
            else functions.saveFileAs(savePath, save, htmlEditor);
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            functions.saveFileAs(savePath, save, htmlEditor);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (savePath != "")
            {
                browser.Show();
                browser.Navigate(savePath);
                btnPreview.Enabled = false;
                btnStop.Enabled = true;
            }
            else
            {
                MessageBox.Show("You must save your file first.");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            browser.Hide();
            btnPreview.Enabled = true;
            btnStop.Enabled = false;
        }

        //@@@@@@@@@@@@@@  Moving and selecting elements  @@@@@@@@@@@@@@@
        Boolean pressed = false;
        Point MouseDownLocation;

        private void element_MouseDown(object sender, MouseEventArgs e)
        {
            Control control = sender as Control;

            selectedControl = control;

            if (e.Button == MouseButtons.Left)
            {
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
    }
}
