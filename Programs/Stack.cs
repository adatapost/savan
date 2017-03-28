using System;

public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }

    public Student Link { get; set; }
}
public class Stack
{
    public Student Head { get; set; }
    public Student Tail { get; set; }

     
    public void Push(Student student)
    {
        if (Head == null)
        {
            Head = Tail = student;
        }
        else
        {
            student.Link = Head;
            Head = student;
        }
    }
    

    public Student Pop()
    {
        Student temp = Head;
        if (Head != null)
        {
            Head = Head.Link;
        }
        return temp;
    }
    public void Print()
    {
        Student temp = Head;
        while (temp != null)
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
        Stack stack = new global::Stack();
        stack.Push(new global::Student { Roll = 10, Name = "X" });
        stack.Push(new global::Student { Roll = 20, Name = "Y" });
        stack.Push(new global::Student { Roll = 30, Name = "Z" });

        Console.WriteLine("----------");
        stack.Print();
        Console.WriteLine("----------");
        var popped = stack.Pop();
        if (popped != null)
            Console.WriteLine("Deleted node = > " + popped.Roll + " " + popped.Name);
        popped = stack.Pop();
        if (popped != null)
            Console.WriteLine("Deleted node = > " + popped.Roll + " " + popped.Name);

    }
}
