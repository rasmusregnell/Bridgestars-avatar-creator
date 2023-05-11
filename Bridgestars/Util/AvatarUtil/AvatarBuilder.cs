using System.Drawing;
using System.Security.Cryptography;
using Bridgestars.Util.AvatarUtil.FeatureTypes;
using System.Linq;
using Color = Bridgestars.Util.AvatarUtil.FeatureTypes.Color;

namespace Bridgestars.Util.AvatarUtil;

//This is the class used to build Avatars, it contains Include and Exclude methods which randomizes 
//between certain features given in the Directory FeatureTypes

public class AvatarBuilder
{
    private Avatar avatar;

    public AvatarBuilder(Avatar avatar)
    {
        this.avatar = avatar;
    }

    //This method "builds" the avatar, should be the last called method in chain
    public Avatar Build()
    {
        return avatar;
    } 
    
    //Below are all the methods for including and excluding different attributes
    
    
    //ACCESSORIES
    public AvatarBuilder IncludeAccessories(params string[] includeList)
    {
        avatar.SetAccessories(Include(includeList,Accessories.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeAccessories(params string[] excludeList)
    {
        avatar.SetAccessories(Exclude(excludeList,Accessories.ListAll));
        return this;
    }
    
    //This method exists both in Avatar and in AvatarBuilder
    public AvatarBuilder SetAccessoriesProbability(int prob)
    {
        avatar.SetAccessoriesProbability(prob);
        return this;
    }

    //ACCESSORIES COLOR
    public AvatarBuilder IncludeAccessoriesColor(params string[] includeList)
    {
        avatar.SetAccessoriesColor(Include(includeList,Color.ListAll));
        return this;
    }
    
    public AvatarBuilder ExcludeAccessoriesColor(params string[] excludeList)
    {
        avatar.SetAccessoriesColor(Exclude(excludeList,Color.ListAll));
        return this;
    }

    //CLOTHING
    public AvatarBuilder IncludeClothing(params string[] includeList)
    {
        avatar.SetClothing(Include(includeList,Clothing.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeClothing(params string[] excludeList)
    {
        avatar.SetClothing(Exclude(excludeList,Clothing.ListAll));
        return this;
    }
    
    //CLOTHES COLOR
    public AvatarBuilder IncludeClothesColor(params string[] includeList)
    {
        avatar.SetClothesColor(Include(includeList,Color.ListAll));
        return this;
    }
    
    public AvatarBuilder ExcludeClothesColor(params string[] excludeList)
    {
        avatar.SetClothesColor(Exclude(excludeList,Color.ListAll));
        return this;
    }
    
    //CLOTHING GRAPHIC
    public AvatarBuilder IncludeClothingGraphic(params string[] includeList)
    {
        avatar.SetClothingGraphic(Include(includeList,ClothingGraphic.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeClothingGraphic(params string[] excludeList)
    {
        avatar.SetClothingGraphic(Exclude(excludeList,ClothingGraphic.ListAll));
        return this;
    }
    
    //EYEBROWS
    public AvatarBuilder IncludeEyebrows(params string[] includeList)
    {
        avatar.SetEyebrows(Include(includeList,Eyebrows.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeEyebrows(params string[] excludeList)
    {
        avatar.SetEyebrows(Exclude(excludeList,Eyebrows.ListAll));
        return this;
    }
    
    
    //EYES
    public AvatarBuilder IncludeEyes(params string[] includeList)
    {
        avatar.SetEyes(Include(includeList,Eyes.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeEyes(params string[] excludeList)
    {
        avatar.SetEyes(Exclude(excludeList,Eyes.ListAll));
        return this;
    }
    
    
    //FACIALHAIR
    public AvatarBuilder IncludeFacialHair(params string[] includeList)
    {
        avatar.SetFacialHair(Include(includeList,FacialHair.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeFacialHair(params string[] excludeList)
    {
        avatar.SetFacialHair(Exclude(excludeList,FacialHair.ListAll));
        return this;
    }

    public AvatarBuilder SetFacialHairProbability(int prob)
    {
        avatar.SetFacialHairProbability(prob);
        return this;
    }
    
    //FACIALHAIR COLOR
    public AvatarBuilder IncludeFacialHairColor(params string[] includeList)
    {
        avatar.SetFacialHairColor(Include(includeList,Color.ListAll));
        return this;
    }

    //This method exists both in Avatar and AvatarBuilder
    public AvatarBuilder ExcludeFacialHairColor(params string[] excludeList)
    {
        avatar.SetFacialHairColor(Exclude(excludeList,Color.ListAll));
        return this;
    }
    
    //MOUTH
    public AvatarBuilder IncludeMouth(params string[] includeList)
    {
        avatar.SetMouth(Include(includeList,Mouth.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeMouth(params string[] excludeList)
    {
        avatar.SetMouth(Exclude(excludeList,Mouth.ListAll));
        return this;
    }
    
    
    //TOPP
    public AvatarBuilder IncludeTop(params string[] includeList)
    {
        avatar.SetTop(Include(includeList,Top.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeTop(params string[] excludeList)
    {
        avatar.SetTop(Exclude(excludeList,Top.ListAll));
        return this;
    }

    //This method exists both in Avatar and AvatarBuilder
    public AvatarBuilder SetTopProbability(int prob)
    {
        avatar.SetTopProbability(prob);
        return this;
    }
    
    //HAIR COLOR
    public AvatarBuilder IncludeHairColor(params string[] includeList)
    {
        avatar.SetHairColor(Include(includeList,Color.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeHairColor(params string[] excludeList)
    {
        avatar.SetHairColor(Exclude(excludeList,Color.ListAll));
        return this;
    }
    
    //HAT COLOR
    public AvatarBuilder IncludeHatColor(params string[] includeList)
    {
        avatar.SetHatColor(Include(includeList,Color.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeHatColor(params string[] excludeList)
    {
        avatar.SetHatColor(Exclude(excludeList,Color.ListAll));
        return this;
    }
    
    //SKIN COLOR
    public AvatarBuilder IncludeSkinColor(params string[] includeList)
    {
        avatar.SetSkinColor(Include(includeList,Color.ListAll));
        return this;
    }

    public AvatarBuilder ExcludeSkinColor(params string[] excludeList)
    {
        avatar.SetSkinColor(Exclude(excludeList,Color.ListAll));
        return this;
    }
    
    
    //Here comes private methods for generating random strings from a list
    private string Include(string[] includeList, string[] existingAttributes)
    {
        var includeListLength = includeList.Length;
        var existingAttributesLength = existingAttributes.Length;
        var random = new Random();
        
        //Zero elements: randomize between all available
        if (includeListLength == 0)
        { 
            var randomNbr1 = random.Next(0, existingAttributesLength);
            //Console.WriteLine(existingAttributes[randomNbr1]);
            return existingAttributes[randomNbr1];
        }
        
        //One element: returns this element
        if (includeListLength == 1)
        {
            return includeList[0];
        }
        
        //Multiple elements: randomize between these
        var randomNbr2 = random.Next(0, includeListLength);
        return includeList[randomNbr2];

    }
    
    private string Exclude(string[] excludeList, string[] existingAttributes)
    {
        //Multiple elements: exclude these, random between the others
        if (excludeList.Length > 0)
        {
            //What should happen here? EXPLOSION
            /*if (excludeList.Length == existingAttributes.Length)
            {
                return "";
            }*/
            var withoutExcludedElements = RemoveExcludedElements(excludeList, existingAttributes);
            var random = new Random();
            var randomNbr = random.Next(0, withoutExcludedElements.Length);
            return withoutExcludedElements[randomNbr];
        }
        
        //Zero elements, randomizes between all existing attributes
        return Include(Array.Empty<string>(), existingAttributes);
    }
    
    private string[] RemoveExcludedElements(string[] excludeList, string[] existingAttributes)
    {
        return existingAttributes.Where(e => !excludeList.Contains(e)).ToArray();
    } 
    
}

