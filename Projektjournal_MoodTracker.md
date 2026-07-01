# Projektjournal – MoodTracker App

## 1. Projektdaten

| Punkt | Inhalt |
|---|---|
| **Projektname** | MoodTracker |
| **Thema** | Android App Entwicklung |
| **Fachbereich** | API |
| **Technologie** | C# mit .NET MAUI |
| **Entwicklungsumgebung** | Visual Studio 2022, Englisch |
| **Zielplattform** | Android |
| **Repository** | [GitHub-Link einfügen] |
| **Ablage** | GitHub und SharePoint |
| **Projektstart** | [Datum einfügen] |
| **Abgabetermin / Zwischenpräsentation** | 08.07.2026 |
| **Projektverantwortliche Person** | Yané Bonne Ramos |
| **Betreuung / FW-Leitung** | [Name einfügen] |

---

## 2. Ausgangslage

In Camps, Freizeitangeboten oder sozialen Einrichtungen nehmen Personen an verschiedenen Aktivitäten wie Sportkursen, Tanzkursen, Bastelkursen oder Workshops teil. Rückmeldungen zu diesen Angeboten werden häufig nur mündlich oder unregelmässig abgegeben.

Mit der MoodTracker-App soll eine einfache Möglichkeit geschaffen werden, nach einem Angebot eine kurze Rückmeldung zu erfassen. Die Benutzerin oder der Benutzer wählt ein Angebot sowie eine Stimmung aus und kann optional eine Notiz hinzufügen. Die Rückmeldungen werden gespeichert und in einer Liste angezeigt.

Die App wird mit C# und .NET MAUI umgesetzt. Zur bewussten Vereinfachung wird auf das MVVM-Pattern verzichtet. Das Data Binding erfolgt direkt oder über Code-Behind.

---

## 3. Projektziel

Ziel ist es, eine funktionsfähige Android-App zu entwickeln, mit der Rückmeldungen zu Angeboten erfasst, gespeichert und später wieder angezeigt werden können.

### Muss-Ziele

- [ ] Ein Angebot kann ausgewählt werden.
- [ ] Eine Stimmung kann ausgewählt werden.
- [ ] Eine optionale Notiz kann eingegeben werden.
- [ ] Ein Eintrag kann gespeichert werden.
- [ ] Alle bisherigen Einträge werden in einer Liste angezeigt.
- [ ] Die App läuft im Android Emulator.
- [ ] Der Quellcode ist im GitHub-Repository gespeichert.
- [ ] Die App entspricht den vorgegebenen C#-Codier-Richtlinien.
- [ ] Die App verwendet .NET MAUI und kein MAUI Blazor.
- [ ] Es wird kein ViewModel verwendet.
- [ ] Die Architektur ist bewusst auf zwei Schichten vereinfacht.

### Kann-Ziele

- [ ] Einträge können gelöscht werden.
- [ ] Einträge können bearbeitet werden.
- [ ] Eine einfache Statistikseite wird angezeigt.
- [ ] Die Kursliste kann erweitert werden.
- [ ] Die Kursliste unterstützt CRUD.
- [ ] Die App funktioniert im Portrait- und Landscape-Modus.
- [ ] Das Design kann angepasst werden.
- [ ] Eine externe API wird angebunden.
- [ ] Eine tägliche Erinnerung wird implementiert.
- [ ] Eine Datenverarbeitungszustimmung wird angezeigt.
- [ ] Eine Benutzeranmeldung wird implementiert.
- [ ] Ein biometrischer Login wird implementiert.
- [ ] Eine Sponsor- oder Informationsseite wird ergänzt.

---

## 4. Geplanter Funktionsumfang

### Version 1 – Minimal funktionsfähig

- Angebot auswählen
- Stimmung auswählen
- optionale Notiz eingeben
- Eintrag speichern
- Einträge anzeigen

### Version 2 – Verbesserte App

- Einträge löschen
- Formular validieren
- Bestätigung nach dem Speichern
- übersichtlicheres Design
- Navigation zwischen mehreren Seiten

