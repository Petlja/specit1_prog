Употреба матрица - квиз
=======================

.. fillintheblank:: matrice_q1

    Колико редова има матрица `a` после наредбе 
    
    .. code-block:: csharp

        int[, ] a = new int[5, 9];
        
    - :^5$: Тачно!
      :.*: Не.



.. fillintheblank:: matrice_q2

    Колико колона има матрица `a` после наредбе 
    
    .. code-block:: csharp

        int[,] a = new int[20, 10];
        
    - :^10$: Тачно!
      :.*: Не.



.. fillintheblank:: matrice_q3

    Која је вредност ``s[2,1]`` после наредбе 
    
    .. code-block:: csharp

        string[,] s = {
            {"prvi", "prva", "prvo"}, 
            {"drugi", "druga", "drugo"}, 
            {"treci", "treca", "trece"}, 
            {"cetvrti", "cetvrta", "cetvrto"}
        };
        
    - :^treca$: Тачно!
      :.*: Не.



.. mchoice:: matrice_q4
    :answer_a: На први начин (сви елементи матрице у једном реду).
    :answer_b: На други начин (свака врста матрице у посебном реду).
    :answer_c: На трећи начин (сваки елемент матрице посебном реду).
    :correct: a
    :feedback_a: Тачно!
    :feedback_b: Не.
    :feedback_c: Не.
		
    Следећи кôд формира и приказује матрицу:

    .. code-block:: csharp

        int[,] x = { { 1, 2 }, { 3, 4 } };
        for (int i = 0; i < 2; i++)
            for (int j = 0; j < 2; j++)
                Console.Write("{0} ", x[i,j]);
        Console.WriteLine();
        
    Како ће бити приказани елементи матрице извршавањем тог кода?

    .. code-block::

        први начин:       други начин:    трећи начин:
        
        1 2 3 4           1 2             1
                          3 4             2
                                          3
                                          4
                                          

.. mchoice:: matrice_q5
    :answer_a: 1 2 3 4 
    :answer_b: 2 1 4 3
    :answer_c: 1 3 2 4
    :correct: c
    :feedback_a: Не.
    :feedback_b: Не.
    :feedback_c: Тачно!
		
    Којим редом ће бити приказани елементи матрице при извршавању следећег кода?

    .. code-block:: csharp

        int[,] x = { { 1, 2 }, { 3, 4 } };
        for (int j = 0; j < 2; j++)
            for (int i = 0; i < 2; i++)
                Console.Write("{0} ", x[i,j]);
        Console.WriteLine();
        



.. fillintheblank:: matrice_q6

    Колико елемената има низ ``a`` после наредбе 
    
    .. code-block:: csharp

        int[,,] a = new int[3, 5, 4];
        
    - :^60$: Тачно!
      :.*: Не.
