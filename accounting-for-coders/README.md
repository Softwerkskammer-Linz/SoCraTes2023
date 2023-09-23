# Accounting for coders

by norbert, support by fuero

## Buchhaltung Grundbegriffe

### Bilanz

Gegenüberstellung der Aktiva und Passiva - beide Seiten müssen den selben Betrag aufweisen.

Summe Aktiva - Summe Passiva = 0

Unterteilung an sich frei, üblich grob nach Dauer des Gebrauchs:

 > 1 Jahr - Anlagevermögen (Maschinen, Grundstücke, Gedbäude, Finanzanlagen)
 < 1 Jahr - Umlaufvermögen (Waren, Verbrauchsgüter, etc.)

Aktiva: Vermögen des Unternehmens (Geld, Anlagen, Maschinen, Forderungen etc.)

Irrelevant ob materiell (zum Angreifen) oder immateriell

Passiva: Verbindlichkeiten des Unternehmens (Schulden/Fremdkapital, nicht realisierte Verluste, Lieferantenverbindlichkeiten, nicht realisierte Verluste aus Finanzanlagen)

| Aktiva         | Passiva         |
| Anlagevermögen | Eigenkapital    |
|  Maschinen     |   Gewinnvorv.   |
|  Autos         |   Stammkapital  |
|  Computer      |   Sacheinlage   |
|                |   Gewinn        |
| Umlaufvermögen | Fremdkapital    |
|  Lager         |   Lieferantenverbindlichkeiten |
|  Forderungen   |   Bankkredit    |
|  Bank          |                 |

Gruppen in der Gliederung der Bilanz entsprechen Konten, auf denen
in der doppelten Buchführung Buchungen durchgeführt werden. Für Firmen
eine Struktur üblich, aber die ist nicht zwingend.

Prinzip der doppelten Buchhaltung:

Geschäftsvorfälle generieren Buchungen - ein Fluss zwischen Aktiva und
Passiva, muss also auf 2 Konten verbucht werden. Auf einem wirds mehr,
auf einem weniger.

### Buchungen

Beispiel Firmeneröffnung:

Einzahlung Stammkapital auf der Bank von 5000 EUR.
+5000 EUR auf Konto "Bank" (Aktiva)
-5000 EUR auf Konto "Stammkapital" (Passiva)

Beispiel Einbringen Laptop:

+300 EUR Wert Laptop auf Konto "Computer" (Aktiva)
-300 EUR auf Konto "Sacheinlage" (Passiva)

Beispiel Bankkredit:

+10000 EUR auf Konto "Bank" (Aktiva)
-10000 EUR auf Konto "Fremdkapital" (Passiva)

Beispiel Kundenzahlung, Fakturierung:

+800 EUR auf Konto "Forderung" (Aktiva)
-800 EUR auf Konto "Gewinn" (Passiva)

Beispiel Anschaffung Laptop

(1)
+500 EUR auf Konto "Computer"
-500 EUR auf Konto "Lieferantenverbindlichkeiten"
(2)
+500 EUR auf Konto "Lieferantenverbindlichkeiten"
-500 EUR auf Konto "Bank"

Beispiel Abschreibung:

-30 EUR auf Konto "Maschinen"
+30 EUR auf Konto "Gewinn"

GuV

| Aufwände    | Erlöse         |
| 30 auf AfA  | -30 auf Gewinn |

Konto Gewinn wird wegen Wichtigkeit noch in GuV (Gewinn- und Verlustrechnung)
aufgeteilt:

| Aufwände                        | Erträge                      |
| Gehalt an Programmierer         | Erlöse aus Programmierarbeit |

Sinnfrage der doppelten Buchhaltung:

Nicht bloß Kontrolle, sondern unterschiedliche Sichtweise auf Geldflüsse
zur besseren Übersicht.

