using Bridgestars.Util.AvatarUtil.FeatureTypes;

namespace Bridgestars.Util.AvatarUtil;


//A class with "presets", each method generates a different AvatarBuilder with different "themes"
//Use this link to see different options: https://www.dicebear.com/styles/avataaars
public static class AvatarBuilderPresets
{
    
    public static AvatarBuilder Normal()
    {
        var avatar = new Avatar();
        var builder = new AvatarBuilder(avatar);
        builder.IncludeAccessories(Accessories.Round, Accessories.Sunglasses, Accessories.Wayfarers,
                Accessories.Prescription01, Accessories.Prescription02)
            .IncludeAccessoriesColor(Color.ListAllStandardColors)
            .ExcludeClothing(Clothing.Overall)
            .IncludeClothesColor(Color.ListAllStandardColors)
            .ExcludeEyebrows(Eyebrows.UnibrowNatural)
            .ExcludeEyes(Eyes.EyeRoll, Eyes.Hearts, Eyes.XDizzy)
            .IncludeFacialHair()
            .IncludeFacialHairColor(Color.ListAllHairColors)
            .IncludeHairColor(Color.ListAllHairColors)
            .IncludeHatColor(Color.ListAllStandardColors)
            .ExcludeMouth(Mouth.Eating, Mouth.Grimace, Mouth.Tongue, Mouth.Vomit)
            .IncludeSkinColor(Color.ListAllSkinColors)
            .ExcludeTop(Top.Hijab, Top.Turban, Top.Frida)
            .SetFacialHairProbability(100)
            //.SetAccessoriesProbability(51)
            .SetTopProbability(100);
        return builder;
    }
    
    public static AvatarBuilder NormalGuy()
    {
        return new AvatarBuilder(new Avatar());
    }

    public static AvatarBuilder NormalGirl()
    {
        return new AvatarBuilder(new Avatar());
    }
    
    
}