namespace FileIODemo
{
    class Program
    {
        public static void Main(string[] args) 
        {
            string path = "J:\\240\\FileIODemo\\FileIODemo\\Example.txt";
            //CheckFileExists(path);
            //ReadTheDataFromFile(path);
            //ReadFromFile(path);
            //CopyToAnotherFile(path);
            //DeleteTheFile(path);
            //ReadFromStreamReader(path);
            //WriteUsingStreamWriter(path);

            //BinarySerialization binarySerialization = new BinarySerialization();
            //binarySerialization.Serialization();
            //binarySerialization.DeSerialization();

            CSVHandlerDemo cSVHandlerDemo = new CSVHandlerDemo();
            cSVHandlerDemo.ImplementCSVDataHandling();

        }
        public static void CheckFileExists(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("The File Exists");
            }
            else
            {
                Console.WriteLine("The File Not Exists");
            }
        }
        public static void ReadTheDataFromFile(string path)
        {
            string[] lines;
            lines= File.ReadAllLines(path);

            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
        }
        public static void ReadFromFile(string path)
        {
            string line;
            line = File.ReadAllText(path);

            Console.WriteLine(line);
        }
        public static void CopyToAnotherFile(string path)
        {
            string copyPath = "J:\\240\\FileIODemo\\FileIODemo\\CopyExample.txt";
            File.Copy(path, copyPath);
        }
        public static void DeleteTheFile(string path)
        {
            string copyPath = "J:\\240\\FileIODemo\\FileIODemo\\CopyExample.txt";
            File.Delete(copyPath);
        }
        public static void ReadFromStreamReader(string path)
        {
            using (StreamReader sr = File.OpenText(path)) 
            {
                string s = "";
                while (( s = sr.ReadLine()) != null ) 
                {
                    Console.WriteLine(s);
                }
            }
        }
        public static void WriteUsingStreamWriter(string path)
        {
            using (StreamWriter sr = File.AppendText(path))
            {
                
                sr.WriteLine("\n.Net is a Technology");
            }
        }
    }
}