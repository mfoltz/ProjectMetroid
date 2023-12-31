// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class SpawnUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableSpawned_Public_Static_Void_EntityManager_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableSpawned_Public_Static_Void_EntityCommandBuffer_Entity_0;

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 765247, RefRangeEnd = 765257, XrefRangeStart = 765226, XrefRangeEnd = 765247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DisableSpawned(EntityManager entityManager, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnUtility.NativeMethodInfoPtr_DisableSpawned_Public_Static_Void_EntityManager_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 765260, RefRangeEnd = 765277, XrefRangeStart = 765257, XrefRangeEnd = 765260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DisableSpawned(EntityCommandBuffer commandBuffer, Entity entity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &commandBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnUtility.NativeMethodInfoPtr_DisableSpawned_Public_Static_Void_EntityCommandBuffer_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnUtility()
    {
      Il2CppClassPointerStore<SpawnUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SpawnUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnUtility>.NativeClassPtr);
      SpawnUtility.NativeMethodInfoPtr_DisableSpawned_Public_Static_Void_EntityManager_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnUtility>.NativeClassPtr, 100667591);
      SpawnUtility.NativeMethodInfoPtr_DisableSpawned_Public_Static_Void_EntityCommandBuffer_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnUtility>.NativeClassPtr, 100667592);
    }

    public SpawnUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
