using System;

namespace Delegate
{
    public delegate void DOCProgram();

    public delegate void ProDOCProgram();

    public delegate void ExpertProgram();
    class Program
    {
        static void Start()
        {
            DocumentProgram docProgram = new();
            DocumentProgram prodocProgram = new ProDocumentProgram();
            DocumentProgram expDoc = new ExpertDocument();



            DOCProgram program = docProgram.OpenDocument;
            program += docProgram.EditDocument;
            program += docProgram.SaveDocument;

            ProDOCProgram proProg = prodocProgram.OpenDocument;
            proProg += prodocProgram.EditDocument;
            proProg += prodocProgram.SaveDocument;

            ExpertProgram expProg = expDoc.OpenDocument;
            expProg = expDoc.EditDocument;
            expProg = expDoc.SaveDocument;

            Console.WriteLine("Acar sozu daxil edin (basic/pro/expert): ");
            string key = Console.ReadLine();

            if (key == "basic")
                program.Invoke();
            else if (key == "pro")
                proProg.Invoke();
            else if (key == "expert")
                expProg.Invoke();
        }

        static void Main(string[] args)
        {
            Start();
        }
    }
}
