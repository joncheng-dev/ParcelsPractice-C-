using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  public class Package
  {
    // Package Dimensions
    public int Length { get; } // how long
    public int Width { get; } // how wide
    public int Height { get; } // how tall
    // Package Mass
    public int Weight { get; } // how heavy
    public int Volume { get; set; }
    public int Cost { get; set; }

    // Package Instance Constructor
    public Package(string pkgLength, string pkgWidth, string pkgHeight, string pkgWeight)
    {
      Length = int.Parse(pkgLength);
      Width = int.Parse(pkgWidth);
      Height = int.Parse(pkgHeight);
      Weight = int.Parse(pkgWeight);
      CalcVolume();
      CalcCost(Volume);
    }

    public void CalcVolume()
    {
      int volume = Length * Width * Height;
      Volume = volume;
    }

    public void CalcCost(int CalcVolume)
    {
      int cost = 100 * CalcVolume;
      Cost = cost;
    }
  }
}