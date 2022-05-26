Операције над листама - квиз
============================

.. mchoice:: metodi_q1
    :multiple_answers:
    :answer_a: a.InsertRange(4, b);
    :answer_b: a.Add(b);
    :answer_c: a.AddRange(b);
    :answer_d: a.Add({4, 5, 6});
    :correct: a, c
		
    Листа *a* садржи елементе 1, 2, 3, а листа *b* елементе 4, 5, 6. Како се на крај листе *a* могу додати елементи листе *b*?

    (означите све тачне одговоре)


.. mchoice:: metodi_q2
    :answer_a: a.Clear();
    :answer_b: a.RemoveAll();
    :answer_c: a.Remove(0, a.Count);
    :correct: a
    :feedback_a: Тачно!
    :feedback_b: Не.
    :feedback_c: Не.
		
    Извршавање метода a.RemoveAll(x => true); има исти ефекат као и 


.. mchoice:: metodi_q3
    :answer_a: 9
    :answer_b: 3
    :answer_c: -1
    :answer_d: 4
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.
    :feedback_d: Не.
		
     Шта се исписује следећим наредбама?
     
     .. code-block:: csharp

        List<int> a = new List<int>() { 4, 5, 6, 9, 8, 7 };
        Console.WriteLine(a.FindIndex(x => x > 6));
        

.. mchoice:: metodi_q4
    :answer_a: 7
    :answer_b: 3
    :answer_c: -1
    :answer_d: 5
    :correct: d
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Тачно!
		
     Шта се исписује следећим наредбама?
     
     .. code-block:: csharp

        List<int> a = new List<int>() { 4, 5, 6, 9, 8, 7 };
        Console.WriteLine(a.FindLastIndex(x => x > 6));
        

.. mchoice:: metodi_q5
    :answer_a: -5
    :answer_b: 0
    :answer_c: -1
    :answer_d: 3
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.
		
     Шта исписује следећи програм?
     
     .. code-block:: csharp

        static bool Negativan(int x) { return x < 0; }

        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 5, 5 };
            Console.WriteLine(a.FindLastIndex(Negativan));
        }
