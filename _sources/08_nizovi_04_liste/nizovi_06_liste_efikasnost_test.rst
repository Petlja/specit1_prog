Листе и ефикасност - квиз
=========================

.. mchoice:: metodi_efi_q1
    :answer_a: a.AddRange(a);
    :answer_b: a.InsertRange(0, a);
    :answer_c: int n = a.Count; for (int i = 0; i < n; i++) a.Insert(i, a[2*i]);
    :answer_d: int n = a.Count; for (int i = 0; i < n; i++) a.Add(a[i]);
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.
		
    Који од датих начина да се листа *a* надовеже на саму себе је далеко најспорији?


.. mchoice:: metodi_efi_q2
    :answer_a: Оба начина су врло брза
    :answer_b: Оба начина су врло спора
    :answer_c: Први начин је врло брз а други врло спор
    :answer_d: Први начин је врло спор а други врло брз
    :correct: d
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Не.
    :feedback_d: Тачно!
		
    Шта можемо рећи о два дата начина да се празна листа попуни бројевима од *n*-1 до 0?

    .. code-block:: csharp

        // Први начин
        for (int i = 0; i < n; i++) a.Insert(0, i);
        
        // Други начин
        for (int i = n-1; i >=0; i--) a.Insert(a.Count, i);

.. mchoice:: metodi_efi_q3
    :answer_a: цела листа попуњена нулама
    :answer_b: у првој половини листе све нуле, а у другој све јединице
    :answer_c: у првој половини листе све јединице, а у другој све нуле
    :answer_d: цела листа попуњена јединицама
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
    :feedback_d: Не.
		
    За какву листу *a* од 100000 елемената ће следећи код (који избацује све јединице из листе) бити најспорији?

    .. code-block:: csharp

        int k; 
        while ((k = a.FindLastIndex(x => x == 1)) != -1) 
            a.RemoveAt(k);


.. fillintheblank:: metodi_efi_q4

    Дата су три начина да се из листе *a* дужине :math:`2 \cdot n` избаце сви елементи који се на почетку налазе на позицијама са непарним индексима.
    
    .. code-block:: csharp

        // a
        for (int i = 2*n-1; i > 0; i-=2) a.RemoveAt(i);
        
        // b
        for (int i = 0; i < n; i++) a[i] = a[2 * i];
        a.RemoveRange(n, n);

        // c
        for (int i = 1; i <= n; i++) a.RemoveAt(i);
        
    Упишите слова a, b, c без размака, тако да прво слово одговара најспоријем поступку, друго средњем по брзини, а треће најбржем.
        
    - :^cab$: Тачан одговор!
      :.*: Покушај поново.


.. comment

    .. parsonsprob:: metodi_efi_q4

        Дата су три начина да се из листе *a* избаце сви елементи који се на почетку налазе на парним позицијама. Поређајте ове начине по ефикасности од најспоријег до најбржег.
       
        .. code-block:: csharp
       
            // први начин
            for (int i = 2*n-1; i > 0; i-=2) 
                a.RemoveAt(i);
            
            
            // други начин
            for (int i = 0; i < n; i++) 
                a[i] = a[2 * i]; 
            
            a.RemoveRange(n, n);


            // трећи начин
            for (int i = 1; i <= n; i++) 
                a.RemoveAt(i);

        -----
        трећи начин
        први начин
        други начин
