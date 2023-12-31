// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldConfigUtilities
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class WorldConfigUtilities : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateSceneSystems_Public_Static_Void_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IncludeSceneSystems_Public_Static_Void_WorldTypeSystemConfig_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ExcludeSceneSystems_Public_Static_Void_WorldTypeSystemConfig_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneSystemTypes_Public_Static_Il2CppReferenceArray_1_Type_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722422, XrefRangeEnd = 722483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void CreateSceneSystems(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldConfigUtilities.NativeMethodInfoPtr_CreateSceneSystems_Public_Static_Void_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 722499, RefRangeEnd = 722501, XrefRangeStart = 722483, XrefRangeEnd = 722499, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void IncludeSceneSystems(WorldTypeSystemConfig worldTypeSystemConfig)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) worldTypeSystemConfig);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldConfigUtilities.NativeMethodInfoPtr_IncludeSceneSystems_Public_Static_Void_WorldTypeSystemConfig_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722501, XrefRangeEnd = 722521, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ExcludeSceneSystems(
      WorldTypeSystemConfig worldTypeSystemConfig,
      bool keepSceneSystemGroup)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) worldTypeSystemConfig);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &keepSceneSystemGroup;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldConfigUtilities.NativeMethodInfoPtr_ExcludeSceneSystems_Public_Static_Void_WorldTypeSystemConfig_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 722560, RefRangeEnd = 722562, XrefRangeStart = 722521, XrefRangeEnd = 722560, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> GetSceneSystemTypes()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldConfigUtilities.NativeMethodInfoPtr_GetSceneSystemTypes_Public_Static_Il2CppReferenceArray_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : new Il2CppReferenceArray<Il2CppSystem.Type>(nativeObject);
    }

    static WorldConfigUtilities()
    {
      Il2CppClassPointerStore<WorldConfigUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldConfigUtilities));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldConfigUtilities>.NativeClassPtr);
      WorldConfigUtilities.NativeMethodInfoPtr_CreateSceneSystems_Public_Static_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldConfigUtilities>.NativeClassPtr, 100663799);
      WorldConfigUtilities.NativeMethodInfoPtr_IncludeSceneSystems_Public_Static_Void_WorldTypeSystemConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldConfigUtilities>.NativeClassPtr, 100663800);
      WorldConfigUtilities.NativeMethodInfoPtr_ExcludeSceneSystems_Public_Static_Void_WorldTypeSystemConfig_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldConfigUtilities>.NativeClassPtr, 100663801);
      WorldConfigUtilities.NativeMethodInfoPtr_GetSceneSystemTypes_Public_Static_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldConfigUtilities>.NativeClassPtr, 100663802);
    }

    public WorldConfigUtilities(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
