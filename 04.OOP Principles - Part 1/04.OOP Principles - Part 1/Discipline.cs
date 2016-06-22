namespace SchoolClasses
{
    public class Discipline
    {
      //  private string name;

        public Discipline(string name, int numberOfLectures = 0,int numberOfExcercises=0)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcercises = numberOfExcercises;
        }
        public string Name { get; set; }
        //public string Name
        //{
        //    get
        //    { return this.Name; }
        //    set { this.Name = value; }
        //}
        public int NumberOfLectures { get; set; }
        public int NumberOfExcercises { get; set; }
    }
}
