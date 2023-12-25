// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.PatrolApproachPositionAuthoring
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
  public class PatrolApproachPositionAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_SeekedDistance;
    private static readonly IntPtr NativeFieldInfoPtr_PositionRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1338806, RefRangeEnd = 1338808, XrefRangeStart = 1338801, XrefRangeEnd = 1338806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PatrolApproachPositionAuthoring(float seekedDistance, string positionRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &seekedDistance;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(positionRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolApproachPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338808, XrefRangeEnd = 1338824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolApproachPositionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(13), CachedScanResults(RefRangeStart = 1338824, RefRangeEnd = 1338837, XrefRangeStart = 1338824, XrefRangeEnd = 1338824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PatrolApproachPositionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static PatrolApproachPositionAuthoring()
    {
      Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (PatrolApproachPositionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr);
      PatrolApproachPositionAuthoring.NativeFieldInfoPtr_SeekedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr, nameof (SeekedDistance));
      PatrolApproachPositionAuthoring.NativeFieldInfoPtr_PositionRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr, nameof (PositionRegister));
      PatrolApproachPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr, 100664818);
      PatrolApproachPositionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr, 100664819);
      PatrolApproachPositionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolApproachPositionAuthoring>.NativeClassPtr, 100664820);
    }

    public PatrolApproachPositionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float SeekedDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolApproachPositionAuthoring.NativeFieldInfoPtr_SeekedDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolApproachPositionAuthoring.NativeFieldInfoPtr_SeekedDistance)) = value;
      }
    }

    public unsafe string PositionRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PatrolApproachPositionAuthoring.NativeFieldInfoPtr_PositionRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PatrolApproachPositionAuthoring.NativeFieldInfoPtr_PositionRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
