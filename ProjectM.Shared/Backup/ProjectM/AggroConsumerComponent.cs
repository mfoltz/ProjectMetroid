﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.AggroConsumerComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class AggroConsumerComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AggroRangeAsset;
    private static readonly IntPtr NativeFieldInfoPtr_AlertRangeAsset;
    private static readonly IntPtr NativeFieldInfoPtr_AggroSettingsAsset;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride;
    private static readonly IntPtr NativeFieldInfoPtr_UseBossCenterPositionAsPreCombatPosition;
    private static readonly IntPtr NativeFieldInfoPtr_BossCenterPositionRange;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722939, XrefRangeEnd = 722997, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AggroConsumerComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722997, XrefRangeEnd = 723001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AggroConsumerComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723001, XrefRangeEnd = 723002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AggroConsumerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AggroConsumerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AggroConsumerComponent()
    {
      Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AggroConsumerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr);
      AggroConsumerComponent.NativeFieldInfoPtr_AggroRangeAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, nameof (AggroRangeAsset));
      AggroConsumerComponent.NativeFieldInfoPtr_AlertRangeAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, nameof (AlertRangeAsset));
      AggroConsumerComponent.NativeFieldInfoPtr_AggroSettingsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, nameof (AggroSettingsAsset));
      AggroConsumerComponent.NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, nameof (MaxDistanceFromPreCombatPositionOverride));
      AggroConsumerComponent.NativeFieldInfoPtr_UseBossCenterPositionAsPreCombatPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, nameof (UseBossCenterPositionAsPreCombatPosition));
      AggroConsumerComponent.NativeFieldInfoPtr_BossCenterPositionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, nameof (BossCenterPositionRange));
      AggroConsumerComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, 100663872);
      AggroConsumerComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, 100663873);
      AggroConsumerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AggroConsumerComponent>.NativeClassPtr, 100663874);
    }

    public AggroConsumerComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AggroRangeAsset AggroRangeAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_AggroRangeAsset));
        return pointer == IntPtr.Zero ? (AggroRangeAsset) null : new AggroRangeAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_AggroRangeAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AlertRangeAsset AlertRangeAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_AlertRangeAsset));
        return pointer == IntPtr.Zero ? (AlertRangeAsset) null : new AlertRangeAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_AlertRangeAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AggroSettingsAsset AggroSettingsAsset
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_AggroSettingsAsset));
        return pointer == IntPtr.Zero ? (AggroSettingsAsset) null : new AggroSettingsAsset(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_AggroSettingsAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float MaxDistanceFromPreCombatPositionOverride
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_MaxDistanceFromPreCombatPositionOverride)) = value;
      }
    }

    public unsafe bool UseBossCenterPositionAsPreCombatPosition
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_UseBossCenterPositionAsPreCombatPosition));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_UseBossCenterPositionAsPreCombatPosition)) = value;
      }
    }

    public unsafe float BossCenterPositionRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_BossCenterPositionRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AggroConsumerComponent.NativeFieldInfoPtr_BossCenterPositionRange)) = value;
      }
    }
  }
}