Diskussion über Übersichtlichkeit und welchen Nutzen das für ein Unternehmen hat.
Firmen haben viel mehr Zahlungen und Geschäftsvorfälle als man einfach überblicken
kann, die doppelte Buchführung ist ein Instrument um Gefahren bei ausstehenden Zahlungen
und evtl. fehlender Deckung (Cashflow) aufzuzeigen.

## Ledger CLI

Ledger führt ein Text-Journal, das Buchungen dieser Gestalt auflistet:

Buchhalter führen Konten als Nummern, hier aber als Text

```
2023-09-22 Kauf Laptop
  Aktiva:Anlagevermögen:Laptop  500

## Bilanz

Gegenüberstellung der Aktiva und Passiva - beide Seiten müssen den selben Betrag aufweisen.

Summe Aktiva - Summe Passiva = 0

Unterteilung an sich frei, üblich grob nach Dauer des Gebrauchs:

 > 1 Jahr - Anlagevermögen (Maschinen, Grundstücke, Gedbäude, Finanzanlagen)
 < 1 Jahr - Umlaufvermögen (Waren, Verbrauchsgüter, etc.)

Aktiva: Vermögen des Unternehmens (Geld, Anlagen, Maschinen, Forderungen etc.)

Irrelevant ob materiell (zum Angreifen) oder immateriell

Passiva: Verbindlichkeiten des Unternehmens (Schulden/Fremdkapital, nicht realisierte Verluste, Lieferantenverbindlichkeiten, nicht realisierte Verluste aus Finanzanlagen)

| Aktiva         | Passiva         |
| Anlagevermögen | Eigenkapital    |
|  Maschinen     |   Gewinnvorv.   |
|  Autos         |   Stammkapital  |
|  Computer      |   Sacheinlage   |
|                |   Gewinn        |
| Umlaufvermögen | Fremdkapital    |
|  Lager         |   Lieferantenverbindlichkeiten |
|  Forderungen   |   Bankkredit    |
|  Bank          |                 |

Gruppen in der Gliederung der Bilanz entsprechen Konten, auf denen
in der doppelten Buchführung Buchungen durchgeführt werden. Für Firmen
eine Struktur üblich, aber die ist nicht zwingend.

Prinzip der doppelten Buchhaltung:

Geschäftsvorfälle generieren Buchungen - ein Fluss zwischen Aktiva und
Passiva, muss also auf 2 Konten verbucht werden. Auf einem wirds mehr,
auf einem weniger.

Beispiel Firmeneröffnung:

Einzahlung Stammkapital auf der Bank von 5000 EUR.
+5000 EUR auf Konto "Bank" (Aktiva)
-5000 EUR auf Konto "Stammkapital" (Passiva)

Beispiel Einbringen Laptop:

+300 EUR Wert Laptop auf Konto "Computer" (Aktiva)
-300 EUR auf Konto "Sacheinlage" (Passiva)

Beispiel Bankkredit:

+10000 EUR auf Konto "Bank" (Aktiva)
-10000 EUR auf Konto "Fremdkapital" (Passiva)

Beispiel Kundenzahlung, Fakturierung:

+800 EUR auf Konto "Forderung" (Aktiva)
-800 EUR auf Konto "Gewinn" (Passiva)

Beispiel Anschaffung Laptop

(1)
+500 EUR auf Konto "Computer"
-500 EUR auf Konto "Lieferantenverbindlichkeiten"
(2)
+500 EUR auf Konto "Lieferantenverbindlichkeiten"
-500 EUR auf Konto "Bank"

Beispiel Abschreibung:

-30 EUR auf Konto "Maschinen"
+30 EUR auf Konto "Gewinn"

GuV

| Aufwände    | Erlöse         |
| 30 auf AfA  | -30 auf Gewinn |

Konto Gewinn wird wegen Wichtigkeit noch in GuV (Gewinn- und Verlustrechnung)
aufgeteilt:

| Aufwände                        | Erträge                      |
| Gehalt an Programmierer         | Erlöse aus Programmierarbeit |

Sinnfrage der doppelten Buchhaltung:

Nicht bloß Kontrolle, sondern unterschiedliche Sichtweise auf Geldflüsse
zur besseren Übersicht.

Diskussion über Übersichtlichkeit und welchen Nutzen das für ein Unternehmen hat.
Firmen haben viel mehr Zahlungen und Geschäftsvorfälle als man einfach überblicken
kann, die doppelte Buchführung ist ein Instrument um Gefahren bei ausstehenden Zahlungen
und evtl. fehlender Deckung (Cashflow) aufzuzeigen.


## Ledger CLI

Ledger führt ein Text-Journal, das Buchungen dieser Gestalt auflistet:

Buchhalter führen Konten als Nummern, hier aber als Text

```bash
λ › ledger -f sample.dat accounts
Aktiva:Anlagevermögen:Laptop
Aktiva:Umlaufvermögen:Bank
GuV:Aufwand:AfA
λ › cat sample.dat
2023-09-22 Kauf Laptop
  Aktiva:Anlagevermögen:Laptop  500
  Aktiva:Umlaufvermögen:Bank  -500

