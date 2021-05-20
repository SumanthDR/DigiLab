using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class cpp : Form
    {
        public cpp()
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
            list.Add(rchcpp1);
            list.Add(rchcpp2);
            list.Add(rchcpp3);
            list.Add(rchcpp4);
            list.Add(rchcpp5);
            list.Add(rchcpp6);
            list.Add(rchcpp7);
            list.Add(rchcpp8);
            list.Add(rchcpp9);
            list.Add(rchcpp10);
            list.Add(rchcpp11);
            list.Add(rchcpp12);
            list.Add(rchcpp13);
            list.Add(rchcpp14);
            list.Add(rchcpp15);
            list.Add(rchcpp16);
            list.Add(rchcpp_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }

        private void cpp_Load(object sender, EventArgs e)
        {
            switch(Home.var_cpp)
            {
                case 1: setActive(rchcpp1);
                    break;
                case 2: setActive(rchcpp2);
                    break;
                case 3: setActive(rchcpp3);
                    break;
                case 4: setActive(rchcpp4);
                    break;
                case 5: setActive(rchcpp5);
                    break;
                case 6: setActive(rchcpp6);
                    break;
                case 7: setActive(rchcpp7);
                    break;
                case 8: setActive(rchcpp8);
                    break;
                case 9: setActive(rchcpp9);
                    break;
                case 10: setActive(rchcpp10);
                    break;
                case 11: setActive(rchcpp11);
                    break;
                case 12: setActive(rchcpp12);
                    break;
                case 13: setActive(rchcpp13);
                    break;
                case 14: setActive(rchcpp14);
                    break;
                case 15: setActive(rchcpp15);
                    break;
                case 16: setActive(rchcpp16);
                    break;
                case 100: setActive(rchcpp_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_cpp)
            {
                case 1: PrintPDF(rchcpp1);
                    break;
                case 2: PrintPDF(rchcpp2);
                    break;
                case 3: PrintPDF(rchcpp3);
                    break;
                case 4: PrintPDF(rchcpp4);
                    break;
                case 5: PrintPDF(rchcpp5);
                    break;
                case 6: PrintPDF(rchcpp6);
                    break;
                case 7: PrintPDF(rchcpp7);
                    break;
                case 8: PrintPDF(rchcpp8);
                    break;
                case 9: PrintPDF(rchcpp9);
                    break;
                case 10: PrintPDF(rchcpp10);
                    break;
                case 11: PrintPDF(rchcpp11);
                    break;
                case 12: PrintPDF(rchcpp12);
                    break;
                case 13: PrintPDF(rchcpp13);
                    break;
                case 14: PrintPDF(rchcpp14);
                    break;
                case 15: PrintPDF(rchcpp15);
                    break;
                case 100: PrintPDF(rchcpp_con);
                    break;
            }
        }
    }
}
