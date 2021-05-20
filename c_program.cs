using System;
using System.Windows.Forms;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Fortune_Infotech
{
    public partial class c_program : Form
    {
        public c_program()
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
            list.Add(rchc1);
            list.Add(rchc2);
            list.Add(rchc3);
            list.Add(rchc4);
            list.Add(rchc5);
            list.Add(rchc6);
            list.Add(rchc7);
            list.Add(rchc8);
            list.Add(rchc9);
            list.Add(rchc10);
            list.Add(rchc11);
            list.Add(rchc12);
            list.Add(rchc13);
            list.Add(rchc14);
            list.Add(rchc15);
            list.Add(rchc_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void c_program_Load(object sender, EventArgs e)
        {

            switch(Home.var_c)
            {
                case 1: setActive(rchc1);
                    break;
                case 2: setActive(rchc2);
                    break;
                case 3: setActive(rchc3);
                    break;
                case 4: setActive(rchc4);
                    break;
                case 5: setActive(rchc5);
                    break;
                case 6: setActive(rchc6);
                    break;
                case 7: setActive(rchc7);
                    break;
                case 8: setActive(rchc8);
                    break;
                case 9: setActive(rchc9);
                    break;
                case 10: setActive(rchc10);
                    break;
                case 11: setActive(rchc11);
                    break;
                case 12: setActive(rchc12);
                    break;
                case 13: setActive(rchc13);
                    break;
                case 14: setActive(rchc14);
                    break;
                case 15: setActive(rchc15);
                    break;
                case 100: setActive(rchc_con);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(Home.var_c)
            {
                case 1: PrintPDF(rchc1);
                        break;
                case 2: PrintPDF(rchc2);
                        break;
                case 3: PrintPDF(rchc3);
                        break;
                case 4: PrintPDF(rchc4);
                        break;
                case 5: PrintPDF(rchc5);
                        break;
                case 6: PrintPDF(rchc6);
                        break;
                case 7: PrintPDF(rchc7);
                        break;
                case 8: PrintPDF(rchc8);
                        break;
                case 9: PrintPDF(rchc9);
                        break;
                case 10: PrintPDF(rchc10);
                        break;
                case 11: PrintPDF(rchc11);
                        break;
                case 12: PrintPDF(rchc12);
                        break;
                case 13: PrintPDF(rchc13);
                        break;
                case 14: PrintPDF(rchc14);
                        break;
                case 15: PrintPDF(rchc15);
                        break;
                case 100: PrintPDF(rchc_con);
                        break;
            }
        }
    }
}
