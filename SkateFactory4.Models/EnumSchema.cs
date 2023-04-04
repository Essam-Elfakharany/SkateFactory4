using SkateFactory4.Models.Enums;
namespace SkateFactory4.Models;

public class EnumSchema { 

    public EBrakeType BrakeType { get; set; } 
    public EColor Color { get; set; } 
    public  EShapeType ShapeType { get; set; } 
    public ESkateType SkateType { get; set; } 
    public ESkateboardCriteria SkateboardCriteria { get; set; }
}