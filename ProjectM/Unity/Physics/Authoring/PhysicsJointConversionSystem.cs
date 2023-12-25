// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Authoring.PhysicsJointConversionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Unity.Physics.Authoring
{
  public class PhysicsJointConversionSystem : GameObjectConversionSystem
  {
    private static readonly IntPtr NativeMethodInfoPtr_CreateJoint_Private_Void_BaseJoint_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_BallAndSocketJoint_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_1_Private_Void_FreeHingeJoint_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_2_Private_Void_LimitedHingeJoint_0;
    private static readonly IntPtr NativeMethodInfoPtr__OnUpdate_b__1_3_Private_Void_RagdollJoint_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 926669, RefRangeEnd = 926673, XrefRangeStart = 926658, XrefRangeEnd = 926669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateJoint(BaseJoint joint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joint);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsJointConversionSystem.NativeMethodInfoPtr_CreateJoint_Private_Void_BaseJoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926673, XrefRangeEnd = 926709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PhysicsJointConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhysicsJointConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsJointConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926709, XrefRangeEnd = 926714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_0(BallAndSocketJoint joint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joint);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_BallAndSocketJoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926714, XrefRangeEnd = 926719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_1(FreeHingeJoint joint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joint);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_1_Private_Void_FreeHingeJoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926719, XrefRangeEnd = 926724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_2(LimitedHingeJoint joint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joint);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_2_Private_Void_LimitedHingeJoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 926724, XrefRangeEnd = 926729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__1_3(RagdollJoint joint)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joint);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_3_Private_Void_RagdollJoint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PhysicsJointConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhysicsJointConversionSystem()
    {
      Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Authoring", nameof (PhysicsJointConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr);
      PhysicsJointConversionSystem.NativeMethodInfoPtr_CreateJoint_Private_Void_BaseJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664021);
      PhysicsJointConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664022);
      PhysicsJointConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664023);
      PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_0_Private_Void_BallAndSocketJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664024);
      PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_1_Private_Void_FreeHingeJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664025);
      PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_2_Private_Void_LimitedHingeJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664026);
      PhysicsJointConversionSystem.NativeMethodInfoPtr__OnUpdate_b__1_3_Private_Void_RagdollJoint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664027);
      PhysicsJointConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsJointConversionSystem>.NativeClassPtr, 100664028);
    }

    public PhysicsJointConversionSystem(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
