using System;

public class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }

    public Student Link { get; set; }
}
public class Queue
{
    public Student Head { get; set; }
    public Student Tail { get; set; }

    public void Enqueue(Student student)
    {
        if (Head == null)
        {
            Head = Tail = student;
        }
        else
        {
            Tail.Link = student;
            Tail = student;
        }
    }
    public Student Dequeue()
    {
        var temp = Head;
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
        Queue queue = new Queue();

        queue.Enqueue(new Student { Roll = 10, Name = "AA" });
        queue.Enqueue(new Student { Roll = 20, Name = "BA" });

        Console.WriteLine("-----");
        queue.Print();
        Console.WriteLine("-----");

        queue.Enqueue(new Student { Roll = 30, Name = "CA" });

        var deleted = queue.Dequeue();
        if (deleted != null)
            Console.WriteLine("Delete the node => " + deleted.Roll + " " + deleted.Name);
        deleted = queue.Dequeue();
        if (deleted != null)
            Console.WriteLine("Delete the node => " + deleted.Roll + " " + deleted.Name);

        Console.WriteLine("-----");
        queue.Print();
        Console.WriteLine("-----");
    }
}
