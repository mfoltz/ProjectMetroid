// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Metrics.EndPlayerSessionOptionsAccountId
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Metrics
{
  public sealed class EndPlayerSessionOptionsAccountId : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AccountIdType;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Epic;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_External;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_External_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_EndPlayerSessionOptionsAccountIdInternal_0;

    public unsafe MetricsAccountIdType AccountIdType
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MetricsAccountIdType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId Epic
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 953487, RefRangeEnd = 953488, XrefRangeStart = 953481, XrefRangeEnd = 953487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 953494, RefRangeEnd = 953497, XrefRangeStart = 953488, XrefRangeEnd = 953494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String External
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 953503, RefRangeEnd = 953504, XrefRangeStart = 953497, XrefRangeEnd = 953503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(4), CachedScanResults(RefRangeStart = 953510, RefRangeEnd = 953514, XrefRangeStart = 953504, XrefRangeEnd = 953510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953514, XrefRangeEnd = 953515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator EndPlayerSessionOptionsAccountId(EpicAccountId value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_EpicAccountId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new EndPlayerSessionOptionsAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953515, XrefRangeEnd = 953516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator EndPlayerSessionOptionsAccountId(Epic.OnlineServices.Utf8String value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_Utf8String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new EndPlayerSessionOptionsAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953516, XrefRangeEnd = 953518, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator EndPlayerSessionOptionsAccountId(string value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(value);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new EndPlayerSessionOptionsAccountId(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953518, XrefRangeEnd = 953522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref EndPlayerSessionOptionsAccountIdInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_byref_EndPlayerSessionOptionsAccountIdInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EndPlayerSessionOptionsAccountId()
    {
      Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Metrics", nameof (EndPlayerSessionOptionsAccountId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr);
      EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_AccountIdType));
      EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_Epic));
      EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, nameof (m_External));
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_AccountIdType_Public_get_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669532);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_AccountIdType_Private_set_Void_MetricsAccountIdType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669533);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_Epic_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669534);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_Epic_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669535);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_get_External_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669536);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_set_External_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669537);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669538);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669539);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_op_Implicit_Public_Static_EndPlayerSessionOptionsAccountId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669540);
      EndPlayerSessionOptionsAccountId.NativeMethodInfoPtr_Set_Internal_Void_byref_EndPlayerSessionOptionsAccountIdInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, 100669541);
    }

    public EndPlayerSessionOptionsAccountId(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public EndPlayerSessionOptionsAccountId()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EndPlayerSessionOptionsAccountId>.NativeClassPtr, data));
    }

    public unsafe MetricsAccountIdType m_AccountIdType
    {
      get
      {
        return *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType));
      }
      [param: In] set
      {
        *(MetricsAccountIdType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_AccountIdType)) = value;
      }
    }

    public unsafe EpicAccountId m_Epic
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic));
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_Epic), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Epic.OnlineServices.Utf8String m_External
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External));
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EndPlayerSessionOptionsAccountId.NativeFieldInfoPtr_m_External), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
