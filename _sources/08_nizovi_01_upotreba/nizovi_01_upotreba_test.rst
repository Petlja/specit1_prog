Употреба низова - квиз
======================

.. quizq::

    .. mchoice:: niz1_q1
        :multiple_answers:
        :answer_a: int[10] a;
        :answer_b: int[] slova;
        :answer_c: bool[] jednaki;
        :answer_d: int a[10];
        :correct: b, c
                
        Које од датих декларација су исправне декларације низа?


.. quizq::

    .. fillintheblank:: niz1_q2

        Наведите индекс елемента низа *fib*, који је једнак 8.
        
        .. code-block:: csharp

            int[] fib = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            
        - :^5$: Тачан одговор!
          :.*: Покушај поново.

.. quizq::

    .. fillintheblank:: niz1_q3

        Који је највећи исправан индекс за низ *fib*?
        
        .. code-block:: csharp

            int[] fib = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            
        - :^9$: Тачан одговор!
          :.*: Покушај поново.


.. quizq::

    .. mchoice:: niz1_q4
        :answer_a: 4 бајта за једну целобројну променљиву
        :answer_b: Зависи од дужине низа
        :answer_c: Ништа, јер низ није иницијализован
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!

        Колико простора се заузима у динамичкој меморији следећом наредбом?
        
        .. code-block:: csharp
        
            int[] a;

.. quizq::

    .. mchoice:: niz1_q5
        :answer_a: 10 бајтова
        :answer_b: 40 бајтова
        :answer_c: 4 бајта
        :answer_d: Ништа
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
        :feedback_d: Не.

        Колико простора се заузима у динамичкој меморији следећом наредбом?
        
        .. code-block:: csharp
        
            int[] a = new int[10];

.. quizq::

    .. mchoice:: niz1_q6
        :answer_a: Ако и само ако је први елемент низа позитиван
        :answer_b: Ако и само ако је бар један елемент низа позитиван
        :answer_c: Ако и само ако је последњи елемент низа позитиван
        :answer_d: Ако и само ако су сви елементи низа позитивни
        :correct: d
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Не.
        :feedback_d: Тачно!

        У ком случају ће променљива *rez* по извршењу следећих наредби имати вредност *true*?
        
        .. code-block:: csharp
        
            bool rez = true;
            foreach (int x in a)
                if (x <= 0) rez = false;


.. comment
 
    Чему је једнак а[3]?