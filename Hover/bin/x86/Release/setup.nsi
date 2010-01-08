!include "MUI2.nsh"
!include "checkDotNet3.nsh"
!include "getDotNetDir.nsh"

!define MIN_FRA_MAJOR "3"
!define MIN_FRA_MINOR "5"
!define MIN_FRA_BUILD "*"

!define ENGINE_NAME "hover"


; The name of the installer
Name "Snarl Style Hover"

; The file to write
OutFile "Setup-Hover.exe"


; The default installation directory
InstallDir "$PROGRAMFILES\Tlhan Ghun\Styles\Hover"

; Registry key to check for directory (so if you install again, it will 
; overwrite the old one automatically)
InstallDirRegKey HKLM "Software\TlhanGhun\Styles\Hover" "Install_Dir"

; Request application privileges for Windows Vista
RequestExecutionLevel admin


;--------------------------------

  !define MUI_ABORTWARNING

!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_BITMAP "tlhanGhun.bmp"
!define MUI_WELCOMEFINISHPAGE_BITMAP "tlhanGhunWelcome.bmp"
!define MUI_WELCOMEPAGE_TITLE "Snarl style Hover"
!define MUI_WELCOMEPAGE_TEXT "Shows a semitransparent rectangle on the center of the screen$\r$\n$\r$\nPlease stop Snarl prior to installation."
!define MUI_STARTMENUPAGE_DEFAULTFOLDER "Tlhan Ghun\Styles\Hover"
!define MUI_ICON "hover.ico"
!define MUI_UNICON "uninstall.ico"


Var StartMenuFolder
; Pages

  !insertmacro MUI_PAGE_WELCOME
  !insertmacro MUI_PAGE_LICENSE "License.txt"
  !insertmacro MUI_PAGE_COMPONENTS
  !insertmacro MUI_PAGE_DIRECTORY
  !define MUI_STARTMENUPAGE_REGISTRY_ROOT "HKCU" 
  !define MUI_STARTMENUPAGE_REGISTRY_KEY "Software\TlhanGhun\Styles\Hover" 
  !define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "Start Menu Folder"
  !insertmacro MUI_PAGE_STARTMENU Application $StartMenuFolder
  !insertmacro MUI_PAGE_INSTFILES
  !insertmacro MUI_PAGE_FINISH
  
; Uninstaller  
  !insertmacro MUI_UNPAGE_WELCOME
  !insertmacro MUI_UNPAGE_CONFIRM
  !insertmacro MUI_UNPAGE_INSTFILES
  !insertmacro MUI_UNPAGE_FINISH

;--------------------------------

!insertmacro MUI_LANGUAGE "English"

; LoadLanguageFile "${NSISDIR}\Contrib\Language files\English.nlf"
;--------------------------------
;Version Information

  VIProductVersion "2.0.0.0"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "ProductName" "Snarl Style Hover"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "CompanyName" "Tlhan Ghun"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "LegalCopyright" "© 2010 Tlhan Ghun GPL v.3"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileDescription" "Sends Snarl notifications as email"
  VIAddVersionKey /LANG=${LANG_ENGLISH} "FileVersion" "1.0"


Function un.UninstallDirs
    Exch $R0 ;input string
    Exch
    Exch $R1 ;maximum number of dirs to check for
    Push $R2
    Push $R3
    Push $R4
    Push $R5
       IfFileExists "$R0\*.*" 0 +2
       RMDir "$R0"
     StrCpy $R5 0
    top:
     StrCpy $R2 0
     StrLen $R4 $R0
    loop:
     IntOp $R2 $R2 + 1
      StrCpy $R3 $R0 1 -$R2
     StrCmp $R2 $R4 exit
     StrCmp $R3 "\" 0 loop
      StrCpy $R0 $R0 -$R2
       IfFileExists "$R0\*.*" 0 +2
       RMDir "$R0"
     IntOp $R5 $R5 + 1
     StrCmp $R5 $R1 exit top
    exit:
    Pop $R5
    Pop $R4
    Pop $R3
    Pop $R2
    Pop $R1
    Pop $R0
FunctionEnd



; The stuff to install
Section "Snarl style Hover files"
  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  !insertmacro AbortIfBadFramework

  call checkforsnarl  
  ExecWait '$R0\snarlm.exe -us hover.styleengine'
  Sleep 500


  ; Put file there
  File "Changes.txt"
