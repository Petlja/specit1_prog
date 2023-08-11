Аргументи командне линије програма - квиз
=========================================

.. quizq::

    .. mchoice:: cmdline_args_q1
        :answer_a: zadatak primer01.in
        :answer_b: zadatak > primer01.in
        :answer_c: zadatak < primer01.in
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!
            
        Како се пише команда којом се програму ``zadatak`` преусмерава стандардни улаз са тастатуре на фајл ``primer01.in``?

.. quizq::

    .. mchoice:: cmdline_args_q2
        :answer_a: Није могуће истовремено преусмерити и стандардни улаз и стандардни излаз.
        :answer_b: zadatak < primer01.in > primer01.out
        :answer_c: zadatak > primer01.in < primer01.out
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
            
        Како се пише команда којом се програму ``zadatak`` преусмерава стандардни улаз са тастатуре на фајл ``primer01.in``, а стандардни излаз на фајл ``primer01.out``?

.. quizq::

    .. mchoice:: cmdline_args_q3
        :answer_a: листа стрингова
        :answer_b: један стринг
        :answer_c: низ стрингова
        :answer_d: структура
        :correct: c
        :feedback_a: Не.
        :feedback_b: Не.
        :feedback_c: Тачно!
        :feedback_d: Не.
            
        Аргументи из командне линије се могу проследити програму као ...  (доврши реченицу)

.. quizq::

    .. mchoice:: cmdline_args_q4
        :answer_a: Уместо размака треба користити доњу црту (симбол ``_``).
        :answer_b: Такав аргумент треба писати под наводницима.
        :answer_c: Такав аргумент треба писати у заградама.
        :answer_d: Такав аргумент није могуће проследити програму.
        :correct: b
        :feedback_a: Не.
        :feedback_b: Тачно!
        :feedback_c: Не.
        :feedback_d: Не.
            
        Како се програму прослеђује аргумент који садржи размаке?

.. quizq::

    .. mchoice:: cmdline_args_q5
        :answer_a: У дијалогу "Project properties" (својства пројекта)
        :answer_b: Писањем вредности аргумената у коду, између заграда после речи "Main"
        :answer_c: У коду, у првој линији коментара.
        :answer_d: Аргументи у командној линији се не могу проследити при извршавању из радног окружења.
        :correct: a
        :feedback_a: Тачно!
        :feedback_b: Не.
        :feedback_c: Не.
        :feedback_d: Не.
            
        Како се програму прослеђују аргументи у командној линији, ако програм извршавамо у радном окружењу `Visual Studio`?
