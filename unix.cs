using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class unix : Form
    {
        public unix()
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
            list.Add(rchunix1);
            list.Add(rchunix2);
            list.Add(rchunix3);
            list.Add(rchunix4);
            list.Add(rchunix5);
            list.Add(rchunix6);
            list.Add(rchunix7);
            list.Add(rchunix8);
            list.Add(rchunix9);
            list.Add(rchunix10);
            list.Add(rchunix11);
            list.Add(rchunix12);
            list.Add(rchunix13);
            list.Add(rchunix14);
            list.Add(rchunix15);
            list.Add(rchunix_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void unix_Load(object sender, EventArgs e)
        {
            switch(Home.var_unix)
            {
                case 1: setActive(rchunix1);
                    break;
                case 2: setActive(rchunix2);
                    break;
                case 3: setActive(rchunix3);
                    break;
                case 4: setActive(rchunix4);
                    break;
                case 5: setActive(rchunix5);
                    break;
                case 6: setActive(rchunix6);
                    break;
                case 7: setActive(rchunix7);
                    break;
                case 8: setActive(rchunix8);
                    break;
                case 9: setActive(rchunix9);
                    break;
                case 10: setActive(rchunix10);
                    break;
                case 11: setActive(rchunix11);
                    break;
                case 12: setActive(rchunix12);
                    break;
                case 13: setActive(rchunix13);
                    break;
                case 14: setActive(rchunix14);
                    break;
                case 15: setActive(rchunix15);
                    break;
                case 100: setActive(rchunix_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_unix)
            {
                case 1: PrintPDF(rchunix1);
                    break;
                case 2: PrintPDF(rchunix2);
                    break;
                case 3: PrintPDF(rchunix3);
                    break;
                case 4: PrintPDF(rchunix4);
                    break;
                case 5: PrintPDF(rchunix5);
                    break;
                case 6: PrintPDF(rchunix6);
                    break;
                case 7: PrintPDF(rchunix7);
                    break;
                case 8: PrintPDF(rchunix8);
                    break;
                case 9: PrintPDF(rchunix9);
                    break;
                case 10: PrintPDF(rchunix10);
                    break;
                case 11: PrintPDF(rchunix11);
                    break;
                case 12: PrintPDF(rchunix12);
                    break;
                case 13: PrintPDF(rchunix13);
                    break;
                case 14: PrintPDF(rchunix14);
                    break;
                case 15: PrintPDF(rchunix15);
                    break;
                case 100: PrintPDF(rchunix_con);
                    break;
            }
        }
    }
}
