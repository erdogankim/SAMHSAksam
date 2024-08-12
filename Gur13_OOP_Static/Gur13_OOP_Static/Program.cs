using Gur13_OOP_Static;

//Person p = new Person();
//PersonDbOperation pdo = new PersonDbOperation();
//PersonDbOperation.AddPersonToDb(p);

Person p1 = new Person();
p1.Name = "Ahmet";
Person p2 = new Person();
p2.Name = "Mehmet";
Person p3 = new Person();
p3.Name = "Hasan";
Console.WriteLine("Nesneler tanımlandı");

List<Person> list = new List<Person>();
list.Add(p1);
list.Add(p2);   
list.Add(p3);

Console.WriteLine("Liste tanımlandı");

PersonDbOperation.AddPersonToDb(p1);
PersonDbOperation.AddPersonToDb(p2);
PersonDbOperation.AddPersonToDb(p3);

