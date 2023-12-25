// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.ShouldCombatAreaRelocateInstantAuthoring
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
  public class ShouldCombatAreaRelocateInstantAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_CombatAreaRelocateDistance;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1339318, RefRangeEnd = 1339320, XrefRangeStart = 1339314, XrefRangeEnd = 1339318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShouldCombatAreaRelocateInstantAuthoring(float combatAreaRelocateDistance)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShouldCombatAreaRelocateInstantAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &combatAreaRelocateDistance;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShouldCombatAreaRelocateInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339320, XrefRangeEnd = 1339323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShouldCombatAreaRelocateInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShouldCombatAreaRelocateInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ShouldCombatAreaRelocateInstantAuthoring()
    {
      Il2CppClassPointerStore<ShouldCombatAreaRelocateInstantAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (ShouldCombatAreaRelocateInstantAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShouldCombatAreaRelocateInstantAuthoring>.NativeClassPtr);
      ShouldCombatAreaRelocateInstantAuthoring.NativeFieldInfoPtr_CombatAreaRelocateDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShouldCombatAreaRelocateInstantAuthoring>.NativeClassPtr, nameof (CombatAreaRelocateDistance));
      ShouldCombatAreaRelocateInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShouldCombatAreaRelocateInstantAuthoring>.NativeClassPtr, 100664916);
      ShouldCombatAreaRelocateInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShouldCombatAreaRelocateInstantAuthoring>.NativeClassPtr, 100664917);
      ShouldCombatAreaRelocateInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShouldCombatAreaRelocateInstantAuthoring>.NativeClassPtr, 100664918);
    }

    public ShouldCombatAreaRelocateInstantAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float CombatAreaRelocateDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShouldCombatAreaRelocateInstantAuthoring.NativeFieldInfoPtr_CombatAreaRelocateDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShouldCombatAreaRelocateInstantAuthoring.NativeFieldInfoPtr_CombatAreaRelocateDistance)) = value;
      }
    }
  }
}
