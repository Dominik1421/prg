Student student = new Student(16, "dominik");
student.Greet();
ChangeStudent(student);
student.Greet();

void ChangeStudent(Student s)
{
    s.name = "Nothing";
}
