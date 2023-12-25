// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.SetMoveSpeedAuthoring
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
  public class SetMoveSpeedAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Speed;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AiMoveSpeed_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1339267, RefRangeEnd = 1339275, XrefRangeStart = 1339263, XrefRangeEnd = 1339267, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetMoveSpeedAuthoring(AiMoveSpeed speed)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetMoveSpeedAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &speed;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetMoveSpeedAuthoring.NativeMethodInfoPtr__ctor_Public_Void_AiMoveSpeed_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339275, XrefRangeEnd = 1339278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetMoveSpeedAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetMoveSpeedAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static SetMoveSpeedAuthoring()
    {
      Il2CppClassPointerStore<SetMoveSpeedAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (SetMoveSpeedAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetMoveSpeedAuthoring>.NativeClassPtr);
      SetMoveSpeedAuthoring.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetMoveSpeedAuthoring>.NativeClassPtr, nameof (Speed));
      SetMoveSpeedAuthoring.NativeMethodInfoPtr__ctor_Public_Void_AiMoveSpeed_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMoveSpeedAuthoring>.NativeClassPtr, 100664906);
      SetMoveSpeedAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMoveSpeedAuthoring>.NativeClassPtr, 100664907);
      SetMoveSpeedAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetMoveSpeedAuthoring>.NativeClassPtr, 100664908);
    }

    public SetMoveSpeedAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AiMoveSpeed Speed
    {
      get
      {
        return *(AiMoveSpeed*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMoveSpeedAuthoring.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(AiMoveSpeed*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetMoveSpeedAuthoring.NativeFieldInfoPtr_Speed)) = value;
      }
    }
  }
}
