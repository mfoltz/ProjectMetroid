// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Authoring.BallAndSocketJoint
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
  public class BallAndSocketJoint : BaseJoint
  {
    private static readonly IntPtr NativeFieldInfoPtr_EditPivots;
    private static readonly IntPtr NativeFieldInfoPtr_AutoSetConnected;
    private static readonly IntPtr NativeFieldInfoPtr_PositionLocal;
    private static readonly IntPtr NativeFieldInfoPtr_PositionInConnectedEntity;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateAuto_Public_Virtual_New_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 926817, RefRangeEnd = 926819, XrefRangeStart = 926777, XrefRangeEnd = 926817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void UpdateAuto()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BallAndSocketJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926819, XrefRangeEnd = 926834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Create(
      EntityManager entityManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BallAndSocketJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 926835, RefRangeEnd = 926837, XrefRangeStart = 926834, XrefRangeEnd = 926835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BallAndSocketJoint()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BallAndSocketJoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BallAndSocketJoint()
    {
      Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Authoring", nameof (BallAndSocketJoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr);
      BallAndSocketJoint.NativeFieldInfoPtr_EditPivots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr, nameof (EditPivots));
      BallAndSocketJoint.NativeFieldInfoPtr_AutoSetConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr, nameof (AutoSetConnected));
      BallAndSocketJoint.NativeFieldInfoPtr_PositionLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr, nameof (PositionLocal));
      BallAndSocketJoint.NativeFieldInfoPtr_PositionInConnectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr, nameof (PositionInConnectedEntity));
      BallAndSocketJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr, 100664039);
      BallAndSocketJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr, 100664040);
      BallAndSocketJoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BallAndSocketJoint>.NativeClassPtr, 100664041);
    }

    public BallAndSocketJoint(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool EditPivots
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_EditPivots));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_EditPivots)) = value;
      }
    }

    public unsafe bool AutoSetConnected
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_AutoSetConnected));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_AutoSetConnected)) = value;
      }
    }

    public unsafe float3 PositionLocal
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_PositionLocal));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_PositionLocal)) = value;
      }
    }

    public unsafe float3 PositionInConnectedEntity
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_PositionInConnectedEntity));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BallAndSocketJoint.NativeFieldInfoPtr_PositionInConnectedEntity)) = value;
      }
    }
  }
}
