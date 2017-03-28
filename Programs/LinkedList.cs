using System;

public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }

    public Student Link { get; set; }
}
public class StudentList
{
    public Student Head { get; set; }
    public Student Tail { get; set; }

    public void Append(Student student)
    {
        if(Head == null)
        {
            Head = Tail = student;
        }
        else
        {
            Tail.Link = student;
            Tail = student;
        }
    }
    public void Append(int roll, string name)
    {
        Append(new global::Student { Roll = roll, Name = name });
    }
    public void AddAtHead(Student student)
    {
        if(Head == null)
        {
            Head = Tail = student;
        }
        else
        {
            student.Link = Head;
            Head = student;
        }
    }
    public void AddAtHead(int roll, string name)
    {
        AddAtHead(new global::Student { Roll = roll, Name = name });
    }

    public void DeleteAtHead()
    {
        if(Head!=null)
        {
            Head = Head.Link;
        }
    }
    public void DeleteAtTail()
    {
        if (Head != null)
        {
            if(Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                Student temp = Head;
                while( temp.Link.Link!=null)
                {
                    temp = temp.Link;
                }
                temp.Link = null;
                Tail = temp;
            }
        }
    }
    public void Print()
    {
        Student temp = Head;
        while( temp!=null)
        {
            Console.WriteLine(temp.Roll + " " + temp.Name);
            temp = temp.Link;
        }
    }
}

public class Test
{
    static void Main()
    {
        StudentList list = new global::StudentList();
        list.Append(new global::Student { Roll = 1, Name = "Raj" });
        list.Append(20, "Manish");
        list.Append(5, "Ram");
        list.Append(52, "Tisha");

        list.AddAtHead(new Student { Roll = 90, Name = "Neha" });
        list.AddAtHead(45, "Mohan");
        list.Print();

        Console.WriteLine("==== After deletion====");
        list.DeleteAtHead();
        list.DeleteAtHead();
        list.DeleteAtTail();
        list.DeleteAtTail();
        list.Print();
    }
}