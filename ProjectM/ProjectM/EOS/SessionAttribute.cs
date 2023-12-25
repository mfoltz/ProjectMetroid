// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.SessionAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.Sessions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.EOS
{
  public sealed class SessionAttribute : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_key;
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToAttributeData_Public_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToAttributeData_Public_Static_AttributeData_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0;

    public unsafe string Key
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(SessionAttribute.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1122964, XrefRangeEnd = 1122967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionAttribute.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(45)]
    [CachedScanResults(RefRangeStart = 1122971, RefRangeEnd = 1123016, XrefRangeStart = 1122967, XrefRangeEnd = 1122971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionAttribute(string key, AttributeDataValue value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_AttributeDataValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1123016, XrefRangeEnd = 1123020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionAttribute(AttributeData attributeData)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) attributeData));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123023, RefRangeEnd = 1123024, XrefRangeStart = 1123020, XrefRangeEnd = 1123023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AttributeData ToAttributeData()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionAttribute.NativeMethodInfoPtr_ToAttributeData_Public_AttributeData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AttributeData(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1123030, RefRangeEnd = 1123032, XrefRangeStart = 1123024, XrefRangeEnd = 1123030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AttributeData ToAttributeData(
      KeyValuePair<string, KeyValuePair<AttributeDataValue, bool>> attributeKVP)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) attributeKVP));
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SessionAttribute.NativeMethodInfoPtr_ToAttributeData_Public_Static_AttributeData_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new AttributeData(pointer);
    }

    static SessionAttribute()
    {
      Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (SessionAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr);
      SessionAttribute.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, nameof (key));
      SessionAttribute.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, nameof (value));
      SessionAttribute.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, 100689111);
      SessionAttribute.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, 100689112);
      SessionAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, 100689113);
      SessionAttribute.NativeMethodInfoPtr__ctor_Public_Void_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, 100689114);
      SessionAttribute.NativeMethodInfoPtr_ToAttributeData_Public_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, 100689115);
      SessionAttribute.NativeMethodInfoPtr_ToAttributeData_Public_Static_AttributeData_KeyValuePair_2_String_KeyValuePair_2_AttributeDataValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, 100689116);
    }

    public SessionAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SessionAttribute()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, data));
    }

    public unsafe string key
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionAttribute.NativeFieldInfoPtr_key)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SessionAttribute.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public AttributeDataValue value
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionAttribute.NativeFieldInfoPtr_value);
        return new AttributeDataValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SessionAttribute.NativeFieldInfoPtr_value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AttributeDataValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
