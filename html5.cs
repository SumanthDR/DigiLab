using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class html5 : Form
    {
        public html5()
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
            list.Add(rchip1);
            list.Add(rchip2);
            list.Add(rchip3);
            list.Add(rchip4);
            list.Add(rchip5);
            list.Add(rchip6);
            list.Add(rchip7);
            list.Add(rchip8);
            list.Add(rchip9);
            list.Add(rchip10);
            list.Add(rchip11);
            list.Add(rchip12);
            list.Add(rchip13);
            list.Add(rchip14);
            list.Add(rchip_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }

        private void html5_Load(object sender, EventArgs e)
        {
            switch(Home.var_ip)
            {
                case 1: setActive(rchip1);
                    break;
                case 2: setActive(rchip2);
                    break;
                case 3: setActive(rchip3);
                    break;
                case 4: setActive(rchip4);
                    break;
                case 5: setActive(rchip5);
                    break;
                case 6: setActive(rchip6);
                    break;
                case 7: setActive(rchip7);
                    break;
                case 8: setActive(rchip8);
                    break;
                case 9: setActive(rchip9);
                    break;
                case 10: setActive(rchip10);
                    break;
                case 11: setActive(rchip11);
                    break;
                case 12: setActive(rchip12);
                    break;
                case 13: setActive(rchip13);
                    break;
                case 14: setActive(rchip14);
                    break;
                case 100: setActive(rchip_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_ip)
            {
                case 1: PrintPDF(rchip1);
                    break;
                case 2: PrintPDF(rchip2);
                    break;
                case 3: PrintPDF(rchip3);
                    break;
                case 4: PrintPDF(rchip4);
                    break;
                case 5: PrintPDF(rchip5);
                    break;
                case 6: PrintPDF(rchip6);
                    break;
                case 7: PrintPDF(rchip7);
                    break;
                case 8: PrintPDF(rchip8);
                    break;
                case 9: PrintPDF(rchip9);
                    break;
                case 10: PrintPDF(rchip10);
                    break;
                case 11: PrintPDF(rchip11);
                    break;
                case 12: PrintPDF(rchip12);
                    break;
                case 13: PrintPDF(rchip13);
                    break;
                case 14: PrintPDF(rchip14);
                    break;
                case 100: PrintPDF(rchip_con);
                    break;
            }
        }
    }
}
