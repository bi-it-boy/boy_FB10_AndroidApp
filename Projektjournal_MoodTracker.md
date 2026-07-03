# 📘 Projektjournal – MoodTracker


---

## Inhaltsverzeichnis

- [📘 Projektjournal – MoodTracker](#-projektjournal--moodtracker)
  - [ℹ️ Info](#ℹ️-info)
  - [Inhaltsverzeichnis](#inhaltsverzeichnis)
  - [Tagesaktivitäten](#tagesaktivitäten)
  - [Phase 1 – Setup und Initialisierung](#phase-1--setup-und-initialisierung)
  - [Phase 2 – Planung](#phase-2--planung)
    - [📂 Geplante Datenstruktur](#-geplante-datenstruktur)
    - [🔷 Geplantes UML-Klassendiagramm](#-geplantes-uml-klassendiagramm)
    - [🖼️ Geplantes Layout](#️-geplantes-layout)
    - [✅ Geplante Validierung](#-geplante-validierung)
  - [Phase 3 – Umsetzung](#phase-3--umsetzung)
  - [Phase 4 – Testing und technische Reflexion](#phase-4--testing-und-technische-reflexion)
  - [Phase 5 – Abschluss und Präsentation](#phase-5--abschluss-und-präsentation)
  - [📸 Screenshots vom Fortschritt](#-screenshots-vom-fortschritt)
  - [⚠️ Herausforderungen und Blockaden](#️-herausforderungen-und-blockaden)
    - [🧩 Visual Studio und Projektstruktur](#-visual-studio-und-projektstruktur)
    - [🤖 Android SDK und Emulator](#-android-sdk-und-emulator)
    - [🌿 Git, Commit und Push](#-git-commit-und-push)
  - [💻 Besonders erwähnenswerte Code-Beispiele](#-besonders-erwähnenswerte-code-beispiele)
  - [Reflexion](#reflexion)

---

## Tagesaktivitäten

| Datum | Aktivität |
|---|---|
| Mi, 01.07.2026 | Visual Studio 2026 eingerichtet und auf Englisch umgestellt. |
| Mi, 01.07.2026 | .NET MAUI 10 geprüft und ein neues Projekt `HelloWorldMAUI` erstellt. |
| Mi, 01.07.2026 | Hello-World-App mit `Windows Machine` gestartet. |
| Mi, 01.07.2026 | Android Emulator getestet. Android-SDK-Lizenzen konnten noch nicht akzeptiert werden. |
| Mi, 01.07.2026 | Git for Windows installiert und Git über das Terminal verwendet. |
| Mi, 01.07.2026 | Projektjournal zum Repository hinzugefügt, committed und gepusht. |
| Mi, 01.07.2026 | Repository-Struktur angepasst, damit `HelloWorldMAUI`, `MoodTracker` und das Projektjournal getrennt abgelegt werden können. |
| Mi, 01.07.2026 | Neues .NET-MAUI-Projekt `MoodTracker` erstellt. |


---

## Phase 1 – Setup und Initialisierung

**Datum:** 01.07.2026

### Was habe ich in Phase 1 umgesetzt?

Zu Beginn wurde die Entwicklungsumgebung eingerichtet. Verwendet wird Visual Studio 2026 mit .NET MAUI 10. Da im Projektauftrag eine englische Entwicklungsumgebung verlangt wird, wurde Visual Studio auf Englisch umgestellt.

Anschliessend wurde ein neues Projekt mit der Vorlage `.NET MAUI App` erstellt.

Das erste Projekt trägt den Namen:

```text
HelloWorldMAUI
```

Das Projekt konnte mit `Windows Machine` gestartet werden. Dadurch wurde bestätigt, dass das Projekt grundsätzlich korrekt erstellt wurde und die .NET-MAUI-Umgebung funktioniert.

Der Android Emulator konnte noch nicht vollständig verwendet werden, da die Android-SDK-Lizenzen noch nicht akzeptiert wurden.

### Repository-Struktur

Die geplante Struktur des Repositories ist:

```text
Repository/
├── Projektjournal_MoodTracker.md
├── HelloWorldMAUI.slnx
├── HelloWorldMAUI/
│   ├── HelloWorldMAUI.csproj
│   ├── App.xaml
│   ├── MainPage.xaml
│   ├── Platforms/
│   └── Resources/
└── MoodTracker/
    ├── MoodTracker.csproj
    ├── App.xaml
    ├── MainPage.xaml
    ├── Platforms/
    └── Resources/
```

Das Projektjournal befindet sich auf der obersten Ebene und ist somit beiden Projekten übergeordnet.

### GitHub

Git wurde über das Terminal verwendet.

Beispiel für die verwendeten Befehle:

```powershell
git status
git add Projektjournal_MoodTracker.md
git commit -m "Add project journal"
git push
```

### Meilenstein 1

- [x] Visual Studio installiert
- [x] Visual Studio auf Englisch umgestellt
- [x] .NET-MAUI-Projekt erstellt
- [x] Hello-World-App unter Windows gestartet
- [x] Projekt auf GitHub gespeichert
- [ ] Android-SDK-Lizenzen akzeptiert
- [ ] Hello-World-App im Android Emulator gestartet
- [ ] Projekt einer FW-Leitung gezeigt
- [ ] „Go“ zum Weiterarbeiten erhalten

---

## Phase 2 – Planung

**Datum:** [01. - 03.07.26]

### Was habe ich in Phase 2 umgesetzt?

In dieser Phase wird die MoodTracker-App geplant. Dazu gehören die Datenstruktur, das Layout, die Navigation und die Validierungsregeln.

Die App soll es Benutzerinnen und Benutzern ermöglichen, nach einem Angebot eine kurze Rückmeldung zu erfassen.

### Geplante Kernfunktionen

1. Auswahl eines Angebots
2. Auswahl einer Stimmung
3. Eingabe einer optionalen Notiz
4. Speichern des Eintrags
5. Anzeige aller bisherigen Einträge
6. optional: Statistikseite

### 📂 Geplante Datenstruktur

Ein MoodTracker-Eintrag soll folgende Daten enthalten:

```json
[
  {
    "Id": 1,
    "CourseName": "Sportkurs",
    "Mood": "Gut",
    "Note": "Der Kurs hat mir gefallen.",
    "CreatedAt": "2026-07-01T14:30:00"
  }
]
```

Die Datenstruktur wird durch eine C#-Klasse abgebildet.

```csharp
public class MoodEntry
{
    public int Id { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public string Mood { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
```

Optional kann eine eigene Klasse für die Angebote erstellt werden:

```csharp
public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
```

### 🔷 Geplantes UML-Klassendiagramm

```text
MoodEntry
-------------------------
Id : int
CourseName : string
Mood : string
Note : string
CreatedAt : DateTime
-------------------------

Course
-------------------------
Id : int
Name : string
Category : string
Description : string
-------------------------
```

![UML-Klassendiagramm](screenshots/phase2_uml.png)

### 🖼️ Geplantes Layout

#### Seite 1: Rückmeldung erfassen

- Titel der App
- Auswahl des Angebots
- Auswahl der Stimmung
- Textfeld für eine optionale Notiz
- Speichern-Button
- kurze Erfolgsmeldung nach dem Speichern

![Mockup Eingabeformular](screenshots/phase2_mockup_form.png)

#### Seite 2: Bisherige Einträge

- Liste aller gespeicherten Einträge
- Name des Angebots
- Stimmung
- Notiz
- Datum und Uhrzeit
- optional: Löschen-Button

![Mockup Listenansicht](screenshots/phase2_mockup_list.png)

#### Optionale Seite 3: Statistik

- Anzahl aller Einträge
- Anzahl positiver, neutraler und negativer Stimmungen
- häufigstes Angebot
- optional: grafische Darstellung

![Mockup Statistik](screenshots/phase2_mockup_statistics.png)

### ✅ Geplante Validierung

| Feld | Regel | Reaktion bei ungültiger Eingabe |
|---|---|---|
| Angebot | Pflichtfeld | Meldung: „Bitte wähle ein Angebot aus.“ |
| Stimmung | Pflichtfeld | Meldung: „Bitte wähle eine Stimmung aus.“ |
| Notiz | optional | keine Fehlermeldung |
| Notiz | maximale Länge wird noch festgelegt | Hinweis bei Überschreitung |
| Speichern | nur bei gültigen Pflichtfeldern | Eintrag wird gespeichert |

Nach erfolgreichem Speichern soll:

- eine Bestätigung angezeigt werden,
- das Formular geleert werden,
- der neue Eintrag in der Liste erscheinen.

### Meilenstein 2

- [ ] Mockup erstellt
- [ ] Datenstruktur definiert
- [ ] Validierungen definiert
- [ ] optionale UML erstellt
- [ ] Planung einer FW-Leitung vorgestellt
- [ ] „Go“ zur Umsetzung erhalten

---

## Phase 3 – Umsetzung

**Datum:** [einfügen]

### Was habe ich in Phase 3 umgesetzt?

- [x] Neues Projekt `MoodTracker` erstellt
- [ ] Grundlayout in XAML erstellt
- [ ] Klasse `MoodEntry` erstellt
- [ ] Angebotsauswahl umgesetzt
- [ ] Stimmungsauswahl umgesetzt
- [ ] Notizfeld umgesetzt
- [ ] Speichern-Button umgesetzt
- [ ] Validierung umgesetzt
- [ ] Speicherung der Einträge umgesetzt
- [ ] Listenansicht umgesetzt
- [ ] gespeicherte Einträge beim Start geladen
- [ ] Einträge nach Datum sortiert
- [ ] Löschen von Einträgen umgesetzt
- [ ] Statistikseite umgesetzt
- [ ] App im Windows-Zielsystem getestet
- [ ] App im Android Emulator getestet

### Verwendete Dateien

```text
MoodTracker/
├── App.xaml
├── App.xaml.cs
├── AppShell.xaml
├── AppShell.xaml.cs
├── MainPage.xaml
├── MainPage.xaml.cs
├── MauiProgram.cs
├── Models/
│   └── MoodEntry.cs
└── Services/
    └── MoodEntryService.cs
```

Die genaue Struktur wird während der Umsetzung angepasst.

![Erste Version](screenshots/phase3_first_version.png)

### Meilenstein 3

Spätestens am **08.07.2026** muss eine funktionsfähige Version vorliegen.

- [ ] App startet ohne Fehler
- [ ] Angebot kann ausgewählt werden
- [ ] Stimmung kann ausgewählt werden
- [ ] optionale Notiz kann eingegeben werden
- [ ] Eintrag kann gespeichert werden
- [ ] Einträge werden in einer Liste angezeigt
- [ ] Zwischenpräsentation vorbereitet
- [ ] Zwischenpräsentation durchgeführt

---

## Phase 4 – Testing und technische Reflexion

**Datum:** [einfügen]

### Was habe ich in Phase 4 umgesetzt?

- [ ] Testszenarien erstellt
- [ ] Testprotokoll ausgefüllt
- [ ] Fehler dokumentiert
- [ ] Fehler behoben
- [ ] Tests wiederholt
- [ ] mindestens drei technische Herausforderungen beschrieben
- [ ] Lösungswege dokumentiert

### Testprotokoll

| Test-ID | Testfall | Erwartetes Ergebnis | Tatsächliches Ergebnis | Status |
|---|---|---|---|---|
| T01 | App starten | App startet ohne Fehler | [einfügen] | ☐ |
| T02 | Angebot auswählen | Angebot wird übernommen | [einfügen] | ☐ |
| T03 | Stimmung auswählen | Stimmung wird übernommen | [einfügen] | ☐ |
| T04 | gültigen Eintrag speichern | Eintrag wird gespeichert | [einfügen] | ☐ |
| T05 | ohne Angebot speichern | Fehlermeldung erscheint | [einfügen] | ☐ |
| T06 | ohne Stimmung speichern | Fehlermeldung erscheint | [einfügen] | ☐ |
| T07 | ohne Notiz speichern | Eintrag wird gespeichert | [einfügen] | ☐ |
| T08 | App neu starten | Daten bleiben erhalten | [einfügen] | ☐ |
| T09 | Liste öffnen | Einträge werden angezeigt | [einfügen] | ☐ |
| T10 | langen Text eingeben | Layout bleibt lesbar | [einfügen] | ☐ |

---

## Phase 5 – Abschluss und Präsentation

**Datum:** [einfügen]

### Was habe ich in Phase 5 umgesetzt?

- [ ] Projekt fertiggestellt
- [ ] letzter Funktionstest durchgeführt
- [ ] GitHub-Repository aktualisiert
- [ ] Projektjournal vervollständigt
- [ ] Screenshots eingefügt
- [ ] technische Herausforderungen dokumentiert
- [ ] Präsentation erstellt
- [ ] Demo vorbereitet
- [ ] Projekt präsentiert

### Inhalte der Präsentation

- Ausgangslage
- Ziel der App
- wichtigste Funktionen
- Datenstruktur
- Architektur
- Demo der App
- Herausforderungen
- Lösungswege
- Tests
- Erweiterungsmöglichkeiten
- persönliche Reflexion

---

## 📸 Screenshots vom Fortschritt

| Datum | Phase / Feature | Screenshot |
|---|---|---|
| 01.07.2026 | HelloWorldMAUI | ![](screenshots/phase1_helloworld.png) |
| [Datum] | Mockup Eingabeformular | ![](screenshots/phase2_mockup_form.png) |
| [Datum] | Mockup Listenansicht | ![](screenshots/phase2_mockup_list.png) |
| [Datum] | Erste MoodTracker-Version | ![](screenshots/phase3_first_version.png) |
| [Datum] | Fertiges Eingabeformular | ![](screenshots/final_form.png) |
| [Datum] | Fertige Listenansicht | ![](screenshots/final_list.png) |

---

## ⚠️ Herausforderungen und Blockaden

### 🧩 Visual Studio und Projektstruktur

**Problem:**

Das Projekt `HelloWorldMAUI` wurde zuerst direkt im Hauptordner des Repositories erstellt. Das Projektjournal sollte jedoch auf derselben Ebene wie die beiden Projekte `HelloWorldMAUI` und `MoodTracker` liegen.

Nach dem Verschieben der Projektdateien versuchte Visual Studio weiterhin, die alte Datei `HelloWorldMAUI.csproj` zu öffnen.

Dabei erschien folgende Meldung:

```text
An error occurred in 'Miscellaneous Files' while attempting to open
'HelloWorldMAUI.csproj'.

The document cannot be opened. It has been renamed, deleted, or moved.
```

**Lösung:**

- Projektdateien in einen eigenen Unterordner verschoben
- Pfad in der Solution-Datei angepasst
- veraltete Tabs geschlossen
- Visual-Studio-Zwischenspeicher einmalig gelöscht
- korrekte `.slnx`-Datei direkt geöffnet

```powershell
Remove-Item -Recurse -Force .\.vs -ErrorAction SilentlyContinue
Start-Process .\HelloWorldMAUI.slnx
```

**Erkenntnis:**

Projekt- und Repository-Struktur sollten möglichst vor dem Erstellen der Projekte geplant werden. Dadurch können spätere Pfadprobleme vermieden werden.

### 🤖 Android SDK und Emulator

**Problem:**

Beim Starten des Android-Ziels erschien folgende Meldung:

```text
The Android SDK licenses acceptance failed.
These must be accepted to continue using Android.
```

**Aktueller Stand:**

Die App kann über `Windows Machine` gestartet werden. Dies zeigt, dass das MAUI-Projekt grundsätzlich funktioniert.

Für den Projektauftrag muss die App später zusätzlich im Android Emulator oder auf einem echten Android-Gerät getestet werden.

**Geplanter Lösungsweg:**

- Android SDK Manager öffnen
- Android-SDK-Lizenzen akzeptieren
- Emulator neu starten
- Projekt für `net10.0-android` bauen
- App auf dem Android Emulator ausführen

**Status:** offen

### 🌿 Git, Commit und Push

**Problem:**

Der Befehl `git` wurde zu Beginn im Terminal nicht erkannt.

```text
git wurde nicht als Name eines Cmdlet, einer Funktion,
einer Skriptdatei oder eines ausführbaren Programms erkannt.
```

**Lösung:**

Git for Windows wurde installiert.

```powershell
git --version
```

Ausgabe:

```text
git version 2.54.0.windows.1
```

Danach konnten Änderungen über das Terminal hinzugefügt, committed und gepusht werden.

```powershell
git status
git add .
git commit -m "Add initial MoodTracker project"
git push
```

**Erkenntnis:**

```text
add → commit → push
```

`git push` allein erstellt keinen Commit.

---

## 💻 Besonders erwähnenswerte Code-Beispiele

### Geplantes Datenmodell

```csharp
public class MoodEntry
{
    public int Id { get; set; }
    public string CourseName { get; set; } = string.Empty;
    public string Mood { get; set; } = string.Empty;
    public string Note { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
}
```

### Geplante Validierung

```csharp
private bool ValidateInput()
{
    if (string.IsNullOrWhiteSpace(SelectedCourse))
    {
        return false;
    }

    if (string.IsNullOrWhiteSpace(SelectedMood))
    {
        return false;
    }

    return true;
}
```

### Geplanter Speichervorgang

```csharp
private void SaveMoodEntry()
{
    var entry = new MoodEntry
    {
        Id = GetNextId(),
        CourseName = SelectedCourse,
        Mood = SelectedMood,
        Note = NoteText,
        CreatedAt = DateTime.Now
    };

    moodEntries.Add(entry);
}
```

Die Code-Beispiele werden während der Umsetzung durch den tatsächlich verwendeten Code ersetzt oder ergänzt.

---

## Reflexion

### Aktueller Zwischenstand

Der Einstieg in das Projekt war technisch anspruchsvoller als erwartet. Besonders die Einrichtung von Visual Studio, die Struktur des GitHub-Repositories und die Android-Umgebung benötigten mehrere Schritte.

Positiv ist, dass die .NET-MAUI-Umgebung grundsätzlich funktioniert und die Hello-World-App über `Windows Machine` gestartet werden konnte. Ausserdem wurde Git erfolgreich eingerichtet und das Projektjournal konnte über das Terminal committed und gepusht werden.

### Was habe ich bisher gelernt?

- wie ein .NET-MAUI-Projekt aufgebaut ist
- Unterschied zwischen Solution, Projekt und Repository
- wie mehrere Projekte in einem Repository organisiert werden können
- wie Dateien mit Git hinzugefügt, committed und gepusht werden
- dass `Windows Machine` kein Android Emulator ist
- wie wichtig eine saubere Ordnerstruktur vor Projektbeginn ist
- wie Visual Studio alte Dateipfade und Tabs zwischenspeichert

### Was war bisher schwierig?

- Visual Studio öffnete nach dem Verschieben weiterhin alte Dateipfade
- Git war zuerst nicht im Terminal verfügbar
- die Commit-Funktion in Visual Studio war nicht eindeutig auffindbar
- die Android-SDK-Lizenzen konnten noch nicht akzeptiert werden
- die Repository-Struktur musste nachträglich angepasst werden

### Nächste Schritte

- [ ] Android-SDK-Lizenzen akzeptieren
- [ ] Android Emulator vollständig einrichten
- [ ] HelloWorldMAUI im Android Emulator starten
- [ ] Meilenstein 1 abschliessen
- [ ] Mockup erstellen
- [ ] Datenstruktur definitiv festlegen
- [ ] Validierungen definieren
- [ ] Meilenstein 2 abschliessen
- [ ] erste MoodTracker-Funktionen umsetzen
