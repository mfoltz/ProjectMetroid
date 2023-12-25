// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.FindPathToPositionAuthoring
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
  public class FindPathToPositionAuthoring : BehaviourTreeNodeAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_TargetPosRegister;
    private static readonly IntPtr NativeFieldInfoPtr_PathRequestEntityRegister;
    private static readonly IntPtr NativeFieldInfoPtr_MaxExpansionsOverride;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0;

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 1337622, RefRangeEnd = 1337638, XrefRangeStart = 1337616, XrefRangeEnd = 1337622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FindPathToPositionAuthoring(
      string targetPosRegister,
      string pathRequestEntityRegister,
      int maxExpansionsOverride = -1)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(targetPosRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(pathRequestEntityRegister);
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &maxExpansionsOverride;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FindPathToPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1337638, XrefRangeEnd = 1337651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe Il2CppStructArray<byte> Serialize(BlackboardBuilder blackboardBuilder)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blackboardBuilder);
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FindPathToPositionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FindPathToPositionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BehaviourTreeNodeType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static FindPathToPositionAuthoring()
    {
      Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (FindPathToPositionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr);
      FindPathToPositionAuthoring.NativeFieldInfoPtr_TargetPosRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr, nameof (TargetPosRegister));
      FindPathToPositionAuthoring.NativeFieldInfoPtr_PathRequestEntityRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr, nameof (PathRequestEntityRegister));
      FindPathToPositionAuthoring.NativeFieldInfoPtr_MaxExpansionsOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr, nameof (MaxExpansionsOverride));
      FindPathToPositionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr, 100664566);
      FindPathToPositionAuthoring.NativeMethodInfoPtr_Serialize_Public_Virtual_Il2CppStructArray_1_Byte_BlackboardBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr, 100664567);
      FindPathToPositionAuthoring.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_BehaviourTreeNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FindPathToPositionAuthoring>.NativeClassPtr, 100664568);
    }

    public FindPathToPositionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string TargetPosRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FindPathToPositionAuthoring.NativeFieldInfoPtr_TargetPosRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FindPathToPositionAuthoring.NativeFieldInfoPtr_TargetPosRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string PathRequestEntityRegister
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FindPathToPositionAuthoring.NativeFieldInfoPtr_PathRequestEntityRegister)));
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FindPathToPositionAuthoring.NativeFieldInfoPtr_PathRequestEntityRegister), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int MaxExpansionsOverride
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FindPathToPositionAuthoring.NativeFieldInfoPtr_MaxExpansionsOverride));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FindPathToPositionAuthoring.NativeFieldInfoPtr_MaxExpansionsOverride)) = value;
      }
    }
  }
}
