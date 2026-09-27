using System;

class Course
{
    // Приватні поля
    private string title;
    private string teacher;

    // Публічна властивість
    public int Credits { get; set; }

    // Конструктор
    public Course(string title, string teacher, int credits)
    {
        this.title = title;
        this.teacher = teacher;
        Credits = credits;
    }

    // Метод запису студента на курс
    public void EnrollStudent(string studentName)
    {
        Console.WriteLine(
            $"Студент {studentName} записаний на курс \"{title}\". " +
            $"Викладач: {teacher}, кредити: {Credits}."
        );
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єктів класу Course
        Course course1 = new Course(
            "Об'єктно-орієнтоване програмування",
            "Бубнов Олексій Володимирович",
            4
        );

        Course course2 = new Course(
            "Програмування на C#",
            "Іваненко Іван Іванович",
            5
        );

        Course course3 = new Course(
            "Бази даних",
            "Петренко Петро Петрович",
            3
        );

        // Виклик методу
        course1.EnrollStudent("Павло");
        course2.EnrollStudent("Павло");
        course3.EnrollStudent("Павло");

        Console.WriteLine("\nПрограму завершено.");
    }
}