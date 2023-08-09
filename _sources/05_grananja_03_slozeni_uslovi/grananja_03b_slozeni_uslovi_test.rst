Сложени услови - квиз
=====================

.. quizq::

    .. mchoice:: slozeni_uslovi_q1
        :answer_a: a < b && b < c
        :answer_b: (a < b && b < c) || (a > b && b > c)
        :answer_c: a < b < c || a > b > c
        :answer_d: (a <= b && b <= c) || (a >= b && b >= c)
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
        :feedback_d: Не.

        Који од услова је тачан ако и само ако су ``a``, ``b`` и ``c`` три различита броја и број ``b`` је средњи по величини међу њима?
        
.. quizq::

    .. mchoice:: slozeni_uslovi_q2
        :multiple_answers:
        :answer_a: x < 7 || 11 <= x
        :answer_b: x < 7 && 11 <= x
        :answer_c: !(7 <= x) || !(x < 11)
        :answer_d: x <= 7 || 11 < x
        :correct: a, c

        Који све услови су равноправни са ``!(7 <= x && x < 11)`` ?

.. quizq::

    .. mchoice:: slozeni_uslovi_q3
        :multiple_answers:
        :answer_a: (k == 2 || r < 6) && (k > 1 || r == 5)
        :answer_b: (k == 2 && r < 6) || (k > 1 && r == 5)
        :answer_c: (k == 2 || r == 5) && k > 1 && r < 6
        :answer_d: (k == 2 && r < 6) || (k > 2 && r == 5)
        :correct: b, c, d

        Који од услова су потребни и довољни да поље у реду *r* и колони *k* на следећој слици буде једно од обојених (означити све тачне одговоре)?
        
        .. image:: ../../_images/sekvencijalni/xy_R5K2-6_K2R1-5.png
            :width: 200px
            :align: center

.. quizq::

    .. mchoice:: slozeni_uslovi_q4
        :multiple_answers:
        :answer_a: x > 0 || y > 0 || z > 0
        :answer_b: x <= 0 && y <= 0 && z <= 0
        :answer_c: x <= 0 || y <= 0 || z <= 0
        :answer_d: !(x > 0 || y > 0 || z > 0)
        :correct: b, d

        Како се све може записати услов да ниједан од бројева *x*, *y*, *z* није позитиван?

.. quizq::

    .. mchoice:: slozeni_uslovi_q5
        :multiple_answers:
        :answer_a: (stanovnika <= 10000) || (stanovnika > 10000 && prihod <= 2000)
        :answer_b: stanovnika <= 10000 || prihod <= 2000
        :answer_c: stanovnika <= 10000 && prihod <= 2000
        :answer_d: (prihod <= 2000) || (prihod > 2000 && stanovnika <= 10000)
        :correct: a, b, d

        Државна влада нуди помоћ за изградњу спортског центра. Насељена места до 10000 становника могу сва да конкуришу, а од места са више од 10000 становника, могу да конкуришу она у којима је просечан приход до 2000. Који од услова исправно проверавају да ли неко место може да конкурише?

