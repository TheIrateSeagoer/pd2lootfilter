################################################################################
Write-Host -NoNewline "Compilation ... "
################################################################################
if (Test-Path -Path '.\obj') { Remove-Item '.\obj' -Recurse }
if (Test-Path -Path '.\bin') { Remove-Item '.\bin' -Recurse }

New-Item -ItemType Directory -Path 'obj' | Out-Null
New-Item -ItemType Directory -Path 'bin' | Out-Null

Get-ChildItem -Path ..\src\*.filter | 
ForEach-Object {
    $outputPath = '.\obj\' + $_.Name
    $inputPath = '.\src\' + $_.Name

    $lineNumber = 0;
    [System.IO.StreamReader] $sr = [System.IO.File]::Open($inputPath, [System.IO.FileMode]::Open)
    while (-not $sr.EndOfStream)
    {
        $line = $sr.ReadLine()
        $lineNumber++;

        $writeLine = 1
        if ($line -eq "") 
        {
            $writeLine = 0
        }
        elseif ($line.Trim() -eq "") 
        {
            $writeLine = 0
        }
        elseif ($line.StartsWith("/////"))
        {
            $writeLine = 0    
        }

        if ($line.Contains("#HIDE"))
        {
            # $split = ($line.Split(']:')[0]).Trim()
            # if ($split.Length -lt 127)
            # {
            #     $line = $line.Replace("#HIDE", "{%NAME%%NL%%RED%" + $split + "}//")
            # }
            # else {
            #     $line = $line.Replace("#HIDE", "{%NAME%%NL%%RED% " + $_.Name + ":" + $lineNumber + "}//")
            # }  

            $line = $line.Replace("#HIDE", "{%NAME%%NL%%RED% " + $_.Name + ":" + $lineNumber + "}//")
        }

        if ($writeLine -eq 1)
        {
            if ($line.EndsWith('\')) {
                Add-Content -Path $outputPath -Value $line.Substring(0,$line.Length-1) -NoNewline
            }
            else {
                Add-Content -Path $outputPath -Value $line
            }
        }
    }
    $sr.Close() 
}
################################################################################
Write-Host "Done"
################################################################################


################################################################################
Write-Host -NoNewline "Show All ... "
################################################################################
.\pd2showall.ps1

#if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2') { Copy-Item '.\bin\show-all-items.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2\loot.filter' }
#if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg') { Copy-Item '.\bin\show-all-items.filter' -Destination 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg' }

################################################################################
Write-Host "Done"
################################################################################


################################################################################
Write-Host -NoNewline "Treasure Class ... "
################################################################################
.\pd2treasureclass.ps1
################################################################################
Write-Host "Done"
################################################################################


################################################################################
Write-Host -NoNewline "Default ... "
################################################################################
.\pd2default.ps1
################################################################################
Write-Host "Done"
################################################################################


################################################################################
Write-Host -NoNewline "Maps ... "
################################################################################

$outputPath = '.\obj\catchall.maps.filter'
$inputPath = '.\obj\catchall.default.filter'
(Get-Content -Path $inputPath).replace("CLVL>94","CLVL>1").replace("CLVL>89","CLVL>1").replace("CLVL>80","CLVL>1").replace("CLVL>79","CLVL>1").replace("CLVL>69","CLVL>1").replace("CLVL>49","CLVL>1").replace("CLVL>29","CLVL>1").replace("CLVL>19","CLVL>1").replace("CLVL>9","CLVL>1").replace("CLVL>4","CLVL>1") | Set-Content -Path $outputPath 

.\pd2maps.ps1

#if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2 - Debug\ProjectD2') { Copy-Item '.\bin\maps.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2 - Debug\ProjectD2\loot.filter' }
#if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2') { Copy-Item '.\bin\maps.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2\loot.filter' }
#if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg') { Copy-Item '.\bin\maps.filter' -Destination 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg' }

#if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2') { Copy-Item '.\bin\maps-with-crafting.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2\loot.filter' }
#if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg') { Copy-Item '.\bin\maps-with-crafting.filter' -Destination 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg' }

################################################################################
Write-Host "Done"
################################################################################


################################################################################
Write-Host -NoNewline "Personal ... "
################################################################################

Get-Content '.\obj\quest.lod.filter', '.\obj\quest.pd2.filter', 
'.\obj\common.lod.filter', '.\obj\common.pd2.filter', 
'.\obj\item.prefix.filter',
'.\obj\item.suffix.filter', 
'.\obj\item.shopping.charms.filter', '.\obj\item.shopping.jewels.filter', '.\obj\item.shopping.filter', 
'.\obj\item.colorfix.filter', 
'.\obj\bases.filter', '.\obj\bases.larzuk.filter', 
'.\obj\item.colorfix.filter', 
'.\obj\item.description.filter', 
'.\obj\arreat.normal.filter', '.\obj\arreat.exceptional.filter', '.\obj\arreat.elite.filter', 
'.\obj\set.shared.filter', '.\obj\set.normal.filter', '.\obj\set.exceptional.filter', '.\obj\set.elite.filter', 
'.\obj\unique.shared.filter', '.\obj\unique.normal.filter', '.\obj\unique.exceptional.filter', '.\obj\unique.elite.filter', 
'.\obj\personal.filter',
#'.\obj\item.treasureclass.filter', 
'.\obj\catchall.filter', '.\obj\catchall.default.filter' | Set-Content '.\bin\personal.filter'

#(Get-Content -Path '.\bin\personal.filter').replace("%DOT-81%","%DOT-81%[%CODE%] ").replace("%DOT-0D%","%DOT-0D%[%CODE%] ") | Set-Content -Path '.\bin\personal.filter'

if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2 - Debug\ProjectD2') { Copy-Item '.\bin\personal.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2 - Debug\ProjectD2\loot.filter' }
if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2') { Copy-Item '.\bin\personal.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2\loot.filter' }
if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg') { Copy-Item '.\bin\personal.filter' -Destination 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg' }


################################################################################
Write-Host "Done"
################################################################################

