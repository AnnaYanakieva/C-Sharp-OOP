namespace DefiningClassesPart2
{
    using System;
    using System.IO;
    using System.Text;

    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            StreamWriter file = new StreamWriter("..//..//file.txt");
            using (file)
            {
                for (int i = 0; i < path.SequenceOfPoints.Count; i++)
                { 
                        file.WriteLine(path.SequenceOfPoints[i]);                    
                }
            }
        }
        public static string ReadPath()
        {
            StringBuilder file = new StringBuilder();
            StreamReader path = new StreamReader("..//..//file.txt");

            using (path)
            {                
                file.Append(path.ReadToEnd());
            }
            return file.ToString();
        }
    }
}
    

