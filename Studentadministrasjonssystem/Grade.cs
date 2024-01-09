namespace Studentadministrasjonssystem
{
    internal class Grade
    {
        private Student _student;
        private Class _class;
        private int _value;

        public void SkrivUtInfo()
        {
            Console.WriteLine($"{_student} fikk {_value} i {_class}");
        }
        
        public Grade(Student student, Class @class, int value)
        {
            _student = student;
            _class = @class;
            _value = value;
        }

    }
}
