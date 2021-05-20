using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Fortune_Infotech
{
    public partial class ada : Form
    {
        public ada()
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
                        Chunk c1 = new Chunk("                              Seshadripuram College Tumakuru ",FontFactory.GetFont("Microsoft Tai Le"));
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
            list.Add(rchada1);
            list.Add(rchada2);
            list.Add(rchada3);
            list.Add(rchada4);
            list.Add(rchada5);
            list.Add(rchada6);
            list.Add(rchada7);
            list.Add(rchada8);
            list.Add(rchada9);
            list.Add(rchada10);
            list.Add(rchada11);
            list.Add(rchada12);
            list.Add(rchada13);
            list.Add(rchada14);
            list.Add(rchada15);
            list.Add(rchada_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }
        private void ada_Load(object sender, EventArgs e)
        {
            switch(Home.var_ada)
            {
                case 1: setActive(rchada1);
                    break;
                case 2: setActive(rchada2);
                    break;
                case 3: setActive(rchada3);
                    break;
                case 4: setActive(rchada4);
                    break;
                case 5: setActive(rchada5);
                    break;
                case 6: setActive(rchada6);
                    break;
                case 7: setActive(rchada7);
                    break;
                case 8: setActive(rchada8);
                    break;
                case 9: setActive(rchada9);
                    break;
                case 10: setActive(rchada10);
                    break;
                case 11: setActive(rchada11);
                    break;
                case 12: setActive(rchada12);
                    break;
                case 13: setActive(rchada13);
                    break;
                case 14: setActive(rchada14);
                    break;
                case 15: setActive(rchada15);
                    break;
                case 100: setActive(rchada_con);
                    break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_ada)
            {
                case 1: PrintPDF(rchada1);
                    break;
                case 2: PrintPDF(rchada2);
                    break;
                case 3: PrintPDF(rchada3);
                    break;
                case 4: PrintPDF(rchada4);
                    break;
                case 5: PrintPDF(rchada5);
                    break;
                case 6: PrintPDF(rchada6);
                    break;
                case 7: PrintPDF(rchada7);
                    break;
                case 8: PrintPDF(rchada8);
                    break;
                case 9: PrintPDF(rchada9);
                    break;
                case 10: PrintPDF(rchada10);
                    break;
                case 11: PrintPDF(rchada11);
                    break;
                case 12: PrintPDF(rchada12);
                    break;
                case 13: PrintPDF(rchada13);
                    break;
                case 14: PrintPDF(rchada14);
                    break;
                case 15: PrintPDF(rchada15);
                    break;
                case 100: PrintPDF(rchada_con);
                    break;
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
           
        }          
    }
}
