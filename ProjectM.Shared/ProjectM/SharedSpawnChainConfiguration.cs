// Decompiled with JetBrains decompiler
// Type: ProjectM.SharedSpawnChainConfiguration
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SharedSpawnChainConfiguration : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnChain;
    private static readonly System.IntPtr NativeFieldInfoPtr_AutoTransitions;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainElementOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_TileSettingsOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorVisualsOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr_LoopOnTransitionEnd;
    private static readonly System.IntPtr NativeFieldInfoPtr_EnforceSamePlacementShapesOnChildren;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727991, XrefRangeEnd = 727992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SharedSpawnChainConfiguration()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SharedSpawnChainConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SharedSpawnChainConfiguration()
    {
      Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SharedSpawnChainConfiguration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr);
      SharedSpawnChainConfiguration.NativeFieldInfoPtr_SpawnChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (SpawnChain));
      SharedSpawnChainConfiguration.NativeFieldInfoPtr_AutoTransitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (AutoTransitions));
      SharedSpawnChainConfiguration.NativeFieldInfoPtr_MainElementOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (MainElementOverride));
      SharedSpawnChainConfiguration.NativeFieldInfoPtr_TileSettingsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (TileSettingsOverride));
      SharedSpawnChainConfiguration.NativeFieldInfoPtr_EditorVisualsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (EditorVisualsOverride));
      SharedSpawnChainConfiguration.NativeFieldInfoPtr_LoopOnTransitionEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (LoopOnTransitionEnd));
      SharedSpawnChainConfiguration.NativeFieldInfoPtr_EnforceSamePlacementShapesOnChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (EnforceSamePlacementShapesOnChildren));
      SharedSpawnChainConfiguration.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, 100664468);
    }

    public SharedSpawnChainConfiguration(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnChainAsset SpawnChain
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_SpawnChain));
        return pointer == System.IntPtr.Zero ? (SpawnChainAsset) null : new SpawnChainAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_SpawnChain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SharedSpawnChainConfiguration.AutoChainTransitionArray AutoTransitions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_AutoTransitions));
        return pointer == System.IntPtr.Zero ? (SharedSpawnChainConfiguration.AutoChainTransitionArray) null : new SharedSpawnChainConfiguration.AutoChainTransitionArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_AutoTransitions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnChainAssetElement MainElementOverride
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_MainElementOverride));
        return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_MainElementOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnChainAssetElement TileSettingsOverride
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_TileSettingsOverride));
        return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_TileSettingsOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnChainAssetElement EditorVisualsOverride
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_EditorVisualsOverride));
        return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_EditorVisualsOverride), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool LoopOnTransitionEnd
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_LoopOnTransitionEnd));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_LoopOnTransitionEnd)) = value;
      }
    }

    public unsafe bool EnforceSamePlacementShapesOnChildren
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_EnforceSamePlacementShapesOnChildren));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.NativeFieldInfoPtr_EnforceSamePlacementShapesOnChildren)) = value;
      }
    }

    [Serializable]
    public class AutoChainTransitionArray : 
      ReorderableArray<SharedSpawnChainConfiguration.AutoChainTransition>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727988, XrefRangeEnd = 727991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AutoChainTransitionArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransitionArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SharedSpawnChainConfiguration.AutoChainTransitionArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AutoChainTransitionArray()
      {
        Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransitionArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (AutoChainTransitionArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransitionArray>.NativeClassPtr);
        SharedSpawnChainConfiguration.AutoChainTransitionArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransitionArray>.NativeClassPtr, 100664469);
      }

      public AutoChainTransitionArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [Serializable]
    public class AutoChainTransition : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChainElement;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransitionAfterDuration;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe AutoChainTransition()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransition>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SharedSpawnChainConfiguration.AutoChainTransition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static AutoChainTransition()
      {
        Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SharedSpawnChainConfiguration>.NativeClassPtr, nameof (AutoChainTransition));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransition>.NativeClassPtr);
        SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_ChainElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransition>.NativeClassPtr, nameof (ChainElement));
        SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_TransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransition>.NativeClassPtr, nameof (TransitionId));
        SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_TransitionAfterDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransition>.NativeClassPtr, nameof (TransitionAfterDuration));
        SharedSpawnChainConfiguration.AutoChainTransition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedSpawnChainConfiguration.AutoChainTransition>.NativeClassPtr, 100664470);
      }

      public AutoChainTransition(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpawnChainAssetElement ChainElement
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_ChainElement));
          return pointer == System.IntPtr.Zero ? (SpawnChainAssetElement) null : new SpawnChainAssetElement(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_ChainElement), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SpawnChainTransitionId TransitionId
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_TransitionId));
          return pointer == System.IntPtr.Zero ? (SpawnChainTransitionId) null : new SpawnChainTransitionId(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_TransitionId), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe float TransitionAfterDuration
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_TransitionAfterDuration));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedSpawnChainConfiguration.AutoChainTransition.NativeFieldInfoPtr_TransitionAfterDuration)) = value;
        }
      }
    }
  }
}
