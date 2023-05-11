using Bridgestars.Util.AvatarUtil.FeatureTypes;
using Bridgestars.Util.WebUtil;
using ImageMagick;

namespace Bridgestars.Util.AvatarUtil;

//This is the class which holds the attributes for an Avatar.
//Contains setters mainly used by AvatarBuilder
//Contains Render method which generates a png with given attributes

public class Avatar
{
    //Avatar attributes
    private string accessories;
    private string accessoriesColor;
    private string clothing;
    private string clothesColor;
    private string clothingGraphic;
    private string eyebrows;
    private string eyes;
    private string facialHair;
    private string facialHairColor;
    private string mouth;
    private string top;
    private string hairColor;
    private string hatColor;
    private string skinColor;
    
    //Probabilities:
    public string accessoriesProbability;
    private string facialHairProbability;
    private string topProbability;
    
    //Constructor, generates a new avatar using AvatarBuilder, specifications on what to Exclude/Include in DefaultAvatarSettings
    public Avatar(/*Avatar avatar*/)
    {
        
        //All of the parameters must be included, or else error when rendering avatar, because no empty attributes allowed
        /*AvatarBuilder avatarBuilder = new AvatarBuilder(this)
            .ExcludeAccessories(DefaultAvatarSettings.Accessories)
            .ExcludeAccessoriesColor(DefaultAvatarSettings.AccessoriesColor)
            .ExcludeClothing(DefaultAvatarSettings.Clothing)
            .ExcludeClothesColor(DefaultAvatarSettings.ClothesColor)
            .ExcludeClothingGraphic(DefaultAvatarSettings.ClothingGraphic)
            .ExcludeEyebrows(DefaultAvatarSettings.Eyebrows)
            .ExcludeEyes(DefaultAvatarSettings.Eyes)
            .ExcludeFacialHair(DefaultAvatarSettings.FacialHair)
            .ExcludeFacialHairColor(DefaultAvatarSettings.FacialHairColor)
            .ExcludeMouth(DefaultAvatarSettings.Mouth)
            .ExcludeTop(DefaultAvatarSettings.Top)
            .ExcludeHairColor(DefaultAvatarSettings.HairColor)
            .ExcludeHatColor(DefaultAvatarSettings.HatColor)
            .IncludeSkinColor(DefaultAvatarSettings.SkinColor)
            .SetAccessoriesProbability(DefaultAvatarSettings.AccessoriesProbability)
            .SetFacialHairProbability(DefaultAvatarSettings.FacialHairProbability)
            .SetTopProbability(DefaultAvatarSettings.TopProbability);*/
        
        //Could be something like this:
        accessories = Accessories.Sunglasses;
        accessoriesColor = Color.Black;
        clothing = Clothing.Hoodie;
        clothesColor = Color.Green;
        clothingGraphic = ClothingGraphic.Diamond;
        eyebrows = Eyebrows.Default;
        eyes = Eyes.Default;
        facialHair = FacialHair.BeardLight;
        facialHairColor = Color.Gray;
        mouth = Mouth.Default;
        top = Top.LongButNotTooLong;
        hairColor = Color.BrownSkin;
        hatColor = Color.Blue;
        skinColor = Color.LightBrownSkin;
        accessoriesProbability = DefaultProbabilitySettings.AccessoriesProbability.ToString();
        topProbability = DefaultProbabilitySettings.TopProbability.ToString();
        facialHairProbability = DefaultProbabilitySettings.FacialHairProbability.ToString();



    }
    
    //A method which gives you all the attributes of the avatar
    public string GetAttributes()
    {
        return "";
    }
    
    //Setters for each attribute
    
    //ACCESSORIES
    public void SetAccessories(string accessories)
    {
        this.accessories = accessories;
    }
    
    public void SetAccessoriesColor(string accessoriesColor)
    {
        this.accessoriesColor = accessoriesColor;
    }
    
    
    //This method exists both in Avatar and AvatarBuilder
    public void SetAccessoriesProbability(int prob)
    {
        if (prob < 0 || prob > 100)
        {
            prob = DefaultProbabilitySettings.AccessoriesProbability;
        }
        this.accessoriesProbability = prob.ToString();
    }
    
    //CLOTHING
    public void SetClothing(string clothing)
    {
        this.clothing = clothing;
    }
    
    public void SetClothesColor(string clothesColor)
    {
        this.clothesColor = clothesColor;
    }
    
    //CLOTHING GRAPHIC
    public void SetClothingGraphic(string clothingGraphic)
    {
        this.clothingGraphic = clothingGraphic;
    }
    
    //EYEBROWS
    public void SetEyebrows(string eyebrows)
    {
        this.eyebrows = eyebrows;
    }
    
    //EYES
    public void SetEyes(string eyes)
    {
        this.eyes = eyes;
    }
    
    //FACIALHAIR
    public void SetFacialHair(string facialHair)
    {
        this.facialHair = facialHair;
    }
    
    public void SetFacialHairColor(string facialHairColor)
    {
        this.facialHairColor = facialHairColor;
    }
    
    //This method exists both in Avatar and AvatarBuilder
    public void SetFacialHairProbability(int prob)
    {
        if (prob < 0 || prob > 100)
        {
            prob = DefaultProbabilitySettings.FacialHairProbability;
        }
        this.facialHairProbability = prob.ToString();
    }
    
    //MOUTH
    public void SetMouth(string mouth)
    {
        this.mouth = mouth;
    }
    
    //TOP/HAIR
    public void SetTop(string top)
    {
        this.top = top;
    }
    
    public void SetHairColor(string hairColor)
    {
        this.hairColor = hairColor;
    }
    
    public void SetHatColor(string hatColor)
    {
        this.hatColor = hatColor;
    }
    
    //This method exists both in Avatar and AvatarBuilder
    public void SetTopProbability(int prob)
    {
        if (prob < 0 || prob > 100)
        {
            prob = DefaultProbabilitySettings.TopProbability;
        }
        this.topProbability = prob.ToString();
    }
    
    public void SetSkinColor(string skinColor)
    {
        this.skinColor = skinColor;
    }


    //A method which renders a png file, and stores it at required location
    public MagickImage Render()
    {
        MagickImage image = new MagickImage();
        new WebRequest()
            .SetEndpoint("https://api.dicebear.com/6.x/avataaars/png")
            .AddParam("accessories", accessories)
            .AddParam("accessoriesColor", accessoriesColor)
            .AddParam("accessoriesProbability", accessoriesProbability)
            .AddParam("clothing" , clothing)
            .AddParam("clothesColor", clothesColor)
            .AddParam("clothingGraphic" , clothingGraphic)
            .AddParam("eyeBrows", eyebrows)
            .AddParam("eyes", eyes)
            .AddParam("facialHair", facialHair)
            .AddParam("facialHairColor", facialHairColor)
            .AddParam("facialHairProbability", facialHairProbability)
            .AddParam("mouth", mouth)
            .AddParam("top", top)
            .AddParam("hairColor", hairColor)
            .AddParam("hatColor", hatColor)
            .AddParam("topProbability", topProbability)
            .AddParam("skinColor", skinColor)
            .GET()
            .Then(response => {
                var resp = response.RawBytes;
                //File.WriteAllBytes("test.png",resp);
                image = ImageUtil.LoadFromData(resp);
                //image.Write("C:/Users/Rasmu/source/repos/bridgestars-avatar-creator/Test/AvatarGenerator/Images/test2.png");
            }).Await();
        return image;
    }
}