using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        public static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
        }
        static int[] s_knownContractsLists = new int[] {
              -1,   72,   -1,   72,   -1, }
        ;
        // Count = 376
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                3, // array length: 3
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                2, // array length: 2
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                1, // array length: 1
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                2, // array length: 2
                896, // index: 896, string: "Pixel"
                902, // index: 902, string: "Axis"
                3, // array length: 3
                916, // index: 916, string: "Horizontal"
                927, // index: 927, string: "Vertical"
                936, // index: 936, string: "All"
                4, // array length: 4
                960, // index: 960, string: "Left"
                965, // index: 965, string: "Center"
                972, // index: 972, string: "Right"
                978, // index: 978, string: "Stretch"
                2, // array length: 2
                994, // index: 994, string: "None"
                999, // index: 999, string: "Arrow"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1011, // index: 1011, string: "http://schemas.datacontract.org/2004/07/Windows.Foundation"
                2, // array length: 2
                3865, // index: 3865, string: "X"
                3867, // index: 3867, string: "Y"
                2, // array length: 2
                1011, // index: 1011, string: "http://schemas.datacontract.org/2004/07/Windows.Foundation"
                1011, // index: 1011, string: "http://schemas.datacontract.org/2004/07/Windows.Foundation"
                4, // array length: 4
                1143, // index: 1143, string: "Flat"
                1148, // index: 1148, string: "Square"
                1155, // index: 1155, string: "Round"
                1161, // index: 1161, string: "Triangle"
                3, // array length: 3
                1182, // index: 1182, string: "Miter"
                1188, // index: 1188, string: "Bevel"
                1155, // index: 1155, string: "Round"
                4, // array length: 4
                960, // index: 960, string: "Left"
                972, // index: 972, string: "Right"
                1216, // index: 1216, string: "Top"
                1220, // index: 1220, string: "Bottom"
                4, // array length: 4
                1216, // index: 1216, string: "Top"
                965, // index: 965, string: "Center"
                1220, // index: 1220, string: "Bottom"
                978, // index: 978, string: "Stretch"
                2, // array length: 2
                1256, // index: 1256, string: "Visible"
                1264, // index: 1264, string: "Collapsed"
                4, // array length: 4
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                4, // array length: 4
                1220, // index: 1220, string: "Bottom"
                960, // index: 960, string: "Left"
                972, // index: 972, string: "Right"
                1216, // index: 1216, string: "Top"
                4, // array length: 4
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                1, // array length: 1
                -1, // string: null
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                1, // array length: 1
                4464, // index: 4464, string: "BehaviorType"
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                1, // array length: 1
                1081, // index: 1081, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media"
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                1, // array length: 1
                4477, // index: 4477, string: "CustomBrushes"
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                1081, // index: 1081, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media"
                3, // array length: 3
                4491, // index: 4491, string: "Opacity"
                4499, // index: 4499, string: "RelativeTransform"
                4517, // index: 4517, string: "Transform"
                3, // array length: 3
                1081, // index: 1081, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media"
                1081, // index: 1081, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media"
                1081, // index: 1081, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                3, // array length: 3
                4527, // index: 4527, string: "BorderThickness"
                4543, // index: 4543, string: "Unit"
                4548, // index: 4548, string: "Width"
                3, // array length: 3
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                2, // array length: 2
                1419, // index: 1419, string: "Star"
                1424, // index: 1424, string: "Pixels"
                5, // array length: 5
                960, // index: 960, string: "Left"
                1216, // index: 1216, string: "Top"
                972, // index: 972, string: "Right"
                1220, // index: 1220, string: "Bottom"
                1665, // index: 1665, string: "Floating"
                2, // array length: 2
                1689, // index: 1689, string: "Inside"
                1696, // index: 1696, string: "Outside"
                3, // array length: 3
                1721, // index: 1721, string: "Default"
                916, // index: 916, string: "Horizontal"
                927, // index: 927, string: "Vertical"
                14, // array length: 14
                994, // index: 994, string: "None"
                1747, // index: 1747, string: "Metro"
                1753, // index: 1753, string: "Custom"
                1760, // index: 1760, string: "AutumnBrights"
                1774, // index: 1774, string: "FloraHues"
                1784, // index: 1784, string: "Pineapple"
                1794, // index: 1794, string: "TomatoSpectrum"
                1809, // index: 1809, string: "RedChrome"
                1819, // index: 1819, string: "PurpleChrome"
                1832, // index: 1832, string: "BlueChrome"
                1843, // index: 1843, string: "GreenChrome"
                1855, // index: 1855, string: "Elite"
                1861, // index: 1861, string: "SandyBeach"
                1872, // index: 1872, string: "LightCandy"
                4, // array length: 4
                2119, // index: 2119, string: "Auto"
                994, // index: 994, string: "None"
                1155, // index: 1155, string: "Round"
                2124, // index: 2124, string: "Additional"
                4, // array length: 4
                965, // index: 965, string: "Center"
                2157, // index: 2157, string: "Shift"
                2163, // index: 2163, string: "Fit"
                2167, // index: 2167, string: "Hide"
                3, // array length: 3
                1721, // index: 1721, string: "Default"
                2197, // index: 2197, string: "AlwaysVisible"
                1256, // index: 1256, string: "Visible"
                8, // array length: 8
                2119, // index: 2119, string: "Auto"
                2232, // index: 2232, string: "Milliseconds"
                2245, // index: 2245, string: "Seconds"
                2253, // index: 2253, string: "Minutes"
                2261, // index: 2261, string: "Hours"
                2267, // index: 2267, string: "Days"
                2272, // index: 2272, string: "Months"
                2279, // index: 2279, string: "Years"
                2, // array length: 2
                2300, // index: 2300, string: "OnTicks"
                2308, // index: 2308, string: "BetweenTicks"
                5, // array length: 5
                994, // index: 994, string: "None"
                2347, // index: 2347, string: "MultipleRows"
                2167, // index: 2167, string: "Hide"
                2119, // index: 2119, string: "Auto"
                2360, // index: 2360, string: "Wrap"
                2, // array length: 2
                1689, // index: 1689, string: "Inside"
                1696, // index: 1696, string: "Outside"
                5, // array length: 5
                2119, // index: 2119, string: "Auto"
                994, // index: 994, string: "None"
                1155, // index: 1155, string: "Round"
                2402, // index: 2402, string: "Normal"
                2124, // index: 2124, string: "Additional"
                7, // array length: 7
                2660, // index: 2660, string: "Sunday"
                2667, // index: 2667, string: "Monday"
                2674, // index: 2674, string: "Tuesday"
                2682, // index: 2682, string: "Wednesday"
                2692, // index: 2692, string: "Thursday"
                2701, // index: 2701, string: "Friday"
                2708, // index: 2708, string: "Saturday"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                3, // array length: 3
                4527, // index: 4527, string: "BorderThickness"
                4554, // index: 4554, string: "Height"
                4543, // index: 4543, string: "Unit"
                3, // array length: 3
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                3, // array length: 3
                1216, // index: 1216, string: "Top"
                1220, // index: 1220, string: "Bottom"
                3262, // index: 3262, string: "TopAndBottom"
                5, // array length: 5
                1721, // index: 1721, string: "Default"
                2119, // index: 2119, string: "Auto"
                3299, // index: 3299, string: "Inner"
                3305, // index: 3305, string: "Outer"
                965, // index: 965, string: "Center"
                6, // array length: 6
                3324, // index: 3324, string: "XValue"
                3331, // index: 3331, string: "YValue"
                3338, // index: 3338, string: "Percentage"
                3349, // index: 3349, string: "YofTot"
                3356, // index: 3356, string: "DateTime"
                3365, // index: 3365, string: "LabelContentPath"
                12, // array length: 12
                1753, // index: 1753, string: "Custom"
                3394, // index: 3394, string: "Ellipse"
                3402, // index: 3402, string: "Cross"
                3408, // index: 3408, string: "Diamond"
                3416, // index: 3416, string: "Hexagon"
                3424, // index: 3424, string: "HorizontalLine"
                3439, // index: 3439, string: "InvertedTriangle"
                3456, // index: 3456, string: "Pentagon"
                3465, // index: 3465, string: "Plus"
                1148, // index: 1148, string: "Square"
                1161, // index: 1161, string: "Triangle"
                3470, // index: 3470, string: "VerticalLine"
                3, // array length: 3
                3497, // index: 3497, string: "Bezier"
                3504, // index: 3504, string: "Line"
                3509, // index: 3509, string: "StraightLine"
                2, // array length: 2
                3542, // index: 3542, string: "Area"
                3504, // index: 3504, string: "Line"
                3, // array length: 3
                3563, // index: 3563, string: "Interior"
                3572, // index: 3572, string: "Symbol"
                3579, // index: 3579, string: "SymbolAndInterior"
                2, // array length: 2
                3613, // index: 3613, string: "Zero"
                3618, // index: 3618, string: "Average"
                2, // array length: 2
                3642, // index: 3642, string: "ValueIsWidth"
                3655, // index: 3655, string: "ValueIsHeight"
                10, // array length: 10
                1081, // index: 1081, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media"
                4561, // index: 4561, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                3, // array length: 3
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                10, // array length: 10
                4619, // index: 4619, string: "Stroke"
                4626, // index: 4626, string: "StrokeDashArray"
                4642, // index: 4642, string: "StrokeDashCap"
                4656, // index: 4656, string: "StrokeDashOffset"
                4673, // index: 4673, string: "StrokeEndLineCap"
                4690, // index: 4690, string: "StrokeLineJoin"
                4705, // index: 4705, string: "StrokeMiterLimit"
                4722, // index: 4722, string: "StrokeThickness"
                4738, // index: 4738, string: "LineWidth"
                1245, // index: 1245, string: "Visibility"
                10, // array length: 10
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                8, // array length: 8
                1081, // index: 1081, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media"
                4561, // index: 4561, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                790, // index: 790, string: "http://schemas.datacontract.org/2004/07/Windows.UI.Xaml"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                8, // array length: 8
                4619, // index: 4619, string: "Stroke"
                4626, // index: 4626, string: "StrokeDashArray"
                4642, // index: 4642, string: "StrokeDashCap"
                4656, // index: 4656, string: "StrokeDashOffset"
                4673, // index: 4673, string: "StrokeEndLineCap"
                4690, // index: 4690, string: "StrokeLineJoin"
                4705, // index: 4705, string: "StrokeMiterLimit"
                4722, // index: 4722, string: "StrokeThickness"
                8, // array length: 8
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                263, // index: 263, string: "http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts"
                3, // array length: 3
                1689, // index: 1689, string: "Inside"
                1696, // index: 1696, string: "Outside"
                3720, // index: 3720, string: "OutsideExtended"
                13, // array length: 13
                994, // index: 994, string: "None"
                3752, // index: 3752, string: "SeriesType"
                3763, // index: 3763, string: "Rectangle"
                3509, // index: 3509, string: "StraightLine"
                3470, // index: 3470, string: "VerticalLine"
                3773, // index: 3773, string: "Circle"
                3408, // index: 3408, string: "Diamond"
                3456, // index: 3456, string: "Pentagon"
                3416, // index: 3416, string: "Hexagon"
                1161, // index: 1161, string: "Triangle"
                3439, // index: 3439, string: "InvertedTriangle"
                3402, // index: 3402, string: "Cross"
                3465, // index: 3465, string: "Plus"
                3, // array length: 3
                916, // index: 916, string: "Horizontal"
                927, // index: 927, string: "Vertical"
                3793, // index: 3793, string: "Both"
                2, // array length: 2
                3815, // index: 3815, string: "Linear"
                3822, // index: 3822, string: "Surface"
                4, // array length: 4
                994, // index: 994, string: "None"
                1155, // index: 1155, string: "Round"
                3842, // index: 3842, string: "Floor"
                3848, // index: 3848, string: "Ceil"
                2, // array length: 2
                3865, // index: 3865, string: "X"
                3867, // index: 3867, string: "Y"
                2, // array length: 2
                3879, // index: 3879, string: "Ascending"
                3889, // index: 3889, string: "Descending"
                5, // array length: 5
                3815, // index: 3815, string: "Linear"
                4151, // index: 4151, string: "Exponential"
                4163, // index: 4163, string: "Power"
                4169, // index: 4169, string: "Logarithmic"
                4181, // index: 4181, string: "Polynomial"
                5, // array length: 5
                4205, // index: 4205, string: "Fixed"
                3338, // index: 3338, string: "Percentage"
                4211, // index: 4211, string: "StandardDeviation"
                4229, // index: 4229, string: "StandardErrors"
                1753  // index: 1753, string: "Custom"
        };
        // Count = 171
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[] {
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 896, // Pixel
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 902, // Axis
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 916, // Horizontal
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 927, // Vertical
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 936, // All
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 960, // Left
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 965, // Center
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 972, // Right
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 978, // Stretch
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 994, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 999, // Arrow
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1143, // Flat
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1148, // Square
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1155, // Round
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1161, // Triangle
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1182, // Miter
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1188, // Bevel
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1155, // Round
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 960, // Left
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 972, // Right
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1216, // Top
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1220, // Bottom
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1216, // Top
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 965, // Center
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1220, // Bottom
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 978, // Stretch
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1256, // Visible
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1264, // Collapsed
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1419, // Star
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1424, // Pixels
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 960, // Left
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1216, // Top
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 972, // Right
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1220, // Bottom
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1665, // Floating
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1689, // Inside
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1696, // Outside
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1721, // Default
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 916, // Horizontal
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 927, // Vertical
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 994, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1747, // Metro
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1753, // Custom
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1760, // AutumnBrights
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1774, // FloraHues
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1784, // Pineapple
                    Value = 5,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1794, // TomatoSpectrum
                    Value = 6,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1809, // RedChrome
                    Value = 7,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1819, // PurpleChrome
                    Value = 8,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1832, // BlueChrome
                    Value = 9,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1843, // GreenChrome
                    Value = 10,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1855, // Elite
                    Value = 11,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1861, // SandyBeach
                    Value = 12,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1872, // LightCandy
                    Value = 13,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2119, // Auto
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 994, // None
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1155, // Round
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2124, // Additional
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 965, // Center
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2157, // Shift
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2163, // Fit
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2167, // Hide
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1721, // Default
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2197, // AlwaysVisible
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1256, // Visible
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2119, // Auto
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2232, // Milliseconds
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2245, // Seconds
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2253, // Minutes
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2261, // Hours
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2267, // Days
                    Value = 5,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2272, // Months
                    Value = 6,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2279, // Years
                    Value = 7,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2300, // OnTicks
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2308, // BetweenTicks
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 994, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2347, // MultipleRows
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2167, // Hide
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2119, // Auto
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2360, // Wrap
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1689, // Inside
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1696, // Outside
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2119, // Auto
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 994, // None
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1155, // Round
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2402, // Normal
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2124, // Additional
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2660, // Sunday
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2667, // Monday
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2674, // Tuesday
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2682, // Wednesday
                    Value = 8,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2692, // Thursday
                    Value = 16,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2701, // Friday
                    Value = 32,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2708, // Saturday
                    Value = 64,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1216, // Top
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1220, // Bottom
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3262, // TopAndBottom
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1721, // Default
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 2119, // Auto
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3299, // Inner
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3305, // Outer
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 965, // Center
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3324, // XValue
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3331, // YValue
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3338, // Percentage
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3349, // YofTot
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3356, // DateTime
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3365, // LabelContentPath
                    Value = 5,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1753, // Custom
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3394, // Ellipse
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3402, // Cross
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3408, // Diamond
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3416, // Hexagon
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3424, // HorizontalLine
                    Value = 5,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3439, // InvertedTriangle
                    Value = 6,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3456, // Pentagon
                    Value = 7,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3465, // Plus
                    Value = 8,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1148, // Square
                    Value = 9,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1161, // Triangle
                    Value = 10,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3470, // VerticalLine
                    Value = 11,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3497, // Bezier
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3504, // Line
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3509, // StraightLine
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3542, // Area
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3504, // Line
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3563, // Interior
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3572, // Symbol
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3579, // SymbolAndInterior
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3613, // Zero
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3618, // Average
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3642, // ValueIsWidth
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3655, // ValueIsHeight
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1689, // Inside
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1696, // Outside
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3720, // OutsideExtended
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 994, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3752, // SeriesType
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3763, // Rectangle
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3509, // StraightLine
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3470, // VerticalLine
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3773, // Circle
                    Value = 5,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3408, // Diamond
                    Value = 6,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3456, // Pentagon
                    Value = 7,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3416, // Hexagon
                    Value = 8,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1161, // Triangle
                    Value = 9,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3439, // InvertedTriangle
                    Value = 10,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3402, // Cross
                    Value = 11,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3465, // Plus
                    Value = 12,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 916, // Horizontal
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 927, // Vertical
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3793, // Both
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3815, // Linear
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3822, // Surface
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 994, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1155, // Round
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3842, // Floor
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3848, // Ceil
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3865, // X
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3867, // Y
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3879, // Ascending
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3889, // Descending
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3815, // Linear
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 4151, // Exponential
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 4163, // Power
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 4169, // Logarithmic
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 4181, // Polynomial
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 4205, // Fixed
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 3338, // Percentage
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 4211, // StandardDeviation
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 4229, // StandardErrors
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1753, // Custom
                    Value = 4,
                }
        };
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=150
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                "11d50a3a")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableSfChart, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                "blicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 336, // 0x150
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAnnotations, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                ", PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAnnotation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                " PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 352, // 0x160
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.DataTemplate, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicK" +
                                "eyToken=null")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.FrameworkTemplate, Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.DependencyObject, Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CoordinateUnit, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                "eyToken=3d67ed1f87d44c89")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.CoordinateUnit, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultu" +
                                "re=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5" +
                                "c561934e089")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToke" +
                                "n=3d67ed1f87d44c89")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.AxisMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neu" +
                                "tral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56193" +
                                "4e089")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, " +
                                "PublicKeyToken=null")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0" +
                                ", Culture=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
                                "34e089")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LineCap, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToken" +
                                "=3d67ed1f87d44c89")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.LineCap, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neut" +
                                "ral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934" +
                                "e089")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.Foundation.Point, System.Runtime.WindowsRuntime, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b77a5" +
                                "c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.Foundation.Point, System.Runtime.WindowsRuntime, Version=4.0.10.0, Culture=neutral, P" +
                                "ublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.PenLineCap, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pub" +
                                "licKeyToken=null")),
                    TableIndex = 67, // 0x43
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.Media.PenLineCap, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, C" +
                                "ulture=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e" +
                                "089")),
                    TableIndex = 67, // 0x43
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.PenLineJoin, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null")),
                    TableIndex = 83, // 0x53
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.Media.PenLineJoin, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, " +
                                "Culture=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934" +
                                "e089")),
                    TableIndex = 83, // 0x53
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ToolTipLabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 99, // 0x63
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ToolTipLabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54" +
                                ", Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToke" +
                                "n=b77a5c561934e089")),
                    TableIndex = 99, // 0x63
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pu" +
                                "blicKeyToken=null")),
                    TableIndex = 115, // 0x73
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, " +
                                "Culture=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934" +
                                "e089")),
                    TableIndex = 115, // 0x73
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Visibility, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicKey" +
                                "Token=null")),
                    TableIndex = 131, // 0x83
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.Visibility, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture" +
                                "=neutral, PublicKeyToken=null]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 131, // 0x83
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Thickness, System.Runtime.WindowsRuntime.UI.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                "en=b77a5c561934e089")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Windows.UI.Xaml.Thickness, System.Runtime.WindowsRuntime.UI.Xaml, Version=4.0.0.0, Culture=ne" +
                                "utral, PublicKeyToken=b77a5c561934e089]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
                                "34e089")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableBehaviors, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartBehavior, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                "al, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartColorModel, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                "KeyToken=3d67ed1f87d44c89")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Windows.UI.Xaml.Media.Brush, Windows.Foundation.UniversalApiContract, Version" +
                                "=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, Public" +
                                "KeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.Brush, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                "yToken=null")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableColumnDefinitions, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=n" +
                                "eutral, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableColumnDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=ne" +
                                "utral, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartUnitType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                "yToken=3d67ed1f87d44c89")),
                    TableIndex = 147, // 0x93
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartUnitType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultur" +
                                "e=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c" +
                                "561934e089")),
                    TableIndex = 147, // 0x93
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartLegend, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                ", PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 368, // 0x170
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartDock, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                "en=3d67ed1f87d44c89")),
                    TableIndex = 163, // 0xa3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartDock, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=ne" +
                                "utral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
                                "34e089")),
                    TableIndex = 163, // 0xa3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LegendPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                "eyToken=3d67ed1f87d44c89")),
                    TableIndex = 179, // 0xb3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.LegendPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultu" +
                                "re=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5" +
                                "c561934e089")),
                    TableIndex = 179, // 0xb3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartOrientation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                "cKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 195, // 0xc3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartOrientation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cul" +
                                "ture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77" +
                                "a5c561934e089")),
                    TableIndex = 195, // 0xc3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartColorPalette, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publ" +
                                "icKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 211, // 0xd3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartColorPalette, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cu" +
                                "lture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b7" +
                                "7a5c561934e089")),
                    TableIndex = 211, // 0xd3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAxis, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                "cKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 384, // 0x180
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.DateTimeRangePadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, P" +
                                "ublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 227, // 0xe3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.DateTimeRangePadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54," +
                                " Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=b77a5c561934e089")),
                    TableIndex = 227, // 0xe3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EdgeLabelsDrawingMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 243, // 0xf3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.EdgeLabelsDrawingMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54" +
                                ", Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToke" +
                                "n=b77a5c561934e089")),
                    TableIndex = 243, // 0xf3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EdgeLabelsVisibilityMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutra" +
                                "l, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 259, // 0x103
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.EdgeLabelsVisibilityMode, Syncfusion.SfChart.UWP, Version=16.4460.0" +
                                ".54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyT" +
                                "oken=b77a5c561934e089")),
                    TableIndex = 259, // 0x103
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.DateTimeIntervalType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, P" +
                                "ublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 275, // 0x113
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.DateTimeIntervalType, Syncfusion.SfChart.UWP, Version=16.4460.0.54," +
                                " Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken" +
                                "=b77a5c561934e089")),
                    TableIndex = 275, // 0x113
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                "eyToken=3d67ed1f87d44c89")),
                    TableIndex = 291, // 0x123
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.LabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultu" +
                                "re=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5" +
                                "c561934e089")),
                    TableIndex = 291, // 0x123
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisLabelsIntersectAction, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                "al, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 307, // 0x133
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.AxisLabelsIntersectAction, Syncfusion.SfChart.UWP, Version=16.4460." +
                                "0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKey" +
                                "Token=b77a5c561934e089")),
                    TableIndex = 307, // 0x133
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisElementPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                "blicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 323, // 0x143
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.AxisElementPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, " +
                                "Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "b77a5c561934e089")),
                    TableIndex = 323, // 0x143
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.NumericalPadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                "cKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 339, // 0x153
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.NumericalPadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cul" +
                                "ture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77" +
                                "a5c561934e089")),
                    TableIndex = 339, // 0x153
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableStripLines, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                " PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableStripLine, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 400, // 0x190
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.Day, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToken=3d6" +
                                "7ed1f87d44c89")),
                    TableIndex = 355, // 0x163
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.Day, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                " PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" +
                                "")),
                    TableIndex = 355, // 0x163
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableRowDefinitions, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neut" +
                                "ral, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableRowDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                "al, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableSeries, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pub" +
                                "licKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartSeries, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                ", PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 416, // 0x1a0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartAdornmentInfo, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=" +
                                "neutral, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 432, // 0x1b0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AdornmentsPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pub" +
                                "licKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 371, // 0x173
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.AdornmentsPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, C" +
                                "ulture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b" +
                                "77a5c561934e089")),
                    TableIndex = 371, // 0x173
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AdornmentsLabelPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                ", PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 387, // 0x183
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.AdornmentsLabelPosition, Syncfusion.SfChart.UWP, Version=16.4460.0." +
                                "54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                "ken=b77a5c561934e089")),
                    TableIndex = 387, // 0x183
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LabelContent, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                "Token=3d67ed1f87d44c89")),
                    TableIndex = 403, // 0x193
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.LabelContent, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture" +
                                "=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5" +
                                "61934e089")),
                    TableIndex = 403, // 0x193
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartSymbol, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                "oken=3d67ed1f87d44c89")),
                    TableIndex = 419, // 0x1a3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartSymbol, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=" +
                                "neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56" +
                                "1934e089")),
                    TableIndex = 419, // 0x1a3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ConnectorMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                "yToken=3d67ed1f87d44c89")),
                    TableIndex = 435, // 0x1b3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ConnectorMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultur" +
                                "e=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c" +
                                "561934e089")),
                    TableIndex = 435, // 0x1b3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartSeriesDrawType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                "blicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 451, // 0x1c3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartSeriesDrawType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, " +
                                "Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "b77a5c561934e089")),
                    TableIndex = 451, // 0x1c3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EmptyPointStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                "KeyToken=3d67ed1f87d44c89")),
                    TableIndex = 467, // 0x1d3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.EmptyPointStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cult" +
                                "ure=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a" +
                                "5c561934e089")),
                    TableIndex = 467, // 0x1d3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EmptyPointValue, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                "KeyToken=3d67ed1f87d44c89")),
                    TableIndex = 483, // 0x1e3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.EmptyPointValue, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cult" +
                                "ure=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a" +
                                "5c561934e089")),
                    TableIndex = 483, // 0x1e3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartFunnelMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                "KeyToken=3d67ed1f87d44c89")),
                    TableIndex = 499, // 0x1f3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartFunnelMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cult" +
                                "ure=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a" +
                                "5c561934e089")),
                    TableIndex = 499, // 0x1f3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CapLineStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                "Token=3d67ed1f87d44c89")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LineStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                "en=3d67ed1f87d44c89")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CircularSeriesLabelPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neu" +
                                "tral, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 515, // 0x203
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.CircularSeriesLabelPosition, Syncfusion.SfChart.UWP, Version=16.446" +
                                "0.0.54, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicK" +
                                "eyToken=b77a5c561934e089")),
                    TableIndex = 515, // 0x203
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartLegendIcon, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                "KeyToken=3d67ed1f87d44c89")),
                    TableIndex = 531, // 0x213
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartLegendIcon, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cult" +
                                "ure=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a" +
                                "5c561934e089")),
                    TableIndex = 531, // 0x213
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ErrorBarMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                "Token=3d67ed1f87d44c89")),
                    TableIndex = 547, // 0x223
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ErrorBarMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture" +
                                "=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5" +
                                "61934e089")),
                    TableIndex = 547, // 0x223
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartPyramidMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                "cKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 563, // 0x233
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ChartPyramidMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cul" +
                                "ture=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77" +
                                "a5c561934e089")),
                    TableIndex = 563, // 0x233
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SnapToPoint, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                "oken=3d67ed1f87d44c89")),
                    TableIndex = 579, // 0x243
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.SnapToPoint, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=" +
                                "neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56" +
                                "1934e089")),
                    TableIndex = 579, // 0x243
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SortingAxis, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                "oken=3d67ed1f87d44c89")),
                    TableIndex = 595, // 0x253
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.SortingAxis, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=" +
                                "neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c56" +
                                "1934e089")),
                    TableIndex = 595, // 0x253
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.Direction, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                "en=3d67ed1f87d44c89")),
                    TableIndex = 611, // 0x263
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.Direction, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=ne" +
                                "utral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5619" +
                                "34e089")),
                    TableIndex = 611, // 0x263
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableTrendlinesCollection, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultur" +
                                "e=neutral, PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableTrendline, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 448, // 0x1c0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.TrendlineType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                "yToken=3d67ed1f87d44c89")),
                    TableIndex = 627, // 0x273
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.TrendlineType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultur" +
                                "e=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c" +
                                "561934e089")),
                    TableIndex = 627, // 0x273
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ErrorBarType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                "Token=3d67ed1f87d44c89")),
                    TableIndex = 643, // 0x283
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[Syncfusion.UI.Xaml.Charts.ErrorBarType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture" +
                                "=neutral, PublicKeyToken=3d67ed1f87d44c89]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c5" +
                                "61934e089")),
                    TableIndex = 643, // 0x283
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableWatermark, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                    TableIndex = 464, // 0x1d0
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=30
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Xml.ReaderWriter, Version=4.0.11.0, Culture=neutral, PublicKeyToken=b03f5f7f" +
                                    "11d50a3a")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // SfChart
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 255, // SfChart
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 255, // SfChart
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableSfChart, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                    "blicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableSfChart, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                    "blicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 329, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableSfChart' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 555, // Annotation
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 555, // Annotation
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 555, // Annotation
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAnnotation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                    " PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAnnotation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                    " PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 566, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableAnnotation' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1431, // ChartLegend
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1431, // ChartLegend
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1431, // ChartLegend
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartLegend, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartLegend, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 1443, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableChartLegend' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1883, // ChartAxis
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1883, // ChartAxis
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1883, // ChartAxis
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAxis, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAxis, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 1893, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableAxis' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2431, // ChartStripLine
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2431, // ChartStripLine
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2431, // ChartStripLine
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableStripLine, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableStripLine, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 2446, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableStripLine' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2781, // ChartSeries
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2781, // ChartSeries
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2781, // ChartSeries
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartSeries, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartSeries, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 2793, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableChartSeries' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 3005, // ChartAdornmentInfo
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3005, // ChartAdornmentInfo
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3005, // ChartAdornmentInfo
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartAdornmentInfo, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=" +
                                    "neutral, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartAdornmentInfo, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=" +
                                    "neutral, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 3024, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableChartAdornmentInfo' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 3917, // Trendline
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3917, // Trendline
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3917, // Trendline
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableTrendline, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableTrendline, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 3927, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableTrendline' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 4244, // Watermark
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 4244, // Watermark
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 4244, // Watermark
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableWatermark, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableWatermark, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    ErrorMessageIndex = 4254, // The 'MethodName' property of the KnownTypeAttribute on type 'Syncfusion.UI.Xaml.Charts.SerializableWatermark' is not currently supported. See http://go.microsoft.com/fwlink/?LinkId=723954 for more information.
                    Kind = global::DataContractKind.InvalidDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=12
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 777, // DataTemplate
                        NamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 777, // DataTemplate
                        StableNameNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 777, // DataTemplate
                        TopLevelElementNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.DataTemplate, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicK" +
                                    "eyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.DataTemplate, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicK" +
                                    "eyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type3.ReadDataTemplateFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type4.WriteDataTemplateToXml),
                    ContractNamespacesListIndex = 1,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 846, // FrameworkTemplate
                        NamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 846, // FrameworkTemplate
                        StableNameNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 846, // FrameworkTemplate
                        TopLevelElementNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.FrameworkTemplate, Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.FrameworkTemplate, Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type5.ReadFrameworkTemplateFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type6.WriteFrameworkTemplateToXml),
                    ContractNamespacesListIndex = 5,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 864, // DependencyObject
                        NamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 864, // DependencyObject
                        StableNameNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 864, // DependencyObject
                        TopLevelElementNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.DependencyObject, Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.DependencyObject, Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type7.ReadDependencyObjectFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type8.WriteDependencyObjectToXml),
                    ContractNamespacesListIndex = 8,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1005, // Point
                        NamespaceIndex = 1011, // http://schemas.datacontract.org/2004/07/Windows.Foundation
                        StableNameIndex = 1005, // Point
                        StableNameNamespaceIndex = 1011, // http://schemas.datacontract.org/2004/07/Windows.Foundation
                        TopLevelElementNameIndex = 1005, // Point
                        TopLevelElementNamespaceIndex = 1011, // http://schemas.datacontract.org/2004/07/Windows.Foundation
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.Foundation.Point, System.Runtime.WindowsRuntime, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b77a5" +
                                    "c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.Foundation.Point, System.Runtime.WindowsRuntime, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b77a5" +
                                    "c561934e089")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type9.ReadPointFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type10.WritePointToXml),
                    ChildElementNamespacesListIndex = 25,
                    ContractNamespacesListIndex = 28,
                    MemberNamesListIndex = 30,
                    MemberNamespacesListIndex = 33,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1274, // Thickness
                        NamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 1274, // Thickness
                        StableNameNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 1274, // Thickness
                        TopLevelElementNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Thickness, System.Runtime.WindowsRuntime.UI.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Thickness, System.Runtime.WindowsRuntime.UI.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b77a5c561934e089")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type11.ReadThicknessFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type12.WriteThicknessToXml),
                    ChildElementNamespacesListIndex = 58,
                    ContractNamespacesListIndex = 63,
                    MemberNamesListIndex = 65,
                    MemberNamespacesListIndex = 70,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1305, // ChartBehavior
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1305, // ChartBehavior
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1305, // ChartBehavior
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartBehavior, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                    "al, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartBehavior, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                    "al, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type16.ReadChartBehaviorFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type17.WriteChartBehaviorToXml),
                    ChildElementNamespacesListIndex = 75,
                    ContractNamespacesListIndex = 77,
                    MemberNamesListIndex = 79,
                    MemberNamespacesListIndex = 81,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1319, // ChartColorModel
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1319, // ChartColorModel
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1319, // ChartColorModel
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartColorModel, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartColorModel, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type18.ReadChartColorModelFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type19.WriteChartColorModelToXml),
                    ChildElementNamespacesListIndex = 83,
                    ContractNamespacesListIndex = 85,
                    MemberNamesListIndex = 87,
                    MemberNamespacesListIndex = 89,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1348, // Brush
                        NamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        StableNameIndex = 1348, // Brush
                        StableNameNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        TopLevelElementNameIndex = 1348, // Brush
                        TopLevelElementNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.Brush, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.Brush, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                    "yToken=null")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type23.ReadBrushFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type24.WriteBrushToXml),
                    ChildElementNamespacesListIndex = 91,
                    ContractNamespacesListIndex = 95,
                    MemberNamesListIndex = 98,
                    MemberNamespacesListIndex = 102,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1383, // ChartColumnDefinition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1383, // ChartColumnDefinition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1383, // ChartColumnDefinition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableColumnDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=ne" +
                                    "utral, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableColumnDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=ne" +
                                    "utral, PublicKeyToken=3d67ed1f87d44c89")),
                        KnownDataContractsListIndex = 1,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type28.ReadChartColumnDefinitionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type29.WriteChartColumnDefinitionToXml),
                    ChildElementNamespacesListIndex = 106,
                    ContractNamespacesListIndex = 110,
                    MemberNamesListIndex = 112,
                    MemberNamespacesListIndex = 116,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2743, // ChartRowDefinition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2743, // ChartRowDefinition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2743, // ChartRowDefinition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableRowDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                    "al, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableRowDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                    "al, PublicKeyToken=3d67ed1f87d44c89")),
                        KnownDataContractsListIndex = 3,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type36.ReadChartRowDefinitionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type37.WriteChartRowDefinitionToXml),
                    ChildElementNamespacesListIndex = 200,
                    ContractNamespacesListIndex = 204,
                    MemberNamesListIndex = 206,
                    MemberNamespacesListIndex = 210,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 3669, // CapLineStyle
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3669, // CapLineStyle
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3669, // CapLineStyle
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CapLineStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CapLineStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type41.ReadCapLineStyleFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type42.WriteCapLineStyleToXml),
                    ChildElementNamespacesListIndex = 261,
                    ContractNamespacesListIndex = 272,
                    MemberNamesListIndex = 276,
                    MemberNamespacesListIndex = 287,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 3682, // LineStyle
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3682, // LineStyle
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3682, // LineStyle
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LineStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                    "en=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LineStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                    "en=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type43.ReadLineStyleFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type44.WriteLineStyleToXml),
                    ChildElementNamespacesListIndex = 298,
                    ContractNamespacesListIndex = 307,
                    MemberNamesListIndex = 310,
                    MemberNamespacesListIndex = 319,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=8
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 537, // ArrayOfAnnotation
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 537, // ArrayOfAnnotation
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 537, // ArrayOfAnnotation
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAnnotations, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAnnotations, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type0.ReadArrayOfAnnotationFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type1.WriteArrayOfAnnotationToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type2.ReadArrayOfAnnotationFromXmlIsGetOnly),
                    CollectionItemNameIndex = 555, // Annotation
                    KeyNameIndex = -1,
                    ItemNameIndex = 555, // Annotation
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableAnnotation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                " PublicKeyToken=3d67ed1f87d44c89")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1284, // ArrayOfChartBehavior
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1284, // ArrayOfChartBehavior
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1284, // ArrayOfChartBehavior
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableBehaviors, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableBehaviors, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type13.ReadArrayOfChartBehaviorFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type14.WriteArrayOfChartBehaviorToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type15.ReadArrayOfChartBehaviorFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1305, // ChartBehavior
                    KeyNameIndex = -1,
                    ItemNameIndex = 1305, // ChartBehavior
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartBehavior, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                "al, PublicKeyToken=3d67ed1f87d44c89")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1335, // ArrayOfBrush
                        NamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        StableNameIndex = 1335, // ArrayOfBrush
                        StableNameNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        TopLevelElementNameIndex = 1335, // ArrayOfBrush
                        TopLevelElementNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Windows.UI.Xaml.Media.Brush, Windows.Foundation.UniversalApiContract, Version" +
                                    "=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, Public" +
                                    "KeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[Windows.UI.Xaml.Media.Brush, Windows.Foundation.UniversalApiContract, Version" +
                                    "=1.0.0.0, Culture=neutral, PublicKeyToken=null]], System.Collections, Version=4.0.10.0, Culture=neutral, Public" +
                                    "KeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Collections, Version=4.0.10.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type20.ReadArrayOfBrushFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type21.WriteArrayOfBrushToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type22.ReadArrayOfBrushFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1348, // Brush
                    KeyNameIndex = -1,
                    ItemNameIndex = 1348, // Brush
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.Brush, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicKe" +
                                "yToken=null")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1354, // ArrayOfChartColumnDefinition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1354, // ArrayOfChartColumnDefinition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1354, // ArrayOfChartColumnDefinition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableColumnDefinitions, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=n" +
                                    "eutral, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableColumnDefinitions, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=n" +
                                    "eutral, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type25.ReadArrayOfChartColumnDefinitionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type26.WriteArrayOfChartColumnDefinitionToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type27.ReadArrayOfChartColumnDefinitionFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1383, // ChartColumnDefinition
                    KeyNameIndex = -1,
                    ItemNameIndex = 1383, // ChartColumnDefinition
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableColumnDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=ne" +
                                "utral, PublicKeyToken=3d67ed1f87d44c89")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2409, // ArrayOfChartStripLine
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2409, // ArrayOfChartStripLine
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2409, // ArrayOfChartStripLine
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableStripLines, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                    " PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableStripLines, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral," +
                                    " PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type30.ReadArrayOfChartStripLineFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type31.WriteArrayOfChartStripLineToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type32.ReadArrayOfChartStripLineFromXmlIsGetOnly),
                    CollectionItemNameIndex = 2431, // ChartStripLine
                    KeyNameIndex = -1,
                    ItemNameIndex = 2431, // ChartStripLine
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableStripLine, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2717, // ArrayOfChartRowDefinition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2717, // ArrayOfChartRowDefinition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2717, // ArrayOfChartRowDefinition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableRowDefinitions, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neut" +
                                    "ral, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableRowDefinitions, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neut" +
                                    "ral, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type33.ReadArrayOfChartRowDefinitionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type34.WriteArrayOfChartRowDefinitionToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type35.ReadArrayOfChartRowDefinitionFromXmlIsGetOnly),
                    CollectionItemNameIndex = 2743, // ChartRowDefinition
                    KeyNameIndex = -1,
                    ItemNameIndex = 2743, // ChartRowDefinition
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableRowDefinition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                "al, PublicKeyToken=3d67ed1f87d44c89")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 2762, // ArrayOfChartSeries
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2762, // ArrayOfChartSeries
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2762, // ArrayOfChartSeries
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableSeries, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pub" +
                                    "licKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableSeries, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pub" +
                                    "licKeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type38.ReadArrayOfChartSeriesFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type39.WriteArrayOfChartSeriesToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type40.ReadArrayOfChartSeriesFromXmlIsGetOnly),
                    CollectionItemNameIndex = 2781, // ChartSeries
                    KeyNameIndex = -1,
                    ItemNameIndex = 2781, // ChartSeries
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableChartSeries, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                ", PublicKeyToken=3d67ed1f87d44c89")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 3900, // ArrayOfTrendline
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3900, // ArrayOfTrendline
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3900, // ArrayOfTrendline
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableTrendlinesCollection, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultur" +
                                    "e=neutral, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableTrendlinesCollection, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Cultur" +
                                    "e=neutral, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type45.ReadArrayOfTrendlineFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type46.WriteArrayOfTrendlineToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type47.ReadArrayOfTrendlineFromXmlIsGetOnly),
                    CollectionItemNameIndex = 3917, // Trendline
                    KeyNameIndex = -1,
                    ItemNameIndex = 3917, // Trendline
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SerializableTrendline, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                "PublicKeyToken=3d67ed1f87d44c89")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=41
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[] {
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 881, // CoordinateUnit
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 881, // CoordinateUnit
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 881, // CoordinateUnit
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CoordinateUnit, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                    "eyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CoordinateUnit, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                    "eyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 10,
                    MemberCount = 2,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 907, // AxisMode
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 907, // AxisMode
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 907, // AxisMode
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToke" +
                                    "n=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToke" +
                                    "n=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 13,
                    MemberCount = 3,
                    MemberListIndex = 2,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 940, // HorizontalAlignment
                        NamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 940, // HorizontalAlignment
                        StableNameNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 940, // HorizontalAlignment
                        TopLevelElementNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.HorizontalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, " +
                                    "PublicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 17,
                    MemberCount = 4,
                    MemberListIndex = 5,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 986, // LineCap
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 986, // LineCap
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 986, // LineCap
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LineCap, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToken" +
                                    "=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LineCap, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToken" +
                                    "=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 22,
                    MemberCount = 2,
                    MemberListIndex = 9,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1070, // PenLineCap
                        NamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        StableNameIndex = 1070, // PenLineCap
                        StableNameNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        TopLevelElementNameIndex = 1070, // PenLineCap
                        TopLevelElementNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.PenLineCap, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.PenLineCap, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pub" +
                                    "licKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 36,
                    MemberCount = 4,
                    MemberListIndex = 11,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1170, // PenLineJoin
                        NamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        StableNameIndex = 1170, // PenLineJoin
                        StableNameNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        TopLevelElementNameIndex = 1170, // PenLineJoin
                        TopLevelElementNamespaceIndex = 1081, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml.Media
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.PenLineJoin, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Media.PenLineJoin, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 41,
                    MemberCount = 3,
                    MemberListIndex = 15,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1194, // ToolTipLabelPlacement
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1194, // ToolTipLabelPlacement
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1194, // ToolTipLabelPlacement
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ToolTipLabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ToolTipLabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 45,
                    MemberCount = 4,
                    MemberListIndex = 18,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1227, // VerticalAlignment
                        NamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 1227, // VerticalAlignment
                        StableNameNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 1227, // VerticalAlignment
                        TopLevelElementNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.VerticalAlignment, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, Pu" +
                                    "blicKeyToken=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 50,
                    MemberCount = 4,
                    MemberListIndex = 22,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1245, // Visibility
                        NamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        StableNameIndex = 1245, // Visibility
                        StableNameNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        TopLevelElementNameIndex = 1245, // Visibility
                        TopLevelElementNamespaceIndex = 790, // http://schemas.datacontract.org/2004/07/Windows.UI.Xaml
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Visibility, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicKey" +
                                    "Token=null")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Windows.UI.Xaml.Visibility, Windows.Foundation.UniversalApiContract, Version=1.0.0.0, Culture=neutral, PublicKey" +
                                    "Token=null")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 55,
                    MemberCount = 2,
                    MemberListIndex = 26,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1405, // ChartUnitType
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1405, // ChartUnitType
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1405, // ChartUnitType
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartUnitType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                    "yToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartUnitType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                    "yToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 120,
                    MemberCount = 2,
                    MemberListIndex = 28,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1655, // ChartDock
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1655, // ChartDock
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1655, // ChartDock
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartDock, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                    "en=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartDock, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                    "en=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 123,
                    MemberCount = 5,
                    MemberListIndex = 30,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1674, // LegendPosition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1674, // LegendPosition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1674, // LegendPosition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LegendPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                    "eyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LegendPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                    "eyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 129,
                    MemberCount = 2,
                    MemberListIndex = 35,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1704, // ChartOrientation
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1704, // ChartOrientation
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1704, // ChartOrientation
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartOrientation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartOrientation, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 132,
                    MemberCount = 3,
                    MemberListIndex = 37,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1729, // ChartColorPalette
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 1729, // ChartColorPalette
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 1729, // ChartColorPalette
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartColorPalette, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publ" +
                                    "icKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartColorPalette, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publ" +
                                    "icKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 136,
                    MemberCount = 14,
                    MemberListIndex = 40,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2098, // DateTimeRangePadding
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2098, // DateTimeRangePadding
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2098, // DateTimeRangePadding
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.DateTimeRangePadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, P" +
                                    "ublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.DateTimeRangePadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, P" +
                                    "ublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 151,
                    MemberCount = 4,
                    MemberListIndex = 54,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2135, // EdgeLabelsDrawingMode
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2135, // EdgeLabelsDrawingMode
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2135, // EdgeLabelsDrawingMode
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EdgeLabelsDrawingMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EdgeLabelsDrawingMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, " +
                                    "PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 156,
                    MemberCount = 4,
                    MemberListIndex = 58,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2172, // EdgeLabelsVisibilityMode
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2172, // EdgeLabelsVisibilityMode
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2172, // EdgeLabelsVisibilityMode
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EdgeLabelsVisibilityMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutra" +
                                    "l, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EdgeLabelsVisibilityMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutra" +
                                    "l, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 161,
                    MemberCount = 3,
                    MemberListIndex = 62,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2211, // DateTimeIntervalType
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2211, // DateTimeIntervalType
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2211, // DateTimeIntervalType
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.DateTimeIntervalType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, P" +
                                    "ublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.DateTimeIntervalType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, P" +
                                    "ublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 165,
                    MemberCount = 8,
                    MemberListIndex = 65,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2285, // LabelPlacement
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2285, // LabelPlacement
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2285, // LabelPlacement
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                    "eyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LabelPlacement, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicK" +
                                    "eyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 174,
                    MemberCount = 2,
                    MemberListIndex = 73,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2321, // AxisLabelsIntersectAction
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2321, // AxisLabelsIntersectAction
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2321, // AxisLabelsIntersectAction
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisLabelsIntersectAction, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                    "al, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisLabelsIntersectAction, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutr" +
                                    "al, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 177,
                    MemberCount = 5,
                    MemberListIndex = 75,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2365, // AxisElementPosition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2365, // AxisElementPosition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2365, // AxisElementPosition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisElementPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                    "blicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AxisElementPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                    "blicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 183,
                    MemberCount = 2,
                    MemberListIndex = 80,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2385, // NumericalPadding
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2385, // NumericalPadding
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2385, // NumericalPadding
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.NumericalPadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.NumericalPadding, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 186,
                    MemberCount = 5,
                    MemberListIndex = 82,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 2656, // Day
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 2656, // Day
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 2656, // Day
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.Day, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToken=3d6" +
                                    "7ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.Day, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyToken=3d6" +
                                    "7ed1f87d44c89")),
                    },
                    IsFlags = true,
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 192,
                    MemberCount = 7,
                    MemberListIndex = 87,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3243, // AdornmentsPosition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3243, // AdornmentsPosition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3243, // AdornmentsPosition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AdornmentsPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pub" +
                                    "licKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AdornmentsPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pub" +
                                    "licKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 214,
                    MemberCount = 3,
                    MemberListIndex = 94,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3275, // AdornmentsLabelPosition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3275, // AdornmentsLabelPosition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3275, // AdornmentsLabelPosition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AdornmentsLabelPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.AdornmentsLabelPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral" +
                                    ", PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 218,
                    MemberCount = 5,
                    MemberListIndex = 97,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3311, // LabelContent
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3311, // LabelContent
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3311, // LabelContent
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LabelContent, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.LabelContent, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 224,
                    MemberCount = 6,
                    MemberListIndex = 102,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3382, // ChartSymbol
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3382, // ChartSymbol
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3382, // ChartSymbol
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartSymbol, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                    "oken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartSymbol, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                    "oken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 231,
                    MemberCount = 12,
                    MemberListIndex = 108,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3483, // ConnectorMode
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3483, // ConnectorMode
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3483, // ConnectorMode
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ConnectorMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                    "yToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ConnectorMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                    "yToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 244,
                    MemberCount = 3,
                    MemberListIndex = 120,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3522, // ChartSeriesDrawType
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3522, // ChartSeriesDrawType
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3522, // ChartSeriesDrawType
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartSeriesDrawType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                    "blicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartSeriesDrawType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Pu" +
                                    "blicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 248,
                    MemberCount = 2,
                    MemberListIndex = 123,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3547, // EmptyPointStyle
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3547, // EmptyPointStyle
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3547, // EmptyPointStyle
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EmptyPointStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EmptyPointStyle, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 251,
                    MemberCount = 3,
                    MemberListIndex = 125,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3597, // EmptyPointValue
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3597, // EmptyPointValue
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3597, // EmptyPointValue
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EmptyPointValue, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.EmptyPointValue, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 255,
                    MemberCount = 2,
                    MemberListIndex = 128,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3626, // ChartFunnelMode
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3626, // ChartFunnelMode
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3626, // ChartFunnelMode
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartFunnelMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartFunnelMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 258,
                    MemberCount = 2,
                    MemberListIndex = 130,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3692, // CircularSeriesLabelPosition
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3692, // CircularSeriesLabelPosition
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3692, // CircularSeriesLabelPosition
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CircularSeriesLabelPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neu" +
                                    "tral, PublicKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.CircularSeriesLabelPosition, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neu" +
                                    "tral, PublicKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 328,
                    MemberCount = 3,
                    MemberListIndex = 132,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3736, // ChartLegendIcon
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3736, // ChartLegendIcon
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3736, // ChartLegendIcon
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartLegendIcon, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartLegendIcon, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Public" +
                                    "KeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 332,
                    MemberCount = 13,
                    MemberListIndex = 135,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3780, // ErrorBarMode
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3780, // ErrorBarMode
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3780, // ErrorBarMode
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ErrorBarMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ErrorBarMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 346,
                    MemberCount = 3,
                    MemberListIndex = 148,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3798, // ChartPyramidMode
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3798, // ChartPyramidMode
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3798, // ChartPyramidMode
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartPyramidMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ChartPyramidMode, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, Publi" +
                                    "cKeyToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 350,
                    MemberCount = 2,
                    MemberListIndex = 151,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3830, // SnapToPoint
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3830, // SnapToPoint
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3830, // SnapToPoint
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SnapToPoint, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                    "oken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SnapToPoint, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                    "oken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 353,
                    MemberCount = 4,
                    MemberListIndex = 153,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3853, // SortingAxis
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3853, // SortingAxis
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3853, // SortingAxis
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SortingAxis, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                    "oken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.SortingAxis, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyT" +
                                    "oken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 358,
                    MemberCount = 2,
                    MemberListIndex = 157,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 3869, // Direction
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 3869, // Direction
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 3869, // Direction
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.Direction, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                    "en=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.Direction, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKeyTok" +
                                    "en=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 361,
                    MemberCount = 2,
                    MemberListIndex = 159,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 4137, // TrendlineType
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 4137, // TrendlineType
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 4137, // TrendlineType
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.TrendlineType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                    "yToken=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.TrendlineType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKe" +
                                    "yToken=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 364,
                    MemberCount = 5,
                    MemberListIndex = 161,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 4192, // ErrorBarType
                        NamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        StableNameIndex = 4192, // ErrorBarType
                        StableNameNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        TopLevelElementNameIndex = 4192, // ErrorBarType
                        TopLevelElementNamespaceIndex = 263, // http://schemas.datacontract.org/2004/07/Syncfusion.UI.Xaml.Charts
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ErrorBarType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Syncfusion.UI.Xaml.Charts.ErrorBarType, Syncfusion.SfChart.UWP, Version=16.4460.0.54, Culture=neutral, PublicKey" +
                                    "Token=3d67ed1f87d44c89")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 370,
                    MemberCount = 5,
                    MemberListIndex = 166,
                }
        };
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','S','f','C','h','a','r','t','\0','h','t','t','p',':','/','/',
            's','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/',
            '0','7','/','S','y','n','c','f','u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','\0','T',
            'h','e',' ','\'','M','e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o','f',' ','t','h',
            'e',' ','K','n','o','w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y','p','e',' ','\'',
            'S','y','n','c','f','u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.','S','e','r','i',
            'a','l','i','z','a','b','l','e','S','f','C','h','a','r','t','\'',' ','i','s',' ','n','o','t',' ','c','u','r','r','e','n',
            't','l','y',' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t','p',':','/','/','g','o','.','m',
            'i','c','r','o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L','i','n','k','I','d','=','7','2',
            '3','9','5','4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t','i','o','n','.','\0','A','r','r',
            'a','y','O','f','A','n','n','o','t','a','t','i','o','n','\0','A','n','n','o','t','a','t','i','o','n','\0','T','h','e',' ',
            '\'','M','e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o','f',' ','t','h','e',' ','K',
            'n','o','w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y','p','e',' ','\'','S','y','n',
            'c','f','u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.','S','e','r','i','a','l','i',
            'z','a','b','l','e','A','n','n','o','t','a','t','i','o','n','\'',' ','i','s',' ','n','o','t',' ','c','u','r','r','e','n',
            't','l','y',' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t','p',':','/','/','g','o','.','m',
            'i','c','r','o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L','i','n','k','I','d','=','7','2',
            '3','9','5','4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t','i','o','n','.','\0','D','a','t',
            'a','T','e','m','p','l','a','t','e','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c',
            'o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','W','i','n','d','o','w','s','.','U','I',
            '.','X','a','m','l','\0','F','r','a','m','e','w','o','r','k','T','e','m','p','l','a','t','e','\0','D','e','p','e','n','d',
            'e','n','c','y','O','b','j','e','c','t','\0','C','o','o','r','d','i','n','a','t','e','U','n','i','t','\0','P','i','x','e',
            'l','\0','A','x','i','s','\0','A','x','i','s','M','o','d','e','\0','H','o','r','i','z','o','n','t','a','l','\0','V','e','r',
            't','i','c','a','l','\0','A','l','l','\0','H','o','r','i','z','o','n','t','a','l','A','l','i','g','n','m','e','n','t','\0',
            'L','e','f','t','\0','C','e','n','t','e','r','\0','R','i','g','h','t','\0','S','t','r','e','t','c','h','\0','L','i','n','e',
            'C','a','p','\0','N','o','n','e','\0','A','r','r','o','w','\0','P','o','i','n','t','\0','h','t','t','p',':','/','/','s','c',
            'h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7',
            '/','W','i','n','d','o','w','s','.','F','o','u','n','d','a','t','i','o','n','\0','P','e','n','L','i','n','e','C','a','p',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','W','i','n','d','o','w','s','.','U','I','.','X','a','m','l','.','M','e','d',
            'i','a','\0','F','l','a','t','\0','S','q','u','a','r','e','\0','R','o','u','n','d','\0','T','r','i','a','n','g','l','e','\0',
            'P','e','n','L','i','n','e','J','o','i','n','\0','M','i','t','e','r','\0','B','e','v','e','l','\0','T','o','o','l','T','i',
            'p','L','a','b','e','l','P','l','a','c','e','m','e','n','t','\0','T','o','p','\0','B','o','t','t','o','m','\0','V','e','r',
            't','i','c','a','l','A','l','i','g','n','m','e','n','t','\0','V','i','s','i','b','i','l','i','t','y','\0','V','i','s','i',
            'b','l','e','\0','C','o','l','l','a','p','s','e','d','\0','T','h','i','c','k','n','e','s','s','\0','A','r','r','a','y','O',
            'f','C','h','a','r','t','B','e','h','a','v','i','o','r','\0','C','h','a','r','t','B','e','h','a','v','i','o','r','\0','C',
            'h','a','r','t','C','o','l','o','r','M','o','d','e','l','\0','A','r','r','a','y','O','f','B','r','u','s','h','\0','B','r',
            'u','s','h','\0','A','r','r','a','y','O','f','C','h','a','r','t','C','o','l','u','m','n','D','e','f','i','n','i','t','i',
            'o','n','\0','C','h','a','r','t','C','o','l','u','m','n','D','e','f','i','n','i','t','i','o','n','\0','C','h','a','r','t',
            'U','n','i','t','T','y','p','e','\0','S','t','a','r','\0','P','i','x','e','l','s','\0','C','h','a','r','t','L','e','g','e',
            'n','d','\0','T','h','e',' ','\'','M','e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o',
            'f',' ','t','h','e',' ','K','n','o','w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y',
            'p','e',' ','\'','S','y','n','c','f','u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.',
            'S','e','r','i','a','l','i','z','a','b','l','e','C','h','a','r','t','L','e','g','e','n','d','\'',' ','i','s',' ','n','o',
            't',' ','c','u','r','r','e','n','t','l','y',' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t',
            'p',':','/','/','g','o','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L',
            'i','n','k','I','d','=','7','2','3','9','5','4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t',
            'i','o','n','.','\0','C','h','a','r','t','D','o','c','k','\0','F','l','o','a','t','i','n','g','\0','L','e','g','e','n','d',
            'P','o','s','i','t','i','o','n','\0','I','n','s','i','d','e','\0','O','u','t','s','i','d','e','\0','C','h','a','r','t','O',
            'r','i','e','n','t','a','t','i','o','n','\0','D','e','f','a','u','l','t','\0','C','h','a','r','t','C','o','l','o','r','P',
            'a','l','e','t','t','e','\0','M','e','t','r','o','\0','C','u','s','t','o','m','\0','A','u','t','u','m','n','B','r','i','g',
            'h','t','s','\0','F','l','o','r','a','H','u','e','s','\0','P','i','n','e','a','p','p','l','e','\0','T','o','m','a','t','o',
            'S','p','e','c','t','r','u','m','\0','R','e','d','C','h','r','o','m','e','\0','P','u','r','p','l','e','C','h','r','o','m',
            'e','\0','B','l','u','e','C','h','r','o','m','e','\0','G','r','e','e','n','C','h','r','o','m','e','\0','E','l','i','t','e',
            '\0','S','a','n','d','y','B','e','a','c','h','\0','L','i','g','h','t','C','a','n','d','y','\0','C','h','a','r','t','A','x',
            'i','s','\0','T','h','e',' ','\'','M','e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o',
            'f',' ','t','h','e',' ','K','n','o','w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y',
            'p','e',' ','\'','S','y','n','c','f','u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.',
            'S','e','r','i','a','l','i','z','a','b','l','e','A','x','i','s','\'',' ','i','s',' ','n','o','t',' ','c','u','r','r','e',
            'n','t','l','y',' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t','p',':','/','/','g','o','.',
            'm','i','c','r','o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L','i','n','k','I','d','=','7',
            '2','3','9','5','4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t','i','o','n','.','\0','D','a',
            't','e','T','i','m','e','R','a','n','g','e','P','a','d','d','i','n','g','\0','A','u','t','o','\0','A','d','d','i','t','i',
            'o','n','a','l','\0','E','d','g','e','L','a','b','e','l','s','D','r','a','w','i','n','g','M','o','d','e','\0','S','h','i',
            'f','t','\0','F','i','t','\0','H','i','d','e','\0','E','d','g','e','L','a','b','e','l','s','V','i','s','i','b','i','l','i',
            't','y','M','o','d','e','\0','A','l','w','a','y','s','V','i','s','i','b','l','e','\0','D','a','t','e','T','i','m','e','I',
            'n','t','e','r','v','a','l','T','y','p','e','\0','M','i','l','l','i','s','e','c','o','n','d','s','\0','S','e','c','o','n',
            'd','s','\0','M','i','n','u','t','e','s','\0','H','o','u','r','s','\0','D','a','y','s','\0','M','o','n','t','h','s','\0','Y',
            'e','a','r','s','\0','L','a','b','e','l','P','l','a','c','e','m','e','n','t','\0','O','n','T','i','c','k','s','\0','B','e',
            't','w','e','e','n','T','i','c','k','s','\0','A','x','i','s','L','a','b','e','l','s','I','n','t','e','r','s','e','c','t',
            'A','c','t','i','o','n','\0','M','u','l','t','i','p','l','e','R','o','w','s','\0','W','r','a','p','\0','A','x','i','s','E',
            'l','e','m','e','n','t','P','o','s','i','t','i','o','n','\0','N','u','m','e','r','i','c','a','l','P','a','d','d','i','n',
            'g','\0','N','o','r','m','a','l','\0','A','r','r','a','y','O','f','C','h','a','r','t','S','t','r','i','p','L','i','n','e',
            '\0','C','h','a','r','t','S','t','r','i','p','L','i','n','e','\0','T','h','e',' ','\'','M','e','t','h','o','d','N','a','m',
            'e','\'',' ','p','r','o','p','e','r','t','y',' ','o','f',' ','t','h','e',' ','K','n','o','w','n','T','y','p','e','A','t',
            't','r','i','b','u','t','e',' ','o','n',' ','t','y','p','e',' ','\'','S','y','n','c','f','u','s','i','o','n','.','U','I',
            '.','X','a','m','l','.','C','h','a','r','t','s','.','S','e','r','i','a','l','i','z','a','b','l','e','S','t','r','i','p',
            'L','i','n','e','\'',' ','i','s',' ','n','o','t',' ','c','u','r','r','e','n','t','l','y',' ','s','u','p','p','o','r','t',
            'e','d','.',' ','S','e','e',' ','h','t','t','p',':','/','/','g','o','.','m','i','c','r','o','s','o','f','t','.','c','o',
            'm','/','f','w','l','i','n','k','/','?','L','i','n','k','I','d','=','7','2','3','9','5','4',' ','f','o','r',' ','m','o',
            'r','e',' ','i','n','f','o','r','m','a','t','i','o','n','.','\0','D','a','y','\0','S','u','n','d','a','y','\0','M','o','n',
            'd','a','y','\0','T','u','e','s','d','a','y','\0','W','e','d','n','e','s','d','a','y','\0','T','h','u','r','s','d','a','y',
            '\0','F','r','i','d','a','y','\0','S','a','t','u','r','d','a','y','\0','A','r','r','a','y','O','f','C','h','a','r','t','R',
            'o','w','D','e','f','i','n','i','t','i','o','n','\0','C','h','a','r','t','R','o','w','D','e','f','i','n','i','t','i','o',
            'n','\0','A','r','r','a','y','O','f','C','h','a','r','t','S','e','r','i','e','s','\0','C','h','a','r','t','S','e','r','i',
            'e','s','\0','T','h','e',' ','\'','M','e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o',
            'f',' ','t','h','e',' ','K','n','o','w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y',
            'p','e',' ','\'','S','y','n','c','f','u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.',
            'S','e','r','i','a','l','i','z','a','b','l','e','C','h','a','r','t','S','e','r','i','e','s','\'',' ','i','s',' ','n','o',
            't',' ','c','u','r','r','e','n','t','l','y',' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t',
            'p',':','/','/','g','o','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L',
            'i','n','k','I','d','=','7','2','3','9','5','4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t',
            'i','o','n','.','\0','C','h','a','r','t','A','d','o','r','n','m','e','n','t','I','n','f','o','\0','T','h','e',' ','\'','M',
            'e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o','f',' ','t','h','e',' ','K','n','o',
            'w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y','p','e',' ','\'','S','y','n','c','f',
            'u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.','S','e','r','i','a','l','i','z','a',
            'b','l','e','C','h','a','r','t','A','d','o','r','n','m','e','n','t','I','n','f','o','\'',' ','i','s',' ','n','o','t',' ',
            'c','u','r','r','e','n','t','l','y',' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t','p',':',
            '/','/','g','o','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L','i','n',
            'k','I','d','=','7','2','3','9','5','4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t','i','o',
            'n','.','\0','A','d','o','r','n','m','e','n','t','s','P','o','s','i','t','i','o','n','\0','T','o','p','A','n','d','B','o',
            't','t','o','m','\0','A','d','o','r','n','m','e','n','t','s','L','a','b','e','l','P','o','s','i','t','i','o','n','\0','I',
            'n','n','e','r','\0','O','u','t','e','r','\0','L','a','b','e','l','C','o','n','t','e','n','t','\0','X','V','a','l','u','e',
            '\0','Y','V','a','l','u','e','\0','P','e','r','c','e','n','t','a','g','e','\0','Y','o','f','T','o','t','\0','D','a','t','e',
            'T','i','m','e','\0','L','a','b','e','l','C','o','n','t','e','n','t','P','a','t','h','\0','C','h','a','r','t','S','y','m',
            'b','o','l','\0','E','l','l','i','p','s','e','\0','C','r','o','s','s','\0','D','i','a','m','o','n','d','\0','H','e','x','a',
            'g','o','n','\0','H','o','r','i','z','o','n','t','a','l','L','i','n','e','\0','I','n','v','e','r','t','e','d','T','r','i',
            'a','n','g','l','e','\0','P','e','n','t','a','g','o','n','\0','P','l','u','s','\0','V','e','r','t','i','c','a','l','L','i',
            'n','e','\0','C','o','n','n','e','c','t','o','r','M','o','d','e','\0','B','e','z','i','e','r','\0','L','i','n','e','\0','S',
            't','r','a','i','g','h','t','L','i','n','e','\0','C','h','a','r','t','S','e','r','i','e','s','D','r','a','w','T','y','p',
            'e','\0','A','r','e','a','\0','E','m','p','t','y','P','o','i','n','t','S','t','y','l','e','\0','I','n','t','e','r','i','o',
            'r','\0','S','y','m','b','o','l','\0','S','y','m','b','o','l','A','n','d','I','n','t','e','r','i','o','r','\0','E','m','p',
            't','y','P','o','i','n','t','V','a','l','u','e','\0','Z','e','r','o','\0','A','v','e','r','a','g','e','\0','C','h','a','r',
            't','F','u','n','n','e','l','M','o','d','e','\0','V','a','l','u','e','I','s','W','i','d','t','h','\0','V','a','l','u','e',
            'I','s','H','e','i','g','h','t','\0','C','a','p','L','i','n','e','S','t','y','l','e','\0','L','i','n','e','S','t','y','l',
            'e','\0','C','i','r','c','u','l','a','r','S','e','r','i','e','s','L','a','b','e','l','P','o','s','i','t','i','o','n','\0',
            'O','u','t','s','i','d','e','E','x','t','e','n','d','e','d','\0','C','h','a','r','t','L','e','g','e','n','d','I','c','o',
            'n','\0','S','e','r','i','e','s','T','y','p','e','\0','R','e','c','t','a','n','g','l','e','\0','C','i','r','c','l','e','\0',
            'E','r','r','o','r','B','a','r','M','o','d','e','\0','B','o','t','h','\0','C','h','a','r','t','P','y','r','a','m','i','d',
            'M','o','d','e','\0','L','i','n','e','a','r','\0','S','u','r','f','a','c','e','\0','S','n','a','p','T','o','P','o','i','n',
            't','\0','F','l','o','o','r','\0','C','e','i','l','\0','S','o','r','t','i','n','g','A','x','i','s','\0','X','\0','Y','\0','D',
            'i','r','e','c','t','i','o','n','\0','A','s','c','e','n','d','i','n','g','\0','D','e','s','c','e','n','d','i','n','g','\0',
            'A','r','r','a','y','O','f','T','r','e','n','d','l','i','n','e','\0','T','r','e','n','d','l','i','n','e','\0','T','h','e',
            ' ','\'','M','e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o','f',' ','t','h','e',' ',
            'K','n','o','w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y','p','e',' ','\'','S','y',
            'n','c','f','u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.','S','e','r','i','a','l',
            'i','z','a','b','l','e','T','r','e','n','d','l','i','n','e','\'',' ','i','s',' ','n','o','t',' ','c','u','r','r','e','n',
            't','l','y',' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t','p',':','/','/','g','o','.','m',
            'i','c','r','o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L','i','n','k','I','d','=','7','2',
            '3','9','5','4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t','i','o','n','.','\0','T','r','e',
            'n','d','l','i','n','e','T','y','p','e','\0','E','x','p','o','n','e','n','t','i','a','l','\0','P','o','w','e','r','\0','L',
            'o','g','a','r','i','t','h','m','i','c','\0','P','o','l','y','n','o','m','i','a','l','\0','E','r','r','o','r','B','a','r',
            'T','y','p','e','\0','F','i','x','e','d','\0','S','t','a','n','d','a','r','d','D','e','v','i','a','t','i','o','n','\0','S',
            't','a','n','d','a','r','d','E','r','r','o','r','s','\0','W','a','t','e','r','m','a','r','k','\0','T','h','e',' ','\'','M',
            'e','t','h','o','d','N','a','m','e','\'',' ','p','r','o','p','e','r','t','y',' ','o','f',' ','t','h','e',' ','K','n','o',
            'w','n','T','y','p','e','A','t','t','r','i','b','u','t','e',' ','o','n',' ','t','y','p','e',' ','\'','S','y','n','c','f',
            'u','s','i','o','n','.','U','I','.','X','a','m','l','.','C','h','a','r','t','s','.','S','e','r','i','a','l','i','z','a',
            'b','l','e','W','a','t','e','r','m','a','r','k','\'',' ','i','s',' ','n','o','t',' ','c','u','r','r','e','n','t','l','y',
            ' ','s','u','p','p','o','r','t','e','d','.',' ','S','e','e',' ','h','t','t','p',':','/','/','g','o','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','f','w','l','i','n','k','/','?','L','i','n','k','I','d','=','7','2','3','9','5',
            '4',' ','f','o','r',' ','m','o','r','e',' ','i','n','f','o','r','m','a','t','i','o','n','.','\0','B','e','h','a','v','i',
            'o','r','T','y','p','e','\0','C','u','s','t','o','m','B','r','u','s','h','e','s','\0','O','p','a','c','i','t','y','\0','R',
            'e','l','a','t','i','v','e','T','r','a','n','s','f','o','r','m','\0','T','r','a','n','s','f','o','r','m','\0','B','o','r',
            'd','e','r','T','h','i','c','k','n','e','s','s','\0','U','n','i','t','\0','W','i','d','t','h','\0','H','e','i','g','h','t',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/',
            '2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','S',
            't','r','o','k','e','\0','S','t','r','o','k','e','D','a','s','h','A','r','r','a','y','\0','S','t','r','o','k','e','D','a',
            's','h','C','a','p','\0','S','t','r','o','k','e','D','a','s','h','O','f','f','s','e','t','\0','S','t','r','o','k','e','E',
            'n','d','L','i','n','e','C','a','p','\0','S','t','r','o','k','e','L','i','n','e','J','o','i','n','\0','S','t','r','o','k',
            'e','M','i','t','e','r','L','i','m','i','t','\0','S','t','r','o','k','e','T','h','i','c','k','n','e','s','s','\0','L','i',
            'n','e','W','i','d','t','h','\0'};
    }
}
