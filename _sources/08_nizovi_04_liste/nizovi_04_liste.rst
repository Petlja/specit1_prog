Листе
=====

Вероватно сте приметили да у примерима и задацима које смо до сада проучавали и решавали, сваки низ након формирања остаје исте дужине све док постоји у програму. То није случајно. Научили смо да се наредбом попут ове 

.. code-block:: csharp

    int[] a = new int[10];

у динамичкој меморији резервише тачно онолико простора колико је потребно за дати низ, у овом случају то је по 4 бајта за сваки целобројни податак, дакле :math:`10 \cdot 4 = 40` бајта. 

**Низови не могу да се продужавају**

Свака меморијска локација у рачунару има своју адресу, која је цео број. То значи да је меморија у рачунару линеарна (локације се ређају једна за другом). Због тога део меморије који смо на овај начин заузели не можемо накнадно продужавати или скраћивати, јер део који следи или претходи заузетом можда није слободан. Ако би нам било потребно да низу ``a`` додамо једанаести елемент, суштински једини начин да то урадимо је да направимо нови низ, на пример овако:

.. code-block:: csharp

    int[] b = new int[11];
    for (int i = 0; i < 10; i++)
        b[i] = a[i];
    a = b;

Овим смо заузели потпуно нову меморију, преписали постојеће вредности и ослободили стару меморију. Овакав поступак зовемо **реалокација низа.** За дугачке низове ова операција може да буде прилично спора. Јасно је да ово није најбољи начин да се низ продужи и да нема смисла преписивати све елементе низа сваки пут када желимо да додамо нови елемент. 

**Низови не могу да се скраћују**

Могућа је и обрнута ситуација, када нам логика проблема намеће да низ треба скратити. Нека је, на пример, потребно да се из низа избаци последњи елемент. Овде смо у нешто бољој позицији него малопре, јер можемо да се снађемо и без алоцирања новог низа и преписивања свих елемената осим последњег. Наиме, можемо да уведемо посебну променљиву која нам говори колико елемената низа користимо. Након увођења такве конвенције, скраћивање низа је врло једноставно - само поменуту променљиву смањимо за 1. Ипак, тиме програми постају мање елегантни и јасни, јер низ као тип при таквој употреби више није самосталан (енгл. *self-contained*).

~~~~

Када не знамо унапред колико елемената ће нам бити потребно у низу, или је погодно да се тај број мења током рада програма, уместо низа треба да користимо листу. Листе су веома сличне низовима, а најважнија разлика је у томе што листе могу да се продужавају на ефикаснији начин. Осим ове, најважније разлике, значајно је и то да је скраћивање листе јасније и на одређени начин чистије него "скраћивање" низа увођењем посебне променљиве за његову "дужину".

Формирање листе
---------------

Листе се налазе у именском простору ``System.Collections.Generic``, па да не бисмо свуда уместо ``List`` писали ``System.Collections.Generic.List``, на почетак програма треба додати директиву

.. code-block:: csharp

    using System.Collections.Generic;
    
Најједноставнији начин да формирамо листу је 

.. code-block:: csharp

    List<int> a = new List<int>();

Листа ``a`` је листа целих бројева, а на исти начин се може направити и листа елемената било којег другог типа (само уместо ``int`` треба уписати назив одговарајућег типа). 

Овако формирана листа је празна. Листу често попуњавамо користећи метод ``Add``, којим се додаје елемент на крај листе. На пример, овако можемо да учитавамо бројеве и додајемо их у листу све док се не унесе 0:

.. code-block:: csharp

    List<int> a = new List<int>();
    int x = int.Parse(Console.ReadLine());
    while (x != 0)
    {
        a.Add(x);
        x = int.Parse(Console.ReadLine());
    }

Број елемената и капацитет листе
--------------------------------

С обзиром на речено о организацији меморије у рачунару и немогућност накнадног проширивања раније заузете меморије, можемо се запитати како онда листе могу да се продужавају. Први део трика је у томе да листа уме унапред да заузме нешто више меморије него што је потребно за њене елементе. Зато, када причамо о дужини листе, треба разликовати број елемената листе који очитавамо као својство ``Count`` и капацитет листе, који је доступан преко својства ``Capacity`` (које се може и постављати, а не само читати). Понекад се број елемената назива и логичка дужина, а капацитет  - физичка дужина.

Кроз проучавање следећег програма можемо боље да схватимо својства ``Count`` и ``Capacity``:

.. activecode:: nizovi_kapacitet_liste
    :passivecode: true
    :coach:
    :includesrc: _src/nizovi/nizovi_kapacitet_liste.cs

У листу додајемо нове елементе (сви су једнаки 5, пошто вредности нису битне у овом примеру), док листа не нарасте на 1000 елемената. Када покренемо овај програм, он исписује:

.. code::

    Na pocetku lista ima 0 elemenata, a kapacitet je 0.
    Dodavanjem 1-og elementa kapacitet se povecao na 4.
    Dodavanjem 5-og elementa kapacitet se povecao na 8.
    Dodavanjem 9-og elementa kapacitet se povecao na 16.
    Dodavanjem 17-og elementa kapacitet se povecao na 32.
    Dodavanjem 33-og elementa kapacitet se povecao na 64.
    Dodavanjem 65-og elementa kapacitet se povecao na 128.
    Dodavanjem 129-og elementa kapacitet se povecao na 256.
    Dodavanjem 257-og elementa kapacitet se povecao na 512.
    Dodavanjem 513-og elementa kapacitet se povecao na 1024.

