Угнежђено гранање - квиз
========================

.. mchoice:: slozena_grananja_q1
    :answer_a: да, само је непрегледно написан
    :answer_b: не, програм не даје очекивани резултат (семантички је неисправан)
    :answer_c: не, програм не може да се покрене (синтаксно је неисправан)
    :correct: a
    :feedback_a: Тачно!
    :feedback_b: Не.
    :feedback_c: Не.

    Следећи програмски код теба да испише ``Ispravno`` ако је вредност променљиве ``poeni`` између 0 и 100 (укључујући границе), ``Preveliko`` ако је вредност ``poeni`` већа од 100, а ``Premalo`` ако је вредност ``poeni`` мања од 0.
    
    Да ли је овај код синтаксно и семантички исправан (да ли ради то што се од њега очекује)?
    
    .. code-block:: csharp
    
        if (poeni >= 0)
        if (poeni <= 100) Console.WriteLine("Ispravno");
        else Console.WriteLine("Preveliko");
        else Console.WriteLine("Premalo");



.. mchoice:: slozena_grananja_q2
    :answer_a: програм не може да се покрене
    :answer_b: програм се за неке вредности променљиве poeni другачије понаша
    :answer_c: програм се понаша потпуно исто као и са витичастим заградама
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.

    Шта се дешава ако уклонимо витичасте заграде ``{ }`` у следећем коду (подразумевајући да је остатак програма исправан)?
    
    .. code-block:: csharp
    
        if (poeni >= 0)
        {
            if (poeni <= 100) Console.WriteLine("Ispravno");
        }
        else Console.WriteLine("Neispravno");



.. mchoice:: slozena_grananja_q3
    :answer_a: Исписује A
    :answer_b: Исписује B
    :answer_c: Исписује C
    :answer_d: Исписује D
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.

    Шта при извршавању исписује следећи програмски код ако је вредност ``x`` једнака 7?
    
    .. code-block:: csharp
    
        if (x > 10)
            if (x > 15) Console.WriteLine("A");
            else Console.WriteLine("B");
        else 
            if (x > 5)  Console.WriteLine("C");
            else Console.WriteLine("D");



.. mchoice:: slozena_grananja_q4
    :answer_a: Исписује A
    :answer_b: Исписује B
    :answer_c: Не исписује ништа
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!

    Шта при извршавању исписује следећи програмски код ако је вредност ``x`` једнака 23?
    
    .. code-block:: csharp
    
        if (x > 100)
        if (x < 150) Console.WriteLine("A");
        else Console.WriteLine("B");



.. mchoice:: slozena_grananja_q5
    :multiple_answers:
    :answer_a: Фрагмент A
    :answer_b: Фрагмент B
    :answer_c: Фрагмент C
    :correct: a, c

    Дата је следећа сложена наредба гранања:
    
    .. code-block:: csharp

        if (x > 0)
            if (y > 0) Console.WriteLine("Prvi kvadant");
            else Console.WriteLine("Cetvrti kvadant");
        else
            if (y > 0) Console.WriteLine("Drugi kvadant");
            else Console.WriteLine("Treci kvadant");
                
    Ако претпоставимо да су ``x`` и ``y`` различити од нуле, који од наредна три програмска фрагмента су (функционално) равноправни са датим:
    
    .. code-block:: csharp
    
        // A
        if (x > 0 && y > 0) Console.WriteLine("Prvi kvadant");
        else if (x > 0) Console.WriteLine("Cetvrti kvadant");
        else if (y > 0) Console.WriteLine("Drugi kvadant");
        else Console.WriteLine("Treci kvadant");
        
        // B
        if (x > 0 && y > 0) Console.WriteLine("Prvi kvadant");
        if (x > 0) Console.WriteLine("Cetvrti kvadant");
        if (y > 0) Console.WriteLine("Drugi kvadant");
        else Console.WriteLine("Treci kvadant");
        
        // C
        if (x > 0 && y > 0) Console.WriteLine("Prvi kvadant");
        if (x > 0 && y < 0) Console.WriteLine("Cetvrti kvadant");
        if (x < 0 && y > 0) Console.WriteLine("Drugi kvadant");
        if (x < 0 && y < 0) Console.WriteLine("Treci kvadant");



