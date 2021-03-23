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

Get-Content '.\obj\quest.lod.filter', '.\obj\quest.pd2.filter', 
'.\obj\common.lod.filter', '.\obj\common.pd2.filter', 
'.\obj\item.prefix.filter', 
'.\obj\item.crafting.filter', 
'.\obj\item.suffix.filter', '.\obj\item.shopping.filter', '.\obj\item.colorfix.filter', 
'.\obj\bases.filter', '.\obj\bases.larzuk.filter', 
'.\obj\item.colorfix.filter', 
'.\obj\item.description.filter', 
'.\obj\arreat.normal.filter', '.\obj\arreat.exceptional.filter', '.\obj\arreat.elite.filter', 
'.\obj\set.shared.filter', '.\obj\set.normal.filter', '.\obj\set.exceptional.filter', '.\obj\set.elite.filter', 
'.\obj\unique.shared.filter', '.\obj\unique.normal.filter', '.\obj\unique.exceptional.filter', '.\obj\unique.elite.filter', 
'.\obj\catchall.filter' | Set-Content '.\bin\default.filter'

if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2') { Copy-Item '.\bin\default.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2\loot.filter' }
if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg') { Copy-Item '.\bin\default.filter' -Destination 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg' }

Copy-Item '.\bin\default.filter' -Destination '..\default.filter'