Видимо да до реалокације долази само када постојећи капацитет листе није довољан да прими све елементе листе. На пример, капацитет од 128 елемената је довољан све док не покушамо да додамо 129-ти елемент, а тада се алоцира нови простор. Тако се додавање на пример 124-тог елемента у листу дешава практично тренутно (у листу се само упише једна нова вредност и повећа се својство ``Count``), док додавање 129-тог елемента траје 128 корака више (јер треба преписати све претходне елементе). Зашто онда овакво проширивање листе сматрамо ефикасним? Овде долазимо до другог дела трика, а то је да се сваки пут када је потребна реалокација, заузме простор за двоструко више елемената него што је претходно било алоцирано. На тај начин реалокације постају довољно ретке да је укупно време свих додавања и преписивања елемената знатно смањено.

|

Анализирајмо мало резултат рада датог програма да би нам постало јасније колико је стварно ефикасно додавање елемената у листу на овај начин. При реалокацијама највећи део времена одлази на преписивање постојећих  елемената. Израчунајмо зато број преписивања елемената која се догоде током додавања првих ``n`` елемената у листу. Додавањем нпр. 1000 елемената у листу, она је једном алоцирана и 8 пута реалоцирана. При првој реалокацији је преписано 4 елемента, при другој 8 итд. до 512, што је укупно :math:`4 + 8 + 16 + 32 + 64 + 128 + 256 + 512 = 1020` преписивања. Уз још мало анализирања можемо се уверити да број преписивања ни у једном тренутку није већи од двоструког броја елемената листе, што значи да у просеку имамо до два преписивања по елементу листе. Према томе, **просечно трајање додавања једног елемента у листу је ограничено константом и не зависи од дужине листе!** Дакле, истина је да су додавања појединих елемената спора, али укупно време додавања свих елемената је сразмерно дужини листе, то јест такво као да су сва појединачна додавања брза (у просеку трају мање него три уписа вредности у листу).

|

Приликом формирања листе можемо и да јој задамо почетни капацитет. На пример, ако напишемо

.. code-block:: csharp

    List<int> a = new List<int>(n);

добијамо празну листу капацитета ``n``. Када овако задамо листу, додавање првих ``n`` елемената неће изазвати реалокације. На овај начин се постепено  повећавање листе може учинити још ефикаснијим, нарочито ако знамо максималну дужину листе која нам може требати током решавања проблема (јер тада уопште неће бити реалокација).

**Пример - декомпресија низа**

Један од првих алгоритама за компресију података је познат под именом *run-length encoding* алгоритам. Реч *run* у називу алгоритма означава секвенцу у којој се иста вредност појављује велики број пута узастопно. Ово је, на пример, типично за слике са великим једнобојним површинама. Таква секвенца се овим алгоритмом представља тако што се запише број понављања и вредност која се понавља (отуда назив *run-length*). На пример, секвенца 2, 2, 2, 2, 2, 2, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 4 се сажима у 7, 2, 9, 1, 1, 4. Овај сажет (компримован) запис тумачимо као седам двојки, девет јединица и једну четворку. 

Претпоставимо да имамо један овако спакован запис у низу ``a`` и да треба да га распакујемо. Ако желимо да решимо задатак без употребе листи, потребно је прво одредити дужину резултујућег низа, затим алоцирати и напунити тај резултујући низ.

.. code-block:: csharp

    // odredjujemo duzinu
    int n = 0;
    for (int ia = 0; ia < a.Length; ia += 2)
        n += a[ia];

    // alociramo
    int[] b = new int[n];
    int ib = 0;

    // punimo rezultujuci niz
    for (int ia = 0; ia < a.Length; ia += 2)
    {
        for (int pon = 0; pon < a[ia]; pon++)
        {
            b[ib] = a[ia + 1];
            ib++;
        }
    }

Ако користимо листу, задатак можемо да решимо краће јер не морамо да одређујемо дужину листе са распакованим подацима:
 
.. code-block:: csharp

    List<int> b = new List<int>();
    for (int ia = 0; ia < a.Length; ia += 2)
        for (int pon = 0; pon < a[ia]; pon++)
            b.Add(a[ia + 1]);

Иницијализација и конверзије
----------------------------

Листу можемо да започнемо са првих неколико вредности смештених у њу већ приликом декларације. То се ради врло слично као са низом:

.. code-block:: csharp

    List<int> prosti = new List<int>() { 2, 3, 5, 7, 11 };


Такође, у сваком тренутку рада програма, од низа једноставно можемо да направимо листу и обрнуто, на пример овако:

.. code-block:: csharp

    int[] a1 = { 1, 2, 3, 4 };
    List<int> L1 = new List<int>(a1);
    int[] a2 = L1.ToArray();

Треба имати на уму да се овим наредбама елементи низа ``a1`` преписују у листу ``L1``, а затим из листе ``L1`` у низ ``a2``, што значи да наведене операције нису брзе и не треба их користити превише често на дугачким серијама података. Да низови ``a1``, ``a2`` и листа ``L1`` садрже независне копије података лако се можемо уверити мењајући неке од вредности и исписујући вредности оба низа и листе. 

Напоменимо само да се овде ради о такозваним плитким копијама, што постаје важно тек у раду са низовима елемената који су неког референцираног типа. Наиме, овде се елементима листе или низа вредности додељују оператором =. У случају бројева то је све што нам треба, али ако су елементи полазног низа на пример нови низови, онда ће листа и други низ садржати нову серију референци на исте низове који се референцирају из полазног низа.

