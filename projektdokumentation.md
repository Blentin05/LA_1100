# LA_1100

# Projekt-Dokumentation



Blentin Tosuni

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 01.09.2022 | 001 | Ich habe programmiert, dass eine Zahl generiert wird und habe programmiert, dass man eine Zahl eingeben kann.|
|  01.09.2022  |  002  |Man bekommt einen Hinweis, ob die Zahl grösser, kleiner oder gleich gross ist.                                                        |
|  01.09.2022      | 003  |Man sieht nun wieviel mal man geratten hat.                                                              |
|  08.09.2022      | 004 |Mein Programm kann noch nicht mit Fehlangaben umgehen.                                                            |
|  15.09.2022      | 005 |Mein Programm kann noch nicht mit Fehlangaben umgehen.(Ziel nicht geschafft)                                                            |
## 1 Informieren

### 1.1 Random number generator

Ich erstelle ein Random Number game.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss                | funktional    | Als User möchte ich eine Zahl erraten können. Damit ich eine Zahl erraten kann, muss eine Zahl generiert werden.  |      | muss                | funktional    | Als User möchte ich eine Zahl erraten.               
| 2     | kann                | funktional    |  Als User möchte ich einen Hinweis, wenn die geratene Zahl grösser und niedriger als die generierte Zahl ist oder gleich. 
| 3     | kann              | funktional       | Als User möchte ich die Anzahl Rateversuche sehen, nachdem die Geheimzahl erraten wurde.                
| 4     | muss                  | funktional     | Als User möchte ich, dass das Program mit Fehlangaben umgeht oder Sie vermeidet 
| 5     | kann                  |  qualität   | Als User möchte ich, dass die falsche Zahl soll rot angezeigt wird.   
| 6     | kann                  |  qualität   | Als User möchte ich, dass die Seite mit dem Generator schön ist.
| 7     | kann                  |  funktional | Als User möchte ich, dass wenn die Rateversuche angezeigt werden, die Zahlen grün markiert sein sollten, die eine gerringere Distanz als 20 zu der Zahl haben.


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Zahl wird generiert. | Eingabe einer Zahl        | Ausgabe einer Zahl                  |
| 2.1 | Eingegebene Zahl wird überprüft |        |  Ausgabe, ob kleiner, grösser oder gleich                 |
| 3.1  |Zahl wird erraten |50(x)        |Anzahl Versuche (y)                 |
| 4.1  | Programm wird gestartet  |Text|Keine Zahl    
| 5.1  |Zahl eingegeben | Zahl  |Rote Zahl|50(x)        
| 6.1  |Programm startet |---       |Schöne Seite              |
| 7.1  |Ratversuche werden gezählt |Zahl       |Grün markierte Zahlen die eine Distanz von max 20 zu der generierten Zahl haben.                 |

      
### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111045987/186598625-753a8022-d7d3-4d82-92c9-028f78314c37.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |01.09.2022| Blentin Tosuni | US 1,2 | 135 min       |
| 2.A  |08.09.2022| Blentin Tosuni | US 3 | 135 min        |
| 3.A  |08.09.2022| Blentin Tosuni | US 4 | 135 min        |
| 4.A  |15.09.2022| Blentin Tosuni | US 5 | 45 min         |
| 5.A  |15.09.2022| Blentin Tosuni | US 6 | 90 min         |
| 6.A  |15.09.2022| Blentin Tosuni | US 7 | 90 min         |

Total: 630 min (Zeit total verschätzt, hätte viel länger gebraucht).



## 3 Entscheiden



## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 1.09.22      |  Blentin Tosuni         | 150 min                |
| 2.A  | 1.09.22      |  Blentin Tosuni         | 150 min                |
|3.A   | 8.09.22      |Blentin Tosuni           | Ca. 150 min                 |
|3.A   | 15.09.22      |Blentin Tosuni           | Ca. 150 min                 |

Ich habe länger gebraucht als gedacht und hatte viele Probleme. Meine Klassenkameraden haben mir manchmal geholfen, aber hatte viel Mühe.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 22.09.2022      | funktioniert teilweise        | Blentin Tosuni       |
| 2.1 | 22.09.2022      |   funktioniert nicht       |Blentin Tosuni        |
| 3.1 | 22.09.2022      |   funktioniert nicht       |Blentin Tosuni        |
| 4.1 | 22.09.2022      |   funktioniert nicht       |Blentin Tosuni        |
| 5.1 | 22.09.2022      |   funktioniert nicht       |Blentin Tosuni        |
| 6.1 | 22.09.2022      |   funktioniert nicht       |Blentin Tosuni        |

Wegen dem Ende, also bei Fehleranzeigen musste ich Schlaufen anwenden, die das ganze Programm beeinflussten. Bevor ich probiert habe Schleifen zu programmieren, funktionierten die ersten Ziele, also das Programm funktionierte gut und zeigte an wenn Zahlen grösser, kleiner oder gleich gross waren, als die zufällige Zahl. Als ich jedoch versuchte Fehlermeldungen zu programmieren ging nichts mehr. Alles hing also mit dem letzten Ziel zusammen, das ich versuchte zu realisieren. Den Rest habe ich nicht geschafft, weil ich mich verschätzt habe, bezüglich der Zeit und viel Zeit bei der letzteren Realisierung investiert habe.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |



## 6 Auswerten
https://github.com/Blentin05/LA_1100/blob/main/Lernbericht.md
