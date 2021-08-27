namespace XML
{
    public class Window
    {
        public string Title { get; set; }
        public int? Top { get; set; }
        public int? Left { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }

        public bool IsCorrectWindow()
        {
            return Title == "main" && Top != null && Left != null && Width != null && Height != null;
        }

        public override string ToString()
        {
            return $"{Title}({Top},{Left},{Width},{Height})";
        }
    }
}
