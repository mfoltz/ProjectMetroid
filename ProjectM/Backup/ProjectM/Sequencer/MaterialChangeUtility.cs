// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.MaterialChangeUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public static class MaterialChangeUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PREFS_KEY;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialChangeEnabledCache;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaterialChangeEnabled_Public_Static_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaterialChangeEnabled_Public_Static_set_Void_Boolean_0;

    public static unsafe bool MaterialChangeEnabled
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1089907, RefRangeEnd = 1089908, XrefRangeStart = 1089889, XrefRangeEnd = 1089907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaterialChangeUtility.NativeMethodInfoPtr_get_MaterialChangeEnabled_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089908, XrefRangeEnd = 1089917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MaterialChangeUtility.NativeMethodInfoPtr_set_MaterialChangeEnabled_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static MaterialChangeUtility()
    {
      Il2CppClassPointerStore<MaterialChangeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (MaterialChangeUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialChangeUtility>.NativeClassPtr);
      MaterialChangeUtility.NativeFieldInfoPtr_PREFS_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeUtility>.NativeClassPtr, nameof (PREFS_KEY));
      MaterialChangeUtility.NativeFieldInfoPtr_MaterialChangeEnabledCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialChangeUtility>.NativeClassPtr, nameof (MaterialChangeEnabledCache));
      MaterialChangeUtility.NativeMethodInfoPtr_get_MaterialChangeEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeUtility>.NativeClassPtr, 100685842);
      MaterialChangeUtility.NativeMethodInfoPtr_set_MaterialChangeEnabled_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialChangeUtility>.NativeClassPtr, 100685843);
    }

    public MaterialChangeUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string PREFS_KEY
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(MaterialChangeUtility.NativeFieldInfoPtr_PREFS_KEY, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialChangeUtility.NativeFieldInfoPtr_PREFS_KEY, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Nullable_Unboxed<bool> MaterialChangeEnabledCache
    {
      get
      {
        Nullable_Unboxed<bool> changeEnabledCache;
        IL2CPP.il2cpp_field_static_get_value(MaterialChangeUtility.NativeFieldInfoPtr_MaterialChangeEnabledCache, (void*) &changeEnabledCache);
        return changeEnabledCache;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MaterialChangeUtility.NativeFieldInfoPtr_MaterialChangeEnabledCache, (void*) &value);
      }
    }
  }
}
