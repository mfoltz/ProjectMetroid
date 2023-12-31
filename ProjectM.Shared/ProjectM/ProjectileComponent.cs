// Decompiled with JetBrains decompiler
// Type: ProjectM.ProjectileComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ProjectileComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveXLoops;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveX;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveY;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurveXScale;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelToMouseCursor;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelToMouseCursorLengthOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_OverrideLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecalculateLifetimeBasedOnTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetRotationEveryFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_DelayLifeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_get_IEnumerable_1_SpellModSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726769, XrefRangeEnd = 726780, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ProjectileComponent.NativeMethodInfoPtr_get_SpellModSettings_Public_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726780, XrefRangeEnd = 726807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ProjectileComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726807, XrefRangeEnd = 726823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectileComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726823, XrefRangeEnd = 726824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectileComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectileComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectileComponent()
    {
      Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ProjectileComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr);
      ProjectileComponent.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (Speed));
      ProjectileComponent.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (Range));
      ProjectileComponent.NativeFieldInfoPtr_CurveZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (CurveZ));
      ProjectileComponent.NativeFieldInfoPtr_CurveXLoops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (CurveXLoops));
      ProjectileComponent.NativeFieldInfoPtr_CurveX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (CurveX));
      ProjectileComponent.NativeFieldInfoPtr_HeightOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (HeightOffset));
      ProjectileComponent.NativeFieldInfoPtr_CurveY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (CurveY));
      ProjectileComponent.NativeFieldInfoPtr_CurveXScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (CurveXScale));
      ProjectileComponent.NativeFieldInfoPtr_TravelToMouseCursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (TravelToMouseCursor));
      ProjectileComponent.NativeFieldInfoPtr_TravelToMouseCursorLengthOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (TravelToMouseCursorLengthOffset));
      ProjectileComponent.NativeFieldInfoPtr_OverrideLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (OverrideLifetime));
      ProjectileComponent.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (MinRange));
      ProjectileComponent.NativeFieldInfoPtr_RecalculateLifetimeBasedOnTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (RecalculateLifetimeBasedOnTarget));
      ProjectileComponent.NativeFieldInfoPtr_SetRotationEveryFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (SetRotationEveryFrame));
      ProjectileComponent.NativeFieldInfoPtr_DelayLifeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (DelayLifeTime));
      ProjectileComponent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (SpellMods));
      ProjectileComponent.NativeMethodInfoPtr_get_SpellModSettings_Public_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, 100664265);
      ProjectileComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, 100664266);
      ProjectileComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, 100664267);
      ProjectileComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, 100664268);
    }

    public ProjectileComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_Speed)) = value;
      }
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe CurveReference CurveZ
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveZ));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveZ)) = value;
      }
    }

    public unsafe float CurveXLoops
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveXLoops));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveXLoops)) = value;
      }
    }

    public unsafe CurveReference CurveX
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveX));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveX)) = value;
      }
    }

    public unsafe float HeightOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_HeightOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_HeightOffset)) = value;
      }
    }

    public unsafe CurveReference CurveY
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveY));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveY)) = value;
      }
    }

    public unsafe float CurveXScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveXScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_CurveXScale)) = value;
      }
    }

    public unsafe bool TravelToMouseCursor
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_TravelToMouseCursor));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_TravelToMouseCursor)) = value;
      }
    }

    public unsafe float TravelToMouseCursorLengthOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_TravelToMouseCursorLengthOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_TravelToMouseCursorLengthOffset)) = value;
      }
    }

    public unsafe float OverrideLifetime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_OverrideLifetime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_OverrideLifetime)) = value;
      }
    }

    public unsafe float MinRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_MinRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_MinRange)) = value;
      }
    }

    public unsafe bool RecalculateLifetimeBasedOnTarget
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_RecalculateLifetimeBasedOnTarget));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_RecalculateLifetimeBasedOnTarget)) = value;
      }
    }

    public unsafe bool SetRotationEveryFrame
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_SetRotationEveryFrame));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_SetRotationEveryFrame)) = value;
      }
    }

    public unsafe float DelayLifeTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_DelayLifeTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_DelayLifeTime)) = value;
      }
    }

    public ProjectileComponent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_SpellMods);
        return new ProjectileComponent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Speed;
      private static readonly System.IntPtr NativeFieldInfoPtr_Range;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectileComponent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr);
        ProjectileComponent.SpellModsAuthoring.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr, nameof (Speed));
        ProjectileComponent.SpellModsAuthoring.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr, nameof (Range));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProjectileComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Speed
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.SpellModsAuthoring.NativeFieldInfoPtr_Speed));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.SpellModsAuthoring.NativeFieldInfoPtr_Speed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Range
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.SpellModsAuthoring.NativeFieldInfoPtr_Range));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ProjectileComponent.SpellModsAuthoring.NativeFieldInfoPtr_Range), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
