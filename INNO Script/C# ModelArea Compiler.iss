#define Name    "FigureCalc"

#define Version "0.1"

#define ExeName "FigureCalc.exe" 

[Setup]
AppId={{997226E5-78D2-459E-AF3A-6BEDC38AA599}

AppName={#Name}

AppVersion={#Version}

ChangesAssociations = yes

DefaultDirName = {pf}\{#Name}

DefaultGroupName = {#Name}

OutputDir=D:\ModelAreaSetup

OutputBaseFilename=test-setup

Compression=lzma
SolidCompression=yes


[Registry]
Root: HKCR; Subkey: ".fg";                             ValueData: "{#Name}";          Flags: uninsdeletevalue; ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#Name}";                     ValueData: "Program {#Name}";  Flags: uninsdeletekey;   ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#Name}\DefaultIcon";             ValueData: "{app}\{#ExeName},0";               ValueType: string;  ValueName: ""
Root: HKCR; Subkey: "{#Name}\shell\open\command";  ValueData: """{app}\{#ExeName}"" ""%1""";  ValueType: string;  ValueName: ""

[Languages]

Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl";

[Files]

Source: "C:\Users\Администратор\Desktop\GPO\ModelArea\ModelView\bin\Release\ModelView.exe"; DestDir: "{app}"; Flags: ignoreversion

Source: "C:\Users\Администратор\Desktop\GPO\ModelArea\ModelView\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

