namespace gregsListSharp.Models;

public class House
{
    public int Id { get; set; }
    public int Sqft { get; set; }
    public int Bedrooms { get; set; }
    public double Bathroom { get; set; }
    public string ImgUrl { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }

    // NOTE we do not need to make our own constructor because it wants mySQL to make it or something like that..
    // public House(int id, int sqft, int bedrooms, double bathroom, string imgUrl, string description, int price)
    // {
    //     Id = id;
    //     Sqft = sqft;
    //     Bedrooms = bedrooms;
    //     Bathroom = bathroom;
    //     ImgUrl = imgUrl;
    //     Description = description;
    //     Price = price;
    // }
}