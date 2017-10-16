# Know your IDE - Visual Studio

Warum? Man verbringt 8h am Tag in der IDE! Es lohnt sich, ein paar Kniffe drauf zu haben.

<!-- TOC depthFrom:2 -->

- [Das A und O: Keyboard Shortcuts](#das-a-und-o-keyboard-shortcuts)
    - [Visual Studio: Basic Keyboard Shortcuts](#visual-studio-basic-keyboard-shortcuts)
    - [Visual Studio: Code Snippets/Templates](#visual-studio-code-snippetstemplates)
    - [Resharper: Power Keyboard Shortcuts](#resharper-power-keyboard-shortcuts)
        - [Konstruktor anlegen](#konstruktor-anlegen)
        - [Refactoring: `Ctrl+R ...`](#refactoring-ctrlr-)
        - [Im Solution Explorer: Neue Klassen/Interfaces etc anlegen](#im-solution-explorer-neue-klasseninterfaces-etc-anlegen)
        - [Unit Testing: `Ctrl+U ...`](#unit-testing-ctrlu-)
        - [Eigene Templates anlegen](#eigene-templates-anlegen)
        - [Einstellungen ("Options"): Projekteinstellungen](#einstellungen-options-projekteinstellungen)
        - [Auswahl duplizieren](#auswahl-duplizieren)
    - [Eigene Keyboard Shortcuts anlegen](#eigene-keyboard-shortcuts-anlegen)
- [Git](#git)
- [Ordnerstruktur aendern](#ordnerstruktur-aendern)
- [NCrunch](#ncrunch)
- [Productivity Tools](#productivity-tools)
- [EditorConfig](#editorconfig)
- [Mal in das Option Menue reinschaun](#mal-in-das-option-menue-reinschaun)
- [Web.config Transformationen](#webconfig-transformationen)
- [App.config Transformationen](#appconfig-transformationen)
- [MSBuild (`sln` File)](#msbuild-sln-file)

<!-- /TOC -->

## Das A und O: Keyboard Shortcuts

Sowenig wie moeglich mit der Maus machen!

Kennt ihr das:

Kollege klickt auf "Datei", das Kontextmenue geht auf, dann wird auf "Speichern" geklickt...

Oder:

Text mit der Maus markieren, Rechtsklick, Kontextmenue geht auf, klicken auf "Kopieren", danach mit der Maus woanders hin klicken, wieder Rechtsklick, Kontextmenue "Einfuegen"...(das kann sogar ein Guttenberg besser)

Mir tut das innerlich weh.

### Visual Studio: Basic Keyboard Shortcuts

- `Alt+Arrow Up/Down`: Springt zur vorherigen/naechsten Methode
- `Ctrl+K Ctrl+C`: markierten Text auskommentieren
- `Ctrl+K Ctrl+U`: markierten Text auskommentieren
- `Ctrl+K Ctrl+S`: "Surround": markierten Text mit zB try/catch "umrahmen"

### Visual Studio: Code Snippets/Templates

- `ctor`
- `prop`
- `propg`
- `if`
- `try`
- ...

### Resharper: Power Keyboard Shortcuts

Der wichtigste Keyboard Shortcut ueberhaupt bei R#:

- `Alt+Enter`: Kontextabhaengige Verbesserungen

#### Konstruktor anlegen

- `Alt+Insert`: Ctor erstellen

#### Refactoring: `Ctrl+R ...`

- `Ctrl+R Ctrl+R`: **R**ename
- `Ctrl+R Ctrl+M`: Extract **M**ethod
- `Ctrl+R Ctrl+V`: Extract **V**ariable
- `Ctrl+R Ctrl+I`: **I**nline variable
- `Ctrl+R Ctrl+O`: Move
- `Ctrl+Shift+R`: Oeffnet Submenue "Refactor This":
    - Pull member up
    - Extract class
    - Extract interface
    - ...

#### Im Solution Explorer: Neue Klassen/Interfaces etc anlegen

- `Alt+Insert`: Oeffnet Kontextmenue mit sinnvollen (!) Vorschlaegen

#### Unit Testing: `Ctrl+U ...`

- `Ctrl+U Ctrl+R`: Unit Test ausfuehren
- `Ctrl+U Ctrl+D`: Unit Test debuggen
- `Ctrl+U Ctrl+L`: Alle Unit Test ausfuehren
- ...

#### Eigene Templates anlegen

`Resharper` -> `Tools` -> `Template Explorer`: `New Template`

``` csharp
private $RETURN_TYPE$ $METHODNAME$($PARAMS$)
{
    $END$
}
```

#### Einstellungen ("Options"): Projekteinstellungen

- persoenliche Einstellungen
- Projekteinstellungen (kann mit in Git einchecken)
- Systemeinstellungen
- einfach mal schauen, was man anpassen kann

#### Auswahl duplizieren

- `Ctrl+D`: Duplicate selection

### Eigene Keyboard Shortcuts anlegen

Sollte man sparsam mit umgehen!

Folgende Shortcuts finde ich pers. nuetzlich:

- `Ctrl+W`: Expand selection (`Resharper.Resharper_ExtendSelection`)


## Git

- Ich finde die Standardintegration in VS eher "mau". Ich nutze lediglich die Icons im Solution Explorer als schnellen Indicator fuer mich, ob sich an einer Datei/einem Ordner was geaendert hat.
- VS2015: GitExtensions
- VS2017: GitExtensions funktionieren noch nicht. Hier verwende ich einen Mix aus GitExtensions/TortoiseGit/Kommandozeile.

## Ordnerstruktur aendern

- Aufbau von `csproj` Dateien
- Funktion von `AssemblyInfo.cs`
- Solution folder
- Anpassen von `sln` Datei
- R# verwenden, wo moeglich!
- Verbesserungsvorschlaege?

## NCrunch

Frage: Wer verwendet Unit Tests?

NCrunch ist ein automatischer TestRunner fuer VS.

Kurze Demo...

## Productivity Tools

- Shrink empty lines
- Solution error visualizer (erzeugt die Unterringelung im Solution Explorer)

## EditorConfig

- vor VS2017: via plugin
- ab VS2017: default
    - ueberschreibt `Tools` -> `Options` -> `Text Editor` -> `C#` -> `Code Style` -> `General`.

## Mal in das Option Menue reinschaun

- was kann man konfigurieren?

## Web.config Transformationen

- TODO

## App.config Transformationen

- TODO

## MSBuild (`sln` File)

- TODO
