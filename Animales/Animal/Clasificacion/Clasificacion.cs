using System.Xml.Serialization;
namespace Animales;


public enum Clasificacion
{
    [XmlEnum(Name="Mamifero")]
    Mamiferos = 1,
    [XmlEnum(Name="Pajaro")]
    Pajaros,
    [XmlEnum(Name="Reptil")]
    Reptil,
    [XmlEnum(Name="Peces")]
    Peces,
    [XmlEnum(Name="Anfibios")]
    Anfibios,
    [XmlEnum(Name="Insecto")]
    Insecto,
    [XmlEnum(Name="Invertebrado")]
    Invertebrado,
}