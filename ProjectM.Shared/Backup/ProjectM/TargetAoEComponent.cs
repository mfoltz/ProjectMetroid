// Decompiled with JetBrains decompiler
// Type: ProjectM.TargetAoEComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TargetAoEComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRandomTimeAdded;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseRandomOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffsetMin;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffsetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThrowArcHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_ThrowMaxHeightDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_MapCollisionRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_FindValidPositionFromMax;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetPositionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_HandleCollisionType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727043, XrefRangeEnd = 727059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetAoEComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727059, XrefRangeEnd = 727066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TargetAoEComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727066, XrefRangeEnd = 727067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TargetAoEComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TargetAoEComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TargetAoEComponent()
    {
      Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TargetAoEComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr);
      TargetAoEComponent.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (MinRange));
      TargetAoEComponent.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (MaxRange));
      TargetAoEComponent.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (MinTime));
      TargetAoEComponent.NativeFieldInfoPtr_MaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (MaxTime));
      TargetAoEComponent.NativeFieldInfoPtr_MaxRandomTimeAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (MaxRandomTimeAdded));
      TargetAoEComponent.NativeFieldInfoPtr_UseRandomOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (UseRandomOffset));
      TargetAoEComponent.NativeFieldInfoPtr_RandomOffsetMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (RandomOffsetMin));
      TargetAoEComponent.NativeFieldInfoPtr_RandomOffsetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (RandomOffsetRadius));
      TargetAoEComponent.NativeFieldInfoPtr_ThrowArcHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (ThrowArcHeight));
      TargetAoEComponent.NativeFieldInfoPtr_ThrowMaxHeightDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (ThrowMaxHeightDiff));
      TargetAoEComponent.NativeFieldInfoPtr_MapCollisionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (MapCollisionRadius));
      TargetAoEComponent.NativeFieldInfoPtr_FindValidPositionFromMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (FindValidPositionFromMax));
      TargetAoEComponent.NativeFieldInfoPtr_TargetPositionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (TargetPositionType));
      TargetAoEComponent.NativeFieldInfoPtr_HandleCollisionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (HandleCollisionType));
      TargetAoEComponent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (SpellMods));
      TargetAoEComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, 100664299);
      TargetAoEComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, 100664300);
      TargetAoEComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, 100664301);
    }

    public TargetAoEComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MinRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MinRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MinRange)) = value;
      }
    }

    public unsafe float MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MaxRange)) = value;
      }
    }

    public unsafe float MinTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MinTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MinTime)) = value;
      }
    }

    public unsafe float MaxTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MaxTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MaxTime)) = value;
      }
    }

    public unsafe float MaxRandomTimeAdded
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MaxRandomTimeAdded));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MaxRandomTimeAdded)) = value;
      }
    }

    public unsafe bool UseRandomOffset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_UseRandomOffset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_UseRandomOffset)) = value;
      }
    }

    public unsafe float RandomOffsetMin
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_RandomOffsetMin));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_RandomOffsetMin)) = value;
      }
    }

    public unsafe float RandomOffsetRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_RandomOffsetRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_RandomOffsetRadius)) = value;
      }
    }

    public unsafe float ThrowArcHeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_ThrowArcHeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_ThrowArcHeight)) = value;
      }
    }

    public unsafe float ThrowMaxHeightDiff
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_ThrowMaxHeightDiff));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_ThrowMaxHeightDiff)) = value;
      }
    }

    public unsafe float MapCollisionRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MapCollisionRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_MapCollisionRadius)) = value;
      }
    }

    public unsafe bool FindValidPositionFromMax
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_FindValidPositionFromMax));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_FindValidPositionFromMax)) = value;
      }
    }

    public unsafe TargetAoE.TargetPositionTypeEnum TargetPositionType
    {
      get
      {
        return *(TargetAoE.TargetPositionTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_TargetPositionType));
      }
      [param: In] set
      {
        *(TargetAoE.TargetPositionTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_TargetPositionType)) = value;
      }
    }

    public unsafe TargetAoE.HandleCollisionTypeEnum HandleCollisionType
    {
      get
      {
        return *(TargetAoE.HandleCollisionTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_HandleCollisionType));
      }
      [param: In] set
      {
        *(TargetAoE.HandleCollisionTypeEnum*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_HandleCollisionType)) = value;
      }
    }

    public TargetAoEComponent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_SpellMods);
        return new TargetAoEComponent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
      private static readonly System.IntPtr NativeFieldInfoPtr_MinTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxTime;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TargetAoEComponent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr);
        TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MinRange));
        TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MaxRange));
        TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MinTime));
        TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MaxTime));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TargetAoEComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MinRange
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinRange));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MaxRange
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxRange));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MinTime
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinTime));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MaxTime
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxTime));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TargetAoEComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
