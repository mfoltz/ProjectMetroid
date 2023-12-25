// Decompiled with JetBrains decompiler
// Type: ProjectM.AimPreviewUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class AimPreviewUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_KEY;
    private static readonly System.IntPtr NativeFieldInfoPtr__AimPreviewEnabledCached;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_AimPreviewsEnabled_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_AimPreviewsEnabled_Public_Static_set_Void_Boolean_0;

    public static unsafe bool AimPreviewsEnabled
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 995930, RefRangeEnd = 995938, XrefRangeStart = 995912, XrefRangeEnd = 995930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AimPreviewUtility.NativeMethodInfoPtr_get_AimPreviewsEnabled_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995938, XrefRangeEnd = 995947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AimPreviewUtility.NativeMethodInfoPtr_set_AimPreviewsEnabled_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static AimPreviewUtility()
    {
      Il2CppClassPointerStore<AimPreviewUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AimPreviewUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AimPreviewUtility>.NativeClassPtr);
      AimPreviewUtility.NativeFieldInfoPtr_PREFS_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewUtility>.NativeClassPtr, nameof (PREFS_KEY));
      AimPreviewUtility.NativeFieldInfoPtr__AimPreviewEnabledCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AimPreviewUtility>.NativeClassPtr, nameof (_AimPreviewEnabledCached));
      AimPreviewUtility.NativeMethodInfoPtr_get_AimPreviewsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimPreviewUtility>.NativeClassPtr, 100676921);
      AimPreviewUtility.NativeMethodInfoPtr_set_AimPreviewsEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AimPreviewUtility>.NativeClassPtr, 100676922);
    }

    public AimPreviewUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string PREFS_KEY
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(AimPreviewUtility.NativeFieldInfoPtr_PREFS_KEY, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AimPreviewUtility.NativeFieldInfoPtr_PREFS_KEY, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Nullable_Unboxed<bool> _AimPreviewEnabledCached
    {
      get
      {
        Nullable_Unboxed<bool> previewEnabledCached;
        IL2CPP.il2cpp_field_static_get_value(AimPreviewUtility.NativeFieldInfoPtr__AimPreviewEnabledCached, (void*) &previewEnabledCached);
        return previewEnabledCached;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AimPreviewUtility.NativeFieldInfoPtr__AimPreviewEnabledCached, (void*) &value);
      }
    }
  }
}
