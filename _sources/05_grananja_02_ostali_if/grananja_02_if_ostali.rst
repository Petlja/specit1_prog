Остали облици if наредбе
========================

У приручнику `Увод у програмирање у програмском језику C# <https://petljamediastorage.blob.core.windows.net/root/Media/Default/Kursevi/spec-it/csharpprirucnik.pdf>`_ погледајте поглавље 3.2 (стране 42-44).

~~~~

Поновимо укратко како све може да изгледа ``if`` наредба, осим свог основног облика описаног у претходној лекцији.

Скраћени облик *if* наредбе
---------------------------

Научили смо да наредба ``if`` има и скраћени облик, који се добија изостављањем *не* гране пуног облика који смо прво упознали. Према томе, скраћени облик изгледа овако:

.. code-block:: csharp

    if (услов) 
    { 
        наредбе
    }

Уколико је у скраћеном облику ``if`` наредбе услов испуњен, извршиће се наредбе у сада јединој грани, коју и даље можемо звати *да* грана, а понекад је зовемо и тело ``if`` наредбе. Када услов није испуњен, ``if`` наредба нема ефекта (програм наставља са радом као да ``if`` наредбе није ни било).

Вишеструка *if* наредба
-----------------------

Надовезивањем више ``if`` наредби може се добити такозвана вишеструка ``if`` наредба. На пример, надовезивањем 3 ``if`` наредбе добијамо запис овог облика:

.. code-block:: csharp

    if (услов1)
    { 
        наредбе1
    }
    else if (услов2)
    { 
        наредбе2
    }
    else if (услов3)
    { 
        наредбе3
    }
    else
    { 
        наредбе0
    }

Од 4 блока наредби биће извршен тачно један, и то онај који одговара првом испуњеном услову, а ако ниједан од услова није испуњен, извршава се последњи блок наредби (овде означен са ``наредбе0``).

.. questionnote::
    
    **Пример - категорије играча:** 
    
    Млади кошаркаши се на почетку кошаркашке сезоне региструју у једној од узрасних категорија, према томе колико година пуне у календарској години у којој сезона почиње. Правила регистровања су следећа:

    - 10 и мање - без категорије
    - 11 или 12 година - млађи пионири
    - 13 или 14 година - пионири
    - 15 или 16 година - кадети
    - 17 или 18 година - јуниори
    - 19 и више година - сениори
    
    Написати програм који учитава колико година кошаркаш пуни у години у којој се региструје, а исписује његову узрасну категорију.

.. activecode:: gran_1_KosarkaKategorije
    :passivecode: true
    :coach:
    :includesrc: _src/grananja/Grananja_KosarkaKategorije.cs
    

Вишеструка ``if`` наредба такође има скраћени облик, који се добија изостављањем последње речи ``else`` и последњег блока. На пример, скраћени облик троструке ``if`` наредбе изгледа овако:

.. code-block:: csharp

    if (услов1)
    { 
        наредбе1
    }
    else if (услов2)
    { 
        наредбе2
    }
    else if (услов3)
    { 
        наредбе3
    }

У овако написаној ``if`` наредби извршава се највише један блок. Ако има испуњених услова, извршиће се блок који одговара првом испуњеном услову, а ако ниједан услов није испуњен неће бити извршен ниједан блок наредби.

.. questionnote::
    
    **Пример - учење:** 
    
    Јованови родитељи су рекли Јовану да ако добије оцену мању од четворке из математике, енглеског или хемије, поподне треба да учи један од тих предмета. При томе, ако Јован буде имао оцене мање од четворке из два или сва три од ових предмета, приоритет има математика, затим енглески и на крају хемија. У случају да Јован добије четворке или петице из сва три предмета, онда родитељи немају посебних захтева и препуштају Јовану да изабере чиме ће да се бави поподне.

    Написати програм који редом учитава Јованове оцене из математике, енглеског и хемије, а затим исписује поруку за Јована. На пример:
    
    - за оцене 2, 4, 5 исписати "учи математику"
    - за оцене 3, 3, 2 исписати "учи математику"
    - за оцене 4, 2, 3 исписати "учи енглески"
    - за оцене 4, 5, 2 исписати "учи хемију"
    - за оцене 4, 4, 4 не треба исписати ништа

.. activecode:: gran_2_MatEngHem
    :passivecode: true
    :coach:
    :includesrc: _src/grananja/Grananja_MatEngHem.cs

Следе задаци који сви могу да се реше применом вишеструке ``if`` наредбе. Проверите да ли умете то да урадите.
