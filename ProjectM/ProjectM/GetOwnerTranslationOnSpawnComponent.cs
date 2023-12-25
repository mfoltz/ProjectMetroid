// Decompiled with JetBrains decompiler
// Type: ProjectM.GetOwnerTranslationOnSpawnComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Physics;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class GetOwnerTranslationOnSpawnComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_SpawnOffset;
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreOffsetLastTranslationOnSpawn;
    private static readonly IntPtr NativeFieldInfoPtr_ObstacleBehavior;
    private static readonly IntPtr NativeFieldInfoPtr_ObstacleFilter;
    private static readonly IntPtr NativeFieldInfoPtr_TranslationSource;
    private static readonly IntPtr NativeFieldInfoPtr_SnapToGround;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996378, XrefRangeEnd = 996398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetOwnerTranslationOnSpawnComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996398, XrefRangeEnd = 996405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GetOwnerTranslationOnSpawnComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GetOwnerTranslationOnSpawnComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GetOwnerTranslationOnSpawnComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GetOwnerTranslationOnSpawnComponent()
    {
      Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (GetOwnerTranslationOnSpawnComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr);
      GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_SpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, nameof (SpawnOffset));
      GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_IgnoreOffsetLastTranslationOnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, nameof (IgnoreOffsetLastTranslationOnSpawn));
      GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_ObstacleBehavior = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, nameof (ObstacleBehavior));
      GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_ObstacleFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, nameof (ObstacleFilter));
      GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_TranslationSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, nameof (TranslationSource));
      GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_SnapToGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, nameof (SnapToGround));
      GetOwnerTranslationOnSpawnComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, 100677009);
      GetOwnerTranslationOnSpawnComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, 100677010);
      GetOwnerTranslationOnSpawnComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetOwnerTranslationOnSpawnComponent>.NativeClassPtr, 100677011);
    }

    public GetOwnerTranslationOnSpawnComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 SpawnOffset
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_SpawnOffset));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_SpawnOffset)) = value;
      }
    }

    public unsafe bool IgnoreOffsetLastTranslationOnSpawn
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_IgnoreOffsetLastTranslationOnSpawn));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_IgnoreOffsetLastTranslationOnSpawn)) = value;
      }
    }

    public unsafe SpawnOffsetObstacleBehavior ObstacleBehavior
    {
      get
      {
        return *(SpawnOffsetObstacleBehavior*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_ObstacleBehavior));
      }
      [param: In] set
      {
        *(SpawnOffsetObstacleBehavior*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_ObstacleBehavior)) = value;
      }
    }

    public unsafe CollisionFilterFlags ObstacleFilter
    {
      get
      {
        return *(CollisionFilterFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_ObstacleFilter));
      }
      [param: In] set
      {
        *(CollisionFilterFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_ObstacleFilter)) = value;
      }
    }

    public unsafe GetOwnerTranslationOnSpawnComponent.GetTranslationSource TranslationSource
    {
      get
      {
        return *(GetOwnerTranslationOnSpawnComponent.GetTranslationSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_TranslationSource));
      }
      [param: In] set
      {
        *(GetOwnerTranslationOnSpawnComponent.GetTranslationSource*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_TranslationSource)) = value;
      }
    }

    public unsafe bool SnapToGround
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_SnapToGround));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GetOwnerTranslationOnSpawnComponent.NativeFieldInfoPtr_SnapToGround)) = value;
      }
    }

    public enum GetTranslationSource
    {
      Owner,
      Creator,
      BuffTarget,
      SpellTarget,
      None,
    }
  }
}
