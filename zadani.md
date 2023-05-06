# Domácí projekt - Peaceful Snowball

Jedná se o zasněženou oplocenou krajinu. Doporučuji hru vytvořit 2D, ale nezakazuji 3D. Hráč
hraje za středovou sněhovou kouli na sněhuláka. Cílem je odpálit sněhovou kouli (jako na golfu) tak,
aby se koule dostala ke svým ostatním koulím, ale cestou aby narostla do správně velikosti (velikost
mezi menší a větší koulí). Pravidla Již existujících překážek:

- **hráč** – ovládání nechám na vás, ale když se koule pohybuje, roste (to je hlavní mechanika hry)
- **strom** – blok, při kolizi dojde k odražení, ale také ke zpomalení. Strom je animovaný, takže
pokud do něj koule narazí, proběhne nějaká animace
- **ending** – cíl, kam se má hráč dovalit. Aby byl level splněný, musí mít hráč (koule) velikost mezi
malou a velkou koulí sněhuláka.
- **booster** – při dotyku odpálí hráče, který se zmenší na polovinu své aktuální velikosti a zrychlí
hráče na vyšší rychlost, než měl, když k boosteru dorazil (třeba 1,5x, 2x...?)


**- plot –** blok, od kterého se koule odrazí, ale nezpomalí (doporučuji si pohrát
s Physics materiálem). Vytvořte si plot modulární, abyste v rámci různých levelů mohli tvořit i jiné
tvary než jen obdélníky.

Nastavená pravidla nejsou otestována, takže zatím nevím, jaký budou mít vliv na gameplay. Nebojte
se si trochu s těmi pravidly číselně pohrát! Některé další věci jsou záměrně otevřené a je na vás, jak je
uděláte, například jestli se celý level musí dohrát na jeden „šťouch“ nebo jestli je možné jich udělat
víc. Také není zadán způsob ovládání.

Vytvořte alespoň 5 levelů, které budou náročné dle vašeho uvážení. Doporučuji k tomu přistoupit jako
k opravdovému vývoji hry, takže dejte hru někomu otestovat a neměl by se tvářit zmateně, nevědět
co dělat, jak hru ovládat atd. – tedy doporučuji použít mechaniky interaktivního tutoriálu, kdy se hráč
postupně seznamuje s novými prvky napříč levely.

## Za práci budou uděleny 3 známky a budou za různá kritéria!

**1. Zpracování –** kvalita zpracování

```
Např. Grafika, UI, animace, originalita, návrh tříd...
```
**2. Gameplay –** mechaniky, které mají vliv na hráče (aby se necítil ztracený atd.)

```
Např. Ovládání, level select, informování hráče, tutoriál...
```
**3. Vlastní iniciativa (něco svého „navíc“) –** jsou vyžadovány aspoň 2 (1 viditelná a 1
    neviditelná), ale budou hodnoceny dohromady (pokud uděláte jen jednu z těch dvou,
    dostanete za toto 3)
       - **„Neviditelná mechanika“ –** vlastní herní mechanika, která přímo ovlivňuje hru, ale
          není to „další překážka do levelu“, ale je to průvodní mechanika napříč levely,
          příkladem mohou být _skóre, ukládání progresu, HP, shop, skiny, speciální vlastnosti,_
          _upgrady, buffy, mince..._
       - **„Viditelná mechanika“ –** nový objekt umístitelný do levelu s vlastní mechanikou
          (rozdílnou od zadaných), např. _další překážky, boostery, nepřátelé, lasery, časově_
          _závislé překážky, klíče..._

Odevzdání při hodině HEV v týdnu 8.-12. květena. Pokud víte, že budete chybět, doručte včas build, ať
si můžeme všichni zahrát

## Forma odevzdání

Přineste si hlavně build aplikace, Unity mě ten den zajímat nebude. Proto udělejte přechody mezi
scénami řádně, ať se vám hra nezasekává a nemusí se komplet restartovat.

V den kontroly si všichni všechny hry zahrajeme a ohodnotíme. Pokud nebudete ve škole, pokuste se
build doručit nějak jinak (poslat).


