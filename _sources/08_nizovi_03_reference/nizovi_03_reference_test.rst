Низ као референцирани тип - квиз
================================

.. mchoice:: nizref_q1
    :multiple_answers:
    :answer_a: користе различит простор у динамичкој меморији
    :answer_b: разликују се по дужини
    :answer_c: имају различит садржај
    :answer_d: разликују се или по дужини или по садржају (или оба)
    :correct: a

    Нека су *a* и *b* низови целих бројева и нека важи (*a != b*). Означити тврђења која су сигурно тачна за ова два низа.


.. mchoice:: nizref_q2
    :answer_a: 0
    :answer_b: 10
    :answer_c: 5
    :answer_d: Програм пукне током извршавања
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.

    Шта исписује овај програм?
    
    .. code-block:: csharp
    
        using System;

        class Program
        {
            static void Main(string[] args)
            {
                int[] a;
                int[] b = new int[5];
                int[] c = new int[10];
                a = b;
                b = c;
                Console.WriteLine(a.Length);
            }
        }



.. fillintheblank:: nizref_q3

    Шта исписује овај програм?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            static void Main(string[] args)
            {
                int[] a = { 1, 2, 3 };
                int[] b = (int[])(a.Clone());
                int[] c = a;
                b[0] = 5;
                Console.Write(a[0]);
                c[0] = 6;
                Console.WriteLine(a[0]); 
            }
        }
        
    - :^16$: Тачан одговор!
      :.*: Покушај поново.


.. mchoice:: nizref_q4
    :answer_a: 5
    :answer_b: 6
    :answer_c: 2
    :answer_d: 7
    :answer_e: 8
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.
    :feedback_d: Не.
    :feedback_e: Не.

    Шта исписује овај програм?
    
    .. code-block:: csharp
    
        using System;

        class Program
        {
            static void Izmeni(int[] x)
            {
                x[0]++;
                x = new int[10];
                x[0]+=2;
            }

            static void Main(string[] args)
            {
                int[] a = { 5, 5, 5 };
                Izmeni(a);
                Console.WriteLine(a[0]);
            }
        }


.. mchoice:: nizref_q5
    :answer_a: 5
    :answer_b: 6
    :answer_c: 2
    :answer_d: 7
    :answer_e: 8
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.
    :feedback_e: Не.

    Шта исписује овај програм?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            static void Izmeni(ref int[] x)
            {
                x[0]++;
                x = new int[10];
                x[0]+=2;
            }

            static void Main(string[] args)
            {
                int[] a = { 5, 5, 5 };
                Izmeni(ref a);
                Console.WriteLine(a[0]);
            }
        }
