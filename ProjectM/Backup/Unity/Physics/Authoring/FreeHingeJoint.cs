// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Authoring.FreeHingeJoint
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
  public class FreeHingeJoint : BallAndSocketJoint
  {
    private static readonly IntPtr NativeFieldInfoPtr_EditAxes;
    private static readonly IntPtr NativeFieldInfoPtr_HingeAxisLocal;
    private static readonly IntPtr NativeFieldInfoPtr_HingeAxisInConnectedEntity;
    private static readonly IntPtr NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 926854, RefRangeEnd = 926855, XrefRangeStart = 926849, XrefRangeEnd = 926854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void UpdateAuto()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FreeHingeJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926855, XrefRangeEnd = 926864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Create(
      EntityManager entityManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FreeHingeJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 926865, RefRangeEnd = 926866, XrefRangeStart = 926864, XrefRangeEnd = 926865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FreeHingeJoint()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FreeHingeJoint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FreeHingeJoint()
    {
      Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Authoring", nameof (FreeHingeJoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr);
      FreeHingeJoint.NativeFieldInfoPtr_EditAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr, nameof (EditAxes));
      FreeHingeJoint.NativeFieldInfoPtr_HingeAxisLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr, nameof (HingeAxisLocal));
      FreeHingeJoint.NativeFieldInfoPtr_HingeAxisInConnectedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr, nameof (HingeAxisInConnectedEntity));
      FreeHingeJoint.NativeMethodInfoPtr_UpdateAuto_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr, 100664045);
      FreeHingeJoint.NativeMethodInfoPtr_Create_Public_Virtual_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr, 100664046);
      FreeHingeJoint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeHingeJoint>.NativeClassPtr, 100664047);
    }

    public FreeHingeJoint(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool EditAxes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeHingeJoint.NativeFieldInfoPtr_EditAxes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeHingeJoint.NativeFieldInfoPtr_EditAxes)) = value;
      }
    }

    public unsafe float3 HingeAxisLocal
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeHingeJoint.NativeFieldInfoPtr_HingeAxisLocal));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeHingeJoint.NativeFieldInfoPtr_HingeAxisLocal)) = value;
      }
    }

    public unsafe float3 HingeAxisInConnectedEntity
    {
      get
      {
        return *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeHingeJoint.NativeFieldInfoPtr_HingeAxisInConnectedEntity));
      }
      [param: In] set
      {
        *(float3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FreeHingeJoint.NativeFieldInfoPtr_HingeAxisInConnectedEntity)) = value;
      }
    }
  }
}
