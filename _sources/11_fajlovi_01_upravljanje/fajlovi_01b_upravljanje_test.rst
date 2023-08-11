Управљање фајловима - квиз
==========================

.. quizq::

    .. fillintheblank:: fajlovi_upravljanje_q1

        У ком именском простору се налазе методи за рад са фајловима?
        
        - :^System.IO$: Тачно!
          :.*: Не.

.. quizq::

    .. mchoice:: fajlovi_upravljanje_q2
        :answer_a: Набројиву колекцију имена фолдера задатог описа који постоје у задатом фолдеру.
        :answer_b: Број фајлова задатог описа, који постоје у задатом фолдеру.
        :answer_c: Набројиву колекцију имена фајлова задатог описа, који постоје у задатом фолдеру.
        :answer_d: Број фолдера задатог описа, који постоје у задатом фолдеру.
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!
        :feedback_d: Не.
            
        Шта враћа метод ``Directory.EnumerateFiles``?

.. quizq::

    .. mchoice:: fajlovi_upravljanje_q3
        :answer_a: Увек је бар једна једна нетачна, а могу бити и обе.
        :answer_b: Увек је једна тачна а једна нетачна.
        :answer_c: Зависно од унете путање, могу да буду тачне две, једна, или ниједна.
        :correct: a
        :feedback_a: Тачно!
        :feedback_b: Не.
        :feedback_c: Не.
            
        Какве могу да буду вредности ``b1`` и ``b2`` након извршавања следећег кода?

        .. code-block:: csharp
        
            Console.WriteLine("Unesite putanju: ");
            string putanja = Console.ReadLine();

            bool b1 = File.Exists(putanja);
            bool b2 = Directory.Exists(putanja);


.. quizq::

    .. mchoice:: fajlovi_upravljanje_q4
        :answer_a: Прелази се у задати фолдер, који тиме постаје текући (активан).
        :answer_b: Креира се задати фолдер ако већ не постоји.
        :answer_c: Копира се задати фолдер са свим подфолдерима на нову дестинацију.
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
            
        Шта се постиже позивом метода ``Directory.CreateDirectory``?
