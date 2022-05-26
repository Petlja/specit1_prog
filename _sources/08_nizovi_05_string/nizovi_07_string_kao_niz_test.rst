Стринг и низ карактера - квиз
=============================

.. mchoice:: string_niz_q1
    :answer_a: испише се AA, а затим AB
    :answer_b: испише се AA, а затим програм пукне
    :answer_c: програм пукне пре него што ишта испише
    :answer_d: програм не може да се покрене
    :correct: d
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Тачно!
		
    Шта се дешава при покретању следећег програма?

    .. code-block:: csharp

        static void Main(string[] args)
        {
            string s = "AA";
            Console.WriteLine("{0}{1}", s[0], s[1]);
            s[1]++;
            Console.WriteLine("{0}{1}", s[0], s[1]);
        }


.. mchoice:: string_niz_q2
    :answer_a: Први метод не ради исправно.
    :answer_b: Први метод има узгредан ефекат.
    :answer_c: Нема разлике.
    :answer_d: Други метод не ради исправно.
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.
		
    Методи дати испод проверавају да ли два стринга садрже исти текст, не разликујући мала и велика слова.
    
    У чему је разлика између ова два метода?

    .. code-block:: csharp

        static bool IstiTekst1(string a, string b)
        {
            a = a.ToUpper();
            b = b.ToUpper();
            return a == b;
        }

        static bool IstiTekst2(string a, string b)
        {
            return a.ToUpper() == b.ToUpper();
        }


.. mchoice:: string_niz_q3
    :multiple_answers:
    :answer_a: Dopuni1
    :answer_b: Dopuni2
    :answer_c: Dopuni3
    :correct: a, b, c
		
    Који од датих метода враћа стринг допуњен тачкама са десне стране до ширине од 10 карактера ако је допуна потребна, а у супротном враћа неизмењен стринг (означити све тачне одговоре)? 

    .. code-block:: csharp

        static string Dopuni1(string s)
        {
            while (s.Length < 10) 
                s += '.';
            return s;
        }

        static string Dopuni2(string s)
        {
            if (s.Length < 10)
                s += new string('.', 10 - s.Length);
            return s;
        }

        static string Dopuni3(string s)
        {
            if (s.Length < 10)
                return s + new string('.', 10 - s.Length);
            return s;
        }


.. mchoice:: string_niz_q4
    :answer_a: XBC
    :answer_b: XXC
    :answer_c: ABC
    :answer_d: Програм не може да се покрене
    :correct: a
    :feedback_a: Тачно!
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Не.
		
    Шта исписује следећи програм?

    .. code-block:: csharp

        using System;

        namespace Program
        {
            class Program
            {
                static void a(string s) { s = "A"; }

                static void b(ref string s) { s = "B"; }
                                            
                static void c(out string s) { s = "C"; }

                static void Main(string[] args)
                {
                    string s = "X";
                    a(s);  Console.Write(s);
                    b(ref s);  Console.Write(s);
                    c(out s);  Console.Write(s);
                    Console.WriteLine();
                }
            }
        }

