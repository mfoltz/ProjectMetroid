// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  public sealed class SessionDetailsAttribute : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Data_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__AdvertisementType_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AdvertisementType_Public_get_SessionAttributeAdvertisementType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_SessionDetailsAttributeInternal_0;

    public unsafe Il2CppSystem.Nullable<AttributeData> Data
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 294177, RefRangeEnd = 294178, XrefRangeStart = 294177, XrefRangeEnd = 294178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttribute.NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<AttributeData>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 941525, XrefRangeEnd = 941526, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttribute.NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SessionAttributeAdvertisementType AdvertisementType
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 45778, RefRangeEnd = 45781, XrefRangeStart = 45778, XrefRangeEnd = 45781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttribute.NativeMethodInfoPtr_get_AdvertisementType_Public_get_SessionAttributeAdvertisementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SessionAttributeAdvertisementType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttribute.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 941533, RefRangeEnd = 941534, XrefRangeStart = 941526, XrefRangeEnd = 941533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref SessionDetailsAttributeInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionDetailsAttribute.NativeMethodInfoPtr_Set_Internal_Void_byref_SessionDetailsAttributeInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionDetailsAttribute()
    {
      Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr);
      SessionDetailsAttribute.NativeFieldInfoPtr__Data_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, "<Data>k__BackingField");
      SessionDetailsAttribute.NativeFieldInfoPtr__AdvertisementType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, "<AdvertisementType>k__BackingField");
      SessionDetailsAttribute.NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, 100666332);
      SessionDetailsAttribute.NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, 100666333);
      SessionDetailsAttribute.NativeMethodInfoPtr_get_AdvertisementType_Public_get_SessionAttributeAdvertisementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, 100666334);
      SessionDetailsAttribute.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, 100666335);
      SessionDetailsAttribute.NativeMethodInfoPtr_Set_Internal_Void_byref_SessionDetailsAttributeInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, 100666336);
    }

    public SessionDetailsAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SessionDetailsAttribute()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsAttribute>.NativeClassPtr, data));
    }

    public Il2CppSystem.Nullable<AttributeData> _Data_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsAttribute.NativeFieldInfoPtr__Data_k__BackingField);
        return new Il2CppSystem.Nullable<AttributeData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Il2CppSystem.Nullable<AttributeData>>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsAttribute.NativeFieldInfoPtr__Data_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Il2CppSystem.Nullable<AttributeData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SessionAttributeAdvertisementType _AdvertisementType_k__BackingField
    {
      get
      {
        return *(SessionAttributeAdvertisementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsAttribute.NativeFieldInfoPtr__AdvertisementType_k__BackingField));
      }
      [param: In] set
      {
        *(SessionAttributeAdvertisementType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionDetailsAttribute.NativeFieldInfoPtr__AdvertisementType_k__BackingField)) = value;
      }
    }
  }
}