### Version 3 – Erweiterungen

- Statistikseite
- Kursverwaltung mit CRUD
- Filter nach Kurs oder Stimmung
- externe API
- Erinnerungsfunktion
- Login oder biometrische Sicherung

---

## 5. Verwendete Technologien und Werkzeuge

| Werkzeug / Technologie | Zweck |
|---|---|
| Visual Studio 2022 | Entwicklung der App |
| C# | Programmiersprache |
| .NET MAUI | Framework für die App |
| XAML | Gestaltung der Benutzeroberfläche |
| Android Emulator | Testen der App |
| Git | Versionsverwaltung |
| GitHub | Speicherung des Repositories |
| SharePoint | zusätzliche Ablage |
| Figma / Papier | Mockup und Planung |
| Markdown | Projektjournal und Dokumentation |

---

## 6. Geplante Datenstruktur

### Klasse `MoodEntry`

| Attribut | Datentyp | Beschreibung |
|---|---|---|
| `Id` | int | eindeutige ID |
| `CourseName` | string | Name des ausgewählten Angebots |
| `Mood` | string | ausgewählte Stimmung |
| `Note` | string | optionale Notiz |
| `CreatedAt` | DateTime | Datum und Uhrzeit des Eintrags |

### Optionale Klasse `Course`

| Attribut | Datentyp | Beschreibung |
|---|---|---|
| `Id` | int | eindeutige ID |
| `Name` | string | Name des Angebots |
| `Category` | string | Kategorie des Angebots |
| `Description` | string | optionale Beschreibung |

---

## 7. Projektphasen und Arbeitsschritte

# Phase 1 – Setup und Initialisierung

## Entwicklungsumgebung

- [ ] Visual Studio 2022 installiert
- [ ] Oberfläche auf Englisch eingestellt
- [ ] .NET MAUI Workload installiert
- [ ] Android SDK installiert
- [ ] Android Emulator eingerichtet
- [ ] Testgerät im Emulator erstellt
- [ ] Git installiert und eingerichtet
- [ ] GitHub-Zugang geprüft

## HelloWorldMAUI

- [ ] Neues .NET-MAUI-Projekt erstellt
- [ ] Projektname `HelloWorldMAUI` gewählt
- [ ] Standard-App ohne Fehler gestartet
- [ ] App im Android Emulator ausgeführt
- [ ] Text oder Button testweise angepasst
- [ ] Änderungen erneut im Emulator getestet
- [ ] Git-Repository initialisiert
- [ ] Ersten Commit erstellt
- [ ] Repository auf GitHub hochgeladen
- [ ] GitHub-Link im Projektjournal ergänzt

## Meilenstein 1

- [ ] Hello-World-App einer FW-Leitung gezeigt
- [ ] Rückmeldung erhalten
- [ ] „Go“ zum Weiterarbeiten erhalten

**Datum:** [einfügen]  
**Rückmeldung der FW-Leitung:**  
[Notizen einfügen]

---

# Phase 2 – Planung

## Anforderungen analysieren

- [ ] Projektauftrag vollständig gelesen
- [ ] Muss-Funktionen markiert
- [ ] Kann-Funktionen priorisiert
- [ ] technische Einschränkungen notiert
- [ ] Verzicht auf MVVM berücksichtigt
- [ ] Zwei-Schichten-Architektur berücksichtigt
- [ ] Speicherlösung ausgewählt
- [ ] Navigation der App geplant

## Design und Aufbau

- [ ] Name und Stil der App festgelegt
- [ ] Farbkonzept festgelegt
- [ ] Schriftarten und Grössen definiert
- [ ] Mockup der Startseite erstellt
- [ ] Mockup des Eingabeformulars erstellt
- [ ] Mockup der Listenansicht erstellt
- [ ] optionales Mockup der Statistikseite erstellt
- [ ] Portrait-Ansicht berücksichtigt
- [ ] Landscape-Ansicht berücksichtigt

