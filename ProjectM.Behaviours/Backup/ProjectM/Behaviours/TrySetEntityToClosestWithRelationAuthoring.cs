// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.TrySetEntityToClosestWithRelationAuthoring
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
  public class TrySetEntityToClosestWithRelationAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Relation;
    private static readonly IntPtr NativeFieldInfoPtr_RequireLineOfSight;
    private static readonly IntPtr NativeFieldInfoPtr_OutRegister;
    private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;
    private static readonly IntPtr NativeFieldInfoPtr_IncludeSelf;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnitRelation_Boolean_String_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339695, XrefRangeEnd = 1339700, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrySetEntityToClosestWithRelationAuthoring(
      UnitRelation relation,
      bool requireLineOfSight,
      string outRegister,
      float maxDistance = 3.402823E+38f,
      bool includeSelf = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &relation;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &requireLineOfSight;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &maxDistance;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = (IntPtr) &includeSelf;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrySetEntityToClosestWithRelationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_UnitRelation_Boolean_String_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339700, XrefRangeEnd = 1339708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrySetEntityToClosestWithRelationAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrySetEntityToClosestWithRelationAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static TrySetEntityToClosestWithRelationAuthoring()
    {
      Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (TrySetEntityToClosestWithRelationAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr);
      TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_Relation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, nameof (Relation));
      TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_RequireLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, nameof (RequireLineOfSight));
      TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_OutRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, nameof (OutRegister));
      TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, nameof (MaxDistance));
      TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_IncludeSelf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, nameof (IncludeSelf));
      TrySetEntityToClosestWithRelationAuthoring.NativeMethodInfoPtr__ctor_Public_Void_UnitRelation_Boolean_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, 100664980);
      TrySetEntityToClosestWithRelationAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, 100664981);
      TrySetEntityToClosestWithRelationAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetEntityToClosestWithRelationAuthoring>.NativeClassPtr, 100664982);
    }

    public TrySetEntityToClosestWithRelationAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UnitRelation Relation
    {
      get
      {
        return *(UnitRelation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_Relation));
      }
      [param: In] set
      {
        *(UnitRelation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_Relation)) = value;
      }
    }

    public unsafe bool RequireLineOfSight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_RequireLineOfSight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_RequireLineOfSight)) = value;
      }
    }

    public unsafe string OutRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_OutRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_OutRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe float MaxDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_MaxDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_MaxDistance)) = value;
      }
    }

    public unsafe bool IncludeSelf
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_IncludeSelf));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetEntityToClosestWithRelationAuthoring.NativeFieldInfoPtr_IncludeSelf)) = value;
      }
    }
  }
}
