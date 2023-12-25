// Decompiled with JetBrains decompiler
// Type: ProjectM.PersistenceV2Test
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class PersistenceV2Test : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateLoadTestWorld_Public_Static_World_GameBootstrap_Boolean_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TriggerNewLoad_Public_Static_Void_World_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DestroyLoadTest_Public_Static_Void_World_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057796, RefRangeEnd = 1057797, XrefRangeStart = 1057696, XrefRangeEnd = 1057796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe World CreateLoadTestWorld(
      GameBootstrap gameBootstrap,
      bool forceUseSubScenes,
      bool keepLoadedDataAfterLoad)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameBootstrap);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &forceUseSubScenes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &keepLoadedDataAfterLoad;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PersistenceV2Test.NativeMethodInfoPtr_CreateLoadTestWorld_Public_Static_World_GameBootstrap_Boolean_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (World) null : new World(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1057832, RefRangeEnd = 1057833, XrefRangeStart = 1057797, XrefRangeEnd = 1057832, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void TriggerNewLoad(
      World world,
      string saveDirectoryPath,
      string saveToLoad)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveDirectoryPath);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(saveToLoad);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Test.NativeMethodInfoPtr_TriggerNewLoad_Public_Static_Void_World_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1057836, RefRangeEnd = 1057838, XrefRangeStart = 1057833, XrefRangeEnd = 1057836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DestroyLoadTest(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PersistenceV2Test.NativeMethodInfoPtr_DestroyLoadTest_Public_Static_Void_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PersistenceV2Test()
    {
      Il2CppClassPointerStore<PersistenceV2Test>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PersistenceV2Test));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistenceV2Test>.NativeClassPtr);
      PersistenceV2Test.NativeMethodInfoPtr_CreateLoadTestWorld_Public_Static_World_GameBootstrap_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Test>.NativeClassPtr, 100683043);
      PersistenceV2Test.NativeMethodInfoPtr_TriggerNewLoad_Public_Static_Void_World_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Test>.NativeClassPtr, 100683044);
      PersistenceV2Test.NativeMethodInfoPtr_DestroyLoadTest_Public_Static_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistenceV2Test>.NativeClassPtr, 100683045);
    }

    public PersistenceV2Test(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
