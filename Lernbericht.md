# Lern-Bericht
Blentin Tosuni

## Einleitung

Ich habe beim Lernatelier einen Number Guesser programmiert.

## Was habe ich gelernt?

Ich habe gelernt, wie man eine try-catch Schleife anwendet und wozu man sie braucht.

## Beschreibung

Eine Try-Catch Schleife ist an erster Stelle dafür gedacht, dass das Programm bei Fehleingaben nicht direkt abstürzt. Ich wollte, dass mein Programm auch nicht einfach abstürzt und habe diese Schleife angewendet. Als erstes muss man wissen, wann die Schleife genau eingesetzt werden sollte. Ich habe es gemerkt, als man Buchstaben eingegeben hat und das Programm abgestürzt ist. Der zweite Schritt ist auch sehr wichtig. Man muss wissen, was das Problem ist und was man in die Schleife einsetzen sollte. Ich wollte an erster Stelle, dass wenn man keine Zahl eingeben sollte, eine Meldung kommt: ```"Ich habe das nicht richtig verstanden."``` Dafür muss man beim try programmieren, was das Programm versuchen sollte. Beim catch sollte man programmieren, was das Programm ausgeben sollte, falls das Programm das Verlangte bei try nicht umsetzen kann. 

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
```

Hier noch ein Bild von der Eingabe und Ausgabe: 
![Console](https://user-images.githubusercontent.com/111045987/191703425-aea984f5-9e86-4883-b990-667cda309a33.png)

## Verifikation

Wie die Medien meinen Lernprozess aufzeigen: 

Text: Beim Text kann man lesen, welche Schritte für eine Try-Catch Schlaufe benötigt werden und wozu man diese Schlaufe braucht.

Code: Der Code zeigt auf, wie die Schlaufe programmiert ist und welcher Code für welche Funktion zuständig ist.

Bild: Das Bild zeigt nochmal, dass mein Ziel, wenn man keine Zahlen eingibt eine Meldung erscheint, funktioniert.

# Reflexion zum Arbeitsprozess

Was lief gut?

Ich war konzentriert und habe nicht aufgegeben wenn Mal etwas nicht ging.

Was lief nicht so gut?

Ich habe die Zeit nicht gut geplant, also wie lange ein Auftrag geht.

**VBV**: Das nächste Mal muss ich die Zeit besser planen und frühzeitig herausfinden, was ich bis am Schluss noch hinbekomme. Falls ich unnötigere Dinge geplant habe diese lieber weglassen und das wichtigste machen.
