// Decompiled with JetBrains decompiler
// Type: Unity.Physics.Authoring.BaseBodyPairConnector
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
using UnityEngine;

#nullable disable
namespace Unity.Physics.Authoring
{
  public class BaseBodyPairConnector : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ConnectedBody;
    private static readonly IntPtr NativeFieldInfoPtr__EntityA_k__BackingField;
    private static readonly IntPtr NativeFieldInfoPtr__EntityB_k__BackingField;
    private static readonly IntPtr NativeMethodInfoPtr_get_LocalBody_Public_get_PhysicsBodyAuthoring_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_worldFromA_Public_get_RigidTransform_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_worldFromB_Public_get_RigidTransform_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_EntityA_Public_get_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_EntityA_Public_set_Void_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_EntityB_Public_get_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_EntityB_Public_set_Void_Entity_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    public unsafe PhysicsBodyAuthoring LocalBody
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 926732, RefRangeEnd = 926733, XrefRangeStart = 926729, XrefRangeEnd = 926732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_get_LocalBody_Public_get_PhysicsBodyAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (PhysicsBodyAuthoring) null : new PhysicsBodyAuthoring(pointer);
      }
    }

    public unsafe RigidTransform worldFromA
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 926755, RefRangeEnd = 926758, XrefRangeStart = 926733, XrefRangeEnd = 926755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_get_worldFromA_Public_get_RigidTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(RigidTransform*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe RigidTransform worldFromB
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 926774, RefRangeEnd = 926777, XrefRangeStart = 926758, XrefRangeEnd = 926774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_get_worldFromB_Public_get_RigidTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(RigidTransform*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe Entity EntityA
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_get_EntityA_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_set_EntityA_Public_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Entity EntityB
    {
      [CallerCount(12), CachedScanResults(RefRangeStart = 22440, RefRangeEnd = 22452, XrefRangeStart = 22440, XrefRangeEnd = 22452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_get_EntityB_Public_get_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_set_EntityB_Public_set_Void_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Create(
      EntityManager entityManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &entityManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseBodyPairConnector.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Void_EntityManager_GameObjectConversionSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BaseBodyPairConnector()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BaseBodyPairConnector.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BaseBodyPairConnector()
    {
      Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Physics.Authoring", nameof (BaseBodyPairConnector));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr);
      BaseBodyPairConnector.NativeFieldInfoPtr_ConnectedBody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, nameof (ConnectedBody));
      BaseBodyPairConnector.NativeFieldInfoPtr__EntityA_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, "<EntityA>k__BackingField");
      BaseBodyPairConnector.NativeFieldInfoPtr__EntityB_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, "<EntityB>k__BackingField");
      BaseBodyPairConnector.NativeMethodInfoPtr_get_LocalBody_Public_get_PhysicsBodyAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664029);
      BaseBodyPairConnector.NativeMethodInfoPtr_get_worldFromA_Public_get_RigidTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664030);
      BaseBodyPairConnector.NativeMethodInfoPtr_get_worldFromB_Public_get_RigidTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664031);
      BaseBodyPairConnector.NativeMethodInfoPtr_get_EntityA_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664032);
      BaseBodyPairConnector.NativeMethodInfoPtr_set_EntityA_Public_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664033);
      BaseBodyPairConnector.NativeMethodInfoPtr_get_EntityB_Public_get_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664034);
      BaseBodyPairConnector.NativeMethodInfoPtr_set_EntityB_Public_set_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664035);
      BaseBodyPairConnector.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664036);
      BaseBodyPairConnector.NativeMethodInfoPtr_Create_Public_Abstract_Virtual_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664037);
      BaseBodyPairConnector.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseBodyPairConnector>.NativeClassPtr, 100664038);
    }

    public BaseBodyPairConnector(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PhysicsBodyAuthoring ConnectedBody
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseBodyPairConnector.NativeFieldInfoPtr_ConnectedBody));
        return pointer == IntPtr.Zero ? (PhysicsBodyAuthoring) null : new PhysicsBodyAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BaseBodyPairConnector.NativeFieldInfoPtr_ConnectedBody), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Entity _EntityA_k__BackingField
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseBodyPairConnector.NativeFieldInfoPtr__EntityA_k__BackingField));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseBodyPairConnector.NativeFieldInfoPtr__EntityA_k__BackingField)) = value;
      }
    }

    public unsafe Entity _EntityB_k__BackingField
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseBodyPairConnector.NativeFieldInfoPtr__EntityB_k__BackingField));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BaseBodyPairConnector.NativeFieldInfoPtr__EntityB_k__BackingField)) = value;
      }
    }
  }
}
