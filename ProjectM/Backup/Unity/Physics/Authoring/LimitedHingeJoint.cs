// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Authoring.LimitedHingeJoint
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
  public class LimitedHingeJoint : FreeHingeJoint
  {
    private static readonly IntPtr NativeFieldInfoPtr_EditLimits;
    private static readonly IntPtr NativeFieldInfoPtr_PerpendicularAxisLocal;
    private static readonly IntPtr NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity;
    private static readonly IntPtr NativeFieldInfoPtr_MinAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MaxAngle;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926866, XrefRangeEnd = 926871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void UpdateAuto()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LimitedHingeJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926871, XrefRangeEnd = 926885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Create(
      EntityManager entityManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LimitedHingeJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926885, XrefRangeEnd = 926886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LimitedHingeJoint()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LimitedHingeJoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LimitedHingeJoint()
    {
      Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Authoring", nameof (LimitedHingeJoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr);
      LimitedHingeJoint.NativeFieldInfoPtr_EditLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, nameof (EditLimits));
      LimitedHingeJoint.NativeFieldInfoPtr_PerpendicularAxisLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, nameof (PerpendicularAxisLocal));
      LimitedHingeJoint.NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, nameof (PerpendicularAxisInConnectedEntity));
      LimitedHingeJoint.NativeFieldInfoPtr_MinAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, nameof (MinAngle));
      LimitedHingeJoint.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, nameof (MaxAngle));
      LimitedHingeJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, 100664048);
      LimitedHingeJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, 100664049);
      LimitedHingeJoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LimitedHingeJoint>.NativeClassPtr, 100664050);
    }

    public LimitedHingeJoint(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool EditLimits
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_EditLimits));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_EditLimits)) = value;
      }
    }

    public unsafe float3 PerpendicularAxisLocal
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_PerpendicularAxisLocal));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_PerpendicularAxisLocal)) = value;
      }
    }

    public unsafe float3 PerpendicularAxisInConnectedEntity
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_PerpendicularAxisInConnectedEntity)) = value;
      }
    }

    public unsafe float MinAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_MinAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_MinAngle)) = value;
      }
    }

    public unsafe float MaxAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_MaxAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LimitedHingeJoint.NativeFieldInfoPtr_MaxAngle)) = value;
      }
    }
  }
}