## Daten und Klassen

- [ ] Datenmodell `MoodEntry` geplant
- [ ] Attribute und Datentypen definiert
- [ ] Kursliste vorbereitet
- [ ] Speicherung geplant
- [ ] optionales UML-Klassendiagramm erstellt
- [ ] Validierungsregeln definiert

## Validierungsregeln

- [ ] Angebot ist Pflichtfeld
- [ ] Stimmung ist Pflichtfeld
- [ ] Notiz ist optional
- [ ] Notiz hat eine sinnvolle Maximallänge
- [ ] Fehlermeldungen sind verständlich
- [ ] Nach erfolgreichem Speichern wird das Formular geleert

## Meilenstein 2

- [ ] Planung einer FW-Leitung vorgestellt
- [ ] Mockup gezeigt
- [ ] Datenstruktur erklärt
- [ ] Rückmeldung dokumentiert
- [ ] „Go“ zur Umsetzung erhalten

**Datum:** [einfügen]  
**Rückmeldung der FW-Leitung:**  
[Notizen einfügen]

---

# Phase 3 – Umsetzung

## Projektstruktur

- [ ] Neues Projekt `MoodTracker` erstellt
- [ ] Projekt im bestehenden Fachblock-Repository gespeichert
- [ ] sinnvolle Ordnerstruktur erstellt
- [ ] Modelle angelegt
- [ ] Seiten angelegt
- [ ] Code-Behind-Dateien vorbereitet
- [ ] Navigation eingerichtet

## Benutzeroberfläche

- [ ] Titel und App-Name eingefügt
- [ ] Auswahlfeld für Angebote erstellt
- [ ] Stimmungsauswahl erstellt
- [ ] Textfeld für Notiz erstellt
- [ ] Speichern-Button erstellt
- [ ] Liste für bisherige Einträge erstellt
- [ ] leere Liste sinnvoll dargestellt
- [ ] Benutzeroberfläche im Emulator geprüft
- [ ] Abstände und Grössen verbessert
- [ ] Lesbarkeit geprüft

## Logik

- [ ] Kursliste im Code bereitgestellt
- [ ] Angebot kann ausgewählt werden
- [ ] Stimmung kann ausgewählt werden
- [ ] Notiz kann eingegeben werden
- [ ] Eingaben werden validiert
- [ ] Eintrag wird erzeugt
- [ ] Datum und Uhrzeit werden automatisch ergänzt
- [ ] Eintrag wird gespeichert
- [ ] Liste wird nach dem Speichern aktualisiert
- [ ] Formular wird nach dem Speichern zurückgesetzt
- [ ] Erfolgsmeldung wird angezeigt

## Speicherung

- [ ] Speicherart festgelegt
- [ ] Daten werden beim Schliessen der App nicht unbeabsichtigt verloren
- [ ] gespeicherte Daten werden beim Start geladen
- [ ] Fehler beim Speichern werden behandelt
- [ ] Fehler beim Laden werden behandelt

## Liste und Einträge

- [ ] Angebot wird angezeigt
- [ ] Stimmung wird angezeigt
- [ ] Notiz wird angezeigt
- [ ] Datum und Uhrzeit werden angezeigt
- [ ] Einträge werden sinnvoll sortiert
- [ ] lange Notizen werden korrekt dargestellt
- [ ] leere Notizen werden sinnvoll behandelt

## Optionale Erweiterungen

- [ ] Eintrag löschen
- [ ] Löschen bestätigen lassen
- [ ] Eintrag bearbeiten
- [ ] nach Angebot filtern
- [ ] nach Stimmung filtern
- [ ] Statistikseite erstellen
- [ ] Anzahl Einträge pro Stimmung anzeigen
- [ ] häufigstes Angebot anzeigen
- [ ] Kursverwaltung erstellen
- [ ] Kurs hinzufügen
- [ ] Kurs bearbeiten
- [ ] Kurs löschen
- [ ] externe API anbinden
- [ ] Erinnerungsfunktion ergänzen
- [ ] Sponsorenseite ergänzen
- [ ] Datenschutzseite ergänzen
- [ ] Login ergänzen
- [ ] biometrische Sicherung ergänzen

