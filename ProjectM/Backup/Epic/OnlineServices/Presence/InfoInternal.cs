// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.InfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence
{
  [StructLayout(LayoutKind.Explicit)]
  public struct InfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Status;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_UserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Platform;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RichText;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RecordsCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Records;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_IntegratedPlatform;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Status_Public_get_Status_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductId_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductVersion_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Platform_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Platform_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RichText_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RichText_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ProductName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IntegratedPlatform_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_IntegratedPlatform_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Info_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Info_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Info_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public Status m_Status;
    [FieldOffset(8)]
    public System.IntPtr m_UserId;
    [FieldOffset(16)]
    public System.IntPtr m_ProductId;
    [FieldOffset(24)]
    public System.IntPtr m_ProductVersion;
    [FieldOffset(32)]
    public System.IntPtr m_Platform;
    [FieldOffset(40)]
    public System.IntPtr m_RichText;
    [FieldOffset(48)]
    public int m_RecordsCount;
    [FieldOffset(56)]
    public System.IntPtr m_Records;
    [FieldOffset(64)]
    public System.IntPtr m_ProductName;
    [FieldOffset(72)]
    public System.IntPtr m_IntegratedPlatform;

    public unsafe Status Status
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_Status_Public_get_Status_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Status*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe EpicAccountId UserId
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 948259, RefRangeEnd = 948260, XrefRangeStart = 948253, XrefRangeEnd = 948259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (EpicAccountId) null : new EpicAccountId(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948260, XrefRangeEnd = 948264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948264, XrefRangeEnd = 948268, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_ProductId_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948268, XrefRangeEnd = 948272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductVersion
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948272, XrefRangeEnd = 948276, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_ProductVersion_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948276, XrefRangeEnd = 948280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Platform
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948280, XrefRangeEnd = 948284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948284, XrefRangeEnd = 948288, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_Platform_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RichText
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948288, XrefRangeEnd = 948292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_RichText_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948292, XrefRangeEnd = 948296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_RichText_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppReferenceArray<DataRecord> Records
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 948302, RefRangeEnd = 948303, XrefRangeStart = 948296, XrefRangeEnd = 948302, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<DataRecord>) null : new Il2CppReferenceArray<DataRecord>(nativeObject);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 948309, RefRangeEnd = 948311, XrefRangeStart = 948303, XrefRangeEnd = 948309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String ProductName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948311, XrefRangeEnd = 948315, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_ProductName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948315, XrefRangeEnd = 948319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String IntegratedPlatform
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948319, XrefRangeEnd = 948323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_get_IntegratedPlatform_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948323, XrefRangeEnd = 948327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_set_IntegratedPlatform_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948327, XrefRangeEnd = 948356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Info other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Info_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948356, XrefRangeEnd = 948405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<Info> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Info_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948405, XrefRangeEnd = 948416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948416, XrefRangeEnd = 948417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out Info output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Info_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Info local = ref output;
      System.IntPtr pointer = zero;
      Info info = pointer == System.IntPtr.Zero ? (Info) null : new Info(pointer);
      local = info;
    }

    static InfoInternal()
    {
      Il2CppClassPointerStore<InfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Presence", nameof (InfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr);
      InfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      InfoInternal.NativeFieldInfoPtr_m_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_Status));
      InfoInternal.NativeFieldInfoPtr_m_UserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_UserId));
      InfoInternal.NativeFieldInfoPtr_m_ProductId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ProductId));
      InfoInternal.NativeFieldInfoPtr_m_ProductVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ProductVersion));
      InfoInternal.NativeFieldInfoPtr_m_Platform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_Platform));
      InfoInternal.NativeFieldInfoPtr_m_RichText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_RichText));
      InfoInternal.NativeFieldInfoPtr_m_RecordsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_RecordsCount));
      InfoInternal.NativeFieldInfoPtr_m_Records = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_Records));
      InfoInternal.NativeFieldInfoPtr_m_ProductName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_ProductName));
      InfoInternal.NativeFieldInfoPtr_m_IntegratedPlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, nameof (m_IntegratedPlatform));
      InfoInternal.NativeMethodInfoPtr_get_Status_Public_get_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668140);
      InfoInternal.NativeMethodInfoPtr_set_Status_Public_set_Void_Status_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668141);
      InfoInternal.NativeMethodInfoPtr_get_UserId_Public_get_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668142);
      InfoInternal.NativeMethodInfoPtr_set_UserId_Public_set_Void_EpicAccountId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668143);
      InfoInternal.NativeMethodInfoPtr_get_ProductId_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668144);
      InfoInternal.NativeMethodInfoPtr_set_ProductId_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668145);
      InfoInternal.NativeMethodInfoPtr_get_ProductVersion_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668146);
      InfoInternal.NativeMethodInfoPtr_set_ProductVersion_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668147);
      InfoInternal.NativeMethodInfoPtr_get_Platform_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668148);
      InfoInternal.NativeMethodInfoPtr_set_Platform_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668149);
      InfoInternal.NativeMethodInfoPtr_get_RichText_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668150);
      InfoInternal.NativeMethodInfoPtr_set_RichText_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668151);
      InfoInternal.NativeMethodInfoPtr_get_Records_Public_get_Il2CppReferenceArray_1_DataRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668152);
      InfoInternal.NativeMethodInfoPtr_set_Records_Public_set_Void_Il2CppReferenceArray_1_DataRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668153);
      InfoInternal.NativeMethodInfoPtr_get_ProductName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668154);
      InfoInternal.NativeMethodInfoPtr_set_ProductName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668155);
      InfoInternal.NativeMethodInfoPtr_get_IntegratedPlatform_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668156);
      InfoInternal.NativeMethodInfoPtr_set_IntegratedPlatform_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668157);
      InfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Info_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668158);
      InfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Info_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668159);
      InfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668160);
      InfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Info_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, 100668161);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
