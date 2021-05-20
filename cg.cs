using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class cg : Form
    {
        public cg()
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
            list.Add(rchcg1);
            list.Add(rchcg2);
            list.Add(rchcg3);
            list.Add(rchcg4);
            list.Add(rchcg5);
            list.Add(rchcg6);
            list.Add(rchcg7);
            list.Add(rchcg8);
            list.Add(rchcg9);
            list.Add(rchcg10);
            list.Add(rchcg11);
            list.Add(rchcg12);
            list.Add(rchcg_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void cg_Load(object sender, EventArgs e)
        {
            switch(Home.var_cg)
            {
                case 1: setActive(rchcg1);
                    break;
                case 2: setActive(rchcg2);
                    break;
                case 3: setActive(rchcg3);
                    break;
                case 4: setActive(rchcg4);
                    break;
                case 5: setActive(rchcg5);
                    break;
                case 6: setActive(rchcg6);
                    break;
                case 7: setActive(rchcg7);
                    break;
                case 8: setActive(rchcg8);
                    break;
                case 9: setActive(rchcg9);
                    break;
                case 10: setActive(rchcg10);
                    break;
                case 11: setActive(rchcg11);
                    break;
                case 12: setActive(rchcg12);
                    break;
                case 100: setActive(rchcg_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_cg)
            {
                case 1: PrintPDF(rchcg1);
                    break;
                case 2: PrintPDF(rchcg2);
                    break;
                case 3: PrintPDF(rchcg3);
                    break;
                case 4: PrintPDF(rchcg4);
                    break;
                case 5: PrintPDF(rchcg5);
                    break;
                case 6: PrintPDF(rchcg6);
                    break;
                case 7: PrintPDF(rchcg7);
                    break;
                case 8: PrintPDF(rchcg8);
                    break;
                case 9: PrintPDF(rchcg9);
                    break;
                case 10: PrintPDF(rchcg10);
                    break;
                case 11: PrintPDF(rchcg11);
                    break;
                case 12: PrintPDF(rchcg12);
                    break;
                case 100: PrintPDF(rchcg_con);
                    break;
            }
        }
    }
}
