namespace Studentadministrasjonssystem
{
    internal class Class
    {
        private int _code;
        private string _name;
        private int _points;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"{_code}: {_name}  -  {_points} studiepoeng");
        }

        public Class(int code, string name, int points)
        {
            _code = code;
            _name = name;
            _points = points;
        }
    }
}
