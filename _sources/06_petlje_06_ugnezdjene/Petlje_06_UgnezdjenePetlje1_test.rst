Угнежђене петље - квиз
======================

.. mchoice:: ugnp1_q1
    :answer_a: више петљи написаних једна за другом
    :answer_b: једна или више петљи у телу друге петље
    :answer_c: петље које су накнадно написане
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.

    Уметнуте петље су 


.. mchoice:: ugnp1_q2
    :answer_a: је највише четири
    :answer_b: је два
    :answer_c: није ограничен правилима језика
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!

    Број петљи које се могу уметнути једна у другу 


.. fillintheblank:: ugnp1_q3

    Колико бројева исписује следећи програм?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            static void Main(string[] args)
            {
                for (int st = 2; st <= 4; st++)
                {
                    for (int des = 3; des <= 6; des++)
                    {
                        for (int jed = 4; jed <= 8; jed++)
                        {
                            Console.WriteLine(100 * st + 10 * des + jed);
                        }
                    }            
                }
            }
        }
        
    - :^60$: Тачан одговор!
      :.*: Покушај поново.


.. fillintheblank:: ugnp1_q4

    Шта исписује следећи програм?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            static void Main(string[] args)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.Write(i);
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write(j);
                    }            
                }
                Console.WriteLine();
            }
        }

    - :^112321233123$: Тачан одговор!
      :.*: Покушај поново.


.. mchoice:: ugnp1_q5
    :answer_a: на месту (1)
    :answer_b: на месту (2)
    :answer_c: на месту (3)
    :answer_d: на месту (4)
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.

    На којем од означених места у програму 
    
    .. code-block:: csharp
    
        using System;

        class Program
        {
            static void Main(string[] args)
            {
                for (int i = 1; i <= 3; i++)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        for (int k = 1; k <= 3; k++)
                        {
                            Console.Write(k);
                            // (1)
                        }
                        // (2)
                    }
                    // (3)
                }
                // (4)
            }
        }

    треба да стоји наредба *Console.WriteLine();* да би програм исписао резултат овако:
    
    .. code::
        
        123123123
        123123123
        123123123


