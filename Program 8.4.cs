class Program
{
    static void Main()
    {
        GenericArray<int> intArray = new GenericArray<int>(5);
        GenericArray<string> stringArray = new GenericArray<string>(3);
        GenericArray<double> doubleArray = new GenericArray<double>(4);

        intArray.AddItem(0, 8);
        intArray.AddItem(1, 16);
        intArray.AddItem(2, 32);

        stringArray.AddItem(0, "Обобщение");
        stringArray.AddItem(1, "Делегирование");
        stringArray.AddItem(2, "Наследование");

        doubleArray.AddItem(0, 8.233);
        doubleArray.AddItem(1, 1.56);
        doubleArray.AddItem(1, 76.09);

        Console.WriteLine("Элемент по индексу 1 в intArray: " + intArray.GetItem(1));
        Console.WriteLine("Элемент по индексу 0 в stringArray: " + stringArray.GetItem(0));
        Console.WriteLine("Элемент по индексу 0 в doubleArray: " + doubleArray.GetItem(0));

        Console.WriteLine("Длина intArray: " + intArray.GetLength());
        Console.WriteLine("Длина stringArray: " + stringArray.GetLength());
        Console.WriteLine("Длина doubleArray: " + doubleArray.GetLength());

        LoginStorage logins = new LoginStorage(10);
        PasswordStorage passwords = new PasswordStorage(10);

        RegisterUser(logins, passwords, "user1", "pass1");
        RegisterUser(logins, passwords, "user2", "pass2");

        Console.WriteLine("Логин пользователя 1: " + logins.GetItem(0));
        Console.WriteLine("Пароль пользователя 1: " + passwords.GetItem(0));

        // Метод для регистрации пользователя
        static void RegisterUser(LoginStorage logins, PasswordStorage passwords, string login, string password)
        {
            int index = FindEmptyIndex(logins);
            if (index != -1)
            {
                logins.AddItem(index, login);
                passwords.AddItem(index, password);
                Console.WriteLine("Пользователь " + login + " зарегистрирован.");
            }
            else
            {
                Console.WriteLine("Хранилище пользователей заполнено.");
            }
        }

        // Метод для поиска свободного индекса в хранилище
        static int FindEmptyIndex(GenericArray<string> array)
        {
            for (int i = 0; i < array.GetLength(); i++)
            {
                if (array.GetItem(i) == null)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}