## Qualität und Code

- [ ] sprechende Variablennamen verwendet
- [ ] sprechende Methodennamen verwendet
- [ ] Methoden nicht unnötig lang
- [ ] wiederholter Code reduziert
- [ ] Kommentare nur dort eingesetzt, wo nötig
- [ ] Formatierung einheitlich
- [ ] ITS-Codier-Richtlinien geprüft
- [ ] keine unnötigen Klassen erstellt
- [ ] kein ViewModel verwendet
- [ ] kein `StaticResource` für Data Binding verwendet
- [ ] Fehler und Warnungen in Visual Studio geprüft

## Git und Versionsverwaltung

- [ ] nach Projektstart committed
- [ ] nach fertigem Grundlayout committed
- [ ] nach fertiger Eingabelogik committed
- [ ] nach fertiger Speicherung committed
- [ ] nach fertiger Listenansicht committed
- [ ] nach Bugfixes committed
- [ ] vor Meilenstein 3 committed
- [ ] verständliche Commit-Nachrichten verwendet
- [ ] Änderungen regelmässig auf GitHub gepusht
- [ ] Repository aufgeräumt
- [ ] unnötige Dateien nicht mitcommitted
- [ ] `.gitignore` geprüft

## Meilenstein 3

- [ ] funktionsfähige Version erstellt
- [ ] App startet ohne Fehler
- [ ] Kernfunktionen funktionieren
- [ ] App im Android Emulator getestet
- [ ] Zwischenpräsentation vorbereitet
- [ ] Zwischenpräsentation im IT-Labor durchgeführt
- [ ] Stand spätestens am 08.07.2026 erreicht

**Datum:** [einfügen]  
**Rückmeldung:**  
[Notizen einfügen]

---

# Phase 4 – Testen und technische Reflexion

## Testplanung

- [ ] Testszenarien erstellt
- [ ] erwartete Resultate definiert
- [ ] Tests durchgeführt
- [ ] tatsächliche Resultate dokumentiert
- [ ] Fehler korrigiert
- [ ] Tests nach Korrekturen wiederholt

## Testprotokoll

| Test-ID | Testfall | Voraussetzung | Testschritte | Erwartetes Ergebnis | Tatsächliches Ergebnis | Status |
|---|---|---|---|---|---|---|
| T01 | App starten | App installiert | App öffnen | App startet ohne Fehler | [einfügen] | ☐ |
| T02 | Angebot auswählen | App geöffnet | Angebot auswählen | Auswahl wird übernommen | [einfügen] | ☐ |
| T03 | Stimmung auswählen | App geöffnet | Stimmung auswählen | Auswahl wird übernommen | [einfügen] | ☐ |
| T04 | Eintrag speichern | Angebot und Stimmung gewählt | Speichern drücken | Eintrag wird gespeichert | [einfügen] | ☐ |
| T05 | Pflichtfeld Angebot | kein Angebot gewählt | Speichern drücken | verständliche Fehlermeldung | [einfügen] | ☐ |
| T06 | Pflichtfeld Stimmung | keine Stimmung gewählt | Speichern drücken | verständliche Fehlermeldung | [einfügen] | ☐ |
| T07 | Notiz leer lassen | Angebot und Stimmung gewählt | ohne Notiz speichern | Eintrag wird gespeichert | [einfügen] | ☐ |
| T08 | Einträge anzeigen | Eintrag vorhanden | Listenansicht öffnen | Eintrag wird angezeigt | [einfügen] | ☐ |
| T09 | App neu starten | Eintrag gespeichert | App schliessen und öffnen | Eintrag bleibt erhalten | [einfügen] | ☐ |
| T10 | lange Notiz | App geöffnet | lange Notiz speichern | Darstellung bleibt lesbar | [einfügen] | ☐ |
| T11 | Landscape-Modus | App geöffnet | Gerät drehen | Layout bleibt verwendbar | [einfügen] | ☐ |
| T12 | Eintrag löschen | Eintrag vorhanden | Löschen ausführen | Eintrag wird entfernt | [einfügen] | ☐ |

