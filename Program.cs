using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace hw8
{
    public class Program
    {
        static void Main(string[] args)
        {
            var basic = new DocumentProgram();
            var pro = new ProDocumentProgram();
            var expert = new ExpertDocumentProgram();
            initial:  Console.WriteLine("enter ur option (basic/pro/expert): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "basic":
                    basic.OpenDocument();
                    basic.SaveDocument();
                    basic.EditDocument();
                    break;
                
                case "pro":
                    pro.OpenDocument();
                    pro.SaveDocument();
                    pro.EditDocument();
                    break;

                case "expert":
                    expert.OpenDocument();
                    expert.SaveDocument();
                    expert.EditDocument();
                    break;

                default:
                    Console.Clear();
                    goto initial;
            }

           
            


            
            
            
        }
    }
}