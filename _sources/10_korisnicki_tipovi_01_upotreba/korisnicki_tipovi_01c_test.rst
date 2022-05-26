Набројиви типови и структуре - квиз
===================================

.. mchoice:: korisnicki_tipovi_q1
    :multiple_answers:
    :answer_a: Употреба програма је олакшана корисницима.
    :answer_b: Значење појединих аргумената у методима постаје јасније.
    :answer_c: Програми постају краћи.
    :answer_d: Теже је правити семантичке грешке (багове) у коду.
    :correct: b, d
		
    Које су све последице употребе набројивих типова (означи све тачне реченице)?



.. mchoice:: korisnicki_tipovi_q2
    :answer_a: бројеви израчунати на основу имена ових константи
    :answer_b: стрингови
    :answer_c: специјални кодови, који се увoде за сваки набројиви тип посебно
    :answer_d: целобројне вредности
    :correct: d
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Тачно!
		
    Константе набројивог типа се интерно региструју као ... ?



.. mchoice:: korisnicki_tipovi_q3
    :multiple_answers:
    :answer_a: Поља структуре морају да буду међусобно истог типа.
    :answer_b: Поља структуре морају да буду простог типа (string, int, double и сл.).
    :answer_c: Свако поље у структури заузима простор у меморији.
    :answer_d: У наредбама ван структуре могу да се користе само јавна (public) поља структуре.
    :answer_e: Структуре су референцирани тип података.
    :correct: c, d
		
    Означи све тачне реченице о пољима структуре.



.. mchoice:: korisnicki_tipovi_q4
    :multiple_answers:
    :answer_a: Својство може да буде доступно само за читање, само за писање, или за читање и писање.
    :answer_b: На месту употребе, својство изгледа потпуно исто као поље.
    :answer_c: Ако својство има оба приступника (set и get), оно је исто што и поље.
    :answer_d: Свака структура мора да има бар једно својство.
    :correct: a, b
		
    Означи све тачне реченице о својствима структуре.



.. fillintheblank:: korisnicki_tipovi_q5

    Шта се исписује извршавањем овог кода?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            struct Tacka { public double x; public double y; }

            public static void Main()
            {
                Tacka A = new Tacka { x = 1, y = 2 };
                Tacka B = A;
                A.x += 3; 
                Console.WriteLine(B.x);
            }
        }
    
    - :^1$: Тачно!
      :.*: Не.



.. fillintheblank:: korisnicki_tipovi_q6

    Шта се исписује извршавањем овог кода?
    
    .. code-block:: csharp

        using System;

        class Program
        {
            struct Tacka { public double x; public double y; }

            static void Pomeri(Tacka t, double dx, double dy)
            {
                t.x += dx;
                t.y += dy;
            }
            public static void Main()
            {
                Tacka A = new Tacka { x = 1, y = 2 };
                Pomeri(A, 3, 3);
                Console.WriteLine(A.x);
            }
        }
    
    - :^1$: Тачно!
      :.*: Не.



.. mchoice:: korisnicki_tipovi_q7
    :answer_a: Програм не може да се покрене (због синтаксне грешке).
    :answer_b: Програм пукне.
    :answer_c: Програм може да да неисправан резултат.
    :answer_d: Окружење аутоматски преправи поље у јавно.
    :correct: a
    :feedback_a: Тачно!
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Не.
		
    Шта се догоди ако у програму покушамо да приступимо приватном пољу структуре?