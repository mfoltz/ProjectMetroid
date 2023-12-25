// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.IsBlackboardEntityNullMonitorAuthoring
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
  public class IsBlackboardEntityNullMonitorAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_InRegister;
    private static readonly IntPtr NativeFieldInfoPtr_Invert;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1338475, RefRangeEnd = 1338478, XrefRangeStart = 1338470, XrefRangeEnd = 1338475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IsBlackboardEntityNullMonitorAuthoring(string inRegister, bool invert = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(inRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &invert;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IsBlackboardEntityNullMonitorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338478, XrefRangeEnd = 1338487, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IsBlackboardEntityNullMonitorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(16), CachedScanResults(RefRangeStart = 76041, RefRangeEnd = 76057, XrefRangeStart = 76041, XrefRangeEnd = 76057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IsBlackboardEntityNullMonitorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static IsBlackboardEntityNullMonitorAuthoring()
    {
      Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (IsBlackboardEntityNullMonitorAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr);
      IsBlackboardEntityNullMonitorAuthoring.NativeFieldInfoPtr_InRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr, nameof (InRegister));
      IsBlackboardEntityNullMonitorAuthoring.NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr, nameof (Invert));
      IsBlackboardEntityNullMonitorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr, 100664730);
      IsBlackboardEntityNullMonitorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr, 100664731);
      IsBlackboardEntityNullMonitorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IsBlackboardEntityNullMonitorAuthoring>.NativeClassPtr, 100664732);
    }

    public IsBlackboardEntityNullMonitorAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string InRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IsBlackboardEntityNullMonitorAuthoring.NativeFieldInfoPtr_InRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(IsBlackboardEntityNullMonitorAuthoring.NativeFieldInfoPtr_InRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool Invert
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IsBlackboardEntityNullMonitorAuthoring.NativeFieldInfoPtr_Invert));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IsBlackboardEntityNullMonitorAuthoring.NativeFieldInfoPtr_Invert)) = value;
      }
    }
  }
}
