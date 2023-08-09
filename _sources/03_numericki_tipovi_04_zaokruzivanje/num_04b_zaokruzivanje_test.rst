Конверзије и заокруживање - квиз
================================

.. comment 

    zanimljivije pitanje je sa 1/3 umesto 1/2

.. quizq::

    .. mchoice:: zaokruzivanje_q1
        :answer_a: 1/2
        :answer_b: 0
        :answer_c: Наредба није синтаксно исправна
        :answer_d: Програм би пукао при извршавању ове наредбе (наредба није семантички исправна)
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
        :feedback_d: Не.
        
        колико је *x* после наредбе
        
        .. code-block:: csharp
        
            double x = (double)(1/2);

.. quizq::


    .. mchoice:: zaokruzivanje_q2
        :answer_a: 1/2
        :answer_b: 0
        :answer_c: Наредба није синтаксно исправна
        :answer_d: Програм би пукао при извршавању ове наредбе (наредба није семантички исправна)
        :correct: a
        :feedback_a: Тачно!
        :feedback_b: Не.
        :feedback_c: Не.
        :feedback_d: Не.
        
        колико је *x* после наредбе 

        .. code-block:: csharp

            double x = (double)1/2;
            
.. quizq::


    .. mchoice:: zaokruzivanje_q3
        :answer_a: негативна и целобројна
        :answer_b: негативна и није целобројна
        :answer_c: негативна (било са децималама или без)
        :answer_d: позитивна и целобројна
        :answer_e: позитивна и није целобројна
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
        :feedback_d: Не.
        :feedback_e: Не.
        
        Ако су вредности функција *Math.Truncate(x)* и  *Math.Floor(x)* различите, то значи да је вредност *x* ...

.. quizq::


    .. mchoice:: zaokruzivanje_q4
        :answer_a: ... негативна
        :answer_b: ... целобројна
        :answer_c: ... позитивна
        :answer_d: ... нецелобројна (има разломљени део)
        :correct: d
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Не.
        :feedback_d: Тачно!
        
        Ако су вредности функција *Math.Floor(x)* и  *Math.Ceiling(x)* различите, то значи да је вредност *x* ...


.. quizq::


    .. mchoice:: zaokruzivanje_q5
        :answer_a: вредност x целобројна и парна
        :answer_b: вредност x целобројна и непарна
        :answer_c: вредност x+0.5 целобројна и парна
        :answer_d: вредност x+0.5 целобројна и непарна
        :answer_e: ништа од наведеног
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!
        :feedback_d: Не.
        
        Ако су вредности функција *Math.Round(x)* и  *Math.Round(x+1)* једнаке, то значи да је ...
