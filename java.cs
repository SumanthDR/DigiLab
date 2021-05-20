using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class java : Form
    {
        public java()
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
            list.Add(rchjava1);
            list.Add(rchjava2);
            list.Add(rchjava3);
            list.Add(rchjava4);
            list.Add(rchjava5);
            list.Add(rchjava6);
            list.Add(rchjava7);
            list.Add(rchjava8);
            list.Add(rchjava9);
            list.Add(rchjava10);
            list.Add(rchjava11);
            list.Add(rchjava12);
            list.Add(rchjava_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void java_Load(object sender, EventArgs e)
        {
            switch(Home.var_java)
            {
                case 1: setActive(rchjava1);
                    break;
                case 2: setActive(rchjava2);
                    break;
                case 3: setActive(rchjava3);
                    break;
                case 4: setActive(rchjava4);
                    break;
                case 5: setActive(rchjava5);
                    break;
                case 6: setActive(rchjava6);
                    break;
                case 7: setActive(rchjava7);
                    break;
                case 8: setActive(rchjava8);
                    break;
                case 9: setActive(rchjava9);
                    break;
                case 10: setActive(rchjava10);
                    break;
                case 11: setActive(rchjava11);
                    break;
                case 12: setActive(rchjava12);
                    break;
                case 100: setActive(rchjava_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_java)
            {
                case 1: PrintPDF(rchjava1);
                    break;
                case 2: PrintPDF(rchjava2);
                    break;
                case 3: PrintPDF(rchjava3);
                    break;
                case 4: PrintPDF(rchjava4);
                    break;
                case 5: PrintPDF(rchjava5);
                    break;
                case 6: PrintPDF(rchjava6);
                    break;
                case 7: PrintPDF(rchjava7);
                    break;
                case 8: PrintPDF(rchjava8);
                    break;
                case 9: PrintPDF(rchjava9);
                    break;
                case 10: PrintPDF(rchjava10);
                    break;
                case 11: PrintPDF(rchjava11);
                    break;
                case 12: PrintPDF(rchjava12);
                    break;
                case 100: PrintPDF(rchjava_con);
                    break;
            }
        }
    }
}
