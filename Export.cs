using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
namespace DIPS3
{
    public static class Word
    {
        public static void Export(Student a)
        {
            using (WordDocument document = new WordDocument())
            {
                //Adding a new section to the document.
                WSection section = document.AddSection() as WSection;

                //Appends paragraph.
                IWParagraph paragraph = section.AddParagraph();
                WTextRange textRange = textRange = paragraph.AppendText("ФИО: " + a.FIO) as WTextRange;

                //Appends paragraph.
                paragraph = section.AddParagraph();
                textRange = paragraph.AppendText("Телефон: +7" + a.Phone) as WTextRange;

                //Appends paragraph.
                paragraph = section.AddParagraph();
                textRange = paragraph.AppendText("Адрес: " + a.Address) as WTextRange;

                //Appends table.
                if (a.Grades.Count > 1)
                {
                    IWTable table = section.AddTable();
                    table.ResetCells(a.Grades.Count+1, 2);
                    //table.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.None;
                    //  table.TableFormat.IsAutoResized = true;

                    paragraph = table[0, 0].AddParagraph();
                    textRange = paragraph.AppendText("Предмет") as WTextRange;
                    textRange.CharacterFormat.FontSize = 12f;

                    paragraph = table[0, 1].AddParagraph();
                    textRange = paragraph.AppendText("Оценки") as WTextRange;
                    textRange.CharacterFormat.FontSize = 12f;

                    int i = 1;
                    foreach (var item in a.Grades)
                    {

                        paragraph = table[i, 0].AddParagraph();
                        textRange = paragraph.AppendText(item.Key) as WTextRange;

                        paragraph = table[i, 1].AddParagraph();
                        textRange = paragraph.AppendText(item.Value.ToString()) as WTextRange;
                        i++;
                    }
                }

                section.AddParagraph();

                //Saves the document
                document.Save("Карточка студента.docx", FormatType.Docx);
            }


        }
    }
}
