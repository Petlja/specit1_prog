Читање и упис података у текстуални фајл
========================================

У приручнику `Увод у програмирање у програмском језику C# <https://petljamediastorage.blob.core.windows.net/root/Media/Default/Kursevi/spec-it/csharpprirucnik.pdf>`_ прочитајте поглавље 7.8 (стране 214-219).

~~~~

Отварање и затварање фајла
--------------------------

За читање и писање фајла у језику `C#` користе се редом објекти класа ``StreamReader`` и ``StreamWriter``. Класичан редослед операција приликом читања текста из фајла је:

.. code-block:: csharp

    StreamReader sr = new StreamReader(putanja);  // Отвори фајл за читање
    string linija;
    while ((linija = sr.ReadLine()) != null)      // Док можеш да прочиташ једну линију текста
    {
        // ... linija ...                         // обради ту линију текста
    }
    sr.Close();                                   // Затвори фајл
    
Слично је и приликом писања у фајл:

.. code-block:: csharp

    StreamWriter sw = new StreamWriter(putanja);  // Отвори фајл за писање
    sw.Write("...");                              // Пиши у фајл
    sw.WriteLine("...");                          // Пиши у фајл
    // ...
    sw.Close();                                   // Затвори фајл

При сваком отварању фајла (било за читање или писање) оперативни систем алоцира одређене ресурсе да би омогућио приступ фајлу. Затварањем фајла (позивањем метода ``Close()``) одјављујемо потребу за тим ти ресурсима и растерећујемо оперативни систем, који ће касније те ресурсе да ослободи. 

У случају да се не изврши метод ``Close()`` (нпр. зато што смо заборавили да га напишемо), систем остаје оптерећен неослобођеним ресурсима, а у неким случајевима текст уписан у фајл може да не буде сачуван у целости.

.. reveal:: nezatvaranje_fajla
    :showtitle: О незатварању фајла
    :hidetitle: Сакриј детаље о незатварању фајла

    **Детаљније о незатварању фајла:**
    
    Приликом извршавања наредби за писање у фајл, текст се не уписује одмах на диск, јер би такав начин рада био врло спор (приступ диску је за неколико редова величине спорији од приступа радној меморији рачунара). Уместо директног писања на диск, текст се уписује у одговарајући бафер (`buffer`), тј. меморију специјално намењену за чување текста до уписа на диск. Текст се уписује на диск тек кад се бафер напуни, или када се то експлицитно захтева (нпр. методом ``Flush()``). На тај начин се смањује број приступа диску и успорење програма које тиме настаје (енглеска реч `buffer` у овом контексту значи ублаживач, јер употреба поменуте меморије ублажава проблем успорења програма).
    
    Може се догодити да након отварања а пре затварања фајла наступи изузетак (`exception`) због покушаја неизводљиве операције (нпр. приступ непостојећем елементу низа, дељење нулом и слично). У том случају наредбе у наставку програма, међу којима је и наредба за затварање фајла, неће бити извршене, већ се прелази на наредбе за обраду изузетка, ако такве наредбе постоје (ако не постоје, програм пукне).
    
    Незатварање фајла је већ само по себи лоше, јер су заузети ресурси који се више не могу користити. Додатни проблем је што може  доћи до тога да део текста заостане у баферу и да не буде уписан на диск.
    
Наредба `using`
---------------

Да не бисмо морали да бринемо о затварању фајла, `C#` омогућава савременији начин употребе фајла:

.. code-block:: csharp

    using (StreamReader sr = new StreamReader(putanja))
    {
        string linija;
        while ((linija = sr.ReadLine()) != null)
        {
            // обради ту линију текста
        }
    }

односно, за писање:

.. code-block:: csharp

    using (StreamWriter sw = new StreamWriter(putanja))
    {
        sw.Write("...");
        sw.WriteLine("...");
        // ...
    }

Значење наредбе ``using`` је такво да се самим изласком из блока који следи, фајл правилно затвара и ресурси се одмах ослобађају. Захваљујући томе, није потребно писати позив метода ``Close()``. Фајл се такође правилно затвара и у случају да наступи изузетак и не дође се до краја блока означеног витичастим заградама ``{ ... }``.

Читање помоћу набројиве колекције
---------------------------------

Још једноставнији и савременији начин читања фајла је употреба метода ``File.ReadLines``. Овај метод враћа набројиву колекцију стрингова, од којих сваки садржи по једну линију текстуалног фајла. Употреба изгледа овако:

.. code-block:: csharp

    foreach (string linija in File.ReadLines(putanja))
    {
        // обради ту линију текста
    }

или, потпуно равноправно:

.. code-block:: csharp

    var tekst = File.ReadLines(putanja);
    foreach (string linija in tekst)
    {
        // обради ту линију текста
    }

