//using System.Xml.Linq;


#region Task1
//Создайте лист целых чисел. 
//Заполните лист 100 случайными числами в диапазоне от 0 до 100. 
//Выведите коллекцию чисел на экран. 
//Удалите из листа числа, которые больше 25, но меньше 50. 
//Снова выведите числа на экран. 

//void FillList(List<int> nums)
//{
//    Random random = new Random();
//    for (int i = 0; i < 100; i++)
//    {
//        nums.Add(random.Next(101));
//    }
//}
//void PrintList(List<int> nums)
//{
//    foreach (var item in nums) Console.Write($"{item} ");
//}
//void DeleteRange(List<int> nums, int numFrom, int numTo)
//{
//    nums.RemoveAll(i => numFrom < i && i < numTo);
//}

//List<int> numbers = new List<int>();

//FillList(numbers);
//PrintList(numbers);
//Console.WriteLine();
//DeleteRange(numbers, 25, 50);
//PrintList(numbers);
#endregion

#region Task2
//Dictionary<string, string> phoneBook = new Dictionary<string, string>();
//while (true)
//{
//    Console.WriteLine($"добавить абонента - 1\n" +
//        $"просмотреть книжку - 2\n" +
//        $"закончить - 3");
//    char inputAnswer = Console.ReadKey().KeyChar;
//    if (inputAnswer == '3') break;
//    switch (inputAnswer)
//    {
//        case '1':
//            Console.WriteLine("Введите номер, а затем ФИО абонента");
//            string inputNumber = Console.ReadLine();
//            string inputFIO = Console.ReadLine();
//            phoneBook[inputNumber] = inputFIO;
//            break;
//        case '2':
//            Console.WriteLine("Введите номер владельца");
//            inputNumber = Console.ReadLine();
//            if (phoneBook.ContainsKey(inputNumber))
//                Console.WriteLine(phoneBook[inputNumber]);
//            else Console.WriteLine("Нет такого номера");
//            break;
//    }
//}
#endregion

#region Task3
//Пользователь вводит число. Число сохраняется в HashSet коллекцию. Если такое число уже присутствует
//в коллекции, то пользователю на экран выводится сообщение, что число уже вводилось ранее.
//Если числа нет, то появляется сообщение о том, что число успешно сохранено. 

//HashSet<int> numbers = new HashSet<int>();
//while (true)
//{
//    Console.WriteLine("- Нажмите цифру 1 для продолжения\n" +
//        "- любую цифру для закрытия");
//    if (Console.ReadKey().KeyChar == '1')
//    {
//        Console.WriteLine("Введите число");
//        int inputNumber = int.Parse(Console.ReadLine());
//        if (numbers.Contains(inputNumber)) Console.WriteLine("Такое число уже есть");
//        else
//        {
//            numbers.Add(inputNumber);
//            Console.WriteLine("Число успешно сохранено");
//        }
//    }
//    else break;
}

#endregion

#region Task4
//Console.WriteLine("Введите " +
//    "ФИО\n" +
//    "Улица\n" +
//    "Номер дома\n" +
//    "Номер квартиры\n" +
//    "Мобильный телефон\n" +
//    "Домашний телефон");
//string fio = Console.ReadLine();
//string street = Console.ReadLine();
//int houseNumber = int.Parse(Console.ReadLine());
//int flatNumber = int.Parse(Console.ReadLine());
//string mobilePhone = Console.ReadLine();
//string flatPhone = Console.ReadLine();

//AddSubscriber(fio, street, houseNumber, flatNumber, mobilePhone , flatPhone);
//void AddSubscriber(string fio, 
//                   string street, 
//                   int houseNumber, 
//                   int flatNumber, 
//                   string mobilePhone,
//                   string flatPhone)
//{
//    XElement Person = new XElement("Person");
//    XAttribute name = new XAttribute("name", fio);
//    Person.Add(name);

//    XElement Address = new XElement("Address");
//    XElement Street = new XElement("Street", street);
//    XElement HouseNumber = new XElement("HouseNumber", houseNumber);
//    XElement FlatNumber = new XElement("FlatNumber", flatNumber);
//    Address.Add(Street);
//    Address.Add(HouseNumber);
//    Address.Add(FlatNumber);
//    Person.Add(Address);

//    XElement Phones = new XElement("Phones");
//    XElement MobilePhone = new XElement("MobilePhone", mobilePhone);
//    XElement FlatPhone = new XElement("FlatPhone", flatPhone);
//    Phones.Add(MobilePhone);
//    Phones.Add(FlatPhone);
//    Person.Add(Phones);

//    Person.Save(@"D:\notebook.xml");
//}
#endregion