---

## 8. Laufendes Arbeitsjournal

Für jeden Arbeitstag oder grösseren Arbeitsschritt wird ein Eintrag erstellt.

### Vorlage

## Journal-Eintrag [Nummer]

**Datum:**  
**Arbeitszeit:**  
**Bearbeitete Phase:**  
**Ziel des Tages:**  

### Erledigte Arbeiten

- [ ] 
- [ ] 
- [ ] 

### Verwendete Dateien / Klassen

- 

### Git-Commit(s)

- Commit-ID oder Nachricht: 

### Probleme / Herausforderungen

- 

### Lösungsweg

- 

### Ergebnis

- 

### Offene Punkte

- [ ] 
- [ ] 

### Nächster Schritt

- 

---

## Journal-Eintrag 1

**Datum:** [einfügen]  
**Arbeitszeit:** [einfügen]  
**Bearbeitete Phase:** Setup und Initialisierung  
**Ziel des Tages:** Entwicklungsumgebung einrichten und Hello-World-App starten.

### Erledigte Arbeiten

- [ ] Visual Studio geprüft
- [ ] .NET-MAUI-Komponenten installiert
- [ ] Android Emulator eingerichtet
- [ ] Hello-World-Projekt erstellt
- [ ] App im Emulator gestartet
- [ ] Repository erstellt
- [ ] erster Commit erstellt

### Verwendete Dateien / Klassen

- `MainPage.xaml`
- `MainPage.xaml.cs`
- `App.xaml`
- `AppShell.xaml`

### Git-Commit(s)

- `Initial project setup`
- [weitere einfügen]

### Probleme / Herausforderungen

- [einfügen]

### Lösungsweg

- [einfügen]

### Ergebnis

- [einfügen]

### Offene Punkte

- [ ] Meilenstein 1 zeigen
- [ ] Rückmeldung dokumentieren

### Nächster Schritt

- Planung und Mockup erstellen.

---

## Journal-Eintrag 2

**Datum:** [einfügen]  
**Arbeitszeit:** [einfügen]  
**Bearbeitete Phase:** Planung  
**Ziel des Tages:** Aufbau, Design und Datenstruktur der App planen.

### Erledigte Arbeiten

- [ ] Anforderungen analysiert
- [ ] Muss- und Kann-Ziele festgelegt
- [ ] Mockup erstellt
- [ ] Datenmodell geplant
- [ ] Validierungen definiert
- [ ] Seitenstruktur geplant

### Verwendete Dateien / Werkzeuge

- Figma / Papier
- Projektauftrag
- Markdown-Projektjournal

### Git-Commit(s)

- [einfügen]

### Probleme / Herausforderungen

- [einfügen]

### Lösungsweg

- [einfügen]

### Ergebnis

- [einfügen]

### Offene Punkte

- [ ] Meilenstein 2 zeigen
- [ ] Rückmeldung einarbeiten

### Nächster Schritt

- MoodTracker-Projekt erstellen und Grundlayout umsetzen.

---

## Journal-Eintrag 3

**Datum:** [einfügen]  
**Arbeitszeit:** [einfügen]  
**Bearbeitete Phase:** Umsetzung  
**Ziel des Tages:** Eingabeformular und Datenmodell erstellen.

### Erledigte Arbeiten

- [ ] Projekt `MoodTracker` erstellt
- [ ] Klasse `MoodEntry` erstellt
- [ ] Kursauswahl erstellt
- [ ] Stimmungsauswahl erstellt
- [ ] Notizfeld erstellt
- [ ] Speichern-Button erstellt

### Verwendete Dateien / Klassen

- `MoodEntry.cs`
- `MainPage.xaml`
- `MainPage.xaml.cs`

### Git-Commit(s)

