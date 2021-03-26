using System.Drawing;

namespace OpenColor
{
    /// <summary>
    /// a .NET version of https://github.com/yeun/open-color
    /// </summary>
    public static class OC
    {
        /*  Gray
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Gray0 = Color.FromArgb(248, 249, 250);
        public static Color Gray1 = Color.FromArgb(241, 243, 245);
        public static Color Gray2 = Color.FromArgb(233, 236, 239);
        public static Color Gray3 = Color.FromArgb(222, 226, 230);
        public static Color Gray4 = Color.FromArgb(206, 212, 218);
        public static Color Gray5 = Color.FromArgb(173, 181, 189);
        public static Color Gray6 = Color.FromArgb(134, 142, 150);
        public static Color Gray7 = Color.FromArgb(73, 80, 87);
        public static Color Gray8 = Color.FromArgb(52, 58, 64);
        public static Color Gray9 = Color.FromArgb(33, 37, 41);

        /*  Red
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Red0 = Color.FromArgb(255, 245, 245);
        public static Color Red1 = Color.FromArgb(255, 227, 227);
        public static Color Red2 = Color.FromArgb(255, 201, 201);
        public static Color Red3 = Color.FromArgb(255, 168, 168);
        public static Color Red4 = Color.FromArgb(255, 135, 135);
        public static Color Red5 = Color.FromArgb(255, 107, 107);
        public static Color Red6 = Color.FromArgb(250, 82, 82);
        public static Color Red7 = Color.FromArgb(240, 62, 62);
        public static Color Red8 = Color.FromArgb(224, 49, 49);
        public static Color Red9 = Color.FromArgb(201, 42, 42);

        /*  Pink
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Pink0 = Color.FromArgb(255, 240, 246);
        public static Color Pink1 = Color.FromArgb(255, 222, 235);
        public static Color Pink2 = Color.FromArgb(252, 194, 215);
        public static Color Pink3 = Color.FromArgb(250, 162, 193);
        public static Color Pink4 = Color.FromArgb(247, 131, 172);
        public static Color Pink5 = Color.FromArgb(240, 101, 149);
        public static Color Pink6 = Color.FromArgb(230, 73, 128);
        public static Color Pink7 = Color.FromArgb(214, 51, 108);
        public static Color Pink8 = Color.FromArgb(194, 37, 92);
        public static Color Pink9 = Color.FromArgb(166, 30, 77);


        /*  Grape
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Grape0 = Color.FromArgb(248, 240, 252);
        public static Color Grape1 = Color.FromArgb(243, 217, 250);
        public static Color Grape2 = Color.FromArgb(238, 190, 250);
        public static Color Grape3 = Color.FromArgb(229, 153, 247);
        public static Color Grape4 = Color.FromArgb(218, 119, 242);
        public static Color Grape5 = Color.FromArgb(204, 93, 232);
        public static Color Grape6 = Color.FromArgb(190, 75, 219);
        public static Color Grape7 = Color.FromArgb(174, 62, 201);
        public static Color Grape8 = Color.FromArgb(156, 54, 181);
        public static Color Grape9 = Color.FromArgb(134, 46, 156);


        /*  Violet
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Violet0 = Color.FromArgb(243, 240, 255);
        public static Color Violet1 = Color.FromArgb(229, 219, 255);
        public static Color Violet2 = Color.FromArgb(208, 191, 255);
        public static Color Violet3 = Color.FromArgb(177, 151, 252);
        public static Color Violet4 = Color.FromArgb(151, 117, 250);
        public static Color Violet5 = Color.FromArgb(132, 94, 247);
        public static Color Violet6 = Color.FromArgb(121, 80, 242);
        public static Color Violet7 = Color.FromArgb(112, 72, 232);
        public static Color Violet8 = Color.FromArgb(103, 65, 217);
        public static Color Violet9 = Color.FromArgb(95, 61, 196);


        /*  Indigo
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Indigo0 = Color.FromArgb(237, 242, 255);
        public static Color Indigo1 = Color.FromArgb(219, 228, 255);
        public static Color Indigo2 = Color.FromArgb(186, 200, 255);
        public static Color Indigo3 = Color.FromArgb(145, 167, 255);
        public static Color Indigo4 = Color.FromArgb(116, 143, 252);
        public static Color Indigo5 = Color.FromArgb(92, 124, 250);
        public static Color Indigo6 = Color.FromArgb(76, 110, 245);
        public static Color Indigo7 = Color.FromArgb(66, 99, 235);
        public static Color Indigo8 = Color.FromArgb(59, 91, 219);
        public static Color Indigo9 = Color.FromArgb(54, 79, 199);


        /*  Blue
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Blue0 = Color.FromArgb(231, 245, 255);
        public static Color Blue1 = Color.FromArgb(208, 235, 255);
        public static Color Blue2 = Color.FromArgb(165, 216, 255);
        public static Color Blue3 = Color.FromArgb(116, 192, 252);
        public static Color Blue4 = Color.FromArgb(77, 171, 247);
        public static Color Blue5 = Color.FromArgb(51, 154, 240);
        public static Color Blue6 = Color.FromArgb(34, 139, 230);
        public static Color Blue7 = Color.FromArgb(28, 126, 214);
        public static Color Blue8 = Color.FromArgb(25, 113, 194);
        public static Color Blue9 = Color.FromArgb(24, 100, 171);

        /*  Cyan
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Cyan0 = Color.FromArgb(227, 250, 252);
        public static Color Cyan1 = Color.FromArgb(197, 246, 250);
        public static Color Cyan2 = Color.FromArgb(153, 233, 242);
        public static Color Cyan3 = Color.FromArgb(102, 217, 232);
        public static Color Cyan4 = Color.FromArgb(59, 201, 219);
        public static Color Cyan5 = Color.FromArgb(34, 184, 207);
        public static Color Cyan6 = Color.FromArgb(21, 170, 191);
        public static Color Cyan7 = Color.FromArgb(16, 152, 173);
        public static Color Cyan8 = Color.FromArgb(12, 133, 153);
        public static Color Cyan9 = Color.FromArgb(11, 114, 133);


        /*  Teal
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Teal0 = Color.FromArgb(230, 252, 245);
        public static Color Teal1 = Color.FromArgb(195, 250, 232);
        public static Color Teal2 = Color.FromArgb(150, 242, 215);
        public static Color Teal3 = Color.FromArgb(99, 230, 190);
        public static Color Teal4 = Color.FromArgb(56, 217, 169);
        public static Color Teal5 = Color.FromArgb(32, 201, 151);
        public static Color Teal6 = Color.FromArgb(18, 184, 134);
        public static Color Teal7 = Color.FromArgb(12, 166, 120);
        public static Color Teal8 = Color.FromArgb(9, 146, 104);
        public static Color Teal9 = Color.FromArgb(8, 127, 91);


        /*  Green
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Green0 = Color.FromArgb(235, 251, 238);
        public static Color Green1 = Color.FromArgb(211, 249, 216);
        public static Color Green2 = Color.FromArgb(178, 242, 187);
        public static Color Green3 = Color.FromArgb(140, 233, 154);
        public static Color Green4 = Color.FromArgb(105, 219, 124);
        public static Color Green5 = Color.FromArgb(81, 207, 102);
        public static Color Green6 = Color.FromArgb(64, 192, 87);
        public static Color Green7 = Color.FromArgb(55, 178, 77);
        public static Color Green8 = Color.FromArgb(47, 158, 68);
        public static Color Green9 = Color.FromArgb(43, 138, 62);


        /*  Lime
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Lime0 = Color.FromArgb(244, 252, 227);
        public static Color Lime1 = Color.FromArgb(233, 250, 200);
        public static Color Lime2 = Color.FromArgb(216, 245, 162);
        public static Color Lime3 = Color.FromArgb(192, 235, 117);
        public static Color Lime4 = Color.FromArgb(169, 227, 75);
        public static Color Lime5 = Color.FromArgb(148, 216, 45);
        public static Color Lime6 = Color.FromArgb(130, 201, 30);
        public static Color Lime7 = Color.FromArgb(116, 184, 22);
        public static Color Lime8 = Color.FromArgb(102, 168, 15);
        public static Color Lime9 = Color.FromArgb(92, 148, 13);


        /*  Yellow
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Yellow0 = Color.FromArgb(255, 249, 219);
        public static Color Yellow1 = Color.FromArgb(255, 243, 191);
        public static Color Yellow2 = Color.FromArgb(255, 236, 153);
        public static Color Yellow3 = Color.FromArgb(255, 224, 102);
        public static Color Yellow4 = Color.FromArgb(255, 212, 59);
        public static Color Yellow5 = Color.FromArgb(252, 196, 25);
        public static Color Yellow6 = Color.FromArgb(250, 176, 5);
        public static Color Yellow7 = Color.FromArgb(245, 159, 0);
        public static Color Yellow8 = Color.FromArgb(240, 140, 0);
        public static Color Yellow9 = Color.FromArgb(230, 119, 0);


        /*  Orange
         *  式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式式 */
        public static Color Orange0 = Color.FromArgb(255, 244, 230);
        public static Color Orange1 = Color.FromArgb(255, 232, 204);
        public static Color Orange2 = Color.FromArgb(255, 216, 168);
        public static Color Orange3 = Color.FromArgb(255, 192, 120);
        public static Color Orange4 = Color.FromArgb(255, 169, 77);
        public static Color Orange5 = Color.FromArgb(255, 146, 43);
        public static Color Orange6 = Color.FromArgb(253, 126, 20);
        public static Color Orange7 = Color.FromArgb(247, 103, 7);
        public static Color Orange8 = Color.FromArgb(232, 89, 12);
        public static Color Orange9 = Color.FromArgb(217, 72, 15);
    }
}
