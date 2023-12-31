// Decompiled with JetBrains decompiler
// Type: ProjectM.MountSettingsAsset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class MountSettingsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Acceleration;
    private static readonly IntPtr NativeFieldInfoPtr_Deceleration;
    private static readonly IntPtr NativeFieldInfoPtr_WalkMaxSpeeed;
    private static readonly IntPtr NativeFieldInfoPtr_GallopMaxSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_MaxSpeedReverse;
    private static readonly IntPtr NativeFieldInfoPtr_DegallopSpeedThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_TurnRate;
    private static readonly IntPtr NativeFieldInfoPtr_JumpFromCliffsMaxAngle;
    private static readonly IntPtr NativeFieldInfoPtr_JumpFromCliffsMinVelocity;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold;
    private static readonly IntPtr NativeFieldInfoPtr_MaxAimAngle;
    private static readonly IntPtr NativeFieldInfoPtr_TurnRatePerSpeedCurve;
    private static readonly IntPtr NativeFieldInfoPtr_FrictionCurve;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MountSettingsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MountSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MountSettingsAsset()
    {
      Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MountSettingsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr);
      MountSettingsAsset.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (Acceleration));
      MountSettingsAsset.NativeFieldInfoPtr_Deceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (Deceleration));
      MountSettingsAsset.NativeFieldInfoPtr_WalkMaxSpeeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (WalkMaxSpeeed));
      MountSettingsAsset.NativeFieldInfoPtr_GallopMaxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (GallopMaxSpeed));
      MountSettingsAsset.NativeFieldInfoPtr_MaxSpeedReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (MaxSpeedReverse));
      MountSettingsAsset.NativeFieldInfoPtr_DegallopSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (DegallopSpeedThreshold));
      MountSettingsAsset.NativeFieldInfoPtr_TurnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (TurnRate));
      MountSettingsAsset.NativeFieldInfoPtr_JumpFromCliffsMaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (JumpFromCliffsMaxAngle));
      MountSettingsAsset.NativeFieldInfoPtr_JumpFromCliffsMinVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (JumpFromCliffsMinVelocity));
      MountSettingsAsset.NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (DestroyOnCollisionSpeedThreshold));
      MountSettingsAsset.NativeFieldInfoPtr_MaxAimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (MaxAimAngle));
      MountSettingsAsset.NativeFieldInfoPtr_TurnRatePerSpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (TurnRatePerSpeedCurve));
      MountSettingsAsset.NativeFieldInfoPtr_FrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, nameof (FrictionCurve));
      MountSettingsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MountSettingsAsset>.NativeClassPtr, 100665342);
    }

    public MountSettingsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Acceleration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_Acceleration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_Acceleration)) = value;
      }
    }

    public unsafe float Deceleration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_Deceleration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_Deceleration)) = value;
      }
    }

    public unsafe float WalkMaxSpeeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_WalkMaxSpeeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_WalkMaxSpeeed)) = value;
      }
    }

    public unsafe float GallopMaxSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_GallopMaxSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_GallopMaxSpeed)) = value;
      }
    }

    public unsafe float MaxSpeedReverse
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_MaxSpeedReverse));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_MaxSpeedReverse)) = value;
      }
    }

    public unsafe float DegallopSpeedThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_DegallopSpeedThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_DegallopSpeedThreshold)) = value;
      }
    }

    public unsafe float TurnRate
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_TurnRate));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_TurnRate)) = value;
      }
    }

    public unsafe float JumpFromCliffsMaxAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_JumpFromCliffsMaxAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_JumpFromCliffsMaxAngle)) = value;
      }
    }

    public unsafe float JumpFromCliffsMinVelocity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_JumpFromCliffsMinVelocity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_JumpFromCliffsMinVelocity)) = value;
      }
    }

    public unsafe float DestroyOnCollisionSpeedThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold)) = value;
      }
    }

    public unsafe float MaxAimAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_MaxAimAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_MaxAimAngle)) = value;
      }
    }

    public unsafe CurveReference TurnRatePerSpeedCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_TurnRatePerSpeedCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_TurnRatePerSpeedCurve)) = value;
      }
    }

    public unsafe CurveReference FrictionCurve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_FrictionCurve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MountSettingsAsset.NativeFieldInfoPtr_FrictionCurve)) = value;
      }
    }
  }
}
