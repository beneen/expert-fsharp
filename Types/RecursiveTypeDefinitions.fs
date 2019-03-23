module RecursiveTypeDefinitions

// referencing types - mutually recursive
// f# has special syntax for defining types that are mutually recursive

// representing an XML tree in F# using union and record types that are mutually recursive

// represents an XML attribute

type XmlAttribute = 
    { AttribName: string;
      AttribValue: string; }

// represents an XML element

type XmlElement = 
    { ElementName : string;
      Attributes: list<XmlAttribute>
      InnerXml: XmlTree }

// represents an XML tree

and XmlTree = 
    | Element of XmlElement
    | ElementList of list<XmlTree>
    | Text of string
    | Comment of string
    | Empty

// declaring types in same block