// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.PositionInPathfindingLineOfSightMonitorAuthoring
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
  public class PositionInPathfindingLineOfSightMonitorAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_IgnoreSize;
    private static readonly IntPtr NativeFieldInfoPtr_PositionRegister;
    private static readonly IntPtr NativeFieldInfoPtr_Invert;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1338911, RefRangeEnd = 1338916, XrefRangeStart = 1338906, XrefRangeEnd = 1338911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PositionInPathfindingLineOfSightMonitorAuthoring(
      bool ignoreSize,
      string positionRegister,
      bool invert = false)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &ignoreSize;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(positionRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &invert;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PositionInPathfindingLineOfSightMonitorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338916, XrefRangeEnd = 1338924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PositionInPathfindingLineOfSightMonitorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      IntPtr nativeObject = num;
      return nativeObject == IntPtr.Zero ? (Il2CppStructArray<byte>) null : new Il2CppStructArray<byte>(nativeObject);
    }

    public override unsafe BehaviourTreeNodeType NodeType
    {
      [CallerCount(11), CachedScanResults(RefRangeStart = 75010, RefRangeEnd = 75021, XrefRangeStart = 75010, XrefRangeEnd = 75021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PositionInPathfindingLineOfSightMonitorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static PositionInPathfindingLineOfSightMonitorAuthoring()
    {
      Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (PositionInPathfindingLineOfSightMonitorAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr);
      PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_IgnoreSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr, nameof (IgnoreSize));
      PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_PositionRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr, nameof (PositionRegister));
      PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_Invert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr, nameof (Invert));
      PositionInPathfindingLineOfSightMonitorAuthoring.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr, 100664837);
      PositionInPathfindingLineOfSightMonitorAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr, 100664838);
      PositionInPathfindingLineOfSightMonitorAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInPathfindingLineOfSightMonitorAuthoring>.NativeClassPtr, 100664839);
    }

    public PositionInPathfindingLineOfSightMonitorAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IgnoreSize
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_IgnoreSize));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_IgnoreSize)) = value;
      }
    }

    public unsafe string PositionRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_PositionRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_PositionRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool Invert
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_Invert));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PositionInPathfindingLineOfSightMonitorAuthoring.NativeFieldInfoPtr_Invert)) = value;
      }
    }
  }
}
