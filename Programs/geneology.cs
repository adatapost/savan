using System;

public class Person
{
    public string Name { get; set; }
    public Person Father { get; set; }
    public Person Mother { get; set; }
}

public class Test
{
    static void Main()
    {
        Person gf1 = new Person { Name = "M1" };
        Person gm1 = new Person { Name = "M2" };

        Person ch1 = new Person { Name = "V1", Father = gf1, Mother = gm1 };
        Person wch1 = new Person { Name = "WV1" };
        Person ch2 = new Person { Name = "V2", Father = gf1, Mother = gm1 };
        Person wch2 = new Person { Name = "WV2" };

        Person ch3 = new Person { Name = "C1", Father = ch1, Mother = wch1 };

        Console.WriteLine(ch3.Name + " " + ch3.Father.Name + " " + ch3.Father.Father.Name);
        Console.WriteLine(string.Format("Mother of {0} is {1}",ch3.Name,ch3.Mother.Name));

    }
}
