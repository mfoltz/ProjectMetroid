// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Relocate_ShouldEarlyOutAuthoring
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
  public class Relocate_ShouldEarlyOutAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_MaxAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MinTime;
    private static readonly IntPtr NativeFieldInfoPtr_TargetEntityRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1339197, RefRangeEnd = 1339198, XrefRangeStart = 1339192, XrefRangeEnd = 1339197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Relocate_ShouldEarlyOutAuthoring(
      float maxAngle,
      float minTime,
      string targetEntityRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &maxAngle;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &minTime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(targetEntityRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Relocate_ShouldEarlyOutAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339198, XrefRangeEnd = 1339214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Relocate_ShouldEarlyOutAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Relocate_ShouldEarlyOutAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static Relocate_ShouldEarlyOutAuthoring()
    {
      Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (Relocate_ShouldEarlyOutAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr);
      Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_MaxAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr, nameof (MaxAngle));
      Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_MinTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr, nameof (MinTime));
      Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_TargetEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr, nameof (TargetEntityRegister));
      Relocate_ShouldEarlyOutAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr, 100664894);
      Relocate_ShouldEarlyOutAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr, 100664895);
      Relocate_ShouldEarlyOutAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Relocate_ShouldEarlyOutAuthoring>.NativeClassPtr, 100664896);
    }

    public Relocate_ShouldEarlyOutAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MaxAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_MaxAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_MaxAngle)) = value;
      }
    }

    public unsafe float MinTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_MinTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_MinTime)) = value;
      }
    }

    public unsafe string TargetEntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_TargetEntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Relocate_ShouldEarlyOutAuthoring.NativeFieldInfoPtr_TargetEntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
