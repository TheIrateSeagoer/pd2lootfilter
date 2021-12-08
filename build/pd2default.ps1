
Get-Content '.\obj\1.quest.lod.filter', '.\obj\1.quest.pd2.filter', 
'.\obj\1.common.lod.filter', '.\obj\1.common.pd2.filter', 
'.\obj\1.bases.filter', '.\obj\1.bases.larzuk.filter', 
'.\obj\1.set.shared.filter', '.\obj\1.set.normal.filter', '.\obj\1.set.exceptional.filter', '.\obj\1.set.elite.filter', 
'.\obj\1.unique.shared.filter', '.\obj\1.unique.normal.filter', '.\obj\1.unique.exceptional.filter', '.\obj\1.unique.elite.filter', 
'.\obj\item.prefix.filter',
'.\obj\item.suffix.filter', 
'.\obj\item.shopping.charms.filter', '.\obj\item.shopping.jewels.filter', '.\obj\item.shopping.filter', 
'.\obj\item.colorfix.filter', 
'.\obj\item.description.filter', 
'.\obj\arreat.normal.filter', '.\obj\arreat.exceptional.filter', '.\obj\arreat.elite.filter', 
'.\obj\catchall.filter', '.\obj\catchall.default.filter' | Set-Content '.\bin\default.filter'

Copy-Item '.\bin\default.filter' -Destination '..\season4.filter'

