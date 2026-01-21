namespace Structy_CS.Intro;

public partial class Intro
{
    public static List<List<string>> Pairs(List<string> elements )
    {
        var pairs = new List<List<string>>();
        for (var i = 0; i < elements.Count; i++)
        {
            for (var j = i + 1; j < elements.Count; j++)
            {
                
                pairs.Add(new List<string> { elements[i], elements[j] });
            }
        }
        return pairs; 
    }
}