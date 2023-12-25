// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.TimePassedSinceBlackboardInstantAuthoring
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
  public class TimePassedSinceBlackboardInstantAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_TimeInSecondsRegister;
    private static readonly IntPtr NativeFieldInfoPtr_TimeStampRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1339476, RefRangeEnd = 1339478, XrefRangeStart = 1339470, XrefRangeEnd = 1339476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TimePassedSinceBlackboardInstantAuthoring(
      string timeInSecondsRegister,
      string timeStampRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(timeInSecondsRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(timeStampRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TimePassedSinceBlackboardInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339478, XrefRangeEnd = 1339490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TimePassedSinceBlackboardInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TimePassedSinceBlackboardInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static TimePassedSinceBlackboardInstantAuthoring()
    {
      Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (TimePassedSinceBlackboardInstantAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr);
      TimePassedSinceBlackboardInstantAuthoring.NativeFieldInfoPtr_TimeInSecondsRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr, nameof (TimeInSecondsRegister));
      TimePassedSinceBlackboardInstantAuthoring.NativeFieldInfoPtr_TimeStampRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr, nameof (TimeStampRegister));
      TimePassedSinceBlackboardInstantAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr, 100664947);
      TimePassedSinceBlackboardInstantAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr, 100664948);
      TimePassedSinceBlackboardInstantAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimePassedSinceBlackboardInstantAuthoring>.NativeClassPtr, 100664949);
    }

    public TimePassedSinceBlackboardInstantAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string TimeInSecondsRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimePassedSinceBlackboardInstantAuthoring.NativeFieldInfoPtr_TimeInSecondsRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimePassedSinceBlackboardInstantAuthoring.NativeFieldInfoPtr_TimeInSecondsRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string TimeStampRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TimePassedSinceBlackboardInstantAuthoring.NativeFieldInfoPtr_TimeStampRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TimePassedSinceBlackboardInstantAuthoring.NativeFieldInfoPtr_TimeStampRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
