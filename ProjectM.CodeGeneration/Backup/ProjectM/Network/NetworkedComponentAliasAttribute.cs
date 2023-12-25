// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.NetworkedComponentAliasAttribute
// Assembly: ProjectM.CodeGeneration, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AE751F2E-D812-4D5F-A9DE-9160851E105B
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CodeGeneration.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  public class NetworkedComponentAliasAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetType;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 35476, RefRangeEnd = 35499, XrefRangeStart = 35476, XrefRangeEnd = 35499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NetworkedComponentAliasAttribute(Il2CppSystem.Type targetType)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkedComponentAliasAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetType);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NetworkedComponentAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NetworkedComponentAliasAttribute()
    {
      Il2CppClassPointerStore<NetworkedComponentAliasAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CodeGeneration.dll", "ProjectM.Network", nameof (NetworkedComponentAliasAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkedComponentAliasAttribute>.NativeClassPtr);
      NetworkedComponentAliasAttribute.NativeFieldInfoPtr_TargetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetworkedComponentAliasAttribute>.NativeClassPtr, nameof (TargetType));
      NetworkedComponentAliasAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkedComponentAliasAttribute>.NativeClassPtr, 100663483);
    }

    public NetworkedComponentAliasAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppSystem.Type TargetType
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentAliasAttribute.NativeFieldInfoPtr_TargetType));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NetworkedComponentAliasAttribute.NativeFieldInfoPtr_TargetType), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
