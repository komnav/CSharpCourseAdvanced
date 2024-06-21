//class Program
//{
//    /// <summary>
//    /// Этом структура сохранится в стеке и ее поля тоже.
//    /// </summary>
//    struct MyStruct
//    {
//        public int A;
//        public int B;
//    }
//    /// <summary>
//    /// Этот метод при вызова сохранится в стеке
//    /// </summary>
//    void Code1()
//    {
//        int intValue = 42;// Это переменна сохранится в сетке
//        object boxedInt = intValue;// Мы в этом строке делаем операции Boxing.И это перемена сохранится в кучу.
//        MyStruct myStruct = new MyStruct { A = 10, B = 20 };//Мы создаем экземпляр структуру MyStruct и даем значения в перемени А и В.он сохранится в кучу 
//        object boxedStruct = myStruct;// Мы в этом строке делаем операции Boxing.Экземпляра структуру myStruct делаем Boxing.Перемена boxedStruct сохранится в стеке.

//        int unboxedInt = (int)boxedInt; //Мы в этом строке делаем операции UnBoxing и он сохранится в стеке.
//        MyStruct unboxedStruct = (MyStruct)boxedStruct;//Мы в этом строке делаем операции UnBoxing и он сохранится в стеке.
//    }

//}

//class MyClass//Мы создаем класс.Сохранится в кучу.В его поля мы создаем два публичный тип инт.
//{
//    public int X;//Сохранится в стеке 
//    public int Y;//Сохранится в стеке 
//    public MyClass NestedClass; //Сохранится в кучу.
//}

//struct MyStruct//Этом структура сохранится в стеке и ее поля тоже.В его поля мы создаем два публичный тип инт и они тоже сохранится в стеке 
//{
//    public int X;
//    public int Y;
//}

//class Program
//{
//    void Code2()// Мы здесь создаем метод и он сохранится в стеке
//    {
//        MyClass class1 = new MyClass();//Здесь мы создаем экземпляра класса и он сохранится в кучу
//        class1.X = 1;//В экземпляра класса мы даем значение он сохранится в стеке 
//        class1.Y = 2;//В экземпляра класса мы даем значение он сохранится в стеке 
//        class1.NestedClass = new MyClass { X = 3, Y = 4 };

//        MyStruct struct1 = new MyStruct { X = 5, Y = 6 };//Здесь мы создаем экземпляр структуру MyStruct и даем значения в перемени Х и Y он сохранится в кучу 
//        MyClass class2 = new MyClass { X = 7, Y = 8, NestedClass = class1 };// Здесь мы создаем экземпляра класса и он сохранится в кучу и даем значения в перемени Х и Y 
//        MyStruct struct2 = struct1;//Мы копируем значения экземпляра структуры struct1 в экземпляра структуры struct2 и он сохранится в стеке
//        struct2.X = 9;//Мы даем значения в экземпляра структуры struct2 в перемена Х и он сохранится в стеке
//    }
//}

//struct MyStruct//Этом структура сохранится в стеке и ее поля тоже.В его поля мы создаем два публичный тип инт и они тоже сохранится в стеке 
//{
//    public int A;
//    public int B;
//}


//class MyClass
//{
//    void Code3()//Мы здесь создаем метод и он сохранится в стеке
//    {
//        MyStruct[] structArray = new MyStruct[2];//Мы создаем экземпляра структуры и говорим что у нас будет две экземпляра.Он сохранится в кучу.
//        structArray[0] = new MyStruct { A = 1, B = 2 };//Мы даем значение и говорим что он новый.Это значит в кучу выделяет новый места для этого экземпляра.И он сохранится в кучу
//        structArray[1] = new MyStruct { A = 3, B = 4 };//Мы даем значение и говорим что он новый.Это значит в кучу выделяет новый места для этого экземпляра.И он сохранится в кучу

//        int[][] jaggedArray = new int[2][];//Мы создаем двумерный массив и говорим что у него две столбца.
//        jaggedArray[0] = new int[] { 1, 2, 3 };//Здесь в столбце даем значение 
//        jaggedArray[1] = new int[] { 4, 5, 6 };//Здесь в столбце даем значение 
//    }
//}



//struct MyStruct// Создаем структуру он сохранится в стеке и в его поля создаем публичный интовй тип он сохранится в стеке
//{
//    public int Value;
//}

//class MyClass
//{
//    void Code4()//Мы здесь создаем метод и он сохранится в стеке
//    {
//        int refValue = 50;//Создаем перемена тип инт и даем значения.
//        MyStruct myStruct = new MyStruct { Value = 20 };//Создаем экземпляра структуры и в его поля даем значения
//        ModifyValues(ref refValue, ref myStruct);//Здесь мы вызываем метода ModifyValues и в его сигнатуру даем значение по ссылке стек.
//        int outValue;//Объявляем перемена стек.
//        InitializeValues(out outValue, out myStruct);//Здесь мы вызываем метода InitializeValues и в его сигнатуру даем значение  стек.
//    }

//    void ModifyValues(ref int intValue, ref MyStruct structValue)//Создаем метод в его сигнатуре есть два переменная.1)интовый 2)Переменная типа структура стек.
//    {
//        intValue += 10;//добавляет в значение 10
//        structValue.Value += 30;//В поле структура валуе добавляет 30
//    }

//    void InitializeValues(out int intValue, out MyStruct structValue)//Создаем метод в его сигнатуре есть два переменная.1)интовый 2)Переменная типа структура стек.
//    {
//        intValue = 100;//Мы изменяем значение в сто 
//        structValue = new MyStruct { Value = 200 };// Мы с перва создаем выделяем новый места в кучу для structValue и изменяем его значение в двести
//    }
//}




//class Node//Мы создаем класс.Сохранится в кучу.В его поля мы создаем публичный тип инт и... .
//{
//    public int Value;
//    public Node Next;
//}

//class MyClass
//{
//    void Code5()//Мы здесь создаем метод и он сохранится в стеке
//    {
//        Node firstNode = new Node { Value = 1 };
//        Node secondNode = new Node { Value = 2 };
//        Node thirdNode = new Node { Value = 3 };

//        firstNode.Next = secondNode;
//        secondNode.Next = thirdNode;

//        Node tempNode = firstNode;
//        tempNode.Value = 4;
//    }
//}