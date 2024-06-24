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
//    static void Main(string[] args)
//    {
//        int intValue = 42;// Это переменна сохранится в сетке
//        object boxedInt = intValue;// Мы в этом строке делаем операции Boxing.И это перемена сохранится в кучу.
//        MyStruct myStruct = new MyStruct { A = 10, B = 20 };//Мы создаем экземпляр структуру MyStruct и даем значения в перемени А и В.он сохранится в стеке 
//        object boxedStruct = myStruct;// Мы в этом строке делаем операции Boxing.Экземпляра структуру myStruct делаем Boxing.Перемена boxedStruct сохранится в стеке.

//        int unboxedInt = (int)boxedInt; //Мы в этом строке делаем операции UnBoxing и он сохранится в стеке.
//        MyStruct unboxedStruct = (MyStruct)boxedStruct;//Мы в этом строке делаем операции UnBoxing и он сохранится в стеке.
//    }

//}




//class MyClass
//{
//    public int X;//Сохранится в heap 
//    public int Y;//Сохранится в heap 
//    public MyClass NestedClass; //Сохранится в кучу.
//}

//struct MyStruct//Этом структура сохранится в стеке и ее поля тоже.В его поля мы создаем два публичный тип инт и они тоже сохранится в стеке 
//{
//    public int X;
//    public int Y;
//}

//class Program
//{
//    static void Main(string[] args)// Мы здесь создаем метод и он сохранится в стеке
//    {
//        MyClass class1 = new MyClass();//Здесь мы создаем экземпляра класса и он сохранится в кучу
//        class1.X = 1;//В экземпляра класса мы даем значение он сохранится в кучу 
//        class1.Y = 2;//В экземпляра класса мы даем значение он сохранится в кучу 
//        class1.NestedClass = new MyClass { X = 3, Y = 4 };

//        MyStruct struct1 = new MyStruct { X = 5, Y = 6 };//Здесь мы создаем экземпляр структуру MyStruct и даем значения в перемени Х и Y он сохранится в стек 

//        MyStruct struct2 = struct1;//Мы копируем значения экземпляра структуры struct1 в экземпляра структуры struct2 и он сохранится в стеке
//        struct2.X = 9;//Мы даем значения в экземпляра структуры struct2 в перемена Х и он сохранится в стеке
//    }
//}





//struct MyStruct//Этот структура сохранится в стеке и ее поля тоже.В его поля мы создаем два публичный тип инт и они тоже сохранится в стеке 
//{
//    public int A;
//    public int B;
//}


//class MyClass
//{
//    static void Main(string[] args)//Мы здесь создаем метод и он сохранится в стеке
//    {
//        MyStruct[] structArray = new MyStruct[2];//Мы создаем экземпляра структуры и говорим что у нас будет две экземпляра.Он сохранится в heap.
//        structArray[0] = new MyStruct { A = 1, B = 2 };//Мы даем значение и говорим что он новый.И он сохранится в heap
//        structArray[1] = new MyStruct { A = 3, B = 4 };//Мы даем значение и говорим что он новый.И он сохранится в heap
//        ReplaceArray(structArray);
//        ReplaceArray2(structArray[0]);
//        int[][] jaggedArray = new int[2][];//Мы создаем двумерный массив и говорим что у него две столбца.heap
//        jaggedArray[0] = new int[] { 1, 2, 3 };//Здесь в столбце даем значение heap
//        jaggedArray[1] = new int[] { 4, 5, 6 };//Здесь в столбце даем значение heap
//    }
//    static void ReplaceArray(MyStruct[] myStruct)
//    {
//        myStruct[0] = new MyStruct { A = 5, B = 6 };
//    }
//    static void ReplaceArray2(MyStruct myStruct)
//    {
//        myStruct.A = 5;
//        myStruct.B = 6;
//    }
//}



//struct MyStruct// Создаем структуру он сохранится в стеке и в его поля создаем публичный интовй тип он сохранится в стеке
//{
//    public int Value;
//}

//class MyClass
//{
//    static void Main(string[] args)//Мы здесь создаем метод и он сохранится в стеке
//    {
//        int refValue = 50;//Создаем перемена тип инт и даем значения.stack
//        MyStruct myStruct = new MyStruct { Value = 20 };//Создаем экземпляра структуры и в его поля даем значения stack
//        ModifyValues(ref refValue, ref myStruct);//Здесь мы вызываем метода ModifyValues и в его сигнатуру даем значение по ссылке. стек.
//        int outValue;//Объявляем перемена стек.
//        InitializeValues(out outValue, out myStruct);//Здесь мы вызываем метода InitializeValues и в его сигнатуру даем значение  стек.
//    }

//    static void ModifyValues(ref int intValue, ref MyStruct structValue)//Создаем метод в его сигнатуре есть два переменная.1)интовый 2)Переменная типа структура стек.
//    {
//        intValue += 10;//добавляет в значение 10
//        structValue.Value += 30;//В поле структура валуе добавляет 30
//    }

//    static void InitializeValues(out int intValue, out MyStruct structValue)//Создаем метод в его сигнатуре есть два переменная.1)интовый 2)Переменная типа структура стек.
//    {
//        intValue = 100;//Мы изменяем значение в сто 
//        structValue.Value = 200;// Мы даем новый значение в MyStruct.Стек
//    }
//}




class Node//Мы создаем класс.Сохранится в кучу.В его поля мы создаем публичный тип инт и... .
{
    public int Value;
    public Node Next;
}

class MyClass
{
    static void Main(string[] args)//Мы здесь создаем метод и он сохранится в стеке
    {
        Node firstNode = new Node { Value = 1 };//Мы создаем экземпляр класса Нод и даем значение.куча
        Node secondNode = new Node { Value = 2 };//Мы создаем экземпляр класса Нод и даем значение.куча
        Node thirdNode = new Node { Value = 3 };//Мы создаем экземпляр класса Нод и даем значение.куча

        firstNode.Next = secondNode;
        secondNode.Next = thirdNode;

        Node tempNode = firstNode;
        tempNode.Value = 4;
    }
}