// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.TransferDeviceIdAccountOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TransferDeviceIdAccountOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PrimaryLocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalDeviceUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ProductUserIdToPreserve;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_TransferDeviceIdAccountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_TransferDeviceIdAccountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PrimaryLocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_LocalDeviceUserId;
    [FieldOffset(24)]
    public System.IntPtr m_ProductUserIdToPreserve;

    public unsafe ProductUserId PrimaryLocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966441, XrefRangeEnd = 966445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId LocalDeviceUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966445, XrefRangeEnd = 966449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ProductUserId ProductUserIdToPreserve
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966449, XrefRangeEnd = 966453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 966465, RefRangeEnd = 966466, XrefRangeStart = 966453, XrefRangeEnd = 966465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref TransferDeviceIdAccountOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_TransferDeviceIdAccountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966466, XrefRangeEnd = 966486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<TransferDeviceIdAccountOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_TransferDeviceIdAccountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 966486, XrefRangeEnd = 966492, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TransferDeviceIdAccountOptionsInternal()
    {
      Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (TransferDeviceIdAccountOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr);
      TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_PrimaryLocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_PrimaryLocalUserId));
      TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_LocalDeviceUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_LocalDeviceUserId));
      TransferDeviceIdAccountOptionsInternal.NativeFieldInfoPtr_m_ProductUserIdToPreserve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, nameof (m_ProductUserIdToPreserve));
      TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_PrimaryLocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100673135);
      TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_LocalDeviceUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100673136);
      TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_set_ProductUserIdToPreserve_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100673137);
      TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_TransferDeviceIdAccountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100673138);
      TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_TransferDeviceIdAccountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100673139);
      TransferDeviceIdAccountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, 100673140);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransferDeviceIdAccountOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
