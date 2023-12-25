// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuffsHelper
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CastleBuffsHelper : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ApplyBuff_Public_Static_Void_PrefabGUID_Entity_Entity_PrefabCollectionSystem_BuffSpawner_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveBuff_Public_Static_Void_PrefabGUID_Entity_PrefabCollectionSystem_BuffSpawner_EntityCommandBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190771, XrefRangeEnd = 1190784, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ApplyBuff(
      PrefabGUID buffPrefabGUID,
      Entity target,
      Entity creator,
      PrefabCollectionSystem collectionSystem,
      BuffUtility.BuffSpawner buffSpawner)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &buffPrefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &creator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &buffSpawner;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuffsHelper.NativeMethodInfoPtr_ApplyBuff_Public_Static_Void_PrefabGUID_Entity_Entity_PrefabCollectionSystem_BuffSpawner_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190784, XrefRangeEnd = 1190797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void RemoveBuff(
      PrefabGUID buffPrefabGUID,
      Entity target,
      PrefabCollectionSystem collectionSystem,
      BuffUtility.BuffSpawner buffSpawner,
      EntityCommandBuffer destroyBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &buffPrefabGUID;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) collectionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buffSpawner;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &destroyBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuffsHelper.NativeMethodInfoPtr_RemoveBuff_Public_Static_Void_PrefabGUID_Entity_PrefabCollectionSystem_BuffSpawner_EntityCommandBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuffsHelper()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuffsHelper>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuffsHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuffsHelper()
    {
      Il2CppClassPointerStore<CastleBuffsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM", nameof (CastleBuffsHelper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuffsHelper>.NativeClassPtr);
      CastleBuffsHelper.NativeMethodInfoPtr_ApplyBuff_Public_Static_Void_PrefabGUID_Entity_Entity_PrefabCollectionSystem_BuffSpawner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsHelper>.NativeClassPtr, 100663352);
      CastleBuffsHelper.NativeMethodInfoPtr_RemoveBuff_Public_Static_Void_PrefabGUID_Entity_PrefabCollectionSystem_BuffSpawner_EntityCommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsHelper>.NativeClassPtr, 100663353);
      CastleBuffsHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsHelper>.NativeClassPtr, 100663354);
    }

    public CastleBuffsHelper(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
