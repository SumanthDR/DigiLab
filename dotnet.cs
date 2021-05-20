using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class dotnet : Form
    {
        public dotnet()
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
            list.Add(rchdotnet1);
            list.Add(rchdotnet2);
            list.Add(rchdotnet3);
            list.Add(rchdotnet4);
            list.Add(rchdotnet5);
            list.Add(rchdotnet6);
            list.Add(rchdotnet7);
            list.Add(rchdotnet8);
            list.Add(rchdotnet9);
            list.Add(rchdotnet10);
            list.Add(rchdotnet11);
            list.Add(rchdotnet12);
            list.Add(rchdotnet13);
            list.Add(rchdotnet14);
            list.Add(rchdotnet15);
            list.Add(rchdotnet_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }

        private void dotnet_Load(object sender, EventArgs e)
        {
            switch(Home.var_dotnet)
            {
                case 1: setActive(rchdotnet1);
                    break;
                case 2: setActive(rchdotnet2);
                    break;
                case 3: setActive(rchdotnet3);
                    break;
                case 4: setActive(rchdotnet4);
                    break;
                case 5: setActive(rchdotnet5);
                    break;
                case 6: setActive(rchdotnet6);
                    break;
                case 7: setActive(rchdotnet7);
                    break;
                case 8: setActive(rchdotnet8);
                    break;
                case 9: setActive(rchdotnet9);
                    break;
                case 10: setActive(rchdotnet10);
                    break;
                case 11: setActive(rchdotnet11);
                    break;
                case 12: setActive(rchdotnet12);
                    break;
                case 13: setActive(rchdotnet13);
                    break;
                case 14: setActive(rchdotnet14);
                    break;
                case 15: setActive(rchdotnet15);
                    break;
                case 100: setActive(rchdotnet_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_dotnet)
            {
                case 1: PrintPDF(rchdotnet1);
                        break;
                case 2: PrintPDF(rchdotnet2);
                        break;
                case 3: PrintPDF(rchdotnet3);
                        break;
                case 4: PrintPDF(rchdotnet4);
                        break;
                case 5: PrintPDF(rchdotnet5);
                        break;
                case 6: PrintPDF(rchdotnet6);
                        break;
                case 7: PrintPDF(rchdotnet7);
                        break;
                case 8: PrintPDF(rchdotnet8);
                        break;
                case 9: PrintPDF(rchdotnet9);
                        break;
                case 10: PrintPDF(rchdotnet10);
                        break;
                case 11: PrintPDF(rchdotnet11);
                        break;
                case 12: PrintPDF(rchdotnet12);
                        break;
                case 13: PrintPDF(rchdotnet13);
                        break;
                case 14: PrintPDF(rchdotnet14);
                        break;
                case 15: PrintPDF(rchdotnet15);
                        break;
                case 100: PrintPDF(rchdotnet_con);
                        break;
            }
        }
    }
}
