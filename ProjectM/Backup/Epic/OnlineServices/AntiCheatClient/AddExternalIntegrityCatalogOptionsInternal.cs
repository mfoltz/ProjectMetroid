// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatClient.AddExternalIntegrityCatalogOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatClient
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AddExternalIntegrityCatalogOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_PathToBinFile;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PathToBinFile_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddExternalIntegrityCatalogOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AddExternalIntegrityCatalogOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_PathToBinFile;

    public unsafe Epic.OnlineServices.Utf8String PathToBinFile
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970792, XrefRangeEnd = 970796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_set_PathToBinFile_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 970800, RefRangeEnd = 970801, XrefRangeStart = 970796, XrefRangeEnd = 970800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AddExternalIntegrityCatalogOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddExternalIntegrityCatalogOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970801, XrefRangeEnd = 970809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<AddExternalIntegrityCatalogOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AddExternalIntegrityCatalogOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970809, XrefRangeEnd = 970813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AddExternalIntegrityCatalogOptionsInternal()
    {
      Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatClient", nameof (AddExternalIntegrityCatalogOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr);
      AddExternalIntegrityCatalogOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AddExternalIntegrityCatalogOptionsInternal.NativeFieldInfoPtr_m_PathToBinFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, nameof (m_PathToBinFile));
      AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_set_PathToBinFile_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100674322);
      AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AddExternalIntegrityCatalogOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100674323);
      AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AddExternalIntegrityCatalogOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100674324);
      AddExternalIntegrityCatalogOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, 100674325);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AddExternalIntegrityCatalogOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
