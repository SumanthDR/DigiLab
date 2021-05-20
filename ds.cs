using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class ds : Form
    {
        public ds()
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
            list.Add(rchds1);
            list.Add(rchds2);
            list.Add(rchds3);
            list.Add(rchds4);
            list.Add(rchds5);
            list.Add(rchds6);
            list.Add(rchds7);
            list.Add(rchds8);
            list.Add(rchds9);
            list.Add(rchds10);
            list.Add(rchds11);
            list.Add(rchds12);
            list.Add(rchds13);
            list.Add(rchds14);
            list.Add(rchds15);
            list.Add(rchds16);
            list.Add(rchds17);
            list.Add(rchds_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void ds_Load(object sender, EventArgs e)
        {
            switch(Home.var_ds)
            {
                case 1: setActive(rchds1);
                    break;
                case 2: setActive(rchds2);
                    break;
                case 3: setActive(rchds3);
                    break;
                case 4: setActive(rchds4);
                    break;
                case 5: setActive(rchds5);
                    break;
                case 6: setActive(rchds6);
                    break;
                case 7: setActive(rchds7);
                    break;
                case 8: setActive(rchds8);
                    break;
                case 9: setActive(rchds9);
                    break;
                case 10: setActive(rchds10);
                    break;
                case 11: setActive(rchds11);
                    break;
                case 12: setActive(rchds12);
                    break;
                case 13: setActive(rchds13);
                    break;
                case 14: setActive(rchds14);
                    break;
                case 15: setActive(rchds15);
                    break;
                case 16: setActive(rchds16);
                    break;
                case 17: setActive(rchds17);
                    break;
                case 100: setActive(rchds_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_ds)
            {
                case 1: PrintPDF(rchds1);
                    break;
                case 2: PrintPDF(rchds2);
                    break;
                case 3: PrintPDF(rchds3);
                    break;
                case 4: PrintPDF(rchds4);
                    break;
                case 5: PrintPDF(rchds5);
                    break;
                case 6: PrintPDF(rchds6);
                    break;
                case 7: PrintPDF(rchds7);
                    break;
                case 8: PrintPDF(rchds8);
                    break;
                case 9: PrintPDF(rchds9);
                    break;
                case 10: PrintPDF(rchds10);
                    break;
                case 11: PrintPDF(rchds11);
                    break;
                case 12: PrintPDF(rchds12);
                    break;
                case 13: PrintPDF(rchds13);
                    break;
                case 14: PrintPDF(rchds14);
                    break;
                case 15: PrintPDF(rchds15);
                    break;
                case 16: PrintPDF(rchds16);
                    break;
                case 17: PrintPDF(rchds17);
                    break;
                case 100: PrintPDF(rchds_con);
                    break;
            }
        }
    }
}
