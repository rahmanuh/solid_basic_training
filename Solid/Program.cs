/*
 * Most of the example were taken from https://www.c-sharpcorner.com/UploadFile/damubetha/solid-principles-in-C-Sharp/   
 * Please visit the link if you find any hesitation :) 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // =========================
            // SRP
            // =========================
            SRP.WholeCook wholeCook = new SRP.WholeCook();
            SRP.Appetizer appetizer = new SRP.Appetizer();
            SRP.MainCourse mainCourse = new SRP.MainCourse();
            SRP.Dessert dessert = new SRP.Dessert();

            // Bad example
            Console.WriteLine("======== Bad SRP =======");
            wholeCook.cook();
            Console.WriteLine();

            Console.ReadKey();

            // Good example
            Console.WriteLine("======== Good SRP =======");
            appetizer.cookLumpia();
            mainCourse.cookChickenRice();
            dessert.cookEsCampur();
            Console.WriteLine();

            Console.ReadKey();



            // =========================
            // OCP
            // =========================
            OCP.Rectangle rectangle = new OCP.Rectangle();
            OCP.Circle circle = new OCP.Circle();
            OCP.AreaCalculator areaCalculator = new OCP.AreaCalculator();
            object[] obj = new object[] { rectangle, circle };
            OCP.Shape[] shape = new OCP.Shape[2];

            // Bad example
            
            rectangle.Height = 20;
            rectangle.Width = 15;
            circle.Radius = 10;

            Console.WriteLine("======== Bad OCP =======");
            areaCalculator.TotalArea(obj);
            Console.WriteLine();
            Console.ReadKey();

            // Good example
            Console.WriteLine("======== Good OCP =======");
            shape[0] = rectangle;
            shape[1] = circle;
            areaCalculator.TotalArea(shape);
            Console.WriteLine();
            Console.ReadKey();




            // =========================
            // LSP
            // =========================
            LSP.SqlFile sqlFile = new LSP.SqlFile();
            LSP.SqlFileManager sqlFileManager = new LSP.SqlFileManager();
            LSP.ReadOnlySqlFile readOnlySqlFile = new LSP.ReadOnlySqlFile();

            // Bad example
            Console.WriteLine("======== Bad LSP =======");

            sqlFile.FilePath = "/home/formulatrix/Documents";
            sqlFile.FileText = "Hello I am a file";

            sqlFileManager.lstSqlFiles = new List<LSP.SqlFile>();
            sqlFileManager.lstSqlFiles.Add(sqlFile);

            sqlFileManager.GetTextFromFiles();
            sqlFileManager.SaveTextIntoFiles();

            Console.WriteLine();
            Console.ReadKey();


            // Good example
            Console.WriteLine("======== Good LSP =======");
            sqlFile.FilePath = "/home/formulatrix/Documents";
            sqlFile.FileText = "Hello I am a file";

            readOnlySqlFile.FilePath = "/home/formulatrix/Documents/readOnly";
            readOnlySqlFile.FileText = "You cannot write me, I am read only";

            List<LSP.IReadableSqlFile> readableFiles = new List<LSP.IReadableSqlFile>();
            List<LSP.IWritableSqlFile> writeableFiles = new List<LSP.IWritableSqlFile>();

            readableFiles.Add(sqlFile);
            writeableFiles.Add(sqlFile);

            readableFiles.Add(readOnlySqlFile);
            //writeableFiles.Add(readOnlySqlFile);

            sqlFileManager.GetTextFromFiles(readableFiles);
            sqlFileManager.SaveTextIntoFiles(writeableFiles);


            //Console.WriteLine();
            //Console.ReadKey();


            // =========================
            // ISP
            // =========================
            ISP.Manager manager = new ISP.Manager();
            ISP.TeamLead teamLead = new ISP.TeamLead();
            ISP.Programmer programmer = new ISP.Programmer();

            // Bad example
            Console.WriteLine("======== Bad ISP =======");
            manager.AssignTask();
            manager.CreateSubTask();
            //manager.workOnTask();
            Console.WriteLine();

            Console.ReadKey();

            // Good example
            Console.WriteLine("======== Good ISP =======");
            manager.AssignTask();
            teamLead.CreateSubTask();
            programmer.WorkOnTask();
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