- [einfügen]

### Probleme / Herausforderungen

- [einfügen]

### Lösungsweg

- [einfügen]

### Ergebnis

- [einfügen]

### Offene Punkte

- [ ] Validierung ergänzen
- [ ] Speicherung ergänzen
- [ ] Liste erstellen

### Nächster Schritt

- Speichern und Laden der Einträge umsetzen.

---

## Journal-Eintrag 4

**Datum:** [einfügen]  
**Arbeitszeit:** [einfügen]  
**Bearbeitete Phase:** Umsetzung  
**Ziel des Tages:** Einträge speichern und anzeigen.

### Erledigte Arbeiten

- [ ] Speicherlogik erstellt
- [ ] Einträge beim App-Start geladen
- [ ] Listenansicht erstellt
- [ ] Datum und Uhrzeit ergänzt
- [ ] Formular nach Speicherung zurückgesetzt
- [ ] Erfolgsmeldung ergänzt

### Verwendete Dateien / Klassen

- [einfügen]

### Git-Commit(s)

- [einfügen]

### Probleme / Herausforderungen

- [einfügen]

### Lösungsweg

- [einfügen]

### Ergebnis

- [einfügen]

### Offene Punkte

- [ ] Darstellung verbessern
- [ ] Tests durchführen

### Nächster Schritt

- App testen und Fehler beheben.

---

## Journal-Eintrag 5

**Datum:** [einfügen]  
**Arbeitszeit:** [einfügen]  
**Bearbeitete Phase:** Testen  
**Ziel des Tages:** Kernfunktionen testen und Fehler beheben.

### Erledigte Arbeiten

- [ ] Testfälle durchgeführt
- [ ] Fehler dokumentiert
- [ ] Fehler behoben
- [ ] App erneut getestet
- [ ] Landscape-Modus geprüft
- [ ] Meilenstein-3-Version erstellt

### Verwendete Dateien / Klassen

- [einfügen]

### Git-Commit(s)

- [einfügen]

### Probleme / Herausforderungen

- [einfügen]

### Lösungsweg

- [einfügen]

### Ergebnis

- [einfügen]

### Offene Punkte

- [ ] technische Reflexion schreiben
- [ ] Abschlusspräsentation erstellen

### Nächster Schritt

- Reflexion und Präsentation abschliessen.

---

## 9. Entscheidungsprotokoll

| Datum | Entscheidung | Begründung | Auswirkung |
|---|---|---|---|
| [Datum] | Drei Stimmungen verwenden | einfache Bedienung und schneller Entwicklungsstart | weniger komplexe Auswertung |
| [Datum] | Kein ViewModel verwenden | Vorgabe des Projektauftrags | Logik teilweise im Code-Behind |
| [Datum] | [Entscheidung] | [Begründung] | [Auswirkung] |

---

## 10. Problem- und Lösungsprotokoll

| Nr. | Datum | Problem | Ursache | Lösungsweg | Status |
|---|---|---|---|---|---|
| 1 | [Datum] | [Problem] | [Ursache] | [Lösung] | ☐ offen / ☐ gelöst |
| 2 | [Datum] | [Problem] | [Ursache] | [Lösung] | ☐ offen / ☐ gelöst |
| 3 | [Datum] | [Problem] | [Ursache] | [Lösung] | ☐ offen / ☐ gelöst |

---

## 11. Technische Herausforderungen

Mindestens drei Herausforderungen müssen beschrieben werden.

### Herausforderung 1

**Problem:**  
[Beschreibung]

**Ursache:**  
[Beschreibung]

**Lösungsweg:**  
[Beschreibung der einzelnen Schritte]

**Ergebnis:**  
[Beschreibung]

**Was habe ich gelernt?**  
[Beschreibung]

---

### Herausforderung 2

**Problem:**  
[Beschreibung]

**Ursache:**  
[Beschreibung]

**Lösungsweg:**  
[Beschreibung der einzelnen Schritte]

**Ergebnis:**  
[Beschreibung]

