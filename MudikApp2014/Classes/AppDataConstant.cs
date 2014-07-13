using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MudikApp2014.Classes
{
    public class AppDataConstant
    {
        #region Jalur Utara

        public static string JalurUtara = @"{
   'routes' : [
      {
         'bounds' : {
            'northeast' : {
               'lat' : -5.9314301,
               'lng' : 113.9954432
            },
            'southwest' : {
               'lat' : -7.7912822,
               'lng' : 106.8296081
            }
         },
         'copyrights' : 'Data peta ©2014 Google',
         'legs' : [
            {
               'distance' : {
                  'text' : '79,4 km',
                  'value' : 79391
               },
               'duration' : {
                  'text' : '1 jam 10 menit',
                  'value' : 4182
               },
               'end_address' : 'Cikampek, Karawang, Jawa Barat, Indonesia',
               'end_location' : {
                  'lat' : -6.4000794,
                  'lng' : 107.443756
               },
               'start_address' : 'Pelabuhan Merak, Indonesia',
               'start_location' : {
                  'lat' : -5.9314301,
                  'lng' : 105.9973755
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '8 m',
                        'value' : 8
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 1
                     },
                     'end_location' : {
                        'lat' : -6.2087167,
                        'lng' : 106.845536
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003ebarat\u003c/b\u003e di \u003cb\u003eJl. Minangkabau\u003c/b\u003e menuju \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rs{d@ahckS?@CJ'
                     },
                     'start_location' : {
                        'lat' : -5.9314301,
                        'lng' : 105.9973755
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1354
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 247
                     },
                     'end_location' : {
                        'lat' : -6.205222399999999,
                        'lng' : 106.8338468
                     },
                     'html_instructions' : 'Terus lurus ke \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'maneuver' : 'straight',
                     'polyline' : {
                        'points' : 'ns{d@sgckSSp@Od@GRwA|FYfAIZQt@q@~C_@~Aw@xCi@xBg@zB_@zACJk@rB[fAOd@GRg@dBMb@ETGf@I~@OtBa@bEGdA?DUhCCV'
                     },
                     'start_location' : {
                        'lat' : -6.2087167,
                        'lng' : 106.845536
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 434
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 42
                     },
                     'end_location' : {
                        'lat' : -6.204655,
                        'lng' : 106.8299688
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eGalunggung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'r}zd@q~`kSEf@Gv@Ix@Eh@MhBEjAE|@K`BQfBOvAIl@'
                     },
                     'start_location' : {
                        'lat' : -6.205222399999999,
                        'lng' : 106.8338468
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 248
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 29
                     },
                     'end_location' : {
                        'lat' : -6.2067305,
                        'lng' : 106.829347
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. H. R. Rasuna Said\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'bzzd@if`kSjADfABTAX@PBN@RF`@Pt@^XNPL^R'
                     },
                     'start_location' : {
                        'lat' : -6.204655,
                        'lng' : 106.8299688
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,7 km',
                        'value' : 3662
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 341
                     },
                     'end_location' : {
                        'lat' : -6.236591799999999,
                        'lng' : 106.8275078
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. H. R. Rasuna Said\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`g{d@mb`kSxB_At@W|@Y@Ab@Mp@U\\In@Mj@G\\EtBSdBM~@Er@C^AxACn@?fC@pA?L?xAEdCCj@CjAEbAE`BEnCKx@Cx@GVC^IZELCl@IB?LCPCXC@AXCf@Il@Kd@In@MFAZIbAUj@Mx@UJEfBm@nAc@@?|@SrAWjAO|Ce@BAt@KDAxB_@r@MB?PEhEOB?tBGTAP?R?\\Cf@CdIWZAlBGB?B?F?jBEnAC`@@fAFr@Hb@Hj@LpB`@VFhA\\NH|An@f@Vv@j@nApAl@n@NPd@l@h@z@\\p@^z@b@lATj@HR\\|@\\t@DHX`@d@p@LL@BHFTPPNdAt@DBVL@@HDTLDBx@b@?@JF'
                     },
                     'start_location' : {
                        'lat' : -6.2067305,
                        'lng' : 106.829347
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 449
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 53
                     },
                     'end_location' : {
                        'lat' : -6.238815,
                        'lng' : 106.830893
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Jenderal Gatot Subroto\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'taae@}v_kSJSbByCv@yABA@CBEJUXi@FMHKP[PYLSTYJKFMT]JUb@u@\\q@R['
                     },
                     'start_location' : {
                        'lat' : -6.236591799999999,
                        'lng' : 106.8275078
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 217
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 21
                     },
                     'end_location' : {
                        'lat' : -6.2398208,
                        'lng' : 106.832572
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Kapten Tendean\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'roae@al`kSfEoI'
                     },
                     'start_location' : {
                        'lat' : -6.238815,
                        'lng' : 106.830893
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,5 km',
                        'value' : 5456
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 327
                     },
                     'end_location' : {
                        'lat' : -6.2474568,
                        'lng' : 106.88064
                     },
                     'html_instructions' : 'Ambil jalan di \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Tol Cawang Grogol\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'zuae@qv`kSf@i@BENQR_@h@uA`@}APaAFc@?_@VgBF_@RyAXeBDQ@C@CBAFAv@uFlAoHz@iG\\mBTkAfAeCJU\\w@HWFOFWFYDWD_@@E?I@E?A?I@I?G?A?G@G?E@a@B{A?C?[@{@N}G@qA?_@CsACiACg@Ai@Au@IwCOqFCaAAm@GmACkB?]?{B?gAAuA?I?uA@sA?G?_A?w@?E@_B@mQ?o@AO?C?U?G?I?gACu@EeDCuCCsH?uB?WFeBD_ADo@Hw@LsAD]PkAVkA`@aBTy@@Gj@wBfAyDNi@@A@E?ALc@tAoFNk@@GPq@rAoGBKl@aELy@RyAVyB`@qDD]@O@?B[BM?EDSLcA@KBMD[d@qD@ABSBSd@gDBOR_BBQPsAZmCVuC'
                     },
                     'start_location' : {
                        'lat' : -6.2398208,
                        'lng' : 106.832572
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '53,1 km',
                        'value' : 53139
                     },
                     'duration' : {
                        'text' : '39 menit',
                        'value' : 2326
                     },
                     'end_location' : {
                        'lat' : -6.3539172,
                        'lng' : 107.3283817
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Tol Jakarta-Cikampek\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'rece@_cjkS?YBsA?uA?oAAeACc@?AO}GO{BIg@Io@Qu@Qq@So@Si@Yk@Wm@[m@o@kA]k@u@eAy@iAe@s@[m@EIMSCGmAmBcAoBSk@a@_BO}@U}BOiC?{BFoBFu@Jq@`@wBZqAf@cBt@cB|@mBz@sAbAsApAwAnBeBjB{AvBsA~CgBrC{AtBaAnCuAdB}@nDsB|@y@`@_@jAcAzAeB`BsB~AmCz@sBd@{AxAcEv@}Cn@gB`AwC~AkGJ]lBsGfAgEP_A|@_FXiBH_ANsAJoB@c@DmADgB@gGCmE?IAcAU_LG}F[uN?Am@oZAQw@ye@q@s[AYAi@I{DEmDA]A}AC}A?_@GeCQyEAcACkBAgAEcKCkBMoFAaA?S?E?yAGwBO_GI_DE}BCwAIqBOyDIwBCY?CCWAGCg@?C?CC[?AIw@E]a@{DCQIs@Gm@OkAMy@Mq@Kk@GYQs@_@mB}@yD]mAOg@[eAo@kBoCgHoAcCO[{@{A]o@y@{Aw@uAIQCGIQCCYi@QYS]aAeB}@cBm@gAo@eAIQqAsCAAm@qA_@gAkAaE]_Bg@cDAE_@mCSsBIkAIeBEkBAiEFuB@_@\\uFPsABKh@_Dn@uCj@iBF[HUvBkGbAcCpDeJBGBGHShBmEFQnAeD\\aAx@wBj@cB^wADM?AFO?ABGLg@|Kkc@?A@?BMf@sB|@uDnAeFvCkLBGdCcK?ADO?CHWfBeHr@uCJc@?CBIrBqI~B{IzBgJBGDSvAqFdCiKhDeNBMPq@p@mCz@mDlFgT@C^yAtKoc@@C^}ARu@tBiIvAgGrDuNrAqF|D}ONo@l@sBbCyIjGmRjAiDDMrKi[XcAlFmQ`@cB?ADQdCsJHa@nBkI~Iob@l@sCt@qDt@iD^eBjIe`@lAyF|AgHnAqGnA}FFWjAcF~ByKnBuJBGFY|@aEz@_EjHy\\rDyNjB{GtCsJL_@@EHWz@uCpD_Kd@sA`BoEzB_G`A_CxCoHJSJW|DsIvBoEbFeKdDaHxCeGHQ~AiDx@cBxD{H|BsEL[Pe@tAoCJSR_@z@eBVo@jB{Dh@kAp@uAh@iAd@aAXk@Xm@`AoBlByDrE}IjAmCHS`E_J~c@u~@BGBAlEaJ`GaMDIDGR]Te@Ti@b@}@P_@p@uAf@eA`AsB`AsBd@eATc@\\u@fA_CbAwBj@kA\\w@@ATg@JQ`@s@jAoClDyG~AeDrEiJjAeC`CaFtBeElAeCTc@zC{GxBqEnAyCzAeDnAuCvBkFpBcFxB_GxAyDL]f@oAn@wB\\qAbC}Hj@eBDOBItBaH~@kDdAaEj@wBh@uBzBcJ~D{OzAmGrCyKhD{M`DiL\\cBRu@?AFUbDqLvAwEPa@N]jAuCb@aAJWzBwE@Cn@oA~@gBt@qAh@{@PYrB}CbB{BdCaD?A`@g@DGd@m@FGdAoAr@_ArAaBnAwARWBAZa@b@i@RYRWTWX]`@m@z@kAbAqAJQNWT_@LSHMT_@@Ab@u@b@s@n@eAj@cADIh@gAlB_EhAgCv@qBN]HWzAgFt@yBTq@XkAv@_DPs@Lu@~AmHZsBHu@n@uE^wCr@kGJq@BK@IFYv@qGTeBNaAVsAXmCR}AXeCHm@Dc@ZiCToBLmAf@sDZyBTkBBWLw@XwBHi@h@uEX_Cj@qENaAt@wFFg@BWJeAD[j@qEj@cG?SJeAFyALeC?C@qBFkC@aFGgCEwDO{DUgDUaD]}Ce@}Cc@wCWcBYqAgG}TcCiH}DsL}BmH{@aDwAyGmA{G{@{Hc@wEYiEOsF?uG@iFP{JBmADsADkBHuEJyF?UHcFDeCN_ELoEFqBDsCDmBFcDH}DJqH\\qONwF@S?SLuER{IPiJXyO?qALsFNcEL_G@K?CHoFF{CBw@@]^wSRmK?AT{IHuDhAoi@x@wWjAgRlAaQ~@_JtBgQZkCf@cDF[BM@M`BaK'
                     },
                     'start_location' : {
                        'lat' : -6.2474568,
                        'lng' : 106.88064
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 402
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -6.3547196,
                        'lng' : 107.3319132
                     },
                     'html_instructions' : 'Ambil jalan keluar\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'maneuver' : 'ramp-left',
                     'polyline' : {
                        'points' : '~~we@kqanS?o@Hy@\\uCZgCRyAXkATgAPu@DU'
                     },
                     'start_location' : {
                        'lat' : -6.3539172,
                        'lng' : 107.3283817
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 569
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 32
                     },
                     'end_location' : {
                        'lat' : -6.3527084,
                        'lng' : 107.3365423
                     },
                     'html_instructions' : 'Tetap di \u003cb\u003ekiri\u003c/b\u003e di pertigaan\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'maneuver' : 'fork-left',
                     'polyline' : {
                        'points' : '~cxe@mgbnSBqACy@Cc@GWE[IYMe@IQSe@MW]o@a@{@OYIQU]e@cAg@eAa@u@Uc@Wk@Oa@ISISIY'
                     },
                     'start_location' : {
                        'lat' : -6.3547196,
                        'lng' : 107.3319132
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,1 km',
                        'value' : 1114
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 102
                     },
                     'end_location' : {
                        'lat' : -6.353434999999999,
                        'lng' : 107.3456837
                     },
                     'html_instructions' : 'Terus lurus\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol sebagian\u003c/div\u003e',
                     'maneuver' : 'straight',
                     'polyline' : {
                        'points' : 'lwwe@kdcnSIMi@cAg@aA[q@AEOa@I[CQES?SAWAY@O?EBWBYDWH[HULYZo@v@wAv@wAl@gAh@_Af@}@Ve@P]BGZs@L[H]HYJg@DYFY@a@@m@?c@Ac@Ei@Ec@AEEYEOEU]iAi@uASk@Oc@GO'
                     },
                     'start_location' : {
                        'lat' : -6.3527084,
                        'lng' : 107.3365423
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,9 km',
                        'value' : 1944
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 97
                     },
                     'end_location' : {
                        'lat' : -6.362774399999999,
                        'lng' : 107.3597147
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Raya Klari\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '|{we@o}dnSn@Od@Ob@Mx@WPGxAc@`AYj@Sb@O`@S\\Ud@]NK\\Wp@k@x@q@b@_@x@s@n@y@t@eBVw@J[FYDQDSFYHYHYL]@GFOHUN[Ta@\\k@Ta@Xe@b@w@Na@BGRg@JYRm@FQ`@aAFSTk@`@gA\\eAFUPm@r@}BFUn@kBV_Ah@eBz@uCp@aCDM~@oCd@sAPi@Pg@p@mB'
                     },
                     'start_location' : {
                        'lat' : -6.353434999999999,
                        'lng' : 107.3456837
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,5 km',
                        'value' : 5525
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 277
                     },
                     'end_location' : {
                        'lat' : -6.3873269,
                        'lng' : 107.402477
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya kosambi\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'hvye@eugnSvBuG@?L_@j@wA?Aj@_B@Cr@qBn@mB^kAXw@Rc@JSt@mA^m@JQPYNUt@kAp@mAVk@r@_Bn@_BX_An@oBfAeDt@_C|@sC|@mC|@mCf@{Af@_BjAuDt@cCd@}AJc@Lc@ZeAXkA^sBDWBQ^gBT{@Tm@Te@j@aAlAeBb@q@^k@bA}AT[x@qA^o@Rg@Rg@Le@BK\\wAd@qBPq@b@eBb@cB`@uAZ}@x@}Bn@wAz@iCl@iBFQFO\\y@BIb@iA\\{@d@kAj@wAhBqE^{@JSNU@CZg@Zc@LQT[b@k@lBeClBmBdAeATSv@w@bCuBVWjAgADEdAaAn@k@@APOp@o@TQz@w@r@m@BCh@a@hBwA~@}@dAyAHOhBwC|B_EDI^q@`@s@LUd@w@\\i@~@cBJQv@wAVi@JQ\\w@Vo@d@oADKVq@ZaA'
                     },
                     'start_location' : {
                        'lat' : -6.362774399999999,
                        'lng' : 107.3597147
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,9 km',
                        'value' : 4865
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 243
                     },
                     'end_location' : {
                        'lat' : -6.400034499999999,
                        'lng' : 107.4437762
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. A. Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'xo~e@o`pnSZsALg@d@{BHY^kB@Gh@}CN_ADYJu@Jy@HcAPsCFy@B]FuAD_B@MHwEHoEH{HDwC?G@uA?a@?yA?c@?Y?[@a@By@Bo@?ODs@JyCBe@Fy@Bc@Hu@De@R}BRyBLkA@IJoAJmARmBN_BNoAPkAN{@Pw@Rs@Vw@Xw@^kAv@_CTq@J]L[BCd@y@Xi@p@wANYx@iBP]JWP]\\q@DIh@cAh@{@HQrAyBBExBoDLUbAgB`A{Ab@q@b@s@DGR[Pc@DMJSRo@Tq@BOHYNq@@C^}Ap@mC@ERy@H]@EJc@Pq@FSDQ@E@EFSF_@Rw@TeA`@sBPoAJq@T}A`@sCVkBL}@Hc@N{@BU@IRw@l@yA^y@xA{CBEdBoDn@yA|AkD'
                     },
                     'start_location' : {
                        'lat' : -6.3873269,
                        'lng' : 107.402477
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5 m',
                        'value' : 5
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 20
                     },
                     'end_location' : {
                        'lat' : -6.4000794,
                        'lng' : 107.443756
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Jend. Sudirman\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'd_af@sbxnSHB'
                     },
                     'start_location' : {
                        'lat' : -6.400034499999999,
                        'lng' : 107.4437762
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '113 km',
                  'value' : 112934
               },
               'duration' : {
                  'text' : '1 jam 38 menit',
                  'value' : 5855
               },
               'end_address' : 'Indramayu, Jawa Barat, Indonesia',
               'end_location' : {
                  'lat' : -6.3374953,
                  'lng' : 108.3254188
               },
               'start_address' : 'Cikampek, Karawang, Jawa Barat, Indonesia',
               'start_location' : {
                  'lat' : -6.4000794,
                  'lng' : 107.443756
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '5 m',
                        'value' : 5
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 0
                     },
                     'end_location' : {
                        'lat' : -6.400034499999999,
                        'lng' : 107.4437762
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etimur laut\u003c/b\u003e di \u003cb\u003eJl. Jend. Sudirman\u003c/b\u003e menuju \u003cb\u003eJl. A. Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'n_af@obxnSIC'
                     },
                     'start_location' : {
                        'lat' : -6.4000794,
                        'lng' : 107.443756
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,0 km',
                        'value' : 2002
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 100
                     },
                     'end_location' : {
                        'lat' : -6.4079617,
                        'lng' : 107.4599498
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. A. Yani\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'd_af@sbxnS~@uBN[j@gApAsCr@_B|@kBDKFK^{@NYN[dA_C\\u@Tk@Vi@`@_AN]BEFQVm@x@mBDIZs@Vk@Vk@fAaCn@mA^y@x@iBZu@Re@Pa@Zu@Vk@l@uAf@kAPe@v@kBHON[Pc@FMHQdAiCL[Ts@Tq@Jg@Ja@RcAd@mDv@iF'
                     },
                     'start_location' : {
                        'lat' : -6.400034499999999,
                        'lng' : 107.4437762
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 328
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -6.408465199999999,
                        'lng' : 107.4628643
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. A. Yani\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'vpbf@ug{nSAKAG?IFc@NeALgAXyBPmAJuA@OHgA'
                     },
                     'start_location' : {
                        'lat' : -6.4079617,
                        'lng' : 107.4599498
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,5 km',
                        'value' : 2519
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 178
                     },
                     'end_location' : {
                        'lat' : -6.4086405,
                        'lng' : 107.4855134
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Jendral Sudirman\u003c/b\u003e',
                     'polyline' : {
                        'points' : '|sbf@{y{nSDs@Fs@JkBHaADu@Bq@Bg@BW@K@E@C@ABCFeCHwBJuCJ{BNmCViGFeCFiCFeEBoABwADyABaADyADcABy@?EBiAFoAFaBB}ADiABs@Bq@?q@?a@Ck@EeACs@Ca@C[Ei@C[Gw@IgAEi@WoDU}BQmBQ}BWgDAEIw@Gq@Ck@E_ACa@CYAQCMCK'
                     },
                     'start_location' : {
                        'lat' : -6.408465199999999,
                        'lng' : 107.4628643
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,2 km',
                        'value' : 4165
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 209
                     },
                     'end_location' : {
                        'lat' : -6.3812973,
                        'lng' : 107.5095736
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Pangulah\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~tbf@mg`oSOc@AACIO[CEa@{@gAkCi@mA[w@EGAAk@{@U[c@g@s@s@AAo@o@iAkACC_@]{AwAGGu@i@eAy@QOSMMGYK[IYGg@IYGA?_@Ii@Ie@IQC]GYICAKC{Be@[GWIa@I_Ba@i@SQKMKEEGIU[a@s@]q@Wa@]k@Wa@gEkGEGS]MQCCOU[e@SWIICEKKEEEEMGMGKEQGc@K}@Qk@K_ASQEc@ISE_@I[GYGICk@Ia@KUISIQMMIKGKICCKIWUOMSOOM_@[AAk@a@USKKAAKIGIIIIKIMGKMOKQEIGIW_@Wc@]g@k@w@U_@UW[e@Y_@U[QYQSYa@SWOUg@o@c@e@QSOO}@}@q@q@{@y@sAsAaA}@q@q@CCWS]]]Ua@WUOSMSOSKOMMIc@_@MMQOUUGGIIOQSUIMCCKO[_@OUi@}@a@k@Ya@k@w@]i@i@w@Ya@W]U]SWSWQUMOIKa@i@UWWYUU[WWUQKUQWOYOYMSMy@_@e@Qe@OeAa@_AWi@Qa@KA?oA]q@Sa@OKEICIGIE'
                     },
                     'start_location' : {
                        'lat' : -6.4086405,
                        'lng' : 107.4855134
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,3 km',
                        'value' : 3309
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 166
                     },
                     'end_location' : {
                        'lat' : -6.3649898,
                        'lng' : 107.5329338
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Jatisari\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bj}e@y}doSCAKIMIIKIGEIEGEEEKCICICGESSw@Ow@AGMi@M_@CMK]KYKYKYGQGMGIGMKKKKOMOIIGECKGKEg@YYQOKQOWU]]gBkBq@q@CCu@u@{B}BgAkA_BgBqAsAc@c@MMwAyAOQq@q@MKgBeBWUUSWWUSIIIKW[_@i@_@i@KQo@aAc@q@S]IMGKCIEIEMGOM_@Qm@Sg@Uo@KUYq@S_@Q]KOIKMOQOKKSMOK_BcAiC}AcC{Ao@_@UM_Ak@QMUOWQOK_Aq@CCu@i@iAy@_@[UQQO[[SSOUMQGMGM]aAO_@IYUw@EMOc@Qs@GQuAgFs@oCc@aB?AOi@CSCS?WHi@Da@b@uCHu@@OBQ?M?U?SAQEg@Mq@G]Oq@GM'
                     },
                     'start_location' : {
                        'lat' : -6.3812973,
                        'lng' : 107.5095736
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 610
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 30
                     },
                     'end_location' : {
                        'lat' : -6.3633685,
                        'lng' : 107.5381058
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Pangulah\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ddze@yoioSi@qA_@{@Wm@Wk@i@qAe@uAW}@c@cBQ}@Kq@M}@Gg@Ks@Gc@A[?W@i@Bc@Di@'
                     },
                     'start_location' : {
                        'lat' : -6.3649898,
                        'lng' : 107.5329338
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '88,9 km',
                        'value' : 88870
                     },
                     'duration' : {
                        'text' : '1 jam 14 menit',
                        'value' : 4448
                     },
                     'end_location' : {
                        'lat' : -6.4041248,
                        'lng' : 108.2676289
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eRaya Cikalong Sari/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : '`zye@epjoSDSFWHYPi@L]HSP[PULQ~@aAxAwA~@cAz@{@PQ|@{@dAeAVW`B_B|@_AXa@JQJQFOFMJ]ZeA`@uAL_@L_@BK^mAZgA\\iAZcAX_Ab@sAb@oAHURo@Z}@VaARq@FWTw@ZeA\\kAb@yALc@X}@Ng@`@{ANq@VeAj@gCTaAb@gB^yAJc@Nk@XmADO?AR{@FU\\uAf@sBDOR{@FSXkAb@iB`@cB`@aB`@cBf@qBDOd@qBl@cC`@aBNm@^yAZuABKNu@FYBUD[HcAFy@JeAFmA@KH_BBs@Bo@@_@@aAFeBDaB@_@@q@ByAFcBDoBFuBDkBBiABi@B{A@KB}A@WBaAD}ABaA@y@DsA@a@D_ABk@LyAXeE@ETiDJsAFeAhAgPFQ@KHqAPkC@?@WDc@TcB^mBH_@Jc@Ji@BMPu@Pw@@GDMRgAH_@BIPw@Ji@Z{AReAH]@APy@`@qBFWhAoF?AHi@`@_CZuBT{AJs@j@mDL}@PkALw@?CBOD[RmABSRkAVgBT}A`@iCv@_FViBHe@RuAHk@Hc@D[?AJs@Jk@Hi@D_@Ji@D[Jk@DWHm@He@Js@Hi@NaAJo@Jy@Js@BO@O@Q?M?MASAYCQCS?CI[GWEMGKKSMQW_@MOm@q@CEa@c@QSUWeGgHq@y@y@_Ak@s@_AeAs@y@g@m@]c@uCkDe@k@s@w@a@e@i@i@[_@QUOYQc@[{@Ma@e@kAAEM]AAk@}Aq@kBoAgDiAcDWs@kBmFo@eB[{@KW]_A]}@Qe@Ma@]}@Oe@Sk@[y@M[Ma@M]CGKYg@sAEKIUQi@KWSi@m@eB]{@]aAw@yAIOQY_@k@]e@We@a@s@oBwCsB}Cy@oAyBmDcBkCgBuCm@}@mBwCiCgEiDgFOUiAiBw@iAyAeBmA}AcG{Ga@e@aGaHoD{Ds@w@yCeDyDeE}DqE}@aAe@i@]e@o@_AcA}AyBiDcAiBs@mAcAmB}DiIu@{Au@eBWi@eAsAw@{@_EyDyA_BgAiA{Q{QgAeAmAgAaCgC]_@]]CC_EkE_@i@uAgC}@cBSa@Wk@KSMWQc@sBuDq@kB[cAG[Ee@C_@Ca@?]CiAAYUcH@s@DcC@KB[Ba@?QDaA?C@uAAYO}AS}AQw@]eASi@k@mAa@y@Ua@qBkCk@w@k@s@AEaCiDACW]yAkBqCwDs@_AeAoAe@o@QYa@k@u@gAYa@gA{AEGgAyAo@}@g@s@_A}AoBeDkAoBMSACuAmCq@wA}@aB?A]o@s@kA]g@c@k@}@aAmAkAwDiDy@w@yCsC_A{@qDgDm@m@{AwAQQ_CsBq@m@{@w@a@]SSQOeA_Ae@c@_CuBo@o@wAuAYWWWi@i@e@c@cEwDiAeA_B{AoAkAs@m@k@k@IKMOGKIO]s@Sc@_@s@w@eBsAyCCEM]GYGYC[AIAu@?G?e@?ADyBB_BBcA@[T_G?KJeCFw@Dm@Bg@?[@EAe@Ck@Gg@COCOEMGMIOMSMUs@y@mBuB]S_@_@_EuDKIm@m@{@y@e@g@[_@OWUa@GOCGAIAMMSEKSi@aB}EWy@k@kBEKW}@CI}AeFwF}PSm@Ws@cFgOcBeFy@cCIWCIAQEQGG?A{@cCEImAsDc@aBq@uC]cB{@wEm@yCI]Oy@g@cCk@sCM}@o@uDgAkHaBeKi@iDq@yEE_ACQ}@aGs@wEe@_Dm@_Ec@wCU{AU_BGa@QkAYsBUyAMy@G]CQc@{CE[]aCa@sCWaBOgAW}A?AUgAKi@SeAs@mESgBCOOiBIy@EWE_@O{@Iq@U{AQkAAKU}AM}@U_BQiAOeACIUyAQqAKm@CSi@mDIm@Mq@a@qCu@}Es@uEW}AYeBs@yEEWO}@AMg@{CYaBS_ACMKc@Mi@Y_BQeAK}@UyBQ}AIq@AGc@wCq@eEy@gFwAoJg@iDg@}Ck@aDIs@Ko@OaAi@oDEQYmBEUs@yEUmAWkAIa@GWc@aC]}BMaAOwAEk@Gc@Io@Ge@Ii@CQYsBMaAu@{EMw@?EEQg@oDSmA_@cCAGIe@AIGg@Ga@CUWgBg@eDc@sCE]Ic@]wB?ACOIi@AGIc@CUa@_CYkBMw@G]OeAa@aCU{ASiACUGa@My@Mw@Mq@i@sD?CIa@]uBSsAIi@CMCSi@gDi@kD?CIg@QeAU{AOeAKo@G]EYi@oDCOCOk@sD?AMu@AEGe@Mo@E[g@iCI[_@mBIi@G]Mw@QgAEe@Ca@Gq@Ky@Y}BKi@MaACKQiAEWIi@AKKq@AEM{@AAGg@O}@QqAKu@AKWcBWcBO_A_AwG[oBSuAG_@CMUkBm@{DM}@E_@O_AAMm@_Ee@aDAE?ACIS_BCKQqAAGCICWUqBEWAEGc@AMYuBCQOoA]mCKy@y@wGEWCUCWWoBe@{DGe@W}BQcBK}@a@sCUaCGe@Kk@AIAGSaAQcAGa@CSAOAKAMAU?g@B{@FsAF{A@K@}@AWAQAU?KSiAQg@Ug@MQIM[_@qAsA[YMMo@o@}A}Ao@w@EESSQUOSU_@KWIWEOEa@?a@@c@@KD_@DMJa@p@cC\\iAH]HYDQBa@Ba@Cu@QcAOq@GSCGYmAOm@a@kBUeAUgAUsAEWe@qCSqAQkASoASwAQwACU]kCMeAAMWuBYgCK_AKg@_@sD_@kD_@wD?I_@yEI_AS}BEcAUoGIcBEcBC{A?s@?q@Bo@JcAPwA`@qCt@_FD[L}@PgAPmARqAJ}@\\eCFe@TaBTmBBU\\iC\\gC^qCDWL}@ZwBBOH}@Jq@f@qDTaBJ_ARqARwAPsARuAPeABKJq@FYFe@Dm@`@sBp@}Df@wCb@gCj@uDb@qCFa@\\oBXcBF]ZgBVuAJa@Lm@T}@n@iCPo@`CmJdAcEBMr@mClFiSx@{CJc@`@yADMt@oCp@oCBI^yAvAmGhAuF~@oEz@_EfAsFP{@b@qBbAaFDU`AoEVqA\\_Bt@sDZyALg@Ns@r@iD\\_Br@cDhAoFBIlAyFh@gCj@aCh@{BTeAR{@BE~@uDBMj@sBx@sCLc@jAsDxB{GvDgLlBwFhH{SbAwCnAsDpAqDpAwDVs@x@_CJYDMr@mBr@yBvA_E`@kAZ}@Ri@Rm@^eA\\}@DI\\}@Xo@Pa@Zs@Xw@^mA`@cB\\uAZqALm@BMNiAj@mE^wB`@wCRyAHk@Ly@BSJ}@ZeCD_@@KR}ANkA?ATmBTeB^wChC}S`@gDb@_D\\iCV{BJ}@TmB`@oDf@gEbBgNFa@VyBR{AHo@BQViBh@qEx@{GXcC`@gDVsBV{BL}@@KdAoKBORiBbAcJJ}@VwB^gDN}ANoBB]RaCD}@HuAFwA@QVsEDy@@[FoA@w@BaAWuVE{CEaFKeI?yC@kAFsAJuBf@eFTaCZeDJiA`AeKFyAAg@Ag@@y@Bq@B[BUh@iCDSNi@TqAHa@@Gb@_ELeAFk@j@yE@KZmC`B_OP}ABS|@uH\\mCf@_EBU@C@GNmAD[NsAJkAHy@@EJgAf@qJDk@HuB@QJcCR_D@E@YJ_B@IJmBBg@DaA@W@OL}BJwB@IV_FFqANoCNeEBeBAiE?_CCsLAuBCmBACC{BAyEFsC?m@@gB?cD?oAAc@C}BGsDAqAEyBAo@GqCCgACeBEiAA}@CmAG{AGwBCuAKmEEyA?GGqCIoDGeDKeEEcBI{AEqACy@GiBOgCIeCUiEO{DOiDMwBSkDCg@AWUiFS_DGoAAQIeACi@GmAEm@O_DOeDCcAI{CEgBCcDAaD@uC?e@?C@aBBu@BmBFaBHaCBc@PwDPaELyBB[ZaHXgFLyBLoBD[BUL_Av@sERmAh@_DTmAr@eEN}@bAcG`@aCj@cDHc@XoBXeBFa@\\aCx@yF`@iC|BaNRoARkADS`@_Cn@sCT}@Tq@N_@N[R_@NWT]jAoBp@iAVe@jAoBLSfAoBfDyFh@}@r@mA^o@lBcDbAqBVi@|@eBhBkDl@qAx@qBpAcDRg@HSHQ\\s@j@gAz@sADGt@gANWNUR_@DIDIFGFGHGHEHGHEDANGRIjBy@^QNINKDEFEDE@CBC@CDGDIZkAJe@@EH_@BKDIHUr@}Ar@_Bf@iAXo@?AN]RWNSt@y@p@q@f@g@RSpBoBDE`C_CfAeANQrAqA~A}AhAaAzAgAt@c@fT{MfBkA~AcAnCeBrFqDn@c@hA}@\\]X]`@g@fCsD@Aj@u@v@gAfAqAbAgAr@s@RQJIJKbJuId@a@fB{Av@s@tAeAVS`@WhAq@ZQFCnBgAvAy@xBmAjC_Bl@[RKd@[JGFC@AHEjFmDjCoBrBwAJIhDoBj@YPMRM^UTQHGDGHMJ[Tq@@ATm@Te@NQXU@Al@_@|BuAj@[BCDC@AbAq@b@]DCVQn@i@fDiDj@k@RSvB_CRWh@q@`@g@fAuAj@s@dBsBPUhAuAb@i@v@{@fAoAjAoApBuB`CaCBC|A{A~@{@n@m@hAcAPOlBaBxD{CHGlB}AdA{@`BoAbBwAdAw@bBqAVU~@q@bAy@TQr@i@l@g@b@[JIt@g@FEXSDEPMfDaCpDiCJItAcAjA{@p@k@r@m@^]\\_@j@q@BCfAsAbBqBT[NQbAkAf@m@BCZ_@\\a@?Ah@s@bAuAXg@T_@HMt@qAb@u@P[JQf@_ATa@HQDIL]Le@Ji@b@gCDMDML[HQ@EJUXo@JQFKTe@NYXk@Xg@`AiBR_@p@iAFIx@yAx@oA~@}AxB_DxAuBv@cAT]NSPWjAeBtAmB\\g@JMt@eALS@CDEz@oAPWdCkD`AsA~@qAnAgB|@mA~@mAHMVa@zAuCDIz@kBt@oBX{@Rm@h@iBRs@^qAd@aBbAkD@E?ADIj@oBTw@To@Pq@R}@FWZeBFa@RiAHc@DW^yB?CF]BO@IRkARkAH_@Ty@Ve@@EV]@CVa@`@i@RYX_@Xa@r@cA@Ab@m@V]HMvAwBl@kAHQ\\}@L]Rm@BIj@aB@CXu@zB{F`@kAdGgPVy@Tw@Pu@XeA@CPw@Ry@nBsHNq@D[@SAYCSKg@CGY}@m@kBACi@yAEKCKa@oAmBsFEM]w@e@sAm@iBGOUq@yA}DSe@IUUo@A?K_@CYGa@MeBEc@IyB?]@]?Q?M@}@?s@DwB@m@?WDwA@m@B}@BkABkA?I@s@@c@?S?s@AgAAICg@M{AEo@?{@@c@Bi@BYJo@ReAh@}BP_ALm@`@iCXqBT{BBST}CRgD@]LwDTwMD{BFeD@i@@a@HeEJmFNwEBm@DyADaATqG@QBw@HqBRqH?KPkFLkC?CJgBH{@L_B@IFq@R_B@KD]Lu@p@sCLa@r@_BRc@|@eBx@cBr@wAbAwBb@mAZaADSZoAt@sCd@mBJ_@b@}ApA_FJe@l@eCXwAVkAF]d@cCj@cDZmBBORaALo@b@uB`@eBd@yBb@wBd@{BZ_CRyAHq@@AZgCNaAFe@D_@TaB?AZ{BDa@ZaCd@eE^mC?E^uC@IBMPmAJo@Ju@n@{D@E@IF]NaAp@{Ef@_E^}CDWn@qEDa@X}BD]j@{El@sFp@eGReBB]RoBb@kEd@cFDu@F_ABoCCkA?AEcACWI_AYkDAOWaDQoCQqBC[OqBKuAGyB?gBBy@?CDiAFw@B[TwCTkCRwBPgBDYNmAJw@BSHi@VuBDi@?W?MAq@Ee@KmA?AAMCk@IgAKqAI}@Ew@AME[AWGw@I}@I}@IeAQ{AI{@QwAOyASeBWyBi@wDUoAc@oAo@cBo@uAeAcCU_@OWOWACCECECGc@{@MYo@oAi@gAo@uAKYGMEICICMEOCE'
                     },
                     'start_location' : {
                        'lat' : -6.3633685,
                        'lng' : 107.5381058
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,7 km',
                        'value' : 1729
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 88
                     },
                     'end_location' : {
                        'lat' : -6.400448099999999,
                        'lng' : 108.2825995
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Indramayu\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'vxaf@u_ysSIGQU_@o@]w@c@gAaAkBYq@eAkDs@}BeB{GCG{@qDMk@Ic@ESE[S{AMqAUgCAAMoAAOQ{BKiAAGI}@KmAEg@KkBA_@Cm@E}ACcB@U?OC{@M{ECkAA]CsACs@'
                     },
                     'start_location' : {
                        'lat' : -6.4041248,
                        'lng' : 108.2676289
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,5 km',
                        'value' : 3516
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 183
                     },
                     'end_location' : {
                        'lat' : -6.3734701,
                        'lng' : 108.2970308
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Pamayanan\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'xaaf@g}{sSUQa@WYMCASMk@UOIs@]y@_@cDwAk@WoDaBWMsB{@WKoAi@c@Qy@_@MGa@QaBs@c@QsAk@gAe@}Ao@OO{Ag@aBo@c@S_@QqAk@YMIEe@SGEcBy@_CcAIEq@YmAi@SKgAe@i@S{@_@CAe@W[Mo@[k@YkAa@YMg@O_AYiA_@y@Ya@Qq@]GCAACASMgB{@cEyB[Qo@[u@_@UIMEw@Qw@M_AKaAM}BWm@GcBQ_AKG?c@Gy@KuD_@OC[GyCe@c@GSCi@K_@K[Ka@KICg@OEAc@Q{@[GCm@Q}Ac@aA[WKMEGAIG_@WEAQUGMGKCICKCMAOE{AEgACs@AOAMCQCGCIEMCEACMSKM?AMM_@]GG'
                     },
                     'start_location' : {
                        'lat' : -6.400448099999999,
                        'lng' : 108.2825995
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,0 km',
                        'value' : 1991
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 100
                     },
                     'end_location' : {
                        'lat' : -6.3583745,
                        'lng' : 108.3066324
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Rambatan Wetan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dy{e@mw~sSGGEEcA{@g@a@e@_@y@u@a@_@UQYWg@c@ACIGq@k@OGYKCAg@[IEs@a@uAs@aAg@ICGCAAyAs@KEiCoAcB_AaEqBiE{BsAo@i@WmAo@cCmAq@YcAk@}@c@u@a@u@]kAk@iAk@w@]kAm@u@a@w@_@y@c@_By@aAe@sCwAgCsAi@Y'
                     },
                     'start_location' : {
                        'lat' : -6.3734701,
                        'lng' : 108.2970308
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,3 km',
                        'value' : 2309
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 117
                     },
                     'end_location' : {
                        'lat' : -6.340412199999999,
                        'lng' : 108.3167299
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Terusan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'xzxe@ms`tSa@U]OA?aB}@}@e@}@e@oBaAeB_AaBaAqAq@g@Ww@Y_Aa@s@[mAk@WK]OwAq@gCgAqB}@A?UKqB{@IE[MsAi@k@WsAk@ECeCiAWQk@_@aAo@UOcAw@sBqA{CuBQOGECAmFsDoCkBk@YiBy@kDwA]MQEUI_@I]Gi@My@Ke@Ec@A]AcAEaAE'
                     },
                     'start_location' : {
                        'lat' : -6.3583745,
                        'lng' : 108.3066324
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 630
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -6.334913,
                        'lng' : 108.317605
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Mt Haryono\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pjue@qrbtSm@Gi@EY?_@CwC?eDFoBFWAuBWc@E_AQ]GeAYk@UcA_@eAa@'
                     },
                     'start_location' : {
                        'lat' : -6.340412199999999,
                        'lng' : 108.3167299
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 689
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 96
                     },
                     'end_location' : {
                        'lat' : -6.3373572,
                        'lng' : 108.3233189
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Ismail\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'dhte@_xbtSNk@pC{Ht@yB~@oC@GbA{CnAqDt@eCBE@O?A?Q'
                     },
                     'start_location' : {
                        'lat' : -6.334913,
                        'lng' : 108.317605
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '84 m',
                        'value' : 84
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 9
                     },
                     'end_location' : {
                        'lat' : -6.3372666,
                        'lng' : 108.3240618
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Veteran\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'nwte@w{ctSIcB?WAI?CAA?AAAAC'
                     },
                     'start_location' : {
                        'lat' : -6.3373572,
                        'lng' : 108.3233189
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '76 m',
                        'value' : 76
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 18
                     },
                     'end_location' : {
                        'lat' : -6.337506800000001,
                        'lng' : 108.3247057
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Letnan Jenderal Suprapto\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : '|vte@k`dtSn@aC'
                     },
                     'start_location' : {
                        'lat' : -6.3372666,
                        'lng' : 108.3240618
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '29 m',
                        'value' : 29
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 32
                     },
                     'end_location' : {
                        'lat' : -6.3372682,
                        'lng' : 108.3248013
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Letnan Jenderal Suprapto\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'lxte@mddtSo@Q'
                     },
                     'start_location' : {
                        'lat' : -6.337506800000001,
                        'lng' : 108.3247057
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '73 m',
                        'value' : 73
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 33
                     },
                     'end_location' : {
                        'lat' : -6.3374953,
                        'lng' : 108.3254188
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kiri.\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '|vte@_edtS@GR{@@ITm@'
                     },
                     'start_location' : {
                        'lat' : -6.3372682,
                        'lng' : 108.3248013
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '127 km',
                  'value' : 126617
               },
               'duration' : {
                  'text' : '1 jam 53 menit',
                  'value' : 6751
               },
               'end_address' : 'Tegal, Kota Tegal, Jawa Tengah, Indonesia',
               'end_location' : {
                  'lat' : -6.8666205,
                  'lng' : 109.1333419
               },
               'start_address' : 'Indramayu, Jawa Barat, Indonesia',
               'start_location' : {
                  'lat' : -6.3374953,
                  'lng' : 108.3254188
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 102
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 16
                     },
                     'end_location' : {
                        'lat' : -6.337911699999999,
                        'lng' : 108.3262384
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etenggara\u003c/b\u003e menuju \u003cb\u003eJl. Kapten Arya\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jxte@{hdtSDMPe@Pc@Xm@JU@G'
                     },
                     'start_location' : {
                        'lat' : -6.3374953,
                        'lng' : 108.3254188
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 191
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 26
                     },
                     'end_location' : {
                        'lat' : -6.336266600000001,
                        'lng' : 108.326733
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Kapten Arya\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|zte@_ndtS{@SaAOcAUw@OmAW'
                     },
                     'start_location' : {
                        'lat' : -6.337911699999999,
                        'lng' : 108.3262384
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 781
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 75
                     },
                     'end_location' : {
                        'lat' : -6.337818899999999,
                        'lng' : 108.333498
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Olahraga\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'tpte@aqdtS@AFEFGjByEJWd@oAPe@DMDOBK@MBa@@k@Bs@?CFy@JgBB}@T_GNcC@WH}AFm@DK'
                     },
                     'start_location' : {
                        'lat' : -6.336266600000001,
                        'lng' : 108.326733
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 239
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -6.336717699999999,
                        'lng' : 108.3353577
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Tanjungpura\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'jzte@k{etSKSmAiCiA{Bw@yA'
                     },
                     'start_location' : {
                        'lat' : -6.337818899999999,
                        'lng' : 108.333498
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '49,1 km',
                        'value' : 49085
                     },
                     'duration' : {
                        'text' : '42 menit',
                        'value' : 2548
                     },
                     'end_location' : {
                        'lat' : -6.699434999999999,
                        'lng' : 108.5546806
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Jend. Sudirman/Jl. Lohbener - Cirebon\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Lohbener - Cirebon\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan melalui 1 bundaran\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'nste@_gftSl@q@@AxA{Ab@a@b@c@dDeDPSdAeAb@m@`@g@`AgAAA?AAA?AAA?A?A?A?A?A?A?A?A@A?A?A@??A@A@A?A@?@A@A@?@??A@?@?@?@?@?@?@?@?@?@@@?@??@@?h@q@dCsDp@cA@M@AT]?ArCmEZg@l@_AtAwBf@{@FKJQ|AmCh@_A|CoG@CxAcDVi@^y@v@cBBGn@qAP_@`A_CHQZu@`@eAJU~@gCNg@nAoDPc@JY^_A\\}@HSRm@L_@jA{CDIn@eB^oAJa@f@eBViAh@wBNe@HIRi@p@qAJQVg@@Cb@y@d@_Af@{@Tc@d@w@vB{DBEBGFKr@oAvAmClAyBz@}AbAmBNUJUnA}BnA{Bn@iAfAqBl@gAHM@E`D{FxBaE~BkENW`DyFdBaDNYLW\\m@d@w@Zc@^a@xAkAlA}@@ANIp@a@FEx@i@FEdCaBbBeAp@c@rFsD^Wv@e@rFoDlBgAvAaArA_AHEd@Yz@m@VOr@e@pA{@`Am@tA_AbAq@fAs@|AcAt@e@@?jAs@t@e@`Ao@h@]VQ|GkE`Ak@|AaAl@a@lD_CdBeAHEROd@]rA}@x@g@|DgCfCwArA}@pCoBxBoAfBkA|B_BnA{@nAy@r@c@bAq@bHsE\\YT[Xa@LQRc@tBmF|@aCx@sBh@sAdEuKbBaEdBaEDEl@_AR[FI`Aq@zAeAHGr@g@TO@AhCcBTOZU@?`BaApA_An@k@vCqBHGzA}@r@e@nAcAnBoAz@c@dAaAn@g@DCDGDEl@cAfAeB@C|C_GXk@rBgErDwHjD}GdDyHhE}JfAcCXq@DKtB_FlGqNl@eA\\o@FIj@}@dOyTbA{AlBuCpAmBXa@V_@T[JQh@y@NWPWJMJMZYNMPMd@Wt@_@t@[BCxCqAv@a@pCsA~@c@pEuBpAo@nCsAVMvKeFDA~@a@pEyBdAg@fGwC`F{BxGaDhB_A|@a@fFaCvBgAHEzAu@zAq@lHiDlAm@tAm@vFoCxAq@f@UHEp@[VKn@[r@]HEfAg@n@YDCn@[nAi@FEb@Sf@Ul@Wr@]|@c@zAq@t@]XO|@a@VMFCj@YbAg@~EcCjAi@rBcAvBeARKfBw@fG{CXMfB_AhB}@nCqAp@[r@_@ZM~C{Al@]f@YNGrDgBnBeAlAk@h@]bA_@VMrB{@`A_@fF{APGvEyAdCu@fCw@zCy@dCi@bEcA|A_@~Bi@rCs@vEiAbCe@pDu@rCi@j@Mf@KNEv@OdFcAtAYvDw@FAdAUrA]REz@Qn@M\\IbAUr@Op@Ov@WHCLE^Qr@c@dAm@lA{@DMXQh@u@@CTS~@eA|@aAl@o@VYd@g@NOd@c@LMLMt@s@DE\\[NOBCjAeAZ[bAw@jBwADCd@a@TQl@g@v@m@hCoBd@_@d@]BCFE^[DCDEZQd@YjBkAZSBC`@UXQh@]f@WRMVMTK?AVI\\INEj@MJCpASBAvASVGTEn@KHCd@IPCb@GNA`AMFAx@In@IVCl@GTE`AK@?f@IpAQd@I|Ba@rAWx@M\\CjBSRCnAODAnAWPEvAY`@KZIrA[bA]`A_@tAi@ZMr@Yl@W`Ac@NIh@UPIJEVMTKLG^Qb@UFERKd@Yl@_@l@_@PM@?f@]\\WDETQJINKh@c@rAgATS\\[n@i@FGh@g@TSRSr@s@BE`@c@PUPSd@i@TY^e@@?NQLO`@c@d@g@@CXYl@k@TUb@e@TW@A\\[HK\\[PSvA{Av@y@d@e@j@i@HK~@aAjAkAPSZ_@b@m@\\g@nBeDLS`AaBl@cAFK\\k@r@oAHOd@}@DMp@mAr@qAj@cAj@_AR_@b@q@hAgBd@u@b@q@l@aA|@qAZc@b@i@dAwA@C^g@Zc@BCf@m@RW@CV[?ABCr@_ABCZ_@r@aAfAuA|@kA@CLQt@}@?APS@A\\a@BEV[d@i@v@{@`@e@RU@AXY`AgA@APSBCXYLMJITSNMVQ^UVO\\Q\\QLGRIfA[r@WrA_@vA_@t@SdEaADAdAWdCo@~Bk@tBc@pBc@v@QFA|@SPEPEDA`@I|Be@lCg@vAW@AB?|A]DAf@Kd@MBATGhA[BAbA]hA]DABAxBs@xAa@jGeBtCu@dFuAvDeALELEDAr@QBATGzAc@RGDAf@QHCDA|@WpAa@HEB?nA_@l@Sn@SZIRGVGrAYB?|Be@FC~A]LE`Du@jAYpEaAtCo@pAYn@ObB_@xB_@rAWdBYZIpB]xBc@|@MfAK|@Gn@?`H?pJA`@@lA@z@@tB?|A@|B?l@@B?jB?nABlABv@@zADz@?\\?TAPALAPGTGNGTKZOzCiBnFaDhAq@jDuBzIkFl@_@nDwBvBmANKnAe@lAa@VGJCZEtPqCrHsA|AYpDm@zF}@nAWnAU`AWxFeBdA[h@Of@KPELAZCLALAJ?RAVA~@EL?~@ElCC~A?lA@jCAf@A|@?rA?V?^?R?z@?^?v@Ah@@X?fA?J?B?L?d@@ZANATCNCf@OlBe@RG`AWHCf@OdA[`@MjA]v@Sb@Md@MZIt@UfAYBAr@S~Ae@`AY`AY\\Kb@O@?RGXKZKxBs@TIzAg@h@OfAWRGXEVGz@OPCdCe@rCe@jAS|@O|AW`@EDA@?hCc@hC]tAQNCl@K~@Mb@IJCVE^IZGJCbEkAzAa@nBi@l@O^MLEbBg@|@W@?xA_@ZKxAa@hBc@d@MNElBi@pA_@PG`A]nAa@PGd@Q|Ai@VIrCcAZKd@Qp@WBADChCaA~D{AdBs@VIjCcAlBq@r@YZKh@SzAk@TIpB{@@?zB}@lBu@DALEpAg@@?nCgAhBs@vCmAhBu@BAzAo@lAi@\\Qj@WTKfCmA|@a@nAi@b@QZMNGJC^Of@OREv@S`AUBAREl@Ml@Kr@Mx@QxBc@FA`AQrAWvCe@p@Kn@Kl@K@?JCbAOrB]nAQr@KfASjBYXEdBWzAWvAWtAWd@I^Gp@M~Do@VEfAQz@Od@IpASxB]lCa@zBWxBWn@IdBO`BI^APCJ?n@B^CH?v@G`BUREz@KVEj@IBA~@Oj@M`AShB_@NCTEJCHAl@Oh@KPGf@Ml@Sd@Ox@[FEFC\\Q|BkAHCFEJElAi@lAi@JGtBw@NG`@MNEVIp@QLEPE`A_@XGj@MPEPCj@IPCB?`B]`ASt@OD?rA[FAXCv@MbB[ZG@?x@O`AS@A|@Qt@MHClAUXGHCr@MvB_@tBYXOpAWLCvAW~AYFAZGtASjAUFABAREd@IJChAQ~@QjB[HCJCZGvB_@tAYbDi@xCe@lBYPC@ArBa@~Bi@PEbAUTKn@MRIDCzAc@bCo@DC~@UTG@?n@SHCf@OTIx@c@h@Uj@[hAq@z@k@TQHEx@i@vAkAb@]~AsAPMVSTSdAw@VQl@c@h@[pCmBZQDChBeAzAu@b@Sv@]VMRKNG~Aq@FCFC@?@AdCgAnAi@pAc@lA[hAShAUdC_@bBYpAU^GJADAfAQHCj@Ib@GJCz@M\\G\\GTEJCTE`ASB?XG~@U`AUJCdA[NG^MRGZMXMn@SBA|@_@z@[b@QpAg@TKr@WTKBAXIHE@?r@[fAc@NGJEj@S^OhA_@vBk@BAzAYNCp@GpAIX?\\?h@E`@EjA]RE|Aa@lA]`@MrAa@^MrBq@xAo@hBu@TIdD{ARKRIp@[TMd@ULILGJEjAg@^Qh@Yl@YlAm@b@SNEZQlAk@t@]DCr@[p@]TKXMNGrAg@TIZOJCJEp@UPGbA[l@UFA`@M\\KdA]vAa@`@MXKdA[zAe@vBm@TG^KTG`@Oj@O\\Kb@Ot@SfDcAz@YRI^KvAc@rAa@VITG|Ac@hA]|@UPG|@WdA[FCZIVIn@Q`Be@b@O\\KRGn@StBq@rAe@j@QdA_@h@QTIdA_@p@Ul@Uv@Yt@YpAi@jAc@b@Uh@Wj@ULGjAi@rAm@FCt@{@X[XSFEHIHCHCPGVAP?l@CJAPARE@AFAHCn@UJE'
                     },
                     'start_location' : {
                        'lat' : -6.336717699999999,
                        'lng' : 108.3353577
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 452
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 50
                     },
                     'end_location' : {
                        'lat' : -6.7011403,
                        'lng' : 108.551308
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eSlamet Riyadi\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'ln{g@waquSHN?@Lf@RrAJh@TjAXdBBJHf@DVVtA@H@BFb@BF@DBDFHJNPN@@DDB@HBPF@?^F@?VBNBP?'
                     },
                     'start_location' : {
                        'lat' : -6.699434999999999,
                        'lng' : 108.5546806
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,2 km',
                        'value' : 1225
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 63
                     },
                     'end_location' : {
                        'lat' : -6.7121404,
                        'lng' : 108.5509246
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eDr. Wahidin Sudiro H\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'by{g@ulpuSbA@Z?^?D@@?B@DDz@@N@zBBH?N?nB@D?nBBH?xAD`@@l@BzAAv@?rA@H?vBHx@@h@?JAD?J?D?BAL?L?n@@h@@b@?x@@N@P?l@@v@BdABd@@nAAX?zBF|@@fDB'
                     },
                     'start_location' : {
                        'lat' : -6.7011403,
                        'lng' : 108.551308
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,7 km',
                        'value' : 2735
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 151
                     },
                     'end_location' : {
                        'lat' : -6.7365558,
                        'lng' : 108.5502088
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Dokter Cipto Mangunkusumo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'z}}g@gjpuSF?lGDjGNp@@L@tABP?tABjA@`@@p@@j@@\\?zBDx@@R@rCDvBBZ?zHLf@@`B@~CHV@`BDbA@R@d@?|@@dABB?~@BF?P@T@X?D?T@`A@bADR@b@@p@BH@hA@@?P?\\?p@@\\@f@@~A@vA@lBFB?x@@`@?b@@P?z@BjABf@?Z@vBBZ@h@@jABn@@X?D@|@BdABf@@V@r@@V@x@BX@n@@bA@xA@n@AH?JADAHCBAHGDEBCBCBCRa@'
                     },
                     'start_location' : {
                        'lat' : -6.7121404,
                        'lng' : 108.5509246
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 405
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 46
                     },
                     'end_location' : {
                        'lat' : -6.739552799999999,
                        'lng' : 108.5481317
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Kesambi Raya\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'nvbh@yepuSTPFBzC`Bj@\\~A~@n@^LF^Vz@n@LH@@dBlA'
                     },
                     'start_location' : {
                        'lat' : -6.7365558,
                        'lng' : 108.5502088
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,9 km',
                        'value' : 3875
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 226
                     },
                     'end_location' : {
                        'lat' : -6.7391793,
                        'lng' : 108.5821964
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Jend A. Yani/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'dich@yxouS@MD]Ba@NyAL_AJk@L_ANyA@GFk@J_AD[LqAPaBNiAPyAJs@D_@Fy@BMJgAVeCRmBH{@NqAB]Hs@D_@PgB@IFi@JgAD[BQ@WBW@U@UBe@HeBP}CHiA@SJoBJwBLaCFyBBcADmA?I@ID_A?OFeA?ILcD@MJqDHeBHyADeAFeA?MJmAF}@Du@Be@JuBTqDNoCPaDDq@?MBm@@[Ae@Aa@MiAIi@O}@Q_A[uBk@cCw@iCkAuC_AsBuAcDUm@]u@OQe@wAQk@o@sBe@wAK[[cAMc@Uq@Qg@CQCOCQAO?S?M@O'
                     },
                     'start_location' : {
                        'lat' : -6.739552799999999,
                        'lng' : 108.5481317
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '58,0 km',
                        'value' : 58041
                     },
                     'duration' : {
                        'text' : '50 menit',
                        'value' : 3019
                     },
                     'end_location' : {
                        'lat' : -6.8751609,
                        'lng' : 109.0525434
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Kalijaga/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zfch@wmvuSbAe@DCn@]r@]l@[BArGiDf@W\\STK~Ay@^SfAm@j@[nAu@\\Q@Ax@g@@?VMbAm@|@g@x@a@RKXMPIDCpB}@NG`Bu@JCzB}@nAg@jAg@z@]^Or@Wz@[DCHC^Ox@YZKTIh@Uj@_@rAkATSx@u@xAoAPOl@g@FEl@g@`BsA@A|AoAh@_@t@g@FETOxAcABAnCgBl@c@j@_@nA_AtAeAz@u@bA{@POh@a@\\YXQBARO^Ub@Ur@_@LIZOxAy@~@g@DCx@e@ZQbBcAFEl@[lAq@VM^S|@e@hB}@p@WLGz@UVEdAWzAWJC\\IFAf@KbB[h@MJAdB]XE|AWrAWp@OPGHCLGHCJIj@[NI`CmBj@e@bA}@hDuCp@m@NQrCiCvAuA|B}B^]v@y@TW`@_@JMhBqBd@g@~BeC`AgAhByBzBcClB{BtDmEDGvDmELQHQJQb@}@h@iAh@oAt@aBlAwC`@oAV{@|B_H|@wCrAgE`@sAz@yCVy@FQlAiFVgAVwABQDe@Fc@?IX}BFa@BKb@iBnAaF~@uD`AcEPs@BIDQj@gCZ_BHa@nAoG`A_Ez@}C@Gf@mBRo@ViAj@yB~@uDF[h@qBl@aCHe@@GDSLgANmA@GLmBBS\\gFXyCN}ARwBD_@JeA@ODg@PqBD_@`@qEf@eFRiCL_DDcA@SXsEVsC@G\\sCFg@DSDQ@CNk@Re@LYj@gAHOJSLQLQNSNONQPQNODGJGNOROPMzBgBrCwBVQdBkArBuAbBiAZSv@i@vCqBn@c@tByA@?pCmBvBwAXQRMRORORMRORMROFEvA_Av@u@\\c@^c@v@iAd@q@LQ|@}AJU~@qB~@_CPk@p@mBfAeDx@aCXm@Vm@d@{@d@w@d@s@R]JUJUFUFUDYFe@@o@DaB?WBsAHgBJ{ARiCRgCFa@Ja@h@yB|@_DR{@d@gBR{@n@oCb@yBb@wBLm@dCwLJk@BKP{@FWNq@Jg@XmADQb@eBRu@f@mB^qAb@eB`BgGl@uBd@{A`AuCh@wARg@Z{@\\}@|@uB@C^aAn@}Ap@cBL[L]HUJYH]Jg@BKDYDWHo@Hs@B_@NaBFi@@GL}@DUTsAZsAZyAVmA^aB\\{Ap@{CTaAVcARo@LY^u@`@o@Zi@^i@Xc@Zc@PY\\g@h@w@Xa@|@uAr@cA`E_GHMb@o@p@}@j@y@n@{@\\c@j@u@V[n@m@fAcABEpAwAv@aAVc@P[N_@Pq@Ju@JaAHy@De@Hi@He@Jg@BINy@F[D_@He@\\sCRoBH_AXaDBs@Bq@?i@?]?eA?cC?C?oAAs@?_B@uEA}@?}@?sA?a@Ae@IaFQsFGwAAY[uG?Gk@_IMuBI{AAIOkBq@oJG{@Eu@OqBSsBCQEq@KiBIy@Ca@AOKsAEaA?AC_@@a@Be@@a@BUVqBVuAJi@DUPkA^_Cb@mDN}@Jo@hAuEh@}B`AaDnAcEt@mCHU`@iAz@gCFUvAqDjAgD\\cAVw@x@}BzBgGxByGjCiIpAyDJ[\\wAf@uBFUh@{BBMNm@l@mCdA}D?A~@wEf@}BXwAJe@XoAJi@T_Ab@sBBOBKdAyEHi@V}APcBJm@Dg@Bc@LiADc@N}BNgBJgBNeC?WFmB@gB@eD@e@DsBJmFBcABy@BcADeA?_@@q@?a@?[EsD?g@?KAWAoAGsFAcAGuDAwCHeC`@yDBQb@cEb@iDBMJaALaA\\yCVyBBOr@_G?E@EXqCXaCpAkK@ID_@XyBFg@@EFg@?A\\oCx@uGNkA^aDJ}@D]@IReARcAVmAv@}C?Af@_Bl@_Bt@{A`@y@b@s@dBqCfAoBt@oAhAsBvA{ChAqCdByElAqDhAkDxAqElAyDf@aB\\mAXkAZsA?Ab@yBn@wC\\uAn@mCf@kBZgAnAkFTaAT}@DQH_@H_@He@@ERy@Ru@h@{Bh@eB@AL_@Pc@FK^q@dAqBpA}Br@qAb@u@nHsM@CP[@C`@y@DIl@iATc@R_@HOHSb@w@jB_F@E@EJUv@qCFQ~@aCBIFMHQ\\u@j@oA^{@LSHQNWR]JOHKHGJEZQxAi@|@WtDeAHA@AB?^K?Ar@QfAa@PEdA_@b@Oj@QXI`@SVMHIRUNUVa@b@aAPa@rCmGN[|B}EbBmDDMP_@d@cA~@uBXk@^u@n@qApBcEPYt@kAh@w@Xc@Ze@x@mAdCcDDGDGh@u@BAf@g@b@e@tEsErAwA`CgCr@{@j@m@nCqC~AyAPQZUvBgBd@]hAmAbBoBdBqBRU~@gAX[b@g@n@s@`@[pB_BjCkBvDsC~AiA@?FIfAu@dAw@\\WbAu@dBsApBaBx@y@fDoClCyB^]~EgEj@i@FK|@}@TUFILOFI\\q@LYTg@Pk@J_@l@_CPm@H[Rq@ZmAf@mBt@oCFUb@_BXsABSH]Nw@Fa@Hg@Jo@d@qCDSJm@N{@?APiA@[@_@?C@[CeAYeEKsAAMQgCEy@MyAEu@KuAAIGoAG{@A]Q_DAMASA[?Q?U?I?G?S@Y@m@BgA?CBc@?I@Q?a@@g@?o@AK?o@Ae@?EAiAAkBAu@@I?[@S@KD_ANuC?M?Q?q@A_@ASIcASsBQ_BSqBKyAEgAEsBGgB?UASGmCAcA?C?mA?sA?}@?kA?e@EcHAgBGeB?GGeBEy@Gy@QmBSyBMyBAQCi@?EAKMkBKkBGi@Cs@AMQoBAGEe@KcAAEo@gFQqAAMK}@MaAC[G_@Ea@K{@k@_GQiBQoBWuC[}Do@cGMkB{@{L?QCWESCY]gDg@aFUaDKgBAO?KAA?II}AI{AASG_BMgLCkCBq@BmA@c@J{A@Ql@sJBs@l@qJFmAXsFB[?S@MFiADcA@i@Bw@?aAEsAA_@Ac@?A@i@@i@Dk@Fg@L{@F]Fe@Ho@Bg@@W?w@Ao@C_A?y@@k@D{@FiAFaA@MBa@HeAFk@Hk@XgAPw@@APu@VcAXkABKJ_@x@{CDSZwALe@d@gBRy@FUn@kDP}AFg@Da@He@B]JiABcA@}@@Y?_@A_@?AAY?GA_@C_AAUEqACWE}@EqAAKCm@?EEo@Cs@?A?O?sABoCHaENaDDsA^iJH{A@[HiB?EH}BJyCCeDASK_CUkDWeEEm@IuA?IAc@OmCIoBCg@?CEaBCk@Ak@A}AAy@A{AAoAAq@?o@A[Ak@Am@Cg@IeAGk@Ga@SaAKi@I_@Mo@Sw@CMMq@O{@Io@AIE]Ga@AOGw@AOGw@AMMcCAW?SEuAAe@?O?o@BYBg@Jq@DYHc@Le@XiALg@Rw@@GTaAT{@h@yCTyATeBLu@Py@P}@?CVwAHg@`@gCHg@XaBDWNeAPiFm@qIAIQaBAOWuBO{@AGG[Qw@AEG[Kg@ScAa@aBS}@_@aBGWAEm@uCe@yBCQc@qBEQMc@G]K[AI]y@g@cAU_@cBwCCEKWk@eAk@yAI[S_AIc@Gk@E[KsBIsBGiBEq@?IOaBMeAGa@Ga@YaAGUSi@g@kAy@_B}@kBcAoBm@sAa@eAUs@S_AIk@OqAMmAASEq@Cs@@}B?c@DwAA}@C[AQCa@Iq@Iq@CUGa@EUSkAAICQOgAc@aDg@sEAKKy@OgACSKaAE]E}@Eg@C]A[Ca@QeEMsCGsAMoBUaECi@EmA?iA@oAByB?ADyBFwCDiAAcBA]Aa@Cq@Cc@E]E[CWEYKi@AG]}BK{@K_ACK]mBMm@AIOu@G]?E]eBQ{@a@qB]cB?Ag@_CG_@CGKg@Ga@CMS_A?CMw@UwAO{@AAQkAGc@EWM}@Ms@OgAKu@G_@Ea@Cc@AM?KAKAW?YA_@@g@?M@Y?G@S@GB]DWBOBSPu@BKp@wEJ_AFgA?ABu@DyA?CBaB?y@?W@gA?Y?i@?}@@aB?sA@_@?MBwA@aAByABiA@UBoD?E@sA?_AAy@?q@AME}CA}@?s@?e@@a@Bq@D{@Dy@@e@JyBHcB@GBgABc@?EB[Ba@@YJmAF{@JeAPkB@ITyBPaB@MFg@PwAD]DSBMD]j@qDPiAPiAFUVqAf@eCF[VmABQVkA`@wBNw@Hg@?ELs@Jo@NoAXiBJm@R}AHk@TgBFe@PoA`@_DVsB\\yCP{ABc@JuAB]Be@@I@I@GHi@V}AJs@@G?A@EF_@DWNi@H[N_@HWTy@DUNs@@CHM@AFa@Hc@He@Je@Py@Ls@Ny@BQXoAJg@F]v@cEzAqIDWVyAHc@ZyArA_IxBkM?GToAz@kFNeABIt@{EZsBDSVaBDU\\mBDUDUDMBIFMJMRS\\Sn@StA_@'
                     },
                     'start_location' : {
                        'lat' : -6.7391793,
                        'lng' : 108.5821964
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1398
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 71
                     },
                     'end_location' : {
                        'lat' : -6.8764067,
                        'lng' : 109.065078
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Gajah Mada\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'vx}h@kirxS@AHEHGHSDMB[F{A?KDm@@SLyB?KJsALeBBQDi@RaC?GD{AD{A@UJoCBy@DmA@o@LyDFsCJqCRmF\\iN'
                     },
                     'start_location' : {
                        'lat' : -6.8751609,
                        'lng' : 109.0525434
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '7,7 km',
                        'value' : 7719
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 386
                     },
                     'end_location' : {
                        'lat' : -6.8697783,
                        'lng' : 109.1329539
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eRaya Kali Gangga/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'p`~h@wwtxSR_FHwBRmC@QFcAR_CJkAD]@KJcA?ELmABY@SLsAPoBV}C@IFq@B]D]?ANuA?CD_@BYJaADg@BWRcB@MFs@Dk@LwB@I@SF}@@KFuABq@DaA@a@@IFmAD_A?GHoB@M?KBe@NkC@KB[FkAFsARqCDm@Dm@P}DFaC@i@F}B@oB?Y@kB?o@AI?CC_EAo@?GAy@AECuC?c@EmAE}@KkBA[GgAKgAYkDC]ASCa@AGKoAEi@MeB?AKgA_@qDO{ACWGk@COIu@sAaLAOKu@OcACWAGUyAQqACYCM[wBMq@CUKk@EYmBuKEOk@wCYqAg@wBe@{BYqAAGAGm@yC_@kBOu@{AuGCOEWi@qC]aB[aBESOm@UaAI[K]Qk@Sm@a@cAKS[o@_@s@Wi@MY[u@EEO]mE{JQc@}@yBCIg@gAEM_@}@w@oBe@qAGOIQ_@cAc@mAe@yAi@cBg@aBOq@Om@Aa@Ai@@c@@YBm@Bg@HqA@OJiB@I?AHwAFmBDkA?ADqA?ONeD?CFgBNeDRkFJe@?KDw@TuE?Cd@sI@_@XiF'
                     },
                     'start_location' : {
                        'lat' : -6.8764067,
                        'lng' : 109.065078
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 353
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 32
                     },
                     'end_location' : {
                        'lat' : -6.866649199999999,
                        'lng' : 109.1334862
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Gajah Mada\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'bw|h@}_byScCQuAOcAM]Ek@Gg@GqBOu@Ky@I'
                     },
                     'start_location' : {
                        'lat' : -6.8697783,
                        'lng' : 109.1329539
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '16 m',
                        'value' : 16
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 11
                     },
                     'end_location' : {
                        'lat' : -6.8666205,
                        'lng' : 109.1333419
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Delima\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kiri.\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'pc|h@icbySE\\'
                     },
                     'start_location' : {
                        'lat' : -6.866649199999999,
                        'lng' : 109.1334862
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '163 km',
                  'value' : 163171
               },
               'duration' : {
                  'text' : '2 jam 27 menit',
                  'value' : 8831
               },
               'end_address' : 'Semarang, Kota Semarang, Jawa Tengah, Indonesia',
               'end_location' : {
                  'lat' : -6.966628800000001,
                  'lng' : 110.4168616
               },
               'start_address' : 'Tegal, Kota Tegal, Jawa Tengah, Indonesia',
               'start_location' : {
                  'lat' : -6.8666205,
                  'lng' : 109.1333419
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '16 m',
                        'value' : 16
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 1
                     },
                     'end_location' : {
                        'lat' : -6.866649199999999,
                        'lng' : 109.1334862
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etimur\u003c/b\u003e di \u003cb\u003eJl. Delima\u003c/b\u003e menuju \u003cb\u003eJl. Gajah Mada\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jc|h@kbbySD]'
                     },
                     'start_location' : {
                        'lat' : -6.8666205,
                        'lng' : 109.1333419
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 821
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 74
                     },
                     'end_location' : {
                        'lat' : -6.859384299999999,
                        'lng' : 109.134813
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Gajah Mada\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'pc|h@icbySw@ICAs@IwAMs@IuBUaAK}Da@]Eg@GsBSoBQ_Fg@uDa@{BW'
                     },
                     'start_location' : {
                        'lat' : -6.866649199999999,
                        'lng' : 109.1334862
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 342
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -6.856349799999999,
                        'lng' : 109.1353278
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. MT. Haryono\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bvzh@qkbySyBUCAuAMu@GeHq@m@G'
                     },
                     'start_location' : {
                        'lat' : -6.859384299999999,
                        'lng' : 109.134813
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 163
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 8
                     },
                     'end_location' : {
                        'lat' : -6.8549112,
                        'lng' : 109.1356006
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Teratai\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dczh@ynbySg@EeFm@QA'
                     },
                     'start_location' : {
                        'lat' : -6.856349799999999,
                        'lng' : 109.1353278
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 794
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 120
                     },
                     'end_location' : {
                        'lat' : -6.8551884,
                        'lng' : 109.1427778
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Yos Sudarso\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'dzyh@opbySFa@DQDsF?wB@eA?O@gB?O@[?UAcABwB@a@@g@BoCDoB@_@BeDFo@'
                     },
                     'start_location' : {
                        'lat' : -6.8549112,
                        'lng' : 109.1356006
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,8 km',
                        'value' : 1828
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 93
                     },
                     'end_location' : {
                        'lat' : -6.860500399999999,
                        'lng' : 109.15808
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Martoloyo\u003c/b\u003e',
                     'polyline' : {
                        'points' : '|{yh@k}cySBMJWFIxAmC~@cBNYVc@lAaCz@sBTg@bDgHfAcCj@qAR]zA_DBYh@wAl@qBH[J_@Fc@BSBY?k@?yA?Q?cACoCByCJ_CBSFi@BOD]BM^uCTcBdAmI'
                     },
                     'start_location' : {
                        'lat' : -6.8551884,
                        'lng' : 109.1427778
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 488
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -6.8616385,
                        'lng' : 109.1623478
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eDampyak\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'b}zh@_}fySf@aDt@mEv@}EJc@`AcF'
                     },
                     'start_location' : {
                        'lat' : -6.860500399999999,
                        'lng' : 109.15808
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,9 km',
                        'value' : 3863
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 193
                     },
                     'end_location' : {
                        'lat' : -6.8666683,
                        'lng' : 109.1968934
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003ePantura\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'fd{h@uwgySVkBd@eDHs@BQDYP}@Ny@@ATkA~@uENw@ToAFe@RmAD[BQHk@TsARuAJi@?EBWFc@Fq@B_@BO@YJsABa@@QB_@?EH{A@YB]Bu@?AHmB@SBe@Bm@HoA@SHcBDiAFeA@a@Bs@@w@BeA?s@?K@aA?g@BaADy@FwAJuCF{AFcB@UH{BDmAJqCJ_DNiE@O@U@IBc@?GDi@H_A@OTyCBOHeAHw@HcAHgAJuAZ{C@MHw@Dg@BWBSDg@R_BJ}@@M@OB]BMBc@HgADe@Fs@PiBFy@Dq@HoAF_ABg@@K@QHmABYB_@@YF}@BOFgAH_ALgB\\mDLqAFoABQ'
                     },
                     'start_location' : {
                        'lat' : -6.8616385,
                        'lng' : 109.1623478
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,1 km',
                        'value' : 2129
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 106
                     },
                     'end_location' : {
                        'lat' : -6.868131200000001,
                        'lng' : 109.2161009
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Kramat\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'tc|h@qonySPgCHuATyDLeC@OZ}FJcBXgF@CVsFHsA@_@F{A@ULwBFkAHqABe@H}AHcB@k@Bs@BcABoBB{A@eAB}ABuA?[?G@k@DsD?A@E@kA@i@?{B?_A?a@?K?Y?M@eDBuA@w@@{@B_A'
                     },
                     'start_location' : {
                        'lat' : -6.8666683,
                        'lng' : 109.1968934
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '25,3 km',
                        'value' : 25280
                     },
                     'duration' : {
                        'text' : '21 menit',
                        'value' : 1266
                     },
                     'end_location' : {
                        'lat' : -6.8911088,
                        'lng' : 109.4345329
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eMaribaya/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'xl|h@sgryS@QNmDD_ADu@?CL}BRoDF}@Do@Bi@B]Di@HoAHgALwAFm@Di@Dg@@UHmAHcADk@@G?A\\cEBa@@EDy@Da@?ETwBHoAFy@@IJ{APiDFuABs@?W@SBsA@{@BcA@KJ{C?KF{ADy@@SDe@Fo@NsAHs@@OZoC@QPcB\\gDLkA@OLcAB[TkBTwBLeAJ}@ToBJq@@MNiAZiCLmABKh@uFPmB@KHu@@I`AkLHsAPaDHyAHmA@UHwBHiAJqA@]?ADg@\\qEDu@BYNyBLsCFwA@MHcCHiBBkAFyABaBHmDFkDFqBFwBHwB?a@@]?I@QBw@@Q@_@Bu@VsGBkAHkF?UH}DBaBNsHJyF@WNqDHsC@}@B}C?e@DcE@]HyDj@mWBuABeB@s@JmEHwDDmB@WA_@@_@D{BBgA@e@FwC?e@F_K@k@ByA?K@cG@_C@eD@{@@_D?eA@sDAgDAkB?M@iA@uCBcD@wC?aBAsCAyCCgDA}@C{EAQEcDAa@AwAGyDAWAs@Ck@AsBAqCGwFAW?Q?UK_JCqBMcGKaEE}A?e@AQGgAGg@GWEYS_AKa@c@aBQu@GQyAoHg@cCYoBOaAw@mFGg@MiAk@sEQyAKo@_@cDUiBY}BE]QqAaAkHaAoH[}BE[c@iDCUQ{BW_JAg@?{@BcAD}@Dm@NeB`@}E?AHcAHsABWF}@JkBJ}AB_@FaAL_CDm@NyBJwBBYF_A?AH{AJmB?CJgB@a@HuALkC@MFeAJ_BJ_BJgBF{@Bk@BQ?ABi@NeDFaBHaBFeANeBFu@BYTyBBUNoADu@F{@?GHaC@eC@yA?WCsACuAIaCCiAEcAIaCCs@?e@@i@?CBe@Ds@b@eHNaC?ETkDNcBDiA?cBGgAEm@C_@Ce@O_CCSG{@MqAIm@S}CKmBCo@EuAGy@?AAEESE[SaBYiBk@_Eq@sGQiAOaACWKqAGs@GgBKsBEmAGsACy@@k@@EDa@Jw@Ls@BGHWXm@|@sA`@q@b@q@Ts@Jg@VqAFSHUL_@Zi@f@k@vAkADCz@w@HGdBkBRW|@iAx@cAb@g@hByAvB_Bn@i@HGHIl@e@lBgBBC@CdAmAl@aAXe@HMRk@j@y@`@Y\\_@~@q@FGr@m@TWT]HWFODYFa@Dc@\\qEf@yEPeBJWHg@ZsD|A{TTiDn@aJJeBB_@?a@Bg@AUAW?UAOCOAOE]Mq@WmAa@mBq@gDEQ[wAi@uCCICQCKAO?W?[B}BByADiBHcHDoCHeFDsE@_A@_@@_@?GBg@@SNaDNoDRaFJqBPcELkDBKBq@FeABq@BWH_@X}Ad@eCv@uDTkAHi@Jk@\\{BRkARoAL{@BW@i@PiEJaCFyAPsEFmBBYPcF@MDgA?CHoADu@Dq@JgCL}CJ_CB_@Bi@D{@Be@Di@Jw@NiARuANeAR}ATcBHs@Ho@~CcWBSPeANkARuAf@eEVeBJgAAO?EAA?C?C@CNcAF[BKHYPa@JUHMRWNS\\[\\Yl@UZKNEn@I^E|A@fNh@fEN'
                     },
                     'start_location' : {
                        'lat' : -6.868131200000001,
                        'lng' : 109.2161009
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '7,2 km',
                        'value' : 7159
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 361
                     },
                     'end_location' : {
                        'lat' : -6.9006544,
                        'lng' : 109.4971754
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Perintis Kemerde\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'l|`i@y||zSnAShAOPCNEXOZWX_@JUF[Jq@Da@ImAMmCMkCEiAi@yLOkDEo@GgA?}@AmBBeAFoCJsEBwAFaD?_@DyAFmBFiA?AHkANyARkBZ_DB]PoAVmAj@{BLc@Pk@h@{AjA}Cf@uAL]V}@T{@Hg@PgAJo@PiANqA`@gDHi@TsBD]J{@P_BPoALcA`@iD@K@GLmAJw@BUNsABORmBPcBHy@LgAJeAXsCPuCJ}CBe@LaEBq@Bw@@s@@e@DaA@]NkEHmAFgA?ANwANgANq@p@uCxAiFDOPq@HQRw@rBkHpBuHt@mCZqAT}@?Ch@iCZwBT{AReBH_AJoADy@Bg@JcDBqAF{AR_G?MHkC?AFwBFaBB{@JeE@mA@g@?[@e@?cA?iA?cA?eAAcACeAC_CEqDAYGsDIeDCcBK{FI}G'
                     },
                     'start_location' : {
                        'lat' : -6.8911088,
                        'lng' : 109.4345329
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,0 km',
                        'value' : 3980
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 199
                     },
                     'end_location' : {
                        'lat' : -6.898223499999999,
                        'lng' : 109.5328871
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Jendral Sudirman\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`xbi@kdi{SA}G?}@Aq@EkCEyIAcF?gBC{B?uBAaBEkIAYASCSCUCUCWMiBIuAA]?AAe@?C?]?K?M@i@Bo@FcAHmB@_A?}@?uA?mEBcF?wACaDAkCE}EIgEKkHEsCA_@KoFC}@CaBGoC?IAs@AMCw@Ik@S}@w@iCAGs@}BOi@GUSy@k@sB_@iAQg@WeAOy@WeBCWAQAK@[@w@GcKA_@AgAAcI?A'
                     },
                     'start_location' : {
                        'lat' : -6.9006544,
                        'lng' : 109.4971754
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,0 km',
                        'value' : 2036
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 102
                     },
                     'end_location' : {
                        'lat' : -6.8886189,
                        'lng' : 109.545686
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Sidorejo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'zhbi@qcp{S?KAG?e@?]A]A_ACaAAeA?OA}@AQEqG?k@AyAAiAAiA?]C}@Ci@C[Ak@?IEo@EUCYCMSoAUiAa@iAOWW]WSs@_@A?{Ac@_A[YK{Ag@ICqA_@{@Y_DaAcAYqDiAq@UaDy@WIeAYwBk@{A_@yAk@OIo@g@[c@k@iAwA}D'
                     },
                     'start_location' : {
                        'lat' : -6.898223499999999,
                        'lng' : 109.5328871
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1397
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 70
                     },
                     'end_location' : {
                        'lat' : -6.8851899,
                        'lng' : 109.5578127
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Ambowetan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'zl`i@qsr{SGK_AuCEMoD{La@mAc@mBCOk@qCg@_DAG[eCs@mFg@}DCKk@{EgAwIMaAGi@Ig@'
                     },
                     'start_location' : {
                        'lat' : -6.8886189,
                        'lng' : 109.545686
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,0 km',
                        'value' : 981
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 49
                     },
                     'end_location' : {
                        'lat' : -6.884347699999999,
                        'lng' : 109.566416
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Ulujami\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'lw_i@i_u{SAKo@cEAGCK?AAE?CGUc@iCMs@O}@y@eESmAI_@O_A?AKg@Iu@I{@E{@Ac@AYCa@A]A[?GAe@?_@@]@SBWFa@Jg@b@gBPu@Vu@L['
                     },
                     'start_location' : {
                        'lat' : -6.8851899,
                        'lng' : 109.5578127
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 852
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 42
                     },
                     'end_location' : {
                        'lat' : -6.886861199999999,
                        'lng' : 109.5736979
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Rembun\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dr_i@cuv{Sj@iBb@sAf@{A\\gANq@@ANu@R_A@ENm@^oBBKTmA`@qBp@eDd@yB^wAbA{D'
                     },
                     'start_location' : {
                        'lat' : -6.884347699999999,
                        'lng' : 109.566416
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,0 km',
                        'value' : 5023
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 251
                     },
                     'end_location' : {
                        'lat' : -6.8914009,
                        'lng' : 109.6174263
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. S Parman\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'za`i@sbx{StA{EBIZoAr@wCv@aDPcAP_AFa@Fm@Hs@Bg@B]@_@?_AC_BCuAAw@EcBCuAA}AAkBBmBBg@B{@Fo@?EBOJ}@P_AR_AZ_A\\}@`AmBHOrAkCP[P]BEBGVc@R_@j@eATc@n@mAnAqCp@yAP_@z@oBt@iBBEbA_C^u@p@sAf@aAZs@J_@H[H_@Fe@H}@Bs@@[@gA@yB?YCaF?wB?yC@aF@gBBoB@]@a@?OJ_D?EDkABcA@k@A{@Cq@EkAE{@AEU}CWuCWyBa@{DSwBO}AQcBCWY}Bs@eGGg@]aC]cCIg@G{@MgAWwBGe@E[OsAO}A?C]kDIsACk@?g@?I@Y?Q@y@@_@Bo@Fq@Dg@Fo@D['
                     },
                     'start_location' : {
                        'lat' : -6.886861199999999,
                        'lng' : 109.5736979
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 503
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 25
                     },
                     'end_location' : {
                        'lat' : -6.891701899999999,
                        'lng' : 109.6219198
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. A. Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f~`i@}s`|Sj@iELuARyBNiB@u@@]?WAwB]{BE]'
                     },
                     'start_location' : {
                        'lat' : -6.8914009,
                        'lng' : 109.6174263
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 603
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 30
                     },
                     'end_location' : {
                        'lat' : -6.8906337,
                        'lng' : 109.6272645
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003ePatimura\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'b`ai@_pa|So@eDKg@_@kB?CCK_@aC?AAIIm@KwAE]WqDSoCKmB'
                     },
                     'start_location' : {
                        'lat' : -6.891701899999999,
                        'lng' : 109.6219198
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,4 km',
                        'value' : 2431
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 122
                     },
                     'end_location' : {
                        'lat' : -6.8899421,
                        'lng' : 109.6492141
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. A. Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ly`i@kqb|SAQKaBMeBA[K{B?{B@i@?SJyFB}A?MDwA@_@@g@Du@FqAJgBJkBB[LeDJ{D?w@?kAEcACq@GcAMwBOoDMuCCgBE{A?M?AE{@]eL?WOoEEeAIoBCs@Ei@Gw@Cc@G{A?W?CA}AC{AGwBGeB'
                     },
                     'start_location' : {
                        'lat' : -6.8906337,
                        'lng' : 109.6272645
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,7 km',
                        'value' : 1690
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 88
                     },
                     'end_location' : {
                        'lat' : -6.8890218,
                        'lng' : 109.6644865
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. . Gajah Mada\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bu`i@qzf|SGaBGoBEkAIiDGkBOkGEuBA[Ce@MwDAm@EqAAc@?UCo@Ai@CsAE_BCi@?WAI?UDKAe@GkCGaDAGGiCEmDE}A?WAk@EoAGkEIoAIgB'
                     },
                     'start_location' : {
                        'lat' : -6.8899421,
                        'lng' : 109.6492141
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 503
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 29
                     },
                     'end_location' : {
                        'lat' : -6.887085000000001,
                        'lng' : 109.6685779
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJalan. Merdeka/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'jo`i@azi|SCEMe@C[Gi@Mm@Qe@Wo@s@eB}C}GGMI[Ue@q@gB'
                     },
                     'start_location' : {
                        'lat' : -6.8890218,
                        'lng' : 109.6644865
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '28 m',
                        'value' : 28
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 97
                     },
                     'end_location' : {
                        'lat' : -6.887220600000001,
                        'lng' : 109.6687912
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 1\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'hc`i@ssj|SXi@'
                     },
                     'start_location' : {
                        'lat' : -6.887085000000001,
                        'lng' : 109.6685779
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 162
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 8
                     },
                     'end_location' : {
                        'lat' : -6.888588299999999,
                        'lng' : 109.6682967
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Otto Iskandardinata\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'bd`i@}tj|Sh@P@?jA^xCn@'
                     },
                     'start_location' : {
                        'lat' : -6.887220600000001,
                        'lng' : 109.6687912
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,1 km',
                        'value' : 1122
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 58
                     },
                     'end_location' : {
                        'lat' : -6.898205,
                        'lng' : 109.66533
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJalan. Kh. Mas Mansyur\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'tl`i@{qj|Sr@PlAZb@F`B^TFF@@?|AVNDFFVDF@r@Jl@LnAVnBZlB\\LBlAPrAT\\FfARRD`@Jp@P`@Ld@LPH~@ZDBnAb@VHJD@?`@L`B`@`Dj@F@pBR'
                     },
                     'start_location' : {
                        'lat' : -6.888588299999999,
                        'lng' : 109.6682967
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '46,4 km',
                        'value' : 46389
                     },
                     'duration' : {
                        'text' : '39 menit',
                        'value' : 2343
                     },
                     'end_location' : {
                        'lat' : -6.9734494,
                        'lng' : 110.0369125
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJalan. Jendral. Sudirman/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'vhbi@i_j|SB]Fa@DWDUD[H]R_A\\uAXaA@GD[`@cCX{AF[XmBHa@^wB@EPiAT{AVqARq@l@qAVk@LUv@cBf@aATc@HODKFK@EDM@EBI@K@OBk@DyAB{@CqB?I?oB@cAAy@Cq@?AGq@GaA?m@?Y?c@@c@Bg@?EBc@HeA\\iDR_C@C@QFi@LoAFm@LsA?ALaALcBJwA@W@MBSGM@K@SLoC@OP_CPqABWHo@V}BJ{@R{BB]De@DQPwBDa@@QPkBHaALuARsCBMFy@NuB@KTkD?CB_@F{@FaAH}AHwAHgAPiDBs@ToFJwDDmD@_AD{B?[BuA@sB?E?O@q@Bw@BsAFyBJ}DBiAHcD?_@D{BF_EFcCR{DPqC@GHiAPyBBUHw@LwANmB@]L}@?ENwBPkBNgB@IPcCPuC\\{E?C?APwCFkBRsEBYb@gH?CJeCToGNuEF_BPcDVsDJgA`@aFPoCB_@JiBLoCLcCLuA?EV{CFaAF{@ZuE@IL{ATeE?AZmEN_BFWHUJO@CrAsBv@iAtCmEJMrB}CNUf@y@p@_AJOnAsBzA}Bf@w@lBuCDIHMvAwB`@o@`A}A`AyAh@{@d@s@@A^m@Xe@d@s@PYjBqC?Ap@gAJQv@kAZi@HSHUF]BW@]B]DaA?CDi@DU@KDOLa@h@}@Xg@j@iAHQPo@Jm@BOJk@F[FUFMLYDIV[l@g@j@e@p@g@n@m@XYRYZc@fCkEP[JSTi@Li@Fe@Dw@Dc@D]@IBGDKL[HQLSPWNS~A{Bf@{@b@q@RW^YJIFEhAk@`AYjAa@VIzA[TEr@Ov@QzA[d@KZK^SPMPQRUHUJ]DU@]@QAWKu@IYMg@_@oAw@mC]iAGWCSCSAa@?Q@MBSBQBKBGJQNWVWhAcAt@o@LKXOLGPGLG@A\\I@?PGPCTENAVA\\CT?dA@l@@V?RAp@CXC`@GZId@OXKTI~@a@FEVK\\MDATI`@IDAlAQv@K`@G`@I^Kd@M\\OXQ|@s@\\]h@i@^_@JOLSJQL[JYDSDSDYD_@f@yIN}CDg@Fm@Da@D]L}@ZoBZ}BVmBFYHWJ]FMHMVa@f@q@h@m@TQb@]xA}@b@Y`@UnAs@nAs@XORIRINGf@O^IPCNCj@GbFQ^A`@ARAd@ETCPEZInBi@dCu@tAa@PGpCw@`@KjAWp@Q`AUv@QZGxA]`AUb@MDAv@W\\MvBy@z@]FCn@YPKPIVQPQNONQPUJQJSJYHSNe@ZgA`@uAPm@Hc@Jk@Fs@Dk@Bm@FyA@g@HeCDgBH{B@Y?EB_@Dg@Ba@NiAHm@Hg@TcANo@ViA@G`@gBVgAd@eBRu@Nk@HYh@wAVw@Rq@`@{AT}@Pw@Jk@Jk@Hk@Jq@Fc@B_@BW@WBwB?WB_@@_@Da@D]?AJo@Nw@R_AHc@F_@Fc@H_AF_A@o@@eB@e@?gA@e@@S@QDe@\\cDRqBFk@H}@p@oG`@mDXsCh@kDJu@Ho@Fq@ZkDH{@JiAJuAf@eELcABKDa@@]@[?_@AWCYEWEWKYM[U]Y[SQs@Ya@MOCg@EQC_BAk@CoDEcAAUAyMCcA@]?a@?M?SA_@EMCEAa@Mc@UIEi@_@c@_@OOQ_@I]EW?_@BW@QFUb@aB^uA@CZoANu@?ADWHo@BSZmD\\gEZwEX}EHgB@e@@k@@a@AS?ACOK_@IUMOSYi@c@eAw@q@g@QUMSIOEc@A]BYF]Xk@HOt@cAr@{@BETYJMp@{@h@{@BCN_@Li@Fo@FuBF}B@SJoAJa@F[DMb@cA`@k@T]z@u@j@g@vAmAt@k@RMr@c@JGbAe@ZKzAq@BATOd@a@d@c@`@k@b@gA@ABINe@Ls@@]Bm@@GHcDDi@B[Nw@Hg@Ne@Zu@`BuD@EvAgEBGFMvAmEDKjCkK@E`@gAZ}@h@{@x@mAJOn@{@LQpAgB`AuABGTa@p@cBz@oCb@eA`@aAr@wAz@uAv@oAJYDW@KHe@?g@Ag@Iu@O_BEs@?CCo@FoAPsBR}Bf@kEf@qCb@cBBETi@h@y@Xc@h@w@|AoC?ABEd@q@v@}@fAqAn@w@b@q@~@aBdAiBLYh@gAFK`@{@zAyC~@kBl@sA~AkDpBiEfAwBhAwBXa@r@oAtAaCNWr@uAz@_B`@_AxAkD@AdAiCXq@hAsCbBsDlByDpBcEtAuCPi@H[Je@Fo@PmBV{BTqBd@gENuA\\qCBSHw@RuBNsA@IFe@PcB@GNcAj@}DPoATqARmAJq@F_@Fo@?K@]?g@Ai@AQAOOqBQkCC[I{AA_@?e@D]@AJ[NWVW^S@?p@SB?rASr@Kz@WVK`@YVUPSr@kANYTe@^s@vAqCP_@v@kC`@uAPs@DQTk@HSv@kB\\_A`@aBFUh@wB`BuGn@}BLe@f@kBx@yCXgAd@gBNm@`@aB`@eBF_@Dc@Dw@?c@Aa@AYCUG[COEYu@yDEc@U_CEo@KcBAs@@m@HuBJyAZgFDm@^wG?I@IFyBBw@Bg@?KHcADw@PaDNcBHuANoAZqBn@_D`@oBN_Ab@iCR_AFo@Bo@Aw@Gu@O}@SwAIy@Ac@@a@Be@J}@LeAJs@D[J{ABw@?w@Cq@Iu@Uy@m@_BeAmCs@mBiA}C[k@a@k@k@g@gAaAe@a@y@q@WSYWa@_@q@s@}@}@cAcASS_A_A_@a@e@i@a@k@i@aAu@yAo@kAc@_Aa@{@Me@Mq@CSEWCWAMAKK{@MmAMwAGo@QoCImAC_@KqAWeCUsBOcAQqAOq@Mq@A?Qu@CESs@k@wAs@yAi@cAe@_A]y@Sw@Oq@OcAWkBEi@QmBQyAIm@Qw@I[EOCIg@kBg@}Aq@}BKa@Ww@g@gB[aA]}@Ym@c@}@Ys@O_@Oc@YyAYgB[cBKq@Io@AWAw@DaADgAFiALsAT{Ab@_DJ_AJsAFmBD{AHgAJiBV}EDwCDyCDqB@q@HsDDeB?[@qAJmHEeCMmCAQIqAKsB?CIuACw@AsBCcBAs@AeAC}A?}A?kA?wA@eA?s@?E?{AAiAA_A?IAeCDkBFiALyA@CP}BJiADq@TmCJ}@Ju@Lq@Pu@No@FUZsAV}@ZaAf@{Aj@aBr@iBb@cA~@uBVm@\\{@t@aBh@iAh@qAt@gBpAgCt@wA`AiBv@{A`@_AR_@DO\\aAJ]TcAFSXaAd@cBx@qCj@iCd@qB?Cp@wC\\cBNy@\\cBh@wCJg@XaB`@yBLo@P}@PiAb@eC@ENaAN{@\\mB^oB@KH_@TmABOn@oD@MRgANy@F[Fk@HcADaA?{AP}F@S?IBMBU@S?ADq@FuA?OHqCAcA?y@\\qMI{BI_AGq@[oBQu@U{@q@oB]_ASc@Ua@[i@e@w@U]e@m@q@w@s@{@g@s@Wa@[g@k@sA_AaCUg@OYYc@a@i@u@w@}@y@}@{@MSQWO[Qg@k@sBe@{BIUIUMWg@w@{AsBsAmBaA}AYg@Sc@Sg@Mc@]gA]_B[cBi@eDQeACU?ACUAS?SBW?MViAX}@HYZ_AHa@De@DeA?WDqB@o@BeA?SPcFB_A?CBg@J{CHiB@_@V}DDa@NaCNqB^mFBi@RuCPcCF}@LcBB[HwARkCDm@r@qKDk@d@aHPaCXcE@QNcCFw@HcATwCVsDNmBF_ANsBBc@DcABY'
                     },
                     'start_location' : {
                        'lat' : -6.898205,
                        'lng' : 109.66533
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,1 km',
                        'value' : 2090
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 108
                     },
                     'end_location' : {
                        'lat' : -6.9702258,
                        'lng' : 110.0550488
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya Semarang - Batang\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : '`_qi@uqr~SCYCSC[Ia@Gc@CSASCi@EIEMWk@mCqGIQsCeHQg@y@uBaAqC{BeGS_AQm@Qs@E_@AY?e@@w@@iD?O@k@?C@mA@mA@q@@c@@w@HiDF_C@Y@k@@UFmBL}D?K@SD{AFuB@m@@U?q@?a@S{F'
                     },
                     'start_location' : {
                        'lat' : -6.9734494,
                        'lng' : 110.0369125
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,2 km',
                        'value' : 3202
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 164
                     },
                     'end_location' : {
                        'lat' : -6.9523701,
                        'lng' : 110.0752735
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eRaya Penaruban-Batan\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : '|jpi@acv~SY{@EMCGKQKMOQ_Bq@kQqHiCeAQGECa@OoLsEKEqB{@iCgAuG}CoDcBaFeCgB}@qCqAo@_@US[YIISSOOEI]i@c@{@_@iAe@mByAwGy@sDGYsAwFkJua@{AsGG_@'
                     },
                     'start_location' : {
                        'lat' : -6.9702258,
                        'lng' : 110.0550488
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1428
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 72
                     },
                     'end_location' : {
                        'lat' : -6.956248599999999,
                        'lng' : 110.0875081
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Semarang - Batang\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'h{li@maz~SAQ@Y@]@OB[FSL[jBuE`B_El@sB^{ArIm^ZuALg@Da@DWFm@@SBQBa@XeDH}@J{B@G'
                     },
                     'start_location' : {
                        'lat' : -6.9523701,
                        'lng' : 110.0752735
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 129
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 18
                     },
                     'end_location' : {
                        'lat' : -6.9558079,
                        'lng' : 110.0885885
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eRaya Montong Sari\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'psmi@}m|~SgA}DOY'
                     },
                     'start_location' : {
                        'lat' : -6.956248599999999,
                        'lng' : 110.0875081
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,6 km',
                        'value' : 2644
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 132
                     },
                     'end_location' : {
                        'lat' : -6.9467684,
                        'lng' : 110.1101097
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eRaya Weleri-Kendal\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'xpmi@ut|~SQa@Oc@KYKa@e@qB}@uEcAaFQw@GYIa@ESW{AIg@QoBe@mEeAmIa@mDEc@Gi@AGC[OsAWqCQwAGk@EYEYIs@QaBUsBC[K}@I}@Gg@CQGWOg@Oe@EKOUOUg@}@A?U[OQ[a@qA}AmAyAW[SWe@o@KKcAkAKMgAoA]c@{AkBU[e@m@o@w@m@aAk@y@CEcBgCEIu@kAEIk@_AWe@IQ'
                     },
                     'start_location' : {
                        'lat' : -6.9558079,
                        'lng' : 110.0885885
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '35,2 km',
                        'value' : 35236
                     },
                     'duration' : {
                        'text' : '30 menit',
                        'value' : 1827
                     },
                     'end_location' : {
                        'lat' : -6.9876947,
                        'lng' : 110.3681931
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Semarang - Batang/Raya Perempatan Hali\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Raya Semarang - Batang\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'hxki@e{`_TGMMY[u@]s@MY{AsCm@oA_AkBS_@KQKSKUWc@eBcDmAaCcAmBkAyBGMkAuBOU?Ai@gAO[Wi@{@aBYi@Yk@O]oAuCMYAAWi@KSaBgD{@wBKYUgAYyAQiAi@cCCMSu@a@wAAEs@kBGOEO]qAOe@c@}AYmAK_@AKYqAgAuE_@yAi@mCUsA?ACWG]UsAES?GSqACII_@k@qD_@kBACCK?Au@cDCGCMCMAQAOK_AAYW{D?OAGCQOqBAOa@wDEg@_@mD]eDIeAG{@Cu@M{@AIEe@ESEQEKIWYi@KSMOSYCC]c@wAaBa@c@s@q@]SGESK_@O[MwBe@MCcBWsAUA?oAUwAYWGEA}Aa@yAc@yAa@{@Y_@Mo@U[MeBq@A?oAe@k@S]M{Ae@oA_@i@QiAYKCkCs@kA_@KGSIWKUQOMIOY]S_@Se@KYIWE[QqBMcCEkAAq@?E?m@@M@IFUL_@d@kAJWPc@BCVi@Zq@@ARe@DKXq@d@aA^{@`@}@Rc@LY\\w@v@mBlAuDb@eBXgADKFYPaAHqABGr@oDFSBGLe@jAsHDc@Ba@@YBu@@[?KAO?SAQOuAOuBCeAC}@Go@AY?MEeAGqBC{@?K?AAOCyB?MAI?c@?QEkBGoAEi@CSQy@kAwFQcAOu@k@qBi@cCIW?Ac@_Bm@eBEKKUACQYi@y@]k@o@kAWs@CKI_@GWc@yCc@yBIe@Qw@YaBs@yEMgAAIu@cG?Am@iGOwACW_@uEYoDm@iIAIy@_JCSi@kEUqBIw@QkBO_B?C?E?KAu@CeC?}@EiBA]AeCCaCAS?WEsCOwIGmDc@iIMmDC[MoBEq@U_DC_@Q_D?AK}A?QEmA?S?s@@EHs@D]DOBGFWDO@Gh@kBDQv@_DJ]p@qBDMRo@@EJ_@HY^iALa@ZaAZcAN]P[NWFGBCDCBCRINEZGPClHeAjDs@^IfCg@|D_AhJwBvA[xEaA|J{B`FcApEcA~Co@pDcAp@UlBq@fBq@v@]PIXM|Ay@FE\\YPQPOFGTU`@a@RWHODGZi@JS`AmBVk@zA}C~A_D|@mBj@iAtA{C@ATo@@?b@cADIN_@DI^u@BGTg@Zu@Na@To@\\{@Zu@^y@Re@Z}@@AVo@Zu@@ELa@BKpC_IbDgJVu@rEcNTq@FUFQjB{EfBkEJ[d@kAf@iAHOZq@FMxBeE?An@oA@A^}@Ti@d@uAr@cCLc@Pg@`@mAXo@`@cAPc@FMLi@@O@I@UAQ?GIi@AIK_@KSISKOKMEEMM}@u@ECoCqB_Aq@mAy@iDcCkDgCgEwCuDiCuAaAmBmAi@YqCcB_Ai@s@_@WO{KaGgE{BkDiBi@[i@a@MMGMOOMSIOKQISKWIUGUG[Go@A]Ao@?_@Fi@F]XyAj@kC^aBl@sCjBqH|@{C`@uAJ]l@oBXs@^{@b@cAv@yAp@mAzFiHtBmCl@u@l@u@hDaGz@_BlAoBZi@j@aA`CcEt@qANUbAgB~BcEbAkBrBuDDKl@mALUBGDIHODKTe@La@`@yAH]Ji@HY\\mA@IVqAZsAnBgI^eBrBuIn@uCv@iDhAuE`A}Dv@cD`@wAxAqEVu@v@cCl@gBTm@Na@JUHMJMd@i@ZWHE\\QVKvAe@pAe@|@YhA_@pAa@RI~KmD\\M`@MRETGVGPALCTAXCV?XA\\?J@R@R@\\DPD\\F\\J\\LTFz@VDB~Ah@lCdAvDrAtDrAlA`@n@RD@`@NJDH@NFNDRFLBPBNBR@P?TANAr@K@AVGXKLIRQX]R_@L[Po@Tw@b@eBBIHk@zAqFJe@H]ZyAP{@X_Cd@wDXuCJk@D_@@ODQRq@r@{A`@u@\\s@`CcFR_@t@wAf@cARa@|BwEDIz@qBn@_Bz@cDLi@T}@XmATaAH_@Ru@b@kBReAPeA?ADUFe@D]Ju@Dc@F_ABk@B_A?}A@kAGsDe@mFe@mFAYe@sG?ICc@IyAI{AEo@S{BKiBK_CC_@C}@Ck@G_FGmBMgDIaCAQ?U?Q@YBSD]BMF]Vq@HSXi@PWRWVWfA{@v@k@TORSNOPULOJSZk@FOVi@FOPc@FU@CBGTy@XgABORy@J]BQF]F]PuAH}@B[@GVsDFkADu@^uHJwALaBBa@HqB?c@?}@?k@CsBAg@A{A?O?e@?sBBaAFaB?IB}@ByA@g@HkBD_ADs@FkAHu@Da@DYBM@GJc@H]Na@T_@JQ\\_@h@i@d@a@\\[PQTSPQNQTUTY\\a@z@cAV[PUl@k@p@o@DE^YXQdE_Dh@c@XQ`BuAv@o@JIl@e@FEPMJI`@[`@_@\\UpAeAx@m@p@g@bCwBZ[LOFMPWTa@Na@Pa@Vw@HUr@wCDMLk@`@yATmADM@E@Ij@cCPiAJw@BW@I?eA?OEwBWaFKmBEeACq@C]?_@KoBE}@IiAIo@GWGYMi@Uk@c@eACEa@s@Y][]OKo@_@KGq@_@aAg@g@WwAy@o@g@USSUMSMSGOGOE[AU?Y?O@O@K@YNaBToAVuAJc@\\{APo@l@mBDQPc@@GHg@BKJ[Tk@L[DKJ[L]@CPc@FM@EXk@BGP[HMLSPUZ]FINMz@w@DCDEVOzAq@JCFCDATMTMLMPSHSDUDODWFc@BYD]BO@SD]J}@Be@H{@D_@JsAB]@{@Ds@@UHaC@GB_@Dq@?ALoA@KHg@D_@@KRs@j@mCRw@H[Rk@VcAJq@Nu@DUF}@B}@?C@UEa@AIEc@GeAKgAEy@A['
                     },
                     'start_location' : {
                        'lat' : -6.9467684,
                        'lng' : 110.1101097
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,7 km',
                        'value' : 1726
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 136
                     },
                     'end_location' : {
                        'lat' : -6.984645899999999,
                        'lng' : 110.383508
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Semarang - Kendal/Jl. Siliwangi\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`xsi@ehs`TS{DIw@AKCc@AQ?ESyCI_AIgAKyA?AMuBm@aDaA}FO{@C_@Gg@Iq@_@oDC]MkAUuBGa@m@wEAMw@kGgAyIE]COk@iDMs@Km@Qy@'
                     },
                     'start_location' : {
                        'lat' : -6.9876947,
                        'lng' : 110.3681931
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,0 km',
                        'value' : 2033
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 193
                     },
                     'end_location' : {
                        'lat' : -6.98086,
                        'lng' : 110.401153
                     },
                     'html_instructions' : 'Di \u003cb\u003eKalibanteng\u003c/b\u003e, ambil jalan keluar \u003cb\u003eke-3\u003c/b\u003e menuju \u003cb\u003eJl. Jenderal Sudirman\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : '`esi@}gv`TA?A?A?A??AA?A?A?GCCCCCCCCCACCEACAEAC?E?EAE?E@C?E?AAA?A?A?A?A?A?ABE@CBCBCBCBCBCBC@A@A@?Eg@CSAMCKG_@]oBgAgHi@cDWuAcAqFKo@Kc@Kg@a@uB?CmAyFk@iC]{AIa@G]Sy@G[Ia@Mk@Ii@OeAA?Is@AMGg@AQEg@[mCa@{DMeAGk@QcBUkBMoAS{CGs@Ce@A_@AQ?M?M?K?M@E?E@G@E@EDGPSBABA'
                     },
                     'start_location' : {
                        'lat' : -6.984645899999999,
                        'lng' : 110.383508
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 180
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 14
                     },
                     'end_location' : {
                        'lat' : -6.980915,
                        'lng' : 110.402699
                     },
                     'html_instructions' : 'Terus \u003cb\u003ekiri\u003c/b\u003e supaya tetap di \u003cb\u003eJl. Jenderal Sudirman\u003c/b\u003e',
                     'maneuver' : 'keep-left',
                     'polyline' : {
                        'points' : 'jmri@evy`TXyBRmABO?I@E?A?C?A?CKW[i@'
                     },
                     'start_location' : {
                        'lat' : -6.98086,
                        'lng' : 110.401153
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '60 m',
                        'value' : 60
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 8
                     },
                     'end_location' : {
                        'lat' : -6.9812789,
                        'lng' : 110.4029578
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Indraprasta\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'vmri@{_z`T?OBKFIFGFEHCF?F?F@H@'
                     },
                     'start_location' : {
                        'lat' : -6.980915,
                        'lng' : 110.402699
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 760
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 41
                     },
                     'end_location' : {
                        'lat' : -6.983843599999999,
                        'lng' : 110.4091128
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Mgr Sugiopranoto\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~ori@oaz`Tf@MPW?AHUFYFQb@oAh@{A@AFO~@eCjAaDPi@JYh@wARk@?ARk@La@BKx@yBd@yADO@EAG?E_@aB'
                     },
                     'start_location' : {
                        'lat' : -6.9812789,
                        'lng' : 110.4029578
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,1 km',
                        'value' : 2067
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 188
                     },
                     'end_location' : {
                        'lat' : -6.9707034,
                        'lng' : 110.4207626
                     },
                     'html_instructions' : 'Di bundaran, ambil jalan keluar \u003cb\u003eke-1\u003c/b\u003e menuju \u003cb\u003eJl. Imam Bonjol\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : '~_si@}g{`TEEECCEEGCECEAGCGcAa@u@WyAe@OGOECAiEyAk@UQGuAc@kAa@iCaAk@QaC{@[OGCsAe@sDgAw@WME}Am@}Ak@OGmAc@EAQGm@QOGc@OSGcCeAGMSe@Y}@AC]}@a@gAoAwCkAcDg@wAM_@CGM]EOEIa@cAi@sAUg@CMIUAEIWCG_A}BKYAE]{@CI_AaCO_@'
                     },
                     'start_location' : {
                        'lat' : -6.983843599999999,
                        'lng' : 110.4091128
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 523
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 77
                     },
                     'end_location' : {
                        'lat' : -6.9661688,
                        'lng' : 110.4196235
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Petek\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'zmpi@wp}`TcDp@G@MBIBIBw@PK@eARKBc@He@RI?[COBC?e@HA?e@DM@A@cAL_AJE@YD[B{@HODk@HKD'
                     },
                     'start_location' : {
                        'lat' : -6.9707034,
                        'lng' : 110.4207626
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 154
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 20
                     },
                     'end_location' : {
                        'lat' : -6.9665176,
                        'lng' : 110.4182754
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Petek\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'pqoi@si}`Th@rCDTVxA?@?@?@A??@'
                     },
                     'start_location' : {
                        'lat' : -6.9661688,
                        'lng' : 110.4196235
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 123
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 11
                     },
                     'end_location' : {
                        'lat' : -6.9654551,
                        'lng' : 110.4180024
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e di \u003cb\u003eJl. Petek\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'vsoi@ga}`TA@?@A?CBA?C@IB{Dh@'
                     },
                     'start_location' : {
                        'lat' : -6.9665176,
                        'lng' : 110.4182754
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 154
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 30
                     },
                     'end_location' : {
                        'lat' : -6.9659375,
                        'lng' : 110.4166942
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Kakap\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'bmoi@o_}`T`@zADPNj@f@jB'
                     },
                     'start_location' : {
                        'lat' : -6.9654551,
                        'lng' : 110.4180024
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '79 m',
                        'value' : 79
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 16
                     },
                     'end_location' : {
                        'lat' : -6.966628800000001,
                        'lng' : 110.4168616
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kanan.\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'bpoi@iw|`TNEVEj@Ir@K@?'
                     },
                     'start_location' : {
                        'lat' : -6.9659375,
                        'lng' : 110.4166942
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '126 km',
                  'value' : 126144
               },
               'duration' : {
                  'text' : '1 jam 59 menit',
                  'value' : 7114
               },
               'end_address' : 'Lasem, Karangturi, Lasem, Rembang 59271, Indonesia',
               'end_location' : {
                  'lat' : -6.6987176,
                  'lng' : 111.4444837
               },
               'start_address' : 'Semarang, Kota Semarang, Jawa Tengah, Indonesia',
               'start_location' : {
                  'lat' : -6.966628800000001,
                  'lng' : 110.4168616
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '79 m',
                        'value' : 79
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 13
                     },
                     'end_location' : {
                        'lat' : -6.9659375,
                        'lng' : 110.4166942
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003eutara\u003c/b\u003e menuju \u003cb\u003eJl. Kakap\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ltoi@kx|`TA?s@Jk@HWDOD'
                     },
                     'start_location' : {
                        'lat' : -6.966628800000001,
                        'lng' : 110.4168616
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 602
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 87
                     },
                     'end_location' : {
                        'lat' : -6.9647983,
                        'lng' : 110.4216685
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Kakap\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'bpoi@iw|`Tg@kBOk@EQa@{AYoAAAIg@U{@ACKg@K]YcAEUGWIe@AGQy@?MKw@MaAEYAKAKCMCK?I?C?C?A@C@ABADCZITCBA'
                     },
                     'start_location' : {
                        'lat' : -6.9659375,
                        'lng' : 110.4166942
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 168
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -6.963678,
                        'lng' : 110.422327
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Komodor Laut Yos Sudarso\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '~hoi@mv}`TAAAEUo@[i@QUEGCAECGEGAEAE?E?KAO?K@u@HG@'
                     },
                     'start_location' : {
                        'lat' : -6.9647983,
                        'lng' : 110.4216685
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 476
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 63
                     },
                     'end_location' : {
                        'lat' : -6.965900299999999,
                        'lng' : 110.4252201
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Bandarharjo Selatan\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~aoi@qz}`TSaA?KAE?E@G@C?GBGDIFKJQHMFIHKDEFEHEDCJCJCPEp@KrC_@JATEHEFCFEDEDIFKFSH[F_@FYHm@D[@O@W?_@'
                     },
                     'start_location' : {
                        'lat' : -6.963678,
                        'lng' : 110.422327
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '53 m',
                        'value' : 53
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -6.966378499999999,
                        'lng' : 110.4252039
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Empu Tantular\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zooi@sl~`Tj@@r@@'
                     },
                     'start_location' : {
                        'lat' : -6.965900299999999,
                        'lng' : 110.4252201
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '26,4 km',
                        'value' : 26365
                     },
                     'duration' : {
                        'text' : '23 menit',
                        'value' : 1408
                     },
                     'end_location' : {
                        'lat' : -6.9068093,
                        'lng' : 110.6512022
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Merak/Jl. Raya Semarang - Purwodadi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Raya Semarang - Purwodadi\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'zroi@ol~`T]wBQiAg@s@mB_DGKEOAEGWCKEIKSS]Yg@S[m@y@EGACCGAC?C?C?A?C?A@IBG@EBEBEBCDC\\Q`@WDCDC@C@C@C?C@C?EAE?E?EAECECIEIa@s@cBeDCIAGAIAK?K?K@IAEAECKKYGMg@oAe@iA?Aq@wAaAkBCEUc@k@mAeAyB_@{@_@w@sAsCc@}@ISSe@qBoEWk@wA_DO[EKCG?EAGAG?G?G?E@E@I@EBEBGHI`AuAHMDGDKDKBK?G?C?E?CAEAICGIYSk@K]Mc@Ic@CGIa@GYCOQcA[yAo@{C_AmDEIMa@Sm@i@cBI]K]}@uDu@{CSw@AEESSs@Ok@_AyDCGe@wBIc@I_@Ie@O{@Ea@OqAE[A[AYEgAAm@?OA?AY?AMwCOcEMuCImC?IGqACu@Ci@?C?MI_CIyCUyFAOGoASmDIsBCo@Ck@IuAYyGAQM{BMsBGsAAOAWCe@KaCAGQeECq@EkAC_AK_CU}CO{@OkAKo@Iu@YeBG[c@iCe@gCIe@e@wBu@cCUu@GSSy@GQcB{FW{@k@qB]kAm@qB[gAw@gCK]Oi@k@eCKYa@}AgAoDI]?AIWyHkYaAwD}@mD_FoRCKeCuIg@kBiDyMaBeGIYIYo@_C]oAOm@WiAWoAw@iDi@gCWgAi@eCKc@WkAu@iD_@aB]}AKe@COk@qCg@cCq@_DI_@[yA[sAI]U}@G]YoAA?G]Me@COK_@GWI_@Qu@U_AGY_@eBEQU_AS}@UaAAGEOIa@a@eBMi@e@uBS{@?AU_A_@}Ac@mBKe@IYg@}BYwAQ{@]cBKi@]_BWiAKg@]cB_@gBS{@EUg@gCOs@_@mBACYmAQw@[uAm@uCGU_@_BOs@CIQ{@YuA]aB[wAS_AUgAm@gCqAcG}@wDCKoAuF[uAoDcPm@qC_@_BiAgFQw@UeAGYk@gCEUe@kB_@yA[oAMk@e@wBIc@I[EQiI{^oGcYMi@ES[wAUmA?CMk@WkAc@oBu@iD_@gBUoAAGO_ACUIo@AA[cCk@eEAEo@sEWkBIi@QmAOcAKo@My@QsAq@aFGa@AMaAkJSqAMcACSOuA{@uIg@iFQaCc@gFWqDM{AIqAEi@W_EEo@u@mKS}CKyA[wFKoAAOy@_LWiD_@}EMkBYkDMaBQeCSiCMcCGq@ImA?AEk@GeAG}@Cg@AOYsDKoACg@OgBKyAEy@Ea@Ce@OwBC_@Iy@KqAYoC?ECUEUIq@Qy@Ga@Ka@Oo@Ia@AE}CwMkCgLAA[mAU{@_@}Ak@sBUu@Oi@o@mBAAIYa@iAk@_BaAgCgAqCM[m@cB?AUw@]sAUu@Su@g@_BeA}Cq@kBsDkJ?A[{@]}@}@eCg@wAg@sAKWu@qBy@}BISkAiDIS?AAAo@gBWs@EMQg@ISAECG}@eCyAyDM]M]{@aCM[Qe@?AAAKYMWs@_B_AcBKO_C}DaBoCIMwBsDKOACAA?AqAwBg@aAYc@g@w@Wa@S_@k@aA}A{CEYAGAG?I?M?YB]@MViBd@cCb@eCv@gEx@}Dl@uC^aBTsAVoAX}AXwARqAToAVeBZqB\\gCJq@?A?A@APuANcANeAVkB@M@UBq@Bu@@cA@i@?A@SA{@?u@Ai@GcEGqD?cACi@Cg@C]KaAMm@AECSAME_@Ei@AUAC_@gGEw@CoAAsA?iDFsJFqE@i@?g@@m@A_@AYCSESEOCKEIIMIMMOKMOQe@g@k@o@GGEE_@c@g@i@UW_@a@a@c@'
                     },
                     'start_location' : {
                        'lat' : -6.966378499999999,
                        'lng' : 110.4252039
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '24,3 km',
                        'value' : 24270
                     },
                     'duration' : {
                        'text' : '21 menit',
                        'value' : 1287
                     },
                     'end_location' : {
                        'lat' : -6.817835,
                        'lng' : 110.83832
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Lingkar Demak/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'p~ci@_qjbTSSIGKIKEIEICECGCGCMCOEQEUESEyBUc@Ei@G{@K_BM}@EoAG}AGeAGgBGA?mACcCIqACsBEwBIa@GOCc@Km@Ui@Wk@_@_@W_@]YYIIOYWe@g@sAw@gCy@yCcBmFaA_DAGmAuDgBmFeAgDAGK_@Ma@ACAEiAmDeAiDu@_C[_Ag@aBk@aBAACGS[]e@i@i@gA{@gFqDoCmBa@WoBqAqCkBWOoA{@{AaAgAu@qA{@aAo@_@Wa@W_Ao@o@_@k@Wk@UiAYuAW}@M}@Oe@GcAQmAUuB}@k@u@WgB[wBCOwAiIAKw@{Eq@wEm@iECUs@wEKo@g@}CCQQ_A]yBCOo@cECOYaBUsAKo@AOO{@mAsISyAMyA_@mDSiBSuAMm@M_@a@yAOm@Ki@CWI}@a@yEMu@Ow@q@_DgA{ESiAk@kDc@mCo@yDYiBUcBa@qDMqAMiAa@yEYeDcAkLy@_JQiCWoCASYqCOcBk@_H]gEm@qHYoDEg@MwAUoCw@eJKyAa@mFa@{FgAkNCk@E]Y{DIqAQ}B]uDWeDOgBYcDWcDQsBOeBKiAK{AUoCUyCYgD?AOgBOoBQoBQqBAOAGIaASkCW_DEg@EY?CGw@c@uEYsC[aDCUOgBUwBYcCI}@G_@m@aFEc@UmBW{BMoAa@yDMgAOoASoBMmAYkCIy@MoAGk@UoBwDy^a@eEYeCWkCMkAAKGg@a@{DCUK}@UeCAGYuCAMKq@KeAi@}EOqAAEk@_GCSE]AMGo@Gi@KaAKcAGi@MkAOqAGa@Ga@Ge@?CAGM_AAGG]O_A_AoFO}@_AoFc@}BKk@a@kCY}A_A}FCOUuAEYQaA_@yBAG_@uBGWWuA[}AKe@YsAMm@[uACQ}@gEk@cCg@iCEOYoACG?A]wAaAmEg@mBa@wAK_@o@sBIYa@qAK[{@oCy@kCa@mASk@aAsCGOc@qASm@Um@Um@KY{@}Bs@mBM_@gAqCuAmDGQq@eBaAeCCEEOO]_@}@}@eC?Au@kBqAkDgAwCeAuCeAqCcAoCwA}Di@uAe@oAa@kAc@oA_AoCUm@eBcFyA_EO_@Uo@kAoCi@kAEMUc@w@eB]u@eCsF_@w@MWmAuCUi@Ui@m@{Ac@}@IQ{@oBO[Oc@CWIQUg@CECIM]Qi@Se@iAkCMKGIIM_@u@Yc@]a@UYu@{@qBcCi@k@?AwAmBY]Y]W_@}@cAMMQQ_@e@k@k@c@g@e@g@W[e@e@AAKMEGSUEGY_@YYMMGIIGQUSU{@aAYYKOKMMK{@aAu@{@_AeA}@cAA?_AeA}AgBeCqCSS[YOOGIEEWWOSSSIKKMESg@i@][QSOOeAcAcAeAkAmA_@_@SQACAAUWa@g@AAAAm@m@GIeAgAqAoA?AA?SSu@u@AAAAIKAAAAAAu@y@k@k@AAAACEA??AAAe@e@CAAAAAKKKKAAAAo@q@a@_@ACWYCAq@s@}@}@OOAAA??AAAi@k@KKAAAAk@k@cAcAOQAAAAi@i@cA_Au@s@q@o@ACu@q@m@i@QQOMe@c@[[EEAAw@s@y@u@c@a@QQ_Au@ACa@]GGMMAAAAc@a@AA_@Y[YEEe@]u@c@AACAu@_@mAi@eAe@YK_@SCA{Ao@EA{@_@A?SKaCcAk@UMEkBu@AA]Qo@i@GGIG]SIEiIcFkAs@IEyBsA'
                     },
                     'start_location' : {
                        'lat' : -6.9068093,
                        'lng' : 110.6512022
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '92 m',
                        'value' : 92
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 18
                     },
                     'end_location' : {
                        'lat' : -6.8175026,
                        'lng' : 110.8375526
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e di \u003cb\u003eJl. Ronggo Lawe\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'nrrh@obocTcAxC'
                     },
                     'start_location' : {
                        'lat' : -6.817835,
                        'lng' : 110.83832
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,1 km',
                        'value' : 1107
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 134
                     },
                     'end_location' : {
                        'lat' : -6.80818,
                        'lng' : 110.84107
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Dokter Ramelan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jprh@u}ncTo@QYIGAKCu@SUGiBo@q@QcBa@iBg@oAa@kEmAoA[gIwB_EgA_MiD'
                     },
                     'start_location' : {
                        'lat' : -6.8175026,
                        'lng' : 110.8375526
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 107
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 20
                     },
                     'end_location' : {
                        'lat' : -6.8072781,
                        'lng' : 110.84142
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Jend Sudirman\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bvph@usocTsDeA'
                     },
                     'start_location' : {
                        'lat' : -6.80818,
                        'lng' : 110.84107
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,0 km',
                        'value' : 4023
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 330
                     },
                     'end_location' : {
                        'lat' : -6.8049895,
                        'lng' : 110.8771835
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Jend Sudirman\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'npph@{uocTG_@Ls@Ny@Hg@@K?A?I?QAW?IAG]}B_@{BKq@EUo@iDKk@S{@S}@i@{Bw@eDEK[{AIa@_@}AG_@gA}E?AI]AACOAA?Ae@oBk@{BGWSw@g@uBuAwFMkAEc@C_@EaACm@ImAAGAUEm@C_@Co@?E?]AY?I?IAu@?A@[?C?IAe@?CA{ACe@AaB@k@@gB?A?ADcAH}A?A?A@GBi@?A@AHoBBi@@K@S@E@SJ{B?A@Q?C?AF}@Dw@FmBAk@?G?I?aB?c@?G?_A?cD@gA@sB@oAHsBDiABk@?G?I@O?K@E@WFmBDu@?KB[@]@WD}@PyCBk@JoBDu@De@@OJ_BFaA@ODoANuD@IF_B?G?EFoAFaCBkABw@By@?W?gA?I'
                     },
                     'start_location' : {
                        'lat' : -6.8072781,
                        'lng' : 110.84142
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '18,4 km',
                        'value' : 18365
                     },
                     'duration' : {
                        'text' : '15 menit',
                        'value' : 921
                     },
                     'end_location' : {
                        'lat' : -6.7515116,
                        'lng' : 111.0262337
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Kudus-Pati/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'dbph@kuvcT?I?[A_@Ak@?W?C?OAO?IA[?o@Ay@?eA?M?YBs@JeB@IAQ?GAA@K?UJeBF}@@QFcAR{CBO@EBIBKDy@RqCBY?GJcBB]J}APqBPcBHo@@MHk@TuAJw@ZiC@QFqA?Q@U?CCeB?q@C_C?e@EaBAeC?UD}GAgA?Q?SAKEwA?SEi@Gq@AKImAQwAMeAQwAQ{AOsACSCSCQC_@AKCa@AYOuDK}BEkACq@GmCIuCCcACw@Ck@Cq@?ACgAEkBAmACmBA_A?KBsD?kA@YBiAFaD@MJcBF}ADs@@G`@oGNmBBoADcAHaB?QFqABg@L{ANmCLkCN_DJmCDy@@SH}BBw@@i@@[@[BiA@cA?[@k@@eAJyEBSBK@I@M@O@UBcA@y@?c@?i@@a@?a@Aw@Ac@Aa@Mq@Ki@Qs@GSGSUi@[u@KU_@{@eDyGuAmCcBeDO]q@wA_@_AM[_@qAKc@Mm@Ms@Mi@Kq@AIUqAK_AMwAA_B@mGBoD@yFDuACsAGkA]yFOeC?EQeDYgCOw@qAyGY{AS{@Y{AEUi@oCUeASk@CGKWw@cB[m@s@oAc@y@wAwCk@gAg@_A{ByEu@{Ae@yAu@sCIa@]aBESMo@UmAIa@[eBKg@Kg@I_@u@yD[iA[_Aa@yAEO_@qAUy@Oo@GYAA?AEUC]Ec@ACCo@Ca@E}@A{@A_AAgA?k@@S@o@Bg@F}A@I?EDgA?S?[IgBIcA_@oCSaBIs@Ks@Y{BOgBMoAAGKaAAICOCSQ_AQ{A?EAG?G?EAO?]@CCaA?KAs@AcAAa@CSMiAOmAIm@CK?AIi@ASC_@SqAGUMm@Si@Q]_@s@Ua@MUe@w@{@}Ay@yAsBuDIMWk@Yk@M[uAyCo@eBM[g@wAiAcCQ_@a@_Ac@w@a@s@AAoAsBm@aAc@q@OWMSsBmDA?CAAAgAgBwDcGU]}AeCo@aA{@sAkAmB{H}Lo@cAOWU[EE_@q@OWAAO[EIOSgDmFKQm@_AiAiBeBoCWc@w@mAm@aAq@eAGK_A{AMS{@qACG{@uAIMCCMSCGIKs@eAU_@U]CEi@{@S]gAeB_@m@KMMSMSa@o@Yi@KQ[m@EIMQKSsAgCUg@c@_AACSa@GK{@yA}@oAUYw@}@IOmAkA[[uAwAEEaBmBQUeAmA{@cAIKCEyAiBIIkB_CMQ}@kAcAoA{AmBUYSWq@w@U[QW_@_@m@y@mCqD}BwCUYQSGKQSKM[_@g@o@i@s@S[k@w@k@y@}@gAEEIKmA{AY]_FsG_DcEgAwAcEmFoCiDGKCEQUcCaDMQ_AmAu@_AIMIMGIkA}AEECEqA}Ae@k@c@m@c@m@]a@SYg@q@oGgI{AkBmBkCIKcByB[c@MQo@w@cAmAW[GG_AkAk@u@g@o@g@q@aBsB_@g@w@eAkBiCIKk@m@'
                     },
                     'start_location' : {
                        'lat' : -6.8049895,
                        'lng' : 110.8771835
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 526
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 53
                     },
                     'end_location' : {
                        'lat' : -6.748103,
                        'lng' : 111.0282487
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Tunggul Wulung\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|seh@}xsdTUBE@UDOB[?S?k@COD_AXMDU@MAMCECGCYSACm@y@KMKIOEWCcAMYEGACCKIIMEQ_@sAAE{@gD'
                     },
                     'start_location' : {
                        'lat' : -6.7515116,
                        'lng' : 111.0262337
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 735
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 37
                     },
                     'end_location' : {
                        'lat' : -6.7483852,
                        'lng' : 111.0348871
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Diponegoro\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'r~dh@qetdTACAa@AS?yAAQ?G@}@?G@sDBw@FsDDuB@g@RuFB}@DiADkADs@'
                     },
                     'start_location' : {
                        'lat' : -6.748103,
                        'lng' : 111.0282487
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 352
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 18
                     },
                     'end_location' : {
                        'lat' : -6.7486899,
                        'lng' : 111.0380619
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJ A. L A. N D. I P. O N. E G. O R. O\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'l`eh@aoudTBk@L_D@WLkCXcG?E'
                     },
                     'start_location' : {
                        'lat' : -6.7483852,
                        'lng' : 111.0348871
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 354
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 18
                     },
                     'end_location' : {
                        'lat' : -6.7489197,
                        'lng' : 111.0412605
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Diponegoro\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'hbeh@{bvdTJwDLkEFsB?AD}@@[Bk@'
                     },
                     'start_location' : {
                        'lat' : -6.7486899,
                        'lng' : 111.0380619
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 524
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 108
                     },
                     'end_location' : {
                        'lat' : -6.753554800000001,
                        'lng' : 111.0404002
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Dr. Susanto\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'vceh@{vvdTP@nC\\VBdCZ@?P@nBPN@lBNb@DN@~Cb@\\BpANVD'
                     },
                     'start_location' : {
                        'lat' : -6.7489197,
                        'lng' : 111.0412605
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,7 km',
                        'value' : 1685
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 101
                     },
                     'end_location' : {
                        'lat' : -6.7511249,
                        'lng' : 111.0548631
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Pemuda\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 't`fh@oqvdTNy@DYPkBBW\\yEj@eG@OHmB?GNqBHgAJsABc@PiCBc@?M?G?AAEq@yBIWeBeF_B{E{AeE]mAiAoDYy@mC}Hw@_C'
                     },
                     'start_location' : {
                        'lat' : -6.753554800000001,
                        'lng' : 111.0404002
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 460
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 23
                     },
                     'end_location' : {
                        'lat' : -6.7494539,
                        'lng' : 111.058673
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Pati\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'nqeh@{kydT}AwEqBaG}B_H'
                     },
                     'start_location' : {
                        'lat' : -6.7511249,
                        'lng' : 111.0548631
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '10,0 km',
                        'value' : 9985
                     },
                     'duration' : {
                        'text' : '8 menit',
                        'value' : 500
                     },
                     'end_location' : {
                        'lat' : -6.7182982,
                        'lng' : 111.1431863
                     },
                     'html_instructions' : 'Terus lurus ke \u003cb\u003eJl. Pemuda/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'maneuver' : 'straight',
                     'polyline' : {
                        'points' : '`geh@uczdTm@kBYy@K_@EMu@sBkC}Hg@wA{@eCACIU}@iCEK}@sCuA_EWw@mCaIaB{EAGgEcM?AcA}CiCgHu@wBoFePACk@gBEQg@yAIWAEk@}A]eAGQOe@}@iCiA_DiFeOW}@yAmEeCqHaAsCgBcFs@mBmByF}@kCa@oAi@cB]_A[_A[}@]aA]aAQk@Y{@Ww@Oa@K[_@iAa@mAsDqKw@{B[{@c@sAa@kAKWa@iA[_AIY[w@AG[}@k@eBe@sAi@aBeA}CIYi@cB_@mACKc@wAi@eBe@}AACg@wA[aACI]sAS{@WgAa@eBc@iBU_AWeAYsAc@qBWoAa@cB[yA[wAGWq@wC_@}AWgAm@iCUeAYmAYyAWmASqAWeAk@aDs@gEAGc@mB}@cFe@kCUuAa@_Cc@gCc@cCUuAWwA_@yBQeA]aBMw@]yBMq@Mq@Km@G_@UqAUqAeAqGCMO_AIe@Kq@GUCMIi@_AeFm@_DeAoG[cBCSq@yDQgAu@qEuAoIyAwIEUuAmICUg@{CMy@AGGW?EGQAEAe@@Q?W'
                     },
                     'start_location' : {
                        'lat' : -6.7494539,
                        'lng' : 111.058673
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 468
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -6.719551699999999,
                        'lng' : 111.1472013
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. P. Sudirman\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jd_h@}sjeTFYJYX}@Vy@x@}BDQ@C\\oAPm@Hc@F[NcBJgANwAB[?C'
                     },
                     'start_location' : {
                        'lat' : -6.7182982,
                        'lng' : 111.1431863
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '10,7 km',
                        'value' : 10661
                     },
                     'duration' : {
                        'text' : '9 menit',
                        'value' : 534
                     },
                     'end_location' : {
                        'lat' : -6.705165099999999,
                        'lng' : 111.2400302
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Batangan-Rembang\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dl_h@_mkeTFmAJoAJeABQ?CPoB@I?C@MLeALsADa@@OBe@?]EYI_@M]c@i@UWo@m@_Ay@_DqC{AsAqAiAIIoAgA]YcA{@UQGGYWSQAAkD_DWY}BsBy@o@[e@U_@EKGMEOGOIUCGAE?CQs@CKAGAO?MAmAA_BCq@Ac@?I?ECsEA}B?]?aBCoAEeD?QA{@?K?{@AgB?ECsDA]Au@?CGeBAo@?i@@{DC}@AM?OE}CQ_D?IEs@IqBI}AQaDWyEG}@GiDEoAEgAAe@I}CASAU?YMeDU_FGkAQyDAM?GCo@WoFEu@AOMaCAGMgDEw@?GCa@?IUgE?EG}@S}CCg@Q_D?AQcFQiDIkBC_@AWAqAIoB?CKiBQkDAo@Cc@Ae@GkBEy@Q}EQwDOaDCe@Ei@IqBM{CKqB]eHCe@W{FIgBSeGAcAAm@IuB_@cJEiBCw@CeB?Q?{@Ci@CeA?c@C{B?y@EgGAi@CmCGwCImBAUSgEQ_D?GEaAA[UqEAa@KmBIkBCu@OeEG{CAiBGgEMcJAWIkFIqF?QCeE?C?YCiB?QAcBGeDKiCAm@IyAAUEa@Es@MaAAGYiCKi@eAkHgAqH]uBUiAEUY{AKe@s@kDc@oCa@yBQ{AE[ACAIGUKWMSKOMOGEa@[[SACGEMKq@i@'
                     },
                     'start_location' : {
                        'lat' : -6.719551699999999,
                        'lng' : 111.1472013
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '7,7 km',
                        'value' : 7726
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 387
                     },
                     'end_location' : {
                        'lat' : -6.6988884,
                        'lng' : 111.3080158
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Kaliori-Rembang\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'hr|g@eq}eTA?aAw@WYMSKQEMEKCOCO?IEc@Cc@A?EiA?ECe@Gs@CYAMGe@CIQo@IWEOk@cBk@oBWy@KYY_AUu@AEQk@Ma@EKACY}@K[Qi@]cAEOOa@o@uBk@aBIY_AyCQi@[qAKc@EMMm@Qy@Oo@EQ]cBQw@EOe@aCCK[aBCOCKE_@CQKo@Ks@Io@]_COsACSY_C?E[sBKaAUkBMu@[oCk@_FKs@AMo@_GIs@WgC[mCE]_@aDOsAQ}ACOMuACSEc@AIKcAMgAAG?CEk@E_@SiBOiASkBAOm@gGYiDYkCGa@OcBUqCCi@Cm@GeC@qA?gA?iAA]A_@CgAG_AEe@Ee@WyA}@wDm@gCa@mBQy@AEE_@C_@QoBC[SyBCWYiDAKEg@AMEkACc@EeAEs@AUA{@?iB?uA?C@qA@QAK?k@@aCBmB?}@@_CDcCBsBFkBFs@Hg@Fw@FkAD}@FiAFaABw@@CJsAHmAZwD?AXqCf@qFFu@PmA?CL}@F_@?Cl@wFHs@LcADc@f@iEb@sDdCcNf@qCp@qEv@{FNmANmAb@{DN}ALkA'
                     },
                     'start_location' : {
                        'lat' : -6.705165099999999,
                        'lng' : 111.2400302
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 381
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 19
                     },
                     'end_location' : {
                        'lat' : -6.6996999,
                        'lng' : 111.3113714
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Untung Suropati\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`k{g@czjfTt@kEPoAj@sDb@_DHm@'
                     },
                     'start_location' : {
                        'lat' : -6.6988884,
                        'lng' : 111.3080158
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,3 km',
                        'value' : 2347
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 118
                     },
                     'end_location' : {
                        'lat' : -6.703962799999999,
                        'lng' : 111.3316101
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Gajah Mada\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bp{g@aokfT@MDYLoA?EBQ@Q@SDi@?IDy@@I?]@C@e@@O?U?U?A?M?A@M?AB}A?CAu@C}@AMAk@GoA?EC]Ci@CSAG?CAQAOAICSASCWAQEY?ECUAKEcAC[CUAYG{@C[ASAQAE?AAU?KAa@AY?A?CEeA?A?AAM?G?Q?M?A?A?AAe@?W?U?i@?S@e@?CBa@BWBWBU?E@CBUBMBSDQDO?CFU@IFWLg@FWT{@DKLe@La@FS@C?CHUFSFSHUDMTk@DKL[HUBEDKJYN_@?AN[L_@HSHWHWDMDMBEHWHQDSHU@C?A^aAFML]J[BG@AHUNe@Nc@Nc@@CJYBIFORg@Zq@BIHQ@?Zs@Tc@JS?ALYRg@Tg@DMDMBGBE\\}@JW@C@AJ_@FWj@aC?A@IBOBMBSDUDY?EJu@D_@'
                     },
                     'start_location' : {
                        'lat' : -6.6996999,
                        'lng' : 111.3113714
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '13,4 km',
                        'value' : 13450
                     },
                     'duration' : {
                        'text' : '12 menit',
                        'value' : 692
                     },
                     'end_location' : {
                        'lat' : -6.6977603,
                        'lng' : 111.4477578
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Diponegoro/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan melalui 1 bundaran\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'vj|g@qmofTHm@Fk@@GJ{A@e@@]Bq@@G?G?K?wB?[AgAAkAEeCKmBEgACg@A_@C}@BgBBoB@sABcCJ_EBi@Bc@@c@@aABm@@m@BqAA?A?A??AA?A??AA??AA??AAA?A?A?AA??A?A@??A?A?A@??A?A@??A@??A@?@??A@?@?@?@?@?NkBDo@Bg@BU@Q@SBc@FmABYJeB?EZkGFqAB[Bm@L{CJeC?OHsA@e@@OBi@J}BFuA?ODsALkCJwCFyA@]@GBcA@O@QN}DDoAFiBF_BDgADkB`@cLFmAFuB@s@@a@@aABgADsADs@L}C?G@O?Y?AF_A?K?A?S@_@@]Bo@Bo@FkB?O@M@gA@{@B_A@kABy@Bm@Du@?YB]?WBiAD}AFgB@]?C?CHyAF_ADg@?I@k@?Q@WJkB?OFoB@WDmA@g@`@oMB_B?q@?SAWAC?GCs@Cs@Iu@K_AMy@QgAKe@w@cEi@oCCGy@eEKi@G[c@gCIa@uAsIAI]kBk@cDCMg@oDIo@OqACMWiBa@{CIg@Im@CSQ}A_@{C_@uB]eBU_AUcAWwA[_BG]AAKk@Ka@I[Mc@K[Yu@c@oAu@wBWs@M[Qi@a@kAa@iASi@AI}@oCIWOe@g@sA[aAMc@AEIWa@uAm@sBm@qBy@kCu@gCSw@c@cBI]y@kDi@yBWu@Kc@A?Sk@Qi@yAwDSk@I[o@wBEM?A]sAAICG?AEO}@mD?A[mA[mA?AUy@UaAk@wBUcAs@yCS_A[mAAAKe@AEs@sC[iA]aA?A_@eAy@oBu@wA[m@e@}@[s@y@sBAGEICGAAQc@[w@uAwD]eAc@mA?AOg@k@iB?AGUq@sBuAoEOe@YeA[gAa@wAA?YcAOm@_@qAg@gBa@}Ay@_D_@{AUaAAEI]Mq@E]Ce@AY?K@KNcAHy@Nk@@A?AJ]Xo@DK@EHQ`AyBb@aAx@oBp@kBb@sARq@R}@\\_BPy@VuA@GF[F_@Hg@BKX_BVyA@CHg@Jc@Ru@Nc@Vo@N]Pa@JSPc@FMb@aALYJS~@qBHQl@kA`@y@FON]JQjAcCNYb@y@JWnA}BFKx@{AtDmHFKFKP[n@kAZk@FKPa@FSH[PiADc@@M@EFWb@_DPwAN}A@KB]Dc@Fq@Hs@d@yDTqBJq@'
                     },
                     'start_location' : {
                        'lat' : -6.703962799999999,
                        'lng' : 111.3316101
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 282
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 72
                     },
                     'end_location' : {
                        'lat' : -6.7002339,
                        'lng' : 111.4474053
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Jatirogo\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~c{g@ocfgT~AID?jAAN?R@L@NBVFv@NhDp@'
                     },
                     'start_location' : {
                        'lat' : -6.6977603,
                        'lng' : 111.4477578
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 309
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 51
                     },
                     'end_location' : {
                        'lat' : -6.700112,
                        'lng' : 111.4446105
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'ls{g@iafgTAx@C`DChBE|BGjB'
                     },
                     'start_location' : {
                        'lat' : -6.7002339,
                        'lng' : 111.4474053
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 152
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 27
                     },
                     'end_location' : {
                        'lat' : -6.698776199999999,
                        'lng' : 111.4448442
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'tr{g@yoegTk@Ki@Ks@MUEWAiA?G?'
                     },
                     'start_location' : {
                        'lat' : -6.700112,
                        'lng' : 111.4446105
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '40 m',
                        'value' : 40
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 10
                     },
                     'end_location' : {
                        'lat' : -6.6987176,
                        'lng' : 111.4444837
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kanan.\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'jj{g@gqegTE`@CZAH'
                     },
                     'start_location' : {
                        'lat' : -6.698776199999999,
                        'lng' : 111.4448442
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '85,8 km',
                  'value' : 85828
               },
               'duration' : {
                  'text' : '1 jam 17 menit',
                  'value' : 4619
               },
               'end_address' : 'Tuban, Jawa Timur, Indonesia',
               'end_location' : {
                  'lat' : -6.895393899999999,
                  'lng' : 112.029517
               },
               'start_address' : 'Lasem, Karangturi, Lasem, Rembang 59271, Indonesia',
               'start_location' : {
                  'lat' : -6.6987176,
                  'lng' : 111.4444837
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '40 m',
                        'value' : 40
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 6
                     },
                     'end_location' : {
                        'lat' : -6.698776199999999,
                        'lng' : 111.4448442
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etimur\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~i{g@_oegT@IB[Da@'
                     },
                     'start_location' : {
                        'lat' : -6.6987176,
                        'lng' : 111.4444837
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 152
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 25
                     },
                     'end_location' : {
                        'lat' : -6.700112,
                        'lng' : 111.4446105
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Jatirogo\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jj{g@gqegTF?hA?V@TDr@Lh@Jj@J'
                     },
                     'start_location' : {
                        'lat' : -6.698776199999999,
                        'lng' : 111.4448442
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 309
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 35
                     },
                     'end_location' : {
                        'lat' : -6.7002339,
                        'lng' : 111.4474053
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Jatirogo\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'tr{g@yoegTFkBD}BBiBBaD@y@'
                     },
                     'start_location' : {
                        'lat' : -6.700112,
                        'lng' : 111.4446105
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 282
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 52
                     },
                     'end_location' : {
                        'lat' : -6.6977603,
                        'lng' : 111.4477578
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Jatirogo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ls{g@iafgTiDq@w@OWGOCMASAO?kA@E?_BH'
                     },
                     'start_location' : {
                        'lat' : -6.7002339,
                        'lng' : 111.4474053
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '48,7 km',
                        'value' : 48666
                     },
                     'duration' : {
                        'text' : '42 menit',
                        'value' : 2504
                     },
                     'end_location' : {
                        'lat' : -6.787871,
                        'lng' : 111.7915281
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Sunan Bonang/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~c{g@ocfgT@WDwADcCBkBDcC@q@@OAG?ECGCKGEIEMEOA[C_BIe@EuAIWAuAKe@C}AO_AOsAUCAGAuBa@yA[oAYQE}@SIA_@Ik@Mw@QiAWkAWkAWeAUk@M[IcFgAg@Mu@OeCk@iDs@_B]OCm@MQIqAYoDo@{A]UE}OcD{@SoAYiCm@gH_BcEaA}QiEaQsDm@OWGa@IuA[oA[uAa@_EgBoB{@sAo@}@a@y@i@c@c@o@q@cAgA_BgBOOY]_@a@QOOSSQw@{@MQEEk@o@k@q@IKq@u@cAiASQm@m@A?_Aw@c@]UQa@[OMs@q@IGGGiAcAm@k@gAaAOOm@e@ECCCWQMKECUKYMGAKCU?S@MBYFMDQFKDIBWHQBc@H[?c@Aa@Ka@W]Q_@Sk@SOCWEw@K}AIoA@sBJcEXsCT_@@_@?O@e@Ck@GE?c@G[C]CYCeAEsCT}D\\gAH_@BYBYBcADg@A_@EIAOEYIYO]QWOA?kA}@}EqEYYy@w@kAeASQoE_EiAcAEEcAkAMMOQa@i@_@e@CCq@}@EEwByCKMKQuBuCe@q@u@cAs@cAk@w@w@aAuBiCqA_B}AoBeB_C_@g@o@w@g@q@yCwDq@w@IK[a@k@u@i@w@]c@y@gAo@_Ac@k@_@g@MWOYM[Ma@Sk@GWG[G_@K}@AIc@aEs@yGMaAIoAGyB?e@IsDCs@Is@UoA]qBWsA?Ec@yBG]U}@Mi@AEYiACIUkAWmBQwAMqAE_A@uD@iBFsDBi@J{FDw@Fu@@G?EBSNiALiATcA?ELm@Ju@?CPgADW?EAQF[H{@@y@@qBE{B@MEsA?WE{B?a@Cq@AaB?e@Ay@C_A?MAw@IuCA}@?ACm@?AE_CEqBAg@?IG_CEoAIuAMmAUkBCMI}@UwBSaCQqAKm@M{@Q}@EWWkCMaBO{AAQCSGa@EOQu@_@iA]cAQq@COAKAIA[?]@a@@Q@g@Aa@IcAKs@YgBSkAWmAOk@Wq@e@eAMYQm@UaAYyAG]UwAQ{AOgA]_C]cBQy@OoAIwAA}B?aADsA@_ADy@Bc@By@BW?MN}ARkAn@gCFW^sA\\aALWHKRUj@c@TWNUXm@Tu@Ja@BIb@kB`@qA`@uAnB{EZq@Pi@Ng@Jk@@KLeAXaCr@gGNuAXgBRs@L]Tk@JWHON_@JU@A@GFMJ]FYHa@Di@?sB@i@@O@MJw@@CJo@Nu@b@oBd@sBT{@|B{JLk@Lk@BMDUP}@^kAJYJYHUJg@Fa@NmARqCTsBB[DWJ{@Jq@?CFa@RcAXiA@Cl@qBX_ARg@X_AnBgGJ]fBiFhGiRh@aBZgAZw@|AsDvDcHR[hBwCr@iAV_@?Ap@eA`@s@PUfAeBrCsEl@cAf@w@P[h@}@Ze@rB_D\\i@LQ\\e@|BgCTWd@i@|@aA^c@bBiBVUvG_HXW|A}AvAqAtCqCNQl@o@NMdAeARSvC}CjAoA|@aALO\\_@BEd@g@`@c@V[r@y@@Cz@_Af@m@TY^g@V]DEV[Za@HMFGTYRURUh@g@j@m@f@a@h@c@h@]^Wr@c@lAs@XQp@a@LGz@g@BAj@]FCh@[NIzA{@pA{@x@k@v@k@VS|FgEvB_BjA{@f@_@vByA|@m@f@_@p@i@hCmBPKhAw@XUv@m@rAaA^YHIRM`Aq@vC_C`DkCZWPOhB_BFGl@m@|@{@^a@t@s@HIFITUb@a@p@o@v@}@TWh@m@DE`CgCHIVWn@w@j@s@^g@\\c@V[JMPWp@{@h@q@LO`@i@BENSh@s@\\c@z@gAJOX]j@u@NUtAeBlA{AfAsAZa@hAyARWxAkBDEV]TYT[PUDGLOJMd@k@f@m@PS\\c@JQV[\\c@FIDEp@{@JQNOV]FIDIj@w@p@aA\\e@P[Ta@FMFIjAqB@AjAsB`@w@HOXe@Zi@DK\\i@^s@PYx@uAvAcCFKLQZi@PYNUb@q@NYd@s@@Ad@u@tAqB@Cv@gARYPUh@q@FKV[f@q@jAuADCXa@RWRWZ_@?AV[RWNUFIJMt@}@BCDEh@o@JKTWRSJK\\_@LMLMRQZ[FEZ]b@a@PQDGb@c@PWj@u@d@m@h@u@h@s@`@e@TWv@aAPWV[f@o@jA}ABANS\\e@f@o@v@eAv@eAFIX_@FIh@o@DIJOJMlBcCTYbB{BFI`BsBnDkEHI`@e@lAwA`AeALOp@u@\\[b@a@r@w@b@e@hAoATYRS^g@xBsCFIxAgBrBeC|BmCl@s@lBwBnAoA`A_AbAy@tAiAxAmAz@u@vAiAp@i@z@m@JG^WrCsB|@s@|CuBfBsA@ApAkAbAgA`CkClDoDdDgDBCp@m@t@o@tBqBn@u@h@k@h@s@d@u@PYNUN[d@_AXo@zAkD~AiDv@eB^y@r@_B~@{Bf@sAdE_LDK^cAL[Ti@Pe@LYr@qBH_@HWH[\\oABGJa@r@cB\\u@z@qAr@iAX[r@}@X]`@e@dAqANQHK~AgBNOz@eAJKr@w@n@s@XY\\a@l@u@PQ~@gADGvA_Bl@w@d@q@`@m@FGVa@r@eA~@sAn@}@r@eARW`@i@bAoAr@}@j@u@\\c@l@w@j@q@HKj@s@?A~@cATU\\_@@An@o@z@{@Z]PQ^]d@e@v@{@~B{BnAkA\\]|AwADC`@_@h@e@p@o@`@_@l@i@j@k@tAsAHKb@a@HKPQRSV]TYr@aAHMn@cAj@_ANYLSJSBCBE@Aj@_AT_@HORYr@eAZ]FGV[d@a@h@k@`AeA^W`CeB`Ak@z@e@z@m@`BgAj@m@~AcBt@}@`BqBX]`BqCDIXg@v@yA@AVc@Ra@JS@Af@s@BC\\i@LORSh@g@HGh@g@dCyBHMFGHKNWHM\\c@p@o@d@a@|@w@fA_ADEb@c@TWBCj@}@NW\\g@T[r@qADIdAeBJSPWZi@DGl@cAr@oAf@{@bDeFZe@`AyA~@uABCf@w@z@sAt@iAf@u@Ze@jAkBZi@`@q@pCcEhB{Cn@}@~@uArAkBr@cABCr@_AbAsADIp@}@h@y@V[b@m@x@kAj@{@\\m@DGxA{B\\i@Xa@|AgCdAeB^m@LWfDcGj@iAb@cAl@}ABKXu@Rg@Z{@X}@@EVs@Tk@Tg@BEN]FOXi@x@{ATc@BEXe@nAwBT]~AmCz@{Ap@iALUn@gAn@kAXg@BCFKf@}@Va@t@sAJQP]PY^o@h@aAh@kADKn@yAp@{Ar@yAf@iAb@}@fA_CJSp@qAj@mAh@oA^{@Re@Ti@Xq@Tg@hBmE\\y@FMVs@^sALe@FQBGNq@BGT{@VaAJc@Ni@XmAhA_Ep@wBBGJa@TaAHU~CyKNo@J]@GNi@T{@R}@D]^sB@GN}@R_Bb@sFXsCB]@KDc@Fo@@Kd@}EH}@j@qH@SNkC@y@HsDHcE?O?c@@eADyD@qA@cB?iF@w@BgAFu@Fy@@ULoAV{BTgCDe@FeABc@@cAAk@G{A?IG{@QeCUmCe@yEM{AG_AE_B?QBm@H{@r@uGF_@P_AFi@Hi@P_ANg@d@mA~@mBJU`@{@Tg@Xs@f@sAPk@Nm@P}@X}AVyAXuANy@Ru@Pm@Tk@Rg@Ve@`@u@lByCx@qAFIVc@`@m@p@iAf@_Ad@gAl@iBhAgEZiAf@sB\\qAR{@r@kC@EH[d@gBLw@Jm@\\{AV{A?EFa@Fo@Fq@Da@Fq@?ODy@@WAoAAy@AQ?MCmA@kA?_@?UDiBB[@M?GLeBBQFm@BUJs@Fo@VsBd@eCLm@F]DORaALo@b@sBl@oD@Il@qCBMF]`A_DBI@G^kAJ]L[Vs@Nq@Ts@@G@EH]DYFa@RgAPcBPuABW@C@GF_AHw@H_AB[Do@F{@JyABc@BUBY@WBQDm@@WBY@]PsAHq@BYHe@Ho@XsBDW@KVyAHc@FWJ_@BMFWX}@Vu@X{@N_@HYt@sBDMNa@^cADKZ{@L_@Pe@xJ}X~A}Ev@{B`@iAj@cB'
                     },
                     'start_location' : {
                        'lat' : -6.6977603,
                        'lng' : 111.4477578
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,3 km',
                        'value' : 4263
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 213
                     },
                     'end_location' : {
                        'lat' : -6.801047199999999,
                        'lng' : 111.8276541
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Semarang\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dwlh@ahiiTFQ`AmC\\cAPg@r@qB`KyXlDaKpBiGvAkEjBkGtFyQtBkHdAkDd@}AZ}@b@wANm@vAcFHYVy@\\iAz@sCV_At@mCr@oCr@gDRcAf@gCNs@ZaBTyAN}@|@sGl@uEReAPiA@GpC_PBI?CPg@DIJUHWFQFU@ENaAF_@BW@O?I?S?Q@Q@OFa@BKd@yCNw@Lo@ZgB'
                     },
                     'start_location' : {
                        'lat' : -6.787871,
                        'lng' : 111.7915281
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,1 km',
                        'value' : 1128
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 56
                     },
                     'end_location' : {
                        'lat' : -6.802630300000001,
                        'lng' : 111.8377343
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Merkawang\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pioh@yipiTdAaG@UHm@f@qFd@uEJqAJoA?AJsA@M@IF}@JgBBYDk@Fm@B_@TmCBs@PgDB[FoADk@@YBg@DcA'
                     },
                     'start_location' : {
                        'lat' : -6.801047199999999,
                        'lng' : 111.8276541
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,2 km',
                        'value' : 1208
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 60
                     },
                     'end_location' : {
                        'lat' : -6.803098299999999,
                        'lng' : 111.8485981
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Tambakboyo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'lsoh@yhriT@m@FaB@YBw@@CFkABu@FaA@EDm@L_AHg@?GFYP}A@KFs@LcB?O?A@Y@Q@cA@]@e@@cADcB?UBoA@s@@mA@oA?}B@cB?o@MkBGm@OyAQgB'
                     },
                     'start_location' : {
                        'lat' : -6.802630300000001,
                        'lng' : 111.8377343
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 919
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 46
                     },
                     'end_location' : {
                        'lat' : -6.8018797,
                        'lng' : 111.8568319
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Merkawang\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jvoh@wltiTi@yFUcCa@yDK{@C]AKGw@UsCAQKcBIwA_@{FG_AEa@K}AOqB?G'
                     },
                     'start_location' : {
                        'lat' : -6.803098299999999,
                        'lng' : 111.8485981
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,7 km',
                        'value' : 4694
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 235
                     },
                     'end_location' : {
                        'lat' : -6.7902686,
                        'lng' : 111.8975264
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Socorejo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'vnoh@e`viTYyDg@oGIeAQsCIeAKsAIw@C_@Eo@Ek@Ea@Q_BGaAQuCI_AAK[uD?Cc@aGYyDIaAg@kFsAiH{AyGiA{EiAyEoAkFwAaG}BcKEMy@mDe@qBgBsHg@qBgBwHwByIEQeBkHm@cCCKcA}DoAcFu@gCAEo@_CU{@[kA?Ac@wAAGUw@e@cBq@{BY{@[iACImBqGaAwDo@cF'
                     },
                     'start_location' : {
                        'lat' : -6.8018797,
                        'lng' : 111.8568319
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 204
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 10
                     },
                     'end_location' : {
                        'lat' : -6.7898198,
                        'lng' : 111.8993216
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Glondonggede\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dfmh@q~}iTMw@e@iDe@cC'
                     },
                     'start_location' : {
                        'lat' : -6.7902686,
                        'lng' : 111.8975264
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '12,6 km',
                        'value' : 12588
                     },
                     'duration' : {
                        'text' : '11 menit',
                        'value' : 630
                     },
                     'end_location' : {
                        'lat' : -6.8299239,
                        'lng' : 111.9963595
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Jenu\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jcmh@wi~iTqAgGc@qBeAqEoAuFwAgGiB{Hk@qBK[Qq@{AuE{AoEs@wBwAeEkDiKsA{DAGq@qBIUo@sBy@mCQm@Ms@Ae@Bm@DYLk@r@_BrAkC`AoBv@}AlEcIR_@r@mAf@}@Zk@JONYVe@tAaCJQNWn@iA^q@Zg@hAmB?ANWNS`AaBt@wADIHMZi@p@iAXc@bAaB|@cAv@g@t@g@|CkBxFiDrBmA`CuA^UpC}ARKrCwAnCyAlAo@xAw@hAk@vBiAfDiBb@W~FaD~CqBd@_@HGVQd@k@BCRY^m@NYh@}@nAyBb@w@dAgBHMJS|@cBDIbAgBz@_BBCLWh@aARa@d@y@h@gAZk@Xk@\\q@l@iAnAwBp@gAv@{@dCuBtAkAzBiBj@c@nE{Cl@a@PQjB{AdAuAh@w@b@}@r@qAf@aAJUxAyCv@qBvAqE|@{Ed@iCF[DQ@A?ARI@A@CDQfAuF^_Bp@uBL]FSXw@`@gA`@iA\\_Ab@qA\\mA^mA\\qAZkAh@wAn@{At@aBv@aBj@aAf@cAd@aAhBgEz@sBn@{AlAyClA}ClBmEfAsCn@wAj@qADSZ_AJW^}@bAqDbAkEFo@d@uCN_AFc@b@kC\\yBRuAJo@BONiATyAr@uEBSPiA@I`@kC^}BXeBFc@RiAPcAPaAPcADYp@{C@CZ_BF[?Cr@qCr@cDh@cCFYXqANu@r@gDl@qCFYb@}B^kB@Ch@qCv@gDx@iDFY\\uAb@gBNu@H[Rs@L_@H]p@cC@EJ_@Po@r@gCBGr@gC@Gd@_BBMHW\\kARu@f@eBBERy@'
                     },
                     'start_location' : {
                        'lat' : -6.7898198,
                        'lng' : 111.8993216
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,2 km',
                        'value' : 8188
                     },
                     'duration' : {
                        'text' : '7 menit',
                        'value' : 411
                     },
                     'end_location' : {
                        'lat' : -6.881921999999999,
                        'lng' : 112.046898
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Tuban/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : '~}th@ghqjTp@_Cr@eCt@mC@Cr@cCBITy@l@wB\\gAPu@FS`@wAV_ALg@FSt@iCLc@\\mAVeAn@yBb@{Az@wCJ_@d@iBx@qCPo@J_@J_@HQLSNW\\[bAu@j@c@r@g@rCqB`BeADE`BiAl@c@BA|CyBVOhAy@l@c@`@YzAiAZQ~@o@zB}Ap@i@`BkANIn@c@d@[HG|AgAf@_@vA}@j@_@lDcC|CuBlAgAPQx@m@vCiBnCqBjA}@NK`Ay@hJmGhCkBrBqArB}A`CiBjD}BhGuErAaAhGoEVSvEkDtAeANKl@_@@AxCwBlDeC`Au@nCmBZS`DcCjHqFn@g@lCmBf@a@nEmDnCqBh@a@vAgALKxCuB@Al@g@xAiAb@[tOuMxF}EzIsHpBaBzBmBpEyDzBmBfCyBxAqABAbB{ALMNQ|@_AZ_@DEHM`BiBzCsDRW|@gAt@w@nAwAXYTWJO'
                     },
                     'start_location' : {
                        'lat' : -6.8299239,
                        'lng' : 111.9963595
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,3 km',
                        'value' : 1315
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 124
                     },
                     'end_location' : {
                        'lat' : -6.891871,
                        'lng' : 112.0404593
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Teuku Umar 17/Jl. Tuban - Gresik\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~b_i@cd{jTHFJFdFxC`@T@@`@TlAp@^TpAt@t@`@vAv@~D|B`B~@~A|@pAt@VLl@\\zBlAhBdAVN@@`Aj@pAr@xC`BHD@@RLrBhAr@^HBZL'
                     },
                     'start_location' : {
                        'lat' : -6.881921999999999,
                        'lng' : 112.046898
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,0 km',
                        'value' : 1003
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 132
                     },
                     'end_location' : {
                        'lat' : -6.8881513,
                        'lng' : 112.0324624
                     },
                     'html_instructions' : 'Di bundaran, ambil jalan keluar \u003cb\u003eke-2\u003c/b\u003e menuju \u003cb\u003eJl. Letda Sucipto\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'daai@{{yjT?A@??A@??A@?@??A@?@?@?@??@@?@??@@??@?@@??@?@?@?@?@A??@?@A?A??@A?A??@A?A?A??A[tAKb@Ql@@B?@?@?BABwDfKe@pAAFO^w@rBQf@a@pAqAdDq@zACHw@~A_ChFYp@'
                     },
                     'start_location' : {
                        'lat' : -6.891871,
                        'lng' : 112.0404593
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 869
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 80
                     },
                     'end_location' : {
                        'lat' : -6.895393899999999,
                        'lng' : 112.029517
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Kedondong\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kiri.\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|i`i@{ixjTtA`@HBh@NvAb@|@XjCt@`[pJxBn@'
                     },
                     'start_location' : {
                        'lat' : -6.8881513,
                        'lng' : 112.0324624
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '105 km',
                  'value' : 105440
               },
               'duration' : {
                  'text' : '1 jam 35 menit',
                  'value' : 5687
               },
               'end_address' : 'Banyuwangi, Jawa Timur, Indonesia',
               'end_location' : {
                  'lat' : -8.142855,
                  'lng' : 114.400198
               },
               'start_address' : 'Tuban, Jawa Timur, Indonesia',
               'start_location' : {
                  'lat' : -6.895393899999999,
                  'lng' : 112.029517
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 246
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 20
                     },
                     'end_location' : {
                        'lat' : -6.897451999999999,
                        'lng' : 112.0287052
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003eselatan\u003c/b\u003e di \u003cb\u003eJl. Kedondong\u003c/b\u003e menuju \u003cb\u003eJl. Alfalah\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dwai@owwjT`Cr@jFzAl@P'
                     },
                     'start_location' : {
                        'lat' : -6.895393899999999,
                        'lng' : 112.029517
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,3 km',
                        'value' : 1324
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 126
                     },
                     'end_location' : {
                        'lat' : -6.8965366,
                        'lng' : 112.0400428
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Alfalah\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`dbi@mrwjTj@cG`AaMPuBJwAd@eFBOf@cGFo@?I?I?GAMAIAGCEGUGQMa@Uq@aAcCISSg@CGm@}AkAwCKUQc@OUOQOQWUYU'
                     },
                     'start_location' : {
                        'lat' : -6.897451999999999,
                        'lng' : 112.0287052
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,9 km',
                        'value' : 1863
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 159
                     },
                     'end_location' : {
                        'lat' : -6.881921999999999,
                        'lng' : 112.046898
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Dr. Wahidin Sudiro Husodo/Jl. Tuban - Gresik\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Tuban - Gresik\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan melalui 1 bundaran\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'j~ai@gyyjT_AZSHc@Nc@Hq@J{@De@@c@AEAi@EWC]EwBa@C?_AQUEiBYyA[_AY?@?@A?A??@A?A??@A?A?A??AA?A??AA??AAA?A?A?A?A?A[MICs@_@sBiASMAAIEyCaBqAs@aAk@AAWOiBeA{BmAm@]WMqAu@_B}@aB_A_E}BwAw@u@a@qAu@_@UmAq@a@UAAa@UeFyCKGIG'
                     },
                     'start_location' : {
                        'lat' : -6.8965366,
                        'lng' : 112.0400428
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 672
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 92
                     },
                     'end_location' : {
                        'lat' : -6.8859097,
                        'lng' : 112.051467
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Tuban - Gresik\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~b_i@cd{jTz@eA~@qA\\_@lGqH`DuDhAsAfBuB`@g@'
                     },
                     'start_location' : {
                        'lat' : -6.881921999999999,
                        'lng' : 112.046898
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,4 km',
                        'value' : 3379
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 170
                     },
                     'end_location' : {
                        'lat' : -6.8969169,
                        'lng' : 112.0793334
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Panglima Sudirman\u003c/b\u003e',
                     'polyline' : {
                        'points' : '|{_i@u`|jTpDgEjDaEnCeF@A`CwEj@gAl@kANW^w@~@kBxAwCzBgERa@dAsBJSN]h@sAN[P_@@Gf@uATq@^eArA_EL]Na@Xy@Ri@dBmEl@{AV}@p@wBBKDQHo@b@oD@MDQn@{C@K`AoEXsABOVkBV}A@G@Ef@iCt@{DLo@ZyA?AF_BDeBFuB@o@?UH_D?EBq@FmCLkBDuADq@@W@a@@Q@WBu@D}@'
                     },
                     'start_location' : {
                        'lat' : -6.8859097,
                        'lng' : 112.051467
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,9 km',
                        'value' : 1856
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 146
                     },
                     'end_location' : {
                        'lat' : -6.91301,
                        'lng' : 112.0821744
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Manunggal\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'v`bi@ynakTJKFIJKNKLGNIr@Mn@Cp@AF?B?R?bBHZBjE\\x@FH@rAHT@B?`A?bAGbAINCPA`@I`Ci@p@QjCi@f@KPCpCs@FAdAU^K`Dw@lAY|Bi@xCu@lBg@~DgAFA`@KXGHAHCLAj@ChBAL?jA?vD?pABB?f@?VBl@F'
                     },
                     'start_location' : {
                        'lat' : -6.8969169,
                        'lng' : 112.0793334
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '58 m',
                        'value' : 58
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 3
                     },
                     'end_location' : {
                        'lat' : -6.9135252,
                        'lng' : 112.0821464
                     },
                     'html_instructions' : 'Terus \u003cb\u003ekiri\u003c/b\u003e supaya tetap di \u003cb\u003eJl. Manunggal\u003c/b\u003e',
                     'maneuver' : 'keep-left',
                     'polyline' : {
                        'points' : 'heei@q`bkTf@AN?R?D?D?D@HB'
                     },
                     'start_location' : {
                        'lat' : -6.91301,
                        'lng' : 112.0821744
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,8 km',
                        'value' : 1833
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 111
                     },
                     'end_location' : {
                        'lat' : -6.9253678,
                        'lng' : 112.0925725
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Wr. Supratman\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'phei@m`bkTl@iANYNYlBoDnBuDbAkB`@s@Zk@FKhAkBFKXg@Ta@\\q@d@{@f@aA@Cf@aAtBuD^o@d@y@Vi@b@[XOXQx@[dAa@NGb@QJG@?r@Ov@UTG`Cu@hDcAn@S|@UXIlA_@x@WnC{@LE`Cq@FAbBg@d@ORE'
                     },
                     'start_location' : {
                        'lat' : -6.9135252,
                        'lng' : 112.0821464
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '70,7 km',
                        'value' : 70653
                     },
                     'duration' : {
                        'text' : '1 jam 0 menit',
                        'value' : 3621
                     },
                     'end_location' : {
                        'lat' : -7.168258900000001,
                        'lng' : 112.5944844
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Tunah-Tuban/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan melalui 1 bundaran\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'prgi@qadkTfBa@`AUfCo@j@Oz@UNEz@UfBg@t@S`D}@h@Oz@U~@U|@Yp@Wz@_@|A_Al@]l@]r@a@^Uj@[v@c@DCf@[j@]p@_@d@[PKNKb@YPMZQTM^YDCXOd@[d@U@AXO`@Q\\MHCf@Qh@OHANENEB?z@SpA[fAUtE}@hCi@p@OXGjE{@tBa@|A]NCnB_@bDe@n@KRE~C]ZC\\E^CdBOZCdBOf@Gz@Il@IjAMNAjCS^C^EB?\\CxAEj@CJ?h@Cl@AfBAb@AH?t@?^?tAArH@rA@bB?~BAv@A|@CxGMRAbBAdACZ?^?`@AhAAnCC|@AbA?b@A~HIfCCtBAxIKR?|AEhBMdAI~@Ib@ILA^GnB_@dB]x@OxDaAFCpCaAlBw@dHgD`FgCXO|D}B\\WZUd@e@\\]Xa@Xe@b@u@nAmC\\u@\\q@Tc@l@}@bAoAZ]fCoCl@o@`@[tC}BfDsCzCkCTSdByAjBaBXW`Ay@DEVQ^YDCx@g@t@e@f@]ZQdC{AnBqATQpBwA^YLK^Wd@[PKh@YlAe@jBu@lAg@JEl@Wj@U~@a@pAk@DCjAi@d@U`@SbAk@`BeALKd@YzDeCh@_@j@_@NKbBiAhCkBlAeAfAeAx@w@@Cv@u@f@g@h@g@nBiBh@g@d@c@lAmAjCcCv@u@lAkAlBiBj@k@zDuDt@s@zOkO|HuHtKaKhI{HJITUDE`@a@tCqCRQd@c@~CwCd@e@dBaB`A_AXYtAqAVU^]vEoEj@k@jAgAhCcCpAmA|BwBNM|@{@fCaCRUj@i@VU\\]^[^Y^UVMZM^Kd@Mb@Mh@Md@Kn@G`BOdBKlBMfDQxCOfDOLA@?lAGlBKbAGzAGbBK@?nAG`BI~@Ep@ChAGhBE~ACf@Ab@?\\?pAA`@Ar@AP?V?r@Ah@A`BAtAAnBCB?z@AxAAHA@?dA?x@AlAAbJI`@AL?zCE^C`@A\\EXAd@CB?B?fBM|BQlAIbF]RAzCUdEWjAIrASv@Yl@Wt@[|@_@`Ac@`Aa@lAi@`A_@h@UpB{@j@]VSd@e@TYNSr@_Af@q@nA}AnA_BfAuAjAyAz@iAhAsAbA_Av@c@`Ai@fAk@pBgAhB}@JGjAi@@AfAe@l@WXOLE\\OxAo@FCJEn@Y`Ac@JGRIl@WrAm@BAfCiAvD_BbCcAnDyA~BaAFCt@[TKjBw@fEgB|Aq@BALGvAg@z@Wr@OPEp@MlAQ\\Cl@EZCv@Cx@CvAA|A@bA?^?lABb@?f@@lA@j@@p@Bf@@F?pADnBDz@?TC\\ELCREVGLEv@[d@WtCsBjDaCtEeDjGqElPqL|EkD`GiEzAeA`C_BtAs@fAk@z@c@`Ae@vRuJpFiC@ADABAx@a@@AzAw@PODEFIHOHG^WPIVMTM|@c@f@S@?@??A@?RGj@Q\\Iv@On@M@?LC@?n@Kd@IXEhAO@?n@I^E@AdBSfBUxC_@b@Eb@Gp@I|BYrDe@d@GpBWvASfCYnCa@hBYFKpAWbBYh@G~Ba@JAFC@?FC\\GxDw@f@Ix@QhASDAFABAJCbCa@LCZGTGNGRQLSLe@?ADe@A[COAGEKGOKMKKWSc@[MKMIIGKGUOEAQOoB{AIIQSMSACISC]AIAKBkBBg@FcCDaBDoADwBDoA?INeFDeCJeF@I?CHuCDoAFuBLoG@s@Bu@HkCJsE?]?EB}@FwADuA@oAFcB@s@DkA`A{]PwF@u@Aw@EkAEiAAe@?_@@U@SB]@OLgAJ_AFqAFcAD}AHwC^_Nv@eYLcD@YH{CNuE@CLcD?O@a@@e@B}@?ODcBBiA@sABkB@_B@aB@eA?_B?wAAmBEeB?CE}AG_BAUIcBI{AEs@Cm@KmBA[KgBA_@KuBWwEQyDQoEKoCQ_DMgCOoCQsCQgDScDSuDQaDOcCSkDU_ECYOeCAUIcAE_AMqBI_BIaBCq@Eo@YiGAC[cHAc@EaAGeAIgCMaBQoDAWACAUEgAOmDIuAASIsACa@IoBIcB[gGEeAa@kJEq@]}HQeEAc@M{C?EG{AG{AEyACaAS}FIw@WsBm@yCCMM}@Cc@?c@?u@@WD}@DcAFu@Dq@@m@@_@?_@A[Ac@IkB?I[gIy@uRgCyq@_B{a@WwGIuBGoACe@i@qNgAcYGyACc@Cq@Cu@MiDKqCG{AEy@AMEcAA]MeASiAYeBOoAIu@Gu@?YAY@U@cA?]?_@@cBBwC@q@Ay@?a@?[AE?CAu@EuAGsBAw@CeAAg@EgCGsCC}BEuDE_CAy@IiBAw@O}HQ{JEgCCgAE_CGiCCiBIkDAk@FKC_@IoECo@Ac@@[C{AE_AE}A?WEuAEqAE}@?MC}AA[AQCe@Ae@?k@?q@@q@@{@@G?IHyAFuAHeAFs@PiBDi@Fq@Dc@JiAHaAJkADk@Hu@Fo@TeCXiCRwBDe@@KP{AJgAH}@D[@KJ{@BULkA?Cb@kDZqC?Gp@gGNoA@KLeADe@NiAVqBD_@P{Al@yE@In@sELcAFg@LaAVsB?EPoADc@VkBPwALeAb@_Dh@cEFa@PwA^iDPwATeBDSDa@TcBFg@?ABUVwBn@}ELeAHk@PyAb@mDNiAFi@^yCZaCz@cHZ_C?ALoA@K@IDa@Fi@CIFk@Fq@^_Dp@cF@QR{Az@mHVsBHo@V{BNmATaBHs@Hq@Fc@R}A\\aC?Aj@iEBUPmAh@qETiBP}AR_BD[ZqC^uCL_ADYPwAT_Bb@iDz@_H`@gDxAkLJu@fAsIfAyIToBJq@LcA\\uC\\sCR_B`@}CTiBNqAPyAJu@ZmCXsBRcBN_BPyAP{ABGHo@DURcB~@}GbBgMZkCReBTcB~@yHRaBHq@TkBRsAXwB\\qCHy@LaA@CLgAD]R}AVuBd@cEHo@\\_DJo@BQFm@LYHi@@KPqAPoAP}A?CDU~@oHh@mEDUJ}@Fc@NuANkABSv@uGLgARcBNoAXgC@A?CBO@K@ERgANsAAA?AA??A?AA??A?A?A?A@A?A?A@??A@??A@?^qBP{Aj@mFp@uFZmCr@}FJ}@Da@Hk@vA{L?Eb@mDFi@Dc@DQJaAHq@NeAVyBl@sE@OFa@RcBHo@?CPuABUZyB@I@OTaB\\_C@Gx@}GFa@Jq@~@oHb@_EFa@Fc@F]J}@XyB|@oIJo@PqAlAgKD_@^}CLgAD[D[X_CD[D[Fe@j@qEHu@v@yGz@}Hh@_F@ALmAXwB~@{Hx@sG~@yHd@yDEY@]`B{Mp@aGx@oH^cD^qCbA}It@_GHw@PwAFg@Dc@BMBQFa@Jo@DQBGBI@C@E@CBGFKLUR[PYPSTYNQd@o@Z_@`@g@x@aAlAyAv@_A`BmBvAaBrA{AX[`AcAr@y@v@aALQr@_AFIHOPWNYFK`CaEdCiExAgCjBgDnC{EzB{D@CrAcCHODI|AoC~@aB`@u@~BcEpBoDtAeChBeD?AjA{BnCwFj@oAf@gAlAeCnAoCv@}AVk@^u@p@wAHOtAmC?AbAuBFOjBsD|B}ExCkGp@wAj@cBJ_@F]Lk@Jk@Nk@Pg@L]L]JYJQJQJS@?JSPWPUf@o@dAiArBkCdCeFLWx@gB\\s@dBuDnByDvD_IvAyCJQhBuDb@_Az@gBLU^w@tAuCt@{A@AZo@`@{@BE@Ej@kABEf@iAd@aAtAsCx@kBLY@CLWfBaERg@bA_C@Ej@qATi@@CXq@zB_F@A@C@C@CbAeCf@iA@Az@mBbAuBPe@@AnBkEnAoCf@gAlGwNtFmM@A`@_An@{ARe@BE@Ch@oA~@uBBE@C@Cz@kBN[@EBC\\w@t@aBBC@C@C^}@h@mA\\w@\\}@\\y@\\y@^u@f@oA@E^y@f@eA\\u@?A@A\\u@`@_A@EfA_Cx@oBPi@Hu@Be@FaAJ}ADeARqC?KPeCJaBBe@RmEDkAHkADq@Hy@RuB?CJmBXeEVkDRqCPuBN_CHcAJqAJaB@CHsA?AL}AJ_BBg@Fk@De@Bk@XyDDs@?CBYDs@D}@HsAHaABi@`Cq`@FcABi@Fq@NiCFcADg@DcAB]BUF[@CLcAFw@BUFYb@yAFODI\\u@b@y@n@oAx@{At@{Af@_AvAuCLSl@mARa@l@kAd@y@BGLWVg@Xk@j@kAt@sAj@cAt@wAr@wAd@cADMBG@O@[A[q@eFe@iDYsBa@qCQiAc@yCU}A]_Co@{Du@aFGe@Cc@C]?CEuAE}@E{B?ACaAA]MaF?EAa@Gi@Am@IyCASGcAAKAeAAgAAYEQ[{G?MEo@EaACo@EcAKiBCu@GwAAQEw@ASASCq@Aa@Ce@Ck@Gw@Eq@G}@IoACc@Em@AEEo@Eo@GgAImAOeB'
                     },
                     'start_location' : {
                        'lat' : -6.9253678,
                        'lng' : 112.0925725
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,2 km',
                        'value' : 1198
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 75
                     },
                     'end_location' : {
                        'lat' : -7.161529,
                        'lng' : 112.599371
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Tol Surabaya - Gresik\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'r`wj@obfnTUc@GKGIGKGEIEIGKGGCKEKCMAa@G{DVIBsDxBODSD]DcAH[@Y@}A@Q@WAe@ESGUE_@O[QYWW[Sc@Sk@_@cBYoACIOs@_@kBg@iCo@cEKg@YyAKg@'
                     },
                     'start_location' : {
                        'lat' : -7.168258900000001,
                        'lng' : 112.5944844
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '18,9 km',
                        'value' : 18946
                     },
                     'duration' : {
                        'text' : '14 menit',
                        'value' : 847
                     },
                     'end_location' : {
                        'lat' : -7.2453201,
                        'lng' : 112.7301312
                     },
                     'html_instructions' : 'Tetap di \u003cb\u003ekanan\u003c/b\u003e di pertigaan dan bergabung ke \u003cb\u003eJl. Tol Surabaya - Gresik\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol sebagian\u003c/div\u003e',
                     'maneuver' : 'fork-right',
                     'polyline' : {
                        'points' : 'pvuj@aagnT_B_JCIAMCKAKGYI]K[CMEICGCECECEEECEECCCECGEGCGCIAEAG?GAE?I@G?G@G@GBGBGBGBGDEFEDEFEFCFCHAFAHAJ?H@H?F@FBF@DDJFHDHHFDBDDDBFBHBD@B@F?D@J?LAL?D?B?F?zA[FCFADAnCm@z@QpAWv@O|@SfAUnD_AnDeAxDkAzCeAVITIJCHEtAe@lCcAlBs@nAi@dBs@zAq@rB_AnAo@p@[xDqB`E}Bb@KrD{BvA_ApBmAhBoA|AeAzBgBdBqAfA}@`BsAl@g@`CwBbB_BjCkCh@g@xDgEzDkEzAcBb@c@rA{Av@y@tA_Bj@k@n@u@vA}AfDwDjBsBbAgAv@{@t@y@n@u@h@m@@?RUt@{@x@_Aj@o@~@eATU~@eAxCaDlCuCnDyDd@g@@?hBiBfDeDnDiDrCkCn@o@t@q@JIz@y@?Ap@m@~DqDzCqClC_CvBoBjC{B|BqBbCqB`CoBxAmAdCsB|D_DfDkCbCmBbCkBhBwAvL}IrF}DTWpAs@jDgC~CwBtCmBd@[BABA@CBABA@ABCdBeAxE_D|CoBDCzAcAtD_CvCeBLIrD}Bx@g@`Aq@lAq@z@i@|CkBvCiBnDeCXSXQBCdBoAbEgDdB_BlBiBz@{@p@u@tA{AdAqApBgCbAsA`DaFxAkCtC{FrCwG|BkGbQwh@z@iCr@_CjAqDnAyDdAgDfBoF|@oCx@gCvAqExDcMb@kAb@}A`AuDZiAT{@R{@T}@Ru@Ty@Pq@@CJc@@GFSHa@Lc@HY@EH]Li@DU`@mBBQ@CDUjAsFr@qD`BkIt@kEt@cE^aCLcA`@iCT}A@Ij@}FBKBOVuBb@{D`@kDZsDZyCTkCJcALoARgCX{C\\yDJmDEaCOkBOiAKq@YcAuA}E_AiDSw@UcAWeBKkACy@?[DwAH{@Jq@^iBd@kB?AR{@R}@JWHYBMBK@C?CBK?A@ADY@ALm@Ps@dBeHfAwENk@DUFWHk@Dc@Fy@ASAY?]?C@{B@}AD{C@q@?u@@o@?[@uA@qA?oA@sA@mABcB?]?_B@mA?EDqDB_@?G?IBmDBaCB}B?EAaC?CCoAA]Cw@Is@Ee@CQCq@Ew@Au@?A@o@Bo@BaA?I\\gCJc@N}@'
                     },
                     'start_location' : {
                        'lat' : -7.161529,
                        'lng' : 112.599371
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 204
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 10
                     },
                     'end_location' : {
                        'lat' : -7.245599899999999,
                        'lng' : 112.7319533
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eDupak Raya\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'fbfk@ir`oT\\aC@E?AD_@BOH_CBq@'
                     },
                     'start_location' : {
                        'lat' : -7.2453201,
                        'lng' : 112.7301312
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 763
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 83
                     },
                     'end_location' : {
                        'lat' : -7.2471804,
                        'lng' : 112.7386359
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eTembaan\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~cfk@u}`oTB_@@W@]D[H[DM?CpAaEDUHQDIDKXy@Ha@Fa@D_@@IPaBNyAHk@Dc@D]F_@JmABo@BSDq@Di@Dg@Dc@Da@?AD]Bk@'
                     },
                     'start_location' : {
                        'lat' : -7.245599899999999,
                        'lng' : 112.7319533
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 645
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 103
                     },
                     'end_location' : {
                        'lat' : -7.2525147,
                        'lng' : 112.7368147
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Pahlawan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zmfk@ogboTb@Bb@HbB\\HB`@H@@b@PfAd@pAn@h@XZNxAp@b@Rz@j@TNr@Vp@Rl@BR@R?P?XCJ?VCnBK'
                     },
                     'start_location' : {
                        'lat' : -7.2471804,
                        'lng' : 112.7386359
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 372
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 22
                     },
                     'end_location' : {
                        'lat' : -7.2558428,
                        'lng' : 112.7369906
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Gemblongan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dogk@a|aoTbCFzCDj@ADAz@CP?p@E@ATAr@GRATEPAh@GTE'
                     },
                     'start_location' : {
                        'lat' : -7.2525147,
                        'lng' : 112.7368147
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 819
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 60
                     },
                     'end_location' : {
                        'lat' : -7.262259299999999,
                        'lng' : 112.7406352
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eTunjungan\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~chk@e}aoTz@a@|@_@jBw@ZMHEnAi@bBu@RIvAs@TKlAe@x@e@^UBCLIHCr@[pBcAJGVMp@]hAi@JGTIxAw@^SZQ'
                     },
                     'start_location' : {
                        'lat' : -7.2558428,
                        'lng' : 112.7369906
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 587
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 33
                     },
                     'end_location' : {
                        'lat' : -7.2643799,
                        'lng' : 112.7454409
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Gubernur Suryo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'blik@_tboTjBkBh@_BD[VqAVy@XeA^wATy@jCsJ'
                     },
                     'start_location' : {
                        'lat' : -7.262259299999999,
                        'lng' : 112.7406352
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '22 m',
                        'value' : 22
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 6
                     },
                     'end_location' : {
                        'lat' : -8.142855,
                        'lng' : 114.400198
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kiri.\u003c/div\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'jyik@_rcoTAOAICGAC'
                     },
                     'start_location' : {
                        'lat' : -7.2643799,
                        'lng' : 112.7454409
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '102 km',
                  'value' : 102103
               },
               'duration' : {
                  'text' : '1 jam 31 menit',
                  'value' : 5465
               },
               'end_address' : 'Probolinggo, Kota Probolinggo, Jawa Timur, Indonesia',
               'end_location' : {
                  'lat' : -7.749945200000001,
                  'lng' : 113.2166759
               },
               'start_address' : 'Banyuwangi, Jawa Timur, Indonesia',
               'start_location' : {
                  'lat' : -8.142855,
                  'lng' : 114.400198
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '6 m',
                        'value' : 6
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 0
                     },
                     'end_location' : {
                        'lat' : -7.264307,
                        'lng' : 112.7456797
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etimur laut\u003c/b\u003e menuju \u003cb\u003eJl. Yos Sudarso\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`yik@escoTCI'
                     },
                     'start_location' : {
                        'lat' : -8.142855,
                        'lng' : 114.400198
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 243
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -7.2621929,
                        'lng' : 112.7462509
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Yos Sudarso\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|xik@oscoTkF}@kB[oAW'
                     },
                     'start_location' : {
                        'lat' : -7.264307,
                        'lng' : 112.7456797
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 244
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 44
                     },
                     'end_location' : {
                        'lat' : -7.261506299999999,
                        'lng' : 112.7483078
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eKetabang Kali\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'tkik@awcoTGEOMo@gBK]Oi@E_@Ec@Gs@O_B'
                     },
                     'start_location' : {
                        'lat' : -7.2621929,
                        'lng' : 112.7462509
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '46 m',
                        'value' : 46
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 4
                     },
                     'end_location' : {
                        'lat' : -7.2616857,
                        'lng' : 112.7486487
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eGubeng Pojok\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'lgik@}cdoTB]@KBGBETK'
                     },
                     'start_location' : {
                        'lat' : -7.261506299999999,
                        'lng' : 112.7483078
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 408
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 45
                     },
                     'end_location' : {
                        'lat' : -7.2652532,
                        'lng' : 112.747822
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Boulevard\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'phik@afdoTnATLB`ALh@?~@N|@NpBXlGbA'
                     },
                     'start_location' : {
                        'lat' : -7.2616857,
                        'lng' : 112.7486487
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 243
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 55
                     },
                     'end_location' : {
                        'lat' : -7.2644817,
                        'lng' : 112.7457636
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003ePemuda\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'x~ik@{`doTCNyAbF{@fD'
                     },
                     'start_location' : {
                        'lat' : -7.2652532,
                        'lng' : 112.747822
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 119
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -7.2653916,
                        'lng' : 112.7453111
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1 ke \u003cb\u003eJenderal Sudirman\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~yik@_tcoT@H@DBFBDDDfCj@ZH'
                     },
                     'start_location' : {
                        'lat' : -7.2644817,
                        'lng' : 112.7457636
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 923
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 50
                     },
                     'end_location' : {
                        'lat' : -7.273111399999999,
                        'lng' : 112.7423784
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJenderal Sudirman\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 't_jk@eqcoTFCNDx@XrD~@XL`AVVFJDh@F^@H?L@p@b@JFVFFBVHd@NXHRDrF~A@?JJnA`@nA^|A`@lAXF@~F~A'
                     },
                     'start_location' : {
                        'lat' : -7.2653916,
                        'lng' : 112.7453111
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 489
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -7.277374999999999,
                        'lng' : 112.7413445
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Urip Sumoharjo\u003c/b\u003e',
                     'polyline' : {
                        'points' : '|okk@{~boT^LrAX`B^t@Pj@JRDvARl@Fr@J|@J^Dr@Fx@Ht@HB?fAL'
                     },
                     'start_location' : {
                        'lat' : -7.273111399999999,
                        'lng' : 112.7423784
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,5 km',
                        'value' : 2519
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 176
                     },
                     'end_location' : {
                        'lat' : -7.2990292,
                        'lng' : 112.7376848
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Darmo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pjlk@kxboTjMpAxCZtCZZDPB|Db@z@HjGn@D@d@DdALH@bIz@~CZXDH@R?xBR|CZtEf@Z@jAB|A?TA~@Ah@?pAErBGhBCTA|HMvBMV?TAV?dCKJAf@GJA\\CZ?r@Jv@RVPVVFFFDJJNRPTJPLVJ\\L^DLFLDHFHLHFDHDbAZ^L'
                     },
                     'start_location' : {
                        'lat' : -7.277374999999999,
                        'lng' : 112.7413445
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 706
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 72
                     },
                     'end_location' : {
                        'lat' : -7.3052227,
                        'lng' : 112.736291
                     },
                     'html_instructions' : 'Terus lurus ke \u003cb\u003eJl. Wonokromo\u003c/b\u003e',
                     'maneuver' : 'straight',
                     'polyline' : {
                        'points' : '|qpk@oaboTRFTFRD\\FlALl@HlAL\\Df@Fp@H|@JjGt@L@B@b@Hl@LRB`@D\\F@?pAPD?^HlARlBX'
                     },
                     'start_location' : {
                        'lat' : -7.2990292,
                        'lng' : 112.7376848
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,6 km',
                        'value' : 4635
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 238
                     },
                     'end_location' : {
                        'lat' : -7.346172699999999,
                        'lng' : 112.729302
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Ahmad Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rxqk@yxaoTJ@D@RDZDNBLBnCb@pC^R?F?r@Bp@Hn@JfI|@nCZ^F~El@xGx@tANrATrEj@rC^fBTNBtGx@nAPdFj@vGz@h@FpC`@XDhANfFp@z@JxDb@|G~@^FdBVnBXTD`Fl@r@FF@PBB?b@DdBPXFhBTnFt@LBl@LzATtEt@p@H~B\\@?`IlAlBX~AV`@DdAHnDDzC@tD?Z@hDAfH@hD@l@?~GDjCAJ?tBD'
                     },
                     'start_location' : {
                        'lat' : -7.3052227,
                        'lng' : 112.736291
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 943
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 69
                     },
                     'end_location' : {
                        'lat' : -7.346573900000001,
                        'lng' : 112.7226859
                     },
                     'html_instructions' : 'Di bundaran, ambil jalan keluar \u003cb\u003eke-2\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'pxyk@cm`oTvBD^@zBDn@TDBLHLNFHL\\Cd@Eh@EXAFCFCDIPaAbAu@fAYl@ITEPGT?BAJAF?DAN?DCx@?jAArAG`BEbBGr@StBKtA[`B'
                     },
                     'start_location' : {
                        'lat' : -7.346172699999999,
                        'lng' : 112.729302
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 761
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 38
                     },
                     'end_location' : {
                        'lat' : -7.3477744,
                        'lng' : 112.7161873
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Taman\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`{yk@yc_oTQbAQlA?@CpA@`@D^j@|BVhAFl@?D?fFApBA|@Bf@B\\DHDLh@~@Xb@|@tA`@f@?@@@DFFJ'
                     },
                     'start_location' : {
                        'lat' : -7.346573900000001,
                        'lng' : 112.7226859
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 665
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 37
                     },
                     'end_location' : {
                        'lat' : -7.3460737,
                        'lng' : 112.7140932
                     },
                     'html_instructions' : 'Ambil jalan ke \u003cb\u003eJl. Tol Surabaya - Gempol\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'pbzk@e{}nTF@DBDBNPVXTPLDPFR@X?d@OPUJUBU?QCKGUOUKIKEOEKCE?M?UDUFqAz@MFGDEBOJqBnAy@h@ONMJSR?@MVK^Mn@SbAS`A'
                     },
                     'start_location' : {
                        'lat' : -7.3477744,
                        'lng' : 112.7161873
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '21,1 km',
                        'value' : 21081
                     },
                     'duration' : {
                        'text' : '15 menit',
                        'value' : 914
                     },
                     'end_location' : {
                        'lat' : -7.520828899999999,
                        'lng' : 112.70525
                     },
                     'html_instructions' : 'Tetap di \u003cb\u003ekiri\u003c/b\u003e di pertigaan dan bergabung ke \u003cb\u003eJl. Tol Surabaya - Gempol\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol sebagian\u003c/div\u003e',
                     'maneuver' : 'fork-left',
                     'polyline' : {
                        'points' : '|wyk@an}nTBR?D?JA\\A\\AXCTCTMl@Mr@Q|@Kj@S`AEZETAN?L@JBHBHBHFFDDFFFDFDFBNDJFB@@B@@BB`AP|Ev@hFr@PBrEl@P@F@H@bBR\\DB?L@PBb@F^DfHx@hHbAN@n@HbCZ`Dr@@?lBb@~EhAzAb@nHzBlBn@`DnAzB|@hBz@hBx@`Bz@bAf@fCrArAv@bDpBbBhA@@@?`FbDZTnAz@zCjB|A~@|BpAd@Rv@`@TJvD`BXLxD|A`HzBn@P~Ab@bFnAvBb@fGfAzAR~Gv@dF^\\BVBbSvAd@BH@z@DjNlApCVdD\\`Ed@hEd@|IfAvH~@bD`@hDb@~C\\tBRZBfAHz@FbCLdBHxBFvDFbICjDGtCKlDSxEa@jE_@|CU~BSrCQxCMrEKR?VAvAAxD@X@J?J?xCDfBFrBHnAHbBJvAJ~ANbBNxAP`ALdBV|B^vB`@j@Ll@JdCh@lFdAhARbAPNBD@`ALr@J|APNB\\DdAH~@Hx@B~@DP?~@BjA@tAAdAAp@Ad@C`AExAIz@GbAKB?~@Mv@MbAQz@OnBe@fD{@hIeCxHcC|Bq@xCy@zDaAfEy@|Bc@FAPEPCFALCHAvDe@|CYb@EF?`AGdDW~FYnDK@?D?HAP?~BGlGBzCF\\@H?R@l@BjAFnHd@tEd@vFr@LBpCd@`Ev@zFlAzBf@rE`AzAZzBb@jAVB@\\HpAVjATzAZxIdBdCh@tAZdB^d@JTFRDTFJBzG`BjEfAb@JrCl@LDrA\\^JF@n@Pv@RD@LBB@@?PDFBB@RDn@RrBd@fCn@z@P^Jn@L^Ht@PnCj@vIfBvBd@r@N|@TzA\\~FnA@@rBd@zBb@z@PvAVx@J|@LjAJlDZdBJlBHrADlBBpCBz@CnDKzEWb@El@EvBY~@G|@KvDq@hDw@vA_@zC_AdBm@dAc@zAo@bAc@fB}@rBiAbDiBrDsBfFwCnL{GnEiCJG`OsIxFeDd@WlC{AbBy@pB_ANELERIHCn@SdDaAbB[bAQnBQnAIjACdBArA@pBFtGd@rEXlFNt@CpACdAC|AMnBWlCg@rCy@jCcAvCaB~AcArAeAtCsChA}AFOBGHWDIVo@FY^wAhB}DHUf@{ALY'
                     },
                     'start_location' : {
                        'lat' : -7.3460737,
                        'lng' : 112.7140932
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,1 km',
                        'value' : 3113
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 156
                     },
                     'end_location' : {
                        'lat' : -7.5477168,
                        'lng' : 112.69743
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Nasional 1\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'd|{l@yv{nTzAVt@Ntd@fJhAT`NhCzAZ|GpAdCd@jEx@vB\\`APHBdB\\nCf@pCf@lATjCf@xB`@~E~@bAPzBd@tE|@dDn@tB^lDp@h@HZFnBV`HlAJ@|Aj@RH|@VlAZ'
                     },
                     'start_location' : {
                        'lat' : -7.520828899999999,
                        'lng' : 112.70525
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,1 km',
                        'value' : 5067
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 300
                     },
                     'end_location' : {
                        'lat' : -7.577476399999999,
                        'lng' : 112.7313055
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya Gempol/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan melalui 1 bundaran\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'fdam@}eznTlA_A~AiBZ_@n@q@@CjEeFFIPYLOHK@ABERWHKV[hA{AzAeBrBcCLMrAaBh@m@d@k@`@e@hC}Ch@m@f@m@l@s@LONO~AiBhB}B`@e@l@u@~@gAz@cAX[~AmB|BsCVYbAoA\\c@BAHKt@w@BCdAoAp@y@PUbAiAHKr@w@r@{@v@_AHKh@m@V[|@gABCRUFEd@k@xAcBX_@\\a@`@g@NSbByBDGBC^[b@e@`@c@Xa@DYFw@EEMSEMCKAO@M@ODSHc@FUDWLWDEDGJGNGNCNCx@Cl@EfBKLQd@i@j@m@nEoFJOZ]TW^e@lC}CFI|AeBh@m@l@s@x@aARWpBaC`AiAbAkAJMn@w@NQfAsAl@s@t@{@rA}AHK~@iA~@gAX]DEf@m@lB_C~@eA|@kAtBcCHKHKZ_@p@y@HKl@u@jCkDdByBfAkA'
                     },
                     'start_location' : {
                        'lat' : -7.5477168,
                        'lng' : 112.69743
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,1 km',
                        'value' : 2059
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 103
                     },
                     'end_location' : {
                        'lat' : -7.5897073,
                        'lng' : 112.7453248
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Pattimura/Jl. Nasional 1\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f~fm@uy`oTpA}A|GcI~@iAl@u@h@q@nCaD~@kAnA}ALM`AkA`@e@t@{@PUtA}At@_AtA_BxBoCj@q@DEd@i@t@aAVYzBiC`AkAzBqCDGnAwAb@g@TYjAyARUr@{@r@{@lFsGh@m@'
                     },
                     'start_location' : {
                        'lat' : -7.577476399999999,
                        'lng' : 112.7313055
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,0 km',
                        'value' : 3030
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 152
                     },
                     'end_location' : {
                        'lat' : -7.596000099999999,
                        'lng' : 112.7719226
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. R. Agil Kusumadya/Jl. Raya Bakalan\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Raya Bakalan\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'tjim@gqcoTBEdAqAx@eAJMHQJUHQFSJa@No@PiA@EZyB@KLeA@IJ{@LcAHq@B]RuAf@qD~AoMVqB\\sCp@mF`@}CJu@TgBt@cGt@qGTyAD]b@wC?GZaCL{@Z}BDk@TkB@ERcBDW?GTeBVsBb@iDZiCHu@BSt@sFDa@@GP{AXeCVyBNiAj@uE'
                     },
                     'start_location' : {
                        'lat' : -7.5897073,
                        'lng' : 112.7453248
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 741
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 37
                     },
                     'end_location' : {
                        'lat' : -7.5973811,
                        'lng' : 112.7785009
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Beji\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~qjm@owhoTl@{DHm@LkAb@qD@Kf@uEt@aGX}BBOTcBTeB'
                     },
                     'start_location' : {
                        'lat' : -7.596000099999999,
                        'lng' : 112.7719226
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 609
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 33
                     },
                     'end_location' : {
                        'lat' : -7.5984427,
                        'lng' : 112.7839216
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. A. Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rzjm@s`joTNwA@IDYBM\\mCToBJ_AVyBRqABQVoBNiAHu@Dm@BYD_A@MBO'
                     },
                     'start_location' : {
                        'lat' : -7.5973811,
                        'lng' : 112.7785009
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 819
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 44
                     },
                     'end_location' : {
                        'lat' : -7.601715599999999,
                        'lng' : 112.7903708
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Merdeka\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'fakm@obkoTDe@Dk@\\{B@WZcB\\wBNcAH_@F[BOTeABC@ERi@DKHKDIXa@j@u@FIBCDGHKvAmBRUPS~@kA\\]RWjBgC'
                     },
                     'start_location' : {
                        'lat' : -7.5984427,
                        'lng' : 112.7839216
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,9 km',
                        'value' : 3904
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 196
                     },
                     'end_location' : {
                        'lat' : -7.605336899999999,
                        'lng' : 112.8247444
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Surabaya-Pasuruan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'vukm@yjloTDMnAyC^}@pB}G^iARo@|@yC`@qAd@_BJ]`@iAVu@Rk@^sA@ETcA@CH}@BMBONy@Lw@d@qFT{DLaC@QDe@Fw@Fq@Dw@?M?MEoBIcCEk@Eq@W_EMmBCoAEMCi@Am@i@mMKcBEu@GmASqDYyGCi@C]KwAKsAImBKmCWgFIyAAa@Co@YqDQyBIeACq@A_A?W?U@[@SBOBOJs@BQT}@T{@T}@b@kBBOH]lCqLdAgE'
                     },
                     'start_location' : {
                        'lat' : -7.601715599999999,
                        'lng' : 112.7903708
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,1 km',
                        'value' : 3127
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 156
                     },
                     'end_location' : {
                        'lat' : -7.6170372,
                        'lng' : 112.8505078
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Raci - Bangil\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jllm@sasoTBQxAkGvAmF^oAfCyHjBqFX}@\\gAb@uAt@yBnAwDjAmDVeAj@iBl@wABCBMTm@J_@jDaKBI|CyIvB}Fx@iCXy@hBgFFUJWBIL]JYRo@~@uBHSp@{AL[t@mBTg@zAmDVk@fF{LpAyC`A}B'
                     },
                     'start_location' : {
                        'lat' : -7.605336899999999,
                        'lng' : 112.8247444
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '7,3 km',
                        'value' : 7349
                     },
                     'duration' : {
                        'text' : '7 menit',
                        'value' : 401
                     },
                     'end_location' : {
                        'lat' : -7.6400878,
                        'lng' : 112.9125812
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Raci/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'nunm@ubxoTzCkHbCyFn@}Ad@eAdC_G`A}BACAC?A?Ah@mAZq@`@{@L[Na@Zw@hAcC@CzAiDHSt@_Bv@eBHObFgL~@uBHUl@wAhB{D~@uBh@iA|CiHFMbA{BBEjBeEv@iBf@oA^{@bBwDFOVm@N[`@iATq@Vw@H_@xAiHD[D[Hg@NcAP_A@EToAZgBBS|@aFF_@BMNeA\\aCF[N}@n@qDBQLo@BO^oBHi@x@gF\\iBPaAfAkG@KJe@f@yCh@sCZaBBQBKRkAJs@Z_B?CBQPcANy@Jg@h@_D\\mBj@yCLk@@GBKX_BDWJg@vAqHDY@AfAuFBG?At@iEh@gCH[l@sCv@sDHe@Ji@d@cCLq@@A@GRaATiAToA\\aBJi@Je@DSBQf@iCf@wBVmAJc@^qBZ}AFWZcB\\eB~AqI`BaJFWDQfBuHb@kBDMFSHGp@kC'
                     },
                     'start_location' : {
                        'lat' : -7.6170372,
                        'lng' : 112.8505078
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 451
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 103
                     },
                     'end_location' : {
                        'lat' : -7.643660000000001,
                        'lng' : 112.9106697
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Balaikota\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'pesm@sfdpTr@JrC`AXNvAt@LFPH|DxBlBz@bA`@'
                     },
                     'start_location' : {
                        'lat' : -7.6400878,
                        'lng' : 112.9125812
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1401
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 97
                     },
                     'end_location' : {
                        'lat' : -7.650773399999999,
                        'lng' : 112.9209203
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Veteran\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'z{sm@uzcpTpBoFFSPa@Fi@r@kBtAyDjAaDn@aBxA{DLYFOJST_@h@q@Z[fCsCTSPI|AyALMPOt@s@BCDCBExB{BFG\\]BEf@g@`@c@HIXYNOl@m@j@m@d@g@FG'
                     },
                     'start_location' : {
                        'lat' : -7.643660000000001,
                        'lng' : 112.9106697
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '35,9 km',
                        'value' : 35886
                     },
                     'duration' : {
                        'text' : '30 menit',
                        'value' : 1798
                     },
                     'end_location' : {
                        'lat' : -7.753799399999998,
                        'lng' : 113.2169834
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Insinyur Djuanda/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'hhum@wzepTHIn@m@xA}AxBsBzC}Cj@m@FGBC@Cx@{@fAgA@AzE}E^_@VW`AaA~@}@PO\\_@@?rBuBZ[HKTSJKBCTU`A_AdAgAhBkBhAiA~@_AbAaAlAoANOPQPO`@a@jBuBdI}H`FyEd@c@rBuB~@}@TSrEmElAmA`C_CJIvAsAp@i@`BgAjFqDdD_CzE_D`Aq@~@o@@A~AeAfB}AjAkAh@m@fCyCz@aAdC_D^i@tByCjAcBn@_A|CqEd@s@vB}ClAgB`CkD\\e@FKjBoCpAkBHOb@q@Va@b@_AhAsCFOJUb@iAVw@Ri@bDsItEcMXu@FMv@}A`@w@Za@JQVa@bB{BR[LQPWj@{@LQl@gApAcCLY@?NUn@{@b@g@LOn@k@lAsApAwATWJMvAcBjAoAPSjDyDvCkDTWj@m@|@gAxCqDhBmBFIV[^c@r@y@~@eA@?HMVWJO`@e@\\a@fCuCv@{@b@e@HIz@gA@AxBaCt@y@jBqBlBwB`@a@?AZYZ[TULOr@o@DKzAyA\\_@?APSNSJSJ]BIJc@Li@X{ATkAXoAHa@hAsFR}@`EmR^eBH[TcAb@cB`@_BXgAZcAPUJc@T{@H[Li@Vs@f@qAtBaFf@{AlAmDhAiDfDiKfDkK`@mAHSH[^kA`@kARq@Nc@J[Tu@Pi@^kAJ[FQ`@uAVw@FSt@qCP{@|@{DZyARiAf@mCr@gE^{BRoAT{AXqBD]PgABO@GVgB\\wBXgBRoAHi@Lq@PcAZ_BXwAb@wBZ}A?ADO@MJc@f@eCjA{FRgAHa@Z_Bb@eCRgAf@gCBMFWHe@?CDSPs@ZwALg@Py@H]La@BMRw@V{@V{@JWJWFSN_@Zy@Tm@Tk@\\{@^_A@Gj@sALa@La@@Af@wA@CFUTo@BI`@sABITaAJa@\\}AFk@N}ABa@Dc@@SDi@Hs@B_@@[@O@g@@]Ca@A]Iq@C[w@iFe@}Cg@iDQeASaBIg@YsBUcCE_@UqCQmBYiDMiAEs@IeAEk@KgBEg@Gs@?EAOEs@GiAAi@?C@_@@]Bk@@UD{@Dy@H}@Ba@BQH{@D[BWJy@Hg@DYRiAP}@BMBMH]b@uBDQTaAJe@Nq@Hc@Ls@DW@IBM@KFa@Nw@Jk@BSHu@Hq@BSFk@PiBJeAFk@Da@Du@@ADe@B[Dw@H_A@SFs@Dq@F}@HsABu@By@@U?Q@s@?Q?q@?w@?CEcAI{@I}@KiAKcAI{@I_AGw@Eo@E{@CWIiAAU?AAcA?KAu@?u@?k@DoD?i@@aC?eA?[@gC@eA@{A@_@@a@@o@FsADkADw@JsBNiBFg@JiAPyA^eCt@cEl@yDb@gCD[L}@PcBPeBLyBHiABc@J}AHoAJsBBsABcC?}B?E?yB@cCAs@GuCEeBCk@ASEiAE{@MaCAs@OmDKqCAmAAs@Bg@Hs@V{A@CL{@DWBMDQTyAVyBNgADe@@GBIL{@TmARaAn@qBjBmGzByFzFyLvBaE~BaF`AmBb@}@fAwBJUp@sADGNYJU~AyCpAgC|D{HzA{Cf@eAdAcCDGbByCpAyBXg@Zy@v@{C`BsGBM\\{AjC{JVaAF[l@iCFQXaAh@wBHW~@kDLa@bAiEh@sBFU`@{AJu@n@_CVy@hBeHdAeEtAsFj@}BtAoFd@mB`@eBdA_E`@_BhBsHd@iBFWjAqEn@gCXkA^yArBiI^_BjAkELo@t@wCxBwI^wAxBwIl@kCJa@p@kCx@iDbAcE^_BT}@h@wBv@{Cj@mCBK?CDKbA}D^eB~CmMt@yCXmAhAqEhAcFV}@`@_BT}@`AeEf@}Bj@}BLi@tAwF\\yADQXkAFYfAgE|AwGb@cChA{GVkBHi@BWHg@DYPwAD[d@oDhAqI@Id@aETeBBQHm@Hg@NkAXuB|@}Gb@gD?EPuAR}APqA@Gd@sD@Gb@gDRsBD_@AQBO@EVyBVkBD[VoBBMJy@LcALeAX_C@OXyBL}@LkANiA@KZeCDSb@gDJs@RuATsBFg@d@qDNoAHu@Fc@BSJ{@p@kFFg@NkAHs@\\wCJ_ANiATmBJu@NsAJaAFe@Fq@NoAJiAB[Do@Bi@B[?G@o@DeBD_D@o@@OHgDDgC@_ABkADuCBuBBk@NiH?S?eABaBBcDB_D?]BiA@gF?EAeAAsAAGA_A?]CiACcACkA?E?mA?W?O?cA?c@?s@A_@?yAAKC_B?ECcA?w@CcAAq@AWC_AAQCkBAWAcACqAAc@Es@EO?OE{@IuFEmACyACkA?WCqBEcCAk@AqAA_@AiAA]CuAAy@Aa@Ay@CyA?k@Ak@?IJoE?ADkA@SLUHcA@IPmBNqANcB'
                     },
                     'start_location' : {
                        'lat' : -7.650773399999999,
                        'lng' : 112.9209203
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 417
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 46
                     },
                     'end_location' : {
                        'lat' : -7.750093499999999,
                        'lng' : 113.2175593
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eGg. Salak\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'flin@cu_rT_BO_@C_AKaAIwD[{@GuAMyCW'
                     },
                     'start_location' : {
                        'lat' : -7.753799399999998,
                        'lng' : 113.2169834
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 99
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 15
                     },
                     'end_location' : {
                        'lat' : -7.749945200000001,
                        'lng' : 113.2166759
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eGg. Salak\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kiri.\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`uhn@wx_rTMxAMtA'
                     },
                     'start_location' : {
                        'lat' : -7.750093499999999,
                        'lng' : 113.2175593
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '96,3 km',
                  'value' : 96312
               },
               'duration' : {
                  'text' : '1 jam 23 menit',
                  'value' : 5006
               },
               'end_address' : 'Situbondo, Jawa Timur, Indonesia',
               'end_location' : {
                  'lat' : -7.704920599999999,
                  'lng' : 113.9954432
               },
               'start_address' : 'Probolinggo, Kota Probolinggo, Jawa Timur, Indonesia',
               'start_location' : {
                  'lat' : -7.749945200000001,
                  'lng' : 113.2166759
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 150
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 14
                     },
                     'end_location' : {
                        'lat' : -7.749732099999998,
                        'lng' : 113.21533
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003ebarat\u003c/b\u003e di \u003cb\u003eGg. Salak\u003c/b\u003e menuju \u003cb\u003eJl. Suroyo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dthn@gs_rTK|@Y`DEl@'
                     },
                     'start_location' : {
                        'lat' : -7.749945200000001,
                        'lng' : 113.2166759
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 412
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 46
                     },
                     'end_location' : {
                        'lat' : -7.7534218,
                        'lng' : 113.2150186
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Suroyo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'xrhn@yj_rT`@BzDN~@BR@h@BrDNf@BrBFt@B'
                     },
                     'start_location' : {
                        'lat' : -7.749732099999998,
                        'lng' : 113.21533
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '20,2 km',
                        'value' : 20206
                     },
                     'duration' : {
                        'text' : '17 menit',
                        'value' : 1047
                     },
                     'end_location' : {
                        'lat' : -7.766993100000001,
                        'lng' : 113.3788555
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Panglima Besar Sudirman/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'ziin@{h_rTLUHcA@IPmBNqANcBLoAFq@d@oBzA}D?ABGDQh@{AFMjAmDHUj@}A\\_APg@l@aB`@aAvBuFPc@L_@BEp@kBTo@b@mAVo@@Ct@qB@Et@iBb@mADI\\_A`@gABGr@qB^aAHQ@Ex@yBdAmCRk@N]t@qBBG`@cA`AmC`@eAn@cB`AiCNc@p@eBPe@P[JYhCyGh@yAZw@BIr@oBFMh@uARg@p@kBXs@DK~@cCv@{BVq@`@eATk@DOFON]Rk@jAyCJ[Ti@Ri@FMbBkEFMz@_Cl@cBBGPc@DK^kAPg@|@wBx@qB@Cl@{Az@cCb@oA~@iCNc@\\{@`@gAhBwEj@wAdAgC`@kAL]~@gCh@yAXq@DObAcCVu@j@wARk@Tq@X{@j@wAd@kAf@sAh@{AbCoG`AeCHUf@sAxD}JRc@pCqHtE}LL_@bBoEzB_GZ{@LWp@gBDKHWN_@@G@GBG@GDUBS@Y@WB[Bk@@A@W@OTaFF{@DgA?UC_@Ie@Mg@Ss@Mo@@]FYLUNOXOXKXEd@@xBZl@Fj@Bn@?^EZMRQVWR[l@_ABE\\i@PW`@u@\\m@NWJON[P]N[NUJOHMPORQZUd@[XSj@c@d@_@PM~G{E`CaB~BcBPMjHiF|AeA\\UxFaEDCz@o@NKVSXUZWDE\\[TSRUFIHKFIHIFKFI@ADINUFIHQLYHUFSBKBMBQBQBWHg@Fm@Da@Dg@B[@ODc@HsADo@LiBPsCHmCBm@@wC@gABmD@q@?s@@_A?}A@uA@iA?_@@y@@}CH{GAyBI}GMwEMwD[uGs@gKCe@IqBKmB?EC_@M_CIcBCm@CSQgCAe@GmBAIEeBAMC_@G}@Ck@KwAC[GkAAQM{FAUIqD?WCwC?gA@sB?qB@gAIiLGwFYuRE_CAkAA_BCsAAwB?GIeEEoBYoGOkDGqAIuH?O?]A[?E?E?E?E?EAE?E?E?CAE?EAE?EAE?EAEAE?CAEAEAEAEAC?EAEAECCAEAEo@aBqBaF}@mCcAoCkHmSc@kAkDaKIUeCuH_AqCa@kAy@cCgAeDe@sAmDeKAGmBsF_CyGy@aC]y@qDoIg@kA_B_EEIQa@Se@gAeCEMEIUc@_@s@iMgSOUyFeJ_DuF}AmC{@{AWe@sB{Dm@kAaBgDEKyAyCsAmCyFcLuCmFc@aAg@oAqAgDaBkFeAqDOe@cDmKqB_HCGaB{F'
                     },
                     'start_location' : {
                        'lat' : -7.7534218,
                        'lng' : 113.2150186
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '6,6 km',
                        'value' : 6641
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 333
                     },
                     'end_location' : {
                        'lat' : -7.756503400000001,
                        'lng' : 113.437651
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Panglima Sudirman\u003c/b\u003e',
                     'polyline' : {
                        'points' : 't~kn@{h_sToCqJ[iACIW_A]mAGSa@uAq@}BSs@Yy@e@wAg@}AeAeDQo@M]Sk@Sq@IWQo@AGCI?AEMEUMo@Iq@E_@Iq@YwCWiCMuAIq@I{@WmCk@qFm@cGc@{DCQGa@G_@Ea@Ga@G_@Ea@Ea@Ga@Ea@E_@Ea@Ca@Ea@Ea@Ca@Ea@Ca@Ca@Ca@Ca@Ca@Ca@Aa@Ca@Aa@Ca@AY?GAa@CgCEeDA[A}@AuA?M?k@CsEAwE?cA@}DAmBAeBEeBGIMqH?IG{D?[AgAAi@?]E}CA[?u@As@EcD?[CcCEoBAgECwCCqBCwBC}ACo@KwEG}BOgDEy@I_BE_AOiCQqBIcAOcBg@yFM{@ESCOKs@YoB]wBGWKq@Ki@UoAKq@e@sCQwA[sBASE]Mu@c@mCKg@c@cCk@{CI]WmA_@gBQy@Ia@kAsF[kAgBoGoAyD'
                     },
                     'start_location' : {
                        'lat' : -7.766993100000001,
                        'lng' : 113.3788555
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,1 km',
                        'value' : 2073
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 104
                     },
                     'end_location' : {
                        'lat' : -7.7449323,
                        'lng' : 113.4518593
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Kraksaan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'b}in@ixjsTY{@a@cAs@kBc@iACCs@kBoGcPQc@Si@[w@AAKUISKSKSKSKSEIEIKUKSKSKSKSKSKSMQKSKSMSKSKSMQCEGMMSMQKSCEIMMQKSMSOYEGg@m@g@k@iCkBeAs@mEsCkAu@qEqCIGuBgAaB}@GE}@o@g@]KM[YUWkBwB]a@y@cAKO'
                     },
                     'start_location' : {
                        'lat' : -7.756503400000001,
                        'lng' : 113.437651
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '66,4 km',
                        'value' : 66366
                     },
                     'duration' : {
                        'text' : '56 menit',
                        'value' : 3381
                     },
                     'end_location' : {
                        'lat' : -7.708297799999999,
                        'lng' : 113.9965457
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Jabung/Jl. Nasional 1\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 1\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'xtgn@cqmsT_AqA}B_DUY]e@}CyD_BoBsBcCyH{IMSKOMOKSMOOOMQMOOOmBiCe@q@k@_AKOKOMOKOsA}BgBkCKQKOuOkVACOUeCeESa@GMU_@y@_ByCwFSa@aCsEc@w@iAwBc@aA{@kBIQO_@Wo@_A_CQc@{AwDO_@Ma@EKISMa@M_@AAK_@Ma@Ka@Oa@K_@sAyF{@_DMa@Kc@CKGU]{AOo@IWMi@AIK_@S_AQ{@ESKi@W{AAEY}AEWQiAM}@Kk@c@{B_@qBq@aDAIa@gBKe@e@aCc@}Bi@sCe@kCMs@Kk@EYOm@Sw@]kACIMc@g@cBcAcDwAqEq@qB{@iC[_AcAcDo@qBQk@wB_HGQ}A}EEMQk@Uu@Y{@IWGSMa@[_AUq@K_@K]K[K[K[K]K[]eAi@_B]iAi@aBe@wAg@{Aq@qBc@sAAE}@oCIYYy@EK_@iA]_Au@{Bo@iBc@kAo@iBg@}AwAmEOo@aA{G]_CKy@Kk@Ku@?EIq@Ce@Cq@CcF?K?s@?iA@aABy@R}CPuB@IHeAJaAPcB?E\\oD@UDYB[V{B\\iDXmCr@eHN_BNyAH}@Fs@BQRgBFs@BSPqAF_@Hk@Ly@DOHe@PcALs@Jg@D_@N_AXqB@OJw@@KD[F_AHoAHuA@YBa@Dc@?ABcAD_ALuCHuCF{BBs@@u@B{BFmFBwB@eA@g@BcBDyENaG`@aMZmHb@}Hf@qIHgJDgM@iBA]CYGa@Qm@AE_@eAe@qAq@}AyAoDKWuBoFqCgHGMGMGMGMEMGMEMGMEMGOEMGMEMCGCEEOEMEMGMEOEMEMCKACEMEMEOEMCOEMEMS}@Mg@O{@My@K}@mB_P_BkMgDeYE[QmCOmBSwDSmDG}@]gH?E?E?G?E?E?G@E?G?E@E?G@E?E@G?E@E@G@E?E@G@E@E@E@G@EBG@EBIBG@GBGBE?ABGBIBGBGDGBGBGBGDGBEDGBGDGDGBEDGDGDEDGBE@?DGDE@C@ADGFEdFwE`@c@VW\\g@b@{@Vo@To@xA}GR_ANm@rB}GRi@HSJObCkDhA}AvDkFdA_BHMFQDKBU@K?KCKAGCGGMOSMIICMCGCG?YAS?u@C[AYEYI[OMKKKIMIOKWGSCSEUYcBOoAAc@Ce@?yACsDGkA]}Cm@aFO{A?S?Y?O@QB[Hc@d@}AX}@Ps@ToAF}@PaDTkDBSBIBKBG@EFOJSn@gA|@eAR]Xe@Tg@~@wCr@kCj@gC^iBP_APi@Xw@Vm@~@uB`@}@Zg@d@o@RWr@}@hAaBxAsBz@wABGtAiC`@y@LUj@eAd@gADKZw@Pc@^aAp@sBDKLk@ZkALo@F[Ny@@EPeAPmARsADk@@e@?cBIyEKaC?CEkAUoFAc@C_@AY?QCy@GqBAQM_DKiCMsDCo@QyEEaAGeAEc@SmA?GCIKi@AMAAa@wCs@iEG]g@cDq@kEYyB?I]mCEm@AUAM@K?I?EBYRiAV{AD[B[BmA?w@Ac@Ac@CUI[e@iAg@eAGUCMAK?K@GDMDIHOZ]TUNOTIvAe@pAc@PILMBG@EBEBG@G@G?A@GHgB?CDsADiA@_@DaCEsDAw@COCOCOGOi@{@]i@GMAGEe@AY@W@I@G?EV{AZ{AHQ@EBCBCBCBA@ABANGZKFADAZE`AK\\GFAFADCFCFENMFIFMDOBQ@S@S?[Ei@EMAIEIGIS[OUAGAEAGAI?G?E?C@EBKFOHMJIHI\\U\\UNKDIHMRa@Pc@Vu@FOh@}Ab@iALUpAkCbAcBz@sAjAmBp@cB|AmDZw@jAuCRg@Rg@p@aBJYVm@jBoEr@eBtC}GfAkCzEoKtA_DfCyFn@wAhB{Dv@_BLWJW^{@BEN[hAiCVo@rBkEjAiCx@eBFUTy@N}@Ns@Hi@P}@D_@^gBBOBOBS@UB]AMAs@GiAA[AKK_CMqBGk@Mu@SkAYkBO}@OiA}@mFG[QaAAICMAKAG?s@C}@?c@C[E]SyAKg@o@kD]kASq@Uq@Q_@Wo@_@}@Si@y@eCAEOk@EWEg@C[AOAY?UAeD?q@IaD?{A?_@C}AEwF?W?_@AiBCmG?KCqFAsBA_C?UC}CAiACkDBsBAQKsCGiBs@qAQe@AGAG?I?G?WBYFe@NiAL{@Ba@@S@M?M?OAMAGAKCKCCAECCAAACCCAACCAAGEICICMCI?G?]?mFDUAOAOEMGIGCCEEGMCKCQ@cA?uC?I@iB@_A?c@@c@@oA@U@o@?E?G?QDkC?GJeJ@e@?MJeJ?I@SFmF@iBB{ADwG?i@LeHDaHDeEBcB@c@?GH_IB{CBiEFeF@s@@}A@}@FeF@u@BcDJgKDcFDyDHkG@oA?Q@mA@mA?Q@gC@a@?W?a@?_@Bk@DkA?I?kA@wAHyN@qBPmT@cB@gC?eCFcM?YDyF?[?k@?I@mABeBBw@BuAHwA@W?AJw@Nw@Jm@H_@T_A@CXgA@CPm@Ne@f@iBz@kCRq@JWl@{A~@iC`BkErF_ODIfC_Hp@mBL]Rq@Hc@B[BW@[?W?[AwAAiC?m@AeBA{@?_@Aq@?MBm@FgB@g@HqBTyCBSPyCBQH{@NqBViD@OVkCD_@j@uELaAHcADg@De@BYF_BDeA?U?A?[BuDCg@A]G}@IgBAIAOM{AKsAKqAMoBIoAS{COkBCWAQAYg@uH?EOiBSgBGgAQ}CC_@WcDIcAIaBCa@Gq@C]Mq@[q@oAoCmCaGcBqDiBcDoD_G[k@}CaFIO_@q@w@wAc@}@Q]_AcBk@eAAAa@u@Wm@eDaGmA}Bi@mAcEgI}CaGk@cAYm@eAqBc@o@a@o@kE{GyAuB{EgHw@gA{@aAyAiAi@_@iBgAeAs@}AmA_@Y]YqAiAg@e@kBkBa@c@c@i@{CeD}@oAIIuJmNq@aAWWMS[UKGc@Yy@g@mAw@kAs@yByAgCkBi@c@m@m@o@g@MKoB_ByCgCKIc@_@eFgEm@a@k@YuAu@iCaAa@SuAo@k@[UKGE_A_@cBy@eBw@aAg@WM_C}@mBy@eCmAmG}C{EaCeMiHgB}AoFmFqCaDo@s@gAoAcAgAKQMY[k@Wu@YuAAOKw@AGUqAQcBe@mD{@wHYgAKe@Oe@KYSe@cBwB}AyAYWcAg@sBe@yCm@mEw@s@KeDe@UGe@KKCi@YiCeBuAy@e@e@Wa@_@s@_@iAYaASsACQIi@UuA]{Bc@}CCUKy@Y{AKs@a@eByBeLE[Q{AKmAAE?AEe@KqAC[?AIeACa@IcAAOIgAImAGcAKcAAIAKAKCi@AOA[KqAAEEi@GaAMuAAACa@Eo@C]AKM_BAYCUKuAAOKuAQqBAIG_ASiDG_BIkCAm@?w@A}BAmA?}BEcCIiB?_@C}@@{A@o@?_B?kBAeB@}@@{ABiAHiA@oABqAIwACi@AO?KAy@@OEg@AWIo@Ig@G[Ik@A[A[@_@Di@D]?[?YE]E[Oy@Mw@g@{DEUGy@Am@?sABaB?M@w@@]@IDsABe@Fm@BUBS\\{B^_C\\mBP{@ZaBNq@RgAFYH_@RcAh@sCF_@\\{AJi@b@qB^cBFYh@oCLi@hAuFb@kB`@iCLkA@SHYT{@N_@Zs@Tg@Pg@DO@[@YC_AGc@k@mDO}@EWAg@@mACwACuAEs@Ak@?o@@[D[Lu@JWt@cBb@u@Ra@h@cAnBsDLWT_@PYrAgCV_@LQNUNQTS^a@d@_@f@]n@c@h@]bAs@POLMHKv@iATc@b@_APa@DMf@iAZk@nAeCrBkEbAsB^w@DIl@yAh@iA`@oAVq@d@{@~@aBT[FKv@uAPUVWTSTSVSd@]l@c@n@g@HKJKb@_@LKRWJQV_@\\i@~@qB\\q@Na@Vm@Xo@\\s@T{@Rm@Lm@BMTaA@GP_ABMRsAF_@DOXiB^wCJu@Hy@XoDD_AFu@BYh@_JHoAJkBh@iJ@MT}DFkAZyEDy@?CLiBLiCBa@Bg@PyBXaFNmC^uGB_@Di@@QPcDLeC@_@HyALyBDo@XuE?KFgABYHcB^mHBo@JoBNcDF}A@c@?E?W?OA[GYM[]s@eCqF[w@qHcPeCoFCGiEmK}AyDe@iAw@eBgAkBeCmEACOWIMAAQUY]OMMMEGCMAI@GBSzAwFPo@fAgEDKXiAVcAFSPs@V_ADODSH[TaAFY~@mD^gCD[BWBYB_@FsA@UHcBJsB@QCw@OsBAe@Lq@PQb@_@X[j@u@HMdAkBvAcCt@oA\\e@BE`@m@|BmDf@y@@A\\k@Va@HON[Zm@P[@AHOb@aAPg@BGZcAL]T}@DUNy@\\mBPgA\\wCVeBBMZaC@G\\aCr@kEDQPoA?AHaANiALgABSBKFa@@GDQ^eA`@{@HQfA_Cr@yAP[@EBGv@gBb@_ADGh@gAb@eAL[Rg@^oAXoA@EDYH_@H]PaAv@qDVsAh@qCPw@n@gDNu@XcA`@sBf@kCBIHe@Py@Ha@Po@Hg@Ns@@KHo@@S@Y?a@CUKq@[aBUq@[u@e@u@o@iAOYCESa@o@yA[q@EGGWOo@Ig@CWCY?y@Dc@J{@ZqBr@kE@GLaA^uC@ODc@A_@r@gFDY?CXeCFk@TmBLcAHo@d@kDP{ADk@j@{GDm@BUFmAFyA@{@@aA?e@?AASEs@E[QoACIO{@]oBY{Ae@{CGU?CMs@[mBw@yE'
                     },
                     'start_location' : {
                        'lat' : -7.7449323,
                        'lng' : 113.4518593
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 385
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 56
                     },
                     'end_location' : {
                        'lat' : -7.7048573,
                        'lng' : 113.9961554
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. WR. Supratman\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'zo`n@m}wvTeDXkBH_EPG@C?e@Bg@BY@K@Q@k@D_@@'
                     },
                     'start_location' : {
                        'lat' : -7.708297799999999,
                        'lng' : 113.9965457
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '79 m',
                        'value' : 79
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 25
                     },
                     'end_location' : {
                        'lat' : -7.704920599999999,
                        'lng' : 113.9954432
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'jz_n@_{wvTJnC'
                     },
                     'start_location' : {
                        'lat' : -7.7048573,
                        'lng' : 113.9961554
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            }
         ],
         'overview_polyline' : {
            'points' : 'rs{d@ahckSl@z~AhiBqPviAtTha@whBfAmcHrnAoeBjBssEib@q`Dbn@agFd|D{}Ol}HonRdiAczCyRaeIl[}uMn}ByfFpkBkeGrhB}{EzDusC}s@wt@i_B{}AemB{iB|]_bE|v@}oGohKssP}tDwkS{r@q{El|@umKr_CckOhKq`LlgAwwEbvAauAndF_lEvuBkgExc@ejIx^{tIia@wmBajBsx@ixDulBmbBasA|FmwA`_Bs`D`}GufHb_EcdD`oDqsAtiD_tAvuB_eCx`H{|AzaNsxCrlJouCvcCgKfdEtFlf@edF~rEqqDrjF{xOn{@_xJtwBchI~rDukFsXegHcRciN}RcaF`~@sqFdJszGit@coCs@wiAgkAqLha@ugD~OwmB`\\ylGnUycWaBsqCtx@}aCxIcqDjy@opBhr@q}JsMstDux@efBtTsbHqLyeIsR{{CxmAqNla@gnG|cBmeGn~AaoBbdAm}@z[ydCyf@}eAn\\ojAp~B{sHzf@epBkRumC}^sgH`u@kxC{o@y~BrQ_aDoQwtAwrAgcAmTi{Ekw@kcBi{B}cEoS{cG`X}xBz}BqlBta@sgAaoA{{@ncAapCjz@kxA~g@bL~q@_iB`l@cbFfb@iuCaJgaDad@_iDwvAqy@qt@khGm{EqhXucAk|CkCg`CwZipAmpBenBkcAw{Dui@moGypBcrJyqB_wCm}C_qBaBefMycAstGiwBysEkkDw~Dfe@yyBczBavGa_BavIqq@uaGkeBazQdx@e|I}b@ccKe]cyEfb@ym@_aAwr@a`Gy_BuoAkdC{B{~BhRojFxlEk~F`yH{}JviHalK`}DmgSlNg_HigB}yHbmB}dCtwCc{HrwFg`Hf`BgxAz}@rd@v@JySjr@x{@aMmBqTmc@eNQ@qk@}[zcAaaD|gDw_C|kGm}@ntHsaGffGkxApiG{qBfEutI_k@wpNhj@ykIdnCoaTn_E_wHnaBwoHgK_mCso@kz@xxDaeCljEcgDxzBghGfVcfG~fAuSbg@{m@rnF`v@`vDdf@fxAty@_Atl@pkBlt@veHz}@hkDkGxuD|^nsAdVljC}_AvhFiGhxBaiAh|DaxEbbE{aUz|BugI`wFy`GfiDwgHfc@{pFnSkyFp~D}yNd_@wgHnEueAlaAgjCfjCgvFtVg{H{vDc{K_|@ylHimDitG}^mvIoTspEhy@akFjBeyCl{@ylGuGuyIrd@uxCoaAeuDkoDsvCeyAwiC~I{pFbwAqfGkW{`D|j@ynBnOqpBiSymA'
         },
         'summary' : 'Jl. Nasional 1',
         'warnings' : [],
         'waypoint_order' : [ 0, 1, 2, 3, 4, 5, 6, 7 ]
      }
   ],
   'status' : 'OK'
}";

        #endregion

        #region Jalur Selatan

        public static string JalurSelatan = @"{
   'routes' : [
      {
         'bounds' : {
            'northeast' : {
               'lat' : -5.9314301,
               'lng' : 114.3690673
            },
            'southwest' : {
               'lat' : -8.3688267,
               'lng' : 106.8302728
            }
         },
         'copyrights' : 'Data peta ©2014 Google',
         'legs' : [
            {
               'distance' : {
                  'text' : '150 km',
                  'value' : 150351
               },
               'duration' : {
                  'text' : '2 jam 5 menit',
                  'value' : 7514
               },
               'end_address' : 'Bandung, Jawa Barat, Indonesia',
               'end_location' : {
                  'lat' : -6.915076,
                  'lng' : 107.6082096
               },
               'start_address' : 'Pelabuhan Merak, Indonesia',
               'start_location' : {
                  'lat' : -5.9314301,
                  'lng' : 105.9973755
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '8 m',
                        'value' : 8
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 1
                     },
                     'end_location' : {
                        'lat' : -6.2087167,
                        'lng' : 106.845536
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003ebarat\u003c/b\u003e di \u003cb\u003eJl. Minangkabau\u003c/b\u003e menuju \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rs{d@ahckS?@CJ'
                     },
                     'start_location' : {
                        'lat' : -5.9314301,
                        'lng' : 105.9973755
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1354
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 247
                     },
                     'end_location' : {
                        'lat' : -6.205222399999999,
                        'lng' : 106.8338468
                     },
                     'html_instructions' : 'Terus lurus ke \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'maneuver' : 'straight',
                     'polyline' : {
                        'points' : 'ns{d@sgckSSp@Od@GRwA|FYfAIZQt@q@~C_@~Aw@xCi@xBg@zB_@zACJk@rB[fAOd@GRg@dBMb@ETGf@I~@OtBa@bEGdA?DUhCCV'
                     },
                     'start_location' : {
                        'lat' : -6.2087167,
                        'lng' : 106.845536
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 434
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 42
                     },
                     'end_location' : {
                        'lat' : -6.204655,
                        'lng' : 106.8299688
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eGalunggung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'r}zd@q~`kSEf@Gv@Ix@Eh@MhBEjAE|@K`BQfBOvAIl@'
                     },
                     'start_location' : {
                        'lat' : -6.205222399999999,
                        'lng' : 106.8338468
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 248
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 29
                     },
                     'end_location' : {
                        'lat' : -6.2067305,
                        'lng' : 106.829347
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. H. R. Rasuna Said\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'bzzd@if`kSjADfABTAX@PBN@RF`@Pt@^XNPL^R'
                     },
                     'start_location' : {
                        'lat' : -6.204655,
                        'lng' : 106.8299688
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,7 km',
                        'value' : 3662
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 341
                     },
                     'end_location' : {
                        'lat' : -6.236591799999999,
                        'lng' : 106.8275078
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. H. R. Rasuna Said\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`g{d@mb`kSxB_At@W|@Y@Ab@Mp@U\\In@Mj@G\\EtBSdBM~@Er@C^AxACn@?fC@pA?L?xAEdCCj@CjAEbAE`BEnCKx@Cx@GVC^IZELCl@IB?LCPCXC@AXCf@Il@Kd@In@MFAZIbAUj@Mx@UJEfBm@nAc@@?|@SrAWjAO|Ce@BAt@KDAxB_@r@MB?PEhEOB?tBGTAP?R?\\Cf@CdIWZAlBGB?B?F?jBEnAC`@@fAFr@Hb@Hj@LpB`@VFhA\\NH|An@f@Vv@j@nApAl@n@NPd@l@h@z@\\p@^z@b@lATj@HR\\|@\\t@DHX`@d@p@LL@BHFTPPNdAt@DBVL@@HDTLDBx@b@?@JF'
                     },
                     'start_location' : {
                        'lat' : -6.2067305,
                        'lng' : 106.829347
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 449
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 53
                     },
                     'end_location' : {
                        'lat' : -6.238815,
                        'lng' : 106.830893
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Jenderal Gatot Subroto\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'taae@}v_kSJSbByCv@yABA@CBEJUXi@FMHKP[PYLSTYJKFMT]JUb@u@\\q@R['
                     },
                     'start_location' : {
                        'lat' : -6.236591799999999,
                        'lng' : 106.8275078
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 217
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 21
                     },
                     'end_location' : {
                        'lat' : -6.2398208,
                        'lng' : 106.832572
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Kapten Tendean\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'roae@al`kSfEoI'
                     },
                     'start_location' : {
                        'lat' : -6.238815,
                        'lng' : 106.830893
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,5 km',
                        'value' : 5456
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 327
                     },
                     'end_location' : {
                        'lat' : -6.2474568,
                        'lng' : 106.88064
                     },
                     'html_instructions' : 'Ambil jalan di \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Tol Cawang Grogol\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'zuae@qv`kSf@i@BENQR_@h@uA`@}APaAFc@?_@VgBF_@RyAXeBDQ@C@CBAFAv@uFlAoHz@iG\\mBTkAfAeCJU\\w@HWFOFWFYDWD_@@E?I@E?A?I@I?G?A?G@G?E@a@B{A?C?[@{@N}G@qA?_@CsACiACg@Ai@Au@IwCOqFCaAAm@GmACkB?]?{B?gAAuA?I?uA@sA?G?_A?w@?E@_B@mQ?o@AO?C?U?G?I?gACu@EeDCuCCsH?uB?WFeBD_ADo@Hw@LsAD]PkAVkA`@aBTy@@Gj@wBfAyDNi@@A@E?ALc@tAoFNk@@GPq@rAoGBKl@aELy@RyAVyB`@qDD]@O@?B[BM?EDSLcA@KBMD[d@qD@ABSBSd@gDBOR_BBQPsAZmCVuC'
                     },
                     'start_location' : {
                        'lat' : -6.2398208,
                        'lng' : 106.832572
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '65,9 km',
                        'value' : 65860
                     },
                     'duration' : {
                        'text' : '47 menit',
                        'value' : 2829
                     },
                     'end_location' : {
                        'lat' : -6.4184588,
                        'lng' : 107.418593
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Tol Jakarta-Cikampek\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'rece@_cjkS?YBsA?uA?oAAeACc@?AO}GO{BIg@Io@Qu@Qq@So@Si@Yk@Wm@[m@o@kA]k@u@eAy@iAe@s@[m@EIMSCGmAmBcAoBSk@a@_BO}@U}BOiC?{BFoBFu@Jq@`@wBZqAf@cBt@cB|@mBz@sAbAsApAwAnBeBjB{AvBsA~CgBrC{AtBaAnCuAdB}@nDsB|@y@`@_@jAcAzAeB`BsB~AmCz@sBd@{AxAcEv@}Cn@gB`AwC~AkGJ]lBsGfAgEP_A|@_FXiBH_ANsAJoB@c@DmADgB@gGCmE?IAcAU_LG}F[uN?Am@oZAQw@ye@q@s[AYAi@I{DEmDA]A}AC}A?_@GeCQyEAcACkBAgAEcKCkBMoFAaA?S?E?yAGwBO_GI_DE}BCwAIqBOyDIwBCY?CCWAGCg@?C?CC[?AIw@E]a@{DCQIs@Gm@OkAMy@Mq@Kk@GYQs@_@mB}@yD]mAOg@[eAo@kBoCgHoAcCO[{@{A]o@y@{Aw@uAIQCGIQCCYi@QYS]aAeB}@cBm@gAo@eAIQqAsCAAm@qA_@gAkAaE]_Bg@cDAE_@mCSsBIkAIeBEkBAiEFuB@_@\\uFPsABKh@_Dn@uCj@iBF[HUvBkGbAcCpDeJBGBGHShBmEFQnAeD\\aAx@wBj@cB^wADM?AFO?ABGLg@|Kkc@?A@?BMf@sB|@uDnAeFvCkLBGdCcK?ADO?CHWfBeHr@uCJc@?CBIrBqI~B{IzBgJBGDSvAqFdCiKhDeNBMPq@p@mCz@mDlFgT@C^yAtKoc@@C^}ARu@tBiIvAgGrDuNrAqF|D}ONo@l@sBbCyIjGmRjAiDDMrKi[XcAlFmQ`@cB?ADQdCsJHa@nBkI~Iob@l@sCt@qDt@iD^eBjIe`@lAyF|AgHnAqGnA}FFWjAcF~ByKnBuJBGFY|@aEz@_EjHy\\rDyNjB{GtCsJL_@@EHWz@uCpD_Kd@sA`BoEzB_G`A_CxCoHJSJW|DsIvBoEbFeKdDaHxCeGHQ~AiDx@cBxD{H|BsEL[Pe@tAoCJSR_@z@eBVo@jB{Dh@kAp@uAh@iAd@aAXk@Xm@`AoBlByDrE}IjAmCHS`E_J~c@u~@BGBAlEaJ`GaMDIDGR]Te@Ti@b@}@P_@p@uAf@eA`AsB`AsBd@eATc@\\u@fA_CbAwBj@kA\\w@@ATg@JQ`@s@jAoClDyG~AeDrEiJjAeC`CaFtBeElAeCTc@zC{GxBqEnAyCzAeDnAuCvBkFpBcFxB_GxAyDL]f@oAn@wB\\qAbC}Hj@eBDOBItBaH~@kDdAaEj@wBh@uBzBcJ~D{OzAmGrCyKhD{M`DiL\\cBRu@?AFUbDqLvAwEPa@N]jAuCb@aAJWzBwE@Cn@oA~@gBt@qAh@{@PYrB}CbB{BdCaD?A`@g@DGd@m@FGdAoAr@_ArAaBnAwARWBAZa@b@i@RYRWTWX]`@m@z@kAbAqAJQNWT_@LSHMT_@@Ab@u@b@s@n@eAj@cADIh@gAlB_EhAgCv@qBN]HWzAgFt@yBTq@XkAv@_DPs@Lu@~AmHZsBHu@n@uE^wCr@kGJq@BK@IFYv@qGTeBNaAVsAXmCR}AXeCHm@Dc@ZiCToBLmAf@sDZyBTkBBWLw@XwBHi@h@uEX_Cj@qENaAt@wFFg@BWJeAD[j@qEj@cG?SJeAFyALeC?C@qBFkC@aFGgCEwDO{DUgDUaD]}Ce@}Cc@wCWcBYqAgG}TcCiH}DsL}BmH{@aDwAyGmA{G{@{Hc@wEYiEOsF?uG@iFP{JBmADsADkBHuEJyF?UHcFDeCN_ELoEFqBDsCDmBFcDH}DJqH\\qONwF@S?SLuER{IPiJXyO?qALsFNcEL_G@K?CHoFF{CBw@@]^wSRmK?AT{IHuDhAoi@x@wWjAgRlAaQ~@_JtBgQZkCf@cDF[BM@M`BaKpCqOjCoLFYn@sCtB{I~B}IPq@V{@zDqM@E?Ad@qAn@qBd@uAf@wAv@{Bp@gBf@sAt@yBz@yBj@yA?AN]pCyGhAmCz@mBBElBkE~AmDVe@nn@}qAxDgIPc@hEcJdDcHzEeK~CyGf@aA`E{IdCiFhCsFbEwId@cAhCoFBGLYlAiCrFsLvEeKrD_IxByE|DkIdE{I`CiFDI`AwBvAwCvB{ErCyFFOhDiHvCgGz@iBP_@BCr@{AHOjA_CrAmCfAuBpAwBdAeBhAaBdB_CrA_B`BkBxA{AdBeB`BuArBgB^YdAw@hAy@rA{@pCeBhCsA\\Q\\Q`Bw@rB{@hBu@vAi@`@QnJsCr@OdAUhCi@xFiAdDq@`Cg@^IlCi@jBa@@?HCBAPEnA[t@WlA[tDoA|@YxB{@xB_AlAi@~@c@nCyAlAq@`DsBpEiDxCeCxAwA`BiB'
                     },
                     'start_location' : {
                        'lat' : -6.2474568,
                        'lng' : 106.88064
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1366
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 55
                     },
                     'end_location' : {
                        'lat' : -6.4274855,
                        'lng' : 107.4249133
                     },
                     'html_instructions' : 'Tetap di \u003cb\u003ekiri\u003c/b\u003e untuk terus menuju \u003cb\u003eJl. Tol Cipularang\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'maneuver' : 'keep-left',
                     'polyline' : {
                        'points' : 'jrdf@eesnSd@s@~AuBr@cAl@{Al@mBNu@F[@I@EPkAPiAPy@X}@Vo@r@gAh@g@x@m@vB{@rA]B?RETGNCrAYJErAUJChC]nBUp@GhAI`@Cr@Cx@C^Aj@?lB?@?r@?Z?'
                     },
                     'start_location' : {
                        'lat' : -6.4184588,
                        'lng' : 107.418593
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '54,5 km',
                        'value' : 54460
                     },
                     'duration' : {
                        'text' : '37 menit',
                        'value' : 2198
                     },
                     'end_location' : {
                        'lat' : -6.8554819,
                        'lng' : 107.5049509
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Tol Cipularang\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'xjff@ultnSP?vDCfABb@?v@B`ADzBJxGLhBC|@C`DIxAGzCOvAI`AGpAMxBUzFy@hCa@hEy@p@Kz@QbDw@xAc@nBs@ZK|@[zB_AxCyAbDeBfD_CxBkBxAiAjAu@PM|EmCv@e@rBiAtBeAlCgAn@UzCgAnDgAfEiAlCq@dCs@nCeAlDoBdCiBbC{BzBkCtCkEfAaBfAuAdBqB|@}@hBcBpBeBbCqBpB{AhAw@ROBCNIt@g@tBsA`Ak@vCcBnDiBxBcA~BcA`C}@dBo@|Bw@rDeA`AWxA_@~Cs@|E_AdBWtB[~@KhCWjCUbEUpDSlDIfAC|A?nCAbA?t@@X@fEJvDP`AF`BJdD\\vANL@LBRB@@hB^pA\\|Ad@tAd@HFnAd@vAb@dBj@rBn@rDx@RDTDTFj@JrDf@fEXbG^`AHv@JhBVZHtBf@fA^|@ZTJz@^`B|@v@f@LJh@\\hBrA~AjAbAp@t@f@rAn@r@ZfBv@xAl@^NPHbAZhA^bBb@vAZb@JNBRB|@JtBPjCN`ELhBLhBLtAP|AZ|A^z@XjA^fAf@|@`@n@ZtAr@tAr@~@`@rAh@dAZzBh@zAXpB\\`BP`AFhAFZ?|@B`A?j@?lEEfB@T?jBDnCPnAHjANn@Jn@Lp@LdAVhAZl@PFBjFrBvHhDpD~A`A\\l@Rf@L^Lr@P|@PbBXdCZnBPfDLzB@`@?dFDtFJrDFfDLlDHhDNlFT`DLlDJtDFdD@dCBdBFvBZbATz@Xn@Tr@Xx@^r@ZjBbA`CnArAr@bDfBpBjAbAd@~Av@bF~BrDvAlBr@bCx@nCt@nAZ`Cj@lB^rB\\|ATvAPtANdCVnF^rG`@bEVrBNnBDhBBbBAfCGTA`AEXC@?\\An@ElBQ~@OjDk@tEgAv@WPENG~@YDCFCRIxAm@~Aq@zDwBvA_AdBoAp@m@bA{@nAmAfBiBrBkC`CwCr@aAT[hAsA~A{Av@o@|AkAbAo@nAo@bBq@`Bk@fCk@|AW`AK|@Ir@C`ACbAAt@?hA@f@@z@Bl@D`AJjAPt@Nl@Pl@R`Cz@nAb@pBr@xBr@PFPF@?RHd@LrA`@`Bd@bBd@hAXRD`@HD@ZFTDrAZxCl@|ATdC^l@HtBTvARnBZRB^FNBj@FnANlANvBR|BXpBZzB`@pCl@~Cv@vCz@pBh@~@XHB@?FB`AXnA`@rBv@hAb@jE~Ab@PtCpArCvAjGfDrCzAnBdA|BrAnBnAhBhAlAv@h@^rAv@VNz@h@n@\\h@X`@Pd@Td@Nt@Tf@NXH^FrB^fANPDjAJbAHh@Dx@Df@@h@Bh@?hB@T?V?VAZCh@Cf@Ef@Ej@GzDi@lAO`@GfAMrBSzBOxCMfBIzCIzCKl@?n@?fA?fB?z@@h@Af@AbACx@C|@EpAGjDSLA~@EdBKfAGv@Ef@E^C^Cf@Gf@GxC_@`D]PClAQp@Ip@Kn@KzA[~@SxBk@hCm@xA[|A[t@Op@Ip@IdAMp@Gn@Eb@Cn@Ct@En@C\\CRAb@E\\Gd@If@KXIVKXKXMXOVOVQZSRQTQTWJIBEPOJOLQjAyAj@s@b@g@d@c@ZWDENKb@W`@Ud@U^OVIRGBAREt@Of@G^I`@ItBa@~@Qv@Mh@Ib@E\\Cp@CpEW`@Af@?jAAtAB`ABnAF~@J|@LZFb@Hv@Pl@PZJNDj@PLDZHhA\\rAh@rHtClBh@`BRxCPjCEfBYl@KnA]`@KzBaAPIx@k@v@k@bAaAfAoAp@iAh@eAPc@Vw@Jc@XqAr@uEf@}CNy@Jc@Lg@FYHWDO@EHS@EDMHSFSFOFMFMFQHQHSHQFKLWJQFOJOFMHKHMFKHKHMDGDGDGFGFMJKHMJKHKLMHKNQRSLONOPQZ[h@e@l@g@pAsAh@k@FGxAwA^_@\\]l@m@h@i@XY\\_@TU\\]XW^a@^]XY\\YX[d@c@d@g@f@c@VUPQJIBANM`@[\\UVMROVMVMTKRKRIZKZKd@O\\Ih@Mn@M`@G\\E`@E\\A\\C`@A`@?b@AV@VAV@T@X@ZBZD\\D^D^Fr@N\\H^JVFf@Pp@T^LPHj@R`@N^L\\L^L\\Lf@NZLZJZNr@Tj@Pf@Lj@Nj@Nb@Hp@Lf@Jp@Ln@Lf@Hd@Jx@Lb@H^D^Ht@JXDXBb@DLBx@J|ANtARlAJh@Bd@Dp@Dv@Bn@Fl@Fj@D^Dh@Fb@Fb@F^FRBXF\\F`@H`@H^Fl@N~@Xf@NZJZJd@P`@LD@ZJ`@Jh@Nf@Lh@Nd@Lr@Nd@J^Jb@Jl@Ll@Lt@NJBJBr@Lh@J`@Hd@Hb@Hh@JTDvGhAZDfE^J@\\BB@p@HvGt@pBXlWrClOjBlBT~Ch@xA\\d@LtC|@bCr@|@Vt@PzCh@VFbGrAd@J|Bd@pAT|@LxARfCTzCNdCBvCCxAEdDMbCQzD[hF[fESnQcBfAKdBQtIcA`CY`@ItDs@lBY?AbHuAzNqDp@QpA[@?HClF{AdJwCbAc@dAc@bA_@v@UbAUbBW|@IhBEnBBfBHlBRrAFh@B@?j@Bl@DlCHn@@j@?tCIbDQbAMPAHAXE`AKfDg@hBg@LElA_@dBk@hHwCxAm@BAx@[PIf@Uf@Qb@O`AU`AUhB[|ASzBQnBCxABbCNhAHzAHpBNnBL`AFzBHdFAp@Ax@ClAGfAKtAUrAQjAO|@MXE|@KjBKr@CdCGtFAl@@d@?B?b@@xBBjG?jELf@@N@V?rFV|EJnGD~BA`CUvBWjDa@bE]lAIFA`@Cl@AzA?fBB~@BL@XBhANv@LvARZBb@DlAJbBNlCVfBPrBTr@HXDXDX@`ADlB@jB?pDEX?TATAT?r@EjAGdAGn@Ir@Iz@OZELEVGd@Op@Ur@Yr@[\\ORKJEb@Sd@U~@c@LIt@_@x@c@zAw@BAv@_@lBy@t@Yd@Qh@Ot@U~@Wr@O|@Up@On@Kt@Mn@Ij@GdBMdAG|@C|@C|AC^Ax@Cr@AV?h@Aj@CTCb@CjAOz@KdAUp@Ml@OTG`A[`A]z@]p@Yx@a@v@g@z@k@x@k@v@m@HGf@c@bBwAxBsBPO@?NOtBwBfBqBh@o@z@eAp@{@pAaBf@s@LS@CPU\\g@bAwA`A_B`AeB`AoBZu@`@gAL_@Le@Nu@PeADi@Hs@Dq@DgADw@@e@@UFwADkADqAFiAHyAHqAH}@Hw@JaAPqATkBRuAXiBV{APgAXqBTqAFYH]Ja@\\uA\\gAb@oAb@kAf@qAd@eAp@_Bb@aAf@gA|@kBr@wAn@kAv@wAb@u@j@aAh@_Al@_Af@u@lDaFlAaBhAaBr@eAhA_Bd@q@Xa@pBiCbDaEBCRUPSd@g@pBuBfGyFnAeADCZWXSpB_BhBsAj@c@fBwA?Ab@_@VW|@y@h@g@p@s@jAsAnAaBl@{@|AyBj@_ApA{BbBuC^k@^m@b@m@^e@b@g@b@c@h@e@t@o@`@Y\\Uj@[j@[@?TMJEDCVKHCdAa@v@Wv@Wt@WfAa@RIZMf@Up@]d@Wp@a@j@]VSJIh@c@HGb@c@BCpAqAn@q@j@m@jAoA|@y@t@k@v@i@vA{@HGt@a@x@c@jAk@RKnDkBvAw@z@i@BC~@k@v@g@JIf@_@|@q@~AsAtAoAfAmAnDqENUvAkBvDiFhAgB|BmDlBcDzAkCp@mAdB_DBEfBkCz@aAPQb@c@XY@ATW~@y@|@u@~AgAl@]x@e@fAg@fBo@hBi@fAYJE`AQXGjASbAMp@Il@ChAEd@C~DBtBBhEHR?V@B?nBFf@?D@p@@L@@?l@@P@H?|CPxKv@P@VBF?H@RBB?|ALlEX'
                     },
                     'start_location' : {
                        'lat' : -6.4274855,
                        'lng' : 107.4249133
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,8 km',
                        'value' : 5780
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 233
                     },
                     'end_location' : {
                        'lat' : -6.8980918,
                        'lng' : 107.5323609
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Tol Padaleunyi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'v}yh@}`doSfAF`FNhGK\\CN?@?~Ja@|JuA~A_@LEB?FCzD}@f@Of@QtG}BdDyA~BiAdHkEtEmDNKfAu@xOyKjA{@`@YpIcGtFmDvFeDl@_@p@_@lGsDlAs@fGqDlBcAvAw@fGsDHEb@WzCcBxCaBfHaE~D_CRMHEdE_Cf@]pBqA|BmBJKfA}@pAoA~BkCfBkBzB}ChAgBl@cANWBEHONW`BwCx@qAvBwCbAiANODEFGX[|BuBhCoBhCcB|Au@'
                     },
                     'start_location' : {
                        'lat' : -6.8554819,
                        'lng' : 107.5049509
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,1 km',
                        'value' : 5126
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 258
                     },
                     'end_location' : {
                        'lat' : -6.890384,
                        'lng' : 107.5747527
                     },
                     'html_instructions' : 'Keluar ke \u003cb\u003eJl. Tol Pasteur\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'maneuver' : 'ramp-left',
                     'polyline' : {
                        'points' : '`hbi@glioSbA{@VQXSZWVUXY^m@Xk@Rs@He@Fc@Fe@@e@?]AW?O@G?A?C?A@CBAGo@KeA]yBAA?A[eCi@}GAMAIqAoLg@kDQiAS{@aAsCGSQ_@_AcByBeDoCiDSU_AkAoBaCeD}DsBkCiAyA}AuBkBwC}@{A]k@S[CICECEGGAEAAWa@]m@}BaFeCyFCEIOS_@Wi@Ue@c@eAAEACCGM[]_Ai@wAAGGSAACKK_@GQYoAg@kCW{AU{AQaBKqAAIOyBGyAGgBAiC?Q?]?A@Y@_AFcBLsBRsBP_Bv@mGP_BHq@Jw@@Kj@uEnAcKt@_GVsBF]tA{LZoC'
                     },
                     'start_location' : {
                        'lat' : -6.8980918,
                        'lng' : 107.5323609
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,1 km',
                        'value' : 2063
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 289
                     },
                     'end_location' : {
                        'lat' : -6.8969407,
                        'lng' : 107.5917854
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Dr. Djunjunan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'zw`i@euqoSv@aGR{A@K?CBQ^oCd@sDJm@f@uBHYh@aBN[BIBGXcA^yARgABY@i@@g@D[DW@U?M@O?_@CS?ICa@EsA?S?EBoA?C@a@Fm@@UVyABM\\gALc@DMd@cAT]BEl@aABEFKr@aAnAqB\\c@l@{@HMZa@Ve@HMHMJOjAeB\\g@p@gALWP_@t@}AFMJYNYHWp@{AHS`@}@^{@JW'
                     },
                     'start_location' : {
                        'lat' : -6.890384,
                        'lng' : 107.5747527
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 231
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 19
                     },
                     'end_location' : {
                        'lat' : -6.8981607,
                        'lng' : 107.5934622
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Layang Pasupati\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'z`bi@u_uoSDIDIP]f@cA^s@DGb@q@@A`BgB'
                     },
                     'start_location' : {
                        'lat' : -6.8969407,
                        'lng' : 107.5917854
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 512
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 87
                     },
                     'end_location' : {
                        'lat' : -6.9001733,
                        'lng' : 107.5974351
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Pasirkaliki\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'nhbi@cjuoSBODKDGnA}ANQf@m@`@c@b@g@X_@FGV]@A`@k@Tg@Ri@Nk@Ji@BYDg@@OBg@?s@?o@?S'
                     },
                     'start_location' : {
                        'lat' : -6.8981607,
                        'lng' : 107.5934622
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 702
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 178
                     },
                     'end_location' : {
                        'lat' : -6.9064795,
                        'lng' : 107.5975854
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Pasirkaliki\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`ubi@_cvoSH?B?J?B?H?h@AdBAPDfDCx@Az@AlCEbCEtDEH?hAAF?d@AzDA'
                     },
                     'start_location' : {
                        'lat' : -6.9001733,
                        'lng' : 107.5974351
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 762
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 73
                     },
                     'end_location' : {
                        'lat' : -6.9071507,
                        'lng' : 107.6044415
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Pajajaran\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'n|ci@}cvoSLq@Ha@H_@BW@W@O@_@LsA@YFgAJyD@]DgB@S?E?U@a@XsF@_A?EFmCDuB'
                     },
                     'start_location' : {
                        'lat' : -6.9064795,
                        'lng' : 107.5975854
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 619
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 64
                     },
                     'end_location' : {
                        'lat' : -6.912654799999999,
                        'lng' : 107.6039627
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Cicendo\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 't`di@wnwoSdBC^?jBC@?pA?@?\\@R@NB^Ht@TNBZHf@HTBVBn@BrADvENv@BtA@'
                     },
                     'start_location' : {
                        'lat' : -6.9071507,
                        'lng' : 107.6044415
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '80 m',
                        'value' : 80
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 10
                     },
                     'end_location' : {
                        'lat' : -6.9127402,
                        'lng' : 107.6046865
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Cicendo\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`cei@wkwoSPqC'
                     },
                     'start_location' : {
                        'lat' : -6.912654799999999,
                        'lng' : 107.6039627
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 556
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 77
                     },
                     'end_location' : {
                        'lat' : -6.9141784,
                        'lng' : 107.6076387
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Kebon Jukut\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rcei@ipwoSxDHjBH\\BFAD?DCDGDYRaDZmE@YAQCIGG[KOKGMGQOWM[AEK]'
                     },
                     'start_location' : {
                        'lat' : -6.9127402,
                        'lng' : 107.6046865
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 152
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 23
                     },
                     'end_location' : {
                        'lat' : -6.913854600000001,
                        'lng' : 107.60895
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Perintis Kemerdekaan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rlei@wbxoSO]GQK[IYI[Ge@Ag@A_@@U'
                     },
                     'start_location' : {
                        'lat' : -6.9141784,
                        'lng' : 107.6076387
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 171
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 32
                     },
                     'end_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'html_instructions' : 'Di bundaran, ambil jalan keluar \u003cb\u003eke-2\u003c/b\u003e menuju \u003cb\u003eJl. Braga\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'pjei@}jxoSA?A??AA??AA??AA??A?A?A?A?A?A@??A@??A@?@?@?@?@?@??@@??@@??@@@?@?@p@@|BD`A?D?D@'
                     },
                     'start_location' : {
                        'lat' : -6.913854600000001,
                        'lng' : 107.60895
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '83 m',
                        'value' : 83
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 28
                     },
                     'end_location' : {
                        'lat' : -6.915076,
                        'lng' : 107.6082096
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Viaduct\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kanan.\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zrei@}jxoSIjAEf@AHAT'
                     },
                     'start_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '123 km',
                  'value' : 123273
               },
               'duration' : {
                  'text' : '2 jam 9 menit',
                  'value' : 7716
               },
               'end_address' : 'Ciamis, Jawa Barat, Indonesia',
               'end_location' : {
                  'lat' : -7.326177299999999,
                  'lng' : 108.3541123
               },
               'start_address' : 'Bandung, Jawa Barat, Indonesia',
               'start_location' : {
                  'lat' : -6.915076,
                  'lng' : 107.6082096
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '83 m',
                        'value' : 83
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 10
                     },
                     'end_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etimur\u003c/b\u003e di \u003cb\u003eJl. Viaduct\u003c/b\u003e menuju \u003cb\u003eJl. Braga\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'frei@ifxoS@U@IDg@HkA'
                     },
                     'start_location' : {
                        'lat' : -6.915076,
                        'lng' : 107.6082096
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 120
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 48
                     },
                     'end_location' : {
                        'lat' : -6.916245,
                        'lng' : 107.6089453
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Braga\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zrei@}jxoS^@hCDL?J?NG'
                     },
                     'start_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 128
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -6.9165211,
                        'lng' : 107.6100336
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Merdeka\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'nyei@}jxoSCGCE?G?G?GBIz@gD'
                     },
                     'start_location' : {
                        'lat' : -6.916245,
                        'lng' : 107.6089453
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 232
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 30
                     },
                     'end_location' : {
                        'lat' : -6.9175137,
                        'lng' : 107.6118848
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Lembong\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f{ei@uqxoSJSNa@~@{B^y@JSXw@b@y@'
                     },
                     'start_location' : {
                        'lat' : -6.9165211,
                        'lng' : 107.6100336
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 507
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 89
                     },
                     'end_location' : {
                        'lat' : -6.921816199999999,
                        'lng' : 107.6119103
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Tamblong Dalam\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'lafi@g}xoSFG\\k@NWFGFENC^@^DLC~@@@?p@FlBJf@DfBNF?zBPH?xDT'
                     },
                     'start_location' : {
                        'lat' : -6.9175137,
                        'lng' : 107.6118848
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,3 km',
                        'value' : 1293
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 177
                     },
                     'end_location' : {
                        'lat' : -6.9324369,
                        'lng' : 107.611391
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Lengkong Besar\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'j|fi@m}xoSvAHP@p@B~AHr@@rAH|DRJ?P?R?DAB?LEl@Up@a@x@o@j@k@ZYVUd@a@d@[TKTE`@E~@Hb@BrCDhDFr@Ap@BB?nBHT@R@RD`@PNHHDtA~@`Ah@zBlBXV@B@@@@@B'
                     },
                     'start_location' : {
                        'lat' : -6.921816199999999,
                        'lng' : 107.6119103
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 528
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 71
                     },
                     'end_location' : {
                        'lat' : -6.9318523,
                        'lng' : 107.6066487
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Ibu Inggit Garnasih\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'v~hi@ezxoSCZIdB?DQfCSzA[bFKzBE~@Ez@MjB'
                     },
                     'start_location' : {
                        'lat' : -6.9324369,
                        'lng' : 107.611391
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,8 km',
                        'value' : 2776
                     },
                     'duration' : {
                        'text' : '9 menit',
                        'value' : 547
                     },
                     'end_location' : {
                        'lat' : -6.9558538,
                        'lng' : 107.6119115
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Moh. Toha\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`{hi@q|woSbBHzAD`@B\\BzCNxBJ\\?bADxADlBBj@BZ@N@|ABH?ZBR?x@?RDnAFhA@Z@NAH?@ARENC|Bi@@A`ASRGfCg@r@SHCZGjCq@B?PEfAUj@MJCPEVGFA`@KBAj@MDAd@KPElAYp@OhAY`@M^IZGz@Sj@O\\INEFAXIVGFATG`@Kd@KpBc@~@W@?`@Mf@MRINCDAv@SRGv@MTAR?XKFAbA[ZKh@QpA]ZI\\I`@ItA]j@MrA]l@MHCh@IfAUh@O~@WLEv@QXGb@KTG^KXGn@M@AfB_@h@Kv@QLCTGb@KXIDA'
                     },
                     'start_location' : {
                        'lat' : -6.9318523,
                        'lng' : 107.6066487
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 784
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 95
                     },
                     'end_location' : {
                        'lat' : -6.9593481,
                        'lng' : 107.6062276
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Tol\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol sebagian\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '`qmi@m}xoSBD~@|DNp@Lf@p@zCz@zDTdAZlAXz@`@x@RZZ`@HL@?FFfAz@|@d@bBh@nAN'
                     },
                     'start_location' : {
                        'lat' : -6.9558538,
                        'lng' : 107.6119115
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '17,2 km',
                        'value' : 17221
                     },
                     'duration' : {
                        'text' : '13 menit',
                        'value' : 779
                     },
                     'end_location' : {
                        'lat' : -6.9425948,
                        'lng' : 107.7533701
                     },
                     'html_instructions' : 'Tetap di \u003cb\u003ekiri\u003c/b\u003e di pertigaan dan bergabung ke \u003cb\u003eJl. Tol Padaleunyi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan tol\u003c/div\u003e',
                     'maneuver' : 'fork-left',
                     'polyline' : {
                        'points' : '|fni@}ywoSFAB?vAEZEr@Sh@UXQTQTWRWb@}@T}@J{@GkBK}DOqHWqJKaDAUAU?A?AAE?EEsACoAKqEBcBXwD`@gDh@aDd@mBv@mCBGh@cBDOTw@x@}BbBgFXy@^uAf@gBd@sBf@aCd@iC^cC\\iCRwBPwBPeCTmDFsAfAeQ?M@E?A@Mx@oL@W?E@G@EFwAVaEJaBBYB]HkANgCLmC@eBAkDAw@SsDUsC_@sCMo@e@}B[}AO{@g@kDM_AKkAKyAGqAGqCDuD@CVkFTkC^oEj@gGn@wH^oEDg@b@eFXuC^kDx@qFbA_G@CF]l@uCf@}CRgBHaAf@{K?CAOAaGGqDC]A_@Aa@Aa@Aa@?e@?k@?y@@q@?a@Bu@B{@Bi@Z{FjA}VXoG?K?G@I?KZ{F@QPcDTuEh@yKFmBn@yM@KB_@DcAFcAFsAFkADmAFeAD}@HgBFkAD}@HsAHeBFgBHgB@{@FuD@mBA}CIaFO}Da@oFYqDq@_Fa@gCSqAm@}CgA{EkBoGGOIUGUGO}@gCAC?CA?c@oAaB{DaDqHACEI}BuFcI{Q}FcNmAwCISYq@aCwFyCiHqCoGoFcMiAmCaD{Hw@gBuAaDi@oAk@qAaDuHUg@Se@g@oA_AsBc@eA_AyBoDcIoDaIaCkF}D{IO]ISYm@EIeByDSe@EKYm@[q@cAyBwBaFEIWm@{@mBcB}DWi@Yu@uBoFwBgGm@mBSs@oAcEWk@k@gAg@mA]}@YaAK[Km@Eg@Ko@YeBMa@e@eBCIg@sAUo@Qc@_A{BQ_@_@m@GMISIU'
                     },
                     'start_location' : {
                        'lat' : -6.9593481,
                        'lng' : 107.6062276
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 206
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 23
                     },
                     'end_location' : {
                        'lat' : -6.9417417,
                        'lng' : 107.7550297
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Bandung-Garut ByPass Cicalengka\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'd~ji@qqtpSUu@[{@mBgEIQ'
                     },
                     'start_location' : {
                        'lat' : -6.9425948,
                        'lng' : 107.7533701
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '21,2 km',
                        'value' : 21177
                     },
                     'duration' : {
                        'text' : '23 menit',
                        'value' : 1407
                     },
                     'end_location' : {
                        'lat' : -7.0370214,
                        'lng' : 107.9076685
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Nagreg Cicalengka/Jl. Raya Bandung-Garut ByPass Cicalengka\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Raya Bandung-Garut ByPass Cicalengka\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zxji@}{tpSPg@bA{@l@i@|@y@bHqGFEt@s@TQRMVKXGn@KhAMl@GXCXGPGPIJGHGNOFI~@gAp@y@zAgBRWHKfAqAlEqFnGoHz@iA\\i@LWBEXq@BQDWLUJOHMFINOLKdA{@l@c@tAcAj@m@NOb@g@Zc@LUL]La@Lm@d@oBt@mDHa@Ry@\\{ALw@f@yBLo@F[VaANm@H[l@iCpAcGPq@Pw@Nk@l@qCb@}BFQ?A^mAFWBS@MC]?CEo@?m@@k@Fc@Le@HMf@m@LOLKRWLUPm@Lk@Nq@b@kBl@yC@C^_Bh@aCRy@TaAFSf@yBl@aCVgAPs@ZuAH]hAiFPw@@ETcAJg@`@gBBONm@d@kBNo@XoA~@eEbAyERu@VcAPs@tAmGVcAbAgEl@kC@AZ}AFUNm@d@oBViA@I@?ZwAXoAj@}BXuAZkAd@qBHc@Tw@?CDWHi@BWXgDPiBViCPiBXcDHo@Fo@Z{CPgB`@}DB]LyAFw@TeC@c@JoANiBB]TuCHgA?IPuC?]@E?c@@w@@M?S@I@[?E?U@G?E@y@@a@Bc@@m@?I?EFyB@Q?k@?KFkB@c@@eAByA@YBkC?CJaFJ}E?EBs@@_@RgNHeDBu@@e@?_@E]Mk@Oc@CGAICS?U?KBc@TcBFa@\\iDBo@DsCFaA@y@Cm@KeBCu@@a@?EDu@TyCBqAD}@No@Ri@zAcBrA{A^a@f@u@Rm@Lo@Lo@P_ALm@Ng@LYLSNQf@c@^Wr@Y|Ae@b@QTKd@YVQp@m@`AkA^]tBgBnA_AnB_BfA{@b@_@pAkAj@a@rBqBhAaAb@a@r@e@hAm@rDsBlA{@t@k@z@q@dA{@dA}@LMzAoArBcBzCoCfAaAHG`BaBt@u@r@s@@?LOLMfAaAb@_@\\Wj@[\\Q\\QLG|C_BhAm@bBy@~DuBz@a@xBcA@AlBcAdB}@xBgAf@UJEhEcBdAc@n@Y^O`Bi@bFoBlC_AdBs@`@W~@{@l@{@LQ@AXa@\\i@`A{At@oALSx@wAVa@Va@l@{@R[f@a@HEbAk@RIhA_@DCLENEd@OHEvBu@lBo@z@U|@[bE{AZOHCNGPMROp@{@DE^g@JMXa@t@cAr@u@JSDI@AViAHQTs@LWJUHK@AHKXUFEn@g@^S|Aw@zAi@DChAa@ZOROPMf@e@RWT_@j@gA`@gABM`@eB|@mCVy@t@gBf@kA`AsBBUFMBEd@y@FM\\m@b@_AJUN[h@uAr@aBn@eBXm@^m@\\e@DEv@kALSf@}@HQDIrAcDN_@Pc@FKLYTc@DIdA_BNUbAsA|@eAj@}@d@w@Ve@^u@FM`@u@dA{Bl@mA`@y@fBuDZs@BCN_@dA_C`BkD\\s@|B_F`AwBJUZq@P]pAwCj@mAFMjC}FBG`@}@BEtAwCt@_B|@kBJWFKL[p@yADI|@oB?AR_@h@iAHQRc@BGXs@JUZu@\\aAPu@ReA?AHi@Da@BSDi@@OF}@Hw@Jk@Ny@V}@T{@BK\\aAF]B[?A@WAI?K?G?M?E?ABQBKFQBCHOTWV[r@y@f@k@h@k@\\[l@e@p@_@RMhAm@PKBCL?v@e@l@_@`@U~@u@BCJK^_@^c@\\g@T]R[`@u@P]VWTOb@ORCZETAXE\\IXSNWPWTOVO^Kd@Cf@@\\A\\CLEFIFGDGBE@E@E@CBEJa@Fc@BQDUPaBFq@F{@BMBa@BOBGBCDEJIPKd@Ub@OLENEPININMJKHMFILYXy@\\aARYJSZ[VMr@g@\\MPCT?RCPCVKNQJMHKb@a@RSRO^Yz@W\\Kf@GZENAPEJCJEJIHILSJMBGDKLWNQnAsA@AXWZg@d@m@f@i@JMHM\\k@T]^a@X]Le@Fa@Fg@Rk@Pg@HQFGLOFGRKVKl@Sb@M|@['
                     },
                     'start_location' : {
                        'lat' : -6.9417417,
                        'lng' : 107.7550297
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,8 km',
                        'value' : 4752
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 267
                     },
                     'end_location' : {
                        'lat' : -7.041761999999999,
                        'lng' : 107.9455269
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Nagreg/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'jl}i@}urqSp@a@XSRMRWHOJSDMJWBQBQDU@W?[ASASAIEKGUEKM[GOSg@GSOYSe@GUIYIYASCW?m@F{@DYFg@BSD[BWBWDUDa@@SBg@B]Bc@D_@Dg@Dk@Fw@Ds@?[Ai@Ec@AGAGGQIWI[EQCUAQCi@CuAEaBGcCI{Ce@kFUwBMwC@uBFq@BYBSDYD_@Bc@DQ@SA[O[[[Wc@U[Kc@SaAGkACg@GeBMwBE}AOsCAcB?aBAe@B}B?}BLoB@SRcBb@kCf@uCTsAPkAB[@_@@ED}AHcBB}@LsAHgALkARsAZaBT{@Le@Ha@Hc@D[@Y@WA]Ai@Ec@G]IQIKc@c@e@i@a@WQQg@]UYSUMQIMEKEQA_@@YDQDIFKDILKHKPOLIZOVMJCNEVEJAJCDCDEBI@ABEFIDMFODI@MBMHUDIBEDIPSDIFGDCDCBAB?D?R?F?h@A`@Ed@GB?DABCDAEhA@@@?@?DAPWFGJGJEJEJELGHCb@ITGHGLILMHKDIFMBQ@U?c@?SBODUDOFQL]FQHUDSPaABW@UBYBUDSDOHQJKFEFGr@[bAk@\\SJKDIDIBI?G@SBa@'
                     },
                     'start_location' : {
                        'lat' : -7.0370214,
                        'lng' : 107.9076685
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,7 km',
                        'value' : 3698
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 239
                     },
                     'end_location' : {
                        'lat' : -7.0380916,
                        'lng' : 107.9769187
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eLimbangan Barat\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~i~i@qbzqSbBc@l@OVMJGDEHGBIDGBI@I?C?KCOEUOe@w@aCSw@C_@?MBQDMLW`@kATi@\\u@Tc@`@}@|@iBJYHWfAyEHg@BI?I@K?KA]IiASaCYqCQoBi@kKOoBMoAOyAGi@MgAEWi@wF_AcMWyCwA}L_AeJ]mEAWYeDKkAWaCSgBW_CGo@AMY}BAEc@sCMu@Ou@{@eCmBsDeAqB_FmJ'
                     },
                     'start_location' : {
                        'lat' : -7.041761999999999,
                        'lng' : 107.9455269
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,1 km',
                        'value' : 4051
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 299
                     },
                     'end_location' : {
                        'lat' : -7.0445623,
                        'lng' : 107.9946129
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eBlubur Limbangan/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : '`s}i@wf`rSiBcDC[C]GYEMEKGKEKOUQSQSw@kAq@u@CCCCEICCCCCCAA?AA?AAA?CA_@Q{@]SKyBgAqAu@ECGCECEEEEEGAACCACAC?CAAAG?E?GAK?ML}FBmGF_DBoH_@e@Y[Y[MQMQEIEKCICKAIAI?I?K@I@I@IBIDGBIDGFGDEFGFEHCDCDAJCLAJAL?J@L@J@HBHBPJPHPLn@\\n@\\PJRHHBHBHBH@J@H?H?H?HAHCHCHCBABADCBABCBC@A?A@A@C?A@A?C?A?A?C?A?A?CAA?AAC?AAAAAAAAAAAAACCCCGGEIEICICIEUESCU?S?U?]B]F]F[HYHYLWLWPWRYRWTWT_@T_@T_@V[TUHIDCDCt@c@~FbBbBj@hCfAr@Vv@\\b@d@Vb@^nBLdCt@\\dBX|ABbABnA@HDFD\\RXV`@Z\\PXDz@Ml@OCg@@q@y@y@i@m@KUE]Cm@B_@@IBSLWHGHETKHGFMBKCMGUIWOa@Mk@ES?OAM@O@MBOJm@FWLULKLCLAJCJGDMDa@Bm@Iq@IYOWM[Ia@Es@E_BFeBC?KCICGEEKCKEYAk@Bu@T}@'
                     },
                     'start_location' : {
                        'lat' : -7.0380916,
                        'lng' : 107.9769187
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,6 km',
                        'value' : 4610
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 306
                     },
                     'end_location' : {
                        'lat' : -7.0530146,
                        'lng' : 108.0214847
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'n{~i@iucrSxAi@XIPGDGBIBMBWFc@FYJUR_@n@gAFKBO@K?MAO?YEWG]Me@IW[]QUMUEMAMBMDMBIDKLMLKLEJCH@HDR\\PZNJNFj@D|@Bp@?j@?X@ZF~Cn@j@LNBN?HA@AHAJCFKDODO?UCS_@cAG]AYB[H[HMFGHCHCNAJ?L?NBNBRH\\Nx@p@XLN@LCFAHEHEHIXc@BEf@w@PYr@gAx@{@RU\\Ub@Ob@Ib@Gb@CtAAh@C`@Cl@Gf@KvAYTEHEHIDI?I?YCCWICIEGEEGEKEMCWEMCKEKEIGIIKQIQISGYI]E]Ca@?[?[B]B[Da@Fc@BKFOFMJORYZ]h@e@n@k@~@u@zAiAl@a@b@[t@g@XWVWPSJOLUFU@MCMEIGEEEWG[Eq@EUCMEKGSMQMOKOWEIEKCMAKASAi@?o@B{BDiAF_CBc@DIHKJMRQTSNKZi@Re@L_@FUDUBW@WAc@Eo@Cc@AW@QFSHSTc@Xi@FOFQDS@G@G?O?QCOCQIMKMUOSI[Is@K[EQGQIMIMOKSEU@QBSZaCCOKOIOOOe@Wi@[MIEGIOESGYMgBWwCGmAC_A?c@B_@JWLMRCV?TENCHGFEFKFQBSBk@Cw@OaA[}@Se@Yk@g@w@Yg@c@u@Ui@Sa@Sc@S]a@g@'
                     },
                     'start_location' : {
                        'lat' : -7.0445623,
                        'lng' : 107.9946129
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,9 km',
                        'value' : 4931
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 344
                     },
                     'end_location' : {
                        'lat' : -7.054435199999999,
                        'lng' : 108.0502283
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'hp`j@g}hrSJWL]Ps@`@{Ax@}Dh@wCXaBVqAZiATm@\\s@\\u@Xq@EKEIEEEEECICMAOC{@E_@AOEKGEEGIIOOk@UmAK{@Ei@@c@@WB[p@c@x@g@|@g@hAg@x@YjA]r@Of@GV?P?PBPBLDJHLJLJBAL?j@D^?N?LENEJCFEFGDGDGBIBIBIBO@M@KAKAGEIGKSYQg@YcASgAWaBUcBI_A?q@AO@iBFaBD}@@q@Dc@D[?QASEOGIIISIQESCe@AU@SB]Fc@PUJ[N[LODI@Q@S?YGYI_@Qe@YgAy@sAoAkAqAkAcB}@_@g@W]QQMSOMKIOEMCO?_@@]BMBKFMJOZc@t@u@r@k@v@i@BS@S?OAOEUMe@Wu@[}@[sAQy@AQ?OAWBOBSDQFQJSR[V]V]POJILEJCN?TAT?x@@\\?R?RAHCFABCDCBCFI@K@G@E?G?IAGAGI]K[e@_BWu@[g@SUUSUOOKSGQ?U?k@HyAPu@DU@UAIAKGGGGKEQCQ?S@QDOJKHGJEHAR@p@DV@P?J?L@JCLGDIFK@OAOCQEa@AI?MBQBIDIHKHIVQRKNKTSLUJSBMFUBYBS@]?[Aa@?KAWAc@AUGWCe@Ac@wBiBU[MSIUISGg@?[?UBWFUNWHIHGFCHAHGNIHGNINKVIRGTCP?V@ZDXFTHVNPJVP'
                     },
                     'start_location' : {
                        'lat' : -7.0530146,
                        'lng' : 108.0214847
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,9 km',
                        'value' : 3885
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 222
                     },
                     'end_location' : {
                        'lat' : -7.058225999999999,
                        'lng' : 108.0726472
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'fy`j@}pnrS~@Yt@W~@_@pAk@f@QZKZEXE\\EVEPELEDEHKDKDM@Q?K?EAOEGGQOOk@_@MKIIIIGIGMGYCKGIIGGGICIAGAu@ISAc@Ea@AWAGAGAEAEAECECGGACACAAAE?GBGDMVc@f@}@Xq@~@qBn@}APq@D]BWD]FUNm@Lo@F[DOFQHWHQLKLKHILGHGFGDEJQF[BYDs@Jy@Jm@FWFKFGHCJCHARBTHTLPRLRJPDLFVFNFNHJFFFBJBJ@R@L?J?NGHGFGDGJUDK@I@S?UEYCEGGKEQGECIGGCEGCCAGAE?M?KAIAKCKEMEIGIEGMMKEKEEECCCGCGCM?MAUAQCGAICEEIGKGEMIMEQIGCIGEGGGEMCI?G?MBKBIDGLQPSTSTKFELCTCNCPEJEFGDGBGCKMSSUEICGCK@I@GDQHSFUJc@FWDOFWDMFOHMDGBI@IAIAGCKIKKKKIKCOCK?E?E@GBEBEDADCHA\\CNALEFIFMJOHSDQDI?KAKAQKSYS]Mc@Mg@?A?CC_@C[EUISKKYUc@Wo@Ue@U[W_@[]a@GGMQIc@Aa@L_A\\qBViAVcA`@o@\\g@\\_@v@q@z@e@v@Mr@ETCVE\\OVYT_@D]CWK]YYSSIGKSCO@KFUPYXa@JW?ECMGMGOEOAMAO?U?QBk@?W@ODIDIJMBE@E@I?GAGCIEKEKIKGIEMCKCMCMAM?GBIHOJSR[LSJQV['
                     },
                     'start_location' : {
                        'lat' : -7.054435199999999,
                        'lng' : 108.0502283
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,8 km',
                        'value' : 1840
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 109
                     },
                     'end_location' : {
                        'lat' : -7.0607602,
                        'lng' : 108.0869373
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|paj@a}rrSA?E]EYM_AK}@Iu@?AC_@C_@Bk@F_@HWXm@Xe@N_@Bg@D{@C}@?u@@}@FcARqATqAVeAv@aCd@aAdBuB\\[NSLM@EDI@KCIIIGKEKGOEOCQ?Q?UBODWFOJQRSn@]x@c@TMJKBK?E@IGKIKUOUGKCKKGMAO@YHg@H]Ra@NWXWXMXMVKFEFELKXg@Xq@Pi@He@@SAYCKEUIOIMMKSKYMm@[]UEIGIGKGKCKC[D{E'
                     },
                     'start_location' : {
                        'lat' : -7.058225999999999,
                        'lng' : 108.0726472
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '15,8 km',
                        'value' : 15751
                     },
                     'duration' : {
                        'text' : '15 menit',
                        'value' : 879
                     },
                     'end_location' : {
                        'lat' : -7.1583216,
                        'lng' : 108.1472904
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-2 agar tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'v`bj@kvurSx@A|CQtCOhBGN?TALA`@Cf@Eb@KRGbA_@d@S^OxCeBr@_@pAw@nAy@zA{@`DqBp@c@\\OXMv@I`@A~BIfAMh@I`@MXOVIlAW~JmBPEPEHGHEJGNMHIRS^i@v@kAd@w@b@g@NUr@_@ZM`@Ij@Mh@Mj@Sf@Wb@WXYt@s@^]b@a@f@_@b@Yf@[h@[b@MVEl@Mn@AXAJALCtAg@v@]j@[b@YVc@DCpF{C~GgDhGmCtCy@zBa@pCYhAUjASz@e@jC{@x@Sn@I~@Gp@Ap@@|AJxAN~Cj@\\FVF|@P@?nJy@|D|@F?|@MtBc@^E\\G^Op@e@JGXQzAo@lCgBzFgDb@[XUNMbAk@jAe@nAWlAQ@?REtDy@b@Ir@MpEiAv@Qt@W`C}@vAa@hA[r@UfBs@r@WnAa@r@[x@]~BgAf@_@bB_AzBcAvAi@XKt@_@VK@ALGVKNIJIHGJMFG@AHKHOVa@\\i@\\u@b@_AHKDIFIFGJKFGFEDCDADCJALCH?J?R?B?D?FAHCDCJIFKLUL[ZoANm@Hg@Hq@B]@K@IBIBEDIDEFGFEHGJGDCFAF?F?D?D?D@B@DBDBDDDFFHFJL\\HRFTDNBV?N@R?F@H@B?@@B@B@@@@BB@@@?B@F?J?FARENC\\GHCFCFCFE@CBA?C@G?E?GAOAI]wBGg@EWAMAI?I@O?CHk@DSLq@@K@I?K?EAEAK[cAGWCKCM?S@QBQBM?K?SAW?E?C?C?A@C@C?A@EDEBCDCBADC`@If@KLEHEBABADE@E?A@IBKBMBI@EFKJMV]JOBEBIBOD_@?K?M?GEOEKIIKIUIKGIGEICGAMAy@@sAB{@DWFSFIFKFEFCNGLC^AT@N@PDZFv@ZTH`@Lb@LLFJFDDHHFJBFBJBD@J@^Ad@AZCX?PBPBLHT?@FJDFDDD@DBB?F?HAJEJGbAk@PKNKVSPWJWDIBIHg@BS?OAOCUIk@Su@oAyDYw@Ue@AAUYg@i@MOGMGMEGCOAEEUCUAUA_A?e@?QAMEQKg@CUCSCe@E{@E_AAWAO?O@I@KBMFWDM?O?G?EAKCIGMGIOSMQIMUe@KQECGIKGIGCECCAG?I?K@KJWNYRe@BM?GAGAKO]KSEKAEAK?IBOBQNm@f@uBZ_AZo@FKNQJMFE\\]PUJOHUHWDY@KNgBFkABc@@a@AQ?EAKCIGK]k@IOGQEQAMAC?M@SBSLeAZeBFm@D[Du@Bm@?E?k@@S@QBG@E@EFOJUTa@T]Tc@R[j@aAp@uAd@gAh@oAvAcDx@iBj@uAhAmC~AmDXm@Vq@j@wAl@{A^y@l@qAh@qAz@eBl@oARe@p@{AXq@f@wAVu@X}@Nc@Ts@~@{CX}@BGDQL_@Jc@DSF_@Hu@Fm@DYFMJIHCJCB?RATAhB?nC@zB@hAB|ON|A@x@@X?`@@dCChB?\\AnC?f@Ar@@|D?r@@~AAdB@t@?`@?jACx@Gh@Gn@IdAMn@KpB[x@OhAWpBc@fAWBAjAYrCq@dFmAhBc@fAWn@K@?ZEVAP?T?\\?B?X?J?X?~@?vA@|A?Z?f@?fGBtHJfB?hA?fCBH?dGDrD@z@?t@@xCB^@X?r@@|BDH?lC@bF@pBAb@@F?J?vBDPAJAHAHC'
                     },
                     'start_location' : {
                        'lat' : -7.0607602,
                        'lng' : 108.0869373
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,9 km',
                        'value' : 4857
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 260
                     },
                     'end_location' : {
                        'lat' : -7.185046199999999,
                        'lng' : 108.1786118
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'nbuj@qoasSBC?C@C@C?G@KAgF@aB?C?m@?[?[@]@_@@K@K@IBKDMDINYVa@n@cARUDEDEFGBABAFEHCJEHARELAfAIfE_@z@KtASZIp@QdBk@XMv@[JEl@UtAi@FEh@UvAm@TMZQn@]zBmAn@[DEl@YTMHGDK@E@IHaADk@FeAFcAJ{A@CH}@TmCRsBLoAJ}@B[DQJk@H_@Rw@Tu@BGPo@Tq@\\cATm@L[j@yAd@_AP[LUR]^o@j@_ANWDGZc@z@sAf@w@BEb@m@fCmDdAwAlBeCj@y@t@aAz@iAd@m@z@cAv@}@lAsAZ]TYX[Zc@rGiIvJeMxEmGhB_B|@s@z@k@p@_@VMl@Ub@M`@Kx@WLGTG^SZM\\M^Ql@Y`@Sn@[n@a@NKd@_@pAaA`Au@PMtDiCtB_Bv@m@'
                     },
                     'start_location' : {
                        'lat' : -7.1583216,
                        'lng' : 108.1472904
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,5 km',
                        'value' : 1465
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 73
                     },
                     'end_location' : {
                        'lat' : -7.1956266,
                        'lng' : 108.185251
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Pagerageung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pizj@isgsSxAiApBeBxAgAzBkBhAaAt@q@p@o@TQDEr@s@lAmAv@y@pA{Az@mAb@s@p@oAN[Zm@Ve@LQHGRKZM`@IzAK`@AJ?R?rACxBMxBOtCSd@Cp@MbCY`@ELA'
                     },
                     'start_location' : {
                        'lat' : -7.185046199999999,
                        'lng' : 108.1786118
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '28,4 km',
                        'value' : 28378
                     },
                     'duration' : {
                        'text' : '24 menit',
                        'value' : 1425
                     },
                     'end_location' : {
                        'lat' : -7.326177299999999,
                        'lng' : 108.3541123
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eRaya Raja Polah/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kiri.\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'tk|j@y|hsS~@KhBQz@IhAO@?jAOf@Gd@Gj@Kx@OjASfBc@ZKfA[j@UhBs@z@]fBq@hAg@t@[nBy@\\MTIBATCPAl@?f@@v@DpBXbBXtDd@zBPH@`@@XBl@@@?p@?`@AfBSx@ObCk@l@QrA]\\Kd@QNGtAs@b@ShAi@d@UVKz@a@JE^O\\OjBs@JO@CDCPGrBy@lAe@VMr@g@LMJKHIh@e@Z[NODEFG|EiFbDsDxAgBnDaEbBoBf@m@PYHUFODMD]D[@U@s@CiAA}@CcAIeGEoD?Y?S@g@D_@L]?AXk@PUp@i@PKb@UhAi@bAe@HEVK`By@r@W^ITE\\ChECzFGfAApB?|@DV@dBTh@JTDZDD@rB`@@?zBh@lA\\nAb@t@VD@tAf@@@pA^|@X~CfA`EvAD@v@ZvAh@lAb@zBz@p@VzBx@LD`@NbARD@L@B@fAZzBz@VH~@\\f@Pf@Lf@LTDt@RbATtAZt@Ph@Nb@JXHh@NhB`@fEx@jAXvAVvAXfAPLBh@Ff@Hd@Ff@FH@dDh@pBLn@@\\?Z?ZA^?r@CpAE`BGr@Ct@Cx@C`@AJAjAEF?`@A\\A`ACnBG~@CrACr@Ar@Cv@AbA?|@@nABx@@x@BX@d@@|ADzAFp@Bn@Bd@Br@@|@@dB@h@AXAL?JAJ?NAb@ClAMnDk@pBa@LCx@Qr@Mt@KNCt@O|EaAvAY`ASxCm@xFkAbHwAv@QlDa@zD[vAKlWwBfJSTALCRGHEHCpAu@nFmDnFqDHEb@WRKLIJINMLINODCDEJMLQLSJUNg@j@aB`@uAFUh@kBTq@HWJYPc@t@}A@E@An@yAd@_AJUJQXi@bAmBXg@Zo@HMx@{Ap@oA`B{Cv@wA^u@x@}Al@gA@Eh@eAf@aA\\o@BGBCp@oAx@{At@uAv@yAx@}Aj@iANSN[\\s@d@}@r@sAbAmBp@qAh@aAn@kAn@kAfA{A`@q@V_@fA_Bz@mArAcBnAaB`AsA`AqA|EsGh@o@x@iAbAoAn@}@v@cAj@s@dAuAdAyArAaBrAeB~AqB|@oAx@gA`BqB`AmAJKb@m@tAkB|@iA^e@Xa@|@mAx@cAl@y@x@gATY^m@r@iAXc@HO`@{@JUVe@h@kANe@v@yBZ}@HY^eADKPk@z@cCv@aCt@uBb@qA~CgI@EJYl@eBVw@BGrAeELc@Ro@jA_EPm@La@JYzAeFHW~BeIpB_H`ByFNk@x@oCt@eCTu@\\gAdAuDfAyDb@gBNk@DU@IF]Fs@Dm@D]R{@Pk@r@gC?A`@sB@Q?UASQs@i@sAEIGQIUEW?W?K?KD]b@mCj@kD~@gFBQ@GzCuPfCqO~BmNp@aEb@gCV_BBO^sB`@oCR_BNmANuAZmCZ}CB]Fu@Di@@k@Du@?U@}@PaHDmE@mA?cAAc@?]@a@@YDg@Hm@L}@TeAHYFWFUDWDUD]D]De@XuEh@cIBo@De@ZiD@IHqAJ_B@SNw@JaA?GFm@XaCJcBPsBFs@Bi@JaDAa@@w@A}@@aA?G@c@@c@JwBJsAXcEF{@Dm@d@gF^yCf@kDLs@RmArA_Hb@_CTwAHg@F]f@cC|DsSToAx@iE`@oBnA{Gz@kEH_@@Cd@aC?EZ{AJk@~@{EJe@FYvBwLP}@xCwPHe@`@kBd@cCvAaHz@eE^eBBQViA@G`AyDZkAxAkFZgABOTm@dDqKvAaFr@aC~@gDNs@VaAXoARu@XeA^}Ad@sBNo@^cBTkAXsANcAHu@FeANcBDaEF{DC_C?iAAiBE{D?ACwD?mA?a@A}@?EAkDGsJEcE?IEsF?O?kEA_AAwFAaD?GA}@?g@?SAiBA{A?S?yB?]?o@'
                     },
                     'start_location' : {
                        'lat' : -7.1956266,
                        'lng' : 108.185251
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '183 km',
                  'value' : 182796
               },
               'duration' : {
                  'text' : '2 jam 42 menit',
                  'value' : 9719
               },
               'end_address' : 'Kebumen, Jawa Tengah, Indonesia',
               'end_location' : {
                  'lat' : -7.6835906,
                  'lng' : 109.6839983
               },
               'start_address' : 'Ciamis, Jawa Barat, Indonesia',
               'start_location' : {
                  'lat' : -7.326177299999999,
                  'lng' : 108.3541123
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '54,6 km',
                        'value' : 54581
                     },
                     'duration' : {
                        'text' : '47 menit',
                        'value' : 2833
                     },
                     'end_location' : {
                        'lat' : -7.2998872,
                        'lng' : 108.7472946
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etimur\u003c/b\u003e di \u003cb\u003eJl. Jenderal Sudirman/Jl. Nasional 3\u003c/b\u003e menuju \u003cb\u003eJl. Pemuda\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'r{uk@e|itS?sA?SEuI?E?O@qF?I?aDAuCCmFCcD?q@AmC@y@FcHA_A?q@GmAAy@As@CsF?yB?aA?q@?W?g@?q@A{A?w@?[AuD?U?yC?gC?UKkEMiDEyACmAEcA[kHWiFIiFAk@@u@Dk@Bm@Bo@Bo@@[Be@B[D_A@ODw@Fq@Bc@P_BJu@Dg@TcBDYFc@Hg@b@{B@Kb@uBp@mDd@aCp@mDj@gDN{@RuALs@Pu@RaAT}@Rs@Pu@Pu@D[B[Bk@@m@BwABwAB[B]B]LaB^mDLkAJcATaBTyAXcBVwA~@yEDQBKNw@d@wBp@cDNw@bEmSpDoPFWXkAd@uBH_@FmABUNiDN_Cf@uG~@yLj@oHFcARwCr@uLHm@H_@Hi@La@P[L[RYR]Ve@RYZWDEFEJCVGnDk@bM{ArAMHAN@LBPDLFLDJFJFJBH@LBL?HALA`@Q|@i@fAo@NGHENEtB_@x@Oj@Qt@UZO`@U`@WxDmCj@c@h@a@^a@LQHQ@?hA_Cf@mAl@wAJUPQ^[VSjDcCVi@\\_Ap@cDTaBLgAFkAVsEL{CD_AJqABo@?aA?k@?iA?y@GmCGkBAw@EmAEy@?ICcAEk@Gg@Kk@O}AOwAOkAOkAMm@[iBCm@AW@[FyB@OHgBPsCHiBFm@L{@`AkE`@uCN}@ZwBB_@@c@AyBFwC@mAAy@Iq@QcBY{AMm@Ca@Ci@@o@DqB?wA?{@?_@?oADm@Da@J_@Pa@`@o@j@w@V_@Ra@VsACoAEkAFi@TcARgIBa@F]Rc@h@i@f@[r@[fA_@hBw@nBkA`@c@\\s@Fw@EeA]wB]}@g@uAi@uAOi@Ie@SoAcAoJAg@?aD?K@IVoC@I^cE@w@HoCF{AHy@Jw@TmATmAjA}FDcBG{AGcAMy@Ke@Mg@[o@g@q@y@y@eA}@i@o@e@q@]o@Yg@Yk@O_@Oc@Sw@G_@Es@AE@k@zBmGLg@Bc@FkAN{@Zy@pBmFP}@JkAQuJkB_KwEwOmEyMe@{@OUi@{@MM]c@[g@{@_Bk@kAm@mAy@uAu@}@SMi@_@UWMOEIGMWw@Me@i@wCCQAGAK?IASNeBh@wD\\oCDw@@_@Da@BWDIBIBIFK@IBE@IBS@E?IAE?O?IKUoAaBy@aAKQGKGMEKCIAKAI?K@IBSJQ|@}Al@kAZ{@Vy@Zu@XUBC`@M~AKpBIr@Qt@OfC_BT[Ng@F_AIiBQq@g@{ASm@sAsD@m@J{@f@gAxAwBtA_CvAaCZ}@P_@`@o@Je@]sA_@y@Sa@GQYi@GqABq@b@uBVo@DKZu@Lq@Ik@]y@sB}Ba@g@GKESO]w@y@[_@MOMQSYyBgA[QQe@EuALsCZeD^oIHeAf@gC@Kr@iCv@mCb@kA`AwAV]Ly@Fm@BYHu@Dy@J{@^w@JSBGBCFKFIFGh@_@XM^KDCXIBAJGLG\\Yp@g@LIPMLK^YX[RY`@o@@?fA}AZ]xAoAv@s@RQRQd@c@z@q@FGx@u@~BkCtD}DzC{CdA_A`Aw@^U\\OTKt@Qd@IB?bAOdAOLC~AWn@ObASb@QXOFIDEDGBGBG@G@G?G@O@s@?C@{A?[@O?C@a@B[DUBMJ_@@KBKJe@BS@SBq@?Q@IBgCA}B?gAEcD?c@AcC?mDAsBAq@A_AAy@?o@?K?I@MBM@IJc@JWZq@b@w@FKNU^_@PSLIPKPGp@U\\MLKLMb@}@JODGDEJGBAJEPEHAXCXAD?F@F@@@HDDBBFNX@HNp@RrAL`@PVNL|@b@JDF@F?F?D?DADAHARIj@UhB{@TKZOjAq@f@Of@Wz@k@f@e@VWLINKb@]NO^SLMDEBE@CVgC@KDOBOBMDKDIDGHIDCLEXAf@@bABT?T?TCREf@Mv@[Xk@N[La@L[FQFUD[B]N_BReCH}@Fu@H_AHs@NmAReA@OBQ@K?MASI[Ma@Sq@K][uAQ_A]mBIs@Ky@QsAcAeGAGQeAEWEKYo@UYKKOIIEGC[Og@UiBm@y@[k@OSIw@W_A[c@Oa@Qc@U[Qc@[m@e@{AuAa@q@aEiJqAuCQa@aAyB]}@_@aAcAaCi@qAcA{Cy@wBKWuAcEo@qBKYACSu@a@yAk@yBUgAc@wBs@gD]yAc@mBw@oDiAeFw@gDYsAq@{C}@kEm@eFOiAkAoJuBwKUkAMo@Se@KQKIIIIGUKMGMCOASC[AM?sAAwCCmCBmCBoAHkDRs@D]@IBQDODKDMFEDGFYXo@r@i@h@]PMBK@M?QAKAKCg@OQEeF_BiDcAsAa@YOMIUUMQYa@i@}@]e@KMq@_A[[MIMGAAOEMAGAGAQ?c@FODMDSF_@N}@ZYBK@K?I?Q?_@By@JO?M?O?E?C?GAEASG[IWGs@UGAICE?QCG?GAG?C?E@yBL{ALUBM@QBSDUFOBC?KBG?G@G?G?GAICEAEAWQeAq@IEIESI[MoAe@g@Q[KSKKGKGUSGEIIYW_@a@GIIIEMEMEIAGCEAGCECCEGSQKKEICICIKg@AICIEKGSKQIQGMUc@IKMMIIGEKGOESISGGCECIGMIKIMKOMIKIGS[a@i@OQMOOOMMQOOQQQa@c@Y[U[QOCCKKOKSQ[SYQ[OMEMEo@QGAGAE?G?G@E?C@G@C@E@CBEBKNKJKJMHMHOHYHWFODQ?O?SAOAKAICSG}@_@OGMEYIUGSCUEWCMCMESGSIKGUM[UUQMOKOKOGMIUQk@Mi@C[?G@s@AMCKEKIKGGMKWMOGKGMIGCEEEGCGMWSi@ISAECKAIAOAI@G@G@GBGDGBELKHIHKFGBEDIBEDOJc@Le@BO@G@K@I@UB_@?a@@oA?aC?_@?GAC?CACCGCIOU]a@GGWQEGMMCCEEAAGKGOO[M]_AaCGQ{@mBiBcEyEwKWw@Qo@EWKo@Gc@C[Ac@?sAAoA?{AHoEBmBBmAH{ADs@@IRoB\\sDFm@@_@Ao@AcAASOkCAiBCY?O?MDo@?MB[Da@Fc@Lk@Pw@Ts@JYHSPYh@o@X_@Vc@Tk@L_@H]LuAVcBPgA\\eBf@_CV}ARsAL_APmAHo@Ho@H}@ASCYE_@CWa@_CESM_AO_AEUCUCYCc@CaC?gAWsMGuAAk@?O@OF[BS@Q?WAQCOG[Y{@Mi@C]Cq@@u@DuAFgAJe@JYBGr@{AHQ`@u@f@w@v@eA\\g@n@s@pAgBxA}BXi@h@iAPc@HYBQ@OAa@Ew@AS?M@K@GDIDIHIJMZ[`@_@VSFIFKFKDK@M?OE_@C]CU?OBMHOJOLIJEVAl@AL?HANEHCDENMPOLOf@m@P]^u@L]BI@E@K?G@K?K?GAMAICMAGGWK_@kBmIWkAESAMAOAU?[@m@?_A?I?GDaK@m@?w@?gACeA?k@?M?G@a@N_BV_DNaBHu@Hq@Fg@j@iG`@}DH_Ar@gGFq@@W@KBSDg@TeCJoB?OAQCSESiA{DsA_FAE{AqG_@wAWkA_@{AUeA]cBEQ]aBAGKi@{@mDK_@EWKg@CYAMAGAi@IcEH{EDmBFaBF_AXmCFaAHo@Fe@Ho@Dg@Hc@Hc@Ja@NY^y@Xo@\\k@|@iBpAmC~@gBt@}A\\}@Z}@P}@Jq@^gCx@gGj@}CPqAPoAp@eGj@sDRoBNeBPeBdAqITcBFg@D_@NeAHq@`@wCj@}DHwABeAE_A@uFBiABg@BaB?k@?i@BuAAG?_ADuB?ODYCm@Cm@@w@A]BmBBkCBqALaC@oA?eBFwBFuBPeAf@mAf@_Bl@sBFSZ_AZcA`AyClCqITs@HWXw@\\cAxAqETo@`CiH~AiFXq@Tq@^aAbF{NRk@FSfAsE^yANu@NiA~AqMRuAN_APs@Vk@DINSRWVYX[LWJUBI@GAEACCECEKGKEYK_@KSGUEQMOMISGSAQ?OBOFKHIHILGXQRKTOTSNQTc@LWJWBK?KAMGMIMQOQKICMAoBIaAE_AEaAEQCIAKGOIGOIQAQAOAY@m@?u@@}@Bk@?OBWFs@BcACcAEsA@WBYHWnAyCx@}AjAcCLYH[DSDS?SAUEOCIGGGEMI}Ag@}Dw@WG{DcAo@Ow@ScAS]IyB]sAWaAY[KwBu@]K_@QKIIGUYw@iACGBgAXuCBWJ_ANyA@K?UAOAOCMCI[s@M[[a@yAsAqAkAk@i@k@i@MM}@_A[c@y@{AiAwB_@s@eAsBs@}@s@k@wA_AeB{A[]MMq@wAWi@]{AS}AAo@HsABW@W@CA_@iBgBeAq@eBmAeCsAcAa@{AWwQeAqJ}@m@KgCc@oCo@{@Ik@@m@D_@HiAXoCp@_CXcARkAF}CEuAGcE@aGKqCQwASk@McAWcLwD]SsKmF}CoByBaBo@[iD}AuEoCoDiC}@_A{@aAw@gAeAsAi@o@e@k@_@g@w@c@oBw@oFgBiAQ'
                     },
                     'start_location' : {
                        'lat' : -7.326177299999999,
                        'lng' : 108.3541123
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,2 km',
                        'value' : 1249
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 118
                     },
                     'end_location' : {
                        'lat' : -7.3009989,
                        'lng' : 108.7581768
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Bhayangkara\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'hwpk@quvvSKaAEqABqDNoDL{Az@_CfAqB`@_An@iAf@gBPiB@yBIkAYqAu@uCQu@f@}N'
                     },
                     'start_location' : {
                        'lat' : -7.2998872,
                        'lng' : 108.7472946
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 254
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 26
                     },
                     'end_location' : {
                        'lat' : -7.298743999999999,
                        'lng' : 108.7585191
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-2 ke \u003cb\u003eJl. Diponegoro\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f~pk@syxvScE]yBMeCW'
                     },
                     'start_location' : {
                        'lat' : -7.3009989,
                        'lng' : 108.7581768
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '21,8 km',
                        'value' : 21834
                     },
                     'duration' : {
                        'text' : '20 menit',
                        'value' : 1177
                     },
                     'end_location' : {
                        'lat' : -7.410113699999999,
                        'lng' : 108.9002393
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekanan\u003c/b\u003e ke-2 ke \u003cb\u003eJl. Diponegoro/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'bppk@w{xvSRuH?GL_D@aB@eB?eA?G?eAC{@CoAA}F?K?oDAiAKaH?m@GgG?}DIoJA]A{DEiCGuDNkKVmJ|@}FHa@x@mC`@cA`BmDDEZq@nBaDnBmDr@wAJ]@E?EIuB?QDg@PcA|@iEj@_A\\i@|@iApBwBLSLYF[FUDYHg@Fe@Hs@v@gEv@cEDMDIJWn@qAlBgDv@uAxA}Bh@{@LS^i@jB{CnAqBDCDELEPCNCrCUh@G`@G`@GLEJCBCFEJKfDgE~CaFr@aA^i@|@mA`@aABIBG?G@G@Y?q@AsA?GBOBMH[J_@xAoC~@gAfBcCjBcDdAaBv@iAtBsC|@aA~ByBrBiBz@{@tCaC@ArB{BpBiCnAsBhBuDdAoBl@kAf@s@f@o@v@aAzAgBbAkAv@s@`As@dB}@d@Wf@Wn@a@zG{D~AuAd@]hB_A\\KXIpBw@dBy@pAy@t@k@jB{Af@i@rAyBjAeBnAkBdAcBx@iAjCwDfAkAPUNQDG@?n@s@JGBA@?BA@ABADEHGxAeBbKmOvEqHPWXc@BEDIBCd@q@r@aA`IkLjAyArAaBz@_AXUp@k@jAu@h@[j@a@zAeAtA{@`EgC^U~AcAv@_@|@a@fBg@fDkApAo@nGwCfBaAjB_AxCqA?AbEaCnAw@`GeDz@a@rAq@tDcBlAq@|ByAbEwCdBiATMpCwAlAg@\\M`@Oj@S@AlCeAx@]pA{@~@w@^g@t@gAt@cAPSTW`AuAf@s@dAeB`@y@Tm@Ha@PaALkADeDKyAw@mEq@cBqAsCQa@K_@Ia@UoAKw@QcCGy@CqA@o@JoAXwA^kADGHQl@uA`BqCbAyAbA}ArA_BvAaBf@m@v@aAlBcCvEgHjAuANUlGcMxAwCbAmBvAyBdCoCpAcBzDsEnDgEn@m@x@k@p@e@f@WNIjAk@v@_@l@Uf@OZGZA^@l@DzAHdAJb@Hb@Jd@Pb@XZRn@j@h@\\RNXNLDLDF?L?JAJAh@MzCs@|DaAlBa@|EeAtGoAbFgA`DeALEHE^YVYXe@^s@^eAPo@b@mDRy@Pg@P_@Z_@fAsA~AmBhAqAtAkBv@gAZi@R_@Tk@TaAXqB?u@?k@@[?WBSHWPg@Zw@Zm@d@}@Zo@Te@RSZMd@G`@?d@?b@G\\OLMLQJQFS\\u@b@y@Vg@Ri@BMBO@_@Ac@?]?WBQBMFMJQPS\\]t@o@xBuBfAeAz@k@z@e@XQTOLSNYLWlBuCp@sAtA_CnAuBf@y@Xg@LYRe@Na@Re@l@}@h@w@fBsAt@c@r@]ZOROVWL[Pg@J[Ze@zAsBzBwB`AgAf@q@r@o@|AcAdAg@lAy@t@m@lBgBp@y@ZWVQ\\MXE\\@dAHvAT|@P~@HZ@^?ZGVMTOXYpDoEPSRMVORIPElBg@dA_@TOVQlBqB`BeC|A_BZUb@Yb@W\\OTI~Aa@dAOVCv@F'
                     },
                     'start_location' : {
                        'lat' : -7.298743999999999,
                        'lng' : 108.7585191
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,5 km',
                        'value' : 3520
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 189
                     },
                     'end_location' : {
                        'lat' : -7.4275657,
                        'lng' : 108.9247352
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Banyumas-Bandu\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'dhfl@oqtwSZkAPo@vB{D`AaCTe@rBkCv@y@nAwAz@gAj@m@~AuAt@WtBo@vBoAt@y@^a@fAoAPQr@eA@Cj@_Az@_AjAw@lCuArA_AJMbDuBd@a@PUJW\\sDNyALo@L_@Za@tA}@ZCd@EXKZ[t@eAJQf@gA\\wAHaAQmBQsBB_Ab@}CPk@f@q@~@o@j@a@T[Je@?m@M}@?m@Rq@`@q@nBwAd@c@PWHc@B{@Jc@LWnB{Bd@k@FKd@}@Xm@F]De@Ja@Ta@d@k@lBmAd@]^s@h@mB\\q@f@m@jBkA'
                     },
                     'start_location' : {
                        'lat' : -7.410113699999999,
                        'lng' : 108.9002393
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,1 km',
                        'value' : 3140
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 159
                     },
                     'end_location' : {
                        'lat' : -7.4417968,
                        'lng' : 108.9440075
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Lumbir-Bandung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'huil@sjywSbCoBd@k@Ve@Fa@JgAFk@\\iAv@oB`@w@dCyBp@i@h@O`CGdBAp@?j@HZPd@|@\\r@b@`@TJFB^@\\KVWFW?MEs@UiAAg@TaAVg@DKdBiCDGX_@RWhA{A\\o@ZuA?GTsBViE\\qDZyBZeAFW|@cBx@oApA_Cd@iAd@iAHWL_@?ABQFaAW{BAKI}A@m@La@^e@l@_@bAWjBOLAp@GXCrC]HAZKPMNSNUJQv@sGL{@Ja@f@u@|@w@x@i@xAeAJGPO'
                     },
                     'start_location' : {
                        'lat' : -7.4275657,
                        'lng' : 108.9247352
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '53,2 km',
                        'value' : 53182
                     },
                     'duration' : {
                        'text' : '46 menit',
                        'value' : 2742
                     },
                     'end_location' : {
                        'lat' : -7.603801600000001,
                        'lng' : 109.3413885
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Wangon/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'fnll@ac}wSf@e@p@}@n@y@f@i@b@YzBiAtA}@f@m@BG@ICKCOKWWs@COAMBWNyA\\}B@Kv@uFz@cCC}AMq@Wg@s@oAKq@?{@JcGNaDD_A@kC?EMm@W_@a@Ue@Ew@Ig@_@MWA]Jg@jAoDr@cCb@aBbBcEhAuBd@u@vAyBHIJGXKz@OhBShC?p@K`@WTa@Vy@Tq@j@w@rAoAl@_@VE~A?pAYRINOLM~@qAJOJQHMDQFUBODe@@EBIDGBGHINOVQROLKHIFIDIDG@I@ILgATuB@OAKAi@AI@E?G@G@C@EBCBCTWZ_@LGLGNCNCXCd@Gt@ArAAl@CTCTITQZ[`@e@FGTYV_@LUPe@`@aA\\q@FMLQNMh@YVODE@A@ABC@C?C@G@IAGCWI_@Qw@Go@E[Ae@Fy@Ha@R]^q@pAmAj@c@pCwC|@o@BCD?DAF?l@Ab@Cl@GD?BABADCBCBEBEhBoFV_A\\s@NWJOHGTMpAu@ZMRE`AQl@GTGLGNGFIPSb@cAPa@DIBEDCFCdAo@r@g@j@k@DEBG@GBM@m@@UBGBGDEJIRS\\c@PUPQFGx@{Bx@}C\\yB?e@Bg@@O@WBU@ODMBGFMNWHMFMFSDQFc@B[BQBQH]FOZe@JMDGLONQTYDIFKDOBY@O@KBI@IBGBI@AHKLMDGTSNKJKFEBEFONe@Rk@@GJ[FI@CBELKDCBALGPAZCbA@hAFf@DVBRFJDJFJLFRF^D\\DPHPLRPVRR`@l@T^DP@N@T?\\@\\@N@H@BBB@B@@FBf@Hl@LHDFDDBBHDN@H@Z@J?R@T@T@PBV@P@RBRFTFPDFFDJDD@D@D?D?F?HALCHGTMNIJEZK`AWlB_@nAa@dAUHCPGXMJE@?LIHODOFWHQZi@TYNQDEDEROJG\\QDCPGLAH@F@D@B?B@BBBBB@BBBFHTJ\\DN@@BHFFFD@@NFRFJ@LBF?NAHAJCFCHCFGDEDIFMJ]Ji@BIVmABMF[DQFWBODO@G@K@E?EAGAM?O?I@G@GBE?ABC?AHIPO?Af@W@AZQTID?DAHAL?L?LALAPALCJCZOj@[HGJGJKBGBAFMDGBK@GBw@?_@?O@SFo@D[BEDGJMXSDCDIBG@K@M?QAUKi@AKGUCQAI?I?IDOJQJM@?NOPK\\M^IVAJAFAJA@ALGHE\\a@TWNMFGPIz@Qp@E|@ALCLCJCXMVGHA\\AT@PBRFLHJDHBN?F?f@E^EF?VCNAPEZO`@OLGt@WLELEHGBC@?FIFODOH_@H]Hc@@EBQJ]FOFG@CBCFEFEDA`AYFALKHEFIFIFEBCBCDABABA@?`@A@?PAFAH?BAB?BADCBCFGFIBIDONw@ZgAPa@NORWX]N_@JSJQRQPQNMNQDIDGFIN_@LYHIFELKLEPCPEJGLKFKDOF[BSBUBIBKDK@CBCFCHINGLCZGNGHCHEDEFIDOHOFQFMHGFENIJEJC\\CPCFCNITWNULONKNIPGb@MRAj@Q|@_@pAm@|@]dC_ARIVOLMJI^WPINGTE\\ARCPCPCTKLILINSJSFUDYBWDSFQP[PSNWNYJY?CDWB_@BWDOBIHWRo@P]LWN[BENUBCV[d@]h@Yp@QXIZIFEDEDEDGFQBM@OAKAIEWEWCO@KBMDSFMv@_AbC}CRYLWZs@Xk@JOHGPG`@MVMNMLOJOFM@OBU?S?c@A[@SDMNQJKFIDMDSBU@c@?e@BUH[Re@Xe@TYt@u@r@g@x@k@`@[d@a@TYLSXy@Jc@D[@OFq@Fk@Hm@BIDQFORY^m@Ra@DKBM@E@E@G?EAk@GyAEiACqAAA?MAQ@_@@U@UBODQP]\\]HIf@[f@[JKVc@Na@DQFW@Gb@qBF[DUHa@RcAF[VoALUP[`@a@|@q@`@]X]VQNMDCVI@?RE\\CVETGTIp@]b@Yb@a@x@w@b@k@d@o@~DoEr@k@h@i@d@_@POx@q@NKNGJCNCT?L@TDTBN@TANEVQFIz@mAZq@JWFQ@OBQ?WAW?_B@eABe@@MBKDMDMJSFOn@}@j@s@\\a@b@k@b@g@ZUHG^Sn@Yh@SjA_@hBk@|@a@rBeABAz@k@lA}@p@k@V[N_@DSDW?M?OAIEIEIEEGCMECCQAiAM}@Oq@QKC]MGC[QMGGGKOq@mAIMw@qAwEmGe@m@m@cAKSIOCM@MF]@EBEd@w@JOLUHMZ}@@EFQFWBYD{@?g@C_AEk@AW@WBUDSJS^o@DIR]DMBKDSFyA?a@B]BSd@cB@GNc@r@qBr@_C|AuELm@D_@BOn@mGH]Lc@R_@rB}BHIr@{@FIh@m@NMRSVSROTOHCj@SXEPINIDE@AJKPSBE\\i@^i@JKHGLIHCTGt@Kb@INGFCBCFEDGBGBK@I@M@I?y@@]@yA@o@@e@@mAAa@?OASEOIYK]GUWmAKi@AMEg@Aa@Ci@?i@@k@@S@]RyALcA@IRcAHe@r@wENcAF]d@yCn@_EXeB@KJi@NaARoAPsAVuCHmA\\cF`@{FBe@PqD?KVuFH_BDiA?A?I@S?S?I?MBe@H_E@uA?O?cB@aE@m@B}D?cA?M?mA?}C?M?Y@y@DuF@Q?s@Dm@@G@G@EDQFMBEP[JKx@m@lBsAvAaAdC}AvB{At@g@h@_@nA}@BAnBoA|ByAbAo@h@_@^[DE|@{@T]LW@AP_@b@iABKTy@Nq@XwABKR}@NcAHeAFwADuADmA?gAA[Ci@Ck@GcBI}@Ec@KiAWwCI_AEg@CWMkA?GEk@Cu@?s@@sABaAFq@H_@FYXo@d@gAHQTc@Zo@BEXi@d@cANWd@w@FMR_@nAeBNUT]PYPc@Vq@\\aArAeEn@oBTq@t@yBp@_CLe@|AuFNk@`@uAj@wBBGv@mCj@oBJ_@ZkAt@}CdAwDPg@^oAXcAp@aCBKPq@n@iC@ELs@@ILeATeCJkAXsDTkDTmDNuBN_C@MDc@@SJeBHwAXaG`@uGLuBF_AFcABi@PkD@SXeEHqAJgB^eHFgAFgAFeA@ORaEHsAJwAFy@^cFBKDIHKpB_C~CuDr@y@x@_AHIDGBEDGDIDIBIBG@E@KBM^kCTaBHi@\\iCf@iDjCuRr@eG@Q\\}Db@wFJsADe@J{AHgB@}A@sA@{A@WCeD?e@EkJAsA?yA?mEAkD?sD?q@?MAaF@eFEcG@iA?{@?i@AiD?gEE{E?{BE{JCcEAg@A_@CiBAcBC{A?KAgAAe@?MAeAC}ACaBEiECyCOsHAQCcAS}ICcAGyBE_AEa@Km@WoAq@yCo@oCM}@ACKw@MsAMkDCc@Eo@?QOkCEsAIyBKyCImAAWQwEAYCWOaCUeD?u@@YHe@D[Hq@J_@Vs@d@w@R]j@m@NK@APK^Sz@a@ZG^I^G`@Gl@?B?T@d@Bj@FzBNxBP`Eb@hAJb@Bd@Aj@?~@Gb@Gd@GdB]DCZMh@]h@c@BCv@{@FGrCuD`@k@hBgChA_Bz@mA~BwCNSHK~@oARYhDuEfA}Ap@}@PW`AkAzAwBd@o@nAqBrAuBj@eAhHsN^i@R]f@aAx@}AdDgGr@yAp@uAl@iAdBqBtAmABC~AmApAaA~AqA`Aq@vAiApAaAdAw@z@s@fCkB@AbBqAfCmBZW`@[BCDEBAVi@J_@DY@YIe@CG?EEO?AG_@[_BQ{@Qw@Ow@o@qDOu@Os@WsAG[CUCUAQCME_@As@@YDo@BOBQDYNc@T}@\\gA^mAj@cBx@qC`@wAh@eBRk@Xs@tD}JNc@jDuIr@cBn@uAp@cBVk@HStBoDpBmD~BeEDITe@xBqDjJsOvA{BpCuExA{BTe@n@uA\\i@h@_AFK`MiSzHyLr@iAdBiCdA_Bh@{@jDqFtBaDt^qk@@?lHaLvA}BPYd@q@fAyB^q@DKpByDFMFQXo@l@mADK|@}Aj@kABCr@yArAuCnDeIxB{FpAcDz@gC`@_B`@eBv@{EbAeID]DgAD_F?qD?cALwJ@]@aA@eB@e@DcD@I?[?OLuEDcCRiXBuEHeLE_HAg@CeBEgBOaBEc@Ky@qAqKk@uD_@wDEe@Ag@By@Ho@BYj@{CXcBXuAP_AViBN_BX_EHgDT_NJmFRuE@yA@_CTyMh@gTvAuz@ZkNRmGF}Al@gGZqB^gD^uDbAwLjDgZd@cCfAkGd@gC~AuHfAeEx@{Dz@oDdA}Dt@qBp@iARe@fCiGrD}HdBiEv@iB~@yB~@mB~AqDHQfBwDz@iBd@u@Ve@b@i@'
                     },
                     'start_location' : {
                        'lat' : -7.4417968,
                        'lng' : 108.9440075
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,3 km',
                        'value' : 1300
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 95
                     },
                     'end_location' : {
                        'lat' : -7.6090553,
                        'lng' : 109.3515304
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya Sumpiuh-B\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'vblm@uvjzSSGGACACCAACCAAAAAAAC?ACKAOCSdBqD@CbBiDJU`@w@f@aAl@mA`HiOBCrAsCbD_HrEsJTe@'
                     },
                     'start_location' : {
                        'lat' : -7.603801600000001,
                        'lng' : 109.3413885
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,3 km',
                        'value' : 3346
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 168
                     },
                     'end_location' : {
                        'lat' : -7.615284999999999,
                        'lng' : 109.380607
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Sumpiuh\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rcmm@avlzSvBwE`@gArC}GTg@p@iAl@eAzC}EzAyDNe@b@{@l@aBNa@J]Ps@TkAJo@DY@W?e@?YFeFD{A?S?GCgC?kD?IEmBIwDAaACsDBmBDsDDkAD{CJg@^yCj@wHd@_GTgDVwDX_Fn@_Gr@qG\\kEr@iH'
                     },
                     'start_location' : {
                        'lat' : -7.6090553,
                        'lng' : 109.3515304
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '7,0 km',
                        'value' : 6957
                     },
                     'duration' : {
                        'text' : '6 menit',
                        'value' : 351
                     },
                     'end_location' : {
                        'lat' : -7.6059144,
                        'lng' : 109.4405469
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Tambak\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'njnm@ykrzSGwEKcE]}GsBe^QoBq@_JYeFMuBi@}EQkASgC?iCD}Aa@s@SUU]I[EgAI_XK_FQsCIeBQqB_@gHCkACkCCcJAcCEy@Eo@IoEEmBAS?OCmAKqBSyDE_AIaH?AYaFGsAIuAAGQ}EaA{]EsBI{AAc@GuCScDa@aHEi@C[?EA_@Ag@Ak@A]MuCG{@CYAS?e@?c@?INy@Jm@P}@J_@JYFWDQDS@SBWDm@?OHsBLaEZuE@a@?_@AUAQCWEQ?CGOQ[KSQWY_@yAqAyAkAgDeC{@o@mAcAoB_Bg@c@gAq@u@a@{CoBuA{@c@S'
                     },
                     'start_location' : {
                        'lat' : -7.615284999999999,
                        'lng' : 109.380607
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '31,3 km',
                        'value' : 31285
                     },
                     'duration' : {
                        'text' : '26 menit',
                        'value' : 1577
                     },
                     'end_location' : {
                        'lat' : -7.6966826,
                        'lng' : 109.6774784
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Kebumen - Cilacap/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : '|olm@mb~zSyB_A{Am@i@WQIaBu@c@Uw@g@iAy@a@[WQeAu@gAm@mBeAMIyA_AoBmAyB{Ak@e@_@WIIGGIKQSMUKSIWEO_@mCKo@KoAASGoAMmCKeBM_BASIiBI_AEm@UwBYqBQmAE]CMAYAQ?G?G?IBIDOTu@h@}ADMJY^aABG`@{@b@k@^]\\[@?JMb@_@TUZWNQT[Xi@Xo@Rg@Vq@FQNa@Rg@@ENa@@AJYHOL_@N]LUZ]\\[j@a@\\Uh@_@ZUj@e@LKLMV]NUdBoCJMx@yAh@aAp@gAd@o@\\g@j@w@j@y@p@_AR_@^u@LYBIFa@DYD_@@g@@mA@q@B{CEM?ACM?CAQAU?QAMAOCIG]Ke@EOCMAKAI@G?K?GDKDKVi@P[LSPQJKLMFGl@c@JIFGHETQHKHKP]x@_BXo@JYd@aA\\w@b@cADUFUBM@KBa@?]?YCmAGoAI}@?CM}CEiAAc@Aw@?{@@a@@MBYRmAXuAd@iBpAsDl@eBJ[p@oBXw@No@DSFYf@oCF_@\\uBl@}DVeBN}ADi@?c@?_A?k@IeHC}A?i@A]AeBCgA?GA[AKAQCOAICGCIIQGKSYKMISISOc@GYCWEo@?UCU?I@O@QrAsAx@u@HMFKBGHSEWESI[S_@m@oAUm@EQEa@Iu@GcACi@Cy@KeBCq@SyCGeACm@CU_@}DASGq@KeA_@_DK_AWoB?E?ACOASASAKCuA?CE_CAmAEcDAgDAsAAs@?EAaD?IAyD?a@?S@oA?kCA_C?aDAyDAs@AsB?o@A_@AoAC}B@_@AkA?WAo@AOAmA?C@iA?A@{@HgCDg@V_DD{@HwA?U?c@Bs@A}AAg@?AB}@?ADeB@w@FgD?KBk@NoCFu@b@gEPuBNsBJgBJ{AFo@?e@?O?A?gE?{A@_B?QDwC?AHeD@SBs@HqC?e@@a@@uC?AJcDB_A?CBoBBu@HeB@i@?GBm@VcCDcAN}EXcJDgANcEPmEDeATeFP{DLeDDeB?CRgLFeFBeA@Q?K@Q@EBQD[N}@FUJa@H[d@qATu@Ra@LQTWj@g@^]LMp@k@RQ?Ah@a@f@a@n@s@HGxEoEfBaBp@m@|GkG|A}AbD{CdC}Bn@o@nEgEzA{AjCgCFEnCcBBCHGbCcB|@q@ZWz@o@^[fAw@jAaAnAgAf@_@t@w@^_@JOBCTe@Ro@RgA@MlBmKD]?Aj@}DF[^{Bv@uEZ_B^mBTeA^{Ah@_CTgA@INq@Jg@L[?AFIDINSRSROLKd@_@ROjCkBp@e@~AoALKjA}@h@]lF_EVQ|AaA`GgEbBkATMhD_CXQn@c@|B{AZUtCoBl@_@j@a@pA}@`@WbGaEfAw@LIl@e@`Ao@|IsGNM`@Yj@e@dByAtC{BtBcBlAcAjB{A~@u@|CeCnJaIbAy@jA_AfDoC?ATQBE`@cA~@{CFSrA_EPm@La@bAiDdCkINi@rA{E\\kAx@iCvCoIfAaDrCmIjBuFfAkDbA}Cv@gCd@iAh@oA^{@Pa@Rc@BG@Ad@eAhBeDFKZi@rAsBJMDGpAcB~@wABG`EeGRYxE}GjBmCBAbAoAV]`CqB|@w@f@a@DAHKx@iAl@{@JOvC_E`@m@RWb@k@z@uAP]p@{AtB_FbAcCxCwG~BaFJUN[j@eADKb@m@`A}AP[~@{A~@yAFKZk@T_@Ve@j@cAVa@j@yAv@oBj@sAt@eBLGzAg@lDeAzAg@TKVMTQjC}AnBgA|Aw@t@]d@YZS`@Yp@i@v@k@z@e@fB{@dAe@hBs@|D}AdBm@hCaAbCy@jBm@r@WfAk@f@YVMb@YHGTMdAm@^SbAi@`@QPKnAc@^O`Bi@|@Wx@Uv@QjAWt@I`@Gn@KxAg@`@OpB_A`@QxBy@dA_@TIHGPOLKNQl@cAd@cAb@kAp@iBj@yBZ}@v@iBb@kAXgAP_ADYHw@Js@RwABW@EFa@J{@J_AHs@R_BHi@d@sAr@aBN]DIHUDIXs@Vy@BEDKXm@JWHSBMBM@KBq@Bw@@UBMBMDMDK`@o@v@mARa@HSf@oAXs@b@iARe@bA}BT]p@oAl@aAJONQTWBCj@k@xAuAbDuC|AuA|@}@NOTYd@k@^k@NWR]N_@HYNe@D_@Da@LgCJ{AD_@Fm@Ly@NiAR_B@OZiCDa@?M?UAMCUGc@e@mCQkAOeAE_@EUE]AOAMA]AKC_BAm@?A?w@@iAD}ADgADoA@g@?s@AkBAuAIqDGgBEoCAIMoBo@aGGo@Ge@MwAKuAWgCMw@Ms@Oq@Q_AMk@S}@wAoGe@eCg@gCk@yC[gBIc@SwAU_BESQuAKm@Ig@Ka@Mi@ISGSGUCQAQGi@IuAIiA'
                     },
                     'start_location' : {
                        'lat' : -7.6059144,
                        'lng' : 109.4405469
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,7 km',
                        'value' : 728
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 69
                     },
                     'end_location' : {
                        'lat' : -7.690165799999999,
                        'lng' : 109.6780741
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Pupus\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'fg~m@gkl|S{@EwBGyCKmEQmAEqCKsAG{AIiAE_@CiCOuBK'
                     },
                     'start_location' : {
                        'lat' : -7.6966826,
                        'lng' : 109.6774784
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '79 m',
                        'value' : 79
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 42
                     },
                     'end_location' : {
                        'lat' : -7.6903237,
                        'lng' : 109.6787682
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Kutoarjo\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'p~|m@}nl|SDUHk@LaA?G'
                     },
                     'start_location' : {
                        'lat' : -7.690165799999999,
                        'lng' : 109.6780741
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 219
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -7.6883764,
                        'lng' : 109.6789677
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1',
                     'polyline' : {
                        'points' : 'n_}m@isl|SYAm@Aa@Cc@CEAGCICIEGACAEAE?G?s@AiAAe@AO?'
                     },
                     'start_location' : {
                        'lat' : -7.6903237,
                        'lng' : 109.6787682
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 448
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 67
                     },
                     'end_location' : {
                        'lat' : -7.6849956,
                        'lng' : 109.6796275
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'js|m@qtl|S?M?e@?q@?SACACCACAEAEAG?{@IM?GAA?A?C?GAC?C?I?a@@cABa@@Y?S?A?M?E?s@@w@@S?W?}@?I?G?_@Ba@@K@M?'
                     },
                     'start_location' : {
                        'lat' : -7.6883764,
                        'lng' : 109.6789677
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 472
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 53
                     },
                     'end_location' : {
                        'lat' : -7.685384699999999,
                        'lng' : 109.6837951
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'f~{m@uxl|S?UBYLeAFc@BQ?K?EAE?ECGCIAGAG@GDi@@M@I^aDBUNyAFq@Ba@DqCAGCCCCKC'
                     },
                     'start_location' : {
                        'lat' : -7.6849956,
                        'lng' : 109.6796275
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 202
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 29
                     },
                     'end_location' : {
                        'lat' : -7.6835906,
                        'lng' : 109.6839983
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'r`|m@wrm|SWBWAw@CA?uAGu@G}@I_@CEAEACAAA'
                     },
                     'start_location' : {
                        'lat' : -7.685384699999999,
                        'lng' : 109.6837951
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '99,6 km',
                  'value' : 99586
               },
               'duration' : {
                  'text' : '1 jam 32 menit',
                  'value' : 5509
               },
               'end_address' : 'Yogyakarta, Kota Yogyakarta, Yogyakarta, Indonesia',
               'end_location' : {
                  'lat' : -7.797060200000001,
                  'lng' : 110.3706677
               },
               'start_address' : 'Kebumen, Jawa Tengah, Indonesia',
               'start_location' : {
                  'lat' : -7.6835906,
                  'lng' : 109.6839983
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 572
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 49
                     },
                     'end_location' : {
                        'lat' : -7.683121399999998,
                        'lng' : 109.6891281
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etimur\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'lu{m@_tm|SACAw@EeCCw@?YK}BC]EYI]G_@S{@Mm@I_@ASAU@[?o@@]@W?W@c@@o@?o@A]?I'
                     },
                     'start_location' : {
                        'lat' : -7.6835906,
                        'lng' : 109.6839983
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 110
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 22
                     },
                     'end_location' : {
                        'lat' : -7.6840917,
                        'lng' : 109.6890943
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'nr{m@atn|SR?n@E^AB?H@D?BB@@B@DBD@H?F@TAJ?'
                     },
                     'start_location' : {
                        'lat' : -7.683121399999998,
                        'lng' : 109.6891281
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 308
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 37
                     },
                     'end_location' : {
                        'lat' : -7.684376299999999,
                        'lng' : 109.6918398
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1',
                     'polyline' : {
                        'points' : 'px{m@ysn|S@M?c@?e@@_A@I?i@@OB]?_@@c@Du@Hs@@QDKBEDG@C@IBG@G?E@G?C?E@C?E?C?C?A?AACAA'
                     },
                     'start_location' : {
                        'lat' : -7.6840917,
                        'lng' : 109.6890943
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 891
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 84
                     },
                     'end_location' : {
                        'lat' : -7.692208499999999,
                        'lng' : 109.6903601
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jz{m@_eo|STCRAD?bAAvC@f@@b@Bf@DV@h@FjHnAbFt@n@JlCb@XDz@NxATF@~@LHDjC^'
                     },
                     'start_location' : {
                        'lat' : -7.684376299999999,
                        'lng' : 109.6918398
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '32,8 km',
                        'value' : 32761
                     },
                     'duration' : {
                        'text' : '28 menit',
                        'value' : 1675
                     },
                     'end_location' : {
                        'lat' : -7.727381399999999,
                        'lng' : 109.9722667
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'hk}m@w{n|SBUXuBXcBJm@Lu@Je@J_@@EvA_FFQhAmDlAwDbAyC\\gAVw@Nc@Tu@bAcDNi@@EZ}@HSDKPc@R_@Xc@PUNQLOVSJItDuCjBsA|AiAhE}CjEaDhAy@`EgDFETSdBeBz@y@NQNOd@c@zAwAhAkAdAeAdBgBzAaBvA_BV[RSHK^e@b@k@X_@JMRYjAaB|ByDl@cA`AqBZm@jAoCnAmCl@mAj@sATe@t@iBfBuEZ{@Rm@Rq@Jk@Ly@FYf@_DZiB\\uB^}B\\aB\\sAzAwFx@uCfBcGZmAb@sAx@gCj@{Af@kAZu@Zo@b@u@\\_@FGp@q@@A`A{@nAiA~@u@FGtAgAd@a@j@g@|@s@@ARQr@k@dA{@VS~@u@zAmAzAiAt@g@ZY`@_@\\]Vw@ZiA\\qA\\wARw@Ja@@MDSBWBW@a@Bu@@QDuADw@Ho@Hk@Nk@l@oDN_AZ}BBc@Be@A[Ee@E]Wy@Uw@g@uAMWg@eAGQ}AoDiAiCo@{Ag@eAQc@}BoFEI}@sBk@mAoBqE}A}DMiAK}AIqAYsJOqEAg@AUEkAAKIsF?gAC{AGqEImFKmHAgEC}AKoPHeKDeABeALuD@Y@U@S@OBOBMF]h@iB\\mAtCqJPu@T}AVuBNaBLaCJ}BH_DEuBIyAKuAQeBDiGCoI@{@?EHyBPyBT{C\\_DTeBpGka@X}EViApBoIZkAh@oBXaAfAuDvA_Ep@mB`@oAXaANm@FYFUXsAjBuLVwABQN_AB[DUBS?ALuBJ{E?U?G?GAUC_@SoB_@sDm@gFCOm@cFg@wDOsAa@mDU{Aq@yCg@qBaBmG{@mD_@eBIgB@kBBcBJoBJuB@[F}DDwD?I?S@k@H_G?I@]@wAH}CR}G?G?uAE{@AS?A?EMcCWmBWkAo@yDcAaH_@qCo@uE_@aDE_@CYGk@Gy@AiBHcGJmJH_H?iBRgMJcFHyF@q@TgIPeEDy@D}@BaA`@sIP}Cv@qM`@eHb@iI@k@^iHBw@Fq@JgBPcD?Eb@oHf@gHFiABe@FeAVoE?ALiCNcCXkEFw@N{BV_EV}DBSt@yI@Ev@aLd@uEH{@v@gJBU@QtAsOb@gG\\uDp@eHNyBReBlAeMl@aIRmBFq@B[ToDNaCFeB@m@CuCU_FCkAEeAEw@CgAEaAGcCCm@C}@Cg@Ci@Ci@Ag@Ci@Ci@Cg@Q{FIeDCoAAwBAk@?i@?i@?g@?i@@i@?i@?g@?i@?i@@i@@yA?MBc@?e@?]@e@?]?EAG?IAWACIe@Mi@Ie@Mi@Ke@Kk@a@iBESCKAAMq@I]K_@WgA]sAGWIUEWKa@Ka@?CI[Om@Sw@Mi@Ma@AECQGOEWK_@K[CII[]uA?Am@_CkAwEeAiE}@qD}@sDa@qBGW_@cBm@oCu@uCOm@]y@GIqDmIkA}DyAeFKkA?ESsAE]A_@BeBP_JR_Cn@eM@a@Bg@Bg@Bg@Bg@Bg@Bi@LeB@k@De@?K@IHoBX}F@QV_GDcABm@Bc@?CVyE?IBU?[PaF@IDi@Bk@Di@Dk@Bk@Di@Bi@Dk@Dk@Bi@Dk@Di@Bg@Bg@Be@l@}GFa@DW`@cDRcB~@{Fl@aDDQRiA^kBDUHc@n@cDX}ARmATmAHi@VyBD[vCiXdA_IFq@d@yD^}Cn@yEJeBD_@ZuCf@kFHy@b@uBJe@BUFa@b@uEHw@NkBPuBLgAb@iEZwCVgCRyAd@gDDo@@CP_CT}FNcAZeJ^gJDaCFcB'
                     },
                     'start_location' : {
                        'lat' : -7.692208499999999,
                        'lng' : 109.6903601
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 757
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 110
                     },
                     'end_location' : {
                        'lat' : -7.7321899,
                        'lng' : 109.9758216
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Lingkar Selatan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'bgdn@u}e~Sv@Fz@F~@FdAFd@Dv@FdA?z@Q^[h@i@`AgBv@kBpA_CxCmFv@yA'
                     },
                     'start_location' : {
                        'lat' : -7.727381399999999,
                        'lng' : 109.9722667
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,4 km',
                        'value' : 3396
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 272
                     },
                     'end_location' : {
                        'lat' : -7.745435,
                        'lng' : 110.0029428
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Lingkar Selatan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'deen@{sf~SVk@ZoARoBP}ANqA`@wDL_AHi@Fc@FUFOn@sCj@uBdC{IFYLe@VgBPeAFUFYZa@d@o@@A^a@l@k@v@{@TWNSNUZw@f@wAf@yAPu@`@gA\\aAFQJQ^e@RWJKJWNe@Ty@v@qDR{@fCaL`B_Hx@_Dt@aDdAkEDKb@}AJ[HQT[FKLMVWxMwOx@oAfEcFh@q@xBkCd@m@PW'
                     },
                     'start_location' : {
                        'lat' : -7.7321899,
                        'lng' : 109.9758216
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '55,1 km',
                        'value' : 55070
                     },
                     'duration' : {
                        'text' : '47 menit',
                        'value' : 2830
                     },
                     'end_location' : {
                        'lat' : -7.800325699999999,
                        'lng' : 110.3252371
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~wgn@k}k~SxCHfA@dA?fGKt@AtACpGWvIEVAf@AD?t@EnAK|AOj@KjBYtAQ`@Il@Kp@EvCQdCKh@?rBE~BCv@?@?jB?nB@lAAhDEbAAXCfLk@rDShL_@rEMpAEz@Ax@?v@?vB?~DAD?lDCxA?`FAVArB@vPB`A?~ABfDDjADz@F|FXtNh@zGf@bBH@@J?xCLF?T@jACp@Fh@FjDVl@Dh@HJ?jCTrBPtCR@@hAHnDXd@J~AVHBH@J?J@P?fC@RA^AVCTAN?hAMfASrEwAn@U`@QdEsAdA_@hAa@HCrBm@HEB?j@WPGd@SrFeBjBq@hA_@`Cy@nEoAj@S|DqApC}@HAfA_@\\KfBm@hA[hBu@~BsAfAaAX]fAoAh@_AZs@Va@RaBBg@f@qDxA_MDYF[JUP[R[b@m@d@k@\\]XS\\SPKxAy@lAw@JGDEfAq@pAy@\\Q\\MDAl@O`BWbBD^DvCT`@Fj@HH@F@lHl@~@@`BH`ADD@l@AT?nG?N?dAAnCAnC?zA?\\?hBBfA@|AAf@?b@AjC?jFDdEFdLD`@@vAAJ?r@Er@Ib@EbBQ~BYr]kEzOoBtGw@z@M`@M~@YRGTK\\Qx@e@nBoAjCuA|CiBFEt@i@n@e@`@a@^a@VYNa@Tc@Rk@TaA\\oAj@uB@ERs@Li@Nc@RYZa@XYZYZSZS`@Ux@a@fCgA|Ak@hAYr@KZG\\Aj@Bx@Hr@NlBZvC^|@LZB`AHb@Cb@E`@KXKDA\\Sd@W^W^]TWT[R]f@iAj@oAj@sA|@{BP[T[V_@d@c@n@c@z@[~@c@tAk@fAa@@?f@SHCXO\\STQVSXURWDGDIDKFMFQLe@J_@Ha@N_ALg@A_A?o@Bq@DYJq@Nu@J_@X}@Rk@j@qB`@sAZcA\\u@j@eAd@u@FKHMLQHM\\m@d@}@JQFGDGZ[b@_@j@_@f@[bBeA`Am@VUfA_An@a@rB_BjAy@~AmA`EyCfBoAXUj@[n@]jAg@~@[tGmBhCo@r@Sh@O\\IXERE\\G`@CT?TAbADzELbHXxDPnGXtJZR@|DTT?d@BL@B?`@BlA@p@@x@A^Cb@ITGNEPI^Q\\Uf@_@b@e@tAcCtAcC~@iBhCsEd@aA|BcEx@_BZq@\\u@bA{Bb@{@LWnDcGZc@LUHMJULa@tAwEh@wA\\u@Nk@DSD_ACcB?oB@e@@y@@o@@{CAc@E_@A[CKAG?G?GEi@GaACc@MkGAa@Au@EqBCcASmGCcAAm@GyBEiDCWAM@qB@a@@YNkJDcA?S@yA@sC@w@Fu@?_AByADcDDkBDu@?SBeA?G@_@?KBk@?A@YPqEBaABiAHaCDm@?q@?kAB{@AaA?k@DqB?qA@U?iA?K?GBcADaBBkA?EBeE@W?Q?A?I?QDy@@o@D{B@w@DqBDsB?MBkB?GBO^mM@uAF}CL}CJkALkCFiB@]?EB_@Fg@TcBDq@LgB?E?C?C?C@C?CRgBBQBU`AeKb@cGTeDFw@BSH{@@ARgBt@uGh@aHvAuKLiAB_@@WL{B^sFHkB@}@AQCiBNmGHsELgJ?G?E?Q?AFsAHiB@k@?Q@YDqBBgADmABsC@u@?[?GCICEEKAECGAE?K?O?[@A?W?ABc@Bk@Dm@Bi@@QF{@DkA@a@F{@JsBFw@BUBS?ADk@DeAJuABg@LeBB[BWHyABm@FaABWDs@JiBR}BH_Bj@wINsCDk@JkAJgBJiBJiB?EWaACGCECCCEEIKMEGOMGEA?WEyA_@iCc@aBYmLoBqEo@YGgFcA]G_AMeCa@YE_@GaG}@{@QaB[cF{@IAgAQiNeC]MMEKGc@YWWqA}A]a@W]}@aA[_@QQEEc@i@w@_AsAcBa@_@OOCCgBuBaBqBGIEGc@s@wCcFkBgDe@y@m@cAy@kAOW_@i@e@}@_A}AIWI[Kg@GIKa@uAyHIc@_@gBOg@GOIq@k@qCS}@Ia@Q{A[eDOqAw@o@SUUUc@Wg@c@wCuB}@o@gBqAe@]kAy@mA}@kA}@w@k@UOMIUQEEGKGOAOASAOB_@VyATcA`@iBVkA`@wBDy@HuEDiF?WFy@^cEVgB@q@@[H_@r@wBz@mCXqAHs@LyBFgCLgAv@_F~@wFL_A@IFq@?SA]EWI]k@yBu@eCu@oCGOQw@Om@Gu@?aAF{@LsCJoA?GPoE@[Bc@^iFFmAJqENkD@g@@wB?i@A_@c@_FMeAA[E{@FaANq@p@yAd@{@~BmEd@eARm@BM?oACaAEs@Ai@Co@Ba@B]Ps@Pk@`A}BVm@Vm@v@oBJWTk@FQdA{CDQDYDy@?{@?EEa@Ik@Qi@sBgFI]Kg@IoAAGCwAHsDHqA@EXy@FW@E@C@CJWPe@Rm@Ti@FWxAiD`AmCh@gAb@s@DKj@{@Xg@\\q@dDkGZc@V[BETcBTeA^gATo@tDmIn@}ATc@Vm@\\w@@C|A{C?CzC}FHQJWFQDOH]@K@I?M?OAMEm@Ok@YqAUs@Oa@Wm@QYQWMO_@_@]Wm@[eAi@iDiAiGeBAAkAOm@I]Gi@IE?CAGA{@Ms@MkDm@s@YwA_@UGYGuA]MCMC}@Ua@K}@WuA[WGw@UKCs@QSGKCQEUESGm@Ks@MIA}@SmAU[I{AYy@M}AUeD[gHw@gCWA?k@Ma@IOEkAWwA[y@QGCo@OiAYQGICA?EAi@UIGGIGICI}CcIQ]]g@UWi@s@[[]Sa@Mk@OiNoBWE[I[MaKoDiFQkM_ByEg@mFa@}CKmEYuCYiBUaASkBs@e@Ok@SaAa@g@Oa@Ia@Gg@EgAGeBGUAC?iAGmCCeAI_AEk@Eu@ImBY{AWkAWkMaCmFgA{@YgE]yBYo@K{BOaASa@OWQMK_@g@Yq@Me@_AeDa@oAQ}@AEMa@Ss@Qs@e@}Ak@qBSs@IUk@gB[cAc@cBeAkDYy@Y{@y@mC_@oAOg@Yk@[_@W_@a@a@aAsAKOGOGQEKQk@Ka@Ie@Ik@mAiJ]cBQi@Oe@Qi@Qi@Ma@EGYu@cBqFs@iC_CkI{EcNYu@KYK_@Mc@Om@wAkEq@wB_BcFWw@o@mBeA}CWw@Us@CIEI]oASm@[aAUq@K]KYKUoA{DOm@g@sAWu@Kc@ESCKIy@Ee@Cm@Gm@I]Og@c@iB_@uCOaBO}AEi@QaCAESoBSaCQaB]yDaBuQKoAi@mGIqAOuBa@qFKwAEiACm@Cu@M}BEw@IsAKaBSmCGy@IgAAOEaACu@E}@Ek@Gq@I_AKeA?GAMAKAIAKGSOg@_@mAOq@AICQAOAMCg@GoA?YAICm@C}@AMAa@Cw@AWAYE{@Em@Ag@AQASCQAQCUCM?EGe@MmAKk@a@oBKk@_@wBG]WuAI[Qu@]kB]oBWsAE_@Kg@CMCM[gAESCMs@_EUiAAGES?AUoAGYCMe@gCOu@k@wCIc@Mo@SsA]eBMs@AEKm@SaAe@cCMk@I[Ms@oEwUKq@O_Aa@aCOm@CMQgAeB}I}@_FaAoFCK_@uBIy@CQY_CCWSeBAQGm@KgAo@wFsAmLS}BS{AcAwJAOE[gAwLO{A_@}DQsBGm@i@yFKkA_@oDa@aEKy@COIy@Gi@]qDCOCa@KYg@iEQeBK}@SeBYwCGk@MoAAKg@{ECY'
                     },
                     'start_location' : {
                        'lat' : -7.745435,
                        'lng' : 110.0029428
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 557
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 32
                     },
                     'end_location' : {
                        'lat' : -7.7998269,
                        'lng' : 110.3295528
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. RingRoad Barat\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`orn@w{j`TIcAAE?E?EAE?OBQ@E@GBK~AaGV{@Tw@J_@@K@G?G?M?KAIAIISKSMOIMKKMKOMwCqBKG'
                     },
                     'start_location' : {
                        'lat' : -7.800325699999999,
                        'lng' : 110.3252371
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1402
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 92
                     },
                     'end_location' : {
                        'lat' : -7.8006696,
                        'lng' : 110.3422393
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Wates\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '|krn@uvk`TBOAU?Y?O?SVeDH{AHyBPgGBwAD_BD}@JgE?OLuFDeC@k@LwE@}@?WFeB@UFoBDkBBgAB}@D_C'
                     },
                     'start_location' : {
                        'lat' : -7.7998269,
                        'lng' : 110.3295528
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,6 km',
                        'value' : 1565
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 134
                     },
                     'end_location' : {
                        'lat' : -7.801150000000001,
                        'lng' : 110.3564255
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. RE Martadinata\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dqrn@_fn`TFYJsF?U@uB?[?OHiE?CD}@BkC?I@qABeCByA@[ByC@q@B_BByC@eF?O?e@DgF?K@eB@K?S?cF@e@BgA?CBq@AaA?OFi@'
                     },
                     'start_location' : {
                        'lat' : -7.8006696,
                        'lng' : 110.3422393
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 923
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 47
                     },
                     'end_location' : {
                        'lat' : -7.801383299999999,
                        'lng' : 110.3647939
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. KH. Ahmad Dahlan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dtrn@u~p`T@iEB{A@wD@{A?CA_CJwD@Q?MBwA?gB@[@aA@i@?qA@cA?W@q@D{@@iA@cA'
                     },
                     'start_location' : {
                        'lat' : -7.801150000000001,
                        'lng' : 110.3564255
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 503
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 40
                     },
                     'end_location' : {
                        'lat' : -7.801534999999999,
                        'lng' : 110.3693581
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Senopati\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rurn@}rr`THgD?KJmH@S@uA@k@?_A?yA@qA?[@Q'
                     },
                     'start_location' : {
                        'lat' : -7.801383299999999,
                        'lng' : 110.3647939
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 252
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 27
                     },
                     'end_location' : {
                        'lat' : -7.801582499999999,
                        'lng' : 110.3716474
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rvrn@oos`TAY?wA@oABiDB}A'
                     },
                     'start_location' : {
                        'lat' : -7.801534999999999,
                        'lng' : 110.3693581
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 519
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 58
                     },
                     'end_location' : {
                        'lat' : -7.797060200000001,
                        'lng' : 110.3706677
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Jagalan\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kiri.\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'zvrn@y}s`TaC|@m@ZWFa@Dg@Ho@Ds@Fo@FK@s@FoAJgAH_@Be@DeAFkAFq@@'
                     },
                     'start_location' : {
                        'lat' : -7.801582499999999,
                        'lng' : 110.3716474
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '110 km',
                  'value' : 110164
               },
               'duration' : {
                  'text' : '1 jam 44 menit',
                  'value' : 6237
               },
               'end_address' : 'Pacitan, Jawa Timur, Indonesia',
               'end_location' : {
                  'lat' : -8.1839987,
                  'lng' : 111.104075
               },
               'start_address' : 'Yogyakarta, Kota Yogyakarta, Yogyakarta, Indonesia',
               'start_location' : {
                  'lat' : -7.797060200000001,
                  'lng' : 110.3706677
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 519
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 46
                     },
                     'end_location' : {
                        'lat' : -7.801582499999999,
                        'lng' : 110.3716474
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003eselatan\u003c/b\u003e di \u003cb\u003eJl. Jagalan\u003c/b\u003e menuju \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rzqn@uws`Tp@AjAGdAGd@E^CfAInAKr@GJAn@Gr@Gn@Ef@I`@EVGl@[`C}@'
                     },
                     'start_location' : {
                        'lat' : -7.797060200000001,
                        'lng' : 110.3706677
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,0 km',
                        'value' : 974
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 84
                     },
                     'end_location' : {
                        'lat' : -7.8017901,
                        'lng' : 110.3804796
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'zvrn@y}s`T?}D?YBmABeABy@?kD@uADuB@w@?GBcDF{FBsB?uCA[@uA?[BoA'
                     },
                     'start_location' : {
                        'lat' : -7.801582499999999,
                        'lng' : 110.3716474
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,4 km',
                        'value' : 2396
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 124
                     },
                     'end_location' : {
                        'lat' : -7.802369499999999,
                        'lng' : 110.4022082
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Kusumanegara\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dxrn@_uu`TBsB@{@?]HgA?U@w@AuA?I@y@DcFA_ABiDBkC?cCFiB@}@@_B@e@DeD@sB@i@Ae@DsB@sF@WD}C@m@B}@?}D@}@EsB?MD_BBeC@gA@cAHsF@uE?i@@wB?GHiC?g@?{@?e@DsA@o@'
                     },
                     'start_location' : {
                        'lat' : -7.8017901,
                        'lng' : 110.3804796
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 926
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 98
                     },
                     'end_location' : {
                        'lat' : -7.810695900000001,
                        'lng' : 110.4020933
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Geodong Kuning Utara\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'x{rn@y|y`TlBAZAH?tBBpA@vA@d@?J?J?vDDJ?P?jD@fB@H?F?D?F?vFBj@?jFBt@?Z@J?V?'
                     },
                     'start_location' : {
                        'lat' : -7.802369499999999,
                        'lng' : 110.4022082
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,4 km',
                        'value' : 8407
                     },
                     'duration' : {
                        'text' : '9 menit',
                        'value' : 526
                     },
                     'end_location' : {
                        'lat' : -7.8364769,
                        'lng' : 110.4720799
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Wonosari\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'zotn@a|y`T@y@NwH@{@@c@DcD?q@?S?m@@m@BcB@E@oA@Y@I?AD_@Fa@Nm@DKPc@d@gAJQd@q@RUZ[BCLSBQFODEnAoAzEyFdAeA`EaEf@i@`AgAhBmBbBgBzAiBBAPU\\a@FI^e@Zo@DIn@oAXi@b@y@l@sAl@wAn@wAf@kA|@mBb@aAf@mAXs@nA{CXo@xAaD`@iAHMVm@`@{@b@_A~@}BfAeCLWdAsCPc@b@eAFOLi@Ts@X_APo@Vw@Z{@Pg@HUHU~AyETo@hAaDnAyDfBkF|@mClAgDTs@fAgDRk@DUBOBK@K?KNmBZoEB]PkCDg@JaBBs@B_@?IPyCDi@Bg@R_DDi@@QDe@ZeI`@sIBa@JsBDiAFqAn@kQF{AFcABm@DgABi@B[D_@P_ALiADk@Di@Dc@JaBJiBBg@LuAN_ATkAf@iB@ExAuE@CJ[JYnAmE|AmFNg@dBiG\\iATu@nBwGLc@tA{EPe@dA}CBIj@qBJc@Rq@V{@|@wCRq@Xw@b@oAhBcGNe@x@yCh@mBPm@BMx@mCzA}E'
                     },
                     'start_location' : {
                        'lat' : -7.810695900000001,
                        'lng' : 110.4020933
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,2 km',
                        'value' : 8178
                     },
                     'duration' : {
                        'text' : '7 menit',
                        'value' : 429
                     },
                     'end_location' : {
                        'lat' : -7.866074299999999,
                        'lng' : 110.5112254
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~pyn@oqgaTbDcKx@kCrAgEVy@DI@EFOPs@J]HSHQFMLONONMJKHKN[P_@Pc@BGFSBI@G?I?KAIEQEIEGIKMOWWc@g@A?U[MUIQESEYCe@CUAOEs@AYC]C]CYESIUKQKOKKMKMMQOOMMQIOIWIWEWEYE]AWAK?a@@]BWFU\\s@z@{AJSFQFSBQ?O?MCMEQIWGUGSCEIWIOKMMKMIOGSGMESCm@Ck@CUAKCKEMKQQWc@Uc@Ua@Q[CGAIAI?G?E@EBEDEBCDABCF?DAD?B@D@FBDBBDBF@D?DBF@LBF@DBFBFBFDDFDLFPFJ@J@RBL@TAN?RAp@Kf@M\\E@?VEPCLAL@J?J@J@NBJDTNXNVNXPTRPPJTL^Jb@\\hBF\\Jd@FVBR@T@Z@V@PDLDJHFNJTJ^Fj@Hx@Br@Bf@?l@AhAAd@AP?NBJDLDVJTHNJJHFHHLNXNRPJXPFBRJLDLBH@H?N?PCLCLCRAP?H@H@HDDDBFBF?LANCRAN@TBVDVFTFPHPLRTRTRRJNDVD^BRDNDRHFBTJ`@VbAj@z@f@b@Xf@ZB@NHHDF@D@D?B?@?B?DADABCJIJIHKLQNWFKT_@LOJGHCF?F?F@NBLJJL^b@X^VXHHHFJFBBB@B@@@@?B@B?D?BAFCHEHGBGDEBI@K?IAICIKQMOY[[[wAyAi@i@SUGKGMAKAMBKBIDIHGRKDCJGHGLOLUHUFQL]Ti@V_AXy@Xk@fBmCP[pBoCT[h@}@Ze@`@}@`@gA\\{@X{@Vy@V}@f@oBl@kC^cBDQLi@Ja@H[Ns@T}@BK|@cDdBiEPc@Ve@hA_CfAuBPk@b@iA^cAf@oAZw@b@y@t@gBb@mARu@F[Ja@He@Da@Da@@k@Do@@k@@}A@i@?c@@w@@c@@M@KL]p@yAnB_Ed@aA\\{@Ti@Rc@N]JYJSJOBEBCDERIRGh@ShAm@lBkARMb@Y|@g@VOLIJI@EBGBM@I@I@GBGBEFIDIDEBENKHGJMHIDIBGBG@I?MAWEWCU?G?E@C@EBCHKPSVQZO`@SVKNEJGDEDGFMDOL_@Z{@d@}ARq@NYHKFKHIJG`@QfC}@z@Wv@[^Mb@MZDXDRBTAVCRETGRITQRSPWDMBKDMDQBO@MDQFSDMDKFKHKNOt@w@p@s@HMDM?KDUAKCQMSEI'
                     },
                     'start_location' : {
                        'lat' : -7.8364769,
                        'lng' : 110.4720799
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '15,5 km',
                        'value' : 15549
                     },
                     'duration' : {
                        'text' : '14 menit',
                        'value' : 842
                     },
                     'end_location' : {
                        'lat' : -7.9574837,
                        'lng' : 110.5926512
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eJalan melalui 1 bundaran\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|i_o@efoaT{@Mo@AmBKo@C[GICEAEACAEEEEEEAACECE?CCE?CAEC[CWEqAAWC]CYKaBM}@Ku@Dy@Jq@Ha@HWJUPUPSXc@JQDOTe@LQXWVQTKd@MxCcAnEmBr@YTOJIHMHQ`@kAHUHK@CFG\\ITERGVOHGFIBMBU@W?Q?K@IBOFMHKJGJGLCXGb@KLEDCDEBG@G@G?E?G?EAGCUi@oAg@mAISQc@IYGa@AK@S?E?A?AHk@BKDSHYJm@FWBO@EJw@DWFk@@GBIVk@\\e@FIJGDCDAJGDAF?L?zA?D?JAJEJGFGFGBKDIDKBK?APs@?c@@cB@Y@K?IBGBEDINOXSfAk@r@[t@]\\UNKd@[JINMPOLMHINQFQBW?SCOCWCM?KAI?MBKJUHQLOJSRQr@UHCDCDC@A@C@A@CBUCSAMAIAEAI?I@KBGDEDEFAH?F?NDLDLDF?F@H@H?H?PCLEPGTMTOTQRQJKDGDKBI@MAKGQIUCIAGAEAE?E@G@E@E@CFGPGJEJEBCFEBEDEDGHMR]L_@F]DYBQ@M?Y?Q@KBMDEDKHELGPEf@AZ?RCNGTMPSVYXY@Aj@m@X]BE@G@I?E?GAECGCGGKGGKIg@c@[WQOw@q@_@YQSKOGQCMCOAM@O@UD_@D]P_ARw@Z_Af@}CPeCLoB@yBTmALaAF_AA{@IiAKo@?e@B_@F[L_@R_@V[r@s@f@i@^I`LmCbB]jAUrA_@dAc@x@UfAWvA]`A[fAc@vBaA\\YZOnBe@|Ae@|A_@p@WdDwAtAo@LEJGLIhAu@nBgAl@W\\Uf@_@\\UhBeA`A[@E@A@ABC`@QNEJCVErAS@?jAMBAz@K@?zBUPDb@Ep@E`AEvAWv@IjAMTCXA`@AxAFfBQjB]~@S~@OtAS`Ee@r@W|DcBh@MbAKrAKp@S\\St@_@dAs@lAw@t@q@Rc@VgAXmBJ_AViBR{@d@cApDaHLQZ[RCZDn@Vb@ZZh@p@t@v@r@d@RvAd@h@RJBpDpA^NXH\\B\\@^A^EXMZKDCz@YzE}ANGr@Wf@OzAc@h@QRGlA]JEhA]p@SZIHCnAe@zC}@bA[tBo@fA]f@O`I_C|@YpA_@|@UjAc@|H}GbA{@fDsCdDqCjAcA`Ay@f@c@p@k@`@]nAeAhA}@vCmCx@q@p@k@rF{Er@o@~CqC`Ay@rCcCDC@?dFoEt@o@|@u@`@[`Ay@\\YBClAgAbA{@rCgCPMf@c@XWxAoAZYPOpCaCNMf@c@nBeBFG~BmBZWx@s@BA\\]r@o@hByAn@m@lBaBDC`@]`@_@h@e@b@]d@a@rBgBLI`GeFtHqGxBqBz@u@p@o@`@]^_@Z[FEtAmAdEmD|CiC^_@VUh@e@vAoALM~@w@PMXUdA}@fAaABC^_@HGhAcAHIXWJIx@w@h@_@b@_@VWx@w@JGAA?A?AAA?A?A@??A?A@??A?A@?@A@??A@?@?@?@?@?@@@??@@??@@?xAkAfBgBVUl@g@DElAgAhBaBbA}@@Af@a@h@c@v@w@\\[XWfA_ABCTQxAmAjAcAz@y@LKVWHIb@]\\Y@AZWHKRQ\\[JKBAxCkC'
                     },
                     'start_location' : {
                        'lat' : -7.866074299999999,
                        'lng' : 110.5112254
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,2 km',
                        'value' : 1244
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 62
                     },
                     'end_location' : {
                        'lat' : -7.9656126,
                        'lng' : 110.6003936
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. brigjen katamso\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'feqo@ac_bTrAoAfA_A`@_@DENKh@c@PO`@a@\\YHIb@_@lBgBn@g@b@e@VU~@y@h@e@bA_AtAkA`@]l@k@\\[r@i@r@w@l@m@@APMl@k@p@u@DC`@]Z_@BAPS@C@ABCBCt@{@@CBCx@}@h@g@V[HI|AyA'
                     },
                     'start_location' : {
                        'lat' : -7.9574837,
                        'lng' : 110.5926512
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '51,1 km',
                        'value' : 51101
                     },
                     'duration' : {
                        'text' : '43 menit',
                        'value' : 2606
                     },
                     'end_location' : {
                        'lat' : -8.116537600000001,
                        'lng' : 110.9954263
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`xro@ms`bTV[\\a@LOFGLObAkAz@}@p@s@Z[b@a@p@g@X_@FKLOrCoCV[Z_@JOBG\\Yb@c@`AiABCNMj@i@BCV[FEb@e@p@w@|@aAHIj@m@h@g@f@i@pBsBb@]dCeC\\]^c@zBiCbAcAjBmB\\]nAmAt@u@V[POf@g@JQ|@{@|@}@t@w@r@w@j@o@z@_AfAmAd@c@BAj@o@hAiArA{ADG~C{C@ARSrAuAj@k@VWVWX[BCJKzA_Bb@i@|BaCVYTUR_@FMFMNc@Ne@^sAl@gB@Cr@{Bf@wAt@_Cj@eBn@uBp@kBl@mBTm@Tm@`@qA@Ej@_Bd@uAFSJY^kAf@aBh@{AX}@dA}CPi@Rq@Vw@Vs@JYt@{B`@sAd@yAlAoDd@yAv@aC|AwE\\aAhC}HPk@dA}CZ{@BIp@sBx@aC\\eARm@pB{F@EbAsCDKLa@r@qB@CDOd@yANc@`@kAJ[bAaDFMBIb@oATq@Z_Ar@qBPm@Tk@To@Rg@Z}@xAgERk@Vw@b@kAf@{AFOVs@HW|@gC@CN]DOF[N_@Z{@`@oAZ_ARo@\\aAf@oAZs@JSFEx@eB\\w@Zm@l@oAl@sADIZo@DItAqCv@_B?Cf@aAR[NQGkAQeCOgBAKQgCKyAKcACa@WkC?AAGOoBAEAIEw@Gw@?CI}@G}@Gi@IaAG_ACYGy@Eo@?Q?M?SBoB?OBmE?y@@{A@kB@wA@a@?s@?uA@oA@yD?a@?mD@yB?]@g@@eEDgM?M@_E?M@aJ?C?m@@kD@a@A_AF}H@kA?eH?e@FgJBiE?{C?kDBeE@yEBqCB}C@iA@qC?m@@aB@kC?G?s@?K?cD?E@aE@cB?aA@i@@wC?u@?_B@y@?[@iC?aB?i@BaE?eA@a@BoG@mC@aD?{D@mAD_H@_A?I@_DCuFAQB{A?w@?_@BUFWHUBEP]DEb@c@Ti@Nc@Xe@JYJSPY`@u@NULQLQNUJQNYJMDGFCHCHEl@Kh@KNGRGVOTONIXQLKLMJMDK@IDODIFQDIBEDCHGnAi@`@UPKBAd@]`@]t@s@f@_@l@c@j@a@XUl@o@FIDG@C@EBC?E@G@G?Q?O?O?_@?Q?I@SBOF[H_@BOFWBM@E@E?E@E?C@E?G?C?E?G?C?CAC?CAGCKIYCMKUOUKKQQMMGIAEACEMAK?Q?[@EFi@H[J_@HUb@w@Xi@h@{@xB_D@Cz@iAZa@Xa@nAcBBELSDIBGBI@K@K@S@a@?o@B}A@O@]Di@FaADc@Bq@Bk@B_@@_@Dy@@S@I@GBKBGNSZ]^_@\\YPINM^YJKX[NUDIFSDS@KDWBSDSDO@GDIFIFIFGZ[f@]\\SVUPSh@m@BEf@g@hAiAv@w@r@s@r@q@n@m@n@m@tAsAx@u@`CgCnAmAbCaCzC{CnCkCdAeAFG|BqCLOJM`AsAJMbCcDLOh@}@P_@LYH_@@U@Q?o@GuAIqAM}AAIEWCW?I@KB[Je@FSDUN{@\\_BLg@FUDMLSHMDIDKBOB]@K@MDKR]^e@hAoAr@cAj@s@PUNSPWHOJWP_@L]FKHMRULGNGb@QPIFERQJKJMJSLWZw@F[FQBI@EBEBCBEFEFGf@Qz@WNCJEBCDCBE?C@C@C?C@E?_@?c@C{@A[AMAG?G?G?E?E@_@BQ@M@O?I?G?IAG?IAGCGIWQe@CKE]CeACw@CU?ICIG]Kc@AIAG?K?MAU?GAO?GAMAOAM?Q?[AY?A@WAGCWIUYm@EKGMEICIAG?E?EA[AQCQEKEMIM]g@SYGKQ[O[Qg@COAG?K?G@GBONYR_@\\e@HIDGFMDK@I@K@Y?YAYAWCWAGEKEKOa@Wq@Ia@?IAI@K@I@IBIHWJSJUJOLQV_@NQFKBGBG@I@Y@S?WCSAQQoBAMCa@Aq@Am@Bq@@O@]Bc@Ho@BWD]BY@SAOCS?MAK@_@Bk@Hc@NaAFQbCeCx@y@r@u@LOJQHKDKDGBIHYf@eCHq@d@wCBUBM?I?KASCQCMAK?G@MBSBULq@BIBG^q@LSDKDKFOBODYN{@Lu@Ti@FOFGT]r@}@RQ`@Uh@S`@KLCJAF?DAB@B@D@BBXTLLFDD@D?F?D?HADEFEDEHKR]Zg@\\e@DGDEDCHCRCHCPELEDEJGFIPWJSBKBI?GBO?M?KAK?IAUAO?M?K@OD_@B[BKBKBGBGFGFI`@WRMXUJIHGNQRUDIFILSJ_@d@}BJk@@I?G?G?GACCKc@oAIYAIAG?E?E?E@IBGFQPi@J_@Lk@@G@C?C?C?E?C?CGe@SoACIAKAGCqCAkB?iAHWHWJQHMHIHGNETE~AQ~AWjBU|@GBAD?FAFAHABADCFEFEV[b@q@Zi@Ra@R[@CPYR[Zi@Zo@HMNYJOJM|@qAh@s@^i@PWNUjBgCd@q@X_@X_@JMJMT[T[bAqA`@i@^c@V[LKHIHGHGZQNO\\U`@_@hAsApBiChBoBdAeARQnAmA`AiAPSbB_BLKz@u@|@s@`@[ZSLIJIHGb@Ur@g@^StAs@f@YJEd@Yn@_@NKbBcA^UTMJKJKHM@ADK`@m@|AmB^i@LQdAeBP]^q@Va@FQHQHWF[FY@MBI@IBGDELMROVSNOFIFON]P[JMJMpAmARUPUJOz@sAN[FMJQLO~@mARSxEwFpFiHv@iA`@g@Za@T]PYv@}ADMFKf@cAj@gAHQ^w@?Ad@cALW\\o@pAyBZi@LYJSRg@Vm@J[FO\\}@r@yBBIrA}Df@wAn@mB|A}EHM@CBADEDENILIJGRKzB_An@WrAg@~@YfDq@jCm@nEy@b@ITEJCNGNGtAo@pB}@jBy@hB}@d@W@?fAi@XMb@OpDcA~@Yr@SLEp@Qz@WfA_@d@K~HgCbBi@lEoAf@OTGDAv@QTEd@E^AZAF?XAHAD?DANEHEDEFGDKDIH]Hc@Hi@ZmBFc@@?Jo@~@_FNu@VkBPgAt@iE@IFQHc@DWHe@DMBQ?EF]BUBUDY@I?GDYJw@Fo@Bu@?i@A[Ee@IsBIyBIgBAOCy@?k@CkC?MAsBAoA?gAAi@Au@CiACeAAk@CsA?E?m@C_@GgBGkAAKAaACsA@{@@[BWFu@NiBl@yEJk@Z{ADWJk@VeALi@Je@Ru@BIRw@Pg@To@L[Pg@BEh@{AVu@`@yAV{@Vu@b@cA\\s@FMLUFUFQHi@Jw@RuBVmCd@kEV{B^_DRuBXeCd@}DZ_CZ{CLoAJy@Hq@`@gDj@iEDSLg@FWPs@XiAXmALc@@E?CBK~C_Lr@oCj@wBf@iBj@qB`@kAVg@|@eCl@eCLm@\\{An@uCBK`@oBPw@n@qFfBuK~AsJv@sDd@}EL_APw@DKVkAJo@f@qAx@cB@A^kAl@{Aj@oA\\yAJs@Ek@Mk@Ia@YeBWmAI{ABq@^yAx@sB`@eA^{BBQCi@KyAB}BAaBJgBZoC?CHe@TeB@KAkB?o@?eAA[@i@J{@Ns@Jm@RgAIyF_AuBOgACcASoCMwA?gAFoAV{Bp@{Ch@aBj@_Bd@uA`@aBXaAZoAVkALwE?yA?{BIiAMg@m@oARwBFiANgAVeAxAaDp@eA`@c@n@e@d@a@rFqDhAs@x@e@j@Uj@Ol@Kl@Or@On@U`@Ol@[d@]j@i@`@i@Ta@b@k@jA{@pAcA`DkCNMrAkAj@q@p@uAFGR]Tk@x@{AjAsBTg@UUMOo@y@a@g@Wc@Qi@I]Uu@y@q@i@e@aAq@CAiAo@UMUUMSQk@Ks@?_@@ODQBQFk@@o@?y@E}@KkAO_CSwE@C?C@G@IX_BLs@J[J_@Rg@l@wAZo@Zq@Ri@HYFU@MBM@KAQ?UCgACcBCmAJk@BODODILKJGJGlA]|A]|@W`@OJErCsA|@g@jAs@TKXGPGTKNMRWV_@PYJUFQJe@?qB@mA@q@Bg@B]J_@Pg@\\i@jAyARWTWPUNSHODQ@WA[Ei@Gq@Ei@MoBEwBAeA?mABgAV}FAq@E}@OsBIaAC{@?g@@Q?Q?Q?QAIEIIIIGIGGICI?MBIFEJCR@^B|@@hABdA?rABv@A^CZERIRGJILSBOBUAWA]?SAW@SBOBKFILKTOLIFIBG@K@M@OAOEQY[aAq@o@_@YWSWKWCU?m@@_@@IFk@Ac@E_@Ic@Wo@Wq@Uq@Qm@Ie@Gc@A_@@o@F]No@\\o@b@a@d@e@TYHQBQAQAQIUS]Ue@Q_@MQOOUOMOOU]s@KYGYA[@_@?Y@A?[CWG]Ko@Ii@E_@A[?_@@YFYPc@L]JUJWPe@FYDYD[@CF_@J_@Tc@PWNYDOHUBS?]Ao@CaACmBGgCIqC@MCeB?gA@k@?a@Aa@A[Gm@Ia@Mk@UgAKy@DiARcCZ{DHq@Lu@RiAZiA^y@x@aA~@w@XUXQLSJSF_@Bu@?_B@wBEaBIgAGw@Oo@Ga@I[Ic@CQAc@?c@NaAJo@Da@BW?M?SI[KUU]g@w@{@oAeAsBY{@YgAMs@K}@EgAB{ALsAJuADc@f@wEXyCH}@Da@FQHMLMr@k@TU^[h@k@@AdAqAnAwBbCaD|@{@LSHKNYJSBS@SGWEc@@[Fa@Ru@Vm@BITa@r@sATYPUT[j@q@n@u@f@m@|@_An@s@RSb@_@FEl@a@pDcCLKpCoBZSHGHCLCTAH?b@AN?RCJCFCFEDGFMRaA@En@_DNq@BQ@IB]DaA@_A@UBSDWPo@Rk@BIDKN[Rc@^g@NQTWV[JOFKBK?KAWIcACcAE]COESCUAE?I@SNcANu@@GLk@Hc@XcBDQ~@mFRcALm@?ARy@b@uBDWN}@`@qC\\oCLiAHc@N[DG\\o@T[BEd@g@HILSN[?ARi@Vs@Z_ADGPa@BKPY@CXc@NWDKDKBS@WDc@HkBFkAFcAJaAFq@Hq@BQFc@Jk@No@Lg@DMHUJ_@BQB['
                     },
                     'start_location' : {
                        'lat' : -7.9656126,
                        'lng' : 110.6003936
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,8 km',
                        'value' : 1755
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 150
                     },
                     'end_location' : {
                        'lat' : -8.1281342,
                        'lng' : 111.0036137
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Pacitan Donorojo\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jgpp@mxmdT`@KbBg@VIpBi@l@Q@?RKNIJGJQLWHMj@yAj@cBFONa@DKDGDGDEJKZQRINGROLKNU`BwC`@k@n@w@vAuAh@c@XINCP?fCZ~BZf@B`@@TCNGJCZO\\S^UDGFKJQ`@y@DIDEDCFCFED?LAL?J@JBPFLHDBJHHFHBB?F?F?DAd@_@hB{AbAo@hFiD~@o@h@k@HOBO@C?C?EC[CWCS?G?O'
                     },
                     'start_location' : {
                        'lat' : -8.116537600000001,
                        'lng' : 110.9954263
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,6 km',
                        'value' : 8643
                     },
                     'duration' : {
                        'text' : '9 menit',
                        'value' : 550
                     },
                     'end_location' : {
                        'lat' : -8.1710102,
                        'lng' : 111.0483894
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Pacitan Donorojo/Jl. Pacitan-Solo\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Pacitan Donorojo\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'xorp@qkodTPKBABADAH@L?HBF?D@B?J?L?NCnD}@nDcAdAe@x@]\\KZEv@EpB@p@@r@ARCHEDCDEj@wBb@wA@AZq@PYP[x@oAz@wAh@}@dAaBZg@DIT_@Zi@DGZe@b@s@NSV_@Vc@JQDKBG@GHa@Da@Fo@He@Fc@BUHYN_A@KVwA\\kBVuALq@P}@Fa@RsABQD_@P}ALcA?CDWP{ARaB?EVuBVsBF]DW@K@IBIDIBGBGBEFGTYVWj@q@PQ\\_@ZYTSLILGJCREZCHAHAXCr@Ij@Eb@EVAn@Cx@CF?t@A@?ZA@?LAVE`@I^IVGDATG`@KHC`@KTITILId@Wh@[NI\\QfB}@f@MJCHCJEVIRIHCLGLITMBARMLGJEFCFCFA@?BAFAF?D?^CNAPCPAPALALC@?LCJELGLEFCDCFGDCBEX_@r@gATWFE?AHGZWHKTQFGf@g@FEHGFEFCDCl@QTIPITKJGHEDCDCRGNENEJAJAPANATAR?L@D?H@J?PDJ@`@JRFVJHDHD@@HDXTHFRPl@h@LJ`@\\h@`@LHPJPJJBLBJ@F@D?F?D?J?FAJAJAHAJCJANEt@_@LGFEFEDAFCFAXGDADAD?JCFAFAHCDCFCDCBCDABABADCDADABADAB?FAF?JAF?H?H?NCF?FCFCFCBCHEDEFGLMFMBGFMFKDGBGDCBCBABAFAt@CF?JAHAFARGPIHGDEBGBC@E@G@E?C?I?EAGAESi@CGAEACAE?E?E@C?C@CBCPKfAm@RMFIDEFKBK@E?G?EAC?CAEACACCGGGECEAGCaAe@CACCCCAECEAEAI?M?K?K@I@E?CBCBEBEDEDCBCFATGz@KFCHCFADCDGHGJOFKBCFMHUH_@BQBQBo@@c@Bo@AK?IAGAGAECGCICECGEGEEiAeAGIEEMQSUIK]c@u@_AEGMQe@m@KKOQGGKGECAAIGKCKEQGC?]IYIGACACAECCCQQCECEOYEMCGAECULYN_@Ro@Ri@@?DM@EDEBCBEDCBCFCXKj@M`@KJCHEDCDABEDEBGJWFMDSBE@CBCBCDEDCBAFCZGHCHAFAXCD?VAj@?XAJ?B?B?FAD?FAd@ITIf@M@?h@Mj@OLEJC\\GBAF?D?HAB?B?v@?P@L?L?FAFAFAFCDCFEDEDIDG@IFYLoBF{ANwBDs@@QBQAG?EAE?CACCCECYKUEMCOGIEGCEEEGCIAIAK?C@E@EBGBCFEDCDABAB?B?B?@?D@B?JBHBD@B?D?B?B?BAB?BABABCr@o@^g@FM@I@G@E?KEo@CMGMEIIMMWSUOWQQEIKMCIEGAEAEAI?K?OBKBIBGDGDGFEDADCFAJAv@?FAD?BAVKJEJE@AJELEHCF?FAD?D?D?^@PBH@L@N@vANP@H@H?L@NAF?FALCFARGPMJGXYT_@DGNULQBCBCDCBADAHANED?FAHCf@MDCLGLGTQRUHKFGNQh@k@JM`@g@f@m@XYZ_@^c@ROTSb@]`@[^W^Yl@e@DCRO`@[ZWROdB_Bp@u@rB_Cb@i@\\_@v@}@LMz@aA^a@p@q@^_@jBgBJIxA{A@ALORS\\e@\\c@|@qAp@oA'
                     },
                     'start_location' : {
                        'lat' : -8.1281342,
                        'lng' : 111.0036137
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,9 km',
                        'value' : 8921
                     },
                     'duration' : {
                        'text' : '9 menit',
                        'value' : 516
                     },
                     'end_location' : {
                        'lat' : -8.195588499999999,
                        'lng' : 111.0997003
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Pacitan-Pringkutu/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'x{zp@mcxdTb@aAf@mAn@qAZo@JWHQ^q@Ti@DMH[Ja@Ji@@CFe@BQ@Y@G?M?Q?c@?AAgA?G?G?I?G@G?GBIHQFMXo@HUH]D]Fi@@_@BW?YAUAIAKGYIc@Qq@]kAe@kB]iACQMg@Ok@Qm@Se@S_@OSIMUWOOOUEOAI@KDMJMz@w@d@_@b@[ZYf@c@JKBG@G?KAAAESa@EOGOAG?EAE?G?K?I?GBSLw@Jq@@CJe@Pu@FQDKBGLMBABCLELEHCD?\\E\\C\\AZGDCFAXOFCHIHODKDM@K?MAMAK?EESGSACM_@MWAEEIAICK@[@O@IBIBKDMHI^_@f@g@BCPQNKHEDCLGHGHGDEBEDEBGDK@G@C?GAI?I?MAKAOAO@MBM@GDI?ALY@CBI@ABO@O?U?GAG?ECECECECCYWWSMMCEAE?E?C?G@EBCHIDEHIJI@EBG?CHi@BWF]DS?CJo@Hc@BO@I?E@G?G?k@?EAG?EAA?A?ACAAAA?CAC?C?MAEAI?OCICMEIEIGCCAECI?K?C?K?OBS@EBIDKFKV]\\e@JU?C@I?EAAAAACAAAAAAC?CAC?E?G@MBMBG@E?G?G?CACCCACEACAEAC?E?K@IBIBGDCDCHELANCF?HAF?FCFADEDGFERYNQHKDI@G?KCOGGCIEO?MD[DUBM@KBW@M@KHSLWBE`@w@FKNSFENMn@_@NMXS`@a@DEHQTa@Nc@DQH[DKFMHODCDCFAF@B?B@B?DBFB`@ZdAt@JLJNDJBJ?R?rABN@HHJHJJJDJBFDNDN^v@@Bd@bAFHFHJFp@n@n@`@VNVLNDL@hBV^H^FNBTD\\Fb@JTH^LVLVLVP\\TFFDDDFBDBBBDBB?@DDFDFDRFPDd@FF@t@JH@JBD@DBFDHDDFJDBBFBD@LDL@H@F@L@HDx@\\~@d@bAp@d@^^T^PLDJBTBz@HbALB?VBX@f@Bd@@\\?^?P?DAJAHCfAe@FAtAi@NEJEFADAD?B?@@J?JBB?F@LBD@DAB?RGZMr@Wl@W\\KNGPCZEDAVCb@GNERILG@?JINMRU@CBC@ABADAf@Kf@IPCD?FCHC`@OPIPKRORQPSJKDCV_@Va@Pa@FMDKDKBKDQBQDYDWDa@@EBMF]Hg@DYBa@DWBSFSDQDKDMFKFIFGJEJGJELEHCHCFGFCBC@C@C?C@EAC?EACCCECIAMAM?KAMCMEMCMIKGKIKIKKGKEKCEAI@I@OJg@Vs@@GLa@Pk@Tm@Xw@Re@Pc@Re@N]Pc@FQDIFUDOHUDUFYDSD[@QBMFq@BY@WBWBUBOFM?ABEBCBEFC`@ODCFCBA@A@E@EBIBSFa@DMDMDKJMT[V[JOHIFGRUDEFEFMZe@\\m@FIBEHOVe@HMDGJU@GBG@KJi@DUBU?CBUBODg@@S@I@c@?E?Q?WAOCeBAcAC}@?e@ASAw@?w@Ao@?k@?Y?KAc@?i@AS?O?I?Q?K?[Aa@?QAk@?MA]AY?M?EAS?GAY?WC}@?i@?[?EAY?]Ao@?[Ac@AW?Q?UA[As@A}@?WAuAAc@?Q?MAi@A_@?i@Ag@?]A_@?c@A_@?s@Ak@A[Ac@?]AO?QAy@?o@Ak@?[?IAcBA}@CoB?k@A[?UAq@?o@A}@?GAk@?GA}@A[AcAAgAAcAAc@?E?UAo@?_AA}@?MAw@'
                     },
                     'start_location' : {
                        'lat' : -8.1710102,
                        'lng' : 111.0483894
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,3 km',
                        'value' : 312
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -8.1929216,
                        'lng' : 111.1005432
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'lu_q@cdbeTa@QQG[Ki@S}Bg@uB[gAQ_BW'
                     },
                     'start_location' : {
                        'lat' : -8.195588499999999,
                        'lng' : 111.0997003
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '47 m',
                        'value' : 47
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 16
                     },
                     'end_location' : {
                        'lat' : -8.1929854,
                        'lng' : 111.1009696
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'vd_q@kibeTLuA'
                     },
                     'start_location' : {
                        'lat' : -8.1929216,
                        'lng' : 111.1005432
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 572
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 65
                     },
                     'end_location' : {
                        'lat' : -8.188011099999999,
                        'lng' : 111.1021521
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1',
                     'polyline' : {
                        'points' : 'de_q@albeTe@EOAc@GUCqAQo@Ig@Gk@EOCSEYGGAeBa@o@M[EQCkAc@q@UYIOCGAMCSC[Ca@CYAk@AKAS?W?E?'
                     },
                     'start_location' : {
                        'lat' : -8.1929854,
                        'lng' : 111.1009696
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 229
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 23
                     },
                     'end_location' : {
                        'lat' : -8.1861341,
                        'lng' : 111.1026704
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : '`f~p@msbeTU?O@M@UBa@@}@?SAOCWCYGWKWOOK[WIIQU'
                     },
                     'start_location' : {
                        'lat' : -8.188011099999999,
                        'lng' : 111.1021521
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '48 m',
                        'value' : 48
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 16
                     },
                     'end_location' : {
                        'lat' : -8.186170600000001,
                        'lng' : 111.1031075
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'hz}p@uvbeTB_@@]@Y'
                     },
                     'start_location' : {
                        'lat' : -8.1861341,
                        'lng' : 111.1026704
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 186
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -8.1853715,
                        'lng' : 111.1039877
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1',
                     'polyline' : {
                        'points' : 'pz}p@mybeT[CWEQAWC{@IQAE?CAAAAA?A?A?E?IBK@GBI@C@A@C?A?C?C?C?C?E?A?C@KDS@S'
                     },
                     'start_location' : {
                        'lat' : -8.186170600000001,
                        'lng' : 111.1031075
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 157
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 29
                     },
                     'end_location' : {
                        'lat' : -8.1839987,
                        'lng' : 111.104075
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'pu}p@}~beTm@Ii@MGCGAG?K?I@K?I@G@G?I?S?]AS?I?E@CBA@'
                     },
                     'start_location' : {
                        'lat' : -8.1853715,
                        'lng' : 111.1039877
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '339 km',
                  'value' : 339181
               },
               'duration' : {
                  'text' : '5 jam 30 menit',
                  'value' : 19792
               },
               'end_address' : 'Lumajang, Jawa Timur, Indonesia',
               'end_location' : {
                  'lat' : -8.1329552,
                  'lng' : 113.216387
               },
               'start_address' : 'Pacitan, Jawa Timur, Indonesia',
               'start_location' : {
                  'lat' : -8.1839987,
                  'lng' : 111.104075
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0,9 km',
                        'value' : 902
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 100
                     },
                     'end_location' : {
                        'lat' : -8.1919065,
                        'lng' : 111.1043494
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003etenggara\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~l}p@o_ceT@ABCDAH?R?\\@R?H?F?FAHAJ?HAJ?F?F@FBh@Ll@HZF\\DXBN@n@FVBHCFAJAR?p@AB?bA@H@l@@v@DB?PBT@\\?F?DAFAHEFCFCPITILCLCLAF?J?H?R?r@AHARCPCXGHCJEHEVKRILCVIBALCLAHCTCJATCT?T?Z@L@r@D`AJv@F'
                     },
                     'start_location' : {
                        'lat' : -8.1839987,
                        'lng' : 111.104075
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 375
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 55
                     },
                     'end_location' : {
                        'lat' : -8.1936269,
                        'lng' : 111.1068953
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Veteran\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'l~~p@eaceTBON}@@EF]f@wCHe@Jo@F]DQBGDGBCDCJE~@WVGtBo@'
                     },
                     'start_location' : {
                        'lat' : -8.1919065,
                        'lng' : 111.1043494
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 450
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 53
                     },
                     'end_location' : {
                        'lat' : -8.194422700000002,
                        'lng' : 111.1108453
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya Pacitan - Ponorogo\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'di_q@cqceTB]@O@MBOB]Dk@Fm@Ba@@KBWB]@IFq@BU@EFe@Hq@Da@D{@FcABUB]De@FYFOFIDANK'
                     },
                     'start_location' : {
                        'lat' : -8.1936269,
                        'lng' : 111.1068953
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '9,8 km',
                        'value' : 9765
                     },
                     'duration' : {
                        'text' : '9 menit',
                        'value' : 526
                     },
                     'end_location' : {
                        'lat' : -8.124946899999999,
                        'lng' : 111.1463685
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya Pacitan - Ponorogo\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'bn_q@yideTCiAAMEo@C[EYCOGUI_@Mg@I[CKEKS]S_@a@q@u@cAe@i@OQMMKKQMGEKGMIUKWKIEKEGAGCIAE?G?E?E?E@E?E@G@I@IBODSDc@J_@J}Ab@s@Rm@NOBE@G@I@E?E?G?E?G?G?EAGAKAQEeAYw@WQGi@Sa@MmAa@kAa@k@SeA]q@UeBk@aDkAmA_@uAe@{Ai@{Ag@qAe@_Bk@qBs@c@Og@QgA_@wAc@o@OYIICu@Ue@OQGWK_A_@YKiCiAiAc@?AcBm@eCy@{CiAA?e@QECyAg@YIWIc@OCAq@SCAw@WkA]aAY_@MOGEA_@OYM]Sk@g@a@a@]YOMKGKCOEWC_@Ci@?gAAS?u@?u@?[@Q@O@O@YDWDUBW@Y?WAWAQAIAMAUEGA_@K[IMEu@Wo@Us@YIEo@YCA[OQGEASCu@MMEMESM]Q_@Qg@QqBq@c@Ma@I]EYCg@AsCEuACO?WCOC]G[Iq@Sy@Ue@KWGiBc@mA[k@M_AUu@QSEUCQ?Q?O?QDKDA?WPUHMDG@K@A?M?]CIAUEUEKCGAQCO?O@M@IBUHGDMDKBO@G@G?M?MAWGc@I[IMAOEEAKCQGUKCAIEAAQMUUSSEEOOIECC]YSKMGIAMAE?G?KBYHe@NUDI@M@e@@[@]?OAQ?OCYGSKUMQOQWUa@IKKGKGICICG?IAG@K?G@[@[Bc@@k@?aACcAAu@?o@?q@Bm@Dg@D[HUFi@Ly@R_@FYFK@E?[BO?SAQCYCc@Gc@Ia@K_@M]Se@U}@c@kAm@i@WOI[M[IKCYMGCGCKGOMQQMQcB_Dg@uAMc@ESKe@g@}Bi@yAO_@CGEIQW_CaDGIEGSUUW_@[A?YQc@Qa@Q[K[GgKsAaBSmAUYGk@S[O[UOOWWUYWQWQ[SWSMMOWIKMYOUQSSYQQS_@]k@c@}@MUc@o@c@{@Ym@o@qBmAuDYcAO_@EGCCEEECEACAGAKAOAY?YAGAEAKCIIMQS[Qc@Mc@ISM]Wm@EGEIUm@Mg@Ke@AKCUCYAWCa@AWGYI[KUGSMQQOMSMOMQMWEOAQ@UHSLODODM?MAOCUKe@Ue@KSAE?G@GBS?I?I]gAYo@_AuBKYEKEMEYIc@I_@IYEOEICGGG]Uc@[KIEGEGCKCIAGCMAM@]@[D[BU?I?G?KAIAGCGCECEIEECIAMA[@Q@Q?QCi@ESEc@?q@?A?cA?y@@eACA?iAC_@CQA[?_AFaCJcBFA?_B?sB?gA@w@?{@FOBOFYL_@T]Pg@Lk@NA?a@JWDUBQ?K@'
                     },
                     'start_location' : {
                        'lat' : -8.194422700000002,
                        'lng' : 111.1108453
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '45,8 km',
                        'value' : 45767
                     },
                     'duration' : {
                        'text' : '43 menit',
                        'value' : 2604
                     },
                     'end_location' : {
                        'lat' : -8.0360017,
                        'lng' : 111.414656
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Raya Pacitan - Ponorogo\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '|{qp@ygkeTMc@K_@Mm@?AEa@CIFyC@iA?u@@GAkBAQ@K@i@@e@B_A@gAAg@C[K_@O_@GYG[Ca@AsB?sABwADs@?c@E]Ia@Kg@Ek@A_A?k@@a@Bi@AeB?CAYCo@EeAA[C]EQEQAAGQKWQ[Yg@[e@EIOWCC]u@O[KOIOCIAACIAG?G?I@SBYFk@BSDWF[Hc@Nk@FUNk@Tq@Rc@Vc@LYDc@Bk@Aw@AYE[GWIUCKUs@[cA]sAa@kAK]Og@Ss@Im@Ck@Ce@N}@b@u@FGfAsABIPYFYDc@B_@@WB_@Dm@Ba@BW?EBOBO@QBO@SCMCICGGGOOKMOQQ[EKAOCK?QB_ADc@Jo@De@?aAFyABkABo@Bi@Ac@CSAECCACACCCCCAECKEMCO?M?O@KDKN_@H[?AHy@Dm@D]F]Ts@JYJ[DS?M?QIYGQa@w@]u@KOMOKIMEOEOCU?M?OBOBM@QASAQG_@OSOSSSOa@_@c@]IIQIOKMMIMIMIUEOGSIQIOKMIKKGMGWMSIYKQE[IQGOGQEQAWAYEYGg@Mm@Uc@O[QWQc@_@MMKOMSS]u@cAIKW[OSISEQEUCUGUG]Qq@ISGMKMQQEIGEYc@Yc@Ye@QYQ[}@iBK[IWCOKgAGs@MmAGw@IgACWCYAOAUCQCSG]EQCMGOEIOUQWIMGKWa@SWOSSUW]KOOQGKIMKUGOEMUq@KWOQSW[]KMKKOOGGGCECQI[SOICAIGGCEGKIIKIIGIGIEIEEEESI]OSISGOGMI]KUKYG[IKEC?IAMC_@GYMMIYMQM[WKIEGY[EGIEIGKCaAUQIECOWIOOg@Oe@aCaKq@mCC_@B[dAuCFQF]^kELcCCSIOOO[MoAEOAYCOCWOsC}B]a@Qa@eCaNSc@Wa@gSyJUKo@E}GL{AFa@AsACI?OBs@VU@K@uBWWCYCm@CaAEI?[Go@UMEWAW?[JgBfAQDK@YAo@C{BOyGe@u@EeGY_BG]Aq@GIKIOKg@SoAMqACOCGEIc@m@CCKOCCIOQe@IWKg@Ee@A_@BUBQFWJUHQR_@r@uADO?ABIb@sDF]HYN[PS|A{A\\]HMBOAKo@gCGa@CY@[Ba@Fm@HYV_A@I?KAGOsBG{@I}ABaAJc@J_@V_APu@Ls@@IJgAN}A?M@K?WA[OeACKG]I[]uACOSk@Uq@Oe@I[k@wBGSEKGIi@u@GKOu@M]]aAGUUiAu@aFAO@QFUP[DGt@iAhBkCd@q@T_@DGDQ@SB]@i@?QAOCGEGe@e@EIGOGWAa@n@cF?WEWIQIKIEyDgAg@a@U[KUIe@?uB?_AEk@EUGSIQEMMSQSsA{@c@WQKQEmAIK?GCIEGGGKcAuBs@cAIOEQE]?]BUd@kDVgAz@yBR_@`@}@`AqB`B}CHW?KCKISIIIEEA_ASkBQYGSKOMQMIKk@cAGMKe@Q{AO}@[wC?AKs@M]gA{CYy@Ia@GYCYCc@?q@Ba@Dk@BOJi@LYPWxAeB\\e@b@u@T[JKZWTMZQ~Am@ZYFIHU?IAcBG{@Ma@GO{@iAqC{DCCMMQOYSOKUIiA[g@M_A_@YQQQKMiCsDUY]o@Sc@yAeDm@gAGMGIEIcEkDOOEGEOKc@EMSYEM@SDSTe@XYLKVIpBKLENGJGJMFOFSDYFa@?QOyB?[@UHw@FYTs@N]P_@`@m@\\o@He@Ee@MUKSSMUSyD{BSIQAMDGDs@`Aa@`@IFOFgCp@q@V{GnDIFYXGDOHWHWBUASEiC{@IGKMEKEO?S@Kb@aBhAyHL}@P]X]lL_G|@w@Xc@No@Fo@?W?WKU[Sc@Aa@D{CnAoAT{@Bq@@cAEg@G[GyBk@uBoAoB_BkCmCoCmCkBaB}@gAMQWu@WeAEYKcBEWGUIIMEMAUAa@Bi@AcAC_ASaAa@e@YQOMQGQESA[?[Da@De@Dc@ZkAJq@Bk@Ci@ISMOSMYISEaAI{@Mq@Oi@SUMSMOKKIOIKIKKEKGQIa@Ec@@[FYVe@\\g@XWf@Wz@[|@UNGFEBI?ICIEKAAEKIK_@[SMQEMCYAM?OCUMq@a@MKKOOk@[aBEQEMGKIIOGOEKAM?M?M@WFWJg@Tu@Vw@`@EDCFI^GREHIDKBo@JOBS@I?I?G?GAWCOAIAK?K?I?I@I?G@I@I?IAGAIEEEEGGGGCIEIEGCQIICIEEEIICGCGAM?U@M@]DY@MDSHQFKLOLOPOXSLQHMFGDIDIBEBK@G?ICIAIMU}@}@eAiAg@a@cAm@QO]e@}@mA]eAUm@EQCQCi@M}@Sc@WY_@Yq@[]MqA[iAg@OEKAS?OBQHOLOHMFQD[DMASGKIGOKg@UgAKk@Ak@De@Lg@\\aA`@k@n@o@lB_Bp@]TMNIFGFMBW@QDOFMJMl@g@zAcAv@q@Va@Pa@HSBWMm@Ya@e@_@a@S_Bk@}Bk@q@Sc@Ki@]a@_@_@c@OYQe@UaAIs@?o@Ja@\\{@NULKPI\\Eb@A^CRGJGDI@M?GCKGQu@y@qHmEa@k@c@g@Y_@W_@KQGMEOCQAK?WD]DYLc@Ni@DMReATq@FQBG@E?C?C?E?CACAGCEACCCAA?AA?A??AE?IAG?O@M?KAK?A?KAICGEKGIM[k@ISIQEOAOCm@A_AJiAH}@Jg@N]z@iB|@mBXm@Na@DODU@U?[]uDA]B_@Da@H[H[J_@JYDW@Q?K?EAGAICEEEUYKOAECGI]GWC]AY?S@WD_@Nk@BKDIFGFGLGLEPCHAH?L?x@Br@DzBZ|@@J@LAHAHCFGDGBKBMFWD]R{AD_@@Q?G@K?M?IAEAICKCIEECEEIMMIOGMEMOi@gAaGSk@Yw@KUKQGKMOMQIGIEWMUMIIGIEEEICIAKAMAM?Y@_@D_@D]XyAVaATgANe@FYDWDa@Be@@c@?MBOBMJSj@y@TUf@a@p@a@|@[x@Ub@MRINKDEBCBC@G@I@E?GAG?EACCEACCECAQQi@_@y@c@[OIEKKQWO]Qi@G_@AY?S@Q@OFOJ[HQFGHIROXMrAy@VMRK\\OTMNEPGHAHAJ?HAJ@L@L@HBR?XDN@PBZDRFJDJFJFTRLJFDBBB@D@DB@?B?B@@?D?BAB?D?DADCFEBCBEBE?C@E?EEe@Is@Gk@CO@YBi@Fc@FYDOFOFOHKJKJGJEj@O~@Qt@Qv@O^CPCNEBADEDGDO@KBKFSBM?G@I?GAG?EAEI]K[Oc@MWKKIKGKCGAEAE@E@EBEHIJIDIFMFYRo@Ha@BQBY@QBY?CAE?GAGAGCGEGGIa@a@KQCECGAEAG?E?KAOCM?CAAAECCECECECECGAG?GAE?O@C?EAC?CAA?CAAAAA?A?AAC@A?C?C?C@C@EBEDIBI@E@G@KAG?O?O?YAa@?_@GoAAw@Cw@C[A[AUCQGMGMKOKIIIIECCCECEAE?I?E?E@EBCBEHEFCHAJAH?t@?d@ANAJAHAFCBABA@A@A?A@A?A?A?C?C?EAEAICCAGCICK?EAE?E?E@E@IBMFSDM@I@K?G?GAEAE?CAAAC?AA?AAAAAACAEAICMGKEMIMMOSQWQSKGMEMEMCQECAEEIKIKIIGEGEIEOEMGGECEMMGOCCCICIAI?O?G@G?G@E?A@C@A@CBADCHAN?R@P?JALCFEJGHGHCJAJAN@L@HBNHXPRHLFDDFD@?B?@@@?DAF?HAJCBABC@ABEBG@G@I?O?M?G?EAKAGAGCECCMMKKMKMMEKGKCICKCICIEGIMKMSSEGEEAECE?EAE@E?E@E@CBEBCBADCFAFCF?JAL?XAf@C`@Cb@CN?H?HCHADCDCBEDGFI@G?E@CAICKCQKYIc@Cc@CY@Q@M@ODOBEBEJMPSDGBE?C@C?C?C@E?CAE?ECCAEKOEGCGAGAK@K@KDOPo@Rk@N[b@uA?E?EAG?AAAA?GACAGAIAUA_@GUESAQ?QBMFOLOJWHUBS@YAe@Ig@Me@Qm@a@g@e@u@w@YUSQIGCEECAAC?CAC?C?E?C?G@E@IDGBQPSTIFKJIDIDKBGBQ@OBOBSFOFSNQLSFODU@W@[?QAG?G?E@CBCDEDEFGBEBG@I@G@I?EAC?CCCACECKCEGGIIGCIAKAMBMDSNKHMHODK@M?Q?OCWCUCMCQEMGKIEICKCQ?Y?oA?_@C_@C_@A[?O?I?KAMAE?EAEAECECECCEAE?GAI@G?gAP_@Jo@RYH]Fa@Bg@Ba@?YCWE[I_@MEAMI_@YUSYUk@e@ACCEACAC?EAC@I@ODODUPc@Po@Nm@Lk@B[@MCOCKIQIKGGICMAO?_@B[BYD]H]Nc@PUHWLe@\\a@\\SNOJSHSDU@_@B_@?aAAyAEcBCeADq@@{@@{@F[@Q@O?K?C?EAIAUG]I_@MOGGECCCECGAOASC_@Ci@Eo@AQAGEQAICKEKCKW_@M[CGEGCICIACAE?C?CAG@C?C?C@C?C@A@C@CBC@CBCFEFEFEPIXOZQLGDEDCDEBE@CBC?A@A?A@C?A?E@K?E?E@E?A@C?A@CBEDE@A@CBABABABAFCFAFAFAPANAN?PAFAF?DADAHEHEHGHGFIFIDI@E@E@E@E@G?E?A?C?C?AAA?AACACACCECGIKKK]o@QYQ[CCCECCAAAAAAA?AAA?A?CAC?C?E?C?I@QDQDWDK@K@K?E?EAE?EAAAA?CAAACAAAAAAACECECGAEAC?A?C?C?C?C?C@C?C@CBEBGBE@ABC@ABA@A@?BABABAHAHAP?HAH?HAJATGHCHCHEBCBADEDGDEBGBEBG?C@C?C@C?C?C?EAEAECKCKEKCKEIAEAEAKAIAI?E?E?C@A?E@K@E?E?E?C?A?CAA?CCEACACCCCCACGGCACCEACACAEAC?CAI?GAG@I?G@Q@YDYDQBO@I@G?I?I?EAEAKCKEKGGEEEEEEEIOCECGCICIEQCSASAM?MAGAE?CAA?CACACCAACCCAACAAAA?AAA?A?A?A?A?A?E?C?C@C@I@IBIDE@C@EBCBCBCBA@C@A@A@A@A?A?C@A?C?A?C?A?G?EAEAEAKCIEKCECEAEAGAKCMEGAECCAAAGCEECEKKIKIMIMIMCECCAACAACGCKGMGECCAAACCAACCEKGKACCE?CACAGAOAGAGAGAC?AAA?AAACEEGMOUYIMEECGAECGCKCMEMOe@Qg@Mi@Ki@AKAAAM?G?IAQ?GAI?CACAC?A?AAA?AAAEECCEEIICEAAACACAACGAGAGEOAQC]A_@Gm@Gk@Ge@EQAICGGQAGACACAC?CAIAQAQ?IAG?EAECKGWSm@g@mBKe@EQCIAI?G?GAQ?GAG?GACAC?CAAAECCCEGIGIIIKGIGEAGCEAGAMCMAOA{AMKEMCKAGAG?I?G?K@IBKBIBGBEBMHYTEBGDEBC@C@A@A?E@E?A?A?C?C?CAC?EAECEACCCCAAAACCACAA?CAA?A?AGMCECEACACCGGOEECGEECCCACCCAECCAICIAGAG?O?O?G?E@I@K@C?E?A?A?C?A?AAA?AACCCAAAACCAACACAEACAEAI?CAEIc@AIG]Ic@?C?A?AACAAAA?ACCACCCAAA?AACAC?AAEAE?GAEAA?CAC??AA?AAA?CCCCACEGEGKQGQGSAICI?KAKAK?EAA?AACAAAECECCIIGIQOQMc@YMGKIECEEAAACAAAA?AAA?AAA?C?CAE?GAK?MEmAAw@?C?E?C?K?E?EAC?CAAACACACAACCACCACAAAAACAGAICGAWGICECCAGCEEGGGICCCEGIEIEKEKCMCMAMAO?O@_@B_A@G?G?C?C?C?A?AAA?AACACACACACCAACCAAAEACCEAKAKCa@I_@Ek@GWCKAKCKCKECAA?GECAACAACCAECECEEKEKEIEIKQ[c@IIMOMMMKOKOIKEECOG]QYS_@[UU_@e@g@k@OQOO_@[{FQk@OYKKEKCOEQAOCQ?u@CcACc@?sAB[@]@I@K@IBIBSDQEQEIAG?IAI?M@K@YDYFM@G@E?C?C?G?OCMAOCg@Ki@KKCGCEAECECCE?GAC?C?A?C?C@A?C@A@E@EDIDIDMDMDK@G@E?I?I?I?E?CAEAECIEIAE?EAC?CAE?O?O@O@MBO@MDMDKBILUDI@ABG@G@A?C@E?G?E?GAEAMCQEOGMIOIMKKUSWWKKMIMIMG[Oy@e@QKGCCAECA?CAE?KAMAKAk@CWBY@W?KAKAWEUGUIUIKCEAECAACAAAAAAAACA??AAA?A?A?AAC@C?C?C@C?A@A?A@A?A@ABC@A@ABADCDCDADAFANCNCPAF?FAj@GPADAD?HAD?BAD?@AB?@ABA@A@A@A?A@A@C?A@C?E@E?C?E?MAEAG?EAGEKCKCEAEEGCECAACCACAEEGAECGCOCSEUCGAG?C?C?C?A?A?C@C?MDE@A@C@CBCBADEJEREN?BA@A@C@C@A?C@A?A?C?E?EAGAEAIEECMGw@e@s@a@iAo@k@Y[IGAE?G@G@I@EBIDKHSPKJIFIDGDOFMFWHC?E@CAC?CAECCACEACAGAE?E@KJUJWNa@FMDEFGDCFGPKNOFGBGBEDIBE@EBG?C@C?C?C?GAEAICKIYK_@E]C[Cc@Aa@C_@EWG]EOEMGKGIKIQMOOEIGKCIEMAEEIEEEGEEKCQCSEKAKCAACCCCCCAC?GAC@M@MD[B[BWBOBMBIBGBGHKJMNKt@g@DEBCBE@C?E?G?EAEEMACCAECOGYGUGSCSGOGKGCAEECCAEAA?CACAA?EAC?A?A?A?A?A@C?A@C@C@?BCBAB?BAR?XAXCN?HAHCFADCDCBCNUDG@EBG@IBK@QDWBODSDKBGDEDEHEFEDAHC@?D?HAJ?D@@?FBFBHDNHJFLDDBJD@?J@D?D?B?DAB?BAVQHIJKFGFCDCFAFAVAV?H?LELCTERIJCDC@ABC@A@CBGDU@CBYFa@Dc@BWJ]HSDGDIDGBEBABC@ABAFC@?@AB?@?@?@?B?B?B@B?B@B@D@HDTTLHFBFDHFHDHFBDBBDDDFFNN\\DHDJDFBDBB@@@?@B@??@@?@?@@@?@?@?@?@AB?@A@A@?@A@A@A@A@C@EBC@EBIL]FOBEBGDEBCBC@ABA@A@?@?@A@?B?B?@?B?F@D@D@D@FBJFJFLFJFFDD@B@B@D?@?@@@?B?@?@A@?@?BA@A@??A@??A@??A?A?A@A?A?A?A?C?CAC?CCMCOCMAEAGAKAIAK?K?I?KBWFo@NuA@WBI@K@E@EDIHUDKDIBE@E@E?C@A?C?A?E?EAEAEAEAEACEECEAACAAACACACAC?CAC?EAC?A?A?C?C@G@C?E?A?A?A?A?A?AAA?CAAAAACAAAAA?AA??AACCEACACAAAAAAAAA?A?AAC?A?C?A?A?A?A?C@E@EBC?A@A?A?C?C@CAC?C?A?AAA?AAA?AAAAAAACCCAEACAEACCIAGAIAG?E?E@C?E@C@E@C@CBEBCBABC@?@A@A@A?A@A@A?A?A@A?C?AAC?A?ECK?EAEACCEAECCACCAEEGCECIEKCICIAKAI?U?G?A?G?E@G?C@A@A?A@C@EDEBEDEDCBA@C@A@A??@C?A?A@A?A?A?A?C?C?AAA?A?AAA?AAAAA?CCACAAAAAA?AAA?A?AAA?C?AAKFQFKHMJMJM@A@A@A@A?C@A?A@C?A?C?A?CAA?C?AACAAACACAACAAAAAA?AAA?AAA?C?A?E@C?I@E@C@E?C?C?C?EAA?AAA?AAA??AA??AAAAA?A?AAA?A?A?A?A?A?A@A?A@A@A@C@CBEHKHKJIHIJGJGVQDCDEBA@C@A@A?A@A?A@A?C@C?C?I@I@Y@M@E@A?C@A?CBCDIFIDIRa@FQFODSBQH[DY@M@K?M?E?EAIAGAC?CACACCCACCAACEEGCECEAECGAECECMGGCEAGACAC?CAC?G?G@E?OBM@m@HA?A?A?A?AAA??AA?AAAAAA?AA??AAC?ACMAE?C?C?A?C?E?K@I?E?C?A?AAA?CAA?CCECEEMCECEKSi@oAmAwCEMAG?IASAe@AS?M?_@?Q?IBUHWH]DSFa@BM@I?M?I?Q?M?IBIDGHML[JWPg@DOJODEJGFCRCNCHCNELGLKJIJCNCXC^CVCNCFCDEBG@I@S@IBIDKLKNIPIJKZ[ZYXM`@QXIJGJGPO^o@b@w@f@y@NUDQBOASAUAQ@UBWFWBMFMFELIRGZITGTKJGJOLa@BIFKHOXe@Ra@Xk@DK^s@d@iARu@BKVg@DMNUTa@R[NWNW@AHWP{@Jk@Vo@Lk@La@?ALy@NsA@WDSHMJGNG`@KNCREPENELEHCPIJGHEFCHCFAHCFCBAJCTIVKNKPMJEFEFEBCDEBKBG@I?ICQASAO@OJe@J_@DOJ_@HUHIPSHMHKBK?G@EAGCIU]W]KIKEICQCSAUCGCGCEE]a@OUKQOQMKMGSKUKOESGSEOEKEGGCCCEAG?C?W?I?O@IBEFMNMT[TYJYHOBI?GAKCQGc@E]CWAM@UFe@JgC?GJuB@OBmBBoAB{A?g@@QBQFWDQH[?KCMIOGMKMq@kA_A{Aa@mAMs@Ku@COAKK{BSaCUsCAKQaBYsCC[AYEiBDwA?[B[LiBPwB?CBg@J{ATsF@aACKAGcC_J]qAc@wAY}@Qw@w@{C'
                     },
                     'start_location' : {
                        'lat' : -8.124946899999999,
                        'lng' : 111.1463685
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '9,3 km',
                        'value' : 9311
                     },
                     'duration' : {
                        'text' : '8 menit',
                        'value' : 490
                     },
                     'end_location' : {
                        'lat' : -7.9576235,
                        'lng' : 111.4372356
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Raya Pacitan - Ponorogo\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '~o`p@st_gTO?aEI}HA_B?W?cBBY@cEF_B?gB?gDCEA{A?Q?OAY?cAEI?cBG]CWEGCECGEEEEC_@i@q@q@MIKGKEICKCQC]AOAO@M@i@F]HWHOF{Ah@I@UDQBO?Y@WAMAKCGAQGMEg@SQIGEEEGIIUCGAMCQCUEWKYGKGEGCECKAK?IAE?W@G@G@C@E@IFUVKHMJQDG@I?_@CYCOCGAKCKCIEMIMOCEEGISEGGGGEGEGCIAIAMCG?G@G?IBGBKFEDA@EDEJGJIPKLIHKDUFm@HK@uANA?k@FYBK?a@?YAk@GyCe@kCm@QCeAWo@MCAoAWc@IEAk@OICoBg@aAYYGeCo@a@KMEkBm@eBk@mCy@QIe@QOEmC{@cDgA}FmBkFaB_FgB}Bs@eA_@{Bu@gCq@sBu@UIkC_A{@YyBu@g@O[KoBe@oBc@iAQaCe@k@Kq@KG?OEwBa@_BUaAKQEa@GuAWaHaAWEC?kDk@{B_@wGiAeG}@cAOWEoB[qJ_Bk@I{@MQCqAScB[EAqCe@gF}@}AUUEmB]}@MgAOQEk@I_@GgDi@a@Gg@IoCc@kAQiCa@u@MaBYgAQwAUk@KMCYE]I{A_@_AU_@Ig@MCAa@Mi@OiEsAc@O[Ke@O}DoAwFeB{GsBWIeIiCuFeBmEwACAUIICuAg@sDiAcA]cAYmAa@wC_AeDgAuEyAeA]YIoDkAg@OGCqBq@mIqC'
                     },
                     'start_location' : {
                        'lat' : -8.0360017,
                        'lng' : 111.414656
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '6,6 km',
                        'value' : 6570
                     },
                     'duration' : {
                        'text' : '10 menit',
                        'value' : 597
                     },
                     'end_location' : {
                        'lat' : -7.9594543,
                        'lng' : 111.493489
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Ngasinan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'bfqo@wadgTj@aI@a@R}DPwCBg@DcABm@@e@@M@GHcBRaDDk@Fm@HmAPaC?IPcCDg@XmDPiCd@qGpAeQD_@LcBLyAF_AHiABe@Ba@RoC@GHoA?GJuADq@Dm@JwAJuABWFy@j@sIRoCDg@Ba@HeABS?ITgDV_D@YZaE@WRoCXyDVmDFw@VeBXyBTmBF_@J{@PoAHk@@Kv@aGFc@`@aDx@uGHm@XyBv@aGFe@\\eCF[?EJy@RuA?ALeA@CFg@He@D]BQF_@?AJy@Jw@Fe@FWBQBMFUHSFQDSBIBG?G@GB[D_@D_@Fa@BSNgAHm@DWJcA@_@?W?_@Ce@QeAk@}Ck@eDu@gECOI_@Mq@Ou@Ms@UmAQaAQkAOw@Q_AKq@Mo@Kk@Ko@Ic@Ic@Ki@Ic@Ic@G[AGGYCOEKCGEGKOOOUUQSECEEMKCACCGCCACAICOCOCc@G[E[EQCC?UCWCm@GYAEAUA[AAA[CYESEOCOESGMEWGQGKEGACCAAAA?CAA?C?M?M@E?KB_@HgADw@Dk@@OBq@Bc@?AFsADaA@OBU'
                     },
                     'start_location' : {
                        'lat' : -7.9576235,
                        'lng' : 111.4372356
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '20 m',
                        'value' : 20
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 14
                     },
                     'end_location' : {
                        'lat' : -7.959299700000001,
                        'lng' : 111.4935772
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya Ponorogo Trenggalek Sambit\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'pqqo@iaogTKEGCIG'
                     },
                     'start_location' : {
                        'lat' : -7.9594543,
                        'lng' : 111.493489
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,9 km',
                        'value' : 3880
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 250
                     },
                     'end_location' : {
                        'lat' : -7.963748499999999,
                        'lng' : 111.5284908
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Raya Ponorogo Trenggalek Sambit\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'rpqo@{aogTDCBA@CBE@C@A@I@G@M@E?I@_@B]@SBi@D{@?GBW@SFkALoCBc@JsBB]ReE@ODq@Du@HqA@e@LsC@MDi@H_BFcAHoAHwAD{@PiC@O@K@WDi@?AD}@@]T{EVeDb@oGB]VmEJyAJ}AN{BLoBPeCFw@LqBHmAPkCFs@@KJwA`@eGJyAP_Cf@mGL{AVuCBi@Bc@ZsEBWNaBV{CDg@Fw@JeBF}@N{BBa@VqDJqADm@RqDP_DPoCH}AFaA'
                     },
                     'start_location' : {
                        'lat' : -7.959299700000001,
                        'lng' : 111.4935772
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,0 km',
                        'value' : 1039
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 52
                     },
                     'end_location' : {
                        'lat' : -7.9647475,
                        'lng' : 111.5378706
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Sawo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'llro@a|ugT`@aK@SJeBBi@FoA^uHReDBc@H{AJeBBe@@UJuA?KNyB@U@OL{BFuA@K'
                     },
                     'start_location' : {
                        'lat' : -7.963748499999999,
                        'lng' : 111.5284908
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '32,7 km',
                        'value' : 32671
                     },
                     'duration' : {
                        'text' : '30 menit',
                        'value' : 1770
                     },
                     'end_location' : {
                        'lat' : -8.053832099999999,
                        'lng' : 111.7035746
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Sambit Sawo/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'trro@uvwgT?KDk@Ds@Dy@@YB[FkAB}@Bg@Dq@?MDw@Dm@TgEXiF@IL{CTuDPiCl@qH@K?GFcAFe@LwBJqAJsAB_@LgBHcARsCF_AJ{@Jq@`A{EfBeIp@iC|A{IrAeFVgAFWDMb@iBDO@EXmADOPk@ZuAFUFU^aBLe@@EPy@FS^mA^mA@Ch@kBp@}BNk@f@yANi@Rq@Ng@Ty@ZkAV}@DKRu@DKNe@ZeAh@gBFSt@kCh@eBXcA^qAl@_CFSF]X_A\\oA`AuDv@oCFSPu@n@cC^{A^oAx@qCDEFCFAF?n@?|@@nCDP@bB?ZBV@XD^Jz@Tr@PpBZnAPr@N`@HZBpGTXHFBHDFBHFHDHFLFLBN@L@L?LEDCDEDEFEDIBKBIDe@Di@@_@@GBUDQBKHO@ADIFIDETQHEJELEFCFAPEPEf@GF?RALAR@Z@PBLDLBJFFBHDJHXRTPTP^Td@T`@TXLXHVFV@\\@NALATETCRANCXCPCR?JBTDLFHHNPN\\Vl@HPFJLFJDJBF?J?NAPKr@URGFCTIHENGNMHKBO@I@IBMBMNUFOLGNAN@LBJBHDHBJBJBL@R?JCJELIFGHKHKNUFS@YCUMOQOmAq@AAc@USSQQKQGOKWEQCSCUAUBOBMFMJORENCRAR?\\@VDPDNBNBB@LBJBTDRDVFXJPFN@N?HCHALGFILQHSDKBGDKFGDCFEFCJAL?L?L@F@HBPBB@T@JBRB\\@r@Dj@@X?R@T?VAPENGJEPIb@QhAa@HEJAHAFAJ?H@JBVJNFPHPDP@RBR@TARCRERGLKROHGJOJQHSDSA]Gw@E_@AUA[?S@SFQDKJIJGHA@?`@B~@DjADT@tAF^BrAFX@VDB@NBZHJFPLRRLNLRNVLVHVFLFHHHNHLFNDL@NDTDT@b@?j@ERAj@If@Al@?p@@V?T@NBNBXFZHf@Rj@Xh@Z~A~@rAx@f@`@nAfA`BhBPPJHLLJHRJLDLFJDJDHFJFJHFHBP@ZAb@A\\Gv@Ch@Cd@?Z@L@LBRFb@XrBHh@D\\?D@PANCf@Av@?d@@d@Bb@@RDJBJHHFJJHNLPLNTFLDHBHFVJ`@FXH^DFBDFDh@V^H`@HTBVJXNRN`@^`EbHtCjIrAfFr@|C`@hBDNFHFF@@NJ`Ab@b@JRDR@LATEj@Wf@Y~@g@\\WNMLMZ]`@g@X]VQTK|@Y\\KZGLAT@^@`@DVDP@L?PEh@Ml@SRMVQLONSBS?KASIe@AGCCEGEEACCC}E_CQMMMI[AUBc@Nu@FU@SAYm@}DEa@Ai@?_@?[B[R_ARk@^gA^sADMJQLQNILENIFGHILMPOFMFU@Oe@aCm@k@Q]O]G_@Aa@?a@@a@@QDUBOHSHQDGFCLCJ?`@?b@D\\@L@R?^G^G^ITGVKNIXSNMFGHIDGBG@I@G@I@O@SA[?[AWCa@CQMWCECMAQ?W@QBQH]Jc@DW?K?I?I?MAKAMCKCICEGKGKIIMGQKSMMMKGIQGO?UBIFKJIHAH?HCLHLFJFLHLJLDLBPAJGHGHKHODMLQFKFOFGLENAL@PFXDVD`@H^Db@FX@Z@X?L?N@RJHDNJFJJJJHJBR@RENA`@KTIZKTE`@K\\I^KNEHEFEHGFKDK`@g@X[TWBEFCHEHELEPERAT?R?N@J@NDTFHBFFFFDHDDBJDJBL?@FTDb@Hz@Jt@BPFRDJLVPVTPRJNDJBH@R@N@R?d@?r@C|@CL?L@LBPHJFNJFHJLHLHJFHLFHDJBL?N@RAJCFCHGHEHKFKBCBCDGFGDCHCFAHAT@Z@L@DAJANCPCNCJ?^An@Ej@A`@?PDLFDBDBFFJHNPNPFHHDHFLFf@Pj@PNFl@Nv@T\\LZLb@TXPPNXVZZPRDDPRVZLNDFDBF@F@H?HAF?DCFCRMZYPMRIREFCPE\\GJAF?D?F?D@DBBBFDDF@B@D@D@H?DAFEJIJEJCHCFAH?J?J@N@H@B@DB@@@B@FBLDRDH@FAJAFAFCFCDCBEBE@E@E?GAE?GAICKKc@Ie@COAM?I@G@GBIBGDKDGDGBCFCFAD?F@F@LDHBHDHFBDDDBFDFBF@D@D@F?J@D?B@DBDDDDBHBHBF?P@RCNAD?BABA@A@A?ADELWJMJMFEFCHC\\Il@Kj@IXGHEHCFEJGLKX[T[NQLOJMJKXMr@Wr@[^QNGJIDIBE@E?EAC?CACCEECIEMKGIGGCGAGAG?G@IBKBIFON]JSJOJMx@mAz@{ANa@L]@M@KAIAGCKKQKQCICIAG?KAYEYESEKGKKMSSMKIGIEKEQGQGQMSQSUIKEICIEOKa@Ge@C[AO@O?GBQBQ?I?MAGEICICOCMAM?S?YBc@Dc@DUBQDKDMFKJOZg@X_@NMNOROj@a@^WBALGFEFCHAFANCVETENEJEDEFIJQFQ?M?K?OC[AQCQG]EOCSCMAMAGAG?EAEACCEGGIGEECEEEAGGSMYGKEIAEAGAKAOAUAQAM?S@M@QBq@Dc@Fg@R}@N{@Hk@@UBUBIDKHWDQDM@K?KAKCKCIAMASAOCKEKGMKMk@m@[]U[KOEOGOIUES?K?KBKFOJKRYTYJSBG@G@G@G?IAO?O?OBMBSDUBMBOFOFKFIHKV[JODKDG@G@G?I?GEOEIGKQUOMGEECCECIAI?E@GBIDOBO@G?GAEAECEECECECE?OA_@EQCKCGECCCEAC?G?E?G@EDGDERO^e@l@_AXw@HYDMDEFEFAHARCREDGDI@I@I?GCQGa@Ae@Ck@Ag@AK?M?I?IAICGCICICMASEg@QkAEYCYESGMEKM[IWKUGQEMCMAGAI?G?GAIAGCGAGEEIIMIKGKEICIAK?M?QBQBO@K@[F]Fg@B[?K?KAIAGAEAIEICSEU?M?O@WF[D_@BQ@OCKAICGAIGCAKIYSc@c@q@m@e@c@m@o@s@s@y@w@s@o@SQQK[SYOMMKMKOIUI]Ii@Ie@CKCIEKEGEEGEIGYMSI[MOGIEMIMMMQQ[m@kA]w@GOMc@YoAQo@Q}@Os@K_@?AMi@KYGMCGEGMKg@a@cAw@gAy@GIeBaBu@cAS_@OWCQCK?MAU?E@oAB}@BcAFaCBcB@IBoABy@B}@JmA@KFq@Hc@BODa@BOFg@BS@Q?GAIAGAGCCCGEEGCMGUG_@KaAQk@KYIKEKEMIQO]Sc@Y[W[[OQGKGM[{@Yu@K_@GQEOAWAa@Ai@?e@@[@U@KDa@@GDSR{@VgADSP}@@IFa@Hc@D]Ba@@YD}@@[@]@QBG@GDCHCbAUXIHEDCBE@E@C?C?EACAGCGc@s@[i@IMEICIAGAKAi@@kA@G?E@CBCDKJKBCFCVGTA`@CVCHCDABCBE@C?G@GAE?C?ECECGUSSQWUgA}@}AuA_@]QQGIEIIMEICI?CAEAIAM?M?G@s@@S@c@FyA@ODgALaDDoAD{ABq@HwBHoB?IH_BLyCFeABs@@?DaAHsATiE@]Ba@Ba@XyFBc@@O@GBGBGHIFGJGPG`@KfA_@|Ag@vHeCdEuAr@UxEyAxAe@dA[b@OdBi@vBo@zDmA`DcAp@UfDcAJCzAe@bC}@LGHEJGDEHGFGRKfCgCb@i@x@gAd@o@~@mAfGiJxDsFbAwAz@oAjAaBV_@^i@`@k@RUHIDCFCDCF?h@@h@?VAPATEJCLGJIJIDGDGHQDSDM@IBU?KB]@]@oAGsA?IAIAOGYIc@Ma@Ke@AIAI@M@O@ODOPy@^uBr@}DXcBDUJk@LaAPkADSBWJq@?AFc@Hi@?C^oCJs@TiC@QF_ADu@DgABcAJiD?CDkA?I@s@Ba@?W@G@i@Bs@@c@DaADgA?GDcA@YDmABSLgADUHa@Hg@Jk@@GF_@N{@F[Jm@TmAn@oDVsALo@@IDOBQJi@VqALy@@?@M@O?M?KCQOo@Ka@GWAMAK?I?E?GBKDOFOLQRUb@o@\\c@TYBCZa@FGJMX]JMRSJO@ERYZe@V_@V]DEBCZc@X[BC^e@|@iARYTWjAcBHMd@s@Zg@Te@To@\\kATw@Pw@RaA`@oCXiBXsBJ_AH_@Fa@Li@Pc@Ta@p@eAn@cA^q@LSh@w@P[Zi@BEd@{@d@w@f@cAXk@JWLa@Nc@Lk@XoAF_@BSDUJu@PiBNuAN_BToB?GPyA@IRwBBc@Ba@Dg@Bq@Fo@J_BPyEDeCHaDDmADiB@w@FgDByABmA@s@@Y?ABs@@y@@u@@a@@O@WBMJk@Jm@H]N{@Jm@Pq@@K?A?ECmAAw@CgAC{@?KEaAGeBEeAGkAGmACWAIEm@IeAGs@Go@Gc@AGM}@M}@?AG[?AKm@AAIe@Ga@M{@?AUcAG[K_@KUO_@Se@Uc@CGCCAACCCEEECCECGCECEAKC]E]ESC_@GKA[E'
                     },
                     'start_location' : {
                        'lat' : -7.9647475,
                        'lng' : 111.5378706
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 552
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 82
                     },
                     'end_location' : {
                        'lat' : -8.053336399999999,
                        'lng' : 111.7085595
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Yos Sudarso\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'l_dp@ibxhTEYEUCYEYC]A[A_@Cs@Ca@AMMeCCaAIcCCg@M}C?AGkA?ICs@?e@'
                     },
                     'start_location' : {
                        'lat' : -8.053832099999999,
                        'lng' : 111.7035746
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '43,6 km',
                        'value' : 43588
                     },
                     'duration' : {
                        'text' : '38 menit',
                        'value' : 2266
                     },
                     'end_location' : {
                        'lat' : -8.1042384,
                        'lng' : 112.0085306
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'j|cp@oayhTH@hE\\P@jDTZBj@BTBdCT^DtALt@Fv@HP?V?P?T@d@DXBH?RBF?D?j@Fv@D|@H`AF^Dp@DfAHrBPvAJLBfAH~ALrD\\N@~CV@?\\DhAJh@FD@j@Dn@Db@BH?l@DtAH`@B@?J?|@BzADVB^?p@BpADD?fABnADn@BZ?n@BjADxBBbABlADdBBtADvABL@j@@bADbABxELNFn@BlADhAB~AHjA@bABj@@`@?t@@NAL?JALEb@U\\YBCPOrBaBVU`BqARSf@e@j@e@`BuAn@i@jB}Ap@m@n@i@ZWfA}@BCJIj@e@VORKZIb@GNC^Eb@Gv@MlEo@JA~AUbAOLAfAOx@KfAQn@GlAO@?pAUBAFAHEFADEDEFGDGBGBEBKDSHe@BUF[?AF[D_@F_@PsAVmBlA{HHi@~@oG`@gCd@kDNiAd@_D@MV{APmABQDSL{@Ny@@ArAwI@Gl@mEHg@N}@\\mAb@kABENg@p@uBdAsCP_@JWpCaIfBaFdAyCp@eBNa@r@sBFQNa@FYDI@G@I?G@QBoA?mBAeA@O?eB?mA?kD?[?_B@gC?sA?sC?wB@kB?[?sA@uD?}A?kA?iA@_B?iC?qA@kB?yE@cF?cB?u@?_E?_@@a@@M?IBQD]PkAF]PaA`@iCFa@l@_EXeBT_B@IN}@DUJm@Ji@BSH]BKDKDIDGFINSNQLKHILKJIVO`@UHERKPIfAi@fAi@n@[`Ac@bAg@jAo@hB_Aj@[^Qf@[j@]`@Yv@o@X[r@_Ax@kAd@q@nAiBdAyAvHwKZe@LQf@s@\\c@lAeBfAaBBEb@k@zAoBl@w@PWFIf@q@`CgDXc@z@iA\\g@PSv@iAHKPUFKtAkBn@{@bAuAZc@n@{@n@_A@ANSv@gAT]Xa@p@}@l@}@BEV_@JMf@u@NSNWDIFM^_ADKj@{AHY@Cn@gB@E@GL]n@qBZaAX{@Vy@Pm@Pi@BITy@ZgAr@sCp@qCJa@La@XiA@AT{@VcAZoALg@h@wBLe@VgARw@@Eb@aB`@iBJ_@XmAd@cBNo@No@Vy@@CT{@@EL_@^aBBMTeAZ}A@ALs@F_@BSBM`AqEF]RcA@AHe@ZaBNw@`@yBTmATmA@E`B_JPcA@EDYp@yDHg@?Aj@sC^iBReAVoAToALq@VmAr@uDTqAZgBDWJi@p@mDBMjAoHj@oDDe@@MBO?U@a@?[As@Kw@Ou@UmAScAq@kDsAyFiA{Eq@sCI]SaAm@aCu@yC[oAQs@[oAqAqF]mAIYCEEIEGMMw@o@aEyC{BeBiDiCIIeAw@yDyCgAy@kKyHWS{CaCe@]m@a@ICICGAQAY?}AZ}AFG?E?y@F}BXE@aCV]DiANm@Fk@HkBH_CDQ?o@?{A?oA?_D?i@?A?uAC_BCsBCoACsBCeACq@GSEA?OEa@G[K_@KiB{@_Ag@c@]QOc@][e@Uk@KUe@mASg@O_@cAqCiA}Co@wB]qAGWYwA[aDE_A?CGyBCsA?U?eA?G?UBkABwD@kB@eD?sCAqBAuB?c@CwC?S?EAo@C{AAY?kA?[?iAAa@C}@CYCICIGSSWIKSOSMq@[a@QwAi@eBm@{Ag@aDeAkCcAKCsBu@mAe@YKwAe@wAg@oC_AeBm@}Ai@kBo@g@UICk@SuAg@eOkFeEyAEA_E{AmDoAyEcB[MaHmCwGaCwBw@kAc@o@WaA]{EgB{DwAQI}Ak@eDmAwAi@kAi@GGEIMQuDoH[i@MQQQKIIGi@QeBk@qBe@y@UmGgBe@MwAc@cAW_Bc@aBc@cBg@aD_AqA_@kA]a@MgA[sEmACAwEuAu@S_FoACAwDiA[Ik@QAAeA]OKGEEECEEIGMCKAEAI?EAG?Q?OBW?A@G@C?A@K@GLeAf@wCdAiHFe@Jq@^}Bv@uFZoBT_BnAgIFe@`@mCHi@h@iDBODWLm@@E@EL_@J[\\cAHYPg@rByF^aAfCmHr@qBx@aCr@iBd@mABG~DsI^w@Zo@Xs@dCgF`@w@nBkEx@gBzAaDr@uAjA}BpAqCdByDhCkFBE@AnBeEN[~B}EbAuBfByDBEFIFKDIFKDKBMDODQ@C`@kBf@wCp@_EZeB?ALs@`@gCHc@p@{DHo@\\oB@IXyAHa@F[Js@NaAJk@RsAPgAJk@?G@I@Q?U@AE}DAoEAiBEgFAkAAqBCmEA}@AkC?UCkDAyA?m@C{CEqBAiBA{@A{A?Y?_@?gB?iFAcB@[?_@n@yCLi@F]BMr@uCBK@Gl@mCDOHe@Pw@\\cBLq@XwA@Cp@cDH[N_APy@Lq@BI\\cBlAoF@IRmAF_@Jc@XkAbAwEHe@^uB\\cBl@cDPcALo@h@sCF[?AJk@RmAj@_DHe@BM@CDO\\iB@Eb@uBh@_Db@_CBOLy@RkAVgBRwA@E@GTwB\\eDLkA@OTgCD]LoAJgAXqCDk@D_@NoAXsCDk@d@wEb@mEDi@HiARqBh@oFLgANaBn@qGHo@J}@N_AXcAJa@BE@G?E@G?E?E?GAGCIGICC?ACGCGAECKCKAM@KBODOVo@Na@@K@KDY@O@YB]L{@BWXqCDYPyAp@{GBU\\wDh@_G?I@A?EDa@XeDV{BZ_DRqBHaAPaBDe@Hk@JgAFo@J}@Fs@Fq@D]Fi@Hi@P}ANuAJcAHs@TsBLeAFc@RcBLeALgAJaAP_BFe@Hy@R_B?ENgAl@oFHq@b@{D|AeNx@gHHi@lAiK`@gDLyAReB@EFi@Fc@D]FWDUHYDKnA}DHYp@qBf@aB|@yCz@kCHWd@_BTu@FSd@yAFSp@qBx@gC@C^mAPk@j@eBDOf@{A|@wCbAaDHUdAiD~@yCb@uAb@qAJ[nAyD`AcDnA{DDKxAaFVy@DGv@aCX{@\\kARq@j@iBZ_A@Gb@uALa@@E`A{Ch@iBTu@Ps@|@cDnAgFH]FSz@mDTw@r@eCPu@d@mBHW?Cr@mCDM~BeJNo@^uAPo@@ADMDQ@Aj@aCBKVcALk@La@f@uA\\s@`@y@DKZo@Zs@z@kBLYl@qAnAqCbAyBn@wANUBC@ABA@ABAD?|A@R?L?~B?F?jA@DABABCBA'
                     },
                     'start_location' : {
                        'lat' : -8.053336399999999,
                        'lng' : 111.7085595
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 454
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 39
                     },
                     'end_location' : {
                        'lat' : -8.1044359,
                        'lng' : 112.0126395
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya II\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'nzmp@itsjT@E@E@A?E?u@DaEH}DJyE@q@B_B'
                     },
                     'start_location' : {
                        'lat' : -8.1042384,
                        'lng' : 112.0085306
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '16,0 km',
                        'value' : 16030
                     },
                     'duration' : {
                        'text' : '14 menit',
                        'value' : 810
                     },
                     'end_location' : {
                        'lat' : -8.1408047,
                        'lng' : 112.144636
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Blitar/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'v{mp@_ntjT?oBBuABmBLaE@yABuBTkKBkAFwCJwDFmDDsAB]@_@?GAECEAGGMGOCKAMFYTuAFY@K?M?U?Q?m@@{@BmAFaB@UBo@FcCBgADyC@u@BqADsB@k@@UHoEJqGDyADw@Nu@Lk@FUBMv@_Dn@eCz@oDXcABOl@cClB}HVcAvB}IZoAZqADOViAJ_@t@iDLe@J[Na@`@{@@?h@iAFMv@{AHQd@aA`@w@dAuBpAgCh@eAdBeDN[r@uAVg@JWb@y@BIDIBGDEFIDCLId@SBCFEBEDGBGDKBI@IxA_Hx@wDpAeG^cBj@kCBMnAaGP{@fAaFhAoF@Gx@yDZ{ADSjAeGpAaHHa@b@gBt@gE?Ez@aEH_@f@aCrAoGHa@h@sC~@wELk@~@{ExAwGv@gE\\yAXkAd@iCp@iDbAiFzAsHN_Af@eDBW?WIaAk@kE[wBQsAS_Bm@wGM{@EOGKGEGACAI?_@@A@Q@mANOAE?MAIGEGCEKYUw@iCuIoAiEo@wBaByFoBkGw@gC_BmFy@mCwC_KgAyDQ{@Oy@i@{CM}@Kk@?EG]CWAI?G?I?I?I@IFc@Hi@L}@Jy@Ho@D[DSDQHQDGDGHGHGHCj@UZMp@SPGHEDCBCDEDEDKFMDKTq@Ts@Rk@zAqE~@sCL]BEV{@vAkEpCsI\\_ATw@Na@P_@NYh@eAd@}@bEqH@Eh@eAfCoEVg@tAeCDI|CiFlAsBXe@h@_A~CsFT_@f@{@JWDKv@qBNc@@AJWFOPc@vAiDbAaC?ARc@~@yB\\{@@AdBkEhAyCJULSd@c@~@s@TQtEoDhB{AhA}@pEoDlA_ApA}@?ALKBEDGBE@EBCBG@C@GBK@K@M@K?MAM?KAOAKAOAM?M?I?E?K@G?K@KFmAHqA@QRoDBUBe@D[D]T{ABONu@XgAX_A^gABI`DwHz@uBZo@fA}BnBcEf@cAnCwF|@kBr@wAFM^q@Zk@v@wA\\q@Zo@f@cADGl@oAx@{AN]Ta@FMR]V[NONKTOBA`@WLKHGJOHQPe@PmAf@qCVqADMJa@PaAb@cCN}@Fe@@K'
                     },
                     'start_location' : {
                        'lat' : -8.1044359,
                        'lng' : 112.0126395
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,3 km',
                        'value' : 3275
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 171
                     },
                     'end_location' : {
                        'lat' : -8.115198699999999,
                        'lng' : 112.1548819
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Cemara\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '~~tp@_gnkTa@o@eAmByBmE[s@Ee@Ec@?EAg@?q@?_ECUCGEIIKKIKGMG_@KeA[cBg@oFuAOEoBc@iB[sAYe@IiCk@oAUICyCi@e@IcAQm@MeAQkBYA?EA{GeAmG_AuAQeFw@mCe@sCc@iDk@uAUy@OaCa@A?gBUuAQ}AQe@GoD]}BUQAaBMyBS}BW_CW}AS{BWg@GGAaFs@y@M'
                     },
                     'start_location' : {
                        'lat' : -8.1408047,
                        'lng' : 112.144636
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,0 km',
                        'value' : 996
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 133
                     },
                     'end_location' : {
                        'lat' : -8.1153017,
                        'lng' : 112.1634683
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Raya Kenari\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~~op@_gpkTBm@HaB?U?[?UAOCICGCGGKGIEKaAaC}@{By@yBGS?K?{@FcDBe@Fa@F[PkA@IHq@Ji@?AR{ABS?I?A@E@EFU~A_G`@cB'
                     },
                     'start_location' : {
                        'lat' : -8.115198699999999,
                        'lng' : 112.1548819
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,8 km',
                        'value' : 753
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 78
                     },
                     'end_location' : {
                        'lat' : -8.1093592,
                        'lng' : 112.1667235
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Raya Kenari\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'r_pp@u|qkTkBy@sGsCICaCeAwFcCOI{Ao@wAm@mEsBMQ'
                     },
                     'start_location' : {
                        'lat' : -8.1153017,
                        'lng' : 112.1634683
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,4 km',
                        'value' : 1367
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 120
                     },
                     'end_location' : {
                        'lat' : -8.1135666,
                        'lng' : 112.1779984
                     },
                     'html_instructions' : 'Di bundaran, ambil jalan keluar \u003cb\u003eke-3\u003c/b\u003e menuju \u003cb\u003eJl. Bali\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'nznp@_qrkTA?A??@A?A?A?A?A?A?AAA?A?AAA??AA??AAA?AA??A?AA??A?A?A?A?A?A?A?A@??A?A@??A@??A@A@A@?@A@?@?@A@?@?@??@@?@?@?@@@??@@?@@?@HGDEBCDGHMJ[@CNi@V}@J[r@qCBI\\kADO@C^oAV_AXmABG`AsDLe@T}@`@yAj@yBj@wBVaA`@{Ap@iC^}A|@oD\\mANq@b@kBl@wB'
                     },
                     'start_location' : {
                        'lat' : -8.1093592,
                        'lng' : 112.1667235
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '11,0 km',
                        'value' : 10967
                     },
                     'duration' : {
                        'text' : '9 menit',
                        'value' : 568
                     },
                     'end_location' : {
                        'lat' : -8.1205856,
                        'lng' : 112.2718678
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Manado\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'xtop@owtkTl@_Cz@gD\\mAd@iBh@yBXeAJ_@Nk@DO^yA^uAPw@Jg@Ho@De@NyARkC@EJ{@Fc@F_@BITo@pByEnAuC?Af@cAbA{B@Er@yAVi@pCgGPc@p@aBxF_MJWbBqDjA_CTe@l@oAZu@d@gATk@Na@JYTs@DKBKTgAHc@j@aDf@qCPgAdAiGBO^gBHe@Js@Fc@RkALqAJq@l@cE^yCBQFa@Fe@Ho@Hc@BODODOFSDMDMFQJWJYNYNY\\m@R]x@yAz@{AR]|BuDfB{C\\s@Tk@d@iAZy@Tq@Xq@Rq@T_AH[p@kCHWL]J_@h@wB`AmDLc@b@aBRq@FSf@kBNk@Li@DMDQ^uAlAeE~@kDNm@Li@FSa@oDMeAu@{FSyAOiAw@wFe@mDE]i@uDAKcAiHEWSuAOiAUcBIe@UcBCMWmBi@sDQmAo@oE[wBOkAQsAOiAK_AIm@E]AMAMAY?m@BaCDyDBoA@k@?SAYC]AWGi@KmAEq@Ga@UsBIy@Ec@AEU_CIq@S_BGe@SwAEYW_BG[G[I]Ia@YeBYwAQcAUwAKq@Qw@SkAK]cB}IY}Aa@kBYgBW}A_@yBEYYyAQaAa@eCi@wCe@_Cg@mC]}Aw@eEaAyEGUMu@Mw@WqAYwASy@UeAACGO[m@uA_CoAsBGIqAkBcA}Au@gAIYIWG_@EUCYAs@Ak@Ag@?W?A@WDe@Dc@Ba@@e@@Y@W@]BS?IHe@Lu@BOTmAVyAHc@Hi@NcAHs@HiAD}@?OHoELgH?iBAo@'
                     },
                     'start_location' : {
                        'lat' : -8.1135666,
                        'lng' : 112.1779984
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 159
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 25
                     },
                     'end_location' : {
                        'lat' : -8.119288200000002,
                        'lng' : 112.2724762
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 't`qp@ebglT}Ak@eDmA'
                     },
                     'start_location' : {
                        'lat' : -8.1205856,
                        'lng' : 112.2718678
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,2 km',
                        'value' : 1209
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 104
                     },
                     'end_location' : {
                        'lat' : -8.122212599999999,
                        'lng' : 112.283032
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'pxpp@_fglTdAkEtAoF^wA^{AVcAf@oBPw@Lm@D[@ID_@PiBHaAHu@JcAZaC^_CJo@XeBt@{Er@sE'
                     },
                     'start_location' : {
                        'lat' : -8.119288200000002,
                        'lng' : 112.2724762
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 594
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 90
                     },
                     'end_location' : {
                        'lat' : -8.1272433,
                        'lng' : 112.2812084
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'xjqp@}gilTD@dBb@lHnBr@Pf@LVFb@L|@TRDj@NlA\\nBd@~Bn@'
                     },
                     'start_location' : {
                        'lat' : -8.122212599999999,
                        'lng' : 112.283032
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,6 km',
                        'value' : 1552
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 127
                     },
                     'end_location' : {
                        'lat' : -8.132131599999999,
                        'lng' : 112.2920483
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'fjrp@q|hlTH[@I@KBKNiAVwBRwAHs@RsAJq@BS@M@G?E?E?E?E?A?G?AAA?CAECGCIK_@CKAIAGAGAI?A?G?G?K?M@K@IBKFYFYLm@ZqA`@gBZgANe@DO@?@C@A@ABADAHAD?B?D?F@N@D@D?D@DBD@DBB@DBp@j@PRRTZb@@@@?B@@?@?@?B?@AB?@ABAJEHE@AB?JCDCFANCHAr@WHWFQHa@FYNm@Lk@XoAn@sCBGNw@Lk@zA}GTeANq@XoA@GBGFG'
                     },
                     'start_location' : {
                        'lat' : -8.1272433,
                        'lng' : 112.2812084
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 183
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -8.133693500000001,
                        'lng' : 112.2915953
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'xhsp@i`klTJ@J@PBfFtAL@H?LE'
                     },
                     'start_location' : {
                        'lat' : -8.132131599999999,
                        'lng' : 112.2920483
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5,2 km',
                        'value' : 5150
                     },
                     'duration' : {
                        'text' : '5 menit',
                        'value' : 297
                     },
                     'end_location' : {
                        'lat' : -8.143096099999999,
                        'lng' : 112.3345676
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1 menuju \u003cb\u003eJl. Hasan Ahmad\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'prsp@o}jlTJMDOVy@zAaG`@sAd@eBNk@bA{DBIj@wBRu@HYLc@FUFSJ]j@mCViA^eB@KVmAReAH]@IJe@X}A@E\\eB`@mB^}AlAgFtCcMNk@R_A\\wAn@iCTkANk@BMFUFWTs@\\iAj@yATk@Lc@FQPi@d@{AtCuK^wALi@N_@HSRo@Ng@Rs@HULa@BG@CJ[BKBKBQ@S@O@g@F}@B]BUDQBKJ[Je@BOBWNkBNcDHqATmDHcB@OHoAH_AfA}JjAwHJcB@U?OAS@k@@QVoBh@oCFY`@cCfBqLRqAj@wDX}B?CVcCLcA@Y@UC}@K_A@sADq@Bg@@QBm@@K@UDm@?OAKCGCCC?EAK?aCK}AGmDK'
                     },
                     'start_location' : {
                        'lat' : -8.133693500000001,
                        'lng' : 112.2915953
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 456
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 84
                     },
                     'end_location' : {
                        'lat' : -8.1437537,
                        'lng' : 112.3386177
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Hasan Ahmad\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jmup@ajslT^uBP}@^oBDQTsAJq@Ju@B]@k@?k@Ac@?YAMA[CyA'
                     },
                     'start_location' : {
                        'lat' : -8.143096099999999,
                        'lng' : 112.3345676
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,5 km',
                        'value' : 520
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 45
                     },
                     'end_location' : {
                        'lat' : -8.143841399999999,
                        'lng' : 112.3430557
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Hasan Ahmad\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'lqup@kctlTWMQKOIUMCGEQAK?KBQH{@Dc@H{@Dg@Da@?ADa@Hy@De@JeADa@FcALyB@MDk@?YA]'
                     },
                     'start_location' : {
                        'lat' : -8.1437537,
                        'lng' : 112.3386177
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '88 m',
                        'value' : 88
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 25
                     },
                     'end_location' : {
                        'lat' : -8.143049399999999,
                        'lng' : 112.3431217
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Hasan Ahmad\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '~qup@c_ulT]Am@CWASAe@A'
                     },
                     'start_location' : {
                        'lat' : -8.143841399999999,
                        'lng' : 112.3430557
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '30,8 km',
                        'value' : 30829
                     },
                     'duration' : {
                        'text' : '28 menit',
                        'value' : 1686
                     },
                     'end_location' : {
                        'lat' : -8.1274449,
                        'lng' : 112.561775
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '`mup@o_ulTb@i@XQVId@Kr@Mn@MLCJCLGFKBKAUGMOKSKa@Mq@U_AWCAWSSUUk@YeAUaAK[MMOGWGgAUMGKMCI?I@GDGh@ORGRIJEHGJIPWJWFOHQHQNOx@}@d@i@T[BENWZo@n@oAdAcCTu@@GNa@Rq@Pe@Rq@dAuCn@aBf@iAN_@@E@I?GAI?E?GAK?G@G@I@IJWLUFWBS@U?WBG?]A[Ca@GWIWW_@g@_@]YWSKMEOCK?KBKDKDIHGJENINGz@e@HIDKBM?OCSM[g@aBI_@?CLkCJ}CLuCHsCd@{GBUBa@Js@Fu@Hq@Du@@E?GDa@?cA@w@AaD?QAmAAsC?I?a@?{A?WEYCOKUw@cCmDsJY_AKg@Mq@Ic@Oo@y@_Dm@yBa@mASi@Ug@wBkEs@oA_@{@Wu@_@aBSkAMi@Uu@EMcAaDmBgGGQcDkJ_@}@c@eAGQ{@eBSiAGWCKi@_CS}@WmAo@kCMo@Qw@Kc@IUEMAAEICGCCCEGGEGGEEEMG[Qk@Ui@Si@UKGMGaBmAeAy@QOo@e@AAeBoA{@m@g@Y_@SoBy@gBo@SI{B{@]M{@]SKACGEEGGIGOI[O}@Ic@?IEYIcCEy@A{@EsBCkAC_@?GEWACAC?CAEAECCAECEKMQMYOSKGGIGIMQ_@MSGGIIOGQIOEOCq@IWGQGUOWOEGEIGKKa@Mm@Mk@GQGOGQMWQ_@EQAI?K@MDMBKDKFIHGFGLIHAH?D?N@B@B?F@B@D@F@D@F@FBRH`AZZJJBJD@?B?B@FAD?D?FCDEDEFIFMHONc@rAeEJ_@Nm@BU@Y@g@?q@CuAASB}@?c@?I@E?E@CBKBI@AZq@DEX[XYfByArAiAtBiBd@a@JGHCJELCLCJARCHAF?ZC\\CDAFAFALCx@[LGLGf@[v@o@LMDGBE@E@GBIBS@I@sABcAAa@KoAgByHm@}BWu@COAOAI@I?E?A@CDY@KBK@GDIb@o@xB}CFMDKBOBMBML{AFmC?M?IAGASEQISOSKIKGMEi@Se@MiA]IEIEEEGGEECGACCGcBkGW{@CKAO?GAk@?Q?G?QBW@IDc@`@aA~@gBHgAEgBAkCLaCFq@Ny@RkAFWJa@L_@N]|AoCFKN[FODKBK@G@E?C?G?CA[E_AUaBMs@Kq@YsAMo@AEG_@SmAAGEUAMEQCIGOCEEIa@k@k@_AAEGOACAC?CAAAC?GAC?CAM?Y?MJc@T}@Ha@DS@GFSFUHWX_A@ETs@L_@J]Vw@@GJ[BIBEFKDIFIBEBCHGHEZMJCHCDAD?JAD?H?V?h@Bp@Bd@@Z@ZAtAGzAGFAt@G\\CnFe@b@Gr@EtAMFAHCREHEBAJGFGFGHIHKdAoBXg@DGZm@hBsDjAeB`@o@p@mAvAkCj@eA^o@X_@LSl@iATg@Pe@@U@G?E?G@C?E?E?EAUAG?K?IA[Am@?c@AO?OAY?MAO?OASASCQAEAIAGAGCGCOCIIWGUSo@KWEQEMAGAGAGAC?G?K@I@IBIBKFKJITOPI\\O\\G~@Qd@IXGh@Of@Qf@W\\a@~@wAf@}@^i@^YTMTKNCTCHAN?L?PBF@F@DDD@BBBBDBBBDFFTFTHPFJFLXb@DHBD@D?D@D@F@D?B?D@B?H?DADAF?J?J?L@D@B@B?BBD@BDDBBFDDBD@D@N?J?N?LDF@D@HDJHFDNNPNFFlAtAHHFBF@F?DAFABEHIFKNSDGBCDCBABABCD?F?F?H@L@XDhBLLBF@HBDDFFJPDLFNDDDDDBDBB@F@H@tBd@PFNH\\LLFTFTFNBF?B?B?@?B?BABABCBA@C@CFK?C@C?C?C?A?C?AAA?AACCCAAAAC?CAC?G?K?K?E?M@MAKCGCKGOMMMOQIMGICGAGAE?E?E?GBM?ADOHUDQDM@G@K@GBU@O@K?MAWAKCKCIEOEMCIAIACCGGIGGYO]MMEEAIAKAIAOAICEC[Qm@Yo@_@_@[s@g@][OMEGCCCGACAE?C?GBMLYJ[DKBEDEDCFCHAF@F@F@HDXJTFF?J?JARCXCHCFALEJCJAL?PAF@D@B?HBLFFBDBDDFHBB@B@D@D@H?H@D?H?R?H?J@NBH@F@DBFBDBDJJLLJFLHJBTDN@RD^BP@LBf@JNBF?H?BAFCBEBE@E?G?CAEAEGGIGQGQGMEQIQKIIEGCGAC?EAA?C@C?C@C@C@A@C@ABCBCBA@?B?BAB?B?B?B@B@@?B@B@BBDBD@D@B@@?B?F?HAFEDCHINU^k@Xe@FKDGFCLEJGZGVGLELEXKNIFEJKDKDI@Q?S@W?M?M@M@GFS^c@r@w@LSDQF]Ba@BQBM?EBMBKDMFIDCBCFEJCXAVATCJENG^[f@i@j@k@n@m@Va@Za@HOBG@G@E?C?C?E?IAGACEEWU_@a@a@]GKCGGQGWGMIIIIMI_@Q_@Mg@Oi@SKKIGOQOWGMEKCQ?SBu@@_@@O?CAOAGEKU_@{@{@MOQc@M_@Ma@Ma@Sw@k@eBEEAY?[B[d@wDp@}EBQFc@De@Ls@DSDOLUFGFGROHCFCTGvA[v@OrBi@L@ZSNMBEf@a@ZYr@u@PQPUh@g@z@{@p@s@z@{@V[FKBGDKFWHa@@CDYBS?YAYAc@C]Es@CYEk@CUAQCGG]Mg@_@}AAC[qACKOu@Sw@UiAUeAACAGKu@Ko@QcAGe@G_@WyAQiAM}@O}@[mBCOWcBGa@[uBM}@o@mEM{@g@cDYcCWoB[eDCk@Ca@?[A]?C?[AU?E?s@A_@?IAw@?k@?a@?g@?Y?G?[?e@?S?EAm@?o@?y@AG?M?G[_IAi@G}@Gs@g@wFU}EC[CaAA{@Ag@DyA@iC?_A@sBBaD@kB@y@@iA?}@BaB@{A?IB{@BmALuB@STwCVeDBg@Fu@HiAL{AJyADm@Be@?IBc@@_@Bs@?KBqAD_B@qA@m@@WFsF?[?INoG@qAN{G?gA?k@@]Bk@?G?Y@WAgAEg@Kk@G[GU[iAK[m@oBCIi@aB[eAo@qBM_@qAaE}@mCa@oAIYs@sBo@wB{@oCw@aC_@kAKe@GSkBoIa@cBYuAUaAUcAa@kB]_BWoAYkAMm@a@_Bo@wC]}Ae@uBAEi@{BI]a@gBc@sBa@kBAECK[kAc@gAc@aAQ]Q_@a@}@KYIQQa@Wq@O[Um@OYYo@O]EKSe@CGIQGOQ[SYMQW[OSWUi@g@e@c@SUWS_@_@i@q@m@w@c@k@U[CEy@cAuBmCuBiCYYaAmAs@{@GIc@i@cAmAc@i@m@u@kDiE[a@sAcBk@q@qA_Bu@_AUWOUW[y@eAcAqAc@o@EEMWIQSk@i@cB[qAQcAUcB]qBACYsAUeA[_Aq@_BUi@k@uAWi@g@iAwA}C[q@eAcCiAcCoBuDUe@k@eA_AcBIMqA_C]o@O[gAmBKQiBeD]k@_@q@g@}@GK]m@k@cAc@q@QYg@q@e@e@u@}@AAQU]g@i@y@MQgA_ByA{Bu@eAQW_@o@O[m@wAEI[y@_@{@CKACYgAK_@WgAAGS_AO{@Kk@Ki@w@iEEQaAkF[cBGOO_ACQMm@YqAo@aDUiAi@qCg@iCMm@EWAECCACEGGCCAEAa@Ei@Cq@C[Ae@GQEQEOESIKGIIGM?CAG?E@E@G@GBGDKLULQLQVUh@c@b@_@LKJMDGDGPa@JQHMPO^[x@{@HMDKBG@IBQDY@IPuAL{@Ha@H]DMDKHW'
                     },
                     'start_location' : {
                        'lat' : -8.143049399999999,
                        'lng' : 112.3431217
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,0 km',
                        'value' : 968
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 100
                     },
                     'end_location' : {
                        'lat' : -8.131583299999999,
                        'lng' : 112.5692143
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Kawi\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'nkrp@cv_nTn@YBAjBs@XMHEJEHEFCHGDCNYL[Pk@h@oBx@sCDQ^mANe@Tw@`@kAb@sAx@}Bj@eBjAgDpB}F'
                     },
                     'start_location' : {
                        'lat' : -8.1274449,
                        'lng' : 112.561775
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 570
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 43
                     },
                     'end_location' : {
                        'lat' : -8.133659999999999,
                        'lng' : 112.5739446
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Sultan Agung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jesp@qdanTPg@HUdAaDtAgEZaAh@eBL_@Ni@@EJS@GDK^aARg@x@_C'
                     },
                     'start_location' : {
                        'lat' : -8.131583299999999,
                        'lng' : 112.5692143
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,5 km',
                        'value' : 1502
                     },
                     'duration' : {
                        'text' : '2 menit',
                        'value' : 134
                     },
                     'end_location' : {
                        'lat' : -8.1459268,
                        'lng' : 112.5682274
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Panji\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jrsp@cbbnTb@N@?nBp@p@VTHXJtDrARFbCx@xBr@z@\\\\LbBl@dA\\hA^VHjCz@`@NtBv@dC`A`Bl@tAh@l@VD@|@^bBn@d@PpCdArEfBx@ZpBt@'
                     },
                     'start_location' : {
                        'lat' : -8.133659999999999,
                        'lng' : 112.5739446
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,1 km',
                        'value' : 8051
                     },
                     'duration' : {
                        'text' : '7 menit',
                        'value' : 425
                     },
                     'end_location' : {
                        'lat' : -8.1756606,
                        'lng' : 112.6339328
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Trunojoyo\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`_vp@m~`nT@EV{@t@}BT}@BIdCsIdAwDd@aBTu@j@kB`@qA^uAj@uBLa@Lc@XcAPk@@ExAiFpAqEx@_CJY\\iAf@kAZ}@h@qAPc@Vg@Ra@@EpAyCd@eAtAyCXo@HQj@}@jAyAl@i@JGDIBK@ICOCKEOIQY]]c@O_@CKAM?Q@IFYVo@^s@\\m@Xm@b@{@Tk@^oB`@yBZgBXiAb@iC|@{E?CnAcGlAkGZuAHWVi@f@s@lBiCf@}@TYd@i@`@a@ROVODEFE`@YVWp@y@HMZe@`AwALOHKBGXa@x@kAh@w@r@uAPa@N[Pa@Xi@^w@f@aALYJQLURa@f@aA`AqBd@cATe@l@oA\\s@BGl@uAXu@nAaDfAaDrAwD`@kAHWb@mAPg@hAkDFURo@LYv@}Bh@aBJ]@?DMPg@h@{Az@cCt@sB?A@Cd@uAt@}B@Av@}Bl@gBXaAhAiDXu@b@sAl@iBt@{B@CPg@Pg@DM@EFQd@yAl@iBb@oAX{@@El@kBLc@h@_Bn@{B`@gA|AwEp@gBRm@r@eCtAeETm@?CbBaFFQ\\cAjAqDPg@JYFSj@cBDMlA}Dd@qAh@wAf@{AnA{D^kABI^gAv@eCb@qALa@'
                     },
                     'start_location' : {
                        'lat' : -8.1459268,
                        'lng' : 112.5682274
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 552
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 28
                     },
                     'end_location' : {
                        'lat' : -8.177707,
                        'lng' : 112.6385014
                     },
                     'html_instructions' : 'Terus lurus ke \u003cb\u003eJl. Dipenogoro\u003c/b\u003e',
                     'maneuver' : 'straight',
                     'polyline' : {
                        'points' : 'zx{p@aymnTvBmGzCyIPq@rBwF'
                     },
                     'start_location' : {
                        'lat' : -8.1756606,
                        'lng' : 112.6339328
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '14,1 km',
                        'value' : 14144
                     },
                     'duration' : {
                        'text' : '12 menit',
                        'value' : 726
                     },
                     'end_location' : {
                        'lat' : -8.2117784,
                        'lng' : 112.7461118
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'te|p@sunnTW{@EKEIWo@Sc@_@{@Yi@iBiEMYoBsEsAyCyAeDy@iB{FoM[s@iAiCWo@KWEKAGCK@{@J}Ap@gIB[DoA@gFCcCGaB?OMyCGcB?a@AG?AMcFKeEKgCCw@MaFK}CGiCAmAIaC?Y@[BYBM?ABMBKLa@r@uBNg@Tu@To@rAeERq@FU@GBI?E@G?GAQAIAICIM_@y@kBUe@gB_E[{@sAwCG_@?GEc@AU?q@B_A?MFsBB_A?SG}B_@eEQkDA_B@y@@c@A[@q@@qH?C?[?k@?_D?aF?cDBs@?EBw@@[B_@BYFSFSJQRWd@[j@Wl@Qd@Kn@Kl@MTEHCDAHCFCDA^[\\_@xAiC^s@hBeDHQ`B{Cl@gAnBoDjBgD~@}A|JqQrByD\\q@bG{KnByDxBkE@CnAaCZo@b@aAh@gAXm@hDgIr@_B~BwEPa@DGFO`EqIv@cBpCiGLYhBwDd@w@JQHOHMDIDKBEBGBI@C@E?A@K?G?C?A?C?AAA?AACACEEEIIOMQIOGIEOEMEOCOCOCU?Q?QBU?ADa@Fo@Fe@?AL{@LeALy@F]Jg@FSBEJUN[^YTKd@Qb@Qd@Qf@Q\\Kf@Od@O`@M`@OTOFCBEDGDEDGP]Zm@Xg@P_@PYVe@Ra@Rc@j@_An@wAXm@tAcDhAaCb@{@\\o@fAwBDI\\s@DKfA}BP[Te@j@iA~@{Af@w@T]p@}@tBqC|AcCvAgCBG\\q@j@oAPc@JWFUDUFe@@W?UAK?GCUGg@Ey@Aq@A{@CcAGw@Ks@Ms@EWUuAQgAQiBCQE[?GK}@AQGi@Go@Eo@Ei@?o@@q@B[Di@Hm@TyANw@Jk@FYF[Lm@Ji@FWLo@TkAh@uC^iBPu@T_ALi@Tk@HQXi@FKP[JQHM\\o@z@{ABE`@w@Xi@P[Pa@FKRc@JURa@Ra@d@o@n@q@PQlAqAZ]T]N]Rk@J[Vu@X{@L[?CJQBEDGLMPITCXAb@F\\BF@NAFC@?BCBA@Ev@uA`@i@b@a@LOLKJGNGJA^B^@X@H?LAfAO~@Kd@?PBL@NDPJLHRPj@b@v@p@l@j@RRFBD@FBH@N@J?HCFC?ADCBEBEBOBIJu@H_@FS@U?KAEACO]KWGUEQE[AMCMCKEOS]u@qAGUAQ?UDODQT]`@e@j@a@TKVMNITMHIXUv@o@^UXIBATK`@SFEHM^e@RWPSVSNKfAw@BCZUVUT[PYXk@NWJSVe@Ve@NO@AHGHGJGp@_@@?HE`@UPIVM'
                     },
                     'start_location' : {
                        'lat' : -8.177707,
                        'lng' : 112.6385014
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 196
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -8.210758999999999,
                        'lng' : 112.7472671
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Semeru Selatan/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'rzbq@evcoTLy@@E?G?EAIAEAEAAAAAAQOi@YsCsA'
                     },
                     'start_location' : {
                        'lat' : -8.2117784,
                        'lng' : 112.7461118
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '24,3 km',
                        'value' : 24284
                     },
                     'duration' : {
                        'text' : '27 menit',
                        'value' : 1619
                     },
                     'end_location' : {
                        'lat' : -8.222469,
                        'lng' : 112.8936473
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Semeru Selatan/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'ftbq@m}coTBI^{@rAeDLW@CTm@JUFMbAcCd@iAZy@l@_B~@}CdBcFl@iBnAuDx@wAr@kAxBmC`@k@~AaBTYZ_@j@eAt@eBZ}@L_@FY^{AHa@TuA^gCPuAR}AP{ALmBNsC?AB}AAuBA]?Y@U@KFSbAcBPUFKDKDMDQBQBQ?OB_@Dg@Fo@H_@Je@DQFODIRWNMb@]h@]NGNAZAh@BRCNEHIDKBI@QAMCWOq@C[AOCKAMCMc@_Be@iBAKAI?KBGBEFEFAJAX?b@?b@Cf@C^CZGr@QXG|@WdBg@rAY|A[RGLGNIHMFOFY@S?MAKEIEECCQIWIeBg@YMMICGACCG?E?G@KHOJUNWLQFODMDQNaBBk@BQ@GDG@AFCFAFAR?LB`@BfCV`@D|APz@JV@@@L?JAHCNGPITONOLSDMBK?M?MCOCIEMIOIKIEIEKAKA[Ca@Ec@IYMMGIGIMGOGQMc@CMCK?S@c@D}A?YA}@GqAAq@HmBBo@DYDMJQRQNOp@e@h@[\\WPQT]HUFY?OAo@Ee@Ek@Iq@Ii@COGSGWKQIOSUQSGMAE?E@GBEDK\\_@LQHQHQ@K@QASEOESKW_@k@Q]CK@K?EBGDIHGXO\\Q^Yr@k@HGNMZ[\\i@`@k@j@s@TYHIFIDEXY\\[NI@AZULMJKPWDGR]~AgCJSBS?MAOESCQ?I@M@KBKDMHQL[@C?C?C?C?C?A?A?CAA?AACACIMOMWSQIWMSKe@SMGGEEEGECGEECGAEAGAGCKAM?O?KAUAS?[?_@@e@JqDB_@?GBg@@E@E@C@A@CBA@CBABC@AB?BAFCD?DAD?HAH@L@PBJBp@RF@H@D@B?D?BAB?BA@ABABC@CBEBCBCBG@C@C@E@G@E@G?G?GAGAIEMUc@CICI?I?I@M@GBI@C@EBEBCDEBCBARINILKNQFI@EBC@G@E@E?E?EAEAEEIGIOQMMIIKKEIEECGAGAEAE?EAC?I?M@YB_@Fu@BIBGBCDERQLIFEBCBC@A@A@C@A?A@C?C?C?C?A?E?EAC?CACACACECEGUSGGCEOMEGEGEIEKGQGOEMEMEQAEAIAE?E?E?G@G@G@IDMJSDIFIDGDIBKFMBIBK@I?I?QAOAMEQCMCICMAG?IAG?G@G?I@IBKDOFQBIDMBMDIDMBKDIDIFIDKDIBIDKBIDUDMBMBIBKBM@Q@K@M@S?U@UBS@O@Q@Q?M?K?IAKAIAGEKEGIIIKOMOMOMKKKMKOGKCMAIAG?G@G@GDIFKHMHKDGDIDIBI@E?C@GBM@K?E?C@M@O@Q@CBIBKDIFMFIHIHILMNMJILKJGFEFCFEFCBEDEBC?ADGBG@E@CDMBKBGBKDKDIDMBK@IBE@E@E@C@E?C@G?EAIAIAEAEACCGAECECMAIAKA]A[AK?E?E@G?IBGFODMN[P]JUFMDGBEFGDCFEFCFCHCFAF?DAF?F?H@J@JBLBL@J@J?B?D?D?DABCDCBCBE@E@EBI@I@K@M?I?I?IACAGAEACAAACCCCCECICCAKCWIYGA?UEECGAEEA?EE?ACGEICKCOAKAKCOCM?KAK@I@I?E@C?C@C?E?C@C?E?C?E?C?C?EAE?GAEAC?CAE?EAIAG?E?G?E@EBGBIBGFK@G@EBE?E@E@I@K?G@O@M@K@K?M?I?C?G?MAI?IAK?G?I@K@O?M@G?G@G?EAE?GACAECEAGGIEIEICIAI?K?I@IBI@GDIDGFGBEFIFIHGFGDGBEBEBEDMBMBI@O?GUiAWaBG]AS@O@MDS`@mAH_@H[BSH[PYDUDO?U?UD]@WBMFOJMh@w@JSDOBG@QAOA[?O@M@KFMRUNKFGDEBE?I?ECKCGMQKUEMEi@G_@KUMQQSGMEKCI?M@oADe@@ODQJ[HUBK@O@KAIGMKKQOMQKUCOCQAK?QBODM`@{@HOBGFGFEDCHAD?r@EJCFCBEBEBEBK?I?ICQAQ@K@IBGJSPUFIBI@O@MEo@?u@BY?SAKAIAEACEEGAIAI@IDA?YN]\\GHEJERAJEJGHURMFIBK@K?OAWEy@Ua@OOKGKEMASDgAJiCBoA@QAMEM_@eAU]KOeAeBISCIAK?KBi@?g@Ca@Gw@CY?CEQGMEGGGMIOEWAWAKCKAICIIMUKMEGMGKCM?[@{@Lg@HS@M?MAKIIEEEKOQUIMGGGEUOi@W[OGIEGCI?I?KF{@Bo@?Y?OAQCSDQDWFQBGBGh@c@XYRUJYJ]Hq@Fm@F]H]NWTYNUPYFQDS@W?_@@UBSH[HWP]JSBK@G?I?I?ACOMUIOIMQQUKe@SKIIIQ]Yo@a@_AMc@CUCS@c@Dk@NuADg@@]EYEYMq@Ee@Ko@CSAU?]@[F_@b@sATm@BMBUDm@@a@@U@QH[`@w@FMBI?I?I?ACICAII]Q]QGEGCGAI@C@ID[RQD[FWBQCMCKI]WECA?C?A?AAC@E?I@G?EAGAGEQMY[MOYQUQOMi@_AGKCG?EAE@GBSDOFEFGLE@?J?h@DdBL^?H?HCHERQn@}@v@gA`@m@^u@DKFGFEDCJAF@D@FDHHXj@JHFBL@N@PA^GXOVONOJODI@C?K?I?EAAAECECIGWCK?K@K@GHWDM?KEOWm@AI?G?G@GBGFKZYx@o@^_@FIDCFAJAT?^ANCHCHELKDGBK?IAICIQWIIEE_@_@GGEIAEAE?E@IBMJUBMBM@O?M?IAOGSKSGQCICKAI?GBIBIDIFIHGLEnCu@RQLMDKDOBQBQNq@^iAHUFGLIVOVMFIDIBSB_A@gA@I@IDEDGVKh@MHEDEBEBUESGUCQ?G@GDIHIdAo@RSFIDKDKLOLOFGDIBI@G@IAKCWM]EWA[?aABOBMFSRq@H]J[JOFIJMDCZWn@s@p@wAVg@HKHKLMLKJGRKDEFGJOHUDKFIDCBCDAD?D?F@VDTDb@Fb@GJAJCLEJGFK@K?KA[AI?K@KBIBGHIBCFCX?N@J?F?FCDEBGBEDM@E@MBMBUDMFI@CDEHEHCF?PAR@R?H@XAL@R@B?RDLFPLNFHDH@J?L?HAHAHCJCDEDEBI@G?G?ICIEIEGGKCICICKEQEYEMCKAGAE?G@EBKDIBGDEDIDEBG@EAE?GGGACCACAE?KAI@GAOCCAAACACEAG?G?KBMFQ^_AHUJ[H[XcATm@HSHSLQDGVYr@q@TUNOFOFOHYDQHSHQJOJMJITMPILGFE@AFODKBQAMAEAGCCCCEEIGECEAIAG?I@KBIBOFYLYPKJSNMFIDC@E?C@E?QKIGKMEIEO@MBG@CFEf@[l@Y^UNSV]n@cAFQ@CDGBGBCBCDADADAFAL@`@DN@J@J?JADCBABCHKJUJSHMPKNEJEDEBGBS@g@@}@@IBOFSPYPUJIHKBC@E@I?SAYAg@?KAQ@ULu@Pi@P]V]NOHQDO?G?IEOGKKGMMGMEKCQAMCMCE[g@e@aA]w@EGKKGEQOIMEIGg@ESAGEIGCECEAC?C?G@GBEDSNw@j@m@Xe@PSHi@`@m@l@e@ZIBI@E@G?E?q@GqAS[C]CK@E@E@]NG@C@E?G?CAEACCCCEGAGAIAM?IAGAEAECGS[KSGOCGAMCSAGAECECEAAGAI?G?C?E@EBC@OHE@C?A?EAEAKGWKGAI?E@UDMDOBI@KAIAEAg@Og@Ug@QQEI?OAaB?_A@g@AK?SECCCCACCCAC?E?E?G@E@E@EDGDEXOrAs@TMJKDEBIBG@O@K?K?IAGACCECCKKKG[Q[WEGCEAG?M?C@G@EBEBCBCFAF?P@L@XHd@HRFFBHDDBBBFJFR@DBFBFFFDBB?@@B?D?B?D?FABAROTO@CB?DANANAJADAB?DCBCDEBIHWBIBCDCDARATBVBL?N?NAd@EHALGHG@EBGDM@K@MAO@OCQAGCG?CCCCACE[Sg@YQO?AMUKUESAKAQHwANw@La@FM`@k@TWhA_Bl@q@PWPWBGFK@E@I?IAEAGUYKK][OKKEOEE?E?E@KBEDIFSLUJC@E?E?K?s@QMCCAEAI@E@I@GBULq@b@GBE?C@GAGCICECEEAECE?EAE?E@E?EBIT_@lA}Ab@o@DI\\g@h@eBLg@B]EQKKECGCICIAK?c@@YD_@JyAt@QJIBG@E@G?G?KCIGMIEEMOAAS_@IQEMAUCQ?c@?eA?}@?W?eE?gA?oA?K?K?M@U@MDMFODIJKRQTMd@YTQDE@E@E@E@KAOKoAI]EQGOIOCEMMGEKGOGMCs@QMCIESMGGIKSWOQMKAAMIMEMGSC[EO?[Dm@JODI@K?OAGAGEGEACCCAG?CAC?I@IBKBINYf@y@RYHODOFWBS@OAsAA]?y@AU@OHa@BS@K@G?G?GAEACCGGIIICCGCGAGAE?G@MBSJIDi@ZSJIBE?IBCAIAGEGIEKEMG]?a@Dc@Fm@B[@YAYEQGI[O{@[a@OWSIWG[G_@?ACMO[MYISi@iAm@mAQ[MOMOSOQEG@KFQNMHIDM?SAOEQIUWUSQOGCK?G?E@IDIJAJBNBN@LANGVO`@WXOHK@K?ICEEEEGQ@UDW?MAICGGEGCKGMCI@KFOBYJS@MCSIOIIKAWJ_@DQBMCOMOWGa@D[FKAGASIc@a@EIGK?M@KBKBQ?G?IEMKQOKUKQGM?MBe@Pq@T[LK?KEOQQ[IWKq@Kk@Gu@Bw@Cs@GQKMk@SsBO_AEc@COG]UMEMGGCKAKAK?IAICGCGGGOAM?IB[@KHY@E?A?A?AAAAAGEOGGE'
                     },
                     'start_location' : {
                        'lat' : -8.210758999999999,
                        'lng' : 112.7472671
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,9 km',
                        'value' : 1916
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 161
                     },
                     'end_location' : {
                        'lat' : -8.2288958,
                        'lng' : 112.9056677
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'l}dq@ip`pTPc@NYHGFC@?FA@?@ABEFY?[CWGa@Kg@Ei@Cg@B]DSRUb@_@b@UTAl@At@IZIb@[b@w@He@H[RQ`@GZG^EVOX[HUHW@a@Kw@EW@UDM^Wv@c@r@]DCDG@C@E@E?C@u@BYDMFMNMXKLIJMDGHEFAHAd@LZ@HEHIFMBO@QA[AYMe@Q[Qa@AMAE@I@CJKRILKFMBE@KAKGOKMIMKMEU?I@QDKFGLAX@^@F?DCBCDET]^i@FQDMAQIQ[YKMCECE?E?E?C?EHe@Lq@Hg@J[FIHGJAN@RJLDPBJCHEDMBI@]BUHQRYt@s@dA{@\\c@@E@G@OAICIIMMGOGg@QSK'
                     },
                     'start_location' : {
                        'lat' : -8.222469,
                        'lng' : 112.8936473
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '34,9 km',
                        'value' : 34916
                     },
                     'duration' : {
                        'text' : '33 menit',
                        'value' : 1962
                     },
                     'end_location' : {
                        'lat' : -8.210084799999999,
                        'lng' : 113.0972826
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'refq@m{bpTEO?K?S\\aAJ_@DMDWDc@BODMBMLUJM`@[VSXSRMLMFIPSBg@AQGUc@gAAEGOKWS[KQSSUKqAg@QE]KMKKIEGAEAE@C@EBEBCDCFEHENEZErBYb@ER?P?Z@t@?p@@J?J?RANCJEFEBGBI@K?IAGAECGIGQOo@c@MKOKYOy@]WMQEQGWISCKCMEKMQSMMKEKGa@EmAKm@EUCY?WCUCWGUIWIu@e@OKU[c@{@Yk@u@{AO_@O[qAiCK[QYUWWUa@Y[Q_@QWIWCSC[C]Cs@Ie@GsAYA?ICKIMOCKAK?Q?QFc@F]BKDGDCHAR?H@\\Dt@JbA@f@ATANILMJKLSLY@AFMJMLKr@_@v@i@\\SJEJAPATAf@CVITK\\Mx@[LGLKHKN[@YAg@Ki@CMGMEMAC?GAC?Y@UF]Pg@Ji@F]@CDMJSLSJIXM@?b@ORE^GN?F@D@D@FDNPPJ@@JBL?PAVI^QRKdBs@b@SDABCDAD?FAF?F@B?PBRDD@D?F?FAHCNGFCFANAP?R@LAJ?HCJGTSTa@n@iATe@JYDQ?O?CCKCIEEEEGEGCIAIAI?E?C@IDEDQRKNGDIBG@K@IAGAECECEIEICIEa@A[@]?_@BeBAgAAQAe@EaAI}@CWEYKYISu@{@YYEECGAE?G@I@EBEFELEHEJGFEDKBK@I@K?I@I?G@IDMDKFIFKHKRQXQTO^YZYJKBC\\_@Za@LWHODOBI@I?MCKEMGISMa@S_@OOIIEGCG?MBOFKHUNOHKDI?O?GAKGIIMYWu@[aAO_@MUIIKEOGUI]IUEwCu@i@Ma@Ii@OWKUQy@}@s@y@s@w@y@_Ak@m@W[IOCG?G?GBKFOJUVa@Xg@DUAOEQIKKEk@I[?i@Cc@Ki@Oq@SmBs@y@]k@]s@g@UOGEOOGMEOGSCO?CGWGKIIKEKG_@Ge@GOEOMEO?ACK@S@MHMXYVUJODS?O?KEIIMGEGEKAK?M?UDkAf@mAf@g@LE@QD_@@UECAe@YAAgAgAiAeAOO{AwAeA{@QI?AQGOEMAQAS?W?QFMD]Hi@Tc@Ji@F]Aq@Go@KqDy@iC{AqC}A_A]GC[QKMMSQQSMA?OGa@CKAaADq@Ca@IKIOKu@{@MISKe@SOMGIIKAO?Q@KDWLa@JONSHQBMAKAICKIK]Se@S]WQSG[Ie@c@gBQq@ISIOQSESAS?SHy@D]DQPq@F[B]@a@AI?U?W?MAq@?OAWA[CUCQEUIY[o@Q]QWIMACACAE@G@CBIJSFIBEFCFCLCFAL@F?FBJDPJDDNLRPNLJF\\BNAHANGHCLMn@aAh@_Ah@iAH_@BI?]?WEUSq@KQMQCCAAOOeAYa@We@[c@]UQMIECSMs@g@OOKIMKc@w@S]O_@Kk@CYAg@?UEQO[QK_@WKKGI?EAI@GFIDGPQLMR_@DK@OISMOKOKOIQGW?O@c@By@Eg@Ou@Mi@AM?M?I@IDIJ[BQBQ?S?M?g@@KBK@IFKPWNOLSDIFYHq@Bk@?w@?QAQ?C@K@KBKDKPOJKTMVO`@WZQZUNMHMBGBI?ADQ@S@M?M?OCSGYCEIQIOISAG?I@EFKJMn@o@f@g@TUNMNOTUFIDIBM?Q?G?MCGEIIKKOKSCG?KAG@A?GBSBKHMDEFELGNEXETIRCTGHAZ@ZDXH`@LZFLAFALGFK@IAQCUISOWEM?G@ODMTUFGNORUZYLMPMTMd@O`@I^KTKTQHIDI?ABM@G@IBS?UAOEYGQOWMKMIIESI[E_@E_@Gk@IQEOISQGGEOAG@ODQ@C@EJKNKROPKdAk@bAq@l@]TOXOFG\\UVWJWFUJ]BOFMFEHEFCJAJ?LDFBHHRRZd@FDJJD@D@P@PAPEHEBCHIBK@I?QCMCCAGIKQQOOOQGQAK?MBIBGFKDGXGZKHC@ADE@ABEBE?G@E?GAQGSGYCK@KDKDEHE@ANEPEZG`@KFENIHGFI@G?E@OASCa@ASAMAIAECKCKGIS_@MSEO?K?KFOJUHOBM@I?I?A?EAEEKEISQq@c@m@a@uBqAe@]IIIICICK?C?SBe@Be@DYDSDIFGHEFEH?BAL?T?P@J@XCTMFKFSDW?E@Y?QCOCGKSKQOO[Ui@_@UQ[Si@UA?u@Um@KQOGKEOAUDoADu@FaA@EBm@@q@Dw@Du@@]@CBQFOFIJIPMj@_@RODEBE@CDK@K?K?I?IAGCIIMMMYSi@WWSIKAAEICI?M?O@OFSNc@FSBK?E?E?EEKEIEGKKSMQOIIEGKM?ECG?WAe@AW?Q?O?IBKDIBEBCNUDM@G?IAICGEIGGGEMMWOSGc@OSIGCEEEGEKEQEQCGCKCEKKOGc@MSIICOIGEEEEIAUAU?S?M@SCYEMCEIMIKOGIEOE]Ck@Gc@Gw@IQC]EUEIGGCEIIIEIACCG?E?C@MBKBKPS\\]b@w@Ja@DWAWAOGKGIi@a@]SOIIIOSAAM[MY[o@CIAAIOWe@OSOUIOQOQKEAOEu@Ys@S]Ik@Qy@Uc@KSEkAYUIMKg@i@QQGEIEOCU@SFOF]Rc@\\OFKB[@QCa@UWQe@[YQ]Q[GWFWDm@H_@CWEi@Qm@Um@Oo@UOEIEQM[[QUq@eA{@qAc@q@KUAM?SDQLUBEBEFOFO@EBSAYKq@Gg@GU?AGMIIGCICM?Q@YFO@MAIEGEQOGIAK?SD_@@CFq@B}@AKAKCIEISKOGg@QgA_@q@QSQSOUU]UQC[@[BY@U@SGSGMMKMGSAY@_@@i@Po@Xs@Zy@\\_AD]BUAQACESIQQQOKSC[CWAc@KUQc@w@e@m@i@aA_@k@e@o@KMm@y@c@aAQe@_@w@[a@i@o@MQGMY[W]SS[_@CCQOOEMCMAM?KAuABY?[@}DB{B@mB?w@Ia@SMOKKOc@CUAYB_@@O?KAIAKCKAECGCCIGIAGAK?I@I@QHWJSFKBGBK?I?SEUMq@c@m@]s@]GIEIEKCUAOASAOACACEAAAE?I?E@WJ[HMBM?]BG@[@a@?KAKEIEKMMQIMCGAEAIAK@]BKDKFUBO?C@E?GAEACAAAC?AOIMKACGKCEAECKCYAs@A_@?q@?[?QDi@?IBKBIBC@EFGDETKXGRIHELGJIBE?G@CAE?GAGGKMKUMOEIAOCg@Ca@EICEEGKCKAK?M@SBKFGDIl@]~AcARQBEBK@C@E?GCOIe@?Q?IBOBMJWFYFO@EBU?AAO?ECMAIAG?KAG?E?I@GBEDEBEHGLENEHCBEBEBIAQ?EAGCIEKAEAKAO?E?G@G@CBEN[HSDGFMBI@IBKDoAGWEKCCOMYMa@K_@MIIEGAEIkA?g@DM@EJQ^]v@e@JGHEBCBABI?C?GAGAE_@k@GG[g@EIAU?C?M@GDQd@{@J]@??I?C?EAAAGAACCE?E?]DUBQ?I?ICSEKAK?I@E@KBMLGLCBA@KFMDSDKBQ?MCIAWKWMGEMOCEEO?MB[?I@QCQEOMUMYMOCCICIA[@aAL[@CAC?EAACAACEAI?O@G@ERa@DWAM?GGMEGMIKCICO?k@Jk@NYFG?MAICCCGGCEAKAO?S@MASAEACCCGGCGCE?C?E?ABKDYBS?E@A?CAG?AAICK?C?E?CBGn@eA`@e@XY`@]NKBC@C@G@C@G@G?G?G@_@BO@E@E@CFG\\c@Z[p@]RCNAP?LBH?JAHATKnCcBJKFK@K?IAKCGKUIM{@q@KSKYEO?GD_@JYR]JYDS?EAKAIAIQa@S[EQAK?E@E@IPq@@G@KBOCMCKKYCGCGEGECGCIAE?A?C?GDEBGFCDEHOXKNQVMRCH?D?@@FBD@D?@?@?@A@A@CBCBE@WNMLGDCDAB?DAH?BCHCBGH[RQLEBMBy@Ji@Ds@?_@BS@ODODKBGFCBADAFAB?F@H@JBHFNFPBHB`@@X?FALEPABGJEBGBSFMFEBCBCBAFENADCBA@C@C@E?I@U@y@DIBCDCFO^Mh@CDMPGJAF@DABENGLEBA@C@G@Q?K?IBGBCBEDCDABAJ?BERM\\CHAH?D?BABK^EBC@E@G?GAEAEE[W[Wo@c@u@_@MEOEICC?E@EDIJGDCBKBC@E?C?KCCAAAEEAI?KD]@I@G?C?E?EAC?CCCACEI?C@E@EBEHMPS@C?A?E?CAK?CEIEKCGGECCGCKEOEQGGCIGCEIIGKMQGIIIGEOEOAQAI@GBIBEHGJIPORYVa@`@a@ZWRe@^URSRQPOPQPOLKFKDOBOB]C[EUMMSM]Qi@CMCO?MF[Xm@Te@FUBW@QBYFOFQDWJu@FWDSB[?Y?O?YAOAWAOCMCIEKAG?E?E@EBIBEFGDGDIDIBG?E?ICOEIEOGMGMGMGQAM?KDOBKJONOHMJMLQHQJSFSDQ@O?M?KEMGIGKIKIGKIGIGGEEGEKCMEMGGIEIIOGSIICEOGI?O?M?MDIDE@CDGFCDEJAFAFCFAFABABABABA@A@C@C?E@E?_@DWDKHGBEDCHEHELEHEFGBE?IAEAGEAECGCIEOGUAUG[GUIKEGGEGEUIQKGEKKGOEUEUCOGUMa@IUISCOISEOEKEIGGIEKGOEi@M]GQAO?O?I?G?M?OC[IECEAGECECCEECECGAGAM?M?K?CBg@BcABcA@Q?Q@YDY?CBK?AFQNc@DIN[^{@DIVg@Vk@~@oBz@cBf@gA\\w@|@kB`@{@`@{@Zs@j@kAHQ\\s@f@iAf@eARc@v@aBBGJQDGBEDKBIDK?G@C@I@IAMCICKEKGKKQMOMQW[OWOYGQCWBQBMHWt@eBbA}Bh@iAP]LWv@cBdBqDr@sAf@gAPe@z@{ABEb@}@f@y@`@i@|@u@JK`A{@tAmAZWbCsBJKjBgBnBcBf@c@dAaAbBmA`CqBh@_@~@u@d@c@~@s@lAcAhByA\\Y^YfA}@p@i@b@]JIj@e@dByAVWJIHIRQJK\\[POPOLK^c@XWHIDCVWj@i@n@k@f@a@PQFGHGHIDGDKDK@EBQ@OAUCSCMGMCGGGIIA?OMAAIGWQYOA?k@[s@c@{@e@q@a@i@[CCOISOIKAAIMKUM_@K[CEIQACSYEEOO[_@UUQMSQWQMIQOMKSMMKSMIIIGOMSQOMWSUe@[q@Og@AECQE_@Go@C{@Gs@C]COAOGUEMGO[y@m@yAg@eA_@y@Ka@Yw@Og@]aAGUEWCKCKAE?G?I?I@OFa@Lg@Je@Jc@Le@Lk@L_@Na@`@aAT_@PWRYPYT[T]NWJQHQNW@AJYL_@DOBS@O?I@[?OAO?_@BU?QAQCSEQGK[_@CCa@USMKEYOQKo@_@c@We@]c@_@g@g@YWUS_Aw@QMo@c@[QQMu@e@EAAAKMKSGOI[CSAUC[AYG_AAW?KAKCa@C_@Ck@Cs@C]C_@?IAIAGAMCUCQAQC]Eo@Ei@Ca@AO?AAMCQ?OAO@K@CDKFIBEJQ\\c@JMJKTSLILCRIFCHC`@Q`@O^OFEn@Uh@UDC\\MLEJETILG~@_@TKv@]b@QFEh@Yv@e@XO\\OHE`@QXM\\O\\QPKLIRKTQPUTW@CT]HOJOT]j@u@Z]LKDCDIJQV]T]Zg@\\m@FO\\q@\\o@\\s@TY`@e@VWJM`@c@X[\\]VSb@[XOTOTO^KTG`@Ob@Q\\OXMPQPMHEVQNMNM\\UPMROROLGNKPOPU@A^i@f@}@HQXm@Pe@LQHMJKBAXQRKLGRMPMJMHKJOLMT]`@i@?A^o@TUX_@^e@X]TWRUd@g@\\c@JKTUJMX[d@i@Z[Z]f@m@BC`@c@f@k@h@m@LMJMV_@HOJSDO@CFODSHWN_@PUPWLUJMJMNUFMHM@CJUJUJ_@BIPc@Pc@HQNe@JYP]BEJWNYN_@P]P[LYPWJSHMFKHONWLUDIHIHGJEJCPCLCFAHAFEFEDGHKFKDIFIDGDIFEJEHELAL?L@JBPJLDJFVT^RJJ@BDDB@D@FBD?B?B?BABCBADETQNQLW`@u@r@gANUXe@NSHMVc@BCFIFIZg@@APUR[^e@`@c@ZUFGr@c@VQDEPMBC^YLIXUZUzAeAJGXQXSFEBCBCTU'
                     },
                     'start_location' : {
                        'lat' : -8.2288958,
                        'lng' : 112.9056677
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '21,6 km',
                        'value' : 21606
                     },
                     'duration' : {
                        'text' : '19 menit',
                        'value' : 1115
                     },
                     'end_location' : {
                        'lat' : -8.135069400000001,
                        'lng' : 113.2137787
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '~obq@_ihqTWe@CEEGEISWWYq@s@c@e@MOk@o@UWQU_@c@CCSWkAuAY_@cAiAqA{ASU[a@_@c@UW{@_AGG[[US_@]][[Ua@YOI]Ua@Sa@WICIC]Mm@O_@GOEUKQGMEYOWMYOKIKIUQWWMMCC}@aAQSg@e@QSOMIIUU[YUUWUGIGIGICEAEGSGWGWEW?AESCUE_@Ga@E_@?GAK@I?A?G@G?GDQBOBMDMDMDI@GFOFOL[HOFKFGPOZSFCDCFEDCHEHGDEBCBCBEBEFG?ANUNQR[Va@PY`@o@^q@HON[Ra@Zg@v@mAt@kAd@y@Xi@L[JWTi@DMj@uAPa@`@{@LUVa@l@aAh@{@f@{@BEp@kAp@gAZi@DId@w@l@eA\\k@`@s@T]R_@NUBEDCBC@CDCBAFCHC@AD?D?DAD?L?J?D@D@HBJBNFZRB@nAt@VNLFdDlBVPxDzBjF~CPJ^Pd@N`@D@?J?F?B?J?xBFzADR?f@DX?\\?VAXCRCXGzBg@TGd@MTGDCp@Sj@Yh@W~@g@`@S`@_@zAaA`@]j@i@f@c@l@e@VQx@s@lAkANOf@i@Za@X}@Je@Ro@Vu@N_@P[h@cAZk@h@}@DK~@aB^o@zAkC~A}Ch@cAp@sAjAgCLYb@cADI~@_CJW@AZ{@BGh@}A^mAPi@Ri@J[Tw@@G\\iALg@HWNi@Ru@BKFSZgA?Ad@kBBIh@sBJ_@FYD]@UAo@@kB?o@Bq@@w@?CFmCDoB@s@FeBD{@HsC\\mK?GLqBJoBDaABU?QDs@BaALyB@YT_G?[@qAAMAKEYIUEIIISOk@WUMSEKCG?IAIBQDo@ReA^}DxAQBM@I?w@Ga@GWIOKMQO]_AiCq@}BIm@Ci@?YBWL{@H_@@MBQ^sBLg@Pi@bB{CpA}BDI@CLO^c@bA}@j@a@|@s@VY@ABC@EBCBG@IBM@KDYEe@EWQq@o@qB_FaPCIEKIUSo@u@yBa@iAGUM]Y_Ao@mB[aAc@sAgAkDCIGUiA_Da@mA[}@EQWs@K]_@_A[_AkBsE_BuC]k@{AiCi@_AwAaCU_@{BuDMUY]MQIGUS{AoAmAcAaCuB[][YUYKQCKCGESIc@Kc@Oi@CGEGEGIISQWOyA}@kAo@w@_@kGyCyDgBoCsA[OSMSQQOOSOSACa@q@{CgFQU_@q@_@s@kAsBmBiDk@iAS]EIEGCACCUKc@OSEyCi@s@IeDm@{@OwDq@m@KcAQi@IsF_AaBWg@IoB[eHiAsEu@u@MwAUuAUu@MoASmAUiBYwB_@kDe@cB[cAQyDq@s@MmB]sB]sGiAgCc@oAWoAUiEw@c@IyAYcEw@mCi@kB]oCg@m@KgB]WEmIyAoAUkASOCcCe@e@K}B_@{B_@[GSGoA]GCeBm@}Ai@gDiAcBk@oAc@QGoAa@GCq@SICmBi@UG{DsAo@Sw@]_@OgAYaAOGAwBUaBOs@ISAc@GWGa@G]Ia@OUKQOAC{@eA_AcAc@_@iA_Aq@m@{AuAm@s@[]y@y@k@m@c@_@iAiA_C_Cq@q@][uAuA[_@gBcBYYGG[WMMEE_@a@sAuAc@_@c@_@c@k@o@o@i@k@SU][iAaAi@]c@YWScAs@QMkEqCyFsDgEiCSKqBeAcBiAu@e@_Ak@a@W[UQMQKUMEC[Q]UgDoBgAm@GEi@WYOy@i@IG[QIEKGOKWOUOSMOIQIgAo@g@YQMSMWSwAy@}@i@w@a@q@[[YkAs@m@]]QMGWMUMi@a@kAm@g@[a@SKG[S?AMGWQkAs@[USMe@WaBaAm@]yCaBiAq@eAm@w@a@_B{@oA}@oBgAaHaEw@e@k@]KGg@YgCsAa@Yy@e@_@Uo@_@WKqCgBm@Y{@m@c@[w@c@WOaAg@a@i@GIEKGMAKCOC[?w@@}D@}CAECK'
                     },
                     'start_location' : {
                        'lat' : -8.210084799999999,
                        'lng' : 113.0972826
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 173
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 15
                     },
                     'end_location' : {
                        'lat' : -8.1335833,
                        'lng' : 113.2141426
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Imam Bonjol\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'd{sp@ca_rTGGECGAsCUo@CQCSG_@MIE'
                     },
                     'start_location' : {
                        'lat' : -8.135069400000001,
                        'lng' : 113.2137787
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,4 km',
                        'value' : 375
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 82
                     },
                     'end_location' : {
                        'lat' : -8.1340273,
                        'lng' : 113.2175003
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Kapten Kyai Ilyas\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zqsp@kc_rT?YAKAKGYDUZmCDa@Hm@D_@?ABSb@eGDc@'
                     },
                     'start_location' : {
                        'lat' : -8.1335833,
                        'lng' : 113.2141426
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 209
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -8.1321689,
                        'lng' : 113.2178119
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Kapten Kyai Ilyas\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'ttsp@kx_rTaCU{CYcAKQA'
                     },
                     'start_location' : {
                        'lat' : -8.1340273,
                        'lng' : 113.2175003
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 127
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 40
                     },
                     'end_location' : {
                        'lat' : -8.131937599999999,
                        'lng' : 113.2166795
                     },
                     'html_instructions' : 'Ambil belokan \u003cb\u003ekiri\u003c/b\u003e ke-1 ke \u003cb\u003eJl. Kapten Kyai Ilyas\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`isp@iz_rTS`BY~B'
                     },
                     'start_location' : {
                        'lat' : -8.1321689,
                        'lng' : 113.2178119
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 120
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 23
                     },
                     'end_location' : {
                        'lat' : -8.1329552,
                        'lng' : 113.216387
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'rgsp@gs_rTv@Lx@LB?@B@@BB@B@@B@B?`AJ'
                     },
                     'start_location' : {
                        'lat' : -8.131937599999999,
                        'lng' : 113.2166795
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '169 km',
                  'value' : 169082
               },
               'duration' : {
                  'text' : '2 jam 33 menit',
                  'value' : 9184
               },
               'end_address' : 'Banyuwangi, Jawa Timur, Indonesia',
               'end_location' : {
                  'lat' : -8.2190083,
                  'lng' : 114.3690673
               },
               'start_address' : 'Lumajang, Jawa Timur, Indonesia',
               'start_location' : {
                  'lat' : -8.1329552,
                  'lng' : 113.216387
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0,1 km',
                        'value' : 120
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 19
                     },
                     'end_location' : {
                        'lat' : -8.131937599999999,
                        'lng' : 113.2166795
                     },
                     'html_instructions' : 'Ke arah \u003cb\u003eutara\u003c/b\u003e menuju \u003cb\u003eJl. Kapten Kyai Ilyas\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~msp@mq_rTaAKC?CAAAACCCAAACC?y@Mw@M'
                     },
                     'start_location' : {
                        'lat' : -8.1329552,
                        'lng' : 113.216387
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 209
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 42
                     },
                     'end_location' : {
                        'lat' : -8.1315911,
                        'lng' : 113.2148174
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Kapten Kyai Ilyas\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'rgsp@gs_rTEZCNIz@YfCCZQ~AAF'
                     },
                     'start_location' : {
                        'lat' : -8.131937599999999,
                        'lng' : 113.2166795
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,4 km',
                        'value' : 2358
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 179
                     },
                     'end_location' : {
                        'lat' : -8.1109791,
                        'lng' : 113.2198279
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Brigjend Slamet Riyadi\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'lesp@sg_rTsAQmBYYEaBWcHiAoASsRyCKCiEo@aBWE?wB]UEE?kASw@MmBYqCc@u@M[GUCg@Ic@Go@KMAwAUMCc@GkAOyDc@y@OmB[mDk@wF}@sAUi@IwB]qB[oDi@uDm@'
                     },
                     'start_location' : {
                        'lat' : -8.1315911,
                        'lng' : 113.2148174
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,0 km',
                        'value' : 953
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 48
                     },
                     'end_location' : {
                        'lat' : -8.1027057,
                        'lng' : 113.2220534
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Gatot Subroto\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rdop@}f`rToAQq@Mc@G[E_G{@mBa@mAWOCaBYgCc@SEcBYy@M}@MmC_@oAUiBa@EA]IQC{Bi@SG'
                     },
                     'start_location' : {
                        'lat' : -8.1109791,
                        'lng' : 113.2198279
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,2 km',
                        'value' : 1159
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 62
                     },
                     'end_location' : {
                        'lat' : -8.1039519,
                        'lng' : 113.2322726
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Letnan Jendral Sunandar Priyo Sudarmo/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : '|pmp@yt`rTEEEECGCIEKAIAMAG?Q@IDSDMJ]L]Vs@\\{@`AkCX{@FY@G@MBQ@m@EaDEwACs@Eo@IyBAa@?iAAOD}C@[FgBDm@De@Jy@JaAJ_AHq@NkAHy@@KBMDw@'
                     },
                     'start_location' : {
                        'lat' : -8.1027057,
                        'lng' : 113.2220534
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,0 km',
                        'value' : 2996
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 174
                     },
                     'end_location' : {
                        'lat' : -8.078507099999999,
                        'lng' : 113.2375503
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Soekarno Hatta/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'txmp@utbrTAOAGAI?AAEAAACCCACGIII_AOg@KOCICk@K}@OyAWgDm@g@IA?KA]GaEq@m@KUEo@KcAOYGYICASGa@OYK_@OOGUI]IKCQCWA[?C?U?c@@UA[Ag@GaBYgLkB{Ce@MCgIsAaF{@aEs@uBc@wA_@kAWkAUkCk@[I{Ac@yBq@]I_Bi@}E{ACAaAYg@Qi@O]I_@E]Ac@AQCsADQ?K?A?OAQCC?g@I[COAK@A?M@I@IBUJg@Ts@^y@b@{@b@i@X_@P]LWFIF[Jc@HG@G@WDSBSB'
                     },
                     'start_location' : {
                        'lat' : -8.1039519,
                        'lng' : 113.2322726
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '26,0 km',
                        'value' : 25961
                     },
                     'duration' : {
                        'text' : '23 menit',
                        'value' : 1363
                     },
                     'end_location' : {
                        'lat' : -8.148351999999999,
                        'lng' : 113.4305287
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e untuk tetap di \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'tyhp@uucrTAOAIAu@?EASCcA?{@B}@Fe@N{@@CXaA^gA^aAVu@Zu@BIDM\\}@BGp@gBTw@H]HWHg@Lo@TqAD[DY@k@Ak@E_@CUGUGOU{@e@sAa@uAQi@Qm@My@C[?O?S@]BQ@KF_@FQBIRk@n@kAb@{@Ta@FIJKX[`Au@VOj@_@^Wl@a@RMRMzAcAlD}Bf@]vA_AHGVQhJeGVQb@YfAu@|AgAnBoAnAw@BCj@e@BC~@y@b@c@b@k@d@u@n@iAf@cAP[\\s@\\}@@AXi@\\s@z@iB~@oBDInAkCz@kB~@oB\\s@f@cAZe@\\c@?An@i@lAeArAkAn@k@b@k@nAqBV_@lAsBnAqBv@kAl@_A^e@NOXU?Ax@k@`EqCnDaCd@]zCsB|CuBtFyDrBuAjCiBdCcBhBoAbAs@nA{@n@a@pA}@lDcC`BiAxI}F^Uj@a@zB_B`Aq@LMHKLOX[b@o@La@BQDW@OB[FcA@[J}@Fu@L}BXaEb@iGR}Cn@mJN{BF{@Dm@BY@k@@kAHkP?wBBuA@iAD{ABy@FkB\\yJh@iO?EXkIf@eN@k@@MFgADi@L}@@CPiANeAt@aF`BkKZwBRwAt@eFFa@Lu@NaAPgAH_@H]Lc@JYRi@Xo@b@}@Zs@^{@L_@HYJa@DUDYDc@@_@@i@?aA?kC@SBeD?oD?]@sA?g@@mA?mABk@De@BMF[RiALy@Lk@d@eCZkBR_AVsAh@{CDY^sB^yBZeBLe@Hc@\\sBBM\\qBTqAHe@BIHc@DU^eATa@FMX]^[r@g@\\O^M`@GXEp@Ef@ANAhA@jB@bA@p@?lBBlA?nBBbBBlB@lB@f@@H?z@?bB@fBBv@?r@@n@AZCTCZI^MPINGTQTSVUDGFIPYNWHUJa@DYFo@@_@By@?w@@I@qCBqDHiFDkDDiD?]B{CB{DFuD?ULaKDoDJyGDoCHuFBuAC_@?OC[Mo@CIu@wCq@qCaAyDgAkEq@kCu@}CYu@Uc@{@eA{AkA}@i@e@[qCoB}BaBaD{B}CuBeHqEMGk@]i@e@UYYc@Oa@Mg@Ik@Ec@@_@B[DU@GPa@LS^c@VSLKVWNSDGDMDQDYBk@?ADuB?W@yD@mA?s@CWCOESIQOQYYYWs@a@mAu@UQSOOMQMOMOMEGGIMSAECECGAEACAGAEAEAEAG?E?EAA?W?O@W?MBQHi@Pw@f@iBJ_@hAuEdAgEtAeGjAoEfBuHn@qCBIj@oBx@_Cb@mAN[JQPWNSTQDCNIPITGPELAVAh@@J@^?J@T?JAHCLEFIDGDODUBq@FiD@M@_@DaADc@H_@Rm@FSZw@l@}AVm@LYTq@HYH_@TkAN}@Fe@Je@@AHSTo@\\o@PUR[j@_Af@w@Vc@JMfDoFxAaCDGr@iAz@uAHMh@{@LUZm@Xm@Rm@Le@RiAHw@Ba@@S@m@?e@Ce@Iw@Iq@Q{@o@{Ce@_C?AUmAUkAMk@UgAIe@Ok@aBkGs@iCUiAACIm@Ge@Ck@CyE?WQyH?{A?MKkAG]Mc@Wi@Sa@[o@MWOYM[K]Ka@EYCU?SAg@@[Fm@b@aDZoBj@gELq@Lo@Rm@ZaAbEwKtCeIHSHWFQL]jFuNb@qAt@qBhBaFz@_CdBuErC}HdAsCHUbC}GvCcI~Pme@f@uAb@oA^cAd@oAd@kAXo@b@u@z@gA`AaAn@i@x@k@|@e@xAk@rDmArJaDpIwCjIqClBm@REVCj@Gj@ERATEb@If@OXKTKHGHGBEFI@E@E@I?EAGAIGWEMGMMYOWOWMUQ_@MU'
                     },
                     'start_location' : {
                        'lat' : -8.078507099999999,
                        'lng' : 113.2375503
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,2 km',
                        'value' : 2193
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 171
                     },
                     'end_location' : {
                        'lat' : -8.158978899999999,
                        'lng' : 113.4465111
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Tanggul-Lumajang\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'dnvp@ykisTZ[@KHIPQBCd@]XUp@i@XU~CaCb@[~AeAf@WRMHAt@g@`Aq@jAw@xAcA`BiAVSVQh@_@\\WNKJIJINOZ[Z]\\e@PYVa@T_@Xc@LUb@s@NW^q@Ra@FMHS@ABML_@La@BMHYDKFUf@iBd@iBDQ@Cx@}CPs@@ETy@FUVcA^sA@GbAyDLc@La@DOLk@l@{Bp@cC@ARu@FY@E`@{ADOp@mCV_AH[FU'
                     },
                     'start_location' : {
                        'lat' : -8.148351999999999,
                        'lng' : 113.4305287
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,3 km',
                        'value' : 1318
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 69
                     },
                     'end_location' : {
                        'lat' : -8.163392199999999,
                        'lng' : 113.4575601
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. HOS. Cokroaminoto\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rpxp@uolsTVgABQNm@\\yA^wANo@b@cBJa@BKVcALc@FUR{@Lg@n@gCF[b@cBPq@`@cBb@wAXkAh@sBBM\\sA@CV_AF]@ADUHUPa@P[Zg@NS`@o@RYFMJWP_@J_@FWNk@Le@Ps@Nc@HSBGBCBC@A@ABCFC'
                     },
                     'start_location' : {
                        'lat' : -8.158978899999999,
                        'lng' : 113.4465111
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,2 km',
                        'value' : 165
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 61
                     },
                     'end_location' : {
                        'lat' : -8.164752199999999,
                        'lng' : 113.4569733
                     },
                     'html_instructions' : 'Belok sedikit ke \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Tanggul-Manggisan\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'dlyp@wtnsTD?D?B?D@TDt@Xb@Pd@PbBn@'
                     },
                     'start_location' : {
                        'lat' : -8.163392199999999,
                        'lng' : 113.4575601
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4,8 km',
                        'value' : 4849
                     },
                     'duration' : {
                        'text' : '4 menit',
                        'value' : 264
                     },
                     'end_location' : {
                        'lat' : -8.188335600000002,
                        'lng' : 113.4919047
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Bangsalsari-Tulakan\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'ttyp@aqnsTZmAJe@Le@H]T}@d@kBJ_@f@qBTcARu@Ry@Ru@VgAl@iCFU@G?AHYLc@FYDQZmAVcARs@f@uB?CjCcKNq@Ru@Li@BK`@aB~@mDn@iCJe@\\qABOj@sBHUFQVi@b@m@f@i@h@c@n@k@VQXSHIj@c@TQTO^YLKrAcAjAy@z@q@~@s@\\Wl@c@bAy@ROTQVSNOlA_An@g@\\UXQfBmAz@i@HGXOd@Yd@Y|@g@x@YDAh@SnCaAhAc@|Ao@v@a@lAk@vAq@tAs@n@_@NKJGdAo@BC`@WROBA`@[@Ar@i@v@o@t@m@\\[VUb@e@NMHKPYt@kAJQDIjBaDtAaCZk@|BgE`CoEJSHOHSDOHULc@FWH]VoA@GDO@IBKDQXkAH[z@kDp@kCPu@Tw@Le@Rq@Pi@z@{CxAuFf@mB'
                     },
                     'start_location' : {
                        'lat' : -8.164752199999999,
                        'lng' : 113.4569733
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3,6 km',
                        'value' : 3567
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 178
                     },
                     'end_location' : {
                        'lat' : -8.199340900000001,
                        'lng' : 113.5221451
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Raya Tanggul\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bh~p@kkusTLi@dBcHz@kDLi@XgANm@\\sAZeAXaAVy@XaADMp@aC\\gA?C`@oARq@Rq@d@wAZ}@Pg@J[JWfDiIRc@Pa@`@cAl@uArCkHTi@j@wAz@sBVq@L]bAeCxAiDPg@LWDKd@eA@C^eAV{@Ja@Ni@He@BMF[T_B@IBWFe@Da@RkD@WHcABg@Dk@@M@Q@UBU@[@AFuA@IHoAD_@Hu@Jq@b@gC@E?C\\qB^uBDSFY\\_BVgALm@h@{B@GDWH[@CTaA|@mDt@{CPm@t@}CXsA'
                     },
                     'start_location' : {
                        'lat' : -8.188335600000002,
                        'lng' : 113.4919047
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '22,3 km',
                        'value' : 22271
                     },
                     'duration' : {
                        'text' : '19 menit',
                        'value' : 1142
                     },
                     'end_location' : {
                        'lat' : -8.178203399999999,
                        'lng' : 113.7044465
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Bangsal Sarri-Tanggul/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'zl`q@mh{sT@GZsA`@kB@ERy@R{@F]N{@n@wDBSBS\\mBL{@Hq@RgBFu@Fy@FoA@CNiDJyBDkADwA@]DoBFyB@E@g@?IDo@Bi@@SJoBH{BBgABw@@k@DaBBo@BcB@iA?sA@kCAcAAyD?S?mB?wB@aBAuHAuE?SGsRCeFCsCA}ACwB?EIoGIcEEwCCeB?YC{B?AA_ACsB?a@A}AAkACmFh@}MXcGFaB@GJsBLeCPiCd@oF?Kb@aGFw@@OHeA@GDk@D]V{Cv@oIV}BRoBHq@J}@p@eGLaAb@aEJ_ATuBJ{@pBaRt@sHd@wEDYj@oFBQn@qGDe@Hm@Fs@BUBM?AHs@@INwA@I@E@Q^_DFi@BSXyBZkC@I`@iDzAuLD_@\\eCd@qD@IPuBP}Ab@eEPkBHaAPcBNyAJmAD]BYPqAJo@X{ADQPy@TaAPq@~@kD^uAn@iCHWT{@Ty@No@H]Nc@@CFUJWFOHMLSn@eBFWRcADi@B[?U@_@AWEWCQCEGM?AIMEGKMKOKKo@s@{BgCqAyAqEeF?AuB_Ck@m@KK_A_AaDkDOQIOEGKQ?COc@_AyDo@cC]mAc@cBK_@q@kCEOoAaFqB_IgBwGI_@}A_Gm@cCy@eDYcAACa@_BCMQo@Om@Kc@I]AE]uAGSMi@YkASy@WeAQu@EW_@{AEUIa@I]Sy@G[CKQ{@Oi@Kg@I[EQAAKe@AGg@yBAKSaAQw@SeAIe@GYi@gC?AQy@AGKm@GWMs@Kk@Ow@c@uBKk@?Am@eCGSYoAMc@Ok@]qAsAeFYaAMa@iA}DOe@k@sBYaA]gA_@qAc@}AI[Ma@GQOk@Uy@So@CMc@{AUw@Uw@Og@GYOe@a@_AUy@a@yAuBkHe@eBMu@Qg@EQwCeK{BwH}AkFeAwDK_@EKAC]oAU{@i@mBSs@GUGUU{@eBeG_B{FK]?Cm@sBk@yBy@uCEOEOy@mCUy@{@aDOg@U}@K_@g@gBc@aBAECGQo@CIyAeFAECECIg@iBwA{Ey@uCIEM_@Ok@CG]qAKYIWw@uCs@gCGSOm@GQAGACCISm@wBsHCGoByGGQGWW}@Ss@K_@_@oAk@mBUu@M]Uo@O_@KUMUQ]g@cAQ][o@mByDO[Sc@[o@{AeDcA_Ci@oA_A{B{@oBu@iBCIo@_B[y@a@eAM[Qc@EM[w@o@gBiByEQi@c@iAq@iBkA}C{@{BGOk@yAwAuDo@cBO]oAuC{@gC[w@CKK[Su@COIe@UsAEQCI@G@Mq@uDG[CICMCOYyAKc@Mq@c@qBCIEUEOAG?Cm@qC{A{GAEEKEMSg@{@gBKSy@eB_CmFO[aA{Ba@}@GOe@}@GKGMEGACCEIKQSKOKKWWWIOKMIIIGIOYCQDcA?gADWBQ@KBGDGBABCJCJAPATAR@hENhAAv@AH?b@AF?f@Cf@A\\Ed@Gh@Kn@Qt@Ul@Ud@U\\O|@_@LGz@k@DCp@_@XQf@Yf@Y@?HEHE@?FADA@?FAJ?@?L?`B?@?T@n@?t@@F?r@@fAB@?r@Bn@BJ?P@tEBr@H'
                     },
                     'start_location' : {
                        'lat' : -8.199340900000001,
                        'lng' : 113.5221451
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,3 km',
                        'value' : 1252
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 78
                     },
                     'end_location' : {
                        'lat' : -8.1818974,
                        'lng' : 113.7150939
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Letjen DI Panjaitan\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'vh|p@y{~tTDa@AEEe@Ck@Ca@?a@D]FYBST}@J]J_@h@qBxAqFfA{Dn@wB^mANi@Vw@Le@DOf@aB@GJ[Ne@X{@FQh@iBTu@fBcGPm@Pi@\\oABE'
                     },
                     'start_location' : {
                        'lat' : -8.178203399999999,
                        'lng' : 113.7044465
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1,6 km',
                        'value' : 1643
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 82
                     },
                     'end_location' : {
                        'lat' : -8.1865156,
                        'lng' : 113.7291595
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Letjen S.Parman\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'z_}p@i~`uTl@sBNe@^mANi@Z}@Hc@b@oADMDKn@wB^kALe@FWFg@Fu@@SJgB@SJaB@OB{@HoABo@@EB_@DQNi@DKLa@d@mAFMTu@p@iBBGDMb@mADMZ{@@EHUd@wADMh@cBX}@\\qAT}@No@Lg@HWPw@FSXiALo@BSDUFe@Da@?CDo@Bw@'
                     },
                     'start_location' : {
                        'lat' : -8.1818974,
                        'lng' : 113.7150939
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,7 km',
                        'value' : 8691
                     },
                     'duration' : {
                        'text' : '7 menit',
                        'value' : 443
                     },
                     'end_location' : {
                        'lat' : -8.177059399999999,
                        'lng' : 113.7992077
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Letjen MT Haryono/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'v|}p@gvcuT@_ABkA?s@A{@EwA?MEeA?KAGGw@A]Ai@@g@@o@?K@i@@M@i@@_@?G@]@Y@[@m@?i@A_@Gy@Ca@Gs@CWCYE_@IUMc@ACUw@GUAI?EAWAe@?k@AgA?Y?_AA]?E@qD?mAB}@@}@?CDmB?SBg@FoAF_A@UBu@DmABs@Fe@?EHkA@MLwAB[N{@@KLy@Jw@Nw@@CLu@Lq@BQN{@b@_CRiAVqAJe@?A@K?K?OAI@m@@uA@{@@K?ENcBDm@Bk@@[Fw@@O@m@BgA?IN{BJcBB[Bi@F{@@U?K@IAuAG{@Ac@Aq@C}@EeACk@CWEi@AWKiAWmCOoAGg@QaBCICW?GKw@Iu@Ii@I_@Kc@EKOa@GQWo@c@{@MYMWQ[MYKUQa@CEMa@Oc@I_@AIOq@EYIc@Ii@Q_ACQCOCQGc@G]QgAKi@GUAESw@EMQo@]kAAEi@sBs@yBMc@Sy@CGYaAOq@Oi@CMUcAAKKw@GWGSMWaAkACCwAyAcBeBiBoBw@{@KKmBmBCCEEyAaBOQg@g@CCY_@?ACGKQGUCKAGAGA_@BgADg@@EBi@Be@BWBOBKHITIVEVEf@GJGFCJMDKDQ@W?_@Cc@E]AEQs@CGGM_@cAAAQ]GIO]q@{@]g@EEg@o@i@q@u@aAe@k@SWq@{@[c@W[OOSOg@_@{@_@gCgBGEy@i@qA{@c@_@]YOMOSwAiB]g@Q[MQYc@Yk@Yk@Wm@Oa@Sk@M_@I[a@qACGg@cB]iAIW[oAm@wBSu@Ok@Sm@Sq@GUK_@GUQk@Qi@[gAGUMc@IWm@_CCUC[Ag@?U?c@?kDAmDAcBASAQG]I[Ma@M[Ma@AEOu@EYCUEg@EsA?W?K?K@M?EBGDGFINKNG^K~Aa@nAYhA[d@Q`@WTSN[Pc@BGTm@\\w@j@mADKP_@Zs@N_@HMHUFMDIRe@NYFMFKPURSNMNMhAw@bCkBZ[HKDEh@s@DGd@m@RY'
                     },
                     'start_location' : {
                        'lat' : -8.1865156,
                        'lng' : 113.7291595
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '8,5 km',
                        'value' : 8451
                     },
                     'duration' : {
                        'text' : '8 menit',
                        'value' : 466
                     },
                     'end_location' : {
                        'lat' : -8.1821021,
                        'lng' : 113.8698914
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Banyuwangi\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'ra|p@alquTEk@?_@Ae@AoAE}AI{BCu@Ac@AOIgACa@KoA?CM_AAIMaAEYMs@EWEMGYCIK][iACIISK]k@mAGSk@oB_@sAUy@a@mAK]?AK[a@qA]iAs@wBCIYu@Wu@Qg@M_@Oe@K]K_@AGCI_@wBEYYsAI]YyA_@yB_@{BW_BUiBIw@E_@AW@U@WBQHWBGHWL_@DMRc@HQXo@Zm@^u@Zq@@CTg@Tg@@EBEJg@F[Lu@@ID_@D_@Fo@?G@U@G?I@I?O@_@@U?E?WBUDc@FQBIDKBEFIFGDGJINOZSNMp@e@p@e@p@e@ZWNMNOnAgA\\e@V]NUR]NWFOHSFUDQ@O@YA]As@Ac@AQAKAKCKAICIEKS_@GMCEWm@YaASo@CE_@yA?AOk@EMCIEKEIGIGKACEIKMEGIKQUOUKQGKEIEIAECGCQESEWCSCQAKAKCm@AQAWAOCW?CCYEUAGEUEMCKGKYk@MWO[MWYa@CIc@aAQe@GQCKAQ?IAK@K?CLw@DQHe@FYDS@CFQDMFMFKDKFIHKPSVWRUNOPQROl@m@RYd@i@T[n@i@NSLU@AHO\\q@\\u@N[JYJ[HUBI@EFWDWBSFo@HeAFu@@M@M@OD]H_ALkA@MH{@HeADo@BUJeADW@M@CBIBIBIDIBGJQHKLQj@i@\\Yv@i@t@g@^UPMBCLKJMNSNY\\u@Pa@HUJ]FWDYBYB[BkADiAFyB@eAAcA?g@?K?MBU@G@MFULo@T}@J_@Ni@j@qBRu@H[HWN[P[DIPUn@aAHMd@s@Xe@BGHMDIHSDMBIBKDc@D]@O@SA[AYEWCQCOGOMUMYIUISCKAK?Q?M@s@@]DmA?G@c@?C?O?SC]CSE_@?GUoCIcACc@MuAEYCUE]O{@CMOw@Ms@Y}BEg@C]A_@A_@Ak@@_A?I?W?i@?u@?IAcBAuC?M@qAAaA?s@?C?o@Ak@Ea@C[EYGg@QwAMcAIo@CUS{@Ma@CMOYGa@IgAAGCm@Ca@EkAA]?_@AC@]?c@AQDs@Fu@Do@?CBU@W@Q@EBUF]BGX_AFQLWp@}AFIDMN[N]Vo@Zq@BETi@z@kBJUVo@LYL]DKPi@To@J['
                     },
                     'start_location' : {
                        'lat' : -8.177059399999999,
                        'lng' : 113.7992077
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0,6 km',
                        'value' : 606
                     },
                     'duration' : {
                        'text' : '1 menit',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -8.185492199999999,
                        'lng' : 113.8741346
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Jendral Ahmad Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ba}p@ye_vTFOXk@DIx@{AV]Zc@Z]RUbBgBFGdBkBt@u@@AFELM@AHIFG`@_@HIDCJKTUPSBE@AJQRi@^sA'
                     },
                     'start_location' : {
                        'lat' : -8.1821021,
                        'lng' : 113.8698914
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '21,2 km',
                        'value' : 21158
                     },
                     'duration' : {
                        'text' : '18 menit',
                        'value' : 1101
                     },
                     'end_location' : {
                        'lat' : -8.2762213,
                        'lng' : 113.9680765
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Banyuwangi/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'hv}p@i``vTFYJ_@FWDST_ABIBMH]Rw@DQ@?R{@Pq@Lg@FYR}@@EXsADKHc@DQJa@Ha@XgAVcALg@Ha@Ja@DQBKNo@VkALi@f@sBr@gCd@oB\\qAZkARy@FOHYN_@LWNSX_@^c@DGLOZ[jDaEHKJMTUVO`@ONCNEJCt@MHC|@QnAWXE@At@ONCJGDCPIPSHQLc@@ADOPq@DMPq@FYH]d@_BJc@Rs@@EPq@DMf@aBFSZ{@HQDIBEJOb@g@@AJQJUHY@OBa@@g@@c@@g@@g@B}@?C@QBODWFOJUJOHIPONIFELGPEd@Kh@CP?\\@Z@h@@NATGx@YbAi@tAw@LOJKJMHMZi@`@q@JQLKJGHEJCFAH?D?JBLFHFNRBFT`@bApBz@dBpAjCXh@Rd@`@t@b@p@PTRLVJVBHBz@FvEJx@BB?~@Bp@Br@BH?bADt@BxBFvDNd@@l@@Z@xAFpAFzAFp@BD?l@@f@A^CZG@?TK\\Q@Aj@c@ZWXUTS^Y?AZUd@]PKFEHERIREZC`@Ab@@~@@~@@J@B?^@H?ZBt@FJ?j@Dp@HrAJH@j@Fj@DZBd@DVBD?~@JH?RBP@J@XDN@H?J@b@B~@BL@J?D@^?L?@?J?HAPAPCPELC@?LETMNKROd@_@RQDCDEFEPOd@e@`@g@FIHINKHGn@]DCh@]\\SLG@ADCDCXYr@o@HGTSj@k@d@c@PK?AHEBCJENGZMz@UZIPERCz@Sd@ODA`@MTK@?TIz@_@\\Mp@YdB}@b@Yh@_@|@k@n@a@LIj@_@DELIHEJGHCLGRGFCFCJCLEHCHC@?HCFEFAHENIZYTWd@_@h@m@d@e@FEZ]`@_@n@m@j@k@LMb@c@DCFGDEFGHOFKL_@Lc@J[@ELo@Je@BKTu@Ry@Pw@Pw@DUT_AH[Jg@Ja@@GRu@Jg@@ELe@DQDOBKl@kC@ETy@Je@BO\\{ABGLi@TaAH[Jc@ZiADU@Cd@wB`@eB^aBH[^_Bd@eBh@_CViAT}@Li@Lo@J[DMBGBGHGJIFCJENCPCLCf@CjAG^ETC\\GTGRKp@c@jAaAvB}AhAaAzAiAn@i@jBsAz@u@hA{@dAy@@AXQdAy@DEjEiDjByAjAcAt@w@r@s@xA}AJKDIHOHOHWDMFQFONOVWXUpBmAr@a@f@YDCd@a@zAqA`@_@d@]TSTO\\Gx@M`BUtDk@zEcAvBk@nDcA`@Gf@Iv@S`@WjA{@\\QPKHIz@aAd@a@NYH[BY@SC[I]MW[{@w@iBk@uBWeASoAEa@?M?G@GDI@EDCBCBAH?D?HBPHJJTXXl@f@bAl@`BJh@Nb@JPLPRTVLTHf@PVP\\Vp@x@xB~Cj@r@v@p@|@r@RDLANEHAHGFIBMAKGK[Se@S]U]UWi@]}@Kc@Gy@Gw@Ao@Ee@GWI]WaAAM?K?MBIDGDEJGLCNE`@CpAKTCNCTITKd@Wd@[^a@Z_@\\i@Re@Rg@La@@G@ICMCOWm@U]MUAQAQBMDWHWj@oAT]RUVMTIPAZBxAb@DBF@D?B?D?NEVETGHAF?D?D@D@D@FDDDBDFR@FBFHLDFFDFBJDJ@D?F?FABCFEDGDIf@mAHUFMFGFCFAF?F@FDLHLPP\\Zp@X\\XV^Nb@Jb@HVC^MRONSBW?UKYOU[UWOUSACCCCECGAC?CAE@C?A@CBCBABA@C?C@IFyAZmABk@Co@Km@yAwJ@YNe@Za@VQb@GjBIT?zCHl@Ev@MJ@`BDF?l@CbAOjAc@l@k@RWX{@Pg@TW\\OXGZOf@Qf@c@P[La@Jq@DU?GB[Hs@HOLKFARALDLHNNNXZ~@Vv@ZZHDLDLDR@b@G`@UhAeBvAmBbAoA`@Wf@If@AZDRJjAbBNPJDL@TAVAt@Ut@O^Ef@DRJLTPd@H`@AN?D?B@@?@@?F?DABCDAD?@?JBRHRJHHFH@F?N@L@LDRHJHDNDH?F@b@PJFHBJB\\?DIDIFQBWDODO\\k@`@m@b@k@TWJMJEHAR?V@j@N^Nh@\\jA~@LLNJTHT?VEPOLQJWHYB[D[@U@YBUBOFGFAF?T@|Al@hCtBVJTLNDN@PCJMFSB[B]@c@TeDJe@DWHYH[BYDWHOTORAXHPLNRN\\T`@RRZLVBPARER@PBNTHj@Jh@Nh@J\\HPPPJ@RCXMPIZO^QTQLWJKPGTANEDC@A@CBG?G?EAEECGCM?E?A?C@CB_@ROBM@S@W?K?ICGECI?E?SAUG[ISGMc@i@iAeAUSSWKUIWEMGUYCy@IUCq@CSEQK[[_As@OOUIYEa@Aa@?]AUCYEQIg@OIGEGAEACAIAa@?gCCg@AQESa@{AKc@Mw@a@kFGwAG{AHy@?S@MAQAQIOQMUI]Kc@Io@MOGKIKKIKMSKSM[CU@SB[P]\\u@Nk@ZeABYBc@?Q?]Iq@Ow@Um@K]GYIo@Ei@Gs@Ek@Aq@?o@@m@LqDFo@De@D]Bg@Da@Dq@CQEiAKgDCqA@c@@SBUHm@Pw@l@eBb@iA`AiCVe@nA_CDIJ]H[H]BY?g@@w@GmA?EEmABc@Bg@Fa@Ry@pAgD|@cBd@}@Xq@Pm@Rs@Fa@h@wFdAgKRwG'
                     },
                     'start_location' : {
                        'lat' : -8.185492199999999,
                        'lng' : 113.8741346
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '9,6 km',
                        'value' : 9550
                     },
                     'duration' : {
                        'text' : '10 menit',
                        'value' : 587
                     },
                     'end_location' : {
                        'lat' : -8.3064798,
                        'lng' : 114.0388444
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekanan\u003c/b\u003e menuju \u003cb\u003eJl. Raya Kalibaru\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jmoq@okrvTrCwAp@k@|@cAzAoAnGkFjEkDzEuE|MwMvJ{In@k@fJgJb@i@FIJQj@mA\\s@Pq@Li@Ny@Fm@Bq@BkCJmDF_AJw@Fk@Dc@DyB?K@mF@W@_@DeBBy@HwC@Q@a@@K@I@E@CJEnAi@vCUB?xDc@lD_@b@EbCMV?jC@n@@B?J?PA\\IbD_Bj@SVKp@IxCUlHi@dASRGB?BCBCBGBQ@cB\\_LRcK^qTJoH@_@DwAHqIBgFPwG@YDwB?uAAgBCiBG_AOq@K]O_@IQCICQCQASAO?M?M?K?I@E@IBORaAj@{BJg@Jk@DYJi@PcAJu@He@DUBYFe@Bg@?iACkD?aA?O?M?iAAg@@cA@q@@cABcAF}B?EB}@FyB@mAFyBB}ADmABY?ADUDQTy@b@cAj@{Ad@kAZs@^{@^_AVm@Na@He@@SAKAG@EGUEKGIGIMKMGMEUIICKC[IWIIEGEGGGGEKCCCEAGCI?GAOBy@@k@DkA@{ABsAB}A?C@kAB{ADoB@{@Bo@?KBmA?c@@[Bu@?U@QBIBIDKFQDIRe@LYRa@N]x@aBBGj@oADK`@{@HOz@oBl@sAh@gAp@wAj@sA|@oB@CLY`EyIbCaFh@kAv@aBz@iBZy@Na@FMFSLc@R{@'
                     },
                     'start_location' : {
                        'lat' : -8.2762213,
                        'lng' : 113.9680765
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '32,9 km',
                        'value' : 32926
                     },
                     'duration' : {
                        'text' : '28 menit',
                        'value' : 1655
                     },
                     'end_location' : {
                        'lat' : -8.3098084,
                        'lng' : 114.2662322
                     },
                     'html_instructions' : 'Terus ke \u003cb\u003eJl. Jember-Banyuwangi/Jl. Jember Kalibaru-Banyuwangi/Jl. Raya Jember\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Jember Kalibaru-Banyuwangi\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'njuq@we`wT@IXaA@EDKBGFIDIFIJMRU?ARWNULUJWRe@lAkCj@qAb@aALWXm@Xm@Zw@^u@DGjAoCp@wA|@oBp@yAp@yADILUHMp@aALST]T_@Za@HOHQ@IBG@K@KF_@BMBM@E@EBELSNWRa@BCZm@Te@x@_Bf@gADMFMP_@@G|@iB`AuBn@sAVi@`AsBN[`@y@dA{BLWdBmDr@{AbAoBl@qAFM@CL[FS@K?I@M@K?W@[@G@KBEDKFMDIb@k@X[`@a@FIFKPY@?FMj@gAHMn@mAP[vAoCRc@DI@EBG@G@g@?wAAqJBmD?KBqCAaGByCDwEDqEB}AH_BBe@@GBK@INYVe@t@kAzA}B`@m@v@gBVm@|AoDLYf@oAZ}@fAaDf@gBzAwEBIfAwDFQJSJ[NUb@q@f@s@~@sAr@gAxAuBHMJS@AN[L]Vs@n@wC|@iE^{AZ{@v@kAZe@pAmA\\]JMNSJUN[H]Lk@f@eCRgAH]FSJSNQ|BeCNQJQHQJYdAyENq@Tu@`@{ArBsFZ}@`@kAHc@Hg@LiA@y@BoBDsCBoG?sAA_@EsC?ACm@AQCOACCKCGS][i@EMAGKu@OcAIg@I[ACg@mAe@eAOe@_A}Bw@qB_@kAc@eAmA_DEMQg@]eA?EQq@G]ESGe@C[@YB_@Hc@D]\\yB^oBToAZwAd@sBNk@Rs@FY@IFWBg@?C@u@Iw@Kw@QuAES?CCSAMAQ?M@KDIDMHMTU^U`@QBCnCsABAv@a@h@[^Sl@_@z@g@f@[~AcA@AvBmAbAa@t@[n@WhAi@dAu@h@m@Xa@Za@`@YzA{@|@i@bBeAf@[rA{@XSb@YXSTO~@m@rAu@XQxBoA`@STKxDeC^QXQbAc@fRgLfCyAf@YpDsB|BoAXQt@e@DCjBiAVOPMXQf@[nEmCr@c@dBgA~CcBlBaAvCeBj@[d@Yv@e@tBmAPK`CwA@A`C{APKLK|@i@hBkAPO^]z@u@Z[r@q@f@c@RQjByAz@q@ROn@c@x@k@ZUPMBAv@i@@C\\UTOHGLI\\WNKj@_@@A`@Y\\[dAcAf@k@h@o@\\g@RSbAkAxAcC\\i@f@w@BGNS@ANYFOBGBGXy@DMbBoEv@sBt@mB?ADENSJMLKLIp@_@LIx@a@PKJIZW?AZ[@Ah@s@r@cAJONWnAsBDG\\m@Tc@HQz@_B^q@LUd@y@@CLWFMFOPc@Pg@La@Ja@FYD_@Ho@TsBRg@BM@E@E?C?E?CAEWa@Uc@MSOWYa@W]OUAAAAyA}BS[EIeAgBGMEOCOE]Gk@E]CUEg@Ek@CO?IEU?EMgAKgAUsBEU?GGc@g@wD[aCQsAE]OcACUAK?u@?o@?c@@g@Cc@?KAICQIk@CUC[?AAU@UDm@H_@ZeAVy@Xy@Ti@Pe@J_@Pq@Je@@GFg@Dw@@UB_@?e@Dq@?UB]D}@@W@SB[D[D]F_@F[Jk@F_@VgANs@BSFYHk@Fa@B_@?S?UIaAQmBMwACOGk@?ACWAU?W?q@@_@Bo@By@Bc@Di@F_@DWFQHQHSJYJUPYR]R_@Tc@Pc@Ne@HYFULc@BMV{@HUJYTy@J_@Le@Pg@Je@H_@Lq@He@D_@@CB[@K?EBS@WBQBWBMHKFOFOHMJOJOT[d@o@VY~AcBJQJOBEDI@EBEBIBGFSPs@ZwAXkAd@gB^cBFUPw@\\qBR}AJaABS@K@MBY@MBWB_@@]@_@@aA?S?k@?iA?c@AwAEyCAiAEkH?G?E?CAC?C?CAE?CCKYwASgAi@cCiA}Fs@{DI_@?COm@Mq@CKCQEYAS?C?C?A@]@i@@O?M?A?QAg@?[AYAQ?GAGAIAIAKAIKe@UgAEOE_@m@wBOc@Oc@Uk@EKa@}@eAyBCGs@sAWi@Ue@Wi@Ui@[w@]w@ISKYIYg@{AO]Um@[w@Oa@{@kCe@cBAAG_@G[G_@IeAG{@SaCSqBEu@AY?Y@_@@QF_AHeABSBMBKDKFQHMLQz@}@FIhB}BV[P]HU@?DQ@M@U?S?SAKAMCGYo@?AgBuDQ_@IWGYEWAY?eA@}@Fg@L}@Lk@H]HUDMJOHKf@g@dAaA|@u@`A_A^[~AsAVU`A{@LM~@w@jAeADEdAaAX[HKNWP]?ALU^y@d@uAFW@O@A?U?UGkBCcB@iDGw@Gu@O_AIg@EMGQCKAKSiEIqDCcACSGOKKMKqC{AaC}Ae@]EEi@e@iAqACEACCGEGAG?EAQCqACcA?GAcFAa@KkGA{@EcCK}FKgFE{FGaCMqB_@}EAMK_BGmAMsBKuAImAGiA?AKmAKaBASAQQqCIiBEe@G[K_@KU[i@Y_@o@o@eA}@oCuB_CsBUSkAgAoBsAk@_@_C_Bq@[_Bo@c@OWG[Cu@Cc@C{@Eu@CgAEi@Ae@Gq@My@QoA]s@Qw@OUGyAYoAa@qAm@OGgAk@CAoAi@]KaAa@a@Qk@W}@c@c@WGEIK_@YQOEEGG]e@SYo@o@QQMIKEYMcA]{CgAeEg@oCa@_@OOKEGAEEQK}@Gq@e@}BGk@Ia@I[CIIIIEKA]AW@]@o@Di@BI?S?[?UAQAUIUKYMSKYK]MkAQq@AgAAeAKkIkBsEiAo@Oq@Wa@Sk@g@i@_@mBkBGGUQc@SCA_@Mk@Ik@Ey@Mo@UkAk@QIw@k@kCmBeCkBaC}A}BaB}DwCgE_D]Uk@UsMsDi@Qu@Uy@S]IWESCM?K?I?WFi@Pk@Vq@b@w@h@oAr@KFo@d@UDc@Fe@B}@Bc@FwCh@eB\\iGhAW@S?[CQEWGm@WkBw@eBu@_@QqB_AkAi@cF}BcF_Cy@e@UQQOKQIUoJwVe@sAi@yAY{@Us@Ki@Ec@?e@Ao@?oAXsP@qAEKGQEKIMAAMKwBwAaAo@_@Q}@c@KEwDeByGsCaEiByCsA'
                     },
                     'start_location' : {
                        'lat' : -8.3064798,
                        'lng' : 114.0388444
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2,7 km',
                        'value' : 2668
                     },
                     'duration' : {
                        'text' : '3 menit',
                        'value' : 186
                     },
                     'end_location' : {
                        'lat' : -8.3133409,
                        'lng' : 114.2895572
                     },
                     'html_instructions' : 'Terus \u003cb\u003ekanan\u003c/b\u003e untuk melanjutkan di \u003cb\u003eJl. Banyuwangi/Jl. Genteng/Jl. Jember Kalibaru-Banyuwangi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Banyuwangi/Jl. Jember Kalibaru-Banyuwangi\u003c/div\u003e',
                     'maneuver' : 'keep-right',
                     'polyline' : {
                        'points' : 'h_vq@}rlxTM[CW@[Rq@f@kBH]^wANm@ZoA\\kAFWBM@KCKAEAGGGe@WIKEGKQaA_DGQ_@}@CQ?K@MDW~@aElBuHh@yBx@gDf@kDf@oDX}BFi@f@uGVgEJaBD}@BaB@_A@cBBm@NqBp@}GBSb@uDd@qEHw@\\}DXyBP}A@QBc@?eA'
                     },
                     'start_location' : {
                        'lat' : -8.3098084,
                        'lng' : 114.2662322
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '14,0 km',
                        'value' : 14018
                     },
                     'duration' : {
                        'text' : '13 menit',
                        'value' : 783
                     },
                     'end_location' : {
                        'lat' : -8.2190083,
                        'lng' : 114.3690673
                     },
                     'html_instructions' : 'Belok \u003cb\u003ekiri\u003c/b\u003e menuju \u003cb\u003eJl. Jember Kalibaru-Banyuwangi/Jl. Raya Rogojampi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eLanjutkan untuk mengikuti Jl. Jember Kalibaru-Banyuwangi\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eTujuan ada di sebelah kanan.\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'juvq@wdqxTcAo@iCcBqBwAa@Yk@_@aBoAmAu@QOo@c@uEkDo@a@q@g@YS}@m@eHuEgCcBiAs@UQi@]]UUOy@k@}DuCgAaAyEkDa@e@_@u@yEaJ}AkC{EgIe@aA_@o@k@eAgB}CgB_DyAkCaCsE_@s@m@_AiAgBmAwBa@s@y@_BmBuDMQOQCCKEGEoBy@cBm@s@Y_Aa@YOm@YuAm@c@SwHaDSKOIsBgAuDaBaGcCECiBw@}B_AgAe@a@QgF}BoAi@_@OQEa@MYGa@C{AK[?SA{@BwABK?O?Y?MAE?ICOCQGMEg@Y_Ac@q@]yAa@GAs@QyA]A?k@QeCs@wFyAs@S_Cs@oFqAyFeBq@QoCw@k@[[OIGoCcCYWm@k@kAmAQOm@i@iCcCm@k@m@q@{@eAMQ{B}CeB{BQSc@k@_CsCgBaCeFiGkEgFaAkACCq@aAW[e@m@W]Ya@OUOUS]SMMWYe@KUO[AEKUK[Uq@AGWaA_@wAG[?OkA{DI_@EQU}@Y{@i@aAa@o@e@m@QSo@q@EGu@y@_A}@o@o@eA{@a@W{@g@AAOIg@[MIk@_@w@i@aAq@GEUSa@a@q@q@o@s@KMMKaAeAWWi@i@KIy@aAm@o@QQ{A{AKM{@}@OQcAkAs@{@eAoAcAiAa@i@OQc@k@CCcAkAuBgC_AgAKMg@o@]a@e@i@o@s@OQcAmA[]o@q@iAkAWYaAcAaAiAs@w@e@e@w@w@CCg@i@AAeBcBw@u@QQ_A{@i@e@YYA?UWg@e@USg@g@g@e@w@w@WUq@m@c@_@OIMKcA_AaAaASQaAw@[WmAcAy@s@i@g@wAiAeA_AOKyAgAOMuA_AWQsBuAEC_BgAaCaBq@c@sA{@qA}@g@a@gBiAYSMMOAwCmBeBeAaAs@UQIG_@[UQm@k@KKiAkAWW{B}BMKoBcBII[[MO{@y@gAcAMMq@o@SOUU}@y@EEsAqAWUSQ_@WcFqCYM{@e@CAkB_AKGAAeB}@KIm@UKOECk@QEA}@WQEeA[{GsBsC}@{@Wa@KiA]i@Oy@W_IaC]K}@WuCu@'
                     },
                     'start_location' : {
                        'lat' : -8.3133409,
                        'lng' : 114.2895572
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            }
         ],
         'overview_polyline' : {
            'points' : 'rs{d@ahckSl@z~AhiBqP`lBasAfAmcH~qAczHib@q`DhkF}eWl}HonRdiAczCyRaeIjeAirMxlFeiKrkJwhDtkEe{@|yChu@|bF`{@xnDqo@jeHxfA~pHkhBhmTmMhkDcoEnjF{{DllF{eB`~@uaCy[slGn_CenCf]mS|iDfVfhAtH`m@ucDzAitMqiCinG~|@qzAtnAc|G|jCycFlxCucDdxC_nFnV_zIzS{xC~y@mwCiD{oDt`@ugBx}AwuDf}FieCp|@afErpF_i@pvDajEfmEqkBv|GfSjvD}oFrrAc`JncDawW~z@ylGqMuyFvgC}rGasCctE}dAu`@}]wuGhwAofOkqCkrCk}Bss@iEukBx{@kbEfvGksGrqEeoFpwHuoJj{Fk~H|yBooBnuB_qFtnCuhQ{KsbFfzA}qApzFoiLpeCm`Sm_@wnNaOacDxUknDzJebI|_Gy|GvkFkfGhx@{yEiuAcbBz|@e|A||CmbGfD}wNrSudYz~@axDh~BovBfcFrD`{BcwAnzGitAvwDghD~VuuIvFyfBsgCk`BaEe`HvRioBuaBsf@s{DudAobAa`D{w@gpGqXgwQjbFy~Ob`AqA|uBgoFb|@_sCndMmvGvoFo}GdjB{yOvdDm`Kl`GurHdgC}nPnq@erH~vD{eFl~CebErwBqdF`gBq_@u|@ebDfz@ct@moCcw@cvE{dBioAi}D{rC{mEacBwfHo_BunCm_@maEbe@icBqwAq}A}gDs|DtT_t@jFgz@bd@khAmqAwdCwnC{i@geDmk@}cB{|C|Hq|EzH_lEljAgeIhuAn@pgC`hA|rAeuAhlAsTyeAiqHjzDwwIvRapCf{DmZzfEejOwuCgaFidFc_EvzCayQfdEglRxh@qoIvfBowE_|DsyBdt@ejCt{@_vHsKklGxqBgzIyeA{~HxOgsEvcCerBxBggJmkDkyK`qBgs@jr@weCzcCyzG~LkvHzrBofEtzBk`Gb`AgxCxParCxTcjGpN_cCew@{zAhLwtB~B_gBgwBkbCpPgeFemF}wG|pAouFt}AobDvr@o_CxrAapDgqBiiEqlM}lGkzIwaC|iDovEfvAueItj@cbCgq@aqApr@ewEx~FiaMrnC{kEf`AsfHtt@cmJ_zBycHgqBukGxw@srB[mgJui@mhHvjC}pMxlEanAlsDkoCn{Bs{@yM{dDjaCkxCjSu~Cvv@{nDj}Ag_Fpw@_nEneE}eD`ToeHrCgoD{gCetDwaF}cDyi@ejDqlCyxBieEo|Da}DukC'
         },
         'summary' : 'Jl. Nasional 3',
         'warnings' : [],
         'waypoint_order' : [ 0, 1, 2, 3, 4, 5 ]
      }
   ],
   'status' : 'OK'
}";

        #endregion

        #region Jalur Tengah

        public static string JalurTengah = @"{
   'routes' : [
      {
         'bounds' : {
            'northeast' : {
               'lat' : -5.9314301,
               'lng' : 114.400198
            },
            'southwest' : {
               'lat' : -7.6064852,
               'lng' : 106.8315339
            }
         },
         'copyrights' : 'Map data ©2014 Google',
         'legs' : [
            {
               'distance' : {
                  'text' : '123 km',
                  'value' : 123055
               },
               'duration' : {
                  'text' : '2 hours 10 mins',
                  'value' : 7783
               },
               'end_address' : 'Bandung, West Java, Indonesia',
               'end_location' : {
                  'lat' : -6.915076,
                  'lng' : 107.6082096
               },
               'start_address' : 'Jalan Jenderal Sudirman, Babakan Madang, Bogor 16810, Indonesia',
               'start_location' : {
                  'lat' : -5.9314301,
                  'lng' : 105.9973755
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 95
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 11
                     },
                     'end_location' : {
                        'lat' : -6.5665022,
                        'lng' : 106.846684
                     },
                     'html_instructions' : 'Head \u003cb\u003esouth\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'loag@}rckSD?@AB?B@B@B@B??@@@DB@HBH?F@HAF?@?HAHCHAB?@ABABA@ABABEDA@A@ABA@A@A@'
                     },
                     'start_location' : {
                        'lat' : -5.9314301,
                        'lng' : 105.9973755
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 295
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 28
                     },
                     'end_location' : {
                        'lat' : -6.565572299999999,
                        'lng' : 106.8441794
                     },
                     'html_instructions' : 'Exit the roundabout',
                     'polyline' : {
                        'points' : 'roag@wnckSMd@GNy@pC?@Sn@_@~Aq@lCCJ'
                     },
                     'start_location' : {
                        'lat' : -6.5665022,
                        'lng' : 106.846684
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '10.4 km',
                        'value' : 10358
                     },
                     'duration' : {
                        'text' : '9 mins',
                        'value' : 514
                     },
                     'end_location' : {
                        'lat' : -6.6437198,
                        'lng' : 106.8475774
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e to merge onto \u003cb\u003eJl. Labuan - Cianjur/Jl. Tol Jagorawi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eToll road\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'xiag@c_ckSWK_AQYGc@IsMcDOC_AMc@CI?G@G@OFIDGFGHKPCJAFAF?B?J@HBRFJDJFFNJLH`@PVTvA^bMvCz@RD@ZFl@L\\J|EjAXHTDD@xUxFbIlBH@B@D@~h@hM^HLDD@D@~A^LB?@LBvc@nK~WdG^H`@JhH~Az@\\jJvBfAVdDz@bCj@`AT\\HFBd@J~@RLB@?dB`@tBb@`BXxATbALxAPpAJtAJlBJhAB~AHjC@l@AlAG`LQL?fFCT?vGEdLMpCEpBElCMvAK~CW`BSvB]bCc@hCo@tHwB`EiAZKHCNE`Bg@@?FCzUcHxJuC^IdMyDhLiDbPkHdAg@`By@|GmDNK@?LKr@g@f@[TM`@WxAaABCbBgAdBkA`BiAbBiAbBiA~AgArA}@j@a@h@]tA_ApA}@rA}@hAw@jAw@vA}@fAk@l@[n@[JEb@S`Bo@n@UHE'
                     },
                     'start_location' : {
                        'lat' : -6.565572299999999,
                        'lng' : 106.8441794
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '48.4 km',
                        'value' : 48406
                     },
                     'duration' : {
                        'text' : '44 mins',
                        'value' : 2642
                     },
                     'end_location' : {
                        'lat' : -6.8145937,
                        'lng' : 107.1318005
                     },
                     'html_instructions' : 'Exit onto \u003cb\u003eJl. Labuan - Cianjur\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003ePartial toll road\u003c/div\u003e',
                     'maneuver' : 'ramp-left',
                     'polyline' : {
                        'points' : 'frpg@ktckSBCBCBCDCDCNGXK|@]DAZKv@U|@Wv@QnBa@nBYtAU^ETGz@WHELG^SHEHIj@]h@s@j@w@BEBCHM@CJMPUPWNSJM@CFINULSR_@NYXo@DGN]^u@Xm@LUBGP[T_@HQLOPUT[RWNQDGRU@A@E@?JWBIXWZYb@[`@Y\\Ub@Yh@Wj@YfAo@bAe@hAm@`@U`@Wh@a@RU\\]TU`@g@Xc@JOLURa@P_@Na@H[JY?A@M?A@A@ILo@Hg@De@Fw@@q@@m@?_@Ai@Cw@Cc@Ca@CYE_@AS?a@EY]iBEWSoAKq@Ik@Ga@GWKk@AGE[GYE]C[EWCYCc@AWCUCSCWEUGUKYKYMWKUIMEIACMWEMGK]s@Yy@Mo@EYC_@Ae@Is@Cc@A}@FcA@W?WCg@i@gACEg@k@u@u@MOU]EICEI[Eg@?Q@OLcAj@wDX_BDKDIHQPUZe@PWNUHQBMHa@BUL{@d@iCh@sB\\aAFQBI@IBM?M?IAI?GCICMaAiFRu@v@_D@E?C?A@C?C?EWsA]sAIWIQIQYWMMGEIEGEGCQGq@YUe@CMCIIg@M_AWsAESMk@m@kFm@cFGe@O{ASkA{AaKAUAS@U@UFe@@CDYFYHa@HQHQDQDS@K?M?YAYCYG_@I]Ka@G_@My@WsAiAmK[uCEk@WkCC_@IaAAIMoA?KIcACm@O{CEgAO_D?WAGOoE?GAGCu@Ak@AYGiAC_AEuDKaCGaA?IAWGqBGsA?OCa@?Y?[?E@k@@WBUz@wCDORs@FYf@_BdAoDL_@J_@XcANi@l@yBBKnAsEtBsH\\w@BCDCDCDAJARAl@EjA?FA`@?d@CZGPE\\MHC\\ORKDCVO`@Yl@e@p@e@RMz@m@xDaC~@m@rAy@BC~@cA^a@R[FIBEJOb@o@@?DIPWb@i@FK@ADGvBwCFIBCt@cARYV_@^e@f@_AHOdBaCJO@AtAgBV]Va@R]NWLQZc@@A@ABGRWrAoB?A|@kAT[@?HK@CNQVc@h@u@?Af@q@^c@~@iADEbBcBVWPMx@q@JIPQt@s@JKhAmAbAiABCrAyAPWHIv@aAtA}AdAmA|@cA?AHIr@{@^c@PQXY@ALKRM@ANGZMd@O~Ag@DCx@WBAj@SXIXI~@WjCw@nA_@pBk@xBo@x@WbA[j@QPEr@UjDeAx@WxAa@f@O|Ae@ZKpBk@lBk@l@STIn@U`@QPOVWRUJQLUFSBK@MHk@@GHm@@SFa@F_@BMDK@ANUJKT[PQnAcA`@]FEjB{AVUv@q@`EuCBChA}@RQrCaCLKp@i@\\Uh@[\\QrAq@|Au@hAi@`@Qx@_@XKLIJK@ANOFKJODKFSJYH_@BQH[Fc@Jq@BQJ{@@EFs@@ONgC@SAQ?ACe@CUKaACa@Ek@Gq@C[Eo@C_@I_AAAGaAG}@Gm@Ca@CYCMCQGSIUm@{A_@aAOa@Ue@k@aAmCeEIO]o@SYaBkCCCYg@CEIMKSCEa@q@_@o@MUIMGKGQGQESC[AK?KCU?]Ba@@KDYJm@Jg@@?`@mBXqADQR_AH]Nu@DQNs@\\}AFUNs@H]VeAz@oDLe@Ja@HUL[LUZi@DEl@_Al@aAb@q@Ta@f@y@Zg@RWDEl@k@BEHIRYR[v@mAHQ`DaGDOl@_APUDEFGDEJIPKf@St@]dAe@fGkCVKrCmAHC|@a@p@Y\\ODALGNIFCb@UVOPOROLOPSRSNUHOFOFMBKH]DS?CJm@PqABKL}@J{@Fs@@I@Q?S@MAU?WAI?EAMCSCOCOAGIUOa@Sq@GWAEAG?G?E?YBw@@]Ds@DWFc@Hc@Ja@HQP[BEDEDCDAFEDCDADCz@QVE~@OLElAUv@Ov@O\\GlAUdASbB[x@OTENCf@ILCJCJCJCJELERIPGDAp@YLGJGLINOLQPW@CHOFQL[`@gAFOBEJ[FKDGBEDEHIVMNINEXKFADAF?F?H?r@Nn@NzA^XHF@FBH@b@JHBF@@?H@H?P?TAXEVAHAFAD?JMDKBEDEBKBKDQBMBMDGDGFGHGJILIFEDEBEBE?E@EAE?GAEACCECGEEEEECEAGAIAGAG?GCGCGCGIIKIQMUGKGIKOEGGGEGCIAE?E?E@IF]Ji@BS@K@G?I@KAIAIAIESEKAKAI?K?K@M@MBMLo@BMFOJQDIFGf@o@pBsCf@cAJi@Lg@\\}CFu@BOFKDKLKHGTQPK|@]pA_@LGXMNQFK@M?QAMIQMSUWSOQIOAU?UDUD]HWDQ?KAKEIKGMEMCY?m@?}@@Q@MVoATgA?SAKEKIOQOOKQEWEOAA?O?E?C?C?C@G@GBE@a@\\EFuB|B}AtB_@d@EBMJIFC@E?C?IAEAAACAACCCAGEKCOCSEc@E[EOGQCEEEGGIIMIIEGCKCEAGAG?E?E?E@E?E@EBOJEBQHYLGDID[Lg@PMFKBIBI?K?GCIEGEEGCGCEAI?O?O?M?QASAME_@E]E]EYCWAUEc@AYCU@EAG?q@?U@O@KDQNi@J]LYDOBKBI?I@K?KAKAIEGEKEGMOOOSQIGKEGCKAI?K?KBK@YJKBI?I?G?EAECECACEGCGAE?G?E@E@GBEDKHMr@{@RSJIJEHEVIREJCJAF?F?H?H@D??@H@fBd@HBHBF?H@HAFAFCDCBE@CBE?C@E?C?CAEAGAIEIEKIKOOKGIGKEA?SIMEKCQAK?U?q@?a@?}@@W?M@G@C?YFSDM@I?ICECECCGGOAGGUGWAGCEACEECGEEGGGCGCGCGAG?GA}@CQAICEAEACCGGCECC?CAE?A@G?I@I@IDMFODMJSJMHIHGFCHETGFCx@U|@Ud@MFADAHAH?HAD@F?F@DBFBDDFF@?FJJLHPNTJLDDDBFBF@H@F?FAF?DCFCBCBCDG@C@A@I@GAK?s@Ck@?ICiA@K@S@I@G@KBIBKDKFMFGBCDELKJEFCHCLELCLCL?JAL@L@XBH@H?L?LAHADALEDCDEDEDGBG@I?E?KAEAEACACEECGGCEEGAGCEAGAG?c@@W?MAG?ECEAEEGICEAECK?ACOCKCICIEMCIIQISEMCKEQAKCICICECGCGEEEECCA?ECECCAGAE?WAKAMCIAICECCCCAACOSAASWKMQOe@c@IIGKAEAC?EAE?E?A?KBSBK@G?A@K?C?G@AAE?K?S?E?K?G@GBKFU@CBSBMDc@BMBI@E@CBEBCBEDCDCDABADA@?@?F@D?J@HBB@^Jx@XXLHBB@@@JJBDBB@BBD@B?B@D?D?D?@?DAFABALIr@AH?F?F@DBH@DDJTZHJPL`@Rr@ZXHF@B?F?D?D?NGDCPINKz@u@Z[DCDCBAFAD?DAF?D?F@D@H@D?D?F?D?DAB?DCDEJGFIDCFCJCJAV?N@F?DABADADAJGXQZQFEFCF?HAH?F@LBJDHDp@ZVLLDVBN?JCJGHKBCHOJUBIHGHGHCL?N@PBLHDDBFFVBRFrABPBJJLJJHH|AlAFDRPb@^NLVTZPHBJBN?PATCPIJEHIDEX[FMJUFUFc@Dm@B[?MBe@B]BMDIBEFEDCFCPCN@PB?@dCt@NBN?`AGn@Ep@Aj@ATCRGFCFEFINMBER[l@cATe@Pm@Lc@DMJYBGFIDG?Ab@a@JMHQBS?E?OCSGU_@y@Q[KMIKCACAEAIAK?MBIBQLQNGDe@\\GBE@I@I?EAKAQEYMMIUMKIQQSWoAeBQUEICE?EAC?E?E?G?CBKJKJIVOXOHELGFMT_@@K@O@OAQ]cCIo@AI?OBS@ON_@?CHUFODKTu@Pk@x@mCNg@^iAJSPSV[NKx@[p@Uz@S`@KLEPMNODGBGDQ@QCe@E[CWAQ?YDs@@QFoAB_ADwANmBVwAHc@X_BJg@DQBGDIDGDEHGJCVE\\ENANERINGPQNOP[DOBI?I?AAGAGACAECEACEEKGIGk@USIIGOMMMQSIKc@k@Ya@ACKSKWEKACGSCIAGAKAS?mA@oA@M@m@Ba@@SBILiAD]BSHc@@CDQHQFKJKPKLIXONMDEFGJQBEBGFUF]?IBY@[?U?G?AEe@C[Qm@Ke@GQQm@ACMq@EcA?WASAWAM?AK_@O_@[u@[k@Yo@Sm@Sq@a@wBIa@EWEe@Ea@BMBYH]BMJ_@DQ@Q@K?I?I?KAMG_@Ig@E]AYAY?UDUBSBYb@{@R_@HMb@g@VWRQLIZ?FGfAy@pAeADCFEJKLOJOXc@LSp@qB\\_Ad@mAj@{AH]H]Hu@Fq@@g@?sABmC@MVy@xAuEDOx@kBDGJQNUV_@j@s@XYBOVUl@c@h@YpAk@nAe@JCt@Yn@UhBo@z@[jAe@BAFCNGZQXMzBcAJEXKb@KXEPCFAB?DAB?H?NALAr@CLAJAJCLEJEHEDCFGRSDM@A@E@K?M@QAM?GCo@?Q@kB@_@Dm@@MFs@X_Aj@kB@C@CBCRSRSPKJEd@Q^GNAJ?R?N@h@L^F~@Vx@Vl@TLD`@ZHFRRLHVLNDJ@J?LAJGJGHKBG@IDK?G?OAIEIMWmAwAUUKIOMQI}@_@_Ai@SQKMIMISEW?IAK?S@Q@U?E?ABQBUFSJURg@HILKPSTO|@c@BCnAk@NILGx@[TGLERGfAUr@OLE`@Mj@SlC{@fA_@j@Ol@Mb@IBAdBSt@G~@Iz@KzASzAOt@GLAf@EFA|D]VChAKt@EVCHAJAVGb@K\\KPGZMLK`@c@^_@\\YVY`@o@`AqA^Yv@}@`Aw@NKNGNGj@SHEf@Uf@U`Bc@PIh@UXC~@YTKRKn@St@e@vCgB^GbCa@ZGpBa@TEnAUHCnAUFAlAY|@c@FCp@WZMjAe@~@_@DATIh@QTIXINE`@Gv@MPATAF?H?PBVFd@NdFxBl@T^Lt@LlEXzBNzAFxCJD?hCFh@BH@tCTjBLv@F~@Hv@?H?^?f@CZClCa@nAUJATEf@MRG\\MRMPMnAgAt@u@hC}CXYX_@n@q@pAiAv@{@`A_ABC~E}EfAiAb@a@hEmE|A_BtGcHFI|B_C`@c@|B}BtD_EbC}CnA}Ah@o@bAuANShAwAt@cABCx@cAHKpA}AdAqAtAcB@?vAkBn@}@n@{@d@g@LKJI^ONGNCn@GjE_@lAKbCQb@CTAL?J?B?V@tANTBd@FL@\\FZDdARpAX|@LPB`BZxBd@d@Fb@DL?FA`@Cb@EVEz@ItB[r@GLA@?XEtBU\\ETC@A`C[bAOn@Ib@GtEa@ZGF?b@GF?hAONCZEn@KxASB?REVIVIZOLGPKRORMJKfC{CNQdAqARY^c@d@i@bAmAf@o@d@o@Zg@R_@FMn@mAd@wAp@}CBWPgAb@qADK@ChAuB`BkCjAuBXe@Pc@FQDQBWD]NcCBa@@]?SASAK?MAM?K?O@S@UBYDQDOBIDGFIHGNKZMf@OZMLEJGNKDEDEFGHKJMJSJSFOBMBOBU@QBKBKBMDIDIHKLMLGHEl@YpAg@FEBEBCBGBIBMBWDMFQDMDKDMDKDM@G@G@M?MEYESCSC[?GBI@IFMFQJWv@eBP_@NYVa@PSb@k@\\g@Za@R[NQJONITMTM^Ox@Yr@Sd@Mb@MPGJGHGLMNOJOHKJOFMDKDM@M@Q?S?W?[A]A_@AUCa@GSIYK[OW]c@SYIQEKAKCOAOC[Ea@AUAUAQ?IBK@GDEDEBA@AF?H?FBDDBFBH?P@RAP?X?N@LDJDDHBJDb@JdEdARFNDRBXDJ?JAFCHGFEBE@CBKDKBMBQ@S@Y@S?_@F_GD[Ju@\\qAPi@l@sBH[Ps@?CPw@h@}D@M@CR{A\\_C@G^aCx@cF@G@Gd@aCNaAbAaG@KBU@K?[AeB?IAk@IaAM_BQy@w@oEAGCc@Ei@Eq@Q{CIcBE}A?e@OeEGu@?EG}CAyACcBEeB?M?kAEeDB}@@?VuEz@sId@_E^oC@ENgARuARuAFYF_@F[L[N]n@wA^mAFMDIJYLWlAwBBEx@eBJWRi@~AeEj@qA~AqDt@wA`@{@HSh@sAbByD`DqGr@sAn@oARa@JStAyCp@mAv@_Bh@_AjAeC@ALYl@wABEZq@Ve@hAwBVe@d@aAdAmBVg@Te@|A{ClA}B\\q@p@mAFObAmB\\o@`AeBLWVk@NY'
                     },
                     'start_location' : {
                        'lat' : -6.6437198,
                        'lng' : 106.8475774
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.6 km',
                        'value' : 1582
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 118
                     },
                     'end_location' : {
                        'lat' : -6.811691,
                        'lng' : 107.1452461
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e1st\u003c/b\u003e exit onto \u003cb\u003eJl. Dr. Muwardi\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'd~qh@wd{lS?A?AA??A?As@UWGa@OQIOGOMOOGGEIA?GMIUEQCUAQAk@Ao@A_@Au@?a@?MAw@Au@?u@Ao@?eA?O?a@A_A?k@?WAg@?k@?M?qACsBA[G_@YyAQs@e@qBQm@_@uAU{@_@_B[{ASoASuAEWKo@Io@G_@WeBSsAIi@Cq@?[@OB_@Ds@Fi@B['
                     },
                     'start_location' : {
                        'lat' : -6.8145937,
                        'lng' : 107.1318005
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 136
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 26
                     },
                     'end_location' : {
                        'lat' : -6.8109673,
                        'lng' : 107.1461699
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. Dr. Muwardi\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`lqh@yx}lSASCIEIACCEIK[GGCECGEIKKO_@o@KW'
                     },
                     'start_location' : {
                        'lat' : -6.811691,
                        'lng' : 107.1452461
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.4 km',
                        'value' : 351
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 18
                     },
                     'end_location' : {
                        'lat' : -6.809155700000001,
                        'lng' : 107.1487731
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Aria Wiratanudatar\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pgqh@q~}lSSSYc@cAcBMSGK[g@GI{BmDaAkB'
                     },
                     'start_location' : {
                        'lat' : -6.8109673,
                        'lng' : 107.1461699
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 103
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 62
                     },
                     'end_location' : {
                        'lat' : -6.8099441,
                        'lng' : 107.1492355
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'f|ph@yn~lSd@a@VQRORILEJCJANC'
                     },
                     'start_location' : {
                        'lat' : -6.809155700000001,
                        'lng' : 107.1487731
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '19.3 km',
                        'value' : 19259
                     },
                     'duration' : {
                        'text' : '17 mins',
                        'value' : 996
                     },
                     'end_location' : {
                        'lat' : -6.8254554,
                        'lng' : 107.3061408
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Raya Bandung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'baqh@wq~lS}@eEGYUgAm@oCoAuF}@kEKi@Qw@oBaJmBaJ]}AwAyGc@wBgAsEkAsFe@{Bo@yCeD{OgDoOCK{@}DS}@WmA{AsGG]Mm@o@yCGEGQWo@U]g@u@S]EKCI?E?I?K?INmBe@_CmBgJ[wAUkAS_AeAaF_@aBQ_AIe@Mg@k@oCcA}Eu@gDq@aD[uAcAsEiAmFEQo@sCWkAc@oBOu@AA{@aEI_@{@}DKc@AAEWAMAK?M?I@OFi@D[Ls@FWNy@DUPq@nAmFZqAb@oBBKFU|AmGDO^_B\\yAp@oCrAsFVeAnC{Kj@aCLc@^{A`@{ADQ~@yDb@iBf@qBV_AJi@Ns@Hi@PkAF]Fi@Fg@Fw@BY@Y?i@@w@@gA?gBCqDA}AC_BCiA?WAa@?]@S?SBU@UD_@Da@?ARaCNeBTkCBQ@ON_BTgCHu@JkAHw@J_AT_CZ{C@GHu@Fg@NyAReBJ{@Hk@Jq@Jq@Je@Jg@hAuEr@sC`@}Ab@{ADMHWN_@To@b@gAn@}Ah@uADKJUHWHUDQBMN{@L_ANmA@MvAgLf@cEd@sDX_Cd@eDD]NaAL{@BQBMDMBKFQ@G@CFMHODGHMFIHKHKHIHGFEFEFGJGFEFCLG\\MLENCLENCv@OtCi@j@K~HyA~Cm@f@MTIXIPGNGNKNGROTOZWPQLKHKJOLMNUVa@LS`@o@T]R]dAaBv@qALWLUFOHQDODQDQBQBSB[@U?M?S?OAOCUQaBGc@CQAMAMA[GcAGo@S}CKiAGe@Im@EYK[Se@i@y@k@u@m@gAIUKe@K{@AMKaAEg@]_DACAMAUEmAAa@?CEkCAW?i@?AAQ?u@CwBAq@CcBEsBEiAA]KkBGgAEk@IsAE]G]q@mBGQCKEMCMG[Ci@Cs@AKU{CIwAQmCC[IwAGaA?GGs@G{@Gk@o@{IYaEGy@IqAIcA_@{FEk@GaAGy@Ki@Om@O[y@eBeE{IQ]GMCEuBmESc@[m@y@iBO]Sc@GSKa@M_A?AWyBAEc@uDGo@KaAAGOoAM{AGkAAkCAI?QAg@CgBEiBAm@A_AEaDE{ACaCG}FGkBAa@?k@@sABs@JmAL{@Da@Hk@^_ED[D[BMLe@Le@Ru@`@qANo@t@oCBMRq@x@_Dl@iCfBoGt@uCNm@HYLe@XgATy@@GVaA`@}ADOJ_@Ri@JWz@qBL]^_A`@}@N_@Vk@P]JMHKJKLGZSJGZQj@]lEkChBeAVO^ULG|A_ARMp@a@bCuAbAm@~@g@h@]d@YlA}@b@a@f@a@x@u@`@_@BCBELKVUn@i@dC_Bt@e@XQt@g@\\Uj@a@l@c@\\Uf@]f@_@BCDCDABADAB?BAL?D?@A@?@?@AFCh@YZQn@a@j@YrAe@fDgEpAiB~BgDn@eAh@gA'
                     },
                     'start_location' : {
                        'lat' : -6.8099441,
                        'lng' : 107.1492355
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '13.3 km',
                        'value' : 13302
                     },
                     'duration' : {
                        'text' : '11 mins',
                        'value' : 676
                     },
                     'end_location' : {
                        'lat' : -6.8335434,
                        'lng' : 107.4133434
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eRaja Mandala\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bbth@kf}mSPe@p@eBf@iADKRm@Tq@Ja@Lc@Ja@h@yCRiBRqBJwABqA@[?C?E@iA@}G@sD@uDBsC@o@?iA@s@?S@u@DaAFgAHiAp@_JRyC@CTyCFi@HiAToCLgBPsBRiCR_CXmDNcBXwD@MLuAPqB\\kE\\kELaAPoALu@^eBVkAXqAXgAh@mB`AuDp@aC`AuDBMbAsD`@{ANk@`@sA\\qA@Cd@gB@Ij@{Br@iCn@cCXcBBMRyADUNkB@QDaAFsAAuB?UEmAA_@?W?EC[IiA?MKaBMyBAMGaBAy@Aa@A{@A}C?G?EEkEAu@?u@Aq@?WAqD?GCmA?UA{@I}CEeCA_@?_@Aa@IsEAc@?MEgBAG?U?MAUCsAGiEEuCCgD?G?EAQ?MAo@As@A[CwA?YEoBAO?KCaBCqA?KKiBGi@AGe@wCWeBEYKo@QeAQgAMu@Mw@?E[mBKi@W{AUuAIg@YmBEUKm@My@Q_AQiA[qBEUQkA_@_CMk@?C]{BIc@S}AOcAKq@EQOu@Qi@CCQc@[y@e@iAc@gAGMKWUi@CGi@mAw@kBi@qA}BqFAC_AaC]y@i@uAg@iA[s@Ys@c@aAYm@w@}Aw@_Be@_Ai@qAi@wAa@mAM]K_@Km@E_@C_@?GC[C]?KGgAC_AAKAMCOCOIWSm@a@iAUk@O]Q_@GOGQIYGSGUSo@ESQq@WgAm@yBe@kBYgACMESCU?W?M?O@c@D{@@KB]BMDY@EJe@BSBSBS@Q@Q?E?]?e@?]?ICYEYCUGe@IUEIGIGGGIKGMIiBs@oAc@o@Ws@_@ECUMMIIIGICKCIAKASBs@?[@c@A_@?W?I?s@?Y@MN_BH{@JmADw@F_@BKBKDKFMHKLMJKZSj@[TOJE@?NGJEFAHAHAN@nAJN?JAB?JCNITY\\a@HIBADENGv@YDCDCJGFEFIHKJUHUj@sAHQjAiCJ[JYFSBQBM?K?E?A?KCSCMGWSi@iAgCKWIOEOCKAKAIAG?YAwBCgBCkAAk@?GB[DWBEDIDMFIFG|@g@PGFCHAJEz@ANAHAFCHCFEzAiADEDCBABALEdCm@jAWJALELELGHEFGFKDGP[x@}AFM@GDOD]BG?CDGBIHMV[FGDGDG@CDE@CBSVqAFYLWFI@ADEJIREHCJ?^Bt@HH?J?NAJCFARKLMDGHUTs@Vm@BEDE?AHEFANCJ@LDrAv@HBHBJBL?@?J?H?HCHCLGh@a@FIDEFM@G@G@G@k@@I?EBGb@u@FGHEHCxA_@PEHCHGJGJKd@m@JMHOVg@Zm@DIFIFE@ANGdA_@'
                     },
                     'start_location' : {
                        'lat' : -6.8254554,
                        'lng' : 107.3061408
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.9 km',
                        'value' : 1857
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 131
                     },
                     'end_location' : {
                        'lat' : -6.8348207,
                        'lng' : 107.4251269
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eCibogo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rtuh@kdrnSZKLELCb@MRENENCzAOLELEJGDCJIHIFKDMBK@M?QAQCOAGEKEIGISKuAYKCKGGCEEGGi@{@IIGEECKCQAkAIIAICIEGCCCEGCGIQc@}AIY?CAE?G?GJq@DIFILKJGJCLA|@C@?JAJAnAQLCHEHGHIDIDI@K?MCKCGKISK}Ac@_Be@IGIIEEAGAIAIBOPcAHa@BKBGHMVQz@e@FELIZWFIDGHOFSBM@S?M?Q?WC[WoA?ACKAK@I@GV_ADW@S@MAOE[QmA?KEa@G{@?G@IBMHODGDGFITWHKBIBIBG@EBQBYDi@Fq@H}@@KBQBODMb@mA'
                     },
                     'start_location' : {
                        'lat' : -6.8335434,
                        'lng' : 107.4133434
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '9.2 km',
                        'value' : 9215
                     },
                     'duration' : {
                        'text' : '18 mins',
                        'value' : 1078
                     },
                     'end_location' : {
                        'lat' : -6.8515128,
                        'lng' : 107.4971778
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eRaja Mandala/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'r|uh@antnSBG?I?ECu@AQEqAAI?EEQCIOUOOGGgAs@KIEIGICGACCMAQI_BCKCGCKEGCCCCIIMIKGm@YKCICGAGAgAG_@CGAGAQGMEKEGCKGGEGCGGIKGGUU_@_@}@_AEIGKCGCMAKC_@C]AM@M@O?KF[?Q?SQe@GSCMAIAKAK?M?U?QB_@CQAI?IEOGOGMIMKMGGCCGICCCEAEAI?I@[@a@@YDa@@M?GDQFQDIDGTQVUJGRODGHKVWNMTQFEHIHM@CDKBM@IAYCU?E?E@I@E@GBEBE@CDEFKHGJKLKHEHGHIFE@CDGDIBKDM@ODY?_@AQIk@?CMo@Kg@AI?KBQDWFYDW@S?SAQ?A?W?O@MBI@CBOFYDS@OAK?GAG?EEICCAAIIUWOMQOKICCIGGCECKGOGUKEAECSMAAQKEEEGEECGCEAE?CAE?I?I@GBKBEFMFKHMFOBI@E?K?C?EAICIEIGIGEIEQKGEGEKIMOKOMSGKEKCICOAM?O?AAM?CEQAKIWAM?G?GBOFKDINWFKBIBK@C@E?OAMAKAGAKAG?G?I?GBKBKDGDIHGJKLINMFGDGJOFOBKBKJ]DWFQHSFKR[FKHKXg@Va@JSBCPa@`@{@`@{@@ELYL]DW@KBQ@QAMAMAKA?CIOYS]MWM_@IWIQIQSWMQIMQU?CGIIQEQIe@E]G[M_@MWA?a@o@IS]i@CEIWGWAS?Q?UDWL[JWJSP[FSBIBWB[Be@F{@@_@B[AUAKAGEIEEGGCCGCICICWESGMEIGGECCGIMSIYES?K?OBODMBEBGFIJKLIHGNIJC@?FCPGPGHEHGFEHGHK@?JMFKFMLYDMDQBOB_@@u@?u@?{A?C@}B@_@BmB@W@eA?Y@gA?WBeB?[@W?uA@c@?I?G?]@y@@i@?G?k@@_@@eA?aA@Q@yC@Y@qA?kA@o@?a@?K@{@@}B@o@Bw@?K@M@W?OBc@BWBS@E@EBQFSHQBGJWDGHQLSFOP[BENYXi@HMJUb@{@`@u@HO^q@NYR_@\\o@f@_AZm@FKd@y@JQBGNWDG\\o@R_@JQfE_Ip@oAd@y@p@mAx@{AZk@Zm@DI`@y@r@eB|@cCj@aBZ}@\\aAHQXw@\\_A@EPa@b@kAd@sA^cARm@^_AZy@JYTk@BG@EBGL[Na@Tk@j@}AZ_AFQFOh@{AdEcLd@mADKDKfAsCXk@x@{AvBuDFKHMHM~@_B|AkCVe@jAiBDI`A}An@aA|AaC`BeC|C_F@A`AyANUXa@P[p@gABCdBoCJOPW@Ch@y@@Ax@oAP[FIDIBETc@LUBET]~AaCj@y@Xg@HOb@s@Ta@FG@C'
                     },
                     'start_location' : {
                        'lat' : -6.8348207,
                        'lng' : 107.4251269
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.4 km',
                        'value' : 426
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 50
                     },
                     'end_location' : {
                        'lat' : -6.8529089,
                        'lng' : 107.5007255
                     },
                     'html_instructions' : 'Slight \u003cb\u003eleft\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eToll road\u003c/div\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : '|dyh@kpboS|AmC@C?A?ABE@CBGDGFMR_@Na@Nc@La@Je@He@NkAb@mCRyA'
                     },
                     'start_location' : {
                        'lat' : -6.8515128,
                        'lng' : 107.4971778
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '6.6 km',
                        'value' : 6613
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 295
                     },
                     'end_location' : {
                        'lat' : -6.8980918,
                        'lng' : 107.5323609
                     },
                     'html_instructions' : 'Keep \u003cb\u003eright\u003c/b\u003e at the fork and merge onto \u003cb\u003eJl. Tol Padaleunyi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eToll road\u003c/div\u003e',
                     'maneuver' : 'fork-right',
                     'polyline' : {
                        'points' : 'tmyh@qfcoSR{Al@gFHs@Hs@XyAHa@L}@h@uEFi@BQF]Hg@Jg@L[NYPU\\[XQZQ\\Op@MVCL?b@?f@F`@Ht@Zb@Z\\b@d@v@`@f@x@n@j@Xd@Rv@LrAHJBDBFF\\CN?@?~Ja@|JuA~A_@LEB?FCzD}@f@Of@QtG}BdDyA~BiAdHkEtEmDNKfAu@xOyKjA{@`@YpIcGtFmDvFeDl@_@p@_@lGsDlAs@fGqDlBcAvAw@fGsDHEb@WzCcBxCaBfHaE~D_CRMHEdE_Cf@]pBqA|BmBJKfA}@pAoA~BkCfBkBzB}ChAgBl@cANWBEHONW`BwCx@qAvBwCbAiANODEFGX[|BuBhCoBhCcB|Au@'
                     },
                     'start_location' : {
                        'lat' : -6.8529089,
                        'lng' : 107.5007255
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5.1 km',
                        'value' : 5126
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 258
                     },
                     'end_location' : {
                        'lat' : -6.890384,
                        'lng' : 107.5747527
                     },
                     'html_instructions' : 'Exit onto \u003cb\u003eJl. Tol Pasteur\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eToll road\u003c/div\u003e',
                     'maneuver' : 'ramp-left',
                     'polyline' : {
                        'points' : '`hbi@glioSbA{@VQXSZWVUXY^m@Xk@Rs@He@Fc@Fe@@e@?]AW?O@G?A?C?A@CBAGo@KeA]yBAA?A[eCi@}GAMAIqAoLg@kDQiAS{@aAsCGSQ_@_AcByBeDoCiDSU_AkAoBaCeD}DsBkCiAyA}AuBkBwC}@{A]k@S[CICECEGGAEAAWa@]m@}BaFeCyFCEIOS_@Wi@Ue@c@eAAEACCGM[]_Ai@wAAGGSAACKK_@GQYoAg@kCW{AU{AQaBKqAAIOyBGyAGgBAiC?Q?]?A@Y@_AFcBLsBRsBP_Bv@mGP_BHq@Jw@@Kj@uEnAcKt@_GVsBF]tA{LZoC'
                     },
                     'start_location' : {
                        'lat' : -6.8980918,
                        'lng' : 107.5323609
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.1 km',
                        'value' : 2063
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 289
                     },
                     'end_location' : {
                        'lat' : -6.8969407,
                        'lng' : 107.5917854
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Dr. Djunjunan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'zw`i@euqoSv@aGR{A@K?CBQ^oCd@sDJm@f@uBHYh@aBN[BIBGXcA^yARgABY@i@@g@D[DW@U?M@O?_@CS?ICa@EsA?S?EBoA?C@a@Fm@@UVyABM\\gALc@DMd@cAT]BEl@aABEFKr@aAnAqB\\c@l@{@HMZa@Ve@HMHMJOjAeB\\g@p@gALWP_@t@}AFMJYNYHWp@{AHS`@}@^{@JW'
                     },
                     'start_location' : {
                        'lat' : -6.890384,
                        'lng' : 107.5747527
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 231
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 19
                     },
                     'end_location' : {
                        'lat' : -6.8981607,
                        'lng' : 107.5934622
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Layang Pasupati\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'z`bi@u_uoSDIDIP]f@cA^s@DGb@q@@A`BgB'
                     },
                     'start_location' : {
                        'lat' : -6.8969407,
                        'lng' : 107.5917854
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 512
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 87
                     },
                     'end_location' : {
                        'lat' : -6.9001733,
                        'lng' : 107.5974351
                     },
                     'html_instructions' : 'Slight \u003cb\u003eleft\u003c/b\u003e toward \u003cb\u003eJl. Pasirkaliki\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'nhbi@cjuoSBODKDGnA}ANQf@m@`@c@b@g@X_@FGV]@A`@k@Tg@Ri@Nk@Ji@BYDg@@OBg@?s@?o@?S'
                     },
                     'start_location' : {
                        'lat' : -6.8981607,
                        'lng' : 107.5934622
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.7 km',
                        'value' : 702
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 178
                     },
                     'end_location' : {
                        'lat' : -6.9064795,
                        'lng' : 107.5975854
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Pasirkaliki\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`ubi@_cvoSH?B?J?B?H?h@AdBAPDfDCx@Az@AlCEbCEtDEH?hAAF?d@AzDA'
                     },
                     'start_location' : {
                        'lat' : -6.9001733,
                        'lng' : 107.5974351
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.8 km',
                        'value' : 762
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 73
                     },
                     'end_location' : {
                        'lat' : -6.9071507,
                        'lng' : 107.6044415
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Pajajaran\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'n|ci@}cvoSLq@Ha@H_@BW@W@O@_@LsA@YFgAJyD@]DgB@S?E?U@a@XsF@_A?EFmCDuB'
                     },
                     'start_location' : {
                        'lat' : -6.9064795,
                        'lng' : 107.5975854
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.6 km',
                        'value' : 619
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 64
                     },
                     'end_location' : {
                        'lat' : -6.912654799999999,
                        'lng' : 107.6039627
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Cicendo\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 't`di@wnwoSdBC^?jBC@?pA?@?\\@R@NB^Ht@TNBZHf@HTBVBn@BrADvENv@BtA@'
                     },
                     'start_location' : {
                        'lat' : -6.9071507,
                        'lng' : 107.6044415
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '80 m',
                        'value' : 80
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 10
                     },
                     'end_location' : {
                        'lat' : -6.9127402,
                        'lng' : 107.6046865
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. Cicendo\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`cei@wkwoSPqC'
                     },
                     'start_location' : {
                        'lat' : -6.912654799999999,
                        'lng' : 107.6039627
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.6 km',
                        'value' : 556
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 77
                     },
                     'end_location' : {
                        'lat' : -6.9141784,
                        'lng' : 107.6076387
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Kebon Jukut\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rcei@ipwoSxDHjBH\\BFAD?DCDGDYRaDZmE@YAQCIGG[KOKGMGQOWM[AEK]'
                     },
                     'start_location' : {
                        'lat' : -6.9127402,
                        'lng' : 107.6046865
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 152
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 23
                     },
                     'end_location' : {
                        'lat' : -6.913854600000001,
                        'lng' : 107.60895
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Perintis Kemerdekaan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rlei@wbxoSO]GQK[IYI[Ge@Ag@A_@@U'
                     },
                     'start_location' : {
                        'lat' : -6.9141784,
                        'lng' : 107.6076387
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 171
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 32
                     },
                     'end_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e2nd\u003c/b\u003e exit onto \u003cb\u003eJl. Braga\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'pjei@}jxoSA?A??AA??AA??AA??A?A?A?A?A?A@??A@??A@?@?@?@?@?@??@@??@@??@@@?@?@p@@|BD`A?D?D@'
                     },
                     'start_location' : {
                        'lat' : -6.913854600000001,
                        'lng' : 107.60895
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '83 m',
                        'value' : 83
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 28
                     },
                     'end_location' : {
                        'lat' : -6.915076,
                        'lng' : 107.6082096
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Viaduct\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eDestination will be on the right\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zrei@}jxoSIjAEf@AHAT'
                     },
                     'start_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '259 km',
                  'value' : 258810
               },
               'duration' : {
                  'text' : '4 hours 9 mins',
                  'value' : 14960
               },
               'end_address' : 'Purwokerto, Banyumas, Central Java, Indonesia',
               'end_location' : {
                  'lat' : -7.4313873,
                  'lng' : 109.2479051
               },
               'start_address' : 'Bandung, West Java, Indonesia',
               'start_location' : {
                  'lat' : -6.915076,
                  'lng' : 107.6082096
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '83 m',
                        'value' : 83
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 10
                     },
                     'end_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'html_instructions' : 'Head \u003cb\u003eeast\u003c/b\u003e on \u003cb\u003eJl. Viaduct\u003c/b\u003e toward \u003cb\u003eJl. Braga\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'frei@ifxoS@U@IDg@HkA'
                     },
                     'start_location' : {
                        'lat' : -6.915076,
                        'lng' : 107.6082096
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 120
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 48
                     },
                     'end_location' : {
                        'lat' : -6.916245,
                        'lng' : 107.6089453
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Braga\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zrei@}jxoS^@hCDL?J?NG'
                     },
                     'start_location' : {
                        'lat' : -6.915177,
                        'lng' : 107.6089538
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 128
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -6.9165211,
                        'lng' : 107.6100336
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Merdeka\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'nyei@}jxoSCGCE?G?G?GBIz@gD'
                     },
                     'start_location' : {
                        'lat' : -6.916245,
                        'lng' : 107.6089453
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 232
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 30
                     },
                     'end_location' : {
                        'lat' : -6.9175137,
                        'lng' : 107.6118848
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Lembong\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f{ei@uqxoSJSNa@~@{B^y@JSXw@b@y@'
                     },
                     'start_location' : {
                        'lat' : -6.9165211,
                        'lng' : 107.6100336
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 507
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 89
                     },
                     'end_location' : {
                        'lat' : -6.921816199999999,
                        'lng' : 107.6119103
                     },
                     'html_instructions' : 'Slight \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Tamblong Dalam\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'lafi@g}xoSFG\\k@NWFGFENC^@^DLC~@@@?p@FlBJf@DfBNF?zBPH?xDT'
                     },
                     'start_location' : {
                        'lat' : -6.9175137,
                        'lng' : 107.6118848
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.3 km',
                        'value' : 1293
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 177
                     },
                     'end_location' : {
                        'lat' : -6.9324369,
                        'lng' : 107.611391
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Lengkong Besar\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'j|fi@m}xoSvAHP@p@B~AHr@@rAH|DRJ?P?R?DAB?LEl@Up@a@x@o@j@k@ZYVUd@a@d@[TKTE`@E~@Hb@BrCDhDFr@Ap@BB?nBHT@R@RD`@PNHHDtA~@`Ah@zBlBXV@B@@@@@B'
                     },
                     'start_location' : {
                        'lat' : -6.921816199999999,
                        'lng' : 107.6119103
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 528
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 71
                     },
                     'end_location' : {
                        'lat' : -6.9318523,
                        'lng' : 107.6066487
                     },
                     'html_instructions' : 'Slight \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Ibu Inggit Garnasih\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'v~hi@ezxoSCZIdB?DQfCSzA[bFKzBE~@Ez@MjB'
                     },
                     'start_location' : {
                        'lat' : -6.9324369,
                        'lng' : 107.611391
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.8 km',
                        'value' : 2776
                     },
                     'duration' : {
                        'text' : '9 mins',
                        'value' : 547
                     },
                     'end_location' : {
                        'lat' : -6.9558538,
                        'lng' : 107.6119115
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Moh. Toha\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`{hi@q|woSbBHzAD`@B\\BzCNxBJ\\?bADxADlBBj@BZ@N@|ABH?ZBR?x@?RDnAFhA@Z@NAH?@ARENC|Bi@@A`ASRGfCg@r@SHCZGjCq@B?PEfAUj@MJCPEVGFA`@KBAj@MDAd@KPElAYp@OhAY`@M^IZGz@Sj@O\\INEFAXIVGFATG`@Kd@KpBc@~@W@?`@Mf@MRINCDAv@SRGv@MTAR?XKFAbA[ZKh@QpA]ZI\\I`@ItA]j@MrA]l@MHCh@IfAUh@O~@WLEv@QXGb@KTG^KXGn@M@AfB_@h@Kv@QLCTGb@KXIDA'
                     },
                     'start_location' : {
                        'lat' : -6.9318523,
                        'lng' : 107.6066487
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.8 km',
                        'value' : 784
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 95
                     },
                     'end_location' : {
                        'lat' : -6.9593481,
                        'lng' : 107.6062276
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Tol\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003ePartial toll road\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '`qmi@m}xoSBD~@|DNp@Lf@p@zCz@zDTdAZlAXz@`@x@RZZ`@HL@?FFfAz@|@d@bBh@nAN'
                     },
                     'start_location' : {
                        'lat' : -6.9558538,
                        'lng' : 107.6119115
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '17.2 km',
                        'value' : 17221
                     },
                     'duration' : {
                        'text' : '13 mins',
                        'value' : 779
                     },
                     'end_location' : {
                        'lat' : -6.9425948,
                        'lng' : 107.7533701
                     },
                     'html_instructions' : 'Keep \u003cb\u003eleft\u003c/b\u003e at the fork and merge onto \u003cb\u003eJl. Tol Padaleunyi\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eToll road\u003c/div\u003e',
                     'maneuver' : 'fork-left',
                     'polyline' : {
                        'points' : '|fni@}ywoSFAB?vAEZEr@Sh@UXQTQTWRWb@}@T}@J{@GkBK}DOqHWqJKaDAUAU?A?AAE?EEsACoAKqEBcBXwD`@gDh@aDd@mBv@mCBGh@cBDOTw@x@}BbBgFXy@^uAf@gBd@sBf@aCd@iC^cC\\iCRwBPwBPeCTmDFsAfAeQ?M@E?A@Mx@oL@W?E@G@EFwAVaEJaBBYB]HkANgCLmC@eBAkDAw@SsDUsC_@sCMo@e@}B[}AO{@g@kDM_AKkAKyAGqAGqCDuD@CVkFTkC^oEj@gGn@wH^oEDg@b@eFXuC^kDx@qFbA_G@CF]l@uCf@}CRgBHaAf@{K?CAOAaGGqDC]A_@Aa@Aa@Aa@?e@?k@?y@@q@?a@Bu@B{@Bi@Z{FjA}VXoG?K?G@I?KZ{F@QPcDTuEh@yKFmBn@yM@KB_@DcAFcAFsAFkADmAFeAD}@HgBFkAD}@HsAHeBFgBHgB@{@FuD@mBA}CIaFO}Da@oFYqDq@_Fa@gCSqAm@}CgA{EkBoGGOIUGUGO}@gCAC?CA?c@oAaB{DaDqHACEI}BuFcI{Q}FcNmAwCISYq@aCwFyCiHqCoGoFcMiAmCaD{Hw@gBuAaDi@oAk@qAaDuHUg@Se@g@oA_AsBc@eA_AyBoDcIoDaIaCkF}D{IO]ISYm@EIeByDSe@EKYm@[q@cAyBwBaFEIWm@{@mBcB}DWi@Yu@uBoFwBgGm@mBSs@oAcEWk@k@gAg@mA]}@YaAK[Km@Eg@Ko@YeBMa@e@eBCIg@sAUo@Qc@_A{BQ_@_@m@GMISIU'
                     },
                     'start_location' : {
                        'lat' : -6.9593481,
                        'lng' : 107.6062276
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 206
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 23
                     },
                     'end_location' : {
                        'lat' : -6.9417417,
                        'lng' : 107.7550297
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Bandung-Garut ByPass Cicalengka\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'd~ji@qqtpSUu@[{@mBgEIQ'
                     },
                     'start_location' : {
                        'lat' : -6.9425948,
                        'lng' : 107.7533701
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '21.2 km',
                        'value' : 21177
                     },
                     'duration' : {
                        'text' : '23 mins',
                        'value' : 1407
                     },
                     'end_location' : {
                        'lat' : -7.0370214,
                        'lng' : 107.9076685
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Nagreg Cicalengka/Jl. Raya Bandung-Garut ByPass Cicalengka\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Raya Bandung-Garut ByPass Cicalengka\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'zxji@}{tpSPg@bA{@l@i@|@y@bHqGFEt@s@TQRMVKXGn@KhAMl@GXCXGPGPIJGHGNOFI~@gAp@y@zAgBRWHKfAqAlEqFnGoHz@iA\\i@LWBEXq@BQDWLUJOHMFINOLKdA{@l@c@tAcAj@m@NOb@g@Zc@LUL]La@Lm@d@oBt@mDHa@Ry@\\{ALw@f@yBLo@F[VaANm@H[l@iCpAcGPq@Pw@Nk@l@qCb@}BFQ?A^mAFWBS@MC]?CEo@?m@@k@Fc@Le@HMf@m@LOLKRWLUPm@Lk@Nq@b@kBl@yC@C^_Bh@aCRy@TaAFSf@yBl@aCVgAPs@ZuAH]hAiFPw@@ETcAJg@`@gBBONm@d@kBNo@XoA~@eEbAyERu@VcAPs@tAmGVcAbAgEl@kC@AZ}AFUNm@d@oBViA@I@?ZwAXoAj@}BXuAZkAd@qBHc@Tw@?CDWHi@BWXgDPiBViCPiBXcDHo@Fo@Z{CPgB`@}DB]LyAFw@TeC@c@JoANiBB]TuCHgA?IPuC?]@E?c@@w@@M?S@I@[?E?U@G?E@y@@a@Bc@@m@?I?EFyB@Q?k@?KFkB@c@@eAByA@YBkC?CJaFJ}E?EBs@@_@RgNHeDBu@@e@?_@E]Mk@Oc@CGAICS?U?KBc@TcBFa@\\iDBo@DsCFaA@y@Cm@KeBCu@@a@?EDu@TyCBqAD}@No@Ri@zAcBrA{A^a@f@u@Rm@Lo@Lo@P_ALm@Ng@LYLSNQf@c@^Wr@Y|Ae@b@QTKd@YVQp@m@`AkA^]tBgBnA_AnB_BfA{@b@_@pAkAj@a@rBqBhAaAb@a@r@e@hAm@rDsBlA{@t@k@z@q@dA{@dA}@LMzAoArBcBzCoCfAaAHG`BaBt@u@r@s@@?LOLMfAaAb@_@\\Wj@[\\Q\\QLG|C_BhAm@bBy@~DuBz@a@xBcA@AlBcAdB}@xBgAf@UJEhEcBdAc@n@Y^O`Bi@bFoBlC_AdBs@`@W~@{@l@{@LQ@AXa@\\i@`A{At@oALSx@wAVa@Va@l@{@R[f@a@HEbAk@RIhA_@DCLENEd@OHEvBu@lBo@z@U|@[bE{AZOHCNGPMROp@{@DE^g@JMXa@t@cAr@u@JSDI@AViAHQTs@LWJUHK@AHKXUFEn@g@^S|Aw@zAi@DChAa@ZOROPMf@e@RWT_@j@gA`@gABM`@eB|@mCVy@t@gBf@kA`AsBBUFMBEd@y@FM\\m@b@_AJUN[h@uAr@aBn@eBXm@^m@\\e@DEv@kALSf@}@HQDIrAcDN_@Pc@FKLYTc@DIdA_BNUbAsA|@eAj@}@d@w@Ve@^u@FM`@u@dA{Bl@mA`@y@fBuDZs@BCN_@dA_C`BkD\\s@|B_F`AwBJUZq@P]pAwCj@mAFMjC}FBG`@}@BEtAwCt@_B|@kBJWFKL[p@yADI|@oB?AR_@h@iAHQRc@BGXs@JUZu@\\aAPu@ReA?AHi@Da@BSDi@@OF}@Hw@Jk@Ny@V}@T{@BK\\aAF]B[?A@WAI?K?G?M?E?ABQBKFQBCHOTWV[r@y@f@k@h@k@\\[l@e@p@_@RMhAm@PKBCL?v@e@l@_@`@U~@u@BCJK^_@^c@\\g@T]R[`@u@P]VWTOb@ORCZETAXE\\IXSNWPWTOVO^Kd@Cf@@\\A\\CLEFIFGDGBE@E@E@CBEJa@Fc@BQDUPaBFq@F{@BMBa@BOBGBCDEJIPKd@Ub@OLENEPININMJKHMFILYXy@\\aARYJSZ[VMr@g@\\MPCT?RCPCVKNQJMHKb@a@RSRO^Yz@W\\Kf@GZENAPEJCJEJIHILSJMBGDKLWNQnAsA@AXWZg@d@m@f@i@JMHM\\k@T]^a@X]Le@Fa@Fg@Rk@Pg@HQFGLOFGRKVKl@Sb@M|@['
                     },
                     'start_location' : {
                        'lat' : -6.9417417,
                        'lng' : 107.7550297
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4.8 km',
                        'value' : 4752
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 267
                     },
                     'end_location' : {
                        'lat' : -7.041761999999999,
                        'lng' : 107.9455269
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Nagreg/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'jl}i@}urqSp@a@XSRMRWHOJSDMJWBQBQDU@W?[ASASAIEKGUEKM[GOSg@GSOYSe@GUIYIYASCW?m@F{@DYFg@BSD[BWBWDUDa@@SBg@B]Bc@D_@Dg@Dk@Fw@Ds@?[Ai@Ec@AGAGGQIWI[EQCUAQCi@CuAEaBGcCI{Ce@kFUwBMwC@uBFq@BYBSDYD_@Bc@DQ@SA[O[[[Wc@U[Kc@SaAGkACg@GeBMwBE}AOsCAcB?aBAe@B}B?}BLoB@SRcBb@kCf@uCTsAPkAB[@_@@ED}AHcBB}@LsAHgALkARsAZaBT{@Le@Ha@Hc@D[@Y@WA]Ai@Ec@G]IQIKc@c@e@i@a@WQQg@]UYSUMQIMEKEQA_@@YDQDIFKDILKHKPOLIZOVMJCNEVEJAJCDCDEBI@ABEFIDMFODI@MBMHUDIBEDIPSDIFGDCDCBAB?D?R?F?h@A`@Ed@GB?DABCDAEhA@@@?@?DAPWFGJGJEJEJELGHCb@ITGHGLILMHKDIFMBQ@U?c@?SBODUDOFQL]FQHUDSPaABW@UBYBUDSDOHQJKFEFGr@[bAk@\\SJKDIDIBI?G@SBa@'
                     },
                     'start_location' : {
                        'lat' : -7.0370214,
                        'lng' : 107.9076685
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.7 km',
                        'value' : 3698
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 239
                     },
                     'end_location' : {
                        'lat' : -7.0380916,
                        'lng' : 107.9769187
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eLimbangan Barat\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~i~i@qbzqSbBc@l@OVMJGDEHGBIDGBI@I?C?KCOEUOe@w@aCSw@C_@?MBQDMLW`@kATi@\\u@Tc@`@}@|@iBJYHWfAyEHg@BI?I@K?KA]IiASaCYqCQoBi@kKOoBMoAOyAGi@MgAEWi@wF_AcMWyCwA}L_AeJ]mEAWYeDKkAWaCSgBW_CGo@AMY}BAEc@sCMu@Ou@{@eCmBsDeAqB_FmJ'
                     },
                     'start_location' : {
                        'lat' : -7.041761999999999,
                        'lng' : 107.9455269
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4.1 km',
                        'value' : 4051
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 299
                     },
                     'end_location' : {
                        'lat' : -7.0445623,
                        'lng' : 107.9946129
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eBlubur Limbangan/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : '`s}i@wf`rSiBcDC[C]GYEMEKGKEKOUQSQSw@kAq@u@CCCCEICCCCCCAA?AA?AAA?CA_@Q{@]SKyBgAqAu@ECGCECEEEEEGAACCACAC?CAAAG?E?GAK?ML}FBmGF_DBoH_@e@Y[Y[MQMQEIEKCICKAIAI?I?K@I@I@IBIDGBIDGFGDEFGFEHCDCDAJCLAJAL?J@L@J@HBHBPJPHPLn@\\n@\\PJRHHBHBHBH@J@H?H?H?HAHCHCHCBABADCBABCBC@A?A@A@C?A@A?C?A?A?C?A?A?CAA?AAC?AAAAAAAAAAAAACCCCGGEIEICICIEUESCU?S?U?]B]F]F[HYHYLWLWPWRYRWTWT_@T_@T_@V[TUHIDCDCt@c@~FbBbBj@hCfAr@Vv@\\b@d@Vb@^nBLdCt@\\dBX|ABbABnA@HDFD\\RXV`@Z\\PXDz@Ml@OCg@@q@y@y@i@m@KUE]Cm@B_@@IBSLWHGHETKHGFMBKCMGUIWOa@Mk@ES?OAM@O@MBOJm@FWLULKLCLAJCJGDMDa@Bm@Iq@IYOWM[Ia@Es@E_BFeBC?KCICGEEKCKEYAk@Bu@T}@'
                     },
                     'start_location' : {
                        'lat' : -7.0380916,
                        'lng' : 107.9769187
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4.6 km',
                        'value' : 4610
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 306
                     },
                     'end_location' : {
                        'lat' : -7.0530146,
                        'lng' : 108.0214847
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'n{~i@iucrSxAi@XIPGDGBIBMBWFc@FYJUR_@n@gAFKBO@K?MAO?YEWG]Me@IW[]QUMUEMAMBMDMBIDKLMLKLEJCH@HDR\\PZNJNFj@D|@Bp@?j@?X@ZF~Cn@j@LNBN?HA@AHAJCFKDODO?UCS_@cAG]AYB[H[HMFGHCHCNAJ?L?NBNBRH\\Nx@p@XLN@LCFAHEHEHIXc@BEf@w@PYr@gAx@{@RU\\Ub@Ob@Ib@Gb@CtAAh@C`@Cl@Gf@KvAYTEHEHIDI?I?YCCWICIEGEEGEKEMCWEMCKEKEIGIIKQIQISGYI]E]Ca@?[?[B]B[Da@Fc@BKFOFMJORYZ]h@e@n@k@~@u@zAiAl@a@b@[t@g@XWVWPSJOLUFU@MCMEIGEEEWG[Eq@EUCMEKGSMQMOKOWEIEKCMAKASAi@?o@B{BDiAF_CBc@DIHKJMRQTSNKZi@Re@L_@FUDUBW@WAc@Eo@Cc@AW@QFSHSTc@Xi@FOFQDS@G@G?O?QCOCQIMKMUOSI[Is@K[EQGQIMIMOKSEU@QBSZaCCOKOIOOOe@Wi@[MIEGIOESGYMgBWwCGmAC_A?c@B_@JWLMRCV?TENCHGFEFKFQBSBk@Cw@OaA[}@Se@Yk@g@w@Yg@c@u@Ui@Sa@Sc@S]a@g@'
                     },
                     'start_location' : {
                        'lat' : -7.0445623,
                        'lng' : 107.9946129
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4.9 km',
                        'value' : 4931
                     },
                     'duration' : {
                        'text' : '6 mins',
                        'value' : 344
                     },
                     'end_location' : {
                        'lat' : -7.054435199999999,
                        'lng' : 108.0502283
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'hp`j@g}hrSJWL]Ps@`@{Ax@}Dh@wCXaBVqAZiATm@\\s@\\u@Xq@EKEIEEEEECICMAOC{@E_@AOEKGEEGIIOOk@UmAK{@Ei@@c@@WB[p@c@x@g@|@g@hAg@x@YjA]r@Of@GV?P?PBPBLDJHLJLJBAL?j@D^?N?LENEJCFEFGDGDGBIBIBIBO@M@KAKAGEIGKSYQg@YcASgAWaBUcBI_A?q@AO@iBFaBD}@@q@Dc@D[?QASEOGIIISIQESCe@AU@SB]Fc@PUJ[N[LODI@Q@S?YGYI_@Qe@YgAy@sAoAkAqAkAcB}@_@g@W]QQMSOMKIOEMCO?_@@]BMBKFMJOZc@t@u@r@k@v@i@BS@S?OAOEUMe@Wu@[}@[sAQy@AQ?OAWBOBSDQFQJSR[V]V]POJILEJCN?TAT?x@@\\?R?RAHCFABCDCBCFI@K@G@E?G?IAGAGI]K[e@_BWu@[g@SUUSUOOKSGQ?U?k@HyAPu@DU@UAIAKGGGGKEQCQ?S@QDOJKHGJEHAR@p@DV@P?J?L@JCLGDIFK@OAOCQEa@AI?MBQBIDIHKHIVQRKNKTSLUJSBMFUBYBS@]?[Aa@?KAWAc@AUGWCe@Ac@wBiBU[MSIUISGg@?[?UBWFUNWHIHGFCHAHGNIHGNINKVIRGTCP?V@ZDXFTHVNPJVP'
                     },
                     'start_location' : {
                        'lat' : -7.0530146,
                        'lng' : 108.0214847
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.9 km',
                        'value' : 3885
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 222
                     },
                     'end_location' : {
                        'lat' : -7.058225999999999,
                        'lng' : 108.0726472
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'fy`j@}pnrS~@Yt@W~@_@pAk@f@QZKZEXE\\EVEPELEDEHKDKDM@Q?K?EAOEGGQOOk@_@MKIIIIGIGMGYCKGIIGGGICIAGAu@ISAc@Ea@AWAGAGAEAEAECECGGACACAAAE?GBGDMVc@f@}@Xq@~@qBn@}APq@D]BWD]FUNm@Lo@F[DOFQHWHQLKLKHILGHGFGDEJQF[BYDs@Jy@Jm@FWFKFGHCJCHARBTHTLPRLRJPDLFVFNFNHJFFFBJBJ@R@L?J?NGHGFGDGJUDK@I@S?UEYCEGGKEQGECIGGCEGCCAGAE?M?KAIAKCKEMEIGIEGMMKEKEEECCCGCGCM?MAUAQCGAICEEIGKGEMIMEQIGCIGEGGGEMCI?G?MBKBIDGLQPSTSTKFELCTCNCPEJEFGDGBGCKMSSUEICGCK@I@GDQHSFUJc@FWDOFWDMFOHMDGBI@IAIAGCKIKKKKIKCOCK?E?E@GBEBEDADCHA\\CNALEFIFMJOHSDQDI?KAKAQKSYS]Mc@Mg@?A?CC_@C[EUISKKYUc@Wo@Ue@U[W_@[]a@GGMQIc@Aa@L_A\\qBViAVcA`@o@\\g@\\_@v@q@z@e@v@Mr@ETCVE\\OVYT_@D]CWK]YYSSIGKSCO@KFUPYXa@JW?ECMGMGOEOAMAO?U?QBk@?W@ODIDIJMBE@E@I?GAGCIEKEKIKGIEMCKCMCMAM?GBIHOJSR[LSJQV['
                     },
                     'start_location' : {
                        'lat' : -7.054435199999999,
                        'lng' : 108.0502283
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.8 km',
                        'value' : 1840
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 109
                     },
                     'end_location' : {
                        'lat' : -7.0607602,
                        'lng' : 108.0869373
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|paj@a}rrSA?E]EYM_AK}@Iu@?AC_@C_@Bk@F_@HWXm@Xe@N_@Bg@D{@C}@?u@@}@FcARqATqAVeAv@aCd@aAdBuB\\[NSLM@EDI@KCIIIGKEKGOEOCQ?Q?UBODWFOJQRSn@]x@c@TMJKBK?E@IGKIKUOUGKCKKGMAO@YHg@H]Ra@NWXWXMXMVKFEFELKXg@Xq@Pi@He@@SAYCKEUIOIMMKSKYMm@[]UEIGIGKGKCKC[D{E'
                     },
                     'start_location' : {
                        'lat' : -7.058225999999999,
                        'lng' : 108.0726472
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '15.8 km',
                        'value' : 15751
                     },
                     'duration' : {
                        'text' : '15 mins',
                        'value' : 879
                     },
                     'end_location' : {
                        'lat' : -7.1583216,
                        'lng' : 108.1472904
                     },
                     'html_instructions' : 'Take the 2nd \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'v`bj@kvurSx@A|CQtCOhBGN?TALA`@Cf@Eb@KRGbA_@d@S^OxCeBr@_@pAw@nAy@zA{@`DqBp@c@\\OXMv@I`@A~BIfAMh@I`@MXOVIlAW~JmBPEPEHGHEJGNMHIRS^i@v@kAd@w@b@g@NUr@_@ZM`@Ij@Mh@Mj@Sf@Wb@WXYt@s@^]b@a@f@_@b@Yf@[h@[b@MVEl@Mn@AXAJALCtAg@v@]j@[b@YVc@DCpF{C~GgDhGmCtCy@zBa@pCYhAUjASz@e@jC{@x@Sn@I~@Gp@Ap@@|AJxAN~Cj@\\FVF|@P@?nJy@|D|@F?|@MtBc@^E\\G^Op@e@JGXQzAo@lCgBzFgDb@[XUNMbAk@jAe@nAWlAQ@?REtDy@b@Ir@MpEiAv@Qt@W`C}@vAa@hA[r@UfBs@r@WnAa@r@[x@]~BgAf@_@bB_AzBcAvAi@XKt@_@VK@ALGVKNIJIHGJMFG@AHKHOVa@\\i@\\u@b@_AHKDIFIFGJKFGFEDCDADCJALCH?J?R?B?D?FAHCDCJIFKLUL[ZoANm@Hg@Hq@B]@K@IBIBEDIDEFGFEHGJGDCFAF?F?D?D?D@B@DBDBDDDFFHFJL\\HRFTDNBV?N@R?F@H@B?@@B@B@@@@BB@@@?B@F?J?FARENC\\GHCFCFCFE@CBA?C@G?E?GAOAI]wBGg@EWAMAI?I@O?CHk@DSLq@@K@I?K?EAEAK[cAGWCKCM?S@QBQBM?K?SAW?E?C?C?A@C@C?A@EDEBCDCBADC`@If@KLEHEBABADE@E?A@IBKBMBI@EFKJMV]JOBEBIBOD_@?K?M?GEOEKIIKIUIKGIGEICGAMAy@@sAB{@DWFSFIFKFEFCNGLC^AT@N@PDZFv@ZTH`@Lb@LLFJFDDHHFJBFBJBD@J@^Ad@AZCX?PBPBLHT?@FJDFDDD@DBB?F?HAJEJGbAk@PKNKVSPWJWDIBIHg@BS?OAOCUIk@Su@oAyDYw@Ue@AAUYg@i@MOGMGMEGCOAEEUCUAUA_A?e@?QAMEQKg@CUCSCe@E{@E_AAWAO?O@I@KBMFWDM?O?G?EAKCIGMGIOSMQIMUe@KQECGIKGIGCECCAG?I?K@KJWNYRe@BM?GAGAKO]KSEKAEAK?IBOBQNm@f@uBZ_AZo@FKNQJMFE\\]PUJOHUHWDY@KNgBFkABc@@a@AQ?EAKCIGK]k@IOGQEQAMAC?M@SBSLeAZeBFm@D[Du@Bm@?E?k@@S@QBG@E@EFOJUTa@T]Tc@R[j@aAp@uAd@gAh@oAvAcDx@iBj@uAhAmC~AmDXm@Vq@j@wAl@{A^y@l@qAh@qAz@eBl@oARe@p@{AXq@f@wAVu@X}@Nc@Ts@~@{CX}@BGDQL_@Jc@DSF_@Hu@Fm@DYFMJIHCJCB?RATAhB?nC@zB@hAB|ON|A@x@@X?`@@dCChB?\\AnC?f@Ar@@|D?r@@~AAdB@t@?`@?jACx@Gh@Gn@IdAMn@KpB[x@OhAWpBc@fAWBAjAYrCq@dFmAhBc@fAWn@K@?ZEVAP?T?\\?B?X?J?X?~@?vA@|A?Z?f@?fGBtHJfB?hA?fCBH?dGDrD@z@?t@@xCB^@X?r@@|BDH?lC@bF@pBAb@@F?J?vBDPAJAHAHC'
                     },
                     'start_location' : {
                        'lat' : -7.0607602,
                        'lng' : 108.0869373
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4.9 km',
                        'value' : 4857
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 260
                     },
                     'end_location' : {
                        'lat' : -7.185046199999999,
                        'lng' : 108.1786118
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. Nasional 3\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'nbuj@qoasSBC?C@C@C?G@KAgF@aB?C?m@?[?[@]@_@@K@K@IBKDMDINYVa@n@cARUDEDEFGBABAFEHCJEHARELAfAIfE_@z@KtASZIp@QdBk@XMv@[JEl@UtAi@FEh@UvAm@TMZQn@]zBmAn@[DEl@YTMHGDK@E@IHaADk@FeAFcAJ{A@CH}@TmCRsBLoAJ}@B[DQJk@H_@Rw@Tu@BGPo@Tq@\\cATm@L[j@yAd@_AP[LUR]^o@j@_ANWDGZc@z@sAf@w@BEb@m@fCmDdAwAlBeCj@y@t@aAz@iAd@m@z@cAv@}@lAsAZ]TYX[Zc@rGiIvJeMxEmGhB_B|@s@z@k@p@_@VMl@Ub@M`@Kx@WLGTG^SZM\\M^Ql@Y`@Sn@[n@a@NKd@_@pAaA`Au@PMtDiCtB_Bv@m@'
                     },
                     'start_location' : {
                        'lat' : -7.1583216,
                        'lng' : 108.1472904
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.5 km',
                        'value' : 1465
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 73
                     },
                     'end_location' : {
                        'lat' : -7.1956266,
                        'lng' : 108.185251
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Pagerageung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pizj@isgsSxAiApBeBxAgAzBkBhAaAt@q@p@o@TQDEr@s@lAmAv@y@pA{Az@mAb@s@p@oAN[Zm@Ve@LQHGRKZM`@IzAK`@AJ?R?rACxBMxBOtCSd@Cp@MbCY`@ELA'
                     },
                     'start_location' : {
                        'lat' : -7.185046199999999,
                        'lng' : 108.1786118
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '83.0 km',
                        'value' : 82958
                     },
                     'duration' : {
                        'text' : '1 hour 11 mins',
                        'value' : 4258
                     },
                     'end_location' : {
                        'lat' : -7.2998872,
                        'lng' : 108.7472946
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eRaya Raja Polah/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'tk|j@y|hsS~@KhBQz@IhAO@?jAOf@Gd@Gj@Kx@OjASfBc@ZKfA[j@UhBs@z@]fBq@hAg@t@[nBy@\\MTIBATCPAl@?f@@v@DpBXbBXtDd@zBPH@`@@XBl@@@?p@?`@AfBSx@ObCk@l@QrA]\\Kd@QNGtAs@b@ShAi@d@UVKz@a@JE^O\\OjBs@JO@CDCPGrBy@lAe@VMr@g@LMJKHIh@e@Z[NODEFG|EiFbDsDxAgBnDaEbBoBf@m@PYHUFODMD]D[@U@s@CiAA}@CcAIeGEoD?Y?S@g@D_@L]?AXk@PUp@i@PKb@UhAi@bAe@HEVK`By@r@W^ITE\\ChECzFGfAApB?|@DV@dBTh@JTDZDD@rB`@@?zBh@lA\\nAb@t@VD@tAf@@@pA^|@X~CfA`EvAD@v@ZvAh@lAb@zBz@p@VzBx@LD`@NbARD@L@B@fAZzBz@VH~@\\f@Pf@Lf@LTDt@RbATtAZt@Ph@Nb@JXHh@NhB`@fEx@jAXvAVvAXfAPLBh@Ff@Hd@Ff@FH@dDh@pBLn@@\\?Z?ZA^?r@CpAE`BGr@Ct@Cx@C`@AJAjAEF?`@A\\A`ACnBG~@CrACr@Ar@Cv@AbA?|@@nABx@@x@BX@d@@|ADzAFp@Bn@Bd@Br@@|@@dB@h@AXAL?JAJ?NAb@ClAMnDk@pBa@LCx@Qr@Mt@KNCt@O|EaAvAY`ASxCm@xFkAbHwAv@QlDa@zD[vAKlWwBfJSTALCRGHEHCpAu@nFmDnFqDHEb@WRKLIJINMLINODCDEJMLQLSJUNg@j@aB`@uAFUh@kBTq@HWJYPc@t@}A@E@An@yAd@_AJUJQXi@bAmBXg@Zo@HMx@{Ap@oA`B{Cv@wA^u@x@}Al@gA@Eh@eAf@aA\\o@BGBCp@oAx@{At@uAv@yAx@}Aj@iANSN[\\s@d@}@r@sAbAmBp@qAh@aAn@kAn@kAfA{A`@q@V_@fA_Bz@mArAcBnAaB`AsA`AqA|EsGh@o@x@iAbAoAn@}@v@cAj@s@dAuAdAyArAaBrAeB~AqB|@oAx@gA`BqB`AmAJKb@m@tAkB|@iA^e@Xa@|@mAx@cAl@y@x@gATY^m@r@iAXc@HO`@{@JUVe@h@kANe@v@yBZ}@HY^eADKPk@z@cCv@aCt@uBb@qA~CgI@EJYl@eBVw@BGrAeELc@Ro@jA_EPm@La@JYzAeFHW~BeIpB_H`ByFNk@x@oCt@eCTu@\\gAdAuDfAyDb@gBNk@DU@IF]Fs@Dm@D]R{@Pk@r@gC?A`@sB@Q?UASQs@i@sAEIGQIUEW?W?K?KD]b@mCj@kD~@gFBQ@GzCuPfCqO~BmNp@aEb@gCV_BBO^sB`@oCR_BNmANuAZmCZ}CB]Fu@Di@@k@Du@?U@}@PaHDmE@mA?cAAc@?]@a@@YDg@Hm@L}@TeAHYFWFUDWDUD]D]De@XuEh@cIBo@De@ZiD@IHqAJ_B@SNw@JaA?GFm@XaCJcBPsBFs@Bi@JaDAa@@w@A}@@aA?G@c@@c@JwBJsAXcEF{@Dm@d@gF^yCf@kDLs@RmArA_Hb@_CTwAHg@F]f@cC|DsSToAx@iE`@oBnA{Gz@kEH_@@Cd@aC?EZ{AJk@~@{EJe@FYvBwLP}@xCwPHe@`@kBd@cCvAaHz@eE^eBBQViA@G`AyDZkAxAkFZgABOTm@dDqKvAaFr@aC~@gDNs@VaAXoARu@XeA^}Ad@sBNo@^cBTkAXsANcAHu@FeANcBDaEF{DC_C?iAAiBE{D?ACwD?mA?a@A}@?EAkDGsJEcE?IEsF?O?kEA_AAwFAaD?GA}@?g@?SAiBA{A?S?yB?]?cC?SEuI?E?O@qF?I?aDAuCCmFCcD?q@AmC@y@FcHA_A?q@GmAAy@As@CsF?yB?aA?q@?W?g@?q@A{A?w@?[AuD?U?yC?gC?UKkEMiDEyACmAEcA[kHWiFIiFAk@@u@Dk@Bm@Bo@Bo@@[Be@B[D_A@ODw@Fq@Bc@P_BJu@Dg@TcBDYFc@Hg@b@{B@Kb@uBp@mDd@aCp@mDj@gDN{@RuALs@Pu@RaAT}@Rs@Pu@Pu@D[B[Bk@@m@BwABwAB[B]B]LaB^mDLkAJcATaBTyAXcBVwA~@yEDQBKNw@d@wBp@cDNw@bEmSpDoPFWXkAd@uBH_@FmABUNiDN_Cf@uG~@yLj@oHFcARwCr@uLHm@H_@Hi@La@P[L[RYR]Ve@RYZWDEFEJCVGnDk@bM{ArAMHAN@LBPDLFLDJFJFJBH@LBL?HALA`@Q|@i@fAo@NGHENEtB_@x@Oj@Qt@UZO`@U`@WxDmCj@c@h@a@^a@LQHQ@?hA_Cf@mAl@wAJUPQ^[VSjDcCVi@\\_Ap@cDTaBLgAFkAVsEL{CD_AJqABo@?aA?k@?iA?y@GmCGkBAw@EmAEy@?ICcAEk@Gg@Kk@O}AOwAOkAOkAMm@[iBCm@AW@[FyB@OHgBPsCHiBFm@L{@`AkE`@uCN}@ZwBB_@@c@AyBFwC@mAAy@Iq@QcBY{AMm@Ca@Ci@@o@DqB?wA?{@?_@?oADm@Da@J_@Pa@`@o@j@w@V_@Ra@VsACoAEkAFi@TcARgIBa@F]Rc@h@i@f@[r@[fA_@hBw@nBkA`@c@\\s@Fw@EeA]wB]}@g@uAi@uAOi@Ie@SoAcAoJAg@?aD?K@IVoC@I^cE@w@HoCF{AHy@Jw@TmATmAjA}FDcBG{AGcAMy@Ke@Mg@[o@g@q@y@y@eA}@i@o@e@q@]o@Yg@Yk@O_@Oc@Sw@G_@Es@AE@k@zBmGLg@Bc@FkAN{@Zy@pBmFP}@JkAQuJkB_KwEwOmEyMe@{@OUi@{@MM]c@[g@{@_Bk@kAm@mAy@uAu@}@SMi@_@UWMOEIGMWw@Me@i@wCCQAGAK?IASNeBh@wD\\oCDw@@_@Da@BWDIBIBIFK@IBE@IBS@E?IAE?O?IKUoAaBy@aAKQGKGMEKCIAKAI?K@IBSJQ|@}Al@kAZ{@Vy@Zu@XUBC`@M~AKpBIr@Qt@OfC_BT[Ng@F_AIiBQq@g@{ASm@sAsD@m@J{@f@gAxAwBtA_CvAaCZ}@P_@`@o@Je@]sA_@y@Sa@GQYi@GqABq@b@uBVo@DKZu@Lq@Ik@]y@sB}Ba@g@GKESO]w@y@[_@MOMQSYyBgA[QQe@EuALsCZeD^oIHeAf@gC@Kr@iCv@mCb@kA`AwAV]Ly@Fm@BYHu@Dy@J{@^w@JSBGBCFKFIFGh@_@XM^KDCXIBAJGLG\\Yp@g@LIPMLK^YX[RY`@o@@?fA}AZ]xAoAv@s@RQRQd@c@z@q@FGx@u@~BkCtD}DzC{CdA_A`Aw@^U\\OTKt@Qd@IB?bAOdAOLC~AWn@ObASb@QXOFIDEDGBGBG@G@G?G@O@s@?C@{A?[@O?C@a@B[DUBMJ_@@KBKJe@BS@SBq@?Q@IBgCA}B?gAEcD?c@AcC?mDAsBAq@A_AAy@?o@?K?I@MBM@IJc@JWZq@b@w@FKNU^_@PSLIPKPGp@U\\MLKLMb@}@JODGDEJGBAJEPEHAXCXAD?F@F@@@HDDBBFNX@HNp@RrAL`@PVNL|@b@JDF@F?F?D?DADAHARIj@UhB{@TKZOjAq@f@Of@Wz@k@f@e@VWLINKb@]NO^SLMDEBE@CVgC@KDOBOBMDKDIDGHIDCLEXAf@@bABT?T?TCREf@Mv@[Xk@N[La@L[FQFUD[B]N_BReCH}@Fu@H_AHs@NmAReA@OBQ@K?MASI[Ma@Sq@K][uAQ_A]mBIs@Ky@QsAcAeGAGQeAEWEKYo@UYKKOIIEGC[Og@UiBm@y@[k@OSIw@W_A[c@Oa@Qc@U[Qc@[m@e@{AuAa@q@aEiJqAuCQa@aAyB]}@_@aAcAaCi@qAcA{Cy@wBKWuAcEo@qBKYACSu@a@yAk@yBUgAc@wBs@gD]yAc@mBw@oDiAeFw@gDYsAq@{C}@kEm@eFOiAkAoJuBwKUkAMo@Se@KQKIIIIGUKMGMCOASC[AM?sAAwCCmCBmCBoAHkDRs@D]@IBQDODKDMFEDGFYXo@r@i@h@]PMBK@M?QAKAKCg@OQEeF_BiDcAsAa@YOMIUUMQYa@i@}@]e@KMq@_A[[MIMGAAOEMAGAGAQ?c@FODMDSF_@N}@ZYBK@K?I?Q?_@By@JO?M?O?E?C?GAEASG[IWGs@UGAICE?QCG?GAG?C?E@yBL{ALUBM@QBSDUFOBC?KBG?G@G?G?GAICEAEAWQeAq@IEIESI[MoAe@g@Q[KSKKGKGUSGEIIYW_@a@GIIIEMEMEIAGCEAGCECCEGSQKKEICICIKg@AICIEKGSKQIQGMUc@IKMMIIGEKGOESISGGCECIGMIKIMKOMIKIGS[a@i@OQMOOOMMQOOQQQa@c@Y[U[QOCCKKOKSQ[SYQ[OMEMEo@QGAGAE?G?G@E?C@G@C@E@CBEBKNKJKJMHMHOHYHWFODQ?O?SAOAKAICSG}@_@OGMEYIUGSCUEWCMCMESGSIKGUM[UUQMOKOKOGMIUQk@Mi@C[?G@s@AMCKEKIKGGMKWMOGKGMIGCEEEGCGMWSi@ISAECKAIAOAI@G@G@GBGDGBELKHIHKFGBEDIBEDOJc@Le@BO@G@K@I@UB_@?a@@oA?aC?_@?GAC?CACCGCIOU]a@GGWQEGMMCCEEAAGKGOO[M]_AaCGQ{@mBiBcEyEwKWw@Qo@EWKo@Gc@C[Ac@?sAAoA?{AHoEBmBBmAH{ADs@@IRoB\\sDFm@@_@Ao@AcAASOkCAiBCY?O?MDo@?MB[Da@Fc@Lk@Pw@Ts@JYHSPYh@o@X_@Vc@Tk@L_@H]LuAVcBPgA\\eBf@_CV}ARsAL_APmAHo@Ho@H}@ASCYE_@CWa@_CESM_AO_AEUCUCYCc@CaC?gAWsMGuAAk@?O@OF[BS@Q?WAQCOG[Y{@Mi@C]Cq@@u@DuAFgAJe@JYBGr@{AHQ`@u@f@w@v@eA\\g@n@s@pAgBxA}BXi@h@iAPc@HYBQ@OAa@Ew@AS?M@K@GDIDIHIJMZ[`@_@VSFIFKFKDK@M?OE_@C]CU?OBMHOJOLIJEVAl@AL?HANEHCDENMPOLOf@m@P]^u@L]BI@E@K?G@K?K?GAMAICMAGGWK_@kBmIWkAESAMAOAU?[@m@?_A?I?GDaK@m@?w@?gACeA?k@?M?G@a@N_BV_DNaBHu@Hq@Fg@j@iG`@}DH_Ar@gGFq@@W@KBSDg@TeCJoB?OAQCSESiA{DsA_FAE{AqG_@wAWkA_@{AUeA]cBEQ]aBAGKi@{@mDK_@EWKg@CYAMAGAi@IcEH{EDmBFaBF_AXmCFaAHo@Fe@Ho@Dg@Hc@Hc@Ja@NY^y@Xo@\\k@|@iBpAmC~@gBt@}A\\}@Z}@P}@Jq@^gCx@gGj@}CPqAPoAp@eGj@sDRoBNeBPeBdAqITcBFg@D_@NeAHq@`@wCj@}DHwABeAE_A@uFBiABg@BaB?k@?i@BuAAG?_ADuB?ODYCm@Cm@@w@A]BmBBkCBqALaC@oA?eBFwBFuBPeAf@mAf@_Bl@sBFSZ_AZcA`AyClCqITs@HWXw@\\cAxAqETo@`CiH~AiFXq@Tq@^aAbF{NRk@FSfAsE^yANu@NiA~AqMRuAN_APs@Vk@DINSRWVYX[LWJUBI@GAEACCECEKGKEYK_@KSGUEQMOMISGSAQ?OBOFKHIHILGXQRKTOTSNQTc@LWJWBK?KAMGMIMQOQKICMAoBIaAE_AEaAEQCIAKGOIGOIQAQAOAY@m@?u@@}@Bk@?OBWFs@BcACcAEsA@WBYHWnAyCx@}AjAcCLYH[DSDS?SAUEOCIGGGEMI}Ag@}Dw@WG{DcAo@Ow@ScAS]IyB]sAWaAY[KwBu@]K_@QKIIGUYw@iACGBgAXuCBWJ_ANyA@K?UAOAOCMCI[s@M[[a@yAsAqAkAk@i@k@i@MM}@_A[c@y@{AiAwB_@s@eAsBs@}@s@k@wA_AeB{A[]MMq@wAWi@]{AS}AAo@HsABW@W@CA_@iBgBeAq@eBmAeCsAcAa@{AWwQeAqJ}@m@KgCc@oCo@{@Ik@@m@D_@HiAXoCp@_CXcARkAF}CEuAGcE@aGKqCQwASk@McAWcLwD]SsKmF}CoByBaBo@[iD}AuEoCoDiC}@_A{@aAw@gAeAsAi@o@e@k@_@g@w@c@oBw@oFgBiAQ'
                     },
                     'start_location' : {
                        'lat' : -7.1956266,
                        'lng' : 108.185251
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.2 km',
                        'value' : 1249
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 118
                     },
                     'end_location' : {
                        'lat' : -7.3009989,
                        'lng' : 108.7581768
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Bhayangkara\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'hwpk@quvvSKaAEqABqDNoDL{Az@_CfAqB`@_An@iAf@gBPiB@yBIkAYqAu@uCQu@f@}N'
                     },
                     'start_location' : {
                        'lat' : -7.2998872,
                        'lng' : 108.7472946
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 254
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 26
                     },
                     'end_location' : {
                        'lat' : -7.298743999999999,
                        'lng' : 108.7585191
                     },
                     'html_instructions' : 'Take the 2nd \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Diponegoro\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f~pk@syxvScE]yBMeCW'
                     },
                     'start_location' : {
                        'lat' : -7.3009989,
                        'lng' : 108.7581768
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '21.8 km',
                        'value' : 21834
                     },
                     'duration' : {
                        'text' : '20 mins',
                        'value' : 1177
                     },
                     'end_location' : {
                        'lat' : -7.410113699999999,
                        'lng' : 108.9002393
                     },
                     'html_instructions' : 'Take the 2nd \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Diponegoro/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'bppk@w{xvSRuH?GL_D@aB@eB?eA?G?eAC{@CoAA}F?K?oDAiAKaH?m@GgG?}DIoJA]A{DEiCGuDNkKVmJ|@}FHa@x@mC`@cA`BmDDEZq@nBaDnBmDr@wAJ]@E?EIuB?QDg@PcA|@iEj@_A\\i@|@iApBwBLSLYF[FUDYHg@Fe@Hs@v@gEv@cEDMDIJWn@qAlBgDv@uAxA}Bh@{@LS^i@jB{CnAqBDCDELEPCNCrCUh@G`@G`@GLEJCBCFEJKfDgE~CaFr@aA^i@|@mA`@aABIBG?G@G@Y?q@AsA?GBOBMH[J_@xAoC~@gAfBcCjBcDdAaBv@iAtBsC|@aA~ByBrBiBz@{@tCaC@ArB{BpBiCnAsBhBuDdAoBl@kAf@s@f@o@v@aAzAgBbAkAv@s@`As@dB}@d@Wf@Wn@a@zG{D~AuAd@]hB_A\\KXIpBw@dBy@pAy@t@k@jB{Af@i@rAyBjAeBnAkBdAcBx@iAjCwDfAkAPUNQDG@?n@s@JGBA@?BA@ABADEHGxAeBbKmOvEqHPWXc@BEDIBCd@q@r@aA`IkLjAyArAaBz@_AXUp@k@jAu@h@[j@a@zAeAtA{@`EgC^U~AcAv@_@|@a@fBg@fDkApAo@nGwCfBaAjB_AxCqA?AbEaCnAw@`GeDz@a@rAq@tDcBlAq@|ByAbEwCdBiATMpCwAlAg@\\M`@Oj@S@AlCeAx@]pA{@~@w@^g@t@gAt@cAPSTW`AuAf@s@dAeB`@y@Tm@Ha@PaALkADeDKyAw@mEq@cBqAsCQa@K_@Ia@UoAKw@QcCGy@CqA@o@JoAXwA^kADGHQl@uA`BqCbAyAbA}ArA_BvAaBf@m@v@aAlBcCvEgHjAuANUlGcMxAwCbAmBvAyBdCoCpAcBzDsEnDgEn@m@x@k@p@e@f@WNIjAk@v@_@l@Uf@OZGZA^@l@DzAHdAJb@Hb@Jd@Pb@XZRn@j@h@\\RNXNLDLDF?L?JAJAh@MzCs@|DaAlBa@|EeAtGoAbFgA`DeALEHE^YVYXe@^s@^eAPo@b@mDRy@Pg@P_@Z_@fAsA~AmBhAqAtAkBv@gAZi@R_@Tk@TaAXqB?u@?k@@[?WBSHWPg@Zw@Zm@d@}@Zo@Te@RSZMd@G`@?d@?b@G\\OLMLQJQFS\\u@b@y@Vg@Ri@BMBO@_@Ac@?]?WBQBMFMJQPS\\]t@o@xBuBfAeAz@k@z@e@XQTOLSNYLWlBuCp@sAtA_CnAuBf@y@Xg@LYRe@Na@Re@l@}@h@w@fBsAt@c@r@]ZOROVWL[Pg@J[Ze@zAsBzBwB`AgAf@q@r@o@|AcAdAg@lAy@t@m@lBgBp@y@ZWVQ\\MXE\\@dAHvAT|@P~@HZ@^?ZGVMTOXYpDoEPSRMVORIPElBg@dA_@TOVQlBqB`BeC|A_BZUb@Yb@W\\OTI~Aa@dAOVCv@F'
                     },
                     'start_location' : {
                        'lat' : -7.298743999999999,
                        'lng' : 108.7585191
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.5 km',
                        'value' : 3520
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 189
                     },
                     'end_location' : {
                        'lat' : -7.4275657,
                        'lng' : 108.9247352
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Banyumas-Bandu\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'dhfl@oqtwSZkAPo@vB{D`AaCTe@rBkCv@y@nAwAz@gAj@m@~AuAt@WtBo@vBoAt@y@^a@fAoAPQr@eA@Cj@_Az@_AjAw@lCuArA_AJMbDuBd@a@PUJW\\sDNyALo@L_@Za@tA}@ZCd@EXKZ[t@eAJQf@gA\\wAHaAQmBQsBB_Ab@}CPk@f@q@~@o@j@a@T[Je@?m@M}@?m@Rq@`@q@nBwAd@c@PWHc@B{@Jc@LWnB{Bd@k@FKd@}@Xm@F]De@Ja@Ta@d@k@lBmAd@]^s@h@mB\\q@f@m@jBkA'
                     },
                     'start_location' : {
                        'lat' : -7.410113699999999,
                        'lng' : 108.9002393
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.1 km',
                        'value' : 3140
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 159
                     },
                     'end_location' : {
                        'lat' : -7.4417968,
                        'lng' : 108.9440075
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Lumbir-Bandung\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'huil@sjywSbCoBd@k@Ve@Fa@JgAFk@\\iAv@oB`@w@dCyBp@i@h@O`CGdBAp@?j@HZPd@|@\\r@b@`@TJFB^@\\KVWFW?MEs@UiAAg@TaAVg@DKdBiCDGX_@RWhA{A\\o@ZuA?GTsBViE\\qDZyBZeAFW|@cBx@oApA_Cd@iAd@iAHWL_@?ABQFaAW{BAKI}A@m@La@^e@l@_@bAWjBOLAp@GXCrC]HAZKPMNSNUJQv@sGL{@Ja@f@u@|@w@x@i@xAeAJGPO'
                     },
                     'start_location' : {
                        'lat' : -7.4275657,
                        'lng' : 108.9247352
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '18.3 km',
                        'value' : 18283
                     },
                     'duration' : {
                        'text' : '16 mins',
                        'value' : 947
                     },
                     'end_location' : {
                        'lat' : -7.5171767,
                        'lng' : 109.0561633
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Wangon/Jl. Nasional 3\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 3\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'fnll@ac}wSf@e@p@}@n@y@f@i@b@YzBiAtA}@f@m@BG@ICKCOKWWs@COAMBWNyA\\}B@Kv@uFz@cCC}AMq@Wg@s@oAKq@?{@JcGNaDD_A@kC?EMm@W_@a@Ue@Ew@Ig@_@MWA]Jg@jAoDr@cCb@aBbBcEhAuBd@u@vAyBHIJGXKz@OhBShC?p@K`@WTa@Vy@Tq@j@w@rAoAl@_@VE~A?pAYRINOLM~@qAJOJQHMDQFUBODe@@EBIDGBGHINOVQROLKHIFIDIDG@I@ILgATuB@OAKAi@AI@E?G@G@C@EBCBCTWZ_@LGLGNCNCXCd@Gt@ArAAl@CTCTITQZ[`@e@FGTYV_@LUPe@`@aA\\q@FMLQNMh@YVODE@A@ABC@C?C@G@IAGCWI_@Qw@Go@E[Ae@Fy@Ha@R]^q@pAmAj@c@pCwC|@o@BCD?DAF?l@Ab@Cl@GD?BABADCBCBEBEhBoFV_A\\s@NWJOHGTMpAu@ZMRE`AQl@GTGLGNGFIPSb@cAPa@DIBEDCFCdAo@r@g@j@k@DEBG@GBM@m@@UBGBGDEJIRS\\c@PUPQFGx@{Bx@}C\\yB?e@Bg@@O@WBU@ODMBGFMNWHMFMFSDQFc@B[BQBQH]FOZe@JMDGLONQTYDIFKDOBY@O@KBI@IBGBI@AHKLMDGTSNKJKFEBEFONe@Rk@@GJ[FI@CBELKDCBALGPAZCbA@hAFf@DVBRFJDJFJLFRF^D\\DPHPLRPVRR`@l@T^DP@N@T?\\@\\@N@H@BBB@B@@FBf@Hl@LHDFDDBBHDN@H@Z@J?R@T@T@PBV@P@RBRFTFPDFFDJDD@D@D?D?F?HALCHGTMNIJEZK`AWlB_@nAa@dAUHCPGXMJE@?LIHODOFWHQZi@TYNQDEDEROJG\\QDCPGLAH@F@D@B?B@BBBBB@BBBFHTJ\\DN@@BHFFFD@@NFRFJ@LBF?NAHAJCFCHCFGDEDIFMJ]Ji@BIVmABMF[DQFWBODO@G@K@E?EAGAM?O?I@G@GBE?ABC?AHIPO?Af@W@AZQTID?DAHAL?L?LALAPALCJCZOj@[HGJGJKBGBAFMDGBK@GBw@?_@?O@SFo@D[BEDGJMXSDCDIBG@K@M?QAUKi@AKGUCQAI?I?IDOJQJM@?NOPK\\M^IVAJAFAJA@ALGHE\\a@TWNMFGPIz@Qp@E|@ALCLCJCXMVGHA\\AT@PBRFLHJDHBN?F?f@E^EF?VCNAPEZO`@OLGt@WLELEHGBC@?FIFODOH_@H]Hc@@EBQJ]FOFG@CBCFEFEDA`AYFALKHEFIFIFEBCBCDABABA@?`@A@?PAFAH?BAB?BADCBCFGFIBIDONw@ZgAPa@NORWX]N_@JSJQRQPQNMNQDIDGFIN_@LYHIFELKLEPCPEJGLKFKDOF[BSBUBIBKDK@CBCFCHINGLCZGNGHCHEDEFIDOHOFQFMHGFENIJEJC\\CPCFCNITWNULONKNIPGb@MRAj@Q|@_@pAm@|@]dC_ARIVOLMJI^WPINGTE\\ARCPCPCTKLILINSJSFUDYBWDSFQP[PSNWNYJY?CDWB_@BWDOBIHWRo@P]LWN[BENUBCV[d@]h@Yp@QXIZIFEDEDEDGFQBM@OAKAIEWEWCO@KBMDSFMv@_AbC}CRYLWZs@Xk@JOHGPG`@MVMNMLOJOFM@OBU?S?c@A[@SDMNQJKFIDMDSBU@c@?e@BUH[Re@Xe@TYt@u@r@g@x@k@`@[d@a@TYLSXy@Jc@D[@OFq@Fk@Hm@BIDQFORY^m@Ra@DKBM@E@E@G?EAk@GyAEiACqAAA?MAQ@_@@U@UBODQP]\\]HIf@[f@[JKVc@Na@DQFW@Gb@qBF[DUHa@RcAF[VoALUP[`@a@|@q@`@]X]VQNMDCVI@?RE\\CVETGTIp@]b@Yb@a@x@w@b@k@d@o@~DoEr@k@h@i@d@_@POx@q@NKNGJCNCT?L@TDTBN@TANEVQFIz@mAZq@JWFQ@OBQ?WAW?_B@eABe@@MBKDMDMJSFOn@}@j@s@\\a@b@k@b@g@ZUHG^Sn@Yh@SjA_@hBk@|@a@rBeABAz@k@lA}@p@k@V[N_@DSDW?M?OAIEIEIEEGCMECCQAiAM}@Oq@QKC]MGC[QMGGGKOq@mAIMw@qAwEmGe@m@m@cAKSIOCM@MF]@EBEd@w@JOLUHMZ}@@EFQFWBYD{@?g@C_AEk@AW@WBUDSJS^o@DIR]DMBKDSFyA?a@B]BSd@cB@GNc@r@qBr@_C|AuELm@D_@BOn@mGH]Lc@R_@rB}BHIr@{@FIh@m@NMRSVSROTOHCj@SXEPINIDE@AJKPSBE\\i@^i@JKHGLIHCTGt@Kb@INGFCBCFEDGBGBK@I@M@I?y@@]@yA@o@@e@@mAAa@?OASEOIYK]GUWmAKi@AMEg@Aa@Ci@?i@@k@@S@]RyALcA@IRcAHe@r@wENcAF]d@yCn@_EXeB@KJi@NaARoA'
                     },
                     'start_location' : {
                        'lat' : -7.4417968,
                        'lng' : 108.9440075
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.2 km',
                        'value' : 2189
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 129
                     },
                     'end_location' : {
                        'lat' : -7.498996600000001,
                        'lng' : 109.0636427
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Raya Utara Wango\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'je{l@_`sxSiDaAa@MiDeA{Aa@_A[C?uC{@uAc@i@OwAc@gCo@[Ko@QYKMCcBe@o@Uy@QCA[IEAQG]KcBg@YM{Bm@wA_@AAcD_AuCiAiD}AsCuAwDiBc@OAAuAg@WKA?w@[]Mu@S{@UOEMCwAc@m@QCAiCm@kCq@qBa@{@Oe@EK?O?'
                     },
                     'start_location' : {
                        'lat' : -7.5171767,
                        'lng' : 109.0561633
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '10.8 km',
                        'value' : 10769
                     },
                     'duration' : {
                        'text' : '9 mins',
                        'value' : 544
                     },
                     'end_location' : {
                        'lat' : -7.408764799999998,
                        'lng' : 109.0801653
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Ajibarang-Wangon\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'vswl@wntxSe@Ho@Pc@RaCr@s@FaBPsARyEz@y@Lw@Ja@FcBRiDPeABQ@qAAQ?K?]?{BBwB?aA?s@?_@C_@Ke@MYKk@SWIqBm@wC_A{CaAICICyJ{Ee@[s@g@]UIGUMYMk@WcA]iBm@gBm@aAYAAqA_@CAgA_@q@Sm@KkAEqAEiAEK?k@Cw@IWC{AOgC]y@GQAK?gBKgAGu@EoAKGAg@Es@G{@AgCDeA@kACm@AU?g@BgAHaAHg@DiCVe@F}@Hq@JQD_@He@Ja@HI@I?O?KAGCOKIGKIOQs@u@a@e@QWSY_@g@UUOKc@USGkAg@OMMOKOSa@[o@[i@QSW[g@i@g@a@WQUQOIMGICUEICOASCM?W?m@A}@Bi@BI?cAFsADa@DI?I@c@B}@JuANiD`@E@y@FM@]BS?aCFyCDO@G?uA?kB@yBBE?wB?y@?i@@_A?O?U?aB?Y@]?iA?o@?I?yC@e@@uA?mA@}A@E?k@?E@e@?m@Am@Cc@Ao@GMAQAWEkAMOCi@GcBUyC]{AOQCeAMi@GEAWCg@EQC}@KIAa@Es@GuAME?{C[[CA?yBUQAcBKSAcBKmCUOAy@EoGSwJMe@?yABkFJqAF{@J}AZqAV}AVcALo@DwAFc@Bo@?mACmA@kA?cABaBDa@@[?AAq@C}@GQ?{@Gy@MEAaE}@o@MaAUaAYwBm@q@[OIMIKIyA_AGEQMGE{CkB{@g@CCiDqBQOMKMSGMGQMg@}@}Ek@kCg@oBMc@GSMWKOOOMIQKYM{Aa@g@QgAYi@O[E_@EoAG{@EiDKeAEsAAE?}AEYAE?i@Em@MMCUGECc@K_@IYIWGaAW]IQEYGA?WEE?a@GqCYmAKUC{@K_D]KAaAKeBSoBUs@IiCWeBQWEQAsAIoD[uAIy@IgE]'
                     },
                     'start_location' : {
                        'lat' : -7.498996600000001,
                        'lng' : 109.0636427
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '17.0 km',
                        'value' : 16957
                     },
                     'duration' : {
                        'text' : '15 mins',
                        'value' : 894
                     },
                     'end_location' : {
                        'lat' : -7.424383499999999,
                        'lng' : 109.2267926
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Ajibarang-Purwok/Jl. Bumiayu-Purwokerto\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Bumiayu-Purwokerto\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'v_fl@avwxSHo@JgAZeDJ_ADe@Bo@?WAOCOCIWWa@Y[OsAu@GCqEmCSOQMOSMQKSu@{BY{@aAaEc@kBI]AMI]o@}CCKeAoFsBmKY}AQ_Ak@aDCQMq@Ke@Ic@u@_EQ}@i@sCkAsGi@uCa@yBM{@i@iDsDyUIi@EYUuACKWgBCMKo@aB_Mu@qFAGc@}CyAaK[}BYyBMeACQoAcJWgBYiBGc@COmAkIQiAGa@EYC[AWA[B{AlAsILu@b@_C@In@aDZ{ALi@Jc@Lc@j@oCp@yC@EF[t@cDPo@?ET_ANk@Jc@R_APw@Ji@DYBW@UBm@?i@DeC@m@B{BBiA?[?Y?K@G?G?A@KBSFa@DYDSH]H_@Jc@Jc@No@Ja@h@mBRw@DM`@oAbC{HVw@L_@l@gB\\eAn@mB^cABIb@iA~AiEb@iAlAgDBI@CFQZ_A@CFUXcA`@wAbCsK`AgEDQj@iCBILo@Ns@XiAjAsEFQ@IPi@hAuD`@{AnA{Ep@yB`CsHNa@vAeEd@sAHU@EjEqOLc@|AsGjA_Fh@sBZsA\\cBNy@Je@Fa@|AqJFg@r@wEfBgM^eCfA_HRoAPiALqAJiB@eABu@DyBHyCPgIDqB@c@@WFw@Jk@VcAp@uBbB_FVs@La@BO@IFs@DsAHwBBi@\\aI@Y@MDg@Hs@Lo@Ls@Pm@b@iA`AeCL[d@mADI~@_C@EBGTk@HS~@}BNc@Xu@VcATcA@MD]Fo@T{CLaBFi@LmBDi@?WCUGWMa@qAmC]y@]mAIc@ES?YFiBHuCD_@HUHMXi@l@aAl@cAzBsFNm@^}ARu@P}@DSPiALiAFq@^uFLcBD]TqDP_CEO?CDk@b@yFZyDf@sGL}AJuAJ}AJqAl@qHPwBT{CZeEd@sG@IHO@K@INiAVgDNcBb@iDF]NmAj@{DVkBZ{ATeBL{BBe@FgCFiC@SDyB@q@?kC?c@?W@{@HyBF_ALwAF}@TqBB]LsAp@_E'
                     },
                     'start_location' : {
                        'lat' : -7.408764799999998,
                        'lng' : 109.0801653
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.9 km',
                        'value' : 1915
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 99
                     },
                     'end_location' : {
                        'lat' : -7.427810399999999,
                        'lng' : 109.2437068
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Ajibarang - Secang/Jl. Jenderal Sudirman Barat\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jail@mjtySXiB\\wCn@cFFaAVqBTkBViBp@kE`@wCRcAPy@rAmG?AbA}Ed@wBjAeGb@iCf@mCd@kCDa@BS?a@@a@A}ECmBAmBAaD'
                     },
                     'start_location' : {
                        'lat' : -7.424383499999999,
                        'lng' : 109.2267926
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 338
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 51
                     },
                     'end_location' : {
                        'lat' : -7.430838699999999,
                        'lng' : 109.2437841
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. S. Parman\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'xvil@etwyStB?bCAN?xBAhA?zBARG'
                     },
                     'start_location' : {
                        'lat' : -7.427810399999999,
                        'lng' : 109.2437068
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.4 km',
                        'value' : 371
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 36
                     },
                     'end_location' : {
                        'lat' : -7.430901700000001,
                        'lng' : 109.2471452
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'vijl@stwySAaE?gDA_A@k@Bq@HyC'
                     },
                     'start_location' : {
                        'lat' : -7.430838699999999,
                        'lng' : 109.2437841
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '40 m',
                        'value' : 40
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 16
                     },
                     'end_location' : {
                        'lat' : -7.431263599999999,
                        'lng' : 109.2471149
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eright\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'bjjl@uixySfAF'
                     },
                     'start_location' : {
                        'lat' : -7.430901700000001,
                        'lng' : 109.2471452
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '87 m',
                        'value' : 87
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 18
                     },
                     'end_location' : {
                        'lat' : -7.431286500000001,
                        'lng' : 109.2478997
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'jljl@mixySBi@BaAAQ?_@'
                     },
                     'start_location' : {
                        'lat' : -7.431263599999999,
                        'lng' : 109.2471149
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '11 m',
                        'value' : 11
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 8
                     },
                     'end_location' : {
                        'lat' : -7.4313873,
                        'lng' : 109.2479051
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eDestination will be on the right\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'pljl@knxySRA'
                     },
                     'start_location' : {
                        'lat' : -7.431286500000001,
                        'lng' : 109.2478997
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '133 km',
                  'value' : 132842
               },
               'duration' : {
                  'text' : '2 hours 6 mins',
                  'value' : 7548
               },
               'end_address' : 'Temanggung, Central Java, Indonesia',
               'end_location' : {
                  'lat' : -7.2988097,
                  'lng' : 110.1688913
               },
               'start_address' : 'Purwokerto, Banyumas, Central Java, Indonesia',
               'start_location' : {
                  'lat' : -7.4313873,
                  'lng' : 109.2479051
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '52 m',
                        'value' : 52
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 14
                     },
                     'end_location' : {
                        'lat' : -7.430924099999999,
                        'lng' : 109.2478803
                     },
                     'html_instructions' : 'Head \u003cb\u003enorth\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'dmjl@mnxySS@iAB'
                     },
                     'start_location' : {
                        'lat' : -7.4313873,
                        'lng' : 109.2479051
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.9 km',
                        'value' : 853
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 102
                     },
                     'end_location' : {
                        'lat' : -7.429977799999999,
                        'lng' : 109.2555431
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e toward \u003cb\u003eJl. Ajibarang - Secang/Jl. Jenderal Sudirman Barat/Jl. Nasional 9\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'fjjl@gnxyS?A@}@?[CmAO}BC_AEmBCoAG_AMaBK}Bm@cHAYO{Am@_GK['
                     },
                     'start_location' : {
                        'lat' : -7.430924099999999,
                        'lng' : 109.2478803
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4.8 km',
                        'value' : 4770
                     },
                     'duration' : {
                        'text' : '6 mins',
                        'value' : 336
                     },
                     'end_location' : {
                        'lat' : -7.45768,
                        'lng' : 109.287409
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Ajibarang - Secang/Jl. Jenderal Sudirman Barat/Jl. Nasional 9\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 9\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eGo through 2 roundabouts\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'jdjl@c~yySt@u@vAsAXW`DwC^]nCkC|@y@X[JIjAgAjCmCb@a@z@w@h@e@TWp@m@JMbB_BBEf@e@|BwBTWTSZQFC@IHCPG?A?A?A?C?A?A@A@C?A@??A@A?A@?@A?A@?@A@?@A@?@?@A@?F[Jm@Fk@Bw@JyBHmAB]@ODk@\\gDBMVgAJ]Vw@J]BG|@iCZaAAA?AAA?AAA?A?A?AAA?A?A?A@A?A?A?A@A?A@A?A@?@A@A@A@A@?@?@A@?@?@?@?@?@?B?NM`Ay@@AJC^a@JIrD}Dl@k@RSDELM\\_@lAuAFG\\]tAwAVWxB_Cx@y@p@o@^]b@c@\\e@h@i@~@aA|A_BLOnEsEfCoCvCuCX]Z[f@g@@Aj@k@tAwANQj@m@d@g@VYbBmBf@g@FIdAgArAsApAqAdAgAf@k@JKfAeAd@g@NMhAiA^a@j@m@`@a@TYVWTWb@a@l@o@NO^_@f@g@n@q@\\_@DEn@s@h@i@jBmBHKjAkAJKhAoAd@c@xA}A|AwALW'
                     },
                     'start_location' : {
                        'lat' : -7.429977799999999,
                        'lng' : 109.2555431
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.3 km',
                        'value' : 1260
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 65
                     },
                     'end_location' : {
                        'lat' : -7.457699499999999,
                        'lng' : 109.2988001
                     },
                     'html_instructions' : 'Slight \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Jendral Sudirman\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'nqol@ie`zS?IAkA@kB?e@KmFAwA?IG_HAaAEqFE{DA_CAc@?o@A[Aa@C_EAe@CqA?i@?k@Dq@NkAb@_C'
                     },
                     'start_location' : {
                        'lat' : -7.45768,
                        'lng' : 109.287409
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.3 km',
                        'value' : 1323
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 96
                     },
                     'end_location' : {
                        'lat' : -7.469541,
                        'lng' : 109.299866
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Kalibagor Sokara\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'rqol@olbzS`GE`DEzAAJAnCI`AE`ACh@Cx@E~AI|AKXAd@CbCOrAK~@Ch@A`AELAL?XCpAG\\AfAGr@G~@GZCv@GrCSpAEXC^CNAf@Ej@E'
                     },
                     'start_location' : {
                        'lat' : -7.457699499999999,
                        'lng' : 109.2988001
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '4.5 km',
                        'value' : 4493
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 228
                     },
                     'end_location' : {
                        'lat' : -7.506796199999999,
                        'lng' : 109.296195
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Kalibagor-Banyumas\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'r{ql@esbzSr@EzDQpAEx@E`AAVAfDK^Ch@Aj@CnBGv@Cd@ApBELA\\Cn@A?A`@?T?T?j@@b@?j@DZ@H?NBL@PBbBTzAT~@Lz@JB?H@t@FD@jAFb@DnADbBHb@BD?vCJL@tAFzALp@DVB`AFXBb@BVBT@TFJBLDPJPNx@t@RTv@j@l@h@TP^Xj@^`@PNDLBD@D@PBlBRh@F\\D`@Ad@Ax@I~AMPAlBIH?jAGx@M|@GNCB?pAGJ?TA~AE`BCF?RGDAJEVS`Aq@r@e@XQTMJEJABAZG@?b@Kj@KTCRENEPGHEJIJKRUR[Zg@V_@JMLKRMJCJCZEn@GjAKd@G\\I`AW`@M^KnBWn@Cj@CrAEPARAjAEn@C`A?h@?jAPDBrAj@DBVLrAt@fAf@LHdARXDX@VB^JRFNDNHTPTZLVJV`@lAd@tAd@`@|@t@xApAr@`@HDRFtBt@JDdBp@|An@VJVHPDR@lDF'
                     },
                     'start_location' : {
                        'lat' : -7.469541,
                        'lng' : 109.299866
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.4 km',
                        'value' : 2420
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 187
                     },
                     'end_location' : {
                        'lat' : -7.5284303,
                        'lng' : 109.2960834
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Gatot Subroto\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ndyl@g|azSzE?pNDnC@fC@f@?~C@jBAV?rA@xA@jC?`@?hA?pA?b@?~@?t@?R?d@@r@@ZDF@H@pB\\~B`@J?t@LJ@`@DL@^@z@@fBIv@Ev@G\\Cx@CRA|BIP?LAP@bCJZ@`@@`@?XCTA`@E~B_@xAWPE@?@?DAF?DAF?F?F?z@BbCL\\@F?D?p@EJAH?V?bAFJ?L?d@Ax@EhBA'
                     },
                     'start_location' : {
                        'lat' : -7.506796199999999,
                        'lng' : 109.296195
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '9.0 km',
                        'value' : 8954
                     },
                     'duration' : {
                        'text' : '8 mins',
                        'value' : 481
                     },
                     'end_location' : {
                        'lat' : -7.5036462,
                        'lng' : 109.3714725
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Ajibarang - Secang/Jl. Banyumas-Banjarnegara\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Banyumas-Banjarnegara\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'tk}l@o{azSByEBaFBqF@k@@_ABwFFaL@cIBm@@mB@}B?cCAqDAkAEi@AIAKAEAGAGIQSg@GSCGCKCIAGEUG_@U{AG[CGAC?CACCEEKCECCEGk@o@eBiBEEEGCGEGAGCIAGAI?O?wD@aE@wA?mBBkA@c@JyBHiABo@?S@E?M?[?WAWAYAc@G}@]oDEs@Ec@Ge@EYE_@Qu@[oA_@yAsAqFKc@I_@e@gBU_Ac@iBWkAa@uB[eBS_AMg@COIWCGACKYc@}AIWOc@oA{DOc@Oa@IWc@mAYq@Wk@q@{A]y@w@gBUe@i@kAqBcEQ_@ISsD_JCEuDwH{CuFe@{@aCmEm@gAUa@yAmCm@mAeCqFgA_CSc@Yi@g@{@u@iAGK{CgFi@}@iBaDsBwDw@yAk@cAQa@MYEMIWI[Kg@u@aEUwAKg@i@cCIe@Qy@a@mBk@cCsBiH_A{Cm@oBIYqAaFo@wCEQm@wCq@cDgAwFw@qDQy@k@eC_@iBcA_FcA{EOi@GUI_@kAaEEK}@}CcBcGsAqEqBkGaB_EIQeBqD'
                     },
                     'start_location' : {
                        'lat' : -7.5284303,
                        'lng' : 109.2960834
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '13.1 km',
                        'value' : 13071
                     },
                     'duration' : {
                        'text' : '11 mins',
                        'value' : 657
                     },
                     'end_location' : {
                        'lat' : -7.452364299999999,
                        'lng' : 109.4666315
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eRaya Susukan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'xpxl@urpzS[m@_@y@gAyBo@mAg@iAqCaG_C_Fc@{@m@oAmAiCSc@qA_Cq@iAk@eA_@s@_@w@IQGYCICMCUAQAS?YAw@?cB?ICeCCyCIuCGcBEgBC]AQCQAG?GAES{@Y}@Ws@I[Sq@CG[iA[}Ag@oC_@eCCQUsAo@aFi@kE[wCY{Ba@yCKo@WyB?EYiCs@oHIq@?KGk@Gi@OiACMIi@c@mCKu@UyAKq@]mCCOQuAAGQeAESKg@Ke@Uw@Yq@Se@Wi@IMKQY]e@k@wAuAaHyFUYSYCE]k@Yc@a@}@Sa@c@iACEg@oAm@eBa@oAQm@Qq@I_@QaAKw@Ku@E}@Cw@AgAE}AEaAE]Mq@Mu@Ms@Sw@Wu@GQc@mAg@sA[aAgAiDSu@EO_@}AUaAWkAa@gBQu@GUEQYaAWs@g@oACEOa@u@oBYw@k@wAy@sBw@yAgAuBIOSa@u@gAKQo@_A_@o@{AyB}HiL_@g@SUMKSOa@SqAe@}@[_Bk@YOKIIMCM?UD]Ls@^aBLk@B[?I?OCOEMGOSYY[IGQQ[SMGKCKAO?S?C?M@qDZI?I?GAMCQGuAg@i@SSIMEOE_@K]EwBYGAiCSiCOi@CaCMyEYi@Cy@EcAE}@G[CeCIQAYCc@CyCQWCW?m@Ce@CSAq@GI?qAIkEUQAo@G{CSYAOAq@EmBMa@Ce@Ea@CsE]UEYIMEEC[MWSa@YYYIIY]Q[GQGOU}@Mi@g@yBgA_F[aBKg@EQqBwIKm@i@iCS_AAAScAOm@EQOw@m@sCYsAI[AIm@{Ck@eCUeA}@mEAG[iB{BsLQ_AS}@o@gDYwAWsAs@wDOu@Ke@e@{BIa@_@kBw@sDg@mCQw@?CS_AOu@i@mCaAaFUeAOs@Ke@c@}B_@wBKo@c@}B[}Am@aDO{@k@{Cm@_D]qB_@iBaAqFe@}Be@eCg@iCCO{A_I'
                     },
                     'start_location' : {
                        'lat' : -7.5036462,
                        'lng' : 109.3714725
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '25.3 km',
                        'value' : 25290
                     },
                     'duration' : {
                        'text' : '21 mins',
                        'value' : 1280
                     },
                     'end_location' : {
                        'lat' : -7.3996755,
                        'lng' : 109.6795284
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Ajibarang - Secang\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'fpnl@mec{SaA_F{@oEs@{Dg@oCa@sBs@}Ds@iEUcBAGKkAGs@Ck@I{AUuEEg@KqB]}GOwCEw@MuBCg@AS?O?E?i@?[?W@W?I?EFuAD{@@W@YJ_BHqAP}BFq@?GR{B?KLaBD[N_BXmD`@mF^}Fn@cJz@_LJqAVqD@KBi@B]TmHNcGJgEBu@TiJN{FF_DDiCDgCFeE\\qQ@{@ZySFyDLoHFuKB_BDiDBwBHsG@_A@w@BaAB}BF{D@Q@yB@_B?E?S@k@?o@@yA?IAqAAY?GC{@Ao@Ce@Aa@Cc@AQEcA?AIsAGg@Oi@EQGSg@eA[m@KWuBmEA?qAqC_BiDgBiDMUw@yA_@}@m@kAqAmCcBgDg@eAAEi@eAmDkHOYa@{@]s@Ui@wAyCWg@oAcDmAkDUk@oBoF?AeByEi@{A[y@c@kAUo@sBwFi@{AiA{CUm@y@wBiAkBWa@S[_CmFqH{Qu@wBISKYiAyCe@oAi@wAWo@q@kBUo@k@{Ae@mAACe@gAQi@eAsCy@qBM[Ws@Qi@g@uAa@iAaAkCSk@s@wBg@oAEOuAqEgBcF_A{CISs@mBEKCEGOq@{A_@{@Qa@Se@wAiDQa@a@}@}@wB[s@ACkAmCYm@Wg@a@}@[u@mAmCUm@GOYs@Qa@Yo@q@gB_@y@iCaG[{@c@aAISuAeDM[e@eA]{@OYKYg@sAWo@Sg@{AqDEMyBqFk@{AUi@aAeC{@uBc@gAq@iBsAmDg@uAUq@KYa@gAe@uAe@mAq@oB]eAe@sAk@yAGQsAuDAAUo@a@gAQi@Oe@M[M_@IS?AGQGOGMGOIQIMIOIOQUY]QQQOGGIIWUYUsA_AqA}@iBoAsCoBCCy@k@mA{@u@k@u@m@}@o@aBmAMM}D}CKIYU{@o@g@_@sAgAm@g@CA][k@g@CCuAoACCk@m@e@e@yA{Aq@g@g@]UQsAaAOKIKMIk@a@[SECSMSKMKOMIIa@c@e@g@CCKMOO[YWWUUQSMMIIKMKKAAGIIOIMEMO_@K[Ws@IUSo@KU{@{Bo@kB]}@_@cAg@oA?Cc@kAqAaDc@gA_@}@uCmI_@cAkEkMmCaIuCiIQg@gAgDSs@y@uC[gASy@Ka@G]Ge@Iq@QeBG{@CUGq@?GI}AEm@EkAEqA?CGiBGoAEaAMaBOmB?EC[Go@c@uDSuBCWIw@Q}AAMCOIu@UcBSmAYsAQs@WaA[aAe@yAw@uB_@gAYw@So@Qm@U}@[oACGScAUkA]eCEc@Ga@?AACAMWaCUyBAKSyBUcCCQGy@Gs@QwBAIIqA?IGoAC[?KASAc@Co@?G?]?EA_C?E?M?EA}BDmBF}ABaAFeA`@}DLyADg@Do@De@BMB]D_@ZcDH{@Fi@BMDm@XcDFy@H_ADk@JuAFaA@]NoCDmADkA?G?GPoFF_D@_A?_A?uABeB@IJmBHeCDu@LuDNiG@a@?W@g@@c@C_@?ICUIq@MeAQoAIs@Gu@Ec@A[?c@?C@o@DqA@UHoCB_ADgBHeDFyB@gB?IBo@@{@D_ADaAH{ADwAB_BBaA@O?ADmA@Ub@oIDkA@[Bk@Fo@HeBNiDFkABm@RsFRkD`@}F\\_KD}APqE@M?GBU@S?y@'
                     },
                     'start_location' : {
                        'lat' : -7.452364299999999,
                        'lng' : 109.4666315
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.1 km',
                        'value' : 1146
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 57
                     },
                     'end_location' : {
                        'lat' : -7.399016899999999,
                        'lng' : 109.6898525
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Letjend. Suprapto\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~fdl@axl|SAILmBFeAFiDJ{BBaDCcBS}CEyAMgCEeAK{Aq@sICYKqAS_C[cE'
                     },
                     'start_location' : {
                        'lat' : -7.3996755,
                        'lng' : 109.6795284
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 488
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 27
                     },
                     'end_location' : {
                        'lat' : -7.397088999999999,
                        'lng' : 109.6929351
                     },
                     'html_instructions' : 'Continue straight onto \u003cb\u003eJl. Mayjend. Panjaitan\u003c/b\u003e',
                     'maneuver' : 'straight',
                     'polyline' : {
                        'points' : 'zbdl@qxn|SW_DGk@?ASaBQaBU}AAKQ_ACKEKEICCGEMCGAO?i@@wA@mA?'
                     },
                     'start_location' : {
                        'lat' : -7.399016899999999,
                        'lng' : 109.6898525
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.9 km',
                        'value' : 886
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 70
                     },
                     'end_location' : {
                        'lat' : -7.396425700000001,
                        'lng' : 109.7009335
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Pemuda\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'xvcl@{ko|SEmAG{E?CAwB?MAMIyBAm@?GKoBE{@IgBKuBAc@K{ACe@C}@MgBGgAGeA?AGkAAY'
                     },
                     'start_location' : {
                        'lat' : -7.397088999999999,
                        'lng' : 109.6929351
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '28.5 km',
                        'value' : 28473
                     },
                     'duration' : {
                        'text' : '24 mins',
                        'value' : 1469
                     },
                     'end_location' : {
                        'lat' : -7.364203900000001,
                        'lng' : 109.9019747
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Ajibarang - Secang/Jl. Letjend S. Parman\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Ajibarang - Secang\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'trcl@y}p|SAKEU_@eB_@aAYgAu@_DS{@Ka@Sg@]}@Yc@MQQ_@Ua@O_@Yo@U{@Us@Ko@g@_CW_Aa@qBa@gBy@uDa@iBaAcF]cBc@{BGg@M}@K{@O_ACOS}BCw@CWMaCASEw@@OBQBIJUDGX]Xg@?MQsD@MCe@CUCQGWK_@IUSc@IOKUOc@Oe@EUKc@Gc@K_ADgCN{BFmALaJHoCDqADsAPiGFmED{BJeGJeF?]EuCMaCEwEMeEYgFo@aJMaB_@}EUkGEcAIyK?C?U@{A?S?Q?AAw@@cAFu@?CBg@d@{EFqA@Ub@wI@eC?OJcFJeEAcBCw@]yC_@mEMwDCe@Co@IiBEoACg@CcA?a@ASC{@?c@DaEDmCCyAAe@Ag@Ca@C_@?a@?g@BQFQ@CLW`@y@`AaCx@qAl@y@NWH_@b@gCZoALi@L[FMJMFCJA`AIZCNALEJIHKDMD[BOBQp@{ENe@La@ZgAN[PY`AoAdB}B~AgClAiBx@mAjCoDN[HSn@m@^e@r@eAhAoBl@iAfAwBtBkDR[TSf@e@FI\\q@Je@NmAj@sEHg@BODSJe@Po@DUDO@GB]@IBIBKDEDGDG^[|BmCh@q@n@q@jAwAn@{@PUNMVSRKl@[TG?Aj@EV?TERELCRIt@e@l@]\\WZYh@k@XUNGLEPGjA]LEDGDGHKFOFMFOFYHWFS@IBQDmABwAH{C@OBK@GJYXa@NUHMJUJYNk@H[DW@G?G@G?E@EDWDOh@gBd@aCPk@J[BKDKHSZo@hAuAz@oAPUlAsBlAuB`A{Ar@cAX_@XUj@i@PMRSX[PY^k@f@s@T[LMHIJG`@KhAYVKRKXSXYPWP[FMBKDOBM@O@CBYBa@Be@?S?KAGAGCKGSe@sA_@w@q@mAKOSYSk@IQESSyAWiAs@wCg@mDAO?_@DaB?MH{ADg@Hg@Pu@FSRk@HULa@Le@H[HSHYP]N]JUDKBG?G?E?EAECKAGEGGSGQCKAGCKAKAKAK?M?I@O@O@OBUJi@^yBLq@DSFQ\\kAXu@\\y@Pc@LYBKDOBMBs@@]LqCJwA?IDu@B[@GBQDQFQTm@p@eBNc@Pg@H]FUD]Fg@Fm@Bm@D[Dk@D_@PeBP}ABS`@mDF]Fe@Da@RsATsALy@H_@DWLq@^}BLs@PeALq@ZmBF[DQ@GHWPa@Rg@Zu@Xs@PYDGRWf@o@j@q@\\[tA}Ah@i@fAcAdAaAnBcBvCcCpAmAlAgAJKZ[V[RULKXQNMFGFKFKNi@l@sBXcALc@BSBOB[Ba@?Y@aA?i@Aa@AWKeAK}@Ca@Ae@Ae@@e@?g@B]Ds@De@D]VqBd@{C\\{BNy@L_AL_ABQ?S?WAWIc@Ik@Mq@EWAGAICQMuACMEk@AEG}@MaBCUC[ASCYAc@?YBa@@e@Ds@Du@Du@RqBJoA@GBQVgBFe@TyARaB@EB]Ba@N}CHaBNgCF}ABa@HgA?AH}@Fw@FaA@QF}@JiAJqAP{BRwBX_DHcAZuC?Cf@cEf@aEDa@Ly@Hi@Fc@PqAR{AV{BHyABq@@i@@g@EiAEwAA}@C{ACqAAk@Es@Ei@KoAQaBKy@CQYuBUiBa@oCi@sC]{CEq@EYA}@?Y?W@a@?EBIJq@L]L[Vk@b@aA\\w@`@gA`@{@Rc@HSHQXw@VcBTaCHaA@W?G?GAEAEAGAECIGGMWUk@MWOg@Gc@?W@IBODg@D_AAi@GaA@u@Fe@Z}@J_@F]De@?i@ByBFcADy@@U?EAEEMCKEIMY_@o@Y[KSIOEKCKCUSq@i@mAa@m@[e@w@iAc@q@q@y@OSSQIMEGCEAGAI@UQsAKaAMaAKg@O]AAGIMGECIEOGUIIGCEEEAAAGCGGa@ESGYGUAGGIGIGEIEKEGAIAKAU@iACi@EMAOGKEGCGGGCEEKGIIEEIIKQIOEMGYISEKCOGUGQEIIKUQw@g@a@Sw@_@aAi@GCm@_@KKGKEGCGEQ?I?GD_A@GDc@DYNi@JYLYBCHKRSLQFMBG@I@K?O?KAQ[}@g@{Ac@yAc@yAUy@So@AACGUa@e@w@_@k@IKEEGEMEmAWAAmAQcAQs@Ii@?c@?KAc@Ak@G_@Iy@QqASQCmA]WIi@OwA_@WGcAYOEg@Mm@O[KSIa@MCAiA]g@O]MsBu@gAWECk@Sk@UCAA?CAE?EAE?U?q@g@QIeCeAk@Uo@Q[KYK_@K]Ik@KOEg@Me@IYGWEQCG?IAm@Ks@Kk@Io@Oq@Mk@M]I_@IUGOEo@SaAWa@M}@UQEc@Mo@Q{@U_@Kk@OuA[wAYcAUw@QgAYWGMEa@Kg@Ke@Ko@OAAo@Ou@OkAYA?WGSEy@S[ImAYA?iAYk@OoA[g@O[Gc@Oa@KSEICSEw@SmA_@s@Uc@Og@Sm@[q@[KEYO_Aa@AAeAc@eA_@w@[AAi@Us@W]MMGOG}Ao@CA[M_DmAUKoBw@GC]MmA_@CAYKaBc@{@UcASqA[yAWKCeASw@Qk@Ow@Uw@SwCs@_H}AgBe@[?mA[{JkC_Ba@qBi@]IsBi@GAkA[m@O_@KCAuFwAmCo@kDy@SEiIsBKKg@MGAOCmDi@_AKaAMuBW[E{@KmC]}@KmCYaEe@q@IqAO}C]aCYaEc@'
                     },
                     'start_location' : {
                        'lat' : -7.396425700000001,
                        'lng' : 109.7009335
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.0 km',
                        'value' : 2029
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 141
                     },
                     'end_location' : {
                        'lat' : -7.363246,
                        'lng' : 109.9158131
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. S. Parman\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'fi}k@ifx}S@eCA[CQGSQs@S_@MUGKIGKGs@WoCy@KAKAK?IAM?a@CGAEAECA?ECIGGG{@{@IM?AIQMKUa@Qa@K]Ia@I_@OgAGm@O_B\\_H@[@Y?_@AKAKAEAEEEECCCAA[OECAAGCGGECEEEGCEACGICGEMEKAK?KBW@IHO@CLSJU\\o@?ADIFS\\}@?ARi@J[?CBELe@Li@@Ax@_DNg@j@oB@EBO@M?M@S?QCSCQMq@O}@a@}A?I?K?OBK@GRs@DQDKDKFMHQBGBK?G?EAGAECCCGEEEIGGEIGIAEAE?C?C?C?C@E?ABC@CBADADAFAF?J@F@F@DBxBzATJFBD@F?f@G'
                     },
                     'start_location' : {
                        'lat' : -7.364203900000001,
                        'lng' : 109.9019747
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '6.1 km',
                        'value' : 6127
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 329
                     },
                     'end_location' : {
                        'lat' : -7.389133699999999,
                        'lng' : 109.9636507
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Ajibarang - Secang/Jl. Kreteg-Wonosobo\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Kreteg-Wonosobo\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'hc}k@y|z}SLKt@y@BCLOp@w@HMj@{@n@iABE~@sB?C`@{@Rk@FODM@K@O@_@Aa@?YAUMgAAY?]@Q@[F_@`AoE@GPw@H_@XqA\\qAJc@L_@l@kBh@sAHUJUFQJYn@aB^eAb@cADIP]HMP[JQb@u@Zi@d@q@vAcCBCTc@HMDGP_@d@eAd@oAHQh@yAV}@J[RkAN{@@C`@eBNu@R{@ZyA\\aB@KJa@v@qDNm@He@j@oC`@uBl@cCXgAbBeGPm@~AkFFOZiAFQVu@?ARe@P[v@uAz@wAT]RWFGl@o@bAaAx@u@h@k@PYDEZ}@Rm@Je@Ju@?ALw@L}@\\cBb@{ABGDOx@kCxCwH`@aAh@{AFOb@wALi@d@aBBKV{@J_@J]JYP[LQz@uA^g@nB{Cj@eAtBiDxAaCt@oAfAoB`@u@Ve@fAsB@AHOHQbA{ARYJOX]d@g@BCh@c@b@[DETOXUNK\\Sl@_@XO@ArBqABAz@w@h@g@x@w@?An@s@@A^k@zA}B?A~@}Av@_B`@y@DIx@oAPSp@_AX_@hAwALOdBuB'
                     },
                     'start_location' : {
                        'lat' : -7.363246,
                        'lng' : 109.9158131
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '20.6 km',
                        'value' : 20648
                     },
                     'duration' : {
                        'text' : '20 mins',
                        'value' : 1193
                     },
                     'end_location' : {
                        'lat' : -7.285859999999999,
                        'lng' : 110.0976114
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Ajibarang - Secang/Jl. Raya Parakan\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Ajibarang - Secang\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '`ebl@ygd~So@mBCIcAkBgAcBu@_Ag@m@[_@k@q@GGGGw@{@a@e@q@m@sAeAaAu@sA}@s@m@g@_@GE[YyAsAwCiCA?WSu@i@[Uo@a@OMqCiBa@]yA_AkCgBcAs@QMq@g@c@a@_@]]e@GIIGGCIEIE]Ma@SA?UMCA[UII_@_@QWQSQOOKWM{@]g@YgAu@}@q@GEEE]Y]]][kAkAyA{A][SWcBiBMMWWcAeAs@u@WYMKAAwAwAq@m@CEuAqAUU_A}@sAaAw@i@u@g@SOMICA_D}Bu@e@mBoAoDyBwA_Au@g@aBeAECAAoAu@UM]OAAICc@M}Ag@OGWIi@QaA]YQOKSQMKKIg@_@QOy@u@KIYWeDsCmBcBs@y@KMaAgAaAkAq@u@CCCECGEKAKGe@KqAC]YkCCGeC_K{AwFm@oBi@eBSq@]gAkAcDqBcFg@cAgB}D]{@S_@eAyB]{@qBsEe@cAWk@eBqDsCcF{@qAKOsBqDIMq@sAgA_Ca@y@_@q@k@q@{@m@u@g@SMKEICICIAKAQCKCMCKEGICGAIAI@K@I@EDGFIDGDEHCJCLAR?PAP?HCHAHEDEHIDGJOBG@MBOBUBQCM_@_Bg@yBa@kBUiA[_BKy@q@uDASOk@KWEIIKKKQM_@YQKKIMKOOIMIKEICGCGAGAG?G?G@E@GBEDGDEDCDCJEJERIHEJIPMJMZa@t@iEN}@TmAHi@Ba@FaAB}@?}ACWQuBMwAK{@Ig@EOKYY{@k@}A_@y@Uk@Ue@s@_B}@kCu@_Cg@wAUk@KUe@}@}@}AEGw@uAEGU]c@q@qA_Cg@y@}@qAaAiAe@m@w@}@a@m@iAsAIKcAmA]c@gBoBgD}Co@k@cCsBECeEoDyDyDiAgAyA}A_EiEuCoCk@k@qBcBkAaAaAs@uAaAa@[u@i@aAs@s@g@wByAs@g@iAy@GGCEEECICIAMAICs@EiA?[Cy@AMCYAKCGCGCEACGECAECCAC?EAC?C@C?C?C?EBMFYN_@LSBKBK@O@W?y@Ac@AS@G@I@K@MBK@G?G?SCMEKGGCIIGGGKCKEKCM?K?M?OBMLi@BG@IBM@IBK?I@K?K?KAGASGeAEo@Is@Ms@CKCEAECACEECECGCECIEC?i@Ou@OEAECGCCACCCCCEEECCAEIOMq@Ka@I]a@gBY_A?CGSISKSSWa@]YQkAs@c@YQKMGEAEAE?GAI?e@?W?k@@Q?KCMCMEWKe@USCG?E@E?EBE@IBGDEBEDGHGFEDGFGBKDC@_@Lk@Pe@JIBE?E?A?C?CAMCKCOGQEGEQGMIGGGGIO_@o@Q[U]OOIIGEAAGCGAGAG?G?I?G?I?E?KAC?GCEAEEEECECEAGAMAO?O@[?U@WAa@AMAKAICIEIEGGKGIIIAACAA?E?A?E?C@A@C@ABABAFEPGb@CPCJCHCFEFC@IDG@I?KAKAKAICIEIIU]Q[KYCKCMAMAMGOEKEGGGECOIYIICGCECGEGECCCECEEGAKCQAc@?MAIAGCECGGIGEGEEEIEKCICKCGAKCEAGEIGYQYUo@YiDwAGCg@W[O_@S_@SYKw@Uu@[GCi@UGCc@QQC{@IOAi@A{@Eq@EEAEAA?AAAAAAAAAC?A@E?E?I?I@G@KCIQq@a@_AO_@Um@_A_Bg@oAa@}@Yy@U_@CKEIEYCU?AEg@@k@Fa@@]Di@@Y?ABU@UAi@A]ESGo@Qy@O]CGEMCIGKACCIEMCICGGIEEGCGAE?EAI@E?EBEBGFCJCHGNEHEFA@CDGFCFIFEBEBGBGBE@KDE?G?C?A?CACACACAEACCAAEEEGAICOESMs@Mq@Gc@CGCGCECCCEEEGGEAS?I?E?KBMBIFKDC@IDMFs@XMGMCGEGGGGIMUe@We@e@oAi@cBQa@Yu@m@yAg@aA[e@u@aACCm@m@_@YQO]U_Ai@i@_@GSEKEWAS?QAi@?I@O@E?CBM@O?QAQCOIUIQIKIGIG[HA@KDMDMBKBSBO?U?O?QCKAMEKCIGWQOKQS[Yw@w@}@s@g@[u@i@kAu@q@c@qAy@oAw@]OYQMKMKIICCGOQ_@o@kAcAyAs@}@KOs@iAsA{AwA_Bc@g@IKMcAMaAc@wAiAcCs@sBYgC[iB_@uAWs@?AKe@]aBm@oBI_@IWIWK_@]}@KOQMm@[IEkB{AGG_AaAMGgBsAe@[y@_@sEaC{BqAcBmASWGCAAe@Y_A}@US]i@eAiCWw@YcAAGMm@]uACMUeA[eAc@yAY}@CUASA[AQAQiA}C{HaTeFiGuD_H_CmFc@cAYk@g@y@Y[EEMMKIIGYUUUOOMO?ASYQ]MYQe@Qu@Mc@Kg@McAIcAQyC?EQcCIsA'
                     },
                     'start_location' : {
                        'lat' : -7.389133699999999,
                        'lng' : 109.9636507
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 217
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 26
                     },
                     'end_location' : {
                        'lat' : -7.284144700000001,
                        'lng' : 110.0982179
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. Ajibarang - Secang\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'r_nk@am~~SeBRO@I?IAI?CAEAIEGECCi@e@o@a@a@Ug@['
                     },
                     'start_location' : {
                        'lat' : -7.285859999999999,
                        'lng' : 110.0976114
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.8 km',
                        'value' : 804
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 83
                     },
                     'end_location' : {
                        'lat' : -7.283462,
                        'lng' : 110.1054526
                     },
                     'html_instructions' : 'Slight \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Ajibarang - Secang\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'ztmk@{p~~SGc@E[Ee@EYCYIq@Oy@Ge@O}AEs@AUAm@?mA?}A@gBI{DKiCCwACaAIsBG{@'
                     },
                     'start_location' : {
                        'lat' : -7.284144700000001,
                        'lng' : 110.0982179
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 135
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 46
                     },
                     'end_location' : {
                        'lat' : -7.284655799999999,
                        'lng' : 110.1056728
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Ajibarang - Secang\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'rpmk@a~__TnFk@'
                     },
                     'start_location' : {
                        'lat' : -7.283462,
                        'lng' : 110.1054526
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '83 m',
                        'value' : 83
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 30
                     },
                     'end_location' : {
                        'lat' : -7.284796699999999,
                        'lng' : 110.1049378
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Ajibarang - Secang\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'bxmk@m_`_TZpC'
                     },
                     'start_location' : {
                        'lat' : -7.284655799999999,
                        'lng' : 110.1056728
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '5.6 km',
                        'value' : 5568
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 295
                     },
                     'end_location' : {
                        'lat' : -7.2767581,
                        'lng' : 110.152254
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. Ajibarang - Secang\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~xmk@{z__TbFaBZILGPMJIJIHMN[HWBM@I?ABU?OAUASESGU[o@kDaIMKk@m@U_@MYKSIOIMKIOMUQKIGEEECCEG[m@iAaC[s@k@oAeA{BoAqCmAmCSc@qBmEw@eBuAyC]u@sBwEm@oASe@AAISGMIQISISEMGSCQEWC[MoACg@Eo@KoAGiAIcBG}@KcBIwAMuBEaAOuCIuAEaAK_B[wFUgEE_A_@wGQcDS_ESeDO_DEq@SiD[iGAISqE[{F?Co@aMAE?GKyBYyECe@UuEAEYuFM{BIyACo@Ae@?i@?w@@uD?c@B_D@mF@_G@gD@oDBeA'
                     },
                     'start_location' : {
                        'lat' : -7.284796699999999,
                        'lng' : 110.1049378
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.0 km',
                        'value' : 996
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 50
                     },
                     'end_location' : {
                        'lat' : -7.279101700000001,
                        'lng' : 110.1609661
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Hayam Wuruk/Kedu-Parakan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'vflk@qbi_TV_CXeCRuAHo@RiAJa@|@aFDS`@sBTgAbBwI`@mBHg@|@_FXwA'
                     },
                     'start_location' : {
                        'lat' : -7.2767581,
                        'lng' : 110.152254
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.4 km',
                        'value' : 390
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 60
                     },
                     'end_location' : {
                        'lat' : -7.280834,
                        'lng' : 110.163298
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'julk@ayj_T\\An@@R?f@?L?H?D?PGRILKPWh@w@d@s@L[JUDQBK@M@K?U?UAUCw@Cu@AU'
                     },
                     'start_location' : {
                        'lat' : -7.279101700000001,
                        'lng' : 110.1609661
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 537
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 56
                     },
                     'end_location' : {
                        'lat' : -7.2854992,
                        'lng' : 110.1626081
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eright\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'd`mk@sgk_T|E?j@@L?NBZBNBPBDBFBFFLFLDFDJBH@L?H?F?J?J@F@D@BBBBDFDDB@D@JB`AHJ@F@F@D@HBb@TD@D@HBL?\\Ab@CNANALAR?P?F?j@@'
                     },
                     'start_location' : {
                        'lat' : -7.280834,
                        'lng' : 110.163298
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.1 km',
                        'value' : 1119
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 99
                     },
                     'end_location' : {
                        'lat' : -7.2940613,
                        'lng' : 110.1655824
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'j}mk@ick_TB]Da@DSLo@DQBGBGDEDEJGHEhEiBpEeBrAc@HC@CBC@EBGBS@I@A?A@A@ABA@?FC`AGpAILAJAPChAO@?~@UlBc@|G{Al@KPAN?NARANAL?J@VDPBF@B@HDRLLJHFNJTNPLPJTL'
                     },
                     'start_location' : {
                        'lat' : -7.2854992,
                        'lng' : 110.1626081
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.7 km',
                        'value' : 710
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 71
                     },
                     'end_location' : {
                        'lat' : -7.2988097,
                        'lng' : 110.1688913
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'zrok@{uk_T@CDEDCHGNIJGNMHIDEFGDEFEDGHMDGDEFCHENGJCPIBAFGBG@I@K@O@KBUD_@Da@FYBQBGDG@CLMLOLSNUTYFKLOFGDGFCHIHGDCFEFCFAD?N?P@H?F?JCFCFCFADAHAH?P?J?PBL?P@R?VAL?\\GRCRCRCRCLAVGXIf@Yh@U'
                     },
                     'start_location' : {
                        'lat' : -7.2940613,
                        'lng' : 110.1655824
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '111 km',
                  'value' : 111332
               },
               'duration' : {
                  'text' : '1 hour 45 mins',
                  'value' : 6322
               },
               'end_address' : 'Surakarta, Surakarta City, Central Java, Indonesia',
               'end_location' : {
                  'lat' : -7.566755100000001,
                  'lng' : 110.8166131
               },
               'start_address' : 'Temanggung, Central Java, Indonesia',
               'start_location' : {
                  'lat' : -7.2988097,
                  'lng' : 110.1688913
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '0.7 km',
                        'value' : 690
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 55
                     },
                     'end_location' : {
                        'lat' : -7.304643100000001,
                        'lng' : 110.1706496
                     },
                     'html_instructions' : 'Head \u003cb\u003esoutheast\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pppk@qjl_T~BeApD_Bp@Yt@[\\Of@QhAYXGPEHCPCNCRARAT?X?ZCLC\\EVE`@Gb@GZCJ?~@ApABx@AJ?JA@?'
                     },
                     'start_location' : {
                        'lat' : -7.2988097,
                        'lng' : 110.1688913
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '57 m',
                        'value' : 57
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -7.3045732,
                        'lng' : 110.1711597
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e toward \u003cb\u003eJl. Perintis Kemerdekaan\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '~tqk@qul_TMeB'
                     },
                     'start_location' : {
                        'lat' : -7.304643100000001,
                        'lng' : 110.1706496
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 140
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -7.3058274,
                        'lng' : 110.1712015
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eright\u003c/b\u003e toward \u003cb\u003eJl. Perintis Kemerdekaan\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ptqk@wxl_TdAGr@An@ApAB'
                     },
                     'start_location' : {
                        'lat' : -7.3045732,
                        'lng' : 110.1711597
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.7 km',
                        'value' : 653
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 65
                     },
                     'end_location' : {
                        'lat' : -7.3089393,
                        'lng' : 110.1761573
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Perintis Kemerdekaan\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'l|qk@_yl_TJg@Lk@J[Nc@\\y@^{@Pc@Vi@^y@FMLYHOXq@LWHSLUP[NSJOTWPSLOZa@Zi@\\k@Zg@JSDGBAFELIHGBAPOPST_@DI'
                     },
                     'start_location' : {
                        'lat' : -7.3058274,
                        'lng' : 110.1712015
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 537
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 48
                     },
                     'end_location' : {
                        'lat' : -7.313499599999999,
                        'lng' : 110.1772083
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Dr. Sutomo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'zork@_xm_TLQ@A|@m@~@k@NIVOLGNEl@OHCHAFAFARCf@A^?~@AB?B?ZA|@ClAA^CdBGvCE'
                     },
                     'start_location' : {
                        'lat' : -7.3089393,
                        'lng' : 110.1761573
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 150
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 24
                     },
                     'end_location' : {
                        'lat' : -7.314849499999999,
                        'lng' : 110.1771367
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. KS. Tubun\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'jlsk@q~m_T|DHnAB'
                     },
                     'start_location' : {
                        'lat' : -7.313499599999999,
                        'lng' : 110.1772083
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 167
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 20
                     },
                     'end_location' : {
                        'lat' : -7.31498,
                        'lng' : 110.1786491
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Setiabudi\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'xtsk@c~m_TXmH'
                     },
                     'start_location' : {
                        'lat' : -7.314849499999999,
                        'lng' : 110.1771367
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 302
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 48
                     },
                     'end_location' : {
                        'lat' : -7.315227699999999,
                        'lng' : 110.1813722
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Ahmad Yani\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rusk@qgn_TZsJTkD'
                     },
                     'start_location' : {
                        'lat' : -7.31498,
                        'lng' : 110.1786491
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 189
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 17
                     },
                     'end_location' : {
                        'lat' : -7.3149314,
                        'lng' : 110.1829752
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Nasional 9\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'dwsk@qxn_TOMGIEIGIGMUm@BO?UBkC?E?Y?G'
                     },
                     'start_location' : {
                        'lat' : -7.315227699999999,
                        'lng' : 110.1813722
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.1 km',
                        'value' : 106
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -7.315860999999999,
                        'lng' : 110.1831293
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Nasional 9\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'husk@sbo_ThBCDC^Mh@G'
                     },
                     'start_location' : {
                        'lat' : -7.3149314,
                        'lng' : 110.1829752
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 510
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 47
                     },
                     'end_location' : {
                        'lat' : -7.315442200000001,
                        'lng' : 110.187723
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Ewarno\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'b{sk@qco_TEa@YeDAGC_@Em@OeBIqAA}@AsAC{BEqD'
                     },
                     'start_location' : {
                        'lat' : -7.315860999999999,
                        'lng' : 110.1831293
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.6 km',
                        'value' : 621
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 63
                     },
                     'end_location' : {
                        'lat' : -7.321007900000001,
                        'lng' : 110.1875851
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Menuju\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'nxsk@g`p_Tj@GrCBdA@L?zED\\@p@BH@jA?X?rCHt@BF?N@j@?dAD\\BZCLALE'
                     },
                     'start_location' : {
                        'lat' : -7.315442200000001,
                        'lng' : 110.187723
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.3 km',
                        'value' : 1299
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 80
                     },
                     'end_location' : {
                        'lat' : -7.3272713,
                        'lng' : 110.1973719
                     },
                     'html_instructions' : 'Slight \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Jendral Sudirman\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'h{tk@m_p_Tj@_AJ_@DKv@cCBE~@iDNk@hAcEfAoCDIRg@FQ@A`@mAFKjHmKZa@Za@BEHKf@i@rA_BzDqEtA_BHIn@y@'
                     },
                     'start_location' : {
                        'lat' : -7.321007900000001,
                        'lng' : 110.1875851
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.3 km',
                        'value' : 1316
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 66
                     },
                     'end_location' : {
                        'lat' : -7.335641400000001,
                        'lng' : 110.2057915
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Suwanto Suwandi\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'lbvk@q|q_TbBiB\\]lAkA~C_DnBcBh@m@x@w@b@a@TKTU`OgOh@k@`AcArByBVWxDaE`AeA'
                     },
                     'start_location' : {
                        'lat' : -7.3272713,
                        'lng' : 110.1973719
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.5 km',
                        'value' : 1473
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 74
                     },
                     'end_location' : {
                        'lat' : -7.3458996,
                        'lng' : 110.2126956
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eKrangan-Pringsurat\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'vvwk@eqs_TxAaBlCwCz@_Aj@s@zD{Dl@k@V[NOFMDK@?HWDUBKFmC@]BOBKDKHMHKLIPINELCv@ENAj@E`@E~@QnAWhAU|@UnAa@`Bm@h@Sf@Qx@YZKh@MtAUb@I`@EdAOnB[pBW\\E'
                     },
                     'start_location' : {
                        'lat' : -7.335641400000001,
                        'lng' : 110.2057915
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '7.2 km',
                        'value' : 7186
                     },
                     'duration' : {
                        'text' : '6 mins',
                        'value' : 383
                     },
                     'end_location' : {
                        'lat' : -7.3923378,
                        'lng' : 110.2473102
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Temanggung-Secang/Kranggan-Secang\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Temanggung-Secang\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'zvyk@k|t_Td@EfCO~BGxAE|CI`ACn@CF?nAET?rCKT?ZC`AEZEbAOTIxBy@l@Ud@OLCTGp@MfAUREj@Gl@GlDU\\CrCMtAG`AERApCGTAz@A~BEn@Av@Av@CjBA\\?H?ZA`@?xCArA@d@@l@@`@?T?\\A`@IDCRIPOROXW@CVWRQ\\YfB_B\\YPMVMDENK^OxBu@jDuAzEkBdDoAlBs@vA_@fHgAlDk@rCi@~Ci@ZGbASn@Ml@Qv@Wd@Oh@Ol@WXQf@UBAXSDE^YHITUXYJKfAqAjAuAX_@RYLQN[Pa@JUFKJKJKJGHGRK^QTGVMrDwBX]HKDEBGDKDIDMDOFODKDEFEDADAD?B?D@B?H@XJZHH@D@D?N?J?H@P?TIFCHEBEFGFIJQHQN[BGrBoETg@N[@Ch@oA@EPg@Ne@Jg@J_@ZsAJe@?Cd@}BVwAHk@@[@]Cc@Aa@AUC[IgAGk@OuAKw@OmAASAS?G?K@M@K@K@C@EDOJWXq@LWBEl@gBXy@@CRq@HUHk@@[@_@?s@?a@?W@UBi@@MBM@CH[BMTc@zA{BBCdAwAFI|@kAbB}Br@_Al@u@JMvAsAh@c@DEp@m@b@c@t@_Ab@k@fGkIXa@xEqG~@sAX]z@oArBkCf@o@^e@FKh@u@NWTYtCeE'
                     },
                     'start_location' : {
                        'lat' : -7.3458996,
                        'lng' : 110.2126956
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '26.9 km',
                        'value' : 26894
                     },
                     'duration' : {
                        'text' : '23 mins',
                        'value' : 1390
                     },
                     'end_location' : {
                        'lat' : -7.260349700000001,
                        'lng' : 110.4026252
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Magelang-Semarang/Jl. Semarang-Yogyakarta\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Semarang-Yogyakarta\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'bybl@ut{_T_Ak@iCwA_B}@eDeB}@g@GEGE_B_AmCyA_Am@yAeAOMm@m@s@aA{@yAc@_AIYqAuCS]Ua@qA{BYg@QWgCoDCGeA}AS[uAwBKOqLkQyBuCmFcHUW_@c@iA{AMQ{C{DgB}Bw@cAy@cA?AeAgAq@q@MOWY_AaAUWq@s@}@y@?AkAgAqAmA_BuAiBcBoGcFc@]o@c@wA}@cAi@u@a@_Bm@u@Y{@[{@]u@WSGSOMKII]e@QUKSo@kAIK_@i@c@m@aAkAa@e@e@i@_@_@c@i@o@eAa@_Ag@{@e@{@o@s@i@e@{@m@_DmBkAs@_CuACAw@a@KGIIIIECCEQWGKYe@SU_BoEa@oACEQk@Oa@CIc@_AGMIQYc@MSMOOMQUCE[g@IOGOKc@YmAOi@IYKWQa@U[S]Q]IKGQKWEUAGCMCUAUCQAYGs@Eg@OaBMq@Ge@_@}AWgAs@}CYwAOq@Kc@GUMa@KYSe@CGIMSYKOk@s@y@u@OMgA}@}@q@k@c@KKqCwBqAeAKKYU][MOMWGSCOCSAKCc@GkAEi@?UAi@Bc@Hs@H}@B_@Ba@Bo@ByAAoB?y@?cB?a@DgD@}@@q@?q@AWKq@Ow@m@yC_@uBY_Be@aC[mAm@wBK_@CKa@oAa@iA?Ai@uAUk@AGUi@u@cBm@{AM[a@_AQg@e@gA[u@CGQc@_@aAGOCK_@oA?ASy@Uy@AEMm@[yAYiA?E]}AESMi@Oc@EKYm@MY[i@[a@EGu@{@_@a@o@m@eFuE_A}@e@e@w@s@u@q@eB{AUUY_@W]MS[g@CEWk@u@cBc@aAs@cBk@uA}@aCoAaDqBsFk@{Am@oAa@}@c@_A[q@IOGKIKGGIEGEGEQGSEOCc@GaBQUCaAG{@GgAIeBOU?S@ODODODULc@VuAbAq@v@[\\c@l@SZUj@YjASlAGVELENGNIRQVg@b@KDIBIBI@K@K?K?O?K?[Eu@Gs@AG?I?K@G@IBYH_@LSFE@C?E?C?E?E?E?EAQ?eAI_AMqAI_@AI?MAM@}@DyAXcAVa@HSBWHq@Xe@Vy@d@OJWLe@TI@KBM?O?Y@[A{@Ky@M_@IIAq@U[OMIIICEGMESCK?IAK?K@O@KBIBKBIBERi@Jc@@K?M?GCc@GoAG}@Cc@CUEYESQm@Oa@Wm@[mAQy@Io@G}@OsAOiBOkAOw@GSMQSUq@e@QMOQMOKSO[I]COGOEKGMEIYYQQYOYMa@Qc@Ie@Ik@Ka@Ey@G{AOO?mBG]@W?C?g@?C?w@?{@D]?Y@cA?eB?wACmAAaA@M?IAI?EAEAEAECCCKGKIOMSSk@k@w@u@QMUOeAo@_Ac@e@SYQk@_@c@a@w@o@o@g@SQg@_@_@WsB{Aw@m@AAQOMKWYGIUYe@q@o@eA]q@GI]m@a@q@OU[g@a@u@MUOWMUu@sAe@{@U_@IOGKKSQ[_@o@g@iAK[Mc@Qm@Kc@G[AQAQAC?WBg@Ds@FaAFy@De@@OLq@F[Ja@F[D[BYB_@@m@?_@?SAQCKAEEMIMGMa@e@m@o@q@s@[]QWQ_@M]ISGUKi@]yAe@wBEOcAeESq@K]Wg@Ug@QYGMISQ]KQ]s@y@}AYm@ISU_@We@KQQ[c@{@EIKSi@eAKUUe@KWEQGWCW?ACa@?O@MB]D]Fc@Hm@Ji@@GBKDKHO^y@Xi@DI^cAJSNc@JY@E@CNeAD]BU?EBY?c@?WGWAICEIMIIUUII_Au@u@k@s@u@CE_@c@e@k@MOQWu@eAc@k@ACi@s@EG_@e@i@o@m@w@w@gAGGWWe@m@u@aAMQY]iAyA_@e@Ya@AAa@o@Q_@Wa@IQM[CSE[A]Ay@?WDo@Da@La@La@Ti@RYROFIFIBM@OASE]AOCS?YDSDQFSHSNYFKDELOZW|DwF~@y@HKLQb@a@Ta@DIBK?M?KASEQKQ_@MOCSAQ?Q?a@CQEUGMIKKIIGMMYIOGMKKQQIEICYAO?S@GDE@KHQVS`@eBdBcCfE}AxAgAf@iA`@i@L_ANuAL}@RcANaBTwAJyAF}C?qEBUBUFQJKJIJe@fAEJIJGHKDED_@TQFUDy@HwAJ_@Da@@U?a@CUAYA[EWCcAMeBUs@M]KQIKMIOGOGUCYC_@Iu@[oA]aAk@wA{@{AiAoBk@_AQQ_@Wg@Wo@SYGWEo@M[EYC}@As@AA?m@?eCWy@MYGsCo@}Bo@_AYWEkFqAkCs@k@SgCw@{Ac@[Ge@Es@AW?gDEqBEkAGy@GMAUEMEOGOMSSW]a@}@Wo@Yi@Ue@WWa@c@y@{@YSQOu@]EAGEQGeCcAGEcAe@KEEAo@]m@[i@_@g@a@g@e@KIY_@IYGWCUCSE[GmAQsBIu@AGIWKQQYOIm@[{Au@[Q[Ye@i@{@iAyAiB_BuB}@gBg@eAo@uAeAgCu@mBy@wBk@mBW{@Qe@KYMS_@a@s@k@_@a@MKSWSYQ[c@q@QSKKWQo@[yCuBsCiCQE_B{Ae@a@]_@k@g@c@a@KQEEYWcAoA_@i@g@_Ag@kAACo@{As@uAgA{BcAwBMYg@gAOWkAsBEIIMMWWk@{@uBIYk@gCWmBEa@Cc@Cc@ESGaBA_@@cBFaCHeBLoA\\kBBaBEc@]oBk@oBg@_AmC}CUUGMGMISk@cBMg@I[EUAKE{@C{@?M@o@?I@gBBaCB[B]BaA?aAAG?GCGAGAKAC?E'
                     },
                     'start_location' : {
                        'lat' : -7.3923378,
                        'lng' : 110.2473102
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.7 km',
                        'value' : 706
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 57
                     },
                     'end_location' : {
                        'lat' : -7.255946300000001,
                        'lng' : 110.4064074
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e1st\u003c/b\u003e exit onto \u003cb\u003eJl. Jend. Sudirman/Jl. Semarang-Yogyakarta\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'd`ik@m_z`T?@A??AA?A?A??AA?AA?AA??A?A?A?A?AE?y@Me@GaASm@Mo@Ue@_@GIEIEGCMAMIm@?GI}@UaCI[COOWIIIGAAIIUQg@WkBy@CAeG_C'
                     },
                     'start_location' : {
                        'lat' : -7.260349700000001,
                        'lng' : 110.4026252
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.6 km',
                        'value' : 3573
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 232
                     },
                     'end_location' : {
                        'lat' : -7.244159,
                        'lng' : 110.4342382
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Jend. Sudirman/Jl. Semarang-Yogyakarta\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Semarang-Yogyakarta\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'tdhk@awz`TWoAIa@CQW_BM{@COIg@MeAAECSAMAEEa@?OAGGcAK{AEm@KqAAKYiEEe@M{@EOQi@KYg@gA_@}@Sc@AAOY_@}@cBoDEKWS_@]}@m@AA_Ai@GCCCQIe@UaAi@EAgBq@}@YYIaAYg@Ma@KOEKEIGUQm@]GGy@u@QQEICKCGK_@CSCSAW@y@?s@?e@?Y?[B]B_@Jm@TmAFg@BgAFoEHyED_E?Y?iA?u@Am@GaAG]UiBKkAM}@AG?MWqAEYGQISKUOWY]q@q@e@c@EGGGIMa@{@MWK[IYMi@K_@Sy@CIGWM]MUEEMSe@g@SWSU]e@OYMUYe@w@sAs@sAIOm@gAi@}@GI}@}AQ[KOu@oAw@qAYi@'
                     },
                     'start_location' : {
                        'lat' : -7.255946300000001,
                        'lng' : 110.4064074
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '44 m',
                        'value' : 44
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 20
                     },
                     'end_location' : {
                        'lat' : -7.2443516,
                        'lng' : 110.4345916
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Palagan/Jl. Raya Ambarawa-Ba\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : '~zek@_e`aTd@eA'
                     },
                     'start_location' : {
                        'lat' : -7.244159,
                        'lng' : 110.4342382
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '12.6 km',
                        'value' : 12640
                     },
                     'duration' : {
                        'text' : '12 mins',
                        'value' : 694
                     },
                     'end_location' : {
                        'lat' : -7.324833300000001,
                        'lng' : 110.5046618
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. tol Semarang-Solo/Jl. Nasional 16\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 16\u003c/div\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'd|ek@eg`aTj@DN@fAHZBfADf@@XAVAhAE\\CHA@?h@Gh@ILCb@MJCd@S~@_@r@YhAc@tBy@NGfBu@JG^[BANST[Pa@BEL_@@EJc@Hg@Jo@VsBXaCTkBHe@J_@HUJUHMLOPSNMTS\\Uh@YdAe@~As@lBy@VM`@WRSNQJQFODODM@Q@Q?C@K?QIy@Ki@Q_AGi@E_@?U?QBSDSBI@GFUf@qAz@uBh@kAZg@X_@PSPMJMLI\\S~@]`Bi@~Ai@bAc@nAk@VO\\Wl@c@j@k@jAoAl@u@j@u@NUjBqD\\o@FQn@wAf@iATg@LS`@m@?A?A?A?ABEZa@Z_@b@c@x@q@~CyBNIHGJGLI\\Qh@SHAJ?RG|@Qt@Gt@EhAKx@KHAz@Qd@IHAvBa@fB]n@O|A]VI`AWhA]hA[~@W~@Wv@OzB[~@Mx@Oh@IpASj@KVCnCg@jB]nAUNCzBc@z@OTEZEbASn@KLCXEBAh@KVELC\\Gh@KDAn@Mx@Uj@Qn@Sb@Op@S^KnAa@BAh@QLGb@St@a@d@Yd@[XS~@q@~@q@VQzAcAv@i@n@a@p@c@`Ao@d@Wp@a@j@[NIf@Yt@a@v@a@\\Sn@[dAk@VMBAd@Y~A{@~@i@JGBAf@WjAo@FCbAi@\\QnCiA~@a@`Aa@bAa@fA_@nAa@r@Wd@Sb@SJGv@m@PM@CTQ@CRSTSRUr@o@BE^W`@W~AaAZQz@i@hA_Ap@m@f@c@f@g@fBwBf@q@PWn@kA`@s@l@kADIL]@EDMHWDWDSB_@B_@L_CD_@Dk@R}ARkANeALy@?CFk@@S@S@w@?u@?yA@i@@_@?U@Q?E@Q?EB[@W@OBKBQP{@FSRs@f@gBBK^mAPk@@GBIb@{A@EN_@Xy@DKFOXu@p@kBj@wAZw@L_@DId@gAf@kARc@Xk@DKTc@LWR]Zm@Ta@LSHI\\e@b@i@b@g@VYd@m@l@q@DE\\a@TU?A`AcAZa@LSj@q@j@m@XYFI\\Uf@_@^U@Ap@[NIj@Yh@QLEXMh@MdAS|AY@?z@QREVGpAe@PIn@[FC^UtDmCl@e@tAgAZYt@q@ZSd@a@j@i@d@[LK`@U\\QHC`@MTGlF{AFAfD}@bBi@nDuAnBu@l@UbAa@RI^Ob@Sd@WTMBCr@g@NMZQt@i@dBkAFElA}@DCPM`@[r@e@p@g@DCbBqAj@o@`@[DGxA{A\\W@AdAeALMtAsAj@i@lAmAZ[p@w@nAoA@Cx@_A~@gAPSVYBCb@c@^_@t@}@\\c@v@eAf@w@\\a@`AoA\\g@`@i@HMFIhAcB@AHMz@oAJMZg@V]^i@JMZe@pAgBJMZe@p@eAP[LW@CT_A'
                     },
                     'start_location' : {
                        'lat' : -7.2443516,
                        'lng' : 110.4345916
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '48.9 km',
                        'value' : 48895
                     },
                     'duration' : {
                        'text' : '44 mins',
                        'value' : 2636
                     },
                     'end_location' : {
                        'lat' : -7.560583999999999,
                        'lng' : 110.7905069
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e3rd\u003c/b\u003e exit onto \u003cb\u003eJl. Jenderal Sudirman/Jl. Semarang-Surakarta\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Semarang-Surakarta\u003c/div\u003e\u003cdiv style=\'font-size:0.9em\'\u003eGo through 1 roundabout\u003c/div\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'dsuk@c}maTA?A?AAA?A??AA?AAAAA??AAA?A?AA??A?A?A?A?A?C?A@??A?A@??A@A@A@??A@?@A@?@?@A@?@?@?@@@?@?@@@??@@?@@?@@??@@@LENCFAF?J?n@B@?xBLd@BX@Z@dCRd@DT@|AJlBJX@^@?ATAx@Ep@INCD?lASv@KhAQtBYDA~@M@AvBY@?XEnBWHA@?t@KdBWbAQh@Gx@M`Em@r@KNCRGDCHEDCh@WnAw@ZQjDwB?An@_@JIf@[xCmBvAy@\\MPGFE|Ai@v@[zB}@rCaAzCeAHC~@]TKFCVMpCcAfBq@HEbDkA\\MvAk@XGRG\\G^Gp@GxCSTAnBMlAI~BQd@E~@G~AMr@EbAI|AMTCTAtCORC`@Cd@EdBKXCXCXCtEYPAPAZCbF[rBOzDWpBMLAbBEd@EpBMRCzAIp@GF?zCSZCnBOtCOjKm@PABAPALAhCQnCQfDSh@CbBMlCOtCSLAtAIZCz@E`@CjDQVAD?p@Gv@IpBMx@En@CjACd@ARAnFEdJAjC@bFH|EA`B?hC@`B@X@fBBlA@dA@b@@zA@rA@bA?\\@jA?bGC`@AxBCjA@nA@vB@bDL`F`@ZDnE^~CZ`ANdCThAL~D\\xGj@~CZfADfAF|AJdCZXDzALxC^d@F\\D\\@x@C\\Gb@Kv@UxEyA|Ae@x@a@`FoAfA[XIRGf@MfBg@tDaAdA[h@MhA[lCoAz@_@lAk@xAu@zDwBPIZQnBeApEkChCyAfBeA^[JSV]PYZi@p@y@hAiArByBTWRSPQVUf@]PK^Of@UTKFAhA_@z@[fCiARIr@QBATEr@]z@c@NIr@a@LIb@[r@e@dAu@j@c@DEl@i@|@w@r@m@ZWHI\\UTOl@Yv@_@|@i@fAq@nA{@j@c@d@a@v@q@jB}Ad@]\\Sr@a@FEn@[lAm@dAg@l@Ql@Qn@ONEhBa@pDy@`B_@~Bk@rA]NCtCw@`Ba@dAWp@QpA[bAWd@MPIr@Yv@c@jCyA~CeBn@a@dAk@nBaAjCsA|@c@NGHEJCVIbCu@z@WnBo@nD{AtB}@`@QLGd@SxCwAVKPInEmBHE`Ae@lB}@`A_@fAe@VKxCwAtBgAp@[`@S\\QtAcAnDiC^[zBiBrDuCn@k@f@c@`@]hByAzB{A`C}Al@a@`BiArDiCj@_@`Aq@BAhBwATQhCuBFEVUf@a@LIJK~CaCxBeB^[l@g@p@[h@QJAtBUhBSNE@?DAz@QpBs@dAg@|@g@`Ag@r@g@NQJORg@H_@Hc@Hw@PeALk@Te@Ve@x@aADExA{ADE~@_A|BqCnCyC^o@j@kA`@}@Zs@P{@dAkFh@uAdAmBb@k@NStAuAd@g@h@i@lByBlBqBxAuAnAmAd@m@TUxAwB\\a@HOf@e@lF}CfBq@h@UzDcAPEdE}@|A[hCq@DAvEiAnCm@bHoB~@a@jD}AbAe@|CwAZODCz@a@@I?A@??AnAm@fAi@|BoAdAg@ZMPIVI|@Uh@OXIJC^EHCPARA^ClAA`BBB?xABR?N?\\E\\C^EZGTENE\\KZOZOl@[nAq@RM@?J@tA{@z@e@~FoDpAw@x@g@bAm@d@[hAu@bBcAFE`Am@NIPKh@[VODC^Uh@[ZQd@Sl@S`@M^Kp@MrAYjASFAjBWl@IhAORCf@IDAz@MDAn@KREvAU~@KVEn@Gz@Mr@MTClAYl@Qr@Yh@Yf@WNG|Au@^Op@]nBcA~@k@JGNKx@c@hAs@NIv@]vAq@@AfAi@nAq@FC`Ai@x@c@jAo@XMn@[bAg@v@c@j@Yx@_@dEwBvAy@DClBgAZMl@]nAu@NGxA{@FEtAw@~@s@l@c@dAaANSl@}@N_@t@uBx@_Cf@}ATs@fAgDl@mB@At@aCb@wAtBiGHU|A}DNa@fB}ElDgJTs@@E@ErAcEvAyDZ{@fAoC`@[LM|BuAd@WtFyC`Ak@`E_Bn@W`A_@LEpAg@p@WzB}@ZMRGnAi@z@YlEeBPG|@[DCdCeA~Ak@fA]RGv@MTCLAtBGVAXA`CE@?b@?p@?Z?PC@?@?l@Bh@?l@Bl@FhARrC\\bDXn@DR@N@\\@HAF?HCBAtAw@LAjC}AXSNKNQVYPa@JQHUJ[DO@GH{@Dq@lA_DjAuD?AZy@Z_Ax@sDDUt@kCF]h@iCP{@?ABGBY?ABQBW@Y@e@?S?UCm@AO?MA[?gBBsB?]@g@?Q?C@i@?}@@}@?A?Y@kD?mA?A?A@M?}BBmE?S?s@?_@?_AAy@AS?IA_CAs@?QIcCC{@AUCuAImDCy@?AGyC?ACc@CcAEaB?E?A?ADqCAIK{AEi@AA?C?MAUCmAAu@GmBCo@Ac@GgBAc@?C?AC{@IkEKuE?AEkB?AASEkB?AMgF?c@Ce@AWAWASOeFMqEIcECe@C_@?K_@gJCk@IgDMsDEwB?A?CO_FGgBKqDKyDCm@IsDEaB?AGuB?AAg@Aq@KsCCoA?I?EAe@GaCAi@C_A?OEiB?AA_@?GAEKaFEaB?AAICwA?EAc@KyDC]E_B?QEgBAeAEcA?s@MuD?WAa@IsBEeAAg@E_B?YO}F?WI_CCoAIgC?a@E_DC}@CoAAi@I}FCgA?Q?KA]CqAA]Cu@?KOaKGiE?G?GEcDIi@CeBCqC?AE{BGoCAq@?I?CAOEwB?GEoB?CCcA?AEgBC}A?AEaDEqBCyCA[?AEuCA}@?}BAuBAuB?AG}C?K?CAG?M@}ACuACuAGkBEgBGgAGcAM}BSqDCm@?c@@S@SJoA?G@EFw@RiAj@kC@CBS@C?A@??ANW@GZ{AJw@D]LsA?A@MPyABYD_@HcAR}BDs@Be@B}@Dc@JcAD[L}@`@eC\\oBl@cDd@gCBQ`@{B^iBRaAh@oC^kB@G`@uBp@aDnAeGF]t@iDH]`AmF|@{E`DiQDUhBkKdAoF^mBHa@L}@ZcBj@kCNs@R}@hAcERs@DIVy@`AiDHYFSr@kCd@{Ab@wAZgABIRy@bBwGd@uBZmAh@}Bf@mB@I@CdC}Kj@mCLm@VoAPw@?A^cBDUPy@j@}BBO@Cp@sCBIn@aCV_Ab@wAPm@d@uAp@gBJYp@cBZs@^y@Vm@p@_Bt@iBRs@Ro@BKd@iBLs@h@}BBGCMNk@No@AA?A?AA??A?A?AAA?A?A@A?A?A?A@A?A@A?A@??A@A@??AB?JYFc@BO?ADC@EP{@\\kB?CV}Ad@mC?ADKVkALYRg@Ti@DKDGRe@Zy@BKjB}EBa@HUzAwDRe@Pe@n@}A`@aAtBoFzB{Ft@eBBGr@eBTo@fAqCN[b@mAdAsCFOVm@d@kA\\{@N]LYl@wAZu@^_A`BmDRa@L[x@eBFMP]r@}AzAcDZw@`@oAV_Ap@aCx@wCFYTgAZeBBQFs@JoA@UD{@@eABk@@M?EDmA@_@@WB_ABu@@c@@gADu@@cA?M?q@@ECm@Eu@Gg@AGM{@Kc@CO_@aCi@{CCKAKUoAE]G[]mBKm@Oy@CKKg@W_BEUK}@WwAG]UuAMgAIi@]kCMiAE[CMKo@i@}CIi@Mw@AI]kBGe@EUQmAAE_@{CO_BAQ[aDS_CGgAOsC?AACAk@BsB@_@@WDe@Di@Lu@VqAZ_BPy@Jg@BK\\eB\\uAHc@FWLm@H]H]VqALq@Ha@r@}Cf@{Bh@gC`@cBHc@@A?CZoBJe@l@uCDQ?C@A\\aBd@sBDIBG'
                     },
                     'start_location' : {
                        'lat' : -7.324833300000001,
                        'lng' : 110.5046618
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.0 km',
                        'value' : 2980
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 193
                     },
                     'end_location' : {
                        'lat' : -7.5684722,
                        'lng' : 110.8163296
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Slamet Riyadi\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rtcm@uwecTp@uCT_ADSHc@@E@GFU`@qBDUHa@VkAd@yBH[VeBD[F_@n@gDt@kCDQJKVqAp@uCReAPw@x@kE@Ed@wBJm@FYDQJg@PuABKLi@H[Lo@Nm@TcA?C@CRaAj@oCPy@@ClC_NBGF]x@wDdAgFDSLo@n@wC?A@ERaA^iBl@uCZ}A|@eENq@h@kCZ_BBG^gB^qBfAuF'
                     },
                     'start_location' : {
                        'lat' : -7.560583999999999,
                        'lng' : 110.7905069
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 188
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 25
                     },
                     'end_location' : {
                        'lat' : -7.566826999999999,
                        'lng' : 110.8167337
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|eem@ayjcTUGiF{@gAK'
                     },
                     'start_location' : {
                        'lat' : -7.5684722,
                        'lng' : 110.8163296
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '16 m',
                        'value' : 16
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 13
                     },
                     'end_location' : {
                        'lat' : -7.566755100000001,
                        'lng' : 110.8166131
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eleft\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eDestination will be on the right\u003c/div\u003e',
                     'polyline' : {
                        'points' : 't{dm@q{jcTMV'
                     },
                     'start_location' : {
                        'lat' : -7.566826999999999,
                        'lng' : 110.8167337
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '72.0 km',
                  'value' : 71986
               },
               'duration' : {
                  'text' : '1 hour 6 mins',
                  'value' : 3988
               },
               'end_address' : 'Jalan Raya Maospati-Solo, Kedunggalar, Ngawi 63254, Indonesia',
               'end_location' : {
                  'lat' : -7.395009699999999,
                  'lng' : 111.3451073
               },
               'start_address' : 'Surakarta, Surakarta City, Central Java, Indonesia',
               'start_location' : {
                  'lat' : -7.566755100000001,
                  'lng' : 110.8166131
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '16 m',
                        'value' : 16
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 1
                     },
                     'end_location' : {
                        'lat' : -7.566826999999999,
                        'lng' : 110.8167337
                     },
                     'html_instructions' : 'Head \u003cb\u003esoutheast\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f{dm@yzjcTLW'
                     },
                     'start_location' : {
                        'lat' : -7.566755100000001,
                        'lng' : 110.8166131
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 188
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 27
                     },
                     'end_location' : {
                        'lat' : -7.5684722,
                        'lng' : 110.8163296
                     },
                     'html_instructions' : 'Take the 1st \u003cb\u003eright\u003c/b\u003e toward \u003cb\u003eJl. Slamet Riyadi\u003c/b\u003e',
                     'polyline' : {
                        'points' : 't{dm@q{jcTfAJhFz@TF'
                     },
                     'start_location' : {
                        'lat' : -7.566826999999999,
                        'lng' : 110.8167337
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.5 km',
                        'value' : 1504
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 164
                     },
                     'end_location' : {
                        'lat' : -7.572468600000001,
                        'lng' : 110.8293626
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Slamet Riyadi\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|eem@ayjcTBMv@uDj@cCf@eCNs@?Av@}DBO@EXqAHe@Ny@z@sE@Ix@{DF[DU@E@EJ[j@eCT_ABKd@uB?A?ABEFQToARw@x@gEbA_FFUTaAn@aDHa@'
                     },
                     'start_location' : {
                        'lat' : -7.5684722,
                        'lng' : 110.8163296
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 331
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 80
                     },
                     'end_location' : {
                        'lat' : -7.569635300000001,
                        'lng' : 110.8302206
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e1st\u003c/b\u003e exit onto \u003cb\u003eJl. Jenderal Sudirman\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : '|~em@ojmcTA?A?A?A?A??AA?A?AAA??AA??AA??AA??AAA?AaDo@C?EA{Cg@EAmE_A'
                     },
                     'start_location' : {
                        'lat' : -7.572468600000001,
                        'lng' : 110.8293626
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 547
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 69
                     },
                     'end_location' : {
                        'lat' : -7.566374600000001,
                        'lng' : 110.833299
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e2nd\u003c/b\u003e exit onto \u003cb\u003eJl. Urip Sumoharjo\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : 'fmem@{omcTA@A@A@A@A?A@A?A??@A?A?A?A?A?A?AAA?AAA?AAAAAAAA?AAA?A?A?AAA?A?A@A?A?A?A@??A@A?A@??A@??A@?@??A@?@A@?@?_@wCmCmBOIQM_Am@cAo@uA{@}AcAaB_ACAEC'
                     },
                     'start_location' : {
                        'lat' : -7.569635300000001,
                        'lng' : 110.8302206
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.2 km',
                        'value' : 3151
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 278
                     },
                     'end_location' : {
                        'lat' : -7.5674089,
                        'lng' : 110.8599096
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Insinyur H. Juanda\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'xxdm@ccncTDMDMBOBELe@Vs@@C@EHc@`@{B?C@A@Ih@kBDO?A@Cb@_BLe@?C@AViAT_A?C@A?K?C@A\\wALu@@AXkAFSPu@R{@ZaA^wAR}@@A?AH[?A@A?AX{@DYj@yBVmAFa@@A?CDQXwAPm@?C@Aj@kBFQTu@J_@Ne@@C@Eb@}ALu@@??C@En@uB@ILs@L_@BMBIBM@G@M?K?K?KGSEMKUYs@ESEg@GYI[Kw@COKi@EWe@mDKs@Ks@SuAKy@e@_DCI]{BYkBE]?AQaBIaAOuAMuACUWoCAGOiBUuBSgBCUCU]iDEkA?M?_@LeBVqB@q@?K?GCIIOSMUIKEc@EYAwAE'
                     },
                     'start_location' : {
                        'lat' : -7.566374600000001,
                        'lng' : 110.833299
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 287
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 43
                     },
                     'end_location' : {
                        'lat' : -7.5653495,
                        'lng' : 110.8600988
                     },
                     'html_instructions' : 'Slight \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Insinyur H. Juanda\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'h_em@miscTUUSWSQYK_@QaAQc@AYEC?g@GGAG?WCO@OBIBGBEBGFEDCFCFCFAF?F?F@F@F'
                     },
                     'start_location' : {
                        'lat' : -7.5674089,
                        'lng' : 110.8599096
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.5 km',
                        'value' : 1492
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 78
                     },
                     'end_location' : {
                        'lat' : -7.568382099999999,
                        'lng' : 110.8724773
                     },
                     'html_instructions' : 'Slight \u003cb\u003eleft\u003c/b\u003e to merge onto \u003cb\u003eJl. By Pass Krian/Jl. Raya Maospati-Solo/Jl. Raya Ngawi-Solo/Jl. Raya Palur\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'lrdm@sjscTDHDDDBDBFBF@F@F?FAFADAFCDEFSDY@U@MBS?C@CD]JkBTuD?qB?o@Ce@OqCK}BASKwAGwACi@?Q@OBSLeAb@wBDQ@EnAcF@EJ]\\yATs@\\eADIRq@v@_CRk@nA{Dn@}AFM\\oA'
                     },
                     'start_location' : {
                        'lat' : -7.5653495,
                        'lng' : 110.8600988
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '64.5 km',
                        'value' : 64470
                     },
                     'duration' : {
                        'text' : '54 mins',
                        'value' : 3248
                     },
                     'end_location' : {
                        'lat' : -7.395009699999999,
                        'lng' : 111.3451073
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. By Pass Krian/Jl. Raya Maospati-Solo/Jl. Raya Ngawi-Solo/Jl. Raya Solo-Sragen\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Raya Ngawi-Solo\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'jeem@_xucTBa@@U?SC]M{@GGACuAaB_CyCs@w@OQ_DwDKMoAsAc@c@WYqDeEiDeEOO{B_Co@k@mLgJg@c@wByAk@_@k@c@gBmAkBaByAaAsAy@KEwAcA_Ao@oA{@MIgAo@MGQKYO_@UgBaAMG{Aw@u@a@MGiAk@eBaAe@WaAg@a@Sy@e@[OeAi@y@]sAq@qAu@a@QkDiBwD{BcDmBSKQKqA{@yAs@aB{@yAu@}BgAg@WSKeJmEQKe@SqEuB{B{@_@OyAo@yFgC_CgAMOwBeAQGWKy@a@c@W[Ou@a@u@a@m@]yA{@_Ai@KG_Ak@cBaAgCyAc@YeBiAmF_D]QAAsG{D_DmBc@WIEkK{GsBsAMIy@i@uA}@KGmByAy@o@OKe@_@yCaCIGyCqBa@Yq@g@}HcFIE_Aq@gAu@yCkBsCgB[UmHqEa@UqBoAi@[{@i@gAs@SOOIiAw@KGk@]_@Wi@]wAu@}@a@QIk@SGCsA]mBg@wKuCaBa@eDy@sJ}BsH}AcB]cAQoB]yLqBg@IcG_AeL}BWG_MkC}Cu@EAyAe@_A[e@SuDoBcCiAMEsE{AYKiA_@e@OiDcA}Ag@mCy@eA]wDmAMCiA]KEkBk@sAa@yAc@EAuBo@o@SMEo@QYIy@Us@SEAe@OsCy@oCu@yC{@]KqA_@kA[KEiDaAcEiAu@S_AW}Ac@W@o@Ss@Sg@Qy@[qBs@k@Q{@e@KGECCEEGIEoAm@cB{@_Bq@wAm@mB{@eCaAu@Wo@Si@S[Ma@OWI]M[MOIIEAACACACAACCAAAAACCAAACCCAACCEIMWGKEMMYIWMc@a@_BOe@s@sBO_@Og@e@qAy@wCs@sBAAs@qBACOi@]iAe@yAY_AK[KYGSEKg@oB{@mCm@sBK[IUAC}@sCSu@o@_CYcAe@eB_AcCCKm@oBw@kCKW_@mAW{@Sm@_@cAGMgBaEISc@iAK]Og@Qs@Kg@UiAQu@I]Ka@EG}@mCm@cBACQ]aA_CQg@OYO]{AmDo@{AKSoBsEmEgKkAeC{C{GCGyAaD_FqK[q@a@iAcBkDYk@Wi@eA{Bm@iA[o@mA_CmEqIaGqKsAeCS_@s@qAoBmDuAgCu@sAc@y@Wc@Yg@IQaAcBIIQWSYsAeBKMMOqAcBs@}@aCwCqDgEqBgCg@m@g@o@k@w@c@g@]c@AAi@q@Y_@EG_@e@[_@AAU[a@g@GIGIYa@Y_@iB}Bc@o@]a@WYsAgBy@eAk@s@[e@uAaBW]w@cA[_@_BsBoBaCU]uAeBmG_IEEU[MQSWQSOUmA}AEEs@w@q@u@QYW]mA_By@oAo@y@w@}@SWsAcBSWGIW[MQKQMWGUK_@MkB?mADeAD{@Dc@Jy@@GH_B?iAEy@A]E[c@eDW{ASwAMs@SqACMEWGYAIWmBOiAIk@OeACk@COAGCOSeBCMGk@Is@Gk@Ki@GYYuA[qAQs@ACYaAQo@]aAe@wAKa@COCSQcBSyAEc@?C?CU{B]sC_@wCWwBYuBIq@AGg@{DIm@U_B?EAGo@}EM}@E_@OoAUgBu@yGMoAUsBAIKy@Ic@a@oCE[OoA]mCOqAUsBAM[qCKcAKeAMyAAG?Ga@oEYcDCSKqA?S?IYcDUwBEQo@_GEg@OqAQ_BGi@UmBGo@Ek@Ei@Ga@EQIU_@aAU_@a@o@[g@KQkAqBuAcCACoBcDEIsAuBOYq@iACG[e@aB}BEEEE]_@IK}@cA{AkBOSAAmDsEm@w@CEEEIMa@k@w@iAi@u@oC}DGGy@eA{AqBy@gAiBcCMQwHeKQWSWsAiB{@iAoBiCi@u@_C_D{@eAc@g@mDkE_@q@s@kAQ_@U_@yAyB}@qA_@m@a@e@MU_A}AcAaBQY[e@g@y@S]oDiFk@}@_@i@_@g@Wg@a@u@GKcA}AU_@oBaD{@sA[c@Yc@kAgBu@kA}@wAoB}CaA}AiAiBq@gAa@o@k@{@aAyAUYU[OQIIuCuDyCmDmDcEe@i@uA_B{BoCsB_C[]iFkGuBiCa@a@OMS[s@e@]UA?qAm@wB_A{DiBUMiAe@}@a@SEk@YICkAi@IC_@Q}@g@ICa@OCAeAg@_DuAcCiA}As@e@SwEuBeBw@{BoAEAwBu@_@MoCoA]MaAa@c@UOISOOMa@g@W_@_@u@kAcCoBeEIMqAsCO[Wo@GKYm@EQCK?M?CAK@W?MBMBKFSJQBGvBgDj@s@`AuAh@w@j@w@`B_C~@sAjAaBn@eADIJOdAmBTaANm@DY@O?EBO@U?W?AAi@Ae@Gi@_@{BGYSeA[{A_AmEUuAKo@Q{@Mm@YqAEUKc@c@_Bi@iBQm@EQQi@o@gCW}@K_@Qg@Sc@Ug@]s@]o@o@cA{@kAAAACEIyEsGgBkCaBsCGKg@s@iB}CSa@CGwDoGe@y@mA{BuAiCCEc@u@Ug@GOiCoFyBqEMWCCgBaEOY_@y@aAoBa@o@u@iA[c@q@{@OQ_CcCqBqBIIQUGGc@e@EGAAi@k@eBkBeAkAeCsCOQ_@g@]_@kB}Bg@q@eAgAeBqAkBuAuAaAmA}@OKuB{AiA_As@q@_@a@}FwFcB}AkBwBi@e@MOOQSYIMKSOSAES_@]y@Oc@CEGQGWEMEOAICOAKAS?O?K?a@?}@B[?{@Aw@?q@?Y?C?K@W@OBSJq@DSH]`@uBZiBN_AJq@TkAPy@\\{AXiAT{@BEZmA\\oAXeANi@Lc@`@yAJ]Ja@BGVeAJc@BODSHk@Je@Fk@@IDo@?[Ae@Eo@O_BAIMkAIMAMC_@AEEmACeAAeBA]Cm@Aa@C]AKIaAKaAKuAQyBAQEs@C_@Cq@AeA?W?[?MG_C?[EaDAw@?CKwF?a@EwCFKAMG{AAOAY?c@Ae@Ac@?Y?aA?y@@Q@U@c@DaAJmBJ_C@WFyAJkB@QBs@@m@NsC@q@Ds@NgDD{@@KJuBPsD@ULkCPcCr@iKHmCB}@?KBqE@qA@cC@{@Bu@PaDDo@FmAFiA?K@C?CDWTeAFQj@oB@EVq@N[p@aBPa@bAqBXk@h@eAFKhA}BDIXo@pBuDFM`AiBZo@JQL[N[Ro@Py@NoATkBBYDy@VqCB_@Fs@Ba@J_BJgARuBTuBj@{CHg@ZaBNm@FYF[TqAPoADQH}@Fc@?GPeB@MFs@HcAFmA@Y?qB?E?eA?U?e@Aw@?]?mA?SA}C?m@AeB?[@wBA_@?c@AgC?iAA}BA}C?K?kB?Y?mA?e@?Y?yA@_@Dc@RgAJq@Ji@Pu@Lm@RcANeAFgAA}@MoDOuEMcFOcDAi@@i@By@DoCJwEF}B@aAA{@Eo@Ci@ACSwBA[Aa@@SBSDMDMHQNYZg@fBiCnAcBd@s@HKJSHQDKNe@Hg@Fk@D_AFcA@EL_AZmBb@sCz@cFx@{Dv@sDfB}Hn@eD`@uBNu@BQX}Ar@wD\\mBZkB@CFa@H{@Dq@DkBAa@Ai@Cs@G}@WoEWiEs@{JYoDC]Q{BMoBMwBIcBGkAAS?ECgAAQ?mA?QT{CPaB?CPsBd@wD@ITcCRkBJ{A?ER}CBYR{BDk@@K^gE|AsXrByNhGoT?y@K{DA}@@k@De@Hc@j@_DT{@Ha@h@gBt@kCBI`C{IDQTkAT_BDa@D{@NcDLwB^uELiANcBT_BTuAXiAb@sAv@mB|@oBpBwDbD{Gl@kAFMb@aABGXo@Re@N_@HWBKDQBSB]BU?W@uADmBBsBBcABe@@UBS@K@Ol@_Hh@_JDcB?g@@u@KiAGe@Ge@Y_BOq@Sw@u@sDKi@i@qBa@}B}AoLuAeHKSQw@]{AYeAk@}Bw@iDi@uBQi@Oa@Sg@Sc@m@aAoBsCgAcAcB}Aw@q@c@g@c@s@o@sA_C}FK[K_@ESAU@WBk@TiCh@cDJ{AFoAD_@Jc@@Cz@kCt@uB\\eAX_ATeAPs@h@uDHc@Fa@F]Ng@dAcCdAqBRc@JWJWFQBIBI@G@E@C@G@I@s@@c@?[Ai@G_ACU?Y?i@Bg@HiAViDJqBF}AFuBBy@HeCH}ADo@D_@@ABQNe@b@eAtAwCvBwEt@aBNWRYlAwAl@o@HSHS@KBMBO?QA}@EyAAi@?g@BwABo@JiBJiCBSFSj@wAZs@Pm@@GHe@HgA@w@?UCUGUk@iASg@EKCGGa@Cc@J}A\\qGNoCBmB@kAA{@AsAKsEAqA?Q?q@H_B`@iEHw@f@}Dj@oEh@eDh@wBTi@Xg@hA{AlAqA~AmBpAaB\\_@ROZMlAg@n@[d@]^a@hBaCT]d@w@\\k@d@w@v@sAlAqBBGPW~@kAd@g@|@_Av@y@z@_AxAoBvAwBX_@BCb@a@pAq@|@c@p@c@\\Yb@a@n@s@h@q@JOd@u@|@iAxAkB\\e@tB_DDI^g@PYBE|@sAb@o@HKHMDGN[HSBIBIBM?G?I?OCQEWGQK]i@wA_@aAGOi@wASi@_@cAe@wASy@EM]oAWiAEMw@}CYeAS{@]mAeAgEU}@g@uB]uAO{@CWCWAS@g@D}@LgAHeAFo@F]PqBBa@J}@'
                     },
                     'start_location' : {
                        'lat' : -7.568382099999999,
                        'lng' : 110.8724773
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            },
            {
               'distance' : {
                  'text' : '173 km',
                  'value' : 173492
               },
               'duration' : {
                  'text' : '2 hours 32 mins',
                  'value' : 9121
               },
               'end_address' : 'Jalur Gempol - Mojokerto, Gempol, Pasuruan 67155, Indonesia',
               'end_location' : {
                  'lat' : -8.142855,
                  'lng' : 114.400198
               },
               'start_address' : 'Jalan Raya Maospati-Solo, Kedunggalar, Ngawi 63254, Indonesia',
               'start_location' : {
                  'lat' : -7.395009699999999,
                  'lng' : 111.3451073
               },
               'steps' : [
                  {
                     'distance' : {
                        'text' : '13.8 km',
                        'value' : 13830
                     },
                     'duration' : {
                        'text' : '12 mins',
                        'value' : 710
                     },
                     'end_location' : {
                        'lat' : -7.407675299999999,
                        'lng' : 111.4644249
                     },
                     'html_instructions' : 'Head \u003cb\u003eeast\u003c/b\u003e on \u003cb\u003eJl. By Pass Krian/Jl. Raya Maospati-Solo/Jl. Raya Ngawi-Solo/Jl. Raya Solo\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. By Pass Krian\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'xicl@}arfTVeCx@uGx@iHr@kGXcCZuCv@sGd@uD\\uC^_DFq@LcADYNiAHm@Js@LiAJgA@c@@C?Y?_A?K?kAA{@AQ?EAOEe@Kg@WwAWuACSaAwG_@cDKu@c@wD]gCi@cE[aCOkAUkBOoAWkCGq@CUWqCIaAGw@ASEm@Ey@E_ACa@Eo@GaBCi@GiACm@Aw@AkA@_ABi@BYHm@Hm@TyABM~@}ERcA^oBZwAz@qELq@BKh@kCFYZcBJq@F_@h@mFHs@VmCXeE@EHy@VyDHcAJ{B?AHsBJqC@c@HmCDiBDsADkBTiF@_@DSBOBORw@d@iBLc@`AqDFMPm@fA{DlAuEr@kCJ]L]\\u@nAsCb@cAnAiCt@iBN]DOl@cBZ}@l@sB\\gAZoARgA?EL}@HaA@s@Bo@@UBiA@g@D]FmBFmB@WBo@DcAHmBDkA@EDkBF}BDsB?kB?iB?S?QHmEBo@FcBFoB@K@[DkAHyAHsALwBz@kNJaBB]@MTeDDe@JcA?Az@qHFa@L{@L}@`@wCRwABQDYFe@Ly@\\yBDU?CNy@l@mDN_ANaAFk@f@uDFe@\\sCHg@?Cn@}ED]XaDNmBDg@LaBTuCF_AVcDPsBFm@N{ABSBOFe@Jg@Lk@Tq@fAqD\\oApAkE\\mADKZeAdBaGb@{AV{@~AaGNi@XeADOBMPo@`AmDPm@h@yBjAcFBIb@wBRcABWBi@?k@?SAMCUM{@Om@M[KUSc@W]AAMQ_@][SGE[Qq@[wBu@}H{BUG_Bi@q@]k@a@IGa@_@W]Y[a@u@Oc@M_@CUCMGWCQCWAIAW@}AFy@JqAj@_HDWBk@JgB@GHcB@WFeAFkA@INyCDw@@EDq@H}@F_AFs@Bu@Ds@HyAD{@FmADm@BWFkAFgABm@ZsEJcBJgBHeA'
                     },
                     'start_location' : {
                        'lat' : -7.395009699999999,
                        'lng' : 111.3451073
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '17.1 km',
                        'value' : 17094
                     },
                     'duration' : {
                        'text' : '14 mins',
                        'value' : 855
                     },
                     'end_location' : {
                        'lat' : -7.458768200000001,
                        'lng' : 111.6085702
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Ngawi-Caruban\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~xel@skigTDy@LuBDu@N}BF_A@KReDD{@Do@Fy@Du@H}ADi@DaAF}@JqBPoCH{@DYPoADURwATuAxAsJVcBFe@RqADSFa@x@qFBM~@_GXoBNaAh@uDfAmH^gCz@cGpDyVTgAJo@Fa@XcCL{@b@wCFYDMV}@FMj@}A|BwGJ[lBuFh@}A`@kA@Eh@yAlDgKlCyHJ]BEbBeFFOXw@h@}Ah@{AXw@Pk@La@La@@E~BkHr@yBd@}A`@oA~A_Fj@eBlB_GZ_AtEqNdAgDN_@FQBKDKDEBGj@}@f@}@`CwD`CwD~AkCVa@pAwBNUp@iA|BsDhBuCzA}B?AzCeF`BgC`EuGPUTa@`@q@RYVc@Zk@rAyBv@oAt@oABC@C|@wApAsBn@cAHMTa@Xg@Vc@Tc@f@{@Xk@P_@d@cADK~@eCFQDMl@iB`@oAv@aC^kA~@qCl@iBl@gB^gABK|@mC|@qCxByG`CqHhAeDvBsG`DwJdD}JvCcJTo@^iAX}@Pi@HUb@sAd@uA?AVo@La@J[Nc@Vy@Z_AN_@N_@JYNe@d@uAPk@Rg@J_@Tq@Tq@HSn@_B|@mCz@}B\\iAXw@\\_ANe@h@yB@IJq@Ly@He@J_AReANoABs@@Ap@mHFkAb@gGHu@@G^}E@MNyBb@gG`@qEj@eGJaBHaBPmAJyBRmBVqB?IXwCVeC\\aDPuBPwB@_@H_BHuBB]TqHPaDJyC@UTaGNkDHqAV{DhB_Wh@kGZuDXuE`@_I`AeFT_AZaAh@mBRg@x@aCr@}BhAgDRm@FQPc@h@qAX}@Xq@l@sABEjAoCBE`@oAlAyDBEt@qBRo@@AVi@lAaDJUx@wB~A{E~F{OtCcH|@eCfFgM'
                     },
                     'start_location' : {
                        'lat' : -7.407675299999999,
                        'lng' : 111.4644249
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.4 km',
                        'value' : 3399
                     },
                     'duration' : {
                        'text' : '4 mins',
                        'value' : 250
                     },
                     'end_location' : {
                        'lat' : -7.4871424,
                        'lng' : 111.5977183
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. By Pass Krian/Jl. Ngawi-Madiuni\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'hxol@qpehT|FpA`Ev@hI|AvH|ANBjDv@HBF@nFvA`B^rAXxD~@pDl@n@LpEp@@?^JnCj@J@vAXv@NjFx@|@R`@JTHPDj@^dAn@HDvBjAvCtAfAf@VNZPbAj@nBt@d@Pt@VXJlAf@RHbBt@l@RfE`BfCfAlBx@hAp@`EjBjCfAxBf@VFt@VlBVbAJ|A@B?|ANp@RXJ`Ad@'
                     },
                     'start_location' : {
                        'lat' : -7.458768200000001,
                        'lng' : 111.6085702
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '10.1 km',
                        'value' : 10127
                     },
                     'duration' : {
                        'text' : '9 mins',
                        'value' : 531
                     },
                     'end_location' : {
                        'lat' : -7.547990800000001,
                        'lng' : 111.6569509
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e to stay on \u003cb\u003eJl. By Pass Krian/Jl. Ngawi-Madiuni\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. By Pass Krian\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'riul@wlchTDOdAoBx@iAhAkA`FkD|AmAxAmA`B{ABEtDkFz@qAXg@Ta@Ri@Lc@He@\\kBlAwFl@oDdAuGr@cDl@sCR{@Lg@La@hAiD`@gAXm@^o@@Ef@}@p@cAVe@f@q@fAsAp@w@|BwB|F{F~@_AZ[VQVQx@i@lAo@lAg@lAy@`Ay@z@_AnBcCRUfBwClBcDtAgBrA_BrBiBhBkBtAaBx@aA|DcEh@a@bAy@rB}ApD}C`DkC~@w@hB}A~DcEjBeBfAaA~B}Ad@_@bBiA`Ae@pEkBHElRuIRQrJeIrAiAbFsErAcBVUFKHWFWDW@[?SGeAE{@?mI@qC?[BWBQHQJQNOdAg@nBw@bAk@VMjAi@j@SZIx@[jDqBpDoDv@m@jDeCzBaBpEwD|A}A^]jDyCfCyABChAk@dB_A`@WpAcAz@q@t@m@h@k@h@m@RUrA}ApByBzAsB`@k@j@}@X_@t@eApAgBjB}B@A`AsAR_@N[`CcGt@gB^cAf@iADKhBiEVu@z@kBDGBC?A@A@A@?DAFADAHAf@?\\CxC?nA@bD@^DrDp@fFx@h@JnB\\t@Jh@LpDr@PD~Dt@'
                     },
                     'start_location' : {
                        'lat' : -7.4871424,
                        'lng' : 111.5977183
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '22.2 km',
                        'value' : 22210
                     },
                     'duration' : {
                        'text' : '19 mins',
                        'value' : 1136
                     },
                     'end_location' : {
                        'lat' : -7.568174399999999,
                        'lng' : 111.8482367
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Bagio Sutomo/Jl. By Pass Krian\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. By Pass Krian\u003c/div\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : '|eam@}~nhT?gB?aAPqCReCLk@JmAd@eF@MVqC@MLcAZ{CBKBYHu@VcCV_DDi@@w@IeCAOUyBAYKqAY_EEqA?qB?_@@aB@]L_G?cA?wB?c@?_B?sE?cH?m@CoIGaCGqA?k@@i@Bq@\\{BZqDr@_Jt@{ONmE\\yKNwETkB@Ih@yAv@uBlAwCbB}Dt@{BjBuFz@aDf@{Bn@mHBc@l@iJh@{NRyHD}Dm@wHACGo@OeDOu@K[Y_AQe@e@eBeAwHq@kC_@mCEq@CcEWmCUaAG_@cB_FeC_IQq@S{@Mm@SaBQcBE_@Ek@YaEu@{FCK}@cFs@mDi@qCQ{@UiAS_AQkAIaA?CCo@@_A?cA@MAsB?}E?yD@kB?qBB_B?e@@YBS@KHc@DUL[HUHUHQFQNa@Pi@`@eAj@aB\\{@z@cC?AHYFYBIBIP{@TmA\\oB@G?CH_@Ha@Le@Zw@Tc@tB}DFIj@}@tAsCN_@b@_ALWHQd@kAz@_CFOPq@Ny@L}@H_A@[BaADwAHoBLwC?O@I@uAB_ADaBDi@D_AV_DHsAVgEHkATmB\\wBHcABYFaADy@?mAA]MoBKw@OmAQeAOy@CISkAWeBSuA_@oCOgAWwBIm@E_@A_@?m@D_AD{@Bq@@m@@q@Ac@Ek@K}BCw@EqAI}B?S?M@K?Q@K?KDUDQDOHWRe@~AyENg@h@aB\\iAZcAPe@Vm@R_@j@}@p@}@p@eAh@w@DER]HOVc@j@u@x@aA\\c@f@o@f@q@p@w@TYXe@Vg@Ri@Lc@Lk@Jo@H}@Du@D{@Bq@Dq@Hm@Le@JWTg@r@kAt@gAZc@Xm@Ra@DKJYVo@XeADOF_@XcB?CHe@Rs@Tw@Vk@Zo@^q@HSLYFSHWTs@Ha@DOVsAJi@D]F_@@GDYNkAToBLsAHw@Hm@PyADY@MHg@BQDWFSTq@Tk@`@_AN_@Pc@Ng@J]La@FULm@BODQBS@Q@Q@K?M?Q?O?YAe@Cg@O_FSmEQ_DGmAIiBK_AI_@a@eA[q@Oa@UeAMw@Wg@Ka@K_@Og@O]k@}@s@_Ae@g@i@e@i@a@eAo@YQYQg@Ya@UuCcBEAaBgAo@g@]]OOGGW]We@]y@Ww@_@gAUm@Ma@G[Kg@Km@ASAGA_@C_@?u@B{@JgAJ}@PyAHm@Ls@Ps@Tm@Zu@^w@r@kA`@k@pA{AfBqBz@_ALOJMHOTm@DM@GHe@FOH_AJcBB]D}@JuA@IHoA?GJwAFw@B_@Bg@Bq@JcBBm@V_FNqDB_@\\aDj@}GD_@RmCFcAReCHsATkCPoBPoBBc@HsAPcDPwBJ_BBg@H_BLgB@URqDLeBDo@?GHcADo@@UTiDDo@Di@B_@Ds@F_A@MPeCJ_BFeABWBk@Dg@FkAJ{ALgBJkB@IFaAFu@NwBX}DFaADq@DaA@c@@O@u@AWCs@Cu@?EGcBG}ACk@Au@?c@BaADy@H{ADc@@GB_@@[LwB@MFiALsBH_BFs@Fq@?CHi@PmAPeATwAVkA^_BPq@d@{AJ_@b@uAL]Tm@^eAZu@@Ab@aAv@_Bd@_AJUDMDI~@sBNW|@cBt@qAf@aADEh@eAj@kApAgCz@_B@ANYj@kA'
                     },
                     'start_location' : {
                        'lat' : -7.547990800000001,
                        'lng' : 111.6569509
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 237
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 12
                     },
                     'end_location' : {
                        'lat' : -7.569293999999999,
                        'lng' : 111.8500657
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Nganjuk\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`dem@ojtiTJSr@sADI?A^s@Zm@BCN[^s@h@cA'
                     },
                     'start_location' : {
                        'lat' : -7.568174399999999,
                        'lng' : 111.8482367
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '6.5 km',
                        'value' : 6519
                     },
                     'duration' : {
                        'text' : '5 mins',
                        'value' : 328
                     },
                     'end_location' : {
                        'lat' : -7.599368999999999,
                        'lng' : 111.8999878
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. By Pass Krian\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`kem@}utiTdAoBtAiCJQLWR[?ANWPa@FSFQ@KBKBQBU?A@WBa@B[HcB@K?C@SHoA?G@KJkB@S@?FiALcAHw@?C@AHm@L{@BOHq@Hk@LmAF]?AXoBBIFu@BORsATsANi@h@kABIlDcH~BiE`AgBBCHOh@kAvAoC`AkB@Ej@mA@AtBwDnEgIbE_IdBcDlAyBBCHOHQn@iAhC{EtCgFn@iAdAmBP]|BiEjBqD@A^o@p@qApA_C`B_DxBwD~AwCdAiBDABABAf@w@|@aBf@_A^o@`AcBnC}ENW~A{CvB_EzEkI`BwChAkBBEp@kA\\o@NY`@s@JOh@eAHQ?CFWx@{AR_@LQLYHMzByDp@qAP[nCeFVe@V_@rA_BBA@CHIpAqAX[lAuAp@q@JKf@g@PQzAaBf@g@rCyCnAqA^a@PSnAsAz@{@b@a@n@q@f@k@JQDMJY'
                     },
                     'start_location' : {
                        'lat' : -7.569293999999999,
                        'lng' : 111.8500657
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '35.5 km',
                        'value' : 35478
                     },
                     'duration' : {
                        'text' : '30 mins',
                        'value' : 1814
                     },
                     'end_location' : {
                        'lat' : -7.5600896,
                        'lng' : 112.2018665
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e1st\u003c/b\u003e exit onto \u003cb\u003eJl. By Pass Krian/Jl. Panglima Besar Sudirman\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : '`gkm@}m~iTAAAA?A?A?AA??A?A?A?AOQUWKSGSAOAQ?Y@]Z}JBg@?UTyGz@gXPuGL}DH{CBy@BkAHiC@k@LaE?QFkBBqABg@J_@F{ABa@NyFRaG@KLyEJ}BL}CNwDHiChAo`@PoFVuG?IDy@@O?G@_@@UB_B@i@@mAJaDR{G@e@LoENiDJ}CJ}D@e@F_CFuCDsAh@uQJgC?Wn@iRBkAhAg_@@MJ_CFsBb@gORgGXsJVwId@gPp@yULqDd@sPfC}~@DqA\\yJ?y@@a@@UB{@?K@c@@_@?]FwBDaAJqEV}INuELwEFmBBiA@kCAwGD{G?K?cC?oA?mAEo@A[Cm@IoA[qGCe@IiBS{DG{AIwAO}CKaB@AUeEAMOcCGuAMyCIcCGuAGkBEk@EqAOeD?[Cq@GqBGmBQoFGeDEqAG_BMgDGaCSsFMmEKcCGoAKmFAQCk@KcDEgA?AMwEEoAOcEi@aPIyBIaD?AIqBKyC?MSmGIaCGiC[wLScGI_CGmBIyBEiAI_BCcAIwAMkCD]F]@GDKNOPS\\c@@?HIDGDEFGBEBGBGHSJ]Vs@DIZcAh@eBBKb@qAf@oAd@sAp@gBh@uAj@yA^aAHSVq@@EHQ\\}@f@uAPa@n@cBdAsC@CJ[X{@Le@HYHWBOBS?G@M?M?OAa@AE?MAICs@WkFAQ_@wHGaAMyBaAoPEgA?ACiB?_@AgA?}AAs@AsFB_ABi@Fw@`@yE~A{PPmBDa@Z_EV{D@Gn@yHNkCA]WaDIg@McAe@qDE]CUWgB[{BGc@QeASwAk@aEy@qFg@eDQkAcAsHCMEc@KuACo@AI@k@?_@?K?[AcAGqB?SEu@I}@ASWiDIa@EOEQGOKWUg@S_@MUi@aAaB_DIQOWGKEMWg@Ww@Qg@Oq@MkAKeAAYC_@Cg@Aa@?AA}B@K@wD?mACaAE{@AEAKEi@Gc@G[Oc@Og@EIm@kBm@iBCOACG[k@iDUaB_@aCa@oCEWCO[qBGa@AOCMASAS?Q@U@w@@q@?CDsB@UBu@BqADaCDkC?U@Q?M?IDsBB}A@e@DgB?QDUDYNo@Jk@DSDO?ABINg@\\iAT_ADSDOBQD_@Fg@@W?A?]A_@G_BKkAOeBKsAEa@Ec@IeAASAEAKQaCWmDAOCWK{AE_AGkBAg@Ea@AOCOCOCKEMEKEIGIGKc@_@MMAAOQUUSUc@g@KOkAuB_AeB]o@IQgAoBKUc@y@a@w@q@qA]k@u@yA_BwCaAkBi@eAIQk@gAaAiBKSoCiFS_@qA}BEKq@kAEIIQS_@Sa@e@aAKYQg@I[e@oBGUs@yBaAeCSq@Wq@Wq@gAwC{@_Cs@qBeA_De@uAaCiHwBwG{@eCUm@CEa@w@Ua@QWEIm@}@uBwCw@eAOSW_@KO_BwBa@g@EIm@w@QWe@q@aDoEKOo@w@m@{@q@_ACEEEeAwA_CaDyCcEc@g@g@o@mBsCwAgBY]m@{@k@w@u@cAyGiJ}AmBwBwC{AsBY_@Ya@MQKQGOEOCOAQ@U@QDODQPi@Rq@J]FUJ]b@yALe@Ng@\\wARs@f@gBd@{AH]l@cC|B_It@sCJ_@fAkEPm@x@aDXkA\\qABONi@|@mD\\oArAuE@E|@kDh@mBRw@n@kCDQDO?ABK@K@I@K@K?E?G?CAEGWmAmESw@u@kCEOg@mBc@_BQq@Ms@Io@Ey@AECi@Ca@E_@Ig@Om@Me@Ok@c@aBi@qBg@iBGY[eAcAwDCMCGEM_@wAgD{LwAsFU}@a@{Aq@_CoBuGqAwEoBqHuBaIyAwFyAuFu@yCq@kCaAcEACa@{AIYqGkUUi@UOKEIE[Qo@]iAi@kAi@}FkCCASIA?AAs@]_By@w@]s@YAACAw@a@}BiAeCqAc@WAAAAkC}AGEA?AAGECAm@_@s@_@}CkBUMCCs@g@CACCi@[oBqAGCg@]AACAgAq@sAy@CAKKAACAAAiCgBwByAA?sB{Ao@c@CC'
                     },
                     'start_location' : {
                        'lat' : -7.599368999999999,
                        'lng' : 111.8999878
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.1 km',
                        'value' : 2090
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 105
                     },
                     'end_location' : {
                        'lat' : -7.5464245,
                        'lng' : 112.2146271
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Nurcholish Madjid\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'pqcm@ulykTCAo@a@CAAAs@g@AAAAeAm@SMyB}Ao@g@u@g@k@[e@Y{@k@g@_@IIQKOMYUKGAAAAyAaAiAq@}B}A{CgBA??AiCeBiEyCeCiB{@u@s@k@uAqAq@s@_@]AAQSaAgAa@e@c@k@_B_CKOcBgCqCiEgCqDgAeBi@w@{@oAAAEEGK'
                     },
                     'start_location' : {
                        'lat' : -7.5600896,
                        'lng' : 112.2018665
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.7 km',
                        'value' : 723
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 36
                     },
                     'end_location' : {
                        'lat' : -7.5416417,
                        'lng' : 112.218927
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Yos Sudarso\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'b|`m@m|{kTy@mAaAoA]c@k@s@_BqBwA{Ao@m@kBkBoBgBMIGEUKIEkAi@]K_AYqAc@'
                     },
                     'start_location' : {
                        'lat' : -7.5464245,
                        'lng' : 112.2146271
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.6 km',
                        'value' : 624
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -7.536603099999999,
                        'lng' : 112.2212385
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Nurcholish Madjid\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'f~_m@iw|kTWIi@QwC}@wAa@o@SWGsAa@GCcFyAiCs@{Ae@GCOIKIGIIKIOO]'
                     },
                     'start_location' : {
                        'lat' : -7.5416417,
                        'lng' : 112.218927
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.0 km',
                        'value' : 1041
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 53
                     },
                     'end_location' : {
                        'lat' : -7.537534299999999,
                        'lng' : 112.2306267
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Panglima Besar Sudirman/Jl. Nasional 15\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 15\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'v~~l@we}kTEUAQ?S?Y@S@a@HyAXcEBYHgBBq@F_BFkABi@RgFHqARwCJyAb@uH?GPwD'
                     },
                     'start_location' : {
                        'lat' : -7.536603099999999,
                        'lng' : 112.2212385
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 274
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 26
                     },
                     'end_location' : {
                        'lat' : -7.5352679,
                        'lng' : 112.2315405
                     },
                     'html_instructions' : 'Turn \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Abdurahman Saleh/Jl. By Pass Krian\u003c/b\u003e',
                     'maneuver' : 'turn-left',
                     'polyline' : {
                        'points' : 'pd_m@m`_lTIICCCEEGg@Gq@SkAYWI[IMEm@Qk@Ok@O}@W'
                     },
                     'start_location' : {
                        'lat' : -7.537534299999999,
                        'lng' : 112.2306267
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.8 km',
                        'value' : 762
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 52
                     },
                     'end_location' : {
                        'lat' : -7.536925000000001,
                        'lng' : 112.238185
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Seroja\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'lv~l@cf_lT\\u@HUz@}BHOXs@No@Lu@F]Jm@RkBBU@OBi@DeADo@Bw@DgA?CTqBLaAHk@Fo@BOb@yC'
                     },
                     'start_location' : {
                        'lat' : -7.5352679,
                        'lng' : 112.2315405
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.2 km',
                        'value' : 152
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 89
                     },
                     'end_location' : {
                        'lat' : -7.538234399999999,
                        'lng' : 112.2378368
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e to stay on \u003cb\u003eJl. Seroja\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'x`_m@so`lTlDx@PDLBH@D@F?F?TC'
                     },
                     'start_location' : {
                        'lat' : -7.536925000000001,
                        'lng' : 112.238185
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.3 km',
                        'value' : 1292
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 91
                     },
                     'end_location' : {
                        'lat' : -7.538124799999999,
                        'lng' : 112.2495006
                     },
                     'html_instructions' : 'At the roundabout, take the \u003cb\u003e1st\u003c/b\u003e exit onto \u003cb\u003eJl. Gus Dur\u003c/b\u003e',
                     'maneuver' : 'roundabout-left',
                     'polyline' : {
                        'points' : '|h_m@om`lTAA?C?AAA?A?C?A?A@C?A?A@ACIAC?AAC?A@E?C?E@EBS?K@wA@]PmEFmBBa@FcADw@Bm@FyBBmAHcD@iB?KAe@CaCAe@GaA?OG}@Ac@EiBCs@AUIkBKcCG_AEw@ASIoAKoA'
                     },
                     'start_location' : {
                        'lat' : -7.538234399999999,
                        'lng' : 112.2378368
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '25.7 km',
                        'value' : 25745
                     },
                     'duration' : {
                        'text' : '22 mins',
                        'value' : 1308
                     },
                     'end_location' : {
                        'lat' : -7.4947327,
                        'lng' : 112.4428942
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. By Pass Krian/Jl. Sukarno Hatta\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. By Pass Krian\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'fh_m@kvblTGoAQ_AAEGwAEq@I}AG_A?GAICq@K}BACKaBGqBMqBCiA?Q?{BCeB@_C@mCAkABm@?}A?]DkCHkDJaGFmDNkF@aABqA\\oQDiBDmCL_OFeLBuBB{@Bg@J{AN_B@Cd@qCLq@Je@H[RaAFWRy@d@eBv@mC\\kAVo@vAqD@ElC{GHQBEP_@`@}@\\o@xDsF`BuBxCiDbFeG?Ap@w@hA_BtCgEz@}A`AoB|BsFx@{Bf@sAp@eBHUb@oAjBoFpAuDz@qBxB_FtAsC`LoUv@qBDGHYHKBGXq@Re@JUFMh@oAz@oBpC_GFKfAoBn@mAr@oA|AmDTk@`CkGrAaDP_@l@uA|AcEZw@HU\\_A|EiNbAyCd@qAVs@JY^}@Zs@Ti@FQHQRa@b@_Ab@y@lAaCnA{Bh@aAhB}CxAuCPc@LYVy@Pw@XyA^sBb@eC^uBXeBz@gEn@iDDUrAiGlAaFRw@h@yBd@iBNi@BKRs@^uA^qALc@DOz@{C^uAd@_BZmAH[`BeG^sAXaAz@{C`B{F\\mA`AiDLc@Je@FUNs@?ATsAHw@L}BFgARkDHsA?INgBFy@PqCDaAB_@?E@oEEgBAa@GeBAI?MCk@Es@Ca@GoAE_AOoCAq@?ECgA?I?e@C_C?O?Q@iCA}@@yCAy@?QAm@AOG_AG_AM}AQw@Ka@_AaDKC?AGSEIsAeDgEoKoA_Dm@uAMYqBeFeCkFcAkBW[SYcCoCs@u@{FsGeEwEg@i@iAqAgDaEmB{Bg@k@kAoA]a@ACEE_@c@AAAAaAgAWWy@aAqHkIiGcJAAIIGIAACE_A_BcAcB?AAAYc@aAcBQ[oAwBoAwBEI_AaBcAoBiAoBAC?ACCsCsEw@mAAAACo@aAg@o@i@u@kBsB{@u@CCCAy@u@uCmCCCiC}Be@a@yE_EaEkDeLmJQMsAeAsDsCu@o@sAmAUQAAqBeBy@u@cA_AoCoCeBcB{@{@kBoBMM{@{@mAkA{A}A{@}@AAq@m@}@}@eEyDSYMSMYYcAq@eCm@oBKg@EQMg@UaA_@gBKi@CKIc@MaAKsAQ_CO_C?OIwAGmACUOeBWoBa@{DQgAWuBE]Mu@AEK{@]iCEYIc@SqAKe@GUEQIQKUOYYg@?AS_@OUKOKKKKi@e@qAw@}AeA}E_Da@WgBkAiAu@oA}@_BcAw@g@gAw@KG]UoBmAiBoAoA{@qA{@{A_Am@_@i@e@OQOSSYKUMU]{@Ui@Sg@u@{AGKa@m@_@a@_@QaCuAwAq@o@YwAo@qBw@_CcAyCkAgEmBm@Yy@YUICCmAe@QQ]_@OUO]mGgOuG_P]}@q@_BO]ISGMEQI]Yu@k@oAm@kAOW[a@[_@YYi@k@_@[iJiGgJcGAC[U_HqEm@a@e@YYSGEOICASM{@m@kA}@m@a@gAu@IIOKQO_@][_@_@i@Sa@[}@i@gBo@sBOc@Ua@Ye@SWcAcAGEGCIEkCiAwAi@}DyA_DmAKMYSmBs@uAo@MGuB{@WKCAGACAa@MQE_A]kAi@c@YaAo@]a@OWKWIYM]Qm@OyAEk@Ck@'
                     },
                     'start_location' : {
                        'lat' : -7.538124799999999,
                        'lng' : 112.2495006
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.6 km',
                        'value' : 577
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 29
                     },
                     'end_location' : {
                        'lat' : -7.491458499999999,
                        'lng' : 112.4466494
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Brangkal/Jl. Raya By Pass\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`yvl@aohmTOkBKu@Mk@Qg@AECGMYYe@IMW[a@a@e@_@c@WCCUMGGKGq@a@eAu@wAaAs@e@GC]Uk@[MKCC'
                     },
                     'start_location' : {
                        'lat' : -7.4947327,
                        'lng' : 112.4428942
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.4 km',
                        'value' : 2410
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 144
                     },
                     'end_location' : {
                        'lat' : -7.496630799999999,
                        'lng' : 112.4678453
                     },
                     'html_instructions' : 'Turn \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Gempol - Mojokerto\u003c/b\u003e',
                     'maneuver' : 'turn-right',
                     'polyline' : {
                        'points' : 'rdvl@qfimTDW@I\\aBj@yCXuAVmAJi@Py@@GBOd@{B`@mBDWDQ@GNw@b@yBDSn@uCR{@BMdA}EBOLs@ReAJo@Je@\\}B^qCt@uF`AoHRcBDYh@mEJw@Hk@BSZ}Bb@kDL}@Fg@~@{FLy@?CXwBToDXeE@Q@M'
                     },
                     'start_location' : {
                        'lat' : -7.491458499999999,
                        'lng' : 112.4466494
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.6 km',
                        'value' : 580
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 29
                     },
                     'end_location' : {
                        'lat' : -7.497292899999999,
                        'lng' : 112.47306
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Gayaman\u003c/b\u003e',
                     'polyline' : {
                        'points' : '|dwl@akmmTReBRqC@G`AmOD{@DuAJqB'
                     },
                     'start_location' : {
                        'lat' : -7.496630799999999,
                        'lng' : 112.4678453
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.9 km',
                        'value' : 886
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 46
                     },
                     'end_location' : {
                        'lat' : -7.4977003,
                        'lng' : 112.4810707
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Gempol - Mojokerto\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`iwl@sknmTJwBJgC@YRsFBu@DcABu@FwA@Q?O@U@SJkC?KFaBFqC?q@?kA?MASAYCk@Ew@Eu@'
                     },
                     'start_location' : {
                        'lat' : -7.497292899999999,
                        'lng' : 112.47306
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.6 km',
                        'value' : 617
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 31
                     },
                     'end_location' : {
                        'lat' : -7.498469200000001,
                        'lng' : 112.4865903
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Bangsal\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'rkwl@u}omTCa@?MAQ?SAW?]B{@@]Dg@TyCFq@TaC@I@KBYh@wE`@iDLaA'
                     },
                     'start_location' : {
                        'lat' : -7.4977003,
                        'lng' : 112.4810707
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.5 km',
                        'value' : 1537
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 77
                     },
                     'end_location' : {
                        'lat' : -7.499192099999999,
                        'lng' : 112.5005027
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Sidomulyo\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'lpwl@e`qmTBOFk@Dc@Bc@Bi@@a@?E?o@DqD?M@a@BcC?o@?qBBwB?MDqD?w@?_E@]DoDBqA@{A@w@@k@?K@}ABsA@aB@QTaF@IBo@PeDRkE'
                     },
                     'start_location' : {
                        'lat' : -7.498469200000001,
                        'lng' : 112.4865903
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.9 km',
                        'value' : 891
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 44
                     },
                     'end_location' : {
                        'lat' : -7.5001605,
                        'lng' : 112.5085274
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Sawahan\u003c/b\u003e',
                     'polyline' : {
                        'points' : '|twl@cwsmTTuDBo@JcBHuAJoBXuE`@sG@OZaFj@yI'
                     },
                     'start_location' : {
                        'lat' : -7.499192099999999,
                        'lng' : 112.5005027
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.5 km',
                        'value' : 2480
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 124
                     },
                     'end_location' : {
                        'lat' : -7.505978699999999,
                        'lng' : 112.5301288
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Gempol - Mojokerto/Jl. Raya Ngranggon\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Raya Ngranggon\u003c/div\u003e',
                     'polyline' : {
                        'points' : '~zwl@iiumTFaAhAyPZyCZsCLuAJqAxAyOHg@LcAHg@FQ\\yAVaARcADKXmAbCoInCuJjDoK\\cA?A`@uAZwA^wB\\iBNu@t@mEF[Hm@Jm@Ny@j@qD'
                     },
                     'start_location' : {
                        'lat' : -7.5001605,
                        'lng' : 112.5085274
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '3.3 km',
                        'value' : 3273
                     },
                     'duration' : {
                        'text' : '3 mins',
                        'value' : 178
                     },
                     'end_location' : {
                        'lat' : -7.515573099999999,
                        'lng' : 112.5580024
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Gempol - Mojokerto/Jl. Nasional 24\u003c/b\u003e\u003cdiv style=\'font-size:0.9em\'\u003eContinue to follow Jl. Nasional 24\u003c/div\u003e',
                     'polyline' : {
                        'points' : 'j_yl@ipymTTwAvA_IXsAdAwFvAaHh@iCt@kCfBeFl@eBBGd@sAd@yADKd@{ADMl@kBh@eBRm@Tq@`@oAPq@Pk@DOLs@Je@VcB?ALy@TuBNwAD[Jy@NcApCkQPmAr@wF@EDa@PuAZeB\\{BDQJq@Jm@TyAR{A@CFYJ_@BGv@kBVi@HSb@}@~@oBtAuCfCaF~AoD'
                     },
                     'start_location' : {
                        'lat' : -7.505978699999999,
                        'lng' : 112.5301288
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.3 km',
                        'value' : 260
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 19
                     },
                     'end_location' : {
                        'lat' : -7.517885300000001,
                        'lng' : 112.5578621
                     },
                     'html_instructions' : 'Slight \u003cb\u003eright\u003c/b\u003e onto \u003cb\u003eJl. Airlangga\u003c/b\u003e',
                     'maneuver' : 'turn-slight-right',
                     'polyline' : {
                        'points' : 'h{zl@o~~mTh@OfCP@?~AJ`@Bl@Dv@DF?j@A'
                     },
                     'start_location' : {
                        'lat' : -7.515573099999999,
                        'lng' : 112.5580024
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '2.3 km',
                        'value' : 2288
                     },
                     'duration' : {
                        'text' : '2 mins',
                        'value' : 123
                     },
                     'end_location' : {
                        'lat' : -7.5243343,
                        'lng' : 112.5775262
                     },
                     'html_instructions' : 'Slight \u003cb\u003eleft\u003c/b\u003e onto \u003cb\u003eJl. Brawijaya\u003c/b\u003e',
                     'maneuver' : 'turn-slight-left',
                     'polyline' : {
                        'points' : 'xi{l@s}~mTb@e@`@}CXcBJk@F[VqAj@sCpAkGR_AZ{AZmAb@mB|BoJ|@wDn@iCp@yCXqAXoAh@{BvAqGZsAhA}E\\wAF[l@aCBGF]XeAJ]@E@O?CDQDMf@oBd@eBf@oBFWXsAd@iC'
                     },
                     'start_location' : {
                        'lat' : -7.517885300000001,
                        'lng' : 112.5578621
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.0 km',
                        'value' : 1029
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 52
                     },
                     'end_location' : {
                        'lat' : -7.525919299999999,
                        'lng' : 112.5866909
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Punggin\u003c/b\u003e',
                     'polyline' : {
                        'points' : '`r|l@qxbnTBILs@@IJk@@IV_BLy@@IF_A?GDw@DoAH_B@EDO@_@LeD?M?GBa@BaAFcAJcCBk@B[Fe@Hk@Ho@l@}DBOHe@Hm@PaAd@iC'
                     },
                     'start_location' : {
                        'lat' : -7.5243343,
                        'lng' : 112.5775262
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '1.3 km',
                        'value' : 1268
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 64
                     },
                     'end_location' : {
                        'lat' : -7.529061100000001,
                        'lng' : 112.5977403
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Gempol - Mojokerto\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~{|l@yqdnTXyAd@{BBONs@D_@DWDi@NeB@GRwAHi@NaAx@yDfA}E`AoEnAyF\\}ABIBKHc@Ns@BGXwADOBOJg@@I`@cCBOZsB?C@G'
                     },
                     'start_location' : {
                        'lat' : -7.525919299999999,
                        'lng' : 112.5866909
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '0.5 km',
                        'value' : 544
                     },
                     'duration' : {
                        'text' : '1 min',
                        'value' : 42
                     },
                     'end_location' : {
                        'lat' : -7.5300822,
                        'lng' : 112.6025618
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Raya Kembangringgit\u003c/b\u003e',
                     'polyline' : {
                        'points' : 'ro}l@{vfnT@KJs@NaAHm@@Gv@uGNoAXyBNmAd@oDF_@@M'
                     },
                     'start_location' : {
                        'lat' : -7.529061100000001,
                        'lng' : 112.5977403
                     },
                     'travel_mode' : 'DRIVING'
                  },
                  {
                     'distance' : {
                        'text' : '13.3 km',
                        'value' : 13255
                     },
                     'duration' : {
                        'text' : '12 mins',
                        'value' : 692
                     },
                     'end_location' : {
                        'lat' : -8.142855,
                        'lng' : 114.400198
                     },
                     'html_instructions' : 'Continue onto \u003cb\u003eJl. Gempol - Mojokerto\u003c/b\u003e',
                     'polyline' : {
                        'points' : '~u}l@_ugnTl@gEBOL{AFw@@MB_@Dw@?KPyCHkA?I@K@IVwCd@iE\\gDHq@NuA?IFi@PcBLwABO^kD@E@K^qDJw@JeAFo@LcAJcADa@DYJk@Jc@Ji@@G@AV{Ah@cDRmANaALs@Lw@N}@RqAF[Ha@BMToAFWBINk@?Aj@oBRq@Pi@n@{BFSH[\\iATe@Tg@\\k@@CfAmB^m@h@u@NKHIPIRIz@Ub@Et@C`@Dh@JF@r@Pp@NfCr@xGfBrHrBrAZdAXj@LLDdAV`@Jn@PbB`@RFF@dBb@lBf@rA\\fCn@HBhAXp@PjD~@nCr@tA^^JH@xGlBl@P~Ab@X@RB`@Bl@?h@EFARCh@Sd@]b@a@JMBCPUR[HOLK`@gADML]FOPe@J[HUL[dAuCVu@f@sAf@sABEhAoCp@_BVs@Xq@@E`A_Ct@mB\\w@FMHSpAwC|BiF@Cz@kBpAuCVg@BIHQdBaEXs@HQlAmChAgCnAuC\\u@JWvAcENg@^iALc@Vy@Pk@Vu@Po@Rm@Tw@L]z@mChAiFtAkHNw@XuALw@X_B@KLk@XcBj@aEBQ^{CFc@@KJeABMRgBTsBj@{EPiBXaC`@aDx@eILkAN}AVcCZyCDk@Hs@TqBBMBK^{Bz@mELi@`@eBVcA@GLe@r@wBTk@~DsJ^eA`@uALo@Lq@Jy@Dy@Ac@EgBEeAE_A?oAFwALmANuAd@}EFm@PyANeBFq@@e@B_@Bs@JyBD_AB_@B[FcB@OB_@FaB@KFkAD_ABYDe@F}@NuB@U@S?U?SCKCICGCG]e@WY{@s@g@a@_@WaC{AYQYO}E{Co@_@kA_Aq@m@o@y@KOa@q@m@aAaA}AW_@Wc@u@oAWa@i@k@g@a@WSQMe@Yu@c@?As@]YS]UQQOSKUEOACEQ?IAq@?_@BUDm@L}@@IDc@NiA@KPoAb@gCDYCa@d@}C@CJw@@KFe@@KXkBPkAFYBMDMDINu@?ALeA\\yDHs@@IFa@@K@MFe@?EN}@@ABSHe@Hy@AG?A?A?C?I@EBOBU^qCNu@@GB_@`@{CD[NiAFc@DY?A'
                     },
                     'start_location' : {
                        'lat' : -7.5300822,
                        'lng' : 112.6025618
                     },
                     'travel_mode' : 'DRIVING'
                  }
               ],
               'via_waypoint' : []
            }
         ],
         'overview_polyline' : {
            'points' : 'loag@}rckSddFzaBxiHmgCdOaaJdrCywBni@meCtvBiuCiSc}Bvm@zOvTqz@lOwyAf}@atBjyAkw@vkFkxBpsBwqAvf@up@zuA{dHgi@{uCkeAg`Ftc@{uC|mAcmDwf@okGjwBwcFvMcfH{}@_~C~mAy{BsA_`Cm@ofCp_BioEhg@owAdjE__BfhAo}Bg`Ac}BxkA}}EjtAogAfZmSvtAb[b~CjAr}@ibKqEiiFylC{sG`cBazEtt@}}GpsEmiDvuBylEfqAmlArN_qD`WyeAmf@}aFhwAueBfe@eiAG}|B`L}gC|BqgBrVc`B~rEubB`dCyaBt@gsAnm@wgBz{CcKtmCcwBtsFqiCvpAirAf}Bhj@tcCyPfmBm}ArgDw_J|_BetKvOgpJ~nBg|GoI_jIjWefErsAkvBvi@_Xqx@iuBmwAubBeh@{Ea~@}f@zJuvHl^cwIbm@u_C{b@mw@aiB}|A{vBun@aOegBxu@wiEnwBy`Cp{CymCf`BacDbqDyzC~sDq_EzwBkjEtpCu~Dl}Aoh@vqBy{Cfu@irBpe@s`Auc@gtAixFap@ipEeXczDssAqo@iqFdd@{oBz`BcvJbxAepJbsAmlBxw@_|BrvBsN~yCjBv{BzWhj@usA_qBewGk{BanIgy@gxBs}AcQg_B_vI|J_iG}fBggE{{CwsFmuAssFxKupIkm@uwHfpAieFloBkfHvTupFoj@iyAaeJk`Dd}B}wHdSurAynAgdAk_CmzDenBo|Dwk@kb@gpAkhAcuAgpBgtAkzB{CctAim@kuC|PqxDhuAoVdtAey@`aDksDr`FexAfmAyeBlp@__Aqe@uz@}|BecCcjAypDc~@qfBkq@jPe_B}x@ugBusEqgDsfA}{AcxDocAqyA|J}mCnuCyfB|{BwbCjoEqfDpkGw_AxmE`@lmBigA|eG{lDbxEo_C|iBagBbsBo~@`LgvFuMaaHf`BqsHnpBmpNrFwvEkU{{CyeIqdFk}GmlCg_EqyHuaAicG{zEihGqa@a{AysActCgu@{aE~~AgjSjK{qH`iBs|FdbAajScKcnBt]}qD|aEmwKhk@mwFxm@efB~nBhNzkA`]ds@syAldD}jDn}ByoBlg@{r@xF{qCeKg~Fxb@ivBjp@kdEgC_jFjz@ixElqD_~Grk@sk_@}\\ouFwlC}bGfSu{ByzAwxDw`EyyCxFc}Djv@cgFzkBgtEbe@{iDwcBuaDsbE}wFqbE{}D`m@kzHteCgkLpcAouGf|@{iAh{AoWn~@k~DoCywBuE{dB'
         },
         'summary' : 'Jl. By Pass Krian',
         'warnings' : [],
         'waypoint_order' : [ 0, 1, 2, 3, 4 ]
      }
   ],
   'status' : 'OK'
}";

        #endregion

        public static List<string> SuggestionPlaceIndonesia = new List<string>()
        {
            "Aek Kanopan","Arga Makmur","Arosuka","Balige","Banda Aceh","Bandar Lampung","Bagansiapiapi","Baganbatu","Bandar Seri Bentan","Bangkinang","Bangko","Banyuasin","Batam","Baturaja","Batusangkar","Bengkalis","Bengkulu","Binjai","Bintuhan","Bireuen","Blambangan Umpu","Blangpidie","Blang Kejeren","Bukittinggi","Calang","Curup","Daik","Dolok Marawa","Dumai","Gedong Tataan","Gunung Sitoli","Gunun Sugih","Gunung Tua","Idi Rayeuk","Indralaya","Jambi","Jantho","Kabanjahe","Kalianda","Karang Baru","Karang Tinggi","Kayu Agung","Kepahiang","Kisaran","Koba","Kota Agung","Kotabumi","Kota Pinang","Kuala Tungkal","Kutacane","Lahat","Lahomi","Langsa","Lhokseumawe","Lhoksukon","Limapuluh","Liwa","Lotu","Lubuk Basung","Lubuk Bendaharo","Lubuk Linggau","Lubuk Pakam","Lubuk Sikaping","Manggar","Manna","Martapura (Sumatera Selatan)","Medan","Menggala","Mentok","Metro","Meulaboh","Meureude","Muara Aman","Muara Bulian","Muara Bungo","Muara Dua","Muara Enim","Muara Sabak","Muara Tebo","Muaro Sijunjung","Muko Muko","Padang","Padang Aro","Padang Panjang","Padang Sidempuan","Pagaralam","Painan","Palembang","Pandan","Pangkalan Kerinci","Pangkal Pinang","Panguruan","Panyabungan","Pariaman","Parit Malintang","Pasir Pengarayan","Payakumbuh","Pekanbaru","Pematang Siantar","Prabumulih","Pringsewu","Pulau Punjung","Ranai","Rantau Prapat","Raya","Rengat","Sabang","Salak","[[Sarila","Sarolangun","Sawahlunto","Sei Rampah","Sekayu","Selat Panjang","Sengeti","Siak Sri Indrapura","Sibolga","Sibuhuan","Sidikalang","Sigli","Simpang Empat","Simpang Tiga Redelong","Sinabang","Singkil","Sipirok","Solok","Stabat","Subulussalam","Sukadana","Suka Makmue","Sungailiat","Sungai Penuh","Takengon","Tais","Tanjung Balai (Sumatera Utara)","Tanjung Balai Karimun (Kepulauan Riau)","Tanjung Enim","Tanjung Pandan","Tanjung Pinang","Tapaktuan","Tarempa","Tarutung","Tebing Tinggi (Sumatera Utara)","Tebing Tinggi (Sumatera Selatan)","Teluk Dalam","Teluk Kuantan","Tembilahan","Toboali","Tuapejat","Ujung Tanjung","Ambarawa","Anyer","Bandung","Bangil","Banjar (Jawa Barat)","Banjarnegara","Bangkalan","Bantul","Banyumas","Banyuwangi","Batang","Batu","Bekasi","Blitar","Blora","Bogor","Bojonegoro","Bondowoso","Boyolali","Bumiayu","Brebes","Caruban","Cianjur","Ciamis","Cibinong","Cikampek","Cikarang","Cilacap","Cilegon","Cirebon","Demak","Depok","Garut","Gresik","Indramayu","Jakarta","Jember","Jepara","Jombang","Kajen","Karanganyar","Kebumen","Kediri","Kendal","Kepanjen","Klaten","Kraksaan","Kudus","Kuningan","Lamongan","Lumajang","Madiun","Magelang","Magetan","Majalengka","Malang","Mojokerto","Mojosari","Mungkid","Ngamprah","Nganjuk","Ngawi","Pacitan","Pamekasan","Pandeglang","Pare","Pati","Pasuruan","Pekalongan","Pelabuhan Ratu","Pemalang","Ponorogo","Probolinggo","Purbalingga","Purwakarta","Purwodadi","Purwokerto","Purworejo","Rangkasbitung","Rembang","Salatiga","Sampang","Semarang","Serang","Sidayu","Sidoarjo","Singaparna","Situbondo","Slawi","Sleman","Soreang","Sragen","Subang","Sukabumi","Sukoharjo","Sumber","Sumedang","Sumenep","Surabaya","Surakarta","Tasikmalaya","Tangerang","Tangerang Selatan","Tegal","Temanggung","Tigaraksa","Trenggalek","Tuban","Tulungagung","Ungaran","Wates","Wlingi","Wonogiri","Wonosari","Wonosobo","Yogyakarta","Atambua","Baa","Badung","Bajawa","Bangli","Bima","Denpasar","Dompu","Ende","Gianyar","Kalabahi","Karangasem","Kefamenanu","Klungkung","Kupang","Labuhan Bajo","Larantuka","Lewoleba","Maumere","Mataram","Mbay","Negara","Praya","Raba","Ruteng","Selong","Singaraja","Soe","Sumbawa Besar","Tabanan","Taliwang","Tambolaka","Tanjung (Nusa Tenggara Barat)","Waibakul","Waikabubak","Waingapu","Denpasar","Negara,Bali","Singaraja","Tabanan","Bangli","Pontianak","Samarinda","Banjarmasin","Balikpapan","Singkawang","Palangkaraya","Mempawah","Ketapang","Sintang","Tarakan","Putussibau","Sambas","Sampit","Banjarbaru","Barabai","Batang Tarang","Batulicin","Bengkayang","Bontang","Buntok","Kandangan","Kotabaru","Kuala Kapuas","Kuala Kurun","Kuala Pembuang","Malinau","Marabahan","Martapura","Muara Teweh","Nanga Bulik","Nanga Pinoh","Ngabang","Nunukan","Pangkalan Bun","Paringin","Pelaihari","Penajam","Pulang Pisau","Purukcahu","Rantau","Sangatta","Sekadau","Sendawar","Sukadana","Sukamara","Sungai Raya","Tamiang Layang","Tanah Grogot","Tanjung","Tanjung Selor","Tanjung Redeb","Tenggarong","Tideng Pale","Airmadidi","Ampana","Amurang","Andolo","Banggai","Bantaeng","Barru","Bau-Bau","Benteng","Bitung","Bolaang Uki","Boroko","Bulukumba","Bungku","Buol","Buranga","Donggala","Enrekang","Gorontalo","Jeneponto","Kawangkoan","Kendari","Kolaka","Kotamobagu","Kota Raha","Kwandang","Lasusua","Luwuk","Majene","Makale","Makassar (Ujung Pandang)","Malili","Mamasa","Mamuju","Manado (Menado)","Marisa","Maros","Masamba","Melonguane","Ondong Siau","Palopo","Palu","Pangkajene","Pare-Pare","Parigi","Pasangkayu","Pinrang","Polewali","Poso","Rantepao","Ratahan","Rumbia","Sengkang","Sidenreng","Sigi Biromaru","Sinjai","Sunggu Minasa","Suwawa","Tahuna","Takalar","Tilamuta","Toli Toli","Tomohon","Tondano","Tutuyan","Unaaha","Wangi Wangi","Wanggudu","Watampone","Watan Soppeng","Cliquers","Libuo Palma","Agats","Ambon","Banda","Biak","Bintuni","Botawa","Burmeso","Dataran Hunimoa","Dataran Hunipopu","Dobo","Elelim","Enarotali","Fak Fak","Fef","Ilaga","Jailolo","Jayapura","Kaimana","Karubaga","Kenyam","Kepi","Kigamani","Kisar","Kobakma","Kota Mulia","Kumurkek","Labuha","Larat","Leksula","Maba","Manokwari","Masohi","Merauke","Morotai Selatan","Nabire","Namlea","Namrole","Oksibil","Oobo","Passo","Piru","Rasiei","Sanana","Saparua","Sarmi","Saumlaki","Sentani","Serui","Sorendiweri","Sorong","Sugapa","Sumohai","Tanah Merah","Teminabuan","Ternate","Tiakur","Tidore","Tigi","Timika","Tiom","Tobelo","Tual","Waisai","Wamena","Waris","Weda"
        };
    }
}
