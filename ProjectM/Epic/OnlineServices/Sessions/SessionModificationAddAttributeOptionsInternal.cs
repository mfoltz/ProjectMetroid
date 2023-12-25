// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionModificationAddAttributeOptionsInternal
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
  [StructLayout(LayoutKind.Explicit)]
  public struct SessionModificationAddAttributeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_SessionAttribute;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_AdvertisementType;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_SessionAttribute_Public_set_Void_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionModificationAddAttributeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionModificationAddAttributeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_SessionAttribute;
    [FieldOffset(16)]
    public SessionAttributeAdvertisementType m_AdvertisementType;

    public unsafe Il2CppSystem.Nullable<AttributeData> SessionAttribute
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942106, XrefRangeEnd = 942112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_SessionAttribute_Public_set_Void_Nullable_1_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe SessionAttributeAdvertisementType AdvertisementType
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 942118, RefRangeEnd = 942119, XrefRangeStart = 942112, XrefRangeEnd = 942118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SessionModificationAddAttributeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionModificationAddAttributeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942119, XrefRangeEnd = 942131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<SessionModificationAddAttributeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionModificationAddAttributeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942131, XrefRangeEnd = 942135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionModificationAddAttributeOptionsInternal()
    {
      Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionModificationAddAttributeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr);
      SessionModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SessionModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_SessionAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_SessionAttribute));
      SessionModificationAddAttributeOptionsInternal.NativeFieldInfoPtr_m_AdvertisementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, nameof (m_AdvertisementType));
      SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_SessionAttribute_Public_set_Void_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100666478);
      SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_set_AdvertisementType_Public_set_Void_SessionAttributeAdvertisementType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100666479);
      SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100666480);
      SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionModificationAddAttributeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100666481);
      SessionModificationAddAttributeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, 100666482);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionModificationAddAttributeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
