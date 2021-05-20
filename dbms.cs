using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class dbms : Form
    {
        public dbms()
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
            list.Add(rchdbms1);
            list.Add(rchdbms2);
            list.Add(rchdbms3);
            list.Add(rchdbms4);
            list.Add(rchdbms5);
            list.Add(rchdbms6);
            list.Add(rchdbms7);
            list.Add(rchdbms8);
            list.Add(rchdbms9);
            list.Add(rchdbms10);
            list.Add(rchdbms11);
            list.Add(rchdbms12);
            list.Add(rchdbms_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void dbms_Load(object sender, EventArgs e)
        {
            switch(Home.var_dbms)
            {
                case 1: setActive(rchdbms1);
                    break;
                case 2: setActive(rchdbms2);
                    break;
                case 3: setActive(rchdbms3);
                    break;
                case 4: setActive(rchdbms4);
                    break;
                case 5: setActive(rchdbms5);
                    break;
                case 6: setActive(rchdbms6);
                    break;
                case 7: setActive(rchdbms7);
                    break;
                case 8: setActive(rchdbms8);
                    break;
                case 9: setActive(rchdbms9);
                    break;
                case 10: setActive(rchdbms10);
                    break;
                case 11: setActive(rchdbms11);
                    break;
                case 12: setActive(rchdbms12);
                    break;
                case 100: setActive(rchdbms_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_dbms)
            {
                case 1: PrintPDF(rchdbms1);
                    break;
                case 2: PrintPDF(rchdbms2);
                    break;
                case 3: PrintPDF(rchdbms3);
                    break;
                case 4: PrintPDF(rchdbms4);
                    break;
                case 5: PrintPDF(rchdbms5);
                    break;
                case 6: PrintPDF(rchdbms6);
                    break;
                case 7: PrintPDF(rchdbms7);
                    break;
                case 8: PrintPDF(rchdbms8);
                    break;
                case 9: PrintPDF(rchdbms9);
                    break;
                case 10: PrintPDF(rchdbms10);
                    break;
                case 11: PrintPDF(rchdbms11);
                    break;
                case 12: PrintPDF(rchdbms12);
                    break;
                case 100: PrintPDF(rchdbms_con);
                    break;
            }
        }
    }
}