Ова језичка конструкција нам омогућава да чак не морамо ни да знамо о отварању и затварању фајла, ресурсима и објекту ``StreamReader``, а да смо при томе сигурни да ће све што је потребно за приступ фајлу бити правилно обављено (и скривено од нас).

Овакав начин читања фајла може да делује нерационално у случају веома дугог фајла, јер изгледа као да смо у ``tekst`` (какав год да је то објекат или променљива) пребацили цео садржај текстуалног фајла и тиме заузели много меморије, а и успорили програм. На срећу, метод ``File.ReadLines`` је имплементиран на много бољи начин. Поменули смо да овај метод враћа набројиву колекцију, која је слична низу. Време је да разјаснимо разлику између низа и набројиве колекције.

Под набројивом колекцијом подразумевамо све што може да се употреби у наредби ``foreach`` (исправније речено, све што имплементира интерфејс ``IEnumerable``). У том смислу, низ је једна врста набројиве колекције о којој већ прилично знамо. Међутим, постоје објекти који могу да се употребе у наредби ``foreach`` и да дају прве елементе своје колекције (у овом случају прве линије текстуалног фајла) и пре него што дохвате све елементе. Наредни елементи колекције могу да буду дохватани док се програм извршава над претходним елементима колекције, због чега програм ради брже и штеди радну меморију рачунара.

Уколико баш желимо да имамо приступ свим линијама текстуалног фајла одједном, можемо да сместимо све линије у листу (једну по једну), а можемо и да употребимо метод ``File.ReadAllLines``, који враћа низ линија фајла. Тај низ можемо даље да користимо на исти начин

.. code-block:: csharp

    string[] sadrzajFajla = File.ReadAllLines(putanja);
    foreach (string linija in sadrzajFajla)
    {
        // linija 
    }

али **ово се не препоручује за велике фајлове** јер је нерационално, као што смо управо објаснили. Смештање свих линија текста у низ је прихватљиво у случају малих фајлова, а код већих фајлова је оправдано само ако из неког разлога имамо потребу да им приступамо другачијим редоследом од уобичајеног.

Пример - Пребројавање појављивања речи
''''''''''''''''''''''''''''''''''''''

.. questionnote::

    Написати програм који нуди корисника да унесе путању до неког `C#` програма (што је такође текстуални фајл) и реч (име променљиве или метода, кључну реч и сл.) коју жели да пронађе у фајлу, а затим за свако појављивање задате речи исписује линију фајла и редни број оне речи у линији, која је једнака задатој.
    
    Програм треба да проналази само целе речи, а не и делове речи. Под речима овде подразумевамо низове малих и великих слова, раздвојене размаком или симболима ``[``, ``]``, ``(``, ``)``, ``;``, ``,``, ``.``, ``:``, ``{``, ``}``, ``+``, ``-``, ``*``, ``/``, ``=``, ``&``, ``!``, ``~``, ``^``, ``\``, ``"``, ``'``.
    
Читање из фајла је, наравно, најважније што желимо да илуструјемо у овом примеру. Поред читања из фајла, занимљив детаљ у програму чине и редови 

.. code-block:: csharp

    char[] separatori = "[]() ;,.:{}+-*/=&!~^\"'".ToCharArray();

и    

.. code-block:: csharp
    
    string[] reci = linija.Split(separatori, StringSplitOptions.RemoveEmptyEntries);
    
Низ симбола ``separatori`` се састоји од свих набројаних симбола, укључујући и размак. Методом ``Split`` растављамо линију текста на низ стрингова, користећи све ове симболе као сепараторе. У случају да се неки од ових симбола нађу један до другог (на пример ``(`` и ``)`` или размак и било који од ових симбола), добили бисмо између њих празан стринг, који би довео до погрешног бројања речи. Тај проблем смо избегли користећи параметар ``StringSplitOptions.RemoveEmptyEntries``, чије дејство је да из резултујућег низа стрингова буду изостављени празни стрингови.

.. activecode:: trazi_rec3
    :passivecode: true
    :coach:
    :includesrc: _src/fajlovi/trazi_rec3.cs

На пример, ако бисмо покренули програм и задали да тражимо реч ``brojPojavljivanja`` управо у овом програму, добили бисмо следећи резултат:

.. code::

    Linija 15 rec 2
    Linija 27 rec 1
    Linija 32 rec 2
    Linija 33 rec 6
    Ukupno 4 pojavljivanja.

Путању до фајла са изворним кодом програма можете да добијете десним кликом на картицу (таб) изнад кода са именом фајла (име фајла је вероватно ``Program.cs``) и избором опције `Copy Full Path`.