;  File "CREDITS.txt"
  File "Documentation.URL"
  File "Interop.libmgraphics.dll"
  File "Interop.libSnarlStyles.dll"
  File "Interop.melon.dll"
  File "Interop.prefs_kit_d2.dll"
 ; File "Interop.SpeechLib.dll"
;  File "Newtonsoft.Json.dll"
  File "LICENSE.txt"
  File "Documentation.ico"
  File "hover.dll"
  File "hover.dll.config"
  File "hover.pdb"
  File "uninstall.ico"
  File "hover.ico"
  File "Winkle.dll"
  File "Winkle.pdb"
  
  
  ; Write the installation path into the registry
  WriteRegStr HKLM SOFTWARE\TlhanGhun\SnarlStylehover "Install_Dir" "$INSTDIR"
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\SnarlStyleHover" "DisplayName" "Snarl Style Hover"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\SnarlStyleHover" "UninstallString" '"$INSTDIR\uninstall.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\SnarlStyleHover" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\SnarlStyleHover" "NoRepair" 1
  WriteUninstaller "uninstall.exe"

; Register the assembly

  push "v2.0"
  call GetDotNetDir
  pop $R0
  GetFullPathName /SHORT $1 $R0
  GetFullPathName /SHORT $2 $INSTDIR
  StrCpy $0 '"$1\RegAsm.exe" "$2\hover.dll" /codebase'  
  DetailPrint $0
  nsExec::ExecToLog $0
  pop $0
  
  SectionEnd


Section "Register style with Snarl"
  SetOutPath "$APPDATA\full phat\snarl\styles"
  File "hover.styleengine"

  call checkforsnarl
  ExecWait '$R0\snarlm.exe -ls ${ENGINE_NAME}.styleengine'


SectionEnd


; Optional section (can be disabled by the user)
Section "Start Menu Shortcuts"

!insertmacro MUI_STARTMENU_WRITE_BEGIN Application

  CreateDirectory "$SMPROGRAMS\$StartMenuFolder"
;  CreateShortCut "$SMPROGRAMS\$StartMenuFolder\\Documentation.lnk" "$INSTDIR\Documentation.URL" "" $INSTDIR\Documentation.ico" 0
  CreateShortCut "$SMPROGRAMS\$StartMenuFolder\\Uninstall.lnk" "$INSTDIR\uninstall.exe" "" "$INSTDIR\uninstall.exe" 0
  
!insertmacro MUI_STARTMENU_WRITE_END

  
SectionEnd


;--------------------------------

; Uninstaller

Section "Uninstall"




  ; UNregister the assembly
  push "v2.0"
call un.GetDotNetDir
pop $R0
GetFullPathName /SHORT $1 $R0
GetFullPathName /SHORT $2 $INSTDIR
StrCpy $0 '"$1\RegAsm.exe" "$2\hover.dll" /unregister'
DetailPrint $0
nsExec::ExecToLog $0
pop $0

  
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\SnarlStyleHover"
  DeleteRegKey HKLM "Software\TlhanGhun\Styles\Hover"
  ; Remove files and uninstaller
  Delete $INSTDIR\*.*

  ; Remove shortcuts, if any
  !insertmacro MUI_STARTMENU_GETFOLDER Application $StartMenuFolder
    
  Delete "$SMPROGRAMS\$StartMenuFolder\\*.*"
  


  DeleteRegKey HKCU "Software\TlhanGhun\Styles\Hover"


  ; Remove directories used
   ; RMDir "$SMPROGRAMS\$StartMenuFolder"
Push 10 #maximum amount of directories to remove
  Push "$SMPROGRAMS\$StartMenuFolder" #input string
    Call un.UninstallDirs

   
  ; RMDir "$INSTDIR"
  
  Push 10 #maximum amount of directories to remove
  Push $INSTDIR #input string
    Call un.UninstallDirs


  
  Delete "$APPDATA\full phat\snarl\styles\hover.styleengine"

SectionEnd

Function checkforsnarl
  ReadRegStr $R0 "HKLM" "Software\Microsoft\Windows\CurrentVersion\Uninstall\Snarl" "Location"
  ; MessageBox MB_ICONQUESTION|MB_OK $R0
  ; was the returned path empty?
  StrCmp $R0 "" 0 skip

  ; yes, so assume Snarl isn't installed
  MessageBox MB_ICONEXCLAMATION|MB_OK "Snarl is not installed.  Snarl can be downloaded from www.fullphat.net."
  Quit
skip:
FunctionEnd