// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.DelayUntilDamageTakenConstantAuthoring
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
  public class DelayUntilDamageTakenConstantAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_HealthLossThreshold;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337246, XrefRangeEnd = 1337250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DelayUntilDamageTakenConstantAuthoring(float healthLossThreshold)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelayUntilDamageTakenConstantAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &healthLossThreshold;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DelayUntilDamageTakenConstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337250, XrefRangeEnd = 1337262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DelayUntilDamageTakenConstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(20), CachedScanResults(RefRangeStart = 1337262, RefRangeEnd = 1337282, XrefRangeStart = 1337262, XrefRangeEnd = 1337262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DelayUntilDamageTakenConstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static DelayUntilDamageTakenConstantAuthoring()
    {
      Il2CppClassPointerStore<DelayUntilDamageTakenConstantAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (DelayUntilDamageTakenConstantAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelayUntilDamageTakenConstantAuthoring>.NativeClassPtr);
      DelayUntilDamageTakenConstantAuthoring.NativeFieldInfoPtr_HealthLossThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelayUntilDamageTakenConstantAuthoring>.NativeClassPtr, nameof (HealthLossThreshold));
      DelayUntilDamageTakenConstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayUntilDamageTakenConstantAuthoring>.NativeClassPtr, 100664509);
      DelayUntilDamageTakenConstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayUntilDamageTakenConstantAuthoring>.NativeClassPtr, 100664510);
      DelayUntilDamageTakenConstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelayUntilDamageTakenConstantAuthoring>.NativeClassPtr, 100664511);
    }

    public DelayUntilDamageTakenConstantAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float HealthLossThreshold
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DelayUntilDamageTakenConstantAuthoring.NativeFieldInfoPtr_HealthLossThreshold));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DelayUntilDamageTakenConstantAuthoring.NativeFieldInfoPtr_HealthLossThreshold)) = value;
      }
    }
  }
}
