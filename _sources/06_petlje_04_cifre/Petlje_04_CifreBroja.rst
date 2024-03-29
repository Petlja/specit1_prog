Цифре природног броја
=====================

Издвајање цифара природног броја и манипулација тим цифрама је традиционална тема за вежбање програмирања петљи. Издвајањем цифара из броја, њиховим премештањем у други број, формирањем броја од датих цифара и слично, стичемо одређену вештину алгоритамског изражавања и писања програма, која је овде много важнија од самог решења неког конкретног задатка.

Издвајање цифара
----------------

За издвајање цифара из броја кључне су следеће чињенице:

- цифра јединица броја :math:`n` је једнака остатку при дељењу :math:`n` са 10, то јест :math:`n \bmod 10`, што у програму записујемо као ``n % 10``.
- број који настаје уклањањем цифре јединица из броја :math:`n` једнак је :math:`\left\lfloor {n \over 10} \right\rfloor` , што у програму записујемо као ``n/10``

Захваљујући овоме, релативно је једноставно издвајати цифре из броја редом сдесна на лево, то јест почевши од цифре јединица. 
Довољно је да у петљи издвајамо цифру јединица и уклањамо је из датог броја, док год има цифара.

.. questionnote::

    **Пример - издвајање цифара**
    
    За дати природан број *n* исписати све његове цифре у обрнутом редоследу (од цифре јединица до цифре највеће тежине).
    
Претходну идеју директно ћемо спровести у програм:

.. activecode:: cifre_izdvoj_while
    :passivecode: true
    :coach:
    :includesrc: _src/petlje/cifre_izdvoj_while.cs
 
Овај програм ради исправно за све природне бројеве - испробајте га. Можда ћете приликом тестирања програма испробати и шта се дешава ако унесете нулу и видећете да програм не исписује ништа у том случају (што може да се закључи и пажљивим читањем програма).

Уколико је потребно да програм исправно ради и за нулу (то јест да испише цифру 0), можемо тај случај да покријемо једном ``if`` наредбом. Пошто сваки број има бар једну цифру, још боље решење је да петљу организујемо тако да се прво издвоји и испише цифра, а затим проверава да ли има још цифара. За такав редослед операција најпогодније је користити ``while-do`` петљу:


.. activecode:: cifre_izdvoj_do_while
    :passivecode: true
    :coach:
    :includesrc: _src/petlje/cifre_izdvoj_do_while.cs

За решавање овог задатка могуће је употребити и ``for`` петљу или наредбу ``break``, али није примерено (такво решење би било помало рогобатно).


Формирање броја од датих цифара
-------------------------------

Када формирамо неки број од датих цифара, користимо следећу математичку чињеницу:

- број који настаје дописивањем цифре :math:`c` на (десни) крај броја :math:`n` једнак је :math:`10 n + c` ( у програму: ``10 * n + c``)

Ово значи да број чије су цифре редом слева на десно :math:`c_1, c_2, ..., c_k`, може да се формира дописивањем тих цифара на нулу (истим редом) користећи наведену формулу.

.. questionnote::

    **Пример - формирање броја с лева надесно**
    
    За дати природан број *m* (не већи од 10) и *m* цифара, исписати број који се састоји од тих *m* цифара. На пример, ако је *m* једнако 5 и затим се унесу цифре 2, 1, 7, 3, 9 (сваки од података се уноси у посебном реду), треба исписати број 21739.
    
Пре петље ћемо учитати број ``m`` и поставити будући резултат ``n`` на 0. Затим, у ``m`` пролаза кроз петљу (за ово је најпогоднија петља ``for``) учитавамо по једну цифру и "дописујемо" је на број ``n``, тј. множимо број ``n`` са 10 и додајемо му цифру.

.. activecode:: cifre_formiraj_broj
    :passivecode: true
    :coach:
    :includesrc: _src/petlje/cifre_formiraj_broj.cs
 
Да бисмо израчунали број који се добија када неком :math:`m`-тоцифреном броју :math:`n` допишемо цифру :math:`c` спреда, треба да броју :math:`n` додамо :math:`c \cdot 10^m`, јер је :math:`10^m` месна вредност (тежина) цифре :math:`c` на тој позицији. 

Ово нам омогућава да број формирамо и дописујући му цифре спреда. 

.. questionnote::

    **Пример - формирање броја с десна налево**
    
    За дати природан број *m* (не већи од 10) и *m* цифара, исписати број који се састоји од тих *m* цифара у обрнутом редоследу. На пример, ако је *m* једнако 5 и затим се унесу цифре 2, 1, 7, 3, 9 (сваки од података се уноси у посебном реду), треба исписати број 93712.
    
Можемо приметити да је месна вредност сваке следеће цифре коју дописујемо 10 пута већа од претходне. Због тога је згодно да у програму користимо једну променљиву за месну вредност, тј. тежину цифре, тако што јој пре петље доделимо вредност 1, а у петљи је множимо са 10.

.. activecode:: cifre_formiraj_broj_unazad
    :passivecode: true
    :coach:
    :includesrc: _src/petlje/cifre_formiraj_broj_unazad.cs
 

У задацима који следе можете вежбати употребу петљи ради баратања цифрама броја.
