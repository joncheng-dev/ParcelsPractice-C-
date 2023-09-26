using System;

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

    // Package Instance Constructor
    public Package(int pkgLength, int pkgWidth, int pkgHeight, int pkgWeight)
    {
      Length = pkgLength;
      Width = pkgWidth;
      Height = pkgHeight;
      Weight = pkgWeight;
    }
  }
}