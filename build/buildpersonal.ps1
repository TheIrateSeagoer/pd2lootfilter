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


        if ($line.Contains("#EQUIP1#")) { $line = $line.Replace("#EQUIP1#", "(#NORM_EQ1# OR #NITE_EQ1# OR #HELL_EQ1#)") }
        if ($line.Contains("#EQUIP2#")) { $line = $line.Replace("#EQUIP2#", "(#NORM_EQ2# OR #NITE_EQ2# OR #HELL_EQ2#)") }
        if ($line.Contains("#EQUIP3#")) { $line = $line.Replace("#EQUIP3#", "(#NORM_EQ3# OR #NITE_EQ3# OR #HELL_EQ3#)") }
        if ($line.Contains("#EQUIP4#")) { $line = $line.Replace("#EQUIP4#", "(#NORM_EQ4# OR #NITE_EQ4# OR #HELL_EQ4#)") }
        if ($line.Contains("#EQUIP5#")) { $line = $line.Replace("#EQUIP5#", "(#NORM_EQ5# OR #NITE_EQ5# OR #HELL_EQ5#)") }
        if ($line.Contains("#EQUIP6#")) { $line = $line.Replace("#EQUIP6#", "(#NORM_EQ6# OR #NITE_EQ6# OR #HELL_EQ6#)") }
        if ($line.Contains("#EQUIP7#")) { $line = $line.Replace("#EQUIP7#", "(#NORM_EQ7# OR #NITE_EQ7# OR #HELL_EQ7#)") }
        if ($line.Contains("#EQUIP8#")) { $line = $line.Replace("#EQUIP8#", "(#NORM_EQ8# OR #NITE_EQ8# OR #HELL_EQ8#)") }
        if ($line.Contains("#EQUIP9#")) { $line = $line.Replace("#EQUIP9#", "(#NORM_EQ9# OR #NITE_EQ9# OR #HELL_EQ9#)") }
        if ($line.Contains("#EQUIP10#")) { $line = $line.Replace("#EQUIP10#", "(#NORM_EQ10# OR #NITE_EQ10# OR #HELL_EQ10#)") }
        if ($line.Contains("#EQUIP11#")) { $line = $line.Replace("#EQUIP11#", "(#NORM_EQ11# OR #NITE_EQ11# OR #HELL_EQ11#)") }

        if ($line.Contains("#NORM_EQ1#")) { $line = $line.Replace("#NORM_EQ1#", "(cap OR skp OR hlm OR fhl OR msk OR bhm OR ghm OR crn)") }
        if ($line.Contains("#NITE_EQ1#")) { $line = $line.Replace("#NITE_EQ1#", "(xap OR xkp OR xlm OR xhl OR xsk OR xh9 OR xhm OR xrn)") }
        if ($line.Contains("#HELL_EQ1#")) { $line = $line.Replace("#HELL_EQ1#", "(uap OR ukp OR ulm OR uhl OR usk OR uh9 OR uhm OR urn)") }

        if ($line.Contains("#NORM_EQ2#")) { $line = $line.Replace("#NORM_EQ2#", "(qui OR lea OR hla OR stu OR rng OR scl OR chn OR brs OR spl OR plt OR fld OR gth OR ltp OR ful OR aar)") }
        if ($line.Contains("#NITE_EQ2#")) { $line = $line.Replace("#NITE_EQ2#", "(xui OR xea OR xla OR xtu OR xng OR xcl OR xhn OR xrs OR xpl OR xlt OR xld OR xth OR xtp OR xul OR xar)") }
        if ($line.Contains("#HELL_EQ2#")) { $line = $line.Replace("#HELL_EQ2#", "(uui OR uea OR ula OR utu OR ung OR ucl OR uhn OR urs OR upl OR ult OR uld OR uth OR utp OR uul OR uar)") }

        if ($line.Contains("#NORM_EQ3#")) { $line = $line.Replace("#NORM_EQ3#", "(buc OR sml OR lrg OR spk OR kit OR bsh OR tow OR gts)") }
        if ($line.Contains("#NITE_EQ3#")) { $line = $line.Replace("#NITE_EQ3#", "(xuc OR xml OR xrg OR xpk OR xit OR xsh OR xow OR xts)") }
        if ($line.Contains("#HELL_EQ3#")) { $line = $line.Replace("#HELL_EQ3#", "(uuc OR uml OR urg OR upk OR uit OR ush OR uow OR uts)") }

        if ($line.Contains("#NORM_EQ4#")) { $line = $line.Replace("#NORM_EQ4#", "(lgl OR vgl OR mgl OR tgl OR hgl)") }
        if ($line.Contains("#NITE_EQ4#")) { $line = $line.Replace("#NITE_EQ4#", "(xlg OR xvg OR xmg OR xtg OR xhg)") }
        if ($line.Contains("#HELL_EQ4#")) { $line = $line.Replace("#HELL_EQ4#", "(ulg OR uvg OR umg OR utg OR uhg)") }
      
        if ($line.Contains("#NORM_EQ5#")) { $line = $line.Replace("#NORM_EQ5#", "(lbt OR vbt OR mbt OR tbt OR hbt)") }
        if ($line.Contains("#NITE_EQ5#")) { $line = $line.Replace("#NITE_EQ5#", "(xlb OR xvb OR xmb OR xtb OR xhb)") }
        if ($line.Contains("#HELL_EQ5#")) { $line = $line.Replace("#HELL_EQ5#", "(ulb OR uvb OR umb OR utb OR uhb)") }
      
        if ($line.Contains("#NORM_EQ6#")) { $line = $line.Replace("#NORM_EQ6#", "(lbl OR vbl OR mbl OR tbl OR hbl)") }
        if ($line.Contains("#NITE_EQ6#")) { $line = $line.Replace("#NITE_EQ6#", "(zlb OR zvb OR zmb OR ztb OR zhb)") }
        if ($line.Contains("#HELL_EQ6#")) { $line = $line.Replace("#HELL_EQ6#", "(ulc OR uvc OR umc OR utc OR uhc)") }
        
        if ($line.Contains("#NORM_EQ7#")) { $line = $line.Replace("#NORM_EQ7#", "(ci0 OR ci1)") }
        if ($line.Contains("#NITE_EQ7#")) { $line = $line.Replace("#NITE_EQ7#", "(ci2)") }
        if ($line.Contains("#HELL_EQ7#")) { $line = $line.Replace("#HELL_EQ7#", "(ci3)") }

        if ($line.Contains("#NORM_EQ8#")) { $line = $line.Replace("#NORM_EQ8#", "(dr1 OR dr2 OR dr3 OR dr4 OR dr5)") }
        if ($line.Contains("#NITE_EQ8#")) { $line = $line.Replace("#NITE_EQ8#", "(dr6 OR dr7 OR dr8 OR dr9 OR dra)") }
        if ($line.Contains("#HELL_EQ8#")) { $line = $line.Replace("#HELL_EQ8#", "(drb OR drc OR drd OR dre OR drf)") }
        
        if ($line.Contains("#NORM_EQ9#")) { $line = $line.Replace("#NORM_EQ9#", "(ba1 OR ba2 OR ba3 OR ba4 OR ba5)") }
        if ($line.Contains("#NITE_EQ9#")) { $line = $line.Replace("#NITE_EQ9#", "(ba6 OR ba7 OR ba8 OR ba9 OR baa)") }
        if ($line.Contains("#HELL_EQ9#")) { $line = $line.Replace("#HELL_EQ9#", "(bab OR bac OR bad OR bae OR baf)") }
        
        if ($line.Contains("#NORM_EQ10#")) { $line = $line.Replace("#NORM_EQ10#", "(pa1 OR pa2 OR pa3 OR pa4 OR pa5)") }
        if ($line.Contains("#NITE_EQ10#")) { $line = $line.Replace("#NITE_EQ10#", "(pa6 OR pa7 OR pa8 OR pa9 OR paa)") }
        if ($line.Contains("#HELL_EQ10#")) { $line = $line.Replace("#HELL_EQ10#", "(pab OR pac OR pad OR pae OR paf)") }
        
        if ($line.Contains("#NORM_EQ11#")) { $line = $line.Replace("#NORM_EQ11#", "(ne1 OR ne2 OR ne3 OR ne4 OR ne5)") }
        if ($line.Contains("#NITE_EQ11#")) { $line = $line.Replace("#NITE_EQ11#", "(ne6 OR ne7 OR ne8 OR ne9 OR nea)") }
        if ($line.Contains("#HELL_EQ11#")) { $line = $line.Replace("#HELL_EQ11#", "(neb OR neg OR ned OR nee OR nef)") }


        if ($line.Contains("#WEP1#")) { $line = $line.Replace("#WEP1#", "(#NORM_WP1# OR #NITE_WP1# OR #HELL_WP1#)") }
        if ($line.Contains("#WEP2#")) { $line = $line.Replace("#WEP2#", "(#NORM_WP2# OR #NITE_WP2# OR #HELL_WP2#)") }
        if ($line.Contains("#WEP3#")) { $line = $line.Replace("#WEP3#", "(#NORM_WP3# OR #NITE_WP3# OR #HELL_WP3#)") }
        if ($line.Contains("#WEP4#")) { $line = $line.Replace("#WEP4#", "(#NORM_WP4# OR #NITE_WP4# OR #HELL_WP4#)") }
        if ($line.Contains("#WEP5#")) { $line = $line.Replace("#WEP5#", "(#NORM_WP5# OR #NITE_WP5# OR #HELL_WP5#)") }
        if ($line.Contains("#WEP6#")) { $line = $line.Replace("#WEP6#", "(#NORM_WP6# OR #NITE_WP6# OR #HELL_WP6#)") }
        if ($line.Contains("#WEP7#")) { $line = $line.Replace("#WEP7#", "(#NORM_WP7# OR #NITE_WP7# OR #HELL_WP7#)") }
        if ($line.Contains("#WEP8#")) { $line = $line.Replace("#WEP8#", "(#NORM_WP8# OR #NITE_WP8# OR #HELL_WP8#)") }
        if ($line.Contains("#WEP9#")) { $line = $line.Replace("#WEP9#", "(#NORM_WP9# OR #NITE_WP9# OR #HELL_WP9#)") }
        if ($line.Contains("#WEP10#")) { $line = $line.Replace("#WEP10#", "(#NORM_WP10# OR #NITE_WP10# OR #HELL_WP10#)") }
        if ($line.Contains("#WEP11#")) { $line = $line.Replace("#WEP11#", "(#NORM_WP11# OR #NITE_WP11# OR #HELL_WP11#)") }
        if ($line.Contains("#WEP12#")) { $line = $line.Replace("#WEP12#", "(#NORM_WP12# OR #NITE_WP12# OR #HELL_WP12#)") }
        if ($line.Contains("#WEP13#")) { $line = $line.Replace("#WEP13#", "(#NORM_WP13# OR #NITE_WP13# OR #HELL_WP13#)") }
        if ($line.Contains("#WEP14#")) { $line = $line.Replace("#WEP14#", "(#NORM_WP14# OR #NITE_WP14# OR #HELL_WP14#)") }
        if ($line.Contains("#WEP15#")) { $line = $line.Replace("#WEP15#", "(#NORM_WP15# OR #NITE_WP15# OR #HELL_WP15#)") }
        if ($line.Contains("#WEP16#")) { $line = $line.Replace("#WEP16#", "(#NORM_WP16# OR #NITE_WP16# OR #HELL_WP16#)") }


        if ($line.Contains("#NORM_WP1#")) { $line = $line.Replace("#NORM_WP1#", "(hax OR axe OR 2ax OR mpi OR wax OR lax OR bax OR btx OR gax OR gix)") }
        if ($line.Contains("#NITE_WP1#")) { $line = $line.Replace("#NITE_WP1#", "(9ha OR 9ax OR 92a OR 9mp OR 9wa OR 9la OR 9ba OR 9bt OR 9ga OR 9gi)") }
        if ($line.Contains("#HELL_WP1#")) { $line = $line.Replace("#HELL_WP1#", "(7ha OR 7ax OR 72a OR 7mp OR 7wa OR 7la OR 7ba OR 7bt OR 7ga OR 7gi)") }

        if ($line.Contains("#NORM_WP2#")) { $line = $line.Replace("#NORM_WP2#", "(clb OR spc OR mac OR mst OR fla OR whm OR mau OR gma)") }
        if ($line.Contains("#NITE_WP2#")) { $line = $line.Replace("#NITE_WP2#", "(9cl OR 9sp OR 9ma OR 9mt OR 9fl OR 9wh OR 9m9 OR 9gm)") }
        if ($line.Contains("#HELL_WP2#")) { $line = $line.Replace("#HELL_WP2#", "(7cl OR 7sp OR 7ma OR 7mt OR 7fl OR 7wh OR 7m7 OR 7gm)") }

        if ($line.Contains("#NORM_WP3#")) { $line = $line.Replace("#NORM_WP3#", "(ssd OR scm OR sbr OR flc OR crs OR bsd OR lsd OR wsd OR 2hs OR clm OR gis OR bsw OR flb OR gsd)") }
        if ($line.Contains("#NITE_WP3#")) { $line = $line.Replace("#NITE_WP3#", "(9ss OR 9sm OR 9sb OR 9fc OR 9cr OR 9bs OR 9ls OR 9wd OR 92h OR 9cm OR 9gs OR 9b9 OR 9fb OR 9gd)") }
        if ($line.Contains("#HELL_WP3#")) { $line = $line.Replace("#HELL_WP3#", "(7ss OR 7sm OR 7sb OR 7fc OR 7cr OR 7bs OR 7ls OR 7wd OR 72h OR 7cm OR 7gs OR 7b7 OR 7fb OR 7gd)") }
        
        if ($line.Contains("#NORM_WP4#")) { $line = $line.Replace("#NORM_WP4#", "(dgr OR dir OR kri OR bld)") }
        if ($line.Contains("#NITE_WP4#")) { $line = $line.Replace("#NITE_WP4#", "(9dg OR 9di OR 9kr OR 9bl)") }
        if ($line.Contains("#HELL_WP4#")) { $line = $line.Replace("#HELL_WP4#", "(7dg OR 7di OR 7kr OR 7bl)") }
        
        if ($line.Contains("#NORM_WP5#")) { $line = $line.Replace("#NORM_WP5#", "(tkf OR tax OR bkf OR bal)") }
        if ($line.Contains("#NITE_WP5#")) { $line = $line.Replace("#NITE_WP5#", "(9tk OR 9ta OR 9bk OR 9b8)") }
        if ($line.Contains("#HELL_WP5#")) { $line = $line.Replace("#HELL_WP5#", "(7tk OR 7ta OR 7bk OR 7b8)") }
        
        if ($line.Contains("#NORM_WP6#")) { $line = $line.Replace("#NORM_WP6#", "(jav OR pil OR ssp OR glv OR tsp)") }
        if ($line.Contains("#NITE_WP6#")) { $line = $line.Replace("#NITE_WP6#", "(9ja OR 9pi OR 9s9 OR 9gl OR 9ts)") }
        if ($line.Contains("#HELL_WP6#")) { $line = $line.Replace("#HELL_WP6#", "(7ja OR 7pi OR 7s7 OR 7gl OR 7ts)") }
        
        if ($line.Contains("#NORM_WP7#")) { $line = $line.Replace("#NORM_WP7#", "(spr OR tri OR brn OR spt OR pik)") }
        if ($line.Contains("#NITE_WP7#")) { $line = $line.Replace("#NITE_WP7#", "(9sr OR 9tr OR 9br OR 9st OR 9p9)") }
        if ($line.Contains("#HELL_WP7#")) { $line = $line.Replace("#HELL_WP7#", "(7sr OR 7tr OR 7br OR 7st OR 7p7)") }
        
        if ($line.Contains("#NORM_WP8#")) { $line = $line.Replace("#NORM_WP8#", "(bar OR vou OR scy OR pax OR hal OR wsc)") }
        if ($line.Contains("#NITE_WP8#")) { $line = $line.Replace("#NITE_WP8#", "(9b7 OR 9vo OR 9s8 OR 9pa OR 9h9 OR 9wc)") }
        if ($line.Contains("#HELL_WP8#")) { $line = $line.Replace("#HELL_WP8#", "(7o7 OR 7vo OR 7s8 OR 7pa OR 7h7 OR 7wc)") }
        
        if ($line.Contains("#NORM_WP9#")) { $line = $line.Replace("#NORM_WP9#", "(sbw OR hbw OR lbw OR cbw OR sbb OR lbb OR swb OR lwb)") }
        if ($line.Contains("#NITE_WP9#")) { $line = $line.Replace("#NITE_WP9#", "(8sb OR 8hb OR 8lb OR 8cb OR 8s8 OR 8l8 OR 8sw OR 8lw)") }
        if ($line.Contains("#HELL_WP9#")) { $line = $line.Replace("#HELL_WP9#", "(6sb OR 6hb OR 6lb OR 6cb OR 6s7 OR 6l7 OR 6sw OR 6lw)") }
        
        if ($line.Contains("#NORM_WP10#")) { $line = $line.Replace("#NORM_WP10#", "(lxb OR mxb OR hxb OR rxb)") }
        if ($line.Contains("#NITE_WP10#")) { $line = $line.Replace("#NITE_WP10#", "(8lx OR 8mx OR 8hx OR 8rx)") }
        if ($line.Contains("#HELL_WP10#")) { $line = $line.Replace("#HELL_WP10#", "(6lx OR 6mx OR 6hx OR 6rx)") }
        
        if ($line.Contains("#NORM_WP11#")) { $line = $line.Replace("#NORM_WP11#", "(sst OR lst OR cst OR bst OR wst)") }
        if ($line.Contains("#NITE_WP11#")) { $line = $line.Replace("#NITE_WP11#", "(8ss OR 8ls OR 8cs OR 8bs OR 8ws)") }
        if ($line.Contains("#HELL_WP11#")) { $line = $line.Replace("#HELL_WP11#", "(6ss OR 6ls OR 6cs OR 6bs OR 6ws)") }
        
        if ($line.Contains("#NORM_WP12#")) { $line = $line.Replace("#NORM_WP12#", "(wnd OR ywn OR bwn OR gwn)") }
        if ($line.Contains("#NITE_WP12#")) { $line = $line.Replace("#NITE_WP12#", "(9wn OR 9yw OR 9bw OR 9gw)") }
        if ($line.Contains("#HELL_WP12#")) { $line = $line.Replace("#HELL_WP12#", "(7wn OR 7yw OR 7bw OR 7gw)") }
       
        if ($line.Contains("#NORM_WP13#")) { $line = $line.Replace("#NORM_WP13#", "(scp OR gsc OR wsp)") }
        if ($line.Contains("#NITE_WP13#")) { $line = $line.Replace("#NITE_WP13#", "(9sc OR 9qs OR 9ws)") }
        if ($line.Contains("#HELL_WP13#")) { $line = $line.Replace("#HELL_WP13#", "(7sc OR 7qs OR 7ws)") }

        if ($line.Contains("#NORM_WP14#")) { $line = $line.Replace("#NORM_WP14#", "(ktr OR wrb OR axf OR ces OR clw OR btl OR skr)") }
        if ($line.Contains("#NITE_WP14#")) { $line = $line.Replace("#NITE_WP14#", "(9ar OR 9wb OR 9xf OR 9cs OR 9lw OR 9tw OR 9qr)") }
        if ($line.Contains("#HELL_WP14#")) { $line = $line.Replace("#HELL_WP14#", "(7ar OR 7wb OR 7xf OR 7cs OR 7lw OR 7tw OR 7qr)") }

        if ($line.Contains("#NORM_WP15#")) { $line = $line.Replace("#NORM_WP15#", "(ob1 OR ob2 OR ob3 OR ob4 OR ob5)") }
        if ($line.Contains("#NITE_WP15#")) { $line = $line.Replace("#NITE_WP15#", "(ob6 OR ob7 OR ob8 OR ob9 OR oba)") }
        if ($line.Contains("#HELL_WP15#")) { $line = $line.Replace("#HELL_WP15#", "(obb OR obc OR obd OR obe OR obf)") }

        if ($line.Contains("#NORM_WP16#")) { $line = $line.Replace("#NORM_WP16#", "(am1 OR am2 OR am3 OR am4 OR am5)") }
        if ($line.Contains("#NITE_WP16#")) { $line = $line.Replace("#NITE_WP16#", "(am6 OR am7 OR am8 OR am9 OR ama)") }
        if ($line.Contains("#HELL_WP16#")) { $line = $line.Replace("#HELL_WP16#", "(amb OR amc OR amd OR ame OR amf)") }

        if ($line.Contains("#HIDE"))
        {
            $line = $line.Replace("#HIDE", "{%NAME%%NL%%RED% " + $_.Name + ":" + $lineNumber + "}//")
        }
        if ($line.Contains("#TEST"))
        {
            $line = $line.Replace("#TEST", "%RED%HIDE / %NAME%{%NAME%%NL%%RED% " + $_.Name + ":" + $lineNumber + "}//")
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
Write-Host -NoNewline "Season 3 ... "
################################################################################
.\pd2season3.ps1
################################################################################
Write-Host "Done"
################################################################################

################################################################################
Write-Host -NoNewline "Maps ... "
################################################################################

$outputPath = '.\obj\catchall.maps.filter'
$inputPath = '.\obj\catchall.default.filter'
(Get-Content -Path $inputPath).replace("CLVL>94","CLVL>1").replace("CLVL>89","CLVL>1").replace("CLVL>80","CLVL>1").replace("CLVL>79","CLVL>1").replace("CLVL>69","CLVL>1").replace("CLVL>49","CLVL>1").replace("CLVL>29","CLVL>1").replace("CLVL>19","CLVL>1").replace("CLVL>14","CLVL>1").replace("CLVL>9","CLVL>1").replace("CLVL>4","CLVL>1") | Set-Content -Path $outputPath 

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

Get-Content '.\obj\1.quest.lod.filter', '.\obj\1.quest.pd2.filter', 
'.\obj\1.common.lod.filter', '.\obj\1.common.pd2.filter', 
'.\obj\1.bases.filter', '.\obj\1.bases.larzuk.filter', 
'.\obj\1.set.shared.filter', '.\obj\1.set.normal.filter', '.\obj\1.set.exceptional.filter', '.\obj\1.set.elite.filter', 
'.\obj\1.unique.shared.filter', '.\obj\1.unique.normal.filter', '.\obj\1.unique.exceptional.filter', '.\obj\1.unique.elite.filter', 
'.\obj\item.prefix.filter',
'.\obj\item.suffix.filter', 
'.\obj\item.shopping.charms.filter', '.\obj\item.shopping.jewels.filter', 
'.\obj\item.shopping.filter', 
'.\obj\item.colorfix.filter', 
'.\obj\item.description.filter', 
'.\obj\arreat.normal.filter', '.\obj\arreat.exceptional.filter', '.\obj\arreat.elite.filter', 
'.\obj\personal.filter',
#'.\obj\item.treasureclass.filter', 
'.\obj\catchall.filter', '.\obj\catchall.default.filter' | Set-Content '.\bin\personal.filter'

#(Get-Content -Path '.\bin\personal.filter').replace("%DOT-81%","%DOT-81%[%CODE%] ").replace("%DOT-0D%","%DOT-0D%[%CODE%] ") | Set-Content -Path '.\bin\personal.filter'

if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2 - Debug\ProjectD2') { Copy-Item '.\bin\personal.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2 - Debug\ProjectD2\loot.filter' }
if (Test-Path -Path 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2') { Copy-Item '.\bin\personal.filter' -Destination 'C:\Program Files (x86)\Diablo II - PD2\ProjectD2\loot.filter' }
if (Test-Path -Path 'C:\Program Files (x86)\Diablo II\ProjectD2') { Copy-Item '.\bin\personal.filter' -Destination 'C:\Program Files (x86)\Diablo II\ProjectD2\default.filter' }
if (Test-Path -LiteralPath 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg') { Copy-Item '.\bin\personal.filter' -Destination 'C:\Program Files (x86)\Diablo II - Cactus\BH.cfg' }


################################################################################
Write-Host "Done"
################################################################################

