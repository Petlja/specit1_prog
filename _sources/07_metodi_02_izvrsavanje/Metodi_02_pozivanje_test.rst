Извршавање метода - квиз
========================

.. mchoice:: metodi_izvrsavanje_q1
    :answer_a: ... могу бити константе
    :answer_b: ... морају бити имена
    :answer_c: ... могу бити изрази
    :answer_d: ... могу бити позиви других функција
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.
    :feedback_d: Не.

    Довршите реченицу тако да буде тачна: формални аргументи ...



.. mchoice:: metodi_izvrsavanje_q2
    :answer_a: Програм исписује 4
    :answer_b: Програм исписује 5
    :answer_c: Програм не може да се покрене (окружење пријављује грешку) јер променљива b не постоји у методу f
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!

    Шта се дешава када покренемо овај програм?

    .. code-block:: csharp

        using System;

        class Program
        {
            static int f(int a) { return b+1; }
            static void Main()
            {
                int b = 3;
                Console.WriteLine(f(b) + 1);
            }
        }


.. fillintheblank:: metodi_izvrsavanje_q3

    Колико пута се извршава метод f3 у следећем програму?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            static void f1(int a) { f2(a); f2(a);  }
            static void f2(int a) { f3(a); f3(a); f3(a); }
            static void f3(int a) { Console.Write(a); }

            static void Main()
            {
                f1(9);
                Console.WriteLine();
            }
        }

    - :^6$: Тачан одговор!
      :.*: Покушај поново.


.. fillintheblank:: metodi_izvrsavanje_q4

    Шта исписује следећи програм?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            static int f(int a) { return a + 1;  }

            static void Main()
            {
                Console.WriteLine(f(3) + 1);
            }
        }

    - :^5$: Тачан одговор!
      :.*: Покушај поново.


.. fillintheblank:: metodi_izvrsavanje_q5

    Шта исписује овај програм?

    .. code-block:: csharp

        using System;

        class Program
        {
            static int f(int a, int b) { return a - b;  }

            static void Main()
            {
                int a = 3;
                int b = 1;
                Console.WriteLine(f(b, a));
            }
        }

    - :^-2$: Тачан одговор!
      :.*: Покушај поново.

