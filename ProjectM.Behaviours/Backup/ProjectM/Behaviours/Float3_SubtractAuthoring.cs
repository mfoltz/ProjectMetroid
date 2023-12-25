// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.Float3_SubtractAuthoring
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
  public class Float3_SubtractAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_In0Register;
    private static readonly IntPtr NativeFieldInfoPtr_In1Register;
    private static readonly IntPtr NativeFieldInfoPtr_ResultRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337762, XrefRangeEnd = 1337769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Float3_SubtractAuthoring(
      string in0Register,
      string in1Register,
      string resultRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(in0Register);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(in1Register);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(resultRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Float3_SubtractAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337769, XrefRangeEnd = 1337783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Float3_SubtractAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 1337783, RefRangeEnd = 1337791, XrefRangeStart = 1337783, XrefRangeEnd = 1337783, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Float3_SubtractAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static Float3_SubtractAuthoring()
    {
      Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (Float3_SubtractAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr);
      Float3_SubtractAuthoring.NativeFieldInfoPtr_In0Register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr, nameof (In0Register));
      Float3_SubtractAuthoring.NativeFieldInfoPtr_In1Register = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr, nameof (In1Register));
      Float3_SubtractAuthoring.NativeFieldInfoPtr_ResultRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr, nameof (ResultRegister));
      Float3_SubtractAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr, 100664587);
      Float3_SubtractAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr, 100664588);
      Float3_SubtractAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Float3_SubtractAuthoring>.NativeClassPtr, 100664589);
    }

    public Float3_SubtractAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string In0Register
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Float3_SubtractAuthoring.NativeFieldInfoPtr_In0Register)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Float3_SubtractAuthoring.NativeFieldInfoPtr_In0Register), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string In1Register
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Float3_SubtractAuthoring.NativeFieldInfoPtr_In1Register)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Float3_SubtractAuthoring.NativeFieldInfoPtr_In1Register), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string ResultRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Float3_SubtractAuthoring.NativeFieldInfoPtr_ResultRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Float3_SubtractAuthoring.NativeFieldInfoPtr_ResultRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
