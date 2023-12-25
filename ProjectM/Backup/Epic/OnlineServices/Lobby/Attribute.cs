// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.Attribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  public sealed class Attribute : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Data_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__Visibility_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_AttributeInternal_0;

    public unsafe Il2CppSystem.Nullable<AttributeData> Data
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 294177, RefRangeEnd = 294178, XrefRangeStart = 294177, XrefRangeEnd = 294178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<AttributeData>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LobbyAttributeVisibility Visibility
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 45778, RefRangeEnd = 45781, XrefRangeStart = 45778, XrefRangeEnd = 45781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LobbyAttributeVisibility*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 953760, RefRangeEnd = 953761, XrefRangeStart = 953753, XrefRangeEnd = 953760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref AttributeInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Attribute.NativeMethodInfoPtr_Set_Internal_Void_byref_AttributeInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Attribute()
    {
      Il2CppClassPointerStore<Attribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (Attribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Attribute>.NativeClassPtr);
      Attribute.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Attribute>.NativeClassPtr, "<Data>k__BackingField");
      Attribute.NativeFieldInfoPtr__Visibility_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Attribute>.NativeClassPtr, "<Visibility>k__BackingField");
      Attribute.NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100669616);
      Attribute.NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100669617);
      Attribute.NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100669618);
      Attribute.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100669619);
      Attribute.NativeMethodInfoPtr_Set_Internal_Void_byref_AttributeInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attribute>.NativeClassPtr, 100669620);
    }

    public Attribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Attribute()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Attribute>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Attribute>.NativeClassPtr, data));
    }

    public Il2CppSystem.Nullable<AttributeData> _Data_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Data_k__BackingField);
        return new Il2CppSystem.Nullable<AttributeData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<AttributeData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<AttributeData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe LobbyAttributeVisibility _Visibility_k__BackingField
    {
      get
      {
        return *(LobbyAttributeVisibility*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Visibility_k__BackingField));
      }
      [param: In] set
      {
        *(LobbyAttributeVisibility*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Attribute.NativeFieldInfoPtr__Visibility_k__BackingField)) = value;
      }
    }
  }
}
