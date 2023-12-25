// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Authoring.BaseJoint
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Physics.Authoring
{
  public class BaseJoint : BaseBodyPairConnector
  {
    private static readonly IntPtr NativeFieldInfoPtr_EnableCollision;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetConstrainedBodyPair_Protected_PhysicsConstrainedBodyPair_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BaseJoint.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 926846, RefRangeEnd = 926849, XrefRangeStart = 926837, XrefRangeEnd = 926846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhysicsConstrainedBodyPair GetConstrainedBodyPair(
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(BaseJoint.NativeMethodInfoPtr_GetConstrainedBodyPair_Protected_PhysicsConstrainedBodyPair_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(PhysicsConstrainedBodyPair*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BaseJoint()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseJoint>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BaseJoint.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BaseJoint()
    {
      Il2CppClassPointerStore<BaseJoint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Authoring", nameof (BaseJoint));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseJoint>.NativeClassPtr);
      BaseJoint.NativeFieldInfoPtr_EnableCollision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseJoint>.NativeClassPtr, nameof (EnableCollision));
      BaseJoint.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseJoint>.NativeClassPtr, 100664042);
      BaseJoint.NativeMethodInfoPtr_GetConstrainedBodyPair_Protected_PhysicsConstrainedBodyPair_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseJoint>.NativeClassPtr, 100664043);
      BaseJoint.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseJoint>.NativeClassPtr, 100664044);
    }

    public BaseJoint(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool EnableCollision
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseJoint.NativeFieldInfoPtr_EnableCollision));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseJoint.NativeFieldInfoPtr_EnableCollision)) = value;
      }
    }
  }
}
