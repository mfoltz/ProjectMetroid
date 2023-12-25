// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EntityInConeInstantAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Behaviours
{
  public class EntityInConeInstantAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_EntityRegister;
    private static readonly IntPtr NativeFieldInfoPtr_ConeAngle;
    private static readonly IntPtr NativeFieldInfoPtr_ConeRotationOffset;
    private static readonly IntPtr NativeFieldInfoPtr_ConeRadius;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337318, XrefRangeEnd = 1337323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EntityInConeInstantAuthoring(
      string entityRegister,
      float coneAngle,
      float coneRotationOffset = 0.0f,
      float coneRadius = 3.402823E+38f)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(entityRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &coneAngle;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &coneRotationOffset;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &coneRadius;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EntityInConeInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337323, XrefRangeEnd = 1337331, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityInConeInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EntityInConeInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static EntityInConeInstantAuthoring()
    {
      Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EntityInConeInstantAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr);
      EntityInConeInstantAuthoring.NativeFieldInfoPtr_EntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr, nameof (EntityRegister));
      EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr, nameof (ConeAngle));
      EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeRotationOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr, nameof (ConeRotationOffset));
      EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr, nameof (ConeRadius));
      EntityInConeInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr, 100664519);
      EntityInConeInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr, 100664520);
      EntityInConeInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityInConeInstantAuthoring>.NativeClassPtr, 100664521);
    }

    public EntityInConeInstantAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string EntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_EntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_EntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float ConeAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeAngle)) = value;
      }
    }

    public unsafe float ConeRotationOffset
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeRotationOffset));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeRotationOffset)) = value;
      }
    }

    public unsafe float ConeRadius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeRadius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EntityInConeInstantAuthoring.NativeFieldInfoPtr_ConeRadius)) = value;
      }
    }
  }
}
