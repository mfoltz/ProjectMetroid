// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.P2P.SocketId
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.P2P
{
  public sealed class SocketId : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SocketName_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SocketName_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SocketName_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_SocketIdInternal_0;

    public unsafe string SocketName
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SocketId.NativeMethodInfoPtr_get_SocketName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SocketId.NativeMethodInfoPtr_set_SocketName_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 952398, RefRangeEnd = 952399, XrefRangeStart = 952393, XrefRangeEnd = 952398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref SocketIdInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SocketId.NativeMethodInfoPtr_Set_Internal_Void_byref_SocketIdInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SocketId()
    {
      Il2CppClassPointerStore<SocketId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.P2P", nameof (SocketId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SocketId>.NativeClassPtr);
      SocketId.NativeFieldInfoPtr__SocketName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SocketId>.NativeClassPtr, "<SocketName>k__BackingField");
      SocketId.NativeMethodInfoPtr_get_SocketName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketId>.NativeClassPtr, 100669260);
      SocketId.NativeMethodInfoPtr_set_SocketName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketId>.NativeClassPtr, 100669261);
      SocketId.NativeMethodInfoPtr_Set_Internal_Void_byref_SocketIdInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SocketId>.NativeClassPtr, 100669262);
    }

    public SocketId(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SocketId()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SocketId>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SocketId>.NativeClassPtr, data));
    }

    public unsafe string _SocketName_k__BackingField
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SocketId.NativeFieldInfoPtr__SocketName_k__BackingField)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SocketId.NativeFieldInfoPtr__SocketName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
