// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Authoring.RagdollJoint
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace Unity.Physics.Authoring
{
  public class RagdollJoint : BallAndSocketJoint
  {
    private static readonly IntPtr NativeFieldInfoPtr_k_LatestVersion;
    private static readonly IntPtr NativeFieldInfoPtr_EditAxes;
    private static readonly IntPtr NativeFieldInfoPtr_EditLimits;
    private static readonly IntPtr NativeFieldInfoPtr_m_Version;
    private static readonly IntPtr NativeFieldInfoPtr_TwistAxisLocal;
    private static readonly IntPtr NativeFieldInfoPtr_TwistAxisInConnectedEntity;
    private static readonly IntPtr NativeFieldInfoPtr_PerpendicularAxisLocal;
    private static readonly IntPtr NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity;
    private static readonly IntPtr NativeFieldInfoPtr_MaxConeAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MinPerpendicularAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MaxPerpendicularAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MinTwistAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MaxTwistAngle;
    private static readonly IntPtr NativeMethodInfoPtr_UpgradeVersionIfNecessary_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public unsafe void UpgradeVersionIfNecessary()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollJoint.NativeMethodInfoPtr_UpgradeVersionIfNecessary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926886, XrefRangeEnd = 926900, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnValidate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollJoint.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926900, XrefRangeEnd = 926905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void UpdateAuto()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RagdollJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926905, XrefRangeEnd = 926923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Create(
      EntityManager entityManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RagdollJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 926865, RefRangeEnd = 926866, XrefRangeStart = 926865, XrefRangeEnd = 926866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RagdollJoint()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RagdollJoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RagdollJoint()
    {
      Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Authoring", nameof (RagdollJoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr);
      RagdollJoint.NativeFieldInfoPtr_k_LatestVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (k_LatestVersion));
      RagdollJoint.NativeFieldInfoPtr_EditAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (EditAxes));
      RagdollJoint.NativeFieldInfoPtr_EditLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (EditLimits));
      RagdollJoint.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (m_Version));
      RagdollJoint.NativeFieldInfoPtr_TwistAxisLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (TwistAxisLocal));
      RagdollJoint.NativeFieldInfoPtr_TwistAxisInConnectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (TwistAxisInConnectedEntity));
      RagdollJoint.NativeFieldInfoPtr_PerpendicularAxisLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (PerpendicularAxisLocal));
      RagdollJoint.NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (PerpendicularAxisInConnectedEntity));
      RagdollJoint.NativeFieldInfoPtr_MaxConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (MaxConeAngle));
      RagdollJoint.NativeFieldInfoPtr_MinPerpendicularAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (MinPerpendicularAngle));
      RagdollJoint.NativeFieldInfoPtr_MaxPerpendicularAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (MaxPerpendicularAngle));
      RagdollJoint.NativeFieldInfoPtr_MinTwistAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (MinTwistAngle));
      RagdollJoint.NativeFieldInfoPtr_MaxTwistAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, nameof (MaxTwistAngle));
      RagdollJoint.NativeMethodInfoPtr_UpgradeVersionIfNecessary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, 100664051);
      RagdollJoint.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, 100664052);
      RagdollJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, 100664053);
      RagdollJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, 100664054);
      RagdollJoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollJoint>.NativeClassPtr, 100664055);
    }

    public RagdollJoint(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int k_LatestVersion
    {
      get
      {
        int kLatestVersion;
        IL2CPP.il2cpp_field_static_get_value(RagdollJoint.NativeFieldInfoPtr_k_LatestVersion, (void*) &kLatestVersion);
        return kLatestVersion;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RagdollJoint.NativeFieldInfoPtr_k_LatestVersion, (void*) &value);
      }
    }

    public unsafe bool EditAxes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_EditAxes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_EditAxes)) = value;
      }
    }

    public unsafe bool EditLimits
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_EditLimits));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_EditLimits)) = value;
      }
    }

    public unsafe int m_Version
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_m_Version));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_m_Version)) = value;
      }
    }

    public unsafe float3 TwistAxisLocal
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_TwistAxisLocal));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_TwistAxisLocal)) = value;
      }
    }

    public unsafe float3 TwistAxisInConnectedEntity
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_TwistAxisInConnectedEntity));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_TwistAxisInConnectedEntity)) = value;
      }
    }

    public unsafe float3 PerpendicularAxisLocal
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_PerpendicularAxisLocal));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_PerpendicularAxisLocal)) = value;
      }
    }

    public unsafe float3 PerpendicularAxisInConnectedEntity
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity)) = value;
      }
    }

    public unsafe float MaxConeAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MaxConeAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MaxConeAngle)) = value;
      }
    }

    public unsafe float MinPerpendicularAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MinPerpendicularAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MinPerpendicularAngle)) = value;
      }
    }

    public unsafe float MaxPerpendicularAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MaxPerpendicularAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MaxPerpendicularAngle)) = value;
      }
    }

    public unsafe float MinTwistAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MinTwistAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MinTwistAngle)) = value;
      }
    }

    public unsafe float MaxTwistAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MaxTwistAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RagdollJoint.NativeFieldInfoPtr_MaxTwistAngle)) = value;
      }
    }
  }
}
