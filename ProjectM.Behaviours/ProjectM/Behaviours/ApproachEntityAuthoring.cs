// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.ApproachEntityAuthoring
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
  public class ApproachEntityAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetMinDistance;
    private static readonly IntPtr NativeFieldInfoPtr_TargetMaxDistance;
    private static readonly IntPtr NativeFieldInfoPtr_EntityRegister;
    private static readonly IntPtr NativeFieldInfoPtr_TargetGoalDistance;
    private static readonly IntPtr NativeFieldInfoPtr_SucceedOnTargetReached;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1336887, RefRangeEnd = 1336888, XrefRangeStart = 1336882, XrefRangeEnd = 1336887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ApproachEntityAuthoring(
      float targetMinDistance,
      float targetMaxDistance,
      string entityRegister,
      float targetGoalDistance = 0.0f,
      bool succeedOnTargetReached = true)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &targetMinDistance;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &targetMaxDistance;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(entityRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &targetGoalDistance;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &succeedOnTargetReached;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ApproachEntityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336888, XrefRangeEnd = 1336896, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ApproachEntityAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ApproachEntityAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ApproachEntityAuthoring()
    {
      Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (ApproachEntityAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr);
      ApproachEntityAuthoring.NativeFieldInfoPtr_TargetMinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, nameof (TargetMinDistance));
      ApproachEntityAuthoring.NativeFieldInfoPtr_TargetMaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, nameof (TargetMaxDistance));
      ApproachEntityAuthoring.NativeFieldInfoPtr_EntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, nameof (EntityRegister));
      ApproachEntityAuthoring.NativeFieldInfoPtr_TargetGoalDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, nameof (TargetGoalDistance));
      ApproachEntityAuthoring.NativeFieldInfoPtr_SucceedOnTargetReached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, nameof (SucceedOnTargetReached));
      ApproachEntityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, 100664455);
      ApproachEntityAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, 100664456);
      ApproachEntityAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApproachEntityAuthoring>.NativeClassPtr, 100664457);
    }

    public ApproachEntityAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float TargetMinDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_TargetMinDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_TargetMinDistance)) = value;
      }
    }

    public unsafe float TargetMaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_TargetMaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_TargetMaxDistance)) = value;
      }
    }

    public unsafe string EntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_EntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_EntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float TargetGoalDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_TargetGoalDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_TargetGoalDistance)) = value;
      }
    }

    public unsafe bool SucceedOnTargetReached
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_SucceedOnTargetReached));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ApproachEntityAuthoring.NativeFieldInfoPtr_SucceedOnTargetReached)) = value;
      }
    }
  }
}
