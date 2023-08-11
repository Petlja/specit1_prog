Угнежђене петље - сегменти - квиз
=================================

.. quizq::

    .. mchoice:: ugnp3_q1
        :answer_a: efgh fgh efg gh fg ef h g f e
        :answer_b: efgh efg fgh ef fg gh e f g h
        :answer_c: e f g h ef fg gh efg fgh efgh
        :answer_d: h g f e gh fg ef fgh efg efgh
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!
        :feedback_d: Не.

        Овај програмски сегмент исписује све подстрингове стринга s.
        
        .. code::
        
            string s = Console.ReadLine();
            int n = s.Length;
            for (int i = 1; i <= n; i++)
            {
                for (int k = 0; k + i <= n; k++)
                    Console.Write(s.Substring(k, i) + " ");
            }
            Console.WriteLine();
            
        Који је редослед исписивања подстрингова, ако се унесе efgh?
    
.. quizq::

    .. fillintheblank:: ugnp3_q2

        Шта исписује овај програм за n=3 и вредности за x редом 3, 2, 4
        
        .. code::

            using System;

            class Program
            {
                static void Main(string[] args)
                {
                    int n = int.Parse(Console.ReadLine());
                    int a = 0;
                    int b = 0;
                    for (int i = 0; i < n; i++)
                    {
                        int x = int.Parse(Console.ReadLine());
                        a += x;
                        b += a;
                    }
                    Console.WriteLine(b);
                }
            }

        - :^17$: Тачан одговор!
          :.*: Покушај поново.


.. quizq::

    .. mchoice:: ugnp3_q3
        :answer_a: код (a)
        :answer_b: код (b)
        :answer_c: код (c)
        :correct: a
        :feedback_a: Тачно!
        :feedback_b: Не.
        :feedback_c: Не.

        Који од наредних програмских сегмената НЕ ИСПИСУЈЕ суме суфикса серије {1, 2, ... n}?
        
        A)

        .. code::

            int s = 0;
            for (int i = 1; i <= n; i++)
                s += i;

            for (int i = n; i > 0; i--)
            {
                Console.WriteLine(s);
                s -= i;
            }

        B)
        
        .. code::

            int s = 0;
            for (int i = n; i > 0; i--)
            {
                s += i;
                Console.WriteLine(s);
            }
            
        C)
        
        .. code::

            int s = 0;
            for (int i = 1; i <= n; i++)
                s += i;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(s);
                s -= i;
            }
            
.. quizq::
        
    .. mchoice:: ugnp3_q4
        :answer_a: Бројеве од 1 до n
        :answer_b: Првих n пирамидалних бројева
        :answer_c: Првих n троугаоних бројева
        :answer_d: ништа од наведеног
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
        :feedback_d: Не.

        Овај програмски сегмент исписује ...
        
        .. code::

                int s = 0;
                for (int n = 1; n <= 3; n++)
                {
                    for (int k = 1; k <= n; k++)
                    {
                        s += k;
                    }
                    Console.WriteLine(s);
                }

.. quizq::

    .. mchoice:: ugnp3_q5
        :answer_a: Факторијеле свих бројева од 1 до n
        :answer_b: n!
        :answer_c: суме префикса серије првих n факторијела 
        :answer_d: суму свих факторијела од 1! до n!
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!
        :feedback_d: Не.

        Шта исписује овај програм за унето n?
        
        .. code::

            using System;

            class Program
            {
                static void Main(string[] args)
                {
                    int n = int.Parse(Console.ReadLine());
                    int s = 0;
                    int f = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        f *= i;
                        s += f;
                        Console.Write(s + " ");
                    }
                    Console.WriteLine();
                }
            }