2023-09-23 Laptop verloren
  Aktiva:Anlagevermögen:Laptop  -200
  GuV:Aufwand:AfA  200
λ › ledger -f sample.dat bal
                -200  Aktiva
                 300    Anlagevermögen:Laptop
                -500    Umlaufvermögen:Bank
                 200  GuV:Aufwand:AfA
--------------------
                   0
λ › vim sample.dat
λ › ledger -f sample.dat bal
While parsing file "/home/fuero/norbert_ledger/sample.dat", line 11:
While balancing transaction from "/home/fuero/norbert_ledger/sample.dat", lines 9-11:
> 2023-09-23 Übertragung in Passiva - Forderung!
>   Aktiva:Umlaufvermögen:Bank  500
>   Passiva:Verbindlichkeiten:Bank  500
Unbalanced remainder is:
                1000
Amount to balance against:
                1000
Error: Transaction does not balance
λ › vim sample.dat
λ › ledger -f sample.dat bal
                 300  Aktiva:Anlagevermögen:Laptop
                 200  GuV:Aufwand:AfA
                -500  Passiva:Verbindlichkeiten:Bank
--------------------
                   0
λ › ledger -f sample.dat reg
23-Sep-22 Kauf Laptop         Ak:Anlagevermög:Laptop         500         500
                              Akt:Umlaufvermöge:Bank        -500           0
23-Sep-23 Laptop verloren     Ak:Anlagevermög:Laptop        -200        -200
                              GuV:Aufwand:AfA                200           0
23-Sep-23 Übertragung in Pa.. Akt:Umlaufvermöge:Bank         500         500
                              Pa:Verbindlichkei:Bank        -500           0
λ › ledger -f sample.dat reg ".*vermö.*"
23-Sep-22 Kauf Laptop         Ak:Anlagevermög:Laptop         500         500
                              Akt:Umlaufvermöge:Bank        -500           0
23-Sep-23 Laptop verloren     Ak:Anlagevermög:Laptop        -200        -200
23-Sep-23 Übertragung in Pa.. Akt:Umlaufvermöge:Bank         500         300
```

```
2023-09-22 Kauf Laptop
  Aktiva:Anlagevermögen:Laptop  500
  Aktiva:Umlaufvermögen:Bank  -500

2023-09-23 Laptop verloren
  Aktiva:Anlagevermögen:Laptop  -200
  GuV:Aufwand:AfA  200

2023-09-23 Übertragung in Passiva - Forderung!
  Aktiva:Umlaufvermögen:Bank  500
  Passiva:Verbindlichkeiten:Bank  -500
```

## Linksammlung

Plain text accounting community: https://plaintextaccounting.org/
HLedger: https://hledger.org/
Ledger (hier verwendetes Tool): https://ledger-cli.org
