//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Events/ResolutionRouteInfo.proto
namespace Diadoc.Api.Proto.Events
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResolutionRouteAssignmentInfo")]
  public partial class ResolutionRouteAssignmentInfo : global::ProtoBuf.IExtensible
  {
    public ResolutionRouteAssignmentInfo() {}
    
    private string _RouteId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RouteId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RouteId
    {
      get { return _RouteId; }
      set { _RouteId = value; }
    }
    private string _Author;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Author", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Author
    {
      get { return _Author; }
      set { _Author = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResolutionRouteRemovalInfo")]
  public partial class ResolutionRouteRemovalInfo : global::ProtoBuf.IExtensible
  {
    public ResolutionRouteRemovalInfo() {}
    
    private string _RouteId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"RouteId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string RouteId
    {
      get { return _RouteId; }
      set { _RouteId = value; }
    }
    private string _Author;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Author", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Author
    {
      get { return _Author; }
      set { _Author = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}