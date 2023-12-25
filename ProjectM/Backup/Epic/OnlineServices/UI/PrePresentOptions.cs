// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.UI.PrePresentOptions
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PrePresentOptions
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PlatformSpecificData_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_PlatformSpecificData_Public_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_PlatformSpecificData_Public_set_Void_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_PrePresentOptionsInternal_0;
    [FieldOffset(0)]
    public System.IntPtr _PlatformSpecificData_k__BackingField;

    public unsafe System.IntPtr PlatformSpecificData
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 40794, RefRangeEnd = 40848, XrefRangeStart = 40794, XrefRangeEnd = 40848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PrePresentOptions.NativeMethodInfoPtr_get_PlatformSpecificData_Public_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 41102, RefRangeEnd = 41116, XrefRangeStart = 41102, XrefRangeEnd = 41116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrePresentOptions.NativeMethodInfoPtr_set_PlatformSpecificData_Public_set_Void_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 937891, RefRangeEnd = 937897, XrefRangeStart = 937891, XrefRangeEnd = 937891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref PrePresentOptionsInternal other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrePresentOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_PrePresentOptionsInternal_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrePresentOptions()
    {
      Il2CppClassPointerStore<PrePresentOptions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.UI", nameof (PrePresentOptions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrePresentOptions>.NativeClassPtr);
      PrePresentOptions.NativeFieldInfoPtr__PlatformSpecificData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrePresentOptions>.NativeClassPtr, "<PlatformSpecificData>k__BackingField");
      PrePresentOptions.NativeMethodInfoPtr_get_PlatformSpecificData_Public_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptions>.NativeClassPtr, 100665296);
      PrePresentOptions.NativeMethodInfoPtr_set_PlatformSpecificData_Public_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptions>.NativeClassPtr, 100665297);
      PrePresentOptions.NativeMethodInfoPtr_Set_Internal_Void_byref_PrePresentOptionsInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrePresentOptions>.NativeClassPtr, 100665298);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrePresentOptions>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
