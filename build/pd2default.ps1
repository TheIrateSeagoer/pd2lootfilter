if (Test-Path -Path '.\obj') { Remove-Item '.\obj' -Recurse }
if (Test-Path -Path '.\bin') { Remove-Item '.\bin' -Recurse }

New-Item -ItemType Directory -Path 'obj' | Out-Null
New-Item -ItemType Directory -Path 'bin' | Out-Null

(Get-Content '..\src\quest.lod.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\quest.lod.filter'
(Get-Content '..\src\quest.pd2.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\quest.pd2.filter'
(Get-Content '..\src\common.lod.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\common.lod.filter'
(Get-Content '..\src\common.pd2.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\common.pd2.filter'
(Get-Content '..\src\item.prefix.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\item.prefix.filter'
(Get-Content '..\src\item.suffix.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\item.suffix.filter'
(Get-Content '..\src\item.colorfix.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\item.colorfix.filter'
(Get-Content '..\src\item.description.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\item.description.filter'
(Get-Content '..\src\arreat.normal.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\arreat.normal.filter'
(Get-Content '..\src\arreat.exceptional.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\arreat.exceptional.filter'
(Get-Content '..\src\arreat.elite.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\arreat.elite.filter'
(Get-Content '..\src\set.shared.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\set.shared.filter'
(Get-Content '..\src\set.normal.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\set.normal.filter'
(Get-Content '..\src\set.exceptional.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\set.exceptional.filter'
(Get-Content '..\src\set.elite.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\set.elite.filter'
(Get-Content '..\src\unique.shared.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\unique.shared.filter'
(Get-Content '..\src\unique.normal.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\unique.normal.filter'
(Get-Content '..\src\unique.exceptional.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\unique.exceptional.filter'
(Get-Content '..\src\unique.elite.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\unique.elite.filter'
(Get-Content '..\src\bases.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\bases.filter'
(Get-Content '..\src\catchall.filter') | Where-Object {$_.trim() -ne "" } | Set-Content '.\obj\catchall.filter'

((Get-Content '.\obj\quest.lod.filter') | Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\quest.lod.filter'
((Get-Content '.\obj\quest.pd2.filter') | Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\quest.pd2.filter'
((Get-Content '.\obj\common.lod.filter') | Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\common.lod.filter'
((Get-Content '.\obj\common.pd2.filter') | Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\common.pd2.filter'
((Get-Content '.\obj\item.prefix.filter') | Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\item.prefix.filter'
((Get-Content '.\obj\item.suffix.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\item.suffix.filter'
((Get-Content '.\obj\item.colorfix.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\item.colorfix.filter'
((Get-Content '.\obj\item.description.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\item.description.filter'
((Get-Content '.\obj\arreat.normal.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\arreat.normal.filter'
((Get-Content '.\obj\arreat.exceptional.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\arreat.exceptional.filter'
((Get-Content '.\obj\arreat.elite.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\arreat.elite.filter'
((Get-Content '.\obj\set.shared.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\set.shared.filter'
((Get-Content '.\obj\set.normal.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\set.normal.filter'
((Get-Content '.\obj\set.exceptional.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\set.exceptional.filter'
((Get-Content '.\obj\set.elite.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\set.elite.filter'
((Get-Content '.\obj\unique.shared.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\unique.shared.filter'
((Get-Content '.\obj\unique.normal.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\unique.normal.filter'
((Get-Content '.\obj\unique.exceptional.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\unique.exceptional.filter'
((Get-Content '.\obj\unique.elite.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\unique.elite.filter'
((Get-Content '.\obj\bases.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\bases.filter'
((Get-Content '.\obj\catchall.filter') |  Select-String -pattern '/////' -notmatch) | Set-Content '.\obj\catchall.filter'

Get-Content '.\obj\quest.lod.filter', '.\obj\quest.pd2.filter', '.\obj\common.lod.filter', '.\obj\common.pd2.filter', '.\obj\item.prefix.filter', '.\obj\item.suffix.filter', '.\obj\item.colorfix.filter', '.\obj\item.description.filter','.\obj\arreat.normal.filter', '.\obj\arreat.exceptional.filter', '.\obj\arreat.elite.filter', '.\obj\set.shared.filter', '.\obj\set.normal.filter', '.\obj\set.exceptional.filter', '.\obj\set.elite.filter', '.\obj\unique.shared.filter', '.\obj\unique.normal.filter', '.\obj\unique.exceptional.filter', '.\obj\unique.elite.filter', '.\obj\bases.filter', '.\obj\catchall.filter' | Set-Content '.\bin\default.filter'

if (Test-Path -Path 'C:\Program Files (x86)\Diablo II\ProjectD2') { Copy-Item '.\bin\default.filter' -Destination 'C:\Program Files (x86)\Diablo II\ProjectD2\loot.filter' }
if (Test-Path -Path 'C:\Program Files (x86)\Diablo II\ProjectD2Beta') { Copy-Item '.\bin\default.filter' -Destination 'C:\Program Files (x86)\Diablo II\ProjectD2Beta\loot.filter' }
if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II\BH.cfg') { Copy-Item '.\bin\default.filter' -Destination 'C:\Program Files (x86)\Diablo II\BH.cfg' }


Copy-Item '.\bin\default.filter' -Destination '..\default.filter'
