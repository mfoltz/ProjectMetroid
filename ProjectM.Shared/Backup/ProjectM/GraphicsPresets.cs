// Decompiled with JetBrains decompiler
// Type: ProjectM.GraphicsPresets
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class GraphicsPresets : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_HighPreset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MediumPreset;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowPreset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
    private static readonly System.IntPtr NativeMethodInfoPtr_DefinePresets_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentPreset_Public_Static_PresetMode_GraphicsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyNonPresetSettings_Private_Static_Void_GraphicsSettings_byref_GraphicsSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPreset_Public_Static_Void_byref_GraphicsSettings_PresetMode_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 749066, RefRangeEnd = 749070, XrefRangeStart = 749010, XrefRangeEnd = 749066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DefinePresets()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsPresets.NativeMethodInfoPtr_DefinePresets_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 749089, RefRangeEnd = 749090, XrefRangeStart = 749070, XrefRangeEnd = 749089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe PresetMode GetCurrentPreset(GraphicsSettings settings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GraphicsPresets.NativeMethodInfoPtr_GetCurrentPreset_Public_Static_PresetMode_GraphicsSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PresetMode*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 749090, RefRangeEnd = 749093, XrefRangeStart = 749090, XrefRangeEnd = 749090, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyNonPresetSettings(
      GraphicsSettings settings,
      ref GraphicsSettings preset)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) preset);
      System.IntPtr* numPtr2 = &ptr;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsPresets.NativeMethodInfoPtr_CopyNonPresetSettings_Private_Static_Void_GraphicsSettings_byref_GraphicsSettings_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref GraphicsSettings local = ref preset;
      System.IntPtr pointer = ptr;
      GraphicsSettings graphicsSettings = pointer == System.IntPtr.Zero ? (GraphicsSettings) null : new GraphicsSettings(pointer);
      local = graphicsSettings;
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 749105, RefRangeEnd = 749108, XrefRangeStart = 749093, XrefRangeEnd = 749105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CopyPreset(ref GraphicsSettings settings, PresetMode mode)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) settings);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &mode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphicsPresets.NativeMethodInfoPtr_CopyPreset_Public_Static_Void_byref_GraphicsSettings_PresetMode_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref GraphicsSettings local = ref settings;
      System.IntPtr pointer = ptr;
      GraphicsSettings graphicsSettings = pointer == System.IntPtr.Zero ? (GraphicsSettings) null : new GraphicsSettings(pointer);
      local = graphicsSettings;
    }

    static GraphicsPresets()
    {
      Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GraphicsPresets));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr);
      GraphicsPresets.NativeFieldInfoPtr_HighPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, nameof (HighPreset));
      GraphicsPresets.NativeFieldInfoPtr_MediumPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, nameof (MediumPreset));
      GraphicsPresets.NativeFieldInfoPtr_LowPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, nameof (LowPreset));
      GraphicsPresets.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, nameof (Initialized));
      GraphicsPresets.NativeMethodInfoPtr_DefinePresets_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, 100665954);
      GraphicsPresets.NativeMethodInfoPtr_GetCurrentPreset_Public_Static_PresetMode_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, 100665955);
      GraphicsPresets.NativeMethodInfoPtr_CopyNonPresetSettings_Private_Static_Void_GraphicsSettings_byref_GraphicsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, 100665956);
      GraphicsPresets.NativeMethodInfoPtr_CopyPreset_Public_Static_Void_byref_GraphicsSettings_PresetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsPresets>.NativeClassPtr, 100665957);
    }

    public GraphicsPresets(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe GraphicsSettings HighPreset
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GraphicsPresets.NativeFieldInfoPtr_HighPreset, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GraphicsSettings) null : new GraphicsSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphicsPresets.NativeFieldInfoPtr_HighPreset, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe GraphicsSettings MediumPreset
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GraphicsPresets.NativeFieldInfoPtr_MediumPreset, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GraphicsSettings) null : new GraphicsSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphicsPresets.NativeFieldInfoPtr_MediumPreset, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe GraphicsSettings LowPreset
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(GraphicsPresets.NativeFieldInfoPtr_LowPreset, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GraphicsSettings) null : new GraphicsSettings(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphicsPresets.NativeFieldInfoPtr_LowPreset, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe bool Initialized
    {
      get
      {
        bool initialized;
        IL2CPP.il2cpp_field_static_get_value(GraphicsPresets.NativeFieldInfoPtr_Initialized, (void*) &initialized);
        return initialized;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(GraphicsPresets.NativeFieldInfoPtr_Initialized, (void*) &value);
      }
    }
  }
}
