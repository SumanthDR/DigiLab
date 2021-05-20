using System;
using System.Windows.Forms;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Fortune_Infotech
{
    public partial class python : Form
    {
        public python()
        {
            InitializeComponent();
        }
        private void PrintPDF(RichTextBox rchtxtbx)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "PDF file|*.pdf", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(PageSize.A4);
                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                        doc.Open();
                        Chunk c1 = new Chunk("                              Seshadripuram College Tumakuru ", FontFactory.GetFont("Microsoft Tai Le"));
                        Chunk c2 = new Chunk("                  3 Melekote, Veerasagara Layout, Gangasandra road, Tumakuru, Karnataka 572105", FontFactory.GetFont("Microsoft Tai Le"));
                        c2.Font.Size = 9;
                        c1.Font.Size = 14;
                        c1.setLineHeight(2);
                        Phrase p2 = new Phrase();
                        p2.Add(c1);
                        p2.Add("\n");
                        p2.Add(c2);
                        p2.Add("\n\n");
                        Paragraph p = new Paragraph();
                        p.Add(p2);
                        RichTextBox rch = new RichTextBox();
                        rch = rchtxtbx;
                        doc.Add(p);
                        doc.Add(new iTextSharp.text.Paragraph(rch.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        doc.Close();
                    }
                }
            }
        }
        public void setActive(RichTextBox rcTxtbx)
        {
            ArrayList list = new ArrayList();
            list.Add(rchpy1);
            list.Add(rchpy2);
            list.Add(rchpy3);
            list.Add(rchpy4);
            list.Add(rchpy5);
            list.Add(rchpy6);
            list.Add(rchpy7);
            list.Add(rchpy8);
            list.Add(rchpy9);
            list.Add(rchpy10);
            list.Add(rchpy11);
            list.Add(rchpy_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void python_Load(object sender, EventArgs e)
        {
            switch(Home.var_py)
            {
                case 1: setActive(rchpy1);
                    break;
                case 2: setActive(rchpy2);
                    break;
                case 3: setActive(rchpy3);
                    break;
                case 4: setActive(rchpy4);
                    break;
                case 5: setActive(rchpy5);
                    break;
                case 6: setActive(rchpy6);
                    break;
                case 7: setActive(rchpy7);
                    break;
                case 8: setActive(rchpy8);
                    break;
                case 9: setActive(rchpy9);
                    break;
                case 10: setActive(rchpy10);
                    break;
                case 11: setActive(rchpy11);
                    break;
                case 100: setActive(rchpy_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
             switch(Home.var_py)
            {
                case 1: PrintPDF(rchpy1);
                    break;
                case 2: PrintPDF(rchpy2);
                    break;
                case 3: PrintPDF(rchpy3);
                    break;
                case 4: PrintPDF(rchpy4);
                    break;
                case 5: PrintPDF(rchpy5);
                    break;
                case 6: PrintPDF(rchpy6);
                    break;
                case 7: PrintPDF(rchpy7);
                    break;
                case 8: PrintPDF(rchpy8);
                    break;
                case 9: PrintPDF(rchpy9);
                    break;
                case 10: PrintPDF(rchpy10);
                    break;
                case 11: PrintPDF(rchpy11);
                    break;
                case 100: PrintPDF(rchpy_con);
                    break;
            }
        }
    }
}
