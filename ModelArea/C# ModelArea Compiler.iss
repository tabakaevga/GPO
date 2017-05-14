#define Name    "FigureCalc"

#define Version "0.1"

#define ExeName "FigureCalc.exe" 

[Setup]
AppId={{997226E5-78D2-459E-AF3A-6BEDC38AA599}

AppName={#Name}

AppVersion={#Version}

DefaultDirName = {pf}\{#Name}

DefaultGroupName = {#Name}

OutputDir=D:\ModelAreaSetup
OutputBaseFilename=test-setup

Compression=lzma
SolidCompression=yes

[Languages]

Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl";

[Files]

Source: "C:\Users\Администратор\Desktop\GPO\ModelArea\ModelView\bin\Release\ModelView.exe"; DestDir: "{app}"; Flags: ignoreversion

Source: "C:\Users\Администратор\Desktop\GPO\ModelArea\ModelView\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs

