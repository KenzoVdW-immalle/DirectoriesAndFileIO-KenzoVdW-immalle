# Analyseer

Bekijk de volledige commit-geschiedenis om te bestuderen hoe dit project tot stand gekomen is.

Probeer volgende vragen te beantwoorden:

i.v.m. MSTest:

- Welke Assert-methods worden naast `Assert.AreEqual` nog allemaal gebruikt?

>Assert.IsTrue en Assert.IsFalse.

- Waarom heeft `TestDirectories` een `Initialize`- en `CleanUp`-method?

> Om te zien of de directory bestaat en om de directory te verwijderen.

- Zijn de attributen `[TestMethod]`, `[TestClass]`, ... noodzakelijk? (Test uit!)

> Als je een van de atributen verwijderd wordt er een test minder uitgevoerd.

- Wat is de shortcut om alle tests uit te voeren in VS?

> CTRL + R + A

i.v.m. Files en Directories:

- Wat is het voordeel van `Path.Combine` i.v.m. strings aan elkaar plakken?

> Het is gemakkelijker en sneller, je moet niet heel het path terug opnieuw intypen.

- Wordt de return-waarde van `Directory.CreateDirectory(...)` steeds opgevangen? (TIP: gebruik `CTRL-SHIFT-F`)

>Ja.

- Wat is de return-waarde van `Directory.CreateDirectory(...)`?

>True of false.

- Wanneer is het nuttig om de return-waarde van `Directory.CreateDirectory(...)` op te vangen?

>Om te controleren of de method werkt.

i.v.m. duidelijkheid/geschiedenis van de code:

- Lukken de testen in de commit 3ffe2c86? Waarom (niet)?

>Nee, expect en assert zijn omgewisseld.

- Wat lost commit d0320b6a op?

>hierdoor werken de testen Wel.

- Wat is het probleem met de files in commit 9d184949?

> niet goed uitgewerkt.

- Wat doet commit 9b3e4065? Maakt dit de code makkelijker leesbaar? Makkelijker uitbreidbaar?

> verduidelijking van de code van de vorige commit.



