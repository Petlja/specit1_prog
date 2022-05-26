Угнежђене петље - ASCII графика - квиз
======================================

.. mchoice:: ugnp2_q1
    :answer_a: слика (A)
    :answer_b: слика (B)
    :answer_c: слика (C)
    :answer_d: слика (D)
    :correct: a
    :feedback_a: Тачно!
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Не.

    Шта исписује овај програм
    
    .. code-block:: csharp
    
        using System;

        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                        if (j == 1 || i == n)
                            Console.Write('*');
                        else
                            Console.Write('.');
                    Console.WriteLine();
                }
            }
        }

    ако се при његовом извршавању унесе *n* = 3?
    
    .. code::
        
        (A)             (B)             (C)             (D)
                               
        *..             ***             *..*..***       ***..*..*
        *..             ..*
        ***             ..*


.. mchoice:: ugnp2_q2
    :answer_a: слика (A)
    :answer_b: слика (B)
    :answer_c: слика (C)
    :answer_d: слика (D)
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.

    Шта исписује овај програм
    
    .. code-block:: csharp
    
        using System;

        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                        if (i < j)
                            Console.Write('*');
                        else
                            Console.Write('.');
                    Console.WriteLine();
                }
            }
        }

    ако се при његовом извршавању унесе *n* = 4?
    
    .. code::
        
        (A)         (B)         (C)         (D)
                              
        ....        *...        .***        ****
        *...        **..        ..**        .***
        **..        ***.        ...*        ..**
        ***.        ****        ....        ...*


.. mchoice:: ugnp2_q3
    :answer_a: if (i < n / 2) m++; else m--;
    :answer_b: if (i < n) m++; else m--;
    :answer_c: if (i < n) m++; else if (i > n) m--;
    :answer_d: if (i < n / 2) m++; else if (i > n / 2) m--;
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.
    :feedback_d: Не.

    Како треба допунити овај програм на месту знакова питања
    
    .. code-block:: csharp
    
        using System;

        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                int m = 1;
                for (int i = 1; i <= 2 * n - 1; i++)
                {
                    for (int j = 1; j <= m; j++)
                            Console.Write('*');
                    Console.WriteLine();

                    // ???
                }
            }
        }

    да би се његовим извршавањем за унето *n* = 3 добила ова слика?
    
    .. code::
        
        *               
        **              
        ***             
        **              
        *                   



.. mchoice:: ugnp2_q4
    :answer_a: на месту (A)
    :answer_b: на месту (B)
    :answer_c: на месту (C)
    :answer_d: на месту (D)
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.

    На које место у овом програму
    
    .. code-block:: csharp
    
        using System;

        class Program
        {
            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                for (int red = 1; red <= n; red++)
                {
                    Console.Write('|');
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            Console.Write('*');
                            // (A)
                        }
                        Console.Write('|');
                        // (B)
                    }
                    // (C)
                }
                // (D)
            }
        }

    треба додати наредбу *Console.WriteLine();* да би се извршавањем програма за унето *n* = 4 добила ова слика?
    
    .. code::
        
        |****|****|****|****|
        |****|****|****|****|
        |****|****|****|****|
        |****|****|****|****|