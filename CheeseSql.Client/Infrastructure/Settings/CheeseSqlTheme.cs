using MudBlazor;

namespace CheeseSql.Client.Infrastructure.Settings
{
    public class CheeseSqlTheme
    {
        private static Typography DefaultTypography = new()
        {
            /*
             * Default
             * H1
             * H2
             * H3
             * H4
             * H5
             * H6
             * Button
             * Body
             * Body2
             * Captaion
             * Subtitle2
             */
        };

        public static LayoutProperties DefaultLayoutProperties = new()
        {
            DefaultBorderRadius = "3px"
        };

        // public static MudTheme defaultTheme = new MudTheme()
        // {
        //     Palette = new Palette()
        //     {
        //         Black = "#272c34"
        //     }
        // };
        //
        // public static MudTheme darkTheme = new MudTheme()
        // {
        //     Palette = new Palette()
        //     {
        //         Black = "#27272f",
        //         Background = "#32333d",
        //         BackgroundGrey = "#27272f",
        //         Surface = "#373740",
        //         DrawerBackground = "#27272f",
        //         DrawerText = "rgba(255,255,255, 0.50)",
        //         DrawerIcon = "rgba(255,255,255, 0.50)",
        //         AppbarBackground = "#27272f",
        //         AppbarText = "rgba(255,255,255, 0.70)",
        //         TextPrimary = "rgba(255,255,255, 0.70)",
        //         TextSecondary = "rgba(255,255,255, 0.50)",
        //         ActionDefault = "#adadb1",
        //         ActionDisabled = "rgba(255,255,255, 0.26)",
        //         ActionDisabledBackground = "rgba(255,255,255, 0.12)",
        //         Divider = "rgba(255,255,255, 0.12)",
        //         DividerLight = "rgba(255,255,255, 0.06)",
        //         TableLines = "rgba(255,255,255, 0.12)",
        //         LinesDefault = "rgba(255,255,255, 0.12)",
        //         LinesInputs = "rgba(255,255,255, 0.3)",
        //         TextDisabled = "rgba(255,255,255, 0.2)"
        //     }
        // };
    }
}