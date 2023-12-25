// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Presence.PresenceModificationDataRecordIdInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Presence
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PresenceModificationDataRecordIdInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Key;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PresenceModificationDataRecordId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PresenceModificationDataRecordId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PresenceModificationDataRecordId_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Key;

    public unsafe Epic.OnlineServices.Utf8String Key
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948849, XrefRangeEnd = 948853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948853, XrefRangeEnd = 948857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948857, XrefRangeEnd = 948861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref PresenceModificationDataRecordId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PresenceModificationDataRecordId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948861, XrefRangeEnd = 948869, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<PresenceModificationDataRecordId> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PresenceModificationDataRecordId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948869, XrefRangeEnd = 948873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 948873, XrefRangeEnd = 948874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out PresenceModificationDataRecordId output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PresenceModificationDataRecordId_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref PresenceModificationDataRecordId local = ref output;
      System.IntPtr pointer = zero;
      PresenceModificationDataRecordId modificationDataRecordId = pointer == System.IntPtr.Zero ? (PresenceModificationDataRecordId) null : new PresenceModificationDataRecordId(pointer);
      local = modificationDataRecordId;
    }

    static PresenceModificationDataRecordIdInternal()
    {
      Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Presence", nameof (PresenceModificationDataRecordIdInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr);
      PresenceModificationDataRecordIdInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PresenceModificationDataRecordIdInternal.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, nameof (m_Key));
      PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, 100668260);
      PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, 100668261);
      PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PresenceModificationDataRecordId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, 100668262);
      PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_PresenceModificationDataRecordId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, 100668263);
      PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, 100668264);
      PresenceModificationDataRecordIdInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PresenceModificationDataRecordId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, 100668265);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PresenceModificationDataRecordIdInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
