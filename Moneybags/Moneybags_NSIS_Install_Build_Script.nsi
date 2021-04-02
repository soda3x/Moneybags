!define MUI_PRODUCT "Moneybags"
!define MUI_FILE "savefile"
!define MUI_VERSION ""
!define MUI_BRANDINGTEXT "Moneybags"
CRCCheck on

Name "Moneybags"

!include "MUI2.nsh"

OutFile "install_moneybags.exe"

!define MUI_ICON "money_bag_1f4b0_Mdj_icon.ico"
!define MUI_ABORTWARNING

InstallDir $LOCALAPPDATA\Moneybags
!insertmacro MUI_PAGE_WELCOME
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES
!insertmacro MUI_UNPAGE_WELCOME
!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES
 
!insertmacro MUI_LANGUAGE "English"

# Install Section
Section
SetOutPath $INSTDIR
File /r "bin\Debug\*"
WriteUninstaller $INSTDIR\uninstall.exe
CreateShortCut "$SMPROGRAMS\Moneybags.lnk" "$INSTDIR\Moneybags.exe"
CreateShortCut "$SMPROGRAMS\Uninstall Moneybags.lnk" "$INSTDIR\uninstall.exe"
CreateShortCut "$DESKTOP\Moneybags.lnk" "$INSTDIR\Moneybags.exe"
SectionEnd

# Uninstall Section
Section "Uninstall"
RMDir /r "$INSTDIR\*.*"
RMDir $INSTDIR
Delete "$SMPROGRAMS\Moneybags\Moneybags.lnk"
Delete "$SMPROGRAMS\Moneybags\Uninstall Moneybags.lnk"
Delete "$DESKTOP\Moneybags.lnk"
SectionEnd