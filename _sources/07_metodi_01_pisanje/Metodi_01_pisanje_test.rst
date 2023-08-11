Писање статичких метода - квиз
==============================

.. quizq::

    .. mchoice:: metodi_pisanje_q1
        :answer_a: static bool PoRedu(int x, int y, int z)
        :answer_b: static void IspisiFormatirano(int n)
        :answer_c: static long Faktorijel(int n)
        :answer_d: static double Stepen(double x, int n)
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!
        :feedback_d: Не.

        Које од наведених је заглавље метода који враћа цео број?


.. quizq::

    .. mchoice:: metodi_pisanje_q2
        :multiple_answers:  
        :answer_a: static IspisiFormatirano(int x)
        :answer_b: static void NapraviTabelu()
        :answer_c: static bool IstogZnaka(int x, y)
        :answer_d: static int SrednjiPoVelicini(int x, int y, int z)
        :correct: a, c

        Која заглавља метода су НЕИСПРАВНО написана?

.. quizq::

    .. fillintheblank:: metodi_pisanje_q3

        Метод ``Najmanji`` не враћа увек очекивани резултат. Шта је резултат његовог извршавања при позиву ``Najmanji(2, 2, 3)``?
        
        .. code-block:: csharp

            using System;

            int Najmanji(int a, int b, int c)
            {
                if (a < b && a < c) 
                    return a;
                else if (b < a && b < c) 
                    return b;
                else 
                    return c;
            }
            
        - :^3$: Тачан одговор!
          :.*: Покушај поново.

.. quizq::

    .. fillintheblank:: metodi_pisanje_q4

        Шта исписује следећи програм ако се унесе 5 и 3?
        
        .. code-block:: csharp

            using System;

            class Program
            {
                static int Proizvod(int a, int b) { return a * b; }
                static int Zbir(int a, int b) { return a + b; }
                static int Razlika(int a, int b) { return a - b; }
                static void Main()
                {
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine(Proizvod(Zbir(x, y), Razlika(x, y)));
                }
            }

        - :^16$: Тачан одговор!
          :.*: Покушај поново.


.. quizq::

    .. fillintheblank:: metodi_pisanje_q5

        Шта исписује следећи програм ако се унесе 3?
        
        .. code-block:: csharp

            using System;

            class Program
            {
                static int f(int a) { return a * a; }
                static void Main()
                {
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine(f(f(x)));
                }
            }

        - :^81$: Тачан одговор!
          :.*: Покушај поново.
