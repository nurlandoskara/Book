using Book.Models;
using GemBox.Document;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Book.Data
{
    public class TestData
    {
        public static List<Test> GetItems()
        {
            var list = new List<Test>();
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            var doc = DocumentModel.Load("Test.docx");
            int i = 0;
            Test test = new Test { Answers = new List<Answer>()};
            foreach (Paragraph paragraph in doc.GetChildElements(true, ElementType.Paragraph))
            {
                // Iterate through all Run elements in the Paragraph element.
                foreach (Run run in paragraph.GetChildElements(true, ElementType.Run))
                {
                    var par = run.Text;
                    i++;
                    if (i==1)
                    {
                        test.Question = par.ToString();
                    }
                    else if(i<=6)
                    {
                        var isCorrect = i == 2;
                        test.Answers.Add(new Answer { Text = par.ToString(), IsCorrect = isCorrect });
                    }
                    else
                    {
                        i = 0;
                        list.Add(test);
                        test = new Test { Answers = new List<Answer>() };
                    }
                }
            }

            return list;
        }
    }
}
