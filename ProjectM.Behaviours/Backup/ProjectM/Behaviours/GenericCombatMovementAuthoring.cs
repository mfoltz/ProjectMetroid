// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.GenericCombatMovementAuthoring
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
  public class GenericCombatMovementAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_CombatAreaRelocateDistance;
    private static readonly IntPtr NativeFieldInfoPtr_CollisionChangeDirectionCooldown;
    private static readonly IntPtr NativeFieldInfoPtr_EntityRegister;
    private static readonly IntPtr NativeFieldInfoPtr_ExitReasonRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1337994, RefRangeEnd = 1337995, XrefRangeStart = 1337988, XrefRangeEnd = 1337994, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GenericCombatMovementAuthoring(
      float combatAreaRelocateDistance,
      float collisionChangeDirectionCooldown,
      string entityRegister,
      string exitReasonRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &combatAreaRelocateDistance;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &collisionChangeDirectionCooldown;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(entityRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(exitReasonRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GenericCombatMovementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337995, XrefRangeEnd = 1338022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GenericCombatMovementAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GenericCombatMovementAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static GenericCombatMovementAuthoring()
    {
      Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (GenericCombatMovementAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr);
      GenericCombatMovementAuthoring.NativeFieldInfoPtr_CombatAreaRelocateDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr, nameof (CombatAreaRelocateDistance));
      GenericCombatMovementAuthoring.NativeFieldInfoPtr_CollisionChangeDirectionCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr, nameof (CollisionChangeDirectionCooldown));
      GenericCombatMovementAuthoring.NativeFieldInfoPtr_EntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr, nameof (EntityRegister));
      GenericCombatMovementAuthoring.NativeFieldInfoPtr_ExitReasonRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr, nameof (ExitReasonRegister));
      GenericCombatMovementAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr, 100664621);
      GenericCombatMovementAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr, 100664622);
      GenericCombatMovementAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericCombatMovementAuthoring>.NativeClassPtr, 100664623);
    }

    public GenericCombatMovementAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float CombatAreaRelocateDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_CombatAreaRelocateDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_CombatAreaRelocateDistance)) = value;
      }
    }

    public unsafe float CollisionChangeDirectionCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_CollisionChangeDirectionCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_CollisionChangeDirectionCooldown)) = value;
      }
    }

    public unsafe string EntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_EntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_EntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ExitReasonRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_ExitReasonRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GenericCombatMovementAuthoring.NativeFieldInfoPtr_ExitReasonRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
