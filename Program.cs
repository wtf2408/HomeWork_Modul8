using System.Xml.Linq;

Console.WriteLine("Введите " +
    "ФИО\n" +
    "Улица\n" +
    "Номер дома\n" +
    "Номер квартиры\n" +
    "Мобильный телефон\n" +
    "Домашний телефон");
string fio = Console.ReadLine();
string street = Console.ReadLine();
int houseNumber = int.Parse(Console.ReadLine());
int flatNumber = int.Parse(Console.ReadLine());
string mobilePhone = Console.ReadLine();
string flatPhone = Console.ReadLine();

AddSubscriber(fio, street, houseNumber, flatNumber, mobilePhone , flatPhone);
void AddSubscriber(string fio, 
                   string street, 
                   int houseNumber, 
                   int flatNumber, 
                   string mobilePhone,
                   string flatPhone)
{
    XElement Person = new XElement("Person");
    XAttribute name = new XAttribute("name", fio);
    Person.Add(name);

    XElement Address = new XElement("Address");
    XElement Street = new XElement("Street", street);
    XElement HouseNumber = new XElement("HouseNumber", houseNumber);
    XElement FlatNumber = new XElement("FlatNumber", flatNumber);
    Address.Add(Street);
    Address.Add(HouseNumber);
    Address.Add(FlatNumber);
    Person.Add(Address);

    XElement Phones = new XElement("Phones");
    XElement MobilePhone = new XElement("MobilePhone", mobilePhone);
    XElement FlatPhone = new XElement("FlatPhone", flatPhone);
    Phones.Add(MobilePhone);
    Phones.Add(FlatPhone);
    Person.Add(Phones);

    Person.Save(@"D:\notebook.xml");
}
