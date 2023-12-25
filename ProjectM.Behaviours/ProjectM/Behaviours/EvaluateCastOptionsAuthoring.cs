// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.EvaluateCastOptionsAuthoring
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
  public class EvaluateCastOptionsAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_CastOptionsPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_OutTargetEntityRegister;
    private static readonly IntPtr NativeFieldInfoPtr_OutAbilityIndexRegister;
    private static readonly IntPtr NativeFieldInfoPtr_OutInterruptOnTargetDeathRegister;
    private static readonly IntPtr NativeFieldInfoPtr_OutCooldownRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PrefabGUID_String_String_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1337501, RefRangeEnd = 1337502, XrefRangeStart = 1337493, XrefRangeEnd = 1337501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EvaluateCastOptionsAuthoring(
      PrefabGUID castOptionsPrefab,
      string outTargetEntityRegister,
      string outAbilityIndexRegister,
      string outInterruptOnTargetDeathRegister,
      string outCooldownRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &castOptionsPrefab;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outTargetEntityRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outAbilityIndexRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outInterruptOnTargetDeathRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(outCooldownRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EvaluateCastOptionsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_PrefabGUID_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337502, XrefRangeEnd = 1337533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EvaluateCastOptionsAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EvaluateCastOptionsAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static EvaluateCastOptionsAuthoring()
    {
      Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (EvaluateCastOptionsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr);
      EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_CastOptionsPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, nameof (CastOptionsPrefab));
      EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutTargetEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, nameof (OutTargetEntityRegister));
      EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutAbilityIndexRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, nameof (OutAbilityIndexRegister));
      EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutInterruptOnTargetDeathRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, nameof (OutInterruptOnTargetDeathRegister));
      EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutCooldownRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, nameof (OutCooldownRegister));
      EvaluateCastOptionsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_PrefabGUID_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, 100664551);
      EvaluateCastOptionsAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, 100664552);
      EvaluateCastOptionsAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EvaluateCastOptionsAuthoring>.NativeClassPtr, 100664553);
    }

    public EvaluateCastOptionsAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabGUID CastOptionsPrefab
    {
      get
      {
        return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_CastOptionsPrefab));
      }
      [param: In] set
      {
        *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_CastOptionsPrefab)) = value;
      }
    }

    public unsafe string OutTargetEntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutTargetEntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutTargetEntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OutAbilityIndexRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutAbilityIndexRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutAbilityIndexRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OutInterruptOnTargetDeathRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutInterruptOnTargetDeathRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutInterruptOnTargetDeathRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string OutCooldownRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutCooldownRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EvaluateCastOptionsAuthoring.NativeFieldInfoPtr_OutCooldownRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
