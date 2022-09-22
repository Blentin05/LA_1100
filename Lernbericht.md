# Lern-Bericht
Blentin Tosuni

## Einleitung

Ich habe beim Lernatelier einen number guesser programmiert.

## Was habe ich gelernt?

Ich habe gelernt, wie man eine try-catch Schleife anwendet und wozu man sie braucht.

## Beschreibung

✍️ Verwenden Sie drei verschiedene Medien, um zu zeigen, was Sie gelernt haben. Zum Beispiel:

Eine try-catch Schleife ist an erster Stelle dafür da, damit das Programm bei Fehleingaben nicht direkt abstürzt. Ich wollte, dass mein Programm auch nicht einfach abstürzt und habe diese Schleife angewendet. Als erstes muss man wissen, wann die Schleife genau eingesetzt werden sollte. Ich habe es gemerkt, als man Buchstaben eingegeben hat und das Programm abgestürzt ist. Der zweite Schritt ist auch sehr wichtig. Man muss wissen, was das Problem ist und was man in die Schleife einsetzt. Ich wollte an erster Stelle, dass wenn man Buchstaben eingeben sollte, eine Meldung kommt: ```"Ich habe das nicht richtig verstanden."``` Dafür muss man beim try programmieren, was das Programm versuchen sollte. Beim catch sollte man programmieren, was das Programm ausgeben sollte, falls das Programm das Verlangte bei try nicht umsetzen kann. 

Dieser Code wird es nochmal klarer zeigen:

```Csharp

            try
            {
                Convert.ToInt32(Console.ReadLine());    // Es wird versucht, die Eingabe in einem Int zu convertieren. Int = Zahl. Das Programm liest die Eingabe ein.
            }

            catch
            {
                Console.WriteLine("Ich habe das nicht richtig verstanden.");  // Wenn man etwas anderes als eine Zahl eingibt, erscheint die Meldung: "Ich habe das nicht richtig verstanden."
            }

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflexion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.
