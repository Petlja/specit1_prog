Пренос аргумената по референци - квиз
=====================================

.. mchoice:: metodi_reference_q1
    :answer_a: да се аргументи пренесу по вредности
    :answer_b: да се аргументи пренесу по референци
    :answer_c: није могуће да се измене сачувају у стварним аргументима
    :answer_d: измене се свакако чувају у стварним аргументима
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.
    :feedback_d: Не.

    Када у методу мењамо вредности аргумената, да би се измене сачувале у стварним аргументима, потребно је:


.. mchoice:: metodi_reference_q2
    :answer_a: 78
    :answer_b: 88
    :answer_c: 89
    :answer_d: 77
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.
    :feedback_d: Не.

    Шта исписује следећи програм?

    .. code-block:: csharp

        using System;

        class Program
        {
            static void f1(ref int a) { a++; }
            static void f2(int a) { a++; }

            static void Main()
            {
                int a = 7;
                f1(ref a);
                Console.Write(a);
                f2(a);
                Console.Write(a);
                Console.WriteLine();
            }
        }


.. mchoice:: metodi_reference_q3
    :answer_a: 5 8
    :answer_b: 6 8
    :answer_c: 5 9
    :answer_d: 6 9
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.

    Шта исписује следећи програм?

    .. code-block:: csharp

        using System;

        class Program
        {
            static void f(int a, ref int b)
            {
                a++;
                b++;
            }

            static void Main()
            {
                int x = 5, y = 8;
                f(x, ref y);
                Console.WriteLine(x + " " + y);
            }
        }


.. mchoice:: metodi_reference_q4
    :answer_a: la la la mi mi mi 
    :answer_b: la la la mi mi 
    :answer_c: la la la mi 
    :answer_d: la la la 
    :correct: d
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Тачно!

    Шта исписује следећи програм (водите рачуна о томе да метод IspisiVisePuta није написан како треба)?

    .. code-block:: csharp

        using System;

        class Program
        {
            static void IspisiVisePuta(ref int n, ref string s)
            {
                while (n > 0)
                {
                    Console.Write(s + " ");
                    n--;
                }
            }

            static void Main()
            {
                int n = 3;
                string s1 = "la", s2 = "mi";
                IspisiVisePuta(ref n, ref s1);
                IspisiVisePuta(ref n, ref s2);
                Console.WriteLine();
            }
        }


.. mchoice:: metodi_reference_q5
    :answer_a: Програм не може да се покрене, јер стварни аргумент није променљива
    :answer_b: Програм исписује 5
    :answer_c: Програм исписује 4, јер константа не може да се мења
    :answer_d: Програм пукне у току извршавања (runtime error)
    :correct: a
    :feedback_a: Тачно!
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Не.

    Шта се дешава при покретању следећег програма?

    .. code-block:: csharp

        using System;

        class Program
        {
            static void f(ref int a) { a++; }

            static void Main()
            {
                Console.WriteLine(f(ref 4));
            }
        }

