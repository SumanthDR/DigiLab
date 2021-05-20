using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class php : Form
    {
        public php()
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
            list.Add(rchphp1);
            list.Add(rchphp2);
            list.Add(rchphp3);
            list.Add(rchphp4);
            list.Add(rchphp5);
            list.Add(rchphp6);
            list.Add(rchphp7);
            list.Add(rchphp8);
            list.Add(rchphp9);
            list.Add(rchphp10);
            list.Add(rchphp11);
            list.Add(rchphp12);
            list.Add(rchphp13);
            list.Add(rchphp_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }

        private void php_Load(object sender, EventArgs e)
        {
            switch(Home.var_php)
            {
                case 1: setActive(rchphp1);
                    break;
                case 2: setActive(rchphp2);
                    break;
                case 3: setActive(rchphp3);
                    break;
                case 4: setActive(rchphp4);
                    break;
                case 5: setActive(rchphp5);
                    break;
                case 6: setActive(rchphp6);
                    break;
                case 7: setActive(rchphp7);
                    break;
                case 8: setActive(rchphp8);
                    break;
                case 9: setActive(rchphp9);
                    break;
                case 10: setActive(rchphp10);
                    break;
                case 11: setActive(rchphp11);
                    break;
                case 12: setActive(rchphp12);
                    break;
                case 13: setActive(rchphp13);
                    break;
                case 100: setActive(rchphp_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_php)
            {
                case 1: PrintPDF(rchphp1);
                    break;
                case 2: PrintPDF(rchphp2);
                    break;
                case 3: PrintPDF(rchphp3);
                    break;
                case 4: PrintPDF(rchphp4);
                    break;
                case 5: PrintPDF(rchphp5);
                    break;
                case 6: PrintPDF(rchphp6);
                    break;
                case 7: PrintPDF(rchphp7);
                    break;
                case 8: PrintPDF(rchphp8);
                    break;
                case 9: PrintPDF(rchphp9);
                    break;
                case 10: PrintPDF(rchphp10);
                    break;
                case 11: PrintPDF(rchphp11);
                    break;
                case 12: PrintPDF(rchphp12);
                    break;
                case 13: PrintPDF(rchphp13);
                    break;
                case 100: PrintPDF(rchphp_con);
                    break;           
            }
        }
    }
}
