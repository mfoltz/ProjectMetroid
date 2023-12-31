// Decompiled with JetBrains decompiler
// Type: ProjectM.TravelBuffComponent
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
  public class TravelBuffComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ScaleDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeightCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_Height;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHeightDiff;
    private static readonly System.IntPtr NativeFieldInfoPtr_ExtraDistanceAllowed;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetStartPositionFromBuffTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_StopAtHighCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreAllCollision;
    private static readonly System.IntPtr NativeFieldInfoPtr_DenyLowerHeight;
    private static readonly System.IntPtr NativeFieldInfoPtr_AimYOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_TravelTargetMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetRangeOffset;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOffsetRadius;
    private static readonly System.IntPtr NativeFieldInfoPtr_ManuallySetupInCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_RotationMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727114, XrefRangeEnd = 727139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(TravelBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727139, XrefRangeEnd = 727149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TravelBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 727149, XrefRangeEnd = 727150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TravelBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TravelBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TravelBuffComponent()
    {
      Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TravelBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr);
      TravelBuffComponent.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (Duration));
      TravelBuffComponent.NativeFieldInfoPtr_ScaleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (ScaleDuration));
      TravelBuffComponent.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (MinDuration));
      TravelBuffComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (Curve));
      TravelBuffComponent.NativeFieldInfoPtr_HeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (HeightCurve));
      TravelBuffComponent.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (Height));
      TravelBuffComponent.NativeFieldInfoPtr_MaxHeightDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (MaxHeightDiff));
      TravelBuffComponent.NativeFieldInfoPtr_ExtraDistanceAllowed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (ExtraDistanceAllowed));
      TravelBuffComponent.NativeFieldInfoPtr_GetStartPositionFromBuffTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (GetStartPositionFromBuffTarget));
      TravelBuffComponent.NativeFieldInfoPtr_StopAtHighCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (StopAtHighCollision));
      TravelBuffComponent.NativeFieldInfoPtr_IgnoreAllCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (IgnoreAllCollision));
      TravelBuffComponent.NativeFieldInfoPtr_DenyLowerHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (DenyLowerHeight));
      TravelBuffComponent.NativeFieldInfoPtr_AimYOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (AimYOffset));
      TravelBuffComponent.NativeFieldInfoPtr_TravelTargetMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (TravelTargetMode));
      TravelBuffComponent.NativeFieldInfoPtr_TargetRangeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (TargetRangeOffset));
      TravelBuffComponent.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (MinRange));
      TravelBuffComponent.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (MaxRange));
      TravelBuffComponent.NativeFieldInfoPtr_RandomOffsetRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (RandomOffsetRadius));
      TravelBuffComponent.NativeFieldInfoPtr_ManuallySetupInCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (ManuallySetupInCode));
      TravelBuffComponent.NativeFieldInfoPtr_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (RotationMode));
      TravelBuffComponent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (SpellMods));
      TravelBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, 100664308);
      TravelBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, 100664309);
      TravelBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, 100664310);
    }

    public TravelBuffComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe bool ScaleDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_ScaleDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_ScaleDuration)) = value;
      }
    }

    public unsafe float MinDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MinDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MinDuration)) = value;
      }
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public unsafe CurveReference HeightCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_HeightCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_HeightCurve)) = value;
      }
    }

    public unsafe float Height
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_Height));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_Height)) = value;
      }
    }

    public unsafe float MaxHeightDiff
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MaxHeightDiff));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MaxHeightDiff)) = value;
      }
    }

    public unsafe float ExtraDistanceAllowed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_ExtraDistanceAllowed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_ExtraDistanceAllowed)) = value;
      }
    }

    public unsafe bool GetStartPositionFromBuffTarget
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_GetStartPositionFromBuffTarget));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_GetStartPositionFromBuffTarget)) = value;
      }
    }

    public unsafe bool StopAtHighCollision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_StopAtHighCollision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_StopAtHighCollision)) = value;
      }
    }

    public unsafe bool IgnoreAllCollision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_IgnoreAllCollision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_IgnoreAllCollision)) = value;
      }
    }

    public unsafe bool DenyLowerHeight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_DenyLowerHeight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_DenyLowerHeight)) = value;
      }
    }

    public unsafe float AimYOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_AimYOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_AimYOffset)) = value;
      }
    }

    public unsafe TravelTargetMode TravelTargetMode
    {
      get
      {
        return *(TravelTargetMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_TravelTargetMode));
      }
      [param: In] set
      {
        *(TravelTargetMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_TravelTargetMode)) = value;
      }
    }

    public unsafe float TargetRangeOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_TargetRangeOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_TargetRangeOffset)) = value;
      }
    }

    public unsafe float MinRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MinRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MinRange)) = value;
      }
    }

    public unsafe float MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_MaxRange)) = value;
      }
    }

    public unsafe float RandomOffsetRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_RandomOffsetRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_RandomOffsetRadius)) = value;
      }
    }

    public unsafe bool ManuallySetupInCode
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_ManuallySetupInCode));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_ManuallySetupInCode)) = value;
      }
    }

    public unsafe MovementCurveRotationMode RotationMode
    {
      get
      {
        return *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_RotationMode));
      }
      [param: In] set
      {
        *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_RotationMode)) = value;
      }
    }

    public TravelBuffComponent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_SpellMods);
        return new TravelBuffComponent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
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
        Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TravelBuffComponent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr);
        TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MinRange));
        TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MaxRange));
        TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MinTime));
        TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MaxTime));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TravelBuffComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MinRange
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinRange));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MaxRange
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxRange));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxRange), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MinTime
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinTime));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MinTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MaxTime
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxTime));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TravelBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