**Was habe ich gelernt?**  
[Beschreibung]

---

### Herausforderung 3

**Problem:**  
[Beschreibung]

**Ursache:**  
[Beschreibung]

**Lösungsweg:**  
[Beschreibung der einzelnen Schritte]

**Ergebnis:**  
[Beschreibung]

**Was habe ich gelernt?**  
[Beschreibung]

---

## 12. Präsentationsvorbereitung

- [ ] Ausgangslage erklären
- [ ] Ziel der App erklären
- [ ] wichtigste Funktionen zeigen
- [ ] App im Emulator demonstrieren
- [ ] Datenstruktur erklären
- [ ] Speicherlösung erklären
- [ ] Architektur erklären
- [ ] Verzicht auf MVVM erwähnen
- [ ] drei technische Herausforderungen vorstellen
- [ ] Lösungswege erklären
- [ ] Tests und Ergebnisse zeigen
- [ ] Erweiterungsmöglichkeiten nennen
- [ ] GitHub-Repository vorbereitet
- [ ] Demo-Daten vorbereitet
- [ ] Notfall-Screenshots erstellt
- [ ] Präsentation probeweise durchgeführt

---

## 13. Abschlusskontrolle

### Funktionalität

- [ ] App startet zuverlässig
- [ ] Angebot kann ausgewählt werden
- [ ] Stimmung kann ausgewählt werden
- [ ] Notiz kann eingegeben werden
- [ ] Eingaben werden validiert
- [ ] Einträge werden gespeichert
- [ ] Einträge werden angezeigt
- [ ] Daten bleiben nach Neustart erhalten
- [ ] keine bekannten kritischen Fehler vorhanden

### Code und Architektur

- [ ] C#-Codier-Richtlinien eingehalten
- [ ] Code verständlich strukturiert
- [ ] Zwei-Schichten-Architektur eingehalten
- [ ] kein ViewModel verwendet
- [ ] keine unnötigen Abhängigkeiten vorhanden
- [ ] Warnungen geprüft
- [ ] Kommentare geprüft

### Dokumentation

- [ ] Projektjournal vollständig
- [ ] Mockup enthalten
- [ ] Datenstruktur dokumentiert
- [ ] Testprotokoll ausgefüllt
- [ ] technische Herausforderungen beschrieben
- [ ] Lösungswege beschrieben
- [ ] Screenshots eingefügt
- [ ] GitHub-Link eingefügt
- [ ] Quellen angegeben

### Abgabe

- [ ] aktueller Stand auf GitHub
- [ ] aktueller Stand auf SharePoint
- [ ] Repository korrekt benannt
- [ ] App unter dem Namen `MoodTracker` gespeichert
- [ ] Präsentation bereit
- [ ] Abschlussversion getestet

---

## 14. Schlussreflexion

### Was ist gut gelungen?

[Text einfügen]

### Welche Funktionen konnten erfolgreich umgesetzt werden?

[Text einfügen]

### Welche Funktionen konnten nicht oder nur teilweise umgesetzt werden?

[Text einfügen]

### Was war besonders schwierig?

[Text einfügen]

### Wie wurden die technischen Probleme gelöst?

[Text einfügen]

### Was würde ich beim nächsten Projekt anders machen?

[Text einfügen]

### Was habe ich fachlich gelernt?

[Text einfügen]

### Was habe ich über Projektplanung und strukturiertes Arbeiten gelernt?

[Text einfügen]

### Persönliches Fazit

[Text einfügen]

---

## 15. Quellen

- Microsoft Learn: .NET MAUI
- Projektauftrag Fachbereich API
- ITS Codier-Richtlinien C#
- FW 10.1 API 2026 Datenstruktur
- [weitere Quellen ergänzen]

---

## 16. Anhänge

- [ ] Mockup
- [ ] UML-Klassendiagramm
- [ ] Screenshots der App
- [ ] Testprotokoll
- [ ] GitHub-Link
- [ ] Präsentation
- [ ] weitere Dokumente
