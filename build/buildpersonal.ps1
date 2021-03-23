Write-Host -NoNewline "TC ... "
.\pd2treasureclass.ps1
Write-Host "Done"

Write-Host -NoNewline "Default ... "
.\pd2default.ps1
Write-Host "Done"



Write-Host -NoNewline "Personal ... "

if (Test-Path -Path '.\obj') { Remove-Item '.\obj' -Recurse }
if (Test-Path -Path '.\bin') { Remove-Item '.\bin' -Recurse }

New-Item -ItemType Directory -Path 'obj' | Out-Null
New-Item -ItemType Directory -Path 'bin' | Out-Null

Get-ChildItem -Path ..\src\*.filter | 
ForEach-Object{
    $outputPath = '.\obj\' + $_.Name
    $inputPath = '..\src\' + $_.Name
    
    Get-Content -Path $inputPath | Where-Object {$_.trim() -ne "" } | Set-Content -Path $outputPath 
    (Get-Content -Path $outputPath | Select-String -pattern '/////' -notmatch) | Set-Content -Path $outputPath
    (Get-Content -Path $outputPath).replace("`t","").replace("    ]","]").replace(" ]","]").replace(" ]","]")| Set-Content -Path $outputPath 
}


$file = '.\obj\common.pd2.filter'
$find = ']:%ORANGE%'
$replace = ']:%NL%%ORANGE%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'o%WHITE%{'
$replace = 'o%NL%%WHITE%{'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Rune{%NAME%%TAN%'
$replace = 'Rune%NL%{%NAME%%TAN%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Stack{%NAME%%TAN%'
$replace = 'Stack%NL%{%NAME%%TAN%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Stack o{%NAME%'
$replace = 'Stack o%NL%{%NAME%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Rune o{%NAME%'
$replace = 'Rune o%NL%{%NAME%'
(Get-Content $file).replace($find, $replace) | Set-Content $file

$file = '.\obj\common.lod.filter'
$find = ']:%ORANGE%'
$replace = ']:%NL%%ORANGE%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Rune o{%NAME%'
$replace = 'Rune o%NL%{%NAME%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Rune{%NAME%'
$replace = 'Rune%NL%{%NAME%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Stack{%NAME%%TAN%'
$replace = 'Stack%NL%{%NAME%%TAN%'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'Stack o{%NAME%'
$replace = 'Stack o%NL%{%NAME%'
(Get-Content $file).replace($find, $replace) | Set-Content $file

$file = '.\obj\catchall.filter'
$find = 'ItemDisplay[MAG !ID cm1]:%DOT-97%%RED%ooo %BLUE%%NAME% %RED%ooo%BLUE%//'
$replace = 'ItemDisplay[MAG !ID cm1]:%DOT-97%%NL%%RED%ooo %BLUE%%NAME% %RED%ooo%NL%%BLUE%//'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'ItemDisplay[MAG !ID cm3]:%DOT-97%%RED%ooo %BLUE%%NAME% %RED%ooo%BLUE%//'
$replace = 'ItemDisplay[MAG !ID cm3]:%DOT-97%%NL%%RED%ooo %BLUE%%NAME% %RED%ooo%NL%%BLUE%//'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'ItemDisplay[MAG !ID jew]:%DOT-97%%RED%ooo %BLUE%%NAME% %RED%ooo%BLUE%//'
$replace = 'ItemDisplay[MAG !ID jew]:%DOT-97%%NL%%RED%ooo %BLUE%%NAME% %RED%ooo%NL%%BLUE%//'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'ItemDisplay[RARE !ID jew]:%MAP-6F%%RED%oooo %YELLOW%%NAME% %RED%oooo%YELLOW%//'
$replace = 'ItemDisplay[RARE !ID jew]:%MAP-6F%%NL%%RED%oooo %YELLOW%%NAME% %RED%oooo%NL%%YELLOW%//'
(Get-Content $file).replace($find, $replace) | Set-Content $file
$find = 'ItemDisplay[RARE !ID rin]:%MAP-6F%%RED%oooo %TAN%Lvl%ILVL% %YELLOW%%NAME% %RED%oooo%YELLOW%//'
$replace = 'ItemDisplay[RARE !ID rin]:%MAP-6F%%NL%%RED%oooo %TAN%Lvl%ILVL% %YELLOW%%NAME% %RED%oooo%NL%%YELLOW%////'
(Get-Content $file).replace($find, $replace) | Set-Content $file

Get-Content '.\obj\quest.lod.filter', '.\obj\quest.pd2.filter', 
'.\obj\common.lod.filter', '.\obj\common.pd2.filter', 
'.\obj\item.prefix.filter', 
#'.\obj\item.treasureclass.filter', 
'.\obj\item.crafting.filter', 
'.\obj\item.suffix.filter', '.\obj\item.shopping.filter', '.\obj\item.colorfix.filter', 
'.\obj\bases.filter', 
'.\obj\item.colorfix.filter', 
'.\obj\item.description.filter', 
'.\obj\arreat.normal.filter', '.\obj\arreat.exceptional.filter', '.\obj\arreat.elite.filter', 
'.\obj\set.shared.filter', '.\obj\set.normal.filter', '.\obj\set.exceptional.filter', '.\obj\set.elite.filter', 
'.\obj\unique.shared.filter', '.\obj\unique.normal.filter', '.\obj\unique.exceptional.filter', '.\obj\unique.elite.filter', 
'.\obj\catchall.filter' | Set-Content '.\bin\default.filter'

if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2') { Copy-Item '.\bin\default.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2\loot.filter' }
if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg') { Copy-Item '.\bin\default.filter' -Destination 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg' }

Write-Host "Done"
