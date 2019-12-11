#pragma checksum "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\LondonMaps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d3074591e33948554d83ebf5341fafdcde5a34a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LondonMaps_Index), @"mvc.1.0.view", @"/Views/LondonMaps/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/LondonMaps/Index.cshtml", typeof(AspNetCore.Views_LondonMaps_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\_ViewImports.cshtml"
using SmartLondon;

#line default
#line hidden
#line 2 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\_ViewImports.cshtml"
using SmartLondon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d3074591e33948554d83ebf5341fafdcde5a34a", @"/Views/LondonMaps/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d1a73ce2143db528227b6f174d78a57e8bcf9c", @"/Views/_ViewImports.cshtml")]
    public class Views_LondonMaps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\engin\SOAIWTTermProject\SmartLondon\SmartLondon\Views\LondonMaps\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 1166, true);
            WriteLiteral(@"<link href=""https://unpkg.com/ionicons@4.5.10-0/dist/css/ionicons.min.css"" rel=""stylesheet"">

<div class=""container-fluid"">
    <div class=""wrapper"">
        <div class=""sidebar"">
            <div class=""sidebar-top"">
                <h4>Explore The London</h4>
            </div>
            <div class=""sidebar-body"">
                <h5>
                    <span><img style=""width: 30px; margin-right:10px;"" src=""/img/location.svg"" /></span>Find
                    nearby
                </h5>
                <input type=""text"" placeholder=""Enter adress,city or coord"" id=""searchKey"" />
                <button class=""next-btn"">Next</button>
                <div class=""results""></div>
            </div>
        </div>
        <div class=""map"" id=""map"">
        </div>
    </div>
</div>
<!--map Component-->
<script src=""./js/jquery/jquery.min.js""></script>
<script src=""https://api-maps.yandex.ru/2.1/?apikey=b4373fc9-c8eb-4a44-91bb-cae4ba0c5f9e&lang=en_US""
        type=""text/javascript""></");
            WriteLiteral("script>\r\n<script src=\"https://yastatic.net/s3/mapsapi-jslibs/area/0.0.1/util.calculateArea.min.js\"\r\n        type=\"text/javascript\"></script>\r\n");
            EndContext();
            BeginContext(1270, 20656, true);
            WriteLiteral(@"<script src=""./js/index.js""></script>
<script type=""text/javascript"">


    $(document).ready(function () {
        ymaps.ready(init);

        function getLocate(locations) {
            myMap.geoObjects.add(new ymaps.Placemark(locations));
        }

        function init() {
            var coords = [];
            var myMap = new ymaps.Map(""map"", {
                center: [51.52026933, -0.095],
                zoom: 10
            });
            searchKey = window.location.search.substring(1).split(""="")[1]
            if (searchKey !== undefined) {
                $('#searchKey').val(searchKey)
                var myGeocoder = ymaps.geocode(searchKey, {
                    boundedBy: myMap.getBounds(),// [[50.259998, -5.269000],[54.906101, -1.080278 ]],
                    strictBounds: true,
                });
                myGeocoder.then(function (res) {
                    locationCount = res.metaData.geocoder.results;
                    for (let i = 0; i < locationCount");
            WriteLiteral(@"; i++) {
                        var name = res.geoObjects.get(i).properties.get('name') + "" - "" + res.geoObjects.get(i).properties.get('description');
                        $("".results"").append(
                            '<div class=""result-list"">' +
                            ' <div class=""result-list-numbering"">' + (i + 1) + '.</div>' +
                            ' <div class=""result-list-text"">' +
                            '        <div class=""result-list-link"">' + name + '</div>' +
                            ' </div>' +
                            ' <div class=""result-list-icon"" ><a class=""locate""><i class=""icon ion-md-locate"" data-location=""' + res.geoObjects.get(i).geometry.getCoordinates() + '""></i></a></div>' +
                            '<div>'
                        );
                        myMap.geoObjects.add(new ymaps.Placemark(res.geoObjects.get(i).geometry.getCoordinates()))
                    }

                })
            }

            $('.results').click(f");
            WriteLiteral(@"unction (e) {
                if (e.target.localName === ""i"") {
                    console.log(e.target.dataset.location.split(','))
                    myMap.setCenter(e.target.dataset.location.split(','));
                    myMap.setZoom(15, { duration: 1000 });
                }
            })
            $('.next-btn').click(function (e) {
                window.location.href = ""LondonMaps?s="" + $('#searchKey').val();
            })

            myMap.geoObjects.add(new ymaps.Polygon([
                [[51.6310519477, -0.4941480548], [51.6305578222, -0.49354744180000004], [51.6307666416, -0.4915365001], [51.6275943351, -0.4890266234], [51.6267628675, -0.48785803600000005], [51.6219012509, -0.4766912036], [51.6168307143, -0.46916928500000005], [51.6131422499, -0.45975947710000004], [51.6122938891, -0.45713075550000004], [51.612701132, -0.4553477262], [51.6153253069, -0.44887870220000003], [51.6196247238, -0.4455483348], [51.6195027174, -0.4432557347], [51.6200732384, -0.4405753028], [51.6199");
            WriteLiteral(@"22361, -0.4382822536], [51.6183485457, -0.43273016080000004], [51.6177521093, -0.42839564760000004], [51.617007046, -0.42648143450000003], [51.6169331688, -0.42090266600000004], [51.6164250288, -0.4166172795], [51.6141826857, -0.4119852216], [51.613791702, -0.4110007885], [51.6131839306, -0.4040501725], [51.6090989968, -0.4032157605], [51.6066197403, -0.40176046940000004], [51.6061206587, -0.40235132020000003], [51.6051911678, -0.4025081484], [51.6019398058, -0.40233787730000004], [51.5996860197, -0.4012604202], [51.5982221576, -0.39994588680000004], [51.5974231779, -0.4003118338], [51.5968593648, -0.3976793287], [51.5950895688, -0.39648564480000004], [51.5936002352, -0.3963431358], [51.5916207225, -0.3954672951], [51.5902016721, -0.3954682799], [51.5904512431, -0.3944503593], [51.5883307427, -0.39201186800000004], [51.5830671866, -0.39101279980000003], [51.5817239255, -0.3910270672], [51.5815602097, -0.3915510004], [51.57725617, -0.3883922623], [51.5752897461, -0.3874920939], [51.5749719498, -0.3880546166], ");
            WriteLiteral(@"[51.5721481052, -0.3856869014], [51.57155595, -0.38643948920000004], [51.5709651781, -0.3859135976], [51.5672508836, -0.3832762306], [51.5647107113, -0.3823780386], [51.563722988, -0.3824823391], [51.5630735659, -0.38194855650000004], [51.5628984552, -0.3823601789], [51.5606774861, -0.38028791840000004], [51.5595857857, -0.3800887061], [51.559109866200004, -0.3802715547], [51.5549876056, -0.3777868856], [51.5546892042, -0.37766762330000003], [51.5511717069, -0.3852485241], [51.5486982975, -0.3939235609], [51.5487575144, -0.3949657025], [51.5480204769, -0.3949873541], [51.547638492, -0.3948680832], [51.5478923358, -0.3986999177], [51.5456633617, -0.3978652797], [51.5459635253, -0.3965364847], [51.5455330162, -0.3962214005], [51.5425487527, -0.39525189520000004], [51.5423261767, -0.3976521557], [51.5425076482, -0.4048317997], [51.5402427066, -0.41613012650000003], [51.5402487955, -0.4185135628], [51.540452042, -0.41924629150000003], [51.5402421431, -0.4194871925], [51.5391512539, -0.4181407051], [51.5386947851,");
            WriteLiteral(@" -0.4195696799], [51.5382567689, -0.419359908], [51.5378616792, -0.4175336445], [51.5366637982, -0.4174597418], [51.5365683714, -0.41531891200000004], [51.536017815, -0.41483775570000003], [51.5357505993, -0.41383044680000003], [51.5346926373, -0.4134606357], [51.5345062432, -0.4122486891], [51.534084919, -0.4118120733], [51.53428883, -0.411063869], [51.5320247535, -0.3968056554], [51.5308000535, -0.38925779650000003], [51.529557254, -0.3870943492], [51.5303949925, -0.38661648590000003], [51.5294152615, -0.3809692193], [51.5288875523, -0.37635571030000003], [51.524915600599996, -0.3761596638], [51.5186353458, -0.3817551275], [51.5174964801, -0.383421342], [51.5163641267, -0.3849675815], [51.514736228, -0.3890017075], [51.5132045618, -0.39042206160000004], [51.5077947185, -0.39284053100000005], [51.5069701321, -0.393565537], [51.5044312296, -0.39984941890000003], [51.5036427101, -0.4027616694], [51.5029222383, -0.40386887650000003], [51.4996945358, -0.4068847325], [51.5003158703, -0.40926484230000004], [51.498");
            WriteLiteral(@"2005759, -0.4106394097], [51.4962191858, -0.4105455575], [51.494989631, -0.4113878065], [51.4924449048, -0.41186947420000003], [51.4920986307, -0.4119305533], [51.4885810969, -0.4126172977], [51.4872546784, -0.4133446577], [51.4871983358, -0.4139645181], [51.4865258711, -0.414515002], [51.4862260375, -0.4146132764], [51.4860684928, -0.41400512170000003], [51.4856548142, -0.4146662077], [51.4825347525, -0.41682083210000004], [51.4820855479, -0.4164561537], [51.4808655143, -0.4168080678], [51.4772038348, -0.4150108239], [51.4760534685, -0.4149296887], [51.474011719800004, -0.4158241321], [51.4733916937, -0.41472674860000003], [51.4714226254, -0.4129576829], [51.470457039, -0.4113122943], [51.4698818729, -0.4111336538], [51.4673028796, -0.41965851670000004], [51.466783232, -0.42026962640000004], [51.4665558635, -0.4220771512], [51.4617390726, -0.43357806790000003], [51.4576844431, -0.4366129045], [51.4571106915, -0.43472673310000004], [51.4568540892, -0.4350406258], [51.456807525, -0.44145906], [51.4532665074, -");
            WriteLiteral(@"0.4439830681], [51.4538446587, -0.4494011679], [51.4548537251, -0.45376271170000004], [51.455460747000004, -0.453968183], [51.4556254352, -0.4554121492], [51.4552865026, -0.4553501166], [51.4552523317, -0.4557585651], [51.4563154241, -0.458640451], [51.4572152253, -0.4612788396], [51.4579841246, -0.4695874202], [51.4586339644, -0.4735601642], [51.4600858905, -0.47587698900000003], [51.4609577334, -0.4761185841], [51.4613367441, -0.47712078350000003], [51.4613141773, -0.48586244], [51.4617852201, -0.4896098601], [51.4629723558, -0.4922095085], [51.4627229049, -0.493861635], [51.46587619, -0.49698561630000004], [51.4664311678, -0.4981177437], [51.4671296557, -0.5003493892], [51.4677062072, -0.5037368999999999], [51.4677125494, -0.5062792675], [51.4669173091, -0.5073172986], [51.4670951485, -0.5087815391], [51.4675053043, -0.5102769277], [51.4687680724, -0.51015379], [51.4691759477, -0.5097014023], [51.4693507991, -0.5087396102], [51.4701168026, -0.5076708054], [51.4724787215, -0.5059422721], [51.4805200375, -0.");
            WriteLiteral(@"5034949387000001], [51.482858144, -0.5019551327], [51.4860799051, -0.49869972170000004], [51.4867248605, -0.49899680820000003], [51.4868342373, -0.49967595000000004], [51.4878581978, -0.49902443550000003], [51.4885812128, -0.4991692159], [51.4884551117, -0.4983075853], [51.4888824921, -0.49797811020000005], [51.489261397, -0.4986297851], [51.4898829703, -0.4973820458], [51.4898268501, -0.49665075410000004], [51.4904874018, -0.4967615698], [51.4905430844, -0.49598620740000005], [51.4913173749, -0.49494227830000004], [51.4920465405, -0.4953489277], [51.4926576567, -0.49483041640000003], [51.4930637191, -0.4914446767], [51.494578916, -0.4901167832], [51.4947476344, -0.4900247312], [51.4954756498, -0.48964335500000006], [51.4959693586, -0.48867331890000004], [51.4967694861, -0.4885863607], [51.4975758119, -0.4894687253], [51.4985659374, -0.48884818680000003], [51.4986211164, -0.48957239500000005], [51.4989668211, -0.48974400830000003], [51.5002065659, -0.4887447957], [51.5003499868, -0.48745779310000004], [51.500");
            WriteLiteral(@"9800107, -0.48729281220000004], [51.5009106436, -0.48616691910000004], [51.5018252114, -0.4862404053], [51.5026069614, -0.4851482489], [51.503578986, -0.48465918550000003], [51.5039271433, -0.48515918480000003], [51.5050749023, -0.4850446835], [51.5056218249, -0.4846475297], [51.5056250212, -0.4839211646], [51.5064597491, -0.4836599673], [51.5066477297, -0.4831739719], [51.507238122, -0.48321196450000004], [51.5076112779, -0.48397622500000004], [51.5080997932, -0.483511831], [51.5098022042, -0.48581721450000004], [51.5100278072, -0.4855358521], [51.5115268278, -0.4897865233], [51.5134142427, -0.4899214308], [51.5140777105, -0.4895608121], [51.5152570407, -0.491199327], [51.5170771624, -0.4923297675], [51.5188972063, -0.4916310963], [51.5201695043, -0.4903667175], [51.5212796779, -0.49117321150000004], [51.5224825601, -0.4905221836], [51.5245850493, -0.4902566271], [51.5262339344, -0.4908579255], [51.5286087674, -0.4889773307], [51.5300627145, -0.4896657964], [51.5320422348, -0.4901135358], [51.533272723, -0.4");
            WriteLiteral(@"9118881550000004], [51.5341574617, -0.4904818119], [51.5343250133, -0.4912072609], [51.5349172126, -0.49159579680000004], [51.5358369176, -0.4933287966], [51.5384292052, -0.49548974440000004], [51.5410053656, -0.49358492400000004], [51.5415732319, -0.49180681340000004], [51.5424483397, -0.49209808060000004], [51.5445585984, -0.4910303308], [51.5450744422, -0.4907939978], [51.5453650476, -0.491574773], [51.5461238237, -0.4913549024], [51.5463321589, -0.48937359690000004], [51.5472131159, -0.48949008860000004], [51.5474304765, -0.4881489029], [51.5496624231, -0.48703923250000003], [51.5507211356, -0.48538722380000004], [51.5514551771, -0.4842277164], [51.5515222527, -0.48266486280000004], [51.5548362747, -0.47888210080000004], [51.5548382099, -0.4777842981], [51.5552720842, -0.4773298816], [51.5580311853, -0.4765958213], [51.5596252784, -0.4769869302], [51.5602823183, -0.4775189106], [51.5608144822, -0.4804210539], [51.5607056449, -0.4810407078], [51.561780937, -0.48075234920000004], [51.562821668, -0.482793741");
            WriteLiteral(@"2], [51.5639152622, -0.4822452404], [51.5651400568, -0.4832215534], [51.5657261369, -0.4825788194], [51.5668711546, -0.48476257040000004], [51.5711957231, -0.4840128543], [51.5722991684, -0.48506122090000003], [51.5738410513, -0.4855338428], [51.5742958868, -0.48454175380000003], [51.5750558016, -0.4839940199], [51.5753450509, -0.48424854310000004], [51.5753632266, -0.4851686503], [51.576241385, -0.4877183069], [51.5777614119, -0.4892107198], [51.5783832449, -0.48945700400000003], [51.5796188305, -0.4885530659], [51.5817724934, -0.48960298210000003], [51.5828241102, -0.4910374832], [51.5846155759, -0.494702226], [51.5854238797, -0.49511288610000004], [51.5865466395, -0.49494154090000003], [51.5881160399, -0.4957412671], [51.5893389023, -0.49720949410000004], [51.5909610739, -0.49791238330000004], [51.5912182114, -0.49882208380000004], [51.5919017193, -0.4986205308], [51.5921428244, -0.4995423284], [51.5930763893, -0.4987824906], [51.5944441143, -0.49856848610000004], [51.5953975472, -0.4994335277], [51.599689");
            WriteLiteral(@"8996, -0.5005958867], [51.6001782635, -0.5008815965], [51.6012511663, -0.5003323083], [51.6013784953, -0.4991036393], [51.6008795232, -0.4976371638], [51.6013790435, -0.49668645770000003], [51.6023984478, -0.49631336000000004], [51.6032213633, -0.4971641196], [51.6049032275, -0.49726313450000004], [51.6082974148, -0.4985707662], [51.6089281161, -0.49923153870000003], [51.6094774599, -0.4983165459], [51.6101486006, -0.498976118], [51.6111068599, -0.4989459389], [51.6132379535, -0.4978935432], [51.6142477445, -0.4978861692], [51.6149167572, -0.49704367400000005], [51.6186875476, -0.49538939190000003], [51.6205005697, -0.49680870870000005], [51.6211091339, -0.4992601686], [51.6220683236, -0.5001545952], [51.6236781308, -0.5000249282], [51.62478418, -0.4983415628], [51.626672458, -0.49763334080000005], [51.6286551238, -0.5002306467000001], [51.6291733057, -0.4999650553], [51.6304798525, -0.4992616107], [51.63169779, -0.4970424566], [51.631703237, -0.4961335269], [51.6311641922, -0.49553437110000004], [51.63105194");
            WriteLiteral(@"77, -0.4941480548]],
            ],
                {
                    hintContent: ""1.Bölge""
                },
                {
                    fillColor: '#00FF0088',
                    strokeWidth: 1,
                    region: ""1.bölge""
                }))
            myMap.geoObjects.add(new ymaps.Polygon([
                [[51.5967692734, 0.14817997700000002], [51.596355534, 0.1480867536], [51.5970778889, 0.1498419953], [51.5954395777, 0.1511579415], [51.5912869944, 0.15059931910000002], [51.5891261708, 0.1512255663], [51.5837568785, 0.150955147], [51.580753891, 0.1484100214], [51.5807934559, 0.1474751547], [51.575680453, 0.1470103797], [51.5756247828, 0.148137869], [51.573118807, 0.14792302470000002], [51.5732341921, 0.1489877167], [51.5702749509, 0.1493172422], [51.5696981318, 0.1497792989], [51.5694168747, 0.1466692057], [51.5687708325, 0.1467873898], [51.5686220086, 0.1487761283], [51.5678227988, 0.1503862866], [51.567991959, 0.1514636321], [51.5661440251, 0.1543026767], [51.56");
            WriteLiteral(@"16078402, 0.1618969664], [51.5632718226, 0.1663679261], [51.5635338203, 0.16834842160000002], [51.5651002731, 0.1734153585], [51.5647158753, 0.1763002358], [51.5649418072, 0.1786600713], [51.5646359212, 0.1835080155], [51.5655130826, 0.18518046330000001], [51.5647887731, 0.1851486122], [51.5638692893, 0.1840109286], [51.5613137008, 0.18264629100000002], [51.5598546595, 0.18479399500000002], [51.5579621224, 0.1844291766], [51.5568210522, 0.1850468161], [51.5564278436, 0.1847697539], [51.5563393066, 0.18589798070000002], [51.5557843591, 0.18691867980000001], [51.5551313244, 0.1876014992], [51.554527764, 0.1875595954], [51.5543554954, 0.1880663413], [51.5540804822, 0.1879117345], [51.5526806165, 0.19020748410000002], [51.5514543335, 0.1896091499], [51.5501988922, 0.1874890706], [51.5475648875, 0.18604016950000002], [51.5458403236, 0.1825928035], [51.5441095583, 0.1803927619], [51.5402884672, 0.17922807100000002], [51.5395711673, 0.1781454506], [51.539489949200004, 0.17728499320000002], [51.538494795, 0.175035478");
            WriteLiteral(@"1], [51.5374068211, 0.1738097575], [51.5326262728, 0.17079058300000002], [51.5307407209, 0.1680032893], [51.5288008458, 0.1660123811], [51.5270594057, 0.16447217760000002], [51.5238830081, 0.1629679202], [51.5213114516, 0.1622667436], [51.5154780008, 0.1595200571], [51.512186802, 0.1587216743], [51.5119636518, 0.1582917708], [51.512812333, 0.15139640070000002], [51.5145989254, 0.1451719024], [51.5145824842, 0.1458254534], [51.5151552419, 0.1455367189], [51.5154547411, 0.1443545376], [51.5148306204, 0.1439115632], [51.5153245715, 0.14320684790000002], [51.5174386818, 0.1395209069], [51.5184659532, 0.13634583690000002], [51.5190428079, 0.1331612442], [51.5187750261, 0.132357325], [51.5194463089, 0.1263459858], [51.5189904354, 0.1224702019], [51.5181468905, 0.1191891798], [51.5160171204, 0.1143699604], [51.5156941495, 0.11447611640000001], [51.5142500214, 0.1090748928], [51.5139373664, 0.1067081971], [51.5145693561, 0.1005093546], [51.51481088, 0.09937318590000001], [51.5169837646, 0.0955956957], [51.5188760647,");
            WriteLiteral(@" 0.0952833482], [51.5205683037, 0.09569689390000001], [51.5226294253, 0.09283199360000001], [51.525112679, 0.0931173751], [51.5266648631, 0.09205835750000001], [51.5262285324, 0.0914601989], [51.5260899434, 0.0905095808], [51.5268567061, 0.0888601021], [51.5260484248, 0.0858669344], [51.5278048946, 0.0809488284], [51.5297111169, 0.0781175881], [51.5299220095, 0.0763667633], [51.5319898463, 0.0754832733], [51.5332738018, 0.0739700118], [51.5338263777, 0.0744002841], [51.5342095162, 0.0734862215], [51.5372485866, 0.0713732738], [51.5391164324, 0.0704544298], [51.538869333, 0.0695246083], [51.5409116297, 0.0699330444], [51.5420706622, 0.06896896970000001], [51.5440633822, 0.0697415333], [51.543569913, 0.0718145951], [51.543816362, 0.0719657446], [51.5440161836, 0.07556881730000001], [51.5446118182, 0.0768217964], [51.5443908264, 0.07706121590000001], [51.5445764196, 0.07750096570000001], [51.5440354105, 0.0779364016], [51.5447968082, 0.0801373397], [51.5451327513, 0.0814261175], [51.5455922427, 0.0816793242], [5");
            WriteLiteral(@"1.5473865985, 0.08601607330000001], [51.5477416494, 0.0885001748], [51.5482859048, 0.09151791570000001], [51.5491097923, 0.09171290950000001], [51.5496538171, 0.0926235026], [51.5486322768, 0.0922650616], [51.5458490241, 0.09352922550000001], [51.5484281, 0.0997660969], [51.549808107, 0.10425207660000001], [51.5509591177, 0.1062092583], [51.5520023136, 0.10745604040000001], [51.5520582188, 0.1082967519], [51.5526997193, 0.1084288056], [51.5524829506, 0.1111321715], [51.5530000495, 0.1123807934], [51.553482493, 0.1123541327], [51.5553267911, 0.1147548838], [51.5565203065, 0.1127515121], [51.5573187164, 0.1133555222], [51.5568936831, 0.11717900640000001], [51.557388664, 0.1171601141], [51.5573489171, 0.1189645042], [51.5585421578, 0.1205145745], [51.559163823, 0.1175066017], [51.5624933594, 0.1197777836], [51.562731352, 0.11890007650000001], [51.5630656896, 0.119059916], [51.5643419899, 0.1250162995], [51.5661414557, 0.1276484215], [51.5665325521, 0.12934335400000002], [51.5681024518, 0.1297038865], [51.5703238");
            WriteLiteral(@"945, 0.130484437], [51.570754354900004, 0.130052893], [51.5715399128, 0.12992944380000002], [51.571830011, 0.1315852513], [51.5733583161, 0.13091350370000002], [51.5730789875, 0.1301009529], [51.5739614048, 0.1294451352], [51.5763229404, 0.129198968], [51.5770880145, 0.1316378174], [51.5793627451, 0.1308262549], [51.5799624341, 0.1335592432], [51.5813141787, 0.13256157470000002], [51.581628409, 0.127781285], [51.5828566736, 0.1280839587], [51.5838905612, 0.1276573882], [51.5839357605, 0.12724662720000002], [51.5867263521, 0.1264012861], [51.5875210291, 0.1310305044], [51.5900536638, 0.1295827322], [51.5938778868, 0.137587221], [51.5965795053, 0.14192605760000002], [51.5994386173, 0.1465904787], [51.5989621546, 0.1482069466], [51.596800806, 0.14768466200000002], [51.5967692734, 0.14817997700000002], [51.5371534941, 0.0710561464], [51.5345265109, 0.0729469653], [51.5335091336, 0.0729137157], [51.531575028, 0.0751889667], [51.529824711, 0.0755145196], [51.5298692616, 0.0754863501], [51.5293711159, 0.0731928517],");
            WriteLiteral(@" [51.5292739299, 0.07274004740000001], [51.5307882204, 0.0725939976], [51.532951606, 0.0719439853], [51.5362909298, 0.06948413], [51.5362151851, 0.0687322715], [51.5361982573, 0.0679585904], [51.5369919501, 0.06828299160000001], [51.537189472, 0.068914949], [51.5396099851, 0.0669928019], [51.5408637687, 0.0666760013], [51.5442551843, 0.0682964092], [51.5444151825, 0.0683540816], [51.5441297469, 0.0693939911], [51.5421334562, 0.0686198518], [51.5413773336, 0.0691220718], [51.5409201872, 0.0685302467], [51.5402997794, 0.0694424025], [51.538812059, 0.06915283130000001], [51.5385125999, 0.0704775651], [51.5371534941, 0.0710561464]],

            ],
                {
                    hintContent: ""2.bölge""
                },
                {
                    fillColor: '#c0c0c0',
                    strokeWidth: 1
                }))
            myMap.geoObjects.events.add('click', function (e) {
                // Getting a reference to the child object where the event occurred.
               ");
            WriteLiteral(" var object = e.get(\'target\');\r\n                console.log(object)\r\n\r\n                alert(object.options._options.region);\r\n            });\r\n        }\r\n    })\r\n\r\n</script>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
