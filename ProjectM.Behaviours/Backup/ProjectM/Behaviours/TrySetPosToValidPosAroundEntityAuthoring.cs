// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.TrySetPosToValidPosAroundEntityAuthoring
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
  public class TrySetPosToValidPosAroundEntityAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Range;
    private static readonly IntPtr NativeFieldInfoPtr_EntityRegister;
    private static readonly IntPtr NativeFieldInfoPtr_PosRegister;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_String_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1339792, RefRangeEnd = 1339794, XrefRangeStart = 1339786, XrefRangeEnd = 1339792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrySetPosToValidPosAroundEntityAuthoring(
      float range,
      string entityRegister,
      string posRegister)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &range;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(entityRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(posRegister);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrySetPosToValidPosAroundEntityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1339794, XrefRangeEnd = 1339807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrySetPosToValidPosAroundEntityAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrySetPosToValidPosAroundEntityAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static TrySetPosToValidPosAroundEntityAuthoring()
    {
      Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (TrySetPosToValidPosAroundEntityAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr);
      TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr, nameof (Range));
      TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_EntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr, nameof (EntityRegister));
      TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_PosRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr, nameof (PosRegister));
      TrySetPosToValidPosAroundEntityAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Single_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr, 100664998);
      TrySetPosToValidPosAroundEntityAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr, 100664999);
      TrySetPosToValidPosAroundEntityAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrySetPosToValidPosAroundEntityAuthoring>.NativeClassPtr, 100665000);
    }

    public TrySetPosToValidPosAroundEntityAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe string EntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_EntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_EntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string PosRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_PosRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrySetPosToValidPosAroundEntityAuthoring.NativeFieldInfoPtr_PosRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
