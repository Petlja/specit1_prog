Трансформисање стрингова - квиз
===============================


.. mchoice:: string_efi_q1
    :answer_a: стринг
    :answer_b: низ карактера
    :answer_c: градитељ стринга (string builder)
    :answer_d: стринг, низ и градитељ стринга су једнако добри избори
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.
		
    Током рада програма прикупљате текстуалне описе обављених поступака, које ћете на крају уписати у лог фајл, за који се очекује да ће имати неколико мегабајта текста. Шта је од понуђеног најбоље користити за прикупљање поменутих описа?


.. mchoice:: string_efi_q2
    :multiple_answers:
    :answer_a: Може да врати нетачан резултат.
    :answer_b: Може да изазове пуцање програма.
    :answer_c: Може да се извршава бесконачно (да упадне у мртву петљу).
    :answer_d: Неефикасан је.
    :correct: b, d
		
    Дати метод треба да врати стринг без водећих размака. Означити све тачне реченице о овом методу.

    .. code-block:: csharp

        static string IzbaciRazmakeNaPocetku(string s)
        {
            while (s[0] == ' ')
                s = s.Remove(0, 1);
            return s;
        }


.. mchoice:: string_efi_q3
    :answer_a: Оба начина су врло брза
    :answer_b: Оба начина су врло спора
    :answer_c: Први начин је врло брз а други врло спор
    :answer_d: Први начин је врло спор а други врло брз
    :correct: b
    :feedback_a: Не.
    :feedback_b: Тачно!
    :feedback_c: Не.
    :feedback_d: Не.
		
    Шта можемо рећи о два дата метода који формирају стринг састављен од *n* понављања датог стринга *s*?

    .. code-block:: csharp

        static string Ponovi1(string s, int n)
        {
            string rez = "";
            for (int i = 0; i < n; i++)
                rez = rez.Insert(0, s);
            return rez;
        }

        static string Ponovi2(string s, int n)
        {
            string rez = "";
            for (int i = 0; i < n; i++)
                rez = rez.Insert(rez.Length, s);
            return rez;
        }

.. mchoice:: string_efi_q4
    :multiple_answers:
    :answer_a: IzbaciRazmake1
    :answer_b: IzbaciRazmake2
    :answer_c: IzbaciRazmake3
    :answer_d: IzbaciRazmake4
    :correct: b, c
		
    Дати методи враћају стринг са изостављеним размацима. Који од њих су неефикасни (означити све тачне одговоре)?

    .. code-block:: csharp

        static string IzbaciRazmake1(string s)
        {
            return s.Replace(" ", "");
        }

        static string IzbaciRazmake2(string s)
        {
            string rez = "";
            foreach (char c in s)
                if (c != ' ') rez += c;
            return rez;
        }

        static string IzbaciRazmake3(string s)
        {
            int i = 0;
            while (i < s.Length)
                if (s[i] == ' ') s = s.Remove(i, 1);
                else i++;
            return s;
        }

        static string IzbaciRazmake4(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
                if (c != ' ') sb.Append(c);
            return sb.ToString();
        }


