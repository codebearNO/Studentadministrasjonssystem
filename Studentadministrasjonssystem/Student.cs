namespace Studentadministrasjonssystem
{
    internal class Student
    {
        private string _name { get; }
        private int _age;
        private string _program;
        private int _id;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"{_name} er en {_program}-student på {_age}år. Student-ID: {_id}");
        }

        public Student(string name, int age, string program, int id)
        {
            _name = name;
            _age = age;
            _program = program;
            _id = id;
        }
    }
}
