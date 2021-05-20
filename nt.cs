using System;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace Fortune_Infotech
{
    public partial class nt : Form
    {
        public nt()
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
            list.Add(rchnt1);
            list.Add(rchnt2);
            list.Add(rchnt3);
            list.Add(rchnt4);
            list.Add(rchnt5);
            list.Add(rchnt6);
            list.Add(rchnt7);
            list.Add(rchnt8);
            list.Add(rchnt_con);
            foreach (RichTextBox rc in list)
            {
                if (rc.Name == rcTxtbx.Name)
                    rc.Visible = true;
                else
                    rc.Visible = false;
            }
        }

        private void nt_Load(object sender, EventArgs e)
        {
            switch(Home.var_nt)
            {
                case 1: setActive(rchnt1);
                    break;
                case 2: setActive(rchnt2);
                   break;
                case 3: setActive(rchnt3);
                   break;
                case 4: setActive(rchnt4);
                   break;
                case 5: setActive(rchnt5);
                   break;
                case 6: setActive(rchnt6);
                   break;
                case 7: setActive(rchnt7);
                   break;
                case 8: setActive(rchnt8);
                   break;
                case 100: setActive(rchnt_con);
                   break;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            switch(Home.var_nt)
            {
                case 1: PrintPDF(rchnt1);
                    break;
                case 2: PrintPDF(rchnt2);
                    break;
                case 3: PrintPDF(rchnt3);
                    break;
                case 4: PrintPDF(rchnt4);
                    break;
                case 5: PrintPDF(rchnt5);
                    break;
                case 6: PrintPDF(rchnt6);
                    break;
                case 7: PrintPDF(rchnt7);
                    break;
                case 8: PrintPDF(rchnt8);
                    break;
                case 100: PrintPDF(rchnt_con);
                    break;
            }
        }
    }
}
