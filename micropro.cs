using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class micropro : Form
    {
        public micropro()
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
            list.Add(rchmp1);
            list.Add(rchmp2);
            list.Add(rchmp3);
            list.Add(rchmp4);
            list.Add(rchmp5);
            list.Add(rchmp6);
            list.Add(rchmp7);
            list.Add(rchmp8);
            list.Add(rchmp9);
            list.Add(rchmp10);
            list.Add(rchmp11);
            list.Add(rchmp_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void micropro_Load(object sender, EventArgs e)
        {
            switch(Home.var_mp)
            {
                case 1: setActive(rchmp1);
                    break;
                case 2: setActive(rchmp2);
                    break;
                case 3: setActive(rchmp3);
                    break;
                case 4: setActive(rchmp4);
                    break;
                case 5: setActive(rchmp5);
                    break;
                case 6: setActive(rchmp6);
                    break;
                case 7: setActive(rchmp7);
                    break;
                case 8: setActive(rchmp8);
                    break;
                case 9: setActive(rchmp9);
                    break;
                case 10: setActive(rchmp10);
                    break;
                case 11: setActive(rchmp11);
                    break;
                case 100: setActive(rchmp_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_mp)
            {
                case 1: PrintPDF(rchmp1);
                        break;
                case 2: PrintPDF(rchmp2);
                        break;
                case 3: PrintPDF(rchmp3);
                        break;
                case 4: PrintPDF(rchmp4);
                        break;
                case 5: PrintPDF(rchmp5);
                        break;
                case 6: PrintPDF(rchmp6);
                        break;
                case 7: PrintPDF(rchmp7);
                        break;
                case 8: PrintPDF(rchmp8);
                        break;
                case 9: PrintPDF(rchmp9);
                        break;
                case 10: PrintPDF(rchmp10);
                        break;
                case 11: PrintPDF(rchmp11);
                        break;
                case 100: PrintPDF(rchmp_con);
                        break;
            }
        }
    }
}
