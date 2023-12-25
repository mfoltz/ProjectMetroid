// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.AttackEntityCastOptionAuthoring
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
  public class AttackEntityCastOptionAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_ForceAimInMoveDirection;
    private static readonly IntPtr NativeFieldInfoPtr_AbilityIndexRegister;
    private static readonly IntPtr NativeFieldInfoPtr_EntityRegister;
    private static readonly IntPtr NativeFieldInfoPtr_CooldownRegister;
    private static readonly IntPtr NativeFieldInfoPtr_InterruptCastOnTargetDeath;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336909, XrefRangeEnd = 1336917, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AttackEntityCastOptionAuthoring(
      bool forceAimInMoveDirection,
      string abilityIndexRegister,
      string entityRegister,
      string cooldownRegister,
      string interruptCastOnTargetDeath = null)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &forceAimInMoveDirection;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(abilityIndexRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(entityRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(cooldownRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(interruptCastOnTargetDeath);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttackEntityCastOptionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1336917, XrefRangeEnd = 1336979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AttackEntityCastOptionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AttackEntityCastOptionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static AttackEntityCastOptionAuthoring()
    {
      Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (AttackEntityCastOptionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr);
      AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_ForceAimInMoveDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, nameof (ForceAimInMoveDirection));
      AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_AbilityIndexRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, nameof (AbilityIndexRegister));
      AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_EntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, nameof (EntityRegister));
      AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_CooldownRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, nameof (CooldownRegister));
      AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_InterruptCastOnTargetDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, nameof (InterruptCastOnTargetDeath));
      AttackEntityCastOptionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, 100664461);
      AttackEntityCastOptionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, 100664462);
      AttackEntityCastOptionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackEntityCastOptionAuthoring>.NativeClassPtr, 100664463);
    }

    public AttackEntityCastOptionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool ForceAimInMoveDirection
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_ForceAimInMoveDirection));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_ForceAimInMoveDirection)) = value;
      }
    }

    public unsafe string AbilityIndexRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_AbilityIndexRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_AbilityIndexRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string EntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_EntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_EntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string CooldownRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_CooldownRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_CooldownRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string InterruptCastOnTargetDeath
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_InterruptCastOnTargetDeath)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AttackEntityCastOptionAuthoring.NativeFieldInfoPtr_InterruptCastOnTargetDeath), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
