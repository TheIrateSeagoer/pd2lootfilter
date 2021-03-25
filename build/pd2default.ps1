
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
'.\obj\catchall.default.filter' | Set-Content '.\bin\default.filter'

Copy-Item '.\bin\default.filter' -Destination '..\default.filter'

