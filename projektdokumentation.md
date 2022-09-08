# LA_1100

# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Blentin Tosuni

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 01.09.2022 | 1.  | Ich habe programmiert, dass eine Zahl generiert wird und habe programmiert, dass man eine Zahl eingeben kann.|
|  01.09.2022  |  2.  |Man bekommt einen Hinweis, ob die Zahl grösser, kleiner oder gleich gross ist.                                                        |
|  01.09.2022      | 3.  |Man sieht nun wieviel mal man geratten hat.                                                              |
|  01.09.2022      | 4. |Mein Programm kann nun mit Fehlangaben umgehen(zB. Buchstaben)                                                              |
## 1 Informieren

### 1.1 Random number generator

Ich erstelle ein Random Number game.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | muss                | funktional    | Als User möchte ich eine Zahl erraten können. Damit ich eine Zahl erraten kann, muss eine Zahl generiert werden.  |      | muss                | funktional    | Als User möchte ich eine Zahl erraten.               
| 2     | kann                | funktional    |  Als User möchte ich einen Hinweis, wenn die geratene Zahl grösser und niedriger als die generierte Zahl ist oder gleich. 
| 3     | kann              | funktional       | Als User möchte ich die Anzahl Rateversuche sehen, nachdem die Geheimzahl erraten wurde.                
| 4     | muss                  | funktional     | Ich möchte, dass das Program mit Fehlangaben umgeht oder Sie vermeidet 
| 5     | kann                  |  qualität   | Das falsche Zahl soll rot angezeigt werden.   
| 6     | kann                  |  qualität   | Die Seite mit dem Generator soll schön sein.
| 7     | kann                  |  funktional | Wenn die Rateversuche angezeigt werden, sollten die Zahlen grün markiert sein, die eine gerringere Distanz als 20 zu der Zahl haben


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Zahl wird generiert. | Eingabe einer Zahl        | Ausgabe einer Zahl                  |
| ...  | Eingegebene Zahl wird überprüft |        |  Ausgabe, ob kleiner, grösser oder gleich                 |
| ...  |Zahl wird erraten |50(x)        |Anzahl Versuche (y)                 |
| ...  | Programm wird gestartet  |Text|Keine Zahl    
| ...  |Zahl eingegeben | Zahl  |Rote Zahl|50(x)        
| ...  |Programm startet |---       |Schöne Seite              |
| ...  |Ratversuche werden gezählt |Zahl       |Grün markierte Zahlen die eine Distanz von max 20 zu der generierten Zahl haben.                 |

      
### 1.4 Diagramme

![image](https://user-images.githubusercontent.com/111045987/186598625-753a8022-d7d3-4d82-92c9-028f78314c37.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A |1.09.2022| Blentin Tosuni | US 1,2 | 135 min       |
| 2.A  |8.09.2022| Blentin Tosuni | US 3 | 135 min        |
| 3.A  |08.09.2022| Blentin Tosuni | US 4 | 135 min        |
| 4.A  |15.09.2022| Blentin Tosuni | US 5 | 45 min         |
| 5.A  |15.09.2022| Blentin Tosuni | US 6 | 90 min         |
| 6.A  |15.09.2022| Blentin Tosuni | US 7 | 90 min         |

Total: 



## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A und 2.A  | 1.09.22      |  Blentin Tosuni         | 135 min              | Ca. 120 min                  |
|3.A   | 1.09.22      |Blentin Tosuni           |135 min               | Ca. 150 min                 |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
